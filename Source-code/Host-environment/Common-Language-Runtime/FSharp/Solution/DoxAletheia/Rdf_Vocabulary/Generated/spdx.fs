namespace https.spdx.org.rdf._3._1.terms.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module spdx =
    let _namespace_iri = Namespace_Iri spdx |> NamespaceIRI
    /// <summary>
    ///   <para>spdx:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"System Package Data Exchange™ (SPDX®) Ontology"</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/">https://spdx.org/rdf/3.1/terms/</seealso>
    let _prefix_iri = Prefixed_Name(spdx, "") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Build/Build</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Class that describes a build instance of software/artifacts."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Build/Build">https://spdx.org/rdf/3.1/terms/Build/Build</seealso>
    let ``Build/Build`` = Prefixed_Name(spdx, "Build/Build") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Build/buildEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Property that describes the time at which a build stops."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Build/buildEndTime">https://spdx.org/rdf/3.1/terms/Build/buildEndTime</seealso>
    let ``Build/buildEndTime`` =
        Prefixed_Name(spdx, "Build/buildEndTime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Build/buildId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A buildId is a locally unique identifier used by a builder to identify a unique
    /// instance of a build produced by it."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Build/buildId">https://spdx.org/rdf/3.1/terms/Build/buildId</seealso>
    let ``Build/buildId`` = Prefixed_Name(spdx, "Build/buildId") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Build/buildStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Property describing the start time of a build."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Build/buildStartTime">https://spdx.org/rdf/3.1/terms/Build/buildStartTime</seealso>
    let ``Build/buildStartTime`` =
        Prefixed_Name(spdx, "Build/buildStartTime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Build/buildType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A buildType is a hint that is used to indicate the toolchain, platform, or
    /// infrastructure that the build was invoked on."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Build/buildType">https://spdx.org/rdf/3.1/terms/Build/buildType</seealso>
    let ``Build/buildType`` = Prefixed_Name(spdx, "Build/buildType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Build/configSourceDigest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property that describes the digest of the build configuration file used to
    /// invoke a build."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Build/configSourceDigest">https://spdx.org/rdf/3.1/terms/Build/configSourceDigest</seealso>
    let ``Build/configSourceDigest`` =
        Prefixed_Name(spdx, "Build/configSourceDigest") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Build/configSourceEntrypoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Property describes the invocation entrypoint of a build."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Build/configSourceEntrypoint">https://spdx.org/rdf/3.1/terms/Build/configSourceEntrypoint</seealso>
    let ``Build/configSourceEntrypoint`` =
        Prefixed_Name(spdx, "Build/configSourceEntrypoint") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Build/configSourceUri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Property that describes the URI of the build configuration source file."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Build/configSourceUri">https://spdx.org/rdf/3.1/terms/Build/configSourceUri</seealso>
    let ``Build/configSourceUri`` =
        Prefixed_Name(spdx, "Build/configSourceUri") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Build/environment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property describing the session in which a build is invoked."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Build/environment">https://spdx.org/rdf/3.1/terms/Build/environment</seealso>
    let ``Build/environment`` = Prefixed_Name(spdx, "Build/environment") |> PrefixedName
    /// <summary>
    ///   <para>spdx:Build/parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property describing a parameter used in an instance of a build."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Build/parameter">https://spdx.org/rdf/3.1/terms/Build/parameter</seealso>
    let ``Build/parameter`` = Prefixed_Name(spdx, "Build/parameter") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Extension/CdxPropertiesExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"A type of extension consisting of a list of name value pairs."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Extension/CdxPropertiesExtension">https://spdx.org/rdf/3.1/terms/Extension/CdxPropertiesExtension</seealso>
    let ``Extension/CdxPropertiesExtension`` =
        Prefixed_Name(spdx, "Extension/CdxPropertiesExtension") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Extension/CdxPropertyEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"A property name with an associated value."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Extension/CdxPropertyEntry">https://spdx.org/rdf/3.1/terms/Extension/CdxPropertyEntry</seealso>
    let ``Extension/CdxPropertyEntry`` =
        Prefixed_Name(spdx, "Extension/CdxPropertyEntry") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Extension/Extension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A characterization of some aspect of an Element that is associated with the Element in a generalized fashion."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Extension/Extension">https://spdx.org/rdf/3.1/terms/Extension/Extension</seealso>
    let ``Extension/Extension`` =
        Prefixed_Name(spdx, "Extension/Extension") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Extension/cdxPropName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A name used in a CdxPropertyEntry name-value pair."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Extension/cdxPropName">https://spdx.org/rdf/3.1/terms/Extension/cdxPropName</seealso>
    let ``Extension/cdxPropName`` =
        Prefixed_Name(spdx, "Extension/cdxPropName") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Extension/cdxPropValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A value used in a CdxPropertyEntry name-value pair."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Extension/cdxPropValue">https://spdx.org/rdf/3.1/terms/Extension/cdxPropValue</seealso>
    let ``Extension/cdxPropValue`` =
        Prefixed_Name(spdx, "Extension/cdxPropValue") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Extension/cdxProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Provides a map of a property name to a value."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Extension/cdxProperty">https://spdx.org/rdf/3.1/terms/Extension/cdxProperty</seealso>
    let ``Extension/cdxProperty`` =
        Prefixed_Name(spdx, "Extension/cdxProperty") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvaluationResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"EvaluationResult is the result of an evaluation."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResult">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResult</seealso>
    let ``FunctionalSafety/EvaluationResult`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvaluationResult") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvaluationResultType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EvaluationResultType describes the outcome of an evaluation or verification process with."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType</seealso>
    let ``FunctionalSafety/EvaluationResultType`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvaluationResultType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvaluationResultType/fail</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:FunctionalSafety/EvaluationResultType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Indicates a failed evaluation where the requirement or condition is not met."</para>
    /// labels<para>"fail"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType/fail">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType/fail</seealso>
    let ``FunctionalSafety/EvaluationResultType/fail`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvaluationResultType/fail") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvaluationResultType/inconclusive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:FunctionalSafety/EvaluationResultType</para>
    ///   <para>"Inconclusive refers to a result or outcome from a verification, test, or analysis that cannot be clearly classified as either positive (successful, pass) or negative (failed, reject). An inconclusive result means there was not enough clear evidence, data, or signal to make a definitive determination, and further investigation or additional testing is necessary. An inconclusive result always shall need a comment on it."</para>
    /// labels<para>"inconclusive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType/inconclusive">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType/inconclusive</seealso>
    let ``FunctionalSafety/EvaluationResultType/inconclusive`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvaluationResultType/inconclusive") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvaluationResultType/pass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:FunctionalSafety/EvaluationResultType</para>
    ///   <para>"Indicates a successful evaluation where the requirement or condition is clearly met."</para>
    /// labels<para>"pass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType/pass">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvaluationResultType/pass</seealso>
    let ``FunctionalSafety/EvaluationResultType/pass`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvaluationResultType/pass") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvidenceRelationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"EvidenceRelationship defines the association between pieces of evidence and EvaluationResult."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceRelationship">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceRelationship</seealso>
    let ``FunctionalSafety/EvidenceRelationship`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvidenceRelationship") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvidenceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"EvidenceType refers to categories of documented or observable proof used to verify compliance, qualification, or performance"</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType</seealso>
    let ``FunctionalSafety/EvidenceType`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvidenceType") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvidenceType/log</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:FunctionalSafety/EvidenceType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Time-stamped records capturing system or operational data recorded as usually as a response to specific triggers in a specified environment."</para>
    /// labels<para>"log"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/log">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/log</seealso>
    let ``FunctionalSafety/EvidenceType/log`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvidenceType/log") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvidenceType/observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:FunctionalSafety/EvidenceType</para>
    ///   <para>"Documentation of direct monitoring or witnessing of the demonstration of processes, tests, or any kind of system responses during a specified timeframe under specified environmental conditions."</para>
    /// labels<para>"observation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/observation">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/observation</seealso>
    let ``FunctionalSafety/EvidenceType/observation`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvidenceType/observation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvidenceType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:FunctionalSafety/EvidenceType</para>
    ///   <para>"Any other relevant type of proof or documentation not covered above."</para>
    /// labels<para>"other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/other">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/other</seealso>
    let ``FunctionalSafety/EvidenceType/other`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvidenceType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvidenceType/recording</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:FunctionalSafety/EvidenceType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Captured datastream like audio, video, or any other kind of continuous electronic capture of events, behavior or conditions."</para>
    /// labels<para>"recording"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/recording">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/recording</seealso>
    let ``FunctionalSafety/EvidenceType/recording`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvidenceType/recording") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/EvidenceType/report</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:FunctionalSafety/EvidenceType</para>
    ///   <para>"Structured documentation of test results, inspections, or analyses."</para>
    /// labels<para>"report"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/report">https://spdx.org/rdf/3.1/terms/FunctionalSafety/EvidenceType/report</seealso>
    let ``FunctionalSafety/EvidenceType/report`` =
        Prefixed_Name(spdx, "FunctionalSafety/EvidenceType/report") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/RequirementVerification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"RequirementVerification class defines the base properties of a verification."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/RequirementVerification">https://spdx.org/rdf/3.1/terms/FunctionalSafety/RequirementVerification</seealso>
    let ``FunctionalSafety/RequirementVerification`` =
        Prefixed_Name(spdx, "FunctionalSafety/RequirementVerification") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/VerificationType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Enumeration of verification types."</para>
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
    ///   <para>"Analytical evaluating of data, designs, or processes methodically to verify correctness against standards or expectations. Typical analysis methods are FMEA, FTA, STPA, static analysis for MISRA compliance etc."</para>
    /// labels<para>"analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/analysis">https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/analysis</seealso>
    let ``FunctionalSafety/VerificationType/analysis`` =
        Prefixed_Name(spdx, "FunctionalSafety/VerificationType/analysis") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/VerificationType/assessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:FunctionalSafety/VerificationType</para>
    ///   <para>"A systematic examination of a system, process, or outcome to evaluate compliance of specific work products with a specific expectation with a specification, regulation or standard. Often involves judgement and a rationale of this judgement."</para>
    /// labels<para>"assessment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/assessment">https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/assessment</seealso>
    let ``FunctionalSafety/VerificationType/assessment`` =
        Prefixed_Name(spdx, "FunctionalSafety/VerificationType/assessment") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/VerificationType/audit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:FunctionalSafety/VerificationType</para>
    ///   <para>"An examination typically focusing on compliance with policies, standards, or regulations. Usually this is done during an audit meeting, while the assessment also involves deep and detailed reviews of work products (e.g. requirements, verification specifications, reports etc.)"</para>
    /// labels<para>"audit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/audit">https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/audit</seealso>
    let ``FunctionalSafety/VerificationType/audit`` =
        Prefixed_Name(spdx, "FunctionalSafety/VerificationType/audit") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/VerificationType/demonstration</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:FunctionalSafety/VerificationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Demonstrating and monitoring or recording that the item under verification to confirm that a requirement is met by the item under verification."</para>
    /// labels<para>"demonstration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/demonstration">https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/demonstration</seealso>
    let ``FunctionalSafety/VerificationType/demonstration`` =
        Prefixed_Name(spdx, "FunctionalSafety/VerificationType/demonstration") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/VerificationType/inspection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:FunctionalSafety/VerificationType</para>
    ///   <para>"A thorough examination or checking of documentation, records, processes, or systems to confirm compliance or adherence. An inspection needs to have a defined set of acceptance criteria (e.g. a checklist), a documentation of roles involved in the inspection (e.g. to document the inspector's independence) and a clear documentation of when and how it was performed."</para>
    /// labels<para>"inspection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/inspection">https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/inspection</seealso>
    let ``FunctionalSafety/VerificationType/inspection`` =
        Prefixed_Name(spdx, "FunctionalSafety/VerificationType/inspection") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/VerificationType/other</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:FunctionalSafety/VerificationType</para>
    ///   <para>"Any other specialized or custom verification method that fits the context."</para>
    /// labels<para>"other"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/other">https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/other</seealso>
    let ``FunctionalSafety/VerificationType/other`` =
        Prefixed_Name(spdx, "FunctionalSafety/VerificationType/other") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/VerificationType/review</para>
    /// </summary>
    /// <remarks>
    ///   <para>spdx:FunctionalSafety/VerificationType</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A examination or checking of documentation, records, processes, or systems to confirm compliance or adherence with an upper level requirement. Typically done as peer review, offline review or review meeting."</para>
    /// labels<para>"review"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/review">https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/review</seealso>
    let ``FunctionalSafety/VerificationType/review`` =
        Prefixed_Name(spdx, "FunctionalSafety/VerificationType/review") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/VerificationType/test</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>spdx:FunctionalSafety/VerificationType</para>
    ///   <para>"Conducting controlled tests, experiments or simulations to verify that specific requirements regarding performance, functionality, robustness, etc. are met."</para>
    /// labels<para>"test"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/test">https://spdx.org/rdf/3.1/terms/FunctionalSafety/VerificationType/test</seealso>
    let ``FunctionalSafety/VerificationType/test`` =
        Prefixed_Name(spdx, "FunctionalSafety/VerificationType/test") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/evaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Evaluation is an outcome considering results of a verification."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/evaluation">https://spdx.org/rdf/3.1/terms/FunctionalSafety/evaluation</seealso>
    let ``FunctionalSafety/evaluation`` =
        Prefixed_Name(spdx, "FunctionalSafety/evaluation") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/evaluationBasedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the specific RequirementVerification instance on which the EvaluationResult is based."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/evaluationBasedOn">https://spdx.org/rdf/3.1/terms/FunctionalSafety/evaluationBasedOn</seealso>
    let ``FunctionalSafety/evaluationBasedOn`` =
        Prefixed_Name(spdx, "FunctionalSafety/evaluationBasedOn") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/evaluationRationale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Detailed explanation or reasoning that supports the EvaluationResult."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/evaluationRationale">https://spdx.org/rdf/3.1/terms/FunctionalSafety/evaluationRationale</seealso>
    let ``FunctionalSafety/evaluationRationale`` =
        Prefixed_Name(spdx, "FunctionalSafety/evaluationRationale") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/evidenceCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"evidenceCategory refers to a category of documented or observable proof."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/evidenceCategory">https://spdx.org/rdf/3.1/terms/FunctionalSafety/evidenceCategory</seealso>
    let ``FunctionalSafety/evidenceCategory`` =
        Prefixed_Name(spdx, "FunctionalSafety/evidenceCategory") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/evidenceUUID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A evidenceUUID is a universally unique identifier (UUID) assigned to an entity, item, or requirement."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/evidenceUUID">https://spdx.org/rdf/3.1/terms/FunctionalSafety/evidenceUUID</seealso>
    let ``FunctionalSafety/evidenceUUID`` =
        Prefixed_Name(spdx, "FunctionalSafety/evidenceUUID") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/verificationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"verificationMethod refers to the specific approach used for a checking an element's conformance with its requirements."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationMethod">https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationMethod</seealso>
    let ``FunctionalSafety/verificationMethod`` =
        Prefixed_Name(spdx, "FunctionalSafety/verificationMethod") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/verificationPostcondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Verification postcondition that are true immediately after a verification method has been performed"</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationPostcondition">https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationPostcondition</seealso>
    let ``FunctionalSafety/verificationPostcondition`` =
        Prefixed_Name(spdx, "FunctionalSafety/verificationPostcondition") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/verificationPrecondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Verification preconditions are initial criteria that are to be met prior to initiating the verification method."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationPrecondition">https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationPrecondition</seealso>
    let ``FunctionalSafety/verificationPrecondition`` =
        Prefixed_Name(spdx, "FunctionalSafety/verificationPrecondition") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/verificationRationale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A verificationRationale is supporting information that justifies the verification details."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationRationale">https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationRationale</seealso>
    let ``FunctionalSafety/verificationRationale`` =
        Prefixed_Name(spdx, "FunctionalSafety/verificationRationale") |> PrefixedName

    /// <summary>
    ///   <para>spdx:FunctionalSafety/verificationUUID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A verificationUUID is a universally unique identifier (UUID) assigned to a Verification item."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationUUID">https://spdx.org/rdf/3.1/terms/FunctionalSafety/verificationUUID</seealso>
    let ``FunctionalSafety/verificationUUID`` =
        Prefixed_Name(spdx, "FunctionalSafety/verificationUUID") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Licensing/NoAssertion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Licensing/NoAssertion">https://spdx.org/rdf/3.1/terms/Licensing/NoAssertion</seealso>
    let ``Licensing/NoAssertion`` =
        Prefixed_Name(spdx, "Licensing/NoAssertion") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Licensing/None</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Licensing/None">https://spdx.org/rdf/3.1/terms/Licensing/None</seealso>
    let ``Licensing/None`` = Prefixed_Name(spdx, "Licensing/None") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/ExportControlClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"Assement of an Element for export control classification."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/ExportControlClassification">https://spdx.org/rdf/3.1/terms/Operations/ExportControlClassification</seealso>
    let ``Operations/ExportControlClassification`` =
        Prefixed_Name(spdx, "Operations/ExportControlClassification") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/ExportControlClassificationAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"Assement of an Element for export control classification."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/ExportControlClassificationAssessment">https://spdx.org/rdf/3.1/terms/Operations/ExportControlClassificationAssessment</seealso>
    let ``Operations/ExportControlClassificationAssessment`` =
        Prefixed_Name(spdx, "Operations/ExportControlClassificationAssessment") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"Temporary endeavor with a beginning and an end and that must be used to create a unique product, service or result."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/Project">https://spdx.org/rdf/3.1/terms/Operations/Project</seealso>
    let ``Operations/Project`` =
        Prefixed_Name(spdx, "Operations/Project") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/assessedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies an Element as subject of an assessment."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/assessedElement">https://spdx.org/rdf/3.1/terms/Operations/assessedElement</seealso>
    let ``Operations/assessedElement`` =
        Prefixed_Name(spdx, "Operations/assessedElement") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/assessmentContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Sets the context for an assessment iby specifying the related project."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/assessmentContext">https://spdx.org/rdf/3.1/terms/Operations/assessmentContext</seealso>
    let ``Operations/assessmentContext`` =
        Prefixed_Name(spdx, "Operations/assessmentContext") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/assessmentResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies an Element as subject of an assessment."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/assessmentResult">https://spdx.org/rdf/3.1/terms/Operations/assessmentResult</seealso>
    let ``Operations/assessmentResult`` =
        Prefixed_Name(spdx, "Operations/assessmentResult") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/assessmentTimestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Timestamp, when an assessment was conducted."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/assessmentTimestamp">https://spdx.org/rdf/3.1/terms/Operations/assessmentTimestamp</seealso>
    let ``Operations/assessmentTimestamp`` =
        Prefixed_Name(spdx, "Operations/assessmentTimestamp") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/assessor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An entity providing an assessment."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/assessor">https://spdx.org/rdf/3.1/terms/Operations/assessor</seealso>
    let ``Operations/assessor`` =
        Prefixed_Name(spdx, "Operations/assessor") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/exportClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Expression for the export control classification."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/exportClassification">https://spdx.org/rdf/3.1/terms/Operations/exportClassification</seealso>
    let ``Operations/exportClassification`` =
        Prefixed_Name(spdx, "Operations/exportClassification") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/exportControlClassificationResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Provides the result of an export control assessment."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/exportControlClassificationResult">https://spdx.org/rdf/3.1/terms/Operations/exportControlClassificationResult</seealso>
    let ``Operations/exportControlClassificationResult`` =
        Prefixed_Name(spdx, "Operations/exportControlClassificationResult") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/exportControlSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specification basis for the export control classification."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/exportControlSpecification">https://spdx.org/rdf/3.1/terms/Operations/exportControlSpecification</seealso>
    let ``Operations/exportControlSpecification`` =
        Prefixed_Name(spdx, "Operations/exportControlSpecification") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/exportingCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Country for which export controls must be taken into account."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/exportingCountry">https://spdx.org/rdf/3.1/terms/Operations/exportingCountry</seealso>
    let ``Operations/exportingCountry`` =
        Prefixed_Name(spdx, "Operations/exportingCountry") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/projectContract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Link to the project contract."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/projectContract">https://spdx.org/rdf/3.1/terms/Operations/projectContract</seealso>
    let ``Operations/projectContract`` =
        Prefixed_Name(spdx, "Operations/projectContract") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/projectEndTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Time when the project ends or is planned to end."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/projectEndTime">https://spdx.org/rdf/3.1/terms/Operations/projectEndTime</seealso>
    let ``Operations/projectEndTime`` =
        Prefixed_Name(spdx, "Operations/projectEndTime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/projectOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Owner or Lead of the project."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/projectOwner">https://spdx.org/rdf/3.1/terms/Operations/projectOwner</seealso>
    let ``Operations/projectOwner`` =
        Prefixed_Name(spdx, "Operations/projectOwner") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/projectSponsor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Sponsor of the project."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/projectSponsor">https://spdx.org/rdf/3.1/terms/Operations/projectSponsor</seealso>
    let ``Operations/projectSponsor`` =
        Prefixed_Name(spdx, "Operations/projectSponsor") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/projectStartTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Time when the project starts or is planned to start."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/projectStartTime">https://spdx.org/rdf/3.1/terms/Operations/projectStartTime</seealso>
    let ``Operations/projectStartTime`` =
        Prefixed_Name(spdx, "Operations/projectStartTime") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/projectTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Title of the project."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/projectTitle">https://spdx.org/rdf/3.1/terms/Operations/projectTitle</seealso>
    let ``Operations/projectTitle`` =
        Prefixed_Name(spdx, "Operations/projectTitle") |> PrefixedName

    /// <summary>
    ///   <para>spdx:Operations/weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Weight to express relevance in de minimis consideration."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/Operations/weight">https://spdx.org/rdf/3.1/terms/Operations/weight</seealso>
    let ``Operations/weight`` = Prefixed_Name(spdx, "Operations/weight") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SimpleLicensing/AnyLicenseInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Abstract class representing a license combination consisting of one or more licenses."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/AnyLicenseInfo">https://spdx.org/rdf/3.1/terms/SimpleLicensing/AnyLicenseInfo</seealso>
    let ``SimpleLicensing/AnyLicenseInfo`` =
        Prefixed_Name(spdx, "SimpleLicensing/AnyLicenseInfo") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SimpleLicensing/LicenseExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>shacl:NodeShape</para>
    ///   <para>"An SPDX Element containing an SPDX license expression string."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/LicenseExpression">https://spdx.org/rdf/3.1/terms/SimpleLicensing/LicenseExpression</seealso>
    let ``SimpleLicensing/LicenseExpression`` =
        Prefixed_Name(spdx, "SimpleLicensing/LicenseExpression") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SimpleLicensing/SimpleLicensingText</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:NodeShape</para>
    ///   <para>owl:Class</para>
    ///   <para>"A license or addition that is not listed on the SPDX License List."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/SimpleLicensingText">https://spdx.org/rdf/3.1/terms/SimpleLicensing/SimpleLicensingText</seealso>
    let ``SimpleLicensing/SimpleLicensingText`` =
        Prefixed_Name(spdx, "SimpleLicensing/SimpleLicensingText") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SimpleLicensing/customIdToLicense</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Maps a "LicenseRef-" string for a custom license or a "AdditionRef-" string for
    /// a custom license addition to a `CustomLicense`, a `CustomLicenseAddition`, or a
    /// `SimpleLicensingText`."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/customIdToLicense">https://spdx.org/rdf/3.1/terms/SimpleLicensing/customIdToLicense</seealso>
    let ``SimpleLicensing/customIdToLicense`` =
        Prefixed_Name(spdx, "SimpleLicensing/customIdToLicense") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SimpleLicensing/customIdToUri</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"**DEPRECATED in SPDX 3.1.**
    /// Use [customIdToLicense](./customIdToLicense.md) instead.
    ///
    /// Maps a LicenseRef or AdditionRef string for a Custom License or a Custom
    /// License Addition to its URI ID.
    ///
    /// **NOTE:**
    /// This property is deprecated and only included for backward compatibility.
    /// New documents should use [customIdToLicense](./customIdToLicense.md) instead."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/customIdToUri">https://spdx.org/rdf/3.1/terms/SimpleLicensing/customIdToUri</seealso>
    let ``SimpleLicensing/customIdToUri`` =
        Prefixed_Name(spdx, "SimpleLicensing/customIdToUri") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SimpleLicensing/licenseExpression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A string in the license expression format."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/licenseExpression">https://spdx.org/rdf/3.1/terms/SimpleLicensing/licenseExpression</seealso>
    let ``SimpleLicensing/licenseExpression`` =
        Prefixed_Name(spdx, "SimpleLicensing/licenseExpression") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SimpleLicensing/licenseListVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The version of the SPDX License List used in the license expression."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/licenseListVersion">https://spdx.org/rdf/3.1/terms/SimpleLicensing/licenseListVersion</seealso>
    let ``SimpleLicensing/licenseListVersion`` =
        Prefixed_Name(spdx, "SimpleLicensing/licenseListVersion") |> PrefixedName

    /// <summary>
    ///   <para>spdx:SimpleLicensing/licenseText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifies the full text of a License or Addition."</para>
    /// </remarks>
    /// <seealso href="https://spdx.org/rdf/3.1/terms/SimpleLicensing/licenseText">https://spdx.org/rdf/3.1/terms/SimpleLicensing/licenseText</seealso>
    let ``SimpleLicensing/licenseText`` =
        Prefixed_Name(spdx, "SimpleLicensing/licenseText") |> PrefixedName
