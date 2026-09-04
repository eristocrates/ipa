#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-loan-ln-ln`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/" "fibo-loan-ln-ln"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : closed-end credit^^xsd:string</para>
    ///   <para>skos:definition : credit agreement in which the loan principal cannot be increased after funds are dispersed in full when the loan closes^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The loan may require regular payments that pay down principal periodically, or it may require the full payment of principal at maturity.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/ClosedEndCredit">fibo-loan-ln-ln:ClosedEndCredit</a>
    /// </summary>
    let ClosedEndCredit = _prefixId.prefix "ClosedEndCredit"
    /// <summary>
    ///   <para>rdfs:label : collateralized loan</para>
    ///   <para>skos:definition : secured loan that is secured with cash or other acceptable collateral (real property, securities or other assets) provided by the borrower as specified in the collateral agreement</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fourth Edition, 2019.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/CollateralizedLoan">fibo-loan-ln-ln:CollateralizedLoan</a>
    /// </summary>
    let CollateralizedLoan = _prefixId.prefix "CollateralizedLoan"
    /// <summary>
    ///   <para>rdfs:label : co-maker^^xsd:string</para>
    ///   <para>skos:definition : party that signs a borrower's promissory note, providing additional security and potentially improving the quality of the debt^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Differences between a co-maker and co-borrower include: (1) a co-maker is not listed on the title of the asset to which the loan applies, (2) a co-maker does not have any legal ownership rights to the asset, and (3) the co-maker does not make regular payments on the loan unless the primary borrower(s) fails to do so.^^xsd:stringcmns-av:explanatoryNote : The co-maker's liability is similar to that of an endorser or guarantor, but with additional risk/exposure, as they can be compelled to honor the debt much sooner and regardless of whether certain conditions are met.^^xsd:string</para>
    ///   <para>cmns-av:synonym : comaker^^xsd:stringcmns-av:synonym : cosigner^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/Comaker">fibo-loan-ln-ln:Comaker</a>
    /// </summary>
    let Comaker = _prefixId.prefix "Comaker"
    /// <summary>
    ///   <para>rdfs:label : combined loan-to-value ratio^^xsd:string</para>
    ///   <para>skos:definition : ratio of the total amount of debt that is secured by the asset(s) and the appraised value of the asset(s) securing the financing^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This is particularly important for secondary loans, or for refinancing that combines outstanding loans against a given asset. Lenders use this ratio to evaluate the risk of extending a loan to a borrower(s) in cases where multiple loans are involved.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/CombinedLoanToValueRatio">fibo-loan-ln-ln:CombinedLoanToValueRatio</a>
    /// </summary>
    let CombinedLoanToValueRatio = _prefixId.prefix "CombinedLoanToValueRatio"
    let FeeSimpleOwnershipInterest = _prefixId.prefix "FeeSimpleOwnershipInterest"
    let FractionalOwnershipInterest = _prefixId.prefix "FractionalOwnershipInterest"
    /// <summary>
    ///   <para>rdfs:label : guaranteed loan</para>
    ///   <para>skos:definition : loan that is secured with respect to repayment of principal and interest by guaranty</para>
    ///   <para>cmns-av:explanatoryNote : A loan guarantee is a promise by one party to assume the debt obligation of a borrower if that borrower defaults. A guarantee can be limited or unlimited, making the guarantor liable for only a portion or all of the debt.cmns-av:explanatoryNote : In the U.S., the term 'guaranteed loan' typically refers to a loan that is backed by a federal agency, such as the Department of Veterans Affairs or the Small Business Administration. Student loans may be guaranteed by the Student Loan Marketing Association.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/GuaranteedLoan">fibo-loan-ln-ln:GuaranteedLoan</a>
    /// </summary>
    let GuaranteedLoan = _prefixId.prefix "GuaranteedLoan"
    /// <summary>
    ///   <para>rdfs:label : individual payment transaction</para>
    ///   <para>skos:definition : actual payment of principal, interest, fees, or other related amounts towards fulfillment of a debt obligation</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/IndividualPaymentTransaction">fibo-loan-ln-ln:IndividualPaymentTransaction</a>
    /// </summary>
    let IndividualPaymentTransaction = _prefixId.prefix "IndividualPaymentTransaction"
    /// <summary>
    ///   <para>rdfs:label : lender lien position^^xsd:string</para>
    ///   <para>skos:definition : classifier indicating whether the lender has the primary lien position with respect to an asset used as collateral for the loan^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/LenderLienPosition">fibo-loan-ln-ln:LenderLienPosition</a>
    /// </summary>
    let LenderLienPosition = _prefixId.prefix "LenderLienPosition"
    /// <summary>
    ///   <para>rdfs:label : loan^^xsd:string</para>
    ///   <para>skos:definition : debt instrument whereby one party extends money or credit to another party (or parties) with the understanding that the borrowed money will be repaid according to the terms of the contract^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/Loan">fibo-loan-ln-ln:Loan</a>
    /// </summary>
    let Loan = _prefixId.prefix "Loan"
    /// <summary>
    ///   <para>rdfs:label : loan payment schedule^^xsd:string</para>
    ///   <para>skos:definition : regular or explicit (ad hoc) payment schedule associated with a given loan-specific account^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Loan payment schedules may or may not be amortization schedules, i.e., they may or may not include principal.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/LoanPaymentSchedule">fibo-loan-ln-ln:LoanPaymentSchedule</a>
    /// </summary>
    let LoanPaymentSchedule = _prefixId.prefix "LoanPaymentSchedule"
    /// <summary>
    ///   <para>rdfs:label : loan-specific customer account^^xsd:string</para>
    ///   <para>skos:definition : account held by the borrower associated with a specific loan^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/LoanSpecificCustomerAccount">fibo-loan-ln-ln:LoanSpecificCustomerAccount</a>
    /// </summary>
    let LoanSpecificCustomerAccount = _prefixId.prefix "LoanSpecificCustomerAccount"
    /// <summary>
    ///   <para>rdfs:label : loan-to-value ratio^^xsd:string</para>
    ///   <para>skos:definition : ratio, expressed as a percentage, between the principal amount of the loan and the appraised value of the asset securing the financing^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : LTV^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/LoanToValueRatio">fibo-loan-ln-ln:LoanToValueRatio</a>
    /// </summary>
    let LoanToValueRatio = _prefixId.prefix "LoanToValueRatio"
    /// <summary>
    ///   <para>rdfs:label : open-end credit^^xsd:string</para>
    ///   <para>skos:definition : credit agreement that may be extended up to an agreed credit limit and paid down at any time within the period of the line, if any, and on which interest is charged only on the outstanding balance^^xsd:string</para>
    ///   <para>skos:example : Credit card and overdraft lines of credit are among the most widely used forms of open-end credit.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : There is a credit limit most of the time, with exceptions including reverse mortgages with tenure payment. The borrower has the option of paying off the outstanding balance, without penalty, or making installment payments.^^xsd:string</para>
    ///   <para>cmns-av:synonym : charge account credit^^xsd:stringcmns-av:synonym : revolving credit^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/OpenEndCredit">fibo-loan-ln-ln:OpenEndCredit</a>
    /// </summary>
    let OpenEndCredit = _prefixId.prefix "OpenEndCredit"
    /// <summary>
    ///   <para>rdfs:label : ownership interest^^xsd:string</para>
    ///   <para>skos:definition : classifier indicating the nature of the applicant's or borrower's ownership or leasehold interest in an asset used as collateral for the loan^^xsd:string</para>
    ///   <para>cmns-av:usageNote : Note that there are a number of variations for ownership interest that represent 'corner cases', including jurisdiction-specific variants, which can be added as needed for specific applications.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/OwnershipInterest">fibo-loan-ln-ln:OwnershipInterest</a>
    /// </summary>
    let OwnershipInterest = _prefixId.prefix "OwnershipInterest"
    /// <summary>
    ///   <para>rdfs:label : payment history^^xsd:string</para>
    ///   <para>skos:definition : record of actual payments of principal, interest, and other related amounts made by a borrower to a lender or servicer in order to fulfill their re-payment obligation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/PaymentHistory">fibo-loan-ln-ln:PaymentHistory</a>
    /// </summary>
    let PaymentHistory = _prefixId.prefix "PaymentHistory"
    /// <summary>
    ///   <para>rdfs:label : pre-payment terms</para>
    ///   <para>skos:definition : principal repayment terms related to payment of the loan prior to maturity</para>
    ///   <para>cmns-av:explanatoryNote : Prepayment may or may not involve refinancing with the same lender. Prepayment terms include any prepayment penalty period, penalty amount and whether or not there is provision for waiver of the penalty, and any conditions related to making additional payments or payments over and above the expected installment payment over the lifetime of the loan.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/PrepaymentTerms">fibo-loan-ln-ln:PrepaymentTerms</a>
    /// </summary>
    let PrepaymentTerms = _prefixId.prefix "PrepaymentTerms"
    let PrimaryLienPosition = _prefixId.prefix "PrimaryLienPosition"
    /// <summary>
    ///   <para>rdfs:label : secured loan^^xsd:string</para>
    ///   <para>skos:definition : loan in which the borrower pledges some asset via a security agreement as collateral for the loan, or that is secured via third-party guarantee^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/SecuredLoan">fibo-loan-ln-ln:SecuredLoan</a>
    /// </summary>
    let SecuredLoan = _prefixId.prefix "SecuredLoan"
    /// <summary>
    ///   <para>rdfs:label : servicer^^xsd:string</para>
    ///   <para>skos:definition : party that collects principal and interest payments on behalf of the lender^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In cases where a loan has been securitized, the servicer is also responsible for forwarding payments to investors, filing reports with credit-rating agencies and investors, and so forth.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/Servicer">fibo-loan-ln-ln:Servicer</a>
    /// </summary>
    let Servicer = _prefixId.prefix "Servicer"
    let SubordinateLienPosition = _prefixId.prefix "SubordinateLienPosition"
    /// <summary>
    ///   <para>rdfs:label : total outstanding principal^^xsd:string</para>
    ///   <para>skos:definition : the principal balance of all loans secured by the property^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/TotalOutstandingPrincipal">fibo-loan-ln-ln:TotalOutstandingPrincipal</a>
    /// </summary>
    let TotalOutstandingPrincipal = _prefixId.prefix "TotalOutstandingPrincipal"
    /// <summary>
    ///   <para>rdfs:label : unsecured loan^^xsd:string</para>
    ///   <para>skos:definition : loan granted based on the strength of the borrower's credit history or reputation in the community^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/UnsecuredLoan">fibo-loan-ln-ln:UnsecuredLoan</a>
    /// </summary>
    let UnsecuredLoan = _prefixId.prefix "UnsecuredLoan"
    /// <summary>
    ///   <para>rdfs:label : has balloon payment</para>
    ///   <para>skos:definition : indicates whether the contractual terms include or would have included repayment of the outstanding principal sum at the end of a loan period, prior to which only partial or no payments were made on the principal</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasBalloonPayment">fibo-loan-ln-ln:hasBalloonPayment</a>
    /// </summary>
    let hasBalloonPayment = _prefixId.prefix "hasBalloonPayment"
    /// <summary>
    ///   <para>rdfs:label : has cost^^xsd:string</para>
    ///   <para>skos:definition : has amount payable for principal, interest, fees or other expenses^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This can entail adding up other prices and/or fees (e.g. 4 units * a unit price)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasCost">fibo-loan-ln-ln:hasCost</a>
    /// </summary>
    let hasCost = _prefixId.prefix "hasCost"
    /// <summary>
    ///   <para>rdfs:label : has first rate change term^^xsd:string</para>
    ///   <para>skos:definition : specifies a period of time in months after origination during which the interest rate cannot change^^xsd:string</para>
    ///   <para>cmns-av:usageNote : This normally applies to a variable rate loan. It may also apply to step up/step down loans that are fixed rate but whose rate changes after a pre-determined number of months.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasFirstRateChangeTerm">fibo-loan-ln-ln:hasFirstRateChangeTerm</a>
    /// </summary>
    let hasFirstRateChangeTerm = _prefixId.prefix "hasFirstRateChangeTerm"
    /// <summary>
    ///   <para>rdfs:label : has individual payment^^xsd:string</para>
    ///   <para>skos:definition : links an actual payment of principal, interest, and other related amounts to the overall payment history for an account^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasIndividualPayment">fibo-loan-ln-ln:hasIndividualPayment</a>
    /// </summary>
    let hasIndividualPayment = _prefixId.prefix "hasIndividualPayment"
    /// <summary>
    ///   <para>rdfs:label : has loan balance^^xsd:string</para>
    ///   <para>skos:definition : indicates the balance with respect to the principal on the loan as of some date^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasLoanBalance">fibo-loan-ln-ln:hasLoanBalance</a>
    /// </summary>
    let hasLoanBalance = _prefixId.prefix "hasLoanBalance"
    /// <summary>
    ///   <para>rdfs:label : has negative amortization</para>
    ///   <para>skos:definition : indicates whether the contractual terms include or would have included a feature that allows unpaid interest to be added to the balance of unpaid principal</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasNegativeAmortization">fibo-loan-ln-ln:hasNegativeAmortization</a>
    /// </summary>
    let hasNegativeAmortization = _prefixId.prefix "hasNegativeAmortization"
    /// <summary>
    ///   <para>rdfs:label : has payment history^^xsd:string</para>
    ///   <para>skos:definition : relates a credit agreement, loan, or commitment to any history of payments that have been made by the borrower up to the point that payment history is requested^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasPaymentHistory">fibo-loan-ln-ln:hasPaymentHistory</a>
    /// </summary>
    let hasPaymentHistory = _prefixId.prefix "hasPaymentHistory"
    /// <summary>
    ///   <para>rdfs:label : has pre-payment penalty term^^xsd:string</para>
    ///   <para>skos:definition : relates a loan to a period of time in months after which there is no prepayment penalty^^xsd:string</para>
    ///   <para>cmns-av:usageNote : A value of zero means no prepayment penalty; this avoids need for a separate boolean property about whether there is a prepayment penalty^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasPrePaymentPenaltyTerm">fibo-loan-ln-ln:hasPrePaymentPenaltyTerm</a>
    /// </summary>
    let hasPrePaymentPenaltyTerm = _prefixId.prefix "hasPrePaymentPenaltyTerm"
    /// <summary>
    ///   <para>rdfs:label : has principal amount</para>
    ///   <para>skos:definition : indicates the nominal amount of the loan that must be paid at or before maturity</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasPrincipalAmount">fibo-loan-ln-ln:hasPrincipalAmount</a>
    /// </summary>
    let hasPrincipalAmount = _prefixId.prefix "hasPrincipalAmount"
    /// <summary>
    ///   <para>rdfs:label : has scheduled unpaid balance^^xsd:string</para>
    ///   <para>skos:definition : indicates what the balance should be after a scheduled payment is made according to contract terms^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasScheduledUnpaidBalance">fibo-loan-ln-ln:hasScheduledUnpaidBalance</a>
    /// </summary>
    let hasScheduledUnpaidBalance = _prefixId.prefix "hasScheduledUnpaidBalance"
    /// <summary>
    ///   <para>rdfs:label : has total closing costs^^xsd:string</para>
    ///   <para>skos:definition : indicates the total the amount paid at the closing of a real estate transaction, i.e., at the time when the title to the property is conveyed (transferred) to the buyer^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Closing costs may be incurred by either the buyer or the seller, and may include fees paid by either or both parties for the preparation and recording of documents, title service costs, such as for title search and insurance (typically paid by the seller, depending on the jurisdiction), other recording costs, other document or transaction stamps or taxes, brokerage commissions, survey, appraisal, inspection and other such fees, home warranties, private mortgage insurance (PMI), and so forth.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasTotalClosingCosts">fibo-loan-ln-ln:hasTotalClosingCosts</a>
    /// </summary>
    let hasTotalClosingCosts = _prefixId.prefix "hasTotalClosingCosts"
    /// <summary>
    ///   <para>rdfs:label : has total points and fees^^xsd:string</para>
    ///   <para>skos:definition : indicates a form of pre-paid interest, charged by the lender as an alternative to charging a higher rate of interest on the mortgage loan^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : One point equals one percent of the loan principal, and usually reduces the interest rate by 1/8 percent (0.125)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/hasTotalPointsAndFees">fibo-loan-ln-ln:hasTotalPointsAndFees</a>
    /// </summary>
    let hasTotalPointsAndFees = _prefixId.prefix "hasTotalPointsAndFees"
    /// <summary>
    ///   <para>rdfs:label : is assumable</para>
    ///   <para>skos:definition : indicates whether or not another borrower may assume the payments on this loan</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/isAssumable">fibo-loan-ln-ln:isAssumable</a>
    /// </summary>
    let isAssumable = _prefixId.prefix "isAssumable"
    /// <summary>
    ///   <para>rdfs:label : is initially payable</para>
    ///   <para>skos:definition : indicates whether the obligation arising from the covered loan was, or in the case of an application, would have been initially payable to the financial institution</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/isInitiallyPayable">fibo-loan-ln-ln:isInitiallyPayable</a>
    /// </summary>
    let isInitiallyPayable = _prefixId.prefix "isInitiallyPayable"
    /// <summary>
    ///   <para>rdfs:label : is interest only</para>
    ///   <para>skos:definition : indicates whether the contractual terms include or would have included interest only payments</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/isInterestOnly">fibo-loan-ln-ln:isInterestOnly</a>
    /// </summary>
    let isInterestOnly = _prefixId.prefix "isInterestOnly"
    /// <summary>
    ///   <para>rdfs:label : is performed by^^xsd:string</para>
    ///   <para>skos:definition : relates a loan to the financial service provider that services it^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/isServicedBy">fibo-loan-ln-ln:isServicedBy</a>
    /// </summary>
    let isServicedBy = _prefixId.prefix "isServicedBy"
