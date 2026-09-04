#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-gao-obj`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/" "fibo-fnd-gao-obj"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : aim^^xsd:string</para>
    ///   <para>skos:definition : intention specifying a desired direction, condition, or situation toward which an agent's actions are directed, without requiring precise scope or measurable criteria^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Business aims are sometimes considered broad, long-term goals, and in such cases, the term 'aim' is used interchangeably with goal. Here, however we differentiate between qualitative goals and quantitative objectives, both of which are kinds of aims, with the critical differences including measurability and time frame. Goals tend to have a much longer trajectory, provide the basis for determining objectives, and are often aligned with an organization's mission, whereas objectives are short term and measurable.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Aim">fibo-fnd-gao-obj:Aim</a>
    /// </summary>
    let Aim = _prefixId.prefix "Aim"
    /// <summary>
    ///   <para>rdfs:label : approach^^xsd:string</para>
    ///   <para>skos:definition : way of addressing an aim or problem characterized by high-level planning and systematic execution, without presupposing scope or granularity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Approach">fibo-fnd-gao-obj:Approach</a>
    /// </summary>
    let Approach = _prefixId.prefix "Approach"
    /// <summary>
    ///   <para>rdfs:label : business objective^^xsd:string</para>
    ///   <para>skos:definition : objective that reflects the strategic goals and direction of a business within a time frame and available resources^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Business objectives allow an organization to define its goals and direction. A company uses strategy and tactics at every level of its operation to achieve its objectives. These define the way a company allocates its resources and the strengths, weaknesses and opportunities it may have. Companies usually do not alter their objectives once they are implemented, unless changes in circumstances arise. Setting a clear course for the organization is key to its success.^^xsd:stringcmns-av:explanatoryNote : In general, objectives are more specific and easier to measure than goals. Objectives are basic tools that underlie all planning and strategic activities. They serve as the basis for creating policy and evaluating performance. Some examples of business objectives include minimizing expenses, expanding internationally, or making a profit.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/BusinessObjective">fibo-fnd-gao-obj:BusinessObjective</a>
    /// </summary>
    let BusinessObjective = _prefixId.prefix "BusinessObjective"
    /// <summary>
    ///   <para>rdfs:label : business strategy^^xsd:string</para>
    ///   <para>skos:definition : strategy for achieving a specific business goal, objective, solution or outcome^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/BusinessStrategy">fibo-fnd-gao-obj:BusinessStrategy</a>
    /// </summary>
    let BusinessStrategy = _prefixId.prefix "BusinessStrategy"
    /// <summary>
    ///   <para>rdfs:label : distribution strategy^^xsd:string</para>
    ///   <para>skos:definition : strategy for making a product or service available, or for distributing funds, such as in the form of a dividend or coupon^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/DistributionStrategy">fibo-fnd-gao-obj:DistributionStrategy</a>
    /// </summary>
    let DistributionStrategy = _prefixId.prefix "DistributionStrategy"
    /// <summary>
    ///   <para>rdfs:label : financial objective^^xsd:string</para>
    ///   <para>skos:definition : objective that reflects the strategic financial goals and direction of a party within a time frame and available resources^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/FinancialObjective">fibo-fnd-gao-obj:FinancialObjective</a>
    /// </summary>
    let FinancialObjective = _prefixId.prefix "FinancialObjective"
    /// <summary>
    ///   <para>rdfs:label : goal^^xsd:string</para>
    ///   <para>skos:definition : aim distinguished by broad scope and aspirational character, often qualitative and long-term, in order to achieve a desired state^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Many people endeavor to reach goals within a finite time by setting deadlines.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Goal">fibo-fnd-gao-obj:Goal</a>
    /// </summary>
    let Goal = _prefixId.prefix "Goal"
    /// <summary>
    ///   <para>rdfs:label : investment objective^^xsd:string</para>
    ///   <para>skos:definition : financial objective used by an investor to determine whether or not a given potential investment is appropriate for themselves or on behalf of another party^^xsd:string</para>
    ///   <para>skos:example : An investor whose objective is capital growth might choose to invest in more aggressive, growth-oriented mutual funds and/or stocks, over income-generating mutual funds and/or bonds.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The combination of investment objectives and risk tolerance are typically used to identify appropriate investment options.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/InvestmentObjective">fibo-fnd-gao-obj:InvestmentObjective</a>
    /// </summary>
    let InvestmentObjective = _prefixId.prefix "InvestmentObjective"
    /// <summary>
    ///   <para>rdfs:label : local investment objective^^xsd:string</para>
    ///   <para>skos:definition : financial objective that aims to support geographically centralized, community development needs^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/LocalInvestmentObjective">fibo-fnd-gao-obj:LocalInvestmentObjective</a>
    /// </summary>
    let LocalInvestmentObjective = _prefixId.prefix "LocalInvestmentObjective"
    /// <summary>
    ///   <para>rdfs:label : method^^xsd:string</para>
    ///   <para>skos:definition : approach distinguished by systematic, repeatable procedures and operational specificity for doing or calculating something, consisting of defined steps or rules to achieve a result^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Method">fibo-fnd-gao-obj:Method</a>
    /// </summary>
    let Method = _prefixId.prefix "Method"
    /// <summary>
    ///   <para>rdfs:label : objective^^xsd:string</para>
    ///   <para>skos:definition : aim distinguished by specific scope and measurable criteria, often quantitative and short-term that a party seeks to attain, typically in order to achieve its long-term goals^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Objective">fibo-fnd-gao-obj:Objective</a>
    /// </summary>
    let Objective = _prefixId.prefix "Objective"
    /// <summary>
    ///   <para>rdfs:label : programrdfs:label : programme</para>
    ///   <para>skos:definition : state of affairs and coordinated set of activities designed to obtain benefits not available from managing them individually^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.prince2.com/usa/blog/project-vs-programme^^xsd:anyURI</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Program">fibo-fnd-gao-obj:Program</a>
    /// </summary>
    let Program = _prefixId.prefix "Program"
    /// <summary>
    ///   <para>rdfs:label : program identifierrdfs:label : programme identifier</para>
    ///   <para>skos:definition : sequence of characters uniquely identifying a specific program within the context in which that program is administered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/ProgramIdentifier">fibo-fnd-gao-obj:ProgramIdentifier</a>
    /// </summary>
    let ProgramIdentifier = _prefixId.prefix "ProgramIdentifier"
    /// <summary>
    ///   <para>rdfs:label : program namerdfs:label : programme name</para>
    ///   <para>skos:definition : contextual designation for a program within the context in which that program is administered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/ProgramName">fibo-fnd-gao-obj:ProgramName</a>
    /// </summary>
    let ProgramName = _prefixId.prefix "ProgramName"
    /// <summary>
    ///   <para>rdfs:label : project^^xsd:string</para>
    ///   <para>skos:definition : state of affairs and unique and temporary organization, designed to deliver a tangible output^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : https://www.prince2.com/usa/blog/project-vs-programme^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : A project has a fixed - generally fairly short - timeframe, and a project manager is responsible for delivering the output on time and on budget.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Project">fibo-fnd-gao-obj:Project</a>
    /// </summary>
    let Project = _prefixId.prefix "Project"
    /// <summary>
    ///   <para>rdfs:label : project identifier^^xsd:string</para>
    ///   <para>skos:definition : sequence of characters uniquely identifying a specific project within the context in which that project or an overarching program is administered^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/ProjectIdentifier">fibo-fnd-gao-obj:ProjectIdentifier</a>
    /// </summary>
    let ProjectIdentifier = _prefixId.prefix "ProjectIdentifier"
    /// <summary>
    ///   <para>rdfs:label : project name^^xsd:string</para>
    ///   <para>skos:definition : contextual designation for a project^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/ProjectName">fibo-fnd-gao-obj:ProjectName</a>
    /// </summary>
    let ProjectName = _prefixId.prefix "ProjectName"
    /// <summary>
    ///   <para>rdfs:label : sales strategy^^xsd:string</para>
    ///   <para>skos:definition : strategy for selling something, including allocating resources to the sales process, reducing costs, and optimizing revenues^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/SalesStrategy">fibo-fnd-gao-obj:SalesStrategy</a>
    /// </summary>
    let SalesStrategy = _prefixId.prefix "SalesStrategy"
    /// <summary>
    ///   <para>rdfs:label : strategy^^xsd:string</para>
    ///   <para>skos:definition : high-level approach that guides decision-making and the coordination of actions and plans in pursuit of some aim^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A strategy is a high-level plan or approach designed to achieve a long-term goal or outcome, often by choosing among different possible methods or courses of action. A strategy may involve activities that are needed in order to achieve specific goals or objectives. It may take into account one or more policies or any number of restrictions and constraints. Strategies are typically distinguished by long-term orientation, adaptive planning, and broad scope.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Strategy">fibo-fnd-gao-obj:Strategy</a>
    /// </summary>
    let Strategy = _prefixId.prefix "Strategy"
    /// <summary>
    ///   <para>rdfs:label : study^^xsd:string</para>
    ///   <para>skos:definition : analytical activity that investigates a specified area of interest, to determine its characteristics, relationships, constraints, or implications^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Studies involve exploration, analysis, sometimes modeling, and sometimes evaluation, but are not necessarily focused on evaluation and may or may not be criteria-based, which distinguishes it from the concept of an assessment. In a business context, a study might map capabilities, analyze value streams, or model information flows. Only some studies produce an assessment (e.g., capability maturity assessment). A clinical research study may observe, test, or model phenomena, and may or may not result in a clinical or risk assessment. A study conducted as part of a project or larger programme may explore feasibility, options, impacts, or requirements.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/Study">fibo-fnd-gao-obj:Study</a>
    /// </summary>
    let Study = _prefixId.prefix "Study"
    /// <summary>
    ///   <para>rdfs:label : triple bottom line objective^^xsd:string</para>
    ///   <para>skos:definition : financial objective that integrates economic performance, environmental stewardship, and social responsibility as co-equal criteria for success^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/TripleBottomLineObjective">fibo-fnd-gao-obj:TripleBottomLineObjective</a>
    /// </summary>
    let TripleBottomLineObjective = _prefixId.prefix "TripleBottomLineObjective"
    /// <summary>
    ///   <para>rdfs:label : addresses^^xsd:string</para>
    ///   <para>skos:definition : deals with, handles, or gives attention to^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/addresses">fibo-fnd-gao-obj:addresses</a>
    /// </summary>
    let addresses = _prefixId.prefix "addresses"
    /// <summary>
    ///   <para>rdfs:label : has goal^^xsd:string</para>
    ///   <para>skos:definition : has long-term, desired outcome^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/hasGoal">fibo-fnd-gao-obj:hasGoal</a>
    /// </summary>
    let hasGoal = _prefixId.prefix "hasGoal"
    /// <summary>
    ///   <para>rdfs:label : has objective^^xsd:string</para>
    ///   <para>skos:definition : aims to achieve within a time frame and with available resources^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/hasObjective">fibo-fnd-gao-obj:hasObjective</a>
    /// </summary>
    let hasObjective = _prefixId.prefix "hasObjective"
    /// <summary>
    ///   <para>rdfs:label : has strategy^^xsd:string</para>
    ///   <para>skos:definition : applies strategy^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/hasStrategy">fibo-fnd-gao-obj:hasStrategy</a>
    /// </summary>
    let hasStrategy = _prefixId.prefix "hasStrategy"
    /// <summary>
    ///   <para>rdfs:label : is addressed by^^xsd:string</para>
    ///   <para>skos:definition : indicates something, such a goal or objective, that is dealt with by^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/isAddressedBy">fibo-fnd-gao-obj:isAddressedBy</a>
    /// </summary>
    let isAddressedBy = _prefixId.prefix "isAddressedBy"
    /// <summary>
    ///   <para>rdfs:label : uses method^^xsd:string</para>
    ///   <para>skos:definition : employs method^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/usesMethod">fibo-fnd-gao-obj:usesMethod</a>
    /// </summary>
    let usesMethod = _prefixId.prefix "usesMethod"
