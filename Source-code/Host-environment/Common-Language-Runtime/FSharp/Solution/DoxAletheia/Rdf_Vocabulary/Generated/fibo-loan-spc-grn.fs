namespace https.spec.edmcouncil.org.fibo.ontology.LOAN.LoansSpecific.GreenLoans.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_loan_spc_grn =
    let _namespace_iri = Namespace_Iri fibo_loan_spc_grn |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-loan-spc-grn:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Green Loans Ontology"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_loan_spc_grn, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-grn:AssessmentBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"assessment boundary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/AssessmentBoundary">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/AssessmentBoundary</seealso>
    let AssessmentBoundary =
        Prefixed_Name(fibo_loan_spc_grn, "AssessmentBoundary") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-grn:EnvironmentalProgram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"environmental program"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/EnvironmentalProgram">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/EnvironmentalProgram</seealso>
    let EnvironmentalProgram =
        Prefixed_Name(fibo_loan_spc_grn, "EnvironmentalProgram") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-grn:EnvironmentalProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"environmental project"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/EnvironmentalProject">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/EnvironmentalProject</seealso>
    let EnvironmentalProject =
        Prefixed_Name(fibo_loan_spc_grn, "EnvironmentalProject") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-grn:GreenLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"green loan"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/GreenLoan">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/GreenLoan</seealso>
    let GreenLoan = Prefixed_Name(fibo_loan_spc_grn, "GreenLoan") |> PrefixedName
    /// <summary>
    ///   <para>fibo-loan-spc-grn:GreenProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"green project"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/GreenProject">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/GreenProject</seealso>
    let GreenProject = Prefixed_Name(fibo_loan_spc_grn, "GreenProject") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-grn:GreenProjectUseOfProceedsProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"green project use of proceeds provision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/GreenProjectUseOfProceedsProvision">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/GreenProjectUseOfProceedsProvision</seealso>
    let GreenProjectUseOfProceedsProvision =
        Prefixed_Name(fibo_loan_spc_grn, "GreenProjectUseOfProceedsProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-grn:ObservedIndicatorValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"observed indicator value"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/ObservedIndicatorValue">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/ObservedIndicatorValue</seealso>
    let ObservedIndicatorValue =
        Prefixed_Name(fibo_loan_spc_grn, "ObservedIndicatorValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-grn:ObservedIndicatorValueStructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"observed indicator value structure"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/ObservedIndicatorValueStructure">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/ObservedIndicatorValueStructure</seealso>
    let ObservedIndicatorValueStructure =
        Prefixed_Name(fibo_loan_spc_grn, "ObservedIndicatorValueStructure") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-grn:SustainabilityBusinessObjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sustainability business objective"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityBusinessObjective">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityBusinessObjective</seealso>
    let SustainabilityBusinessObjective =
        Prefixed_Name(fibo_loan_spc_grn, "SustainabilityBusinessObjective") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-grn:SustainabilityBusinessStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sustainability business strategy"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityBusinessStrategy">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityBusinessStrategy</seealso>
    let SustainabilityBusinessStrategy =
        Prefixed_Name(fibo_loan_spc_grn, "SustainabilityBusinessStrategy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-grn:SustainabilityKeyPerformanceIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sustainability key performance indicator"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityKeyPerformanceIndicator">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityKeyPerformanceIndicator</seealso>
    let SustainabilityKeyPerformanceIndicator =
        Prefixed_Name(fibo_loan_spc_grn, "SustainabilityKeyPerformanceIndicator") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-grn:SustainabilityKeyPerformanceIndicatorIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sustainability key performance indicator identifier"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityKeyPerformanceIndicatorIdentifier">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityKeyPerformanceIndicatorIdentifier</seealso>
    let SustainabilityKeyPerformanceIndicatorIdentifier =
        Prefixed_Name(fibo_loan_spc_grn, "SustainabilityKeyPerformanceIndicatorIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-grn:SustainabilityLinkedLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sustainability-linked loan"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityLinkedLoan">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityLinkedLoan</seealso>
    let SustainabilityLinkedLoan =
        Prefixed_Name(fibo_loan_spc_grn, "SustainabilityLinkedLoan") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-grn:SustainabilityPerformanceTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sustainability performance target"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityPerformanceTarget">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityPerformanceTarget</seealso>
    let SustainabilityPerformanceTarget =
        Prefixed_Name(fibo_loan_spc_grn, "SustainabilityPerformanceTarget") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-grn:SustainabilityPerformanceTargetIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sustainability performance target identifier"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityPerformanceTargetIdentifier">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityPerformanceTargetIdentifier</seealso>
    let SustainabilityPerformanceTargetIdentifier =
        Prefixed_Name(fibo_loan_spc_grn, "SustainabilityPerformanceTargetIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-grn:SustainabilityStructuringAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sustainability structuring agent"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityStructuringAgent">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityStructuringAgent</seealso>
    let SustainabilityStructuringAgent =
        Prefixed_Name(fibo_loan_spc_grn, "SustainabilityStructuringAgent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-grn:TargetIndicatorValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"target indicator value"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TargetIndicatorValue">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TargetIndicatorValue</seealso>
    let TargetIndicatorValue =
        Prefixed_Name(fibo_loan_spc_grn, "TargetIndicatorValue") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-grn:TransitionLoan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"transition loan"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TransitionLoan">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TransitionLoan</seealso>
    let TransitionLoan =
        Prefixed_Name(fibo_loan_spc_grn, "TransitionLoan") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-grn:TransitionProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"transition project"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TransitionProject">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TransitionProject</seealso>
    let TransitionProject =
        Prefixed_Name(fibo_loan_spc_grn, "TransitionProject") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-grn:TransitionStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"transition strategy"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TransitionStrategy">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TransitionStrategy</seealso>
    let TransitionStrategy =
        Prefixed_Name(fibo_loan_spc_grn, "TransitionStrategy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-grn:TransitionUseOfProceedsProvision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"transition use of proceeds provision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TransitionUseOfProceedsProvision">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TransitionUseOfProceedsProvision</seealso>
    let TransitionUseOfProceedsProvision =
        Prefixed_Name(fibo_loan_spc_grn, "TransitionUseOfProceedsProvision") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-grn:hasAssessmentBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has assessment boundary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/hasAssessmentBoundary">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/hasAssessmentBoundary</seealso>
    let hasAssessmentBoundary =
        Prefixed_Name(fibo_loan_spc_grn, "hasAssessmentBoundary") |> PrefixedName

    /// <summary>
    ///   <para>fibo-loan-spc-grn:hasSpatialBoundary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has spatial boundary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/hasSpatialBoundary">https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/hasSpatialBoundary</seealso>
    let hasSpatialBoundary =
        Prefixed_Name(fibo_loan_spc_grn, "hasSpatialBoundary") |> PrefixedName
