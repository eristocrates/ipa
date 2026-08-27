namespace https.ns.verisav.fr.wty.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module wty =
    let _namespace_iri = Namespace_Iri wty |> NamespaceIRI
    /// <summary>
    ///   <para>wty:</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    ///   <para>dcat:Distribution</para>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>schemas:SearchAction</para>
    ///   <para>"Version 1.0.0 (2025-12-28): Initial release. Vocabulary for machine-readable warranties and contracts with payment rules, coverage definitions, exclusions, and automated claim assessment."</para>
    ///   <para>"Version 1.0.0 (2025-12-28): Version initiale. Vocabulaire pour garanties et contrats lisibles par machine avec règles de paiement, définitions de couverture, exclusions et évaluation automatisée des réclamations."</para>
    /// labels<para>"Vocabulaire Garanties et Contrats Verisav"</para><para>"Verisav Warranty &amp; Contracts Vocabulary"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#">https://ns.verisav.fr/wty#</seealso>
    let _prefix_iri = Prefixed_Name(wty, "") |> PrefixedName
    /// <summary>
    ///   <para>wty:ClaimAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Automated assessment of a claim against warranty or contract, determining coverage and payment responsibility."</para>
    /// labels<para>"Évaluation de Réclamation"</para><para>"Claim Assessment"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#ClaimAssessment">https://ns.verisav.fr/wty#ClaimAssessment</seealso>
    let ClaimAssessment = Prefixed_Name(wty, "ClaimAssessment") |> PrefixedName
    /// <summary>
    ///   <para>wty:Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A condition that must be met for warranty or contract to apply (normal use, proper installation, documentation, etc.)."</para>
    /// labels<para>"Condition"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#Condition">https://ns.verisav.fr/wty#Condition</seealso>
    let Condition = Prefixed_Name(wty, "Condition") |> PrefixedName
    /// <summary>
    ///   <para>wty:Contract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A contract (maintenance, extension, insurance) that defines terms and coverage for after-sales service."</para>
    /// labels<para>"Contrat"</para><para>"Contract"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#Contract">https://ns.verisav.fr/wty#Contract</seealso>
    let Contract = Prefixed_Name(wty, "Contract") |> PrefixedName
    /// <summary>
    ///   <para>wty:Coverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines what is covered by a warranty or contract (components, defect types, repair types, periods)."</para>
    /// labels<para>"Coverage"</para><para>"Couverture"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#Coverage">https://ns.verisav.fr/wty#Coverage</seealso>
    let Coverage = Prefixed_Name(wty, "Coverage") |> PrefixedName
    /// <summary>
    ///   <para>wty:Exclusion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines what is NOT covered by a warranty or contract (excluded defect types, causes, components)."</para>
    /// labels<para>"Exclusion"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#Exclusion">https://ns.verisav.fr/wty#Exclusion</seealso>
    let Exclusion = Prefixed_Name(wty, "Exclusion") |> PrefixedName
    /// <summary>
    ///   <para>wty:Invoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An invoice generated automatically based on warranty/contract payment rules and claim assessment."</para>
    /// labels<para>"Facture"</para><para>"Invoice"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#Invoice">https://ns.verisav.fr/wty#Invoice</seealso>
    let Invoice = Prefixed_Name(wty, "Invoice") |> PrefixedName
    /// <summary>
    ///   <para>wty:Limit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines limits (financial, temporal, quantity) for warranty or contract coverage."</para>
    /// labels<para>"Limit"</para><para>"Limite"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#Limit">https://ns.verisav.fr/wty#Limit</seealso>
    let Limit = Prefixed_Name(wty, "Limit") |> PrefixedName
    /// <summary>
    ///   <para>wty:PaymentRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Defines who pays for what (diagnostic, repair, parts, travel) and payment splits between parties."</para>
    /// labels<para>"Payment Rule"</para><para>"Règle de Paiement"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#PaymentRule">https://ns.verisav.fr/wty#PaymentRule</seealso>
    let PaymentRule = Prefixed_Name(wty, "PaymentRule") |> PrefixedName
    /// <summary>
    ///   <para>wty:Warranty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An extended warranty that defines coverage, exclusions, payment rules, and conditions in a machine-readable format for automation."</para>
    /// labels<para>"Warranty"</para><para>"Garantie"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#Warranty">https://ns.verisav.fr/wty#Warranty</seealso>
    let Warranty = Prefixed_Name(wty, "Warranty") |> PrefixedName
    /// <summary>
    ///   <para>wty:appliedCoverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a claim assessment to the coverage that applies."</para>
    /// labels<para>"couverture appliquée"</para><para>"applied coverage"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#appliedCoverage">https://ns.verisav.fr/wty#appliedCoverage</seealso>
    let appliedCoverage = Prefixed_Name(wty, "appliedCoverage") |> PrefixedName
    /// <summary>
    ///   <para>wty:appliedExclusions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a claim assessment to exclusions that apply."</para>
    /// labels<para>"exclusions appliquées"</para><para>"applied exclusions"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#appliedExclusions">https://ns.verisav.fr/wty#appliedExclusions</seealso>
    let appliedExclusions = Prefixed_Name(wty, "appliedExclusions") |> PrefixedName
    /// <summary>
    ///   <para>wty:assessesClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a claim assessment to the ticket or claim being assessed."</para>
    /// labels<para>"évalue la réclamation"</para><para>"assesses claim"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#assessesClaim">https://ns.verisav.fr/wty#assessesClaim</seealso>
    let assessesClaim = Prefixed_Name(wty, "assessesClaim") |> PrefixedName
    /// <summary>
    ///   <para>wty:assessmentDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date when the assessment was performed."</para>
    /// labels<para>"date d'évaluation"</para><para>"assessment date"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#assessmentDate">https://ns.verisav.fr/wty#assessmentDate</seealso>
    let assessmentDate = Prefixed_Name(wty, "assessmentDate") |> PrefixedName
    /// <summary>
    ///   <para>wty:assessmentReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Reason for the assessment result (explanation of why covered or not)."</para>
    /// labels<para>"raison d'évaluation"</para><para>"assessment reason"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#assessmentReason">https://ns.verisav.fr/wty#assessmentReason</seealso>
    let assessmentReason = Prefixed_Name(wty, "assessmentReason") |> PrefixedName
    /// <summary>
    ///   <para>wty:assessmentResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Result of the assessment (covered, not_covered, partially_covered, pending_verification)."</para>
    /// labels<para>"résultat d'évaluation"</para><para>"assessment result"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#assessmentResult">https://ns.verisav.fr/wty#assessmentResult</seealso>
    let assessmentResult = Prefixed_Name(wty, "assessmentResult") |> PrefixedName
    /// <summary>
    ///   <para>wty:autoRenewal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Whether the contract auto-renews."</para>
    /// labels<para>"renouvellement automatique"</para><para>"auto renewal"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#autoRenewal">https://ns.verisav.fr/wty#autoRenewal</seealso>
    let autoRenewal = Prefixed_Name(wty, "autoRenewal") |> PrefixedName
    /// <summary>
    ///   <para>wty:checksCoverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a claim assessment to the coverage being checked."</para>
    /// labels<para>"vérifie la couverture"</para><para>"checks coverage"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#checksCoverage">https://ns.verisav.fr/wty#checksCoverage</seealso>
    let checksCoverage = Prefixed_Name(wty, "checksCoverage") |> PrefixedName
    /// <summary>
    ///   <para>wty:checksExclusions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a claim assessment to exclusions being checked."</para>
    /// labels<para>"checks exclusions"</para><para>"vérifie les exclusions"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#checksExclusions">https://ns.verisav.fr/wty#checksExclusions</seealso>
    let checksExclusions = Prefixed_Name(wty, "checksExclusions") |> PrefixedName

    /// <summary>
    ///   <para>wty:conditionDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Description of the condition that must be met."</para>
    /// labels<para>"description de condition"</para><para>"condition description"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#conditionDescription">https://ns.verisav.fr/wty#conditionDescription</seealso>
    let conditionDescription =
        Prefixed_Name(wty, "conditionDescription") |> PrefixedName

    /// <summary>
    ///   <para>wty:conditionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Type of condition (normal_use, proper_installation, documentation, proof_of_purchase, etc.)."</para>
    /// labels<para>"type de condition"</para><para>"condition type"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#conditionType">https://ns.verisav.fr/wty#conditionType</seealso>
    let conditionType = Prefixed_Name(wty, "conditionType") |> PrefixedName
    /// <summary>
    ///   <para>wty:contractEndDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"End date of the contract."</para>
    /// labels<para>"contract end date"</para><para>"date de fin de contrat"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#contractEndDate">https://ns.verisav.fr/wty#contractEndDate</seealso>
    let contractEndDate = Prefixed_Name(wty, "contractEndDate") |> PrefixedName
    /// <summary>
    ///   <para>wty:contractNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Unique identifier for the contract."</para>
    /// labels<para>"contract number"</para><para>"numéro de contrat"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#contractNumber">https://ns.verisav.fr/wty#contractNumber</seealso>
    let contractNumber = Prefixed_Name(wty, "contractNumber") |> PrefixedName
    /// <summary>
    ///   <para>wty:contractStartDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Start date of the contract."</para>
    /// labels<para>"contract start date"</para><para>"date de début de contrat"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#contractStartDate">https://ns.verisav.fr/wty#contractStartDate</seealso>
    let contractStartDate = Prefixed_Name(wty, "contractStartDate") |> PrefixedName
    /// <summary>
    ///   <para>wty:contractStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Status of the contract (active, expired, suspended, cancelled, renewed)."</para>
    /// labels<para>"contract status"</para><para>"statut du contrat"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#contractStatus">https://ns.verisav.fr/wty#contractStatus</seealso>
    let contractStatus = Prefixed_Name(wty, "contractStatus") |> PrefixedName
    /// <summary>
    ///   <para>wty:contractType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Type of contract (maintenance, extension, insurance, service_agreement)."</para>
    /// labels<para>"type de contrat"</para><para>"contract type"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#contractType">https://ns.verisav.fr/wty#contractType</seealso>
    let contractType = Prefixed_Name(wty, "contractType") |> PrefixedName
    /// <summary>
    ///   <para>wty:coverageEndDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"End date of coverage period."</para>
    /// labels<para>"date de fin de couverture"</para><para>"coverage end date"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#coverageEndDate">https://ns.verisav.fr/wty#coverageEndDate</seealso>
    let coverageEndDate = Prefixed_Name(wty, "coverageEndDate") |> PrefixedName
    /// <summary>
    ///   <para>wty:coveragePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The period during which coverage applies (e.g., '24_months', 'lifetime')."</para>
    /// labels<para>"période de couverture"</para><para>"coverage period"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#coveragePeriod">https://ns.verisav.fr/wty#coveragePeriod</seealso>
    let coveragePeriod = Prefixed_Name(wty, "coveragePeriod") |> PrefixedName
    /// <summary>
    ///   <para>wty:coverageStartDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Start date of coverage period."</para>
    /// labels<para>"date de début de couverture"</para><para>"coverage start date"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#coverageStartDate">https://ns.verisav.fr/wty#coverageStartDate</seealso>
    let coverageStartDate = Prefixed_Name(wty, "coverageStartDate") |> PrefixedName
    /// <summary>
    ///   <para>wty:coveredAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Amount covered by warranty/contract for this claim."</para>
    /// labels<para>"covered amount"</para><para>"montant couvert"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#coveredAmount">https://ns.verisav.fr/wty#coveredAmount</seealso>
    let coveredAmount = Prefixed_Name(wty, "coveredAmount") |> PrefixedName
    /// <summary>
    ///   <para>wty:coveredCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Currency code for the covered amount (ISO 4217)."</para>
    /// labels<para>"devise couverte"</para><para>"covered currency"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#coveredCurrency">https://ns.verisav.fr/wty#coveredCurrency</seealso>
    let coveredCurrency = Prefixed_Name(wty, "coveredCurrency") |> PrefixedName
    /// <summary>
    ///   <para>wty:coversComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links coverage to specific product components that are covered."</para>
    /// labels<para>"covers component"</para><para>"couvre le composant"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#coversComponent">https://ns.verisav.fr/wty#coversComponent</seealso>
    let coversComponent = Prefixed_Name(wty, "coversComponent") |> PrefixedName
    /// <summary>
    ///   <para>wty:coversDefectType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links coverage to types of defects that are covered."</para>
    /// labels<para>"covers defect type"</para><para>"couvre le type de défaut"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#coversDefectType">https://ns.verisav.fr/wty#coversDefectType</seealso>
    let coversDefectType = Prefixed_Name(wty, "coversDefectType") |> PrefixedName
    /// <summary>
    ///   <para>wty:coversRepairType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links coverage to types of repairs that are covered."</para>
    /// labels<para>"covers repair type"</para><para>"couvre le type de réparation"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#coversRepairType">https://ns.verisav.fr/wty#coversRepairType</seealso>
    let coversRepairType = Prefixed_Name(wty, "coversRepairType") |> PrefixedName

    /// <summary>
    ///   <para>wty:customerResponsibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Amount the customer is responsible for."</para>
    /// labels<para>"customer responsibility"</para><para>"responsabilité client"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#customerResponsibility">https://ns.verisav.fr/wty#customerResponsibility</seealso>
    let customerResponsibility =
        Prefixed_Name(wty, "customerResponsibility") |> PrefixedName

    /// <summary>
    ///   <para>wty:definesConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a warranty or contract to its conditions."</para>
    /// labels<para>"defines conditions"</para><para>"définit les conditions"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#definesConditions">https://ns.verisav.fr/wty#definesConditions</seealso>
    let definesConditions = Prefixed_Name(wty, "definesConditions") |> PrefixedName
    /// <summary>
    ///   <para>wty:definesCoverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a warranty or contract to its coverage definition."</para>
    /// labels<para>"defines coverage"</para><para>"définit la couverture"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#definesCoverage">https://ns.verisav.fr/wty#definesCoverage</seealso>
    let definesCoverage = Prefixed_Name(wty, "definesCoverage") |> PrefixedName
    /// <summary>
    ///   <para>wty:definesExclusions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a warranty or contract to its exclusion definitions."</para>
    /// labels<para>"defines exclusions"</para><para>"définit les exclusions"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#definesExclusions">https://ns.verisav.fr/wty#definesExclusions</seealso>
    let definesExclusions = Prefixed_Name(wty, "definesExclusions") |> PrefixedName
    /// <summary>
    ///   <para>wty:definesLimits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a warranty or contract to its limits."</para>
    /// labels<para>"définit les limites"</para><para>"defines limits"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#definesLimits">https://ns.verisav.fr/wty#definesLimits</seealso>
    let definesLimits = Prefixed_Name(wty, "definesLimits") |> PrefixedName
    /// <summary>
    ///   <para>wty:definesPaymentRule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a warranty or contract to its payment rule."</para>
    /// labels<para>"defines payment rule"</para><para>"définit la règle de paiement"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#definesPaymentRule">https://ns.verisav.fr/wty#definesPaymentRule</seealso>
    let definesPaymentRule = Prefixed_Name(wty, "definesPaymentRule") |> PrefixedName
    /// <summary>
    ///   <para>wty:determinesPayment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a claim assessment to the payment rule used to determine payment responsibility."</para>
    /// labels<para>"determines payment"</para><para>"détermine le paiement"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#determinesPayment">https://ns.verisav.fr/wty#determinesPayment</seealso>
    let determinesPayment = Prefixed_Name(wty, "determinesPayment") |> PrefixedName
    /// <summary>
    ///   <para>wty:excludedCause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links exclusion to causes that are excluded (normal wear, damage, misuse, etc.)."</para>
    /// labels<para>"cause exclue"</para><para>"excluded cause"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#excludedCause">https://ns.verisav.fr/wty#excludedCause</seealso>
    let excludedCause = Prefixed_Name(wty, "excludedCause") |> PrefixedName
    /// <summary>
    ///   <para>wty:excludedComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links exclusion to specific components that are excluded."</para>
    /// labels<para>"excluded component"</para><para>"composant exclu"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#excludedComponent">https://ns.verisav.fr/wty#excludedComponent</seealso>
    let excludedComponent = Prefixed_Name(wty, "excludedComponent") |> PrefixedName
    /// <summary>
    ///   <para>wty:excludedDefectType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links exclusion to types of defects that are excluded."</para>
    /// labels<para>"type de défaut exclu"</para><para>"excluded defect type"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#excludedDefectType">https://ns.verisav.fr/wty#excludedDefectType</seealso>
    let excludedDefectType = Prefixed_Name(wty, "excludedDefectType") |> PrefixedName
    /// <summary>
    ///   <para>wty:firstParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The party (organization or person) that pays first or primarily."</para>
    /// labels<para>"first party"</para><para>"première partie"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#firstParty">https://ns.verisav.fr/wty#firstParty</seealso>
    let firstParty = Prefixed_Name(wty, "firstParty") |> PrefixedName
    /// <summary>
    ///   <para>wty:generatesInvoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a claim assessment to the invoice generated."</para>
    /// labels<para>"génère la facture"</para><para>"generates invoice"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#generatesInvoice">https://ns.verisav.fr/wty#generatesInvoice</seealso>
    let generatesInvoice = Prefixed_Name(wty, "generatesInvoice") |> PrefixedName
    /// <summary>
    ///   <para>wty:hasPaymentLimit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Whether the payment rule has a limit."</para>
    /// labels<para>"a une limite de paiement"</para><para>"has payment limit"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#hasPaymentLimit">https://ns.verisav.fr/wty#hasPaymentLimit</seealso>
    let hasPaymentLimit = Prefixed_Name(wty, "hasPaymentLimit") |> PrefixedName
    /// <summary>
    ///   <para>wty:invoiceAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Total amount of the invoice."</para>
    /// labels<para>"montant de facture"</para><para>"invoice amount"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#invoiceAmount">https://ns.verisav.fr/wty#invoiceAmount</seealso>
    let invoiceAmount = Prefixed_Name(wty, "invoiceAmount") |> PrefixedName
    /// <summary>
    ///   <para>wty:invoiceCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Currency code for the invoice amount (ISO 4217)."</para>
    /// labels<para>"invoice currency"</para><para>"devise de facture"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#invoiceCurrency">https://ns.verisav.fr/wty#invoiceCurrency</seealso>
    let invoiceCurrency = Prefixed_Name(wty, "invoiceCurrency") |> PrefixedName
    /// <summary>
    ///   <para>wty:invoiceDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Date when the invoice was generated."</para>
    /// labels<para>"date de facture"</para><para>"invoice date"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#invoiceDate">https://ns.verisav.fr/wty#invoiceDate</seealso>
    let invoiceDate = Prefixed_Name(wty, "invoiceDate") |> PrefixedName
    /// <summary>
    ///   <para>wty:invoiceNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Unique identifier for the invoice."</para>
    /// labels<para>"numéro de facture"</para><para>"invoice number"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#invoiceNumber">https://ns.verisav.fr/wty#invoiceNumber</seealso>
    let invoiceNumber = Prefixed_Name(wty, "invoiceNumber") |> PrefixedName
    /// <summary>
    ///   <para>wty:invoiceStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Status of the invoice (draft, sent, paid, overdue, cancelled)."</para>
    /// labels<para>"statut de facture"</para><para>"invoice status"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#invoiceStatus">https://ns.verisav.fr/wty#invoiceStatus</seealso>
    let invoiceStatus = Prefixed_Name(wty, "invoiceStatus") |> PrefixedName
    /// <summary>
    ///   <para>wty:invoices</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links an invoice to the intervention, repair, or service being invoiced."</para>
    /// labels<para>"invoices"</para><para>"facture"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#invoices">https://ns.verisav.fr/wty#invoices</seealso>
    let invoices = Prefixed_Name(wty, "invoices") |> PrefixedName
    /// <summary>
    ///   <para>wty:limitAmount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Maximum amount for the limit."</para>
    /// labels<para>"limit amount"</para><para>"montant limite"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#limitAmount">https://ns.verisav.fr/wty#limitAmount</seealso>
    let limitAmount = Prefixed_Name(wty, "limitAmount") |> PrefixedName
    /// <summary>
    ///   <para>wty:limitCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Currency code for the limit amount (ISO 4217)."</para>
    /// labels<para>"devise limite"</para><para>"limit currency"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#limitCurrency">https://ns.verisav.fr/wty#limitCurrency</seealso>
    let limitCurrency = Prefixed_Name(wty, "limitCurrency") |> PrefixedName
    /// <summary>
    ///   <para>wty:limitPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Period over which the limit applies (per_month, per_year, total, etc.)."</para>
    /// labels<para>"période limite"</para><para>"limit period"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#limitPeriod">https://ns.verisav.fr/wty#limitPeriod</seealso>
    let limitPeriod = Prefixed_Name(wty, "limitPeriod") |> PrefixedName
    /// <summary>
    ///   <para>wty:limitQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Maximum quantity (for number-based limits like interventions)."</para>
    /// labels<para>"quantité limite"</para><para>"limit quantity"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#limitQuantity">https://ns.verisav.fr/wty#limitQuantity</seealso>
    let limitQuantity = Prefixed_Name(wty, "limitQuantity") |> PrefixedName
    /// <summary>
    ///   <para>wty:limitType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Type of limit (amount, number_of_interventions, per_incident, total, etc.)."</para>
    /// labels<para>"limit type"</para><para>"type de limite"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#limitType">https://ns.verisav.fr/wty#limitType</seealso>
    let limitType = Prefixed_Name(wty, "limitType") |> PrefixedName
    /// <summary>
    ///   <para>wty:payer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The party responsible for paying the invoice."</para>
    /// labels<para>"payer"</para><para>"payeur"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#payer">https://ns.verisav.fr/wty#payer</seealso>
    let payer = Prefixed_Name(wty, "payer") |> PrefixedName
    /// <summary>
    ///   <para>wty:paymentDecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a claim assessment to the payment rule that determines who pays."</para>
    /// labels<para>"décision de paiement"</para><para>"payment decision"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#paymentDecision">https://ns.verisav.fr/wty#paymentDecision</seealso>
    let paymentDecision = Prefixed_Name(wty, "paymentDecision") |> PrefixedName
    /// <summary>
    ///   <para>wty:paymentPercentage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Percentage of cost paid by the first party (0-100)."</para>
    /// labels<para>"payment percentage"</para><para>"pourcentage de paiement"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#paymentPercentage">https://ns.verisav.fr/wty#paymentPercentage</seealso>
    let paymentPercentage = Prefixed_Name(wty, "paymentPercentage") |> PrefixedName
    /// <summary>
    ///   <para>wty:paymentSplit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"JSON string describing payment split between multiple parties."</para>
    ///   <para>"JSON string describing how payment is split between parties (if multiple payers)."</para>
    /// labels<para>"répartition du paiement"</para><para>"payment split"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#paymentSplit">https://ns.verisav.fr/wty#paymentSplit</seealso>
    let paymentSplit = Prefixed_Name(wty, "paymentSplit") |> PrefixedName
    /// <summary>
    ///   <para>wty:paysFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a payment rule to what it pays for (diagnostic, repair, parts, travel, etc.)."</para>
    /// labels<para>"paie pour"</para><para>"pays for"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#paysFor">https://ns.verisav.fr/wty#paysFor</seealso>
    let paysFor = Prefixed_Name(wty, "paysFor") |> PrefixedName

    /// <summary>
    ///   <para>wty:requiresDocumentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Whether documentation is required (proof of purchase, installation certificate, etc.)."</para>
    /// labels<para>"nécessite une documentation"</para><para>"requires documentation"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#requiresDocumentation">https://ns.verisav.fr/wty#requiresDocumentation</seealso>
    let requiresDocumentation =
        Prefixed_Name(wty, "requiresDocumentation") |> PrefixedName

    /// <summary>
    ///   <para>wty:requiresProof</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Whether proof is required (photos, diagnostic report, etc.)."</para>
    /// labels<para>"requires proof"</para><para>"nécessite une preuve"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#requiresProof">https://ns.verisav.fr/wty#requiresProof</seealso>
    let requiresProof = Prefixed_Name(wty, "requiresProof") |> PrefixedName
    /// <summary>
    ///   <para>wty:triggersAssessment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Links a ticket or claim to a claim assessment."</para>
    /// labels<para>"triggers assessment"</para><para>"déclenche l'évaluation"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#triggersAssessment">https://ns.verisav.fr/wty#triggersAssessment</seealso>
    let triggersAssessment = Prefixed_Name(wty, "triggersAssessment") |> PrefixedName
    /// <summary>
    ///   <para>wty:validityPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Period during which the condition is valid (e.g., 'warranty_period', 'lifetime')."</para>
    /// labels<para>"période de validité"</para><para>"validity period"</para></remarks>
    /// <seealso href="https://ns.verisav.fr/wty#validityPeriod">https://ns.verisav.fr/wty#validityPeriod</seealso>
    let validityPeriod = Prefixed_Name(wty, "validityPeriod") |> PrefixedName
