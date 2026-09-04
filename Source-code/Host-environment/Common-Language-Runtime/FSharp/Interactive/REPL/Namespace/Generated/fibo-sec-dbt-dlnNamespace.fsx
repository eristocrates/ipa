#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-sec-dbt-dln`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/" "fibo-sec-dbt-dln"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : administrative agent</para>
    ///   <para>skos:definition : role of a financial institution (often one of the primary lenders in the syndicate) designated to act as an intermediary between the borrowers and the syndicate lenders</para>
    ///   <para>cmns-av:explanatoryNote : An administrative agent is designated by the syndicate and granted the authority to disburse funds, collect payments, monitor compliance and act as the communications intermediary with the borrower on behalf of the syndicate. This coordination role is crucial to ensuring that lenders' rights and oblications are properly coordinated and to streamline operations. Their authority and the scope of what they can do is explicitly stated in the loan agreement, and does not allow unilateral decision making with respect to the terms of the loan.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/AdministrativeAgent">fibo-sec-dbt-dln:AdministrativeAgent</a>
    /// </summary>
    let AdministrativeAgent = _prefixId.prefix "AdministrativeAgent"
    /// <summary>
    ///   <para>rdfs:label : bookrunner</para>
    ///   <para>skos:definition : financial institution (typically a commercial or investment bank) responsible for coordinating the arrangement, structuring, and marketing of the loan to potential lenders</para>
    ///   <para>cmns-av:explanatoryNote : A 'bookrunner' is primarily responsible for managing the distribution and sale of a security during a new issuance, while a 'lead arranger' is the primary bank that structures and leads a syndicated loan, often assigning portions of the loan to other banks to participate in the deal; essentially, the bookrunner focuses on selling the security to investors, while the lead arranger focuses on structuring the loan itself and coordinating the syndicate of lenders involved.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/Bookrunner">fibo-sec-dbt-dln:Bookrunner</a>
    /// </summary>
    let Bookrunner = _prefixId.prefix "Bookrunner"
    /// <summary>
    ///   <para>rdfs:label : documentation agent</para>
    ///   <para>skos:definition : financial institution designated to oversee the drafting, negotiation, and finalization of the loan documentation</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/DocumentationAgent">fibo-sec-dbt-dln:DocumentationAgent</a>
    /// </summary>
    let DocumentationAgent = _prefixId.prefix "DocumentationAgent"
    /// <summary>
    ///   <para>rdfs:label : finance syndicate</para>
    ///   <para>skos:definition : group of financial institutions or lenders that collectively agree to provide funding for a large loan to a single borrower</para>
    ///   <para>cmns-av:explanatoryNote : Syndicates are formed to enable the provision of substantial financing amounts that would be challenging or risky for any one lender to offer alone. The syndicate structure allows lenders to share the loan amount, spreading both the funding and associated risks among multiple participants.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/FinanceSyndicate">fibo-sec-dbt-dln:FinanceSyndicate</a>
    /// </summary>
    let FinanceSyndicate = _prefixId.prefix "FinanceSyndicate"
    /// <summary>
    ///   <para>rdfs:label : finance syndicate member</para>
    ///   <para>skos:definition : syndicate member that is a financial services provider that contributes funds to a syndicated loan or loan participation note</para>
    ///   <para>cmns-av:explanatoryNote : Syndicate members may include a variety of financial institutions, such as commercial banks, investment banks, institutional investors - insurance companies, pension funds, and hedge funds, and specialty finance firms, focused on specific industries or credit profiles, which may join syndicates for specialized or higher-risk loans.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/FinanceSyndicateMember">fibo-sec-dbt-dln:FinanceSyndicateMember</a>
    /// </summary>
    let FinanceSyndicateMember = _prefixId.prefix "FinanceSyndicateMember"
    /// <summary>
    ///   <para>rdfs:label : lead arranger</para>
    ///   <para>skos:definition : financial institution that spearheads the loan structuring and syndication process on behalf of the borrower</para>
    ///   <para>cmns-av:explanatoryNote : The lead arranger acts as the primary point of contact for the borrower. They perform credit analysis and due diligence, ensure that the structure meets borrowers goals, and coordinates with potential lenders regarding the initial structure and commitments.</para>
    ///   <para>cmns-av:synonym : arrangercmns-av:synonym : lead bankcmns-av:synonym : lead manager</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/LeadArranger">fibo-sec-dbt-dln:LeadArranger</a>
    /// </summary>
    let LeadArranger = _prefixId.prefix "LeadArranger"
    /// <summary>
    ///   <para>rdfs:label : loan participation note</para>
    ///   <para>skos:definition : credit facility and fixed-income security that may be distributed across a group of lenders</para>
    ///   <para>cmns-av:abbreviation : LPN</para>
    ///   <para>cmns-av:explanatoryNote : The main difference between a loan participation and a loan syndication is that in a loan participation, one lender sells ownership interests in a loan to other lenders, while in a loan syndication, the lenders work together to originate and lend on the loan.cmns-av:explanatoryNote : With an LPN, a lead bank underwrites and issues the loan. This lending institution then recruits other banks to participate and share the risks and profits on a pro rata basis. The lead lender keeps a partial interest in the loan and is responsible for servicing it.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/LoanParticipationNote">fibo-sec-dbt-dln:LoanParticipationNote</a>
    /// </summary>
    let LoanParticipationNote = _prefixId.prefix "LoanParticipationNote"
    /// <summary>
    ///   <para>rdfs:label : syndicated loan</para>
    ///   <para>skos:definition : credit agreement in which a group of lenders, known as a syndicate, collectively provides a large loan to a single borrower</para>
    ///   <para>cmns-av:explanatoryNote : A syndicated loan enables pooling of funds from multiple financial institutions, typically under the leadership of one or more arranging banks. These kinds of credit agreements are often used by large corporations, private equity investors and government entities for significant capital needs such as acquisitions, project financing, or to meet operational requirements.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/SyndicatedLoan">fibo-sec-dbt-dln:SyndicatedLoan</a>
    /// </summary>
    let SyndicatedLoan = _prefixId.prefix "SyndicatedLoan"
    /// <summary>
    ///   <para>rdfs:label : syndication agent</para>
    ///   <para>skos:definition : financial institution (typically a commercial or investment bank) designated to help structure, arrange, and manage the loan syndication process</para>
    ///   <para>cmns-av:explanatoryNote : Syndication agents are important at the beginning of the process, including setting up the syndicate, supporting distribution of the loan across lenders, marketing, and the like. They are far less involved in loan administration, which is managed by the administrative agent.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/SyndicationAgent">fibo-sec-dbt-dln:SyndicationAgent</a>
    /// </summary>
    let SyndicationAgent = _prefixId.prefix "SyndicationAgent"
