namespace https.ns.verisav.fr.wty.hash

open DoxAletheia

module wty =
    let _namespace_name = "https://ns.verisav.fr/wty#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Automated assessment of a claim against warranty or contract, determining coverage and payment responsibility.
    /// <see href="https://ns.verisav.fr/wty#ClaimAssessment"></see></summary>
    let ClaimAssessment = _prefix "ClaimAssessment"
    /// <summary>
    /// A condition that must be met for warranty or contract to apply (normal use, proper installation, documentation, etc.).
    /// <see href="https://ns.verisav.fr/wty#Condition"></see></summary>
    let Condition = _prefix "Condition"
    /// <summary>
    /// A contract (maintenance, extension, insurance) that defines terms and coverage for after-sales service.
    /// <see href="https://ns.verisav.fr/wty#Contract"></see></summary>
    let Contract = _prefix "Contract"
    /// <summary>
    /// Defines what is covered by a warranty or contract (components, defect types, repair types, periods).
    /// <see href="https://ns.verisav.fr/wty#Coverage"></see></summary>
    let Coverage = _prefix "Coverage"
    /// <summary>
    /// Defines what is NOT covered by a warranty or contract (excluded defect types, causes, components).
    /// <see href="https://ns.verisav.fr/wty#Exclusion"></see></summary>
    let Exclusion = _prefix "Exclusion"
    /// <summary>
    /// An invoice generated automatically based on warranty/contract payment rules and claim assessment.
    /// <see href="https://ns.verisav.fr/wty#Invoice"></see></summary>
    let Invoice = _prefix "Invoice"
    /// <summary>
    /// Defines limits (financial, temporal, quantity) for warranty or contract coverage.
    /// <see href="https://ns.verisav.fr/wty#Limit"></see></summary>
    let Limit = _prefix "Limit"
    /// <summary>
    /// Defines who pays for what (diagnostic, repair, parts, travel) and payment splits between parties.
    /// <see href="https://ns.verisav.fr/wty#PaymentRule"></see></summary>
    let PaymentRule = _prefix "PaymentRule"
    /// <summary>
    /// An extended warranty that defines coverage, exclusions, payment rules, and conditions in a machine-readable format for automation.
    /// <see href="https://ns.verisav.fr/wty#Warranty"></see></summary>
    let Warranty = _prefix "Warranty"
    /// <summary>
    /// Links a claim assessment to the coverage that applies.
    /// <see href="https://ns.verisav.fr/wty#appliedCoverage"></see></summary>
    let appliedCoverage = _prefix "appliedCoverage"
    /// <summary>
    /// Links a claim assessment to exclusions that apply.
    /// <see href="https://ns.verisav.fr/wty#appliedExclusions"></see></summary>
    let appliedExclusions = _prefix "appliedExclusions"
    /// <summary>
    /// Links a claim assessment to the ticket or claim being assessed.
    /// <see href="https://ns.verisav.fr/wty#assessesClaim"></see></summary>
    let assessesClaim = _prefix "assessesClaim"
    /// <summary>
    /// Date when the assessment was performed.
    /// <see href="https://ns.verisav.fr/wty#assessmentDate"></see></summary>
    let assessmentDate = _prefix "assessmentDate"
    /// <summary>
    /// Reason for the assessment result (explanation of why covered or not).
    /// <see href="https://ns.verisav.fr/wty#assessmentReason"></see></summary>
    let assessmentReason = _prefix "assessmentReason"
    /// <summary>
    /// Result of the assessment (covered, not_covered, partially_covered, pending_verification).
    /// <see href="https://ns.verisav.fr/wty#assessmentResult"></see></summary>
    let assessmentResult = _prefix "assessmentResult"
    /// <summary>
    /// Whether the contract auto-renews.
    /// <see href="https://ns.verisav.fr/wty#autoRenewal"></see></summary>
    let autoRenewal = _prefix "autoRenewal"
    /// <summary>
    /// Links a claim assessment to the coverage being checked.
    /// <see href="https://ns.verisav.fr/wty#checksCoverage"></see></summary>
    let checksCoverage = _prefix "checksCoverage"
    /// <summary>
    /// Links a claim assessment to exclusions being checked.
    /// <see href="https://ns.verisav.fr/wty#checksExclusions"></see></summary>
    let checksExclusions = _prefix "checksExclusions"
    /// <summary>
    /// Description of the condition that must be met.
    /// <see href="https://ns.verisav.fr/wty#conditionDescription"></see></summary>
    let conditionDescription = _prefix "conditionDescription"
    /// <summary>
    /// Type of condition (normal_use, proper_installation, documentation, proof_of_purchase, etc.).
    /// <see href="https://ns.verisav.fr/wty#conditionType"></see></summary>
    let conditionType = _prefix "conditionType"
    /// <summary>
    /// End date of the contract.
    /// <see href="https://ns.verisav.fr/wty#contractEndDate"></see></summary>
    let contractEndDate = _prefix "contractEndDate"
    /// <summary>
    /// Unique identifier for the contract.
    /// <see href="https://ns.verisav.fr/wty#contractNumber"></see></summary>
    let contractNumber = _prefix "contractNumber"
    /// <summary>
    /// Start date of the contract.
    /// <see href="https://ns.verisav.fr/wty#contractStartDate"></see></summary>
    let contractStartDate = _prefix "contractStartDate"
    /// <summary>
    /// Status of the contract (active, expired, suspended, cancelled, renewed).
    /// <see href="https://ns.verisav.fr/wty#contractStatus"></see></summary>
    let contractStatus = _prefix "contractStatus"
    /// <summary>
    /// Type of contract (maintenance, extension, insurance, service_agreement).
    /// <see href="https://ns.verisav.fr/wty#contractType"></see></summary>
    let contractType = _prefix "contractType"
    /// <summary>
    /// End date of coverage period.
    /// <see href="https://ns.verisav.fr/wty#coverageEndDate"></see></summary>
    let coverageEndDate = _prefix "coverageEndDate"
    /// <summary>
    /// The period during which coverage applies (e.g., '24_months', 'lifetime').
    /// <see href="https://ns.verisav.fr/wty#coveragePeriod"></see></summary>
    let coveragePeriod = _prefix "coveragePeriod"
    /// <summary>
    /// Start date of coverage period.
    /// <see href="https://ns.verisav.fr/wty#coverageStartDate"></see></summary>
    let coverageStartDate = _prefix "coverageStartDate"
    /// <summary>
    /// Amount covered by warranty/contract for this claim.
    /// <see href="https://ns.verisav.fr/wty#coveredAmount"></see></summary>
    let coveredAmount = _prefix "coveredAmount"
    /// <summary>
    /// Currency code for the covered amount (ISO 4217).
    /// <see href="https://ns.verisav.fr/wty#coveredCurrency"></see></summary>
    let coveredCurrency = _prefix "coveredCurrency"
    /// <summary>
    /// Links coverage to specific product components that are covered.
    /// <see href="https://ns.verisav.fr/wty#coversComponent"></see></summary>
    let coversComponent = _prefix "coversComponent"
    /// <summary>
    /// Links coverage to types of defects that are covered.
    /// <see href="https://ns.verisav.fr/wty#coversDefectType"></see></summary>
    let coversDefectType = _prefix "coversDefectType"
    /// <summary>
    /// Links coverage to types of repairs that are covered.
    /// <see href="https://ns.verisav.fr/wty#coversRepairType"></see></summary>
    let coversRepairType = _prefix "coversRepairType"
    /// <summary>
    /// Amount the customer is responsible for.
    /// <see href="https://ns.verisav.fr/wty#customerResponsibility"></see></summary>
    let customerResponsibility = _prefix "customerResponsibility"
    /// <summary>
    /// Links a warranty or contract to its conditions.
    /// <see href="https://ns.verisav.fr/wty#definesConditions"></see></summary>
    let definesConditions = _prefix "definesConditions"
    /// <summary>
    /// Links a warranty or contract to its coverage definition.
    /// <see href="https://ns.verisav.fr/wty#definesCoverage"></see></summary>
    let definesCoverage = _prefix "definesCoverage"
    /// <summary>
    /// Links a warranty or contract to its exclusion definitions.
    /// <see href="https://ns.verisav.fr/wty#definesExclusions"></see></summary>
    let definesExclusions = _prefix "definesExclusions"
    /// <summary>
    /// Links a warranty or contract to its limits.
    /// <see href="https://ns.verisav.fr/wty#definesLimits"></see></summary>
    let definesLimits = _prefix "definesLimits"
    /// <summary>
    /// Links a warranty or contract to its payment rule.
    /// <see href="https://ns.verisav.fr/wty#definesPaymentRule"></see></summary>
    let definesPaymentRule = _prefix "definesPaymentRule"
    /// <summary>
    /// Links a claim assessment to the payment rule used to determine payment responsibility.
    /// <see href="https://ns.verisav.fr/wty#determinesPayment"></see></summary>
    let determinesPayment = _prefix "determinesPayment"
    /// <summary>
    /// Links exclusion to causes that are excluded (normal wear, damage, misuse, etc.).
    /// <see href="https://ns.verisav.fr/wty#excludedCause"></see></summary>
    let excludedCause = _prefix "excludedCause"
    /// <summary>
    /// Links exclusion to specific components that are excluded.
    /// <see href="https://ns.verisav.fr/wty#excludedComponent"></see></summary>
    let excludedComponent = _prefix "excludedComponent"
    /// <summary>
    /// Links exclusion to types of defects that are excluded.
    /// <see href="https://ns.verisav.fr/wty#excludedDefectType"></see></summary>
    let excludedDefectType = _prefix "excludedDefectType"
    /// <summary>
    /// The party (organization or person) that pays first or primarily.
    /// <see href="https://ns.verisav.fr/wty#firstParty"></see></summary>
    let firstParty = _prefix "firstParty"
    /// <summary>
    /// Links a claim assessment to the invoice generated.
    /// <see href="https://ns.verisav.fr/wty#generatesInvoice"></see></summary>
    let generatesInvoice = _prefix "generatesInvoice"
    /// <summary>
    /// Whether the payment rule has a limit.
    /// <see href="https://ns.verisav.fr/wty#hasPaymentLimit"></see></summary>
    let hasPaymentLimit = _prefix "hasPaymentLimit"
    /// <summary>
    /// Total amount of the invoice.
    /// <see href="https://ns.verisav.fr/wty#invoiceAmount"></see></summary>
    let invoiceAmount = _prefix "invoiceAmount"
    /// <summary>
    /// Currency code for the invoice amount (ISO 4217).
    /// <see href="https://ns.verisav.fr/wty#invoiceCurrency"></see></summary>
    let invoiceCurrency = _prefix "invoiceCurrency"
    /// <summary>
    /// Date when the invoice was generated.
    /// <see href="https://ns.verisav.fr/wty#invoiceDate"></see></summary>
    let invoiceDate = _prefix "invoiceDate"
    /// <summary>
    /// Unique identifier for the invoice.
    /// <see href="https://ns.verisav.fr/wty#invoiceNumber"></see></summary>
    let invoiceNumber = _prefix "invoiceNumber"
    /// <summary>
    /// Status of the invoice (draft, sent, paid, overdue, cancelled).
    /// <see href="https://ns.verisav.fr/wty#invoiceStatus"></see></summary>
    let invoiceStatus = _prefix "invoiceStatus"
    /// <summary>
    /// Links an invoice to the intervention, repair, or service being invoiced.
    /// <see href="https://ns.verisav.fr/wty#invoices"></see></summary>
    let invoices = _prefix "invoices"
    /// <summary>
    /// Maximum amount for the limit.
    /// <see href="https://ns.verisav.fr/wty#limitAmount"></see></summary>
    let limitAmount = _prefix "limitAmount"
    /// <summary>
    /// Currency code for the limit amount (ISO 4217).
    /// <see href="https://ns.verisav.fr/wty#limitCurrency"></see></summary>
    let limitCurrency = _prefix "limitCurrency"
    /// <summary>
    /// Period over which the limit applies (per_month, per_year, total, etc.).
    /// <see href="https://ns.verisav.fr/wty#limitPeriod"></see></summary>
    let limitPeriod = _prefix "limitPeriod"
    /// <summary>
    /// Maximum quantity (for number-based limits like interventions).
    /// <see href="https://ns.verisav.fr/wty#limitQuantity"></see></summary>
    let limitQuantity = _prefix "limitQuantity"
    /// <summary>
    /// Type of limit (amount, number_of_interventions, per_incident, total, etc.).
    /// <see href="https://ns.verisav.fr/wty#limitType"></see></summary>
    let limitType = _prefix "limitType"
    /// <summary>
    /// The party responsible for paying the invoice.
    /// <see href="https://ns.verisav.fr/wty#payer"></see></summary>
    let payer = _prefix "payer"
    /// <summary>
    /// Links a claim assessment to the payment rule that determines who pays.
    /// <see href="https://ns.verisav.fr/wty#paymentDecision"></see></summary>
    let paymentDecision = _prefix "paymentDecision"
    /// <summary>
    /// Percentage of cost paid by the first party (0-100).
    /// <see href="https://ns.verisav.fr/wty#paymentPercentage"></see></summary>
    let paymentPercentage = _prefix "paymentPercentage"
    /// <summary>
    /// JSON string describing payment split between multiple parties.
    /// JSON string describing how payment is split between parties (if multiple payers).
    /// <see href="https://ns.verisav.fr/wty#paymentSplit"></see></summary>
    let paymentSplit = _prefix "paymentSplit"
    /// <summary>
    /// Links a payment rule to what it pays for (diagnostic, repair, parts, travel, etc.).
    /// <see href="https://ns.verisav.fr/wty#paysFor"></see></summary>
    let paysFor = _prefix "paysFor"
    /// <summary>
    /// Whether documentation is required (proof of purchase, installation certificate, etc.).
    /// <see href="https://ns.verisav.fr/wty#requiresDocumentation"></see></summary>
    let requiresDocumentation = _prefix "requiresDocumentation"
    /// <summary>
    /// Whether proof is required (photos, diagnostic report, etc.).
    /// <see href="https://ns.verisav.fr/wty#requiresProof"></see></summary>
    let requiresProof = _prefix "requiresProof"
    /// <summary>
    /// Links a ticket or claim to a claim assessment.
    /// <see href="https://ns.verisav.fr/wty#triggersAssessment"></see></summary>
    let triggersAssessment = _prefix "triggersAssessment"
    /// <summary>
    /// Period during which the condition is valid (e.g., 'warranty_period', 'lifetime').
    /// <see href="https://ns.verisav.fr/wty#validityPeriod"></see></summary>
    let validityPeriod = _prefix "validityPeriod"
