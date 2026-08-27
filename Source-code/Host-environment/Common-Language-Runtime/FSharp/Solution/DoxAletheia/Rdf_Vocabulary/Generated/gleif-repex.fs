namespace https.www.gleif.org.ontology.ReportingException.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gleif_repex =
    let _namespace_iri = Namespace_Iri gleif_repex |> NamespaceIRI
    /// <summary>
    ///   <para>gleif-repex:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"GLEIF Reporting Exception Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/ReportingException/">https://www.gleif.org/ontology/ReportingException/</seealso>
    let _prefix_iri = Prefixed_Name(gleif_repex, "") |> PrefixedName

    /// <summary>
    ///   <para>gleif-repex:DirectConsolidationReportingException</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"direct consolidation reporting exception"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/ReportingException/DirectConsolidationReportingException">https://www.gleif.org/ontology/ReportingException/DirectConsolidationReportingException</seealso>
    let DirectConsolidationReportingException =
        Prefixed_Name(gleif_repex, "DirectConsolidationReportingException") |> PrefixedName

    /// <summary>
    ///   <para>gleif-repex:ExceptionReasonKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"exception reason"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKind">https://www.gleif.org/ontology/ReportingException/ExceptionReasonKind</seealso>
    let ExceptionReasonKind =
        Prefixed_Name(gleif_repex, "ExceptionReasonKind") |> PrefixedName

    /// <summary>
    ///   <para>gleif-repex:ExceptionReasonKindBindingLegalCommitments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-repex:ExceptionReasonKind</para>
    ///
    /// labels<para>"binding legal commitments"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindBindingLegalCommitments">https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindBindingLegalCommitments</seealso>
    let ExceptionReasonKindBindingLegalCommitments =
        Prefixed_Name(gleif_repex, "ExceptionReasonKindBindingLegalCommitments") |> PrefixedName

    /// <summary>
    ///   <para>gleif-repex:ExceptionReasonKindConsentNotObtained</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-repex:ExceptionReasonKind</para>
    ///
    /// labels<para>"consent not obtained"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindConsentNotObtained">https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindConsentNotObtained</seealso>
    let ExceptionReasonKindConsentNotObtained =
        Prefixed_Name(gleif_repex, "ExceptionReasonKindConsentNotObtained") |> PrefixedName

    /// <summary>
    ///   <para>gleif-repex:ExceptionReasonKindDetrimentNotExcluded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-repex:ExceptionReasonKind</para>
    ///
    /// labels<para>"detriment not excluded"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindDetrimentNotExcluded">https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindDetrimentNotExcluded</seealso>
    let ExceptionReasonKindDetrimentNotExcluded =
        Prefixed_Name(gleif_repex, "ExceptionReasonKindDetrimentNotExcluded") |> PrefixedName

    /// <summary>
    ///   <para>gleif-repex:ExceptionReasonKindDisclosureDetrimental</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-repex:ExceptionReasonKind</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"disclosure detrimental"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindDisclosureDetrimental">https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindDisclosureDetrimental</seealso>
    let ExceptionReasonKindDisclosureDetrimental =
        Prefixed_Name(gleif_repex, "ExceptionReasonKindDisclosureDetrimental") |> PrefixedName

    /// <summary>
    ///   <para>gleif-repex:ExceptionReasonKindLegalCommitments</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindLegalCommitments">https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindLegalCommitments</seealso>
    let ExceptionReasonKindLegalCommitments =
        Prefixed_Name(gleif_repex, "ExceptionReasonKindLegalCommitments") |> PrefixedName

    /// <summary>
    ///   <para>gleif-repex:ExceptionReasonKindLegalObstacles</para>
    /// </summary>
    /// <remarks>
    ///   <para>gleif-repex:ExceptionReasonKind</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"legal obstacles"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindLegalObstacles">https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindLegalObstacles</seealso>
    let ExceptionReasonKindLegalObstacles =
        Prefixed_Name(gleif_repex, "ExceptionReasonKindLegalObstacles") |> PrefixedName

    /// <summary>
    ///   <para>gleif-repex:ExceptionReasonKindNaturalPersons</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-repex:ExceptionReasonKind</para>
    ///
    /// labels<para>"natural persons"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindNaturalPersons">https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindNaturalPersons</seealso>
    let ExceptionReasonKindNaturalPersons =
        Prefixed_Name(gleif_repex, "ExceptionReasonKindNaturalPersons") |> PrefixedName

    /// <summary>
    ///   <para>gleif-repex:ExceptionReasonKindNoKnownPerson</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-repex:ExceptionReasonKind</para>
    ///
    /// labels<para>"no known person"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindNoKnownPerson">https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindNoKnownPerson</seealso>
    let ExceptionReasonKindNoKnownPerson =
        Prefixed_Name(gleif_repex, "ExceptionReasonKindNoKnownPerson") |> PrefixedName

    /// <summary>
    ///   <para>gleif-repex:ExceptionReasonKindNoLEI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-repex:ExceptionReasonKind</para>
    ///
    /// labels<para>"no LEI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindNoLEI">https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindNoLEI</seealso>
    let ExceptionReasonKindNoLEI =
        Prefixed_Name(gleif_repex, "ExceptionReasonKindNoLEI") |> PrefixedName

    /// <summary>
    ///   <para>gleif-repex:ExceptionReasonKindNonConsolidating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>gleif-repex:ExceptionReasonKind</para>
    ///
    /// labels<para>"non consolidating"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindNonConsolidating">https://www.gleif.org/ontology/ReportingException/ExceptionReasonKindNonConsolidating</seealso>
    let ExceptionReasonKindNonConsolidating =
        Prefixed_Name(gleif_repex, "ExceptionReasonKindNonConsolidating") |> PrefixedName

    /// <summary>
    ///   <para>gleif-repex:ReportingException</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"reporting exception"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/ReportingException/ReportingException">https://www.gleif.org/ontology/ReportingException/ReportingException</seealso>
    let ReportingException =
        Prefixed_Name(gleif_repex, "ReportingException") |> PrefixedName

    /// <summary>
    ///   <para>gleif-repex:UltimateConsolidationReportingException</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ultimate consolidation reporting exception"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/ReportingException/UltimateConsolidationReportingException">https://www.gleif.org/ontology/ReportingException/UltimateConsolidationReportingException</seealso>
    let UltimateConsolidationReportingException =
        Prefixed_Name(gleif_repex, "UltimateConsolidationReportingException") |> PrefixedName

    /// <summary>
    ///   <para>gleif-repex:hasExceptionReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has exception reason"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/ReportingException/hasExceptionReason">https://www.gleif.org/ontology/ReportingException/hasExceptionReason</seealso>
    let hasExceptionReason =
        Prefixed_Name(gleif_repex, "hasExceptionReason") |> PrefixedName

    /// <summary>
    ///   <para>gleif-repex:hasExceptionReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has exception reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/ReportingException/hasExceptionReference">https://www.gleif.org/ontology/ReportingException/hasExceptionReference</seealso>
    let hasExceptionReference =
        Prefixed_Name(gleif_repex, "hasExceptionReference") |> PrefixedName

    /// <summary>
    ///   <para>gleif-repex:hasReportingEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has reporting entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.gleif.org/ontology/ReportingException/hasReportingEntity">https://www.gleif.org/ontology/ReportingException/hasReportingEntity</seealso>
    let hasReportingEntity =
        Prefixed_Name(gleif_repex, "hasReportingEntity") |> PrefixedName
