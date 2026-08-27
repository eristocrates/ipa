namespace https.spdx.org.rdf._3._1.terms.Security.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ns4 =
    let _namespace_iri = Namespace_Iri ns4 |> NamespaceIRI
    /// <summary>
    ///   <para>spdx:Security/CvssSeverityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies the CVSS base, temporal, threat, or environmental severity type."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType">https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType</seealso>
    let CvssSeverityType = Prefixed_Name(ns4, "CvssSeverityType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/CvssSeverityType/critical</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Security/CvssSeverityType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"When a CVSS score is between 9.0 - 10.0."</para>
    /// labels<para>"critical"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/critical">https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/critical</seealso>
    let ``CvssSeverityType/critical`` =
        Prefixed_Name(ns4, "CvssSeverityType/critical") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/CvssSeverityType/high</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Security/CvssSeverityType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"When a CVSS score is between 7.0 - 8.9."</para>
    /// labels<para>"high"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/high">https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/high</seealso>
    let ``CvssSeverityType/high`` =
        Prefixed_Name(ns4, "CvssSeverityType/high") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/CvssSeverityType/low</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Security/CvssSeverityType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"When a CVSS score is between 0.1 - 3.9."</para>
    /// labels<para>"low"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/low">https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/low</seealso>
    let ``CvssSeverityType/low`` =
        Prefixed_Name(ns4, "CvssSeverityType/low") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/CvssSeverityType/medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Security/CvssSeverityType</para>
    ///   <para>"When a CVSS score is between 4.0 - 6.9."</para>
    /// labels<para>"medium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/medium">https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/medium</seealso>
    let ``CvssSeverityType/medium`` =
        Prefixed_Name(ns4, "CvssSeverityType/medium") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/CvssSeverityType/none</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Security/CvssSeverityType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"When a CVSS score is 0.0."</para>
    /// labels<para>"none"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/none">https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/none</seealso>
    let ``CvssSeverityType/none`` =
        Prefixed_Name(ns4, "CvssSeverityType/none") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/CvssV2VulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"Provides a CVSS version 2.0 assessment for a vulnerability."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/CvssV2VulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/CvssV2VulnAssessmentRelationship</seealso>
    let CvssV2VulnAssessmentRelationship =
        Prefixed_Name(ns4, "CvssV2VulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/CvssV3VulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Provides a CVSS version 3 assessment for a vulnerability."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/CvssV3VulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/CvssV3VulnAssessmentRelationship</seealso>
    let CvssV3VulnAssessmentRelationship =
        Prefixed_Name(ns4, "CvssV3VulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/CvssV4VulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"Provides a CVSS version 4 assessment for a vulnerability."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/CvssV4VulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/CvssV4VulnAssessmentRelationship</seealso>
    let CvssV4VulnAssessmentRelationship =
        Prefixed_Name(ns4, "CvssV4VulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/EpssVulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Provides an EPSS assessment for a vulnerability."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/EpssVulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/EpssVulnAssessmentRelationship</seealso>
    let EpssVulnAssessmentRelationship =
        Prefixed_Name(ns4, "EpssVulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/ExploitCatalogType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies the exploit catalog type."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogType">https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogType</seealso>
    let ExploitCatalogType = Prefixed_Name(ns4, "ExploitCatalogType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/ExploitCatalogType/kev</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Security/ExploitCatalogType</para>
    ///   <para>"CISA's Known Exploited Vulnerability (KEV) catalog."</para>
    /// labels<para>"kev"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogType/kev">https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogType/kev</seealso>
    let ``ExploitCatalogType/kev`` =
        Prefixed_Name(ns4, "ExploitCatalogType/kev") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/ExploitCatalogType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Security/ExploitCatalogType</para>
    ///   <para>"Other exploit catalogs."</para>
    /// labels<para>"other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogType/other">https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogType/other</seealso>
    let ``ExploitCatalogType/other`` =
        Prefixed_Name(ns4, "ExploitCatalogType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/ExploitCatalogVulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Provides an exploit assessment of a vulnerability."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogVulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogVulnAssessmentRelationship</seealso>
    let ExploitCatalogVulnAssessmentRelationship =
        Prefixed_Name(ns4, "ExploitCatalogVulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/SsvcDecisionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies the SSVC decision type."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType">https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType</seealso>
    let SsvcDecisionType = Prefixed_Name(ns4, "SsvcDecisionType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/SsvcDecisionType/act</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Security/SsvcDecisionType</para>
    ///   <para>"The vulnerability requires attention from the organization's internal, supervisory-level and leadership-level individuals. Necessary actions include requesting assistance or information about the vulnerability, as well as publishing a notification either internally and/or externally. Typically, internal groups would meet to determine the overall response and then execute agreed upon actions. CISA recommends remediating Act vulnerabilities as soon as possible."</para>
    /// labels<para>"act"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/act">https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/act</seealso>
    let ``SsvcDecisionType/act`` =
        Prefixed_Name(ns4, "SsvcDecisionType/act") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/SsvcDecisionType/attend</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Security/SsvcDecisionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The vulnerability requires attention from the organization's internal, supervisory-level individuals. Necessary actions include requesting assistance or information about the vulnerability, and may involve publishing a notification either internally and/or externally. CISA recommends remediating Attend vulnerabilities sooner than standard update timelines."</para>
    /// labels<para>"attend"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/attend">https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/attend</seealso>
    let ``SsvcDecisionType/attend`` =
        Prefixed_Name(ns4, "SsvcDecisionType/attend") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/SsvcDecisionType/track</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Security/SsvcDecisionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The vulnerability does not require action at this time. The organization would continue to track the vulnerability and reassess it if new information becomes available. CISA recommends remediating Track vulnerabilities within standard update timelines."</para>
    /// labels<para>"track"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/track">https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/track</seealso>
    let ``SsvcDecisionType/track`` =
        Prefixed_Name(ns4, "SsvcDecisionType/track") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/SsvcDecisionType/trackStar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Security/SsvcDecisionType</para>
    ///   <para>"("Track\*" in the SSVC spec) The vulnerability contains specific characteristics that may require closer monitoring for changes. CISA recommends remediating Track\* vulnerabilities within standard update timelines."</para>
    /// labels<para>"trackStar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/trackStar">https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/trackStar</seealso>
    let ``SsvcDecisionType/trackStar`` =
        Prefixed_Name(ns4, "SsvcDecisionType/trackStar") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/SsvcVulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Provides an SSVC assessment for a vulnerability."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/SsvcVulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/SsvcVulnAssessmentRelationship</seealso>
    let SsvcVulnAssessmentRelationship =
        Prefixed_Name(ns4, "SsvcVulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VexAffectedVulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"Connects a vulnerability and an element designating the element as a product
    /// affected by the vulnerability."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VexAffectedVulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/VexAffectedVulnAssessmentRelationship</seealso>
    let VexAffectedVulnAssessmentRelationship =
        Prefixed_Name(ns4, "VexAffectedVulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VexFixedVulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Links a vulnerability and elements representing products (in the VEX sense) where
    /// a fix has been applied and are no longer affected."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VexFixedVulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/VexFixedVulnAssessmentRelationship</seealso>
    let VexFixedVulnAssessmentRelationship =
        Prefixed_Name(ns4, "VexFixedVulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VexJustificationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies the VEX justification type."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType">https://spdx.org/rdf/3.1/terms/Security/VexJustificationType</seealso>
    let VexJustificationType =
        Prefixed_Name(ns4, "VexJustificationType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VexJustificationType/componentNotPresent</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Security/VexJustificationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The software is not affected because the vulnerable component is not in the product."</para>
    /// labels<para>"componentNotPresent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/componentNotPresent">https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/componentNotPresent</seealso>
    let ``VexJustificationType/componentNotPresent`` =
        Prefixed_Name(ns4, "VexJustificationType/componentNotPresent") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VexJustificationType/inlineMitigationsAlreadyExist</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Security/VexJustificationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Built-in inline controls or mitigations prevent an adversary from leveraging the vulnerability."</para>
    /// labels<para>"inlineMitigationsAlreadyExist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/inlineMitigationsAlreadyExist">https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/inlineMitigationsAlreadyExist</seealso>
    let ``VexJustificationType/inlineMitigationsAlreadyExist`` =
        Prefixed_Name(ns4, "VexJustificationType/inlineMitigationsAlreadyExist") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VexJustificationType/vulnerableCodeCannotBeControlledByAdversary</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Security/VexJustificationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The vulnerable component is present, and the component contains the vulnerable code. However, vulnerable code is used in such a way that an attacker cannot mount any anticipated attack."</para>
    /// labels<para>"vulnerableCodeCannotBeControlledByAdversary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/vulnerableCodeCannotBeControlledByAdversary">https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/vulnerableCodeCannotBeControlledByAdversary</seealso>
    let ``VexJustificationType/vulnerableCodeCannotBeControlledByAdversary`` =
        Prefixed_Name(ns4, "VexJustificationType/vulnerableCodeCannotBeControlledByAdversary") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VexJustificationType/vulnerableCodeNotInExecutePath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Security/VexJustificationType</para>
    ///   <para>"The affected code is not reachable through the execution of the code, including non-anticipated states of the product."</para>
    /// labels<para>"vulnerableCodeNotInExecutePath"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/vulnerableCodeNotInExecutePath">https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/vulnerableCodeNotInExecutePath</seealso>
    let ``VexJustificationType/vulnerableCodeNotInExecutePath`` =
        Prefixed_Name(ns4, "VexJustificationType/vulnerableCodeNotInExecutePath") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VexJustificationType/vulnerableCodeNotPresent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Security/VexJustificationType</para>
    ///   <para>"The product is not affected because the code underlying the vulnerability is not present in the product."</para>
    /// labels<para>"vulnerableCodeNotPresent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/vulnerableCodeNotPresent">https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/vulnerableCodeNotPresent</seealso>
    let ``VexJustificationType/vulnerableCodeNotPresent`` =
        Prefixed_Name(ns4, "VexJustificationType/vulnerableCodeNotPresent") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VexNotAffectedVulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"Links a vulnerability and one or more elements designating the latter as products
    /// not affected by the vulnerability."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VexNotAffectedVulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/VexNotAffectedVulnAssessmentRelationship</seealso>
    let VexNotAffectedVulnAssessmentRelationship =
        Prefixed_Name(ns4, "VexNotAffectedVulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VexUnderInvestigationVulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Designates elements as products where the impact of a vulnerability is being
    /// investigated."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VexUnderInvestigationVulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/VexUnderInvestigationVulnAssessmentRelationship</seealso>
    let VexUnderInvestigationVulnAssessmentRelationship =
        Prefixed_Name(ns4, "VexUnderInvestigationVulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VexVulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"Abstract ancestor class for all VEX relationships."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VexVulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/VexVulnAssessmentRelationship</seealso>
    let VexVulnAssessmentRelationship =
        Prefixed_Name(ns4, "VexVulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Abstract ancestor class for all vulnerability assessments."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/VulnAssessmentRelationship</seealso>
    let VulnAssessmentRelationship =
        Prefixed_Name(ns4, "VulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/Vulnerability</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies a vulnerability and its associated information."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/Vulnerability">https://spdx.org/rdf/3.1/terms/Security/Vulnerability</seealso>
    let Vulnerability = Prefixed_Name(ns4, "Vulnerability") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Security/actionStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides advise on how to mitigate or remediate a vulnerability when a VEX product
    /// is affected by it."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/actionStatement">https://spdx.org/rdf/3.1/terms/Security/actionStatement</seealso>
    let actionStatement = Prefixed_Name(ns4, "actionStatement") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Security/actionStatementTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Records the time when a recommended action was communicated in a VEX statement
    /// to mitigate a vulnerability."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/actionStatementTime">https://spdx.org/rdf/3.1/terms/Security/actionStatementTime</seealso>
    let actionStatementTime = Prefixed_Name(ns4, "actionStatementTime") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Security/assessedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies an Element contained in a piece of software where a vulnerability was
    /// found."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/assessedElement">https://spdx.org/rdf/3.1/terms/Security/assessedElement</seealso>
    let assessedElement = Prefixed_Name(ns4, "assessedElement") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Security/catalogType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the exploit catalog type."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/catalogType">https://spdx.org/rdf/3.1/terms/Security/catalogType</seealso>
    let catalogType = Prefixed_Name(ns4, "catalogType") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Security/decisionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Provide the enumeration of possible decisions in the
    /// [Stakeholder-Specific Vulnerability Categorization (SSVC) decision tree](https://www.cisa.gov/stakeholder-specific-vulnerability-categorization-ssvc)."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/decisionType">https://spdx.org/rdf/3.1/terms/Security/decisionType</seealso>
    let decisionType = Prefixed_Name(ns4, "decisionType") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Security/exploited</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Denote whether a CVE is present in an exploit catalog."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/exploited">https://spdx.org/rdf/3.1/terms/Security/exploited</seealso>
    let exploited = Prefixed_Name(ns4, "exploited") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Security/impactStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Explains why a VEX product is not affected by a vulnerability. It is an
    /// alternative in VexNotAffectedVulnAssessmentRelationship to the machine-readable
    /// justification label."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/impactStatement">https://spdx.org/rdf/3.1/terms/Security/impactStatement</seealso>
    let impactStatement = Prefixed_Name(ns4, "impactStatement") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Security/impactStatementTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Timestamp of impact statement."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/impactStatementTime">https://spdx.org/rdf/3.1/terms/Security/impactStatementTime</seealso>
    let impactStatementTime = Prefixed_Name(ns4, "impactStatementTime") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Security/justificationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Impact justification label to be used when linking a vulnerability to an element
    /// representing a VEX product with a VexNotAffectedVulnAssessmentRelationship
    /// relationship."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/justificationType">https://spdx.org/rdf/3.1/terms/Security/justificationType</seealso>
    let justificationType = Prefixed_Name(ns4, "justificationType") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Security/locator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides the location of an exploit catalog."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/locator">https://spdx.org/rdf/3.1/terms/Security/locator</seealso>
    let locator = Prefixed_Name(ns4, "locator") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Security/modifiedTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies a time when a vulnerability assessment was modified"</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/modifiedTime">https://spdx.org/rdf/3.1/terms/Security/modifiedTime</seealso>
    let modifiedTime = Prefixed_Name(ns4, "modifiedTime") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Security/percentile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The percentile of the current probability score."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/percentile">https://spdx.org/rdf/3.1/terms/Security/percentile</seealso>
    let percentile = Prefixed_Name(ns4, "percentile") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Security/probability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A probability score between 0 and 1 of a vulnerability being exploited."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/probability">https://spdx.org/rdf/3.1/terms/Security/probability</seealso>
    let probability = Prefixed_Name(ns4, "probability") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Security/publishedTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the time when a vulnerability was published."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/publishedTime">https://spdx.org/rdf/3.1/terms/Security/publishedTime</seealso>
    let publishedTime = Prefixed_Name(ns4, "publishedTime") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Security/score</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides a numerical (0-10) representation of the severity of a vulnerability."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/score">https://spdx.org/rdf/3.1/terms/Security/score</seealso>
    let score = Prefixed_Name(ns4, "score") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Security/severity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Specifies the CVSS qualitative severity rating of a vulnerability in relation to a piece of software."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/severity">https://spdx.org/rdf/3.1/terms/Security/severity</seealso>
    let severity = Prefixed_Name(ns4, "severity") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Security/statusNotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Conveys information about how VEX status was determined."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/statusNotes">https://spdx.org/rdf/3.1/terms/Security/statusNotes</seealso>
    let statusNotes = Prefixed_Name(ns4, "statusNotes") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Security/vectorString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the CVSS vector string for a vulnerability."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/vectorString">https://spdx.org/rdf/3.1/terms/Security/vectorString</seealso>
    let vectorString = Prefixed_Name(ns4, "vectorString") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Security/vexVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the version of a VEX statement."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/vexVersion">https://spdx.org/rdf/3.1/terms/Security/vexVersion</seealso>
    let vexVersion = Prefixed_Name(ns4, "vexVersion") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Security/withdrawnTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specified the time and date when a vulnerability was withdrawn."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/withdrawnTime">https://spdx.org/rdf/3.1/terms/Security/withdrawnTime</seealso>
    let withdrawnTime = Prefixed_Name(ns4, "withdrawnTime") |> PrefixedName
