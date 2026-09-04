#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-sec-dbt-pbs`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/" "fibo-sec-dbt-pbs"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : absolute prepayment rate</para>
    ///   <para>skos:definition : measure of the monthly rate of loan prepayments as a percentage of the original pool balance</para>
    ///   <para>cmns-av:abbreviation : ABS</para>
    ///   <para>cmns-av:explanatoryNote : ABS is defined by the following formula where SMM refers to Single Monthly Mortality, which measures the percentage of dollars prepaid in a given month expressed as a percentage of the scheduled loan balance. ABS = (100 * SMM)/100 + (SMM X (Age - 1).cmns-av:explanatoryNote : The ABS measurement differs from conditional prepayment rate (CPR) used in the mortgage industry, which measures prepayment as an annualized percentage of the current pool balance.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/AbsolutePrepaymentRate">fibo-sec-dbt-pbs:AbsolutePrepaymentRate</a>
    /// </summary>
    let AbsolutePrepaymentRate = _prefixId.prefix "AbsolutePrepaymentRate"
    /// <summary>
    ///   <para>rdfs:label : asset-backed security</para>
    ///   <para>skos:definition : debt instrument backed by receivables other than those arising out of real estate loans or mortgages</para>
    ///   <para>cmns-av:abbreviation : ABS</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of Financial Instruments (CFI code), Fourth edition, 2019-10-01^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : An asset-backed security (ABS) is a type of financial investment that is collateralized by an underlying pool of assets—usually ones that generate a cash flow from debt, such as loans, leases, credit card balances, or receivables. It takes the form of a bond or note, paying income at a fixed rate for a set amount of time, until maturity. ABS are financial securities backed by income-generating assets such as credit card receivables, home equity loans, student loans, and auto loans. Pooling assets into an ABS is a process called securitization. One difference between an ABS and a collateralized debt obligation (CDO) is that the CDO issuer is generally a special purpose vehicle (SPV) or trust.cmns-av:explanatoryNote : Asset-backed securities, for example home equity loans (HEL), credit cards, and so forth are backed by receivables [payments] that are either secured (such as HEL) or unsecured (for example, credit cards). They are typically tranched based on default risk.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/AssetBackedSecurity">fibo-sec-dbt-pbs:AssetBackedSecurity</a>
    /// </summary>
    let AssetBackedSecurity = _prefixId.prefix "AssetBackedSecurity"
    /// <summary>
    ///   <para>rdfs:label : attachment point</para>
    ///   <para>skos:definition : lower tranche boundary of a tranche defined as a percentage of the value of the total pool of collateral, either at issuance or as of some point in time</para>
    ///   <para>cmns-av:adaptedFrom : Alexander Veremyev, Peter Tsyurmasto, and Stan Uryasev. "Optimal Structuring of CDO contracts: Optimization Approach". https://www.ise.ufl.edu/uryasev/files/2012/10/structuring_CDO_JCR_oct12.pdfcmns-av:adaptedFrom : https://fincyclopedia.net/finance/</para>
    ///   <para>cmns-av:explanatoryNote : A CDO tranche becomes liable for losses when the total amount of defaults or losses in the underlying debt pool exceeds a certain threshold, called the attachment point. The attachment point is expressed as a percentage of the total value of the debt pool. In other words, the attachment point is the level of subordination above which a given tranche stands. Note that the notion of 'liability for loss' is in a financial or econonmic sense rather than a legal sense.cmns-av:explanatoryNote : The higher the attachment point, the lower the risk and the return for the tranche. The lower the attachment point, the higher the risk and the return for the tranche. The most senior tranches have the highest attachment points and are paid first from the cash flows of the debt pool. The most junior tranches have the lowest attachment points and are paid last from the cash flows of the debt pool. The junior tranches also bear the first losses when defaults occur in the debt pool.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/AttachmentPoint">fibo-sec-dbt-pbs:AttachmentPoint</a>
    /// </summary>
    let AttachmentPoint = _prefixId.prefix "AttachmentPoint"
    /// <summary>
    ///   <para>rdfs:label : debt pool statistical measure</para>
    ///   <para>skos:definition : qualified measure of some aspect of the behavior of one or more debt instrument(s) that may vary over time</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/DebtPoolStatisticalMeasure">fibo-sec-dbt-pbs:DebtPoolStatisticalMeasure</a>
    /// </summary>
    let DebtPoolStatisticalMeasure = _prefixId.prefix "DebtPoolStatisticalMeasure"
    /// <summary>
    ///   <para>rdfs:label : default rate</para>
    ///   <para>skos:definition : qualified measure of the rate at which holders of the debt instruments in the pool default on those instruments</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/DefaultRate">fibo-sec-dbt-pbs:DefaultRate</a>
    /// </summary>
    let DefaultRate = _prefixId.prefix "DefaultRate"
    /// <summary>
    ///   <para>rdfs:label : detachment point</para>
    ///   <para>skos:definition : upper tranche boundary of a tranche defined as a percentage of the value of the total pool of collateral, either at issuance or as of some point in time</para>
    ///   <para>cmns-av:adaptedFrom : Alexander Veremyev, Peter Tsyurmasto, and Stan Uryasev. "Optimal Structuring of CDO contracts: Optimization Approach". https://www.ise.ufl.edu/uryasev/files/2012/10/structuring_CDO_JCR_oct12.pdfcmns-av:adaptedFrom : https://fincyclopedia.net/finance/</para>
    ///   <para>cmns-av:explanatoryNote : The CDO tranche loss arises when the cumulative collateral loss exceeds the tranche's attachment point. The detachment point corresponds to the amount of pool losses that will completely wipe out the respective tranche. The detachment point is the maximum of pool-level losses at which a given tranche becomes liable for losses.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/DetachmentPoint">fibo-sec-dbt-pbs:DetachmentPoint</a>
    /// </summary>
    let DetachmentPoint = _prefixId.prefix "DetachmentPoint"
    /// <summary>
    ///   <para>rdfs:label : pool-backed security</para>
    ///   <para>skos:definition : debt instrument that derives its cashflow from an underlying pool of mortgage loans or other receivables</para>
    ///   <para>cmns-av:explanatoryNote : If the security is a component of a collateralized debt obligation, then the underlying pool is typically segmented into various tranches, each of which provides cash flows to hedge particular risks, or that offset other gains by time to maturity or other factors.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/PoolBackedSecurity">fibo-sec-dbt-pbs:PoolBackedSecurity</a>
    /// </summary>
    let PoolBackedSecurity = _prefixId.prefix "PoolBackedSecurity"
    /// <summary>
    ///   <para>rdfs:label : prepayment speed</para>
    ///   <para>skos:definition : estimated rate at which a debt or part of a debt is paid off ahead of schedule</para>
    ///   <para>cmns-av:explanatoryNote : A prepayment model is used to estimate the level of prepayments (speed) on a loan portfolio that will occur in a set period of time, given possible changes in interest rates. Understanding prepayment speed is critical in assessing the value of mortgage pass-through securities. Prepayment models are based on mathematical equations and usually involve the analysis of historical prepayment trends to predict what will happen in the future. Prepayment models are often used to value mortgage pools such as GNMA securities or other securitized debt products, including mortgage-backed securities (MBS).</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/PrepaymentSpeed">fibo-sec-dbt-pbs:PrepaymentSpeed</a>
    /// </summary>
    let PrepaymentSpeed = _prefixId.prefix "PrepaymentSpeed"
    /// <summary>
    ///   <para>rdfs:label : principal protected note</para>
    ///   <para>skos:definition : structured finance that offers investors exposure to chosen underlying assets using various approaches and asymmetric pay-off profiles</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of Financial Instruments (CFI code), Fourth edition, 2019-10-01.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : There are one or more reference entities underlying the product. Redemption is made at least in the amount of the conditional capital protection at maturity, provided that no credit event by the reference entity has occurred. Conditional capital protection only applies to the nominal amount and not to the purchase price. The general functioning of a capital guaranteed structured instrument is as follows: the notional amount is split into a zero bond, that will deliver the capital guarantee at maturity, and the difference between the zero bond's value (= present value of the guarantee level at maturity) and the notional amount is used for structuring the performance component with options which deliver the agreed pay-off profile of the structured instrument.</para>
    ///   <para>cmns-av:synonym : capital protected note</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/PrincipalProtectedNote">fibo-sec-dbt-pbs:PrincipalProtectedNote</a>
    /// </summary>
    let PrincipalProtectedNote = _prefixId.prefix "PrincipalProtectedNote"
    /// <summary>
    ///   <para>rdfs:label : single monthly mortality</para>
    ///   <para>skos:definition : estimated per-month percentage of mortgages in an MBS pool that will be paid off early</para>
    ///   <para>cmns-av:abbreviation : SMM</para>
    ///   <para>cmns-av:explanatoryNote : Single monthly mortality (SMM) is a way to gauge the prepayment risk of a mortgage-backed security.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/SingleMonthlyMortality">fibo-sec-dbt-pbs:SingleMonthlyMortality</a>
    /// </summary>
    let SingleMonthlyMortality = _prefixId.prefix "SingleMonthlyMortality"
    /// <summary>
    ///   <para>rdfs:label : structured finance instrument</para>
    ///   <para>skos:definition : pool-backed security wherein the risk associated with the pool has been uncoupled from the risk associated with the originating institution through a special purpose vehicle</para>
    ///   <para>skos:example : Collateralized debt obligations (CDOs), synthetic financial instruments, collateralized bond obligations (CBOs), and syndicated loans are examples of structured finance instruments.</para>
    ///   <para>cmns-av:explanatoryNote : Structured finance instruments represent a form of securitization technology which can be defined by three key characteristics: (1) pooling of financial assets, such as loans, bonds, or credit-default swaps; (2) de-linking of the credit risk of the asset pool from the credit risk of the originating firm, usually through use of a finite-lived, stand-alone special purpose vehicle (SPV); and (3) issuance by the SPV of "tranched" liabilities backed by the asset pool. Structured finance instruments are typically presented to large financial institutions or companies with complicated financing needs that are unsatisfied with conventional financial products.</para>
    ///   <para>cmns-av:synonym : structured finance</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/StructuredFinanceInstrument">fibo-sec-dbt-pbs:StructuredFinanceInstrument</a>
    /// </summary>
    let StructuredFinanceInstrument = _prefixId.prefix "StructuredFinanceInstrument"

    /// <summary>
    ///   <para>rdfs:label : structured finance without principal protection</para>
    ///   <para>skos:definition : structured finance that is a short-term note linked to an underlying asset that offers a steady stream of income</para>
    ///   <para>cmns-av:adaptedFrom : ISO 10962, Securities and related financial instruments - Classification of Financial Instruments (CFI code), Fourth edition, 2019-10-01.^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The redemption at the end of the term is determined on the basis of the performance and final fixing of the underlying asset: a redemption at the nominal value is guaranteed as long as the underlying asset has not touched its barrier during relevant barrier monitoring. If the underlying asset has touched its barrier but is again above the strike price at final fixing, the nominal price is also repaid. Nevertheless, if the underlying asset has touched its barrier during barrier monitoring and closes below the strike price at final fixing, the underlying asset is delivered or cash compensation paid, provided that no credit event by the reference entity has occurred. Depending on the characteristics of the product, either a coupon or a discount to the underlying asset can apply. A coupon is paid out regardless of the performance of the underlying asset, provided that no credit event by the reference entity has occurred.</para>
    ///   <para>cmns-av:synonym : structured finance without capital protection</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/StructuredFinanceWithoutPrincipalProtection">fibo-sec-dbt-pbs:StructuredFinanceWithoutPrincipalProtection</a>
    /// </summary>
    let StructuredFinanceWithoutPrincipalProtection =
        _prefixId.prefix "StructuredFinanceWithoutPrincipalProtection"

    /// <summary>
    ///   <para>rdfs:label : tranche</para>
    ///   <para>skos:definition : segment of a pool of securities, typically debt instruments</para>
    ///   <para>cmns-av:explanatoryNote : A tranche is one of a number of related securities in the same offering that represents a partition of a debt pool whose cash flow is derived from the combined cash flows of the instruments in that partition.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/Tranche">fibo-sec-dbt-pbs:Tranche</a>
    /// </summary>
    let Tranche = _prefixId.prefix "Tranche"
    /// <summary>
    ///   <para>rdfs:label : weighted average coupon</para>
    ///   <para>skos:definition : weighted-average gross interest rates of the pool of mortgages that underlie a mortgage-backed security (MBS) weighed by their balances at the time the securities were issued</para>
    ///   <para>skos:editorialNote : Provided by the Issuer (loan servicer?) along with the WALA etc. If you know the underlying loans you can calculate this yourself. For ABS you don't know this so you have to get this information from the loan servicer. Investopedia explains Weighted Average Coupon - WAC For example, suppose a MBS is composed of two different pools of mortgages: $6 million worth of mortgages that yield 7.5% and a pool of $4 million mortgages that yield 5%. The WAC would be 6.5%. The WAC on a mortgage-backed security is an important piece of information used by analysts to estimate the pre-pay characteristics of that security. It is an important relative value tool in MBS portfolio management and analysis.</para>
    ///   <para>cmns-av:abbreviation : WAC</para>
    ///   <para>cmns-av:explanatoryNote : The weighted average coupon (WAC) is calculated by taking the gross of the interest rates owed on the underlying mortgages of the MBS and weighting them according to the percentage of the security that each mortgage represents. The WAC represents the average interest rate of different pools of mortgages with varying interest rates. In the weighted average calculation, the principal balance of each underlying mortgage is used as the weighting factor. To calculate the WAC, the coupon rate of each mortgage or MBS is multiplied by its remaining principal balance. The results are added together, and the sum total is divided by the remaining balance. A mortgage-backed security's current WAC can differ from its original WAC as the underlying mortgages pay down at different speeds. In the weighted-average calculation, the principal balance of each underlying mortgage is used as the weighting factor.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageCoupon">fibo-sec-dbt-pbs:WeightedAverageCoupon</a>
    /// </summary>
    let WeightedAverageCoupon = _prefixId.prefix "WeightedAverageCoupon"
    /// <summary>
    ///   <para>rdfs:label : weighted average life</para>
    ///   <para>skos:definition : weighted average of the times of the principal repayments Average life is calculated using the weighted average time to the receipt of all future cash flows.</para>
    ///   <para>cmns-av:abbreviation : WAL</para>
    ///   <para>cmns-av:explanatoryNote : Average life is calculated using the weighted average time to the receipt of all future cash flows of an amortizing loan or amortizing bond. it's the average time until a dollar of principal is repaid.cmns-av:explanatoryNote : The time weightings used in weighted average life calculations are based on payments to the principal. In many loans, such as mortgages, each payment consists of payments to principal and payments to interest. In WAL, only the principal payments are considered and these payments tend to get larger over time, with early payments of a mortgage going mostly to interest, while payments made towards the end of the loan are applied mostly to the principal balance of the loan.cmns-av:explanatoryNote : Where it refers to pre-payment above, if the bond does not include prepayment then this is not included. However, analytics that refer to this e.g. Yield to Average Life, then this figure is relevant. It is not relevant for other types of bond where e.g. you would use yield to next call, yield to worst etc. Average Life used in place of Maturity for Yield Calculation. This is not only used for Yield calculations though. It is referred to as an analytic figure in its own right. Average Life uses one of a number of standard pre-payment models (for structured finance at least). For MBS, the average life includes some calculations to take account of pre-payments on the underlying mortgages. This takes account of the possibillity of borrowers paying early. This has to be modeled or forecast (not given) as it's a function of market conditions and interest rate. You would not see this in a market data feed. When you model MBS you calculate Average Life as part of the model i.e. you estimate the percentage of prepayment in the next x length of time and factor this into the Average Life. Refers to Weighted Average Time to receipt of future cash flows. For MBS, early payments will shorten the Average Life. For Student Loans, Credit Card, Loan etc, i.e. all Pool Backed (any bond that has securitized debt). Other bonds: Sinking Funds etc., also Early Payment - partial Call for a corporate / regular bond. Early Payment for pass through has the same effect. Sinking Fund: Each payment is part principal and part interest, this is implicit in the overall definition of "Early payment".</para>
    ///   <para>cmns-av:synonym : average life</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageLife">fibo-sec-dbt-pbs:WeightedAverageLife</a>
    /// </summary>
    let WeightedAverageLife = _prefixId.prefix "WeightedAverageLife"
    /// <summary>
    ///   <para>rdfs:label : weighted average loan age</para>
    ///   <para>skos:definition : dollar-weighted average measuring the age of the individual loans in a mortgage pass-through or pooled security</para>
    ///   <para>cmns-av:abbreviation : WALA</para>
    ///   <para>cmns-av:explanatoryNote : A weighted average loan age (WALA) may apply to pool-backed securities such as Ginnie Mae or Freddie Mac securities. The WALA is measured as the time in months since the origination of the loans, with the weighting based on each loan's size in proportion to the aggregate total of the pool.cmns-av:explanatoryNote : This is defined by the issuer. WALA is more official, not an analysis from a vendor. This changes but the values are relayed by the issuer on an ongoing basis. Investopedia explains Weighted Average Loan Age - WALA The weighted average age will change over time as some mortgages get paid off faster than others. Based on the issuer of the mortgage-backed securities (MBS), the WALA may be weighted on the remaining principal balance dollar figure, or the beginning notional value of the loan. The flip side of the WALA is the weighted average maturity (WAM), which is a dollar-weighted measure of the months remaining until the principal amounts are completely repaid on each loan in the pool.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageLoanAge">fibo-sec-dbt-pbs:WeightedAverageLoanAge</a>
    /// </summary>
    let WeightedAverageLoanAge = _prefixId.prefix "WeightedAverageLoanAge"
    /// <summary>
    ///   <para>rdfs:label : weighted average maturity</para>
    ///   <para>skos:definition : weighted average amount of time until the maturities on mortgages in a mortgage-backed security (MBS)</para>
    ///   <para>cmns-av:abbreviation : WAM</para>
    ///   <para>cmns-av:explanatoryNote : The measure is calculated by totaling each mortgage value represented by the MBS. The weights of each mortgage is found by dividing the value of each into the total of all. To arrive at the WAM number the weight of each security is multiplied by the time until maturity of each mortgage, and then all the values are added together. For example say an MBS has three mortgages valued at $1,000, $2,000 and $3,000 (a total of $6,000) and mature in one, two and three years respectively. The weights of these are 1/6 (1,000/6,000), 1/3 (2,000/6,000) and 1/2 (3,000/6,000). The WAM is 2 1/3 years (1/6 x 1 year + 1/3 x 2 years + 1/2 x 3 years). Note that this calculation would need to be adjusted if there are multiple pools behind the MBS.cmns-av:explanatoryNote : This term is used more broadly to describe maturities in a portfolio of debt securities, including corporate debt and municipal bonds. The higher the WAM, the longer it takes for all of the mortgages or bonds in the portfolio to mature. WAM is used to manage debt portfolios and to assess the performance of debt portfolio managers.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageMaturity">fibo-sec-dbt-pbs:WeightedAverageMaturity</a>
    /// </summary>
    let WeightedAverageMaturity = _prefixId.prefix "WeightedAverageMaturity"
    /// <summary>
    ///   <para>rdfs:label : weighted average remaining term</para>
    ///   <para>skos:definition : weighted average time to maturity of a portfolio of asset-backed securities (ABS) or mortgage-backed (MBS) securities</para>
    ///   <para>cmns-av:abbreviation : WART</para>
    ///   <para>cmns-av:explanatoryNote : The longer the WART, the longer the portfolio's assets will take to mature, on average. WART is often used in relation to mortgage-backed securities (MBS) but can also be applied to any portfolio of fixed-income securities. WART is closely related to weighted average loan age (WALA), which is its inverse.</para>
    ///   <para>cmns-av:synonym : weighted average remaining maturity</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/WeightedAverageRemainingTerm">fibo-sec-dbt-pbs:WeightedAverageRemainingTerm</a>
    /// </summary>
    let WeightedAverageRemainingTerm = _prefixId.prefix "WeightedAverageRemainingTerm"
    /// <summary>
    ///   <para>rdfs:label : has attachment point^^xsd:string</para>
    ///   <para>skos:definition : indicates the minimum (lower boundary) of the total value of the underlying collateral, either at issuance or as of some point in time, at which point a given tranche becomes liable for losses^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : When it is said that a tranche becomes 'liable for losses,' it means that the tranche starts to absorb or incur financial losses due to defaults or impairments in the underlying assets. This is based on the contractual agreements and the structuring of the CDO, which dictate the order in which losses are allocated to different tranches. Note that the notion of 'liability for loss' is in a financial or econonmic sense rather than a legal sense.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/hasAttachmentPoint">fibo-sec-dbt-pbs:hasAttachmentPoint</a>
    /// </summary>
    let hasAttachmentPoint = _prefixId.prefix "hasAttachmentPoint"
    /// <summary>
    ///   <para>rdfs:label : has detachment point^^xsd:string</para>
    ///   <para>skos:definition : indicates the maximum (upper boundary) of the total value of the underlying collateral, either at issuance or as of some point in time, at which point the value of given tranche is wiped out^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : When it is said that a tranche becomes 'liable for losses,' it means that the tranche starts to absorb or incur financial losses due to defaults or impairments in the underlying assets. This is based on the contractual agreements and the structuring of the CDO, which dictate the order in which losses are allocated to different tranches. Note that the notion of 'liability for loss' is in a financial or econonmic sense rather than a legal sense.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/hasDetachmentPoint">fibo-sec-dbt-pbs:hasDetachmentPoint</a>
    /// </summary>
    let hasDetachmentPoint = _prefixId.prefix "hasDetachmentPoint"

    /// <summary>
    ///   <para>rdfs:label : is estimated value of^^xsd:string</para>
    ///   <para>skos:definition : indicates the estimated value of the combined underlying collateral for a given tranche at the time the instrument was issued^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/hasEstimatedTotalCollateralValueAtIssuance">fibo-sec-dbt-pbs:hasEstimatedTotalCollateralValueAtIssuance</a>
    /// </summary>
    let hasEstimatedTotalCollateralValueAtIssuance =
        _prefixId.prefix "hasEstimatedTotalCollateralValueAtIssuance"

    /// <summary>
    ///   <para>rdfs:label : is pass through</para>
    ///   <para>skos:definition : indicates whether the cash flows from the underlying asset pool are passed through to the investor by way of redemption payments</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/isPassThrough">fibo-sec-dbt-pbs:isPassThrough</a>
    /// </summary>
    let isPassThrough = _prefixId.prefix "isPassThrough"
