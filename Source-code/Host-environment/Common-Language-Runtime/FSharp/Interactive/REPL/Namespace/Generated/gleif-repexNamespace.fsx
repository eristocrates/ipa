#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``gleif-repex`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://www.gleif.org/ontology/ReportingException/" "gleif-repex"

    let _namespaceIri = _prefixId.prefix ""

    /// <summary>
    ///   <para>gleif-base:hasTag : DIRECT_ACCOUNTING_CONSOLIDATION_PARENT^^xsd:string</para>
    ///   <para>skos:definition : The legal entity has declined to report a direct accounting consolidation parent, based on applicable accounting standards.^^xsd:string</para>
    ///   <para>rdfs:label : direct consolidation reporting exception^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/ReportingException/DirectConsolidationReportingException">gleif-repex:DirectConsolidationReportingException</a>
    /// </summary>
    let DirectConsolidationReportingException =
        _prefixId.prefix "DirectConsolidationReportingException"

    /// <summary>
    ///   <para>skos:definition : A single reason provided by the legal entity for declining to provide the mandatory report of a specified type of information (beyond the minimum reference data needed purely for identification of the legal entity). ^^xsd:string</para>
    ///   <para>rdfs:label : exception reason^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/ReportingException/ExceptionReasonKind">gleif-repex:ExceptionReasonKind</a>
    /// </summary>
    let ExceptionReasonKind = _prefixId.prefix "ExceptionReasonKind"

    let ExceptionReasonKindBindingLegalCommitments =
        _prefixId.prefix "ExceptionReasonKindBindingLegalCommitments"

    let ExceptionReasonKindConsentNotObtained =
        _prefixId.prefix "ExceptionReasonKindConsentNotObtained"

    let ExceptionReasonKindDetrimentNotExcluded =
        _prefixId.prefix "ExceptionReasonKindDetrimentNotExcluded"

    let ExceptionReasonKindDisclosureDetrimental =
        _prefixId.prefix "ExceptionReasonKindDisclosureDetrimental"

    let ExceptionReasonKindLegalCommitments =
        _prefixId.prefix "ExceptionReasonKindLegalCommitments"

    let ExceptionReasonKindLegalObstacles =
        _prefixId.prefix "ExceptionReasonKindLegalObstacles"

    let ExceptionReasonKindNaturalPersons =
        _prefixId.prefix "ExceptionReasonKindNaturalPersons"

    let ExceptionReasonKindNoKnownPerson =
        _prefixId.prefix "ExceptionReasonKindNoKnownPerson"

    let ExceptionReasonKindNoLEI = _prefixId.prefix "ExceptionReasonKindNoLEI"

    let ExceptionReasonKindNonConsolidating =
        _prefixId.prefix "ExceptionReasonKindNonConsolidating"

    /// <summary>
    ///   <para>skos:definition : A single exception to a specified reporting requirement, giving reasons and references where applicable.^^xsd:string</para>
    ///   <para>rdfs:label : reporting exception^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/ReportingException/ReportingException">gleif-repex:ReportingException</a>
    /// </summary>
    let ReportingException = _prefixId.prefix "ReportingException"

    /// <summary>
    ///   <para>gleif-base:hasTag : ULTIMATE_ACCOUNTING_CONSOLIDATION_PARENT^^xsd:string</para>
    ///   <para>skos:definition : The legal entity has declined to report an ultimate accounting consolidation parent, based on applicable accounting standards.^^xsd:string</para>
    ///   <para>rdfs:label : ultimate consolidation reporting exception^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/ReportingException/UltimateConsolidationReportingException">gleif-repex:UltimateConsolidationReportingException</a>
    /// </summary>
    let UltimateConsolidationReportingException =
        _prefixId.prefix "UltimateConsolidationReportingException"

    /// <summary>
    ///   <para>skos:definition : A single reason provided by the legal entity for declining to provide the mandatory report of a specified type of information (beyond the minimum reference data needed purely for identification of the legal entity).^^xsd:string</para>
    ///   <para>rdfs:label : has exception reason^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/ReportingException/hasExceptionReason">gleif-repex:hasExceptionReason</a>
    /// </summary>
    let hasExceptionReason = _prefixId.prefix "hasExceptionReason"
    /// <summary>
    ///   <para>skos:definition : References of the law, regulation or other element of the legal framework to support reason(s) provided by the legal entity for declining to provide information on its parents.^^xsd:string</para>
    ///   <para>rdfs:label : has exception reference^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/ReportingException/hasExceptionReference">gleif-repex:hasExceptionReference</a>
    /// </summary>
    let hasExceptionReference = _prefixId.prefix "hasExceptionReference"
    /// <summary>
    ///   <para>skos:definition : The LEI-registered legal entity which raised this exception.^^xsd:string</para>
    ///   <para>rdfs:label : has reporting entity^^xsd:string</para>
    ///   <a href="https://www.gleif.org/ontology/ReportingException/hasReportingEntity">gleif-repex:hasReportingEntity</a>
    /// </summary>
    let hasReportingEntity = _prefixId.prefix "hasReportingEntity"
