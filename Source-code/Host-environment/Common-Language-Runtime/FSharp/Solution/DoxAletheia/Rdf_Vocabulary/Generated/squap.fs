namespace https.w3id.org.squap.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module squap =
    let _namespace_iri = Namespace_Iri squap |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:squap/</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"Quality, architecture, and process are considered the keystones of software engineering. ISO defines them in three separate standards. However, their interaction has been poorly studied, so far. The SQuAP model (Software Quality, Architecture, Process) describes twenty-eight main factors that impact on software quality in banking systems, and each factor is described as a relation among some characteristics from the three ISO standards. Hence, SQuAP makes such relations emerge rigorously, although informally. SQaAP-Ont is an OWL ontology that formalises those relations in order to represent and reason via Linked Data about software engineering in a three-dimensional model consisting of quality, architecture, and process characteristics."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SQuAP Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/">https://w3id.org/squap/</seealso>
    let _prefix_iri = Prefixed_Name(squap, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/0.1</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/squap/0.1">https://w3id.org/squap/0.1</seealso>
    let ``_0.1`` = Prefixed_Name(squap, "0.1") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/0.2</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/squap/0.2">https://w3id.org/squap/0.2</seealso>
    let ``_0.2`` = Prefixed_Name(squap, "0.2") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The software quality characteristic meant as architectural alignment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Architectural alignment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment">https://w3id.org/squap/ArchitecturalAlignment</seealso>
    let ArchitecturalAlignment =
        Prefixed_Name(squap, "ArchitecturalAlignment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ArchitecturalAlignment/ArchitectureDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///
    /// labels<para>"Architecture description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/ArchitectureDescription">https://w3id.org/squap/ArchitecturalAlignment/ArchitectureDescription</seealso>
    let ``ArchitecturalAlignment/ArchitectureDescription`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/ArchitectureDescription") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ArchitecturalAlignment/ArchitectureFramework</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Architecture framework"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/ArchitectureFramework">https://w3id.org/squap/ArchitecturalAlignment/ArchitectureFramework</seealso>
    let ``ArchitecturalAlignment/ArchitectureFramework`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/ArchitectureFramework") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ArchitecturalAlignment/ArchitectureModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Architecture model"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/ArchitectureModel">https://w3id.org/squap/ArchitecturalAlignment/ArchitectureModel</seealso>
    let ``ArchitecturalAlignment/ArchitectureModel`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/ArchitectureModel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ArchitecturalAlignment/ArchitectureRational</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///
    /// labels<para>"Architecture rational"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/ArchitectureRational">https://w3id.org/squap/ArchitecturalAlignment/ArchitectureRational</seealso>
    let ``ArchitecturalAlignment/ArchitectureRational`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/ArchitectureRational") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ArchitecturalAlignment/ArchitectureView</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Architecture view"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/ArchitectureView">https://w3id.org/squap/ArchitecturalAlignment/ArchitectureView</seealso>
    let ``ArchitecturalAlignment/ArchitectureView`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/ArchitectureView") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ArchitecturalAlignment/ArchitectureViewpoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///
    /// labels<para>"Architecture viewpoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/ArchitectureViewpoint">https://w3id.org/squap/ArchitecturalAlignment/ArchitectureViewpoint</seealso>
    let ``ArchitecturalAlignment/ArchitectureViewpoint`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/ArchitectureViewpoint") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ArchitecturalAlignment/Concern</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Concern"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/Concern">https://w3id.org/squap/ArchitecturalAlignment/Concern</seealso>
    let ``ArchitecturalAlignment/Concern`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/Concern") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ArchitecturalAlignment/Correspondence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///
    /// labels<para>"Correspondence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/Correspondence">https://w3id.org/squap/ArchitecturalAlignment/Correspondence</seealso>
    let ``ArchitecturalAlignment/Correspondence`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/Correspondence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ArchitecturalAlignment/CorrespondenceRules</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Correspondence rules"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/CorrespondenceRules">https://w3id.org/squap/ArchitecturalAlignment/CorrespondenceRules</seealso>
    let ``ArchitecturalAlignment/CorrespondenceRules`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/CorrespondenceRules") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ArchitecturalAlignment/Environment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/Environment">https://w3id.org/squap/ArchitecturalAlignment/Environment</seealso>
    let ``ArchitecturalAlignment/Environment`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/Environment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ArchitecturalAlignment/ModelKind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///
    /// labels<para>"Model kind"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/ModelKind">https://w3id.org/squap/ArchitecturalAlignment/ModelKind</seealso>
    let ``ArchitecturalAlignment/ModelKind`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/ModelKind") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ArchitecturalAlignment/ObjectiveCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Objective characteristic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/ObjectiveCharacteristic">https://w3id.org/squap/ArchitecturalAlignment/ObjectiveCharacteristic</seealso>
    let ``ArchitecturalAlignment/ObjectiveCharacteristic`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/ObjectiveCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ArchitecturalAlignment/Stakeholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Stakeholder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/Stakeholder">https://w3id.org/squap/ArchitecturalAlignment/Stakeholder</seealso>
    let ``ArchitecturalAlignment/Stakeholder`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/Stakeholder") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ArchitecturalAlignment/SubjectiveCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Subjective characteristic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/SubjectiveCharacteristic">https://w3id.org/squap/ArchitecturalAlignment/SubjectiveCharacteristic</seealso>
    let ``ArchitecturalAlignment/SubjectiveCharacteristic`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/SubjectiveCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ArchitecturalAlignment/System-of-Interest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/ArchitecturalAlignment</para>
    ///
    /// labels<para>"System-of-Interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignment/System-of-Interest">https://w3id.org/squap/ArchitecturalAlignment/System-of-Interest</seealso>
    let ``ArchitecturalAlignment/System_of_Interest`` =
        Prefixed_Name(squap, "ArchitecturalAlignment/System-of-Interest") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ArchitecturalAlignmentResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Architectural alignment result"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ArchitecturalAlignmentResult">https://w3id.org/squap/ArchitecturalAlignmentResult</seealso>
    let ArchitecturalAlignmentResult =
        Prefixed_Name(squap, "ArchitecturalAlignmentResult") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A concept.
    /// Once defined, a Concept can be used in other descriptions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Concept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Concept">https://w3id.org/squap/Concept</seealso>
    let Concept = Prefixed_Name(squap, "Concept") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/Description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Description represents a conceptualization. It can be thought also as a 'descriptive context' that defines concepts in order to see a 'relational context' out of a set of data or observations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Description">https://w3id.org/squap/Description</seealso>
    let Description = Prefixed_Name(squap, "Description") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/ApplicationAndMaintenanceContractsVsDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Application &amp; Maintenance (AM) contracts are set to outsource the development and maintenance, to decrease internal costs.Typically, they do not provide an adequate documentation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Application and maintenance contracts vs documentation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/ApplicationAndMaintenanceContractsVsDocumentation">https://w3id.org/squap/Factor/ApplicationAndMaintenanceContractsVsDocumentation</seealso>
    let ``Factor/ApplicationAndMaintenanceContractsVsDocumentation`` =
        Prefixed_Name(squap, "Factor/ApplicationAndMaintenanceContractsVsDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/ContractingAndSkills</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:Class</para>
    ///   <para>"Outsourcing is the main cause of poor software quality."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Contracting and skills"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/ContractingAndSkills">https://w3id.org/squap/Factor/ContractingAndSkills</seealso>
    let ``Factor/ContractingAndSkills`` =
        Prefixed_Name(squap, "Factor/ContractingAndSkills") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/CustomSoftwareQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The perceived quality of custom software applications is decreasing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Custom software quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/CustomSoftwareQuality">https://w3id.org/squap/Factor/CustomSoftwareQuality</seealso>
    let ``Factor/CustomSoftwareQuality`` =
        Prefixed_Name(squap, "Factor/CustomSoftwareQuality") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/DataAnalysisVsFunctionalAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Poor data analysis influences functional analysis and so, system integrity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Data analysis vs functional analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/DataAnalysisVsFunctionalAnalysis">https://w3id.org/squap/Factor/DataAnalysisVsFunctionalAnalysis</seealso>
    let ``Factor/DataAnalysisVsFunctionalAnalysis`` =
        Prefixed_Name(squap, "Factor/DataAnalysisVsFunctionalAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/DeveloperProfessionalismVsRates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>"Decreasing developer's professionalism and the decrease of professional rates appears to be quite connected."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Developer professionalism vs rates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/DeveloperProfessionalismVsRates">https://w3id.org/squap/Factor/DeveloperProfessionalismVsRates</seealso>
    let ``Factor/DeveloperProfessionalismVsRates`` =
        Prefixed_Name(squap, "Factor/DeveloperProfessionalismVsRates") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/DeveloperProfessionalismVsSkills</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"No adequate resources to invest in education and to train developers, especially those with no formal education in IT."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Developer professionalism vs skills"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/DeveloperProfessionalismVsSkills">https://w3id.org/squap/Factor/DeveloperProfessionalismVsSkills</seealso>
    let ``Factor/DeveloperProfessionalismVsSkills`` =
        Prefixed_Name(squap, "Factor/DeveloperProfessionalismVsSkills") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/DocumentationStandardsAndTools</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Poor documentation hinders software maintainability and increases evolution costs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Documentation standards and tools"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/DocumentationStandardsAndTools">https://w3id.org/squap/Factor/DocumentationStandardsAndTools</seealso>
    let ``Factor/DocumentationStandardsAndTools`` =
        Prefixed_Name(squap, "Factor/DocumentationStandardsAndTools") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/DocumentationVsTimeAndBudget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:Class</para>
    ///   <para>"Time and budget constraints have a direct impact on software documentation. Due to low budget for new developments and urgency for new applications, documentation is the first element which is skipped."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Documentation vs time and budget"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/DocumentationVsTimeAndBudget">https://w3id.org/squap/Factor/DocumentationVsTimeAndBudget</seealso>
    let ``Factor/DocumentationVsTimeAndBudget`` =
        Prefixed_Name(squap, "Factor/DocumentationVsTimeAndBudget") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/EstablishmentOfInternalAndExternalDevelopmentProcesses</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Merging internal and external development processes is extremely difficult."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Establishment of internal and external development processes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/EstablishmentOfInternalAndExternalDevelopmentProcesses">https://w3id.org/squap/Factor/EstablishmentOfInternalAndExternalDevelopmentProcesses</seealso>
    let ``Factor/EstablishmentOfInternalAndExternalDevelopmentProcesses`` =
        Prefixed_Name(squap, "Factor/EstablishmentOfInternalAndExternalDevelopmentProcesses") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/FunctionalAnalysisVsDataModeling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>"Difficulties in functional analysis lies in bad data modeling and identification of data sources."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Functional analysis vs data modeling"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/FunctionalAnalysisVsDataModeling">https://w3id.org/squap/Factor/FunctionalAnalysisVsDataModeling</seealso>
    let ``Factor/FunctionalAnalysisVsDataModeling`` =
        Prefixed_Name(squap, "Factor/FunctionalAnalysisVsDataModeling") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/IncreaseOfMaintenanceCosts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:Class</para>
    ///   <para>"Some factors have a direct impact on maintenance costs. The overall architectural complexity, the decreasing software quality and incomplete documentation are the most important drivers of high maintenance costs and time."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Increase of maintenance costs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/IncreaseOfMaintenanceCosts">https://w3id.org/squap/Factor/IncreaseOfMaintenanceCosts</seealso>
    let ``Factor/IncreaseOfMaintenanceCosts`` =
        Prefixed_Name(squap, "Factor/IncreaseOfMaintenanceCosts") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/InterfacesArchitecturalComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This factor is a direct consequence of the first one. Module interfaces complexity led to a typical anti-pattern."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Interfaces architectural complexity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/InterfacesArchitecturalComplexity">https://w3id.org/squap/Factor/InterfacesArchitecturalComplexity</seealso>
    let ``Factor/InterfacesArchitecturalComplexity`` =
        Prefixed_Name(squap, "Factor/InterfacesArchitecturalComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/ItalianApplicationsVsQualityAndMaintainability</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Regarding Italian applications, they appear to have more functionalities but incur in higher maintenance costs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Italian applications vs quality and maintainability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/ItalianApplicationsVsQualityAndMaintainability">https://w3id.org/squap/Factor/ItalianApplicationsVsQualityAndMaintainability</seealso>
    let ``Factor/ItalianApplicationsVsQualityAndMaintainability`` =
        Prefixed_Name(squap, "Factor/ItalianApplicationsVsQualityAndMaintainability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/LackingToolsAndMethodologies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>"Finding and implementing the right tools &amp; methodologies is quite a hard task."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lacking tools and methodologies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/LackingToolsAndMethodologies">https://w3id.org/squap/Factor/LackingToolsAndMethodologies</seealso>
    let ``Factor/LackingToolsAndMethodologies`` =
        Prefixed_Name(squap, "Factor/LackingToolsAndMethodologies") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/LowerDevelopersExpertiseAndProfessionalism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>"Short time to market expectations and shrinking IT budget is generally considered the main reason for low software quality."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Lower developers expertise and professionalism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/LowerDevelopersExpertiseAndProfessionalism">https://w3id.org/squap/Factor/LowerDevelopersExpertiseAndProfessionalism</seealso>
    let ``Factor/LowerDevelopersExpertiseAndProfessionalism`` =
        Prefixed_Name(squap, "Factor/LowerDevelopersExpertiseAndProfessionalism") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/MeasurementOfSoftwareQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Losing control over the system quality is a concern."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Measurement of software quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/MeasurementOfSoftwareQuality">https://w3id.org/squap/Factor/MeasurementOfSoftwareQuality</seealso>
    let ``Factor/MeasurementOfSoftwareQuality`` =
        Prefixed_Name(squap, "Factor/MeasurementOfSoftwareQuality") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/ModuleInterfacesComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A banking information system is characterized by a high number of modules;if these are strongly coupled this increases the number of interfaces and their complexity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Module interfaces complexity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/ModuleInterfacesComplexity">https://w3id.org/squap/Factor/ModuleInterfacesComplexity</seealso>
    let ``Factor/ModuleInterfacesComplexity`` =
        Prefixed_Name(squap, "Factor/ModuleInterfacesComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/NewPackagesFunctionalitiesVsComplexity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The demand for more functionalities rose in the last years, along with their complexity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"New packages functionalities vs complexity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/NewPackagesFunctionalitiesVsComplexity">https://w3id.org/squap/Factor/NewPackagesFunctionalitiesVsComplexity</seealso>
    let ``Factor/NewPackagesFunctionalitiesVsComplexity`` =
        Prefixed_Name(squap, "Factor/NewPackagesFunctionalitiesVsComplexity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/Non-ItalianApplicationsVsQualityAndMaintainability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>"Non-Italian applications are more maintainable but have less functionalities."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Non-Italian applications vs quality and maintainability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/Non-ItalianApplicationsVsQualityAndMaintainability">https://w3id.org/squap/Factor/Non-ItalianApplicationsVsQualityAndMaintainability</seealso>
    let ``Factor/Non_ItalianApplicationsVsQualityAndMaintainability`` =
        Prefixed_Name(squap, "Factor/Non-ItalianApplicationsVsQualityAndMaintainability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/PackagesDocumentationVsSystemAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>"The lack of documentation in packages impacts directly on the logical data model and quality controls."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Packages documentation vs system analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/PackagesDocumentationVsSystemAnalysis">https://w3id.org/squap/Factor/PackagesDocumentationVsSystemAnalysis</seealso>
    let ``Factor/PackagesDocumentationVsSystemAnalysis`` =
        Prefixed_Name(squap, "Factor/PackagesDocumentationVsSystemAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/PackagesVsDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:Class</para>
    ///   <para>"The lack of documentation for software packages is perceived as a commercial strategy of suppliers to lock-in customers."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Packages vs documentation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/PackagesVsDocumentation">https://w3id.org/squap/Factor/PackagesVsDocumentation</seealso>
    let ``Factor/PackagesVsDocumentation`` =
        Prefixed_Name(squap, "Factor/PackagesVsDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/QualityVsRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Poorly defined requirements lead to misunderstandings with software developers, which will deliver lower quality software. The functional quality will be low if the requirements' clarity is low."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Quality vs requirements"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/QualityVsRequirements">https://w3id.org/squap/Factor/QualityVsRequirements</seealso>
    let ``Factor/QualityVsRequirements`` =
        Prefixed_Name(squap, "Factor/QualityVsRequirements") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/QualityVsSystemAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Even though the design phase is perceived as the most important up-front activity, it is poorly implemented."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Quality vs system analysis"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/QualityVsSystemAnalysis">https://w3id.org/squap/Factor/QualityVsSystemAnalysis</seealso>
    let ``Factor/QualityVsSystemAnalysis`` =
        Prefixed_Name(squap, "Factor/QualityVsSystemAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/QualityVsTimeAndBudget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>"The whole panel agreed unanimously that there is a direct relationship among quality and time and budget."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Quality vs time and budget"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/QualityVsTimeAndBudget">https://w3id.org/squap/Factor/QualityVsTimeAndBudget</seealso>
    let ``Factor/QualityVsTimeAndBudget`` =
        Prefixed_Name(squap, "Factor/QualityVsTimeAndBudget") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/RequirementsVsMethodologies</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Poor methodologies to elicit business goals and needs lead to the definition of unclear software requirements."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Requirements vs methodologies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/RequirementsVsMethodologies">https://w3id.org/squap/Factor/RequirementsVsMethodologies</seealso>
    let ``Factor/RequirementsVsMethodologies`` =
        Prefixed_Name(squap, "Factor/RequirementsVsMethodologies") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/RequirementsVsTechnicalJargon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>"The (mis-)use of technical jargon of different departments for requirement elicitation leads to low software quality."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Requirements vs technical jargon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/RequirementsVsTechnicalJargon">https://w3id.org/squap/Factor/RequirementsVsTechnicalJargon</seealso>
    let ``Factor/RequirementsVsTechnicalJargon`` =
        Prefixed_Name(squap, "Factor/RequirementsVsTechnicalJargon") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/SystemAnalysisVsDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Inadequate documentation impacts on the system analysis and so on software quality."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"System analysis vs documentation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/SystemAnalysisVsDocumentation">https://w3id.org/squap/Factor/SystemAnalysisVsDocumentation</seealso>
    let ``Factor/SystemAnalysisVsDocumentation`` =
        Prefixed_Name(squap, "Factor/SystemAnalysisVsDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Factor/WebTechnologiesVsMethodologies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    ///   <para>"There is the idea that the adoption of such technologies lead to less rigorous approach to software engineering. In this regard, Agile is considered a scapegoat of such sloppiness."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Web technologies vs methodologies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Factor/WebTechnologiesVsMethodologies">https://w3id.org/squap/Factor/WebTechnologiesVsMethodologies</seealso>
    let ``Factor/WebTechnologiesVsMethodologies`` =
        Prefixed_Name(squap, "Factor/WebTechnologiesVsMethodologies") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/FactorOccurrence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Factor occurrence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/FactorOccurrence">https://w3id.org/squap/FactorOccurrence</seealso>
    let FactorOccurrence = Prefixed_Name(squap, "FactorOccurrence") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/MeasurementResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A measurement result."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Measurement result"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/MeasurementResult">https://w3id.org/squap/MeasurementResult</seealso>
    let MeasurementResult = Prefixed_Name(squap, "MeasurementResult") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/Metric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A metric, e.g. precision."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Metric"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Metric">https://w3id.org/squap/Metric</seealso>
    let Metric = Prefixed_Name(squap, "Metric") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/Parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Concept that classifies something having a certain value, e.g. 'High' can be said of people taller than 185 cm.
    /// However, in order to formally represent this constraint, we need to add an anonymous type to a parameter instance, using a property that convey the semantics of the parameter, e.g.:
    /// High rdf:type Person and (some hasHeight (Height and (oneOf isTallerThan 185) and (oneOf hasUnitOfMeasure centimeter)))"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Parameter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Parameter">https://w3id.org/squap/Parameter</seealso>
    let Parameter = Prefixed_Name(squap, "Parameter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/ProcessMaturity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The software quality characteristic meant as process maturity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Process maturity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity">https://w3id.org/squap/ProcessMaturity</seealso>
    let ProcessMaturity = Prefixed_Name(squap, "ProcessMaturity") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ProcessMaturity/Acquisition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///
    /// labels<para>"Acquisition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Acquisition">https://w3id.org/squap/ProcessMaturity/Acquisition</seealso>
    let ``ProcessMaturity/Acquisition`` =
        Prefixed_Name(squap, "ProcessMaturity/Acquisition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ProcessMaturity/Audit</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Audit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Audit">https://w3id.org/squap/ProcessMaturity/Audit</seealso>
    let ``ProcessMaturity/Audit`` =
        Prefixed_Name(squap, "ProcessMaturity/Audit") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ProcessMaturity/ConfigurationManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Configuration management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/ConfigurationManagement">https://w3id.org/squap/ProcessMaturity/ConfigurationManagement</seealso>
    let ``ProcessMaturity/ConfigurationManagement`` =
        Prefixed_Name(squap, "ProcessMaturity/ConfigurationManagement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ProcessMaturity/Development</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Development"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Development">https://w3id.org/squap/ProcessMaturity/Development</seealso>
    let ``ProcessMaturity/Development`` =
        Prefixed_Name(squap, "ProcessMaturity/Development") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ProcessMaturity/Documentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///
    /// labels<para>"Documentation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Documentation">https://w3id.org/squap/ProcessMaturity/Documentation</seealso>
    let ``ProcessMaturity/Documentation`` =
        Prefixed_Name(squap, "ProcessMaturity/Documentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ProcessMaturity/Improvement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Improvement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Improvement">https://w3id.org/squap/ProcessMaturity/Improvement</seealso>
    let ``ProcessMaturity/Improvement`` =
        Prefixed_Name(squap, "ProcessMaturity/Improvement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ProcessMaturity/Infrastructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Infrastructure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Infrastructure">https://w3id.org/squap/ProcessMaturity/Infrastructure</seealso>
    let ``ProcessMaturity/Infrastructure`` =
        Prefixed_Name(squap, "ProcessMaturity/Infrastructure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ProcessMaturity/JointReview</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///
    /// labels<para>"Joint review"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/JointReview">https://w3id.org/squap/ProcessMaturity/JointReview</seealso>
    let ``ProcessMaturity/JointReview`` =
        Prefixed_Name(squap, "ProcessMaturity/JointReview") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ProcessMaturity/Maintenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///
    /// labels<para>"Maintenance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Maintenance">https://w3id.org/squap/ProcessMaturity/Maintenance</seealso>
    let ``ProcessMaturity/Maintenance`` =
        Prefixed_Name(squap, "ProcessMaturity/Maintenance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ProcessMaturity/Management</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///
    /// labels<para>"Management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Management">https://w3id.org/squap/ProcessMaturity/Management</seealso>
    let ``ProcessMaturity/Management`` =
        Prefixed_Name(squap, "ProcessMaturity/Management") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ProcessMaturity/Operation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///
    /// labels<para>"Operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Operation">https://w3id.org/squap/ProcessMaturity/Operation</seealso>
    let ``ProcessMaturity/Operation`` =
        Prefixed_Name(squap, "ProcessMaturity/Operation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ProcessMaturity/Organisational</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///
    /// labels<para>"Organisational"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Organisational">https://w3id.org/squap/ProcessMaturity/Organisational</seealso>
    let ``ProcessMaturity/Organisational`` =
        Prefixed_Name(squap, "ProcessMaturity/Organisational") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ProcessMaturity/Primary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Primary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Primary">https://w3id.org/squap/ProcessMaturity/Primary</seealso>
    let ``ProcessMaturity/Primary`` =
        Prefixed_Name(squap, "ProcessMaturity/Primary") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ProcessMaturity/ProblemResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Problem resolution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/ProblemResolution">https://w3id.org/squap/ProcessMaturity/ProblemResolution</seealso>
    let ``ProcessMaturity/ProblemResolution`` =
        Prefixed_Name(squap, "ProcessMaturity/ProblemResolution") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ProcessMaturity/QualityAssurance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Quality assurance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/QualityAssurance">https://w3id.org/squap/ProcessMaturity/QualityAssurance</seealso>
    let ``ProcessMaturity/QualityAssurance`` =
        Prefixed_Name(squap, "ProcessMaturity/QualityAssurance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ProcessMaturity/Supply</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Supply"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Supply">https://w3id.org/squap/ProcessMaturity/Supply</seealso>
    let ``ProcessMaturity/Supply`` =
        Prefixed_Name(squap, "ProcessMaturity/Supply") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ProcessMaturity/Supporting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Supporting"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Supporting">https://w3id.org/squap/ProcessMaturity/Supporting</seealso>
    let ``ProcessMaturity/Supporting`` =
        Prefixed_Name(squap, "ProcessMaturity/Supporting") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ProcessMaturity/Training</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Training"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Training">https://w3id.org/squap/ProcessMaturity/Training</seealso>
    let ``ProcessMaturity/Training`` =
        Prefixed_Name(squap, "ProcessMaturity/Training") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ProcessMaturity/Validation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Validation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Validation">https://w3id.org/squap/ProcessMaturity/Validation</seealso>
    let ``ProcessMaturity/Validation`` =
        Prefixed_Name(squap, "ProcessMaturity/Validation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ProcessMaturity/Verification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:squap/ProcessMaturity</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Verification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturity/Verification">https://w3id.org/squap/ProcessMaturity/Verification</seealso>
    let ``ProcessMaturity/Verification`` =
        Prefixed_Name(squap, "ProcessMaturity/Verification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/ProcessMaturityResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Process maturity result"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/ProcessMaturityResult">https://w3id.org/squap/ProcessMaturityResult</seealso>
    let ProcessMaturityResult =
        Prefixed_Name(squap, "ProcessMaturityResult") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any region in a dimensional space (a dimensional space is a maximal Region), which can be used as a value for a quality of an Entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Region">https://w3id.org/squap/Region</seealso>
    let Region = Prefixed_Name(squap, "Region") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/Situation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A view on a set of entities. It can be seen as a 'relational context', reifying a relation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Situation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Situation">https://w3id.org/squap/Situation</seealso>
    let Situation = Prefixed_Name(squap, "Situation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/SoftwareQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The software quality characteristic meant as softwarea quality."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Software quality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQuality">https://w3id.org/squap/SoftwareQuality</seealso>
    let SoftwareQuality = Prefixed_Name(squap, "SoftwareQuality") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQualityCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The concept of the sotftware quality characteristic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Software quality characteristic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQualityCharacteristic">https://w3id.org/squap/SoftwareQualityCharacteristic</seealso>
    let SoftwareQualityCharacteristic =
        Prefixed_Name(squap, "SoftwareQualityCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQualityFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Software quality factor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQualityFactor">https://w3id.org/squap/SoftwareQualityFactor</seealso>
    let SoftwareQualityFactor =
        Prefixed_Name(squap, "SoftwareQualityFactor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/SoftwareQualityResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Software quality result"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/SoftwareQualityResult">https://w3id.org/squap/SoftwareQualityResult</seealso>
    let SoftwareQualityResult =
        Prefixed_Name(squap, "SoftwareQualityResult") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/Value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/Value">https://w3id.org/squap/Value</seealso>
    let Value = Prefixed_Name(squap, "Value") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/affectsMeasurementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"affects measurement of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/affectsMeasurementOf">https://w3id.org/squap/affectsMeasurementOf</seealso>
    let affectsMeasurementOf =
        Prefixed_Name(squap, "affectsMeasurementOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/assesses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"assesses"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/assesses">https://w3id.org/squap/assesses</seealso>
    let assesses = Prefixed_Name(squap, "assesses") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/classifies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"classifies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/classifies">https://w3id.org/squap/classifies</seealso>
    let classifies = Prefixed_Name(squap, "classifies") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/hasMetric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has metric"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/hasMetric">https://w3id.org/squap/hasMetric</seealso>
    let hasMetric = Prefixed_Name(squap, "hasMetric") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/hasParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a metric and a parameter."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has parameter"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/hasParameter">https://w3id.org/squap/hasParameter</seealso>
    let hasParameter = Prefixed_Name(squap, "hasParameter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/hasValue">https://w3id.org/squap/hasValue</seealso>
    let hasValue = Prefixed_Name(squap, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/isAffectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is affected by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/isAffectedBy">https://w3id.org/squap/isAffectedBy</seealso>
    let isAffectedBy = Prefixed_Name(squap, "isAffectedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/isAssessedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is assessed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/isAssessedBy">https://w3id.org/squap/isAssessedBy</seealso>
    let isAssessedBy = Prefixed_Name(squap, "isAssessedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/isClassifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is classified by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/isClassifiedBy">https://w3id.org/squap/isClassifiedBy</seealso>
    let isClassifiedBy = Prefixed_Name(squap, "isClassifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/isConceptUsedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is concept used in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/isConceptUsedIn">https://w3id.org/squap/isConceptUsedIn</seealso>
    let isConceptUsedIn = Prefixed_Name(squap, "isConceptUsedIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/isFactorSatisfiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is factor satisfied by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/isFactorSatisfiedBy">https://w3id.org/squap/isFactorSatisfiedBy</seealso>
    let isFactorSatisfiedBy =
        Prefixed_Name(squap, "isFactorSatisfiedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/isMetricOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is metric of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/isMetricOf">https://w3id.org/squap/isMetricOf</seealso>
    let isMetricOf = Prefixed_Name(squap, "isMetricOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/isParameterOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a parameter and a metric."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is parameter of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/isParameterOf">https://w3id.org/squap/isParameterOf</seealso>
    let isParameterOf = Prefixed_Name(squap, "isParameterOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/isParametrizedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is parametrized by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/isParametrizedBy">https://w3id.org/squap/isParametrizedBy</seealso>
    let isParametrizedBy = Prefixed_Name(squap, "isParametrizedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/isQualityCharacteristicUsedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is quality characteristic used in"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/isQualityCharacteristicUsedIn">https://w3id.org/squap/isQualityCharacteristicUsedIn</seealso>
    let isQualityCharacteristicUsedIn =
        Prefixed_Name(squap, "isQualityCharacteristicUsedIn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/isSatisfiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is satisfied by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/isSatisfiedBy">https://w3id.org/squap/isSatisfiedBy</seealso>
    let isSatisfiedBy = Prefixed_Name(squap, "isSatisfiedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/isSpecializedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"is specialized by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/isSpecializedBy">https://w3id.org/squap/isSpecializedBy</seealso>
    let isSpecializedBy = Prefixed_Name(squap, "isSpecializedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/isValueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is value of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/isValueOf">https://w3id.org/squap/isValueOf</seealso>
    let isValueOf = Prefixed_Name(squap, "isValueOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/parametrizes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"parametrizes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/parametrizes">https://w3id.org/squap/parametrizes</seealso>
    let parametrizes = Prefixed_Name(squap, "parametrizes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/satisfies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"satisfies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/satisfies">https://w3id.org/squap/satisfies</seealso>
    let satisfies = Prefixed_Name(squap, "satisfies") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/satisfiesFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"satisfies factor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/satisfiesFactor">https://w3id.org/squap/satisfiesFactor</seealso>
    let satisfiesFactor = Prefixed_Name(squap, "satisfiesFactor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/specializes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///
    /// labels<para>"specializes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/specializes">https://w3id.org/squap/specializes</seealso>
    let specializes = Prefixed_Name(squap, "specializes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:squap/usesConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"uses concept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/usesConcept">https://w3id.org/squap/usesConcept</seealso>
    let usesConcept = Prefixed_Name(squap, "usesConcept") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/usesQualityCharacteristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"uses quality characteristic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/usesQualityCharacteristic">https://w3id.org/squap/usesQualityCharacteristic</seealso>
    let usesQualityCharacteristic =
        Prefixed_Name(squap, "usesQualityCharacteristic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:squap/value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/squap/value">https://w3id.org/squap/value</seealso>
    let value = Prefixed_Name(squap, "value") |> PrefixedName
