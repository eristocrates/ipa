#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-loan-reln-mtg`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/" "fibo-loan-reln-mtg"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : closed-end mortgage loan^^xsd:string</para>
    ///   <para>skos:definition : loan secured by real estate with no ability for the borrower to receive additional funds under the loan at a later date^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : MISMO Business Glossary, available at https://www.mismo.org/standards-resources/business-glossary/^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/ClosedEndMortgageLoan">fibo-loan-reln-mtg:ClosedEndMortgageLoan</a>
    /// </summary>
    let ClosedEndMortgageLoan = _prefixId.prefix "ClosedEndMortgageLoan"
    /// <summary>
    ///   <para>rdfs:label : closed-end reverse mortgage^^xsd:string</para>
    ///   <para>dcterms:source : Instructions for the Preparation of Consolidated Reports of Condition and Income, FFIEC 031 and FFIEC 041, Updated March 2023, clause A-91^^xsd:string</para>
    ///   <para>skos:definition : reverse mortgage that provides a lump sum payment to the borrower at closing, with no ability for the borrower to receive additional funds under the mortgage at a later date^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Normally, closed-end reverse mortgages are first liens.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/ClosedEndReverseMortgage">fibo-loan-reln-mtg:ClosedEndReverseMortgage</a>
    /// </summary>
    let ClosedEndReverseMortgage = _prefixId.prefix "ClosedEndReverseMortgage"
    /// <summary>
    ///   <para>rdfs:label : loan secured by real estate^^xsd:string</para>
    ///   <para>dcterms:source : Consolidated Reports of Condition and Income for a Bank with Domestic and Foreign Offices - FFIEC 031; Board of Governors of the Federal Reserve System OMB Number 7100-0036, Federal Deposit Insurance Corporation OMB Number 3064-0052, Office of the Comptroller of the Currency OMB Number 1557-0081, dated 20240930^^xsd:stringdcterms:source : Instructions for the Preparation of Consolidated Reports of Condition and Income, FFIEC 031 and FFIEC 041, Updated March 2023, clause A-91^^xsd:string</para>
    ///   <para>skos:definition : loan that, at origination, is secured wholly or substantially by a lien or liens on real property for which the lien or liens are central to the extension of the credit - that is, the borrower would not have been extended credit in the same amount or on terms as favorable without the lien or liens on real property^^xsd:string</para>
    ///   <para>skos:example : Examples include (a) Construction, land development, and other land loans: (1) 1-4 family residential construction loans, and (2) Other construction loans and all land development and other land loans; (b) Secured by farmland (including farm residential and other improvements); (c) Secured by 1-4 family residential properties: (1) Revolving, open-end loans secured by 1-4 family residential properties and extended under lines of credit, and (2) Closed-end loans secured by 1-4 family residential properties including those secured by first liens and those secured by junior liens; (d) Secured by multifamily (5 or more) residential properties; and (e) Secured by nonfarm nonresidential properties: (1) Loans secured by owner-occupied nonfarm nonresidential, and (2) Loans secured by other nonfarm nonresidential properties.</para>
    ///   <para>cmns-av:explanatoryNote : In general parlance, loans secured by real estate are often called mortgages or mortgage loans. This usage conflates a number of related concepts, which would limit the usability of FIBO for financial institutions and regulators with respect to such loans. As described herein, many different kinds of loans can be secured by real estate, including various commercial, construction, agricultural, and consumer loans.cmns-av:explanatoryNote : In the US, to be considered wholly or substantially secured by a lien or liens on real property, the estimated value of the real estate collateral at origination (after deducting any more senior liens held by others) must be greater than 50 percent of the principal amount of the loan at origination.cmns-av:explanatoryNote : The borrower agrees to pay the lender over time, typically in a series of regular payments divided into principal and interest. The property then serves as collateral to secure the loan.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/LoanSecuredByRealEstate">fibo-loan-reln-mtg:LoanSecuredByRealEstate</a>
    /// </summary>
    let LoanSecuredByRealEstate = _prefixId.prefix "LoanSecuredByRealEstate"
    /// <summary>
    ///   <para>rdfs:label : mortgage^^xsd:string</para>
    ///   <para>skos:definition : grant of financial interest in real property to a party that is not an owner of that real property and is recorded by a registration authority^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A mortgage prevents transfer of the ownership of the real property unless the financial interest is satisfied. Any loan can be collateralized by a mortgage, including, for example, a bail bond.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/Mortgage">fibo-loan-reln-mtg:Mortgage</a>
    /// </summary>
    let Mortgage = _prefixId.prefix "Mortgage"
    /// <summary>
    ///   <para>rdfs:label : open-end mortgage loan^^xsd:string</para>
    ///   <para>skos:definition : loan secured by real estate with a provision that the outstanding loan amount may be increased upon mutual agreement of the lender and the borrower^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : MISMO Business Glossary, available at https://www.mismo.org/standards-resources/business-glossary/^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/OpenEndMortgageLoan">fibo-loan-reln-mtg:OpenEndMortgageLoan</a>
    /// </summary>
    let OpenEndMortgageLoan = _prefixId.prefix "OpenEndMortgageLoan"
    /// <summary>
    ///   <para>rdfs:label : open-end reverse mortgage^^xsd:string</para>
    ///   <para>dcterms:source : Instructions for the Preparation of Consolidated Reports of Condition and Income, FFIEC 031 and FFIEC 041, Updated March 2023, clause A-91^^xsd:string</para>
    ///   <para>skos:definition : reverse mortgage structured like a home equity line of credit in that it provides the borrower with additional funds after closing (either as fixed monthly payments, under a line of credit, or both)^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Normally, open-end reverse mortgages are first liens. These include combinations of both a lump sum payment to the borrower at closing and payments after the closing of the loan.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/OpenEndReverseMortgage">fibo-loan-reln-mtg:OpenEndReverseMortgage</a>
    /// </summary>
    let OpenEndReverseMortgage = _prefixId.prefix "OpenEndReverseMortgage"
    /// <summary>
    ///   <para>rdfs:label : reverse mortgage loan^^xsd:string</para>
    ///   <para>skos:definition : loan secured by real estate that pays money to the borrower against a set principal limit based on the value of existing equity in the underlying collateral^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The interest accrued is added to the principal balance.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/ReverseMortgageLoan">fibo-loan-reln-mtg:ReverseMortgageLoan</a>
    /// </summary>
    let ReverseMortgageLoan = _prefixId.prefix "ReverseMortgageLoan"
    /// <summary>
    ///   <para>rdfs:label : has initial funding date^^xsd:string</para>
    ///   <para>skos:definition : relates a mortgage to the date on which the contract is consummated, officially creating the obligations therein^^xsd:string</para>
    ///   <para>cmns-av:synonym : has closing date^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/hasInitialFundingDate">fibo-loan-reln-mtg:hasInitialFundingDate</a>
    /// </summary>
    let hasInitialFundingDate = _prefixId.prefix "hasInitialFundingDate"
    /// <summary>
    ///   <para>rdfs:label : is ARM convertible</para>
    ///   <para>skos:definition : indicates whether or not the loan can be converted into an adjustable-rate mortgage contract (ARM)</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/isARMConvertible">fibo-loan-reln-mtg:isARMConvertible</a>
    /// </summary>
    let isARMConvertible = _prefixId.prefix "isARMConvertible"
