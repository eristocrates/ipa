namespace https.spdx.org.rdf._3._1.terms.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module spdx =
    let _namespace_iri = Namespace_Iri spdx |> NamespaceIRI

    /// <summary>
    ///   <para>spdx:AI/modelDataPreprocessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Preprocessing steps applied to the training data before the model training.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/modelDataPreprocessing">https://spdx.org/rdf/3.1/terms/AI/modelDataPreprocessing</seealso>
    let ``AI/modelDataPreprocessing`` =
        Prefixed_Name(spdx, "AI/modelDataPreprocessing") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/limitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Limitation of the AI software.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/limitation">https://spdx.org/rdf/3.1/terms/AI/limitation</seealso>
    let ``AI/limitation`` = Prefixed_Name(spdx, "AI/limitation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/PresenceType/no</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/PresenceType</para>
    ///   <para>Indicates absence of the field.</para>
    /// labels<para>no</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/PresenceType/no">https://spdx.org/rdf/3.1/terms/Core/PresenceType/no</seealso>
    let ``Core/PresenceType/no`` =
        Prefixed_Name(spdx, "Core/PresenceType/no") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/metricDecisionThreshold</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Threshold that was used for computation of a metric described in
    /// the metric field.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/metricDecisionThreshold">https://spdx.org/rdf/3.1/terms/AI/metricDecisionThreshold</seealso>
    let ``AI/metricDecisionThreshold`` =
        Prefixed_Name(spdx, "AI/metricDecisionThreshold") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/IsoAutomationLevel/fullAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/IsoAutomationLevel</para>
    ///   <para>Level 5 - Full automation. The system is capable of performing its entire mission without external intervention.</para>
    /// labels<para>fullAutomation</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/fullAutomation">https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/fullAutomation</seealso>
    let ``Core/IsoAutomationLevel/fullAutomation`` =
        Prefixed_Name(spdx, "Core/IsoAutomationLevel/fullAutomation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/IsoAutomationLevel/assistiveAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/IsoAutomationLevel</para>
    ///   <para>Level 1 - Assistive automation. The system assists an operator.</para>
    /// labels<para>assistiveAutomation</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/assistiveAutomation">https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/assistiveAutomation</seealso>
    let ``Core/IsoAutomationLevel/assistiveAutomation`` =
        Prefixed_Name(spdx, "Core/IsoAutomationLevel/assistiveAutomation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/IsoAutomationLevel/notAutomated</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/IsoAutomationLevel</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Level 0 - Not automated. No automation. The operator fully controls the system.</para>
    /// labels<para>notAutomated</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/notAutomated">https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/notAutomated</seealso>
    let ``Core/IsoAutomationLevel/notAutomated`` =
        Prefixed_Name(spdx, "Core/IsoAutomationLevel/notAutomated") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/hyperparameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Hyperparameter used to build the AI model contained in the AI package.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/hyperparameter">https://spdx.org/rdf/3.1/terms/AI/hyperparameter</seealso>
    let ``AI/hyperparameter`` = Prefixed_Name(spdx, "AI/hyperparameter") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/EnergyConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>A class for describing the energy consumption incurred by an AI model in
    /// different stages of its lifecycle.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/EnergyConsumption">https://spdx.org/rdf/3.1/terms/AI/EnergyConsumption</seealso>
    let ``AI/EnergyConsumption`` =
        Prefixed_Name(spdx, "AI/EnergyConsumption") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/energyQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Energy quantity.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/energyQuantity">https://spdx.org/rdf/3.1/terms/AI/energyQuantity</seealso>
    let ``AI/energyQuantity`` = Prefixed_Name(spdx, "AI/energyQuantity") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/Artifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>A distinct article or unit within the domain.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Artifact">https://spdx.org/rdf/3.1/terms/Core/Artifact</seealso>
    let ``Core/Artifact`` = Prefixed_Name(spdx, "Core/Artifact") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/actionStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property describing the start time of an action.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/actionStartTime">https://spdx.org/rdf/3.1/terms/Core/actionStartTime</seealso>
    let ``Core/actionStartTime`` =
        Prefixed_Name(spdx, "Core/actionStartTime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/actionEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property that describes the time at which an action stops.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/actionEndTime">https://spdx.org/rdf/3.1/terms/Core/actionEndTime</seealso>
    let ``Core/actionEndTime`` =
        Prefixed_Name(spdx, "Core/actionEndTime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>An assertion made in relation to one or more elements.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Annotation">https://spdx.org/rdf/3.1/terms/Core/Annotation</seealso>
    let ``Core/Annotation`` = Prefixed_Name(spdx, "Core/Annotation") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Commentary on an assertion that an annotator has made.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/statement">https://spdx.org/rdf/3.1/terms/Core/statement</seealso>
    let ``Core/statement`` = Prefixed_Name(spdx, "Core/statement") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/AnnotationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specifies the type of an annotation.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/AnnotationType">https://spdx.org/rdf/3.1/terms/Core/AnnotationType</seealso>
    let ``Core/AnnotationType`` =
        Prefixed_Name(spdx, "Core/AnnotationType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/AnnotationType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/AnnotationType</para>
    ///   <para>Used to store extra information about an Element which is not part of a review (e.g. extra information provided during the creation of the Element).</para>
    /// labels<para>other</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/AnnotationType/other">https://spdx.org/rdf/3.1/terms/Core/AnnotationType/other</seealso>
    let ``Core/AnnotationType/other`` =
        Prefixed_Name(spdx, "Core/AnnotationType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/builtTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies the time an artifact was built.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/builtTime">https://spdx.org/rdf/3.1/terms/Core/builtTime</seealso>
    let ``Core/builtTime`` = Prefixed_Name(spdx, "Core/builtTime") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/suppliedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies who or what supplied the artifact or VulnAssessmentRelationship
    /// referenced by the Element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/suppliedBy">https://spdx.org/rdf/3.1/terms/Core/suppliedBy</seealso>
    let ``Core/suppliedBy`` = Prefixed_Name(spdx, "Core/suppliedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/validUntilTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies until when the artifact can be used before its usage needs to be
    /// reassessed.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/validUntilTime">https://spdx.org/rdf/3.1/terms/Core/validUntilTime</seealso>
    let ``Core/validUntilTime`` =
        Prefixed_Name(spdx, "Core/validUntilTime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/intendedUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The intendedUse property is designed to capture a summary of how or for what item or artifact is meant to be used for.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/intendedUse">https://spdx.org/rdf/3.1/terms/Core/intendedUse</seealso>
    let ``Core/intendedUse`` = Prefixed_Name(spdx, "Core/intendedUse") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/originatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies from where or whom the Element originally came.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/originatedBy">https://spdx.org/rdf/3.1/terms/Core/originatedBy</seealso>
    let ``Core/originatedBy`` = Prefixed_Name(spdx, "Core/originatedBy") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/standardName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of a relevant standard that may apply to an artifact.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/standardName">https://spdx.org/rdf/3.1/terms/Core/standardName</seealso>
    let ``Core/standardName`` = Prefixed_Name(spdx, "Core/standardName") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SupportType/deployed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/SupportType</para>
    ///   <para>In addition to being supported by the supplier, the software is known to have been deployed and is in use. For a software as a service provider, this implies the software is now available as a service.</para>
    /// labels<para>deployed</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SupportType/deployed">https://spdx.org/rdf/3.1/terms/Core/SupportType/deployed</seealso>
    let ``Core/SupportType/deployed`` =
        Prefixed_Name(spdx, "Core/SupportType/deployed") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SupportType/limitedSupport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/SupportType</para>
    ///   <para>The artifact has been released, and there is limited support available from the supplier. There is a validUntilDate that can provide additional information about the duration of support.</para>
    /// labels<para>limitedSupport</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SupportType/limitedSupport">https://spdx.org/rdf/3.1/terms/Core/SupportType/limitedSupport</seealso>
    let ``Core/SupportType/limitedSupport`` =
        Prefixed_Name(spdx, "Core/SupportType/limitedSupport") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SupportType/endOfSupport</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/SupportType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>There is a defined end of support for the artifact from the supplier. This may also be referred to as end of life. There is a validUntilDate that can be used to signal when support ends for the artifact.</para>
    /// labels<para>endOfSupport</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SupportType/endOfSupport">https://spdx.org/rdf/3.1/terms/Core/SupportType/endOfSupport</seealso>
    let ``Core/SupportType/endOfSupport`` =
        Prefixed_Name(spdx, "Core/SupportType/endOfSupport") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SupportType/noSupport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/SupportType</para>
    ///   <para>There is no support for the artifact from the supplier, consumer assumes any support obligations.</para>
    /// labels<para>noSupport</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SupportType/noSupport">https://spdx.org/rdf/3.1/terms/Core/SupportType/noSupport</seealso>
    let ``Core/SupportType/noSupport`` =
        Prefixed_Name(spdx, "Core/SupportType/noSupport") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/DisjunctiveLicenseSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>Portion of an AnyLicenseInfo representing a set of licensing information where
    /// only one of the elements applies.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/DisjunctiveLicenseSet">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/DisjunctiveLicenseSet</seealso>
    let ``ExpandedLicensing/DisjunctiveLicenseSet`` =
        Prefixed_Name(spdx, "ExpandedLicensing/DisjunctiveLicenseSet") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/ListedLicenseException</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>A license exception that is listed on the SPDX Exceptions list.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ListedLicenseException">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ListedLicenseException</seealso>
    let ``ExpandedLicensing/ListedLicenseException`` =
        Prefixed_Name(spdx, "ExpandedLicensing/ListedLicenseException") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/supplyChain</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The element follows the SupplyChain profile specification.</para>
    /// labels<para>supplyChain</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/supplyChain">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/supplyChain</seealso>
    let ``Core/ProfileIdentifierType/supplyChain`` =
        Prefixed_Name(spdx, "Core/ProfileIdentifierType/supplyChain") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/profileConformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes one a profile which the creator of this ElementCollection intends to
    /// conform to.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/profileConformance">https://spdx.org/rdf/3.1/terms/Core/profileConformance</seealso>
    let ``Core/profileConformance`` =
        Prefixed_Name(spdx, "Core/profileConformance") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/elementValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A value used in a key-value pair with a generic key that refers to an Element</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/elementValue">https://spdx.org/rdf/3.1/terms/Core/elementValue</seealso>
    let ``Core/elementValue`` = Prefixed_Name(spdx, "Core/elementValue") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/underInvestigationFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Vulnerability impact is being investigated for each `to` Element. The use of the `underInvestigationFor` type is constrained to `VexUnderInvestigationVulnAssessmentRelationship` classed relationships.</para>
    /// labels<para>underInvestigationFor</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/underInvestigationFor">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/underInvestigationFor</seealso>
    let ``Core/RelationshipType/underInvestigationFor`` =
        Prefixed_Name(spdx, "Core/RelationshipType/underInvestigationFor") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/usesTool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Element uses each `to` Element as a tool, during a LifecycleScopeType period.</para>
    /// labels<para>usesTool</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/usesTool">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/usesTool</seealso>
    let ``Core/RelationshipType/usesTool`` =
        Prefixed_Name(spdx, "Core/RelationshipType/usesTool") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/validatedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Element has been validated on the `to` Element(s).</para>
    /// labels<para>validatedOn</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/validatedOn">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/validatedOn</seealso>
    let ``Core/RelationshipType/validatedOn`` =
        Prefixed_Name(spdx, "Core/RelationshipType/validatedOn") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/verifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Requirement that has verification (test, review, analysis etc.) details defined in the `to` RequirementVerification.</para>
    /// labels<para>verifiedBy</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/verifiedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/verifiedBy</seealso>
    let ``Core/RelationshipType/verifiedBy`` =
        Prefixed_Name(spdx, "Core/RelationshipType/verifiedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/relationshipType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Information about the relationship between two Elements.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/relationshipType">https://spdx.org/rdf/3.1/terms/Core/relationshipType</seealso>
    let ``Core/relationshipType`` =
        Prefixed_Name(spdx, "Core/relationshipType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipCompleteness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates whether a relationship is known to be complete, incomplete, or if no assertion is made with respect to relationship completeness.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness">https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness</seealso>
    let ``Core/RelationshipCompleteness`` =
        Prefixed_Name(spdx, "Core/RelationshipCompleteness") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipCompleteness/incomplete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipCompleteness</para>
    ///   <para>The relationship is known not to be exhaustive.</para>
    /// labels<para>incomplete</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness/incomplete">https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness/incomplete</seealso>
    let ``Core/RelationshipCompleteness/incomplete`` =
        Prefixed_Name(spdx, "Core/RelationshipCompleteness/incomplete") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipCompleteness/complete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipCompleteness</para>
    ///   <para>The relationship is known to be exhaustive.</para>
    /// labels<para>complete</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness/complete">https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness/complete</seealso>
    let ``Core/RelationshipCompleteness/complete`` =
        Prefixed_Name(spdx, "Core/RelationshipCompleteness/complete") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipCompleteness/noAssertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipCompleteness</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>No assertion can be made about the completeness of the relationship.</para>
    /// labels<para>noAssertion</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness/noAssertion">https://spdx.org/rdf/3.1/terms/Core/RelationshipCompleteness/noAssertion</seealso>
    let ``Core/RelationshipCompleteness/noAssertion`` =
        Prefixed_Name(spdx, "Core/RelationshipCompleteness/noAssertion") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/completeness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Provides information about the completeness of relationships.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/completeness">https://spdx.org/rdf/3.1/terms/Core/completeness</seealso>
    let ``Core/completeness`` = Prefixed_Name(spdx, "Core/completeness") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/startTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies the time from which an element is applicable / valid.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/startTime">https://spdx.org/rdf/3.1/terms/Core/startTime</seealso>
    let ``Core/startTime`` = Prefixed_Name(spdx, "Core/startTime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A license expression participating in a license set.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/member">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/member</seealso>
    let ``ExpandedLicensing/member`` =
        Prefixed_Name(spdx, "ExpandedLicensing/member") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/License</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>Abstract class for the portion of an AnyLicenseInfo representing a license.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/License">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/License</seealso>
    let ``ExpandedLicensing/License`` =
        Prefixed_Name(spdx, "ExpandedLicensing/License") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/LicenseAddition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Abstract class for additional text intended to be added to a License, but
    /// which is not itself a standalone License.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/LicenseAddition">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/LicenseAddition</seealso>
    let ``ExpandedLicensing/LicenseAddition`` =
        Prefixed_Name(spdx, "ExpandedLicensing/LicenseAddition") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/ExtendableLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract class representing a License or an OrLaterOperator.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ExtendableLicense">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ExtendableLicense</seealso>
    let ``ExpandedLicensing/ExtendableLicense`` =
        Prefixed_Name(spdx, "ExpandedLicensing/ExtendableLicense") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SimpleLicensing/licenseText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identifies the full text of a License or Addition.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/licenseText">https://spdx.org/rdf/3.1/terms/SimpleLicensing/licenseText</seealso>
    let ``SimpleLicensing/licenseText`` =
        Prefixed_Name(spdx, "SimpleLicensing/licenseText") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/obsoletedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies the licenseId that is preferred to be used in place of a deprecated
    /// License or LicenseAddition.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/obsoletedBy">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/obsoletedBy</seealso>
    let ``ExpandedLicensing/obsoletedBy`` =
        Prefixed_Name(spdx, "ExpandedLicensing/obsoletedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/licenseXml</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identifies all the text and metadata associated with a license in the license
    /// XML format.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/licenseXml">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/licenseXml</seealso>
    let ``ExpandedLicensing/licenseXml`` =
        Prefixed_Name(spdx, "ExpandedLicensing/licenseXml") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/isDeprecatedLicenseId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies whether a license or additional text identifier has been marked as
    /// deprecated.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isDeprecatedLicenseId">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isDeprecatedLicenseId</seealso>
    let ``ExpandedLicensing/isDeprecatedLicenseId`` =
        Prefixed_Name(spdx, "ExpandedLicensing/isDeprecatedLicenseId") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/seeAlso</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Contains a URL where the License or LicenseAddition can be found in use.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/seeAlso">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/seeAlso</seealso>
    let ``ExpandedLicensing/seeAlso`` =
        Prefixed_Name(spdx, "ExpandedLicensing/seeAlso") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/isFsfLibre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies whether the License is listed as free by the
    /// Free Software Foundation (FSF).</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isFsfLibre">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isFsfLibre</seealso>
    let ``ExpandedLicensing/isFsfLibre`` =
        Prefixed_Name(spdx, "ExpandedLicensing/isFsfLibre") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/standardLicenseTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identifies the full text of a License, in SPDX templating format.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/standardLicenseTemplate">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/standardLicenseTemplate</seealso>
    let ``ExpandedLicensing/standardLicenseTemplate`` =
        Prefixed_Name(spdx, "ExpandedLicensing/standardLicenseTemplate") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/standardLicenseHeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides a License author's preferred text to indicate that a file is covered
    /// by the License.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/standardLicenseHeader">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/standardLicenseHeader</seealso>
    let ``ExpandedLicensing/standardLicenseHeader`` =
        Prefixed_Name(spdx, "ExpandedLicensing/standardLicenseHeader") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/xAxisLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Information related to hardware dimension.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/xAxisLength">https://spdx.org/rdf/3.1/terms/Hardware/xAxisLength</seealso>
    let ``Hardware/xAxisLength`` =
        Prefixed_Name(spdx, "Hardware/xAxisLength") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/hazard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Hazards are potential sources of harm, danger, or adverse effects to people, property, the environment, or systems within or related to a specific piece of hardware.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/hazard">https://spdx.org/rdf/3.1/terms/Hardware/hazard</seealso>
    let ``Hardware/hazard`` = Prefixed_Name(spdx, "Hardware/hazard") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/additionalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Additional relevance information.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/additionalInformation">https://spdx.org/rdf/3.1/terms/Hardware/additionalInformation</seealso>
    let ``Hardware/additionalInformation`` =
        Prefixed_Name(spdx, "Hardware/additionalInformation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/serialNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identifier for specific product is called a serial number.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/serialNumber">https://spdx.org/rdf/3.1/terms/Hardware/serialNumber</seealso>
    let ``Hardware/serialNumber`` =
        Prefixed_Name(spdx, "Hardware/serialNumber") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/partNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Product Part Number as defined by OEM.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/partNumber">https://spdx.org/rdf/3.1/terms/Hardware/partNumber</seealso>
    let ``Hardware/partNumber`` =
        Prefixed_Name(spdx, "Hardware/partNumber") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/releaseDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Date of product release.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/releaseDate">https://spdx.org/rdf/3.1/terms/Hardware/releaseDate</seealso>
    let ``Hardware/releaseDate`` =
        Prefixed_Name(spdx, "Hardware/releaseDate") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Service/AuthenticationProtocolType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Protocols which support authentication.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType">https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType</seealso>
    let ``Service/AuthenticationProtocolType`` =
        Prefixed_Name(spdx, "Service/AuthenticationProtocolType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Service/AuthenticationProtocolType/crl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Service/AuthenticationProtocolType</para>
    ///   <para>Certificate Revocation List, or CRL, is a list of revoked certificates that is downloaded from the Certificate Authority (CA).</para>
    /// labels<para>crl</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/crl">https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/crl</seealso>
    let ``Service/AuthenticationProtocolType/crl`` =
        Prefixed_Name(spdx, "Service/AuthenticationProtocolType/crl") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Service/AuthenticationProtocolType/ocsp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Service/AuthenticationProtocolType</para>
    ///   <para>Online Certificate Status Protocol, or OCSP, is a common scheme used to maintain the security of a server and other network resources.</para>
    /// labels<para>ocsp</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/ocsp">https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/ocsp</seealso>
    let ``Service/AuthenticationProtocolType/ocsp`` =
        Prefixed_Name(spdx, "Service/AuthenticationProtocolType/ocsp") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Service/AuthenticationProtocolType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Service/AuthenticationProtocolType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An authentication protocol not covered by one of the other AuthenticationProtocolTypes.</para>
    /// labels<para>other</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/other">https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/other</seealso>
    let ``Service/AuthenticationProtocolType/other`` =
        Prefixed_Name(spdx, "Service/AuthenticationProtocolType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Service/AuthenticationProtocolType/tls</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Service/AuthenticationProtocolType</para>
    ///   <para>Transport Layer Security, or TLS, is a widely adopted security protocol designed to facilitate privacy and data security for communications over the Internet.</para>
    /// labels<para>tls</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/tls">https://spdx.org/rdf/3.1/terms/Service/AuthenticationProtocolType/tls</seealso>
    let ``Service/AuthenticationProtocolType/tls`` =
        Prefixed_Name(spdx, "Service/AuthenticationProtocolType/tls") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/UseProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Use Process defines actions used by elements.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/UseProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/UseProcess</seealso>
    let ``SupplyChain/UseProcess`` =
        Prefixed_Name(spdx, "SupplyChain/UseProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/validState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The valid state for DefinedStateProcess.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/validState">https://spdx.org/rdf/3.1/terms/SupplyChain/validState</seealso>
    let ``SupplyChain/validState`` =
        Prefixed_Name(spdx, "SupplyChain/validState") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/destructionPerformedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is the agent that performed the act of destroying the item.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/destructionPerformedBy">https://spdx.org/rdf/3.1/terms/SupplyChain/destructionPerformedBy</seealso>
    let ``SupplyChain/destructionPerformedBy`` =
        Prefixed_Name(spdx, "SupplyChain/destructionPerformedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/PresenceType/noAssertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/PresenceType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Makes no assertion about the field.</para>
    /// labels<para>noAssertion</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/PresenceType/noAssertion">https://spdx.org/rdf/3.1/terms/Core/PresenceType/noAssertion</seealso>
    let ``Core/PresenceType/noAssertion`` =
        Prefixed_Name(spdx, "Core/PresenceType/noAssertion") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/IsoAutomationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Defines the level of automation a system possesses.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel">https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel</seealso>
    let ``Core/IsoAutomationLevel`` =
        Prefixed_Name(spdx, "Core/IsoAutomationLevel") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/IsoAutomationLevel/partialAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/IsoAutomationLevel</para>
    ///   <para>Level 2 - Partial automation or task automation. Some sub-functions of the system are fully automated while the system remain under control of an external agent. The system can perform actions for an approved task without requiring the agent's continuous direct control.</para>
    /// labels<para>partialAutomation</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/partialAutomation">https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/partialAutomation</seealso>
    let ``Core/IsoAutomationLevel/partialAutomation`` =
        Prefixed_Name(spdx, "Core/IsoAutomationLevel/partialAutomation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/trainingEnergyConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Energy consumed when training the AI model that is
    /// being used in the AI system.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/trainingEnergyConsumption">https://spdx.org/rdf/3.1/terms/AI/trainingEnergyConsumption</seealso>
    let ``AI/trainingEnergyConsumption`` =
        Prefixed_Name(spdx, "AI/trainingEnergyConsumption") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/EnergyUnitType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Unit of energy consumption.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType">https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType</seealso>
    let ``AI/EnergyUnitType`` = Prefixed_Name(spdx, "AI/EnergyUnitType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/EnergyUnitType/megajoule</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:AI/EnergyUnitType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Megajoule.</para>
    /// labels<para>megajoule</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType/megajoule">https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType/megajoule</seealso>
    let ``AI/EnergyUnitType/megajoule`` =
        Prefixed_Name(spdx, "AI/EnergyUnitType/megajoule") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/Element</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Base domain class from which all other SPDX 3 domain classes derive.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Element">https://spdx.org/rdf/3.1/terms/Core/Element</seealso>
    let ``Core/Element`` = Prefixed_Name(spdx, "Core/Element") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Build/environment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property describing the session in which a build is invoked.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Build/environment">https://spdx.org/rdf/3.1/terms/Build/environment</seealso>
    let ``Build/environment`` = Prefixed_Name(spdx, "Build/environment") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Build/configSourceEntrypoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property describes the invocation entrypoint of a build.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Build/configSourceEntrypoint">https://spdx.org/rdf/3.1/terms/Build/configSourceEntrypoint</seealso>
    let ``Build/configSourceEntrypoint`` =
        Prefixed_Name(spdx, "Build/configSourceEntrypoint") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Build/buildStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property describing the start time of a build.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Build/buildStartTime">https://spdx.org/rdf/3.1/terms/Build/buildStartTime</seealso>
    let ``Build/buildStartTime`` =
        Prefixed_Name(spdx, "Build/buildStartTime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Build/buildEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property that describes the time at which a build stops.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Build/buildEndTime">https://spdx.org/rdf/3.1/terms/Build/buildEndTime</seealso>
    let ``Build/buildEndTime`` =
        Prefixed_Name(spdx, "Build/buildEndTime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VexUnderInvestigationVulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Designates elements as products where the impact of a vulnerability is being
    /// investigated.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VexUnderInvestigationVulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/VexUnderInvestigationVulnAssessmentRelationship</seealso>
    let ``Security/VexUnderInvestigationVulnAssessmentRelationship`` =
        Prefixed_Name(spdx, "Security/VexUnderInvestigationVulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/EpssVulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Provides an EPSS assessment for a vulnerability.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/EpssVulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/EpssVulnAssessmentRelationship</seealso>
    let ``Security/EpssVulnAssessmentRelationship`` =
        Prefixed_Name(spdx, "Security/EpssVulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/LifecycleScopedRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>Provide context for a relationship that occurs in the lifecycle.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopedRelationship">https://spdx.org/rdf/3.1/terms/Core/LifecycleScopedRelationship</seealso>
    let ``Core/LifecycleScopedRelationship`` =
        Prefixed_Name(spdx, "Core/LifecycleScopedRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ElementMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>A key with an Element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ElementMap">https://spdx.org/rdf/3.1/terms/Core/ElementMap</seealso>
    let ``Core/ElementMap`` = Prefixed_Name(spdx, "Core/ElementMap") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/UnitOfMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>UnitofMeasure specify information structures through industry standards for Units of Measure, Quantity Kinds, Dimensions and Data Types.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/UnitOfMeasure">https://spdx.org/rdf/3.1/terms/Core/UnitOfMeasure</seealso>
    let ``Core/UnitOfMeasure`` =
        Prefixed_Name(spdx, "Core/UnitOfMeasure") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/PositiveIntegerRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>A tuple of two positive integers that define a range.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/PositiveIntegerRange">https://spdx.org/rdf/3.1/terms/Core/PositiveIntegerRange</seealso>
    let ``Core/PositiveIntegerRange`` =
        Prefixed_Name(spdx, "Core/PositiveIntegerRange") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An individual human being.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Person">https://spdx.org/rdf/3.1/terms/Core/Person</seealso>
    let ``Core/Person`` = Prefixed_Name(spdx, "Core/Person") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>A group of people who work together in an organized way for a shared purpose.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Organization">https://spdx.org/rdf/3.1/terms/Core/Organization</seealso>
    let ``Core/Organization`` = Prefixed_Name(spdx, "Core/Organization") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/MeasureOfMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The measure of mass refers to the quantity of matter in an object or substance.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/MeasureOfMass">https://spdx.org/rdf/3.1/terms/Core/MeasureOfMass</seealso>
    let ``Core/MeasureOfMass`` =
        Prefixed_Name(spdx, "Core/MeasureOfMass") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/Requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>A distinct unit representing a requirement, as used in systems, software, and hardware engineering.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Requirement">https://spdx.org/rdf/3.1/terms/Core/Requirement</seealso>
    let ``Core/Requirement`` = Prefixed_Name(spdx, "Core/Requirement") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SoftwareAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A software agent.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SoftwareAgent">https://spdx.org/rdf/3.1/terms/Core/SoftwareAgent</seealso>
    let ``Core/SoftwareAgent`` =
        Prefixed_Name(spdx, "Core/SoftwareAgent") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/CustomLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A license that is not listed on the SPDX License List.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/CustomLicense">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/CustomLicense</seealso>
    let ``ExpandedLicensing/CustomLicense`` =
        Prefixed_Name(spdx, "ExpandedLicensing/CustomLicense") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/OrLaterOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Portion of an AnyLicenseInfo representing this version, or any later version,
    /// of the indicated License.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/OrLaterOperator">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/OrLaterOperator</seealso>
    let ``ExpandedLicensing/OrLaterOperator`` =
        Prefixed_Name(spdx, "ExpandedLicensing/OrLaterOperator") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/ListedLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>A license that is listed on the SPDX License List.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ListedLicense">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ListedLicense</seealso>
    let ``ExpandedLicensing/ListedLicense`` =
        Prefixed_Name(spdx, "ExpandedLicensing/ListedLicense") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/WithAdditionOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Portion of an AnyLicenseInfo representing a License which has additional
    /// text applied to it.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/WithAdditionOperator">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/WithAdditionOperator</seealso>
    let ``ExpandedLicensing/WithAdditionOperator`` =
        Prefixed_Name(spdx, "ExpandedLicensing/WithAdditionOperator") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/IndividualLicensingInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A concrete subclass of AnyLicenseInfo used by Individuals in the
    /// ExpandedLicensing profile.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/IndividualLicensingInfo">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/IndividualLicensingInfo</seealso>
    let ``ExpandedLicensing/IndividualLicensingInfo`` =
        Prefixed_Name(spdx, "ExpandedLicensing/IndividualLicensingInfo") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/CustomLicenseAddition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A license addition that is not listed on the SPDX Exceptions List.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/CustomLicenseAddition">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/CustomLicenseAddition</seealso>
    let ``ExpandedLicensing/CustomLicenseAddition`` =
        Prefixed_Name(spdx, "ExpandedLicensing/CustomLicenseAddition") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/ExportControlClassificationAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Assement of an Element for export control classification.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/ExportControlClassificationAssessment">https://spdx.org/rdf/3.1/terms/Operations/ExportControlClassificationAssessment</seealso>
    let ``Operations/ExportControlClassificationAssessment`` =
        Prefixed_Name(spdx, "Operations/ExportControlClassificationAssessment") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/ExportControlClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Assement of an Element for export control classification.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/ExportControlClassification">https://spdx.org/rdf/3.1/terms/Operations/ExportControlClassification</seealso>
    let ``Operations/ExportControlClassification`` =
        Prefixed_Name(spdx, "Operations/ExportControlClassification") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/StateAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>This is the state of an affected Element at a specific moment in time.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/StateAction">https://spdx.org/rdf/3.1/terms/SupplyChain/StateAction</seealso>
    let ``SupplyChain/StateAction`` =
        Prefixed_Name(spdx, "SupplyChain/StateAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/PlanAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A PlanAction involves the execution of a plan in relation to a PlanProcess.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/PlanAction">https://spdx.org/rdf/3.1/terms/SupplyChain/PlanAction</seealso>
    let ``SupplyChain/PlanAction`` =
        Prefixed_Name(spdx, "SupplyChain/PlanAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/DestroyAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>The record of destruction is entered in this action.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/DestroyAction">https://spdx.org/rdf/3.1/terms/SupplyChain/DestroyAction</seealso>
    let ``SupplyChain/DestroyAction`` =
        Prefixed_Name(spdx, "SupplyChain/DestroyAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/ChangeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actual change to a product.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ChangeAction">https://spdx.org/rdf/3.1/terms/SupplyChain/ChangeAction</seealso>
    let ``SupplyChain/ChangeAction`` =
        Prefixed_Name(spdx, "SupplyChain/ChangeAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/StorageAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Records the storage of a product.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/StorageAction">https://spdx.org/rdf/3.1/terms/SupplyChain/StorageAction</seealso>
    let ``SupplyChain/StorageAction`` =
        Prefixed_Name(spdx, "SupplyChain/StorageAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/PlanProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Process plans outline the stages of implementation or use related to a process.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/PlanProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/PlanProcess</seealso>
    let ``SupplyChain/PlanProcess`` =
        Prefixed_Name(spdx, "SupplyChain/PlanProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/ReproduceAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Reproduction is the biological process by which organisms generate new individuals of the same species.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ReproduceAction">https://spdx.org/rdf/3.1/terms/SupplyChain/ReproduceAction</seealso>
    let ``SupplyChain/ReproduceAction`` =
        Prefixed_Name(spdx, "SupplyChain/ReproduceAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/ReproduceProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Reproduction is the biological process by which living organisms produce offspring.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ReproduceProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/ReproduceProcess</seealso>
    let ``SupplyChain/ReproduceProcess`` =
        Prefixed_Name(spdx, "SupplyChain/ReproduceProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/BoundaryCrossingAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An action of crossing a boundary is defined in this class.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/BoundaryCrossingAction">https://spdx.org/rdf/3.1/terms/SupplyChain/BoundaryCrossingAction</seealso>
    let ``SupplyChain/BoundaryCrossingAction`` =
        Prefixed_Name(spdx, "SupplyChain/BoundaryCrossingAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/InspectionProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>Inspection Process defines specific various processes needed to satisfy the inspection requirements for a specific product or service.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/InspectionProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/InspectionProcess</seealso>
    let ``SupplyChain/InspectionProcess`` =
        Prefixed_Name(spdx, "SupplyChain/InspectionProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/HarvestProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Harvest is the process of extracting goods or products from nature.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/HarvestProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/HarvestProcess</seealso>
    let ``SupplyChain/HarvestProcess`` =
        Prefixed_Name(spdx, "SupplyChain/HarvestProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/InspectionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An inspection action refers to a specific activity or set of activities performed during an inspection to examine, verify, or evaluate an item, process, or system.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/InspectionAction">https://spdx.org/rdf/3.1/terms/SupplyChain/InspectionAction</seealso>
    let ``SupplyChain/InspectionAction`` =
        Prefixed_Name(spdx, "SupplyChain/InspectionAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/ChangeProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A prescribed change to a product.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ChangeProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/ChangeProcess</seealso>
    let ``SupplyChain/ChangeProcess`` =
        Prefixed_Name(spdx, "SupplyChain/ChangeProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/ManufactureAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>ManufactureAction represents the act of creating a product by a manufacturing process.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ManufactureAction">https://spdx.org/rdf/3.1/terms/SupplyChain/ManufactureAction</seealso>
    let ``SupplyChain/ManufactureAction`` =
        Prefixed_Name(spdx, "SupplyChain/ManufactureAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/TransportAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>An actual change to a product's location.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/TransportAction">https://spdx.org/rdf/3.1/terms/SupplyChain/TransportAction</seealso>
    let ``SupplyChain/TransportAction`` =
        Prefixed_Name(spdx, "SupplyChain/TransportAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/Snippet</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>Describes a certain part of a file.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/Snippet">https://spdx.org/rdf/3.1/terms/Software/Snippet</seealso>
    let ``Software/Snippet`` = Prefixed_Name(spdx, "Software/Snippet") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/ContentIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>A canonical, unique, immutable identifier.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/ContentIdentifier">https://spdx.org/rdf/3.1/terms/Software/ContentIdentifier</seealso>
    let ``Software/ContentIdentifier`` =
        Prefixed_Name(spdx, "Software/ContentIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/VirtualHardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Class that describes an instance of VirtualHardware.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardware">https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardware</seealso>
    let ``Hardware/VirtualHardware`` =
        Prefixed_Name(spdx, "Hardware/VirtualHardware") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/Dimensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>Dimensions generally refer to measurable extents or attributes that define the size, shape, or scale of an object, system, or concept.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/Dimensions">https://spdx.org/rdf/3.1/terms/Hardware/Dimensions</seealso>
    let ``Hardware/Dimensions`` =
        Prefixed_Name(spdx, "Hardware/Dimensions") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/ProductSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>A product specification (product spec) is a detailed document that outlines the technical, functional, and design requirements of a product.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/ProductSpecification">https://spdx.org/rdf/3.1/terms/Hardware/ProductSpecification</seealso>
    let ``Hardware/ProductSpecification`` =
        Prefixed_Name(spdx, "Hardware/ProductSpecification") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/PhysicalHardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Class that describes a physical instance of Hardware.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/PhysicalHardware">https://spdx.org/rdf/3.1/terms/Hardware/PhysicalHardware</seealso>
    let ``Hardware/PhysicalHardware`` =
        Prefixed_Name(spdx, "Hardware/PhysicalHardware") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/buildSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>A reference build system used to create or publish the package.</para>
    /// labels<para>buildSystem</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/buildSystem">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/buildSystem</seealso>
    let ``Core/ExternalRefType/buildSystem`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/buildSystem") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/chat</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to the instant messaging system used by the maintainer for a package.</para>
    /// labels<para>chat</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/chat">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/chat</seealso>
    let ``Core/ExternalRefType/chat`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/chat") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/certificationReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to a certification report for a package from an accredited/independent body.</para>
    /// labels<para>certificationReport</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/certificationReport">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/certificationReport</seealso>
    let ``Core/ExternalRefType/certificationReport`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/certificationReport") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/componentAnalysisReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>A reference to a Software Composition Analysis (SCA) report.</para>
    /// labels<para>componentAnalysisReport</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/componentAnalysisReport">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/componentAnalysisReport</seealso>
    let ``Core/ExternalRefType/componentAnalysisReport`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/componentAnalysisReport") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/cwe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>[Common Weakness Enumeration](https://csrc.nist.gov/glossary/term/common_weakness_enumeration). A reference to a source of software flaw defined within the official [CWE List](https://cwe.mitre.org/data/) that conforms to the [CWE specification](https://cwe.mitre.org/).</para>
    /// labels<para>cwe</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/cwe">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/cwe</seealso>
    let ``Core/ExternalRefType/cwe`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/cwe") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/documentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>A reference to the documentation for a package.</para>
    /// labels<para>documentation</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/documentation">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/documentation</seealso>
    let ``Core/ExternalRefType/documentation`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/documentation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/dynamicAnalysisReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to a dynamic analysis report for a package.</para>
    /// labels<para>dynamicAnalysisReport</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/dynamicAnalysisReport">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/dynamicAnalysisReport</seealso>
    let ``Core/ExternalRefType/dynamicAnalysisReport`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/dynamicAnalysisReport") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/eolNotice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>A reference to the End Of Sale (EOS) and/or End Of Life (EOL) information related to a package.</para>
    /// labels<para>eolNotice</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/eolNotice">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/eolNotice</seealso>
    let ``Core/ExternalRefType/eolNotice`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/eolNotice") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/riskAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>A reference to a risk assessment for a package.</para>
    /// labels<para>riskAssessment</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/riskAssessment">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/riskAssessment</seealso>
    let ``Core/ExternalRefType/riskAssessment`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/riskAssessment") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/runtimeAnalysisReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to a runtime analysis report for a package.</para>
    /// labels<para>runtimeAnalysisReport</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/runtimeAnalysisReport">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/runtimeAnalysisReport</seealso>
    let ``Core/ExternalRefType/runtimeAnalysisReport`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/runtimeAnalysisReport") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/secureSoftwareAttestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>A reference to information assuring that the software is developed using security practices as defined by [NIST SP 800-218 Secure Software Development Framework (SSDF) Version 1.1](https://csrc.nist.gov/pubs/sp/800/218/final) or [CISA Secure Software Development Attestation Form](https://www.cisa.gov/resources-tools/resources/secure-software-development-attestation-form).</para>
    /// labels<para>secureSoftwareAttestation</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/secureSoftwareAttestation">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/secureSoftwareAttestation</seealso>
    let ``Core/ExternalRefType/secureSoftwareAttestation`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/secureSoftwareAttestation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/securityAdvisory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>A reference to a published security advisory (where advisory as defined per [ISO 29147:2018](https://www.iso.org/standard/72311.html)) that may affect one or more elements, e.g., vendor advisories or specific NVD entries.</para>
    /// labels<para>securityAdvisory</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityAdvisory">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityAdvisory</seealso>
    let ``Core/ExternalRefType/securityAdvisory`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/securityAdvisory") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/securityAdversaryModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>A reference to the security adversary model for a package.</para>
    /// labels<para>securityAdversaryModel</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityAdversaryModel">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityAdversaryModel</seealso>
    let ``Core/ExternalRefType/securityAdversaryModel`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/securityAdversaryModel") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/securityFix</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to the patch or source code that fixes a vulnerability.</para>
    /// labels<para>securityFix</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityFix">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityFix</seealso>
    let ``Core/ExternalRefType/securityFix`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/securityFix") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/securityOther</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to related security information of unspecified type.</para>
    /// labels<para>securityOther</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityOther">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityOther</seealso>
    let ``Core/ExternalRefType/securityOther`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/securityOther") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/securityPenTestReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>A reference to a [penetration test](https://en.wikipedia.org/wiki/Penetration_test) report for a package.</para>
    /// labels<para>securityPenTestReport</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityPenTestReport">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityPenTestReport</seealso>
    let ``Core/ExternalRefType/securityPenTestReport`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/securityPenTestReport") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/LifecycleScopeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Provide an enumerated set of lifecycle phases that can provide context to relationships.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType">https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType</seealso>
    let ``Core/LifecycleScopeType`` =
        Prefixed_Name(spdx, "Core/LifecycleScopeType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/LifecycleScopeType/build</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/LifecycleScopeType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A relationship has specific context implications during an element's build phase, during development.</para>
    /// labels<para>build</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/build">https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/build</seealso>
    let ``Core/LifecycleScopeType/build`` =
        Prefixed_Name(spdx, "Core/LifecycleScopeType/build") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/LifecycleScopeType/decommission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/LifecycleScopeType</para>
    ///   <para>A relationship has specific context implications for a product's retirement and/or decommissioning.</para>
    /// labels<para>decommission</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/decommission">https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/decommission</seealso>
    let ``Core/LifecycleScopeType/decommission`` =
        Prefixed_Name(spdx, "Core/LifecycleScopeType/decommission") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/LifecycleScopeType/design</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/LifecycleScopeType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A relationship has specific context implications during an element's design.</para>
    /// labels<para>design</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/design">https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/design</seealso>
    let ``Core/LifecycleScopeType/design`` =
        Prefixed_Name(spdx, "Core/LifecycleScopeType/design") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/LifecycleScopeType/development</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/LifecycleScopeType</para>
    ///   <para>A relationship has specific context implications during development phase of an element.</para>
    /// labels<para>development</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/development">https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/development</seealso>
    let ``Core/LifecycleScopeType/development`` =
        Prefixed_Name(spdx, "Core/LifecycleScopeType/development") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/LifecycleScopeType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/LifecycleScopeType</para>
    ///   <para>A relationship has other specific context information necessary to capture that the above set of enumerations does not handle.</para>
    /// labels<para>other</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/other">https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/other</seealso>
    let ``Core/LifecycleScopeType/other`` =
        Prefixed_Name(spdx, "Core/LifecycleScopeType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/LifecycleScopeType/runtime</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/LifecycleScopeType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A relationship has specific context implications during the execution phase of an element.</para>
    /// labels<para>runtime</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/runtime">https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/runtime</seealso>
    let ``Core/LifecycleScopeType/runtime`` =
        Prefixed_Name(spdx, "Core/LifecycleScopeType/runtime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/LifecycleScopeType/test</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/LifecycleScopeType</para>
    ///   <para>A relationship has specific context implications during an element's testing phase, during development.</para>
    /// labels<para>test</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/test">https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/test</seealso>
    let ``Core/LifecycleScopeType/test`` =
        Prefixed_Name(spdx, "Core/LifecycleScopeType/test") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/LifecycleScopeType/update</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/LifecycleScopeType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A relationship has specific context implications for a product update.</para>
    /// labels<para>update</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/update">https://spdx.org/rdf/3.1/terms/Core/LifecycleScopeType/update</seealso>
    let ``Core/LifecycleScopeType/update`` =
        Prefixed_Name(spdx, "Core/LifecycleScopeType/update") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A substitute for a URI.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/prefix">https://spdx.org/rdf/3.1/terms/Core/prefix</seealso>
    let ``Core/prefix`` = Prefixed_Name(spdx, "Core/prefix") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/namespace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides an unambiguous mechanism for conveying a URI fragment portion of an
    /// Element ID.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/namespace">https://spdx.org/rdf/3.1/terms/Core/namespace</seealso>
    let ``Core/namespace`` = Prefixed_Name(spdx, "Core/namespace") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/NoAssertionElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/IndividualElement</para>
    ///   <para>An Individual Value for Element representing a set of Elements of unknown
    /// identity or cardinality (number).</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/NoAssertionElement">https://spdx.org/rdf/3.1/terms/Core/NoAssertionElement</seealso>
    let ``Core/NoAssertionElement`` =
        Prefixed_Name(spdx, "Core/NoAssertionElement") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/NoneElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/IndividualElement</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An Individual Value for Element representing a set of Elements with
    /// cardinality (number/count) of zero.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/NoneElement">https://spdx.org/rdf/3.1/terms/Core/NoneElement</seealso>
    let ``Core/NoneElement`` = Prefixed_Name(spdx, "Core/NoneElement") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/headquartersLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The headquartersLocation defines the location of the organization's headquarters.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/headquartersLocation">https://spdx.org/rdf/3.1/terms/Core/headquartersLocation</seealso>
    let ``Core/headquartersLocation`` =
        Prefixed_Name(spdx, "Core/headquartersLocation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/packageVerificationCodeExcludedFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The relative file name of a file to be excluded from the
    /// `PackageVerificationCode`.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/packageVerificationCodeExcludedFile">https://spdx.org/rdf/3.1/terms/Core/packageVerificationCodeExcludedFile</seealso>
    let ``Core/packageVerificationCodeExcludedFile`` =
        Prefixed_Name(spdx, "Core/packageVerificationCodeExcludedFile") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/city</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>City is a specific name used to define a locality.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/city">https://spdx.org/rdf/3.1/terms/Core/city</seealso>
    let ``Core/city`` = Prefixed_Name(spdx, "Core/city") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/countyCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A code that identifies a county.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/countyCode">https://spdx.org/rdf/3.1/terms/Core/countyCode</seealso>
    let ``Core/countyCode`` = Prefixed_Name(spdx, "Core/countyCode") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/postalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of the recipient expressed in text.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/postalName">https://spdx.org/rdf/3.1/terms/Core/postalName</seealso>
    let ``Core/postalName`` = Prefixed_Name(spdx, "Core/postalName") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/provinceStateCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Text specifying a province or state.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/provinceStateCode">https://spdx.org/rdf/3.1/terms/Core/provinceStateCode</seealso>
    let ``Core/provinceStateCode`` =
        Prefixed_Name(spdx, "Core/provinceStateCode") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/geographicPointLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>This is a set of point coordinates as defined in by the GPS standard.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/geographicPointLocation">https://spdx.org/rdf/3.1/terms/Core/geographicPointLocation</seealso>
    let ``Core/geographicPointLocation`` =
        Prefixed_Name(spdx, "Core/geographicPointLocation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies a country code of the location.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/country">https://spdx.org/rdf/3.1/terms/Core/country</seealso>
    let ``Core/country`` = Prefixed_Name(spdx, "Core/country") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/postOfficeBoxNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number that identifies a PO box. A PO box is a box in a post office or other postal service location assigned to an organization where postal items may be kept.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/postOfficeBoxNumber">https://spdx.org/rdf/3.1/terms/Core/postOfficeBoxNumber</seealso>
    let ``Core/postOfficeBoxNumber`` =
        Prefixed_Name(spdx, "Core/postOfficeBoxNumber") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/streetAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Street address includes a street number, name and unit ID to identify a specific street.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/streetAddress">https://spdx.org/rdf/3.1/terms/Core/streetAddress</seealso>
    let ``Core/streetAddress`` =
        Prefixed_Name(spdx, "Core/streetAddress") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/postalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Text specifying the postal code for an address.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/postalCode">https://spdx.org/rdf/3.1/terms/Core/postalCode</seealso>
    let ``Core/postalCode`` = Prefixed_Name(spdx, "Core/postalCode") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/endIntegerRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Defines the end of a range.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/endIntegerRange">https://spdx.org/rdf/3.1/terms/Core/endIntegerRange</seealso>
    let ``Core/endIntegerRange`` =
        Prefixed_Name(spdx, "Core/endIntegerRange") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/beginIntegerRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Defines the beginning of a range.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/beginIntegerRange">https://spdx.org/rdf/3.1/terms/Core/beginIntegerRange</seealso>
    let ``Core/beginIntegerRange`` =
        Prefixed_Name(spdx, "Core/beginIntegerRange") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/affects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Vulnerability, Action or DefinedProcess affects each `to` Element.</para>
    /// labels<para>affects</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/affects">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/affects</seealso>
    let ``Core/RelationshipType/affects`` =
        Prefixed_Name(spdx, "Core/RelationshipType/affects") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/amendedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Element is amended by each `to` Element.</para>
    /// labels<para>amendedBy</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/amendedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/amendedBy</seealso>
    let ``Core/RelationshipType/amendedBy`` =
        Prefixed_Name(spdx, "Core/RelationshipType/amendedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/ancestorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Element is an ancestor of each `to` Element.</para>
    /// labels<para>ancestorOf</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/ancestorOf">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/ancestorOf</seealso>
    let ``Core/RelationshipType/ancestorOf`` =
        Prefixed_Name(spdx, "Core/RelationshipType/ancestorOf") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/availableFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Element is available from the additional supplier described by each `to` Element.</para>
    /// labels<para>availableFrom</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/availableFrom">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/availableFrom</seealso>
    let ``Core/RelationshipType/availableFrom`` =
        Prefixed_Name(spdx, "Core/RelationshipType/availableFrom") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/configures</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Element is a configuration applied to each `to` Element, during a LifecycleScopeType period.</para>
    /// labels<para>configures</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/configures">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/configures</seealso>
    let ``Core/RelationshipType/configures`` =
        Prefixed_Name(spdx, "Core/RelationshipType/configures") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/conformsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Element conforms to each `to` Specification.</para>
    /// labels<para>conformsTo</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/conformsTo">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/conformsTo</seealso>
    let ``Core/RelationshipType/conformsTo`` =
        Prefixed_Name(spdx, "Core/RelationshipType/conformsTo") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Element contains each `to` Element.</para>
    /// labels<para>contains</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/contains">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/contains</seealso>
    let ``Core/RelationshipType/contains`` =
        Prefixed_Name(spdx, "Core/RelationshipType/contains") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/coordinatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Vulnerability is coordinatedBy the `to` Agent(s) (vendor, researcher, or consumer agent).</para>
    /// labels<para>coordinatedBy</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/coordinatedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/coordinatedBy</seealso>
    let ``Core/RelationshipType/coordinatedBy`` =
        Prefixed_Name(spdx, "Core/RelationshipType/coordinatedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/copiedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Element has been copied to each `to` Element.</para>
    /// labels<para>copiedTo</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/copiedTo">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/copiedTo</seealso>
    let ``Core/RelationshipType/copiedTo`` =
        Prefixed_Name(spdx, "Core/RelationshipType/copiedTo") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/createdBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Element's Action or DefinedProcess is createdBy `to` Agent(s).</para>
    /// labels<para>createdBy</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/createdBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/createdBy</seealso>
    let ``Core/RelationshipType/createdBy`` =
        Prefixed_Name(spdx, "Core/RelationshipType/createdBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/delegatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Agent is delegating an action to the Agent of the `to` Relationship (which shall be of type invokedBy), during a LifecycleScopeType (e.g. the `to` invokedBy Relationship is being done on behalf of `from`).</para>
    /// labels<para>delegatedTo</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/delegatedTo">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/delegatedTo</seealso>
    let ``Core/RelationshipType/delegatedTo`` =
        Prefixed_Name(spdx, "Core/RelationshipType/delegatedTo") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/dependsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Element depends on each `to` Element, during a LifecycleScopeType period.</para>
    /// labels<para>dependsOn</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/dependsOn">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/dependsOn</seealso>
    let ``Core/RelationshipType/dependsOn`` =
        Prefixed_Name(spdx, "Core/RelationshipType/dependsOn") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/descendantOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Element is a descendant of each `to` Element.</para>
    /// labels<para>descendantOf</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/descendantOf">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/descendantOf</seealso>
    let ``Core/RelationshipType/descendantOf`` =
        Prefixed_Name(spdx, "Core/RelationshipType/descendantOf") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/describes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Element describes each `to` Element. To denote the root(s) of a tree of elements in a collection, the rootElement property shall be used.</para>
    /// labels<para>describes</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/describes">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/describes</seealso>
    let ``Core/RelationshipType/describes`` =
        Prefixed_Name(spdx, "Core/RelationshipType/describes") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/doesNotAffect</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Vulnerability has no impact on each `to` Element. The use of the `doesNotAffect` is constrained to `VexNotAffectedVulnAssessmentRelationship` classed relationships.</para>
    /// labels<para>doesNotAffect</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/doesNotAffect">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/doesNotAffect</seealso>
    let ``Core/RelationshipType/doesNotAffect`` =
        Prefixed_Name(spdx, "Core/RelationshipType/doesNotAffect") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/evaluatedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Element has been evaluated on the `to` Element(s).</para>
    /// labels<para>evaluatedOn</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/evaluatedOn">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/evaluatedOn</seealso>
    let ``Core/RelationshipType/evaluatedOn`` =
        Prefixed_Name(spdx, "Core/RelationshipType/evaluatedOn") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasContactPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Artifact has each `to` Agent as a contact point. The use of `hasContactPoint` type is constrained to `ContactPointRelationship` typed relationships. The type of contact (i.e. security) may be specified using a `ContactPointRelationship` element.</para>
    /// labels<para>hasContactPoint</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasContactPoint">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasContactPoint</seealso>
    let ``Core/RelationshipType/hasContactPoint`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasContactPoint") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasDataFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Element treats each `to` Element as a data file. A data file is an artifact that stores data required or optional for the `from` Element's functionality. A data file can be a database file, an index file, a log file, an AI model file, a calibration data file, a temporary file, a backup file, and more. For AI training dataset, test dataset, test artifact, configuration data, build input data, and build output data, please consider using the more specific relationship types: `trainedOn`, `testedOn`, `hasTest`, `configures`, `hasInput`, and `hasOutput`, respectively. This relationship does not imply dependency.</para>
    /// labels<para>hasDataFile</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDataFile">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDataFile</seealso>
    let ``Core/RelationshipType/hasDataFile`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasDataFile") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasDeclaredLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` SoftwareArtifact was discovered to actually contain each `to` AnyLicenseInfo (for example, as detected by automated tooling).</para>
    /// labels<para>hasDeclaredLicense</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDeclaredLicense">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDeclaredLicense</seealso>
    let ``Core/RelationshipType/hasDeclaredLicense`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasDeclaredLicense") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasDeletedFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Every `to` Element is a file deleted from the `from` Element (`from` hasDeletedFile `to`).</para>
    /// labels<para>hasDeletedFile</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDeletedFile">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDeletedFile</seealso>
    let ``Core/RelationshipType/hasDeletedFile`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasDeletedFile") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasDependencyManifest</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Element has manifest files that contain dependency information in each `to` Element.</para>
    /// labels<para>hasDependencyManifest</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDependencyManifest">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDependencyManifest</seealso>
    let ``Core/RelationshipType/hasDependencyManifest`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasDependencyManifest") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasDistributionArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Element is distributed as an artifact in each `to` Element (e.g. an RPM or archive file).</para>
    /// labels<para>hasDistributionArtifact</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDistributionArtifact">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDistributionArtifact</seealso>
    let ``Core/RelationshipType/hasDistributionArtifact`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasDistributionArtifact") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Element is documented by each `to` Element.</para>
    /// labels<para>hasDocumentation</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDocumentation">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDocumentation</seealso>
    let ``Core/RelationshipType/hasDocumentation`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasDynamicLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Element dynamically links in each `to` Element, during a LifecycleScopeType period.</para>
    /// labels<para>hasDynamicLink</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDynamicLink">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasDynamicLink</seealso>
    let ``Core/RelationshipType/hasDynamicLink`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasDynamicLink") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasEvidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>Every `to` Element is considered as evidence for the `from` Element (`from` hasEvidence `to`).</para>
    /// labels<para>hasEvidence</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasEvidence">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasEvidence</seealso>
    let ``Core/RelationshipType/hasEvidence`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasEvidence") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasExample</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Every `to` Element is an example for the `from` Element (`from` hasExample `to`).</para>
    /// labels<para>hasExample</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasExample">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasExample</seealso>
    let ``Core/RelationshipType/hasExample`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasExample") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasHost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Build was run on the `to` Element during a LifecycleScopeType period (e.g. the host that the build runs on).</para>
    /// labels<para>hasHost</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasHost">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasHost</seealso>
    let ``Core/RelationshipType/hasHost`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasHost") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Build, DefinedProcess or Action element has each `to` Element as an input.</para>
    /// labels<para>hasInput</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasInput">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasInput</seealso>
    let ``Core/RelationshipType/hasInput`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasInput") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Every `to` Element is metadata about the `from` Element (`from` hasMetadata `to`).</para>
    /// labels<para>hasMetadata</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasMetadata">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasMetadata</seealso>
    let ``Core/RelationshipType/hasMetadata`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasMetadata") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasOptionalComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>Every `to` Element is an optional component of the `from` Element (`from` hasOptionalComponent `to`).</para>
    /// labels<para>hasOptionalComponent</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasOptionalComponent">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasOptionalComponent</seealso>
    let ``Core/RelationshipType/hasOptionalComponent`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasOptionalComponent") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasOptionalDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Element optionally depends on each `to` Element, during a LifecycleScopeType period.</para>
    /// labels<para>hasOptionalDependency</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasOptionalDependency">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasOptionalDependency</seealso>
    let ``Core/RelationshipType/hasOptionalDependency`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasOptionalDependency") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Build, DefinedProcess or Action element generates each `to` Element as an output.</para>
    /// labels<para>hasOutput</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasOutput">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasOutput</seealso>
    let ``Core/RelationshipType/hasOutput`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasOutput") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/modifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Element is modified by each `to` Element.</para>
    /// labels<para>modifiedBy</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/modifiedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/modifiedBy</seealso>
    let ``Core/RelationshipType/modifiedBy`` =
        Prefixed_Name(spdx, "Core/RelationshipType/modifiedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Every `to` Element is related to the `from` Element where the relationship type is not described by any of the SPDX relationship types (this relationship is directionless).</para>
    /// labels<para>other</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/other">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/other</seealso>
    let ``Core/RelationshipType/other`` =
        Prefixed_Name(spdx, "Core/RelationshipType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/packagedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>Every `to` Element is a packaged instance of the `from` Element (`from` packagedBy `to`).</para>
    /// labels<para>packagedBy</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/packagedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/packagedBy</seealso>
    let ``Core/RelationshipType/packagedBy`` =
        Prefixed_Name(spdx, "Core/RelationshipType/packagedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/patchedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Every `to` Element is a patch for the `from` Element (`from` patchedBy `to`).</para>
    /// labels<para>patchedBy</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/patchedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/patchedBy</seealso>
    let ``Core/RelationshipType/patchedBy`` =
        Prefixed_Name(spdx, "Core/RelationshipType/patchedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/pretrainedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Element has been pretrained on the `to` Element(s).</para>
    /// labels<para>pretrainedOn</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/pretrainedOn">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/pretrainedOn</seealso>
    let ``Core/RelationshipType/pretrainedOn`` =
        Prefixed_Name(spdx, "Core/RelationshipType/pretrainedOn") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/providesSupportFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Agent provides support for each `to` Artifact. Shall be a `SupportRelationship` type.</para>
    /// labels<para>providesSupportFor</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/providesSupportFor">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/providesSupportFor</seealso>
    let ``Core/RelationshipType/providesSupportFor`` =
        Prefixed_Name(spdx, "Core/RelationshipType/providesSupportFor") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/performedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Every `from` action is performedBy `to` Agent.</para>
    /// labels<para>performedBy</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/performedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/performedBy</seealso>
    let ``Core/RelationshipType/performedBy`` =
        Prefixed_Name(spdx, "Core/RelationshipType/performedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/publishedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>Designates a `from` Vulnerability was made available for public use or reference by each `to` Agent.</para>
    /// labels<para>publishedBy</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/publishedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/publishedBy</seealso>
    let ``Core/RelationshipType/publishedBy`` =
        Prefixed_Name(spdx, "Core/RelationshipType/publishedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/reportedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>Designates a `from` Vulnerability was first reported to a project, vendor, or tracking database for formal identification by each `to` Agent.</para>
    /// labels<para>reportedBy</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/reportedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/reportedBy</seealso>
    let ``Core/RelationshipType/reportedBy`` =
        Prefixed_Name(spdx, "Core/RelationshipType/reportedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/republishedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Designates a `from` Vulnerability's details were tracked, aggregated, and/or enriched to improve context (i.e. NVD) by each `to` Agent.</para>
    /// labels<para>republishedBy</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/republishedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/republishedBy</seealso>
    let ``Core/RelationshipType/republishedBy`` =
        Prefixed_Name(spdx, "Core/RelationshipType/republishedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/resolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `to` OutOfSpecAction is resolved in the `from` ResolutionAction.</para>
    /// labels<para>resolved</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/resolved">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/resolved</seealso>
    let ``Core/RelationshipType/resolved`` =
        Prefixed_Name(spdx, "Core/RelationshipType/resolved") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/runsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Element (the instructions) of runs on each `to` Hardware (processing element), during a LifecycleScopeType period.</para>
    /// labels<para>runsOn</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/runsOn">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/runsOn</seealso>
    let ``Core/RelationshipType/runsOn`` =
        Prefixed_Name(spdx, "Core/RelationshipType/runsOn") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/serializedInArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` SpdxDocument can be found in a serialized form in each `to` Artifact.</para>
    /// labels<para>serializedInArtifact</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/serializedInArtifact">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/serializedInArtifact</seealso>
    let ``Core/RelationshipType/serializedInArtifact`` =
        Prefixed_Name(spdx, "Core/RelationshipType/serializedInArtifact") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/testedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Element has been tested on the `to` Element(s).</para>
    /// labels<para>testedOn</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/testedOn">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/testedOn</seealso>
    let ``Core/RelationshipType/testedOn`` =
        Prefixed_Name(spdx, "Core/RelationshipType/testedOn") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/tracedToDetail</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>the `from` Requirement is refined and further elaborated by each `to` Requirement, which contains more detailed implementation information.</para>
    /// labels<para>tracedToDetail</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/tracedToDetail">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/tracedToDetail</seealso>
    let ``Core/RelationshipType/tracedToDetail`` =
        Prefixed_Name(spdx, "Core/RelationshipType/tracedToDetail") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/trainedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Element has been trained on the `to` Element(s).</para>
    /// labels<para>trainedOn</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/trainedOn">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/trainedOn</seealso>
    let ``Core/RelationshipType/trainedOn`` =
        Prefixed_Name(spdx, "Core/RelationshipType/trainedOn") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/video</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Data is video based, such as a collection of movie clips featuring Tom Hanks.</para>
    /// labels<para>video</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/video">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/video</seealso>
    let ``Dataset/DatasetType/video`` =
        Prefixed_Name(spdx, "Dataset/DatasetType/video") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/datasetType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Type of data in a dataset.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/datasetType">https://spdx.org/rdf/3.1/terms/Dataset/datasetType</seealso>
    let ``Dataset/datasetType`` =
        Prefixed_Name(spdx, "Dataset/datasetType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/knownBias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Records the biases that the dataset is known to encompass.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/knownBias">https://spdx.org/rdf/3.1/terms/Dataset/knownBias</seealso>
    let ``Dataset/knownBias`` = Prefixed_Name(spdx, "Dataset/knownBias") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/confidentialityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Confidentiality level of the data points contained in the dataset.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/confidentialityLevel">https://spdx.org/rdf/3.1/terms/Dataset/confidentialityLevel</seealso>
    let ``Dataset/confidentialityLevel`` =
        Prefixed_Name(spdx, "Dataset/confidentialityLevel") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/hasSensitivePersonalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes if any sensitive personal information is present in the dataset.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/hasSensitivePersonalInformation">https://spdx.org/rdf/3.1/terms/Dataset/hasSensitivePersonalInformation</seealso>
    let ``Dataset/hasSensitivePersonalInformation`` =
        Prefixed_Name(spdx, "Dataset/hasSensitivePersonalInformation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/datasetSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>**DEPRECATED in SPDX 3.1.**
    /// Use [/Software/artifactSize](../../Software/Properties/artifactSize.md)
    /// instead.
    ///
    /// Size of the dataset.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/datasetSize">https://spdx.org/rdf/3.1/terms/Dataset/datasetSize</seealso>
    let ``Dataset/datasetSize`` =
        Prefixed_Name(spdx, "Dataset/datasetSize") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/anonymizationMethodUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Anonymization methods used.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/anonymizationMethodUsed">https://spdx.org/rdf/3.1/terms/Dataset/anonymizationMethodUsed</seealso>
    let ``Dataset/anonymizationMethodUsed`` =
        Prefixed_Name(spdx, "Dataset/anonymizationMethodUsed") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/subjectAddition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A LicenseAddition participating in a 'with addition' model.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/subjectAddition">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/subjectAddition</seealso>
    let ``ExpandedLicensing/subjectAddition`` =
        Prefixed_Name(spdx, "ExpandedLicensing/subjectAddition") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/subjectExtendableLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A License participating in a 'with addition' model.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/subjectExtendableLicense">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/subjectExtendableLicense</seealso>
    let ``ExpandedLicensing/subjectExtendableLicense`` =
        Prefixed_Name(spdx, "ExpandedLicensing/subjectExtendableLicense") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Extension/CdxPropertiesExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>A type of extension consisting of a list of name value pairs.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Extension/CdxPropertiesExtension">https://spdx.org/rdf/3.1/terms/Extension/CdxPropertiesExtension</seealso>
    let ``Extension/CdxPropertiesExtension`` =
        Prefixed_Name(spdx, "Extension/CdxPropertiesExtension") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Extension/cdxProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Provides a map of a property name to a value.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Extension/cdxProperty">https://spdx.org/rdf/3.1/terms/Extension/cdxProperty</seealso>
    let ``Extension/cdxProperty`` =
        Prefixed_Name(spdx, "Extension/cdxProperty") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Extension/cdxPropName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A name used in a CdxPropertyEntry name-value pair.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Extension/cdxPropName">https://spdx.org/rdf/3.1/terms/Extension/cdxPropName</seealso>
    let ``Extension/cdxPropName`` =
        Prefixed_Name(spdx, "Extension/cdxPropName") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Extension/cdxPropValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A value used in a CdxPropertyEntry name-value pair.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Extension/cdxPropValue">https://spdx.org/rdf/3.1/terms/Extension/cdxPropValue</seealso>
    let ``Extension/cdxPropValue`` =
        Prefixed_Name(spdx, "Extension/cdxPropValue") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/mass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Information related to physical hardware.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/mass">https://spdx.org/rdf/3.1/terms/Hardware/mass</seealso>
    let ``Hardware/mass`` = Prefixed_Name(spdx, "Hardware/mass") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/exportControlSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specification basis for the export control classification.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/exportControlSpecification">https://spdx.org/rdf/3.1/terms/Operations/exportControlSpecification</seealso>
    let ``Operations/exportControlSpecification`` =
        Prefixed_Name(spdx, "Operations/exportControlSpecification") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Weight to express relevance in de minimis consideration.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/weight">https://spdx.org/rdf/3.1/terms/Operations/weight</seealso>
    let ``Operations/weight`` = Prefixed_Name(spdx, "Operations/weight") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/exportClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Expression for the export control classification.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/exportClassification">https://spdx.org/rdf/3.1/terms/Operations/exportClassification</seealso>
    let ``Operations/exportClassification`` =
        Prefixed_Name(spdx, "Operations/exportClassification") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/exportingCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Country for which export controls must be taken into account.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/exportingCountry">https://spdx.org/rdf/3.1/terms/Operations/exportingCountry</seealso>
    let ``Operations/exportingCountry`` =
        Prefixed_Name(spdx, "Operations/exportingCountry") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/assessmentTimestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Timestamp, when an assessment was conducted.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/assessmentTimestamp">https://spdx.org/rdf/3.1/terms/Operations/assessmentTimestamp</seealso>
    let ``Operations/assessmentTimestamp`` =
        Prefixed_Name(spdx, "Operations/assessmentTimestamp") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/assessmentResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies an Element as subject of an assessment.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/assessmentResult">https://spdx.org/rdf/3.1/terms/Operations/assessmentResult</seealso>
    let ``Operations/assessmentResult`` =
        Prefixed_Name(spdx, "Operations/assessmentResult") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/assessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An entity providing an assessment.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/assessor">https://spdx.org/rdf/3.1/terms/Operations/assessor</seealso>
    let ``Operations/assessor`` =
        Prefixed_Name(spdx, "Operations/assessor") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/assessedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies an Element as subject of an assessment.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/assessedElement">https://spdx.org/rdf/3.1/terms/Operations/assessedElement</seealso>
    let ``Operations/assessedElement`` =
        Prefixed_Name(spdx, "Operations/assessedElement") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/assessmentContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Sets the context for an assessment iby specifying the related project.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/assessmentContext">https://spdx.org/rdf/3.1/terms/Operations/assessmentContext</seealso>
    let ``Operations/assessmentContext`` =
        Prefixed_Name(spdx, "Operations/assessmentContext") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/projectStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Time when the project starts or is planned to start.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/projectStartTime">https://spdx.org/rdf/3.1/terms/Operations/projectStartTime</seealso>
    let ``Operations/projectStartTime`` =
        Prefixed_Name(spdx, "Operations/projectStartTime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/projectEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Time when the project ends or is planned to end.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/projectEndTime">https://spdx.org/rdf/3.1/terms/Operations/projectEndTime</seealso>
    let ``Operations/projectEndTime`` =
        Prefixed_Name(spdx, "Operations/projectEndTime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/projectOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Owner or Lead of the project.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/projectOwner">https://spdx.org/rdf/3.1/terms/Operations/projectOwner</seealso>
    let ``Operations/projectOwner`` =
        Prefixed_Name(spdx, "Operations/projectOwner") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/projectSponsor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Sponsor of the project.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/projectSponsor">https://spdx.org/rdf/3.1/terms/Operations/projectSponsor</seealso>
    let ``Operations/projectSponsor`` =
        Prefixed_Name(spdx, "Operations/projectSponsor") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/projectContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Link to the project contract.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/projectContract">https://spdx.org/rdf/3.1/terms/Operations/projectContract</seealso>
    let ``Operations/projectContract`` =
        Prefixed_Name(spdx, "Operations/projectContract") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/projectTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Title of the project.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/projectTitle">https://spdx.org/rdf/3.1/terms/Operations/projectTitle</seealso>
    let ``Operations/projectTitle`` =
        Prefixed_Name(spdx, "Operations/projectTitle") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/exportControlClassificationResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides the result of an export control assessment.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/exportControlClassificationResult">https://spdx.org/rdf/3.1/terms/Operations/exportControlClassificationResult</seealso>
    let ``Operations/exportControlClassificationResult`` =
        Prefixed_Name(spdx, "Operations/exportControlClassificationResult") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/vectorString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies the CVSS vector string for a vulnerability.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/vectorString">https://spdx.org/rdf/3.1/terms/Security/vectorString</seealso>
    let ``Security/vectorString`` =
        Prefixed_Name(spdx, "Security/vectorString") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/score</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides a numerical (0-10) representation of the severity of a vulnerability.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/score">https://spdx.org/rdf/3.1/terms/Security/score</seealso>
    let ``Security/score`` = Prefixed_Name(spdx, "Security/score") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Security/severity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the CVSS qualitative severity rating of a vulnerability in relation to a piece of software.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/severity">https://spdx.org/rdf/3.1/terms/Security/severity</seealso>
    let ``Security/severity`` = Prefixed_Name(spdx, "Security/severity") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/percentile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The percentile of the current probability score.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/percentile">https://spdx.org/rdf/3.1/terms/Security/percentile</seealso>
    let ``Security/percentile`` =
        Prefixed_Name(spdx, "Security/percentile") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/probability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A probability score between 0 and 1 of a vulnerability being exploited.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/probability">https://spdx.org/rdf/3.1/terms/Security/probability</seealso>
    let ``Security/probability`` =
        Prefixed_Name(spdx, "Security/probability") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/ExploitCatalogType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specifies the exploit catalog type.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogType">https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogType</seealso>
    let ``Security/ExploitCatalogType`` =
        Prefixed_Name(spdx, "Security/ExploitCatalogType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/ExploitCatalogType/kev</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Security/ExploitCatalogType</para>
    ///   <para>CISA's Known Exploited Vulnerability (KEV) catalog.</para>
    /// labels<para>kev</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogType/kev">https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogType/kev</seealso>
    let ``Security/ExploitCatalogType/kev`` =
        Prefixed_Name(spdx, "Security/ExploitCatalogType/kev") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/ExploitCatalogType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Security/ExploitCatalogType</para>
    ///   <para>Other exploit catalogs.</para>
    /// labels<para>other</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogType/other">https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogType/other</seealso>
    let ``Security/ExploitCatalogType/other`` =
        Prefixed_Name(spdx, "Security/ExploitCatalogType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/catalogType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the exploit catalog type.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/catalogType">https://spdx.org/rdf/3.1/terms/Security/catalogType</seealso>
    let ``Security/catalogType`` =
        Prefixed_Name(spdx, "Security/catalogType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/locator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides the location of an exploit catalog.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/locator">https://spdx.org/rdf/3.1/terms/Security/locator</seealso>
    let ``Security/locator`` = Prefixed_Name(spdx, "Security/locator") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/exploited</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Denote whether a CVE is present in an exploit catalog.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/exploited">https://spdx.org/rdf/3.1/terms/Security/exploited</seealso>
    let ``Security/exploited`` =
        Prefixed_Name(spdx, "Security/exploited") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/SsvcDecisionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specifies the SSVC decision type.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType">https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType</seealso>
    let ``Security/SsvcDecisionType`` =
        Prefixed_Name(spdx, "Security/SsvcDecisionType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/SsvcDecisionType/act</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Security/SsvcDecisionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The vulnerability requires attention from the organization's internal, supervisory-level and leadership-level individuals. Necessary actions include requesting assistance or information about the vulnerability, as well as publishing a notification either internally and/or externally. Typically, internal groups would meet to determine the overall response and then execute agreed upon actions. CISA recommends remediating Act vulnerabilities as soon as possible.</para>
    /// labels<para>act</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/act">https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/act</seealso>
    let ``Security/SsvcDecisionType/act`` =
        Prefixed_Name(spdx, "Security/SsvcDecisionType/act") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/SsvcDecisionType/attend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Security/SsvcDecisionType</para>
    ///   <para>The vulnerability requires attention from the organization's internal, supervisory-level individuals. Necessary actions include requesting assistance or information about the vulnerability, and may involve publishing a notification either internally and/or externally. CISA recommends remediating Attend vulnerabilities sooner than standard update timelines.</para>
    /// labels<para>attend</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/attend">https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/attend</seealso>
    let ``Security/SsvcDecisionType/attend`` =
        Prefixed_Name(spdx, "Security/SsvcDecisionType/attend") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/SsvcDecisionType/track</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Security/SsvcDecisionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The vulnerability does not require action at this time. The organization would continue to track the vulnerability and reassess it if new information becomes available. CISA recommends remediating Track vulnerabilities within standard update timelines.</para>
    /// labels<para>track</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/track">https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/track</seealso>
    let ``Security/SsvcDecisionType/track`` =
        Prefixed_Name(spdx, "Security/SsvcDecisionType/track") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/SsvcDecisionType/trackStar</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Security/SsvcDecisionType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>("Track\*" in the SSVC spec) The vulnerability contains specific characteristics that may require closer monitoring for changes. CISA recommends remediating Track\* vulnerabilities within standard update timelines.</para>
    /// labels<para>trackStar</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/trackStar">https://spdx.org/rdf/3.1/terms/Security/SsvcDecisionType/trackStar</seealso>
    let ``Security/SsvcDecisionType/trackStar`` =
        Prefixed_Name(spdx, "Security/SsvcDecisionType/trackStar") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Provides information about the primary purpose of an Element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose</seealso>
    let ``Software/SoftwarePurpose`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/application</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>The Element is a software application.</para>
    /// labels<para>application</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/application">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/application</seealso>
    let ``Software/SoftwarePurpose/application`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/application") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/archive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>The Element is an archived collection of one or more files (.tar, .zip, etc.).</para>
    /// labels<para>archive</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/archive">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/archive</seealso>
    let ``Software/SoftwarePurpose/archive`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/archive") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/bom</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The Element is a bill of materials.</para>
    /// labels<para>bom</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/bom">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/bom</seealso>
    let ``Software/SoftwarePurpose/bom`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/bom") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/configuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>The Element is configuration data.</para>
    /// labels<para>configuration</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/configuration">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/configuration</seealso>
    let ``Software/SoftwarePurpose/configuration`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/configuration") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/container</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The Element is a container image which can be used by a container runtime application.</para>
    /// labels<para>container</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/container">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/container</seealso>
    let ``Software/SoftwarePurpose/container`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/container") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>The Element is data.</para>
    /// labels<para>data</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/data">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/data</seealso>
    let ``Software/SoftwarePurpose/data`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/data") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/device</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The Element refers to a chipset, processor, or electronic board.</para>
    /// labels<para>device</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/device">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/device</seealso>
    let ``Software/SoftwarePurpose/device`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/device") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/diskImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The Element refers to a disk image that can be written to a disk, booted in a VM, etc. A disk image typically contains most or all of the components necessary to boot, such as bootloaders, kernels, firmware, userspace, etc.</para>
    /// labels<para>diskImage</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/diskImage">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/diskImage</seealso>
    let ``Software/SoftwarePurpose/diskImage`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/diskImage") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/deviceDriver</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The Element represents software that controls hardware devices.</para>
    /// labels<para>deviceDriver</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/deviceDriver">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/deviceDriver</seealso>
    let ``Software/SoftwarePurpose/deviceDriver`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/deviceDriver") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/documentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The Element is documentation.</para>
    /// labels<para>documentation</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/documentation">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/documentation</seealso>
    let ``Software/SoftwarePurpose/documentation`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/documentation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/evidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>The Element is the evidence that a specification or requirement has been fulfilled.</para>
    /// labels<para>evidence</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/evidence">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/evidence</seealso>
    let ``Software/SoftwarePurpose/evidence`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/evidence") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/executable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>The Element is an Artifact that can be run on a computer.</para>
    /// labels<para>executable</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/executable">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/executable</seealso>
    let ``Software/SoftwarePurpose/executable`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/executable") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/file</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The Element is a single file which can be independently distributed (configuration file, statically linked binary, Kubernetes deployment, etc.).</para>
    /// labels<para>file</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/file">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/file</seealso>
    let ``Software/SoftwarePurpose/file`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/file") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/filesystemImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>The Element is a file system image that can be written to a disk (or virtual) partition.</para>
    /// labels<para>filesystemImage</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/filesystemImage">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/filesystemImage</seealso>
    let ``Software/SoftwarePurpose/filesystemImage`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/filesystemImage") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/firmware</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The Element provides low level control over a device's hardware.</para>
    /// labels<para>firmware</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/firmware">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/firmware</seealso>
    let ``Software/SoftwarePurpose/firmware`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/firmware") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/framework</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>The Element is a software framework.</para>
    /// labels<para>framework</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/framework">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/framework</seealso>
    let ``Software/SoftwarePurpose/framework`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/framework") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/install</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>The Element is used to install software on disk.</para>
    /// labels<para>install</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/install">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/install</seealso>
    let ``Software/SoftwarePurpose/install`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/install") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/library</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The Element is a software library.</para>
    /// labels<para>library</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/library">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/library</seealso>
    let ``Software/SoftwarePurpose/library`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/library") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/manifest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>The Element is a software manifest.</para>
    /// labels<para>manifest</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/manifest">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/manifest</seealso>
    let ``Software/SoftwarePurpose/manifest`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/manifest") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>The Element is a machine learning or artificial intelligence model.</para>
    /// labels<para>model</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/model">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/model</seealso>
    let ``Software/SoftwarePurpose/model`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/model") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/module</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The Element is a module of a piece of software.</para>
    /// labels<para>module</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/module">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/module</seealso>
    let ``Software/SoftwarePurpose/module`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/module") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/operatingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The Element is an operating system.</para>
    /// labels<para>operatingSystem</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/operatingSystem">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/operatingSystem</seealso>
    let ``Software/SoftwarePurpose/operatingSystem`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/operatingSystem") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The Element doesn't fit into any of the other categories.</para>
    /// labels<para>other</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/other">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/other</seealso>
    let ``Software/SoftwarePurpose/other`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/patch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>The Element contains a set of changes to update, fix, or improve another Element.</para>
    /// labels<para>patch</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/patch">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/patch</seealso>
    let ``Software/SoftwarePurpose/patch`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/patch") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/platform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>The Element represents a runtime environment.</para>
    /// labels<para>platform</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/platform">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/platform</seealso>
    let ``Software/SoftwarePurpose/platform`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/platform") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/requirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>The Element provides a requirement needed as input for another Element.</para>
    /// labels<para>requirement</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/requirement">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/requirement</seealso>
    let ``Software/SoftwarePurpose/requirement`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/requirement") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/source</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The Element is a single or a collection of source files.</para>
    /// labels<para>source</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/source">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/source</seealso>
    let ``Software/SoftwarePurpose/source`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/source") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/specification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>The Element is a plan, guideline or strategy how to create, perform or analyze an application.</para>
    /// labels<para>specification</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/specification">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/specification</seealso>
    let ``Software/SoftwarePurpose/specification`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/specification") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwarePurpose/test</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SoftwarePurpose</para>
    ///   <para>The Element is a test used to verify functionality on a software element.</para>
    /// labels<para>test</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/test">https://spdx.org/rdf/3.1/terms/Software/SoftwarePurpose/test</seealso>
    let ``Software/SoftwarePurpose/test`` =
        Prefixed_Name(spdx, "Software/SoftwarePurpose/test") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/primaryPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Provides information about the primary purpose of the software artifact.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/primaryPurpose">https://spdx.org/rdf/3.1/terms/Software/primaryPurpose</seealso>
    let ``Software/primaryPurpose`` =
        Prefixed_Name(spdx, "Software/primaryPurpose") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/contentIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A canonical, unique, immutable identifier of the artifact content, that may be
    /// used for verifying its identity and/or integrity.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/contentIdentifier">https://spdx.org/rdf/3.1/terms/Software/contentIdentifier</seealso>
    let ``Software/contentIdentifier`` =
        Prefixed_Name(spdx, "Software/contentIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/plannedInspectionLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The planned location that a good, product or material is inspected.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedInspectionLocation">https://spdx.org/rdf/3.1/terms/SupplyChain/plannedInspectionLocation</seealso>
    let ``SupplyChain/plannedInspectionLocation`` =
        Prefixed_Name(spdx, "SupplyChain/plannedInspectionLocation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/current</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is the individual, business, or organization who currently manages goods, services, or assets.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/current">https://spdx.org/rdf/3.1/terms/SupplyChain/current</seealso>
    let ``SupplyChain/current`` =
        Prefixed_Name(spdx, "SupplyChain/current") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/responsibilityChangedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The element that has it's responsibility changed.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/responsibilityChangedOn">https://spdx.org/rdf/3.1/terms/SupplyChain/responsibilityChangedOn</seealso>
    let ``SupplyChain/responsibilityChangedOn`` =
        Prefixed_Name(spdx, "SupplyChain/responsibilityChangedOn") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/previous</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is the individual, business, or organization who was previously managing goods, services, or assets.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/previous">https://spdx.org/rdf/3.1/terms/SupplyChain/previous</seealso>
    let ``SupplyChain/previous`` =
        Prefixed_Name(spdx, "SupplyChain/previous") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/ResponsibilityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>These categories help define sets Responsibility Type.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityType">https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityType</seealso>
    let ``SupplyChain/ResponsibilityType`` =
        Prefixed_Name(spdx, "SupplyChain/ResponsibilityType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/ResponsibilityType/ownership</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:SupplyChain/ResponsibilityType</para>
    ///   <para>Ownership refers to the legal right to control, manage, and benefit from an asset, resource, or responsibility. It establishes authority, accountability, and entitlements over something, whether it's property, a business, intellectual property, or responsibilities.</para>
    /// labels<para>ownership</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityType/ownership">https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityType/ownership</seealso>
    let ``SupplyChain/ResponsibilityType/ownership`` =
        Prefixed_Name(spdx, "SupplyChain/ResponsibilityType/ownership") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/ResponsibilityType/custody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:SupplyChain/ResponsibilityType</para>
    ///   <para>Custody refers to the responsibility, control, and safekeeping of an asset, person, or legal entity. It involves both physical possession and legal authority over something or someone.</para>
    /// labels<para>custody</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityType/custody">https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityType/custody</seealso>
    let ``SupplyChain/ResponsibilityType/custody`` =
        Prefixed_Name(spdx, "SupplyChain/ResponsibilityType/custody") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/responsibilityCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Requirements can be categorized into various types based on their focus, purpose, and scope.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/responsibilityCategory">https://spdx.org/rdf/3.1/terms/SupplyChain/responsibilityCategory</seealso>
    let ``SupplyChain/responsibilityCategory`` =
        Prefixed_Name(spdx, "SupplyChain/responsibilityCategory") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/plannedCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is the planned individual, business, or organization who currently manages goods, services, or assets.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedCurrent">https://spdx.org/rdf/3.1/terms/SupplyChain/plannedCurrent</seealso>
    let ``SupplyChain/plannedCurrent`` =
        Prefixed_Name(spdx, "SupplyChain/plannedCurrent") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/plannedProductOfResponsibilityChange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is the planned product associated with the change of responsibility.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedProductOfResponsibilityChange">https://spdx.org/rdf/3.1/terms/SupplyChain/plannedProductOfResponsibilityChange</seealso>
    let ``SupplyChain/plannedProductOfResponsibilityChange`` =
        Prefixed_Name(spdx, "SupplyChain/plannedProductOfResponsibilityChange") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/plannedPrevious</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is the planned individual, business, or organization who was previously managing goods, services, or assets.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedPrevious">https://spdx.org/rdf/3.1/terms/SupplyChain/plannedPrevious</seealso>
    let ``SupplyChain/plannedPrevious`` =
        Prefixed_Name(spdx, "SupplyChain/plannedPrevious") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/currentState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is the state of an affected Element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/currentState">https://spdx.org/rdf/3.1/terms/SupplyChain/currentState</seealso>
    let ``SupplyChain/currentState`` =
        Prefixed_Name(spdx, "SupplyChain/currentState") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/decisionProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is how the currentState of an affected Element is found.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/decisionProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/decisionProcess</seealso>
    let ``SupplyChain/decisionProcess`` =
        Prefixed_Name(spdx, "SupplyChain/decisionProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/plannedStorageLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The planned location that a good, product or material is stored.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedStorageLocation">https://spdx.org/rdf/3.1/terms/SupplyChain/plannedStorageLocation</seealso>
    let ``SupplyChain/plannedStorageLocation`` =
        Prefixed_Name(spdx, "SupplyChain/plannedStorageLocation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/pickupLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The location for picking up a package or item.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/pickupLocation">https://spdx.org/rdf/3.1/terms/SupplyChain/pickupLocation</seealso>
    let ``SupplyChain/pickupLocation`` =
        Prefixed_Name(spdx, "SupplyChain/pickupLocation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/dropoffLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The location for dropping off or delivering a package or item.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/dropoffLocation">https://spdx.org/rdf/3.1/terms/SupplyChain/dropoffLocation</seealso>
    let ``SupplyChain/dropoffLocation`` =
        Prefixed_Name(spdx, "SupplyChain/dropoffLocation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/SafetyRiskAssessmentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Safety risk level.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType">https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType</seealso>
    let ``AI/SafetyRiskAssessmentType`` =
        Prefixed_Name(spdx, "AI/SafetyRiskAssessmentType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/SafetyRiskAssessmentType/low</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:AI/SafetyRiskAssessmentType</para>
    ///   <para>Low/no risk is posed by an AI system.</para>
    /// labels<para>low</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/low">https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/low</seealso>
    let ``AI/SafetyRiskAssessmentType/low`` =
        Prefixed_Name(spdx, "AI/SafetyRiskAssessmentType/low") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/typeOfModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Type of the model used in the AI software.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/typeOfModel">https://spdx.org/rdf/3.1/terms/AI/typeOfModel</seealso>
    let ``AI/typeOfModel`` = Prefixed_Name(spdx, "AI/typeOfModel") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/IsoAutomationLevel/autonomous</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/IsoAutomationLevel</para>
    ///   <para>Level 6 - Autonomous. The system is capable of modifying its intended domain of use or its goals without external intervention, control or oversight.</para>
    /// labels<para>autonomous</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/autonomous">https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/autonomous</seealso>
    let ``Core/IsoAutomationLevel/autonomous`` =
        Prefixed_Name(spdx, "Core/IsoAutomationLevel/autonomous") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/EnergyUnitType/kilowattHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:AI/EnergyUnitType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Kilowatt-hour.</para>
    /// labels<para>kilowattHour</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType/kilowattHour">https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType/kilowattHour</seealso>
    let ``AI/EnergyUnitType/kilowattHour`` =
        Prefixed_Name(spdx, "AI/EnergyUnitType/kilowattHour") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/EnergyUnitType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:AI/EnergyUnitType</para>
    ///   <para>Any other units of energy measurement.</para>
    /// labels<para>other</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType/other">https://spdx.org/rdf/3.1/terms/AI/EnergyUnitType/other</seealso>
    let ``AI/EnergyUnitType/other`` =
        Prefixed_Name(spdx, "AI/EnergyUnitType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/energyUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Unit in which energy is measured.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/energyUnit">https://spdx.org/rdf/3.1/terms/AI/energyUnit</seealso>
    let ``AI/energyUnit`` = Prefixed_Name(spdx, "AI/energyUnit") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Build/buildId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A buildId is a locally unique identifier used by a builder to identify a unique
    /// instance of a build produced by it.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Build/buildId">https://spdx.org/rdf/3.1/terms/Build/buildId</seealso>
    let ``Build/buildId`` = Prefixed_Name(spdx, "Build/buildId") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SupportType/noAssertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/SupportType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>No assertion about the type of support is made. This is considered the default if no other support type is used.</para>
    /// labels<para>noAssertion</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SupportType/noAssertion">https://spdx.org/rdf/3.1/terms/Core/SupportType/noAssertion</seealso>
    let ``Core/SupportType/noAssertion`` =
        Prefixed_Name(spdx, "Core/SupportType/noAssertion") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ElementCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>A collection of Elements, not necessarily with unifying context.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ElementCollection">https://spdx.org/rdf/3.1/terms/Core/ElementCollection</seealso>
    let ``Core/ElementCollection`` =
        Prefixed_Name(spdx, "Core/ElementCollection") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ContactPointRelationshipType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ContactPointRelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A generic contact point to be used when the contact type does not match any of the other options.</para>
    /// labels<para>other</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/other">https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/other</seealso>
    let ``Core/ContactPointRelationshipType/other`` =
        Prefixed_Name(spdx, "Core/ContactPointRelationshipType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/contactType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies the nature of the contactPointRelationship.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/contactType">https://spdx.org/rdf/3.1/terms/Core/contactType</seealso>
    let ``Core/contactType`` = Prefixed_Name(spdx, "Core/contactType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VexAffectedVulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Connects a vulnerability and an element designating the element as a product
    /// affected by the vulnerability.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VexAffectedVulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/VexAffectedVulnAssessmentRelationship</seealso>
    let ``Security/VexAffectedVulnAssessmentRelationship`` =
        Prefixed_Name(spdx, "Security/VexAffectedVulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VexNotAffectedVulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Links a vulnerability and one or more elements designating the latter as products
    /// not affected by the vulnerability.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VexNotAffectedVulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/VexNotAffectedVulnAssessmentRelationship</seealso>
    let ``Security/VexNotAffectedVulnAssessmentRelationship`` =
        Prefixed_Name(spdx, "Security/VexNotAffectedVulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/phoneNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>Phone number; A string of decimal digits that uniquely indicates the network termination point defined in [RFC 3966](https://datatracker.ietf.org/doc/rfc3966/) Section 5.</para>
    /// labels<para>phoneNumber</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/phoneNumber">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/phoneNumber</seealso>
    let ``Core/ExternalIdentifierType/phoneNumber`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType/phoneNumber") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/requirementUUID</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The UUID used by a requirements management or any other lifecycle management tool to uniquely identify a requirement item. UUID, or universally unique ID, is a standard term in requirements engineering.</para>
    /// labels<para>requirementUUID</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/requirementUUID">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/requirementUUID</seealso>
    let ``Core/ExternalIdentifierType/requirementUUID`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType/requirementUUID") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/verificationUUID</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The UUID used by a verification management system or any other lifecycle management tool to uniquely identify a verification item. UUID, or universally unique ID, is a standard term to refer to verification items.</para>
    /// labels<para>verificationUUID</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/verificationUUID">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/verificationUUID</seealso>
    let ``Core/ExternalIdentifierType/verificationUUID`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType/verificationUUID") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/webpage</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Absolute URL that can be used to locate a resource, as defined in [RFC 7230](https://datatracker.ietf.org/doc/rfc7230/) Section 2.7.1 or Section 2.7.2.</para>
    /// labels<para>webpage</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/webpage">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/webpage</seealso>
    let ``Core/ExternalIdentifierType/webpage`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType/webpage") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/externalIdentifierType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the type of the external identifier.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/externalIdentifierType">https://spdx.org/rdf/3.1/terms/Core/externalIdentifierType</seealso>
    let ``Core/externalIdentifierType`` =
        Prefixed_Name(spdx, "Core/externalIdentifierType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/securityPolicy</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to instructions for reporting newly discovered security vulnerabilities for a package.</para>
    /// labels<para>securityPolicy</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityPolicy">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityPolicy</seealso>
    let ``Core/ExternalRefType/securityPolicy`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/securityPolicy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/securityThreatModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference the [security threat model](https://en.wikipedia.org/wiki/Threat_model) for a package.</para>
    /// labels<para>securityThreatModel</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityThreatModel">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/securityThreatModel</seealso>
    let ``Core/ExternalRefType/securityThreatModel`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/securityThreatModel") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/socialMedia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>A reference to a social media channel for a package.</para>
    /// labels<para>socialMedia</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/socialMedia">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/socialMedia</seealso>
    let ``Core/ExternalRefType/socialMedia`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/socialMedia") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/sourceArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to an artifact containing the sources for a package.</para>
    /// labels<para>sourceArtifact</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/sourceArtifact">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/sourceArtifact</seealso>
    let ``Core/ExternalRefType/sourceArtifact`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/sourceArtifact") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/endTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies the time from which an element is no longer applicable / valid.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/endTime">https://spdx.org/rdf/3.1/terms/Core/endTime</seealso>
    let ``Core/endTime`` = Prefixed_Name(spdx, "Core/endTime") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/from</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>References the Element on the left-hand side of a relationship.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/from">https://spdx.org/rdf/3.1/terms/Core/from</seealso>
    let ``Core/from`` = Prefixed_Name(spdx, "Core/from") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>References an Element on the right-hand side of a relationship.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/to">https://spdx.org/rdf/3.1/terms/Core/to</seealso>
    let ``Core/to`` = Prefixed_Name(spdx, "Core/to") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information about the relationship between two Elements.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType">https://spdx.org/rdf/3.1/terms/Core/RelationshipType</seealso>
    let ``Core/RelationshipType`` =
        Prefixed_Name(spdx, "Core/RelationshipType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/expandsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Element expands out as an artifact described by each `to` Element.</para>
    /// labels<para>expandsTo</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/expandsTo">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/expandsTo</seealso>
    let ``Core/RelationshipType/expandsTo`` =
        Prefixed_Name(spdx, "Core/RelationshipType/expandsTo") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/exploitCreatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Vulnerability has had an exploit created against it by each `to` Agent.</para>
    /// labels<para>exploitCreatedBy</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/exploitCreatedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/exploitCreatedBy</seealso>
    let ``Core/RelationshipType/exploitCreatedBy`` =
        Prefixed_Name(spdx, "Core/RelationshipType/exploitCreatedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/finetunedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Element has been finetuned on the `to` Element(s).</para>
    /// labels<para>finetunedOn</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/finetunedOn">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/finetunedOn</seealso>
    let ``Core/RelationshipType/finetunedOn`` =
        Prefixed_Name(spdx, "Core/RelationshipType/finetunedOn") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/fixedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>Designates a `from` Vulnerability has been fixed by the `to` Agent(s).</para>
    /// labels<para>fixedBy</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/fixedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/fixedBy</seealso>
    let ``Core/RelationshipType/fixedBy`` =
        Prefixed_Name(spdx, "Core/RelationshipType/fixedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/fixedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A `from` Vulnerability has been fixed in each `to` Element. The use of the `fixedIn` type is constrained to `VexFixedVulnAssessmentRelationship` classed relationships.</para>
    /// labels<para>fixedIn</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/fixedIn">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/fixedIn</seealso>
    let ``Core/RelationshipType/fixedIn`` =
        Prefixed_Name(spdx, "Core/RelationshipType/fixedIn") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/follows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `to` Element succeeds the `from` Element, establishing a unidirectional sequence. This succession is defined as chronological, procedural, or logical. It is used to represent either a temporal order (e.g., in a workflow) or a logical order for processing and traversal (e.g., in an ordered list).</para>
    /// labels<para>follows</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/follows">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/follows</seealso>
    let ``Core/RelationshipType/follows`` =
        Prefixed_Name(spdx, "Core/RelationshipType/follows") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/foundBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Designates a `from` Vulnerability was originally discovered by the `to` Agent(s).</para>
    /// labels<para>foundBy</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/foundBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/foundBy</seealso>
    let ``Core/RelationshipType/foundBy`` =
        Prefixed_Name(spdx, "Core/RelationshipType/foundBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/generates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Element generates each `to` Element.</para>
    /// labels<para>generates</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/generates">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/generates</seealso>
    let ``Core/RelationshipType/generates`` =
        Prefixed_Name(spdx, "Core/RelationshipType/generates") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasAddedFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>Every `to` Element is a file added to the `from` Element (`from` hasAddedFile `to`).</para>
    /// labels<para>hasAddedFile</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasAddedFile">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasAddedFile</seealso>
    let ``Core/RelationshipType/hasAddedFile`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasAddedFile") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasAssessmentFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Relates a `from` Vulnerability and each `to` Element with a security assessment. To be used with `VulnAssessmentRelationship` types.</para>
    /// labels<para>hasAssessmentFor</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasAssessmentFor">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasAssessmentFor</seealso>
    let ``Core/RelationshipType/hasAssessmentFor`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasAssessmentFor") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasAssociatedVulnerability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>Used to associate a `from` Artifact with each `to` Vulnerability.</para>
    /// labels<para>hasAssociatedVulnerability</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasAssociatedVulnerability">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasAssociatedVulnerability</seealso>
    let ``Core/RelationshipType/hasAssociatedVulnerability`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasAssociatedVulnerability") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasConcludedLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` SoftwareArtifact is concluded by the SPDX data creator to be governed by each `to` AnyLicenseInfo.</para>
    /// labels<para>hasConcludedLicense</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasConcludedLicense">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasConcludedLicense</seealso>
    let ``Core/RelationshipType/hasConcludedLicense`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasConcludedLicense") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/requirementRationale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Text used to define the rationale or additional information.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/requirementRationale">https://spdx.org/rdf/3.1/terms/Core/requirementRationale</seealso>
    let ``Core/requirementRationale`` =
        Prefixed_Name(spdx, "Core/requirementRationale") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SimpleLicensing/AnyLicenseInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract class representing a license combination consisting of one or more licenses.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/AnyLicenseInfo">https://spdx.org/rdf/3.1/terms/SimpleLicensing/AnyLicenseInfo</seealso>
    let ``SimpleLicensing/AnyLicenseInfo`` =
        Prefixed_Name(spdx, "SimpleLicensing/AnyLicenseInfo") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/dataLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Provides the license under which the SPDX documentation of the Element can be
    /// used.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/dataLicense">https://spdx.org/rdf/3.1/terms/Core/dataLicense</seealso>
    let ``Core/dataLicense`` = Prefixed_Name(spdx, "Core/dataLicense") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/namespaceMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Provides a NamespaceMap of prefixes and associated namespace partial URIs applicable to an SpdxDocument and independent of any specific serialization format or instance.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/namespaceMap">https://spdx.org/rdf/3.1/terms/Core/namespaceMap</seealso>
    let ``Core/namespaceMap`` = Prefixed_Name(spdx, "Core/namespaceMap") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SpecificationType/formalStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/SpecificationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A formal standard is a standard ratified by a recognized standards-development organization and published as a normative reference.</para>
    /// labels<para>formalStandard</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SpecificationType/formalStandard">https://spdx.org/rdf/3.1/terms/Core/SpecificationType/formalStandard</seealso>
    let ``Core/SpecificationType/formalStandard`` =
        Prefixed_Name(spdx, "Core/SpecificationType/formalStandard") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SpecificationType/regulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/SpecificationType</para>
    ///   <para>A mandatory legal specification issued by a governmental or regulatory authority. Compliance is enforceable by law.</para>
    /// labels<para>regulation</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SpecificationType/regulation">https://spdx.org/rdf/3.1/terms/Core/SpecificationType/regulation</seealso>
    let ``Core/SpecificationType/regulation`` =
        Prefixed_Name(spdx, "Core/SpecificationType/regulation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SpecificationType/specification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/SpecificationType</para>
    ///   <para>A specification is a detailed document (or set of documents) that describes the requirements, design, behavior, or other characteristics of a system, component, or process so that all stakeholders have a clear, unambiguous reference.</para>
    /// labels<para>specification</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SpecificationType/specification">https://spdx.org/rdf/3.1/terms/Core/SpecificationType/specification</seealso>
    let ``Core/SpecificationType/specification`` =
        Prefixed_Name(spdx, "Core/SpecificationType/specification") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SpecificationType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/SpecificationType</para>
    ///   <para>Any specification that does not fall under any of the other entries.</para>
    /// labels<para>other</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SpecificationType/other">https://spdx.org/rdf/3.1/terms/Core/SpecificationType/other</seealso>
    let ``Core/SpecificationType/other`` =
        Prefixed_Name(spdx, "Core/SpecificationType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/specType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A specification type defines the nature of a specification.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/specType">https://spdx.org/rdf/3.1/terms/Core/specType</seealso>
    let ``Core/specType`` = Prefixed_Name(spdx, "Core/specType") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/quantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Quantity is the amount in the selected QUDT unit.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/quantity">https://spdx.org/rdf/3.1/terms/Core/quantity</seealso>
    let ``Core/quantity`` = Prefixed_Name(spdx, "Core/quantity") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/unitQUDT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>QUDT unit is used for measurement criteria based on product type, region and use.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/unitQUDT">https://spdx.org/rdf/3.1/terms/Core/unitQUDT</seealso>
    let ``Core/unitQUDT`` = Prefixed_Name(spdx, "Core/unitQUDT") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/evaluationBasedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the specific RequirementVerification instance on which the EvaluationResult is based.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/evaluationBasedOn">https://spdx.org/rdf/3.1/terms/FunctionalSafety/evaluationBasedOn</seealso>
    let ``FunctionalSafety/evaluationBasedOn`` =
        Prefixed_Name(spdx, "FunctionalSafety/evaluationBasedOn") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvaluationResultType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>EvaluationResultType describes the outcome of an evaluation or verification process with.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType</seealso>
    let ``FunctionalSafety/EvaluationResultType`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvaluationResultType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvaluationResultType/pass</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:FunctionalSafety/EvaluationResultType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Indicates a successful evaluation where the requirement or condition is clearly met.</para>
    /// labels<para>pass</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType/pass">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType/pass</seealso>
    let ``FunctionalSafety/EvaluationResultType/pass`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvaluationResultType/pass") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvaluationResultType/fail</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:FunctionalSafety/EvaluationResultType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Indicates a failed evaluation where the requirement or condition is not met.</para>
    /// labels<para>fail</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType/fail">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType/fail</seealso>
    let ``FunctionalSafety/EvaluationResultType/fail`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvaluationResultType/fail") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvaluationResultType/inconclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:FunctionalSafety/EvaluationResultType</para>
    ///   <para>Inconclusive refers to a result or outcome from a verification, test, or analysis that cannot be clearly classified as either positive (successful, pass) or negative (failed, reject). An inconclusive result means there was not enough clear evidence, data, or signal to make a definitive determination, and further investigation or additional testing is necessary. An inconclusive result always shall need a comment on it.</para>
    /// labels<para>inconclusive</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType/inconclusive">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType/inconclusive</seealso>
    let ``FunctionalSafety/EvaluationResultType/inconclusive`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvaluationResultType/inconclusive") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/evaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Evaluation is an outcome considering results of a verification.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/evaluation">https://spdx.org/rdf/3.1/terms/FunctionalSafety/evaluation</seealso>
    let ``FunctionalSafety/evaluation`` =
        Prefixed_Name(spdx, "FunctionalSafety/evaluation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/CvssSeverityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specifies the CVSS base, temporal, threat, or environmental severity type.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType">https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType</seealso>
    let ``Security/CvssSeverityType`` =
        Prefixed_Name(spdx, "Security/CvssSeverityType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/CvssSeverityType/critical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Security/CvssSeverityType</para>
    ///   <para>When a CVSS score is between 9.0 - 10.0.</para>
    /// labels<para>critical</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/critical">https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/critical</seealso>
    let ``Security/CvssSeverityType/critical`` =
        Prefixed_Name(spdx, "Security/CvssSeverityType/critical") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/CvssSeverityType/high</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Security/CvssSeverityType</para>
    ///   <para>When a CVSS score is between 7.0 - 8.9.</para>
    /// labels<para>high</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/high">https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/high</seealso>
    let ``Security/CvssSeverityType/high`` =
        Prefixed_Name(spdx, "Security/CvssSeverityType/high") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/CvssSeverityType/low</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Security/CvssSeverityType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>When a CVSS score is between 0.1 - 3.9.</para>
    /// labels<para>low</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/low">https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/low</seealso>
    let ``Security/CvssSeverityType/low`` =
        Prefixed_Name(spdx, "Security/CvssSeverityType/low") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/FileKindType/file</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/FileKindType</para>
    ///   <para>The file represents a single file (default).</para>
    /// labels<para>file</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/FileKindType/file">https://spdx.org/rdf/3.1/terms/Software/FileKindType/file</seealso>
    let ``Software/FileKindType/file`` =
        Prefixed_Name(spdx, "Software/FileKindType/file") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/FileKindType/directory</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/FileKindType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The file represents a directory and all content stored in that directory.</para>
    /// labels<para>directory</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/FileKindType/directory">https://spdx.org/rdf/3.1/terms/Software/FileKindType/directory</seealso>
    let ``Software/FileKindType/directory`` =
        Prefixed_Name(spdx, "Software/FileKindType/directory") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/fileKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes if a given file is a directory or non-directory kind of file.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/fileKind">https://spdx.org/rdf/3.1/terms/Software/fileKind</seealso>
    let ``Software/fileKind`` = Prefixed_Name(spdx, "Software/fileKind") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/packageUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides a place for the SPDX data creator to record the package URL string
    /// (in accordance with the Package URL specification) for a software Package.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/packageUrl">https://spdx.org/rdf/3.1/terms/Software/packageUrl</seealso>
    let ``Software/packageUrl`` =
        Prefixed_Name(spdx, "Software/packageUrl") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/sourceInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Records any relevant background information or additional comments
    /// about the origin of the package.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/sourceInfo">https://spdx.org/rdf/3.1/terms/Software/sourceInfo</seealso>
    let ``Software/sourceInfo`` =
        Prefixed_Name(spdx, "Software/sourceInfo") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/energyConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Energy consumption incurred by an AI model.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/energyConsumption">https://spdx.org/rdf/3.1/terms/AI/energyConsumption</seealso>
    let ``AI/energyConsumption`` =
        Prefixed_Name(spdx, "AI/energyConsumption") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/EnergyConsumptionDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>The class that helps note down the quantity of energy consumption and the unit
    /// used for measurement.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/EnergyConsumptionDescription">https://spdx.org/rdf/3.1/terms/AI/EnergyConsumptionDescription</seealso>
    let ``AI/EnergyConsumptionDescription`` =
        Prefixed_Name(spdx, "AI/EnergyConsumptionDescription") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Class that describes an action that has occurred.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Action">https://spdx.org/rdf/3.1/terms/Core/Action</seealso>
    let ``Core/Action`` = Prefixed_Name(spdx, "Core/Action") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/additionalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Additional relevance information.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/additionalInformation">https://spdx.org/rdf/3.1/terms/Core/additionalInformation</seealso>
    let ``Core/additionalInformation`` =
        Prefixed_Name(spdx, "Core/additionalInformation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Location is used to define the location, address or coordinates of a place.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Location">https://spdx.org/rdf/3.1/terms/Core/Location</seealso>
    let ``Core/Location`` = Prefixed_Name(spdx, "Core/Location") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/actionLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Location of a specific action.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/actionLocation">https://spdx.org/rdf/3.1/terms/Core/actionLocation</seealso>
    let ``Core/actionLocation`` =
        Prefixed_Name(spdx, "Core/actionLocation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/DefinedProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>Class that describes a process.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/DefinedProcess">https://spdx.org/rdf/3.1/terms/Core/DefinedProcess</seealso>
    let ``Core/DefinedProcess`` =
        Prefixed_Name(spdx, "Core/DefinedProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProcessReadinessType/active</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProcessReadinessType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>in use</para>
    /// labels<para>active</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/active">https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/active</seealso>
    let ``Core/ProcessReadinessType/active`` =
        Prefixed_Name(spdx, "Core/ProcessReadinessType/active") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/MeasureOfLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The measure of length refers to the dimension of an object or space that describes how long it is, typically expressed in various units depending on the system of measurement being used.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/MeasureOfLength">https://spdx.org/rdf/3.1/terms/Core/MeasureOfLength</seealso>
    let ``Core/MeasureOfLength`` =
        Prefixed_Name(spdx, "Core/MeasureOfLength") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/IndividualElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A concrete subclass of Element used by Individuals in the
    /// Core profile.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/IndividualElement">https://spdx.org/rdf/3.1/terms/Core/IndividualElement</seealso>
    let ``Core/IndividualElement`` =
        Prefixed_Name(spdx, "Core/IndividualElement") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>A map of Element identifiers that are used within an SpdxDocument but defined
    /// external to that SpdxDocument.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalMap">https://spdx.org/rdf/3.1/terms/Core/ExternalMap</seealso>
    let ``Core/ExternalMap`` = Prefixed_Name(spdx, "Core/ExternalMap") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/SpdxDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>A collection of SPDX Elements that could potentially be serialized.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SpdxDocument">https://spdx.org/rdf/3.1/terms/Core/SpdxDocument</seealso>
    let ``Core/SpdxDocument`` = Prefixed_Name(spdx, "Core/SpdxDocument") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/PackageVerificationCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>An SPDX version 2.X compatible verification method for software packages.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/PackageVerificationCode">https://spdx.org/rdf/3.1/terms/Core/PackageVerificationCode</seealso>
    let ``Core/PackageVerificationCode`` =
        Prefixed_Name(spdx, "Core/PackageVerificationCode") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/BulkHardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Products or commodities produced as a bulk unit are called bulk products. Commodities are often sold in bulk.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/BulkHardware">https://spdx.org/rdf/3.1/terms/Hardware/BulkHardware</seealso>
    let ``Hardware/BulkHardware`` =
        Prefixed_Name(spdx, "Hardware/BulkHardware") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/scope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Capture the scope of information about a specific relationship between elements.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/scope">https://spdx.org/rdf/3.1/terms/Core/scope</seealso>
    let ``Core/scope`` = Prefixed_Name(spdx, "Core/scope") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/locationTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A known location is specified at this time.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/locationTime">https://spdx.org/rdf/3.1/terms/Core/locationTime</seealso>
    let ``Core/locationTime`` = Prefixed_Name(spdx, "Core/locationTime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasPrerequisite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Element has a prerequisite on each `to` Element, during a LifecycleScopeType period.</para>
    /// labels<para>hasPrerequisite</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasPrerequisite">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasPrerequisite</seealso>
    let ``Core/RelationshipType/hasPrerequisite`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasPrerequisite") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasProvidedDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Element has a dependency on each `to` Element, dependency is not in the distributed artifact, but assumed to be provided, during a LifecycleScopeType period.</para>
    /// labels<para>hasProvidedDependency</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasProvidedDependency">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasProvidedDependency</seealso>
    let ``Core/RelationshipType/hasProvidedDependency`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasProvidedDependency") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Element has a requirement on each `to` Element, during a LifecycleScopeType period.</para>
    /// labels<para>hasRequirement</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasRequirement">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasRequirement</seealso>
    let ``Core/RelationshipType/hasRequirement`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasRequirement") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` ResolutionAction point to the `to` OutOfSpecAction that is addressed.</para>
    /// labels<para>hasResolution</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasResolution">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasResolution</seealso>
    let ``Core/RelationshipType/hasResolution`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasResolution") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Every `to` Element is a specification for the `from` Element (`from` hasSpecification `to`), during a LifecycleScopeType period.</para>
    /// labels<para>hasSpecification</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasSpecification">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasSpecification</seealso>
    let ``Core/RelationshipType/hasSpecification`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasSpecification") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasStaticLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Element statically links in each `to` Element, during a LifecycleScopeType period.</para>
    /// labels<para>hasStaticLink</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasStaticLink">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasStaticLink</seealso>
    let ``Core/RelationshipType/hasStaticLink`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasStaticLink") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasTest</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Every `to` Element is a test artifact for the `from` Element (`from` hasTest `to`), during a LifecycleScopeType period.</para>
    /// labels<para>hasTest</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasTest">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasTest</seealso>
    let ``Core/RelationshipType/hasTest`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasTest") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasTestCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Every `to` Element is a test case for the `from` Element (`from` hasTestCase `to`).</para>
    /// labels<para>hasTestCase</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasTestCase">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasTestCase</seealso>
    let ``Core/RelationshipType/hasTestCase`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasTestCase") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/hasVariant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>Every `to` Element is a variant the `from` Element (`from` hasVariant `to`).</para>
    /// labels<para>hasVariant</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasVariant">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/hasVariant</seealso>
    let ``Core/RelationshipType/hasVariant`` =
        Prefixed_Name(spdx, "Core/RelationshipType/hasVariant") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/implementedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>The `from` Requirement is implemented in the `to` Element(s).</para>
    /// labels<para>implementedBy</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/implementedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/implementedBy</seealso>
    let ``Core/RelationshipType/implementedBy`` =
        Prefixed_Name(spdx, "Core/RelationshipType/implementedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/invokedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The `from` Element was invoked by the `to` Agent, during a LifecycleScopeType period (for example, a Build element that describes a build step).</para>
    /// labels<para>invokedBy</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/invokedBy">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/invokedBy</seealso>
    let ``Core/RelationshipType/invokedBy`` =
        Prefixed_Name(spdx, "Core/RelationshipType/invokedBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/RelationshipType/locatedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/RelationshipType</para>
    ///   <para>`from` element located at a specific `to` location. A time period is optional.</para>
    /// labels<para>locatedAt</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/RelationshipType/locatedAt">https://spdx.org/rdf/3.1/terms/Core/RelationshipType/locatedAt</seealso>
    let ``Core/RelationshipType/locatedAt`` =
        Prefixed_Name(spdx, "Core/RelationshipType/locatedAt") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/import</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Provides an ExternalMap of Element identifiers.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/import">https://spdx.org/rdf/3.1/terms/Core/import</seealso>
    let ``Core/import`` = Prefixed_Name(spdx, "Core/import") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SpecificationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A specification type defines the nature of a specification.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SpecificationType">https://spdx.org/rdf/3.1/terms/Core/SpecificationType</seealso>
    let ``Core/SpecificationType`` =
        Prefixed_Name(spdx, "Core/SpecificationType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/datasetUpdateMechanism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Mechanism to update the dataset.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/datasetUpdateMechanism">https://spdx.org/rdf/3.1/terms/Dataset/datasetUpdateMechanism</seealso>
    let ``Dataset/datasetUpdateMechanism`` =
        Prefixed_Name(spdx, "Dataset/datasetUpdateMechanism") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/dataPreprocessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Preprocessing steps that were applied to the raw data to create the given dataset.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/dataPreprocessing">https://spdx.org/rdf/3.1/terms/Dataset/dataPreprocessing</seealso>
    let ``Dataset/dataPreprocessing`` =
        Prefixed_Name(spdx, "Dataset/dataPreprocessing") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/intendedUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>**DEPRECATED in SPDX 3.1.**
    /// Use [/Core/intendedUse](../../Core/Properties/intendedUse.md) instead.
    ///
    /// The intended use of a given dataset.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/intendedUse">https://spdx.org/rdf/3.1/terms/Dataset/intendedUse</seealso>
    let ``Dataset/intendedUse`` =
        Prefixed_Name(spdx, "Dataset/intendedUse") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes a sensor used for collecting the data.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/sensor">https://spdx.org/rdf/3.1/terms/Dataset/sensor</seealso>
    let ``Dataset/sensor`` = Prefixed_Name(spdx, "Dataset/sensor") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/categorical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>Data that is classified into a discrete number of categories, such as the eye color of a population of people.</para>
    /// labels<para>categorical</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/categorical">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/categorical</seealso>
    let ``Dataset/DatasetType/categorical`` =
        Prefixed_Name(spdx, "Dataset/DatasetType/categorical") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/graph</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Data is in the form of a graph where entries are somehow related to each other through edges, such a social network of friends.</para>
    /// labels<para>graph</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/graph">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/graph</seealso>
    let ``Dataset/DatasetType/graph`` =
        Prefixed_Name(spdx, "Dataset/DatasetType/graph") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>Data is a collection of images such as pictures of animals.</para>
    /// labels<para>image</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/image">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/image</seealso>
    let ``Dataset/DatasetType/image`` =
        Prefixed_Name(spdx, "Dataset/DatasetType/image") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/noAssertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>Data type is not known.</para>
    /// labels<para>noAssertion</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/noAssertion">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/noAssertion</seealso>
    let ``Dataset/DatasetType/noAssertion`` =
        Prefixed_Name(spdx, "Dataset/DatasetType/noAssertion") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/isDeprecatedAdditionId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies whether an additional text identifier has been marked as deprecated.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isDeprecatedAdditionId">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isDeprecatedAdditionId</seealso>
    let ``ExpandedLicensing/isDeprecatedAdditionId`` =
        Prefixed_Name(spdx, "ExpandedLicensing/isDeprecatedAdditionId") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/standardAdditionTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identifies the full text of a LicenseAddition, in SPDX templating format.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/standardAdditionTemplate">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/standardAdditionTemplate</seealso>
    let ``ExpandedLicensing/standardAdditionTemplate`` =
        Prefixed_Name(spdx, "ExpandedLicensing/standardAdditionTemplate") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/additionText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identifies the full text of a LicenseAddition.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/additionText">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/additionText</seealso>
    let ``ExpandedLicensing/additionText`` =
        Prefixed_Name(spdx, "ExpandedLicensing/additionText") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/deprecatedVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies the SPDX License List version in which this license or exception
    /// identifier was deprecated.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/deprecatedVersion">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/deprecatedVersion</seealso>
    let ``ExpandedLicensing/deprecatedVersion`` =
        Prefixed_Name(spdx, "ExpandedLicensing/deprecatedVersion") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/productAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Agent who is responsible for product branding such as an OEM.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/productAgent">https://spdx.org/rdf/3.1/terms/Hardware/productAgent</seealso>
    let ``Hardware/productAgent`` =
        Prefixed_Name(spdx, "Hardware/productAgent") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The category describes the hardware item in a DefinedType.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/category">https://spdx.org/rdf/3.1/terms/Hardware/category</seealso>
    let ``Hardware/category`` = Prefixed_Name(spdx, "Hardware/category") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/additionalInformationSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>It is the authoritative or credible entity, document, or body of knowledge that provides the meaning of an additionalInformation key and/or its values, ensuring accuracy, context, and standardization.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/additionalInformationSpecification">https://spdx.org/rdf/3.1/terms/Hardware/additionalInformationSpecification</seealso>
    let ``Hardware/additionalInformationSpecification`` =
        Prefixed_Name(spdx, "Hardware/additionalInformationSpecification") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/hardwareVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Version identifier for the hardware product.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/hardwareVersion">https://spdx.org/rdf/3.1/terms/Hardware/hardwareVersion</seealso>
    let ``Hardware/hardwareVersion`` =
        Prefixed_Name(spdx, "Hardware/hardwareVersion") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/batchNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identifier for product production batch.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/batchNumber">https://spdx.org/rdf/3.1/terms/Hardware/batchNumber</seealso>
    let ``Hardware/batchNumber`` =
        Prefixed_Name(spdx, "Hardware/batchNumber") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/dimensions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Information related to hardware dimension.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/dimensions">https://spdx.org/rdf/3.1/terms/Hardware/dimensions</seealso>
    let ``Hardware/dimensions`` =
        Prefixed_Name(spdx, "Hardware/dimensions") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/centerOfMass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A point representing the mean position of the matter in a body or system.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/centerOfMass">https://spdx.org/rdf/3.1/terms/Hardware/centerOfMass</seealso>
    let ``Hardware/centerOfMass`` =
        Prefixed_Name(spdx, "Hardware/centerOfMass") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Service/serverAuthenticationProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Authentication protocol used by a server.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Service/serverAuthenticationProtocol">https://spdx.org/rdf/3.1/terms/Service/serverAuthenticationProtocol</seealso>
    let ``Service/serverAuthenticationProtocol`` =
        Prefixed_Name(spdx, "Service/serverAuthenticationProtocol") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Service/provider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The provider of a SoftwareService.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Service/provider">https://spdx.org/rdf/3.1/terms/Service/provider</seealso>
    let ``Service/provider`` = Prefixed_Name(spdx, "Service/provider") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Service/serviceHostingCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies a country code where a software service is hosted.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Service/serviceHostingCountry">https://spdx.org/rdf/3.1/terms/Service/serviceHostingCountry</seealso>
    let ``Service/serviceHostingCountry`` =
        Prefixed_Name(spdx, "Service/serviceHostingCountry") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/CreateAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>CreationAction represents an event of product creation.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/CreateAction">https://spdx.org/rdf/3.1/terms/SupplyChain/CreateAction</seealso>
    let ``SupplyChain/CreateAction`` =
        Prefixed_Name(spdx, "SupplyChain/CreateAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/CreateProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The CreateProcess refers to the abstract process class that can be used to represent the process of creation of a product.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/CreateProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/CreateProcess</seealso>
    let ``SupplyChain/CreateProcess`` =
        Prefixed_Name(spdx, "SupplyChain/CreateProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/UseAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The action of product use.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/UseAction">https://spdx.org/rdf/3.1/terms/SupplyChain/UseAction</seealso>
    let ``SupplyChain/UseAction`` =
        Prefixed_Name(spdx, "SupplyChain/UseAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/boundaryParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The boundary parameters define the area or region needed to describe a boundary.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/boundaryParameter">https://spdx.org/rdf/3.1/terms/SupplyChain/boundaryParameter</seealso>
    let ``SupplyChain/boundaryParameter`` =
        Prefixed_Name(spdx, "SupplyChain/boundaryParameter") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/ModifyAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actual alteration of a product.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ModifyAction">https://spdx.org/rdf/3.1/terms/SupplyChain/ModifyAction</seealso>
    let ``SupplyChain/ModifyAction`` =
        Prefixed_Name(spdx, "SupplyChain/ModifyAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/ModifyProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A prescribed alteration of a product.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ModifyProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/ModifyProcess</seealso>
    let ``SupplyChain/ModifyProcess`` =
        Prefixed_Name(spdx, "SupplyChain/ModifyProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/finetuningEnergyConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Energy consumed when finetuning the AI model that is
    /// being used in the AI system.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/finetuningEnergyConsumption">https://spdx.org/rdf/3.1/terms/AI/finetuningEnergyConsumption</seealso>
    let ``AI/finetuningEnergyConsumption`` =
        Prefixed_Name(spdx, "AI/finetuningEnergyConsumption") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/inferenceEnergyConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Energy consumed during inference time by an AI model
    /// that is being used in the AI system.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/inferenceEnergyConsumption">https://spdx.org/rdf/3.1/terms/AI/inferenceEnergyConsumption</seealso>
    let ``AI/inferenceEnergyConsumption`` =
        Prefixed_Name(spdx, "AI/inferenceEnergyConsumption") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Agent represents anything with the potential to act on a system.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Agent">https://spdx.org/rdf/3.1/terms/Core/Agent</seealso>
    let ``Core/Agent`` = Prefixed_Name(spdx, "Core/Agent") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/contentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides information about the content type of an Element or a property.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/contentType">https://spdx.org/rdf/3.1/terms/Core/contentType</seealso>
    let ``Core/contentType`` = Prefixed_Name(spdx, "Core/contentType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/AnnotationType/review</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/AnnotationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Used when someone reviews the Element.</para>
    /// labels<para>review</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/AnnotationType/review">https://spdx.org/rdf/3.1/terms/Core/AnnotationType/review</seealso>
    let ``Core/AnnotationType/review`` =
        Prefixed_Name(spdx, "Core/AnnotationType/review") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/annotationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the type of annotation.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/annotationType">https://spdx.org/rdf/3.1/terms/Core/annotationType</seealso>
    let ``Core/annotationType`` =
        Prefixed_Name(spdx, "Core/annotationType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An Element an annotator has made an assertion about.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/subject">https://spdx.org/rdf/3.1/terms/Core/subject</seealso>
    let ``Core/subject`` = Prefixed_Name(spdx, "Core/subject") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/key</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A key used in a generic key-value pair.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/key">https://spdx.org/rdf/3.1/terms/Core/key</seealso>
    let ``Core/key`` = Prefixed_Name(spdx, "Core/key") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/PhysicalLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>A physical location is a tangible, geographically identifiable place where objects, people, or assets exist or operate.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/PhysicalLocation">https://spdx.org/rdf/3.1/terms/Core/PhysicalLocation</seealso>
    let ``Core/PhysicalLocation`` =
        Prefixed_Name(spdx, "Core/PhysicalLocation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/Regulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Regulation represents a rule or directive maintained by an authority.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Regulation">https://spdx.org/rdf/3.1/terms/Core/Regulation</seealso>
    let ``Core/Regulation`` = Prefixed_Name(spdx, "Core/Regulation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetPackage</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>A Package that contains a dataset.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetPackage">https://spdx.org/rdf/3.1/terms/Dataset/DatasetPackage</seealso>
    let ``Dataset/DatasetPackage`` =
        Prefixed_Name(spdx, "Dataset/DatasetPackage") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/lite</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The element follows the Lite profile specification.</para>
    /// labels<para>lite</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/lite">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/lite</seealso>
    let ``Core/ProfileIdentifierType/lite`` =
        Prefixed_Name(spdx, "Core/ProfileIdentifierType/lite") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/hardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The element follows the Hardware profile specification.</para>
    /// labels<para>hardware</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/hardware">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/hardware</seealso>
    let ``Core/ProfileIdentifierType/hardware`` =
        Prefixed_Name(spdx, "Core/ProfileIdentifierType/hardware") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/ConfidentialityLevelType/clear</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/ConfidentialityLevelType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Dataset may be distributed freely, without restriction.</para>
    /// labels<para>clear</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/clear">https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/clear</seealso>
    let ``Dataset/ConfidentialityLevelType/clear`` =
        Prefixed_Name(spdx, "Dataset/ConfidentialityLevelType/clear") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/ConfidentialityLevelType/green</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Dataset/ConfidentialityLevelType</para>
    ///   <para>Dataset can be shared within a community of peers and partners.</para>
    /// labels<para>green</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/green">https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/green</seealso>
    let ``Dataset/ConfidentialityLevelType/green`` =
        Prefixed_Name(spdx, "Dataset/ConfidentialityLevelType/green") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/isOsiApproved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies whether the License is listed as approved by the
    /// Open Source Initiative (OSI).</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isOsiApproved">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/isOsiApproved</seealso>
    let ``ExpandedLicensing/isOsiApproved`` =
        Prefixed_Name(spdx, "ExpandedLicensing/isOsiApproved") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/CvssSeverityType/medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Security/CvssSeverityType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>When a CVSS score is between 4.0 - 6.9.</para>
    /// labels<para>medium</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/medium">https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/medium</seealso>
    let ``Security/CvssSeverityType/medium`` =
        Prefixed_Name(spdx, "Security/CvssSeverityType/medium") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/CvssSeverityType/none</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Security/CvssSeverityType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>When a CVSS score is 0.0.</para>
    /// labels<para>none</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/none">https://spdx.org/rdf/3.1/terms/Security/CvssSeverityType/none</seealso>
    let ``Security/CvssSeverityType/none`` =
        Prefixed_Name(spdx, "Security/CvssSeverityType/none") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>Abstract ancestor class for all vulnerability assessments.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/VulnAssessmentRelationship</seealso>
    let ``Security/VulnAssessmentRelationship`` =
        Prefixed_Name(spdx, "Security/VulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/snippetFromFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Defines the original host file that the snippet information applies to.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/snippetFromFile">https://spdx.org/rdf/3.1/terms/Software/snippetFromFile</seealso>
    let ``Software/snippetFromFile`` =
        Prefixed_Name(spdx, "Software/snippetFromFile") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/lineRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Defines the line range in the original host file that the snippet information
    /// applies to.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/lineRange">https://spdx.org/rdf/3.1/terms/Software/lineRange</seealso>
    let ``Software/lineRange`` =
        Prefixed_Name(spdx, "Software/lineRange") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/byteRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Defines the byte range in the original host file that the snippet information
    /// applies to.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/byteRange">https://spdx.org/rdf/3.1/terms/Software/byteRange</seealso>
    let ``Software/byteRange`` =
        Prefixed_Name(spdx, "Software/byteRange") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Build/Build</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>Class that describes a build instance of software/artifacts.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Build/Build">https://spdx.org/rdf/3.1/terms/Build/Build</seealso>
    let ``Build/Build`` = Prefixed_Name(spdx, "Build/Build") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Build/parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property describing a parameter used in an instance of a build.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Build/parameter">https://spdx.org/rdf/3.1/terms/Build/parameter</seealso>
    let ``Build/parameter`` = Prefixed_Name(spdx, "Build/parameter") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Build/buildType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A buildType is a hint that is used to indicate the toolchain, platform, or
    /// infrastructure that the build was invoked on.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Build/buildType">https://spdx.org/rdf/3.1/terms/Build/buildType</seealso>
    let ``Build/buildType`` = Prefixed_Name(spdx, "Build/buildType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Build/configSourceUri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Property that describes the URI of the build configuration source file.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Build/configSourceUri">https://spdx.org/rdf/3.1/terms/Build/configSourceUri</seealso>
    let ``Build/configSourceUri`` =
        Prefixed_Name(spdx, "Build/configSourceUri") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/Hash</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>A mathematically calculated representation of a grouping of data.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Hash">https://spdx.org/rdf/3.1/terms/Core/Hash</seealso>
    let ``Core/Hash`` = Prefixed_Name(spdx, "Core/Hash") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Build/configSourceDigest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that describes the digest of the build configuration file used to
    /// invoke a build.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Build/configSourceDigest">https://spdx.org/rdf/3.1/terms/Build/configSourceDigest</seealso>
    let ``Build/configSourceDigest`` =
        Prefixed_Name(spdx, "Build/configSourceDigest") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ContactPointRelationshipType/securityVulnerability</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ContactPointRelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A contact for reporting security vulnerabilities.</para>
    /// labels<para>securityVulnerability</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/securityVulnerability">https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/securityVulnerability</seealso>
    let ``Core/ContactPointRelationshipType/securityVulnerability`` =
        Prefixed_Name(spdx, "Core/ContactPointRelationshipType/securityVulnerability") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ContactPointRelationshipType/support</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ContactPointRelationshipType</para>
    ///   <para>A contact point for support.</para>
    /// labels<para>support</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/support">https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/support</seealso>
    let ``Core/ContactPointRelationshipType/support`` =
        Prefixed_Name(spdx, "Core/ContactPointRelationshipType/support") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identifies the name of an Element as designated by the creator.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/name">https://spdx.org/rdf/3.1/terms/Core/name</seealso>
    let ``Core/name`` = Prefixed_Name(spdx, "Core/name") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>A reference to a resource identifier defined outside the scope of SPDX 3 content that uniquely identifies an Element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifier">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifier</seealso>
    let ``Core/ExternalIdentifier`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/SsvcVulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>Provides an SSVC assessment for a vulnerability.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/SsvcVulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/SsvcVulnAssessmentRelationship</seealso>
    let ``Security/SsvcVulnAssessmentRelationship`` =
        Prefixed_Name(spdx, "Security/SsvcVulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/CvssV2VulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>Provides a CVSS version 2.0 assessment for a vulnerability.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/CvssV2VulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/CvssV2VulnAssessmentRelationship</seealso>
    let ``Security/CvssV2VulnAssessmentRelationship`` =
        Prefixed_Name(spdx, "Security/CvssV2VulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/ExploitCatalogVulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Provides an exploit assessment of a vulnerability.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogVulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/ExploitCatalogVulnAssessmentRelationship</seealso>
    let ``Security/ExploitCatalogVulnAssessmentRelationship`` =
        Prefixed_Name(spdx, "Security/ExploitCatalogVulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/CvssV4VulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>Provides a CVSS version 4 assessment for a vulnerability.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/CvssV4VulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/CvssV4VulnAssessmentRelationship</seealso>
    let ``Security/CvssV4VulnAssessmentRelationship`` =
        Prefixed_Name(spdx, "Security/CvssV4VulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/CvssV3VulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>Provides a CVSS version 3 assessment for a vulnerability.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/CvssV3VulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/CvssV3VulnAssessmentRelationship</seealso>
    let ``Security/CvssV3VulnAssessmentRelationship`` =
        Prefixed_Name(spdx, "Security/CvssV3VulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/Vulnerability</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>Specifies a vulnerability and its associated information.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/Vulnerability">https://spdx.org/rdf/3.1/terms/Security/Vulnerability</seealso>
    let ``Security/Vulnerability`` =
        Prefixed_Name(spdx, "Security/Vulnerability") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VexFixedVulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Links a vulnerability and elements representing products (in the VEX sense) where
    /// a fix has been applied and are no longer affected.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VexFixedVulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/VexFixedVulnAssessmentRelationship</seealso>
    let ``Security/VexFixedVulnAssessmentRelationship`` =
        Prefixed_Name(spdx, "Security/VexFixedVulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/NamespaceMap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>A mapping between prefixes and namespace partial URIs.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/NamespaceMap">https://spdx.org/rdf/3.1/terms/Core/NamespaceMap</seealso>
    let ``Core/NamespaceMap`` = Prefixed_Name(spdx, "Core/NamespaceMap") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SupportRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Describes how an Agent provides support for an Artifact.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SupportRelationship">https://spdx.org/rdf/3.1/terms/Core/SupportRelationship</seealso>
    let ``Core/SupportRelationship`` =
        Prefixed_Name(spdx, "Core/SupportRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/securityOther</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>Used when there is a security related identifier of unspecified type.</para>
    /// labels<para>securityOther</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/securityOther">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/securityOther</seealso>
    let ``Core/ExternalIdentifierType/securityOther`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType/securityOther") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/swhid</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>SoftWare Hash IDentifier, a persistent intrinsic identifier for digital artifacts, such as files, trees (also known as directories or folders), commits, and other objects typically found in version control systems. The format of the identifiers is defined in the [SWHID specification](https://www.swhid.org/swhid-specification/v1.2/) ([ISO/IEC 18670](https://www.iso.org/standard/89985.html)). They typically look like `swh:1:cnt:94a9ed024d3859793618152ea559a168bbcbb5e2`.</para>
    /// labels<para>swhid</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/swhid">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/swhid</seealso>
    let ``Core/ExternalIdentifierType/swhid`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType/swhid") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/swid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>Concise Software Identification (CoSWID) tag, as defined in [RFC 9393](https://datatracker.ietf.org/doc/rfc9393/) Section 2.3.</para>
    /// labels<para>swid</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/swid">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/swid</seealso>
    let ``Core/ExternalIdentifierType/swid`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType/swid") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/urlScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>[Uniform Resource Identifier (URI) Schemes](https://www.iana.org/assignments/uri-schemes/uri-schemes.xhtml). The scheme used in order to locate a resource.</para>
    /// labels<para>urlScheme</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/urlScheme">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/urlScheme</seealso>
    let ``Core/ExternalIdentifierType/urlScheme`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType/urlScheme") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/identifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Uniquely identifies an external element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/identifier">https://spdx.org/rdf/3.1/terms/Core/identifier</seealso>
    let ``Core/identifier`` = Prefixed_Name(spdx, "Core/identifier") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/issuingAuthority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>An entity that is authorized to issue identification credentials.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/issuingAuthority">https://spdx.org/rdf/3.1/terms/Core/issuingAuthority</seealso>
    let ``Core/issuingAuthority`` =
        Prefixed_Name(spdx, "Core/issuingAuthority") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/ConfidentialityLevelType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Confidentiality level.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType">https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType</seealso>
    let ``Dataset/ConfidentialityLevelType`` =
        Prefixed_Name(spdx, "Dataset/ConfidentialityLevelType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/ConfidentialityLevelType/amber</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/ConfidentialityLevelType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Data points in the dataset can be shared only with specific organizations and their clients on a need to know basis.</para>
    /// labels<para>amber</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/amber">https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/amber</seealso>
    let ``Dataset/ConfidentialityLevelType/amber`` =
        Prefixed_Name(spdx, "Dataset/ConfidentialityLevelType/amber") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/ConfidentialityLevelType/red</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Dataset/ConfidentialityLevelType</para>
    ///   <para>Data points in the dataset are highly confidential and can only be shared with named recipients.</para>
    /// labels<para>red</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/red">https://spdx.org/rdf/3.1/terms/Dataset/ConfidentialityLevelType/red</seealso>
    let ``Dataset/ConfidentialityLevelType/red`` =
        Prefixed_Name(spdx, "Dataset/ConfidentialityLevelType/red") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetAvailabilityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Availability of dataset.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType">https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType</seealso>
    let ``Dataset/DatasetAvailabilityType`` =
        Prefixed_Name(spdx, "Dataset/DatasetAvailabilityType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetAvailabilityType/clickthrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/DatasetAvailabilityType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Dataset is not publicly available and can only be accessed after affirmatively accepting terms on a clickthrough webpage.</para>
    /// labels<para>clickthrough</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/clickthrough">https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/clickthrough</seealso>
    let ``Dataset/DatasetAvailabilityType/clickthrough`` =
        Prefixed_Name(spdx, "Dataset/DatasetAvailabilityType/clickthrough") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/Hardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>Class that describes an instance of Hardware.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/Hardware">https://spdx.org/rdf/3.1/terms/Hardware/Hardware</seealso>
    let ``Hardware/Hardware`` = Prefixed_Name(spdx, "Hardware/Hardware") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/bulkQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The amount or measure of a bulk product.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/bulkQuantity">https://spdx.org/rdf/3.1/terms/Hardware/bulkQuantity</seealso>
    let ``Hardware/bulkQuantity`` =
        Prefixed_Name(spdx, "Hardware/bulkQuantity") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/yAxisLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Information related to hardware dimension.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/yAxisLength">https://spdx.org/rdf/3.1/terms/Hardware/yAxisLength</seealso>
    let ``Hardware/yAxisLength`` =
        Prefixed_Name(spdx, "Hardware/yAxisLength") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/zAxisLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Information related to hardware dimension.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/zAxisLength">https://spdx.org/rdf/3.1/terms/Hardware/zAxisLength</seealso>
    let ``Hardware/zAxisLength`` =
        Prefixed_Name(spdx, "Hardware/zAxisLength") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/decisionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Provide the enumeration of possible decisions in the
    /// [Stakeholder-Specific Vulnerability Categorization (SSVC) decision tree](https://www.cisa.gov/stakeholder-specific-vulnerability-categorization-ssvc).</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/decisionType">https://spdx.org/rdf/3.1/terms/Security/decisionType</seealso>
    let ``Security/decisionType`` =
        Prefixed_Name(spdx, "Security/decisionType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VexVulnAssessmentRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Abstract ancestor class for all VEX relationships.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VexVulnAssessmentRelationship">https://spdx.org/rdf/3.1/terms/Security/VexVulnAssessmentRelationship</seealso>
    let ``Security/VexVulnAssessmentRelationship`` =
        Prefixed_Name(spdx, "Security/VexVulnAssessmentRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/actionStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides advise on how to mitigate or remediate a vulnerability when a VEX product
    /// is affected by it.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/actionStatement">https://spdx.org/rdf/3.1/terms/Security/actionStatement</seealso>
    let ``Security/actionStatement`` =
        Prefixed_Name(spdx, "Security/actionStatement") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/actionStatementTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Records the time when a recommended action was communicated in a VEX statement
    /// to mitigate a vulnerability.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/actionStatementTime">https://spdx.org/rdf/3.1/terms/Security/actionStatementTime</seealso>
    let ``Security/actionStatementTime`` =
        Prefixed_Name(spdx, "Security/actionStatementTime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VexJustificationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specifies the VEX justification type.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType">https://spdx.org/rdf/3.1/terms/Security/VexJustificationType</seealso>
    let ``Security/VexJustificationType`` =
        Prefixed_Name(spdx, "Security/VexJustificationType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VexJustificationType/componentNotPresent</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Security/VexJustificationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The software is not affected because the vulnerable component is not in the product.</para>
    /// labels<para>componentNotPresent</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/componentNotPresent">https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/componentNotPresent</seealso>
    let ``Security/VexJustificationType/componentNotPresent`` =
        Prefixed_Name(spdx, "Security/VexJustificationType/componentNotPresent") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VexJustificationType/inlineMitigationsAlreadyExist</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Security/VexJustificationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Built-in inline controls or mitigations prevent an adversary from leveraging the vulnerability.</para>
    /// labels<para>inlineMitigationsAlreadyExist</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/inlineMitigationsAlreadyExist">https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/inlineMitigationsAlreadyExist</seealso>
    let ``Security/VexJustificationType/inlineMitigationsAlreadyExist`` =
        Prefixed_Name(spdx, "Security/VexJustificationType/inlineMitigationsAlreadyExist") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/additionalPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Provides additional purpose information of the software artifact.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/additionalPurpose">https://spdx.org/rdf/3.1/terms/Software/additionalPurpose</seealso>
    let ``Software/additionalPurpose`` =
        Prefixed_Name(spdx, "Software/additionalPurpose") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/artifactSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identifies the size of a software Artifact, in bytes.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/artifactSize">https://spdx.org/rdf/3.1/terms/Software/artifactSize</seealso>
    let ``Software/artifactSize`` =
        Prefixed_Name(spdx, "Software/artifactSize") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/copyrightText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identifies the text of one or more copyright notices for a software Package,
    /// File or Snippet, if any.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/copyrightText">https://spdx.org/rdf/3.1/terms/Software/copyrightText</seealso>
    let ``Software/copyrightText`` =
        Prefixed_Name(spdx, "Software/copyrightText") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/attributionText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides a place for the SPDX data creator to record acknowledgement text for
    /// a software Package, File or Snippet.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/attributionText">https://spdx.org/rdf/3.1/terms/Software/attributionText</seealso>
    let ``Software/attributionText`` =
        Prefixed_Name(spdx, "Software/attributionText") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/transportRoute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A transport route refers to the specific path or network used to move people, goods, data, or resources from one location to another.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/transportRoute">https://spdx.org/rdf/3.1/terms/SupplyChain/transportRoute</seealso>
    let ``SupplyChain/transportRoute`` =
        Prefixed_Name(spdx, "SupplyChain/transportRoute") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/forPickupLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The location for picking up a package or item.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/forPickupLocation">https://spdx.org/rdf/3.1/terms/SupplyChain/forPickupLocation</seealso>
    let ``SupplyChain/forPickupLocation`` =
        Prefixed_Name(spdx, "SupplyChain/forPickupLocation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/plannedTransportRoutes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A transport route refers to the planned path or network used to move people, goods, data, or resources from one location to another.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/plannedTransportRoutes">https://spdx.org/rdf/3.1/terms/SupplyChain/plannedTransportRoutes</seealso>
    let ``SupplyChain/plannedTransportRoutes`` =
        Prefixed_Name(spdx, "SupplyChain/plannedTransportRoutes") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/forDropoffLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The location that an item will be dropping off or delivered.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/forDropoffLocation">https://spdx.org/rdf/3.1/terms/SupplyChain/forDropoffLocation</seealso>
    let ``SupplyChain/forDropoffLocation`` =
        Prefixed_Name(spdx, "SupplyChain/forDropoffLocation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/ResponsibilityChangeProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>ResponsibilityChangeProcess refers to the process of transferring responsibility from one party to another.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityChangeProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityChangeProcess</seealso>
    let ``SupplyChain/ResponsibilityChangeProcess`` =
        Prefixed_Name(spdx, "SupplyChain/ResponsibilityChangeProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/HarvestAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>HarvestAction represents the act of creating a product by directly extracting goods or materials from nature.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/HarvestAction">https://spdx.org/rdf/3.1/terms/SupplyChain/HarvestAction</seealso>
    let ``SupplyChain/HarvestAction`` =
        Prefixed_Name(spdx, "SupplyChain/HarvestAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/requirementStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A text describing the actual need defined by the requirement.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/requirementStatement">https://spdx.org/rdf/3.1/terms/Core/requirementStatement</seealso>
    let ``Core/requirementStatement`` =
        Prefixed_Name(spdx, "Core/requirementStatement") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/devLifecycleStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The product lifecycle phase, the requirement is applicable for.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/devLifecycleStage">https://spdx.org/rdf/3.1/terms/Core/devLifecycleStage</seealso>
    let ``Core/devLifecycleStage`` =
        Prefixed_Name(spdx, "Core/devLifecycleStage") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/requirementUUID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides a universally unique Requirement ID.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/requirementUUID">https://spdx.org/rdf/3.1/terms/Core/requirementUUID</seealso>
    let ``Core/requirementUUID`` =
        Prefixed_Name(spdx, "Core/requirementUUID") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetAvailabilityType/directDownload</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Dataset/DatasetAvailabilityType</para>
    ///   <para>Dataset is publicly available and can be downloaded directly.</para>
    /// labels<para>directDownload</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/directDownload">https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/directDownload</seealso>
    let ``Dataset/DatasetAvailabilityType/directDownload`` =
        Prefixed_Name(spdx, "Dataset/DatasetAvailabilityType/directDownload") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetAvailabilityType/query</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/DatasetAvailabilityType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Dataset is publicly available, but not all at once, and can only be accessed through queries which return parts of the dataset.</para>
    /// labels<para>query</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/query">https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/query</seealso>
    let ``Dataset/DatasetAvailabilityType/query`` =
        Prefixed_Name(spdx, "Dataset/DatasetAvailabilityType/query") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetAvailabilityType/registration</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/DatasetAvailabilityType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Dataset is not publicly available and an email registration is required before accessing the dataset, although without an affirmative acceptance of terms.</para>
    /// labels<para>registration</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/registration">https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/registration</seealso>
    let ``Dataset/DatasetAvailabilityType/registration`` =
        Prefixed_Name(spdx, "Dataset/DatasetAvailabilityType/registration") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetAvailabilityType/scrapingScript</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/DatasetAvailabilityType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Dataset provider is not making available the underlying data and the dataset shall be reassembled, typically using the provided script for scraping the data.</para>
    /// labels<para>scrapingScript</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/scrapingScript">https://spdx.org/rdf/3.1/terms/Dataset/DatasetAvailabilityType/scrapingScript</seealso>
    let ``Dataset/DatasetAvailabilityType/scrapingScript`` =
        Prefixed_Name(spdx, "Dataset/DatasetAvailabilityType/scrapingScript") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/dataCollectionProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>How the dataset was collected.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/dataCollectionProcess">https://spdx.org/rdf/3.1/terms/Dataset/dataCollectionProcess</seealso>
    let ``Dataset/dataCollectionProcess`` =
        Prefixed_Name(spdx, "Dataset/dataCollectionProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/datasetNoise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Potentially noisy elements of the dataset.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/datasetNoise">https://spdx.org/rdf/3.1/terms/Dataset/datasetNoise</seealso>
    let ``Dataset/datasetNoise`` =
        Prefixed_Name(spdx, "Dataset/datasetNoise") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/datasetAvailability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Availability of a dataset.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/datasetAvailability">https://spdx.org/rdf/3.1/terms/Dataset/datasetAvailability</seealso>
    let ``Dataset/datasetAvailability`` =
        Prefixed_Name(spdx, "Dataset/datasetAvailability") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Enumeration of dataset types.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType</seealso>
    let ``Dataset/DatasetType`` =
        Prefixed_Name(spdx, "Dataset/DatasetType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/audio</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Data is audio based, such as a collection of music from the 80s.</para>
    /// labels<para>audio</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/audio">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/audio</seealso>
    let ``Dataset/DatasetType/audio`` =
        Prefixed_Name(spdx, "Dataset/DatasetType/audio") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/numeric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>Data consists only of numeric entries.</para>
    /// labels<para>numeric</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/numeric">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/numeric</seealso>
    let ``Dataset/DatasetType/numeric`` =
        Prefixed_Name(spdx, "Dataset/DatasetType/numeric") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>Data is of a type not included in this list.</para>
    /// labels<para>other</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/other">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/other</seealso>
    let ``Dataset/DatasetType/other`` =
        Prefixed_Name(spdx, "Dataset/DatasetType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Data is recorded from a physical sensor, such as a thermometer reading or biometric device.</para>
    /// labels<para>sensor</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/sensor">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/sensor</seealso>
    let ``Dataset/DatasetType/sensor`` =
        Prefixed_Name(spdx, "Dataset/DatasetType/sensor") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/structured</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>Data is stored in tabular format or retrieved from a relational database.</para>
    /// labels<para>structured</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/structured">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/structured</seealso>
    let ``Dataset/DatasetType/structured`` =
        Prefixed_Name(spdx, "Dataset/DatasetType/structured") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/syntactic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>Data describes the syntax or semantics of a language or text, such as a parse tree used for natural language processing.</para>
    /// labels<para>syntactic</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/syntactic">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/syntactic</seealso>
    let ``Dataset/DatasetType/syntactic`` =
        Prefixed_Name(spdx, "Dataset/DatasetType/syntactic") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/text</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Data consists of unstructured text, such as a book, a Wikipedia article (without images), or a transcript.</para>
    /// labels<para>text</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/text">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/text</seealso>
    let ``Dataset/DatasetType/text`` =
        Prefixed_Name(spdx, "Dataset/DatasetType/text") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/timeseries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>Data is recorded in an ordered sequence of timestamped entries, such as the price of a stock over the course of a day.</para>
    /// labels<para>timeseries</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/timeseries">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/timeseries</seealso>
    let ``Dataset/DatasetType/timeseries`` =
        Prefixed_Name(spdx, "Dataset/DatasetType/timeseries") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Dataset/DatasetType/timestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Dataset/DatasetType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Data is recorded with a timestamp for each entry, but not necessarily ordered or at specific intervals, such as when a taxi ride starts and ends.</para>
    /// labels<para>timestamp</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/timestamp">https://spdx.org/rdf/3.1/terms/Dataset/DatasetType/timestamp</seealso>
    let ``Dataset/DatasetType/timestamp`` =
        Prefixed_Name(spdx, "Dataset/DatasetType/timestamp") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/listVersionAdded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies the SPDX License List version in which this ListedLicense or
    /// ListedLicenseException identifier was first added.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/listVersionAdded">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/listVersionAdded</seealso>
    let ``ExpandedLicensing/listVersionAdded`` =
        Prefixed_Name(spdx, "ExpandedLicensing/listVersionAdded") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/NoAssertionLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:ExpandedLicensing/IndividualLicensingInfo</para>
    ///   <para>An Individual Value for License when no assertion can be made about its actual
    /// value.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/NoAssertionLicense">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/NoAssertionLicense</seealso>
    let ``ExpandedLicensing/NoAssertionLicense`` =
        Prefixed_Name(spdx, "ExpandedLicensing/NoAssertionLicense") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Licensing/NoAssertion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Licensing/NoAssertion">https://spdx.org/rdf/3.1/terms/Licensing/NoAssertion</seealso>
    let ``Licensing/NoAssertion`` =
        Prefixed_Name(spdx, "Licensing/NoAssertion") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/NoneLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:ExpandedLicensing/IndividualLicensingInfo</para>
    ///   <para>An Individual Value for License where the SPDX data creator determines that no
    /// license is present.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/NoneLicense">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/NoneLicense</seealso>
    let ``ExpandedLicensing/NoneLicense`` =
        Prefixed_Name(spdx, "ExpandedLicensing/NoneLicense") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Licensing/None</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Licensing/None">https://spdx.org/rdf/3.1/terms/Licensing/None</seealso>
    let ``Licensing/None`` = Prefixed_Name(spdx, "Licensing/None") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/subjectLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A License participating in an 'or later' model.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/subjectLicense">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/subjectLicense</seealso>
    let ``ExpandedLicensing/subjectLicense`` =
        Prefixed_Name(spdx, "ExpandedLicensing/subjectLicense") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/massOfHardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Information related to massOfHardware physical hardware.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/massOfHardware">https://spdx.org/rdf/3.1/terms/Hardware/massOfHardware</seealso>
    let ``Hardware/massOfHardware`` =
        Prefixed_Name(spdx, "Hardware/massOfHardware") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/itemVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Version identifier for the item.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/itemVersion">https://spdx.org/rdf/3.1/terms/Hardware/itemVersion</seealso>
    let ``Hardware/itemVersion`` =
        Prefixed_Name(spdx, "Hardware/itemVersion") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/VirtualHardwareModelType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>VirtualHardwareModelType sets the VirtualHardware Model Type.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType">https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType</seealso>
    let ``Hardware/VirtualHardwareModelType`` =
        Prefixed_Name(spdx, "Hardware/VirtualHardwareModelType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/VirtualHardwareModelType/function</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Hardware/VirtualHardwareModelType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Simulation the function of the hardware.</para>
    /// labels<para>function</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType/function">https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType/function</seealso>
    let ``Hardware/VirtualHardwareModelType/function`` =
        Prefixed_Name(spdx, "Hardware/VirtualHardwareModelType/function") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/VirtualHardwareModelType/cycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Hardware/VirtualHardwareModelType</para>
    ///   <para>Simulation architectures with precise cycle-level accuracy.</para>
    /// labels<para>cycle</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType/cycle">https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType/cycle</seealso>
    let ``Hardware/VirtualHardwareModelType/cycle`` =
        Prefixed_Name(spdx, "Hardware/VirtualHardwareModelType/cycle") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/VirtualHardwareModelType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Hardware/VirtualHardwareModelType</para>
    ///   <para>All other simulation types.</para>
    /// labels<para>other</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType/other">https://spdx.org/rdf/3.1/terms/Hardware/VirtualHardwareModelType/other</seealso>
    let ``Hardware/VirtualHardwareModelType/other`` =
        Prefixed_Name(spdx, "Hardware/VirtualHardwareModelType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Hardware/virtualHardwareModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Information related to virtual hardware simulation.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Hardware/virtualHardwareModel">https://spdx.org/rdf/3.1/terms/Hardware/virtualHardwareModel</seealso>
    let ``Hardware/virtualHardwareModel`` =
        Prefixed_Name(spdx, "Hardware/virtualHardwareModel") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SimpleLicensing/customIdToLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Maps a "LicenseRef-" string for a custom license or a "AdditionRef-" string for
    /// a custom license addition to a `CustomLicense`, a `CustomLicenseAddition`, or a
    /// `SimpleLicensingText`.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/customIdToLicense">https://spdx.org/rdf/3.1/terms/SimpleLicensing/customIdToLicense</seealso>
    let ``SimpleLicensing/customIdToLicense`` =
        Prefixed_Name(spdx, "SimpleLicensing/customIdToLicense") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SimpleLicensing/licenseExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A string in the license expression format.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/licenseExpression">https://spdx.org/rdf/3.1/terms/SimpleLicensing/licenseExpression</seealso>
    let ``SimpleLicensing/licenseExpression`` =
        Prefixed_Name(spdx, "SimpleLicensing/licenseExpression") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SimpleLicensing/customIdToUri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>**DEPRECATED in SPDX 3.1.**
    /// Use [customIdToLicense](./customIdToLicense.md) instead.
    ///
    /// Maps a LicenseRef or AdditionRef string for a Custom License or a Custom
    /// License Addition to its URI ID.
    ///
    /// **NOTE:**
    /// This property is deprecated and only included for backward compatibility.
    /// New documents should use [customIdToLicense](./customIdToLicense.md) instead.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/customIdToUri">https://spdx.org/rdf/3.1/terms/SimpleLicensing/customIdToUri</seealso>
    let ``SimpleLicensing/customIdToUri`` =
        Prefixed_Name(spdx, "SimpleLicensing/customIdToUri") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SimpleLicensing/licenseListVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The version of the SPDX License List used in the license expression.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/licenseListVersion">https://spdx.org/rdf/3.1/terms/SimpleLicensing/licenseListVersion</seealso>
    let ``SimpleLicensing/licenseListVersion`` =
        Prefixed_Name(spdx, "SimpleLicensing/licenseListVersion") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/ContentIdentifierType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specifies the type of a content identifier.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/ContentIdentifierType">https://spdx.org/rdf/3.1/terms/Software/ContentIdentifierType</seealso>
    let ``Software/ContentIdentifierType`` =
        Prefixed_Name(spdx, "Software/ContentIdentifierType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/ContentIdentifierType/gitoid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/ContentIdentifierType</para>
    ///   <para>[Gitoid](https://www.iana.org/assignments/uri-schemes/prov/gitoid), stands for [Git Object ID](https://git-scm.com/book/en/v2/Git-Internals-Git-Objects). A gitoid of type blob is a unique hash of a binary artifact. A gitoid may represent either an [Artifact Identifier](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-identifier-types) for the software artifact or an [Input Manifest Identifier](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#input-manifest-identifier) for the software artifact's associated [Artifact Input Manifest](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-input-manifest); this ambiguity exists because the Artifact Input Manifest is itself an artifact, and the gitoid of that artifact is its valid identifier. Gitoids calculated on software artifacts (Snippet, File, or Package Elements) should be recorded in the SPDX 3 SoftwareArtifact's contentIdentifier property. Gitoids calculated on the Artifact Input Manifest (Input Manifest Identifier) should be recorded in the SPDX 3 Element's externalIdentifier property. See [OmniBOR Specification](https://github.com/omnibor/spec/), a minimalistic specification for describing software [Artifact Dependency Graphs](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-dependency-graph-adg).</para>
    /// labels<para>gitoid</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/ContentIdentifierType/gitoid">https://spdx.org/rdf/3.1/terms/Software/ContentIdentifierType/gitoid</seealso>
    let ``Software/ContentIdentifierType/gitoid`` =
        Prefixed_Name(spdx, "Software/ContentIdentifierType/gitoid") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/ContentIdentifierType/swhid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/ContentIdentifierType</para>
    ///   <para>SoftWare Hash IDentifier, a persistent intrinsic identifier for digital artifacts, such as files, trees (also known as directories or folders), commits, and other objects typically found in version control systems. The format of the identifiers is defined in the [SWHID specification](https://www.swhid.org/swhid-specification/v1.2/) ([ISO/IEC 18670](https://www.iso.org/standard/89985.html)). They typically look like `swh:1:cnt:94a9ed024d3859793618152ea559a168bbcbb5e2`.</para>
    /// labels<para>swhid</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/ContentIdentifierType/swhid">https://spdx.org/rdf/3.1/terms/Software/ContentIdentifierType/swhid</seealso>
    let ``Software/ContentIdentifierType/swhid`` =
        Prefixed_Name(spdx, "Software/ContentIdentifierType/swhid") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/contentIdentifierType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the type of the content identifier.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/contentIdentifierType">https://spdx.org/rdf/3.1/terms/Software/contentIdentifierType</seealso>
    let ``Software/contentIdentifierType`` =
        Prefixed_Name(spdx, "Software/contentIdentifierType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/contentIdentifierValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies the value of the content identifier.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/contentIdentifierValue">https://spdx.org/rdf/3.1/terms/Software/contentIdentifierValue</seealso>
    let ``Software/contentIdentifierValue`` =
        Prefixed_Name(spdx, "Software/contentIdentifierValue") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/FileKindType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Enumeration of the different kinds of SPDX file.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/FileKindType">https://spdx.org/rdf/3.1/terms/Software/FileKindType</seealso>
    let ``Software/FileKindType`` =
        Prefixed_Name(spdx, "Software/FileKindType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/packageVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identify the version of a package.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/packageVersion">https://spdx.org/rdf/3.1/terms/Software/packageVersion</seealso>
    let ``Software/packageVersion`` =
        Prefixed_Name(spdx, "Software/packageVersion") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/homePage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A place for the SPDX document creator to record a website that serves as the
    /// package's home page.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/homePage">https://spdx.org/rdf/3.1/terms/Software/homePage</seealso>
    let ``Software/homePage`` = Prefixed_Name(spdx, "Software/homePage") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/downloadLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identifies the download Uniform Resource Identifier for the package at the time
    /// that the document was created.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/downloadLocation">https://spdx.org/rdf/3.1/terms/Software/downloadLocation</seealso>
    let ``Software/downloadLocation`` =
        Prefixed_Name(spdx, "Software/downloadLocation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SbomType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Provides a set of values to be used to describe the common types of SBOMs that
    /// tools may create.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SbomType">https://spdx.org/rdf/3.1/terms/Software/SbomType</seealso>
    let ``Software/SbomType`` = Prefixed_Name(spdx, "Software/SbomType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SbomType/design</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SbomType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>SBOM of intended, planned software project or product with included components (some of which may not yet exist) for a new software artifact.</para>
    /// labels<para>design</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SbomType/design">https://spdx.org/rdf/3.1/terms/Software/SbomType/design</seealso>
    let ``Software/SbomType/design`` =
        Prefixed_Name(spdx, "Software/SbomType/design") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SbomType/source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SbomType</para>
    ///   <para>SBOM created directly from the development environment, source files, and included dependencies used to build a product artifact.</para>
    /// labels<para>source</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SbomType/source">https://spdx.org/rdf/3.1/terms/Software/SbomType/source</seealso>
    let ``Software/SbomType/source`` =
        Prefixed_Name(spdx, "Software/SbomType/source") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SbomType/build</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SbomType</para>
    ///   <para>SBOM generated as part of the process of building the software to create a releasable artifact (e.g., executable or package) from data such as source files, dependencies, built components, build process ephemeral data, and other SBOMs.</para>
    /// labels<para>build</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SbomType/build">https://spdx.org/rdf/3.1/terms/Software/SbomType/build</seealso>
    let ``Software/SbomType/build`` =
        Prefixed_Name(spdx, "Software/SbomType/build") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SbomType/deployed</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SbomType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>SBOM provides an inventory of software that is present on a system. This may be an assembly of other SBOMs that combines analysis of configuration options, and examination of execution behavior in a (potentially simulated) deployment environment.</para>
    /// labels<para>deployed</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SbomType/deployed">https://spdx.org/rdf/3.1/terms/Software/SbomType/deployed</seealso>
    let ``Software/SbomType/deployed`` =
        Prefixed_Name(spdx, "Software/SbomType/deployed") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SbomType/runtime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Software/SbomType</para>
    ///   <para>SBOM generated through instrumenting the system running the software, to capture only components present in the system, as well as external call-outs or dynamically loaded components. In some contexts, this may also be referred to as an "Instrumented" or "Dynamic" SBOM.</para>
    /// labels<para>runtime</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SbomType/runtime">https://spdx.org/rdf/3.1/terms/Software/SbomType/runtime</seealso>
    let ``Software/SbomType/runtime`` =
        Prefixed_Name(spdx, "Software/SbomType/runtime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SbomType/analyzed</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Software/SbomType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>SBOM generated through analysis of artifacts (e.g., executables, packages, containers, and virtual machine images) after its build. Such analysis generally requires a variety of heuristics. In some contexts, this may also be referred to as a "3rd party" SBOM.</para>
    /// labels<para>analyzed</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SbomType/analyzed">https://spdx.org/rdf/3.1/terms/Software/SbomType/analyzed</seealso>
    let ``Software/SbomType/analyzed`` =
        Prefixed_Name(spdx, "Software/SbomType/analyzed") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/sbomType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Provides information about the type of an SBOM.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/sbomType">https://spdx.org/rdf/3.1/terms/Software/sbomType</seealso>
    let ``Software/sbomType`` = Prefixed_Name(spdx, "Software/sbomType") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/CreationInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>Provides information about the creation of the Element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/CreationInfo">https://spdx.org/rdf/3.1/terms/Core/CreationInfo</seealso>
    let ``Core/CreationInfo`` = Prefixed_Name(spdx, "Core/CreationInfo") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/created</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identifies when the Element was originally created.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/created">https://spdx.org/rdf/3.1/terms/Core/created</seealso>
    let ``Core/created`` = Prefixed_Name(spdx, "Core/created") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/createdBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies who or what created the Element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/createdBy">https://spdx.org/rdf/3.1/terms/Core/createdBy</seealso>
    let ``Core/createdBy`` = Prefixed_Name(spdx, "Core/createdBy") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SpdxOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/Organization</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>An Organization representing the SPDX Project.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SpdxOrganization">https://spdx.org/rdf/3.1/terms/Core/SpdxOrganization</seealso>
    let ``Core/SpdxOrganization`` =
        Prefixed_Name(spdx, "Core/SpdxOrganization") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/specVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides a reference number that can be used to understand how to parse and
    /// interpret an Element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/specVersion">https://spdx.org/rdf/3.1/terms/Core/specVersion</seealso>
    let ``Core/specVersion`` = Prefixed_Name(spdx, "Core/specVersion") |> PrefixedName
    /// <summary>
    ///   <para>spdx:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>System Package Data Exchange™ (SPDX®) Ontology</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/">https://spdx.org/rdf/3.1/terms/</seealso>
    let _prefix_iri = Prefixed_Name(spdx, "") |> PrefixedName
    /// <summary>
    ///   <para>spdx:AI/AIPackage</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>A Package that contains AI software or an AI model.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/AIPackage">https://spdx.org/rdf/3.1/terms/AI/AIPackage</seealso>
    let ``AI/AIPackage`` = Prefixed_Name(spdx, "AI/AIPackage") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/Package</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Refers to any unit of content that can be associated with a distribution of
    /// software.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/Package">https://spdx.org/rdf/3.1/terms/Software/Package</seealso>
    let ``Software/Package`` = Prefixed_Name(spdx, "Software/Package") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/SafetyRiskAssessmentType/serious</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:AI/SafetyRiskAssessmentType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The highest level of risk posed by an AI system.</para>
    /// labels<para>serious</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/serious">https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/serious</seealso>
    let ``AI/SafetyRiskAssessmentType/serious`` =
        Prefixed_Name(spdx, "AI/SafetyRiskAssessmentType/serious") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/SafetyRiskAssessmentType/high</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:AI/SafetyRiskAssessmentType</para>
    ///   <para>The second-highest level of risk posed by an AI system.</para>
    /// labels<para>high</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/high">https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/high</seealso>
    let ``AI/SafetyRiskAssessmentType/high`` =
        Prefixed_Name(spdx, "AI/SafetyRiskAssessmentType/high") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/SafetyRiskAssessmentType/medium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:AI/SafetyRiskAssessmentType</para>
    ///   <para>The third-highest level of risk posed by an AI system.</para>
    /// labels<para>medium</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/medium">https://spdx.org/rdf/3.1/terms/AI/SafetyRiskAssessmentType/medium</seealso>
    let ``AI/SafetyRiskAssessmentType/medium`` =
        Prefixed_Name(spdx, "AI/SafetyRiskAssessmentType/medium") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/safetyRiskAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Results of general safety risk assessment of the AI system.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/safetyRiskAssessment">https://spdx.org/rdf/3.1/terms/AI/safetyRiskAssessment</seealso>
    let ``AI/safetyRiskAssessment`` =
        Prefixed_Name(spdx, "AI/safetyRiskAssessment") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/informationAboutApplication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Information about the AI software, not including the model description.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/informationAboutApplication">https://spdx.org/rdf/3.1/terms/AI/informationAboutApplication</seealso>
    let ``AI/informationAboutApplication`` =
        Prefixed_Name(spdx, "AI/informationAboutApplication") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/informationAboutTraining</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Information about different steps of the training process.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/informationAboutTraining">https://spdx.org/rdf/3.1/terms/AI/informationAboutTraining</seealso>
    let ``AI/informationAboutTraining`` =
        Prefixed_Name(spdx, "AI/informationAboutTraining") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/PresenceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Categories of presence or absence.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/PresenceType">https://spdx.org/rdf/3.1/terms/Core/PresenceType</seealso>
    let ``Core/PresenceType`` = Prefixed_Name(spdx, "Core/PresenceType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/PresenceType/yes</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/PresenceType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Indicates presence of the field.</para>
    /// labels<para>yes</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/PresenceType/yes">https://spdx.org/rdf/3.1/terms/Core/PresenceType/yes</seealso>
    let ``Core/PresenceType/yes`` =
        Prefixed_Name(spdx, "Core/PresenceType/yes") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/useSensitivePersonalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Records if sensitive personal information is used during model training or
    /// could be used during the inference.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/useSensitivePersonalInformation">https://spdx.org/rdf/3.1/terms/AI/useSensitivePersonalInformation</seealso>
    let ``AI/useSensitivePersonalInformation`` =
        Prefixed_Name(spdx, "AI/useSensitivePersonalInformation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/DictionaryEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>A key with an associated value.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/DictionaryEntry">https://spdx.org/rdf/3.1/terms/Core/DictionaryEntry</seealso>
    let ``Core/DictionaryEntry`` =
        Prefixed_Name(spdx, "Core/DictionaryEntry") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/IsoAutomationLevel/highAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/IsoAutomationLevel</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Level 4 - High automation. The system performs parts of its mission without external intervention.</para>
    /// labels<para>highAutomation</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/highAutomation">https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/highAutomation</seealso>
    let ``Core/IsoAutomationLevel/highAutomation`` =
        Prefixed_Name(spdx, "Core/IsoAutomationLevel/highAutomation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/IsoAutomationLevel/conditionalAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/IsoAutomationLevel</para>
    ///   <para>Level 3 - Conditional automation. The system can propose strategies and then automatically execute the approved plan, with an external agent being ready to take over when necessary.</para>
    /// labels<para>conditionalAutomation</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/conditionalAutomation">https://spdx.org/rdf/3.1/terms/Core/IsoAutomationLevel/conditionalAutomation</seealso>
    let ``Core/IsoAutomationLevel/conditionalAutomation`` =
        Prefixed_Name(spdx, "Core/IsoAutomationLevel/conditionalAutomation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/isoAutomationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>ISO level of automation.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/isoAutomationLevel">https://spdx.org/rdf/3.1/terms/Core/isoAutomationLevel</seealso>
    let ``Core/isoAutomationLevel`` =
        Prefixed_Name(spdx, "Core/isoAutomationLevel") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/metric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Metric used to evaluate the AI model.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/metric">https://spdx.org/rdf/3.1/terms/AI/metric</seealso>
    let ``AI/metric`` = Prefixed_Name(spdx, "AI/metric") |> PrefixedName
    /// <summary>
    ///   <para>spdx:AI/autonomyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>**DEPRECATED in SPDX 3.1.**
    /// Use [/Core/isoAutomationLevel](../../Core/Properties/isoAutomationLevel.md)
    /// instead.
    ///
    /// Indicates whether the system can perform a decision or action without human
    /// involvement or guidance.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/autonomyType">https://spdx.org/rdf/3.1/terms/AI/autonomyType</seealso>
    let ``AI/autonomyType`` = Prefixed_Name(spdx, "AI/autonomyType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/standardCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Standard that an artifact is being complied with.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/standardCompliance">https://spdx.org/rdf/3.1/terms/AI/standardCompliance</seealso>
    let ``AI/standardCompliance`` =
        Prefixed_Name(spdx, "AI/standardCompliance") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/modelExplainability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Methods that can be used to explain the results from the AI model.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/modelExplainability">https://spdx.org/rdf/3.1/terms/AI/modelExplainability</seealso>
    let ``AI/modelExplainability`` =
        Prefixed_Name(spdx, "AI/modelExplainability") |> PrefixedName

    /// <summary>
    ///   <para>spdx:AI/domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Domain in which the AI package can be used.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/AI/domain">https://spdx.org/rdf/3.1/terms/AI/domain</seealso>
    let ``AI/domain`` = Prefixed_Name(spdx, "AI/domain") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/releaseTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies the time an artifact was released.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/releaseTime">https://spdx.org/rdf/3.1/terms/Core/releaseTime</seealso>
    let ``Core/releaseTime`` = Prefixed_Name(spdx, "Core/releaseTime") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/SupportType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Type of support that is associated with an artifact.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SupportType">https://spdx.org/rdf/3.1/terms/Core/SupportType</seealso>
    let ``Core/SupportType`` = Prefixed_Name(spdx, "Core/SupportType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SupportType/development</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/SupportType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The artifact is in active development and is not considered ready for formal support from the supplier.</para>
    /// labels<para>development</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SupportType/development">https://spdx.org/rdf/3.1/terms/Core/SupportType/development</seealso>
    let ``Core/SupportType/development`` =
        Prefixed_Name(spdx, "Core/SupportType/development") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/SupportType/support</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/SupportType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The artifact has been released, and is supported from the supplier. There is a validUntilDate that can provide additional information about the duration of support.</para>
    /// labels<para>support</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/SupportType/support">https://spdx.org/rdf/3.1/terms/Core/SupportType/support</seealso>
    let ``Core/SupportType/support`` =
        Prefixed_Name(spdx, "Core/SupportType/support") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/supportLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the level of support associated with an artifact.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/supportLevel">https://spdx.org/rdf/3.1/terms/Core/supportLevel</seealso>
    let ``Core/supportLevel`` = Prefixed_Name(spdx, "Core/supportLevel") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/Bom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A container for a grouping of SPDX 3 content characterizing details
    /// (provenance, composition, licensing, etc.) about a product.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Bom">https://spdx.org/rdf/3.1/terms/Core/Bom</seealso>
    let ``Core/Bom`` = Prefixed_Name(spdx, "Core/Bom") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/Bundle</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>A collection of Elements that have a shared context.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Bundle">https://spdx.org/rdf/3.1/terms/Core/Bundle</seealso>
    let ``Core/Bundle`` = Prefixed_Name(spdx, "Core/Bundle") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Gives information about the circumstances or unifying properties
    /// that Elements of the bundle have been assembled under.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/context">https://spdx.org/rdf/3.1/terms/Core/context</seealso>
    let ``Core/context`` = Prefixed_Name(spdx, "Core/context") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ContactPointRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>A contact point from an Artifact to an Agent.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationship">https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationship</seealso>
    let ``Core/ContactPointRelationship`` =
        Prefixed_Name(spdx, "Core/ContactPointRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/Relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Describes a relationship between one or more elements.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Relationship">https://spdx.org/rdf/3.1/terms/Core/Relationship</seealso>
    let ``Core/Relationship`` = Prefixed_Name(spdx, "Core/Relationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ContactPointRelationshipType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information about the type of contact point for `ContactPointRelationship`s.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType">https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType</seealso>
    let ``Core/ContactPointRelationshipType`` =
        Prefixed_Name(spdx, "Core/ContactPointRelationshipType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ContactPointRelationshipType/compliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ContactPointRelationshipType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A contact point for compliance (i.e. export control, licensing).</para>
    /// labels<para>compliance</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/compliance">https://spdx.org/rdf/3.1/terms/Core/ContactPointRelationshipType/compliance</seealso>
    let ``Core/ContactPointRelationshipType/compliance`` =
        Prefixed_Name(spdx, "Core/ContactPointRelationshipType/compliance") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provide consumers with comments by the creator of the Element about the
    /// Element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/comment">https://spdx.org/rdf/3.1/terms/Core/comment</seealso>
    let ``Core/comment`` = Prefixed_Name(spdx, "Core/comment") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/Tool</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An element of hardware and/or software utilized to carry out a particular function.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Tool">https://spdx.org/rdf/3.1/terms/Core/Tool</seealso>
    let ``Core/Tool`` = Prefixed_Name(spdx, "Core/Tool") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/createdUsing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Identifies the tooling that was used during the creation of the Element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/createdUsing">https://spdx.org/rdf/3.1/terms/Core/createdUsing</seealso>
    let ``Core/createdUsing`` = Prefixed_Name(spdx, "Core/createdUsing") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/processVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Defines the version of a specific process.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/processVersion">https://spdx.org/rdf/3.1/terms/Core/processVersion</seealso>
    let ``Core/processVersion`` =
        Prefixed_Name(spdx, "Core/processVersion") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProcessReadinessType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ProcessReadinessType is defined by the enumeration.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType">https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType</seealso>
    let ``Core/ProcessReadinessType`` =
        Prefixed_Name(spdx, "Core/ProcessReadinessType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProcessReadinessType/draft</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProcessReadinessType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>in production</para>
    /// labels<para>draft</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/draft">https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/draft</seealso>
    let ``Core/ProcessReadinessType/draft`` =
        Prefixed_Name(spdx, "Core/ProcessReadinessType/draft") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProcessReadinessType/obsolete</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProcessReadinessType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>superseded or not valid at present</para>
    /// labels<para>obsolete</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/obsolete">https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/obsolete</seealso>
    let ``Core/ProcessReadinessType/obsolete`` =
        Prefixed_Name(spdx, "Core/ProcessReadinessType/obsolete") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProcessReadinessType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ProcessReadinessType</para>
    ///   <para>other</para>
    /// labels<para>other</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/other">https://spdx.org/rdf/3.1/terms/Core/ProcessReadinessType/other</seealso>
    let ``Core/ProcessReadinessType/other`` =
        Prefixed_Name(spdx, "Core/ProcessReadinessType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/processReadiness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>processReadiness describes the readiness of a process.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/processReadiness">https://spdx.org/rdf/3.1/terms/Core/processReadiness</seealso>
    let ``Core/processReadiness`` =
        Prefixed_Name(spdx, "Core/processReadiness") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/processRationale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The reason a process exists.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/processRationale">https://spdx.org/rdf/3.1/terms/Core/processRationale</seealso>
    let ``Core/processRationale`` =
        Prefixed_Name(spdx, "Core/processRationale") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/DefinedType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>The DefinedType class associates a specific type with its defined source.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/DefinedType">https://spdx.org/rdf/3.1/terms/Core/DefinedType</seealso>
    let ``Core/DefinedType`` = Prefixed_Name(spdx, "Core/DefinedType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/Specification</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>A specification is a detailed description of the design, requirements,
    /// or features of a product, process, or system.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/Specification">https://spdx.org/rdf/3.1/terms/Core/Specification</seealso>
    let ``Core/Specification`` =
        Prefixed_Name(spdx, "Core/Specification") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/definitionSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>It is the authoritative or credible entity, document, or body of knowledge that provides the meaning of a type, ensuring accuracy, context, and standardization.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/definitionSource">https://spdx.org/rdf/3.1/terms/Core/definitionSource</seealso>
    let ``Core/definitionSource`` =
        Prefixed_Name(spdx, "Core/definitionSource") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/typeFromSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>typeFromSource is a value used to define an item within the definitionSource.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/typeFromSource">https://spdx.org/rdf/3.1/terms/Core/typeFromSource</seealso>
    let ``Core/typeFromSource`` =
        Prefixed_Name(spdx, "Core/typeFromSource") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A value used in a generic key-value pair.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/value">https://spdx.org/rdf/3.1/terms/Core/value</seealso>
    let ``Core/value`` = Prefixed_Name(spdx, "Core/value") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/ExternalRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>A reference to a resource outside the scope of SPDX 3 content related to an Element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRef">https://spdx.org/rdf/3.1/terms/Core/ExternalRef</seealso>
    let ``Core/ExternalRef`` = Prefixed_Name(spdx, "Core/ExternalRef") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/externalRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Points to a resource outside the scope of the SPDX 3 content
    /// that provides additional characteristics of an Element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/externalRef">https://spdx.org/rdf/3.1/terms/Core/externalRef</seealso>
    let ``Core/externalRef`` = Prefixed_Name(spdx, "Core/externalRef") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/creationInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Provides information about the creation of the Element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/creationInfo">https://spdx.org/rdf/3.1/terms/Core/creationInfo</seealso>
    let ``Core/creationInfo`` = Prefixed_Name(spdx, "Core/creationInfo") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/IntegrityMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>Provides an independently reproducible mechanism that permits verification of a specific Element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/IntegrityMethod">https://spdx.org/rdf/3.1/terms/Core/IntegrityMethod</seealso>
    let ``Core/IntegrityMethod`` =
        Prefixed_Name(spdx, "Core/IntegrityMethod") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/verifiedUsing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Provides an IntegrityMethod with which the integrity of an Element can be
    /// asserted.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/verifiedUsing">https://spdx.org/rdf/3.1/terms/Core/verifiedUsing</seealso>
    let ``Core/verifiedUsing`` =
        Prefixed_Name(spdx, "Core/verifiedUsing") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/summary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A short description of an Element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/summary">https://spdx.org/rdf/3.1/terms/Core/summary</seealso>
    let ``Core/summary`` = Prefixed_Name(spdx, "Core/summary") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/externalIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Provides a reference to a resource outside the scope of SPDX 3 content
    /// that uniquely identifies an Element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/externalIdentifier">https://spdx.org/rdf/3.1/terms/Core/externalIdentifier</seealso>
    let ``Core/externalIdentifier`` =
        Prefixed_Name(spdx, "Core/externalIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides a detailed description of the Element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/description">https://spdx.org/rdf/3.1/terms/Core/description</seealso>
    let ``Core/description`` = Prefixed_Name(spdx, "Core/description") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/RequirementVerification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>RequirementVerification class defines the base properties of a verification.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/RequirementVerification">https://spdx.org/rdf/3.1/terms/FunctionalSafety/RequirementVerification</seealso>
    let ``FunctionalSafety/RequirementVerification`` =
        Prefixed_Name(spdx, "FunctionalSafety/RequirementVerification") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvidenceRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>EvidenceRelationship defines the association between pieces of evidence and EvaluationResult.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceRelationship">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceRelationship</seealso>
    let ``FunctionalSafety/EvidenceRelationship`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvidenceRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvaluationResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>EvaluationResult is the result of an evaluation.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResult">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResult</seealso>
    let ``FunctionalSafety/EvaluationResult`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvaluationResult") |> PrefixedName

    /// <summary>
    ///   <para>spdx:ExpandedLicensing/ConjunctiveLicenseSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>Portion of an AnyLicenseInfo representing a set of licensing information
    /// where all elements apply.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ConjunctiveLicenseSet">https://spdx.org/rdf/3.1/terms/ExpandedLicensing/ConjunctiveLicenseSet</seealso>
    let ``ExpandedLicensing/ConjunctiveLicenseSet`` =
        Prefixed_Name(spdx, "ExpandedLicensing/ConjunctiveLicenseSet") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SimpleLicensing/LicenseExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>An SPDX Element containing an SPDX license expression string.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/LicenseExpression">https://spdx.org/rdf/3.1/terms/SimpleLicensing/LicenseExpression</seealso>
    let ``SimpleLicensing/LicenseExpression`` =
        Prefixed_Name(spdx, "SimpleLicensing/LicenseExpression") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SimpleLicensing/SimpleLicensingText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>A license or addition that is not listed on the SPDX License List.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/SimpleLicensingText">https://spdx.org/rdf/3.1/terms/SimpleLicensing/SimpleLicensingText</seealso>
    let ``SimpleLicensing/SimpleLicensingText`` =
        Prefixed_Name(spdx, "SimpleLicensing/SimpleLicensingText") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Extension/CdxPropertyEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>A property name with an associated value.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Extension/CdxPropertyEntry">https://spdx.org/rdf/3.1/terms/Extension/CdxPropertyEntry</seealso>
    let ``Extension/CdxPropertyEntry`` =
        Prefixed_Name(spdx, "Extension/CdxPropertyEntry") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>Temporary endeavor with a beginning and an end and that must be used to create a unique product, service or result.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/Project">https://spdx.org/rdf/3.1/terms/Operations/Project</seealso>
    let ``Operations/Project`` =
        Prefixed_Name(spdx, "Operations/Project") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A state is an instance that describes what a system, component, subsystem, process, or project has achieved at any given time.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/State">https://spdx.org/rdf/3.1/terms/SupplyChain/State</seealso>
    let ``SupplyChain/State`` = Prefixed_Name(spdx, "SupplyChain/State") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/AssemblyAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>AssemblyAction represents the event of creating a product by assembling individual components.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/AssemblyAction">https://spdx.org/rdf/3.1/terms/SupplyChain/AssemblyAction</seealso>
    let ``SupplyChain/AssemblyAction`` =
        Prefixed_Name(spdx, "SupplyChain/AssemblyAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/BoundaryDefinitionProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The Boundary Definition Process refers to the process class used to produce boundaries.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/BoundaryDefinitionProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/BoundaryDefinitionProcess</seealso>
    let ``SupplyChain/BoundaryDefinitionProcess`` =
        Prefixed_Name(spdx, "SupplyChain/BoundaryDefinitionProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/DestroyProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The destruction process is defined in this process.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/DestroyProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/DestroyProcess</seealso>
    let ``SupplyChain/DestroyProcess`` =
        Prefixed_Name(spdx, "SupplyChain/DestroyProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/ResponsibilityChangeAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>ResponsibilityChangeAction refers to the transfer of responsibility from one party to another.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityChangeAction">https://spdx.org/rdf/3.1/terms/SupplyChain/ResponsibilityChangeAction</seealso>
    let ``SupplyChain/ResponsibilityChangeAction`` =
        Prefixed_Name(spdx, "SupplyChain/ResponsibilityChangeAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/TransportProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>A prescribed change to a product's location.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/TransportProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/TransportProcess</seealso>
    let ``SupplyChain/TransportProcess`` =
        Prefixed_Name(spdx, "SupplyChain/TransportProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/ResolutionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Products out of specification require a resolution action. This is the action of resolution.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ResolutionAction">https://spdx.org/rdf/3.1/terms/SupplyChain/ResolutionAction</seealso>
    let ``SupplyChain/ResolutionAction`` =
        Prefixed_Name(spdx, "SupplyChain/ResolutionAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/TestProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Test Process defines the testing process for an element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/TestProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/TestProcess</seealso>
    let ``SupplyChain/TestProcess`` =
        Prefixed_Name(spdx, "SupplyChain/TestProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/DefinedStateProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>This process is used to determine the state of an affected Element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/DefinedStateProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/DefinedStateProcess</seealso>
    let ``SupplyChain/DefinedStateProcess`` =
        Prefixed_Name(spdx, "SupplyChain/DefinedStateProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/StorageProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Prescribes the storage of a product.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/StorageProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/StorageProcess</seealso>
    let ``SupplyChain/StorageProcess`` =
        Prefixed_Name(spdx, "SupplyChain/StorageProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/InstantiateVirtualHardwareProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class that describes an InstantiateVirtualHardwareProcess that is used to define VirtualHardware and its source.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/InstantiateVirtualHardwareProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/InstantiateVirtualHardwareProcess</seealso>
    let ``SupplyChain/InstantiateVirtualHardwareProcess`` =
        Prefixed_Name(spdx, "SupplyChain/InstantiateVirtualHardwareProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/AssemblyProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The AssemblyProcess represents the process of creating a product by assembling a set of components, potentially in a way that allows for at disassembly (at least partially).</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/AssemblyProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/AssemblyProcess</seealso>
    let ``SupplyChain/AssemblyProcess`` =
        Prefixed_Name(spdx, "SupplyChain/AssemblyProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/ManufactureProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class represents the process involved in manufacturing products.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/ManufactureProcess">https://spdx.org/rdf/3.1/terms/SupplyChain/ManufactureProcess</seealso>
    let ``SupplyChain/ManufactureProcess`` =
        Prefixed_Name(spdx, "SupplyChain/ManufactureProcess") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/BoundaryDefinitionAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>The boundary definition is used to define boundaries.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/BoundaryDefinitionAction">https://spdx.org/rdf/3.1/terms/SupplyChain/BoundaryDefinitionAction</seealso>
    let ``SupplyChain/BoundaryDefinitionAction`` =
        Prefixed_Name(spdx, "SupplyChain/BoundaryDefinitionAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/OutOfSpecAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An out of specification action is defined in this class.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/OutOfSpecAction">https://spdx.org/rdf/3.1/terms/SupplyChain/OutOfSpecAction</seealso>
    let ``SupplyChain/OutOfSpecAction`` =
        Prefixed_Name(spdx, "SupplyChain/OutOfSpecAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SupplyChain/TestAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A test action is a specific action associated with a test.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SupplyChain/TestAction">https://spdx.org/rdf/3.1/terms/SupplyChain/TestAction</seealso>
    let ``SupplyChain/TestAction`` =
        Prefixed_Name(spdx, "SupplyChain/TestAction") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Service/SoftwareService</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>Software provided as a service over a network.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Service/SoftwareService">https://spdx.org/rdf/3.1/terms/Service/SoftwareService</seealso>
    let ``Service/SoftwareService`` =
        Prefixed_Name(spdx, "Service/SoftwareService") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/File</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>Refers to any object that stores content on a computer.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/File">https://spdx.org/rdf/3.1/terms/Software/File</seealso>
    let ``Software/File`` = Prefixed_Name(spdx, "Software/File") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Software/Sbom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>A collection of SPDX Elements describing a single package.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/Sbom">https://spdx.org/rdf/3.1/terms/Software/Sbom</seealso>
    let ``Software/Sbom`` = Prefixed_Name(spdx, "Software/Sbom") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/extension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies an Extension characterization of some aspect of an Element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/extension">https://spdx.org/rdf/3.1/terms/Core/extension</seealso>
    let ``Core/extension`` = Prefixed_Name(spdx, "Core/extension") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/rootElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is used to denote the root Element(s) of a tree of elements contained in a BOM.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/rootElement">https://spdx.org/rdf/3.1/terms/Core/rootElement</seealso>
    let ``Core/rootElement`` = Prefixed_Name(spdx, "Core/rootElement") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/element</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Refers to one or more Elements that are part of an ElementCollection.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/element">https://spdx.org/rdf/3.1/terms/Core/element</seealso>
    let ``Core/element`` = Prefixed_Name(spdx, "Core/element") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Enumeration of the valid profiles.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType</seealso>
    let ``Core/ProfileIdentifierType`` =
        Prefixed_Name(spdx, "Core/ProfileIdentifierType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/core</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The element follows the Core profile specification.</para>
    /// labels<para>core</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/core">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/core</seealso>
    let ``Core/ProfileIdentifierType/core`` =
        Prefixed_Name(spdx, "Core/ProfileIdentifierType/core") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/software</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The element follows the Software profile specification.</para>
    /// labels<para>software</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/software">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/software</seealso>
    let ``Core/ProfileIdentifierType/software`` =
        Prefixed_Name(spdx, "Core/ProfileIdentifierType/software") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/simpleLicensing</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The element follows the SimpleLicensing profile specification.</para>
    /// labels<para>simpleLicensing</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/simpleLicensing">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/simpleLicensing</seealso>
    let ``Core/ProfileIdentifierType/simpleLicensing`` =
        Prefixed_Name(spdx, "Core/ProfileIdentifierType/simpleLicensing") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/expandedLicensing</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The element follows the ExpandedLicensing profile specification.</para>
    /// labels<para>expandedLicensing</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/expandedLicensing">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/expandedLicensing</seealso>
    let ``Core/ProfileIdentifierType/expandedLicensing`` =
        Prefixed_Name(spdx, "Core/ProfileIdentifierType/expandedLicensing") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/security</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>The element follows the Security profile specification.</para>
    /// labels<para>security</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/security">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/security</seealso>
    let ``Core/ProfileIdentifierType/security`` =
        Prefixed_Name(spdx, "Core/ProfileIdentifierType/security") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/build</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The element follows the Build profile specification.</para>
    /// labels<para>build</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/build">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/build</seealso>
    let ``Core/ProfileIdentifierType/build`` =
        Prefixed_Name(spdx, "Core/ProfileIdentifierType/build") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/ai</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The element follows the AI profile specification.</para>
    /// labels<para>ai</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/ai">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/ai</seealso>
    let ``Core/ProfileIdentifierType/ai`` =
        Prefixed_Name(spdx, "Core/ProfileIdentifierType/ai") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The element follows the Dataset profile specification.</para>
    /// labels<para>dataset</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/dataset">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/dataset</seealso>
    let ``Core/ProfileIdentifierType/dataset`` =
        Prefixed_Name(spdx, "Core/ProfileIdentifierType/dataset") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ProfileIdentifierType/extension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ProfileIdentifierType</para>
    ///   <para>The element follows the Extension profile specification.</para>
    /// labels<para>extension</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/extension">https://spdx.org/rdf/3.1/terms/Core/ProfileIdentifierType/extension</seealso>
    let ``Core/ProfileIdentifierType/extension`` =
        Prefixed_Name(spdx, "Core/ProfileIdentifierType/extension") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/identifierLocator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides the location for more information regarding an external identifier.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/identifierLocator">https://spdx.org/rdf/3.1/terms/Core/identifierLocator</seealso>
    let ``Core/identifierLocator`` =
        Prefixed_Name(spdx, "Core/identifierLocator") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specifies the type of an external identifier.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType</seealso>
    let ``Core/ExternalIdentifierType`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/cpe22</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>[Common Platform Enumeration Specification 2.2](https://cpe.mitre.org/files/cpe-specification_2.2.pdf).</para>
    /// labels<para>cpe22</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/cpe22">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/cpe22</seealso>
    let ``Core/ExternalIdentifierType/cpe22`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType/cpe22") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/cpe23</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>[Common Platform Enumeration: Naming Specification Version 2.3](https://csrc.nist.gov/publications/detail/nistir/7695/final).</para>
    /// labels<para>cpe23</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/cpe23">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/cpe23</seealso>
    let ``Core/ExternalIdentifierType/cpe23`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType/cpe23") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/cve</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Common Vulnerabilities and Exposures identifiers, an identifier for a specific software flaw defined within the official CVE Dictionary and that conforms to the [CVE specification](https://csrc.nist.gov/glossary/term/cve_id).</para>
    /// labels<para>cve</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/cve">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/cve</seealso>
    let ``Core/ExternalIdentifierType/cve`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType/cve") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/duns</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>[Data Universal Numbering System (D-U-N-S) Number](https://www.dnb.com/en-us/smb/duns.html) is a unique nine-digit identifier, issued by Dun &amp; Bradstreet, that identifies a business entity, often on a location-specific basis.</para>
    /// labels<para>duns</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/duns">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/duns</seealso>
    let ``Core/ExternalIdentifierType/duns`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType/duns") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/email</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Email address, as defined in [RFC 3696](https://datatracker.ietf.org/doc/rfc3696/) Section 3.</para>
    /// labels<para>email</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/email">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/email</seealso>
    let ``Core/ExternalIdentifierType/email`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType/email") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/evidenceUUID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>The UUID used by a reporting management system or any other lifecycle management tool to uniquely identify an evidence relationship item. UUID, or universally unique ID, is a standard term to refer to evidence items.</para>
    /// labels<para>evidenceUUID</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/evidenceUUID">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/evidenceUUID</seealso>
    let ``Core/ExternalIdentifierType/evidenceUUID`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType/evidenceUUID") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/gitoid</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>[Gitoid](https://www.iana.org/assignments/uri-schemes/prov/gitoid), stands for [Git Object ID](https://git-scm.com/book/en/v2/Git-Internals-Git-Objects). A gitoid of type blob is a unique hash of a binary artifact. A gitoid may represent either an [Artifact Identifier](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-identifier-types) for the software artifact or an [Input Manifest Identifier](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#input-manifest-identifier) for the software artifact's associated [Artifact Input Manifest](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-input-manifest); this ambiguity exists because the Artifact Input Manifest is itself an artifact, and the gitoid of that artifact is its valid identifier. Gitoids calculated on software artifacts (Snippet, File, or Package Elements) should be recorded in the SPDX 3 SoftwareArtifact's contentIdentifier property. Gitoids calculated on the Artifact Input Manifest (Input Manifest Identifier) should be recorded in the SPDX 3 Element's externalIdentifier property. See [OmniBOR Specification](https://github.com/omnibor/spec/), a minimalistic specification for describing software [Artifact Dependency Graphs](https://github.com/omnibor/spec/blob/eb1ee5c961c16215eb8709b2975d193a2007a35d/spec/SPEC.md#artifact-dependency-graph-adg).</para>
    /// labels<para>gitoid</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/gitoid">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/gitoid</seealso>
    let ``Core/ExternalIdentifierType/gitoid`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType/gitoid") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/gln</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>[Global Location Number (GLN)](https://www.gs1.org/standards/id-keys/gln) is a 13-digit number, assigned by GS1, that uniquely identifies a legal entity (e.g., a company or customer), a function within a legal entity, a physical location (e.g., a warehouse or a specific shelf in a store), or a digital location (e.g., an Electronic Data Interchange (EDI) gateway).</para>
    /// labels<para>gln</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/gln">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/gln</seealso>
    let ``Core/ExternalIdentifierType/gln`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType/gln") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/glue</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>[GLobal Unique Enterprise (GLUE) Identifiers](https://datatracker.ietf.org/doc/draft-ietf-spice-glue-id/), as defined by the IETF Internet-Draft, is expressed as a GLUE URI, a Uniform Resource Identifier that standardizes the representation of existing organizational entity identifiers.</para>
    /// labels<para>glue</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/glue">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/glue</seealso>
    let ``Core/ExternalIdentifierType/glue`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType/glue") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/gtin</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>[Global Trade Item Number (GTIN)](https://www.gs1.org/standards/id-keys/gtin) is a number, assigned by GS1, that uniquely identifies a trade item (product or service).</para>
    /// labels<para>gtin</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/gtin">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/gtin</seealso>
    let ``Core/ExternalIdentifierType/gtin`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType/gtin") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/hsCodes</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The [Harmonized System (HS)](https://www.wcoomd.org/en/topics/nomenclature/overview/what-is-the-harmonized-system.aspx) of tariff nomenclature is an internationally standardized system of names and numbers, defined by the World Customs Organization, used to classify traded products.</para>
    /// labels<para>hsCodes</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/hsCodes">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/hsCodes</seealso>
    let ``Core/ExternalIdentifierType/hsCodes`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType/hsCodes") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/lei</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The [Legal Entity Identifier (LEI)](https://www.gleif.org/en/organizational-identity/introducing-the-legal-entity-identifier-lei) is a 20-character, alphanumeric code based on the [ISO 17442](https://www.iso.org/standard/78829.html) standard developed by the International Organization for Standardization.</para>
    /// labels<para>lei</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/lei">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/lei</seealso>
    let ``Core/ExternalIdentifierType/lei`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType/lei") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>Used when the type does not match any of the other options.</para>
    /// labels<para>other</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/other">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/other</seealso>
    let ``Core/ExternalIdentifierType/other`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalIdentifierType/packageUrl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalIdentifierType</para>
    ///   <para>Package URL, as defined in the corresponding [Annex](../../../annexes/pkg-url-specification.md) of this document.</para>
    /// labels<para>packageUrl</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/packageUrl">https://spdx.org/rdf/3.1/terms/Core/ExternalIdentifierType/packageUrl</seealso>
    let ``Core/ExternalIdentifierType/packageUrl`` =
        Prefixed_Name(spdx, "Core/ExternalIdentifierType/packageUrl") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/externalSpdxId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identifies an external Element used within an SpdxDocument but defined
    /// external to that SpdxDocument.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/externalSpdxId">https://spdx.org/rdf/3.1/terms/Core/externalSpdxId</seealso>
    let ``Core/externalSpdxId`` =
        Prefixed_Name(spdx, "Core/externalSpdxId") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/locationHint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides an indication of where to retrieve an external Element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/locationHint">https://spdx.org/rdf/3.1/terms/Core/locationHint</seealso>
    let ``Core/locationHint`` = Prefixed_Name(spdx, "Core/locationHint") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/definingArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Artifact representing a serialization instance of SPDX data containing the
    /// definition of a particular Element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/definingArtifact">https://spdx.org/rdf/3.1/terms/Core/definingArtifact</seealso>
    let ``Core/definingArtifact`` =
        Prefixed_Name(spdx, "Core/definingArtifact") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specifies the type of an external reference.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType</seealso>
    let ``Core/ExternalRefType`` =
        Prefixed_Name(spdx, "Core/ExternalRefType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/altDownloadLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>A reference to an alternative download location.</para>
    /// labels<para>altDownloadLocation</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/altDownloadLocation">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/altDownloadLocation</seealso>
    let ``Core/ExternalRefType/altDownloadLocation`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/altDownloadLocation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/altWebPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to an alternative web page.</para>
    /// labels<para>altWebPage</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/altWebPage">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/altWebPage</seealso>
    let ``Core/ExternalRefType/altWebPage`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/altWebPage") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/binaryArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>A reference to binary artifacts related to a package.</para>
    /// labels<para>binaryArtifact</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/binaryArtifact">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/binaryArtifact</seealso>
    let ``Core/ExternalRefType/binaryArtifact`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/binaryArtifact") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/bower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>A reference to a Bower package. The package locator format, looks like `package#version`, is defined in the "install" section of [Bower API documentation](https://bower.io/docs/api/#install).</para>
    /// labels<para>bower</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/bower">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/bower</seealso>
    let ``Core/ExternalRefType/bower`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/bower") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/buildMeta</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference build metadata related to a published package.</para>
    /// labels<para>buildMeta</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/buildMeta">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/buildMeta</seealso>
    let ``Core/ExternalRefType/buildMeta`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/buildMeta") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/exportControlAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>A reference to an export control assessment for a package.</para>
    /// labels<para>exportControlAssessment</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/exportControlAssessment">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/exportControlAssessment</seealso>
    let ``Core/ExternalRefType/exportControlAssessment`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/exportControlAssessment") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/funding</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to funding information related to a package.</para>
    /// labels<para>funding</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/funding">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/funding</seealso>
    let ``Core/ExternalRefType/funding`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/funding") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/issueTracker</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to the issue tracker for a package.</para>
    /// labels<para>issueTracker</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/issueTracker">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/issueTracker</seealso>
    let ``Core/ExternalRefType/issueTracker`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/issueTracker") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/mailingList</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to the mailing list used by the maintainer for a package.</para>
    /// labels<para>mailingList</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/mailingList">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/mailingList</seealso>
    let ``Core/ExternalRefType/mailingList`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/mailingList") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/mavenCentral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>A reference to a Maven repository artifact. The artifact locator format is defined in the [Maven documentation](https://maven.apache.org/guides/mini/guide-naming-conventions.html) and looks like `groupId:artifactId[:version]`.</para>
    /// labels<para>mavenCentral</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/mavenCentral">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/mavenCentral</seealso>
    let ``Core/ExternalRefType/mavenCentral`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/mavenCentral") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/metrics</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to metrics related to package such as OpenSSF scorecards.</para>
    /// labels<para>metrics</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/metrics">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/metrics</seealso>
    let ``Core/ExternalRefType/metrics`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/metrics") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/npm</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to an npm package. The package locator format is defined in the [npm documentation](https://docs.npmjs.com/cli/v10/configuring-npm/package-json) and looks like `package@version`.</para>
    /// labels<para>npm</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/npm">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/npm</seealso>
    let ``Core/ExternalRefType/npm`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/npm") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/nuget</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to a NuGet package. The package locator format is defined in the [NuGet documentation](https://docs.nuget.org) and looks like `package/version`.</para>
    /// labels<para>nuget</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/nuget">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/nuget</seealso>
    let ``Core/ExternalRefType/nuget`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/nuget") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/license</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>A reference to additional license information related to an artifact.</para>
    /// labels<para>license</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/license">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/license</seealso>
    let ``Core/ExternalRefType/license`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/license") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Used when the type does not match any of the other options.</para>
    /// labels<para>other</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/other">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/other</seealso>
    let ``Core/ExternalRefType/other`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/privacyAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to a privacy assessment for a package.</para>
    /// labels<para>privacyAssessment</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/privacyAssessment">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/privacyAssessment</seealso>
    let ``Core/ExternalRefType/privacyAssessment`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/privacyAssessment") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/productMetadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>A reference to additional product metadata such as reference within organization's product catalog.</para>
    /// labels<para>productMetadata</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/productMetadata">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/productMetadata</seealso>
    let ``Core/ExternalRefType/productMetadata`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/productMetadata") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/purchaseOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>A reference to a purchase order for a package.</para>
    /// labels<para>purchaseOrder</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/purchaseOrder">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/purchaseOrder</seealso>
    let ``Core/ExternalRefType/purchaseOrder`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/purchaseOrder") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/qualityAssessmentReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to a quality assessment for a package.</para>
    /// labels<para>qualityAssessmentReport</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/qualityAssessmentReport">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/qualityAssessmentReport</seealso>
    let ``Core/ExternalRefType/qualityAssessmentReport`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/qualityAssessmentReport") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/releaseNotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to the release notes for a package.</para>
    /// labels<para>releaseNotes</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/releaseNotes">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/releaseNotes</seealso>
    let ``Core/ExternalRefType/releaseNotes`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/releaseNotes") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/releaseHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to a published list of releases for a package.</para>
    /// labels<para>releaseHistory</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/releaseHistory">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/releaseHistory</seealso>
    let ``Core/ExternalRefType/releaseHistory`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/releaseHistory") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/staticAnalysisReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to a static analysis report for a package.</para>
    /// labels<para>staticAnalysisReport</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/staticAnalysisReport">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/staticAnalysisReport</seealso>
    let ``Core/ExternalRefType/staticAnalysisReport`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/staticAnalysisReport") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/support</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to the software support channel or other support information for a package.</para>
    /// labels<para>support</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/support">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/support</seealso>
    let ``Core/ExternalRefType/support`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/support") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/vcs</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to a version control system related to a software artifact.</para>
    /// labels<para>vcs</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/vcs">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/vcs</seealso>
    let ``Core/ExternalRefType/vcs`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/vcs") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/vulnerabilityDisclosureReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A reference to a Vulnerability Disclosure Report (VDR) which provides the software supplier's analysis and findings describing the impact (or lack of impact) that reported vulnerabilities have on packages or products in the supplier's SBOM as defined in [NIST SP 800-161 Cybersecurity Supply Chain Risk Management Practices for Systems and Organizations](https://csrc.nist.gov/pubs/sp/800/161/r1/final).</para>
    /// labels<para>vulnerabilityDisclosureReport</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/vulnerabilityDisclosureReport">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/vulnerabilityDisclosureReport</seealso>
    let ``Core/ExternalRefType/vulnerabilityDisclosureReport`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/vulnerabilityDisclosureReport") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/vulnerabilityExploitabilityAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>A reference to a Vulnerability Exploitability eXchange (VEX) statement which provides information on whether a product is impacted by a specific vulnerability in an included package and, if affected, whether there are actions recommended to remediate. See also [NTIA VEX one-page summary](https://ntia.gov/files/ntia/publications/vex_one-page_summary.pdf).</para>
    /// labels<para>vulnerabilityExploitabilityAssessment</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/vulnerabilityExploitabilityAssessment">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/vulnerabilityExploitabilityAssessment</seealso>
    let ``Core/ExternalRefType/vulnerabilityExploitabilityAssessment`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/vulnerabilityExploitabilityAssessment") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/ExternalRefType/x509Cert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/ExternalRefType</para>
    ///   <para>A reference to an X.509 certificate as defined in [RFC 1422](https://datatracker.ietf.org/doc/rfc1422/). The media type shall be one of application/x-x509-ca-cert or application/x-x509-user-cert.</para>
    /// labels<para>x509Cert</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/x509Cert">https://spdx.org/rdf/3.1/terms/Core/ExternalRefType/x509Cert</seealso>
    let ``Core/ExternalRefType/x509Cert`` =
        Prefixed_Name(spdx, "Core/ExternalRefType/x509Cert") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/externalRefType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the type of the external reference.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/externalRefType">https://spdx.org/rdf/3.1/terms/Core/externalRefType</seealso>
    let ``Core/externalRefType`` =
        Prefixed_Name(spdx, "Core/externalRefType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/locator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Provides the location of an external reference.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/locator">https://spdx.org/rdf/3.1/terms/Core/locator</seealso>
    let ``Core/locator`` = Prefixed_Name(spdx, "Core/locator") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A mathematical algorithm that maps data of arbitrary size to a bit string.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm</seealso>
    let ``Core/HashAlgorithm`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/adler32</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>Adler-32 checksum is part of the widely used zlib compression library as defined in [RFC 1950](https://datatracker.ietf.org/doc/rfc1950/) Section 2.3.</para>
    /// labels<para>adler32</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/adler32">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/adler32</seealso>
    let ``Core/HashAlgorithm/adler32`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm/adler32") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/blake2b256</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>BLAKE2b algorithm with a digest size of 256, as defined in [RFC 7693](https://datatracker.ietf.org/doc/rfc7693/) Section 4.</para>
    /// labels<para>blake2b256</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake2b256">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake2b256</seealso>
    let ``Core/HashAlgorithm/blake2b256`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm/blake2b256") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/blake2b384</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>BLAKE2b algorithm with a digest size of 384, as defined in [RFC 7693](https://datatracker.ietf.org/doc/rfc7693/) Section 4.</para>
    /// labels<para>blake2b384</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake2b384">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake2b384</seealso>
    let ``Core/HashAlgorithm/blake2b384`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm/blake2b384") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/blake2b512</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>BLAKE2b algorithm with a digest size of 512, as defined in [RFC 7693](https://datatracker.ietf.org/doc/rfc7693/) Section 4.</para>
    /// labels<para>blake2b512</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake2b512">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake2b512</seealso>
    let ``Core/HashAlgorithm/blake2b512`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm/blake2b512") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/blake3</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>[BLAKE3](https://github.com/BLAKE3-team/BLAKE3-specs/blob/master/blake3.pdf)</para>
    /// labels<para>blake3</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake3">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/blake3</seealso>
    let ``Core/HashAlgorithm/blake3`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm/blake3") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/crystalsDilithium</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>[Dilithium](https://pq-crystals.org/dilithium/)</para>
    /// labels<para>crystalsDilithium</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/crystalsDilithium">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/crystalsDilithium</seealso>
    let ``Core/HashAlgorithm/crystalsDilithium`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm/crystalsDilithium") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/crystalsKyber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>[Kyber](https://pq-crystals.org/kyber/)</para>
    /// labels<para>crystalsKyber</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/crystalsKyber">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/crystalsKyber</seealso>
    let ``Core/HashAlgorithm/crystalsKyber`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm/crystalsKyber") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/falcon</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>[FALCON](https://falcon-sign.info/falcon.pdf)</para>
    /// labels<para>falcon</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/falcon">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/falcon</seealso>
    let ``Core/HashAlgorithm/falcon`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm/falcon") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/md2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>MD2 message-digest algorithm, as defined in [RFC 1319](https://datatracker.ietf.org/doc/rfc1319/).</para>
    /// labels<para>md2</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md2">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md2</seealso>
    let ``Core/HashAlgorithm/md2`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm/md2") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/md4</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>MD4 message-digest algorithm, as defined in [RFC 1186](https://datatracker.ietf.org/doc/rfc1186/).</para>
    /// labels<para>md4</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md4">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md4</seealso>
    let ``Core/HashAlgorithm/md4`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm/md4") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/md5</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>MD5 message-digest algorithm, as defined in [RFC 1321](https://datatracker.ietf.org/doc/rfc1321/).</para>
    /// labels<para>md5</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md5">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md5</seealso>
    let ``Core/HashAlgorithm/md5`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm/md5") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/md6</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>[MD6 hash function](https://people.csail.mit.edu/rivest/pubs/RABCx08.pdf)</para>
    /// labels<para>md6</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md6">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/md6</seealso>
    let ``Core/HashAlgorithm/md6`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm/md6") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>any hashing algorithm that does not exist in this list of entries</para>
    /// labels<para>other</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/other">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/other</seealso>
    let ``Core/HashAlgorithm/other`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/sha1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>SHA-1, a secure hashing algorithm, as defined in [RFC 3174](https://datatracker.ietf.org/doc/rfc3174/).</para>
    /// labels<para>sha1</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha1">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha1</seealso>
    let ``Core/HashAlgorithm/sha1`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm/sha1") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/sha224</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>SHA-2 with a digest length of 224, as defined in [RFC 3874](https://datatracker.ietf.org/doc/rfc3874/).</para>
    /// labels<para>sha224</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha224">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha224</seealso>
    let ``Core/HashAlgorithm/sha224`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm/sha224") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/sha256</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>SHA-2 with a digest length of 256, as defined in [RFC 6234](https://datatracker.ietf.org/doc/rfc6234/).</para>
    /// labels<para>sha256</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha256">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha256</seealso>
    let ``Core/HashAlgorithm/sha256`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm/sha256") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/sha384</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>SHA-2 with a digest length of 384, as defined in [RFC 6234](https://datatracker.ietf.org/doc/rfc6234/).</para>
    /// labels<para>sha384</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha384">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha384</seealso>
    let ``Core/HashAlgorithm/sha384`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm/sha384") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/sha512</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>SHA-2 with a digest length of 512, as defined in [RFC 6234](https://datatracker.ietf.org/doc/rfc6234/).</para>
    /// labels<para>sha512</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha512">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha512</seealso>
    let ``Core/HashAlgorithm/sha512`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm/sha512") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/sha3_224</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>SHA-3 with a digest length of 224, as defined in [FIPS 202](https://csrc.nist.gov/pubs/fips/202/final).</para>
    /// labels<para>sha3_224</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_224">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_224</seealso>
    let ``Core/HashAlgorithm/sha3_224`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm/sha3_224") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/sha3_256</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>SHA-3 with a digest length of 256, as defined in [FIPS 202](https://csrc.nist.gov/pubs/fips/202/final).</para>
    /// labels<para>sha3_256</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_256">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_256</seealso>
    let ``Core/HashAlgorithm/sha3_256`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm/sha3_256") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/sha3_384</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>SHA-3 with a digest length of 384, as defined in [FIPS 202](https://csrc.nist.gov/pubs/fips/202/final).</para>
    /// labels<para>sha3_384</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_384">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_384</seealso>
    let ``Core/HashAlgorithm/sha3_384`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm/sha3_384") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/HashAlgorithm/sha3_512</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Core/HashAlgorithm</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>SHA-3 with a digest length of 512, as defined in [FIPS 202](https://csrc.nist.gov/pubs/fips/202/final).</para>
    /// labels<para>sha3_512</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_512">https://spdx.org/rdf/3.1/terms/Core/HashAlgorithm/sha3_512</seealso>
    let ``Core/HashAlgorithm/sha3_512`` =
        Prefixed_Name(spdx, "Core/HashAlgorithm/sha3_512") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/algorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies the algorithm used for calculating the hash value.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/algorithm">https://spdx.org/rdf/3.1/terms/Core/algorithm</seealso>
    let ``Core/algorithm`` = Prefixed_Name(spdx, "Core/algorithm") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Core/hashValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The result of applying a hash algorithm to an Element.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/hashValue">https://spdx.org/rdf/3.1/terms/Core/hashValue</seealso>
    let ``Core/hashValue`` = Prefixed_Name(spdx, "Core/hashValue") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Extension/Extension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A characterization of some aspect of an Element that is associated with the Element in a generalized fashion.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Extension/Extension">https://spdx.org/rdf/3.1/terms/Extension/Extension</seealso>
    let ``Extension/Extension`` =
        Prefixed_Name(spdx, "Extension/Extension") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Core/inLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies a human language used within the content of an Element or a property.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Core/inLanguage">https://spdx.org/rdf/3.1/terms/Core/inLanguage</seealso>
    let ``Core/inLanguage`` = Prefixed_Name(spdx, "Core/inLanguage") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/evaluationRationale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Detailed explanation or reasoning that supports the EvaluationResult.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/evaluationRationale">https://spdx.org/rdf/3.1/terms/FunctionalSafety/evaluationRationale</seealso>
    let ``FunctionalSafety/evaluationRationale`` =
        Prefixed_Name(spdx, "FunctionalSafety/evaluationRationale") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvidenceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>EvidenceType refers to categories of documented or observable proof used to verify compliance, qualification, or performance</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType</seealso>
    let ``FunctionalSafety/EvidenceType`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvidenceType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvidenceType/report</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:FunctionalSafety/EvidenceType</para>
    ///   <para>Structured documentation of test results, inspections, or analyses.</para>
    /// labels<para>report</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/report">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/report</seealso>
    let ``FunctionalSafety/EvidenceType/report`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvidenceType/report") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvidenceType/log</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:FunctionalSafety/EvidenceType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Time-stamped records capturing system or operational data recorded as usually as a response to specific triggers in a specified environment.</para>
    /// labels<para>log</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/log">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/log</seealso>
    let ``FunctionalSafety/EvidenceType/log`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvidenceType/log") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvidenceType/recording</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:FunctionalSafety/EvidenceType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Captured datastream like audio, video, or any other kind of continuous electronic capture of events, behavior or conditions.</para>
    /// labels<para>recording</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/recording">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/recording</seealso>
    let ``FunctionalSafety/EvidenceType/recording`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvidenceType/recording") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvidenceType/observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:FunctionalSafety/EvidenceType</para>
    ///   <para>Documentation of direct monitoring or witnessing of the demonstration of processes, tests, or any kind of system responses during a specified timeframe under specified environmental conditions.</para>
    /// labels<para>observation</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/observation">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/observation</seealso>
    let ``FunctionalSafety/EvidenceType/observation`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvidenceType/observation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvidenceType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:FunctionalSafety/EvidenceType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Any other relevant type of proof or documentation not covered above.</para>
    /// labels<para>other</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/other">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/other</seealso>
    let ``FunctionalSafety/EvidenceType/other`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvidenceType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/evidenceCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>evidenceCategory refers to a category of documented or observable proof.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/evidenceCategory">https://spdx.org/rdf/3.1/terms/FunctionalSafety/evidenceCategory</seealso>
    let ``FunctionalSafety/evidenceCategory`` =
        Prefixed_Name(spdx, "FunctionalSafety/evidenceCategory") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/evidenceUUID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A evidenceUUID is a universally unique identifier (UUID) assigned to an entity, item, or requirement.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/evidenceUUID">https://spdx.org/rdf/3.1/terms/FunctionalSafety/evidenceUUID</seealso>
    let ``FunctionalSafety/evidenceUUID`` =
        Prefixed_Name(spdx, "FunctionalSafety/evidenceUUID") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/verificationRationale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A verificationRationale is supporting information that justifies the verification details.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationRationale">https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationRationale</seealso>
    let ``FunctionalSafety/verificationRationale`` =
        Prefixed_Name(spdx, "FunctionalSafety/verificationRationale") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/verificationPrecondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Verification preconditions are initial criteria that are to be met prior to initiating the verification method.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationPrecondition">https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationPrecondition</seealso>
    let ``FunctionalSafety/verificationPrecondition`` =
        Prefixed_Name(spdx, "FunctionalSafety/verificationPrecondition") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/verificationUUID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A verificationUUID is a universally unique identifier (UUID) assigned to a Verification item.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationUUID">https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationUUID</seealso>
    let ``FunctionalSafety/verificationUUID`` =
        Prefixed_Name(spdx, "FunctionalSafety/verificationUUID") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/VerificationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Enumeration of verification types.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType">https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType</seealso>
    let ``FunctionalSafety/VerificationType`` =
        Prefixed_Name(spdx, "FunctionalSafety/VerificationType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/VerificationType/analysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:FunctionalSafety/VerificationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Analytical evaluating of data, designs, or processes methodically to verify correctness against standards or expectations. Typical analysis methods are FMEA, FTA, STPA, static analysis for MISRA compliance etc.</para>
    /// labels<para>analysis</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/analysis">https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/analysis</seealso>
    let ``FunctionalSafety/VerificationType/analysis`` =
        Prefixed_Name(spdx, "FunctionalSafety/VerificationType/analysis") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/VerificationType/assessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:FunctionalSafety/VerificationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A systematic examination of a system, process, or outcome to evaluate compliance of specific work products with a specific expectation with a specification, regulation or standard. Often involves judgement and a rationale of this judgement.</para>
    /// labels<para>assessment</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/assessment">https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/assessment</seealso>
    let ``FunctionalSafety/VerificationType/assessment`` =
        Prefixed_Name(spdx, "FunctionalSafety/VerificationType/assessment") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/VerificationType/audit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:FunctionalSafety/VerificationType</para>
    ///   <para>An examination typically focusing on compliance with policies, standards, or regulations. Usually this is done during an audit meeting, while the assessment also involves deep and detailed reviews of work products (e.g. requirements, verification specifications, reports etc.)</para>
    /// labels<para>audit</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/audit">https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/audit</seealso>
    let ``FunctionalSafety/VerificationType/audit`` =
        Prefixed_Name(spdx, "FunctionalSafety/VerificationType/audit") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/VerificationType/demonstration</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:FunctionalSafety/VerificationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Demonstrating and monitoring or recording that the item under verification to confirm that a requirement is met by the item under verification.</para>
    /// labels<para>demonstration</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/demonstration">https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/demonstration</seealso>
    let ``FunctionalSafety/VerificationType/demonstration`` =
        Prefixed_Name(spdx, "FunctionalSafety/VerificationType/demonstration") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/VerificationType/inspection</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:FunctionalSafety/VerificationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A thorough examination or checking of documentation, records, processes, or systems to confirm compliance or adherence. An inspection needs to have a defined set of acceptance criteria (e.g. a checklist), a documentation of roles involved in the inspection (e.g. to document the inspector's independence) and a clear documentation of when and how it was performed.</para>
    /// labels<para>inspection</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/inspection">https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/inspection</seealso>
    let ``FunctionalSafety/VerificationType/inspection`` =
        Prefixed_Name(spdx, "FunctionalSafety/VerificationType/inspection") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/VerificationType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:FunctionalSafety/VerificationType</para>
    ///   <para>Any other specialized or custom verification method that fits the context.</para>
    /// labels<para>other</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/other">https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/other</seealso>
    let ``FunctionalSafety/VerificationType/other`` =
        Prefixed_Name(spdx, "FunctionalSafety/VerificationType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/VerificationType/review</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:FunctionalSafety/VerificationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A examination or checking of documentation, records, processes, or systems to confirm compliance or adherence with an upper level requirement. Typically done as peer review, offline review or review meeting.</para>
    /// labels<para>review</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/review">https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/review</seealso>
    let ``FunctionalSafety/VerificationType/review`` =
        Prefixed_Name(spdx, "FunctionalSafety/VerificationType/review") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/VerificationType/test</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:FunctionalSafety/VerificationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Conducting controlled tests, experiments or simulations to verify that specific requirements regarding performance, functionality, robustness, etc. are met.</para>
    /// labels<para>test</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/test">https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/test</seealso>
    let ``FunctionalSafety/VerificationType/test`` =
        Prefixed_Name(spdx, "FunctionalSafety/VerificationType/test") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/verificationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>verificationMethod refers to the specific approach used for a checking an element's conformance with its requirements.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationMethod">https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationMethod</seealso>
    let ``FunctionalSafety/verificationMethod`` =
        Prefixed_Name(spdx, "FunctionalSafety/verificationMethod") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/verificationPostcondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Verification postcondition that are true immediately after a verification method has been performed</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationPostcondition">https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationPostcondition</seealso>
    let ``FunctionalSafety/verificationPostcondition`` =
        Prefixed_Name(spdx, "FunctionalSafety/verificationPostcondition") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VexJustificationType/vulnerableCodeCannotBeControlledByAdversary</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:Security/VexJustificationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The vulnerable component is present, and the component contains the vulnerable code. However, vulnerable code is used in such a way that an attacker cannot mount any anticipated attack.</para>
    /// labels<para>vulnerableCodeCannotBeControlledByAdversary</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/vulnerableCodeCannotBeControlledByAdversary">https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/vulnerableCodeCannotBeControlledByAdversary</seealso>
    let ``Security/VexJustificationType/vulnerableCodeCannotBeControlledByAdversary`` =
        Prefixed_Name(spdx, "Security/VexJustificationType/vulnerableCodeCannotBeControlledByAdversary") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VexJustificationType/vulnerableCodeNotInExecutePath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Security/VexJustificationType</para>
    ///   <para>The affected code is not reachable through the execution of the code, including non-anticipated states of the product.</para>
    /// labels<para>vulnerableCodeNotInExecutePath</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/vulnerableCodeNotInExecutePath">https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/vulnerableCodeNotInExecutePath</seealso>
    let ``Security/VexJustificationType/vulnerableCodeNotInExecutePath`` =
        Prefixed_Name(spdx, "Security/VexJustificationType/vulnerableCodeNotInExecutePath") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/VexJustificationType/vulnerableCodeNotPresent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:Security/VexJustificationType</para>
    ///   <para>The product is not affected because the code underlying the vulnerability is not present in the product.</para>
    /// labels<para>vulnerableCodeNotPresent</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/vulnerableCodeNotPresent">https://spdx.org/rdf/3.1/terms/Security/VexJustificationType/vulnerableCodeNotPresent</seealso>
    let ``Security/VexJustificationType/vulnerableCodeNotPresent`` =
        Prefixed_Name(spdx, "Security/VexJustificationType/vulnerableCodeNotPresent") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/impactStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Explains why a VEX product is not affected by a vulnerability. It is an
    /// alternative in VexNotAffectedVulnAssessmentRelationship to the machine-readable
    /// justification label.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/impactStatement">https://spdx.org/rdf/3.1/terms/Security/impactStatement</seealso>
    let ``Security/impactStatement`` =
        Prefixed_Name(spdx, "Security/impactStatement") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/justificationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Impact justification label to be used when linking a vulnerability to an element
    /// representing a VEX product with a VexNotAffectedVulnAssessmentRelationship
    /// relationship.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/justificationType">https://spdx.org/rdf/3.1/terms/Security/justificationType</seealso>
    let ``Security/justificationType`` =
        Prefixed_Name(spdx, "Security/justificationType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/impactStatementTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Timestamp of impact statement.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/impactStatementTime">https://spdx.org/rdf/3.1/terms/Security/impactStatementTime</seealso>
    let ``Security/impactStatementTime`` =
        Prefixed_Name(spdx, "Security/impactStatementTime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/statusNotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Conveys information about how VEX status was determined.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/statusNotes">https://spdx.org/rdf/3.1/terms/Security/statusNotes</seealso>
    let ``Security/statusNotes`` =
        Prefixed_Name(spdx, "Security/statusNotes") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/vexVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies the version of a VEX statement.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/vexVersion">https://spdx.org/rdf/3.1/terms/Security/vexVersion</seealso>
    let ``Security/vexVersion`` =
        Prefixed_Name(spdx, "Security/vexVersion") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/modifiedTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies a time when a vulnerability assessment was modified</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/modifiedTime">https://spdx.org/rdf/3.1/terms/Security/modifiedTime</seealso>
    let ``Security/modifiedTime`` =
        Prefixed_Name(spdx, "Security/modifiedTime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/publishedTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specifies the time when a vulnerability was published.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/publishedTime">https://spdx.org/rdf/3.1/terms/Security/publishedTime</seealso>
    let ``Security/publishedTime`` =
        Prefixed_Name(spdx, "Security/publishedTime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/withdrawnTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specified the time and date when a vulnerability was withdrawn.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/withdrawnTime">https://spdx.org/rdf/3.1/terms/Security/withdrawnTime</seealso>
    let ``Security/withdrawnTime`` =
        Prefixed_Name(spdx, "Security/withdrawnTime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Software/SoftwareArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>A distinct article or unit related to Software.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Software/SoftwareArtifact">https://spdx.org/rdf/3.1/terms/Software/SoftwareArtifact</seealso>
    let ``Software/SoftwareArtifact`` =
        Prefixed_Name(spdx, "Software/SoftwareArtifact") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Security/assessedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specifies an Element contained in a piece of software where a vulnerability was
    /// found.</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Security/assessedElement">https://spdx.org/rdf/3.1/terms/Security/assessedElement</seealso>
    let ``Security/assessedElement`` =
        Prefixed_Name(spdx, "Security/assessedElement") |> PrefixedName
