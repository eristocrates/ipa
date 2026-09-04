#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module wty =
    let _prefixId = PrefixId.fromNamespaceLabel "https://ns.verisav.fr/wty#" "wty"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Claim Assessmentrdfs:label : Évaluation de Réclamation</para>
    ///   <para>rdfs:comment : Automated assessment of a claim against warranty or contract, determining coverage and payment responsibility.</para>
    ///   <a href="https://ns.verisav.fr/wty#ClaimAssessment">wty:ClaimAssessment</a>
    /// </summary>
    let ClaimAssessment = _prefixId.prefix "ClaimAssessment"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Conditionrdfs:label : Condition</para>
    ///   <para>rdfs:comment : A condition that must be met for warranty or contract to apply (normal use, proper installation, documentation, etc.).</para>
    ///   <a href="https://ns.verisav.fr/wty#Condition">wty:Condition</a>
    /// </summary>
    let Condition = _prefixId.prefix "Condition"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Contractrdfs:label : Contrat</para>
    ///   <para>rdfs:comment : A contract (maintenance, extension, insurance) that defines terms and coverage for after-sales service.</para>
    ///   <a href="https://ns.verisav.fr/wty#Contract">wty:Contract</a>
    /// </summary>
    let Contract = _prefixId.prefix "Contract"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Coveragerdfs:label : Couverture</para>
    ///   <para>rdfs:comment : Defines what is covered by a warranty or contract (components, defect types, repair types, periods).</para>
    ///   <a href="https://ns.verisav.fr/wty#Coverage">wty:Coverage</a>
    /// </summary>
    let Coverage = _prefixId.prefix "Coverage"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Exclusionrdfs:label : Exclusion</para>
    ///   <para>rdfs:comment : Defines what is NOT covered by a warranty or contract (excluded defect types, causes, components).</para>
    ///   <a href="https://ns.verisav.fr/wty#Exclusion">wty:Exclusion</a>
    /// </summary>
    let Exclusion = _prefixId.prefix "Exclusion"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Invoicerdfs:label : Facture</para>
    ///   <para>rdfs:comment : An invoice generated automatically based on warranty/contract payment rules and claim assessment.</para>
    ///   <a href="https://ns.verisav.fr/wty#Invoice">wty:Invoice</a>
    /// </summary>
    let Invoice = _prefixId.prefix "Invoice"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Limitrdfs:label : Limite</para>
    ///   <para>rdfs:comment : Defines limits (financial, temporal, quantity) for warranty or contract coverage.</para>
    ///   <a href="https://ns.verisav.fr/wty#Limit">wty:Limit</a>
    /// </summary>
    let Limit = _prefixId.prefix "Limit"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Payment Rulerdfs:label : Règle de Paiement</para>
    ///   <para>rdfs:comment : Defines who pays for what (diagnostic, repair, parts, travel) and payment splits between parties.</para>
    ///   <a href="https://ns.verisav.fr/wty#PaymentRule">wty:PaymentRule</a>
    /// </summary>
    let PaymentRule = _prefixId.prefix "PaymentRule"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Warrantyrdfs:label : Garantie</para>
    ///   <para>rdfs:comment : An extended warranty that defines coverage, exclusions, payment rules, and conditions in a machine-readable format for automation.</para>
    ///   <a href="https://ns.verisav.fr/wty#Warranty">wty:Warranty</a>
    /// </summary>
    let Warranty = _prefixId.prefix "Warranty"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : applied coveragerdfs:label : couverture appliquée</para>
    ///   <para>rdfs:comment : Links a claim assessment to the coverage that applies.</para>
    ///   <a href="https://ns.verisav.fr/wty#appliedCoverage">wty:appliedCoverage</a>
    /// </summary>
    let appliedCoverage = _prefixId.prefix "appliedCoverage"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : applied exclusionsrdfs:label : exclusions appliquées</para>
    ///   <para>rdfs:comment : Links a claim assessment to exclusions that apply.</para>
    ///   <a href="https://ns.verisav.fr/wty#appliedExclusions">wty:appliedExclusions</a>
    /// </summary>
    let appliedExclusions = _prefixId.prefix "appliedExclusions"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : assesses claimrdfs:label : évalue la réclamation</para>
    ///   <para>rdfs:comment : Links a claim assessment to the ticket or claim being assessed.</para>
    ///   <a href="https://ns.verisav.fr/wty#assessesClaim">wty:assessesClaim</a>
    /// </summary>
    let assessesClaim = _prefixId.prefix "assessesClaim"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : assessment daterdfs:label : date d'évaluation</para>
    ///   <para>rdfs:comment : Date when the assessment was performed.</para>
    ///   <a href="https://ns.verisav.fr/wty#assessmentDate">wty:assessmentDate</a>
    /// </summary>
    let assessmentDate = _prefixId.prefix "assessmentDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : assessment reasonrdfs:label : raison d'évaluation</para>
    ///   <para>rdfs:comment : Reason for the assessment result (explanation of why covered or not).</para>
    ///   <a href="https://ns.verisav.fr/wty#assessmentReason">wty:assessmentReason</a>
    /// </summary>
    let assessmentReason = _prefixId.prefix "assessmentReason"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : assessment resultrdfs:label : résultat d'évaluation</para>
    ///   <para>rdfs:comment : Result of the assessment (covered, not_covered, partially_covered, pending_verification).</para>
    ///   <a href="https://ns.verisav.fr/wty#assessmentResult">wty:assessmentResult</a>
    /// </summary>
    let assessmentResult = _prefixId.prefix "assessmentResult"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : auto renewalrdfs:label : renouvellement automatique</para>
    ///   <para>rdfs:comment : Whether the contract auto-renews.</para>
    ///   <a href="https://ns.verisav.fr/wty#autoRenewal">wty:autoRenewal</a>
    /// </summary>
    let autoRenewal = _prefixId.prefix "autoRenewal"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : checks coveragerdfs:label : vérifie la couverture</para>
    ///   <para>rdfs:comment : Links a claim assessment to the coverage being checked.</para>
    ///   <a href="https://ns.verisav.fr/wty#checksCoverage">wty:checksCoverage</a>
    /// </summary>
    let checksCoverage = _prefixId.prefix "checksCoverage"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : checks exclusionsrdfs:label : vérifie les exclusions</para>
    ///   <para>rdfs:comment : Links a claim assessment to exclusions being checked.</para>
    ///   <a href="https://ns.verisav.fr/wty#checksExclusions">wty:checksExclusions</a>
    /// </summary>
    let checksExclusions = _prefixId.prefix "checksExclusions"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : condition descriptionrdfs:label : description de condition</para>
    ///   <para>rdfs:comment : Description of the condition that must be met.</para>
    ///   <a href="https://ns.verisav.fr/wty#conditionDescription">wty:conditionDescription</a>
    /// </summary>
    let conditionDescription = _prefixId.prefix "conditionDescription"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : condition typerdfs:label : type de condition</para>
    ///   <para>rdfs:comment : Type of condition (normal_use, proper_installation, documentation, proof_of_purchase, etc.).</para>
    ///   <a href="https://ns.verisav.fr/wty#conditionType">wty:conditionType</a>
    /// </summary>
    let conditionType = _prefixId.prefix "conditionType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : contract end daterdfs:label : date de fin de contrat</para>
    ///   <para>rdfs:comment : End date of the contract.</para>
    ///   <a href="https://ns.verisav.fr/wty#contractEndDate">wty:contractEndDate</a>
    /// </summary>
    let contractEndDate = _prefixId.prefix "contractEndDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : contract numberrdfs:label : numéro de contrat</para>
    ///   <para>rdfs:comment : Unique identifier for the contract.</para>
    ///   <a href="https://ns.verisav.fr/wty#contractNumber">wty:contractNumber</a>
    /// </summary>
    let contractNumber = _prefixId.prefix "contractNumber"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : contract start daterdfs:label : date de début de contrat</para>
    ///   <para>rdfs:comment : Start date of the contract.</para>
    ///   <a href="https://ns.verisav.fr/wty#contractStartDate">wty:contractStartDate</a>
    /// </summary>
    let contractStartDate = _prefixId.prefix "contractStartDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : contract statusrdfs:label : statut du contrat</para>
    ///   <para>rdfs:comment : Status of the contract (active, expired, suspended, cancelled, renewed).</para>
    ///   <a href="https://ns.verisav.fr/wty#contractStatus">wty:contractStatus</a>
    /// </summary>
    let contractStatus = _prefixId.prefix "contractStatus"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : contract typerdfs:label : type de contrat</para>
    ///   <para>rdfs:comment : Type of contract (maintenance, extension, insurance, service_agreement).</para>
    ///   <a href="https://ns.verisav.fr/wty#contractType">wty:contractType</a>
    /// </summary>
    let contractType = _prefixId.prefix "contractType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : coverage end daterdfs:label : date de fin de couverture</para>
    ///   <para>rdfs:comment : End date of coverage period.</para>
    ///   <a href="https://ns.verisav.fr/wty#coverageEndDate">wty:coverageEndDate</a>
    /// </summary>
    let coverageEndDate = _prefixId.prefix "coverageEndDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : coverage periodrdfs:label : période de couverture</para>
    ///   <para>rdfs:comment : The period during which coverage applies (e.g., '24_months', 'lifetime').</para>
    ///   <a href="https://ns.verisav.fr/wty#coveragePeriod">wty:coveragePeriod</a>
    /// </summary>
    let coveragePeriod = _prefixId.prefix "coveragePeriod"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : coverage start daterdfs:label : date de début de couverture</para>
    ///   <para>rdfs:comment : Start date of coverage period.</para>
    ///   <a href="https://ns.verisav.fr/wty#coverageStartDate">wty:coverageStartDate</a>
    /// </summary>
    let coverageStartDate = _prefixId.prefix "coverageStartDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : covered amountrdfs:label : montant couvert</para>
    ///   <para>rdfs:comment : Amount covered by warranty/contract for this claim.</para>
    ///   <a href="https://ns.verisav.fr/wty#coveredAmount">wty:coveredAmount</a>
    /// </summary>
    let coveredAmount = _prefixId.prefix "coveredAmount"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : covered currencyrdfs:label : devise couverte</para>
    ///   <para>rdfs:comment : Currency code for the covered amount (ISO 4217).</para>
    ///   <a href="https://ns.verisav.fr/wty#coveredCurrency">wty:coveredCurrency</a>
    /// </summary>
    let coveredCurrency = _prefixId.prefix "coveredCurrency"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : covers componentrdfs:label : couvre le composant</para>
    ///   <para>rdfs:comment : Links coverage to specific product components that are covered.</para>
    ///   <a href="https://ns.verisav.fr/wty#coversComponent">wty:coversComponent</a>
    /// </summary>
    let coversComponent = _prefixId.prefix "coversComponent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : covers defect typerdfs:label : couvre le type de défaut</para>
    ///   <para>rdfs:comment : Links coverage to types of defects that are covered.</para>
    ///   <a href="https://ns.verisav.fr/wty#coversDefectType">wty:coversDefectType</a>
    /// </summary>
    let coversDefectType = _prefixId.prefix "coversDefectType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : covers repair typerdfs:label : couvre le type de réparation</para>
    ///   <para>rdfs:comment : Links coverage to types of repairs that are covered.</para>
    ///   <a href="https://ns.verisav.fr/wty#coversRepairType">wty:coversRepairType</a>
    /// </summary>
    let coversRepairType = _prefixId.prefix "coversRepairType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : customer responsibilityrdfs:label : responsabilité client</para>
    ///   <para>rdfs:comment : Amount the customer is responsible for.</para>
    ///   <a href="https://ns.verisav.fr/wty#customerResponsibility">wty:customerResponsibility</a>
    /// </summary>
    let customerResponsibility = _prefixId.prefix "customerResponsibility"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : defines conditionsrdfs:label : définit les conditions</para>
    ///   <para>rdfs:comment : Links a warranty or contract to its conditions.</para>
    ///   <a href="https://ns.verisav.fr/wty#definesConditions">wty:definesConditions</a>
    /// </summary>
    let definesConditions = _prefixId.prefix "definesConditions"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : defines coveragerdfs:label : définit la couverture</para>
    ///   <para>rdfs:comment : Links a warranty or contract to its coverage definition.</para>
    ///   <a href="https://ns.verisav.fr/wty#definesCoverage">wty:definesCoverage</a>
    /// </summary>
    let definesCoverage = _prefixId.prefix "definesCoverage"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : defines exclusionsrdfs:label : définit les exclusions</para>
    ///   <para>rdfs:comment : Links a warranty or contract to its exclusion definitions.</para>
    ///   <a href="https://ns.verisav.fr/wty#definesExclusions">wty:definesExclusions</a>
    /// </summary>
    let definesExclusions = _prefixId.prefix "definesExclusions"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : defines limitsrdfs:label : définit les limites</para>
    ///   <para>rdfs:comment : Links a warranty or contract to its limits.</para>
    ///   <a href="https://ns.verisav.fr/wty#definesLimits">wty:definesLimits</a>
    /// </summary>
    let definesLimits = _prefixId.prefix "definesLimits"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : defines payment rulerdfs:label : définit la règle de paiement</para>
    ///   <para>rdfs:comment : Links a warranty or contract to its payment rule.</para>
    ///   <a href="https://ns.verisav.fr/wty#definesPaymentRule">wty:definesPaymentRule</a>
    /// </summary>
    let definesPaymentRule = _prefixId.prefix "definesPaymentRule"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : determines paymentrdfs:label : détermine le paiement</para>
    ///   <para>rdfs:comment : Links a claim assessment to the payment rule used to determine payment responsibility.</para>
    ///   <a href="https://ns.verisav.fr/wty#determinesPayment">wty:determinesPayment</a>
    /// </summary>
    let determinesPayment = _prefixId.prefix "determinesPayment"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : excluded causerdfs:label : cause exclue</para>
    ///   <para>rdfs:comment : Links exclusion to causes that are excluded (normal wear, damage, misuse, etc.).</para>
    ///   <a href="https://ns.verisav.fr/wty#excludedCause">wty:excludedCause</a>
    /// </summary>
    let excludedCause = _prefixId.prefix "excludedCause"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : excluded componentrdfs:label : composant exclu</para>
    ///   <para>rdfs:comment : Links exclusion to specific components that are excluded.</para>
    ///   <a href="https://ns.verisav.fr/wty#excludedComponent">wty:excludedComponent</a>
    /// </summary>
    let excludedComponent = _prefixId.prefix "excludedComponent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : excluded defect typerdfs:label : type de défaut exclu</para>
    ///   <para>rdfs:comment : Links exclusion to types of defects that are excluded.</para>
    ///   <a href="https://ns.verisav.fr/wty#excludedDefectType">wty:excludedDefectType</a>
    /// </summary>
    let excludedDefectType = _prefixId.prefix "excludedDefectType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : first partyrdfs:label : première partie</para>
    ///   <para>rdfs:comment : The party (organization or person) that pays first or primarily.</para>
    ///   <a href="https://ns.verisav.fr/wty#firstParty">wty:firstParty</a>
    /// </summary>
    let firstParty = _prefixId.prefix "firstParty"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : generates invoicerdfs:label : génère la facture</para>
    ///   <para>rdfs:comment : Links a claim assessment to the invoice generated.</para>
    ///   <a href="https://ns.verisav.fr/wty#generatesInvoice">wty:generatesInvoice</a>
    /// </summary>
    let generatesInvoice = _prefixId.prefix "generatesInvoice"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has payment limitrdfs:label : a une limite de paiement</para>
    ///   <para>rdfs:comment : Whether the payment rule has a limit.</para>
    ///   <a href="https://ns.verisav.fr/wty#hasPaymentLimit">wty:hasPaymentLimit</a>
    /// </summary>
    let hasPaymentLimit = _prefixId.prefix "hasPaymentLimit"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : invoice amountrdfs:label : montant de facture</para>
    ///   <para>rdfs:comment : Total amount of the invoice.</para>
    ///   <a href="https://ns.verisav.fr/wty#invoiceAmount">wty:invoiceAmount</a>
    /// </summary>
    let invoiceAmount = _prefixId.prefix "invoiceAmount"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : invoice currencyrdfs:label : devise de facture</para>
    ///   <para>rdfs:comment : Currency code for the invoice amount (ISO 4217).</para>
    ///   <a href="https://ns.verisav.fr/wty#invoiceCurrency">wty:invoiceCurrency</a>
    /// </summary>
    let invoiceCurrency = _prefixId.prefix "invoiceCurrency"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : invoice daterdfs:label : date de facture</para>
    ///   <para>rdfs:comment : Date when the invoice was generated.</para>
    ///   <a href="https://ns.verisav.fr/wty#invoiceDate">wty:invoiceDate</a>
    /// </summary>
    let invoiceDate = _prefixId.prefix "invoiceDate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : invoice numberrdfs:label : numéro de facture</para>
    ///   <para>rdfs:comment : Unique identifier for the invoice.</para>
    ///   <a href="https://ns.verisav.fr/wty#invoiceNumber">wty:invoiceNumber</a>
    /// </summary>
    let invoiceNumber = _prefixId.prefix "invoiceNumber"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : invoice statusrdfs:label : statut de facture</para>
    ///   <para>rdfs:comment : Status of the invoice (draft, sent, paid, overdue, cancelled).</para>
    ///   <a href="https://ns.verisav.fr/wty#invoiceStatus">wty:invoiceStatus</a>
    /// </summary>
    let invoiceStatus = _prefixId.prefix "invoiceStatus"
    /// <summary>
    ///   <para>rdfs:comment : Links an invoice to the intervention, repair, or service being invoiced.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : facturerdfs:label : invoices</para>
    ///   <a href="https://ns.verisav.fr/wty#invoices">wty:invoices</a>
    /// </summary>
    let invoices = _prefixId.prefix "invoices"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : limit amountrdfs:label : montant limite</para>
    ///   <para>rdfs:comment : Maximum amount for the limit.</para>
    ///   <a href="https://ns.verisav.fr/wty#limitAmount">wty:limitAmount</a>
    /// </summary>
    let limitAmount = _prefixId.prefix "limitAmount"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : limit currencyrdfs:label : devise limite</para>
    ///   <para>rdfs:comment : Currency code for the limit amount (ISO 4217).</para>
    ///   <a href="https://ns.verisav.fr/wty#limitCurrency">wty:limitCurrency</a>
    /// </summary>
    let limitCurrency = _prefixId.prefix "limitCurrency"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : limit periodrdfs:label : période limite</para>
    ///   <para>rdfs:comment : Period over which the limit applies (per_month, per_year, total, etc.).</para>
    ///   <a href="https://ns.verisav.fr/wty#limitPeriod">wty:limitPeriod</a>
    /// </summary>
    let limitPeriod = _prefixId.prefix "limitPeriod"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : limit quantityrdfs:label : quantité limite</para>
    ///   <para>rdfs:comment : Maximum quantity (for number-based limits like interventions).</para>
    ///   <a href="https://ns.verisav.fr/wty#limitQuantity">wty:limitQuantity</a>
    /// </summary>
    let limitQuantity = _prefixId.prefix "limitQuantity"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : limit typerdfs:label : type de limite</para>
    ///   <para>rdfs:comment : Type of limit (amount, number_of_interventions, per_incident, total, etc.).</para>
    ///   <a href="https://ns.verisav.fr/wty#limitType">wty:limitType</a>
    /// </summary>
    let limitType = _prefixId.prefix "limitType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : payerrdfs:label : payeur</para>
    ///   <para>rdfs:comment : The party responsible for paying the invoice.</para>
    ///   <a href="https://ns.verisav.fr/wty#payer">wty:payer</a>
    /// </summary>
    let payer = _prefixId.prefix "payer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : payment decisionrdfs:label : décision de paiement</para>
    ///   <para>rdfs:comment : Links a claim assessment to the payment rule that determines who pays.</para>
    ///   <a href="https://ns.verisav.fr/wty#paymentDecision">wty:paymentDecision</a>
    /// </summary>
    let paymentDecision = _prefixId.prefix "paymentDecision"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : payment percentagerdfs:label : pourcentage de paiement</para>
    ///   <para>rdfs:comment : Percentage of cost paid by the first party (0-100).</para>
    ///   <a href="https://ns.verisav.fr/wty#paymentPercentage">wty:paymentPercentage</a>
    /// </summary>
    let paymentPercentage = _prefixId.prefix "paymentPercentage"
    /// <summary>
    ///   <para>rdfs:label : payment splitrdfs:label : répartition du paiement</para>
    ///   <para>rdfs:comment : JSON string describing payment split between multiple parties.rdfs:comment : JSON string describing how payment is split between parties (if multiple payers).</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/wty#paymentSplit">wty:paymentSplit</a>
    /// </summary>
    let paymentSplit = _prefixId.prefix "paymentSplit"
    /// <summary>
    ///   <para>rdfs:comment : Links a payment rule to what it pays for (diagnostic, repair, parts, travel, etc.).</para>
    ///   <para>rdfs:label : pays forrdfs:label : paie pour</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/wty#paysFor">wty:paysFor</a>
    /// </summary>
    let paysFor = _prefixId.prefix "paysFor"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : requires documentationrdfs:label : nécessite une documentation</para>
    ///   <para>rdfs:comment : Whether documentation is required (proof of purchase, installation certificate, etc.).</para>
    ///   <a href="https://ns.verisav.fr/wty#requiresDocumentation">wty:requiresDocumentation</a>
    /// </summary>
    let requiresDocumentation = _prefixId.prefix "requiresDocumentation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : requires proofrdfs:label : nécessite une preuve</para>
    ///   <para>rdfs:comment : Whether proof is required (photos, diagnostic report, etc.).</para>
    ///   <a href="https://ns.verisav.fr/wty#requiresProof">wty:requiresProof</a>
    /// </summary>
    let requiresProof = _prefixId.prefix "requiresProof"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : triggers assessmentrdfs:label : déclenche l'évaluation</para>
    ///   <para>rdfs:comment : Links a ticket or claim to a claim assessment.</para>
    ///   <a href="https://ns.verisav.fr/wty#triggersAssessment">wty:triggersAssessment</a>
    /// </summary>
    let triggersAssessment = _prefixId.prefix "triggersAssessment"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : validity periodrdfs:label : période de validité</para>
    ///   <para>rdfs:comment : Period during which the condition is valid (e.g., 'warranty_period', 'lifetime').</para>
    ///   <a href="https://ns.verisav.fr/wty#validityPeriod">wty:validityPeriod</a>
    /// </summary>
    let validityPeriod = _prefixId.prefix "validityPeriod"
