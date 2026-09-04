#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-sec-dbt-bnd`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/" "fibo-sec-dbt-bnd"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : amortizing bond^^xsd:string</para>
    ///   <para>skos:definition : bond that regularly pays down the principal (face value) on the debt along with its interest expense over the life of the bond^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/AmortizingBond">fibo-sec-dbt-bnd:AmortizingBond</a>
    /// </summary>
    let AmortizingBond = _prefixId.prefix "AmortizingBond"
    /// <summary>
    ///   <para>rdfs:label : bond^^xsd:string</para>
    ///   <para>skos:definition : tradable debt instrument representing a loan in which the issuer owes the holder(s) a debt^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Depending on the terms of the contract, the issuer is obliged to pay interest (the coupon) and/or to repay the principal at maturity. The most common bonds are corporate or governmental, typically used to finance specific projects or operations.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/Bond">fibo-sec-dbt-bnd:Bond</a>
    /// </summary>
    let Bond = _prefixId.prefix "Bond"
    /// <summary>
    ///   <para>rdfs:label : bond amortization payment terms^^xsd:string</para>
    ///   <para>skos:definition : terms that include a schedule for repayment of the principal over the lifetime of the bond, typically in equal payments at regular intervals^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondAmortizationPaymentTerms">fibo-sec-dbt-bnd:BondAmortizationPaymentTerms</a>
    /// </summary>
    let BondAmortizationPaymentTerms = _prefixId.prefix "BondAmortizationPaymentTerms"
    /// <summary>
    ///   <para>rdfs:label : bond conversion terms^^xsd:string</para>
    ///   <para>skos:definition : terms indicating when a convertible bond can be converted to another security (usually a publicly traded share issued by of the same issuer)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondConversionTerms">fibo-sec-dbt-bnd:BondConversionTerms</a>
    /// </summary>
    let BondConversionTerms = _prefixId.prefix "BondConversionTerms"
    /// <summary>
    ///   <para>rdfs:label : bond coupon^^xsd:string</para>
    ///   <para>skos:definition : interest rate on a debt security that the issuer promises to pay to the holder until maturity, expressed as an annual percentage of the face value^^xsd:string</para>
    ///   <para>cmns-av:synonym : coupon percent rate^^xsd:stringcmns-av:synonym : coupon rate^^xsd:stringcmns-av:synonym : nominal yield^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondCoupon">fibo-sec-dbt-bnd:BondCoupon</a>
    /// </summary>
    let BondCoupon = _prefixId.prefix "BondCoupon"
    /// <summary>
    ///   <para>rdfs:label : bond insurance^^xsd:string</para>
    ///   <para>skos:definition : insurance policy that a bond issuer purchases that guarantees the repayment of the principal and all associated interest payments to the bondholders in the event of default^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondInsurance">fibo-sec-dbt-bnd:BondInsurance</a>
    /// </summary>
    let BondInsurance = _prefixId.prefix "BondInsurance"
    /// <summary>
    ///   <para>rdfs:label : bond principal repayment terms^^xsd:string</para>
    ///   <para>skos:definition : terms for the repayment of the principal on a bond^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondPrincipalRepaymentTerms">fibo-sec-dbt-bnd:BondPrincipalRepaymentTerms</a>
    /// </summary>
    let BondPrincipalRepaymentTerms = _prefixId.prefix "BondPrincipalRepaymentTerms"
    /// <summary>
    ///   <para>rdfs:label : bond registrar^^xsd:string</para>
    ///   <para>skos:definition : party responsible for maintaining records on behalf of the issuer that identify the owners of a registered bond issue^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The trustee under a bond contract often also acts as registrar.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondRegistrar">fibo-sec-dbt-bnd:BondRegistrar</a>
    /// </summary>
    let BondRegistrar = _prefixId.prefix "BondRegistrar"
    /// <summary>
    ///   <para>rdfs:label : bond variable coupon^^xsd:string</para>
    ///   <para>skos:definition : bond coupon that has a variable interest rate^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondVariableCoupon">fibo-sec-dbt-bnd:BondVariableCoupon</a>
    /// </summary>
    let BondVariableCoupon = _prefixId.prefix "BondVariableCoupon"
    /// <summary>
    ///   <para>rdfs:label : bond with partial call^^xsd:string</para>
    ///   <para>skos:definition : bond with a feature whereby the issue can be partially called for amounts that are at the discretion of the issuer^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondWithPartialCall">fibo-sec-dbt-bnd:BondWithPartialCall</a>
    /// </summary>
    let BondWithPartialCall = _prefixId.prefix "BondWithPartialCall"
    /// <summary>
    ///   <para>rdfs:label : bond with published sinking fund^^xsd:string</para>
    ///   <para>skos:definition : bond whereby amortization is via a known and published schedule^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondWithPublishedSinkingFund">fibo-sec-dbt-bnd:BondWithPublishedSinkingFund</a>
    /// </summary>
    let BondWithPublishedSinkingFund = _prefixId.prefix "BondWithPublishedSinkingFund"
    /// <summary>
    ///   <para>rdfs:label : bond with warrant^^xsd:string</para>
    ///   <para>dcterms:source : ISO 10962, Securities and related financial instruments - Classification of financial instruments (CFI) code, Fifth edition, 2021-05^^xsd:string</para>
    ///   <para>skos:definition : bond that is issued together with one or more warrant(s) attached as part of the offer, the warrant(s) granting the holder the right to purchase a designated security, often the common stock of the issuer of the debt, at a specified price^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This concept is needed primarily to support cases where the bond issuer is the issuer of the warrant.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BondWithWarrant">fibo-sec-dbt-bnd:BondWithWarrant</a>
    /// </summary>
    let BondWithWarrant = _prefixId.prefix "BondWithWarrant"
    /// <summary>
    ///   <para>rdfs:label : Build America Bond^^xsd:string</para>
    ///   <para>skos:definition : taxable municipal bond issued through December 31, 2010 under the American Recovery and Reinvestment Act of 2009 (ARRA)^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : BABs may be direct pay subsidy bonds or tax credit bonds.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BuildAmericaBond">fibo-sec-dbt-bnd:BuildAmericaBond</a>
    /// </summary>
    let BuildAmericaBond = _prefixId.prefix "BuildAmericaBond"
    /// <summary>
    ///   <para>rdfs:label : bullet bond^^xsd:string</para>
    ///   <para>skos:definition : bond whose entire principal value is paid on the maturity date, rather than amortized over its lifetime^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BulletBond">fibo-sec-dbt-bnd:BulletBond</a>
    /// </summary>
    let BulletBond = _prefixId.prefix "BulletBond"
    /// <summary>
    ///   <para>rdfs:label : bond bullet principal repayment terms^^xsd:string</para>
    ///   <para>skos:definition : terms for repayment of the principal for a bond as a single payment covering the whole principal amount^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/BulletPrincipalRepaymentTerms">fibo-sec-dbt-bnd:BulletPrincipalRepaymentTerms</a>
    /// </summary>
    let BulletPrincipalRepaymentTerms = _prefixId.prefix "BulletPrincipalRepaymentTerms"
    /// <summary>
    ///   <para>rdfs:label : callable bond^^xsd:string</para>
    ///   <para>skos:definition : bond that includes a stipulation allowing the issuer the right to repurchase and retire the bond at the call price after the call protection period^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CallableBond">fibo-sec-dbt-bnd:CallableBond</a>
    /// </summary>
    let CallableBond = _prefixId.prefix "CallableBond"
    /// <summary>
    ///   <para>rdfs:label : callable convertible bond^^xsd:string</para>
    ///   <para>skos:definition : convertible bond that is also callable^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CallableConvertibleBond">fibo-sec-dbt-bnd:CallableConvertibleBond</a>
    /// </summary>
    let CallableConvertibleBond = _prefixId.prefix "CallableConvertibleBond"
    /// <summary>
    ///   <para>rdfs:label : certificate of obligation^^xsd:string</para>
    ///   <para>skos:definition : municipal security available to governing councils in case of emergency, such as a natural disaster, that needs immediate action without time for voter referendum^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : CO^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : CO's are similar to GO bonds, except that they do not require voter approval before they are issued. The CO's are also guaranteed by the City's taxation power and are counted in the calculation of the tax rate that is needed to support debt payments.^^xsd:stringcmns-av:explanatoryNote : For example, when a hurricane destroys the police and emergency services building, there is no time to go through the process of voter referendum. The local council must be able to borrow the money to set up provisional buildings and necessary equipment for police and emergency services so that the community is served in continuity.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CertificateOfObligation">fibo-sec-dbt-bnd:CertificateOfObligation</a>
    /// </summary>
    let CertificateOfObligation = _prefixId.prefix "CertificateOfObligation"
    /// <summary>
    ///   <para>rdfs:label : certificate of participation^^xsd:string</para>
    ///   <para>skos:definition : debt instrument evidencing a pro rata share in a specific pledged revenue stream, usually lease payments by the issuer that are typically subject to annual appropriation^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : COP^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A certificate of participation (COP) is a type of financing where an investor purchases a share of the lease revenues of a program rather than the bond being secured by those revenues. The certificate generally entitles the holder to receive a share, or participation, in the payments from a particular project. The payments are passed through the lessor to the certificate holders. The lessor typically assigns the lease and the payments to a trustee, which then distributes the payments to the certificate holders.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CertificateOfParticipation">fibo-sec-dbt-bnd:CertificateOfParticipation</a>
    /// </summary>
    let CertificateOfParticipation = _prefixId.prefix "CertificateOfParticipation"
    /// <summary>
    ///   <para>rdfs:label : conventional gilt^^xsd:string</para>
    ///   <para>skos:definition : fixed coupon bond issued by HM Treasury that guarantees to pay the holder of the gilt a fixed cash payment (coupon) every six months until the maturity date, at which point the holder receives the final coupon payment and the return of the principal^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Conventional gilts are the simplest form of government bond and constitute around 75 percent of the gilt portfolio.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ConventionalGilt">fibo-sec-dbt-bnd:ConventionalGilt</a>
    /// </summary>
    let ConventionalGilt = _prefixId.prefix "ConventionalGilt"
    /// <summary>
    ///   <para>rdfs:label : convertible bond^^xsd:string</para>
    ///   <para>skos:definition : bond that gives the holder the right to convert the bond into a fixed number of shares (conversion ratio) if the equity price rises above a specified level (strike price)^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : If the equity price remains below the strike price throughout the term of the bond it matures and is redeemed like a regular bond. The conversion ratio and strike price are usually set when the convertible bond is issued.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ConvertibleBond">fibo-sec-dbt-bnd:ConvertibleBond</a>
    /// </summary>
    let ConvertibleBond = _prefixId.prefix "ConvertibleBond"
    /// <summary>
    ///   <para>rdfs:label : corporate bond^^xsd:string</para>
    ///   <para>skos:definition : bond issued by a company in order to raise financing^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Corporate bonds are issued for purposes such as mergers and acquisitions, business expansion, or to cover ongoing operational needs, and are typically longer-term debt instruments that have a maturity of at least one year. Corporate debt instruments with maturity shorter than one year are referred to as commercial paper.^^xsd:stringcmns-av:explanatoryNote : Note that some classification schemes consider any bond except those issued by a government in its own currency to be a corporate bond, for example, a bond issued by Canada in US dollars might be classified as a corporate bond. Bonds issued by multinational / supranational organizations such as the European Bank for Reconstruction and Development (EBRD) may also be considered corporate bonds rather than government bonds.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CorporateBond">fibo-sec-dbt-bnd:CorporateBond</a>
    /// </summary>
    let CorporateBond = _prefixId.prefix "CorporateBond"
    /// <summary>
    ///   <para>rdfs:label : coupon payment terms^^xsd:string</para>
    ///   <para>skos:definition : terms for payment of interest on a bond^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/CouponPaymentTerms">fibo-sec-dbt-bnd:CouponPaymentTerms</a>
    /// </summary>
    let CouponPaymentTerms = _prefixId.prefix "CouponPaymentTerms"
    /// <summary>
    ///   <para>rdfs:label : equity linked bond^^xsd:string</para>
    ///   <para>skos:definition : bond based on the return on an equity over time, i.e. the price and dividend payments or the total return (similar to total return swaps)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/EquityLinkedBond">fibo-sec-dbt-bnd:EquityLinkedBond</a>
    /// </summary>
    let EquityLinkedBond = _prefixId.prefix "EquityLinkedBond"

    /// <summary>
    ///   <para>rdfs:label : extraordinary redemption provision^^xsd:string</para>
    ///   <para>skos:definition : provision that gives a bond issuer the right to call its bonds due to an unusual one-time occurrence, as specified in the offering statement^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Such redemptions may occur when bond proceeds are not spent according to schedule; when bond proceeds are used in a way that makes nontaxable bond interest taxable; or when a catastrophe destroys the project being financed, among other reasons.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ExtraordinaryRedemptionProvision">fibo-sec-dbt-bnd:ExtraordinaryRedemptionProvision</a>
    /// </summary>
    let ExtraordinaryRedemptionProvision =
        _prefixId.prefix "ExtraordinaryRedemptionProvision"

    /// <summary>
    ///   <para>rdfs:label : first regular coupon date^^xsd:string</para>
    ///   <para>skos:definition : scheduled date for the first regular coupon payment, in a regular repeating series of coupon periods, after any non standard (long or short) first coupon period in the schedule^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FirstRegularCouponDate">fibo-sec-dbt-bnd:FirstRegularCouponDate</a>
    /// </summary>
    let FirstRegularCouponDate = _prefixId.prefix "FirstRegularCouponDate"
    /// <summary>
    ///   <para>rdfs:label : fixed coupon bond^^xsd:string</para>
    ///   <para>skos:definition : bond whose coupon rate and principal amount are fixed at the time of origination or sale and remain constant while the security is outstanding^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FixedCouponBond">fibo-sec-dbt-bnd:FixedCouponBond</a>
    /// </summary>
    let FixedCouponBond = _prefixId.prefix "FixedCouponBond"
    /// <summary>
    ///   <para>rdfs:label : fixed coupon terms^^xsd:string</para>
    ///   <para>skos:definition : terms for payment of interest on a bond with a fixed interest rate^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FixedCouponTerms">fibo-sec-dbt-bnd:FixedCouponTerms</a>
    /// </summary>
    let FixedCouponTerms = _prefixId.prefix "FixedCouponTerms"
    /// <summary>
    ///   <para>rdfs:label : floating rate note^^xsd:string</para>
    ///   <para>skos:definition : bond with a variable interest rate based on a published reference interest rate^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The adjustments to the interest rate (coupon) are made periodically, usually on a quarterly or monthly basis, and are tied to a certain money-market index. Also known as a "floater". For example six months USD LIBOR + 0.20%.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FloatingRateNote">fibo-sec-dbt-bnd:FloatingRateNote</a>
    /// </summary>
    let FloatingRateNote = _prefixId.prefix "FloatingRateNote"
    /// <summary>
    ///   <para>rdfs:label : full faith credit bond^^xsd:string</para>
    ///   <para>skos:definition : bond secured by an unconditional promise to pay by another entity^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Full faith and credit bonds are typically backed by a government entity and are considered low risk.^^xsd:string</para>
    ///   <para>cmns-av:synonym : full faith and credit bond^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/FullFaithCreditBond">fibo-sec-dbt-bnd:FullFaithCreditBond</a>
    /// </summary>
    let FullFaithCreditBond = _prefixId.prefix "FullFaithCreditBond"

    /// <summary>
    ///   <para>rdfs:label : general obligation municipal bond^^xsd:string</para>
    ///   <para>skos:definition : municipal bond that is backed by the full faith and credit and general resources of the issuing municipality, including its general taxing authority^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : GO bond^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/GeneralObligationMunicipalBond">fibo-sec-dbt-bnd:GeneralObligationMunicipalBond</a>
    /// </summary>
    let GeneralObligationMunicipalBond =
        _prefixId.prefix "GeneralObligationMunicipalBond"

    /// <summary>
    ///   <para>rdfs:label : government bond^^xsd:string</para>
    ///   <para>skos:definition : debt security issued by a government to fund government spending^^xsd:string</para>
    ///   <para>cmns-av:synonym : government-issued bond^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/GovernmentBond">fibo-sec-dbt-bnd:GovernmentBond</a>
    /// </summary>
    let GovernmentBond = _prefixId.prefix "GovernmentBond"
    /// <summary>
    ///   <para>rdfs:label : government issued debt security^^xsd:string</para>
    ///   <para>skos:definition : debt security issued by some government on behalf of some polity, including sovereign and municipal debt^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/GovernmentIssuedDebtSecurity">fibo-sec-dbt-bnd:GovernmentIssuedDebtSecurity</a>
    /// </summary>
    let GovernmentIssuedDebtSecurity = _prefixId.prefix "GovernmentIssuedDebtSecurity"
    /// <summary>
    ///   <para>rdfs:label : green bond^^xsd:string</para>
    ///   <para>skos:definition : bond issued specifically to fund climate or environmental projects^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : These bonds are typically asset-linked and backed by the issuer's balance sheet. Green bonds finance projects aimed at energy efficiency, pollution prevention, sustainable agriculture, fishery and forestry, the protection of aquatic and terrestrial ecosystems, clean transportation, sustainable water management and the cultivation of environmentally friendly technologies, and often include incentives such as tax exemption.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/GreenBond">fibo-sec-dbt-bnd:GreenBond</a>
    /// </summary>
    let GreenBond = _prefixId.prefix "GreenBond"
    /// <summary>
    ///   <para>rdfs:label : implicit full faith credit bond^^xsd:string</para>
    ///   <para>skos:definition : bond issued by a government sponsored agency or corporation rather than by the government directly^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : It doesn't carry an explicit full faith and credit guarantee but the market believes the government wouldn't let it default or fail.^^xsd:string</para>
    ///   <para>cmns-av:synonym : implicit full faith and credit bond^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ImplicitFullFaithCreditBond">fibo-sec-dbt-bnd:ImplicitFullFaithCreditBond</a>
    /// </summary>
    let ImplicitFullFaithCreditBond = _prefixId.prefix "ImplicitFullFaithCreditBond"
    /// <summary>
    ///   <para>rdfs:label : index-linked bond^^xsd:string</para>
    ///   <para>skos:definition : bond whose income may vary over time, because either the coupon rate or principal amount is related to a specific index, such as the Consumer Price Index^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/IndexLinkedBond">fibo-sec-dbt-bnd:IndexLinkedBond</a>
    /// </summary>
    let IndexLinkedBond = _prefixId.prefix "IndexLinkedBond"
    /// <summary>
    ///   <para>rdfs:label : inflation-linked bond^^xsd:string</para>
    ///   <para>skos:definition : bond indexed to inflation so that the principal or interest payments rise and fall with the rate of inflation^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : ILB^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Inflation-linked bonds are primarily issued by sovereign governments, such as the U.S. and the UK.^^xsd:string</para>
    ///   <para>cmns-av:synonym : inflation-indexed bond^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/InflationLinkedBond">fibo-sec-dbt-bnd:InflationLinkedBond</a>
    /// </summary>
    let InflationLinkedBond = _prefixId.prefix "InflationLinkedBond"
    /// <summary>
    ///   <para>rdfs:label : last regular coupon date^^xsd:string</para>
    ///   <para>skos:definition : scheduled date of the last regular coupon payment, that is the last of the payments that are made according to a regular repeating series of coupon periods, before any non-standard (long or short) final coupon period in the schedule^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/LastRegularCouponDate">fibo-sec-dbt-bnd:LastRegularCouponDate</a>
    /// </summary>
    let LastRegularCouponDate = _prefixId.prefix "LastRegularCouponDate"
    /// <summary>
    ///   <para>rdfs:label : listed bond^^xsd:string</para>
    ///   <para>skos:definition : bond that may be traded on an exchange^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Most exchange traded bonds are corporate bonds (but most corporate bonds are not exchange traded bonds).^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ListedBond">fibo-sec-dbt-bnd:ListedBond</a>
    /// </summary>
    let ListedBond = _prefixId.prefix "ListedBond"
    let LotteryConvention = _prefixId.prefix "LotteryConvention"
    /// <summary>
    ///   <para>rdfs:label : make whole call^^xsd:string</para>
    ///   <para>skos:definition : call allowing the issuer to pay off remaining debt early^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The issuer typically has to make a lump sum payment to the investor(s) derived from a formula based on the net present value (NPV) of future coupon payments that will not be paid incrementally because of the call combined with the principal payment the investor would have received at maturity.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MakeWholeCall">fibo-sec-dbt-bnd:MakeWholeCall</a>
    /// </summary>
    let MakeWholeCall = _prefixId.prefix "MakeWholeCall"
    /// <summary>
    ///   <para>rdfs:label : mandatory convertible bond^^xsd:string</para>
    ///   <para>skos:definition : convertible bond that converts into shares at maturity regardless of the equity price^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The conversion ratio at maturity reflects the equity price and par value of the bond when issued. There is also typically a second higher conversion ratio if the equity price rises above the strike during the term of the bond.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MandatoryConvertibleBond">fibo-sec-dbt-bnd:MandatoryConvertibleBond</a>
    /// </summary>
    let MandatoryConvertibleBond = _prefixId.prefix "MandatoryConvertibleBond"
    /// <summary>
    ///   <para>rdfs:label : medium term note^^xsd:string</para>
    ///   <para>skos:definition : bond issued over time under a shelf registration program, where each issue may have a different coupon and maturity typically ranging from one to ten years^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A medium-term note (MTN) is a debt note that usually matures (is paid back) in 5 to 10 years, but the term may be less than one year or as long as 100 years. They can be issued on a fixed or floating coupon basis.^^xsd:stringcmns-av:explanatoryNote : By shelf registration we mean the security registration process where an issuer registers in advance, and can issue lots of securities for up to three years.^^xsd:stringcmns-av:explanatoryNote : Medium term notes are typically issued by corporations and financial institutions, although GSEs also have MTN programs. MTNs may be issued under a shelf registration program which allows the company to issue bonds over time with varying maturities and coupons. Companies issue MTNs to have a more flexible source of funding. They may also issue MTN in response to 'reverse inquiry' by investors looking for bonds with specific maturities, issue size and coupon.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MediumTermNote">fibo-sec-dbt-bnd:MediumTermNote</a>
    /// </summary>
    let MediumTermNote = _prefixId.prefix "MediumTermNote"
    /// <summary>
    ///   <para>rdfs:label : municipal bond^^xsd:string</para>
    ///   <para>skos:definition : government bond that may be issued by a regional, rather than national, authority^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : muni^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Municipal bonds may be issued by states, cities, counties, special tax districts or special agencies or authorities of state or local governments.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalBond">fibo-sec-dbt-bnd:MunicipalBond</a>
    /// </summary>
    let MunicipalBond = _prefixId.prefix "MunicipalBond"
    /// <summary>
    ///   <para>rdfs:label : municipal debt funds usage^^xsd:string</para>
    ///   <para>skos:definition : official statement specifying how the funds raised via a new issue of municipal securities are to be applied^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalDebtFundsUsage">fibo-sec-dbt-bnd:MunicipalDebtFundsUsage</a>
    /// </summary>
    let MunicipalDebtFundsUsage = _prefixId.prefix "MunicipalDebtFundsUsage"
    /// <summary>
    ///   <para>rdfs:label : municipal debt remarketing agent^^xsd:string</para>
    ///   <para>skos:definition : municipal securities dealer responsible for reselling to investors securities (such as variable rate demand obligations and other tender option bonds) that have been tendered for purchase by their owner^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The remarketing agent also typically is responsible for resetting the interest rate for a variable rate issue and may act as tender agent.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalDebtRemarketingAgent">fibo-sec-dbt-bnd:MunicipalDebtRemarketingAgent</a>
    /// </summary>
    let MunicipalDebtRemarketingAgent = _prefixId.prefix "MunicipalDebtRemarketingAgent"
    /// <summary>
    ///   <para>rdfs:label : municipal debt source of funds^^xsd:string</para>
    ///   <para>skos:definition : official statement identifying the source of funds for a new issue of municipal securities^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalDebtSourceOfFunds">fibo-sec-dbt-bnd:MunicipalDebtSourceOfFunds</a>
    /// </summary>
    let MunicipalDebtSourceOfFunds = _prefixId.prefix "MunicipalDebtSourceOfFunds"
    /// <summary>
    ///   <para>rdfs:label : municipal note^^xsd:string</para>
    ///   <para>skos:definition : short-term obligation to repay a specified principal amount on a certain date, together with interest at a stated rate, usually payable from a defined source of anticipated revenues^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Notes usually mature in one year or less, although notes of longer maturities are also issued.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalNote">fibo-sec-dbt-bnd:MunicipalNote</a>
    /// </summary>
    let MunicipalNote = _prefixId.prefix "MunicipalNote"
    /// <summary>
    ///   <para>rdfs:label : municipal security^^xsd:string</para>
    ///   <para>skos:definition : debt obligation issued by a regional governmental entity^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A municipal security is typically a bond, note, warrant, certificate or other similar obligation issued by a state or local government or their agencies or authorities (such as cities, towns, villages, counties or special districts or authorities). A prime feature of most municipal securities is that interest or other investment earnings on them are generally excluded from gross income of the bondholder for federal income tax purposes. Some municipal securities are subject to federal income tax, although the issuers or bondholders may receive other federal tax advantages for certain types of taxable municipal securities. Some examples include Build America Bonds, municipal fund securities and direct pay subsidy bonds.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalSecurity">fibo-sec-dbt-bnd:MunicipalSecurity</a>
    /// </summary>
    let MunicipalSecurity = _prefixId.prefix "MunicipalSecurity"
    /// <summary>
    ///   <para>rdfs:label : municipal trustee^^xsd:string</para>
    ///   <para>skos:definition : financial institution with trust powers, designated by the issuer, that acts, pursuant to a bond contract, in a fiduciary capacity for the benefit of the bondholders in enforcing the terms of the bond contract^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In many cases, the trustee also acts as custodian, paying agent, registrar and/or transfer agent for the bonds.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/MunicipalTrustee">fibo-sec-dbt-bnd:MunicipalTrustee</a>
    /// </summary>
    let MunicipalTrustee = _prefixId.prefix "MunicipalTrustee"
    /// <summary>
    ///   <para>rdfs:label : original issue discount bond^^xsd:string</para>
    ///   <para>skos:definition : interest-bearing bond issued at a deep discount to face value^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : An original issue discount (OID) is the discount in price from a bond's face value at the time a bond or other debt instrument is first issued. The OID is the amount of discount or the difference between the original face value and the price paid for the bond.^^xsd:stringcmns-av:explanatoryNote : The principal amount accretes over time at a constant accrual rate and is redeemed at full face value at maturity.^^xsd:string</para>
    ///   <para>cmns-av:synonym : OID bond^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/OriginalIssueDiscountBond">fibo-sec-dbt-bnd:OriginalIssueDiscountBond</a>
    /// </summary>
    let OriginalIssueDiscountBond = _prefixId.prefix "OriginalIssueDiscountBond"
    /// <summary>
    ///   <para>rdfs:label : partial call^^xsd:string</para>
    ///   <para>skos:definition : call of part of an issue^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PartialCall">fibo-sec-dbt-bnd:PartialCall</a>
    /// </summary>
    let PartialCall = _prefixId.prefix "PartialCall"
    /// <summary>
    ///   <para>rdfs:label : partial call feature^^xsd:string</para>
    ///   <para>skos:definition : call feature whereby the issuer can recall part of the issue on scheduled dates, where bonds are selected to be called according to some rule, or by selecting various bonds at random^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PartialCallFeature">fibo-sec-dbt-bnd:PartialCallFeature</a>
    /// </summary>
    let PartialCallFeature = _prefixId.prefix "PartialCallFeature"

    /// <summary>
    ///   <para>rdfs:label : partial redemption allocation convention^^xsd:string</para>
    ///   <para>skos:definition : convention used to determine how the partial call will be actioned with respect to bond selection^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PartialRedemptionAllocationConvention">fibo-sec-dbt-bnd:PartialRedemptionAllocationConvention</a>
    /// </summary>
    let PartialRedemptionAllocationConvention =
        _prefixId.prefix "PartialRedemptionAllocationConvention"

    let PercentageCumulativeAverageValue =
        _prefixId.prefix "PercentageCumulativeAverageValue"

    let PercentageParValue = _prefixId.prefix "PercentageParValue"
    /// <summary>
    ///   <para>rdfs:label : perpetual bond^^xsd:string</para>
    ///   <para>skos:definition : bond that has no maturity date, i.e., one that pays interest in perpetuity^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Perpetual bonds function much like dividend-paying stocks or certain preferred securities. Just as the owner of the stock receives a dividend payment as long as the stock is held, the perpetual bond owner receives an interest payment as long as the bond is held.^^xsd:string</para>
    ///   <para>cmns-av:synonym : consul^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/PerpetualBond">fibo-sec-dbt-bnd:PerpetualBond</a>
    /// </summary>
    let PerpetualBond = _prefixId.prefix "PerpetualBond"
    let ProRataConvention = _prefixId.prefix "ProRataConvention"
    /// <summary>
    ///   <para>rdfs:label : rate basis convention^^xsd:string</para>
    ///   <para>skos:definition : basis for a percentage quoted rate as used in specifying bond call percentage amounts^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RateBasisConvention">fibo-sec-dbt-bnd:RateBasisConvention</a>
    /// </summary>
    let RateBasisConvention = _prefixId.prefix "RateBasisConvention"
    /// <summary>
    ///   <para>rdfs:label : redemption payment^^xsd:string</para>
    ///   <para>skos:definition : repayment event involving payment of a bond's principal amount at maturity or when it is called^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RedemptionPayment">fibo-sec-dbt-bnd:RedemptionPayment</a>
    /// </summary>
    let RedemptionPayment = _prefixId.prefix "RedemptionPayment"
    /// <summary>
    ///   <para>rdfs:label : redemption schedule^^xsd:string</para>
    ///   <para>skos:definition : repayment schedule whereby a given percentage of a bond issue is redeemed on predefined dates^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RedemptionSchedule">fibo-sec-dbt-bnd:RedemptionSchedule</a>
    /// </summary>
    let RedemptionSchedule = _prefixId.prefix "RedemptionSchedule"
    /// <summary>
    ///   <para>rdfs:label : regulatory call^^xsd:string</para>
    ///   <para>skos:definition : call triggered by some regulation-specific rule^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RegulatoryCall">fibo-sec-dbt-bnd:RegulatoryCall</a>
    /// </summary>
    let RegulatoryCall = _prefixId.prefix "RegulatoryCall"
    /// <summary>
    ///   <para>rdfs:label : remarketable bond^^xsd:string</para>
    ///   <para>skos:definition : corporate bond program where the coupon rate on outstanding bonds is periodically reset through an auction process^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A remarketing agent (dealer or underwriter) periodically surveys bond holders to identify those who want to sell bonds. The agent surveys market (or holds an auction) to determine interest rate at which the bonds can be resold. The rate on all outstanding bonds resets at the new rate. These programs are perpetual in the sense they often don't have a fixed maturity date, but the company can redeem them. If an auction fails, i.e., the agent can't place all the bonds then.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RemarketableBond">fibo-sec-dbt-bnd:RemarketableBond</a>
    /// </summary>
    let RemarketableBond = _prefixId.prefix "RemarketableBond"
    /// <summary>
    ///   <para>rdfs:label : revenue bond^^xsd:string</para>
    ///   <para>skos:definition : municipal bond supported by the revenue from a specific project^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Revenue bonds are municipal bonds that finance income-producing projects, such as toll bridges, highways, or local stadiums, and are secured by a specified revenue source. Typically, revenue bonds can be issued by any government agency or fund that is managed in the manner of a business, such as entities having both operating revenues and expenses.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/RevenueBond">fibo-sec-dbt-bnd:RevenueBond</a>
    /// </summary>
    let RevenueBond = _prefixId.prefix "RevenueBond"
    /// <summary>
    ///   <para>rdfs:label : secured bond^^xsd:string</para>
    ///   <para>skos:definition : bond that is backed by collateral, such as a tangible asset or income stream, in addition to a general promise to pay^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A secured bond may be collateralized by a claim on real assets, such as a factory or auto fleet; or by a claim on a revenue stream. A secured bond differs from a mortgage in that proceeds of the bond sale aren't used to acquire the asset.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SecuredBond">fibo-sec-dbt-bnd:SecuredBond</a>
    /// </summary>
    let SecuredBond = _prefixId.prefix "SecuredBond"
    /// <summary>
    ///   <para>rdfs:label : sinking fund amortization terms^^xsd:string</para>
    ///   <para>skos:definition : terms for the paydown of principal in a sinking fund type of amortizing security^^xsd:string</para>
    ///   <para>skos:editorialNote : At present there is only a schedule, there should be other terms for what happens on the scheduled dates. Sinking fund may be bullet e.g. x percent over year for y years. SF may be mandatory or contingent on some other economic event.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SinkingFundAmortizationTerms">fibo-sec-dbt-bnd:SinkingFundAmortizationTerms</a>
    /// </summary>
    let SinkingFundAmortizationTerms = _prefixId.prefix "SinkingFundAmortizationTerms"
    /// <summary>
    ///   <para>rdfs:label : sovereign bond^^xsd:string</para>
    ///   <para>skos:definition : bond issued by the government of a country^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Sovereign bonds issued by G20 developed countries are generally full faith and credit obligations. Sovereign bonds issued by emerging and developing countries may be issued in local currency or a G7 currency, and may either be full faith and credit (unsecured) or secured.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SovereignBond">fibo-sec-dbt-bnd:SovereignBond</a>
    /// </summary>
    let SovereignBond = _prefixId.prefix "SovereignBond"
    /// <summary>
    ///   <para>rdfs:label : sovereign debt instrument^^xsd:string</para>
    ///   <para>skos:definition : debt security issued by the government of a country^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SovereignDebtInstrument">fibo-sec-dbt-bnd:SovereignDebtInstrument</a>
    /// </summary>
    let SovereignDebtInstrument = _prefixId.prefix "SovereignDebtInstrument"
    /// <summary>
    ///   <para>rdfs:label : special assessment bond^^xsd:string</para>
    ///   <para>skos:definition : municipal bond used to fund a development project that is payable from the revenues of an assessment (tax) on the community that is intended to benefit from the project^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A special assessment is a charge imposed against a property in a particular locality because that property receives a special benefit by virtue of some public improvement, separate and apart from the general benefit accruing to the public at large. Special assessments may be apportioned according to the value of the benefit received, rather than merely the cost of the improvement.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SpecialAssessmentBond">fibo-sec-dbt-bnd:SpecialAssessmentBond</a>
    /// </summary>
    let SpecialAssessmentBond = _prefixId.prefix "SpecialAssessmentBond"
    /// <summary>
    ///   <para>rdfs:label : special obligation bond^^xsd:string</para>
    ///   <para>skos:definition : bond secured by a limited revenue source, such as receipts derived from a designated project^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SpecialObligationBond">fibo-sec-dbt-bnd:SpecialObligationBond</a>
    /// </summary>
    let SpecialObligationBond = _prefixId.prefix "SpecialObligationBond"
    /// <summary>
    ///   <para>rdfs:label : special tax bond^^xsd:string</para>
    ///   <para>skos:definition : bond secured by revenues derived from designated taxes other than ad valorem taxes^^xsd:string</para>
    ///   <para>skos:example : For example, bonds for a particular purpose might be supported by sales, cigarette, fuel or business license taxes.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SpecialTaxBond">fibo-sec-dbt-bnd:SpecialTaxBond</a>
    /// </summary>
    let SpecialTaxBond = _prefixId.prefix "SpecialTaxBond"
    /// <summary>
    ///   <para>rdfs:label : step up bond^^xsd:string</para>
    ///   <para>skos:definition : bond with a coupon that increases (steps up) while the bond is outstanding^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The step change may be one time, or occur according to a schedule or at regular intervals.^^xsd:string</para>
    ///   <para>cmns-av:synonym : step down bond^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/StepUpBond">fibo-sec-dbt-bnd:StepUpBond</a>
    /// </summary>
    let StepUpBond = _prefixId.prefix "StepUpBond"
    /// <summary>
    ///   <para>rdfs:label : stepped coupon terms^^xsd:string</para>
    ///   <para>skos:definition : coupon payment terms for securities with a coupon that increases (steps up) while the bond is outstanding^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/SteppedCouponTerms">fibo-sec-dbt-bnd:SteppedCouponTerms</a>
    /// </summary>
    let SteppedCouponTerms = _prefixId.prefix "SteppedCouponTerms"
    /// <summary>
    ///   <para>rdfs:label : strip bond^^xsd:string</para>
    ///   <para>skos:definition : bond that is part of a series of bonds formed by selling each interest payment and the principal amount of a bond as separate zero coupon bonds.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/StripBond">fibo-sec-dbt-bnd:StripBond</a>
    /// </summary>
    let StripBond = _prefixId.prefix "StripBond"
    /// <summary>
    ///   <para>rdfs:label : tax allocation bond^^xsd:string</para>
    ///   <para>skos:definition : bond payable from the incremental increase in tax revenues realized from any increase in property value and other economic activity, often designed to capture the economic benefit resulting from a bond financing^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Tax increment bonds, also known as tax allocation bonds, often are used to finance the redevelopment of blighted areas.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TaxAllocationBond">fibo-sec-dbt-bnd:TaxAllocationBond</a>
    /// </summary>
    let TaxAllocationBond = _prefixId.prefix "TaxAllocationBond"
    /// <summary>
    ///   <para>rdfs:label : treasury bill^^xsd:string</para>
    ///   <para>skos:definition : short-term zero coupon treasury obligation with a maturity ranging from one to twelve months^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : T-bill^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The pricing of T-bills is unique among U.S. government debt issues. Treasury bills are offered in multiples of $100 and in terms ranging from a few days to 52 weeks. Rather than providing interest payments as Treasury Bonds or Notes do, T-bills are sold at a discount, and the entire return is realized upon maturity. The price of a bill is determined at auction. The annualized interest rate earned on T-bills is equal to the difference between the purchase price and maturity value, divided by the maturity value.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TreasuryBill">fibo-sec-dbt-bnd:TreasuryBill</a>
    /// </summary>
    let TreasuryBill = _prefixId.prefix "TreasuryBill"
    /// <summary>
    ///   <para>rdfs:label : treasury bond^^xsd:string</para>
    ///   <para>skos:definition : long term term coupon bearing treasury obligation issued in terms of 20 years or 30 years that pays interest every six months until they mature^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TreasuryBond">fibo-sec-dbt-bnd:TreasuryBond</a>
    /// </summary>
    let TreasuryBond = _prefixId.prefix "TreasuryBond"

    /// <summary>
    ///   <para>rdfs:label : treasury inflation-protected security^^xsd:string</para>
    ///   <para>skos:definition : variable income bond whose principal is indexed to inflation or deflation and thus changes over the life of the security^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : TIPS^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Treasury Inflation-Protected Securities, or TIPS, provide protection against inflation. The principal of a TIPS increases with inflation and decreases with deflation, as measured by the Consumer Price Index. When a TIPS matures, you are paid the adjusted principal or original principal, whichever is greater.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TreasuryInflationProtectedSecurity">fibo-sec-dbt-bnd:TreasuryInflationProtectedSecurity</a>
    /// </summary>
    let TreasuryInflationProtectedSecurity =
        _prefixId.prefix "TreasuryInflationProtectedSecurity"

    /// <summary>
    ///   <para>rdfs:label : treasury note^^xsd:string</para>
    ///   <para>skos:definition : medium term coupon bearing treasury obligation with original maturity ranging from two to ten years^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/TreasuryNote">fibo-sec-dbt-bnd:TreasuryNote</a>
    /// </summary>
    let TreasuryNote = _prefixId.prefix "TreasuryNote"
    /// <summary>
    ///   <para>rdfs:label : U.K. Government security^^xsd:string</para>
    ///   <para>skos:definition : debt instrument issued by HM Treasury and listed on the London Stock Exchange^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : If a private investor wishes to purchase gilts the secondary market can be accessed through a stockbroker, bank or the DMO's Purchase and Sale Service.^^xsd:stringcmns-av:explanatoryNote : The term 'gilt' or 'gilt-edged security' is a reference to the primary characteristic of gilts as an investment: their security. This is a reflection of the fact that the British Government has never failed to make interest or principal payments on gilts as they fall due.^^xsd:string</para>
    ///   <para>cmns-av:synonym : gilt^^xsd:stringcmns-av:synonym : gilt-edged security^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/UKGovernmentSecurity">fibo-sec-dbt-bnd:UKGovernmentSecurity</a>
    /// </summary>
    let UKGovernmentSecurity = _prefixId.prefix "UKGovernmentSecurity"
    /// <summary>
    ///   <para>rdfs:label : U.S. Treasury security^^xsd:string</para>
    ///   <para>skos:definition : debt instrument issued by the United States Department of the Treasury that carries a full faith and credit guarantee^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/USTreasurySecurity">fibo-sec-dbt-bnd:USTreasurySecurity</a>
    /// </summary>
    let USTreasurySecurity = _prefixId.prefix "USTreasurySecurity"
    /// <summary>
    ///   <para>rdfs:label : unlisted bond^^xsd:string</para>
    ///   <para>skos:definition : bond that is traded over the counter rather than via an exchange or other listing facility^^xsd:string</para>
    ///   <para>cmns-av:synonym : OTC Bond^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/UnlistedBond">fibo-sec-dbt-bnd:UnlistedBond</a>
    /// </summary>
    let UnlistedBond = _prefixId.prefix "UnlistedBond"
    /// <summary>
    ///   <para>rdfs:label : unsecured bond^^xsd:string</para>
    ///   <para>skos:definition : bond that is only secured by the bond issuer's good credit standing^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Most unsecured bonds pose limited risk of default, as the organizations that issue them are typically financially sound.^^xsd:string</para>
    ///   <para>cmns-av:synonym : debenture^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/UnsecuredBond">fibo-sec-dbt-bnd:UnsecuredBond</a>
    /// </summary>
    let UnsecuredBond = _prefixId.prefix "UnsecuredBond"
    /// <summary>
    ///   <para>rdfs:label : variable coupon bond^^xsd:string</para>
    ///   <para>skos:definition : bond that has a floating interest rate^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The rate adjusts according to a predetermined formula outlined in the bond's prospectus or official statement.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableCouponBond">fibo-sec-dbt-bnd:VariableCouponBond</a>
    /// </summary>
    let VariableCouponBond = _prefixId.prefix "VariableCouponBond"
    /// <summary>
    ///   <para>rdfs:label : variable coupon terms^^xsd:string</para>
    ///   <para>skos:definition : contractual terms specifying the calculation of the interest rate for a variable coupon bond^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableCouponTerms">fibo-sec-dbt-bnd:VariableCouponTerms</a>
    /// </summary>
    let VariableCouponTerms = _prefixId.prefix "VariableCouponTerms"
    /// <summary>
    ///   <para>rdfs:label : variable debt principal^^xsd:string</para>
    ///   <para>skos:definition : principal that is defined in relation to some variable and so varies over time, as principal^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Not the same as principal paydown. This is when the principal itself varies over time, usually as a result of being defined in relation to some index such as an inflation index. Forms the debt principal in instruments such as inflation bonds.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableDebtPrincipal">fibo-sec-dbt-bnd:VariableDebtPrincipal</a>
    /// </summary>
    let VariableDebtPrincipal = _prefixId.prefix "VariableDebtPrincipal"
    /// <summary>
    ///   <para>rdfs:label : variable income bond^^xsd:string</para>
    ///   <para>skos:definition : bond whose income may vary over time, because either the coupon rate or principal amount changes in line with an index or schedule over the life of the security^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableIncomeBond">fibo-sec-dbt-bnd:VariableIncomeBond</a>
    /// </summary>
    let VariableIncomeBond = _prefixId.prefix "VariableIncomeBond"

    /// <summary>
    ///   <para>rdfs:label : variable interest calculation formula^^xsd:string</para>
    ///   <para>skos:definition : formula for the calculation of variable interest^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableInterestCalculationFormula">fibo-sec-dbt-bnd:VariableInterestCalculationFormula</a>
    /// </summary>
    let VariableInterestCalculationFormula =
        _prefixId.prefix "VariableInterestCalculationFormula"

    /// <summary>
    ///   <para>rdfs:label : variable interest expression^^xsd:string</para>
    ///   <para>skos:definition : an expression used to determine a variable interest payment amount^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariableInterestExpression">fibo-sec-dbt-bnd:VariableInterestExpression</a>
    /// </summary>
    let VariableInterestExpression = _prefixId.prefix "VariableInterestExpression"
    /// <summary>
    ///   <para>rdfs:label : variable principal bond^^xsd:string</para>
    ///   <para>skos:definition : bond whose principal adjusts over time with changes in an index^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The principal on variable principal bonds adjusts line with an index such as inflation or GDP. For example, for a bond linked to the CPI, if inflation rises two percent the principal increases by 2 percent. The coupon rate is typically fixed. The best-known example is TIPS or Treasury Inflation Protected Bonds, which are linked to the CPI. TIPs offer a real or inflation adjusted rate of return.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/VariablePrincipalBond">fibo-sec-dbt-bnd:VariablePrincipalBond</a>
    /// </summary>
    let VariablePrincipalBond = _prefixId.prefix "VariablePrincipalBond"
    /// <summary>
    ///   <para>rdfs:label : zero coupon bond^^xsd:string</para>
    ///   <para>skos:definition : bond issued with a coupon rate of zero and that trades at a deep discount to face value^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Fannie Mae also issues zero-coupon callable debt securities. Zero-coupon notes are debt securities on which no coupon interest is paid to the investor. Rather, the security is purchased at a discounted dollar price and matures at par. If the option on a callable zero-coupon security is exercised, it is redeemed at a higher dollar price than the original issue price. The yield for a callable zero-coupon security is based on the difference between the original discounted price and the principal payment at the call date.^^xsd:stringcmns-av:explanatoryNote : The principal amount accretes over time at a constant accrual rate and is redeemed at full face value at maturity. In effect, the accrual rate is the coupon rate or yield which is added to the outstanding principal rather than being paid out to investors.^^xsd:string</para>
    ///   <para>cmns-av:synonym : z-bond^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ZeroCouponBond">fibo-sec-dbt-bnd:ZeroCouponBond</a>
    /// </summary>
    let ZeroCouponBond = _prefixId.prefix "ZeroCouponBond"
    /// <summary>
    ///   <para>rdfs:label : zero coupon terms^^xsd:string</para>
    ///   <para>skos:definition : terms for payment of interest on a zero coupon bond^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/ZeroCouponTerms">fibo-sec-dbt-bnd:ZeroCouponTerms</a>
    /// </summary>
    let ZeroCouponTerms = _prefixId.prefix "ZeroCouponTerms"
    let ZeroInterestRate = _prefixId.prefix "ZeroInterestRate"
    /// <summary>
    ///   <para>rdfs:label : has award date^^xsd:string</para>
    ///   <para>skos:definition : specifies the date on which bonds are awarded to the lead manager or syndicate on negotiated deals, or the date of bidding on competitive deals^^xsd:string</para>
    ///   <para>cmns-av:synonym : has sale date^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasAwardDate">fibo-sec-dbt-bnd:hasAwardDate</a>
    /// </summary>
    let hasAwardDate = _prefixId.prefix "hasAwardDate"
    /// <summary>
    ///   <para>rdfs:label : has call price^^xsd:string</para>
    ///   <para>skos:definition : indicates the amount of the call on the specified call date, typically the sum of par value and the call premium, as specified in the contract^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This is the price a bond issuer or preferred stock issuer must pay investors to buy back, or call, all or part of an issue before the maturity date.^^xsd:string</para>
    ///   <para>cmns-av:synonym : has redemption price^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasCallPrice">fibo-sec-dbt-bnd:hasCallPrice</a>
    /// </summary>
    let hasCallPrice = _prefixId.prefix "hasCallPrice"
    /// <summary>
    ///   <para>rdfs:label : has call rate basis^^xsd:string</para>
    ///   <para>skos:definition : for each call event on the schedule, indicates whether the rate is expressed as a percentage of par or percentage of percentage of cumulative average value (CAV)^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Zero coupon bonds and OID bonds are callable at an accreted value.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasCallRateBasis">fibo-sec-dbt-bnd:hasCallRateBasis</a>
    /// </summary>
    let hasCallRateBasis = _prefixId.prefix "hasCallRateBasis"
    /// <summary>
    ///   <para>rdfs:label : has ceiling^^xsd:string</para>
    ///   <para>skos:definition : indicates the maximum variable interest payment amount^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasCeiling">fibo-sec-dbt-bnd:hasCeiling</a>
    /// </summary>
    let hasCeiling = _prefixId.prefix "hasCeiling"
    /// <summary>
    ///   <para>rdfs:label : has convertible date^^xsd:string</para>
    ///   <para>skos:definition : date on which a bond can be converted into the specified equity security^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasConvertibleDate">fibo-sec-dbt-bnd:hasConvertibleDate</a>
    /// </summary>
    let hasConvertibleDate = _prefixId.prefix "hasConvertibleDate"

    /// <summary>
    ///   <para>rdfs:label : has extraordinary redemption provision^^xsd:string</para>
    ///   <para>skos:definition : relates the redemption provision of a debt instrument to one-time provision that may be exercised by the issuer under certain circumstances^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasExtraordinaryRedemptionProvision">fibo-sec-dbt-bnd:hasExtraordinaryRedemptionProvision</a>
    /// </summary>
    let hasExtraordinaryRedemptionProvision =
        _prefixId.prefix "hasExtraordinaryRedemptionProvision"

    /// <summary>
    ///   <para>rdfs:label : has final maturity date^^xsd:string</para>
    ///   <para>skos:definition : indicates the final payment date of a financial instrument, at which point the principal (and all remaining interest) is due to be paid^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFinalMaturityDate">fibo-sec-dbt-bnd:hasFinalMaturityDate</a>
    /// </summary>
    let hasFinalMaturityDate = _prefixId.prefix "hasFinalMaturityDate"
    /// <summary>
    ///   <para>rdfs:label : has first call price^^xsd:string</para>
    ///   <para>skos:definition : indicates the amount of the call on the first call date as specified in the call schedule^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstCallPrice">fibo-sec-dbt-bnd:hasFirstCallPrice</a>
    /// </summary>
    let hasFirstCallPrice = _prefixId.prefix "hasFirstCallPrice"
    /// <summary>
    ///   <para>rdfs:label : has first coupon payment date^^xsd:string</para>
    ///   <para>skos:definition : specifies the first date on which the issuer or its agent expects or commits to make a coupon payment^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The first coupon date sometimes occurs at an irregular time; that is, if the bond pays coupons every six months, the first coupon period may be longer or shorter than six months.cmns-av:explanatoryNote : The first coupon payment period can be long or short when this date doesn't coincide with the start of a normal coupon payment period.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstCouponPaymentDate">fibo-sec-dbt-bnd:hasFirstCouponPaymentDate</a>
    /// </summary>
    let hasFirstCouponPaymentDate = _prefixId.prefix "hasFirstCouponPaymentDate"
    /// <summary>
    ///   <para>rdfs:label : has first par call date^^xsd:string</para>
    ///   <para>skos:definition : indicates the first date on which the bond may be called at par for redemption^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstParCallDate">fibo-sec-dbt-bnd:hasFirstParCallDate</a>
    /// </summary>
    let hasFirstParCallDate = _prefixId.prefix "hasFirstParCallDate"
    /// <summary>
    ///   <para>rdfs:label : has first par call price^^xsd:string</para>
    ///   <para>skos:definition : specifies the amount of the call on the first par call date as specified in the call schedule^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstParCallPrice">fibo-sec-dbt-bnd:hasFirstParCallPrice</a>
    /// </summary>
    let hasFirstParCallPrice = _prefixId.prefix "hasFirstParCallPrice"
    /// <summary>
    ///   <para>rdfs:label : has first premium call date^^xsd:string</para>
    ///   <para>skos:definition : indicates the first date on which the bond may be called for redemption at a price above par^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstPremiumCallDate">fibo-sec-dbt-bnd:hasFirstPremiumCallDate</a>
    /// </summary>
    let hasFirstPremiumCallDate = _prefixId.prefix "hasFirstPremiumCallDate"
    /// <summary>
    ///   <para>rdfs:label : has first premium call price^^xsd:string</para>
    ///   <para>skos:definition : specifies the amount of the call on the first call date on which the bond may be called at a price above par as specified in the call schedule^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstPremiumCallPrice">fibo-sec-dbt-bnd:hasFirstPremiumCallPrice</a>
    /// </summary>
    let hasFirstPremiumCallPrice = _prefixId.prefix "hasFirstPremiumCallPrice"
    /// <summary>
    ///   <para>rdfs:label : has first put date^^xsd:string</para>
    ///   <para>skos:definition : indicates the initial date on which the holder may sell the bond to the issuer prior to maturity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstPutDate">fibo-sec-dbt-bnd:hasFirstPutDate</a>
    /// </summary>
    let hasFirstPutDate = _prefixId.prefix "hasFirstPutDate"
    /// <summary>
    ///   <para>rdfs:label : has first put price^^xsd:string</para>
    ///   <para>skos:definition : specifies the initial price at which the holder may sell the bond to the issuer prior to maturity^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFirstPutPrice">fibo-sec-dbt-bnd:hasFirstPutPrice</a>
    /// </summary>
    let hasFirstPutPrice = _prefixId.prefix "hasFirstPutPrice"
    /// <summary>
    ///   <para>rdfs:label : has floor^^xsd:string</para>
    ///   <para>skos:definition : indicates the minimum variable interest payment amount^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFloor">fibo-sec-dbt-bnd:hasFloor</a>
    /// </summary>
    let hasFloor = _prefixId.prefix "hasFloor"
    /// <summary>
    ///   <para>rdfs:label : has funding source^^xsd:string</para>
    ///   <para>skos:definition : indicates the source of funds for a new issue of municipal securities^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasFundingSource">fibo-sec-dbt-bnd:hasFundingSource</a>
    /// </summary>
    let hasFundingSource = _prefixId.prefix "hasFundingSource"
    /// <summary>
    ///   <para>rdfs:label : has last coupon payment date^^xsd:string</para>
    ///   <para>skos:definition : specifies the final date on which the issuer expects to make a final coupon payment^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The last coupon date sometimes occurs at an irregular time; that is, if the bond pays coupons every six months, the last coupon period may be longer or shorter than six months.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasLastCouponPaymentDate">fibo-sec-dbt-bnd:hasLastCouponPaymentDate</a>
    /// </summary>
    let hasLastCouponPaymentDate = _prefixId.prefix "hasLastCouponPaymentDate"
    /// <summary>
    ///   <para>rdfs:label : has lockout period^^xsd:string</para>
    ///   <para>skos:definition : indicates the period of time for which a callable security cannot be called and only interest coupon payments are received by the security holder^^xsd:string</para>
    ///   <para>skos:example : With a 10-year noncall 3-year ("10nc3") debt security, the security cannot be called for the first three years.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasLockoutPeriod">fibo-sec-dbt-bnd:hasLockoutPeriod</a>
    /// </summary>
    let hasLockoutPeriod = _prefixId.prefix "hasLockoutPeriod"
    /// <summary>
    ///   <para>rdfs:label : has municipal trustee^^xsd:string</para>
    ///   <para>skos:definition : specifies the financial institution with trust powers, designated by the issuer, that acts, pursuant to a bond contract, in a fiduciary capacity for the benefit of the bondholders in enforcing the terms of the bond contract^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasMunicipalTrustee">fibo-sec-dbt-bnd:hasMunicipalTrustee</a>
    /// </summary>
    let hasMunicipalTrustee = _prefixId.prefix "hasMunicipalTrustee"

    /// <summary>
    ///   <para>rdfs:label : has original issue discount amount^^xsd:string</para>
    ///   <para>skos:definition : indicates the difference between the stated redemption price at maturity and the issue price^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasOriginalIssueDiscountAmount">fibo-sec-dbt-bnd:hasOriginalIssueDiscountAmount</a>
    /// </summary>
    let hasOriginalIssueDiscountAmount =
        _prefixId.prefix "hasOriginalIssueDiscountAmount"

    /// <summary>
    ///   <para>rdfs:label : has partial redemption allocation convention^^xsd:string</para>
    ///   <para>skos:definition : indicates the convention used to determine how the redemption is allocated over the set of bond holders^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPartialRedemptionAllocationConvention">fibo-sec-dbt-bnd:hasPartialRedemptionAllocationConvention</a>
    /// </summary>
    let hasPartialRedemptionAllocationConvention =
        _prefixId.prefix "hasPartialRedemptionAllocationConvention"

    /// <summary>
    ///   <para>rdfs:label : has penultimate coupon payment date^^xsd:string</para>
    ///   <para>skos:definition : specifies the last coupon payment prior to maturity^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : This is important since the securities processing area needs to start its procedures in anticipation of maturity. For zero coupon bonds, it is the last compounding date prior to maturity.</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPenultimateCouponPaymentDate">fibo-sec-dbt-bnd:hasPenultimateCouponPaymentDate</a>
    /// </summary>
    let hasPenultimateCouponPaymentDate =
        _prefixId.prefix "hasPenultimateCouponPaymentDate"

    /// <summary>
    ///   <para>rdfs:label : has premium amount^^xsd:string</para>
    ///   <para>skos:definition : indicates the premium paid to a bond holder when the bond is called^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPremiumAmount">fibo-sec-dbt-bnd:hasPremiumAmount</a>
    /// </summary>
    let hasPremiumAmount = _prefixId.prefix "hasPremiumAmount"
    /// <summary>
    ///   <para>rdfs:label : has put date^^xsd:string</para>
    ///   <para>skos:definition : indicates the date on which a security is subject to redemption by the bond holder^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPutDate">fibo-sec-dbt-bnd:hasPutDate</a>
    /// </summary>
    let hasPutDate = _prefixId.prefix "hasPutDate"
    /// <summary>
    ///   <para>rdfs:label : has put frequency^^xsd:string</para>
    ///   <para>skos:definition : indicates the recurring window of time in which the put feature can be exercised^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasPutFrequency">fibo-sec-dbt-bnd:hasPutFrequency</a>
    /// </summary>
    let hasPutFrequency = _prefixId.prefix "hasPutFrequency"
    /// <summary>
    ///   <para>rdfs:label : has redemption amount^^xsd:string</para>
    ///   <para>skos:definition : indicates the amount of the principal paid with a redemption payment^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasRedemptionAmount">fibo-sec-dbt-bnd:hasRedemptionAmount</a>
    /// </summary>
    let hasRedemptionAmount = _prefixId.prefix "hasRedemptionAmount"
    /// <summary>
    ///   <para>rdfs:label : has remarketing agent^^xsd:string</para>
    ///   <para>skos:definition : identifies the dealer responsible for reselling to investors securities (such as variable rate demand obligations and other tender option bonds) that have been tendered for purchase by their owner.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasRemarketingAgent">fibo-sec-dbt-bnd:hasRemarketingAgent</a>
    /// </summary>
    let hasRemarketingAgent = _prefixId.prefix "hasRemarketingAgent"
    /// <summary>
    ///   <para>rdfs:label : has reset date offset^^xsd:string</para>
    ///   <para>skos:definition : indicates the offset from the coupon payment date on which the rate is reset^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/hasResetDateOffset">fibo-sec-dbt-bnd:hasResetDateOffset</a>
    /// </summary>
    let hasResetDateOffset = _prefixId.prefix "hasResetDateOffset"
    /// <summary>
    ///   <para>rdfs:label : is bank qualified^^xsd:string</para>
    ///   <para>skos:definition : indicates whether or not a given municipal bond conforms with section 265(b)(3) of the IRS tax code; when purchased by a commercial bank for its portfolio, such designation allows the bank to deduct a portion of the interest cost of carry for the position^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A bond that is bank qualified is also known as a qualified tax-exempt obligation.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isBankQualified">fibo-sec-dbt-bnd:isBankQualified</a>
    /// </summary>
    let isBankQualified = _prefixId.prefix "isBankQualified"
    /// <summary>
    ///   <para>rdfs:label : is legal opinion available^^xsd:string</para>
    ///   <para>skos:definition : indicates whether a legal opinion exists for a given municipal bond^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isLegalOpinionAvailable">fibo-sec-dbt-bnd:isLegalOpinionAvailable</a>
    /// </summary>
    let isLegalOpinionAvailable = _prefixId.prefix "isLegalOpinionAvailable"
    /// <summary>
    ///   <para>rdfs:label : is linked to fallback^^xsd:string</para>
    ///   <para>skos:definition : relates an index-linked instrument to a government bond that may be selected by a calculation agent^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Fallback Bond means, in relation to an Inflation Index applicable to an Inflation Linked Note, a bond selected by the Calculation Agent and issued by the government or one of the governments (but not any government agency) of the country (or countries) to whose level of inflation the Inflation Index relates and which pays a coupon and/or redemption amount which is calculated by reference to the Inflation Index, with a maturity date which falls on the same day as the Maturity Date of the Inflation Linked Notes, or such other date as the Calculation Agent shall select if there is no such bond maturing on the Maturity Date of the Inflation Linked Notes. If any bond so selected is redeemed, the Calculation Agent will select a new Fallback Bond on the same basis, but selected from all eligible bonds in issue at the time the original Fallback Bond is redeemed (including any bond for which the redeemed bond is exchanged). Note the rate of the fallback bond is used as a substitute for the inflation index if, for example, it is no longer published.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isLinkedToFallback">fibo-sec-dbt-bnd:isLinkedToFallback</a>
    /// </summary>
    let isLinkedToFallback = _prefixId.prefix "isLinkedToFallback"
    /// <summary>
    ///   <para>rdfs:label : is mandatory^^xsd:string</para>
    ///   <para>skos:definition : indicates whether something is required^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isMandatory">fibo-sec-dbt-bnd:isMandatory</a>
    /// </summary>
    let isMandatory = _prefixId.prefix "isMandatory"
    /// <summary>
    ///   <para>rdfs:label : is pro-rated^^xsd:string</para>
    ///   <para>skos:definition : indicates whether the coupon is pro rated to the actual number of days in the payment period versus the number of payment periods^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isProRated">fibo-sec-dbt-bnd:isProRated</a>
    /// </summary>
    let isProRated = _prefixId.prefix "isProRated"
    /// <summary>
    ///   <para>rdfs:label : super sinker^^xsd:string</para>
    ///   <para>skos:definition : indicates that the bond has a long-term coupon but short potential short maturity^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Super-sinker is a colloquial term for a term maturity, usually from a single family mortgage revenue issue with several term maturities, that will be the first to be called from a sinking fund into which all proceeds from prepayments of mortgages financed by the issue are deposited. The maturity's priority status under the call provisions means that it is likely to be redeemed in its entirety well before the stated maturity date.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/isSuperSinker">fibo-sec-dbt-bnd:isSuperSinker</a>
    /// </summary>
    let isSuperSinker = _prefixId.prefix "isSuperSinker"
