namespace https.www.gleif.org.ontology.ReportingException.slash

open DoxAletheia.Rdf_Vocabulary

module gleif_repex =
    let _namespace_name = "https://www.gleif.org/ontology/ReportingException/"

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindNoLEI"></see>
    /// </summary>
    let ExceptionReasonKindNoLEI =
        Namespaced_IRI.parse _namespace_name "ExceptionReasonKindNoLEI" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindNaturalPersons"></see>
    /// </summary>
    let ExceptionReasonKindNaturalPersons =
        Namespaced_IRI.parse _namespace_name "ExceptionReasonKindNaturalPersons" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindNonConsolidating"></see>
    /// </summary>
    let ExceptionReasonKindNonConsolidating =
        Namespaced_IRI.parse _namespace_name "ExceptionReasonKindNonConsolidating" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindNoKnownPerson"></see>
    /// </summary>
    let ExceptionReasonKindNoKnownPerson =
        Namespaced_IRI.parse _namespace_name "ExceptionReasonKindNoKnownPerson" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindLegalObstacles"></see>
    /// </summary>
    let ExceptionReasonKindLegalObstacles =
        Namespaced_IRI.parse _namespace_name "ExceptionReasonKindLegalObstacles" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindConsentNotObtained"></see>
    /// </summary>
    let ExceptionReasonKindConsentNotObtained =
        Namespaced_IRI.parse _namespace_name "ExceptionReasonKindConsentNotObtained" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindLegalCommitments"></see>
    /// </summary>
    let ExceptionReasonKindLegalCommitments =
        Namespaced_IRI.parse _namespace_name "ExceptionReasonKindLegalCommitments" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindDetrimentNotExcluded"></see>
    /// </summary>
    let ExceptionReasonKindDetrimentNotExcluded =
        Namespaced_IRI.parse _namespace_name "ExceptionReasonKindDetrimentNotExcluded" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindDisclosureDetrimental"></see>
    /// </summary>
    let ExceptionReasonKindDisclosureDetrimental =
        Namespaced_IRI.parse _namespace_name "ExceptionReasonKindDisclosureDetrimental" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/DirectConsolidationReportingException"></see>
    /// </summary>
    let DirectConsolidationReportingException =
        Namespaced_IRI.parse _namespace_name "DirectConsolidationReportingException" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ReportingException"></see>
    /// </summary>
    let ReportingException =
        Namespaced_IRI.parse _namespace_name "ReportingException" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKind"></see>
    /// </summary>
    let ExceptionReasonKind =
        Namespaced_IRI.parse _namespace_name "ExceptionReasonKind" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindBindingLegalCommitments"></see>
    /// </summary>
    let ExceptionReasonKindBindingLegalCommitments =
        Namespaced_IRI.parse _namespace_name "ExceptionReasonKindBindingLegalCommitments" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/hasReportingEntity"></see>
    /// </summary>
    let hasReportingEntity =
        Namespaced_IRI.parse _namespace_name "hasReportingEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/hasExceptionReason"></see>
    /// </summary>
    let hasExceptionReason =
        Namespaced_IRI.parse _namespace_name "hasExceptionReason" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/hasExceptionReference"></see>
    /// </summary>
    let hasExceptionReference =
        Namespaced_IRI.parse _namespace_name "hasExceptionReference" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.gleif.org/ontology/ReportingException/UltimateConsolidationReportingException"></see>
    /// </summary>
    let UltimateConsolidationReportingException =
        Namespaced_IRI.parse _namespace_name "UltimateConsolidationReportingException" |> NamespacedName
