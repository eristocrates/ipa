#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-agr-agr`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/" "fibo-fnd-agr-agr"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : agreement</para>
    ///   <para>skos:definition : negotiated understanding between two or more parties, reflecting the offer and acceptance of commitments on the part of either party^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : All agreements are time bound, whether implicit or explicitly stated, and thus an agreement reflects a state of affairs that holds for some period of time.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Agreement">fibo-fnd-agr-agr:Agreement</a>
    /// </summary>
    let Agreement = _prefixId.prefix "Agreement"
    /// <summary>
    ///   <para>rdfs:label : beneficiary^^xsd:string</para>
    ///   <para>skos:definition : party that receives some benefit or advantage or profits from something^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Beneficiary">fibo-fnd-agr-agr:Beneficiary</a>
    /// </summary>
    let Beneficiary = _prefixId.prefix "Beneficiary"
    /// <summary>
    ///   <para>rdfs:label : bilateral agreement</para>
    ///   <para>skos:definition : agreement where two parties commit to perform specific actions or obligations towards each other^^xsd:string</para>
    ///   <para>cmns-av:synonym : mutual agreement</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/BilateralAgreement">fibo-fnd-agr-agr:BilateralAgreement</a>
    /// </summary>
    let BilateralAgreement = _prefixId.prefix "BilateralAgreement"
    /// <summary>
    ///   <para>rdfs:label : commitment</para>
    ///   <para>skos:definition : promise made by some party to act or refrain from acting in some manner^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Such a promise often results a corresponding right or obligation with respect to another party to the commitment. Thus, obligations and rights are considered as reciprocal aspects of a commitment.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Commitment">fibo-fnd-agr-agr:Commitment</a>
    /// </summary>
    let Commitment = _prefixId.prefix "Commitment"
    /// <summary>
    ///   <para>rdfs:label : commitment at large^^xsd:string</para>
    ///   <para>skos:definition : commitment made by some party without direct involvement from the potential beneficiaries of that commitment^^xsd:string</para>
    ///   <para>skos:scopeNote : A commitment at large forms the basis for negotiable securities including transferable contracts and potentially other kinds of agreements such as software licenses.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/CommitmentAtLarge">fibo-fnd-agr-agr:CommitmentAtLarge</a>
    /// </summary>
    let CommitmentAtLarge = _prefixId.prefix "CommitmentAtLarge"
    /// <summary>
    ///   <para>rdfs:label : multilateral agreement</para>
    ///   <para>skos:definition : agreements that involve or include multiple parties^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Multilateral agreements are characterized by the participation and commitment of multiple countries or parties to achieve a common objective or address a shared issue.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/MultilateralAgreement">fibo-fnd-agr-agr:MultilateralAgreement</a>
    /// </summary>
    let MultilateralAgreement = _prefixId.prefix "MultilateralAgreement"
    /// <summary>
    ///   <para>rdfs:label : obligee^^xsd:string</para>
    ///   <para>skos:definition : party to whom some commitment or obligation is owed, either legally or per the terms of an agreement^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Obligee">fibo-fnd-agr-agr:Obligee</a>
    /// </summary>
    let Obligee = _prefixId.prefix "Obligee"
    /// <summary>
    ///   <para>rdfs:label : obligor^^xsd:string</para>
    ///   <para>skos:definition : party that is bound legally or by agreement to repay a debt, make a payment, do something, or refrain from doing something^^xsd:string</para>
    ///   <para>cmns-av:synonym : obligated party^^xsd:stringcmns-av:synonym : obligator^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/Obligor">fibo-fnd-agr-agr:Obligor</a>
    /// </summary>
    let Obligor = _prefixId.prefix "Obligor"
    /// <summary>
    ///   <para>rdfs:label : unilateral commitment^^xsd:string</para>
    ///   <para>skos:definition : commitment (promise or obligation) made by one party without requiring a reciprocal promise from another party^^xsd:string</para>
    ///   <para>skos:example : Unilateral commitments include some promotional offers, contests, and rewards, where the offering party sets conditions without requiring upfront agreement from others.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/UnilateralCommitment">fibo-fnd-agr-agr:UnilateralCommitment</a>
    /// </summary>
    let UnilateralCommitment = _prefixId.prefix "UnilateralCommitment"
    /// <summary>
    ///   <para>rdfs:label : has obligation^^xsd:string</para>
    ///   <para>skos:definition : identifies a duty or obligation that a given party has taken on^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/hasObligation">fibo-fnd-agr-agr:hasObligation</a>
    /// </summary>
    let hasObligation = _prefixId.prefix "hasObligation"
    /// <summary>
    ///   <para>rdfs:label : is obligation of^^xsd:string</para>
    ///   <para>skos:definition : identifies a party that has a given obligation^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/isObligationOf">fibo-fnd-agr-agr:isObligationOf</a>
    /// </summary>
    let isObligationOf = _prefixId.prefix "isObligationOf"
