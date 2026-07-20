namespace https.ns.verisav.fr.dpp.hash

open DoxAletheia

module submit =
    let _namespace_name = "https://ns.verisav.fr/dpp#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Product circularity scorecard. Aligned with UNTP DPP.
    /// <see href="https://ns.verisav.fr/dpp#CircularityPerformance"></see></summary>
    let CircularityPerformance = _prefix "CircularityPerformance"
    /// <summary>
    /// A complex identifier combining a GTIN with a variant, batch, or serial number (Made-to-Order products).
    /// <see href="https://ns.verisav.fr/dpp#CompoundIdentifier"></see></summary>
    let CompoundIdentifier = _prefix "CompoundIdentifier"
    /// <summary>
    /// Claim of conformity to a standard or regulation. Aligned with UNTP DPP.
    /// <see href="https://ns.verisav.fr/dpp#ConformityClaim"></see></summary>
    let ConformityClaim = _prefix "ConformityClaim"
    /// <summary>
    /// A consumer who owns or uses a product.
    /// <see href="https://ns.verisav.fr/dpp#Consumer"></see></summary>
    let Consumer = _prefix "Consumer"
    /// <summary>
    /// A criterion or rule within a standard or regulation against which a claim is evaluated.
    /// <see href="https://ns.verisav.fr/dpp#Criterion"></see></summary>
    let Criterion = _prefix "Criterion"
    /// <summary>
    /// A diagnostic assessment performed on a product to identify issues.
    /// <see href="https://ns.verisav.fr/dpp#Diagnostic"></see></summary>
    let Diagnostic = _prefix "Diagnostic"
    /// <summary>
    /// A document associated with a product (manuals, invoices, certificates, etc.).
    /// <see href="https://ns.verisav.fr/dpp#Document"></see></summary>
    let Document = _prefix "Document"
    /// <summary>
    /// An economic operator in the value chain (manufacturer, importer, distributor, dealer, repairer) as per EU ESPR regulation. Can be authenticated via EU Business Wallet (EBW) with EUID (European Unique Identifier).
    /// <see href="https://ns.verisav.fr/dpp#EconomicOperator"></see></summary>
    let EconomicOperator = _prefix "EconomicOperator"
    /// <summary>
    /// Greenhouse gas emissions scorecard for a product. Aligned with UNTP DPP.
    /// <see href="https://ns.verisav.fr/dpp#EmissionsPerformance"></see></summary>
    let EmissionsPerformance = _prefix "EmissionsPerformance"
    /// <summary>
    /// A location or building involved in the value chain of a product (manufacturing facility, warehouse, etc.) as per EU ESPR regulation. Aligned with UNTP DPP-04.
    /// <see href="https://ns.verisav.fr/dpp#Facility"></see></summary>
    let Facility = _prefix "Facility"
    /// <summary>
    /// A technical intervention on a product (diagnostic, repair, maintenance, replacement, return to manufacturer).
    /// <see href="https://ns.verisav.fr/dpp#Intervention"></see></summary>
    let Intervention = _prefix "Intervention"
    /// <summary>
    /// A specific repair or maintenance intervention performed on a product.
    /// <see href="https://ns.verisav.fr/dpp#RepairEvent"></see></summary>
    let RepairEvent = _prefix "RepairEvent"
    /// <summary>
    /// The manufacturer of a product.
    /// <see href="https://ns.verisav.fr/dpp#Manufacturer"></see></summary>
    let Manufacturer = _prefix "Manufacturer"
    /// <summary>
    /// Information about material provenance: name, mass fraction, origin country. Aligned with UNTP DPP-03.
    /// <see href="https://ns.verisav.fr/dpp#MaterialProvenance"></see></summary>
    let MaterialProvenance = _prefix "MaterialProvenance"
    /// <summary>
    /// A metric defining actual measured values, optionally including accuracy.
    /// <see href="https://ns.verisav.fr/dpp#Metric"></see></summary>
    let Metric = _prefix "Metric"
    /// <summary>
    /// Product classification according to a standardized scheme (UN-CPC, GS1, NACE, etc.). Aligned with UNTP DPP-02.
    /// <see href="https://ns.verisav.fr/dpp#ProductClassification"></see></summary>
    let ProductClassification = _prefix "ProductClassification"
    /// <summary>
    /// A stage in the product lifecycle (manufacturing, purchase, usage, end of life, recycling).
    /// <see href="https://ns.verisav.fr/dpp#ProductLifecycleStage"></see></summary>
    let ProductLifecycleStage = _prefix "ProductLifecycleStage"
    /// <summary>
    /// A Digital Product Passport that tracks a product throughout its entire lifecycle.
    /// <see href="https://ns.verisav.fr/dpp#ProductPassport"></see></summary>
    let ProductPassport = _prefix "ProductPassport"
    /// <summary>
    /// The current status of a product (under warranty, out of warranty, broken, repaired, etc.).
    /// <see href="https://ns.verisav.fr/dpp#ProductStatus"></see></summary>
    let ProductStatus = _prefix "ProductStatus"
    /// <summary>
    /// Instructions for recycling or disposing of a product at end of life.
    /// <see href="https://ns.verisav.fr/dpp#RecyclingInstructions"></see></summary>
    let RecyclingInstructions = _prefix "RecyclingInstructions"
    /// <summary>
    /// Reference regulation for a conformity claim.
    /// <see href="https://ns.verisav.fr/dpp#Regulation"></see></summary>
    let Regulation = _prefix "Regulation"
    /// <summary>
    /// A person or organization that repairs products.
    /// <see href="https://ns.verisav.fr/dpp#Repairer"></see></summary>
    let Repairer = _prefix "Repairer"
    /// <summary>
    /// A part used to replace a component in a product during repair or maintenance.
    /// <see href="https://ns.verisav.fr/dpp#ReplacementPart"></see></summary>
    let ReplacementPart = _prefix "ReplacementPart"
    /// <summary>
    /// A retailer or distributor who sells products.
    /// <see href="https://ns.verisav.fr/dpp#Retailer"></see></summary>
    let Retailer = _prefix "Retailer"
    /// <summary>
    /// A secure sharing of DPP data between economic operators via EU Business Wallet (EBW). Includes cryptographic integrity verification and timestamping.
    /// <see href="https://ns.verisav.fr/dpp#SecureDataShare"></see></summary>
    let SecureDataShare = _prefix "SecureDataShare"
    /// <summary>
    /// A secure link with hash digest and encryption method for verification.
    /// <see href="https://ns.verisav.fr/dpp#SecureLink"></see></summary>
    let SecureLink = _prefix "SecureLink"
    /// <summary>
    /// A request for after-sales service (SAV) for a product.
    /// <see href="https://ns.verisav.fr/dpp#ServiceRequest"></see></summary>
    let ServiceRequest = _prefix "ServiceRequest"
    /// <summary>
    /// Standard, norm, or reference scheme for a conformity claim.
    /// <see href="https://ns.verisav.fr/dpp#Standard"></see></summary>
    let Standard = _prefix "Standard"
    /// <summary>
    /// Traceability event based on ISO/IEC 19987 (EPCIS) or similar standards. Aligned with UNTP DPP-06.
    /// <see href="https://ns.verisav.fr/dpp#TraceabilityEvent"></see></summary>
    let TraceabilityEvent = _prefix "TraceabilityEvent"
    /// <summary>
    /// Traceability information for a specific value chain process. Aligned with UNTP DPP.
    /// <see href="https://ns.verisav.fr/dpp#TraceabilityPerformance"></see></summary>
    let TraceabilityPerformance = _prefix "TraceabilityPerformance"
    /// <summary>
    /// A W3C Verifiable Credential (VCDM 2.0) that can be used to verify claims about a product passport or economic operator. Stored and managed via EU Business Wallet (EBW).
    /// <see href="https://ns.verisav.fr/dpp#VerifiableCredential"></see></summary>
    let VerifiableCredential = _prefix "VerifiableCredential"
    /// <summary>
    /// A Digital Product Passport issued as a W3C Verifiable Credential (VCDM 2.0) via EU Business Wallet (EBW). Provides cryptographic proof of authenticity and integrity.
    /// <see href="https://ns.verisav.fr/dpp#VerifiableProductPassport"></see></summary>
    let VerifiableProductPassport = _prefix "VerifiableProductPassport"
    /// <summary>
    /// A warranty covering a product, which can be of different types (manufacturer, retailer, extension, maintenance).
    /// <see href="https://ns.verisav.fr/dpp#Warranty"></see></summary>
    let Warranty = _prefix "Warranty"
    /// <summary>
    /// A claim made under a warranty.
    /// <see href="https://ns.verisav.fr/dpp#WarrantyClaim"></see></summary>
    let WarrantyClaim = _prefix "WarrantyClaim"
    /// <summary>
    /// An order for work to be performed on a product (repair, maintenance, etc.).
    /// <see href="https://ns.verisav.fr/dpp#WorkOrder"></see></summary>
    let WorkOrder = _prefix "WorkOrder"
    /// <summary>
    /// Accuracy or uncertainty of the metric value (optional).
    /// <see href="https://ns.verisav.fr/dpp#accuracy"></see></summary>
    let accuracy = _prefix "accuracy"
    /// <summary>
    /// Criteria within the standard or regulation against which the claim is evaluated.
    /// <see href="https://ns.verisav.fr/dpp#assessmentCriteria"></see></summary>
    let assessmentCriteria = _prefix "assessmentCriteria"
    /// <summary>
    /// Date when the claim was assessed.
    /// <see href="https://ns.verisav.fr/dpp#assessmentDate"></see></summary>
    let assessmentDate = _prefix "assessmentDate"
    /// <summary>
    /// The batch or lot number (GS1 AI 10) for production batches. Used with GTIN for batch-level granularity.
    /// <see href="https://ns.verisav.fr/dpp#batchLotNumber"></see></summary>
    let batchLotNumber = _prefix "batchLotNumber"
    /// <summary>
    /// Inverse property: links a WorkOrder or Intervention to its ProductPassport.
    /// <see href="https://ns.verisav.fr/dpp#belongsTo"></see></summary>
    let belongsTo = _prefix "belongsTo"
    /// <summary>
    /// Links a WorkOrder to an Intervention.
    /// <see href="https://ns.verisav.fr/dpp#hasIntervention"></see></summary>
    let hasIntervention = _prefix "hasIntervention"
    /// <summary>
    /// Links a ProductPassport to a WorkOrder.
    /// <see href="https://ns.verisav.fr/dpp#hasWorkOrder"></see></summary>
    let hasWorkOrder = _prefix "hasWorkOrder"
    /// <summary>
    /// Carbon footprint of the product in kg CO2eq per declared unit.
    /// <see href="https://ns.verisav.fr/dpp#carbonFootprint"></see></summary>
    let carbonFootprint = _prefix "carbonFootprint"
    /// <summary>
    /// A description of the service request or claim.
    /// <see href="https://ns.verisav.fr/dpp#claimDescription"></see></summary>
    let claimDescription = _prefix "claimDescription"
    /// <summary>
    /// The priority of the service request (normal, high, urgent).
    /// <see href="https://ns.verisav.fr/dpp#claimPriority"></see></summary>
    let claimPriority = _prefix "claimPriority"
    /// <summary>
    /// The status of a service request (soumise, en_cours, approuvee, resolue).
    /// <see href="https://ns.verisav.fr/dpp#claimStatus"></see></summary>
    let claimStatus = _prefix "claimStatus"
    /// <summary>
    /// Classification code according to the specified scheme.
    /// <see href="https://ns.verisav.fr/dpp#classificationCode"></see></summary>
    let classificationCode = _prefix "classificationCode"
    /// <summary>
    /// URI or identifier of the classification scheme (e.g., 'UN-CPC', 'GS1', 'NACE').
    /// <see href="https://ns.verisav.fr/dpp#classificationScheme"></see></summary>
    let classificationScheme = _prefix "classificationScheme"
    /// <summary>
    /// Indicates whether the product meets the specified criteria (true/false).
    /// <see href="https://ns.verisav.fr/dpp#conformance"></see></summary>
    let conformance = _prefix "conformance"
    /// <summary>
    /// Link to second or third party attestation, such as a UNTP Digital Conformity Credential, PDF, or other evidence format.
    /// <see href="https://ns.verisav.fr/dpp#conformityEvidence"></see></summary>
    let conformityEvidence = _prefix "conformityEvidence"
    /// <summary>
    /// Topic category of the claim (e.g., 'environment.emissions', 'social.working_conditions').
    /// <see href="https://ns.verisav.fr/dpp#conformityTopic"></see></summary>
    let conformityTopic = _prefix "conformityTopic"
    /// <summary>
    /// The authority or EconomicOperator that issued a VerifiableCredential via EU Business Wallet (EBW).
    /// <see href="https://ns.verisav.fr/dpp#credentialIssuer"></see></summary>
    let credentialIssuer = _prefix "credentialIssuer"
    /// <summary>
    /// Unique identifier for the criterion (typically a URI).
    /// <see href="https://ns.verisav.fr/dpp#criterionId"></see></summary>
    let criterionId = _prefix "criterionId"
    /// <summary>
    /// Name of the criterion.
    /// <see href="https://ns.verisav.fr/dpp#criterionName"></see></summary>
    let criterionName = _prefix "criterionName"
    /// <summary>
    /// Cryptographic hash digest ensuring the integrity of shared DPP data via EU Business Wallet (EBW). Used in SecureDataShare for tamper detection.
    /// <see href="https://ns.verisav.fr/dpp#dataIntegrityHash"></see></summary>
    let dataIntegrityHash = _prefix "dataIntegrityHash"
    /// <summary>
    /// Unit of measure for carbon footprint (e.g., 'KGM' for kg, 'C62' for unit).
    /// <see href="https://ns.verisav.fr/dpp#declaredUnit"></see></summary>
    let declaredUnit = _prefix "declaredUnit"
    /// <summary>
    /// Actual measured values, optionally including accuracy.
    /// <see href="https://ns.verisav.fr/dpp#declaredValue"></see></summary>
    let declaredValue = _prefix "declaredValue"
    /// <summary>
    /// A description of the diagnostic process and findings.
    /// <see href="https://ns.verisav.fr/dpp#diagnosticDescription"></see></summary>
    let diagnosticDescription = _prefix "diagnosticDescription"
    /// <summary>
    /// The result or conclusion of the diagnostic.
    /// <see href="https://ns.verisav.fr/dpp#diagnosticResult"></see></summary>
    let diagnosticResult = _prefix "diagnosticResult"
    /// <summary>
    /// Encryption method if applicable (e.g., 'AES', 'none').
    /// <see href="https://ns.verisav.fr/dpp#encryptionMethod"></see></summary>
    let encryptionMethod = _prefix "encryptionMethod"
    /// <summary>
    /// The European Unique Identifier (EUID) for a legal entity, issued via EU Business Wallet (EBW). Provides a unified digital identity across all 27 EU member states.
    /// <see href="https://ns.verisav.fr/dpp#euid"></see></summary>
    let euid = _prefix "euid"
    /// <summary>
    /// Links an Intervention to a previous Intervention (creates a chain of interventions).
    /// <see href="https://ns.verisav.fr/dpp#follows"></see></summary>
    let follows = _prefix "follows"
    /// <summary>
    /// The level of identification granularity: 'model' (GTIN only), 'batch' (GTIN + batch/lot number), or 'serial' (GTIN + serial number). Determined by EU delegated acts per product category.
    /// <see href="https://ns.verisav.fr/dpp#granularityLevel"></see></summary>
    let granularityLevel = _prefix "granularityLevel"
    /// <summary>
    /// The standard GS1 Digital Link URI for the product, resolving to the DPP. Uses uncompressed GS1 Digital Link URI syntax per GS1 standards.
    /// <see href="https://ns.verisav.fr/dpp#gs1DigitalLink"></see></summary>
    let gs1DigitalLink = _prefix "gs1DigitalLink"
    /// <summary>
    /// Links a ProductPassport to its circularity scorecard. Aligned with UNTP DPP.
    /// <see href="https://ns.verisav.fr/dpp#hasCircularityScorecard"></see></summary>
    let hasCircularityScorecard = _prefix "hasCircularityScorecard"
    /// <summary>
    /// Links a ProductPassport to a CompoundIdentifier (GTIN + variant/batch/serial).
    /// <see href="https://ns.verisav.fr/dpp#hasCompoundIdentifier"></see></summary>
    let hasCompoundIdentifier = _prefix "hasCompoundIdentifier"
    /// <summary>
    /// Links a ProductPassport to a conformity claim. Aligned with UNTP DPP.
    /// <see href="https://ns.verisav.fr/dpp#hasConformityClaim"></see></summary>
    let hasConformityClaim = _prefix "hasConformityClaim"
    /// <summary>
    /// Link to a DPP of a constituent product in the value chain. Enables multi-level traceability.
    /// <see href="https://ns.verisav.fr/dpp#hasConstituentProduct"></see></summary>
    let hasConstituentProduct = _prefix "hasConstituentProduct"
    /// <summary>
    /// Links a ProductPassport to its Consumer.
    /// <see href="https://ns.verisav.fr/dpp#hasConsumer"></see></summary>
    let hasConsumer = _prefix "hasConsumer"
    /// <summary>
    /// Links a ProductPassport to its current ProductStatus.
    /// <see href="https://ns.verisav.fr/dpp#hasCurrentStatus"></see></summary>
    let hasCurrentStatus = _prefix "hasCurrentStatus"
    /// <summary>
    /// Links an Intervention to a Diagnostic.
    /// <see href="https://ns.verisav.fr/dpp#hasDiagnostic"></see></summary>
    let hasDiagnostic = _prefix "hasDiagnostic"
    /// <summary>
    /// Links a ProductPassport to a Document.
    /// <see href="https://ns.verisav.fr/dpp#hasDocument"></see></summary>
    let hasDocument = _prefix "hasDocument"
    /// <summary>
    /// Links a ProductPassport to its EconomicOperator (manufacturer, importer, distributor, etc.).
    /// <see href="https://ns.verisav.fr/dpp#hasEconomicOperator"></see></summary>
    let hasEconomicOperator = _prefix "hasEconomicOperator"
    /// <summary>
    /// Links a ProductPassport to its emissions scorecard. Aligned with UNTP DPP.
    /// <see href="https://ns.verisav.fr/dpp#hasEmissionsScorecard"></see></summary>
    let hasEmissionsScorecard = _prefix "hasEmissionsScorecard"
    /// <summary>
    /// Links a ProductPassport to the Facility where it was produced.
    /// <see href="https://ns.verisav.fr/dpp#hasFacility"></see></summary>
    let hasFacility = _prefix "hasFacility"
    /// <summary>
    /// The GS1 Global Location Number identifying the organization or facility. Used for economic operators and facilities per EU ESPR regulation.
    /// <see href="https://ns.verisav.fr/dpp#hasGln"></see></summary>
    let hasGln = _prefix "hasGln"
    /// <summary>
    /// The GS1 Global Trade Item Number (GTIN) in one of the formats: GTIN-8, GTIN-12, GTIN-13, or GTIN-14. Used with AI (01) for Made-to-Stock products or AI (03) for Made-to-Order products.
    /// <see href="https://ns.verisav.fr/dpp#hasGtin"></see></summary>
    let hasGtin = _prefix "hasGtin"
    /// <summary>
    /// Links a ProductPassport to a ProductLifecycleStage.
    /// <see href="https://ns.verisav.fr/dpp#hasLifecycleStage"></see></summary>
    let hasLifecycleStage = _prefix "hasLifecycleStage"
    /// <summary>
    /// Links a ProductPassport to its Manufacturer.
    /// <see href="https://ns.verisav.fr/dpp#hasManufacturer"></see></summary>
    let hasManufacturer = _prefix "hasManufacturer"
    /// <summary>
    /// Links a ProductPassport to material provenance information. Aligned with UNTP DPP-03.
    /// <see href="https://ns.verisav.fr/dpp#hasMaterialProvenance"></see></summary>
    let hasMaterialProvenance = _prefix "hasMaterialProvenance"
    /// <summary>
    /// Links a ProductPassport to product classification. Aligned with UNTP DPP-02.
    /// <see href="https://ns.verisav.fr/dpp#hasProductClassification"></see></summary>
    let hasProductClassification = _prefix "hasProductClassification"
    /// <summary>
    /// Links a ProductPassport to RecyclingInstructions.
    /// <see href="https://ns.verisav.fr/dpp#hasRecyclingInstructions"></see></summary>
    let hasRecyclingInstructions = _prefix "hasRecyclingInstructions"
    /// <summary>
    /// Links an Intervention to its Repairer.
    /// <see href="https://ns.verisav.fr/dpp#hasRepairer"></see></summary>
    let hasRepairer = _prefix "hasRepairer"
    /// <summary>
    /// Links an Intervention to a ReplacementPart.
    /// <see href="https://ns.verisav.fr/dpp#hasReplacementPart"></see></summary>
    let hasReplacementPart = _prefix "hasReplacementPart"
    /// <summary>
    /// Links a ProductPassport to its Retailer.
    /// <see href="https://ns.verisav.fr/dpp#hasRetailer"></see></summary>
    let hasRetailer = _prefix "hasRetailer"
    /// <summary>
    /// Links a ProductPassport to a SecureDataShare action via EU Business Wallet (EBW).
    /// <see href="https://ns.verisav.fr/dpp#hasSecureDataShare"></see></summary>
    let hasSecureDataShare = _prefix "hasSecureDataShare"
    /// <summary>
    /// Links a ProductPassport to a ServiceRequest.
    /// <see href="https://ns.verisav.fr/dpp#hasServiceRequest"></see></summary>
    let hasServiceRequest = _prefix "hasServiceRequest"
    /// <summary>
    /// Links a ProductPassport or TraceabilityPerformance to a traceability event. Aligned with UNTP DPP-06.
    /// <see href="https://ns.verisav.fr/dpp#hasTraceabilityEvent"></see></summary>
    let hasTraceabilityEvent = _prefix "hasTraceabilityEvent"
    /// <summary>
    /// Links a ProductPassport to traceability information. Aligned with UNTP DPP-06.
    /// <see href="https://ns.verisav.fr/dpp#hasTraceabilityInformation"></see></summary>
    let hasTraceabilityInformation = _prefix "hasTraceabilityInformation"
    /// <summary>
    /// Links a VerifiableProductPassport or ConformityClaim to its W3C Verifiable Credential (VCDM 2.0) stored in EU Business Wallet (EBW).
    /// <see href="https://ns.verisav.fr/dpp#hasVerifiableCredential"></see></summary>
    let hasVerifiableCredential = _prefix "hasVerifiableCredential"
    /// <summary>
    /// Indicates whether the EconomicOperator's identity has been verified via EU Business Wallet (EBW).
    /// <see href="https://ns.verisav.fr/dpp#hasVerifiedIdentity"></see></summary>
    let hasVerifiedIdentity = _prefix "hasVerifiedIdentity"
    /// <summary>
    /// Links a ProductPassport to its Warranty.
    /// <see href="https://ns.verisav.fr/dpp#hasWarranty"></see></summary>
    let hasWarranty = _prefix "hasWarranty"
    /// <summary>
    /// Links a ProductPassport to a WarrantyClaim.
    /// <see href="https://ns.verisav.fr/dpp#hasWarrantyClaim"></see></summary>
    let hasWarrantyClaim = _prefix "hasWarrantyClaim"
    /// <summary>
    /// Hash digest for verification of link integrity.
    /// <see href="https://ns.verisav.fr/dpp#hashDigest"></see></summary>
    let hashDigest = _prefix "hashDigest"
    /// <summary>
    /// Method used for hashing (e.g., 'SHA-256', 'SHA-512').
    /// <see href="https://ns.verisav.fr/dpp#hashMethod"></see></summary>
    let hashMethod = _prefix "hashMethod"
    /// <summary>
    /// The duration of the intervention in minutes.
    /// <see href="https://ns.verisav.fr/dpp#interventionDuration"></see></summary>
    let interventionDuration = _prefix "interventionDuration"
    /// <summary>
    /// The end date and time of the intervention.
    /// <see href="https://ns.verisav.fr/dpp#interventionEndDate"></see></summary>
    let interventionEndDate = _prefix "interventionEndDate"
    /// <summary>
    /// The start date and time of the intervention.
    /// <see href="https://ns.verisav.fr/dpp#interventionStartDate"></see></summary>
    let interventionStartDate = _prefix "interventionStartDate"
    /// <summary>
    /// The type of intervention (diagnostic, reparation, maintenance, remplacement, retour_fabricant).
    /// <see href="https://ns.verisav.fr/dpp#interventionType"></see></summary>
    let interventionType = _prefix "interventionType"
    /// <summary>
    /// Date when the standard or regulation was issued.
    /// <see href="https://ns.verisav.fr/dpp#issueDate"></see></summary>
    let issueDate = _prefix "issueDate"
    /// <summary>
    /// Links a VerifiableProductPassport to the EconomicOperator that issued it via EU Business Wallet (EBW).
    /// <see href="https://ns.verisav.fr/dpp#issuedBy"></see></summary>
    let issuedBy = _prefix "issuedBy"
    /// <summary>
    /// Organization that issued the standard or regulation.
    /// <see href="https://ns.verisav.fr/dpp#issuingParty"></see></summary>
    let issuingParty = _prefix "issuingParty"
    /// <summary>
    /// The cost of labor for the intervention.
    /// <see href="https://ns.verisav.fr/dpp#laborCost"></see></summary>
    let laborCost = _prefix "laborCost"
    /// <summary>
    /// The date when the product entered this lifecycle stage.
    /// <see href="https://ns.verisav.fr/dpp#lifecycleStageDate"></see></summary>
    let lifecycleStageDate = _prefix "lifecycleStageDate"
    /// <summary>
    /// The name of the lifecycle stage (manufacturing, purchase, usage, end_of_life, recycling).
    /// <see href="https://ns.verisav.fr/dpp#lifecycleStageName"></see></summary>
    let lifecycleStageName = _prefix "lifecycleStageName"
    /// <summary>
    /// Human-readable name for the link.
    /// <see href="https://ns.verisav.fr/dpp#linkName"></see></summary>
    let linkName = _prefix "linkName"
    /// <summary>
    /// Type identifier for the link (e.g., URI to a vocabulary term).
    /// <see href="https://ns.verisav.fr/dpp#linkType"></see></summary>
    let linkType = _prefix "linkType"
    /// <summary>
    /// URL or link to a resource.
    /// <see href="https://ns.verisav.fr/dpp#linkURL"></see></summary>
    let linkURL = _prefix "linkURL"
    /// <summary>
    /// The date when the product was manufactured.
    /// <see href="https://ns.verisav.fr/dpp#manufacturingDate"></see></summary>
    let manufacturingDate = _prefix "manufacturingDate"
    /// <summary>
    /// The location where the product was manufactured.
    /// <see href="https://ns.verisav.fr/dpp#manufacturingLocation"></see></summary>
    let manufacturingLocation = _prefix "manufacturingLocation"
    /// <summary>
    /// Mass fraction of the material in the product (decimal value between 0 and 1).
    /// <see href="https://ns.verisav.fr/dpp#massFraction"></see></summary>
    let massFraction = _prefix "massFraction"
    /// <summary>
    /// Overall circularity score (MCI) calculated as 1 - (V + W) / (2 * D), where V = virgin material proportion, W = waste leakage proportion, D = utility factor (0-1).
    /// <see href="https://ns.verisav.fr/dpp#materialCircularityIndicator"></see></summary>
    let materialCircularityIndicator = _prefix "materialCircularityIndicator"
    /// <summary>
    /// Name of the material (e.g., 'Aluminum', 'Steel', 'Plastic').
    /// <see href="https://ns.verisav.fr/dpp#materialName"></see></summary>
    let materialName = _prefix "materialName"
    /// <summary>
    /// Name of the metric (e.g., 'GHG Emissions Intensity').
    /// <see href="https://ns.verisav.fr/dpp#metricName"></see></summary>
    let metricName = _prefix "metricName"
    /// <summary>
    /// Value of the metric with unit.
    /// <see href="https://ns.verisav.fr/dpp#metricValue"></see></summary>
    let metricValue = _prefix "metricValue"
    /// <summary>
    /// Scope of emissions calculation (e.g., 'CradleToGate', 'CradleToGrave', 'GateToGate').
    /// <see href="https://ns.verisav.fr/dpp#operationalScope"></see></summary>
    let operationalScope = _prefix "operationalScope"
    /// <summary>
    /// Origin country code of the material (ISO 3166-1 alpha-2 or alpha-3).
    /// <see href="https://ns.verisav.fr/dpp#originCountry"></see></summary>
    let originCountry = _prefix "originCountry"
    /// <summary>
    /// Specific region of origin for the material (optional).
    /// <see href="https://ns.verisav.fr/dpp#originRegion"></see></summary>
    let originRegion = _prefix "originRegion"
    /// <summary>
    /// The name of the replacement part.
    /// <see href="https://ns.verisav.fr/dpp#partName"></see></summary>
    let partName = _prefix "partName"
    /// <summary>
    /// The reference number of the replacement part.
    /// <see href="https://ns.verisav.fr/dpp#partReference"></see></summary>
    let partReference = _prefix "partReference"
    /// <summary>
    /// The cost of replacement parts for the intervention.
    /// <see href="https://ns.verisav.fr/dpp#partsCost"></see></summary>
    let partsCost = _prefix "partsCost"
    /// <summary>
    /// Ratio of materials from primary sources (0-1).
    /// <see href="https://ns.verisav.fr/dpp#primarySourcedRatio"></see></summary>
    let primarySourcedRatio = _prefix "primarySourcedRatio"
    /// <summary>
    /// The status of the product (sous_garantie, hors_garantie, contrat_maintenance, en_panne, repare).
    /// <see href="https://ns.verisav.fr/dpp#productStatus"></see></summary>
    let productStatus = _prefix "productStatus"
    /// <summary>
    /// The date when the product status was set.
    /// <see href="https://ns.verisav.fr/dpp#productStatusDate"></see></summary>
    let productStatusDate = _prefix "productStatusDate"
    /// <summary>
    /// The date when the product was purchased.
    /// <see href="https://ns.verisav.fr/dpp#purchaseDate"></see></summary>
    let purchaseDate = _prefix "purchaseDate"
    /// <summary>
    /// The price paid for the product.
    /// <see href="https://ns.verisav.fr/dpp#purchasePrice"></see></summary>
    let purchasePrice = _prefix "purchasePrice"
    /// <summary>
    /// Proportion of product mass designed to be recyclable or reusable (0-1).
    /// <see href="https://ns.verisav.fr/dpp#recyclableContent"></see></summary>
    let recyclableContent = _prefix "recyclableContent"
    /// <summary>
    /// Proportion of product mass made from recycled or repurposed materials (0-1).
    /// <see href="https://ns.verisav.fr/dpp#recycledContent"></see></summary>
    let recycledContent = _prefix "recycledContent"
    /// <summary>
    /// Reference regulation for the conformity claim.
    /// <see href="https://ns.verisav.fr/dpp#referenceRegulation"></see></summary>
    let referenceRegulation = _prefix "referenceRegulation"
    /// <summary>
    /// Reference standard for the conformity claim.
    /// <see href="https://ns.verisav.fr/dpp#referenceStandard"></see></summary>
    let referenceStandard = _prefix "referenceStandard"
    /// <summary>
    /// Link to repair instructions for end users or repair service centers.
    /// <see href="https://ns.verisav.fr/dpp#repairInformation"></see></summary>
    let repairInformation = _prefix "repairInformation"
    /// <summary>
    /// The status of a repair event (pending, in_progress, completed, failed).
    /// <see href="https://ns.verisav.fr/dpp#repairStatus"></see></summary>
    let repairStatus = _prefix "repairStatus"
    /// <summary>
    /// Links a ReplacementPart to the original part it replaces.
    /// <see href="https://ns.verisav.fr/dpp#replaces"></see></summary>
    let replaces = _prefix "replaces"
    /// <summary>
    /// Standard used for emissions reporting.
    /// <see href="https://ns.verisav.fr/dpp#reportingStandard"></see></summary>
    let reportingStandard = _prefix "reportingStandard"
    /// <summary>
    /// A description of how the issue was resolved.
    /// <see href="https://ns.verisav.fr/dpp#resolutionDescription"></see></summary>
    let resolutionDescription = _prefix "resolutionDescription"
    /// <summary>
    /// The serial number of the product.
    /// <see href="https://ns.verisav.fr/dpp#serialNumber"></see></summary>
    let serialNumber = _prefix "serialNumber"
    /// <summary>
    /// Links a SecureDataShare to the EconomicOperator with whom DPP data is shared via EU Business Wallet (EBW).
    /// <see href="https://ns.verisav.fr/dpp#sharedWith"></see></summary>
    let sharedWith = _prefix "sharedWith"
    /// <summary>
    /// Unique identifier for the standard (URI or string).
    /// <see href="https://ns.verisav.fr/dpp#standardId"></see></summary>
    let standardId = _prefix "standardId"
    /// <summary>
    /// Name of the standard.
    /// <see href="https://ns.verisav.fr/dpp#standardName"></see></summary>
    let standardName = _prefix "standardName"
    /// <summary>
    /// The total cost of the intervention (labor + parts).
    /// <see href="https://ns.verisav.fr/dpp#totalCost"></see></summary>
    let totalCost = _prefix "totalCost"
    /// <summary>
    /// Product durability relative to industry average (e.g., 1.2 = 20% more durable).
    /// <see href="https://ns.verisav.fr/dpp#utilityFactor"></see></summary>
    let utilityFactor = _prefix "utilityFactor"
    /// <summary>
    /// Human-readable description of the specific value chain step (e.g., 'Canning', 'Assembly').
    /// <see href="https://ns.verisav.fr/dpp#valueChainProcess"></see></summary>
    let valueChainProcess = _prefix "valueChainProcess"
    /// <summary>
    /// Proportion of materials or components in this step that have been verifiably traced using digital traceability events (0-1).
    /// <see href="https://ns.verisav.fr/dpp#verifiedRatio"></see></summary>
    let verifiedRatio = _prefix "verifiedRatio"
    /// <summary>
    /// The GTIN version number (GS1 AI 22) for product changes that do not require a GTIN change per GTIN Management Standard.
    /// <see href="https://ns.verisav.fr/dpp#versionNumber"></see></summary>
    let versionNumber = _prefix "versionNumber"
    /// <summary>
    /// The duration of the warranty in months.
    /// <see href="https://ns.verisav.fr/dpp#warrantyDurationMonths"></see></summary>
    let warrantyDurationMonths = _prefix "warrantyDurationMonths"
    /// <summary>
    /// The end date of the warranty.
    /// <see href="https://ns.verisav.fr/dpp#warrantyEndDate"></see></summary>
    let warrantyEndDate = _prefix "warrantyEndDate"
    /// <summary>
    /// The start date of the warranty.
    /// <see href="https://ns.verisav.fr/dpp#warrantyStartDate"></see></summary>
    let warrantyStartDate = _prefix "warrantyStartDate"
    /// <summary>
    /// The status of the warranty (active, expiree, suspendue, annulee).
    /// <see href="https://ns.verisav.fr/dpp#warrantyStatus"></see></summary>
    let warrantyStatus = _prefix "warrantyStatus"
    /// <summary>
    /// The type of warranty (constructeur, retailer, extension, maintenance).
    /// <see href="https://ns.verisav.fr/dpp#warrantyType"></see></summary>
    let warrantyType = _prefix "warrantyType"
    /// <summary>
    /// The unique identifier for the work order.
    /// <see href="https://ns.verisav.fr/dpp#workOrderNumber"></see></summary>
    let workOrderNumber = _prefix "workOrderNumber"
    /// <summary>
    /// The priority of the work order (basse, normale, haute, urgente).
    /// <see href="https://ns.verisav.fr/dpp#workOrderPriority"></see></summary>
    let workOrderPriority = _prefix "workOrderPriority"
    /// <summary>
    /// The status of the work order (cree, assigne, en_cours, en_attente_pieces, complete, facture, annule).
    /// <see href="https://ns.verisav.fr/dpp#workOrderStatus"></see></summary>
    let workOrderStatus = _prefix "workOrderStatus"
