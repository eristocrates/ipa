namespace https.w3id.org.idsa.code.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module idsc =
    let _namespace_iri = Namespace_Iri idsc |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:idsa/code/AA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Afar"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/AA">https://w3id.org/idsa/code/AA</seealso>
    let AA = Prefixed_Name(idsc, "AA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/AB</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Abkhaz"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/AB">https://w3id.org/idsa/code/AB</seealso>
    let AB = Prefixed_Name(idsc, "AB") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/ABSOLUTE_SPATIAL_POSITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/LeftOperand</para>
    ///   <para>"The current geospatial position of the *consuming connector*. In case the connector only appears as a virtual entity, the physical location of the hosting server is referenced. Allowed operators are idsc:in. No other spatial operators (close to, north of, etc.) are currently allowed."</para>
    /// labels<para>"Absolute geo-spatial position"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/ABSOLUTE_SPATIAL_POSITION">https://w3id.org/idsa/code/ABSOLUTE_SPATIAL_POSITION</seealso>
    let ABSOLUTE_SPATIAL_POSITION =
        Prefixed_Name(idsc, "ABSOLUTE_SPATIAL_POSITION") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/ACTIVE_ONLY</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/QueryScope</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ACTIVE_ONLY"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/ACTIVE_ONLY">https://w3id.org/idsa/code/ACTIVE_ONLY</seealso>
    let ACTIVE_ONLY = Prefixed_Name(idsc, "ACTIVE_ONLY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/AE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Avestan"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/AE">https://w3id.org/idsa/code/AE</seealso>
    let AE = Prefixed_Name(idsc, "AE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/AF</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Afrikaans"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/AF">https://w3id.org/idsa/code/AF</seealso>
    let AF = Prefixed_Name(idsc, "AF") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/AFTER</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"If a temporal entity T1 is after another temporal entity T2, then the beginning of T1 is after the end of T2 and the beginning of T1 is different to the ending of T2. Temporal entities can either be a xsd:dateTimeStamp or an ids:TemporalEntity."</para>
    /// labels<para>"after"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/AFTER">https://w3id.org/idsa/code/AFTER</seealso>
    let AFTER = Prefixed_Name(idsc, "AFTER") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/AGGREGATE_BY_CONSUMER</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Action</para>
    ///   <para>"Data will be part of another piece of data so that it is not distinguishable anymore."</para>
    /// labels<para>"aggregate by consumer"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/AGGREGATE_BY_CONSUMER">https://w3id.org/idsa/code/AGGREGATE_BY_CONSUMER</seealso>
    let AGGREGATE_BY_CONSUMER =
        Prefixed_Name(idsc, "AGGREGATE_BY_CONSUMER") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/AGGREGATE_BY_PROVIDER</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Action</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Data will be part of another piece of data so that it is not distinguishable anymore."</para>
    /// labels<para>"aggregate by provider"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/AGGREGATE_BY_PROVIDER">https://w3id.org/idsa/code/AGGREGATE_BY_PROVIDER</seealso>
    let AGGREGATE_BY_PROVIDER =
        Prefixed_Name(idsc, "AGGREGATE_BY_PROVIDER") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/AK</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Akan"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/AK">https://w3id.org/idsa/code/AK</seealso>
    let AK = Prefixed_Name(idsc, "AK") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/ALL</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/QueryScope</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ALL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/ALL">https://w3id.org/idsa/code/ALL</seealso>
    let ALL = Prefixed_Name(idsc, "ALL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/AM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Amharic"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/AM">https://w3id.org/idsa/code/AM</seealso>
    let AM = Prefixed_Name(idsc, "AM") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/AN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Aragonese"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/AN">https://w3id.org/idsa/code/AN</seealso>
    let AN = Prefixed_Name(idsc, "AN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/ANNUAL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Frequency</para>
    ///   <para>skos:Concept</para>
    ///   <para>"The event occurs once a year."</para>
    /// labels<para>"Annual"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/ANNUAL">https://w3id.org/idsa/code/ANNUAL</seealso>
    let ANNUAL = Prefixed_Name(idsc, "ANNUAL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/ANONYMIZE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Action</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"To anonymize all, parts or certain attributes of the resource."</para>
    /// labels<para>"anonymize"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/ANONYMIZE">https://w3id.org/idsa/code/ANONYMIZE</seealso>
    let ANONYMIZE = Prefixed_Name(idsc, "ANONYMIZE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/ANONYMIZED</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/ArtifactState</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The artifact is anonymized so the data source can not be recognized by any further user."</para>
    /// labels<para>"is anonymized"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/ANONYMIZED">https://w3id.org/idsa/code/ANONYMIZED</seealso>
    let ANONYMIZED = Prefixed_Name(idsc, "ANONYMIZED") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/ANY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/QueryTarget</para>
    ///
    /// labels<para>"ANY"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/ANY">https://w3id.org/idsa/code/ANY</seealso>
    let ANY = Prefixed_Name(idsc, "ANY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/APPSTORE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/QueryTarget</para>
    ///
    /// labels<para>"APPSTORE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/APPSTORE">https://w3id.org/idsa/code/APPSTORE</seealso>
    let APPSTORE = Prefixed_Name(idsc, "APPSTORE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/APP_RESOURCES_LOCAL_ENFORCEMENT</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/AppExecutionResources</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"App Resources Local Enforcement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/APP_RESOURCES_LOCAL_ENFORCEMENT">https://w3id.org/idsa/code/APP_RESOURCES_LOCAL_ENFORCEMENT</seealso>
    let APP_RESOURCES_LOCAL_ENFORCEMENT =
        Prefixed_Name(idsc, "APP_RESOURCES_LOCAL_ENFORCEMENT") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/APP_RESOURCES_NONE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/AppExecutionResources</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"App Resources None"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/APP_RESOURCES_NONE">https://w3id.org/idsa/code/APP_RESOURCES_NONE</seealso>
    let APP_RESOURCES_NONE = Prefixed_Name(idsc, "APP_RESOURCES_NONE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/APP_RESOURCES_REMOTE_VERIFICATION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/AppExecutionResources</para>
    ///
    /// labels<para>"App Resources Remote Verification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/APP_RESOURCES_REMOTE_VERIFICATION">https://w3id.org/idsa/code/APP_RESOURCES_REMOTE_VERIFICATION</seealso>
    let APP_RESOURCES_REMOTE_VERIFICATION =
        Prefixed_Name(idsc, "APP_RESOURCES_REMOTE_VERIFICATION") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/AR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Arabic"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/AR">https://w3id.org/idsa/code/AR</seealso>
    let AR = Prefixed_Name(idsc, "AR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/AS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Assamese"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/AS">https://w3id.org/idsa/code/AS</seealso>
    let AS = Prefixed_Name(idsc, "AS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/AUDIT_LOCAL_LOGGING</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/AuditGuarantee</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Audit Local Logging"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/AUDIT_LOCAL_LOGGING">https://w3id.org/idsa/code/AUDIT_LOCAL_LOGGING</seealso>
    let AUDIT_LOCAL_LOGGING = Prefixed_Name(idsc, "AUDIT_LOCAL_LOGGING") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/AUDIT_NONE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/AuditGuarantee</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Audit None"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/AUDIT_NONE">https://w3id.org/idsa/code/AUDIT_NONE</seealso>
    let AUDIT_NONE = Prefixed_Name(idsc, "AUDIT_NONE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/AUDIT_REMOTE_TRACING</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/AuditGuarantee</para>
    ///
    /// labels<para>"Audit Remote Tracing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/AUDIT_REMOTE_TRACING">https://w3id.org/idsa/code/AUDIT_REMOTE_TRACING</seealso>
    let AUDIT_REMOTE_TRACING =
        Prefixed_Name(idsc, "AUDIT_REMOTE_TRACING") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/AUTHENTICATION_MUTUAL</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/AuthenticationGuarantee</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Authentication Mutual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/AUTHENTICATION_MUTUAL">https://w3id.org/idsa/code/AUTHENTICATION_MUTUAL</seealso>
    let AUTHENTICATION_MUTUAL =
        Prefixed_Name(idsc, "AUTHENTICATION_MUTUAL") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/AUTHENTICATION_NONE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/AuthenticationGuarantee</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Authentication None"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/AUTHENTICATION_NONE">https://w3id.org/idsa/code/AUTHENTICATION_NONE</seealso>
    let AUTHENTICATION_NONE = Prefixed_Name(idsc, "AUTHENTICATION_NONE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/AUTHENTICATION_SERVER_SIDE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/AuthenticationGuarantee</para>
    ///
    /// labels<para>"Authentication Serverside"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/AUTHENTICATION_SERVER_SIDE">https://w3id.org/idsa/code/AUTHENTICATION_SERVER_SIDE</seealso>
    let AUTHENTICATION_SERVER_SIDE =
        Prefixed_Name(idsc, "AUTHENTICATION_SERVER_SIDE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/AV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Avaric"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/AV">https://w3id.org/idsa/code/AV</seealso>
    let AV = Prefixed_Name(idsc, "AV") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/AY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Aymara"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/AY">https://w3id.org/idsa/code/AY</seealso>
    let AY = Prefixed_Name(idsc, "AY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/AZ</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Azerbaijani"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/AZ">https://w3id.org/idsa/code/AZ</seealso>
    let AZ = Prefixed_Name(idsc, "AZ") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/BA</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bashkir"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/BA">https://w3id.org/idsa/code/BA</seealso>
    let BA = Prefixed_Name(idsc, "BA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/BAD_PARAMETERS</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/RejectionReason</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"At least one query or operation parameter is not acceptable for the sender of this rejection message."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"BAD_PARAMETERS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/BAD_PARAMETERS">https://w3id.org/idsa/code/BAD_PARAMETERS</seealso>
    let BAD_PARAMETERS = Prefixed_Name(idsc, "BAD_PARAMETERS") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/BASE_SECURITY_PROFILE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/SecurityProfile</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Default security profile of a certified IDS Connector."</para>
    /// labels<para>"Base security profile"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/BASE_SECURITY_PROFILE">https://w3id.org/idsa/code/BASE_SECURITY_PROFILE</seealso>
    let BASE_SECURITY_PROFILE =
        Prefixed_Name(idsc, "BASE_SECURITY_PROFILE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/BE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Belarusian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/BE">https://w3id.org/idsa/code/BE</seealso>
    let BE = Prefixed_Name(idsc, "BE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/BEFORE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"If a temporal entity T1 is before another temporal entity T2, then the ending of T1 is before the end of T2 and the ending of T1 is different to the beginning of T2. Temporal entities can either be a xsd:dateTimeStamp or an ids:TemporalEntity."</para>
    /// labels<para>"before"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/BEFORE">https://w3id.org/idsa/code/BEFORE</seealso>
    let BEFORE = Prefixed_Name(idsc, "BEFORE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/BG</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Bulgarian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/BG">https://w3id.org/idsa/code/BG</seealso>
    let BG = Prefixed_Name(idsc, "BG") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/BH</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bihari"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/BH">https://w3id.org/idsa/code/BH</seealso>
    let BH = Prefixed_Name(idsc, "BH") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/BI</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bislama"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/BI">https://w3id.org/idsa/code/BI</seealso>
    let BI = Prefixed_Name(idsc, "BI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/BIENNIAL</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Frequency</para>
    ///   <para>"The event occurs every two years."</para>
    /// labels<para>"Biennial"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/BIENNIAL">https://w3id.org/idsa/code/BIENNIAL</seealso>
    let BIENNIAL = Prefixed_Name(idsc, "BIENNIAL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/BIMONTHLY</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Frequency</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The event occurs every two months."</para>
    /// labels<para>"Bimonthly"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/BIMONTHLY">https://w3id.org/idsa/code/BIMONTHLY</seealso>
    let BIMONTHLY = Prefixed_Name(idsc, "BIMONTHLY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/BIWEEKLY</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Frequency</para>
    ///   <para>"The event occurs every two weeks."</para>
    /// labels<para>"Biweekly"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/BIWEEKLY">https://w3id.org/idsa/code/BIWEEKLY</seealso>
    let BIWEEKLY = Prefixed_Name(idsc, "BIWEEKLY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/BM</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bambara"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/BM">https://w3id.org/idsa/code/BM</seealso>
    let BM = Prefixed_Name(idsc, "BM") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/BN</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Bengali, Bangla"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/BN">https://w3id.org/idsa/code/BN</seealso>
    let BN = Prefixed_Name(idsc, "BN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/BO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Tibetan Standard, Tibetan, Central"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/BO">https://w3id.org/idsa/code/BO</seealso>
    let BO = Prefixed_Name(idsc, "BO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/BR</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Breton"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/BR">https://w3id.org/idsa/code/BR</seealso>
    let BR = Prefixed_Name(idsc, "BR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/BROKER</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/QueryTarget</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"BROKER"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/BROKER">https://w3id.org/idsa/code/BROKER</seealso>
    let BROKER = Prefixed_Name(idsc, "BROKER") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/BS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Bosnian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/BS">https://w3id.org/idsa/code/BS</seealso>
    let BS = Prefixed_Name(idsc, "BS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/CA</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Catalan"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/CA">https://w3id.org/idsa/code/CA</seealso>
    let CA = Prefixed_Name(idsc, "CA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/CE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Chechen"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/CE">https://w3id.org/idsa/code/CE</seealso>
    let CE = Prefixed_Name(idsc, "CE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/CH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Chamorro"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/CH">https://w3id.org/idsa/code/CH</seealso>
    let CH = Prefixed_Name(idsc, "CH") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/CLEARING_HOUSE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/QueryTarget</para>
    ///
    /// labels<para>"CLEARING_HOUSE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/CLEARING_HOUSE">https://w3id.org/idsa/code/CLEARING_HOUSE</seealso>
    let CLEARING_HOUSE = Prefixed_Name(idsc, "CLEARING_HOUSE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/CO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Corsican"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/CO">https://w3id.org/idsa/code/CO</seealso>
    let CO = Prefixed_Name(idsc, "CO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/COMBINED</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/ArtifactState</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The artifact is a collection of smaller artifacts and can be split into parts when necessary."</para>
    /// labels<para>"is combined"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/COMBINED">https://w3id.org/idsa/code/COMBINED</seealso>
    let COMBINED = Prefixed_Name(idsc, "COMBINED") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/COMPENSATE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Action</para>
    ///   <para>"To pay a certain amount of money in order to use a resource."</para>
    /// labels<para>"compensate"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/COMPENSATE">https://w3id.org/idsa/code/COMPENSATE</seealso>
    let COMPENSATE = Prefixed_Name(idsc, "COMPENSATE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/COMPONENT_BASE_SECURITY_PROFILE_CHECKLIST_APPROACH</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/ComponentCertificationLevel</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Base Security Profile Certification of Components based on Checklist Approach"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/COMPONENT_BASE_SECURITY_PROFILE_CHECKLIST_APPROACH">https://w3id.org/idsa/code/COMPONENT_BASE_SECURITY_PROFILE_CHECKLIST_APPROACH</seealso>
    let COMPONENT_BASE_SECURITY_PROFILE_CHECKLIST_APPROACH =
        Prefixed_Name(idsc, "COMPONENT_BASE_SECURITY_PROFILE_CHECKLIST_APPROACH") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/COMPONENT_BASE_SECURITY_PROFILE_CONCEPT_REVIEW</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/ComponentCertificationLevel</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Base Security Profile Certification of Components based on Concept Review"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/COMPONENT_BASE_SECURITY_PROFILE_CONCEPT_REVIEW">https://w3id.org/idsa/code/COMPONENT_BASE_SECURITY_PROFILE_CONCEPT_REVIEW</seealso>
    let COMPONENT_BASE_SECURITY_PROFILE_CONCEPT_REVIEW =
        Prefixed_Name(idsc, "COMPONENT_BASE_SECURITY_PROFILE_CONCEPT_REVIEW") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/COMPONENT_TRUSTPLUS_SECURITY_PROFILE_CONCEPT_REVIEW</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/ComponentCertificationLevel</para>
    ///
    /// labels<para>"Trust-Plus Security Profile Certification of Components based on Concept Review"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/COMPONENT_TRUSTPLUS_SECURITY_PROFILE_CONCEPT_REVIEW">https://w3id.org/idsa/code/COMPONENT_TRUSTPLUS_SECURITY_PROFILE_CONCEPT_REVIEW</seealso>
    let COMPONENT_TRUSTPLUS_SECURITY_PROFILE_CONCEPT_REVIEW =
        Prefixed_Name(idsc, "COMPONENT_TRUSTPLUS_SECURITY_PROFILE_CONCEPT_REVIEW") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/COMPONENT_TRUSTPLUS_SECURITY_PROFILE_HIGH_ASSURANCE_EVALUATION</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/ComponentCertificationLevel</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Trust-Plus Security Profile Certification of Components based on High AssuranceEvaluation"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/COMPONENT_TRUSTPLUS_SECURITY_PROFILE_HIGH_ASSURANCE_EVALUATION">https://w3id.org/idsa/code/COMPONENT_TRUSTPLUS_SECURITY_PROFILE_HIGH_ASSURANCE_EVALUATION</seealso>
    let COMPONENT_TRUSTPLUS_SECURITY_PROFILE_HIGH_ASSURANCE_EVALUATION =
        Prefixed_Name(idsc, "COMPONENT_TRUSTPLUS_SECURITY_PROFILE_HIGH_ASSURANCE_EVALUATION") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/COMPONENT_TRUST_SECURITY_PROFILE_CONCEPT_REVIEW</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/ComponentCertificationLevel</para>
    ///
    /// labels<para>"Trust Security Profile Certification of Components based on Concept Review"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/COMPONENT_TRUST_SECURITY_PROFILE_CONCEPT_REVIEW">https://w3id.org/idsa/code/COMPONENT_TRUST_SECURITY_PROFILE_CONCEPT_REVIEW</seealso>
    let COMPONENT_TRUST_SECURITY_PROFILE_CONCEPT_REVIEW =
        Prefixed_Name(idsc, "COMPONENT_TRUST_SECURITY_PROFILE_CONCEPT_REVIEW") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/COMPONENT_TRUST_SECURITY_PROFILE_HIGH_ASSURANCE_EVALUATION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/ComponentCertificationLevel</para>
    ///
    /// labels<para>"Trust Security Profile Certification of Components based on High Assurance Evaluation"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/COMPONENT_TRUST_SECURITY_PROFILE_HIGH_ASSURANCE_EVALUATION">https://w3id.org/idsa/code/COMPONENT_TRUST_SECURITY_PROFILE_HIGH_ASSURANCE_EVALUATION</seealso>
    let COMPONENT_TRUST_SECURITY_PROFILE_HIGH_ASSURANCE_EVALUATION =
        Prefixed_Name(idsc, "COMPONENT_TRUST_SECURITY_PROFILE_HIGH_ASSURANCE_EVALUATION") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/CONFIG_ENDPOINT</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/AppEndpointType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Endpoint is used for runtime-related app configurations and app parameters."</para>
    /// labels<para>"Config endpoint"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/CONFIG_ENDPOINT">https://w3id.org/idsa/code/CONFIG_ENDPOINT</seealso>
    let CONFIG_ENDPOINT = Prefixed_Name(idsc, "CONFIG_ENDPOINT") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/CONNECTOR_BADLY_CONFIGURED</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/ConnectorStatus</para>
    ///   <para>"Indicates that a Connector is badly configured."</para>
    /// labels<para>"Connector badly configured"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/CONNECTOR_BADLY_CONFIGURED">https://w3id.org/idsa/code/CONNECTOR_BADLY_CONFIGURED</seealso>
    let CONNECTOR_BADLY_CONFIGURED =
        Prefixed_Name(idsc, "CONNECTOR_BADLY_CONFIGURED") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/CONNECTOR_OFFLINE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/ConnectorStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Indicates that a Connector is offline."</para>
    /// labels<para>"Connector Offline"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/CONNECTOR_OFFLINE">https://w3id.org/idsa/code/CONNECTOR_OFFLINE</seealso>
    let CONNECTOR_OFFLINE = Prefixed_Name(idsc, "CONNECTOR_OFFLINE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/CONNECTOR_ONLINE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/ConnectorStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Indicates that a Connector is online."</para>
    /// labels<para>"Connector Online"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/CONNECTOR_ONLINE">https://w3id.org/idsa/code/CONNECTOR_ONLINE</seealso>
    let CONNECTOR_ONLINE = Prefixed_Name(idsc, "CONNECTOR_ONLINE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/CONTAINS</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"If a TemporalEntity (or xsd:dateTimeStamp) T1 contains another ids:TemporalEntity T2, then the beginning of T1 is idsc:AFTER the beginning of T2 and the ending of T1 is idsc:BEFORE the ending of T2. An Instant (or xsd:dateTimeStamp) cannot contain another Instant (or xsd:dateTimeStamp), neihter contains itself."</para>
    /// labels<para>"contains"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/CONTAINS">https://w3id.org/idsa/code/CONTAINS</seealso>
    let CONTAINS = Prefixed_Name(idsc, "CONTAINS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/CONTINUOUS</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Frequency</para>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The event repeats without interruption."</para>
    /// labels<para>"Continuous"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/CONTINUOUS">https://w3id.org/idsa/code/CONTINUOUS</seealso>
    let CONTINUOUS = Prefixed_Name(idsc, "CONTINUOUS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/COUNT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/LeftOperand</para>
    ///   <para>"Numeric count of executions of the Rule. Operators can be idsc:LT, idsc:LTEQ, idsc:EQ, idsc:GT, idsc:GTEQ. Datatype is xsd:double."</para>
    /// labels<para>"count"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/COUNT">https://w3id.org/idsa/code/COUNT</seealso>
    let COUNT = Prefixed_Name(idsc, "COUNT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/COVERED_BY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"Spatial operator 'covered by' as defined by the Egenhofer Topological Relations family: An object A is covered_by another object B if both objects share common bounding and interior faces; if A has interior faces which are bounding faces of B; and if none of B's interior faces are part of A's boundary. (https://doi.org/10.1007/3-540-51295-0_148 Definition 7)"</para>
    /// labels<para>"covered by"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/COVERED_BY">https://w3id.org/idsa/code/COVERED_BY</seealso>
    let COVERED_BY = Prefixed_Name(idsc, "COVERED_BY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/COVERS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"Spatial operator 'covers' as defined by the Egenhofer Topological Relations family: An object A covers another object B if both objects share common bounding and interior faces; if B has interior faces which are bounding faces of A; and if none of A's interior faces are part of B's boundary. (https://doi.org/10.1007/3-540-51295-0_148 Definition 6)"</para>
    /// labels<para>"covers"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/COVERS">https://w3id.org/idsa/code/COVERS</seealso>
    let COVERS = Prefixed_Name(idsc, "COVERS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/CR</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Cree"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/CR">https://w3id.org/idsa/code/CR</seealso>
    let CR = Prefixed_Name(idsc, "CR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/CS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Czech"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/CS">https://w3id.org/idsa/code/CS</seealso>
    let CS = Prefixed_Name(idsc, "CS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/CU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Old Church Slavonic, Church Slavonic, Old Bulgarian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/CU">https://w3id.org/idsa/code/CU</seealso>
    let CU = Prefixed_Name(idsc, "CU") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/CV</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Chuvash"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/CV">https://w3id.org/idsa/code/CV</seealso>
    let CV = Prefixed_Name(idsc, "CV") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/CY</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Welsh"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/CY">https://w3id.org/idsa/code/CY</seealso>
    let CY = Prefixed_Name(idsc, "CY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/DA</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Danish"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/DA">https://w3id.org/idsa/code/DA</seealso>
    let DA = Prefixed_Name(idsc, "DA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/DAILY</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:idsa/core/Frequency</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The event occurs once a day."</para>
    /// labels<para>"Daily"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/DAILY">https://w3id.org/idsa/code/DAILY</seealso>
    let DAILY = Prefixed_Name(idsc, "DAILY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/DE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"German"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/DE">https://w3id.org/idsa/code/DE</seealso>
    let DE = Prefixed_Name(idsc, "DE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/DEBUG_LEVEL_LOGGING</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/LogLevel</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Debug level logging."</para>
    /// labels<para>"Debug Level Logging"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/DEBUG_LEVEL_LOGGING">https://w3id.org/idsa/code/DEBUG_LEVEL_LOGGING</seealso>
    let DEBUG_LEVEL_LOGGING = Prefixed_Name(idsc, "DEBUG_LEVEL_LOGGING") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/DEFINES_AS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"Allows assignments similar to 'var x := {RightOperand}'."</para>
    /// labels<para>"defines as"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/DEFINES_AS">https://w3id.org/idsa/code/DEFINES_AS</seealso>
    let DEFINES_AS = Prefixed_Name(idsc, "DEFINES_AS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/DELAY</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/LeftOperand</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Delay the action. Use idsc:DURATION_EQ, idsc:LONGER, idsc:LONGER_EQ, idsc:SHORTER_EQ, or idsc:SHORTER with datatype xsd:duration."</para>
    /// labels<para>"delay"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/DELAY">https://w3id.org/idsa/code/DELAY</seealso>
    let DELAY = Prefixed_Name(idsc, "DELAY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/DELETE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Action</para>
    ///   <para>"To remove a resource or inhibit any further access with reasonable measures."</para>
    /// labels<para>"delete"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/DELETE">https://w3id.org/idsa/code/DELETE</seealso>
    let DELETE = Prefixed_Name(idsc, "DELETE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/DISJOINT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"Spatial operator 'disjoint' as defined by the Egenhofer Topological Relations family: If all four intersections among all object parts are empty, then the two objects are disjoint. (https://doi.org/10.1007/3-540-51295-0_148 Definition 1)"</para>
    /// labels<para>"disjoint"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/DISJOINT">https://w3id.org/idsa/code/DISJOINT</seealso>
    let DISJOINT = Prefixed_Name(idsc, "DISJOINT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/DISTRIBUTE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Action</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"To forward or supply a resource to a third-party."</para>
    /// labels<para>"distribute"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/DISTRIBUTE">https://w3id.org/idsa/code/DISTRIBUTE</seealso>
    let DISTRIBUTE = Prefixed_Name(idsc, "DISTRIBUTE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/DSA</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/KeyType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"DSA"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/DSA">https://w3id.org/idsa/code/DSA</seealso>
    let DSA = Prefixed_Name(idsc, "DSA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/DURATION_EQ</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"If a temporal entity T1 has the same duration as another temporal entity T2, then their length or their duration is equal. Instants and xsd:dateTimeStamp Literals have always the duration 'P0Y0M0DT0H0M0S'^^xsd:duration and therefore have always the same duration."</para>
    /// labels<para>"has same duration"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/DURATION_EQ">https://w3id.org/idsa/code/DURATION_EQ</seealso>
    let DURATION_EQ = Prefixed_Name(idsc, "DURATION_EQ") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/DURING</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"If a TemporalEntity T1 is during another TemporalEntity T2, then the beginning of T1 is after the beginning of T2, and the end of T1 is before the end of T2."</para>
    /// labels<para>"during"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/DURING">https://w3id.org/idsa/code/DURING</seealso>
    let DURING = Prefixed_Name(idsc, "DURING") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/DV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Divehi, Dhivehi, Maldivian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/DV">https://w3id.org/idsa/code/DV</seealso>
    let DV = Prefixed_Name(idsc, "DV") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/DZ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Dzongkha"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/DZ">https://w3id.org/idsa/code/DZ</seealso>
    let DZ = Prefixed_Name(idsc, "DZ") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/ECDSA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/KeyType</para>
    ///
    /// labels<para>"ECDSA"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/ECDSA">https://w3id.org/idsa/code/ECDSA</seealso>
    let ECDSA = Prefixed_Name(idsc, "ECDSA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/ED25519</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/KeyType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"ED25519"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/ED25519">https://w3id.org/idsa/code/ED25519</seealso>
    let ED25519 = Prefixed_Name(idsc, "ED25519") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/EE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Ewe"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/EE">https://w3id.org/idsa/code/EE</seealso>
    let EE = Prefixed_Name(idsc, "EE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/EL</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Greek (modern)"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/EL">https://w3id.org/idsa/code/EL</seealso>
    let EL = Prefixed_Name(idsc, "EL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/ELAPSED_TIME</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/LeftOperand</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A continuous elapsed time period which may be used for exercising of the action of the Rule. Allowed operators are idsc:SHORTER, idsc:SHORTER_EQ, idsc:LONGER, idsc:LONGER_EQ, and idsc:DURATION_EQ with datatype xsd:duration."</para>
    /// labels<para>"elapsed time"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/ELAPSED_TIME">https://w3id.org/idsa/code/ELAPSED_TIME</seealso>
    let ELAPSED_TIME = Prefixed_Name(idsc, "ELAPSED_TIME") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/EN</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"English"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/EN">https://w3id.org/idsa/code/EN</seealso>
    let EN = Prefixed_Name(idsc, "EN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/ENCRYPT</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Action</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The data artifact or parts of it are encrypted and can not be read by neither the ids:DataConsumer nor any other third party. The encryption algorithm might be specified by a constraint."</para>
    /// labels<para>"ecrypt"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/ENCRYPT">https://w3id.org/idsa/code/ENCRYPT</seealso>
    let ENCRYPT = Prefixed_Name(idsc, "ENCRYPT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/ENCRYPTED</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/ArtifactState</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The artifact is encrypted so the data itself cannot be read by any user without having the corresponding key."</para>
    /// labels<para>"is encrypted"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/ENCRYPTED">https://w3id.org/idsa/code/ENCRYPTED</seealso>
    let ENCRYPTED = Prefixed_Name(idsc, "ENCRYPTED") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/ENDPOINT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/LeftOperand</para>
    ///   <para>"Remote target for an action or information provider (PIP). Must be used together with idsc:IS or idsc:IN operators. RightOperand must be a xsd:anyURI or an URL which should point to an actually deployed endpoint. An example is a refinment of idsc:NOTIFY where idsc:REMOTE points to a Clearing House."</para>
    /// labels<para>"endpoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/ENDPOINT">https://w3id.org/idsa/code/ENDPOINT</seealso>
    let ENDPOINT = Prefixed_Name(idsc, "ENDPOINT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/EO</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Esperanto"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/EO">https://w3id.org/idsa/code/EO</seealso>
    let EO = Prefixed_Name(idsc, "EO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/EQ</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Arithmetic equals operator (5 = 5)."</para>
    /// labels<para>"equals"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/EQ">https://w3id.org/idsa/code/EQ</seealso>
    let EQ = Prefixed_Name(idsc, "EQ") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/EQUALS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"Logical equals operator (true = true)."</para>
    /// labels<para>"equals"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/EQUALS">https://w3id.org/idsa/code/EQUALS</seealso>
    let EQUALS = Prefixed_Name(idsc, "EQUALS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/ES</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Spanish"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/ES">https://w3id.org/idsa/code/ES</seealso>
    let ES = Prefixed_Name(idsc, "ES") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/ET</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Estonian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/ET">https://w3id.org/idsa/code/ET</seealso>
    let ET = Prefixed_Name(idsc, "ET") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/EU</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Basque"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/EU">https://w3id.org/idsa/code/EU</seealso>
    let EU = Prefixed_Name(idsc, "EU") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/EVENT</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/LeftOperand</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The feature dimension regarding whether current events are happening. Does NOT refer 'events' as in real-time data, sensor observations, or Complex Event Processing but rather as 'World Cup 2018' or 'Hannover Trade Fair'."</para>
    /// labels<para>"current event"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/EVENT">https://w3id.org/idsa/code/EVENT</seealso>
    let EVENT = Prefixed_Name(idsc, "EVENT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/FA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Persian (Farsi)"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/FA">https://w3id.org/idsa/code/FA</seealso>
    let FA = Prefixed_Name(idsc, "FA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/FF</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Fula, Fulah, Pulaar, Pular"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/FF">https://w3id.org/idsa/code/FF</seealso>
    let FF = Prefixed_Name(idsc, "FF") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/FI</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Finnish"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/FI">https://w3id.org/idsa/code/FI</seealso>
    let FI = Prefixed_Name(idsc, "FI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/FINISHED_BY</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"If an interval T1 is finished by another interval T2, then the beginning of T1 is before the beginning of T2, and the end of T1 is coincident with the end of T2."</para>
    /// labels<para>"finished by"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/FINISHED_BY">https://w3id.org/idsa/code/FINISHED_BY</seealso>
    let FINISHED_BY = Prefixed_Name(idsc, "FINISHED_BY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/FINISHES</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"If an Interval T1 finishes another interval T2, then the beginning of T1 is after the beginning of T2, and the end of T1 is coincident with the end of T2."</para>
    /// labels<para>"finishes"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/FINISHES">https://w3id.org/idsa/code/FINISHES</seealso>
    let FINISHES = Prefixed_Name(idsc, "FINISHES") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/FJ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Fijian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/FJ">https://w3id.org/idsa/code/FJ</seealso>
    let FJ = Prefixed_Name(idsc, "FJ") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/FO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Faroese"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/FO">https://w3id.org/idsa/code/FO</seealso>
    let FO = Prefixed_Name(idsc, "FO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/FR</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"French"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/FR">https://w3id.org/idsa/code/FR</seealso>
    let FR = Prefixed_Name(idsc, "FR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/FY</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Western Frisian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/FY">https://w3id.org/idsa/code/FY</seealso>
    let FY = Prefixed_Name(idsc, "FY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/GA</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Irish"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/GA">https://w3id.org/idsa/code/GA</seealso>
    let GA = Prefixed_Name(idsc, "GA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/GD</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Scottish Gaelic, Gaelic"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/GD">https://w3id.org/idsa/code/GD</seealso>
    let GD = Prefixed_Name(idsc, "GD") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/GL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Galician"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/GL">https://w3id.org/idsa/code/GL</seealso>
    let GL = Prefixed_Name(idsc, "GL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/GN</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Guaraní"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/GN">https://w3id.org/idsa/code/GN</seealso>
    let GN = Prefixed_Name(idsc, "GN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/GRANT_USE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Action</para>
    ///   <para>"To grant use of a resource to another party. Does *not* imply any other usage rights."</para>
    /// labels<para>"grant use"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/GRANT_USE">https://w3id.org/idsa/code/GRANT_USE</seealso>
    let GRANT_USE = Prefixed_Name(idsc, "GRANT_USE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/GT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"Greater-than operator. Can be used for numeric (5 idsc:GT 2) comparisons."</para>
    /// labels<para>"greater than"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/GT">https://w3id.org/idsa/code/GT</seealso>
    let GT = Prefixed_Name(idsc, "GT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/GTEQ</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Greater-than-or-equals operator. Can be used for numeric (5 idsc:GTEQ 2) comparisons."</para>
    /// labels<para>"greater than or equals"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/GTEQ">https://w3id.org/idsa/code/GTEQ</seealso>
    let GTEQ = Prefixed_Name(idsc, "GTEQ") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/GU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Gujarati"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/GU">https://w3id.org/idsa/code/GU</seealso>
    let GU = Prefixed_Name(idsc, "GU") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/GV</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Manx"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/GV">https://w3id.org/idsa/code/GV</seealso>
    let GV = Prefixed_Name(idsc, "GV") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/HA</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Hausa"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/HA">https://w3id.org/idsa/code/HA</seealso>
    let HA = Prefixed_Name(idsc, "HA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/HAS_MEMBERSHIP</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"If a user has a specific membership required for accessing a resource. A membership includes always a role and a related organisation (see also org:). Should be used together with a RightOperand pointing to an accessible endpoint providing this information."</para>
    /// labels<para>"has Member"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/HAS_MEMBERSHIP">https://w3id.org/idsa/code/HAS_MEMBERSHIP</seealso>
    let HAS_MEMBERSHIP = Prefixed_Name(idsc, "HAS_MEMBERSHIP") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/HAS_SITE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"If a user needs to be located at a certain site required for accessing a resource. A 'HAS_SITE' relation includes always a membership (role and related organisation) corresponding to the site. Should be used together with a RightOperand pointing to an accessible endpoint providing this information."</para>
    /// labels<para>"has site"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/HAS_SITE">https://w3id.org/idsa/code/HAS_SITE</seealso>
    let HAS_SITE = Prefixed_Name(idsc, "HAS_SITE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/HAS_STATE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Operator examining if the target resource has a certain state at the moment, for instance is anonymized (idsc:ANONYMIZED)."</para>
    /// labels<para>"has state"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/HAS_STATE">https://w3id.org/idsa/code/HAS_STATE</seealso>
    let HAS_STATE = Prefixed_Name(idsc, "HAS_STATE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/HE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Hebrew (modern)"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/HE">https://w3id.org/idsa/code/HE</seealso>
    let HE = Prefixed_Name(idsc, "HE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/HI</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Hindi"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/HI">https://w3id.org/idsa/code/HI</seealso>
    let HI = Prefixed_Name(idsc, "HI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/HO</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Hiri Motu"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/HO">https://w3id.org/idsa/code/HO</seealso>
    let HO = Prefixed_Name(idsc, "HO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/HR</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Croatian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/HR">https://w3id.org/idsa/code/HR</seealso>
    let HR = Prefixed_Name(idsc, "HR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/HT</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Haitian, Haitian Creole"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/HT">https://w3id.org/idsa/code/HT</seealso>
    let HT = Prefixed_Name(idsc, "HT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/HU</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Hungarian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/HU">https://w3id.org/idsa/code/HU</seealso>
    let HU = Prefixed_Name(idsc, "HU") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/HY</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Armenian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/HY">https://w3id.org/idsa/code/HY</seealso>
    let HY = Prefixed_Name(idsc, "HY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/HZ</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Herero"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/HZ">https://w3id.org/idsa/code/HZ</seealso>
    let HZ = Prefixed_Name(idsc, "HZ") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/IA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Interlingua"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/IA">https://w3id.org/idsa/code/IA</seealso>
    let IA = Prefixed_Name(idsc, "IA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Indonesian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/ID">https://w3id.org/idsa/code/ID</seealso>
    let ID = Prefixed_Name(idsc, "ID") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/IDS_CONNECTOR_ATTRIBUTES_ALL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Audience</para>
    ///   <para>"Every IDS Connector is in the intended audience for the DAT with this 'scope' property."</para>
    /// labels<para>"all IDS Connectors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/IDS_CONNECTOR_ATTRIBUTES_ALL">https://w3id.org/idsa/code/IDS_CONNECTOR_ATTRIBUTES_ALL</seealso>
    let IDS_CONNECTOR_ATTRIBUTES_ALL =
        Prefixed_Name(idsc, "IDS_CONNECTOR_ATTRIBUTES_ALL") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/IE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Interlingue"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/IE">https://w3id.org/idsa/code/IE</seealso>
    let IE = Prefixed_Name(idsc, "IE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/IG</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Igbo"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/IG">https://w3id.org/idsa/code/IG</seealso>
    let IG = Prefixed_Name(idsc, "IG") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/II</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Nuosu"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/II">https://w3id.org/idsa/code/II</seealso>
    let II = Prefixed_Name(idsc, "II") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/IK</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Inupiaq"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/IK">https://w3id.org/idsa/code/IK</seealso>
    let IK = Prefixed_Name(idsc, "IK") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/IN</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Element-of operator. Allowed RightOperands are RDF collections('(A B C)')."</para>
    /// labels<para>"in"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/IN">https://w3id.org/idsa/code/IN</seealso>
    let IN = Prefixed_Name(idsc, "IN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/INACTIVE_ONLY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/QueryScope</para>
    ///
    /// labels<para>"INACTIVE_ONLY"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/INACTIVE_ONLY">https://w3id.org/idsa/code/INACTIVE_ONLY</seealso>
    let INACTIVE_ONLY = Prefixed_Name(idsc, "INACTIVE_ONLY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/INPUT_ENDPOINT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/AppEndpointType</para>
    ///   <para>"Endpoint is used for data input."</para>
    /// labels<para>"Input endpoint"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/INPUT_ENDPOINT">https://w3id.org/idsa/code/INPUT_ENDPOINT</seealso>
    let INPUT_ENDPOINT = Prefixed_Name(idsc, "INPUT_ENDPOINT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/INSIDE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Spatial operator 'inside' as defined by the Egenhofer Topological Relations family: An object A is inside of another object B if (1) A and B share interior, but not bounding faces, (2) if A has bounding faces which are interior faces of B, and (3) none of B's bounding faces coincides with any of A's interior faces. (https://doi.org/10.1007/3-540-51295-0_148 Definition 4)"</para>
    /// labels<para>"inside"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/INSIDE">https://w3id.org/idsa/code/INSIDE</seealso>
    let INSIDE = Prefixed_Name(idsc, "INSIDE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/INSIDE_NETWORK</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Is satisfied if a system is inside a specified target network or network range."</para>
    /// labels<para>"inside network"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/INSIDE_NETWORK">https://w3id.org/idsa/code/INSIDE_NETWORK</seealso>
    let INSIDE_NETWORK = Prefixed_Name(idsc, "INSIDE_NETWORK") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/INTEGRITY_PROTECTION_LOCAL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/IntegrityGuarantee</para>
    ///
    /// labels<para>"Integrity Protection Local"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/INTEGRITY_PROTECTION_LOCAL">https://w3id.org/idsa/code/INTEGRITY_PROTECTION_LOCAL</seealso>
    let INTEGRITY_PROTECTION_LOCAL =
        Prefixed_Name(idsc, "INTEGRITY_PROTECTION_LOCAL") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/INTEGRITY_PROTECTION_NONE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/IntegrityGuarantee</para>
    ///
    /// labels<para>"Integrity Protection None"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/INTEGRITY_PROTECTION_NONE">https://w3id.org/idsa/code/INTEGRITY_PROTECTION_NONE</seealso>
    let INTEGRITY_PROTECTION_NONE =
        Prefixed_Name(idsc, "INTEGRITY_PROTECTION_NONE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/INTEGRITY_VERIFICATION_REMOTE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/IntegrityGuarantee</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Integrity Protection Remote"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/INTEGRITY_VERIFICATION_REMOTE">https://w3id.org/idsa/code/INTEGRITY_VERIFICATION_REMOTE</seealso>
    let INTEGRITY_VERIFICATION_REMOTE =
        Prefixed_Name(idsc, "INTEGRITY_VERIFICATION_REMOTE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/INTEGRITY_VERIFICATION_SCOPE_KERNEL_CORE_CONTAINER</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/IntegrityVerificationScopeGuarantee</para>
    ///
    /// labels<para>"Integrity Verification Scope Kernel Core Container"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/INTEGRITY_VERIFICATION_SCOPE_KERNEL_CORE_CONTAINER">https://w3id.org/idsa/code/INTEGRITY_VERIFICATION_SCOPE_KERNEL_CORE_CONTAINER</seealso>
    let INTEGRITY_VERIFICATION_SCOPE_KERNEL_CORE_CONTAINER =
        Prefixed_Name(idsc, "INTEGRITY_VERIFICATION_SCOPE_KERNEL_CORE_CONTAINER") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/INTEGRITY_VERIFICATION_SCOPE_KERNEL_CORE_CONTAINER_APPLICATION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/IntegrityVerificationScopeGuarantee</para>
    ///
    /// labels<para>"Integrity Verification Scope Kernel Core Container Application"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/INTEGRITY_VERIFICATION_SCOPE_KERNEL_CORE_CONTAINER_APPLICATION">https://w3id.org/idsa/code/INTEGRITY_VERIFICATION_SCOPE_KERNEL_CORE_CONTAINER_APPLICATION</seealso>
    let INTEGRITY_VERIFICATION_SCOPE_KERNEL_CORE_CONTAINER_APPLICATION =
        Prefixed_Name(idsc, "INTEGRITY_VERIFICATION_SCOPE_KERNEL_CORE_CONTAINER_APPLICATION") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/INTEGRITY_VERIFICATION_SCOPE_NONE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/IntegrityVerificationScopeGuarantee</para>
    ///
    /// labels<para>"Integrity Verification Scope None"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/INTEGRITY_VERIFICATION_SCOPE_NONE">https://w3id.org/idsa/code/INTEGRITY_VERIFICATION_SCOPE_NONE</seealso>
    let INTEGRITY_VERIFICATION_SCOPE_NONE =
        Prefixed_Name(idsc, "INTEGRITY_VERIFICATION_SCOPE_NONE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/INTERFACE_DEFINITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/ContentType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Formal, machine-interpretable definition of a protocol-specific API, e.g. OpenAPI, GraphQL, API Blueprint, WSDL."</para>
    /// labels<para>"Interface definition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/INTERFACE_DEFINITION">https://w3id.org/idsa/code/INTERFACE_DEFINITION</seealso>
    let INTERFACE_DEFINITION =
        Prefixed_Name(idsc, "INTERFACE_DEFINITION") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/INTERNAL_RECIPIENT_ERROR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/RejectionReason</para>
    ///   <para>"The message recipient encountered an internal error while processing the message (e.g., storage capacity exceeded)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"INTERNAL_RECIPIENT_ERROR"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/INTERNAL_RECIPIENT_ERROR">https://w3id.org/idsa/code/INTERNAL_RECIPIENT_ERROR</seealso>
    let INTERNAL_RECIPIENT_ERROR =
        Prefixed_Name(idsc, "INTERNAL_RECIPIENT_ERROR") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/IO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Ido"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/IO">https://w3id.org/idsa/code/IO</seealso>
    let IO = Prefixed_Name(idsc, "IO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/IRREGULAR</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:idsa/core/Frequency</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The event occurs at uneven intervals."</para>
    /// labels<para>"Irregular"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/IRREGULAR">https://w3id.org/idsa/code/IRREGULAR</seealso>
    let IRREGULAR = Prefixed_Name(idsc, "IRREGULAR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/IS</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Icelandic"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/IS">https://w3id.org/idsa/code/IS</seealso>
    let IS = Prefixed_Name(idsc, "IS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/IT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Italian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/IT">https://w3id.org/idsa/code/IT</seealso>
    let IT = Prefixed_Name(idsc, "IT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/IU</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Inuktitut"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/IU">https://w3id.org/idsa/code/IU</seealso>
    let IU = Prefixed_Name(idsc, "IU") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/JA</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Japanese"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/JA">https://w3id.org/idsa/code/JA</seealso>
    let JA = Prefixed_Name(idsc, "JA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/JV</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Javanese"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/JV">https://w3id.org/idsa/code/JV</seealso>
    let JV = Prefixed_Name(idsc, "JV") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/JWT</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/TokenFormat</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Json Web Token"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/JWT">https://w3id.org/idsa/code/JWT</seealso>
    let JWT = Prefixed_Name(idsc, "JWT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/KA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Georgian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/KA">https://w3id.org/idsa/code/KA</seealso>
    let KA = Prefixed_Name(idsc, "KA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/KG</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Kongo"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/KG">https://w3id.org/idsa/code/KG</seealso>
    let KG = Prefixed_Name(idsc, "KG") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/KI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Kikuyu, Gikuyu"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/KI">https://w3id.org/idsa/code/KI</seealso>
    let KI = Prefixed_Name(idsc, "KI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/KJ</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Kwanyama, Kuanyama"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/KJ">https://w3id.org/idsa/code/KJ</seealso>
    let KJ = Prefixed_Name(idsc, "KJ") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/KK</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Kazakh"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/KK">https://w3id.org/idsa/code/KK</seealso>
    let KK = Prefixed_Name(idsc, "KK") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/KL</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Kalaallisut, Greenlandic"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/KL">https://w3id.org/idsa/code/KL</seealso>
    let KL = Prefixed_Name(idsc, "KL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/KM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Khmer"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/KM">https://w3id.org/idsa/code/KM</seealso>
    let KM = Prefixed_Name(idsc, "KM") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/KN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Kannada"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/KN">https://w3id.org/idsa/code/KN</seealso>
    let KN = Prefixed_Name(idsc, "KN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/KO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Korean"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/KO">https://w3id.org/idsa/code/KO</seealso>
    let KO = Prefixed_Name(idsc, "KO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/KR</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Kanuri"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/KR">https://w3id.org/idsa/code/KR</seealso>
    let KR = Prefixed_Name(idsc, "KR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/KS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Kashmiri"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/KS">https://w3id.org/idsa/code/KS</seealso>
    let KS = Prefixed_Name(idsc, "KS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/KU</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Kurdish"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/KU">https://w3id.org/idsa/code/KU</seealso>
    let KU = Prefixed_Name(idsc, "KU") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/KV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Komi"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/KV">https://w3id.org/idsa/code/KV</seealso>
    let KV = Prefixed_Name(idsc, "KV") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/KW</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Cornish"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/KW">https://w3id.org/idsa/code/KW</seealso>
    let KW = Prefixed_Name(idsc, "KW") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/KY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Kyrgyz"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/KY">https://w3id.org/idsa/code/KY</seealso>
    let KY = Prefixed_Name(idsc, "KY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/LA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Latin"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/LA">https://w3id.org/idsa/code/LA</seealso>
    let LA = Prefixed_Name(idsc, "LA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/LB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Luxembourgish, Letzeburgesch"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/LB">https://w3id.org/idsa/code/LB</seealso>
    let LB = Prefixed_Name(idsc, "LB") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/LG</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Ganda"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/LG">https://w3id.org/idsa/code/LG</seealso>
    let LG = Prefixed_Name(idsc, "LG") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/LI</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Limburgish, Limburgan, Limburger"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/LI">https://w3id.org/idsa/code/LI</seealso>
    let LI = Prefixed_Name(idsc, "LI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/LN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Lingala"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/LN">https://w3id.org/idsa/code/LN</seealso>
    let LN = Prefixed_Name(idsc, "LN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/LO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Lao"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/LO">https://w3id.org/idsa/code/LO</seealso>
    let LO = Prefixed_Name(idsc, "LO") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/LOCAL_DATA_CONFIDENTIALITY_FULL_ENCRYPTION</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/LocalDataConfidentialityGuarantee</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Local Data Confidentiality Full Encryption"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/LOCAL_DATA_CONFIDENTIALITY_FULL_ENCRYPTION">https://w3id.org/idsa/code/LOCAL_DATA_CONFIDENTIALITY_FULL_ENCRYPTION</seealso>
    let LOCAL_DATA_CONFIDENTIALITY_FULL_ENCRYPTION =
        Prefixed_Name(idsc, "LOCAL_DATA_CONFIDENTIALITY_FULL_ENCRYPTION") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/LOCAL_DATA_CONFIDENTIALITY_NONE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/LocalDataConfidentialityGuarantee</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Local Data Confidentiality None"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/LOCAL_DATA_CONFIDENTIALITY_NONE">https://w3id.org/idsa/code/LOCAL_DATA_CONFIDENTIALITY_NONE</seealso>
    let LOCAL_DATA_CONFIDENTIALITY_NONE =
        Prefixed_Name(idsc, "LOCAL_DATA_CONFIDENTIALITY_NONE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/LOCAL_DATA_CONFIDENTIALITY_SECURE_ERASURE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/LocalDataConfidentialityGuarantee</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Local Data Confidentiality Secure Erasure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/LOCAL_DATA_CONFIDENTIALITY_SECURE_ERASURE">https://w3id.org/idsa/code/LOCAL_DATA_CONFIDENTIALITY_SECURE_ERASURE</seealso>
    let LOCAL_DATA_CONFIDENTIALITY_SECURE_ERASURE =
        Prefixed_Name(idsc, "LOCAL_DATA_CONFIDENTIALITY_SECURE_ERASURE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/LOG</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Action</para>
    ///   <para>"To log information or store information about incidents in a local file or database. Is not necessarily available to external parties but can be used to create transparency on happened events."</para>
    /// labels<para>"log"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/LOG">https://w3id.org/idsa/code/LOG</seealso>
    let LOG = Prefixed_Name(idsc, "LOG") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/LONGER</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"If a temporal entity T1 is longer than another temporal entity T2, then the length or duration of T1 is bigger. Instants and xsd:dateTimeStamp Literals have always the duration 'P0Y0M0DT0H0M0S'^^xsd:duration and therefore have always the same duration."</para>
    /// labels<para>"longer"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/LONGER">https://w3id.org/idsa/code/LONGER</seealso>
    let LONGER = Prefixed_Name(idsc, "LONGER") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/LONGER_EQ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"If temporal entity T1 is longer or equals than another temporal entity T2, then the length or duration of T1 is bigger or their length or their duration is equal. Instants and xsd:dateTimeStamp Literals have always the duration 'P0Y0M0DT0H0M0S'^^xsd:duration and therefore have always the same duration."</para>
    /// labels<para>"longer or equals"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/LONGER_EQ">https://w3id.org/idsa/code/LONGER_EQ</seealso>
    let LONGER_EQ = Prefixed_Name(idsc, "LONGER_EQ") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/LT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>"Less-than operator. Can be used for numeric (2 idsc:LT 5) comparisons."</para>
    /// labels<para>"Lithuanian"</para><para>"less than"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/LT">https://w3id.org/idsa/code/LT</seealso>
    let LT = Prefixed_Name(idsc, "LT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/LTEQ</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Less-than-or-equals operator. Can be used for numeric (2 idsc:LTEQ 5) comparisons."</para>
    /// labels<para>"less than or equals"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/LTEQ">https://w3id.org/idsa/code/LTEQ</seealso>
    let LTEQ = Prefixed_Name(idsc, "LTEQ") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/LU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Luba-Katanga"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/LU">https://w3id.org/idsa/code/LU</seealso>
    let LU = Prefixed_Name(idsc, "LU") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/LV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Latvian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/LV">https://w3id.org/idsa/code/LV</seealso>
    let LV = Prefixed_Name(idsc, "LV") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/MALFORMED_MESSAGE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/RejectionReason</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The originating message is malformed or missing information."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MALFORMED_MESSAGE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/MALFORMED_MESSAGE">https://w3id.org/idsa/code/MALFORMED_MESSAGE</seealso>
    let MALFORMED_MESSAGE = Prefixed_Name(idsc, "MALFORMED_MESSAGE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/MATCHES</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"Regex operator for strings. Evaluates to true iff the regex pattern of the RightOperand matches the LeftOperand."</para>
    /// labels<para>"matches"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/MATCHES">https://w3id.org/idsa/code/MATCHES</seealso>
    let MATCHES = Prefixed_Name(idsc, "MATCHES") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/MEETS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"If a TemporalEntity or (xsd:dateTimeStamp Literal) T1 meets another TemporalEntity (or xsd:dateTimeStamp Literal) T2, then the end of T1 is coincident with the beginning of T2."</para>
    /// labels<para>"meets"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/MEETS">https://w3id.org/idsa/code/MEETS</seealso>
    let MEETS = Prefixed_Name(idsc, "MEETS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/MEMBER_OF</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"If a user is part of a certain organisation required for accessing a resource. Should be used together with a RightOperand pointing to an accessible endpoint providing this information."</para>
    /// labels<para>"memberOf"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/MEMBER_OF">https://w3id.org/idsa/code/MEMBER_OF</seealso>
    let MEMBER_OF = Prefixed_Name(idsc, "MEMBER_OF") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/MESSAGE_TYPE_NOT_SUPPORTED</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/RejectionReason</para>
    ///   <para>"The sender of the rejection does not support the incoming message type (e.g., ids:QueryMessage)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MESSAGE_TYPE_NOT_SUPPORTED"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/MESSAGE_TYPE_NOT_SUPPORTED">https://w3id.org/idsa/code/MESSAGE_TYPE_NOT_SUPPORTED</seealso>
    let MESSAGE_TYPE_NOT_SUPPORTED =
        Prefixed_Name(idsc, "MESSAGE_TYPE_NOT_SUPPORTED") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/METHOD_NOT_SUPPORTED</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/RejectionReason</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The sender of the rejection does not implement a certain functionality stated in the message (e.g., query language)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"METHOD_NOT_SUPPORTED"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/METHOD_NOT_SUPPORTED">https://w3id.org/idsa/code/METHOD_NOT_SUPPORTED</seealso>
    let METHOD_NOT_SUPPORTED =
        Prefixed_Name(idsc, "METHOD_NOT_SUPPORTED") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/MET_BY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"If a TemporalEntity or (xsd:dateTimeStamp Literal) T1 is met by another TemporalEntity or (xsd:dateTimeStamp Literal) T2, then the beginning of T1 is coincident with the end of T2."</para>
    /// labels<para>"met by"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/MET_BY">https://w3id.org/idsa/code/MET_BY</seealso>
    let MET_BY = Prefixed_Name(idsc, "MET_BY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/MG</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Malagasy"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/MG">https://w3id.org/idsa/code/MG</seealso>
    let MG = Prefixed_Name(idsc, "MG") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/MH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Marshallese"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/MH">https://w3id.org/idsa/code/MH</seealso>
    let MH = Prefixed_Name(idsc, "MH") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/MI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Māori"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/MI">https://w3id.org/idsa/code/MI</seealso>
    let MI = Prefixed_Name(idsc, "MI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/MINIMAL_LOGGING</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/LogLevel</para>
    ///   <para>"Minimal logging."</para>
    /// labels<para>"Minimal Logging"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/MINIMAL_LOGGING">https://w3id.org/idsa/code/MINIMAL_LOGGING</seealso>
    let MINIMAL_LOGGING = Prefixed_Name(idsc, "MINIMAL_LOGGING") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/MK</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Macedonian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/MK">https://w3id.org/idsa/code/MK</seealso>
    let MK = Prefixed_Name(idsc, "MK") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/ML</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Malayalam"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/ML">https://w3id.org/idsa/code/ML</seealso>
    let ML = Prefixed_Name(idsc, "ML") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/MN</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Mongolian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/MN">https://w3id.org/idsa/code/MN</seealso>
    let MN = Prefixed_Name(idsc, "MN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/MODIFY</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Action</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"To change a resource locally."</para>
    /// labels<para>"modify"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/MODIFY">https://w3id.org/idsa/code/MODIFY</seealso>
    let MODIFY = Prefixed_Name(idsc, "MODIFY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/MONTHLY</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:idsa/core/Frequency</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The event occurs once a month."</para>
    /// labels<para>"Monthly"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/MONTHLY">https://w3id.org/idsa/code/MONTHLY</seealso>
    let MONTHLY = Prefixed_Name(idsc, "MONTHLY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/MR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Marathi (Marāṭhī)"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/MR">https://w3id.org/idsa/code/MR</seealso>
    let MR = Prefixed_Name(idsc, "MR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/MS</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Malay"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/MS">https://w3id.org/idsa/code/MS</seealso>
    let MS = Prefixed_Name(idsc, "MS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/MT</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Maltese"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/MT">https://w3id.org/idsa/code/MT</seealso>
    let MT = Prefixed_Name(idsc, "MT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/MULTI_LINGUAL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>"Code indicates that several languages are used or no concrete language can be determined."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Multilingual"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/MULTI_LINGUAL">https://w3id.org/idsa/code/MULTI_LINGUAL</seealso>
    let MULTI_LINGUAL = Prefixed_Name(idsc, "MULTI_LINGUAL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/MY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Burmese"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/MY">https://w3id.org/idsa/code/MY</seealso>
    let MY = Prefixed_Name(idsc, "MY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/NA</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Nauruan"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/NA">https://w3id.org/idsa/code/NA</seealso>
    let NA = Prefixed_Name(idsc, "NA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/NB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Norwegian Bokmål"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/NB">https://w3id.org/idsa/code/NB</seealso>
    let NB = Prefixed_Name(idsc, "NB") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/ND</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Northern Ndebele"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/ND">https://w3id.org/idsa/code/ND</seealso>
    let ND = Prefixed_Name(idsc, "ND") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/NE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Nepali"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/NE">https://w3id.org/idsa/code/NE</seealso>
    let NE = Prefixed_Name(idsc, "NE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/NEXT_POLICY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Action</para>
    ///   <para>"To forward the resource under the same policy. Implies a permission to distribute."</para>
    /// labels<para>"next policy"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/NEXT_POLICY">https://w3id.org/idsa/code/NEXT_POLICY</seealso>
    let NEXT_POLICY = Prefixed_Name(idsc, "NEXT_POLICY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/NG</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Ndonga"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/NG">https://w3id.org/idsa/code/NG</seealso>
    let NG = Prefixed_Name(idsc, "NG") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/NL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Dutch"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/NL">https://w3id.org/idsa/code/NL</seealso>
    let NL = Prefixed_Name(idsc, "NL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/NN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Norwegian Nynorsk"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/NN">https://w3id.org/idsa/code/NN</seealso>
    let NN = Prefixed_Name(idsc, "NN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/NO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Norwegian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/NO">https://w3id.org/idsa/code/NO</seealso>
    let NO = Prefixed_Name(idsc, "NO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/NOT</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Logical difference operator (false != true)."</para>
    /// labels<para>"not equals"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/NOT">https://w3id.org/idsa/code/NOT</seealso>
    let NOT = Prefixed_Name(idsc, "NOT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/NOTIFY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Action</para>
    ///   <para>"To log information or notify an instance about incidents. Can be used to define Clearing House interactions."</para>
    /// labels<para>"notify"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/NOTIFY">https://w3id.org/idsa/code/NOTIFY</seealso>
    let NOTIFY = Prefixed_Name(idsc, "NOTIFY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/NOT_AUTHENTICATED</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/RejectionReason</para>
    ///   <para>"Authenticity of a message sender has failed or is not verifiable."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NOT_AUTHENTICATED"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/NOT_AUTHENTICATED">https://w3id.org/idsa/code/NOT_AUTHENTICATED</seealso>
    let NOT_AUTHENTICATED = Prefixed_Name(idsc, "NOT_AUTHENTICATED") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/NOT_AUTHORIZED</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/RejectionReason</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Sender is not authorized to initiate the command."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NOT_AUTHORIZED"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/NOT_AUTHORIZED">https://w3id.org/idsa/code/NOT_AUTHORIZED</seealso>
    let NOT_AUTHORIZED = Prefixed_Name(idsc, "NOT_AUTHORIZED") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/NOT_FOUND</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/RejectionReason</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Requested Resource was not found."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NOT_FOUND"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/NOT_FOUND">https://w3id.org/idsa/code/NOT_FOUND</seealso>
    let NOT_FOUND = Prefixed_Name(idsc, "NOT_FOUND") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/NO_LOGGING</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/LogLevel</para>
    ///   <para>"No logging."</para>
    /// labels<para>"No Logging"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/NO_LOGGING">https://w3id.org/idsa/code/NO_LOGGING</seealso>
    let NO_LOGGING = Prefixed_Name(idsc, "NO_LOGGING") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/NR</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Southern Ndebele"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/NR">https://w3id.org/idsa/code/NR</seealso>
    let NR = Prefixed_Name(idsc, "NR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/NV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Navajo, Navaho"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/NV">https://w3id.org/idsa/code/NV</seealso>
    let NV = Prefixed_Name(idsc, "NV") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/NY</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Chichewa, Chewa, Nyanja"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/NY">https://w3id.org/idsa/code/NY</seealso>
    let NY = Prefixed_Name(idsc, "NY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/OAUTH2_JWT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/AuthStandard</para>
    ///   <para>"OAUTH2 via JWT"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/idsa/code/OAUTH2_JWT">https://w3id.org/idsa/code/OAUTH2_JWT</seealso>
    let OAUTH2_JWT = Prefixed_Name(idsc, "OAUTH2_JWT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/OC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Occitan"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/OC">https://w3id.org/idsa/code/OC</seealso>
    let OC = Prefixed_Name(idsc, "OC") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/OJ</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Ojibwe, Ojibwa"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/OJ">https://w3id.org/idsa/code/OJ</seealso>
    let OJ = Prefixed_Name(idsc, "OJ") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/OM</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Oromo"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/OM">https://w3id.org/idsa/code/OM</seealso>
    let OM = Prefixed_Name(idsc, "OM") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/OR</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Oriya"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/OR">https://w3id.org/idsa/code/OR</seealso>
    let OR = Prefixed_Name(idsc, "OR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/OS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Ossetian, Ossetic"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/OS">https://w3id.org/idsa/code/OS</seealso>
    let OS = Prefixed_Name(idsc, "OS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/OTHER</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/TokenFormat</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/OTHER">https://w3id.org/idsa/code/OTHER</seealso>
    let OTHER = Prefixed_Name(idsc, "OTHER") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/OUTPUT_ENDPOINT</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/AppEndpointType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Endpoint is used for data output."</para>
    /// labels<para>"Output endpoint"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/OUTPUT_ENDPOINT">https://w3id.org/idsa/code/OUTPUT_ENDPOINT</seealso>
    let OUTPUT_ENDPOINT = Prefixed_Name(idsc, "OUTPUT_ENDPOINT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/OVERLAPPED_BY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"If a interval T1 is overlapped another proper interval T2, then the beginning of T1 is before the beginning of T2, the end of T1 is after the beginning of T2, and the end of T1 is before the end of T2."</para>
    /// labels<para>"overlapped by"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/OVERLAPPED_BY">https://w3id.org/idsa/code/OVERLAPPED_BY</seealso>
    let OVERLAPPED_BY = Prefixed_Name(idsc, "OVERLAPPED_BY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/OVERLAPS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"If an ids:Interval T1 overlapps another ids:Interval T2, then the beginning of T1 is after the beginning of T2, the beginning of T1 is before the end of T2, and the end of T1 is after the end of T2."</para>
    /// labels<para>"overlaps"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/OVERLAPS">https://w3id.org/idsa/code/OVERLAPS</seealso>
    let OVERLAPS = Prefixed_Name(idsc, "OVERLAPS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/PA</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"(Eastern) Punjabi"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/PA">https://w3id.org/idsa/code/PA</seealso>
    let PA = Prefixed_Name(idsc, "PA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/PARIS</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/QueryTarget</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"PARTICIPANT INFORMATION SERVICE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/PARIS">https://w3id.org/idsa/code/PARIS</seealso>
    let PARIS = Prefixed_Name(idsc, "PARIS") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/PARTICIPANT_CENTRAL_LEVEL_CONTROL_FRAMEWORK</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/ParticipantCertificationLevel</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Central Level Control Framework Certification of Participants"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/PARTICIPANT_CENTRAL_LEVEL_CONTROL_FRAMEWORK">https://w3id.org/idsa/code/PARTICIPANT_CENTRAL_LEVEL_CONTROL_FRAMEWORK</seealso>
    let PARTICIPANT_CENTRAL_LEVEL_CONTROL_FRAMEWORK =
        Prefixed_Name(idsc, "PARTICIPANT_CENTRAL_LEVEL_CONTROL_FRAMEWORK") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/PARTICIPANT_CENTRAL_LEVEL_MANAGEMENT_SYSTEM</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/ParticipantCertificationLevel</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Central Level Management System Certification of Participants"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/PARTICIPANT_CENTRAL_LEVEL_MANAGEMENT_SYSTEM">https://w3id.org/idsa/code/PARTICIPANT_CENTRAL_LEVEL_MANAGEMENT_SYSTEM</seealso>
    let PARTICIPANT_CENTRAL_LEVEL_MANAGEMENT_SYSTEM =
        Prefixed_Name(idsc, "PARTICIPANT_CENTRAL_LEVEL_MANAGEMENT_SYSTEM") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/PARTICIPANT_ENTRY_LEVEL_MANAGEMENT_SYSTEM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/ParticipantCertificationLevel</para>
    ///
    /// labels<para>"Entry Level Management System Certification of Participants"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/PARTICIPANT_ENTRY_LEVEL_MANAGEMENT_SYSTEM">https://w3id.org/idsa/code/PARTICIPANT_ENTRY_LEVEL_MANAGEMENT_SYSTEM</seealso>
    let PARTICIPANT_ENTRY_LEVEL_MANAGEMENT_SYSTEM =
        Prefixed_Name(idsc, "PARTICIPANT_ENTRY_LEVEL_MANAGEMENT_SYSTEM") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/PARTICIPANT_ENTRY_LEVEL_SELF_ASSESSMENT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/ParticipantCertificationLevel</para>
    ///
    /// labels<para>"Entry Level Self-Assessment Certification of Participants"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/PARTICIPANT_ENTRY_LEVEL_SELF_ASSESSMENT">https://w3id.org/idsa/code/PARTICIPANT_ENTRY_LEVEL_SELF_ASSESSMENT</seealso>
    let PARTICIPANT_ENTRY_LEVEL_SELF_ASSESSMENT =
        Prefixed_Name(idsc, "PARTICIPANT_ENTRY_LEVEL_SELF_ASSESSMENT") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/PARTICIPANT_MEMBER_LEVEL_CONTROL_FRAMEWORK</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/ParticipantCertificationLevel</para>
    ///
    /// labels<para>"Member Level ControlFramework Certification of Participants"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/PARTICIPANT_MEMBER_LEVEL_CONTROL_FRAMEWORK">https://w3id.org/idsa/code/PARTICIPANT_MEMBER_LEVEL_CONTROL_FRAMEWORK</seealso>
    let PARTICIPANT_MEMBER_LEVEL_CONTROL_FRAMEWORK =
        Prefixed_Name(idsc, "PARTICIPANT_MEMBER_LEVEL_CONTROL_FRAMEWORK") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/PARTICIPANT_MEMBER_LEVEL_MANAGEMENT_SYSTEM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/ParticipantCertificationLevel</para>
    ///
    /// labels<para>"Member Level Management System Certification of Participants"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/PARTICIPANT_MEMBER_LEVEL_MANAGEMENT_SYSTEM">https://w3id.org/idsa/code/PARTICIPANT_MEMBER_LEVEL_MANAGEMENT_SYSTEM</seealso>
    let PARTICIPANT_MEMBER_LEVEL_MANAGEMENT_SYSTEM =
        Prefixed_Name(idsc, "PARTICIPANT_MEMBER_LEVEL_MANAGEMENT_SYSTEM") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/PATH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/LeftOperand</para>
    ///   <para>"Path to specific attribute (default JsonPath). Must be used together with idsc:STRING_EQ, idsc:STRING_CONTAINS, idsc:STRING_IS_CONTAINED, or idsc:MATCHES operators. RightOperand must be a xsd:string."</para>
    /// labels<para>"path to attribute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/PATH">https://w3id.org/idsa/code/PATH</seealso>
    let PATH = Prefixed_Name(idsc, "PATH") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/PAYMENT</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/LeftOperand</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Monetary payment, without any further sepcification on the type, amount or purpose."</para>
    /// labels<para>"payment"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/PAYMENT">https://w3id.org/idsa/code/PAYMENT</seealso>
    let PAYMENT = Prefixed_Name(idsc, "PAYMENT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/PAY_AMOUNT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/LeftOperand</para>
    ///   <para>"Monetary amount to pay, usually used with idsc:EQ. Datatype is double. Currency required."</para>
    /// labels<para>"payAmount"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/PAY_AMOUNT">https://w3id.org/idsa/code/PAY_AMOUNT</seealso>
    let PAY_AMOUNT = Prefixed_Name(idsc, "PAY_AMOUNT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/PI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Pāli"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/PI">https://w3id.org/idsa/code/PI</seealso>
    let PI = Prefixed_Name(idsc, "PI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/PL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Polish"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/PL">https://w3id.org/idsa/code/PL</seealso>
    let PL = Prefixed_Name(idsc, "PL") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/POLICY_EVALUATION_TIME</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/LeftOperand</para>
    ///   <para>"The current system time (as UTC xsd:dateTimeStamp) for evaluating a time-related constraint. Allowed operators are idsc:AFTER, idsc:BEFORE, idsc:CONTAINS, idsc:TEMPORAL_DISJOINT, idsc:DURING, idsc:TEMPORAL_EQUALS, idsc:FINISHED_BY, idsc:FINISHES, idsc:MEETS, idsc:MET_BY, idsc:OVERLAPS, idsc:OVERLAPPED_BY, idsc:STARTS, idsc:STARTED_BY and idsc:DURATION_EQ with RightOperand ids:TemporalEntity."</para>
    /// labels<para>"policy evaluation time"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/POLICY_EVALUATION_TIME">https://w3id.org/idsa/code/POLICY_EVALUATION_TIME</seealso>
    let POLICY_EVALUATION_TIME =
        Prefixed_Name(idsc, "POLICY_EVALUATION_TIME") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/PROCESS_ENDPOINT</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/AppEndpointType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Endpoint is used to start (or control) app processing."</para>
    /// labels<para>"Process endpoint"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/PROCESS_ENDPOINT">https://w3id.org/idsa/code/PROCESS_ENDPOINT</seealso>
    let PROCESS_ENDPOINT = Prefixed_Name(idsc, "PROCESS_ENDPOINT") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/PRODUCTIVE_DEPLOYMENT</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/ConnectorDeployMode</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Indicates that a Connector is deployed for productive use."</para>
    /// labels<para>"Productive Deployment"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/PRODUCTIVE_DEPLOYMENT">https://w3id.org/idsa/code/PRODUCTIVE_DEPLOYMENT</seealso>
    let PRODUCTIVE_DEPLOYMENT =
        Prefixed_Name(idsc, "PRODUCTIVE_DEPLOYMENT") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/PS</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Pashto, Pushto"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/PS">https://w3id.org/idsa/code/PS</seealso>
    let PS = Prefixed_Name(idsc, "PS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/PSEUDONYMIZED</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/ArtifactState</para>
    ///   <para>"The artifact is pseudo pseudonymized."</para>
    /// labels<para>"is pseudonymized"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/PSEUDONYMIZED">https://w3id.org/idsa/code/PSEUDONYMIZED</seealso>
    let PSEUDONYMIZED = Prefixed_Name(idsc, "PSEUDONYMIZED") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/PT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Portuguese"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/PT">https://w3id.org/idsa/code/PT</seealso>
    let PT = Prefixed_Name(idsc, "PT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/PURPOSE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/LeftOperand</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A defined purpose for exercising the action of the Rule. Use with idsc:IN or idsc:SAME_AS and RDF Resources."</para>
    /// labels<para>"purpose"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/PURPOSE">https://w3id.org/idsa/code/PURPOSE</seealso>
    let PURPOSE = Prefixed_Name(idsc, "PURPOSE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/QU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Quechua"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/QU">https://w3id.org/idsa/code/QU</seealso>
    let QU = Prefixed_Name(idsc, "QU") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/QUANTITY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/LeftOperand</para>
    ///   <para>"Quantity limitation for exercising the action of the Rule. Operators can be idsc:LT, idsc:LTEQ, idsc:EQ, idsc:GT, idsc:GTEQ. Datatype is xsd:double."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"quantity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/QUANTITY">https://w3id.org/idsa/code/QUANTITY</seealso>
    let QUANTITY = Prefixed_Name(idsc, "QUANTITY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/QUARTERLY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:idsa/core/Frequency</para>
    ///   <para>"The event occurs every three months."</para>
    /// labels<para>"Quarterly"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/QUARTERLY">https://w3id.org/idsa/code/QUARTERLY</seealso>
    let QUARTERLY = Prefixed_Name(idsc, "QUARTERLY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/READ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Action</para>
    ///   <para>"To obtain data from the resource."</para>
    /// labels<para>"read"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/READ">https://w3id.org/idsa/code/READ</seealso>
    let READ = Prefixed_Name(idsc, "READ") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/RECURRENCE_RATE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/LeftOperand</para>
    ///   <para>"The limit how often exercising the action of the Rule may be possible. Operators can be idsc:LT, idsc:LTEQ, idsc:EQ, idsc:GT, idsc:GTEQ. Datatype is xsd:double."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"recurrence rate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/RECURRENCE_RATE">https://w3id.org/idsa/code/RECURRENCE_RATE</seealso>
    let RECURRENCE_RATE = Prefixed_Name(idsc, "RECURRENCE_RATE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/RM</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Romansh"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/RM">https://w3id.org/idsa/code/RM</seealso>
    let RM = Prefixed_Name(idsc, "RM") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/RN</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Kirundi"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/RN">https://w3id.org/idsa/code/RN</seealso>
    let RN = Prefixed_Name(idsc, "RN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/RO</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Romanian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/RO">https://w3id.org/idsa/code/RO</seealso>
    let RO = Prefixed_Name(idsc, "RO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/RSA</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/KeyType</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"RSA"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/RSA">https://w3id.org/idsa/code/RSA</seealso>
    let RSA = Prefixed_Name(idsc, "RSA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/RU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Russian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/RU">https://w3id.org/idsa/code/RU</seealso>
    let RU = Prefixed_Name(idsc, "RU") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/RW</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Kinyarwanda"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/RW">https://w3id.org/idsa/code/RW</seealso>
    let RW = Prefixed_Name(idsc, "RW") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/RequestTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/PolicyTemplate</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A generic template for policy requests with one permission and several constraints"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Policy Request Template"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/RequestTemplate">https://w3id.org/idsa/code/RequestTemplate</seealso>
    let RequestTemplate = Prefixed_Name(idsc, "RequestTemplate") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SA</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Sanskrit (Saṁskṛta)"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SA">https://w3id.org/idsa/code/SA</seealso>
    let SA = Prefixed_Name(idsc, "SA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SAME_AS</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Logical equals operator comparing two RDF URIs. Is true if at least one owl:sameAs relation exists."</para>
    /// labels<para>"is same as"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SAME_AS">https://w3id.org/idsa/code/SAME_AS</seealso>
    let SAME_AS = Prefixed_Name(idsc, "SAME_AS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SAML_1_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/TokenFormat</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Security Assertion Markup Language (SAML) 1.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SAML_1_1">https://w3id.org/idsa/code/SAML_1_1</seealso>
    let SAML_1_1 = Prefixed_Name(idsc, "SAML_1_1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SAML_2_0</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/TokenFormat</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Security Assertion Markup Language (SAML) 2.0"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SAML_2_0">https://w3id.org/idsa/code/SAML_2_0</seealso>
    let SAML_2_0 = Prefixed_Name(idsc, "SAML_2_0") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SC</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Sardinian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SC">https://w3id.org/idsa/code/SC</seealso>
    let SC = Prefixed_Name(idsc, "SC") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SCHEMA_DEFINITION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/ContentType</para>
    ///   <para>"Formal, machine-interpretable definition of a data schema, e.g. XMLSchema, JSONSchema"</para>
    /// labels<para>"Schema definition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SCHEMA_DEFINITION">https://w3id.org/idsa/code/SCHEMA_DEFINITION</seealso>
    let SCHEMA_DEFINITION = Prefixed_Name(idsc, "SCHEMA_DEFINITION") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SD</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Sindhi"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SD">https://w3id.org/idsa/code/SD</seealso>
    let SD = Prefixed_Name(idsc, "SD") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Northern Sami"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SE">https://w3id.org/idsa/code/SE</seealso>
    let SE = Prefixed_Name(idsc, "SE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SECURITY_LEVEL</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/LeftOperand</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The security level the consuming connector must have. Use together with idsc:SAME_AS or idsc:IN. The value decides which attribute dimension is regarded."</para>
    /// labels<para>"security level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SECURITY_LEVEL">https://w3id.org/idsa/code/SECURITY_LEVEL</seealso>
    let SECURITY_LEVEL = Prefixed_Name(idsc, "SECURITY_LEVEL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SEMIANNUAL</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Frequency</para>
    ///   <para>"The event occurs twice a year."</para>
    /// labels<para>"Semiannual"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SEMIANNUAL">https://w3id.org/idsa/code/SEMIANNUAL</seealso>
    let SEMIANNUAL = Prefixed_Name(idsc, "SEMIANNUAL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SEMIMONTHLY</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Frequency</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"The event occurs twice a month."</para>
    /// labels<para>"Semimonthly"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SEMIMONTHLY">https://w3id.org/idsa/code/SEMIMONTHLY</seealso>
    let SEMIMONTHLY = Prefixed_Name(idsc, "SEMIMONTHLY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SEMIWEEKLY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Frequency</para>
    ///   <para>skos:Concept</para>
    ///   <para>"The event occurs twice a week."</para>
    /// labels<para>"Semiweekly"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SEMIWEEKLY">https://w3id.org/idsa/code/SEMIWEEKLY</seealso>
    let SEMIWEEKLY = Prefixed_Name(idsc, "SEMIWEEKLY") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/SERVICE_ISOLATION_LEAST_PRIVILEGE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/ServiceIsolationGuarantee</para>
    ///
    /// labels<para>"Service Isolation Least Privilege"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SERVICE_ISOLATION_LEAST_PRIVILEGE">https://w3id.org/idsa/code/SERVICE_ISOLATION_LEAST_PRIVILEGE</seealso>
    let SERVICE_ISOLATION_LEAST_PRIVILEGE =
        Prefixed_Name(idsc, "SERVICE_ISOLATION_LEAST_PRIVILEGE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/SERVICE_ISOLATION_NONE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/ServiceIsolationGuarantee</para>
    ///
    /// labels<para>"Service Isolation None"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SERVICE_ISOLATION_NONE">https://w3id.org/idsa/code/SERVICE_ISOLATION_NONE</seealso>
    let SERVICE_ISOLATION_NONE =
        Prefixed_Name(idsc, "SERVICE_ISOLATION_NONE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/SERVICE_ISOLATION_PROCESS_GROUP</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/ServiceIsolationGuarantee</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Service Isolation Process Group"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SERVICE_ISOLATION_PROCESS_GROUP">https://w3id.org/idsa/code/SERVICE_ISOLATION_PROCESS_GROUP</seealso>
    let SERVICE_ISOLATION_PROCESS_GROUP =
        Prefixed_Name(idsc, "SERVICE_ISOLATION_PROCESS_GROUP") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/SG</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Sango"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SG">https://w3id.org/idsa/code/SG</seealso>
    let SG = Prefixed_Name(idsc, "SG") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SHORTER</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"If a temporal entity T1 is shorter than another temporal entity T2, then the length or duration of T1 is shorter. Instants and xsd:dateTimeStamp Literals have always the duration 'P0Y0M0DT0H0M0S'^^xsd:duration and therefore have always the same duration."</para>
    /// labels<para>"shorter"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SHORTER">https://w3id.org/idsa/code/SHORTER</seealso>
    let SHORTER = Prefixed_Name(idsc, "SHORTER") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SHORTER_EQ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"If a temporal entity T1 is shorter or equals than another temporal entity T2, then the length or duration of T1 is shorter or their length or their duration is equal. Instants and xsd:dateTimeStamp Literals have always the duration 'P0Y0M0DT0H0M0S'^^xsd:duration and therefore have always the same duration."</para>
    /// labels<para>"shorter or equals"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SHORTER_EQ">https://w3id.org/idsa/code/SHORTER_EQ</seealso>
    let SHORTER_EQ = Prefixed_Name(idsc, "SHORTER_EQ") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Sinhalese, Sinhala"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SI">https://w3id.org/idsa/code/SI</seealso>
    let SI = Prefixed_Name(idsc, "SI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SK</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Slovak"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SK">https://w3id.org/idsa/code/SK</seealso>
    let SK = Prefixed_Name(idsc, "SK") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Slovene"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SL">https://w3id.org/idsa/code/SL</seealso>
    let SL = Prefixed_Name(idsc, "SL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Samoan"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SM">https://w3id.org/idsa/code/SM</seealso>
    let SM = Prefixed_Name(idsc, "SM") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Shona"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SN">https://w3id.org/idsa/code/SN</seealso>
    let SN = Prefixed_Name(idsc, "SN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Somali"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SO">https://w3id.org/idsa/code/SO</seealso>
    let SO = Prefixed_Name(idsc, "SO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SPARQL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/QueryLanguage</para>
    ///
    /// labels<para>"SPARQL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SPARQL">https://w3id.org/idsa/code/SPARQL</seealso>
    let SPARQL = Prefixed_Name(idsc, "SPARQL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SPATIAL_CONTAINS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"Spatial operator 'contains' as defined by the Egenhofer Topological Relations family: An object A contains another object B if A and B share interior but no bounding faces; if B has bounding faces which are interior faces of , and none of A's bounding faces coincides with any of B's interior faces. (https://doi.org/10.1007/3-540-51295-0_148 Definition 5)"</para>
    /// labels<para>"contains"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SPATIAL_CONTAINS">https://w3id.org/idsa/code/SPATIAL_CONTAINS</seealso>
    let SPATIAL_CONTAINS = Prefixed_Name(idsc, "SPATIAL_CONTAINS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SPATIAL_EQUALS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"Spatial operator 'equals' as defined by the Egenhofer Topological Relations family: Two objects are equal if both intersections of bounding and interior faces are not empty while the two boundary-interior intersections are empty. (https://doi.org/10.1007/3-540-51295-0_148 Definition 3)"</para>
    /// labels<para>"equals"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SPATIAL_EQUALS">https://w3id.org/idsa/code/SPATIAL_EQUALS</seealso>
    let SPATIAL_EQUALS = Prefixed_Name(idsc, "SPATIAL_EQUALS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SPATIAL_MEET</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"Spatial operator 'meet' as defined by the Egenhofer Topological Relations family: If the intersection among the bounding faces is not empty, whereas all other 3 intersections are empty, then the two objects meet. (https://doi.org/10.1007/3-540-51295-0_148 Definition 2)"</para>
    /// labels<para>"meet"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SPATIAL_MEET">https://w3id.org/idsa/code/SPATIAL_MEET</seealso>
    let SPATIAL_MEET = Prefixed_Name(idsc, "SPATIAL_MEET") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SPATIAL_OVERLAP</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Spatial operator 'overlap' as defined by the Egenhofer Topological Relations family: Two objects overlap if they have common interior faces and the bounding faces have common parts with the opposite interior faces. (https://doi.org/10.1007/3-540-51295-0_148 Definition 8)"</para>
    /// labels<para>"overlap"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SPATIAL_OVERLAP">https://w3id.org/idsa/code/SPATIAL_OVERLAP</seealso>
    let SPATIAL_OVERLAP = Prefixed_Name(idsc, "SPATIAL_OVERLAP") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SQ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Albanian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SQ">https://w3id.org/idsa/code/SQ</seealso>
    let SQ = Prefixed_Name(idsc, "SQ") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SQL</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/QueryLanguage</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"SQL"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SQL">https://w3id.org/idsa/code/SQL</seealso>
    let SQL = Prefixed_Name(idsc, "SQL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SR</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Serbian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SR">https://w3id.org/idsa/code/SR</seealso>
    let SR = Prefixed_Name(idsc, "SR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Swati"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SS">https://w3id.org/idsa/code/SS</seealso>
    let SS = Prefixed_Name(idsc, "SS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/ST</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Southern Sotho"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/ST">https://w3id.org/idsa/code/ST</seealso>
    let ST = Prefixed_Name(idsc, "ST") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/STARTED_BY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"If a TemporalEntity T1 is started by another proper interval T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is after the end of T2."</para>
    /// labels<para>"started by"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/STARTED_BY">https://w3id.org/idsa/code/STARTED_BY</seealso>
    let STARTED_BY = Prefixed_Name(idsc, "STARTED_BY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/STARTS</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"If an interval T1 starts with a TemporalEntity T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is before the end of T2."</para>
    /// labels<para>"starts"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/STARTS">https://w3id.org/idsa/code/STARTS</seealso>
    let STARTS = Prefixed_Name(idsc, "STARTS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/STATE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/LeftOperand</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Specifies whether an (external) resource is true/false, active/inactive, has happened/not happened, etc. Operator must be idsc:EQUALS with RightOperands of datatype xsd:anyURI. The referenced URI should point to a (remote) resource which returns a xsd:boolean value."</para>
    /// labels<para>"state"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/STATE">https://w3id.org/idsa/code/STATE</seealso>
    let STATE = Prefixed_Name(idsc, "STATE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/STATUS_ENDPOINT</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/AppEndpointType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Endpoint is used to get app health / lifecycle status."</para>
    /// labels<para>"Status endpoint"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/STATUS_ENDPOINT">https://w3id.org/idsa/code/STATUS_ENDPOINT</seealso>
    let STATUS_ENDPOINT = Prefixed_Name(idsc, "STATUS_ENDPOINT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/STRING_CONTAINS</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Contains operator for strings. Evaluates to true iff the LeftOperand contains the complete RightOperand."</para>
    /// labels<para>"string contains"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/STRING_CONTAINS">https://w3id.org/idsa/code/STRING_CONTAINS</seealso>
    let STRING_CONTAINS = Prefixed_Name(idsc, "STRING_CONTAINS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/STRING_EQ</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Equals operator for strings. Evaluates to true iff all characters and their sequence is the same."</para>
    /// labels<para>"string equals"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/STRING_EQ">https://w3id.org/idsa/code/STRING_EQ</seealso>
    let STRING_EQ = Prefixed_Name(idsc, "STRING_EQ") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/STRING_IS_CONTAINED</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"Contained in operator for strings. Evaluates to true iff the LeftOperand is contained completely by the RightOperand."</para>
    /// labels<para>"string is contained in"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/STRING_IS_CONTAINED">https://w3id.org/idsa/code/STRING_IS_CONTAINED</seealso>
    let STRING_IS_CONTAINED = Prefixed_Name(idsc, "STRING_IS_CONTAINED") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Sundanese"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SU">https://w3id.org/idsa/code/SU</seealso>
    let SU = Prefixed_Name(idsc, "SU") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SV</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Swedish"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SV">https://w3id.org/idsa/code/SV</seealso>
    let SV = Prefixed_Name(idsc, "SV") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SW</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Swahili"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SW">https://w3id.org/idsa/code/SW</seealso>
    let SW = Prefixed_Name(idsc, "SW") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SWT</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/TokenFormat</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Simple Web Token"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SWT">https://w3id.org/idsa/code/SWT</seealso>
    let SWT = Prefixed_Name(idsc, "SWT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/SYSTEM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/LeftOperand</para>
    ///   <para>"Execution system or execution environment that is used to access the asset under consideration, usually an IDS Connector. The regarded data object should correspond to the IDS Connector class and its attributes. Must be used together with idsc:SAME_AS, idsc:NOT, idsc:HAS_STATE, idsc:IN, idsc:COVERED_BY idsc:INSIDE, idsc:SPATIAL_EQUALS, idsc:DISJOINT, or idsc:INSIDE_NETWORK operators. RightOperandReference must be a URI identifying the target system(s)."</para>
    /// labels<para>"execution system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/SYSTEM">https://w3id.org/idsa/code/SYSTEM</seealso>
    let SYSTEM = Prefixed_Name(idsc, "SYSTEM") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/TA</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Tamil"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TA">https://w3id.org/idsa/code/TA</seealso>
    let TA = Prefixed_Name(idsc, "TA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/TE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Telugu"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TE">https://w3id.org/idsa/code/TE</seealso>
    let TE = Prefixed_Name(idsc, "TE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/TEMPORAL_DISJOINT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"If a TemporalEntity (or xsd:dateTimeStamp) T1 is disjoint with another ids:TemporalEntity (or xsd:dateTimeStamp) T2, then T1 is idsc:BEFORE or idsc:AFTER to T2."</para>
    /// labels<para>"disjoint"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TEMPORAL_DISJOINT">https://w3id.org/idsa/code/TEMPORAL_DISJOINT</seealso>
    let TEMPORAL_DISJOINT = Prefixed_Name(idsc, "TEMPORAL_DISJOINT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/TEMPORAL_EQUALS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/BinaryOperator</para>
    ///   <para>"If a TemporalEntity (or xsd:dateTimeStamp Literal) T1 is equals another TemporalEntity (or xsd:dateTimeStamp Literal) T2, then the beginning of T1 is coincident with the beginning of T2, and the end of T1 is coincident with the end of T2. The beginning and ending is the same for instances of ids:Instant (or xsd:dateTimeStamp Literal)."</para>
    /// labels<para>"interval equals"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TEMPORAL_EQUALS">https://w3id.org/idsa/code/TEMPORAL_EQUALS</seealso>
    let TEMPORAL_EQUALS = Prefixed_Name(idsc, "TEMPORAL_EQUALS") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/TEMPORARILY_NOT_AVAILABLE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/RejectionReason</para>
    ///   <para>"The requested resource, representation or artifact is temporarily not available but might be back later."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TEMPORARILY_NOT_AVAILABLE"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TEMPORARILY_NOT_AVAILABLE">https://w3id.org/idsa/code/TEMPORARILY_NOT_AVAILABLE</seealso>
    let TEMPORARILY_NOT_AVAILABLE =
        Prefixed_Name(idsc, "TEMPORARILY_NOT_AVAILABLE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/TEST_DEPLOYMENT</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/ConnectorDeployMode</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Indicates that a Connector is deployed for testing."</para>
    /// labels<para>"Test Deployment"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TEST_DEPLOYMENT">https://w3id.org/idsa/code/TEST_DEPLOYMENT</seealso>
    let TEST_DEPLOYMENT = Prefixed_Name(idsc, "TEST_DEPLOYMENT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/TG</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Tajik"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TG">https://w3id.org/idsa/code/TG</seealso>
    let TG = Prefixed_Name(idsc, "TG") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/TH</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Thai"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TH">https://w3id.org/idsa/code/TH</seealso>
    let TH = Prefixed_Name(idsc, "TH") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/THREE_TIMES_A_MONTH</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Frequency</para>
    ///   <para>"The event occurs three times a month."</para>
    /// labels<para>"Three times a month"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/THREE_TIMES_A_MONTH">https://w3id.org/idsa/code/THREE_TIMES_A_MONTH</seealso>
    let THREE_TIMES_A_MONTH = Prefixed_Name(idsc, "THREE_TIMES_A_MONTH") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/THREE_TIMES_A_WEEK</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Frequency</para>
    ///   <para>"The event occurs three times a week."</para>
    /// labels<para>"Three times a week"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/THREE_TIMES_A_WEEK">https://w3id.org/idsa/code/THREE_TIMES_A_WEEK</seealso>
    let THREE_TIMES_A_WEEK = Prefixed_Name(idsc, "THREE_TIMES_A_WEEK") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/THREE_TIMES_A_YEAR</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Frequency</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>"The event occurs three times a year."</para>
    /// labels<para>"Three times a year"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/THREE_TIMES_A_YEAR">https://w3id.org/idsa/code/THREE_TIMES_A_YEAR</seealso>
    let THREE_TIMES_A_YEAR = Prefixed_Name(idsc, "THREE_TIMES_A_YEAR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/TI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Tigrinya"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TI">https://w3id.org/idsa/code/TI</seealso>
    let TI = Prefixed_Name(idsc, "TI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/TK</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Turkmen"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TK">https://w3id.org/idsa/code/TK</seealso>
    let TK = Prefixed_Name(idsc, "TK") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/TL</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Tagalog"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TL">https://w3id.org/idsa/code/TL</seealso>
    let TL = Prefixed_Name(idsc, "TL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/TN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Tswana"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TN">https://w3id.org/idsa/code/TN</seealso>
    let TN = Prefixed_Name(idsc, "TN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/TO</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Tonga (Tonga Islands)"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TO">https://w3id.org/idsa/code/TO</seealso>
    let TO = Prefixed_Name(idsc, "TO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/TOO_MANY_RESULTS</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/RejectionReason</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Processing of the command would lead to too many results (computational or bandwidth limitations)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TOO_MANY_RESULTS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TOO_MANY_RESULTS">https://w3id.org/idsa/code/TOO_MANY_RESULTS</seealso>
    let TOO_MANY_RESULTS = Prefixed_Name(idsc, "TOO_MANY_RESULTS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/TR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Turkish"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TR">https://w3id.org/idsa/code/TR</seealso>
    let TR = Prefixed_Name(idsc, "TR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/TRACK_PROVENANCE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Action</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"To accept that the use of the Asset may be tracked."</para>
    /// labels<para>"track provenance"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TRACK_PROVENANCE">https://w3id.org/idsa/code/TRACK_PROVENANCE</seealso>
    let TRACK_PROVENANCE = Prefixed_Name(idsc, "TRACK_PROVENANCE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/TRIENNIAL</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Frequency</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The event occurs every three years."</para>
    /// labels<para>"Triennial"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TRIENNIAL">https://w3id.org/idsa/code/TRIENNIAL</seealso>
    let TRIENNIAL = Prefixed_Name(idsc, "TRIENNIAL") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/TRUST_PLUS_SECURITY_PROFILE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/SecurityProfile</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Security Profile TRUST+ as defined by the IDS certification criteria."</para>
    /// labels<para>"Trust Plus security profile"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TRUST_PLUS_SECURITY_PROFILE">https://w3id.org/idsa/code/TRUST_PLUS_SECURITY_PROFILE</seealso>
    let TRUST_PLUS_SECURITY_PROFILE =
        Prefixed_Name(idsc, "TRUST_PLUS_SECURITY_PROFILE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/TRUST_SECURITY_PROFILE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/SecurityProfile</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The Security Profile TRUST as defined by the IDS certification criteria."</para>
    /// labels<para>"Trust security profile"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TRUST_SECURITY_PROFILE">https://w3id.org/idsa/code/TRUST_SECURITY_PROFILE</seealso>
    let TRUST_SECURITY_PROFILE =
        Prefixed_Name(idsc, "TRUST_SECURITY_PROFILE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/TS</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Tsonga"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TS">https://w3id.org/idsa/code/TS</seealso>
    let TS = Prefixed_Name(idsc, "TS") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/TT</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Tatar"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TT">https://w3id.org/idsa/code/TT</seealso>
    let TT = Prefixed_Name(idsc, "TT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/TW</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Twi"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TW">https://w3id.org/idsa/code/TW</seealso>
    let TW = Prefixed_Name(idsc, "TW") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/TY</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Tahitian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/TY">https://w3id.org/idsa/code/TY</seealso>
    let TY = Prefixed_Name(idsc, "TY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/UG</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Uyghur"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/UG">https://w3id.org/idsa/code/UG</seealso>
    let UG = Prefixed_Name(idsc, "UG") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/UK</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Ukrainian"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/UK">https://w3id.org/idsa/code/UK</seealso>
    let UK = Prefixed_Name(idsc, "UK") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/UNKNOWN</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/TokenFormat</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Unknown"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/UNKNOWN">https://w3id.org/idsa/code/UNKNOWN</seealso>
    let UNKNOWN = Prefixed_Name(idsc, "UNKNOWN") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/UR</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Urdu"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/UR">https://w3id.org/idsa/code/UR</seealso>
    let UR = Prefixed_Name(idsc, "UR") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/USAGE_CONTROL_NONE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/UsageControlGuarantee</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Usage Control None"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/USAGE_CONTROL_NONE">https://w3id.org/idsa/code/USAGE_CONTROL_NONE</seealso>
    let USAGE_CONTROL_NONE = Prefixed_Name(idsc, "USAGE_CONTROL_NONE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/USAGE_CONTROL_POLICY_ENFORCEMENT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/UsageControlGuarantee</para>
    ///
    /// labels<para>"Usage Control Policy Enforcement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/USAGE_CONTROL_POLICY_ENFORCEMENT">https://w3id.org/idsa/code/USAGE_CONTROL_POLICY_ENFORCEMENT</seealso>
    let USAGE_CONTROL_POLICY_ENFORCEMENT =
        Prefixed_Name(idsc, "USAGE_CONTROL_POLICY_ENFORCEMENT") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/USAGE_CONTROL_REMOTE_COMPLIANCE_VERIFICATION</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/UsageControlGuarantee</para>
    ///
    /// labels<para>"Usage Control Remote Compliance Verification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/USAGE_CONTROL_REMOTE_COMPLIANCE_VERIFICATION">https://w3id.org/idsa/code/USAGE_CONTROL_REMOTE_COMPLIANCE_VERIFICATION</seealso>
    let USAGE_CONTROL_REMOTE_COMPLIANCE_VERIFICATION =
        Prefixed_Name(idsc, "USAGE_CONTROL_REMOTE_COMPLIANCE_VERIFICATION") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/USE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Action</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"To use a resource in any possible way. Includes all other actions."</para>
    /// labels<para>"use"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/USE">https://w3id.org/idsa/code/USE</seealso>
    let USE = Prefixed_Name(idsc, "USE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/USER</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/LeftOperand</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The user of a system at the *consuming connector* requesting access to a resource. Recommended usage for checking whether the user's role is sufficient for his/her desired action. Allowed operators are idsc:MEMBER_OF, idsc:HAS_MEMBERSHIP, idsc:HAS_SITE with a RightOperand referencing a (set of) acceptable organisations (ids:Participant),memberships, sites. Preferred behaviour is that the RightOperand dereferences to an endpoint hosting the required role information."</para>
    /// labels<para>"user"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/USER">https://w3id.org/idsa/code/USER</seealso>
    let USER = Prefixed_Name(idsc, "USER") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/UZ</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Uzbek"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/UZ">https://w3id.org/idsa/code/UZ</seealso>
    let UZ = Prefixed_Name(idsc, "UZ") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/VE</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Venda"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/VE">https://w3id.org/idsa/code/VE</seealso>
    let VE = Prefixed_Name(idsc, "VE") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/VERSION_NOT_SUPPORTED</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/RejectionReason</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The version of the information model against which the referenced message should be interpreted, is not supported by the recipient."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"VERSION_NOT_SUPPORTED"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/VERSION_NOT_SUPPORTED">https://w3id.org/idsa/code/VERSION_NOT_SUPPORTED</seealso>
    let VERSION_NOT_SUPPORTED =
        Prefixed_Name(idsc, "VERSION_NOT_SUPPORTED") |> PrefixedName

    /// <summary>
    ///   <para>w3id:idsa/code/VI</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Vietnamese"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/VI">https://w3id.org/idsa/code/VI</seealso>
    let VI = Prefixed_Name(idsc, "VI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/VO</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Volapük"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/VO">https://w3id.org/idsa/code/VO</seealso>
    let VO = Prefixed_Name(idsc, "VO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/WA</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Walloon"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/WA">https://w3id.org/idsa/code/WA</seealso>
    let WA = Prefixed_Name(idsc, "WA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/WEEKLY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>skos:Concept</para>
    ///   <para>w3id:idsa/core/Frequency</para>
    ///   <para>"The event occurs once a week."</para>
    /// labels<para>"Weekly"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/WEEKLY">https://w3id.org/idsa/code/WEEKLY</seealso>
    let WEEKLY = Prefixed_Name(idsc, "WEEKLY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/WO</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Wolof"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/WO">https://w3id.org/idsa/code/WO</seealso>
    let WO = Prefixed_Name(idsc, "WO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/WRITE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Action</para>
    ///   <para>"To change a remote resource."</para>
    /// labels<para>"write"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/WRITE">https://w3id.org/idsa/code/WRITE</seealso>
    let WRITE = Prefixed_Name(idsc, "WRITE") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/XH</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Xhosa"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/XH">https://w3id.org/idsa/code/XH</seealso>
    let XH = Prefixed_Name(idsc, "XH") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/XQUERY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/QueryLanguage</para>
    ///
    /// labels<para>"XQUERY"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/XQUERY">https://w3id.org/idsa/code/XQUERY</seealso>
    let XQUERY = Prefixed_Name(idsc, "XQUERY") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/YI</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Yiddish"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/YI">https://w3id.org/idsa/code/YI</seealso>
    let YI = Prefixed_Name(idsc, "YI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/YO</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Yoruba"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/YO">https://w3id.org/idsa/code/YO</seealso>
    let YO = Prefixed_Name(idsc, "YO") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/ZA</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Zhuang, Chuang"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/ZA">https://w3id.org/idsa/code/ZA</seealso>
    let ZA = Prefixed_Name(idsc, "ZA") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/ZH</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:idsa/core/Language</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Chinese"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/ZH">https://w3id.org/idsa/code/ZH</seealso>
    let ZH = Prefixed_Name(idsc, "ZH") |> PrefixedName
    /// <summary>
    ///   <para>w3id:idsa/code/ZU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:idsa/core/Language</para>
    ///
    /// labels<para>"Zulu"</para></remarks>
    /// <seealso href="https://w3id.org/idsa/code/ZU">https://w3id.org/idsa/code/ZU</seealso>
    let ZU = Prefixed_Name(idsc, "ZU") |> PrefixedName
