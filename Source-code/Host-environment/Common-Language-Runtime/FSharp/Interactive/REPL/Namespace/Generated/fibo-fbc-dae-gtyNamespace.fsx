#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fbc-dae-gty`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/" "fibo-fbc-dae-gty"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : collateralized guaranty^^xsd:string</para>
    ///   <para>skos:definition : guaranty that takes the form of some asset that is pledged by a borrower to a lender (usually in return for a loan)^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In some cases, the lender may require the borrower to place pledged assets such as cash or securities in a separate account that the lender controls.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/CollateralizedGuaranty">fibo-fbc-dae-gty:CollateralizedGuaranty</a>
    /// </summary>
    let CollateralizedGuaranty = _prefixId.prefix "CollateralizedGuaranty"
    /// <summary>
    ///   <para>rdfs:label : government guaranty^^xsd:string</para>
    ///   <para>skos:definition : guaranty provided by a government entity, such as for a government-backed security^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/GovernmentGuaranty">fibo-fbc-dae-gty:GovernmentGuaranty</a>
    /// </summary>
    let GovernmentGuaranty = _prefixId.prefix "GovernmentGuaranty"
    /// <summary>
    ///   <para>rdfs:label : guarantor^^xsd:string</para>
    ///   <para>skos:definition : party that guarantees, endorses, or provides indemnity for some obligation on behalf of some other party^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Business and Economics Terms, Fifth Edition, 2012^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In some cases, the party acting as guarantor may also be a party to the contract, such as in the case of Fannie Mae or Freddie Mac. In such cases, the same individual would be modeled as having both roles.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/Guarantor">fibo-fbc-dae-gty:Guarantor</a>
    /// </summary>
    let Guarantor = _prefixId.prefix "Guarantor"
    /// <summary>
    ///   <para>rdfs:label : guaranty^^xsd:string</para>
    ///   <para>skos:definition : commitment whereby something is formally assured if a party with primary liability fails to perform^^xsd:string</para>
    ///   <para>cmns-av:adaptedFrom : Barron's Dictionary of Business and Economics Terms, Fifth Edition, 2012^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The commitment may cover a debt, cash flows on a debt instrument (such as interest payments), or performance of some obligation.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/Guaranty">fibo-fbc-dae-gty:Guaranty</a>
    /// </summary>
    let Guaranty = _prefixId.prefix "Guaranty"
    /// <summary>
    ///   <para>rdfs:label : insurance-backed guaranty^^xsd:string</para>
    ///   <para>skos:definition : guaranty that is realized as an insurance policy^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/InsuranceBackedGuaranty">fibo-fbc-dae-gty:InsuranceBackedGuaranty</a>
    /// </summary>
    let InsuranceBackedGuaranty = _prefixId.prefix "InsuranceBackedGuaranty"
    /// <summary>
    ///   <para>rdfs:label : insurance policy^^xsd:string</para>
    ///   <para>skos:definition : contract that (1) puts an indemnity cover into effect, (2) serves as a legal evidence of the insurance agreement, (3) sets out the exact terms on which the indemnity cover has been provided, and (4) states associated information such as the (a) specific risks and perils covered, (b) duration of coverage, (c) amount of premium, (d) mode of premium payment, and (e) deductibles, if any^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/InsurancePolicy">fibo-fbc-dae-gty:InsurancePolicy</a>
    /// </summary>
    let InsurancePolicy = _prefixId.prefix "InsurancePolicy"
    /// <summary>
    ///   <para>rdfs:label : insurer^^xsd:string</para>
    ///   <para>skos:definition : financial service provider that issues an insurance policy^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/Insurer">fibo-fbc-dae-gty:Insurer</a>
    /// </summary>
    let Insurer = _prefixId.prefix "Insurer"
    /// <summary>
    ///   <para>rdfs:label : joint guaranty^^xsd:string</para>
    ///   <para>skos:definition : guaranty provided by at least two parties, jointly and severally^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/JointGuaranty">fibo-fbc-dae-gty:JointGuaranty</a>
    /// </summary>
    let JointGuaranty = _prefixId.prefix "JointGuaranty"
    /// <summary>
    ///   <para>rdfs:label : letter of credit^^xsd:string</para>
    ///   <para>skos:definition : letter from a bank or other creditworthy institution guaranteeing that a buyer's payment to a seller will be received on time and for the correct amount^^xsd:string</para>
    ///   <para>cmns-av:abbreviation : L/C^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : In some states in the U.S., the issuer is not limited to financial institutions -- it is simply a written instrument, addressed by one person to another, requesting the latter to give credit to the person in whose favor it is drawn.^^xsd:stringcmns-av:explanatoryNote : In the event that the buyer is unable to make payment, the bank or other issuer is required to cover the full or remaining amount.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/LetterOfCredit">fibo-fbc-dae-gty:LetterOfCredit</a>
    /// </summary>
    let LetterOfCredit = _prefixId.prefix "LetterOfCredit"
    /// <summary>
    ///   <para>rdfs:label : letter of credit guaranty^^xsd:string</para>
    ///   <para>skos:definition : guaranty that takes the form of a letter of credit, i.e., a document issued by a bank guaranteeing the payment up to a stated amount for a specified period^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/LetterOfCreditGuaranty">fibo-fbc-dae-gty:LetterOfCreditGuaranty</a>
    /// </summary>
    let LetterOfCreditGuaranty = _prefixId.prefix "LetterOfCreditGuaranty"
    /// <summary>
    ///   <para>rdfs:label : negative pledge^^xsd:string</para>
    ///   <para>skos:definition : guaranty whereby the issuer will not pledge any assets if doing so would result in less security for lender(s) or investor(s)^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/NegativePledge">fibo-fbc-dae-gty:NegativePledge</a>
    /// </summary>
    let NegativePledge = _prefixId.prefix "NegativePledge"
    /// <summary>
    ///   <para>rdfs:label : policyholder^^xsd:string</para>
    ///   <para>skos:definition : counterparty to and typically owner of an insurance policy^^xsd:string</para>
    ///   <para>cmns-av:synonym : insured party^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/Policyholder">fibo-fbc-dae-gty:Policyholder</a>
    /// </summary>
    let Policyholder = _prefixId.prefix "Policyholder"
    /// <summary>
    ///   <para>rdfs:label : priority level^^xsd:string</para>
    ///   <para>skos:definition : relative ranking that a guaranty has in the context of a contract, for example for a credit enhancement priority^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/PriorityLevel">fibo-fbc-dae-gty:PriorityLevel</a>
    /// </summary>
    let PriorityLevel = _prefixId.prefix "PriorityLevel"
    /// <summary>
    ///   <para>rdfs:label : has guaranteed amount^^xsd:string</para>
    ///   <para>skos:definition : relates the guaranty to the monetary amount guaranteed^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/hasGuaranteedAmount">fibo-fbc-dae-gty:hasGuaranteedAmount</a>
    /// </summary>
    let hasGuaranteedAmount = _prefixId.prefix "hasGuaranteedAmount"
    /// <summary>
    ///   <para>rdfs:label : has guarantor^^xsd:string</para>
    ///   <para>skos:definition : relates the guarantor to the contract for which they are providing a guaranty^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/hasGuarantor">fibo-fbc-dae-gty:hasGuarantor</a>
    /// </summary>
    let hasGuarantor = _prefixId.prefix "hasGuarantor"
    /// <summary>
    ///   <para>rdfs:label : has guarantor party^^xsd:string</para>
    ///   <para>skos:definition : indicates a party that guarantees, endorses, or provides indemnity for some obligation on its behalf^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/hasGuarantorParty">fibo-fbc-dae-gty:hasGuarantorParty</a>
    /// </summary>
    let hasGuarantorParty = _prefixId.prefix "hasGuarantorParty"
    /// <summary>
    ///   <para>rdfs:label : has priority level^^xsd:string</para>
    ///   <para>skos:definition : relates a guaranty to some relative ranking that the guaranty has in the context of the contract, for example for a credit enhancement priority^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/hasPriorityLevel">fibo-fbc-dae-gty:hasPriorityLevel</a>
    /// </summary>
    let hasPriorityLevel = _prefixId.prefix "hasPriorityLevel"
    /// <summary>
    ///   <para>rdfs:label : is guaranteed by^^xsd:string</para>
    ///   <para>skos:definition : relates guaranty to the contract guarantor, i.e., to the legal person providing the guaranty^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/isGuaranteedBy">fibo-fbc-dae-gty:isGuaranteedBy</a>
    /// </summary>
    let isGuaranteedBy = _prefixId.prefix "isGuaranteedBy"
    /// <summary>
    ///   <para>rdfs:label : is guarantor of^^xsd:string</para>
    ///   <para>skos:definition : identifies a party over which a guarantor has some measure of control by virtue of the guarantee^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/isGuarantorOf">fibo-fbc-dae-gty:isGuarantorOf</a>
    /// </summary>
    let isGuarantorOf = _prefixId.prefix "isGuarantorOf"
