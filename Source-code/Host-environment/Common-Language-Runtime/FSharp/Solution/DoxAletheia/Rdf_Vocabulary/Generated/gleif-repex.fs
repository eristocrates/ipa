namespace https.www.gleif.org.ontology.ReportingException.slash

open DoxAletheia

module gleif_repex =
    let _namespace_name = "https://www.gleif.org/ontology/ReportingException/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindNoLEI"></see>
    /// </summary>
    let ExceptionReasonKindNoLEI = _prefix "ExceptionReasonKindNoLEI"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindNaturalPersons"></see>
    /// </summary>
    let ExceptionReasonKindNaturalPersons = _prefix "ExceptionReasonKindNaturalPersons"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindNonConsolidating"></see>
    /// </summary>
    let ExceptionReasonKindNonConsolidating =
        _prefix "ExceptionReasonKindNonConsolidating"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindNoKnownPerson"></see>
    /// </summary>
    let ExceptionReasonKindNoKnownPerson = _prefix "ExceptionReasonKindNoKnownPerson"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindLegalObstacles"></see>
    /// </summary>
    let ExceptionReasonKindLegalObstacles = _prefix "ExceptionReasonKindLegalObstacles"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindConsentNotObtained"></see>
    /// </summary>
    let ExceptionReasonKindConsentNotObtained =
        _prefix "ExceptionReasonKindConsentNotObtained"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindLegalCommitments"></see>
    /// </summary>
    let ExceptionReasonKindLegalCommitments =
        _prefix "ExceptionReasonKindLegalCommitments"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindDetrimentNotExcluded"></see>
    /// </summary>
    let ExceptionReasonKindDetrimentNotExcluded =
        _prefix "ExceptionReasonKindDetrimentNotExcluded"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindDisclosureDetrimental"></see>
    /// </summary>
    let ExceptionReasonKindDisclosureDetrimental =
        _prefix "ExceptionReasonKindDisclosureDetrimental"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/DirectConsolidationReportingException"></see>
    /// </summary>
    let DirectConsolidationReportingException =
        _prefix "DirectConsolidationReportingException"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ReportingException"></see>
    /// </summary>
    let ReportingException = _prefix "ReportingException"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKind"></see>
    /// </summary>
    let ExceptionReasonKind = _prefix "ExceptionReasonKind"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindBindingLegalCommitments"></see>
    /// </summary>
    let ExceptionReasonKindBindingLegalCommitments =
        _prefix "ExceptionReasonKindBindingLegalCommitments"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/hasReportingEntity"></see>
    /// </summary>
    let hasReportingEntity = _prefix "hasReportingEntity"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/hasExceptionReason"></see>
    /// </summary>
    let hasExceptionReason = _prefix "hasExceptionReason"
    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/hasExceptionReference"></see>
    /// </summary>
    let hasExceptionReference = _prefix "hasExceptionReference"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/UltimateConsolidationReportingException"></see>
    /// </summary>
    let UltimateConsolidationReportingException =
        _prefix "UltimateConsolidationReportingException"
