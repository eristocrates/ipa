namespace https.w3id.org.squap.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module squap =
    let _namespace_iri = Namespace_Iri squap |> NamespaceIRI

    /// <summary>
    ///   <para>squap:ArchitecturalAlignment/ArchitectureDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///
    /// labels<para>Architecture description</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/ArchitectureDescription">https://w3id.org/squap/ArchitecturalAlignment/ArchitectureDescription</seealso>
    let ``ArchitecturalAlignment/ArchitectureDescription`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/ArchitectureDescription") |> PrefixedName

    /// <summary>
    ///   <para>squap:ArchitecturalAlignment/ArchitectureModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Architecture model</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/ArchitectureModel">https://w3id.org/squap/ArchitecturalAlignment/ArchitectureModel</seealso>
    let ``ArchitecturalAlignment/ArchitectureModel`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/ArchitectureModel") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQualityCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The concept of the sotftware quality characteristic</para>
    /// labels<para>Software quality characteristic</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQualityCharacteristic">https://w3id.org/squap/SoftwareQualityCharacteristic</seealso>
    let SoftwareQualityCharacteristic =
        Prefixed_Name(squap, "SoftwareQualityCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>squap:ArchitecturalAlignment/ObjectiveCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///
    /// labels<para>Objective characteristic</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/ObjectiveCharacteristic">https://w3id.org/squap/ArchitecturalAlignment/ObjectiveCharacteristic</seealso>
    let ``ArchitecturalAlignment/ObjectiveCharacteristic`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/ObjectiveCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQualityResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Software quality result</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQualityResult">https://w3id.org/squap/SoftwareQualityResult</seealso>
    let SoftwareQualityResult =
        Prefixed_Name(squap, "SoftwareQualityResult") |> PrefixedName

    /// <summary>
    ///   <para>squap:isClassifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is classified by</para></remarks>
    /// <seealso href="https://w3id.org/squap/isClassifiedBy">https://w3id.org/squap/isClassifiedBy</seealso>
    let isClassifiedBy = Prefixed_Name(squap, "isClassifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>squap:isAssessedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is assessed by</para></remarks>
    /// <seealso href="https://w3id.org/squap/isAssessedBy">https://w3id.org/squap/isAssessedBy</seealso>
    let isAssessedBy = Prefixed_Name(squap, "isAssessedBy") |> PrefixedName
    /// <summary>
    ///   <para>squap:classifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>classifies</para></remarks>
    /// <seealso href="https://w3id.org/squap/classifies">https://w3id.org/squap/classifies</seealso>
    let classifies = Prefixed_Name(squap, "classifies") |> PrefixedName
    /// <summary>
    ///   <para>squap:isValueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is value of</para></remarks>
    /// <seealso href="https://w3id.org/squap/isValueOf">https://w3id.org/squap/isValueOf</seealso>
    let isValueOf = Prefixed_Name(squap, "isValueOf") |> PrefixedName

    /// <summary>
    ///   <para>squap:ProcessMaturityResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Process maturity result</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturityResult">https://w3id.org/squap/ProcessMaturityResult</seealso>
    let ProcessMaturityResult =
        Prefixed_Name(squap, "ProcessMaturityResult") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/AccessibilityInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Accessibility in use</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/AccessibilityInUse">https://w3id.org/squap/SoftwareQuality/AccessibilityInUse</seealso>
    let ``SoftwareQuality/AccessibilityInUse`` =
        Prefixed_Name(squap, "SoftwareQuality/AccessibilityInUse") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Accuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Accuracy</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Accuracy">https://w3id.org/squap/SoftwareQuality/Accuracy</seealso>
    let ``SoftwareQuality/Accuracy`` =
        Prefixed_Name(squap, "SoftwareQuality/Accuracy") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Transferability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>Transferability</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Transferability">https://w3id.org/squap/SoftwareQuality/Transferability</seealso>
    let ``SoftwareQuality/Transferability`` =
        Prefixed_Name(squap, "SoftwareQuality/Transferability") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Compatibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Compatibility</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Compatibility">https://w3id.org/squap/SoftwareQuality/Compatibility</seealso>
    let ``SoftwareQuality/Compatibility`` =
        Prefixed_Name(squap, "SoftwareQuality/Compatibility") |> PrefixedName

    /// <summary>
    ///   <para>squap:0.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/squap/0.1">https://w3id.org/squap/0.1</seealso>
    let ``_0.1`` = Prefixed_Name(squap, "0.1") |> PrefixedName
    /// <summary>
    ///   <para>squap:SoftwareQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The software quality characteristic meant as softwarea quality.</para>
    /// labels<para>Software quality</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality">https://w3id.org/squap/SoftwareQuality</seealso>
    let SoftwareQuality = Prefixed_Name(squap, "SoftwareQuality") |> PrefixedName
    /// <summary>
    ///   <para>squap:specializes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>specializes</para></remarks>
    /// <seealso href="https://w3id.org/squap/specializes">https://w3id.org/squap/specializes</seealso>
    let specializes = Prefixed_Name(squap, "specializes") |> PrefixedName
    /// <summary>
    ///   <para>squap:ProcessMaturity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The software quality characteristic meant as process maturity.</para>
    /// labels<para>Process maturity</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity">https://w3id.org/squap/ProcessMaturity</seealso>
    let ProcessMaturity = Prefixed_Name(squap, "ProcessMaturity") |> PrefixedName

    /// <summary>
    ///   <para>squap:ArchitecturalAlignment/ArchitectureFramework</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Architecture framework</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/ArchitectureFramework">https://w3id.org/squap/ArchitecturalAlignment/ArchitectureFramework</seealso>
    let ``ArchitecturalAlignment/ArchitectureFramework`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/ArchitectureFramework") |> PrefixedName

    /// <summary>
    ///   <para>squap:ProcessMaturity/Acquisition</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Acquisition</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Acquisition">https://w3id.org/squap/ProcessMaturity/Acquisition</seealso>
    let ``ProcessMaturity/Acquisition`` =
        Prefixed_Name(squap, "ProcessMaturity/Acquisition") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/CustomSoftwareQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>The perceived quality of custom software applications is decreasing.</para>
    /// labels<para>Custom software quality</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/CustomSoftwareQuality">https://w3id.org/squap/Factor/CustomSoftwareQuality</seealso>
    let ``Factor/CustomSoftwareQuality`` =
        Prefixed_Name(squap, "Factor/CustomSoftwareQuality") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/FunctionalAppropriateness</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Functional appropriateness</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/FunctionalAppropriateness">https://w3id.org/squap/SoftwareQuality/FunctionalAppropriateness</seealso>
    let ``SoftwareQuality/FunctionalAppropriateness`` =
        Prefixed_Name(squap, "SoftwareQuality/FunctionalAppropriateness") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/DataAnalysisVsFunctionalAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Poor data analysis influences functional analysis and so, system integrity.</para>
    /// labels<para>Data analysis vs functional analysis</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/DataAnalysisVsFunctionalAnalysis">https://w3id.org/squap/Factor/DataAnalysisVsFunctionalAnalysis</seealso>
    let ``Factor/DataAnalysisVsFunctionalAnalysis`` =
        Prefixed_Name(squap, "Factor/DataAnalysisVsFunctionalAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>squap:ArchitecturalAlignment/SubjectiveCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Subjective characteristic</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/SubjectiveCharacteristic">https://w3id.org/squap/ArchitecturalAlignment/SubjectiveCharacteristic</seealso>
    let ``ArchitecturalAlignment/SubjectiveCharacteristic`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/SubjectiveCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>squap:ArchitecturalAlignment/ArchitectureRational</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Architecture rational</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/ArchitectureRational">https://w3id.org/squap/ArchitecturalAlignment/ArchitectureRational</seealso>
    let ``ArchitecturalAlignment/ArchitectureRational`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/ArchitectureRational") |> PrefixedName

    /// <summary>
    ///   <para>squap:ArchitecturalAlignment/ArchitectureView</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Architecture view</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/ArchitectureView">https://w3id.org/squap/ArchitecturalAlignment/ArchitectureView</seealso>
    let ``ArchitecturalAlignment/ArchitectureView`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/ArchitectureView") |> PrefixedName

    /// <summary>
    ///   <para>squap:ArchitecturalAlignment/ArchitectureViewpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///
    /// labels<para>Architecture viewpoint</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/ArchitectureViewpoint">https://w3id.org/squap/ArchitecturalAlignment/ArchitectureViewpoint</seealso>
    let ``ArchitecturalAlignment/ArchitectureViewpoint`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/ArchitectureViewpoint") |> PrefixedName

    /// <summary>
    ///   <para>squap:ArchitecturalAlignment/Concern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///
    /// labels<para>Concern</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/Concern">https://w3id.org/squap/ArchitecturalAlignment/Concern</seealso>
    let ``ArchitecturalAlignment/Concern`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/Concern") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/PackagesDocumentationVsSystemAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>The lack of documentation in packages impacts directly on the logical data model and quality controls.</para>
    /// labels<para>Packages documentation vs system analysis</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/PackagesDocumentationVsSystemAnalysis">https://w3id.org/squap/Factor/PackagesDocumentationVsSystemAnalysis</seealso>
    let ``Factor/PackagesDocumentationVsSystemAnalysis`` =
        Prefixed_Name(squap, "Factor/PackagesDocumentationVsSystemAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/QualityVsRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Poorly defined requirements lead to misunderstandings with software developers, which will deliver lower quality software. The functional quality will be low if the requirements' clarity is low.</para>
    /// labels<para>Quality vs requirements</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/QualityVsRequirements">https://w3id.org/squap/Factor/QualityVsRequirements</seealso>
    let ``Factor/QualityVsRequirements`` =
        Prefixed_Name(squap, "Factor/QualityVsRequirements") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/TimeBehaviour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>Time behaviour</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/TimeBehaviour">https://w3id.org/squap/SoftwareQuality/TimeBehaviour</seealso>
    let ``SoftwareQuality/TimeBehaviour`` =
        Prefixed_Name(squap, "SoftwareQuality/TimeBehaviour") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/ResourceUtilization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Resource utilization</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/ResourceUtilization">https://w3id.org/squap/SoftwareQuality/ResourceUtilization</seealso>
    let ``SoftwareQuality/ResourceUtilization`` =
        Prefixed_Name(squap, "SoftwareQuality/ResourceUtilization") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/RequirementsVsMethodologies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>Poor methodologies to elicit business goals and needs lead to the definition of unclear software requirements.</para>
    /// labels<para>Requirements vs methodologies</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/RequirementsVsMethodologies">https://w3id.org/squap/Factor/RequirementsVsMethodologies</seealso>
    let ``Factor/RequirementsVsMethodologies`` =
        Prefixed_Name(squap, "Factor/RequirementsVsMethodologies") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/RequirementsVsTechnicalJargon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>The (mis-)use of technical jargon of different departments for requirement elicitation leads to low software quality.</para>
    /// labels<para>Requirements vs technical jargon</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/RequirementsVsTechnicalJargon">https://w3id.org/squap/Factor/RequirementsVsTechnicalJargon</seealso>
    let ``Factor/RequirementsVsTechnicalJargon`` =
        Prefixed_Name(squap, "Factor/RequirementsVsTechnicalJargon") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/FaultTolerance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Fault tolerance</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/FaultTolerance">https://w3id.org/squap/SoftwareQuality/FaultTolerance</seealso>
    let ``SoftwareQuality/FaultTolerance`` =
        Prefixed_Name(squap, "SoftwareQuality/FaultTolerance") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/WebTechnologiesVsMethodologies</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>There is the idea that the adoption of such technologies lead to less rigorous approach to software engineering. In this regard, Agile is considered a scapegoat of such sloppiness.</para>
    /// labels<para>Web technologies vs methodologies</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/WebTechnologiesVsMethodologies">https://w3id.org/squap/Factor/WebTechnologiesVsMethodologies</seealso>
    let ``Factor/WebTechnologiesVsMethodologies`` =
        Prefixed_Name(squap, "Factor/WebTechnologiesVsMethodologies") |> PrefixedName

    /// <summary>
    ///   <para>squap:FactorOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Factor occurrence</para></remarks>
    /// <seealso href="https://w3id.org/squap/FactorOccurrence">https://w3id.org/squap/FactorOccurrence</seealso>
    let FactorOccurrence = Prefixed_Name(squap, "FactorOccurrence") |> PrefixedName
    /// <summary>
    ///   <para>squap:satisfiesFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>satisfies factor</para></remarks>
    /// <seealso href="https://w3id.org/squap/satisfiesFactor">https://w3id.org/squap/satisfiesFactor</seealso>
    let satisfiesFactor = Prefixed_Name(squap, "satisfiesFactor") |> PrefixedName
    /// <summary>
    ///   <para>squap:hasMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has metric</para></remarks>
    /// <seealso href="https://w3id.org/squap/hasMetric">https://w3id.org/squap/hasMetric</seealso>
    let hasMetric = Prefixed_Name(squap, "hasMetric") |> PrefixedName
    /// <summary>
    ///   <para>squap:Parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Concept that classifies something having a certain value, e.g. 'High' can be said of people taller than 185 cm.
    /// However, in order to formally represent this constraint, we need to add an anonymous type to a parameter instance, using a property that convey the semantics of the parameter, e.g.:
    /// High rdf:type Person and (some hasHeight (Height and (oneOf isTallerThan 185) and (oneOf hasUnitOfMeasure centimeter)))</para>
    /// labels<para>Parameter</para></remarks>
    /// <seealso href="https://w3id.org/squap/Parameter">https://w3id.org/squap/Parameter</seealso>
    let Parameter = Prefixed_Name(squap, "Parameter") |> PrefixedName

    /// <summary>
    ///   <para>squap:ProcessMaturity/Supporting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Supporting</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Supporting">https://w3id.org/squap/ProcessMaturity/Supporting</seealso>
    let ``ProcessMaturity/Supporting`` =
        Prefixed_Name(squap, "ProcessMaturity/Supporting") |> PrefixedName

    /// <summary>
    ///   <para>squap:ProcessMaturity/Organisational</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Organisational</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Organisational">https://w3id.org/squap/ProcessMaturity/Organisational</seealso>
    let ``ProcessMaturity/Organisational`` =
        Prefixed_Name(squap, "ProcessMaturity/Organisational") |> PrefixedName

    /// <summary>
    ///   <para>squap:ProcessMaturity/JointReview</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///
    /// labels<para>Joint review</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/JointReview">https://w3id.org/squap/ProcessMaturity/JointReview</seealso>
    let ``ProcessMaturity/JointReview`` =
        Prefixed_Name(squap, "ProcessMaturity/JointReview") |> PrefixedName

    /// <summary>
    ///   <para>squap:ProcessMaturity/Operation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///
    /// labels<para>Operation</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Operation">https://w3id.org/squap/ProcessMaturity/Operation</seealso>
    let ``ProcessMaturity/Operation`` =
        Prefixed_Name(squap, "ProcessMaturity/Operation") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/Non-ItalianApplicationsVsQualityAndMaintainability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Non-Italian applications are more maintainable but have less functionalities.</para>
    /// labels<para>Non-Italian applications vs quality and maintainability</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/Non-ItalianApplicationsVsQualityAndMaintainability">https://w3id.org/squap/Factor/Non-ItalianApplicationsVsQualityAndMaintainability</seealso>
    let ``Factor/Non_ItalianApplicationsVsQualityAndMaintainability`` =
        Prefixed_Name(squap, "Factor/Non-ItalianApplicationsVsQualityAndMaintainability") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/PackagesVsDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The lack of documentation for software packages is perceived as a commercial strategy of suppliers to lock-in customers.</para>
    /// labels<para>Packages vs documentation</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/PackagesVsDocumentation">https://w3id.org/squap/Factor/PackagesVsDocumentation</seealso>
    let ``Factor/PackagesVsDocumentation`` =
        Prefixed_Name(squap, "Factor/PackagesVsDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/QualityVsSystemAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>Even though the design phase is perceived as the most important up-front activity, it is poorly implemented.</para>
    /// labels<para>Quality vs system analysis</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/QualityVsSystemAnalysis">https://w3id.org/squap/Factor/QualityVsSystemAnalysis</seealso>
    let ``Factor/QualityVsSystemAnalysis`` =
        Prefixed_Name(squap, "Factor/QualityVsSystemAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/QualityVsTimeAndBudget</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>The whole panel agreed unanimously that there is a direct relationship among quality and time and budget.</para>
    /// labels<para>Quality vs time and budget</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/QualityVsTimeAndBudget">https://w3id.org/squap/Factor/QualityVsTimeAndBudget</seealso>
    let ``Factor/QualityVsTimeAndBudget`` =
        Prefixed_Name(squap, "Factor/QualityVsTimeAndBudget") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Interoperability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>Interoperability</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Interoperability">https://w3id.org/squap/SoftwareQuality/Interoperability</seealso>
    let ``SoftwareQuality/Interoperability`` =
        Prefixed_Name(squap, "SoftwareQuality/Interoperability") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Co-existence</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Co-existence</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Co-existence">https://w3id.org/squap/SoftwareQuality/Co-existence</seealso>
    let ``SoftwareQuality/Co_existence`` =
        Prefixed_Name(squap, "SoftwareQuality/Co-existence") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/SystemAnalysisVsDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Inadequate documentation impacts on the system analysis and so on software quality.</para>
    /// labels<para>System analysis vs documentation</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/SystemAnalysisVsDocumentation">https://w3id.org/squap/Factor/SystemAnalysisVsDocumentation</seealso>
    let ``Factor/SystemAnalysisVsDocumentation`` =
        Prefixed_Name(squap, "Factor/SystemAnalysisVsDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>squap:isAffectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is affected by</para></remarks>
    /// <seealso href="https://w3id.org/squap/isAffectedBy">https://w3id.org/squap/isAffectedBy</seealso>
    let isAffectedBy = Prefixed_Name(squap, "isAffectedBy") |> PrefixedName

    /// <summary>
    ///   <para>squap:ArchitecturalAlignment/Environment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///
    /// labels<para>Environment</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/Environment">https://w3id.org/squap/ArchitecturalAlignment/Environment</seealso>
    let ``ArchitecturalAlignment/Environment`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/Environment") |> PrefixedName

    /// <summary>
    ///   <para>squap:ArchitecturalAlignment/Stakeholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Stakeholder</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/Stakeholder">https://w3id.org/squap/ArchitecturalAlignment/Stakeholder</seealso>
    let ``ArchitecturalAlignment/Stakeholder`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/Stakeholder") |> PrefixedName

    /// <summary>
    ///   <para>squap:MeasurementResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measurement result.</para>
    /// labels<para>Measurement result</para></remarks>
    /// <seealso href="https://w3id.org/squap/MeasurementResult">https://w3id.org/squap/MeasurementResult</seealso>
    let MeasurementResult = Prefixed_Name(squap, "MeasurementResult") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Security</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Security</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Security">https://w3id.org/squap/SoftwareQuality/Security</seealso>
    let ``SoftwareQuality/Security`` =
        Prefixed_Name(squap, "SoftwareQuality/Security") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/AppropriatenessRecognisability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>Appropriateness recognisability</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/AppropriatenessRecognisability">https://w3id.org/squap/SoftwareQuality/AppropriatenessRecognisability</seealso>
    let ``SoftwareQuality/AppropriatenessRecognisability`` =
        Prefixed_Name(squap, "SoftwareQuality/AppropriatenessRecognisability") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Attractiveness</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Attractiveness</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Attractiveness">https://w3id.org/squap/SoftwareQuality/Attractiveness</seealso>
    let ``SoftwareQuality/Attractiveness`` =
        Prefixed_Name(squap, "SoftwareQuality/Attractiveness") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Availability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Availability</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Availability">https://w3id.org/squap/SoftwareQuality/Availability</seealso>
    let ``SoftwareQuality/Availability`` =
        Prefixed_Name(squap, "SoftwareQuality/Availability") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Reliability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>Reliability</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Reliability">https://w3id.org/squap/SoftwareQuality/Reliability</seealso>
    let ``SoftwareQuality/Reliability`` =
        Prefixed_Name(squap, "SoftwareQuality/Reliability") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Changeability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>Changeability</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Changeability">https://w3id.org/squap/SoftwareQuality/Changeability</seealso>
    let ``SoftwareQuality/Changeability`` =
        Prefixed_Name(squap, "SoftwareQuality/Changeability") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/SatisfactionInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Satisfaction in use</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/SatisfactionInUse">https://w3id.org/squap/SoftwareQuality/SatisfactionInUse</seealso>
    let ``SoftwareQuality/SatisfactionInUse`` =
        Prefixed_Name(squap, "SoftwareQuality/SatisfactionInUse") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Safety</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Safety</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Safety">https://w3id.org/squap/SoftwareQuality/Safety</seealso>
    let ``SoftwareQuality/Safety`` =
        Prefixed_Name(squap, "SoftwareQuality/Safety") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/CompatibilityCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Compatibility compliance</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/CompatibilityCompliance">https://w3id.org/squap/SoftwareQuality/CompatibilityCompliance</seealso>
    let ``SoftwareQuality/CompatibilityCompliance`` =
        Prefixed_Name(squap, "SoftwareQuality/CompatibilityCompliance") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/ContextConformityInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>Context conformity in use</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/ContextConformityInUse">https://w3id.org/squap/SoftwareQuality/ContextConformityInUse</seealso>
    let ``SoftwareQuality/ContextConformityInUse`` =
        Prefixed_Name(squap, "SoftwareQuality/ContextConformityInUse") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/ContextExtendibilityInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Context extendibility in use</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/ContextExtendibilityInUse">https://w3id.org/squap/SoftwareQuality/ContextExtendibilityInUse</seealso>
    let ``SoftwareQuality/ContextExtendibilityInUse`` =
        Prefixed_Name(squap, "SoftwareQuality/ContextExtendibilityInUse") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/EaseOfUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ease of use</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/EaseOfUse">https://w3id.org/squap/SoftwareQuality/EaseOfUse</seealso>
    let ``SoftwareQuality/EaseOfUse`` =
        Prefixed_Name(squap, "SoftwareQuality/EaseOfUse") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/EffectivenessInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>Effectiveness in use</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/EffectivenessInUse">https://w3id.org/squap/SoftwareQuality/EffectivenessInUse</seealso>
    let ``SoftwareQuality/EffectivenessInUse`` =
        Prefixed_Name(squap, "SoftwareQuality/EffectivenessInUse") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/QualityInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>Quality in use</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/QualityInUse">https://w3id.org/squap/SoftwareQuality/QualityInUse</seealso>
    let ``SoftwareQuality/QualityInUse`` =
        Prefixed_Name(squap, "SoftwareQuality/QualityInUse") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Helpfulness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Helpfulness</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Helpfulness">https://w3id.org/squap/SoftwareQuality/Helpfulness</seealso>
    let ``SoftwareQuality/Helpfulness`` =
        Prefixed_Name(squap, "SoftwareQuality/Helpfulness") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Likability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Likability</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Likability">https://w3id.org/squap/SoftwareQuality/Likability</seealso>
    let ``SoftwareQuality/Likability`` =
        Prefixed_Name(squap, "SoftwareQuality/Likability") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Maintainability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Maintainability</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Maintainability">https://w3id.org/squap/SoftwareQuality/Maintainability</seealso>
    let ``SoftwareQuality/Maintainability`` =
        Prefixed_Name(squap, "SoftwareQuality/Maintainability") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/ModificationStability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>Modification stability</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/ModificationStability">https://w3id.org/squap/SoftwareQuality/ModificationStability</seealso>
    let ``SoftwareQuality/ModificationStability`` =
        Prefixed_Name(squap, "SoftwareQuality/ModificationStability") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/OperatorHealthAndSafety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>Operator health and safety</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/OperatorHealthAndSafety">https://w3id.org/squap/SoftwareQuality/OperatorHealthAndSafety</seealso>
    let ``SoftwareQuality/OperatorHealthAndSafety`` =
        Prefixed_Name(squap, "SoftwareQuality/OperatorHealthAndSafety") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/PerformanceEfficiency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>Performance efficiency</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/PerformanceEfficiency">https://w3id.org/squap/SoftwareQuality/PerformanceEfficiency</seealso>
    let ``SoftwareQuality/PerformanceEfficiency`` =
        Prefixed_Name(squap, "SoftwareQuality/PerformanceEfficiency") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Pleasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Pleasure</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Pleasure">https://w3id.org/squap/SoftwareQuality/Pleasure</seealso>
    let ``SoftwareQuality/Pleasure`` =
        Prefixed_Name(squap, "SoftwareQuality/Pleasure") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Portability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Portability</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Portability">https://w3id.org/squap/SoftwareQuality/Portability</seealso>
    let ``SoftwareQuality/Portability`` =
        Prefixed_Name(squap, "SoftwareQuality/Portability") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/PublicHealthAndSafety</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Public health and safety</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/PublicHealthAndSafety">https://w3id.org/squap/SoftwareQuality/PublicHealthAndSafety</seealso>
    let ``SoftwareQuality/PublicHealthAndSafety`` =
        Prefixed_Name(squap, "SoftwareQuality/PublicHealthAndSafety") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/ReliabilityCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Reliability compliance</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/ReliabilityCompliance">https://w3id.org/squap/SoftwareQuality/ReliabilityCompliance</seealso>
    let ``SoftwareQuality/ReliabilityCompliance`` =
        Prefixed_Name(squap, "SoftwareQuality/ReliabilityCompliance") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/SafetyCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Safety compliance</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/SafetyCompliance">https://w3id.org/squap/SoftwareQuality/SafetyCompliance</seealso>
    let ``SoftwareQuality/SafetyCompliance`` =
        Prefixed_Name(squap, "SoftwareQuality/SafetyCompliance") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/SecurityCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Security compliance</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/SecurityCompliance">https://w3id.org/squap/SoftwareQuality/SecurityCompliance</seealso>
    let ``SoftwareQuality/SecurityCompliance`` =
        Prefixed_Name(squap, "SoftwareQuality/SecurityCompliance") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/TechnicalAccessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Technical accessibility</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/TechnicalAccessibility">https://w3id.org/squap/SoftwareQuality/TechnicalAccessibility</seealso>
    let ``SoftwareQuality/TechnicalAccessibility`` =
        Prefixed_Name(squap, "SoftwareQuality/TechnicalAccessibility") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/TransferabilityCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>Transferability compliance</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/TransferabilityCompliance">https://w3id.org/squap/SoftwareQuality/TransferabilityCompliance</seealso>
    let ``SoftwareQuality/TransferabilityCompliance`` =
        Prefixed_Name(squap, "SoftwareQuality/TransferabilityCompliance") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Trust</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Trust</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Trust">https://w3id.org/squap/SoftwareQuality/Trust</seealso>
    let ``SoftwareQuality/Trust`` =
        Prefixed_Name(squap, "SoftwareQuality/Trust") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/UsabilityInUseCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Usability in use compliance</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/UsabilityInUseCompliance">https://w3id.org/squap/SoftwareQuality/UsabilityInUseCompliance</seealso>
    let ``SoftwareQuality/UsabilityInUseCompliance`` =
        Prefixed_Name(squap, "SoftwareQuality/UsabilityInUseCompliance") |> PrefixedName

    /// <summary>
    ///   <para>squap:usesQualityCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uses quality characteristic</para></remarks>
    /// <seealso href="https://w3id.org/squap/usesQualityCharacteristic">https://w3id.org/squap/usesQualityCharacteristic</seealso>
    let usesQualityCharacteristic =
        Prefixed_Name(squap, "usesQualityCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>squap:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>value</para></remarks>
    /// <seealso href="https://w3id.org/squap/value">https://w3id.org/squap/value</seealso>
    let value = Prefixed_Name(squap, "value") |> PrefixedName

    /// <summary>
    ///   <para>squap:affectsMeasurementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>affects measurement of</para></remarks>
    /// <seealso href="https://w3id.org/squap/affectsMeasurementOf">https://w3id.org/squap/affectsMeasurementOf</seealso>
    let affectsMeasurementOf =
        Prefixed_Name(squap, "affectsMeasurementOf") |> PrefixedName

    /// <summary>
    ///   <para>squap:isMetricOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is metric of</para></remarks>
    /// <seealso href="https://w3id.org/squap/isMetricOf">https://w3id.org/squap/isMetricOf</seealso>
    let isMetricOf = Prefixed_Name(squap, "isMetricOf") |> PrefixedName
    /// <summary>
    ///   <para>squap:hasParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between a metric and a parameter.</para>
    /// labels<para>has parameter</para></remarks>
    /// <seealso href="https://w3id.org/squap/hasParameter">https://w3id.org/squap/hasParameter</seealso>
    let hasParameter = Prefixed_Name(squap, "hasParameter") |> PrefixedName
    /// <summary>
    ///   <para>squap:isParameterOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between a parameter and a metric.</para>
    /// labels<para>is parameter of</para></remarks>
    /// <seealso href="https://w3id.org/squap/isParameterOf">https://w3id.org/squap/isParameterOf</seealso>
    let isParameterOf = Prefixed_Name(squap, "isParameterOf") |> PrefixedName
    /// <summary>
    ///   <para>squap:isConceptUsedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is concept used in</para></remarks>
    /// <seealso href="https://w3id.org/squap/isConceptUsedIn">https://w3id.org/squap/isConceptUsedIn</seealso>
    let isConceptUsedIn = Prefixed_Name(squap, "isConceptUsedIn") |> PrefixedName

    /// <summary>
    ///   <para>squap:isFactorSatisfiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is factor satisfied by</para></remarks>
    /// <seealso href="https://w3id.org/squap/isFactorSatisfiedBy">https://w3id.org/squap/isFactorSatisfiedBy</seealso>
    let isFactorSatisfiedBy =
        Prefixed_Name(squap, "isFactorSatisfiedBy") |> PrefixedName

    /// <summary>
    ///   <para>squap:isSatisfiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is satisfied by</para></remarks>
    /// <seealso href="https://w3id.org/squap/isSatisfiedBy">https://w3id.org/squap/isSatisfiedBy</seealso>
    let isSatisfiedBy = Prefixed_Name(squap, "isSatisfiedBy") |> PrefixedName
    /// <summary>
    ///   <para>squap:isParametrizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is parametrized by</para></remarks>
    /// <seealso href="https://w3id.org/squap/isParametrizedBy">https://w3id.org/squap/isParametrizedBy</seealso>
    let isParametrizedBy = Prefixed_Name(squap, "isParametrizedBy") |> PrefixedName

    /// <summary>
    ///   <para>squap:isQualityCharacteristicUsedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is quality characteristic used in</para></remarks>
    /// <seealso href="https://w3id.org/squap/isQualityCharacteristicUsedIn">https://w3id.org/squap/isQualityCharacteristicUsedIn</seealso>
    let isQualityCharacteristicUsedIn =
        Prefixed_Name(squap, "isQualityCharacteristicUsedIn") |> PrefixedName

    /// <summary>
    ///   <para>squap:satisfies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>satisfies</para></remarks>
    /// <seealso href="https://w3id.org/squap/satisfies">https://w3id.org/squap/satisfies</seealso>
    let satisfies = Prefixed_Name(squap, "satisfies") |> PrefixedName
    /// <summary>
    ///   <para>squap:isSpecializedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>is specialized by</para></remarks>
    /// <seealso href="https://w3id.org/squap/isSpecializedBy">https://w3id.org/squap/isSpecializedBy</seealso>
    let isSpecializedBy = Prefixed_Name(squap, "isSpecializedBy") |> PrefixedName
    /// <summary>
    ///   <para>squap:parametrizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>parametrizes</para></remarks>
    /// <seealso href="https://w3id.org/squap/parametrizes">https://w3id.org/squap/parametrizes</seealso>
    let parametrizes = Prefixed_Name(squap, "parametrizes") |> PrefixedName

    /// <summary>
    ///   <para>squap:ArchitecturalAlignment/Correspondence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///
    /// labels<para>Correspondence</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/Correspondence">https://w3id.org/squap/ArchitecturalAlignment/Correspondence</seealso>
    let ``ArchitecturalAlignment/Correspondence`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/Correspondence") |> PrefixedName

    /// <summary>
    ///   <para>squap:ArchitecturalAlignment/CorrespondenceRules</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Correspondence rules</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/CorrespondenceRules">https://w3id.org/squap/ArchitecturalAlignment/CorrespondenceRules</seealso>
    let ``ArchitecturalAlignment/CorrespondenceRules`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/CorrespondenceRules") |> PrefixedName

    /// <summary>
    ///   <para>squap:assesses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>assesses</para></remarks>
    /// <seealso href="https://w3id.org/squap/assesses">https://w3id.org/squap/assesses</seealso>
    let assesses = Prefixed_Name(squap, "assesses") |> PrefixedName
    /// <summary>
    ///   <para>squap:Metric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A metric, e.g. precision.</para>
    /// labels<para>Metric</para></remarks>
    /// <seealso href="https://w3id.org/squap/Metric">https://w3id.org/squap/Metric</seealso>
    let Metric = Prefixed_Name(squap, "Metric") |> PrefixedName
    /// <summary>
    ///   <para>squap:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has value</para></remarks>
    /// <seealso href="https://w3id.org/squap/hasValue">https://w3id.org/squap/hasValue</seealso>
    let hasValue = Prefixed_Name(squap, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>squap:Value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Value</para></remarks>
    /// <seealso href="https://w3id.org/squap/Value">https://w3id.org/squap/Value</seealso>
    let Value = Prefixed_Name(squap, "Value") |> PrefixedName

    /// <summary>
    ///   <para>squap:ProcessMaturity/Primary</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Primary</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Primary">https://w3id.org/squap/ProcessMaturity/Primary</seealso>
    let ``ProcessMaturity/Primary`` =
        Prefixed_Name(squap, "ProcessMaturity/Primary") |> PrefixedName

    /// <summary>
    ///   <para>squap:ArchitecturalAlignmentResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Architectural alignment result</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignmentResult">https://w3id.org/squap/ArchitecturalAlignmentResult</seealso>
    let ArchitecturalAlignmentResult =
        Prefixed_Name(squap, "ArchitecturalAlignmentResult") |> PrefixedName

    /// <summary>
    ///   <para>squap:ArchitecturalAlignment/ModelKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///
    /// labels<para>Model kind</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/ModelKind">https://w3id.org/squap/ArchitecturalAlignment/ModelKind</seealso>
    let ``ArchitecturalAlignment/ModelKind`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/ModelKind") |> PrefixedName

    /// <summary>
    ///   <para>squap:ArchitecturalAlignment/System-of-Interest</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>System-of-Interest</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/System-of-Interest">https://w3id.org/squap/ArchitecturalAlignment/System-of-Interest</seealso>
    let ``ArchitecturalAlignment/System_of_Interest`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/System-of-Interest") |> PrefixedName

    /// <summary>
    ///   <para>squap:Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A concept.
    /// Once defined, a Concept can be used in other descriptions.</para>
    /// labels<para>Concept</para></remarks>
    /// <seealso href="https://w3id.org/squap/Concept">https://w3id.org/squap/Concept</seealso>
    let Concept = Prefixed_Name(squap, "Concept") |> PrefixedName
    /// <summary>
    ///   <para>squap:Situation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A view on a set of entities. It can be seen as a 'relational context', reifying a relation.</para>
    /// labels<para>Situation</para></remarks>
    /// <seealso href="https://w3id.org/squap/Situation">https://w3id.org/squap/Situation</seealso>
    let Situation = Prefixed_Name(squap, "Situation") |> PrefixedName
    /// <summary>
    ///   <para>squap:usesConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uses concept</para></remarks>
    /// <seealso href="https://w3id.org/squap/usesConcept">https://w3id.org/squap/usesConcept</seealso>
    let usesConcept = Prefixed_Name(squap, "usesConcept") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/FunctionalCorrectness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Functional correctness</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/FunctionalCorrectness">https://w3id.org/squap/SoftwareQuality/FunctionalCorrectness</seealso>
    let ``SoftwareQuality/FunctionalCorrectness`` =
        Prefixed_Name(squap, "SoftwareQuality/FunctionalCorrectness") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/FunctionalCompleteness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Functional completeness</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/FunctionalCompleteness">https://w3id.org/squap/SoftwareQuality/FunctionalCompleteness</seealso>
    let ``SoftwareQuality/FunctionalCompleteness`` =
        Prefixed_Name(squap, "SoftwareQuality/FunctionalCompleteness") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Modifiability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>Modifiability</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Modifiability">https://w3id.org/squap/SoftwareQuality/Modifiability</seealso>
    let ``SoftwareQuality/Modifiability`` =
        Prefixed_Name(squap, "SoftwareQuality/Modifiability") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/MaintainabilityCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>Maintainability compliance</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/MaintainabilityCompliance">https://w3id.org/squap/SoftwareQuality/MaintainabilityCompliance</seealso>
    let ``SoftwareQuality/MaintainabilityCompliance`` =
        Prefixed_Name(squap, "SoftwareQuality/MaintainabilityCompliance") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/OperabilityCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Operability compliance</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/OperabilityCompliance">https://w3id.org/squap/SoftwareQuality/OperabilityCompliance</seealso>
    let ``SoftwareQuality/OperabilityCompliance`` =
        Prefixed_Name(squap, "SoftwareQuality/OperabilityCompliance") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/PerformanceEfficiencyCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Performance efficiency compliance</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/PerformanceEfficiencyCompliance">https://w3id.org/squap/SoftwareQuality/PerformanceEfficiencyCompliance</seealso>
    let ``SoftwareQuality/PerformanceEfficiencyCompliance`` =
        Prefixed_Name(squap, "SoftwareQuality/PerformanceEfficiencyCompliance") |> PrefixedName

    /// <summary>
    ///   <para>squap:Region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any region in a dimensional space (a dimensional space is a maximal Region), which can be used as a value for a quality of an Entity.</para>
    /// labels<para>Region</para></remarks>
    /// <seealso href="https://w3id.org/squap/Region">https://w3id.org/squap/Region</seealso>
    let Region = Prefixed_Name(squap, "Region") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/FlexibilityInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Flexibility in use</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/FlexibilityInUse">https://w3id.org/squap/SoftwareQuality/FlexibilityInUse</seealso>
    let ``SoftwareQuality/FlexibilityInUse`` =
        Prefixed_Name(squap, "SoftwareQuality/FlexibilityInUse") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/FunctionalSuitability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>Functional suitability</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/FunctionalSuitability">https://w3id.org/squap/SoftwareQuality/FunctionalSuitability</seealso>
    let ``SoftwareQuality/FunctionalSuitability`` =
        Prefixed_Name(squap, "SoftwareQuality/FunctionalSuitability") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Appropriateness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Appropriateness</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Appropriateness">https://w3id.org/squap/SoftwareQuality/Appropriateness</seealso>
    let ``SoftwareQuality/Appropriateness`` =
        Prefixed_Name(squap, "SoftwareQuality/Appropriateness") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Authenticity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Authenticity</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Authenticity">https://w3id.org/squap/SoftwareQuality/Authenticity</seealso>
    let ``SoftwareQuality/Authenticity`` =
        Prefixed_Name(squap, "SoftwareQuality/Authenticity") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Comfort</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Comfort</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Comfort">https://w3id.org/squap/SoftwareQuality/Comfort</seealso>
    let ``SoftwareQuality/Comfort`` =
        Prefixed_Name(squap, "SoftwareQuality/Comfort") |> PrefixedName

    /// <summary>
    ///   <para>squap:Description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Description represents a conceptualization. It can be thought also as a 'descriptive context' that defines concepts in order to see a 'relational context' out of a set of data or observations.</para>
    /// labels<para>Description</para></remarks>
    /// <seealso href="https://w3id.org/squap/Description">https://w3id.org/squap/Description</seealso>
    let Description = Prefixed_Name(squap, "Description") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQualityFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Software quality factor</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQualityFactor">https://w3id.org/squap/SoftwareQualityFactor</seealso>
    let SoftwareQualityFactor =
        Prefixed_Name(squap, "SoftwareQualityFactor") |> PrefixedName

    /// <summary>
    ///   <para>squap:ProcessMaturity/Management</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///
    /// labels<para>Management</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Management">https://w3id.org/squap/ProcessMaturity/Management</seealso>
    let ``ProcessMaturity/Management`` =
        Prefixed_Name(squap, "ProcessMaturity/Management") |> PrefixedName

    /// <summary>
    ///   <para>squap:ProcessMaturity/Improvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Improvement</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Improvement">https://w3id.org/squap/ProcessMaturity/Improvement</seealso>
    let ``ProcessMaturity/Improvement`` =
        Prefixed_Name(squap, "ProcessMaturity/Improvement") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Replaceability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Replaceability</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Replaceability">https://w3id.org/squap/SoftwareQuality/Replaceability</seealso>
    let ``SoftwareQuality/Replaceability`` =
        Prefixed_Name(squap, "SoftwareQuality/Replaceability") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/EfficiencyInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Efficiency in use</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/EfficiencyInUse">https://w3id.org/squap/SoftwareQuality/EfficiencyInUse</seealso>
    let ``SoftwareQuality/EfficiencyInUse`` =
        Prefixed_Name(squap, "SoftwareQuality/EfficiencyInUse") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/FlexibilityInUseCompliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>Flexibility in use compliance</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/FlexibilityInUseCompliance">https://w3id.org/squap/SoftwareQuality/FlexibilityInUseCompliance</seealso>
    let ``SoftwareQuality/FlexibilityInUseCompliance`` =
        Prefixed_Name(squap, "SoftwareQuality/FlexibilityInUseCompliance") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/ApplicationAndMaintenanceContractsVsDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:Class</para>
    ///   <para>Application &amp; Maintenance (AM) contracts are set to outsource the development and maintenance, to decrease internal costs.Typically, they do not provide an adequate documentation.</para>
    /// labels<para>Application and maintenance contracts vs documentation</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/ApplicationAndMaintenanceContractsVsDocumentation">https://w3id.org/squap/Factor/ApplicationAndMaintenanceContractsVsDocumentation</seealso>
    let ``Factor/ApplicationAndMaintenanceContractsVsDocumentation`` =
        Prefixed_Name(squap, "Factor/ApplicationAndMaintenanceContractsVsDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>squap:ProcessMaturity/Maintenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Maintenance</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Maintenance">https://w3id.org/squap/ProcessMaturity/Maintenance</seealso>
    let ``ProcessMaturity/Maintenance`` =
        Prefixed_Name(squap, "ProcessMaturity/Maintenance") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/CommercialDamageInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Commercial damage in use</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/CommercialDamageInUse">https://w3id.org/squap/SoftwareQuality/CommercialDamageInUse</seealso>
    let ``SoftwareQuality/CommercialDamageInUse`` =
        Prefixed_Name(squap, "SoftwareQuality/CommercialDamageInUse") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/SoftwareProductQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Software product quality</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/SoftwareProductQuality">https://w3id.org/squap/SoftwareQuality/SoftwareProductQuality</seealso>
    let ``SoftwareQuality/SoftwareProductQuality`` =
        Prefixed_Name(squap, "SoftwareQuality/SoftwareProductQuality") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Analysability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Analysability</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Analysability">https://w3id.org/squap/SoftwareQuality/Analysability</seealso>
    let ``SoftwareQuality/Analysability`` =
        Prefixed_Name(squap, "SoftwareQuality/Analysability") |> PrefixedName

    /// <summary>
    ///   <para>squap:ProcessMaturity/QualityAssurance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///
    /// labels<para>Quality assurance</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/QualityAssurance">https://w3id.org/squap/ProcessMaturity/QualityAssurance</seealso>
    let ``ProcessMaturity/QualityAssurance`` =
        Prefixed_Name(squap, "ProcessMaturity/QualityAssurance") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/ContractingAndSkills</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>Outsourcing is the main cause of poor software quality.</para>
    /// labels<para>Contracting and skills</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/ContractingAndSkills">https://w3id.org/squap/Factor/ContractingAndSkills</seealso>
    let ``Factor/ContractingAndSkills`` =
        Prefixed_Name(squap, "Factor/ContractingAndSkills") |> PrefixedName

    /// <summary>
    ///   <para>squap:ProcessMaturity/Infrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Infrastructure</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Infrastructure">https://w3id.org/squap/ProcessMaturity/Infrastructure</seealso>
    let ``ProcessMaturity/Infrastructure`` =
        Prefixed_Name(squap, "ProcessMaturity/Infrastructure") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Recoverability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Recoverability</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Recoverability">https://w3id.org/squap/SoftwareQuality/Recoverability</seealso>
    let ``SoftwareQuality/Recoverability`` =
        Prefixed_Name(squap, "SoftwareQuality/Recoverability") |> PrefixedName

    /// <summary>
    ///   <para>squap:ProcessMaturity/Documentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Documentation</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Documentation">https://w3id.org/squap/ProcessMaturity/Documentation</seealso>
    let ``ProcessMaturity/Documentation`` =
        Prefixed_Name(squap, "ProcessMaturity/Documentation") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Confidentiality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Confidentiality</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Confidentiality">https://w3id.org/squap/SoftwareQuality/Confidentiality</seealso>
    let ``SoftwareQuality/Confidentiality`` =
        Prefixed_Name(squap, "SoftwareQuality/Confidentiality") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/UsabilityInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>Usability in use</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/UsabilityInUse">https://w3id.org/squap/SoftwareQuality/UsabilityInUse</seealso>
    let ``SoftwareQuality/UsabilityInUse`` =
        Prefixed_Name(squap, "SoftwareQuality/UsabilityInUse") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/EnvironmentalHarmInUse</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Environmental harm in use</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/EnvironmentalHarmInUse">https://w3id.org/squap/SoftwareQuality/EnvironmentalHarmInUse</seealso>
    let ``SoftwareQuality/EnvironmentalHarmInUse`` =
        Prefixed_Name(squap, "SoftwareQuality/EnvironmentalHarmInUse") |> PrefixedName

    /// <summary>
    ///   <para>squap:ProcessMaturity/Training</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Training</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Training">https://w3id.org/squap/ProcessMaturity/Training</seealso>
    let ``ProcessMaturity/Training`` =
        Prefixed_Name(squap, "ProcessMaturity/Training") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Operability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>Operability</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Operability">https://w3id.org/squap/SoftwareQuality/Operability</seealso>
    let ``SoftwareQuality/Operability`` =
        Prefixed_Name(squap, "SoftwareQuality/Operability") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/DeveloperProfessionalismVsRates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:Class</para>
    ///   <para>Decreasing developer's professionalism and the decrease of professional rates appears to be quite connected.</para>
    /// labels<para>Developer professionalism vs rates</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/DeveloperProfessionalismVsRates">https://w3id.org/squap/Factor/DeveloperProfessionalismVsRates</seealso>
    let ``Factor/DeveloperProfessionalismVsRates`` =
        Prefixed_Name(squap, "Factor/DeveloperProfessionalismVsRates") |> PrefixedName

    /// <summary>
    ///   <para>squap:ProcessMaturity/Supply</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Supply</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Supply">https://w3id.org/squap/ProcessMaturity/Supply</seealso>
    let ``ProcessMaturity/Supply`` =
        Prefixed_Name(squap, "ProcessMaturity/Supply") |> PrefixedName

    /// <summary>
    ///   <para>squap:ProcessMaturity/Verification</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Verification</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Verification">https://w3id.org/squap/ProcessMaturity/Verification</seealso>
    let ``ProcessMaturity/Verification`` =
        Prefixed_Name(squap, "ProcessMaturity/Verification") |> PrefixedName

    /// <summary>
    ///   <para>squap:ProcessMaturity/Development</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Development</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Development">https://w3id.org/squap/ProcessMaturity/Development</seealso>
    let ``ProcessMaturity/Development`` =
        Prefixed_Name(squap, "ProcessMaturity/Development") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Maturity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>Maturity</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Maturity">https://w3id.org/squap/SoftwareQuality/Maturity</seealso>
    let ``SoftwareQuality/Maturity`` =
        Prefixed_Name(squap, "SoftwareQuality/Maturity") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Reusability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Reusability</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Reusability">https://w3id.org/squap/SoftwareQuality/Reusability</seealso>
    let ``SoftwareQuality/Reusability`` =
        Prefixed_Name(squap, "SoftwareQuality/Reusability") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Testability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Testability</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Testability">https://w3id.org/squap/SoftwareQuality/Testability</seealso>
    let ``SoftwareQuality/Testability`` =
        Prefixed_Name(squap, "SoftwareQuality/Testability") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/FunctionalAnalysisVsDataModeling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Difficulties in functional analysis lies in bad data modeling and identification of data sources.</para>
    /// labels<para>Functional analysis vs data modeling</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/FunctionalAnalysisVsDataModeling">https://w3id.org/squap/Factor/FunctionalAnalysisVsDataModeling</seealso>
    let ``Factor/FunctionalAnalysisVsDataModeling`` =
        Prefixed_Name(squap, "Factor/FunctionalAnalysisVsDataModeling") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/InterfacesArchitecturalComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>This factor is a direct consequence of the first one. Module interfaces complexity led to a typical anti-pattern.</para>
    /// labels<para>Interfaces architectural complexity</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/InterfacesArchitecturalComplexity">https://w3id.org/squap/Factor/InterfacesArchitecturalComplexity</seealso>
    let ``Factor/InterfacesArchitecturalComplexity`` =
        Prefixed_Name(squap, "Factor/InterfacesArchitecturalComplexity") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Accountability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>Accountability</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Accountability">https://w3id.org/squap/SoftwareQuality/Accountability</seealso>
    let ``SoftwareQuality/Accountability`` =
        Prefixed_Name(squap, "SoftwareQuality/Accountability") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Integrity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Integrity</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Integrity">https://w3id.org/squap/SoftwareQuality/Integrity</seealso>
    let ``SoftwareQuality/Integrity`` =
        Prefixed_Name(squap, "SoftwareQuality/Integrity") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/DeveloperProfessionalismVsSkills</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>No adequate resources to invest in education and to train developers, especially those with no formal education in IT.</para>
    /// labels<para>Developer professionalism vs skills</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/DeveloperProfessionalismVsSkills">https://w3id.org/squap/Factor/DeveloperProfessionalismVsSkills</seealso>
    let ``Factor/DeveloperProfessionalismVsSkills`` =
        Prefixed_Name(squap, "Factor/DeveloperProfessionalismVsSkills") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/DocumentationStandardsAndTools</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:Class</para>
    ///   <para>Poor documentation hinders software maintainability and increases evolution costs.</para>
    /// labels<para>Documentation standards and tools</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/DocumentationStandardsAndTools">https://w3id.org/squap/Factor/DocumentationStandardsAndTools</seealso>
    let ``Factor/DocumentationStandardsAndTools`` =
        Prefixed_Name(squap, "Factor/DocumentationStandardsAndTools") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Adaptability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///
    /// labels<para>Adaptability</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Adaptability">https://w3id.org/squap/SoftwareQuality/Adaptability</seealso>
    let ``SoftwareQuality/Adaptability`` =
        Prefixed_Name(squap, "SoftwareQuality/Adaptability") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Learnability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Learnability</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Learnability">https://w3id.org/squap/SoftwareQuality/Learnability</seealso>
    let ``SoftwareQuality/Learnability`` =
        Prefixed_Name(squap, "SoftwareQuality/Learnability") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/IncreaseOfMaintenanceCosts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Some factors have a direct impact on maintenance costs. The overall architectural complexity, the decreasing software quality and incomplete documentation are the most important drivers of high maintenance costs and time.</para>
    /// labels<para>Increase of maintenance costs</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/IncreaseOfMaintenanceCosts">https://w3id.org/squap/Factor/IncreaseOfMaintenanceCosts</seealso>
    let ``Factor/IncreaseOfMaintenanceCosts`` =
        Prefixed_Name(squap, "Factor/IncreaseOfMaintenanceCosts") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/ItalianApplicationsVsQualityAndMaintainability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:Class</para>
    ///   <para>Regarding Italian applications, they appear to have more functionalities but incur in higher maintenance costs.</para>
    /// labels<para>Italian applications vs quality and maintainability</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/ItalianApplicationsVsQualityAndMaintainability">https://w3id.org/squap/Factor/ItalianApplicationsVsQualityAndMaintainability</seealso>
    let ``Factor/ItalianApplicationsVsQualityAndMaintainability`` =
        Prefixed_Name(squap, "Factor/ItalianApplicationsVsQualityAndMaintainability") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Modularity</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Modularity</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Modularity">https://w3id.org/squap/SoftwareQuality/Modularity</seealso>
    let ``SoftwareQuality/Modularity`` =
        Prefixed_Name(squap, "SoftwareQuality/Modularity") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/LowerDevelopersExpertiseAndProfessionalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Short time to market expectations and shrinking IT budget is generally considered the main reason for low software quality.</para>
    /// labels<para>Lower developers expertise and professionalism</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/LowerDevelopersExpertiseAndProfessionalism">https://w3id.org/squap/Factor/LowerDevelopersExpertiseAndProfessionalism</seealso>
    let ``Factor/LowerDevelopersExpertiseAndProfessionalism`` =
        Prefixed_Name(squap, "Factor/LowerDevelopersExpertiseAndProfessionalism") |> PrefixedName

    /// <summary>
    ///   <para>squap:ProcessMaturity/Audit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Audit</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Audit">https://w3id.org/squap/ProcessMaturity/Audit</seealso>
    let ``ProcessMaturity/Audit`` =
        Prefixed_Name(squap, "ProcessMaturity/Audit") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Non-repudiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Non-repudiation</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Non-repudiation">https://w3id.org/squap/SoftwareQuality/Non-repudiation</seealso>
    let ``SoftwareQuality/Non_repudiation`` =
        Prefixed_Name(squap, "SoftwareQuality/Non-repudiation") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/DocumentationVsTimeAndBudget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>Time and budget constraints have a direct impact on software documentation. Due to low budget for new developments and urgency for new applications, documentation is the first element which is skipped.</para>
    /// labels<para>Documentation vs time and budget</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/DocumentationVsTimeAndBudget">https://w3id.org/squap/Factor/DocumentationVsTimeAndBudget</seealso>
    let ``Factor/DocumentationVsTimeAndBudget`` =
        Prefixed_Name(squap, "Factor/DocumentationVsTimeAndBudget") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/EstablishmentOfInternalAndExternalDevelopmentProcesses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:Class</para>
    ///   <para>Merging internal and external development processes is extremely difficult.</para>
    /// labels<para>Establishment of internal and external development processes</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/EstablishmentOfInternalAndExternalDevelopmentProcesses">https://w3id.org/squap/Factor/EstablishmentOfInternalAndExternalDevelopmentProcesses</seealso>
    let ``Factor/EstablishmentOfInternalAndExternalDevelopmentProcesses`` =
        Prefixed_Name(squap, "Factor/EstablishmentOfInternalAndExternalDevelopmentProcesses") |> PrefixedName

    /// <summary>
    ///   <para>squap:SoftwareQuality/Installability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQuality</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Installability</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality/Installability">https://w3id.org/squap/SoftwareQuality/Installability</seealso>
    let ``SoftwareQuality/Installability`` =
        Prefixed_Name(squap, "SoftwareQuality/Installability") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/MeasurementOfSoftwareQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>Losing control over the system quality is a concern.</para>
    /// labels<para>Measurement of software quality</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/MeasurementOfSoftwareQuality">https://w3id.org/squap/Factor/MeasurementOfSoftwareQuality</seealso>
    let ``Factor/MeasurementOfSoftwareQuality`` =
        Prefixed_Name(squap, "Factor/MeasurementOfSoftwareQuality") |> PrefixedName

    /// <summary>
    ///   <para>squap:ProcessMaturity/Validation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///
    /// labels<para>Validation</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Validation">https://w3id.org/squap/ProcessMaturity/Validation</seealso>
    let ``ProcessMaturity/Validation`` =
        Prefixed_Name(squap, "ProcessMaturity/Validation") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/ModuleInterfacesComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>A banking information system is characterized by a high number of modules;if these are strongly coupled this increases the number of interfaces and their complexity.</para>
    /// labels<para>Module interfaces complexity</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/ModuleInterfacesComplexity">https://w3id.org/squap/Factor/ModuleInterfacesComplexity</seealso>
    let ``Factor/ModuleInterfacesComplexity`` =
        Prefixed_Name(squap, "Factor/ModuleInterfacesComplexity") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/NewPackagesFunctionalitiesVsComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>The demand for more functionalities rose in the last years, along with their complexity.</para>
    /// labels<para>New packages functionalities vs complexity</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/NewPackagesFunctionalitiesVsComplexity">https://w3id.org/squap/Factor/NewPackagesFunctionalitiesVsComplexity</seealso>
    let ``Factor/NewPackagesFunctionalitiesVsComplexity`` =
        Prefixed_Name(squap, "Factor/NewPackagesFunctionalitiesVsComplexity") |> PrefixedName

    /// <summary>
    ///   <para>squap:ProcessMaturity/ConfigurationManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Configuration management</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/ConfigurationManagement">https://w3id.org/squap/ProcessMaturity/ConfigurationManagement</seealso>
    let ``ProcessMaturity/ConfigurationManagement`` =
        Prefixed_Name(squap, "ProcessMaturity/ConfigurationManagement") |> PrefixedName

    /// <summary>
    ///   <para>squap:ProcessMaturity/ProblemResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>Problem resolution</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/ProblemResolution">https://w3id.org/squap/ProcessMaturity/ProblemResolution</seealso>
    let ``ProcessMaturity/ProblemResolution`` =
        Prefixed_Name(squap, "ProcessMaturity/ProblemResolution") |> PrefixedName

    /// <summary>
    ///   <para>squap:Factor/LackingToolsAndMethodologies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:Class</para>
    ///   <para>Finding and implementing the right tools &amp; methodologies is quite a hard task.</para>
    /// labels<para>Lacking tools and methodologies</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/LackingToolsAndMethodologies">https://w3id.org/squap/Factor/LackingToolsAndMethodologies</seealso>
    let ``Factor/LackingToolsAndMethodologies`` =
        Prefixed_Name(squap, "Factor/LackingToolsAndMethodologies") |> PrefixedName

    /// <summary>
    ///   <para>squap:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>Quality, architecture, and process are considered the keystones of software engineering. ISO defines them in three separate standards. However, their interaction has been poorly studied, so far. The SQuAP model (Software Quality, Architecture, Process) describes twenty-eight main factors that impact on software quality in banking systems, and each factor is described as a relation among some characteristics from the three ISO standards. Hence, SQuAP makes such relations emerge rigorously, although informally. SQaAP-Ont is an OWL ontology that formalises those relations in order to represent and reason via Linked Data about software engineering in a three-dimensional model consisting of quality, architecture, and process characteristics.</para>
    /// labels<para>SQuAP Ontology</para></remarks>
    /// <seealso href="https://w3id.org/squap/">https://w3id.org/squap/</seealso>
    let _prefix_iri = Prefixed_Name(squap, "") |> PrefixedName
    /// <summary>
    ///   <para>squap:0.2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/squap/0.2">https://w3id.org/squap/0.2</seealso>
    let ``_0.2`` = Prefixed_Name(squap, "0.2") |> PrefixedName

    /// <summary>
    ///   <para>squap:ArchitecturalAlignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The software quality characteristic meant as architectural alignment.</para>
    /// labels<para>Architectural alignment</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment">https://w3id.org/squap/ArchitecturalAlignment</seealso>
    let ArchitecturalAlignment =
        Prefixed_Name(squap, "ArchitecturalAlignment") |> PrefixedName
