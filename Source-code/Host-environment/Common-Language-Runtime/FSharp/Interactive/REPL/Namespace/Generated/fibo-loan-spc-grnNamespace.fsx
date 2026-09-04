#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-loan-spc-grn`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/" "fibo-loan-spc-grn"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : assessment boundary^^xsd:string</para>
    ///   <para>skos:definition : defined scope, limits, and criteria used to determine what is included or excluded in an evaluation, analysis, or measurement of environmental impacts, sustainability performance, or related objectives^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The assessment boundary ensures consistency, transparency, and focus by specifying the parameters for the evaluation. It includes: (1) the scope of assessment, (2) the relevant spacial boundaries, (3) the time period(s) over which the assessment is to be conducted, (4) organizational boundaries - which parts of an organization or project are included in the evaluation, (5) impact categories - which environmental or sustainability impacts are included, (6) lifecycle boundaries - which stages of the lifecycle are included, (7) exclusions - specific elements, processes, or impacts that are excluded from the assessment and justification for these exclusions, and (8) stakeholder boundaries - the extent to which external stakeholders or externalities (e.g., indirect social impacts) are considered.
    ///
    /// 		- The scope statement specifies which aspects, activities, processes, or entities are included in the evaluation. For example, in a greenhouse gas (GHG) emissions assessment, the boundary might cover Scope 1 (direct emissions), Scope 2 (indirect emissions from energy use), and Scope 3 (upstream and downstream emissions in the value chain).
    ///
    /// 		- The spatial boundaries cover the geographic region(s) relevant for the assessment, including but not limited to a specific site, facility, region, or global operations of a company or project.
    ///
    /// 		- The relevant timeframe may be a single year, the entire lifecycle of a product, or a specific project phase.
    ///
    /// 		- Organizational boundaries may include a parent company, subsidiaries, joint ventures, or specific divisions based on control, ownership, or influence.
    ///
    /// 		- Impact may include carbon emissions, energy use, water consumption, biodiversity impact, and waste generation.
    ///
    /// 		- Lifecycle boundaries may cover product or process evaluations (e.g., Life Cycle Assessment or LCA). If so, the boundary defines which stages of the lifecycle are included: Cradle-to-Grave: Includes all stages, from raw material extraction to disposal, Cradle-to-Gate: Covers stages up to the point where the product leaves the manufacturing facility. or Gate-to-Gate: Focuses on a specific segment of the lifecycle, such as manufacturing processes, for example.
    ///
    /// 		- Small, immaterial emissions sources might be excluded if their impact is negligible.
    ///
    /// 		- Stakeholder boundaries with respect to a given sustainability evaluation might include impacts on local communities or supply chain partners.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/AssessmentBoundary">fibo-loan-spc-grn:AssessmentBoundary</a>
    /// </summary>
    let AssessmentBoundary = _prefixId.prefix "AssessmentBoundary"
    /// <summary>
    ///   <para>rdfs:label : environmental program^^xsd:string</para>
    ///   <para>skos:definition : broad scale initiative, activity, or investment aimed at improving environmental sustainability, reducing ecological harm, or addressing environmental challenges^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Key characteristics of an environmental or sustainability program include achieving measurable positive environmental outcomes, and aligning with broader sustainability goals, such as those outlined in international frameworks (e.g., the United Nations Sustainable Development Goals (SDGs), Paris Agreement). Large scale environmental programs may consist of a number of projects aimed at addressing specific requirements that support the broader challenges outlined under the program.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/EnvironmentalProgram">fibo-loan-spc-grn:EnvironmentalProgram</a>
    /// </summary>
    let EnvironmentalProgram = _prefixId.prefix "EnvironmentalProgram"
    /// <summary>
    ///   <para>rdfs:label : environmental project^^xsd:string</para>
    ///   <para>skos:definition : specific initiative, activity, or investment aimed at improving environmental sustainability, reducing ecological harm, or addressing environmental challenges^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Key characteristics of an environmental or sustainability project include achieving measurable positive environmental outcomes, and aligning with broader sustainability goals, such as those outlined in international frameworks (e.g., the United Nations Sustainable Development Goals (SDGs), Paris Agreement).^^xsd:stringcmns-av:explanatoryNote : Such projects are designed to align with environmental goals, such as mitigating climate change, conserving natural resources, protecting biodiversity, and promoting a circular economy.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/EnvironmentalProject">fibo-loan-spc-grn:EnvironmentalProject</a>
    /// </summary>
    let EnvironmentalProject = _prefixId.prefix "EnvironmentalProject"
    /// <summary>
    ///   <para>rdfs:label : green loan</para>
    ///   <para>skos:definition : credit agreement and/or contingent facility (such as a bonding line, guarantee line or letter of credit) made available exclusively to finance, re-finance or guarantee, in whole or in part, new and/or existing eligible green projects that are aligned to the four core components of the Green Loan Principles (GLP)</para>
    ///   <para>skos:example : Example categories of eligibility contained in the LMA's Green Loan Principles (GLP) include loans designed to facilitate renewable energy, energy efficiency, climate change adaptation and green buildings that meet regional, national or internationally recognised standards or certifications.</para>
    ///   <para>cmns-av:adaptedFrom : https://www.addleshawgoddard.com/en/insights/insights-briefings/2020/financial-services/green-loans-and-sustainability-linked-loans-what-is-the-difference/cmns-av:adaptedFrom : https://www.lsta.org/content/sustainable-lending-glossary-of-terms/</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/GreenLoan">fibo-loan-spc-grn:GreenLoan</a>
    /// </summary>
    let GreenLoan = _prefixId.prefix "GreenLoan"
    /// <summary>
    ///   <para>rdfs:label : green project^^xsd:string</para>
    ///   <para>skos:definition : project that contributes to environmental sustainability by addressing climate change, conserving natural resources, reducing pollution, or promoting ecological balance^^xsd:string</para>
    ///   <para>skos:example : Examples include: renewable energy projects (e.g., solar, wind, hydroelectric power), green buildings certified by recognized standards (e.g., LEED, BREEAM), sustainable water and wastewater management systems, pollution reduction technologies and systems, sustainable forestry and agriculture initiatives, circular economy projects, such as recycling or waste-to-energy facilities, low-carbon transportation infrastructure (e.g., electric vehicle charging stations, public transit projects), and the like.</para>
    ///   <para>cmns-av:adaptedFrom : Loan Market Association (LMA) Green Loan Principles, available at https://www.icmagroup.org/assets/documents/Regulatory/Green-Bonds/LMA_Green_Loan_Principles_Booklet-220318.pdf.^^xsd:stringcmns-av:adaptedFrom : https://www.lma.eu.com/application/files/8916/9755/2443/Green_Loan_Principles_23_February_2023.pdfcmns-av:adaptedFrom : https://www.prince2.com/usa/blog/project-vs-programme^^xsd:anyURI</para>
    ///   <para>cmns-av:explanatoryNote : Green projects must align with established green finance principles, such as the Green Loan Principles (GLP) issued by the Loan Market Association (LMA), or other recognized sustainability frameworks.cmns-av:explanatoryNote : The borrower must demonstrate that the project meets predefined eligibility criteria for green financing. These criteria are usually aligned with the taxonomy or standards set forth by the Green Loan Principles, the EU Taxonomy for Sustainable Activities, or other regional or international guidelines.cmns-av:explanatoryNote : To qualify as a green project within a green loan: (a) the project must meet use-of-proceeds requirements, meaning that funds must be exclusively allocated to activities that qualify as green, (b) the borrower must establish clear processes for evaluating and selecting eligible projects, (c) there must be transparency in how funds are managed and allocated, often verified through audits or certifications, and (d) the borrower must report regularly on the environmental impact of the project, typically through measurable metrics (e.g., tons of CO₂ avoided, energy saved).</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/GreenProject">fibo-loan-spc-grn:GreenProject</a>
    /// </summary>
    let GreenProject = _prefixId.prefix "GreenProject"

    /// <summary>
    ///   <para>rdfs:label : green project use of proceeds provision^^xsd:string</para>
    ///   <para>dcterms:source : Loan Market Association (LMA) Green Loan Principles, available at https://www.icmagroup.org/assets/documents/Regulatory/Green-Bonds/LMA_Green_Loan_Principles_Booklet-220318.pdf.^^xsd:string</para>
    ///   <para>skos:definition : use of proceeds provision specifying that funds obtained through financing, such as through a credit agreement, offering, warrant, or other instrument are intended to be used for Green Projects (including other related and supporting expenditures, including research and development)^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : All designated Green Projects should provide clear environmental benefits, which will be assessed, and where feasible, quantified, measured and reported by the borrower, per requirements outlined in the LMA Green Loan Principles (GLP). Where funds are to be used, in whole or part, for refinancing, it is recommended that borrowers provide an estimate of the share of financing versus refinancing. Where appropriate, they should also clarify which investments or project portfolios may be refinanced, and, to the extent relevant, the expected look-back period for refinanced Green Projects. A green loan may take the form of one or more tranches of a loan facility. In such cases, the green tranche(s) must be clearly designated, with proceeds of the green tranche(s) credited to a separate account or tracked by the borrower in an appropriate manner.
    ///
    /// 		The GLP explicitly recognise several broad categories of eligibility for Green Projects with the objective of addressing key areas of environmental concern such as climate change, natural resources depletion, loss of biodiversity, and air, water and soil pollution. This non-exhaustive list, set out in Appendix 1, is intended to capture the most usual types of projects supported, and expected to be supported, by the green loan market. However, it is recognised that definitions of green and green projects may vary depending on sector and geography^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/GreenProjectUseOfProceedsProvision">fibo-loan-spc-grn:GreenProjectUseOfProceedsProvision</a>
    /// </summary>
    let GreenProjectUseOfProceedsProvision =
        _prefixId.prefix "GreenProjectUseOfProceedsProvision"

    /// <summary>
    ///   <para>rdfs:label : observed indicator value</para>
    ///   <para>skos:definition : observation (measurement) of a key performance indicator measured at specific date and time</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/ObservedIndicatorValue">fibo-loan-spc-grn:ObservedIndicatorValue</a>
    /// </summary>
    let ObservedIndicatorValue = _prefixId.prefix "ObservedIndicatorValue"

    /// <summary>
    ///   <para>rdfs:label : observed indicator value structure</para>
    ///   <para>skos:definition : collection of observations for some key performance indicator measured over a specified window of time</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/ObservedIndicatorValueStructure">fibo-loan-spc-grn:ObservedIndicatorValueStructure</a>
    /// </summary>
    let ObservedIndicatorValueStructure =
        _prefixId.prefix "ObservedIndicatorValueStructure"

    /// <summary>
    ///   <para>rdfs:label : sustainability business objective</para>
    ///   <para>skos:definition : objective related to improving the sustainability profile of the business</para>
    ///   <para>cmns-av:adaptedFrom : https://www.lsta.org/content/sustainability-linked-loan-principles-sllp/</para>
    ///   <para>cmns-av:explanatoryNote : The borrower of an SLL should clearly communicate to its lenders its sustainability objective(s) and how such objectives align with its proposed sustainability performance targets (SPTs).</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityBusinessObjective">fibo-loan-spc-grn:SustainabilityBusinessObjective</a>
    /// </summary>
    let SustainabilityBusinessObjective =
        _prefixId.prefix "SustainabilityBusinessObjective"

    /// <summary>
    ///   <para>rdfs:label : sustainability business strategy</para>
    ///   <para>skos:definition : strategy for achieving specific business objectives related to sustainability (from an environmental and/or social and/or governance (ESG) perspective)</para>
    ///   <para>cmns-av:adaptedFrom : https://www.lsta.org/content/sustainability-linked-loan-principles-sllp/</para>
    ///   <para>cmns-av:explanatoryNote : An SLL borrower should clearly communicate to its lender(s) its rationale for the selection of its KPI(s) (i.e. relevance, materiality, whether it is core to the borrower's overall business) and the motivation for the SPT(s) (i.e. ambition level, benchmarking approach and how the borrower intends to reach such SPTs). Borrowers are encouraged to position this information within the context of their overarching objectives, sustainability strategy, policy, sustainability commitments and/or processes relating to sustainability.cmns-av:explanatoryNote : SLLs aim to support a borrower's efforts in improving its sustainability profile over the term of the loan. They do so by aligning loan terms to the borrower's performance, which is measured using one or more sustainability KPIs that can be internal and/or external. The KPIs must be material to the borrower's core sustainability and business strategy, and address relevant ESG challenges of its industry sector.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityBusinessStrategy">fibo-loan-spc-grn:SustainabilityBusinessStrategy</a>
    /// </summary>
    let SustainabilityBusinessStrategy =
        _prefixId.prefix "SustainabilityBusinessStrategy"

    /// <summary>
    ///   <para>rdfs:label : sustainability key performance indicator</para>
    ///   <para>skos:definition : measurable performance indicator that is sustainability specific</para>
    ///   <para>cmns-av:adaptedFrom : https://www.lsta.org/content/sustainability-linked-loan-principles-sllp/</para>
    ///   <para>cmns-av:explanatoryNote : A sustainability KPI must be: (a) relevant, core and material to the borrower's overall business, and of high strategic significance to the borrower's current and/or future operations; (b) measurable or quantifiable on a consistent methodological basis; and (c) able to be benchmarked (i.e. as much as possible using an external reference or definitions to facilitate the assessment of the SPT's level of ambition). A clear definition of the KPI(s) should be provided by the borrower and should include the applicable scope or parameters, as well as the calculation methodology, a definition of a baseline and be benchmarked against an industry standard and/or industry peers where feasible.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityKeyPerformanceIndicator">fibo-loan-spc-grn:SustainabilityKeyPerformanceIndicator</a>
    /// </summary>
    let SustainabilityKeyPerformanceIndicator =
        _prefixId.prefix "SustainabilityKeyPerformanceIndicator"

    /// <summary>
    ///   <para>rdfs:label : sustainability key performance indicator identifier</para>
    ///   <para>skos:definition : sequence of characters uniquely identifying a specific sustainability-related key performance indicator^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityKeyPerformanceIndicatorIdentifier">fibo-loan-spc-grn:SustainabilityKeyPerformanceIndicatorIdentifier</a>
    /// </summary>
    let SustainabilityKeyPerformanceIndicatorIdentifier =
        _prefixId.prefix "SustainabilityKeyPerformanceIndicatorIdentifier"

    /// <summary>
    ///   <para>rdfs:label : sustainability-linked loan</para>
    ///   <para>skos:definition : credit agreement and/or contingent facility (such as a bonding line, guarantee line or letter of credit) for which the economic characteristics can vary depending on whether the borrower achieves ambitious, material and quantifiable predetermined sustainability performance objectives aligned with Sustainability-Linked Loan Principles (SSLP)</para>
    ///   <para>skos:example : The use of proceeds in relation to a SLL is not a determinant in its categorisation and, in most instances, SLLs will be used for general corporate purposes. Instead, SLLs look to support a borrower in improving its sustainability performance.</para>
    ///   <para>cmns-av:abbreviation : SLL</para>
    ///   <para>cmns-av:adaptedFrom : https://www.addleshawgoddard.com/en/insights/insights-briefings/2020/financial-services/green-loans-and-sustainability-linked-loans-what-is-the-difference/cmns-av:adaptedFrom : https://www.lsta.org/content/sustainable-lending-glossary-of-terms/</para>
    ///   <para>cmns-av:explanatoryNote : A borrower's sustainability performance is measured using sustainability performance targets (SPTs), which include key performance indicators, external ratings and/or equivalent metrics that measure improvements in the borrower's sustainability profile.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityLinkedLoan">fibo-loan-spc-grn:SustainabilityLinkedLoan</a>
    /// </summary>
    let SustainabilityLinkedLoan = _prefixId.prefix "SustainabilityLinkedLoan"

    /// <summary>
    ///   <para>rdfs:label : sustainability performance target</para>
    ///   <para>skos:definition : collection of quantitative target values used to calibrate the level of achievement a borrower makes with respect to a key performance indicator, by date, including, but not limited to, the methodology used to calculate its value at any point over the lifetime of a loan</para>
    ///   <para>cmns-av:abbreviation : SPT</para>
    ///   <para>cmns-av:adaptedFrom : https://www.lsta.org/content/sustainability-linked-loan-principles-sllp/</para>
    ///   <para>cmns-av:explanatoryNote : An SLL borrower should clearly communicate to its lenders its rationale for the selection of its KPI(s) (i.e. relevance, materiality, whether it is core to the borrower’s overall business) and the motivation for the SPT(s) (i.e. ambition level, benchmarking approach and how the borrower intends to reach such SPTs). Borrowers are encouraged to position this information within the context of their overarching objectives, sustainability strategy, policy, sustainability commitments and/or processes relating to sustainability.cmns-av:explanatoryNote : The process for calibration of the SPT(s) per KPI is key to the structuring of SLLs, since it will be the expression of the level of ambition the borrower is ready to commit to. The SPTs must be set in good faith and remain relevant (so long as they apply) and ambitious throughout the life of the loan.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityPerformanceTarget">fibo-loan-spc-grn:SustainabilityPerformanceTarget</a>
    /// </summary>
    let SustainabilityPerformanceTarget =
        _prefixId.prefix "SustainabilityPerformanceTarget"

    /// <summary>
    ///   <para>rdfs:label : sustainability performance target identifier</para>
    ///   <para>skos:definition : sequence of characters uniquely identifying a specific sustainability-related performance target^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityPerformanceTargetIdentifier">fibo-loan-spc-grn:SustainabilityPerformanceTargetIdentifier</a>
    /// </summary>
    let SustainabilityPerformanceTargetIdentifier =
        _prefixId.prefix "SustainabilityPerformanceTargetIdentifier"

    /// <summary>
    ///   <para>rdfs:label : sustainability structuring agent</para>
    ///   <para>skos:definition : financial institution appointed to help design, implement, and monitor the sustainability aspects of a syndicated green loan</para>
    ///   <para>cmns-av:explanatoryNote : This role is typically present in sustainability-linked loans (SLLs) or green loans, which tie the loan's terms to the borrower's environmental, social, and governance (ESG) performance. The sustainability structuring agent's role is crucial in ensuring that the loan's sustainability metrics align with both the borrower's goals and the expectations of the participating lenders.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/SustainabilityStructuringAgent">fibo-loan-spc-grn:SustainabilityStructuringAgent</a>
    /// </summary>
    let SustainabilityStructuringAgent =
        _prefixId.prefix "SustainabilityStructuringAgent"

    /// <summary>
    ///   <para>rdfs:label : target indicator value</para>
    ///   <para>skos:definition : target value for a key performance indicator as of a specific date and time</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TargetIndicatorValue">fibo-loan-spc-grn:TargetIndicatorValue</a>
    /// </summary>
    let TargetIndicatorValue = _prefixId.prefix "TargetIndicatorValue"
    /// <summary>
    ///   <para>rdfs:label : transition loan</para>
    ///   <para>skos:definition : credit agreement and/or contingent facility (such as a bonding line, guarantee line or letter of credit) designed to help a business or organization shift from carbon-intensive or environmentally harmful practices to more sustainable and environmentally friendly operations</para>
    ///   <para>cmns-av:explanatoryNote : Transition loans are part of the broader sustainable finance market and are specifically tailored for companies in industries that are not inherently green but are committed to adopting practices that align with a low-carbon or sustainable economy.cmns-av:explanatoryNote : Transition loans are structured to assist companies in reducing greenhouse gas (GHG) emissions, improving energy efficiency, adopting renewable energy sources, or meeting other sustainability targets aligned with climate transition goals. They support initiatives such as retrofitting fossil fuel-based systems, decarbonizing supply chains, or adopting cleaner production methods. Transition loans align with emerging Climate Transition Finance principles (developed by groups such as the International Capital Market Association, ICMA). Borrowers are expected to demonstrate that the loan aligns with long-term, science-based climate goals, such as those outlined in the Paris Agreement (e.g., limiting global warming to well below 2°C).</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TransitionLoan">fibo-loan-spc-grn:TransitionLoan</a>
    /// </summary>
    let TransitionLoan = _prefixId.prefix "TransitionLoan"
    /// <summary>
    ///   <para>rdfs:label : transition project^^xsd:string</para>
    ///   <para>skos:definition : project that supports broad, sector-specific efforts to reduce environmental impact^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Borrowers must demonstrate a credible transition plan, which include: (a) clear sustainability performance targets (SPTs), (b) alignment with recognized climate goals and frameworks (e.g., the Science Based Targets initiative, SBTi), and (c) transparency in reporting progress and outcomes. Third-party verification or certification of the transition plan and its alignment with best practices is often required.cmns-av:explanatoryNote : Green loans focus on funding projects with direct and measurable environmental benefits (e.g., solar farms, green buildings). Transition loans are for broader initiatives aimed at improving sustainability in traditionally carbon-intensive sectors.cmns-av:explanatoryNote : Sustainability-Linked Loans (SLLs): Transition loans share similarities with SLLs, as both tie terms (such as interest rates) to achieving predefined sustainability goals. However, transition loans are specifically framed within the context of long-term decarbonization or sustainability transitions.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TransitionProject">fibo-loan-spc-grn:TransitionProject</a>
    /// </summary>
    let TransitionProject = _prefixId.prefix "TransitionProject"
    /// <summary>
    ///   <para>rdfs:label : transition strategy</para>
    ///   <para>skos:definition : strategy for achieving specific business objectives related to sustainability in the context of long-term decarbonization or sustainability transitions</para>
    ///   <para>cmns-av:explanatoryNote : Note that although there are similarities with sustainability business strategies, they are not the same. KPIs and SPTs may, however, be defined similarly for a given project.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TransitionStrategy">fibo-loan-spc-grn:TransitionStrategy</a>
    /// </summary>
    let TransitionStrategy = _prefixId.prefix "TransitionStrategy"

    /// <summary>
    ///   <para>rdfs:label : transition use of proceeds provision^^xsd:string</para>
    ///   <para>skos:definition : use of proceeds provision specifying that funds obtained through financing, such as through a credit agreement, offering, warrant, or other instrument are intended to be used to fund specific projects, investments, or operational changes that support a company's transition toward sustainability^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/TransitionUseOfProceedsProvision">fibo-loan-spc-grn:TransitionUseOfProceedsProvision</a>
    /// </summary>
    let TransitionUseOfProceedsProvision =
        _prefixId.prefix "TransitionUseOfProceedsProvision"

    /// <summary>
    ///   <para>rdfs:label : has assessment boundary^^xsd:string</para>
    ///   <para>skos:definition : indicates the scope, limits, and context for an environmental or sustainability project^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/hasAssessmentBoundary">fibo-loan-spc-grn:hasAssessmentBoundary</a>
    /// </summary>
    let hasAssessmentBoundary = _prefixId.prefix "hasAssessmentBoundary"
    /// <summary>
    ///   <para>rdfs:label : has spatial boundary^^xsd:string</para>
    ///   <para>skos:definition : specifies a geographic region included in an environmental or sustainability assessment, which may cover a specific site, facility, region, or the global operations of a company or project^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/hasSpatialBoundary">fibo-loan-spc-grn:hasSpatialBoundary</a>
    /// </summary>
    let hasSpatialBoundary = _prefixId.prefix "hasSpatialBoundary"
