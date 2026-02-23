namespace Fibo.FND.Arrangements.Reporting.Namespace
module Reporting =
    let _prefixID = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/" (Some @"https://spec.edmcouncil.org/fibo/ontology/master/latest/FND/Arrangements/Reporting.rdf") (Some @"fibo.FND.Arrangements.Reporting") None
    let Report = {_prefixID with _localName = "Report"}
    let ReportingParty = {_prefixID with _localName = "ReportingParty"}
    let Request = {_prefixID with _localName = "Request"}
    let RequestActivity = {_prefixID with _localName = "RequestActivity"}
    let Requester = {_prefixID with _localName = "Requester"}
    let Submitter = {_prefixID with _localName = "Submitter"}
    let hasReportDate = {_prefixID with _localName = "hasReportDate"}
    let hasReportDateTime = {_prefixID with _localName = "hasReportDateTime"}
    let hasRequestDate = {_prefixID with _localName = "hasRequestDate"}
    let hasRequestDateTime = {_prefixID with _localName = "hasRequestDateTime"}
    let isReportedTo = {_prefixID with _localName = "isReportedTo"}
    let isRequestedBy = {_prefixID with _localName = "isRequestedBy"}
    let isRequestedOf = {_prefixID with _localName = "isRequestedOf"}
    let isSubmittedBy = {_prefixID with _localName = "isSubmittedBy"}
    let isSubmittedTo = {_prefixID with _localName = "isSubmittedTo"}
    let reportsOn = {_prefixID with _localName = "reportsOn"}
    let requests = {_prefixID with _localName = "requests"}
    let submits = {_prefixID with _localName = "submits"}