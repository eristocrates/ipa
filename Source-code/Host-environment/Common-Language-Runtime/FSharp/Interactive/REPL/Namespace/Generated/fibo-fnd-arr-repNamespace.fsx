#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-arr-rep`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/" "fibo-fnd-arr-rep"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : report^^xsd:string</para>
    ///   <para>skos:definition : document that provides a structured description of something, prepared on ad hoc, periodic, recurring, regular, or as required basis^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Reports may refer to specific periods, events, occurrences, or subjects, and may be communicated or presented in oral, electronic, or written form.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/Report">fibo-fnd-arr-rep:Report</a>
    /// </summary>
    let Report = _prefixId.prefix "Report"
    /// <summary>
    ///   <para>rdfs:label : reporting party^^xsd:string</para>
    ///   <para>skos:definition : party providing a report, typically in response to some contractual, legal, regulatory or other business requirement^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/ReportingParty">fibo-fnd-arr-rep:ReportingParty</a>
    /// </summary>
    let ReportingParty = _prefixId.prefix "ReportingParty"
    /// <summary>
    ///   <para>rdfs:label : request^^xsd:string</para>
    ///   <para>skos:definition : event in which some party asks another party for something at some point in time^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/Request">fibo-fnd-arr-rep:Request</a>
    /// </summary>
    let Request = _prefixId.prefix "Request"
    /// <summary>
    ///   <para>rdfs:label : request activity^^xsd:string</para>
    ///   <para>skos:definition : activity in which some party asks another party for something or to do something^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/RequestActivity">fibo-fnd-arr-rep:RequestActivity</a>
    /// </summary>
    let RequestActivity = _prefixId.prefix "RequestActivity"
    /// <summary>
    ///   <para>rdfs:label : requester</para>
    ///   <para>skos:definition : party that asks for something</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/Requester">fibo-fnd-arr-rep:Requester</a>
    /// </summary>
    let Requester = _prefixId.prefix "Requester"
    /// <summary>
    ///   <para>rdfs:label : submitter^^xsd:string</para>
    ///   <para>skos:definition : party presenting something, such as a regulatory report^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/Submitter">fibo-fnd-arr-rep:Submitter</a>
    /// </summary>
    let Submitter = _prefixId.prefix "Submitter"
    /// <summary>
    ///   <para>rdfs:label : has report date</para>
    ///   <para>skos:definition : date on which a report was issued</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/hasReportDate">fibo-fnd-arr-rep:hasReportDate</a>
    /// </summary>
    let hasReportDate = _prefixId.prefix "hasReportDate"
    /// <summary>
    ///   <para>rdfs:label : has report date time</para>
    ///   <para>skos:definition : date and time at which a report was issued</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/hasReportDateTime">fibo-fnd-arr-rep:hasReportDateTime</a>
    /// </summary>
    let hasReportDateTime = _prefixId.prefix "hasReportDateTime"
    /// <summary>
    ///   <para>rdfs:label : has request date</para>
    ///   <para>skos:definition : date on which a request was made</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/hasRequestDate">fibo-fnd-arr-rep:hasRequestDate</a>
    /// </summary>
    let hasRequestDate = _prefixId.prefix "hasRequestDate"
    /// <summary>
    ///   <para>rdfs:label : has request date time</para>
    ///   <para>skos:definition : date and time at which a request was made</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/hasRequestDateTime">fibo-fnd-arr-rep:hasRequestDateTime</a>
    /// </summary>
    let hasRequestDateTime = _prefixId.prefix "hasRequestDateTime"
    /// <summary>
    ///   <para>rdfs:label : is reported to^^xsd:string</para>
    ///   <para>skos:definition : indicates the party to which something is reported^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isReportedTo">fibo-fnd-arr-rep:isReportedTo</a>
    /// </summary>
    let isReportedTo = _prefixId.prefix "isReportedTo"
    /// <summary>
    ///   <para>rdfs:label : is requested by^^xsd:string</para>
    ///   <para>skos:definition : indicates the party that asks for something^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isRequestedBy">fibo-fnd-arr-rep:isRequestedBy</a>
    /// </summary>
    let isRequestedBy = _prefixId.prefix "isRequestedBy"
    /// <summary>
    ///   <para>rdfs:label : is requested of^^xsd:string</para>
    ///   <para>skos:definition : indicates the party that is asked for something^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isRequestedOf">fibo-fnd-arr-rep:isRequestedOf</a>
    /// </summary>
    let isRequestedOf = _prefixId.prefix "isRequestedOf"
    /// <summary>
    ///   <para>rdfs:label : is submitted by^^xsd:string</para>
    ///   <para>skos:definition : indicates the party that submits something^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isSubmittedBy">fibo-fnd-arr-rep:isSubmittedBy</a>
    /// </summary>
    let isSubmittedBy = _prefixId.prefix "isSubmittedBy"
    /// <summary>
    ///   <para>rdfs:label : is submitted to^^xsd:string</para>
    ///   <para>skos:definition : indicates the party to which something is submitted^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/isSubmittedTo">fibo-fnd-arr-rep:isSubmittedTo</a>
    /// </summary>
    let isSubmittedTo = _prefixId.prefix "isSubmittedTo"
    /// <summary>
    ///   <para>rdfs:label : reports on^^xsd:string</para>
    ///   <para>skos:definition : indicates a subject matter, observation(s), assessment(s), focus or other topic of a report^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/reportsOn">fibo-fnd-arr-rep:reportsOn</a>
    /// </summary>
    let reportsOn = _prefixId.prefix "reportsOn"
    /// <summary>
    ///   <para>rdfs:label : requests^^xsd:string</para>
    ///   <para>skos:definition : asks for something^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/requests">fibo-fnd-arr-rep:requests</a>
    /// </summary>
    let requests = _prefixId.prefix "requests"
    /// <summary>
    ///   <para>rdfs:label : submits^^xsd:string</para>
    ///   <para>skos:definition : presents something (a proposal, application, report, or other document) for consideration or review^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/submits">fibo-fnd-arr-rep:submits</a>
    /// </summary>
    let submits = _prefixId.prefix "submits"
