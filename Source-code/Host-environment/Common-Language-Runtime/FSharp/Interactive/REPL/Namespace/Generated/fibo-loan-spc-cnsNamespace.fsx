#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-loan-spc-cns`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/" "fibo-loan-spc-cns"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : consumer loan</para>
    ///   <para>skos:definition : loan to one or more individuals for household, family, or other personal expenditures, excluding mortgages and student loans</para>
    ///   <para>skos:example : Other secured consumer loans may include loans against insurance policies, against securities held in a retirement account, loans secured with collateral other than for the loan's stated purpose, lines of credit other than credit card agreements, and so forth.</para>
    ///   <para>cmns-av:adaptedFrom : 12 CFR § 228.12, https://www.law.cornell.edu/cfr/text/12/228.12</para>
    ///   <para>cmns-av:explanatoryNote : In the United Kingdom and per the Bank of England, lending to individuals (excluding student loans) consists of sterling lending secured on dwellings (i.e. mortgages) and sterling consumer credit to UK-resident individuals. See https://www.bankofengland.co.uk/statistics/details/further-details-about-total-lending-to-individuals-data. This definition is broader than the definition used in the US, however.cmns-av:explanatoryNote : In the United States, consumer loans do not include a home mortgage, small business, or small farm loans. They are defined by law to include the following: (1) Motor vehicle loan, which is a consumer loan extended for the purchase of and secured by a motor vehicle; (2) Credit card loan, which is a line of credit for household, family, or other personal expenditures that is accessed by a borrower's use of a 'credit card,' as this term is defined in § 1026.2 of 12 CFR § 228.12; (3) Other secured consumer loan, which is a secured consumer loan that is not included in one of the other categories of consumer loans; and (4) Other unsecured consumer loan, which is an unsecured consumer loan that is not included in one of the other categories of consumer loans.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/ConsumerLoan">fibo-loan-spc-cns:ConsumerLoan</a>
    /// </summary>
    let ConsumerLoan = _prefixId.prefix "ConsumerLoan"
    /// <summary>
    ///   <para>rdfs:label : home equity line of credit</para>
    ///   <para>skos:definition : line of credit granted to a homeowner secured by the equity value in a borrower's home or other property</para>
    ///   <para>cmns-av:acronym : HELOC</para>
    ///   <para>cmns-av:explanatoryNote : Home equity loans allow the borrower to borrow against the difference between the fair market value of the property, as determined by an appraisal, and the amount of any outstanding debt on that property, which is typically a first mortgage. Common practice is to set the maximum amount that can be borrowed of up to 80 percent of the fair market value less any outstanding debt.cmns-av:explanatoryNote : Usually, the term of a HELOC can vary from 5 to up to 25 years, with an initial draw period during which the borrower can access the line of credit, followed by a repayment period during which monthly payments on principal and interest are due until the loan is paid in full. Note that there are restrictions in the US on the nature of the property that may be used as collateral for a HELOC - it must be classified as a 1-4 family dwelling. That determination is independent from the use of proceeds.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/HomeEquityLineOfCredit">fibo-loan-spc-cns:HomeEquityLineOfCredit</a>
    /// </summary>
    let HomeEquityLineOfCredit = _prefixId.prefix "HomeEquityLineOfCredit"
    /// <summary>
    ///   <para>rdfs:label : motor vehicle loan</para>
    ///   <para>skos:definition : collateralized, simple-interest loan that is repaid in monthly installments over a period of typically three to five years, for the purpose of purchasing a vehicle</para>
    ///   <para>cmns-av:adaptedFrom : 12 CFR § 228.12, https://www.law.cornell.edu/cfr/text/12/228.12</para>
    ///   <para>cmns-av:explanatoryNote : Many lenders will only approve auto loans for vehicles (i.e., cars, trucks) that are a certain age (typically 5 years or less) due to depreciation of the value of the vehicle. Because an auto loan is a 'secured' type of loan, the vehicle that is being financed is used as collateral (i.e. if the borrower fails to repay the loan, the vehicle may be seized by the lender).</para>
    ///   <para>cmns-av:synonym : auto loan</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/MotorVehicleLoan">fibo-loan-spc-cns:MotorVehicleLoan</a>
    /// </summary>
    let MotorVehicleLoan = _prefixId.prefix "MotorVehicleLoan"
    /// <summary>
    ///   <para>rdfs:label : secured consumer loan</para>
    ///   <para>skos:definition : loan to one or more individuals for household, family, or other personal expenditures in which the borrower pledges some asset via a security agreement as collateral for the loan, or that is secured via third-party guarantee</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/SecuredConsumerLoan">fibo-loan-spc-cns:SecuredConsumerLoan</a>
    /// </summary>
    let SecuredConsumerLoan = _prefixId.prefix "SecuredConsumerLoan"
    /// <summary>
    ///   <para>rdfs:label : unsecured consumer loan</para>
    ///   <para>skos:definition : loan to one or more individuals for household, family, or other personal expenditures granted based on the strength of the borrower's credit history or reputation in the community</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/UnsecuredConsumerLoan">fibo-loan-spc-cns:UnsecuredConsumerLoan</a>
    /// </summary>
    let UnsecuredConsumerLoan = _prefixId.prefix "UnsecuredConsumerLoan"
