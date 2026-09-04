#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-tr-tr`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/" "fibo-be-tr-tr"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : irrevocable trust^^xsd:string</para>
    ///   <para>skos:definition : trust that cannot be modified, amended or terminated except under certain legal circumstances and typically not without the permission of the grantor's named beneficiary or beneficiaries^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Irrevocable trusts also offer asset protection from future creditors and lawsuits.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/IrrevocableTrust">fibo-be-tr-tr:IrrevocableTrust</a>
    /// </summary>
    let IrrevocableTrust = _prefixId.prefix "IrrevocableTrust"
    /// <summary>
    ///   <para>rdfs:label : living trust^^xsd:string</para>
    ///   <para>skos:definition : trust created during an individual's lifetime where a designated person, the trustee, is given responsibility for managing that individual's assets for the benefit of the eventual beneficiary^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A living trust is designed to allow for the easy transfer of the trust creator or settlor's assets while bypassing the often complex and expensive legal process of probate. Living trust agreements designate a trustee who holds legal possession of assets and property that flow into the trust.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/LivingTrust">fibo-be-tr-tr:LivingTrust</a>
    /// </summary>
    let LivingTrust = _prefixId.prefix "LivingTrust"
    /// <summary>
    ///   <para>rdfs:label : revocable trust^^xsd:string</para>
    ///   <para>skos:definition : trust in which legal ownership of the trust property is transferred to the trustee, but the trustor retains full power to revoke, modify or amend the trust^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/RevocableTrust">fibo-be-tr-tr:RevocableTrust</a>
    /// </summary>
    let RevocableTrust = _prefixId.prefix "RevocableTrust"
    /// <summary>
    ///   <para>rdfs:label : testamentary trust^^xsd:string</para>
    ///   <para>skos:definition : trust established in accordance with the instructions contained in a last will and testament^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A will could have more than one testamentary trust. The trustee named is responsible for managing and distributing the trustor's assets to the beneficiaries as directed in the will. Sometimes called a will trust, the testamentary trust is irrevocable.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/TestamentaryTrust">fibo-be-tr-tr:TestamentaryTrust</a>
    /// </summary>
    let TestamentaryTrust = _prefixId.prefix "TestamentaryTrust"
    /// <summary>
    ///   <para>rdfs:label : trust^^xsd:string</para>
    ///   <para>skos:definition : fiduciary relationship and legal entity in which one party, known as a trustor, gives another party, the trustee, the right to hold title to and manage assets for the benefit of a third party, the beneficiary^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/Trust">fibo-be-tr-tr:Trust</a>
    /// </summary>
    let Trust = _prefixId.prefix "Trust"
    /// <summary>
    ///   <para>rdfs:label : trust agreement^^xsd:string</para>
    ///   <para>skos:definition : formal agreement that establishes a trust, whereby the trustor(s) gives the trustee(s) the responsibility to hold and manage assets for the beneficiary(ies)^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A trust agreement typically states the (1) purpose for which the trust was established and fulfillment of which will terminate the trust, (2) details of the assets placed in the trust, (3) powers and limitations of the trustees, their reporting requirements, and other associated provisions, and (4) may also specify the trustees' compensation, if any. A trust agreement involving real estate requires its exact description and the trustor's express, written consent to create the trust to be valid.^^xsd:string</para>
    ///   <para>cmns-av:synonym : trust deed^^xsd:stringcmns-av:synonym : trust document^^xsd:stringcmns-av:synonym : trust instrument^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/TrustAgreement">fibo-be-tr-tr:TrustAgreement</a>
    /// </summary>
    let TrustAgreement = _prefixId.prefix "TrustAgreement"
    /// <summary>
    ///   <para>rdfs:label : trust beneficiary^^xsd:string</para>
    ///   <para>skos:definition : party for whose interest (benefit) an annuity, assignment (such as a letter of credit), contract, insurance policy, judgment, promise, trust, will, etc., is made^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/TrustBeneficiary">fibo-be-tr-tr:TrustBeneficiary</a>
    /// </summary>
    let TrustBeneficiary = _prefixId.prefix "TrustBeneficiary"
    /// <summary>
    ///   <para>rdfs:label : trust fund manager^^xsd:string</para>
    ///   <para>skos:definition : party empowered to act on behalf of the trustee to manage the assets of the trust^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/TrustFundManager">fibo-be-tr-tr:TrustFundManager</a>
    /// </summary>
    let TrustFundManager = _prefixId.prefix "TrustFundManager"
    /// <summary>
    ///   <para>rdfs:label : trustee^^xsd:string</para>
    ///   <para>skos:definition : party that holds and manages assets for the benefit of another^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The trustee is legally obliged to make all trust-related decisions with the beneficiary's interests in mind, and may be liable for damages in the event of not doing so. Trustees may be entitled to a payment for their services, if specified in the trust agreement. In the specific case of the bond market, a trustee administers a bond issue for a borrower, and ensures that the issuer meets all the terms and conditions associated with the borrowing.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/Trustee">fibo-be-tr-tr:Trustee</a>
    /// </summary>
    let Trustee = _prefixId.prefix "Trustee"
    /// <summary>
    ///   <para>rdfs:label : trustor^^xsd:string</para>
    ///   <para>skos:definition : party that establishes a trust and places property under the protection and management of one or more trustees for the benefit of at least one beneficiary^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : It is not always necessary to identify the trustor who may be also be a trustee and/or one of the beneficiaries. In legal parlance, a trustor is called a settlor in the UK and a grantor in the US, whereas in common usage he or she may also be called a creator, donor, initiator, owner, or trust maker.^^xsd:string</para>
    ///   <para>cmns-av:synonym : grantor^^xsd:stringcmns-av:synonym : settlor^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/Trustor">fibo-be-tr-tr:Trustor</a>
    /// </summary>
    let Trustor = _prefixId.prefix "Trustor"
    /// <summary>
    ///   <para>rdfs:label : has trustee^^xsd:string</para>
    ///   <para>skos:definition : links a trust to a named trustee^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/hasTrustee">fibo-be-tr-tr:hasTrustee</a>
    /// </summary>
    let hasTrustee = _prefixId.prefix "hasTrustee"
    /// <summary>
    ///   <para>rdfs:label : is trustee of^^xsd:string</para>
    ///   <para>skos:definition : identifies the trust over which a trustee has some measure of control^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/isTrusteeOf">fibo-be-tr-tr:isTrusteeOf</a>
    /// </summary>
    let isTrusteeOf = _prefixId.prefix "isTrusteeOf"
