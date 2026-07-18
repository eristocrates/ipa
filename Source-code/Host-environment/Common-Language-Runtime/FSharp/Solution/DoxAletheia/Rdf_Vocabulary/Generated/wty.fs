namespace https.ns.verisav.fr.wty.hash

open DoxAletheia.Rdf_Vocabulary

module wty =
    let _namespace_name = "https://ns.verisav.fr/wty#"

    /// <summary>
    /// Automated assessment of a claim against warranty or contract, determining coverage and payment responsibility.
    /// <see href="https://ns.verisav.fr/wty#ClaimAssessment"></see></summary>
    let ClaimAssessment =
        Namespaced_IRI.parse _namespace_name "ClaimAssessment" |> NamespacedName

    /// <summary>
    /// A condition that must be met for warranty or contract to apply (normal use, proper installation, documentation, etc.).
    /// <see href="https://ns.verisav.fr/wty#Condition"></see></summary>
    let Condition = Namespaced_IRI.parse _namespace_name "Condition" |> NamespacedName
    /// <summary>
    /// A contract (maintenance, extension, insurance) that defines terms and coverage for after-sales service.
    /// <see href="https://ns.verisav.fr/wty#Contract"></see></summary>
    let Contract = Namespaced_IRI.parse _namespace_name "Contract" |> NamespacedName
    /// <summary>
    /// Defines what is covered by a warranty or contract (components, defect types, repair types, periods).
    /// <see href="https://ns.verisav.fr/wty#Coverage"></see></summary>
    let Coverage = Namespaced_IRI.parse _namespace_name "Coverage" |> NamespacedName
    /// <summary>
    /// Defines what is NOT covered by a warranty or contract (excluded defect types, causes, components).
    /// <see href="https://ns.verisav.fr/wty#Exclusion"></see></summary>
    let Exclusion = Namespaced_IRI.parse _namespace_name "Exclusion" |> NamespacedName
    /// <summary>
    /// An invoice generated automatically based on warranty/contract payment rules and claim assessment.
    /// <see href="https://ns.verisav.fr/wty#Invoice"></see></summary>
    let Invoice = Namespaced_IRI.parse _namespace_name "Invoice" |> NamespacedName
    /// <summary>
    /// Defines limits (financial, temporal, quantity) for warranty or contract coverage.
    /// <see href="https://ns.verisav.fr/wty#Limit"></see></summary>
    let Limit = Namespaced_IRI.parse _namespace_name "Limit" |> NamespacedName

    /// <summary>
    /// Defines who pays for what (diagnostic, repair, parts, travel) and payment splits between parties.
    /// <see href="https://ns.verisav.fr/wty#PaymentRule"></see></summary>
    let PaymentRule =
        Namespaced_IRI.parse _namespace_name "PaymentRule" |> NamespacedName

    /// <summary>
    /// An extended warranty that defines coverage, exclusions, payment rules, and conditions in a machine-readable format for automation.
    /// <see href="https://ns.verisav.fr/wty#Warranty"></see></summary>
    let Warranty = Namespaced_IRI.parse _namespace_name "Warranty" |> NamespacedName

    /// <summary>
    /// Links a claim assessment to the coverage that applies.
    /// <see href="https://ns.verisav.fr/wty#appliedCoverage"></see></summary>
    let appliedCoverage =
        Namespaced_IRI.parse _namespace_name "appliedCoverage" |> NamespacedName

    /// <summary>
    /// Links a claim assessment to exclusions that apply.
    /// <see href="https://ns.verisav.fr/wty#appliedExclusions"></see></summary>
    let appliedExclusions =
        Namespaced_IRI.parse _namespace_name "appliedExclusions" |> NamespacedName

    /// <summary>
    /// Links a claim assessment to the ticket or claim being assessed.
    /// <see href="https://ns.verisav.fr/wty#assessesClaim"></see></summary>
    let assessesClaim =
        Namespaced_IRI.parse _namespace_name "assessesClaim" |> NamespacedName

    /// <summary>
    /// Date when the assessment was performed.
    /// <see href="https://ns.verisav.fr/wty#assessmentDate"></see></summary>
    let assessmentDate =
        Namespaced_IRI.parse _namespace_name "assessmentDate" |> NamespacedName

    /// <summary>
    /// Reason for the assessment result (explanation of why covered or not).
    /// <see href="https://ns.verisav.fr/wty#assessmentReason"></see></summary>
    let assessmentReason =
        Namespaced_IRI.parse _namespace_name "assessmentReason" |> NamespacedName

    /// <summary>
    /// Result of the assessment (covered, not_covered, partially_covered, pending_verification).
    /// <see href="https://ns.verisav.fr/wty#assessmentResult"></see></summary>
    let assessmentResult =
        Namespaced_IRI.parse _namespace_name "assessmentResult" |> NamespacedName

    /// <summary>
    /// Whether the contract auto-renews.
    /// <see href="https://ns.verisav.fr/wty#autoRenewal"></see></summary>
    let autoRenewal =
        Namespaced_IRI.parse _namespace_name "autoRenewal" |> NamespacedName

    /// <summary>
    /// Links a claim assessment to the coverage being checked.
    /// <see href="https://ns.verisav.fr/wty#checksCoverage"></see></summary>
    let checksCoverage =
        Namespaced_IRI.parse _namespace_name "checksCoverage" |> NamespacedName

    /// <summary>
    /// Links a claim assessment to exclusions being checked.
    /// <see href="https://ns.verisav.fr/wty#checksExclusions"></see></summary>
    let checksExclusions =
        Namespaced_IRI.parse _namespace_name "checksExclusions" |> NamespacedName

    /// <summary>
    /// Description of the condition that must be met.
    /// <see href="https://ns.verisav.fr/wty#conditionDescription"></see></summary>
    let conditionDescription =
        Namespaced_IRI.parse _namespace_name "conditionDescription" |> NamespacedName

    /// <summary>
    /// Type of condition (normal_use, proper_installation, documentation, proof_of_purchase, etc.).
    /// <see href="https://ns.verisav.fr/wty#conditionType"></see></summary>
    let conditionType =
        Namespaced_IRI.parse _namespace_name "conditionType" |> NamespacedName

    /// <summary>
    /// End date of the contract.
    /// <see href="https://ns.verisav.fr/wty#contractEndDate"></see></summary>
    let contractEndDate =
        Namespaced_IRI.parse _namespace_name "contractEndDate" |> NamespacedName

    /// <summary>
    /// Unique identifier for the contract.
    /// <see href="https://ns.verisav.fr/wty#contractNumber"></see></summary>
    let contractNumber =
        Namespaced_IRI.parse _namespace_name "contractNumber" |> NamespacedName

    /// <summary>
    /// Start date of the contract.
    /// <see href="https://ns.verisav.fr/wty#contractStartDate"></see></summary>
    let contractStartDate =
        Namespaced_IRI.parse _namespace_name "contractStartDate" |> NamespacedName

    /// <summary>
    /// Status of the contract (active, expired, suspended, cancelled, renewed).
    /// <see href="https://ns.verisav.fr/wty#contractStatus"></see></summary>
    let contractStatus =
        Namespaced_IRI.parse _namespace_name "contractStatus" |> NamespacedName

    /// <summary>
    /// Type of contract (maintenance, extension, insurance, service_agreement).
    /// <see href="https://ns.verisav.fr/wty#contractType"></see></summary>
    let contractType =
        Namespaced_IRI.parse _namespace_name "contractType" |> NamespacedName

    /// <summary>
    /// End date of coverage period.
    /// <see href="https://ns.verisav.fr/wty#coverageEndDate"></see></summary>
    let coverageEndDate =
        Namespaced_IRI.parse _namespace_name "coverageEndDate" |> NamespacedName

    /// <summary>
    /// The period during which coverage applies (e.g., '24_months', 'lifetime').
    /// <see href="https://ns.verisav.fr/wty#coveragePeriod"></see></summary>
    let coveragePeriod =
        Namespaced_IRI.parse _namespace_name "coveragePeriod" |> NamespacedName

    /// <summary>
    /// Start date of coverage period.
    /// <see href="https://ns.verisav.fr/wty#coverageStartDate"></see></summary>
    let coverageStartDate =
        Namespaced_IRI.parse _namespace_name "coverageStartDate" |> NamespacedName

    /// <summary>
    /// Amount covered by warranty/contract for this claim.
    /// <see href="https://ns.verisav.fr/wty#coveredAmount"></see></summary>
    let coveredAmount =
        Namespaced_IRI.parse _namespace_name "coveredAmount" |> NamespacedName

    /// <summary>
    /// Currency code for the covered amount (ISO 4217).
    /// <see href="https://ns.verisav.fr/wty#coveredCurrency"></see></summary>
    let coveredCurrency =
        Namespaced_IRI.parse _namespace_name "coveredCurrency" |> NamespacedName

    /// <summary>
    /// Links coverage to specific product components that are covered.
    /// <see href="https://ns.verisav.fr/wty#coversComponent"></see></summary>
    let coversComponent =
        Namespaced_IRI.parse _namespace_name "coversComponent" |> NamespacedName

    /// <summary>
    /// Links coverage to types of defects that are covered.
    /// <see href="https://ns.verisav.fr/wty#coversDefectType"></see></summary>
    let coversDefectType =
        Namespaced_IRI.parse _namespace_name "coversDefectType" |> NamespacedName

    /// <summary>
    /// Links coverage to types of repairs that are covered.
    /// <see href="https://ns.verisav.fr/wty#coversRepairType"></see></summary>
    let coversRepairType =
        Namespaced_IRI.parse _namespace_name "coversRepairType" |> NamespacedName

    /// <summary>
    /// Amount the customer is responsible for.
    /// <see href="https://ns.verisav.fr/wty#customerResponsibility"></see></summary>
    let customerResponsibility =
        Namespaced_IRI.parse _namespace_name "customerResponsibility" |> NamespacedName

    /// <summary>
    /// Links a warranty or contract to its conditions.
    /// <see href="https://ns.verisav.fr/wty#definesConditions"></see></summary>
    let definesConditions =
        Namespaced_IRI.parse _namespace_name "definesConditions" |> NamespacedName

    /// <summary>
    /// Links a warranty or contract to its coverage definition.
    /// <see href="https://ns.verisav.fr/wty#definesCoverage"></see></summary>
    let definesCoverage =
        Namespaced_IRI.parse _namespace_name "definesCoverage" |> NamespacedName

    /// <summary>
    /// Links a warranty or contract to its exclusion definitions.
    /// <see href="https://ns.verisav.fr/wty#definesExclusions"></see></summary>
    let definesExclusions =
        Namespaced_IRI.parse _namespace_name "definesExclusions" |> NamespacedName

    /// <summary>
    /// Links a warranty or contract to its limits.
    /// <see href="https://ns.verisav.fr/wty#definesLimits"></see></summary>
    let definesLimits =
        Namespaced_IRI.parse _namespace_name "definesLimits" |> NamespacedName

    /// <summary>
    /// Links a warranty or contract to its payment rule.
    /// <see href="https://ns.verisav.fr/wty#definesPaymentRule"></see></summary>
    let definesPaymentRule =
        Namespaced_IRI.parse _namespace_name "definesPaymentRule" |> NamespacedName

    /// <summary>
    /// Links a claim assessment to the payment rule used to determine payment responsibility.
    /// <see href="https://ns.verisav.fr/wty#determinesPayment"></see></summary>
    let determinesPayment =
        Namespaced_IRI.parse _namespace_name "determinesPayment" |> NamespacedName

    /// <summary>
    /// Links exclusion to causes that are excluded (normal wear, damage, misuse, etc.).
    /// <see href="https://ns.verisav.fr/wty#excludedCause"></see></summary>
    let excludedCause =
        Namespaced_IRI.parse _namespace_name "excludedCause" |> NamespacedName

    /// <summary>
    /// Links exclusion to specific components that are excluded.
    /// <see href="https://ns.verisav.fr/wty#excludedComponent"></see></summary>
    let excludedComponent =
        Namespaced_IRI.parse _namespace_name "excludedComponent" |> NamespacedName

    /// <summary>
    /// Links exclusion to types of defects that are excluded.
    /// <see href="https://ns.verisav.fr/wty#excludedDefectType"></see></summary>
    let excludedDefectType =
        Namespaced_IRI.parse _namespace_name "excludedDefectType" |> NamespacedName

    /// <summary>
    /// The party (organization or person) that pays first or primarily.
    /// <see href="https://ns.verisav.fr/wty#firstParty"></see></summary>
    let firstParty = Namespaced_IRI.parse _namespace_name "firstParty" |> NamespacedName

    /// <summary>
    /// Links a claim assessment to the invoice generated.
    /// <see href="https://ns.verisav.fr/wty#generatesInvoice"></see></summary>
    let generatesInvoice =
        Namespaced_IRI.parse _namespace_name "generatesInvoice" |> NamespacedName

    /// <summary>
    /// Whether the payment rule has a limit.
    /// <see href="https://ns.verisav.fr/wty#hasPaymentLimit"></see></summary>
    let hasPaymentLimit =
        Namespaced_IRI.parse _namespace_name "hasPaymentLimit" |> NamespacedName

    /// <summary>
    /// Total amount of the invoice.
    /// <see href="https://ns.verisav.fr/wty#invoiceAmount"></see></summary>
    let invoiceAmount =
        Namespaced_IRI.parse _namespace_name "invoiceAmount" |> NamespacedName

    /// <summary>
    /// Currency code for the invoice amount (ISO 4217).
    /// <see href="https://ns.verisav.fr/wty#invoiceCurrency"></see></summary>
    let invoiceCurrency =
        Namespaced_IRI.parse _namespace_name "invoiceCurrency" |> NamespacedName

    /// <summary>
    /// Date when the invoice was generated.
    /// <see href="https://ns.verisav.fr/wty#invoiceDate"></see></summary>
    let invoiceDate =
        Namespaced_IRI.parse _namespace_name "invoiceDate" |> NamespacedName

    /// <summary>
    /// Unique identifier for the invoice.
    /// <see href="https://ns.verisav.fr/wty#invoiceNumber"></see></summary>
    let invoiceNumber =
        Namespaced_IRI.parse _namespace_name "invoiceNumber" |> NamespacedName

    /// <summary>
    /// Status of the invoice (draft, sent, paid, overdue, cancelled).
    /// <see href="https://ns.verisav.fr/wty#invoiceStatus"></see></summary>
    let invoiceStatus =
        Namespaced_IRI.parse _namespace_name "invoiceStatus" |> NamespacedName

    /// <summary>
    /// Links an invoice to the intervention, repair, or service being invoiced.
    /// <see href="https://ns.verisav.fr/wty#invoices"></see></summary>
    let invoices = Namespaced_IRI.parse _namespace_name "invoices" |> NamespacedName

    /// <summary>
    /// Maximum amount for the limit.
    /// <see href="https://ns.verisav.fr/wty#limitAmount"></see></summary>
    let limitAmount =
        Namespaced_IRI.parse _namespace_name "limitAmount" |> NamespacedName

    /// <summary>
    /// Currency code for the limit amount (ISO 4217).
    /// <see href="https://ns.verisav.fr/wty#limitCurrency"></see></summary>
    let limitCurrency =
        Namespaced_IRI.parse _namespace_name "limitCurrency" |> NamespacedName

    /// <summary>
    /// Period over which the limit applies (per_month, per_year, total, etc.).
    /// <see href="https://ns.verisav.fr/wty#limitPeriod"></see></summary>
    let limitPeriod =
        Namespaced_IRI.parse _namespace_name "limitPeriod" |> NamespacedName

    /// <summary>
    /// Maximum quantity (for number-based limits like interventions).
    /// <see href="https://ns.verisav.fr/wty#limitQuantity"></see></summary>
    let limitQuantity =
        Namespaced_IRI.parse _namespace_name "limitQuantity" |> NamespacedName

    /// <summary>
    /// Type of limit (amount, number_of_interventions, per_incident, total, etc.).
    /// <see href="https://ns.verisav.fr/wty#limitType"></see></summary>
    let limitType = Namespaced_IRI.parse _namespace_name "limitType" |> NamespacedName
    /// <summary>
    /// The party responsible for paying the invoice.
    /// <see href="https://ns.verisav.fr/wty#payer"></see></summary>
    let payer = Namespaced_IRI.parse _namespace_name "payer" |> NamespacedName

    /// <summary>
    /// Links a claim assessment to the payment rule that determines who pays.
    /// <see href="https://ns.verisav.fr/wty#paymentDecision"></see></summary>
    let paymentDecision =
        Namespaced_IRI.parse _namespace_name "paymentDecision" |> NamespacedName

    /// <summary>
    /// Percentage of cost paid by the first party (0-100).
    /// <see href="https://ns.verisav.fr/wty#paymentPercentage"></see></summary>
    let paymentPercentage =
        Namespaced_IRI.parse _namespace_name "paymentPercentage" |> NamespacedName

    /// <summary>
    /// JSON string describing payment split between multiple parties.
    /// JSON string describing how payment is split between parties (if multiple payers).
    /// <see href="https://ns.verisav.fr/wty#paymentSplit"></see></summary>
    let paymentSplit =
        Namespaced_IRI.parse _namespace_name "paymentSplit" |> NamespacedName

    /// <summary>
    /// Links a payment rule to what it pays for (diagnostic, repair, parts, travel, etc.).
    /// <see href="https://ns.verisav.fr/wty#paysFor"></see></summary>
    let paysFor = Namespaced_IRI.parse _namespace_name "paysFor" |> NamespacedName

    /// <summary>
    /// Whether documentation is required (proof of purchase, installation certificate, etc.).
    /// <see href="https://ns.verisav.fr/wty#requiresDocumentation"></see></summary>
    let requiresDocumentation =
        Namespaced_IRI.parse _namespace_name "requiresDocumentation" |> NamespacedName

    /// <summary>
    /// Whether proof is required (photos, diagnostic report, etc.).
    /// <see href="https://ns.verisav.fr/wty#requiresProof"></see></summary>
    let requiresProof =
        Namespaced_IRI.parse _namespace_name "requiresProof" |> NamespacedName

    /// <summary>
    /// Links a ticket or claim to a claim assessment.
    /// <see href="https://ns.verisav.fr/wty#triggersAssessment"></see></summary>
    let triggersAssessment =
        Namespaced_IRI.parse _namespace_name "triggersAssessment" |> NamespacedName

    /// <summary>
    /// Period during which the condition is valid (e.g., 'warranty_period', 'lifetime').
    /// <see href="https://ns.verisav.fr/wty#validityPeriod"></see></summary>
    let validityPeriod =
        Namespaced_IRI.parse _namespace_name "validityPeriod" |> NamespacedName
