#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fbc-dae-dbt`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/" "fibo-fbc-dae-dbt"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : accrual^^xsd:string</para>
    ///   <para>skos:definition : the process of accumulating interest or other income that has been earned but not paid^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : There are legal contractual terms for the accrual of interest, as distinct from the payment of interest.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Accrual">fibo-fbc-dae-dbt:Accrual</a>
    /// </summary>
    let Accrual = _prefixId.prefix "Accrual"
    /// <summary>
    ///   <para>rdfs:label : accrued interest</para>
    ///   <para>skos:definition : amount of interest that has been incurred, as of a specific date, on a loan or other financial obligation but has not yet been paid out^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Accrued interest refers to the interest that has accumulated on a bond or other financial obligation since the last interest payment up to, but not including, the settlement date. This interest is earned over time but not yet paid out to the bondholder, for example. If this is a dirty price, this is the amount of accrued interest that is included in the price. This is therefore passed on to the purchaser of the bond or debt instrument.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/AccruedInterest">fibo-fbc-dae-dbt:AccruedInterest</a>
    /// </summary>
    let AccruedInterest = _prefixId.prefix "AccruedInterest"
    /// <summary>
    ///   <para>rdfs:label : amortization^^xsd:string</para>
    ///   <para>skos:definition : the process of reduction of debt or other costs through periodic charges to assets or liabilities, such as through principal payments on mortgages^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Amortization">fibo-fbc-dae-dbt:Amortization</a>
    /// </summary>
    let Amortization = _prefixId.prefix "Amortization"
    /// <summary>
    ///   <para>rdfs:label : amortization schedule^^xsd:string</para>
    ///   <para>skos:definition : schedule of periodic payments (repayment installments) that specify changes in the balance of the debt over time^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Payments are divided into equal amounts for the duration of the loan or debt instrument, making it the simplest repayment model. A greater amount of the payment is applied to interest at the beginning of the amortization schedule, while more money is applied to principal at the end.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/AmortizationSchedule">fibo-fbc-dae-dbt:AmortizationSchedule</a>
    /// </summary>
    let AmortizationSchedule = _prefixId.prefix "AmortizationSchedule"
    /// <summary>
    ///   <para>rdfs:label : borrower^^xsd:string</para>
    ///   <para>skos:definition : party to a credit agreement that is obligated to repay the amount borrowed (principal) with interest and other fees according to the terms of the instrument^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Borrower">fibo-fbc-dae-dbt:Borrower</a>
    /// </summary>
    let Borrower = _prefixId.prefix "Borrower"
    /// <summary>
    ///   <para>rdfs:label : borrower identification scheme^^xsd:string</para>
    ///   <para>skos:definition : system for allocating identifiers to borrowers^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Many banks and other financial institutions have internal systems for assigning identifiers to borrowers. In the United States, larger banks may use a Customer Information File (CIF) number, assigned as a part of their federally mandated Customer Information Program (CIP).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/BorrowerIdentificationScheme">fibo-fbc-dae-dbt:BorrowerIdentificationScheme</a>
    /// </summary>
    let BorrowerIdentificationScheme = _prefixId.prefix "BorrowerIdentificationScheme"
    /// <summary>
    ///   <para>rdfs:label : borrower identifier^^xsd:string</para>
    ///   <para>skos:definition : sequence of characters, capable of uniquely identifying a borrower^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A given identifier identifies a particular borrower with respect to at least some number of notes/facilities inside a particular institution according to some policy for minting identifiers. Optimally, there would be a single identifier for a given borrower, but due to operational issues, this is often not the case. A CIF number, or Customer Information File number, is used to link accounts across an institution to all notes/facilities owed by a given borrower.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/BorrowerIdentifier">fibo-fbc-dae-dbt:BorrowerIdentifier</a>
    /// </summary>
    let BorrowerIdentifier = _prefixId.prefix "BorrowerIdentifier"
    /// <summary>
    ///   <para>rdfs:label : borrowing capacity^^xsd:string</para>
    ///   <para>skos:definition : upper bound on the total amount of money that a lender believes a party has the ability to repay an obligation when due, as of some point in time^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The notion of borrowing capacity is related to management decisions pertaining to credit, i.e., the creditworthiness of the borrower, loan amount, risk tolerance, and so forth, and may be reassessed from time to time depending on the type of credit agreement and regulatory requirements. Determining borrowing capacity is typically done as a part of loan origination, especially for residential mortgages.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/BorrowingCapacity">fibo-fbc-dae-dbt:BorrowingCapacity</a>
    /// </summary>
    let BorrowingCapacity = _prefixId.prefix "BorrowingCapacity"
    /// <summary>
    ///   <para>rdfs:label : capital lease^^xsd:string</para>
    ///   <para>skos:definition : lease that must be reflected on an organization's balance sheet as an asset and as a corresponding liability^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In the United States, such leases must be reported per Statement 13 of the Financial Accounting Standards Board. Generally, this applies to leases where the lessee acquires essentially all of the economic benefits and risks of the leased property.^^xsd:string</para>
    ///   <para>cmns-av:synonym : financial lease^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CapitalLease">fibo-fbc-dae-dbt:CapitalLease</a>
    /// </summary>
    let CapitalLease = _prefixId.prefix "CapitalLease"
    /// <summary>
    ///   <para>rdfs:label : collateral^^xsd:string</para>
    ///   <para>skos:definition : something pledged as security to ensure fulfillment of an obligation to another party, to lend money, extend credit, or provision securities^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Collateral">fibo-fbc-dae-dbt:Collateral</a>
    /// </summary>
    let Collateral = _prefixId.prefix "Collateral"
    /// <summary>
    ///   <para>rdfs:label : collateral value as of date^^xsd:string</para>
    ///   <para>skos:definition : appraised value of the collateral for an obligation as of a given date^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CollateralValueAsOfDate">fibo-fbc-dae-dbt:CollateralValueAsOfDate</a>
    /// </summary>
    let CollateralValueAsOfDate = _prefixId.prefix "CollateralValueAsOfDate"
    /// <summary>
    ///   <para>rdfs:label : committed credit facility</para>
    ///   <para>skos:definition : credit facility that is a confirmed source of financing for the borrower, as long as the borrower meets the conditions of the agreement</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CommittedCreditFacility">fibo-fbc-dae-dbt:CommittedCreditFacility</a>
    /// </summary>
    let CommittedCreditFacility = _prefixId.prefix "CommittedCreditFacility"
    /// <summary>
    ///   <para>rdfs:label : committed sub-facility</para>
    ///   <para>skos:definition : contractually committed portion of a credit facility that is available to the borrower and may be associated with some specific collateral</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CommittedSubFacility">fibo-fbc-dae-dbt:CommittedSubFacility</a>
    /// </summary>
    let CommittedSubFacility = _prefixId.prefix "CommittedSubFacility"
    /// <summary>
    ///   <para>rdfs:label : credit agreement^^xsd:string</para>
    ///   <para>skos:definition : contractual agreement in which a debtor receives something of value and typically agrees to repay the creditor by some date in the future, in some form (e.g., cash, securities, etc.), generally with interest^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditAgreement">fibo-fbc-dae-dbt:CreditAgreement</a>
    /// </summary>
    let CreditAgreement = _prefixId.prefix "CreditAgreement"

    /// <summary>
    ///   <para>rdfs:label : credit agreement repaid at maturity^^xsd:string</para>
    ///   <para>skos:definition : credit agreement in which accrued interest may be periodically repaid or paid at maturity, but principal is paid at maturity^^xsd:string</para>
    ///   <para>skos:example : The most common example of a credit agreement repaid at maturity is a bond.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditAgreementRepaidAtMaturity">fibo-fbc-dae-dbt:CreditAgreementRepaidAtMaturity</a>
    /// </summary>
    let CreditAgreementRepaidAtMaturity =
        _prefixId.prefix "CreditAgreementRepaidAtMaturity"

    /// <summary>
    ///   <para>rdfs:label : credit agreement repaid periodically^^xsd:string</para>
    ///   <para>skos:definition : credit agreement in which the principal and accrued interest may be periodically repaid or exchanged^^xsd:string</para>
    ///   <para>skos:example : Examples include revolving lines of credit, commercial loans, construction loans, residential mortgages and so forth.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditAgreementRepaidPeriodically">fibo-fbc-dae-dbt:CreditAgreementRepaidPeriodically</a>
    /// </summary>
    let CreditAgreementRepaidPeriodically =
        _prefixId.prefix "CreditAgreementRepaidPeriodically"

    /// <summary>
    ///   <para>rdfs:label : credit enhancement agreement</para>
    ///   <para>skos:definition : collateral agreement that governs the exchange of collateral between parties to mitigate counterparty credit risk</para>
    ///   <para>cmns-av:explanatoryNote : A credit enhancement agreement ensures that collateral or a guarantee is established to secure obligations under the agreement. Features may include specification of the kinds of collateral or guarantee that may be used together with the relevant valuation methods, thresholds for the value of the collateral and haircuts applied based on mitigating market risk, margin requirements, dispute resolution with respect to collateral valuation and margin calls, and other operational details related to the transfer, substitution, and return of the collateral if established or posted.</para>
    ///   <para>cmns-av:synonym : collateralizationcmns-av:synonym : credit support agreementcmns-av:synonym : financial collateral arrangementcmns-av:synonym : margin arrangement</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditEnhancementAgreement">fibo-fbc-dae-dbt:CreditEnhancementAgreement</a>
    /// </summary>
    let CreditEnhancementAgreement = _prefixId.prefix "CreditEnhancementAgreement"
    /// <summary>
    ///   <para>rdfs:label : credit enhancement beneficiary</para>
    ///   <para>skos:definition : party that benefits from the collateral or guarantee established under the agreement, i.e., that is protected against counterparty credit risk because the collateral or guarantee serves as security for the obligation(s) owed to them</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditEnhancementBeneficiary">fibo-fbc-dae-dbt:CreditEnhancementBeneficiary</a>
    /// </summary>
    let CreditEnhancementBeneficiary = _prefixId.prefix "CreditEnhancementBeneficiary"
    /// <summary>
    ///   <para>rdfs:label : credit facility</para>
    ///   <para>skos:definition : credit agreement that allows the borrower to periodically take out money over an extended period of time rather than reapplying for a loan every time they need funds</para>
    ///   <para>cmns-av:explanatoryNote : Credit facilities include revolving loans/lines of credit, committed facilities, letters of credit, and most retail credit accounts. They may define sub-facilities to which the lender is prepared to commit for specific purposes.</para>
    ///   <para>cmns-av:synonym : master commitment</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/CreditFacility">fibo-fbc-dae-dbt:CreditFacility</a>
    /// </summary>
    let CreditFacility = _prefixId.prefix "CreditFacility"
    /// <summary>
    ///   <para>rdfs:label : creditor^^xsd:string</para>
    ///   <para>skos:definition : a party to whom an obligation, such as an amount of money, or good, or performance of some service exists^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Creditor">fibo-fbc-dae-dbt:Creditor</a>
    /// </summary>
    let Creditor = _prefixId.prefix "Creditor"
    /// <summary>
    ///   <para>rdfs:label : day-count convention^^xsd:string</para>
    ///   <para>skos:definition : a business recurrence interval convention that is used to calculate the number of days in an interest payment, which applies to the amount of accrued interest or the present value for debt instruments^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Day-count conventions apply to swaps, mortgages and forward rate agreements as well as bonds, each of which has its own day-count convention, which varies depending on the type of instrument, whether the interest rate is fixed or floating, and the country of issuance. Among the most common conventions are 30/360 or 365, actual/360 or 365, and actual/actual. A 30/360 convention assumes 30 days in a month and 360 days in a year. An actual/360 convention assumes the actual number of days in the given month and 360 days in the year. An actual/ actual convention uses the actual number of days in the given interest period and year.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DayCountConvention">fibo-fbc-dae-dbt:DayCountConvention</a>
    /// </summary>
    let DayCountConvention = _prefixId.prefix "DayCountConvention"

    let DayCountConvention_30360BondBasis =
        _prefixId.prefix "DayCountConvention-30360BondBasis"

    let DayCountConvention_30360US = _prefixId.prefix "DayCountConvention-30360US"
    let DayCountConvention_30365 = _prefixId.prefix "DayCountConvention-30365"
    let DayCountConvention_30E360 = _prefixId.prefix "DayCountConvention-30E360"
    let DayCountConvention_30E360ISDA = _prefixId.prefix "DayCountConvention-30E360ISDA"
    let DayCountConvention_Actual360 = _prefixId.prefix "DayCountConvention-Actual360"

    let DayCountConvention_Actual365Fixed =
        _prefixId.prefix "DayCountConvention-Actual365Fixed"

    let DayCountConvention_ActualActualICMA =
        _prefixId.prefix "DayCountConvention-ActualActualICMA"

    let DayCountConvention_ActualActualISDA =
        _prefixId.prefix "DayCountConvention-ActualActualISDA"

    /// <summary>
    ///   <para>rdfs:label : debt^^xsd:string</para>
    ///   <para>skos:definition : obligation to pay something, such as an amount of money, good, service, or instrument^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In cases where the debtor and payer are the same legal person, then a debt is equivalent to a payment obligation.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Debt">fibo-fbc-dae-dbt:Debt</a>
    /// </summary>
    let Debt = _prefixId.prefix "Debt"
    /// <summary>
    ///   <para>rdfs:label : debt terms^^xsd:string</para>
    ///   <para>skos:definition : contract terms that specify the formal rights and obligations of borrower and lender under a contract in which funds are lent from the one party to the other^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : These may be terms in a loan contract (including for example a mortgage contract) or they may be the contractual terms of a debt security.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/DebtTerms">fibo-fbc-dae-dbt:DebtTerms</a>
    /// </summary>
    let DebtTerms = _prefixId.prefix "DebtTerms"
    /// <summary>
    ///   <para>rdfs:label : debtor^^xsd:string</para>
    ///   <para>skos:definition : a party that owes a debt or other obligation to another party^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Debtor">fibo-fbc-dae-dbt:Debtor</a>
    /// </summary>
    let Debtor = _prefixId.prefix "Debtor"
    /// <summary>
    ///   <para>rdfs:label : explicit contract event schedule^^xsd:string</para>
    ///   <para>skos:definition : schedule of events, including but not limited to payment events, rate reset events and others that will occur over the lifetime of the credit agreement^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This is a schedule of actual dates and events that are terms of the contract.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/ExplicitContractEventSchedule">fibo-fbc-dae-dbt:ExplicitContractEventSchedule</a>
    /// </summary>
    let ExplicitContractEventSchedule = _prefixId.prefix "ExplicitContractEventSchedule"
    /// <summary>
    ///   <para>rdfs:label : fixed interest rate^^xsd:string</para>
    ///   <para>skos:definition : interest rate that does not fluctuate over the lifetime of a loan or other debt instrument^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/FixedInterestRate">fibo-fbc-dae-dbt:FixedInterestRate</a>
    /// </summary>
    let FixedInterestRate = _prefixId.prefix "FixedInterestRate"
    /// <summary>
    ///   <para>rdfs:label : floating interest rate^^xsd:string</para>
    ///   <para>skos:definition : variable interest rate that is based on a specific index or benchmark rate^^xsd:string</para>
    ///   <para>skos:example : Certain revolving credit, such as credit-card related debt, may adjust after a specified period of time to an absolute rate stated in the agreement (variable but not floating) rather than based on a benchmark rate (variable, floating).^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The index used to determine the specific interest rate is generally included in the terms of the loan. In most cases, lenders will also charge a spread, or added percentage points on top of the established index rate. If a loan is billed as prime plus 2.5 percent, for a prime rate of 3.5 percent, the terms of the loan will require the borrower to pay off a 6 percent interest. Floating interest rates typically involve periodic reset dates for the loan, particularly when the index rate changes. Resets may also occur online at market predetermined intervals, with yearly adjustments being a common arrangement.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/FloatingInterestRate">fibo-fbc-dae-dbt:FloatingInterestRate</a>
    /// </summary>
    let FloatingInterestRate = _prefixId.prefix "FloatingInterestRate"
    /// <summary>
    ///   <para>rdfs:label : full amortization^^xsd:string</para>
    ///   <para>skos:definition : amortization in which the very last payment (which, if the schedule was calculated correctly, should be equal to all others) pays off all remaining principal and interest on the loan^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/FullAmortization">fibo-fbc-dae-dbt:FullAmortization</a>
    /// </summary>
    let FullAmortization = _prefixId.prefix "FullAmortization"
    /// <summary>
    ///   <para>rdfs:label : interest^^xsd:string</para>
    ///   <para>skos:definition : the cost of using credit, or another's money, expressed as a rate per period of time, payable by a debtor to a creditor in consideration of the credit extended to the debtor^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Interest">fibo-fbc-dae-dbt:Interest</a>
    /// </summary>
    let Interest = _prefixId.prefix "Interest"
    /// <summary>
    ///   <para>rdfs:label : interest calculation^^xsd:string</para>
    ///   <para>skos:definition : event reflecting the calculation of interest^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestCalculation">fibo-fbc-dae-dbt:InterestCalculation</a>
    /// </summary>
    let InterestCalculation = _prefixId.prefix "InterestCalculation"
    /// <summary>
    ///   <para>rdfs:label : interest calculation schedule^^xsd:string</para>
    ///   <para>skos:definition : regular, contract-specific schedule including the dates on which interest is calculated^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The dates may be fixed, or relative to the corresponding interest payment date. It may be the same as the payment date, in arrears, or forward looking to the next interest payment.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestCalculationSchedule">fibo-fbc-dae-dbt:InterestCalculationSchedule</a>
    /// </summary>
    let InterestCalculationSchedule = _prefixId.prefix "InterestCalculationSchedule"
    /// <summary>
    ///   <para>rdfs:label : interest payment^^xsd:string</para>
    ///   <para>skos:definition : event reflecting the actual payment of interest^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestPayment">fibo-fbc-dae-dbt:InterestPayment</a>
    /// </summary>
    let InterestPayment = _prefixId.prefix "InterestPayment"
    /// <summary>
    ///   <para>rdfs:label : interest payment schedule^^xsd:string</para>
    ///   <para>skos:definition : regular, contract-specific schedule including the dates on which interest is due to be paid^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The dates may be fixed, or expressed as an offset of the calculation dates. Typically the payment dates are fixed and calculation dates are expressed as an offset, however.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestPaymentSchedule">fibo-fbc-dae-dbt:InterestPaymentSchedule</a>
    /// </summary>
    let InterestPaymentSchedule = _prefixId.prefix "InterestPaymentSchedule"
    /// <summary>
    ///   <para>rdfs:label : interest payment terms^^xsd:string</para>
    ///   <para>skos:definition : contract terms for payment of interest on a debt^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Interest is usually payable on any outstanding principal amount, therefore interest relates to the amount of debt outstanding at any given point of time, not to the principal amount advanced at the time that the loan was advanced or the debt security issued (aside from the initial payment).^^xsd:stringcmns-av:explanatoryNote : Note that in most cases, the dates and payment frequencies for interest will coincide with the dates and payment frequencies related to the principal.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestPaymentTerms">fibo-fbc-dae-dbt:InterestPaymentTerms</a>
    /// </summary>
    let InterestPaymentTerms = _prefixId.prefix "InterestPaymentTerms"
    /// <summary>
    ///   <para>rdfs:label : interest rate reset^^xsd:string</para>
    ///   <para>skos:definition : event reflecting a potential adjustment to an interest rate, typically corresponding to a change in the underlying benchmark interest rate or index specified in the contract^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that depending on the contract, a rate reset can occur daily or on some other timetable, and depending on the underlying benchmark, the actual rate may or may not change. Rate resets may be associated with variable interest rate loans, scheduled reset dates for loans and other debt instruments, for example, interest rate swaps, certain kinds of bonds, and the like. The date on which interest is (re)calculated may be an explicit or date relative.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestRateReset">fibo-fbc-dae-dbt:InterestRateReset</a>
    /// </summary>
    let InterestRateReset = _prefixId.prefix "InterestRateReset"
    /// <summary>
    ///   <para>rdfs:label : interest rate reset schedule^^xsd:string</para>
    ///   <para>skos:definition : regular, contract-specific schedule including the dates on which a rate reset, and corresponding actual rate, is recalculated^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestRateResetSchedule">fibo-fbc-dae-dbt:InterestRateResetSchedule</a>
    /// </summary>
    let InterestRateResetSchedule = _prefixId.prefix "InterestRateResetSchedule"
    /// <summary>
    ///   <para>rdfs:label : interest rate setting event^^xsd:string</para>
    ///   <para>skos:definition : event on which an initial rate for a given contract is set, which may be relative the the occurrence of some other contract lifecycle event, such as the execution date^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/InterestRateSettingEvent">fibo-fbc-dae-dbt:InterestRateSettingEvent</a>
    /// </summary>
    let InterestRateSettingEvent = _prefixId.prefix "InterestRateSettingEvent"
    /// <summary>
    ///   <para>rdfs:label : lease^^xsd:string</para>
    ///   <para>skos:definition : credit agreement permitting the use of real estate, equipment or another asset, such as a vehicle, by the owner of that asset (the lessor) to a user (the lessee) for a specific period of time in return for payment as specified in the agreement^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The lessor is the legal owner of the asset, while the lessee obtains the right to use the asset in return for rental payments. The lessee also agrees to abide by various conditions regarding their use of the property or equipment. For example, a person leasing a car may agree to the condition that the car will only be used for personal use.^^xsd:string</para>
    ///   <para>cmns-av:synonym : lease agreement^^xsd:stringcmns-av:synonym : lease contract^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Lease">fibo-fbc-dae-dbt:Lease</a>
    /// </summary>
    let Lease = _prefixId.prefix "Lease"
    /// <summary>
    ///   <para>rdfs:label : lender^^xsd:string</para>
    ///   <para>skos:definition : a party that extends credit or money to a borrower with the expectation of being repaid, usually with interest^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Lender">fibo-fbc-dae-dbt:Lender</a>
    /// </summary>
    let Lender = _prefixId.prefix "Lender"
    /// <summary>
    ///   <para>rdfs:label : managed interest rate^^xsd:string</para>
    ///   <para>skos:definition : variable interest rate charged by a financial institution for borrowing that is not prescribed as a margin over base rate but is set from time to time by the institution^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/ManagedInterestRate">fibo-fbc-dae-dbt:ManagedInterestRate</a>
    /// </summary>
    let ManagedInterestRate = _prefixId.prefix "ManagedInterestRate"
    /// <summary>
    ///   <para>rdfs:label : motor vehicle lease^^xsd:string</para>
    ///   <para>skos:definition : lease of a motor vehicle for a fixed period of time at an agreed amount of money^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Motor vehicle leasing is commonly offered by dealers as an alternative to a vehicle purchase but is widely used by businesses as a method of acquiring (or having the use of) vehicles for business use, without the usually needed cash outlay. The key difference in a lease is that after the primary term (usually 2, 3 or 4 years) the vehicle has to either be returned to the leasing company or purchased for the residual value.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/MotorVehicleLease">fibo-fbc-dae-dbt:MotorVehicleLease</a>
    /// </summary>
    let MotorVehicleLease = _prefixId.prefix "MotorVehicleLease"
    /// <summary>
    ///   <para>rdfs:label : negative amortization^^xsd:string</para>
    ///   <para>skos:definition : amortization in which the payments made do not cover the interest due^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/NegativeAmortization">fibo-fbc-dae-dbt:NegativeAmortization</a>
    /// </summary>
    let NegativeAmortization = _prefixId.prefix "NegativeAmortization"
    /// <summary>
    ///   <para>rdfs:label : non-physical collateral^^xsd:string</para>
    ///   <para>skos:definition : asset pledged as collateral that is a financial asset, rather than physical asset^^xsd:string</para>
    ///   <para>skos:example : Examples of non-physical collateral include, but are not limited to, bank deposits, accounts receivable, stocks, bonds, other securities, and the like.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/NonPhysicalCollateral">fibo-fbc-dae-dbt:NonPhysicalCollateral</a>
    /// </summary>
    let NonPhysicalCollateral = _prefixId.prefix "NonPhysicalCollateral"
    /// <summary>
    ///   <para>rdfs:label : partial amortization^^xsd:string</para>
    ///   <para>skos:definition : amortization in which the very last payment the last payment due may be a large balloon payment of all remaining principal and interest^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PartialAmortization">fibo-fbc-dae-dbt:PartialAmortization</a>
    /// </summary>
    let PartialAmortization = _prefixId.prefix "PartialAmortization"
    /// <summary>
    ///   <para>rdfs:label : physical collateral^^xsd:string</para>
    ///   <para>skos:definition : asset pledged as collateral that has a material form, i.e., is a physical asset of the obligor^^xsd:string</para>
    ///   <para>skos:example : Examples of physical collateral include, but are not limited to, real estate, equipment, vehicles, spare parts, inventory, goods, supplies, fixtures, and leasehold improvements.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PhysicalCollateral">fibo-fbc-dae-dbt:PhysicalCollateral</a>
    /// </summary>
    let PhysicalCollateral = _prefixId.prefix "PhysicalCollateral"
    /// <summary>
    ///   <para>rdfs:label : principal^^xsd:string</para>
    ///   <para>skos:definition : with respect to a debt: the value of an obligation, such as a bond or loan, raised and that must be repaid at maturity; for investments: the original amount of money invested, separate from any associated interest, dividends or capital gains^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/Principal">fibo-fbc-dae-dbt:Principal</a>
    /// </summary>
    let Principal = _prefixId.prefix "Principal"
    /// <summary>
    ///   <para>rdfs:label : principal payment^^xsd:string</para>
    ///   <para>skos:definition : event reflecting the actual payment of some amount of the principal of a debt^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PrincipalPayment">fibo-fbc-dae-dbt:PrincipalPayment</a>
    /// </summary>
    let PrincipalPayment = _prefixId.prefix "PrincipalPayment"
    /// <summary>
    ///   <para>rdfs:label : principal payment schedule^^xsd:string</para>
    ///   <para>skos:definition : regular, contract-specific schedule including the dates on which some percentage or all of the principal is due to be (re)paid^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The dates may be fixed, or expressed as an offset of the calculation dates. Typically the payment dates are fixed and calculation dates are expressed as an offset, however.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PrincipalPaymentSchedule">fibo-fbc-dae-dbt:PrincipalPaymentSchedule</a>
    /// </summary>
    let PrincipalPaymentSchedule = _prefixId.prefix "PrincipalPaymentSchedule"
    /// <summary>
    ///   <para>rdfs:label : principal repayment terms^^xsd:string</para>
    ///   <para>skos:definition : contract terms that specify requirements for repayment of the principal^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/PrincipalRepaymentTerms">fibo-fbc-dae-dbt:PrincipalRepaymentTerms</a>
    /// </summary>
    let PrincipalRepaymentTerms = _prefixId.prefix "PrincipalRepaymentTerms"

    /// <summary>
    ///   <para>rdfs:label : projected contract event schedule^^xsd:string</para>
    ///   <para>skos:definition : schedule of events, including but not limited to anticipated payment events, rate reset events and others that are expected to occur over the lifetime of the contract^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A projected schedule is a regular schedule that documents the anchor dates and frequency of occurrences, using rules, rather than providing an explicit list of dates. This method will project future event dates (transaction event dates), based on the frequencies specified and may be adjusted due to calendar restrictions and other rules to deal with holidays, weekends, and so forth in addition to contract-specific events.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/ProjectedContractEventSchedule">fibo-fbc-dae-dbt:ProjectedContractEventSchedule</a>
    /// </summary>
    let ProjectedContractEventSchedule =
        _prefixId.prefix "ProjectedContractEventSchedule"

    /// <summary>
    ///   <para>rdfs:label : rate reset time of day^^xsd:string</para>
    ///   <para>skos:definition : time of day that an interest rate is reset, as indicated by some interest rate authority or market data provider^^xsd:string</para>
    ///   <para>skos:example : Examples include certain rates published by the Federal Reserve Board in their H.15 schedule, which are published at 4:15 pm on business days that are not holidays in the US.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/RateResetTimeOfDay">fibo-fbc-dae-dbt:RateResetTimeOfDay</a>
    /// </summary>
    let RateResetTimeOfDay = _prefixId.prefix "RateResetTimeOfDay"
    /// <summary>
    ///   <para>rdfs:label : retail credit facility</para>
    ///   <para>skos:definition : credit facility that is a loan or line of credit used by retailers and real estate companies</para>
    ///   <para>skos:example : Most consumer credit cards are retail credit facilities, for example.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/RetailCreditFacility">fibo-fbc-dae-dbt:RetailCreditFacility</a>
    /// </summary>
    let RetailCreditFacility = _prefixId.prefix "RetailCreditFacility"
    /// <summary>
    ///   <para>rdfs:label : revolving line of credit</para>
    ///   <para>skos:definition : credit facility that enables the borrower to withdraw funds, repay, and withdraw again</para>
    ///   <para>cmns-av:explanatoryNote : Revolving credit facilities are essentially lines of credit with variable interest rates.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/RevolvingLineOfCredit">fibo-fbc-dae-dbt:RevolvingLineOfCredit</a>
    /// </summary>
    let RevolvingLineOfCredit = _prefixId.prefix "RevolvingLineOfCredit"
    /// <summary>
    ///   <para>rdfs:label : security agreement^^xsd:string</para>
    ///   <para>skos:definition : collateral agreement that grants a financial interest in some collateral to a party that is not an owner of that collateral, specifying terms including relative duties and rights, over and above those specified in the primary contract, regarding the disposition of the asset used as collateral^^xsd:string</para>
    ///   <para>skos:example : Examples include deeds of trust and uniform commercial code (UCC) agreements.^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : ISO 20022^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/SecurityAgreement">fibo-fbc-dae-dbt:SecurityAgreement</a>
    /// </summary>
    let SecurityAgreement = _prefixId.prefix "SecurityAgreement"
    /// <summary>
    ///   <para>rdfs:label : sub-facility</para>
    ///   <para>skos:definition : portion of a credit facility extended to the borrower for some purpose, possibly per some schedule specified in the facility</para>
    ///   <para>cmns-av:explanatoryNote : Each sub-facility may have separate terms, and may be or include individual promissory notes, depending on the facility. The amount of associated with the individual sub-facilities sums to the total credit facility amount. Sub-facilities may, individually, have a stated purpose, such as to cover inventory, equipment, accounts receivable, working capital, letters of credit, and so forth.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/SubFacility">fibo-fbc-dae-dbt:SubFacility</a>
    /// </summary>
    let SubFacility = _prefixId.prefix "SubFacility"
    /// <summary>
    ///   <para>rdfs:label : uncommitted credit facility</para>
    ///   <para>skos:definition : credit facility that has yet to be confirmed as a source of financing for the borrower</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/UncommittedCreditFacility">fibo-fbc-dae-dbt:UncommittedCreditFacility</a>
    /// </summary>
    let UncommittedCreditFacility = _prefixId.prefix "UncommittedCreditFacility"
    /// <summary>
    ///   <para>rdfs:label : uncommitted sub-facility</para>
    ///   <para>skos:definition : sub-facility that has yet to be confirmed as a source of financing for the borrower</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/UncommittedSubFacility">fibo-fbc-dae-dbt:UncommittedSubFacility</a>
    /// </summary>
    let UncommittedSubFacility = _prefixId.prefix "UncommittedSubFacility"
    /// <summary>
    ///   <para>rdfs:label : variable interest rate^^xsd:string</para>
    ///   <para>skos:definition : an interest rate that is allowed to vary over the maturity of a loan or other debt instrument^^xsd:string</para>
    ///   <para>cmns-av:synonym : adjustable rate^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/VariableInterestRate">fibo-fbc-dae-dbt:VariableInterestRate</a>
    /// </summary>
    let VariableInterestRate = _prefixId.prefix "VariableInterestRate"
    /// <summary>
    ///   <para>rdfs:label : governs payment of^^xsd:string</para>
    ///   <para>skos:definition : links contractual terms embedded in a contract, such as interest or repayment terms to the element those terms apply to^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/governsPaymentOf">fibo-fbc-dae-dbt:governsPaymentOf</a>
    /// </summary>
    let governsPaymentOf = _prefixId.prefix "governsPaymentOf"
    /// <summary>
    ///   <para>rdfs:label : has accrual basis^^xsd:string</para>
    ///   <para>skos:definition : identifies the convention that defines how interest accrues on something, that is the number of days in a month and days in a year that are counted when performing interest accrual calculations^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasAccrualBasis">fibo-fbc-dae-dbt:hasAccrualBasis</a>
    /// </summary>
    let hasAccrualBasis = _prefixId.prefix "hasAccrualBasis"
    /// <summary>
    ///   <para>rdfs:label : has amount of credit extended^^xsd:string</para>
    ///   <para>skos:definition : specifies the gross amount of credit that has been provided to the borrower as of a given point in time with respect to a specific agreement (e.g. for line of credit)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasAmountOfCreditExtended">fibo-fbc-dae-dbt:hasAmountOfCreditExtended</a>
    /// </summary>
    let hasAmountOfCreditExtended = _prefixId.prefix "hasAmountOfCreditExtended"

    /// <summary>
    ///   <para>rdfs:label : has anticipated number of payments^^xsd:string</para>
    ///   <para>skos:definition : specifies the number of payments promised per the terms of the contract over the lifetime of the contract assuming all payments are made^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasAnticipatedNumberOfPayments">fibo-fbc-dae-dbt:hasAnticipatedNumberOfPayments</a>
    /// </summary>
    let hasAnticipatedNumberOfPayments =
        _prefixId.prefix "hasAnticipatedNumberOfPayments"

    /// <summary>
    ///   <para>rdfs:label : has available amount^^xsd:string</para>
    ///   <para>skos:definition : indicates an amount of money available for an individual or organization to borrow^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasAvailableAmount">fibo-fbc-dae-dbt:hasAvailableAmount</a>
    /// </summary>
    let hasAvailableAmount = _prefixId.prefix "hasAvailableAmount"
    /// <summary>
    ///   <para>rdfs:label : has borrower^^xsd:string</para>
    ///   <para>skos:definition : relates a contract, such as a debt instrument or credit agreement, to one or more parties that are incurring the debt^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasBorrower">fibo-fbc-dae-dbt:hasBorrower</a>
    /// </summary>
    let hasBorrower = _prefixId.prefix "hasBorrower"
    /// <summary>
    ///   <para>rdfs:label : has compounding frequency^^xsd:string</para>
    ///   <para>skos:definition : the frequency at which interest is added to the principal of the debt over the course of the agreement^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasCompoundingFrequency">fibo-fbc-dae-dbt:hasCompoundingFrequency</a>
    /// </summary>
    let hasCompoundingFrequency = _prefixId.prefix "hasCompoundingFrequency"
    /// <summary>
    ///   <para>rdfs:label : has credit limit^^xsd:string</para>
    ///   <para>skos:definition : specifies the maximum amount of credit that may be borrowed with respect to a specific agreement (e.g. for line of credit)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasCreditLimit">fibo-fbc-dae-dbt:hasCreditLimit</a>
    /// </summary>
    let hasCreditLimit = _prefixId.prefix "hasCreditLimit"
    /// <summary>
    ///   <para>rdfs:label : has debt amount^^xsd:string</para>
    ///   <para>skos:definition : indicates the monetary amount of the debt^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Represents the total debt amount including principal and interest^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasDebtAmount">fibo-fbc-dae-dbt:hasDebtAmount</a>
    /// </summary>
    let hasDebtAmount = _prefixId.prefix "hasDebtAmount"
    /// <summary>
    ///   <para>rdfs:label : has denomination^^xsd:string</para>
    ///   <para>skos:definition : the face value of currency units, coins, or securities^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasDenomination">fibo-fbc-dae-dbt:hasDenomination</a>
    /// </summary>
    let hasDenomination = _prefixId.prefix "hasDenomination"
    /// <summary>
    ///   <para>rdfs:label : has final interest payment date^^xsd:string</para>
    ///   <para>skos:definition : the date on which the last interest payment is due^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasFinalInterestPaymentDate">fibo-fbc-dae-dbt:hasFinalInterestPaymentDate</a>
    /// </summary>
    let hasFinalInterestPaymentDate = _prefixId.prefix "hasFinalInterestPaymentDate"
    /// <summary>
    ///   <para>rdfs:label : has initial exchange date^^xsd:string</para>
    ///   <para>skos:definition : indicates the specific date when the initial exchange of assets or funds takes place^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : IED^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : For a credit agreement, this is the initial funding date, such as the funding of the principal amount, or a portion thereof, but for other kinds of instruments, it may be something else. In the context of contracts related to swaps, options, or other derivative instruments, the initial exchange date marks the point where the parties legally commit to the terms of the agreement and exchange the initial required amounts.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInitialExchangeDate">fibo-fbc-dae-dbt:hasInitialExchangeDate</a>
    /// </summary>
    let hasInitialExchangeDate = _prefixId.prefix "hasInitialExchangeDate"
    /// <summary>
    ///   <para>rdfs:label : has initial interest accrual date^^xsd:string</para>
    ///   <para>skos:definition : the date from which interest begins to accrue^^xsd:string</para>
    ///   <para>cmns-av:synonym : has dated date^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInitialInterestAccrualDate">fibo-fbc-dae-dbt:hasInitialInterestAccrualDate</a>
    /// </summary>
    let hasInitialInterestAccrualDate = _prefixId.prefix "hasInitialInterestAccrualDate"
    /// <summary>
    ///   <para>rdfs:label : has initial interest payment date^^xsd:string</para>
    ///   <para>skos:definition : the date on which the first interest payment is due^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInitialInterestPaymentDate">fibo-fbc-dae-dbt:hasInitialInterestPaymentDate</a>
    /// </summary>
    let hasInitialInterestPaymentDate = _prefixId.prefix "hasInitialInterestPaymentDate"

    /// <summary>
    ///   <para>rdfs:label : has initial principal payment date^^xsd:string</para>
    ///   <para>skos:definition : the date on which the first payment against the principal is due^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInitialPrincipalPaymentDate">fibo-fbc-dae-dbt:hasInitialPrincipalPaymentDate</a>
    /// </summary>
    let hasInitialPrincipalPaymentDate =
        _prefixId.prefix "hasInitialPrincipalPaymentDate"

    /// <summary>
    ///   <para>rdfs:label : has interest payment day^^xsd:string</para>
    ///   <para>skos:definition : the day of the month on which interest payments must be made on the debt^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInterestPaymentDay">fibo-fbc-dae-dbt:hasInterestPaymentDay</a>
    /// </summary>
    let hasInterestPaymentDay = _prefixId.prefix "hasInterestPaymentDay"
    /// <summary>
    ///   <para>rdfs:label : has interest payment frequency^^xsd:string</para>
    ///   <para>skos:definition : the frequency at which interest payments must be made on the debt^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInterestPaymentFrequency">fibo-fbc-dae-dbt:hasInterestPaymentFrequency</a>
    /// </summary>
    let hasInterestPaymentFrequency = _prefixId.prefix "hasInterestPaymentFrequency"
    /// <summary>
    ///   <para>rdfs:label : has interest rate^^xsd:string</para>
    ///   <para>skos:definition : relates something, such as an agreement, or debt instrument, to the rate (typically annual) of interest that is to be paid by the debtor to the creditor on the debt^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInterestRate">fibo-fbc-dae-dbt:hasInterestRate</a>
    /// </summary>
    let hasInterestRate = _prefixId.prefix "hasInterestRate"
    /// <summary>
    ///   <para>rdfs:label : has interest rate cap^^xsd:string</para>
    ///   <para>skos:definition : relates something, such as an agreement, or debt instrument, to the upper bound (ceiling) rate (typically annual) of interest on variable-rate debt that is to be paid by the debtor to the creditor on the debt^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasInterestRateCap">fibo-fbc-dae-dbt:hasInterestRateCap</a>
    /// </summary>
    let hasInterestRateCap = _prefixId.prefix "hasInterestRateCap"
    /// <summary>
    ///   <para>rdfs:label : has lender^^xsd:string</para>
    ///   <para>skos:definition : relates a contract, such as a debt instrument or credit agreement, to one or more parties that are financing the debt^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasLender">fibo-fbc-dae-dbt:hasLender</a>
    /// </summary>
    let hasLender = _prefixId.prefix "hasLender"
    /// <summary>
    ///   <para>rdfs:label : has maturity date^^xsd:string</para>
    ///   <para>skos:definition : indicates the date on which the principal amount of an instrument is due to be repaid to the investor and interest or coupon payments stop, and/or the date on which the instrument may be redeemed^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Maturity dates typically apply to debt instruments, such as notes, drafts, bonds, and other loans, but may also apply to preferred shares and other financial instruments.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasMaturityDate">fibo-fbc-dae-dbt:hasMaturityDate</a>
    /// </summary>
    let hasMaturityDate = _prefixId.prefix "hasMaturityDate"
    /// <summary>
    ///   <para>rdfs:label : has maximum advance amount^^xsd:string</para>
    ///   <para>skos:definition : specifies the ceiling on the amount of credit that can be drawn by the borrower in a single request with respect to a specific agreement (e.g. for line of credit) within the specified credit limit^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasMaximumAdvanceAmount">fibo-fbc-dae-dbt:hasMaximumAdvanceAmount</a>
    /// </summary>
    let hasMaximumAdvanceAmount = _prefixId.prefix "hasMaximumAdvanceAmount"
    /// <summary>
    ///   <para>rdfs:label : has time to maturity^^xsd:string</para>
    ///   <para>skos:definition : indicates the lifespan of credit agreement or offering, from the date of issuance to the scheduled maturity date^^xsd:string</para>
    ///   <para>cmns-av:synonym : has term to maturity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasOriginalTimeToMaturity">fibo-fbc-dae-dbt:hasOriginalTimeToMaturity</a>
    /// </summary>
    let hasOriginalTimeToMaturity = _prefixId.prefix "hasOriginalTimeToMaturity"
    /// <summary>
    ///   <para>rdfs:label : has outstanding amount^^xsd:string</para>
    ///   <para>skos:definition : indicates an amount of money representing the principal, interest, or other amount owed at a specific point in time^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasOutstandingAmount">fibo-fbc-dae-dbt:hasOutstandingAmount</a>
    /// </summary>
    let hasOutstandingAmount = _prefixId.prefix "hasOutstandingAmount"
    /// <summary>
    ///   <para>rdfs:label : has principal^^xsd:string</para>
    ///   <para>skos:definition : indicates the face value of an obligation, such as a bond or loan, that must be repaid at maturity, i.e., the base amount raised by a mortgage or other debt instrument^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasPrincipal">fibo-fbc-dae-dbt:hasPrincipal</a>
    /// </summary>
    let hasPrincipal = _prefixId.prefix "hasPrincipal"
    /// <summary>
    ///   <para>rdfs:label : has principal payment day^^xsd:string</para>
    ///   <para>skos:definition : the day of the month on which payments on the principal must be made^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasPrincipalPaymentDay">fibo-fbc-dae-dbt:hasPrincipalPaymentDay</a>
    /// </summary>
    let hasPrincipalPaymentDay = _prefixId.prefix "hasPrincipalPaymentDay"
    /// <summary>
    ///   <para>rdfs:label : has principal payment frequency^^xsd:string</para>
    ///   <para>skos:definition : the frequency at which payments on the principal must be made^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasPrincipalPaymentFrequency">fibo-fbc-dae-dbt:hasPrincipalPaymentFrequency</a>
    /// </summary>
    let hasPrincipalPaymentFrequency = _prefixId.prefix "hasPrincipalPaymentFrequency"
    /// <summary>
    ///   <para>rdfs:label : has principal repayment date^^xsd:string</para>
    ///   <para>skos:definition : relates an instrument to the date by which the principal must be repaid in full^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Depending on the terms of the instrument (debt security, such as a bond, loan, etc.), this may be the date of a single payment of the debt principal or of the completion of scheduled partial redemption payments.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/hasPrincipalRepaymentDate">fibo-fbc-dae-dbt:hasPrincipalRepaymentDate</a>
    /// </summary>
    let hasPrincipalRepaymentDate = _prefixId.prefix "hasPrincipalRepaymentDate"
    /// <summary>
    ///   <para>rdfs:label : is amortization of^^xsd:string</para>
    ///   <para>skos:definition : links the process of reduction of debt or other costs through periodic charges to the relevant asset or liability^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isAmortizationOf">fibo-fbc-dae-dbt:isAmortizationOf</a>
    /// </summary>
    let isAmortizationOf = _prefixId.prefix "isAmortizationOf"
    /// <summary>
    ///   <para>rdfs:label : is based on^^xsd:string</para>
    ///   <para>skos:definition : relates something to something else on which it rests, or that supports it in some way^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isBasedOn">fibo-fbc-dae-dbt:isBasedOn</a>
    /// </summary>
    let isBasedOn = _prefixId.prefix "isBasedOn"
    /// <summary>
    ///   <para>rdfs:label : is collateralization of^^xsd:string</para>
    ///   <para>skos:definition : relates some collateral to an agreement pledging the asset as security^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isCollateralizationOf">fibo-fbc-dae-dbt:isCollateralizationOf</a>
    /// </summary>
    let isCollateralizationOf = _prefixId.prefix "isCollateralizationOf"
    /// <summary>
    ///   <para>rdfs:label : is collateralized by^^xsd:string</para>
    ///   <para>skos:definition : relates an agreement to an asset pledged as security^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isCollateralizedBy">fibo-fbc-dae-dbt:isCollateralizedBy</a>
    /// </summary>
    let isCollateralizedBy = _prefixId.prefix "isCollateralizedBy"
    /// <summary>
    ///   <para>rdfs:label : is interest on^^xsd:string</para>
    ///   <para>skos:definition : links a monetary amount that is the cost of using credit to the debt that it applies to^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isInterestOn">fibo-fbc-dae-dbt:isInterestOn</a>
    /// </summary>
    let isInterestOn = _prefixId.prefix "isInterestOn"
    /// <summary>
    ///   <para>rdfs:label : is owed^^xsd:string</para>
    ///   <para>skos:definition : links a creditor to a debt that is outstanding and payable to them^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isOwed">fibo-fbc-dae-dbt:isOwed</a>
    /// </summary>
    let isOwed = _prefixId.prefix "isOwed"
    /// <summary>
    ///   <para>rdfs:label : is owed by^^xsd:string</para>
    ///   <para>skos:definition : links a debt to the party that owes it^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isOwedBy">fibo-fbc-dae-dbt:isOwedBy</a>
    /// </summary>
    let isOwedBy = _prefixId.prefix "isOwedBy"
    /// <summary>
    ///   <para>rdfs:label : is owed to^^xsd:string</para>
    ///   <para>skos:definition : links a debt to the party to which it is payable^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isOwedTo">fibo-fbc-dae-dbt:isOwedTo</a>
    /// </summary>
    let isOwedTo = _prefixId.prefix "isOwedTo"
    /// <summary>
    ///   <para>rdfs:label : is principal of^^xsd:string</para>
    ///   <para>skos:definition : links the value of a debt, excluding any interest or other costs of using credit, to the debt that it applies to^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/isPrincipalOf">fibo-fbc-dae-dbt:isPrincipalOf</a>
    /// </summary>
    let isPrincipalOf = _prefixId.prefix "isPrincipalOf"
    /// <summary>
    ///   <para>rdfs:label : owes^^xsd:string</para>
    ///   <para>skos:definition : links a party to a debt that they owe^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/owes">fibo-fbc-dae-dbt:owes</a>
    /// </summary>
    let owes = _prefixId.prefix "owes"
