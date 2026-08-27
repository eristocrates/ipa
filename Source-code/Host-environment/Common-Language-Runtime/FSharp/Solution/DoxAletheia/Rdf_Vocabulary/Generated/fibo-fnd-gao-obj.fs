namespace https.spec.edmcouncil.org.fibo.ontology.FND.GoalsAndObjectives.Objectives.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_gao_obj =
    let _namespace_iri = Namespace_Iri fibo_fnd_gao_obj |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-gao-obj:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Objectives Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_gao_obj, "") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-gao-obj:Aim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"aim"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Aim">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Aim</seealso>
    let Aim = Prefixed_Name(fibo_fnd_gao_obj, "Aim") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-gao-obj:Approach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"approach"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Approach">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Approach</seealso>
    let Approach = Prefixed_Name(fibo_fnd_gao_obj, "Approach") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-gao-obj:BusinessObjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business objective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/BusinessObjective">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/BusinessObjective</seealso>
    let BusinessObjective =
        Prefixed_Name(fibo_fnd_gao_obj, "BusinessObjective") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-gao-obj:BusinessStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"business strategy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/BusinessStrategy">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/BusinessStrategy</seealso>
    let BusinessStrategy =
        Prefixed_Name(fibo_fnd_gao_obj, "BusinessStrategy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-gao-obj:DistributionStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"distribution strategy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/DistributionStrategy">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/DistributionStrategy</seealso>
    let DistributionStrategy =
        Prefixed_Name(fibo_fnd_gao_obj, "DistributionStrategy") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-gao-obj:FinancialObjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"financial objective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/FinancialObjective">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/FinancialObjective</seealso>
    let FinancialObjective =
        Prefixed_Name(fibo_fnd_gao_obj, "FinancialObjective") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-gao-obj:Goal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"goal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Goal">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Goal</seealso>
    let Goal = Prefixed_Name(fibo_fnd_gao_obj, "Goal") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-gao-obj:InvestmentObjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"investment objective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/InvestmentObjective">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/InvestmentObjective</seealso>
    let InvestmentObjective =
        Prefixed_Name(fibo_fnd_gao_obj, "InvestmentObjective") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-gao-obj:LocalInvestmentObjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"local investment objective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/LocalInvestmentObjective">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/LocalInvestmentObjective</seealso>
    let LocalInvestmentObjective =
        Prefixed_Name(fibo_fnd_gao_obj, "LocalInvestmentObjective") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-gao-obj:Method</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"method"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Method">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Method</seealso>
    let Method = Prefixed_Name(fibo_fnd_gao_obj, "Method") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-gao-obj:Objective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"objective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Objective">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Objective</seealso>
    let Objective = Prefixed_Name(fibo_fnd_gao_obj, "Objective") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-gao-obj:Program</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"program"</para><para>"programme"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Program">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Program</seealso>
    let Program = Prefixed_Name(fibo_fnd_gao_obj, "Program") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-gao-obj:ProgramIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"programme identifier"</para><para>"program identifier"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/ProgramIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/ProgramIdentifier</seealso>
    let ProgramIdentifier =
        Prefixed_Name(fibo_fnd_gao_obj, "ProgramIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-gao-obj:ProgramName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"program name"</para><para>"programme name"</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/ProgramName">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/ProgramName</seealso>
    let ProgramName = Prefixed_Name(fibo_fnd_gao_obj, "ProgramName") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-gao-obj:Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"project"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Project">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Project</seealso>
    let Project = Prefixed_Name(fibo_fnd_gao_obj, "Project") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-gao-obj:ProjectIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"project identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/ProjectIdentifier">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/ProjectIdentifier</seealso>
    let ProjectIdentifier =
        Prefixed_Name(fibo_fnd_gao_obj, "ProjectIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-gao-obj:ProjectName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"project name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/ProjectName">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/ProjectName</seealso>
    let ProjectName = Prefixed_Name(fibo_fnd_gao_obj, "ProjectName") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-gao-obj:SalesStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"sales strategy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/SalesStrategy">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/SalesStrategy</seealso>
    let SalesStrategy = Prefixed_Name(fibo_fnd_gao_obj, "SalesStrategy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-gao-obj:Strategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"strategy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Strategy">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Strategy</seealso>
    let Strategy = Prefixed_Name(fibo_fnd_gao_obj, "Strategy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-gao-obj:Study</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"study"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Study">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Study</seealso>
    let Study = Prefixed_Name(fibo_fnd_gao_obj, "Study") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-gao-obj:TripleBottomLineObjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"triple bottom line objective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/TripleBottomLineObjective">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/TripleBottomLineObjective</seealso>
    let TripleBottomLineObjective =
        Prefixed_Name(fibo_fnd_gao_obj, "TripleBottomLineObjective") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-gao-obj:addresses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"addresses"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/addresses">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/addresses</seealso>
    let addresses = Prefixed_Name(fibo_fnd_gao_obj, "addresses") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-gao-obj:hasGoal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has goal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/hasGoal">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/hasGoal</seealso>
    let hasGoal = Prefixed_Name(fibo_fnd_gao_obj, "hasGoal") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-gao-obj:hasObjective</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has objective"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/hasObjective">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/hasObjective</seealso>
    let hasObjective = Prefixed_Name(fibo_fnd_gao_obj, "hasObjective") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-gao-obj:hasStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has strategy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/hasStrategy">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/hasStrategy</seealso>
    let hasStrategy = Prefixed_Name(fibo_fnd_gao_obj, "hasStrategy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-gao-obj:isAddressedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is addressed by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/isAddressedBy">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/isAddressedBy</seealso>
    let isAddressedBy = Prefixed_Name(fibo_fnd_gao_obj, "isAddressedBy") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-gao-obj:usesMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"uses method"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/usesMethod">https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/usesMethod</seealso>
    let usesMethod = Prefixed_Name(fibo_fnd_gao_obj, "usesMethod") |> PrefixedName
