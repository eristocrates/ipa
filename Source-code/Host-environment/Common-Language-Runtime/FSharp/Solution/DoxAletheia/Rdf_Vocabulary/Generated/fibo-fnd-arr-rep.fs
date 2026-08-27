namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.Reporting.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_arr_rep =
    let _namespace_iri = Namespace_Iri fibo_fnd_arr_rep |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-arr-rep:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Reporting Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_arr_rep, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-rep:Report</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"report"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/Report">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/Report</seealso>
    let Report = Prefixed_Name(fibo_fnd_arr_rep, "Report") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rep:ReportingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"reporting party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/ReportingParty">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/ReportingParty</seealso>
    let ReportingParty =
        Prefixed_Name(fibo_fnd_arr_rep, "ReportingParty") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rep:Request</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"request"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/Request">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/Request</seealso>
    let Request = Prefixed_Name(fibo_fnd_arr_rep, "Request") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rep:RequestActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"request activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/RequestActivity">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/RequestActivity</seealso>
    let RequestActivity =
        Prefixed_Name(fibo_fnd_arr_rep, "RequestActivity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rep:Requester</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"requester"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/Requester">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/Requester</seealso>
    let Requester = Prefixed_Name(fibo_fnd_arr_rep, "Requester") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-rep:Submitter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"submitter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/Submitter">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/Submitter</seealso>
    let Submitter = Prefixed_Name(fibo_fnd_arr_rep, "Submitter") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-rep:hasReportDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has report date"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/hasReportDate">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/hasReportDate</seealso>
    let hasReportDate = Prefixed_Name(fibo_fnd_arr_rep, "hasReportDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rep:hasReportDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has report date time"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/hasReportDateTime">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/hasReportDateTime</seealso>
    let hasReportDateTime =
        Prefixed_Name(fibo_fnd_arr_rep, "hasReportDateTime") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rep:hasRequestDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has request date"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/hasRequestDate">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/hasRequestDate</seealso>
    let hasRequestDate =
        Prefixed_Name(fibo_fnd_arr_rep, "hasRequestDate") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rep:hasRequestDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has request date time"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/hasRequestDateTime">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/hasRequestDateTime</seealso>
    let hasRequestDateTime =
        Prefixed_Name(fibo_fnd_arr_rep, "hasRequestDateTime") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rep:isReportedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is reported to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isReportedTo">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isReportedTo</seealso>
    let isReportedTo = Prefixed_Name(fibo_fnd_arr_rep, "isReportedTo") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-rep:isRequestedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is requested by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isRequestedBy">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isRequestedBy</seealso>
    let isRequestedBy = Prefixed_Name(fibo_fnd_arr_rep, "isRequestedBy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-rep:isRequestedOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is requested of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isRequestedOf">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isRequestedOf</seealso>
    let isRequestedOf = Prefixed_Name(fibo_fnd_arr_rep, "isRequestedOf") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-rep:isSubmittedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is submitted by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isSubmittedBy">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isSubmittedBy</seealso>
    let isSubmittedBy = Prefixed_Name(fibo_fnd_arr_rep, "isSubmittedBy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-rep:isSubmittedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is submitted to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isSubmittedTo">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isSubmittedTo</seealso>
    let isSubmittedTo = Prefixed_Name(fibo_fnd_arr_rep, "isSubmittedTo") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-rep:reportsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"reports on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/reportsOn">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/reportsOn</seealso>
    let reportsOn = Prefixed_Name(fibo_fnd_arr_rep, "reportsOn") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-rep:requests</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"requests"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/requests">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/requests</seealso>
    let requests = Prefixed_Name(fibo_fnd_arr_rep, "requests") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-rep:submits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"submits"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/submits">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/submits</seealso>
    let submits = Prefixed_Name(fibo_fnd_arr_rep, "submits") |> PrefixedName
