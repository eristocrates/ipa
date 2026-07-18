namespace https.ns.verisav.fr.dpp.hash

open DoxAletheia.Rdf_Vocabulary

module submit =
    let _namespace_name = "https://ns.verisav.fr/dpp#"

    /// <summary>
    /// Product circularity scorecard. Aligned with UNTP DPP.
    /// <see href="https://ns.verisav.fr/dpp#CircularityPerformance"></see></summary>
    let CircularityPerformance =
        Namespaced_IRI.parse _namespace_name "CircularityPerformance" |> NamespacedName

    /// <summary>
    /// A complex identifier combining a GTIN with a variant, batch, or serial number (Made-to-Order products).
    /// <see href="https://ns.verisav.fr/dpp#CompoundIdentifier"></see></summary>
    let CompoundIdentifier =
        Namespaced_IRI.parse _namespace_name "CompoundIdentifier" |> NamespacedName

    /// <summary>
    /// Claim of conformity to a standard or regulation. Aligned with UNTP DPP.
    /// <see href="https://ns.verisav.fr/dpp#ConformityClaim"></see></summary>
    let ConformityClaim =
        Namespaced_IRI.parse _namespace_name "ConformityClaim" |> NamespacedName

    /// <summary>
    /// A consumer who owns or uses a product.
    /// <see href="https://ns.verisav.fr/dpp#Consumer"></see></summary>
    let Consumer = Namespaced_IRI.parse _namespace_name "Consumer" |> NamespacedName
    /// <summary>
    /// A criterion or rule within a standard or regulation against which a claim is evaluated.
    /// <see href="https://ns.verisav.fr/dpp#Criterion"></see></summary>
    let Criterion = Namespaced_IRI.parse _namespace_name "Criterion" |> NamespacedName
    /// <summary>
    /// A diagnostic assessment performed on a product to identify issues.
    /// <see href="https://ns.verisav.fr/dpp#Diagnostic"></see></summary>
    let Diagnostic = Namespaced_IRI.parse _namespace_name "Diagnostic" |> NamespacedName
    /// <summary>
    /// A document associated with a product (manuals, invoices, certificates, etc.).
    /// <see href="https://ns.verisav.fr/dpp#Document"></see></summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName

    /// <summary>
    /// An economic operator in the value chain (manufacturer, importer, distributor, dealer, repairer) as per EU ESPR regulation. Can be authenticated via EU Business Wallet (EBW) with EUID (European Unique Identifier).
    /// <see href="https://ns.verisav.fr/dpp#EconomicOperator"></see></summary>
    let EconomicOperator =
        Namespaced_IRI.parse _namespace_name "EconomicOperator" |> NamespacedName

    /// <summary>
    /// Greenhouse gas emissions scorecard for a product. Aligned with UNTP DPP.
    /// <see href="https://ns.verisav.fr/dpp#EmissionsPerformance"></see></summary>
    let EmissionsPerformance =
        Namespaced_IRI.parse _namespace_name "EmissionsPerformance" |> NamespacedName

    /// <summary>
    /// A location or building involved in the value chain of a product (manufacturing facility, warehouse, etc.) as per EU ESPR regulation. Aligned with UNTP DPP-04.
    /// <see href="https://ns.verisav.fr/dpp#Facility"></see></summary>
    let Facility = Namespaced_IRI.parse _namespace_name "Facility" |> NamespacedName

    /// <summary>
    /// A technical intervention on a product (diagnostic, repair, maintenance, replacement, return to manufacturer).
    /// <see href="https://ns.verisav.fr/dpp#Intervention"></see></summary>
    let Intervention =
        Namespaced_IRI.parse _namespace_name "Intervention" |> NamespacedName

    /// <summary>
    /// A specific repair or maintenance intervention performed on a product.
    /// <see href="https://ns.verisav.fr/dpp#RepairEvent"></see></summary>
    let RepairEvent =
        Namespaced_IRI.parse _namespace_name "RepairEvent" |> NamespacedName

    /// <summary>
    /// The manufacturer of a product.
    /// <see href="https://ns.verisav.fr/dpp#Manufacturer"></see></summary>
    let Manufacturer =
        Namespaced_IRI.parse _namespace_name "Manufacturer" |> NamespacedName

    /// <summary>
    /// Information about material provenance: name, mass fraction, origin country. Aligned with UNTP DPP-03.
    /// <see href="https://ns.verisav.fr/dpp#MaterialProvenance"></see></summary>
    let MaterialProvenance =
        Namespaced_IRI.parse _namespace_name "MaterialProvenance" |> NamespacedName

    /// <summary>
    /// A metric defining actual measured values, optionally including accuracy.
    /// <see href="https://ns.verisav.fr/dpp#Metric"></see></summary>
    let Metric = Namespaced_IRI.parse _namespace_name "Metric" |> NamespacedName

    /// <summary>
    /// Product classification according to a standardized scheme (UN-CPC, GS1, NACE, etc.). Aligned with UNTP DPP-02.
    /// <see href="https://ns.verisav.fr/dpp#ProductClassification"></see></summary>
    let ProductClassification =
        Namespaced_IRI.parse _namespace_name "ProductClassification" |> NamespacedName

    /// <summary>
    /// A stage in the product lifecycle (manufacturing, purchase, usage, end of life, recycling).
    /// <see href="https://ns.verisav.fr/dpp#ProductLifecycleStage"></see></summary>
    let ProductLifecycleStage =
        Namespaced_IRI.parse _namespace_name "ProductLifecycleStage" |> NamespacedName

    /// <summary>
    /// A Digital Product Passport that tracks a product throughout its entire lifecycle.
    /// <see href="https://ns.verisav.fr/dpp#ProductPassport"></see></summary>
    let ProductPassport =
        Namespaced_IRI.parse _namespace_name "ProductPassport" |> NamespacedName

    /// <summary>
    /// The current status of a product (under warranty, out of warranty, broken, repaired, etc.).
    /// <see href="https://ns.verisav.fr/dpp#ProductStatus"></see></summary>
    let ProductStatus =
        Namespaced_IRI.parse _namespace_name "ProductStatus" |> NamespacedName

    /// <summary>
    /// Instructions for recycling or disposing of a product at end of life.
    /// <see href="https://ns.verisav.fr/dpp#RecyclingInstructions"></see></summary>
    let RecyclingInstructions =
        Namespaced_IRI.parse _namespace_name "RecyclingInstructions" |> NamespacedName

    /// <summary>
    /// Reference regulation for a conformity claim.
    /// <see href="https://ns.verisav.fr/dpp#Regulation"></see></summary>
    let Regulation = Namespaced_IRI.parse _namespace_name "Regulation" |> NamespacedName
    /// <summary>
    /// A person or organization that repairs products.
    /// <see href="https://ns.verisav.fr/dpp#Repairer"></see></summary>
    let Repairer = Namespaced_IRI.parse _namespace_name "Repairer" |> NamespacedName

    /// <summary>
    /// A part used to replace a component in a product during repair or maintenance.
    /// <see href="https://ns.verisav.fr/dpp#ReplacementPart"></see></summary>
    let ReplacementPart =
        Namespaced_IRI.parse _namespace_name "ReplacementPart" |> NamespacedName

    /// <summary>
    /// A retailer or distributor who sells products.
    /// <see href="https://ns.verisav.fr/dpp#Retailer"></see></summary>
    let Retailer = Namespaced_IRI.parse _namespace_name "Retailer" |> NamespacedName

    /// <summary>
    /// A secure sharing of DPP data between economic operators via EU Business Wallet (EBW). Includes cryptographic integrity verification and timestamping.
    /// <see href="https://ns.verisav.fr/dpp#SecureDataShare"></see></summary>
    let SecureDataShare =
        Namespaced_IRI.parse _namespace_name "SecureDataShare" |> NamespacedName

    /// <summary>
    /// A secure link with hash digest and encryption method for verification.
    /// <see href="https://ns.verisav.fr/dpp#SecureLink"></see></summary>
    let SecureLink = Namespaced_IRI.parse _namespace_name "SecureLink" |> NamespacedName

    /// <summary>
    /// A request for after-sales service (SAV) for a product.
    /// <see href="https://ns.verisav.fr/dpp#ServiceRequest"></see></summary>
    let ServiceRequest =
        Namespaced_IRI.parse _namespace_name "ServiceRequest" |> NamespacedName

    /// <summary>
    /// Standard, norm, or reference scheme for a conformity claim.
    /// <see href="https://ns.verisav.fr/dpp#Standard"></see></summary>
    let Standard = Namespaced_IRI.parse _namespace_name "Standard" |> NamespacedName

    /// <summary>
    /// Traceability event based on ISO/IEC 19987 (EPCIS) or similar standards. Aligned with UNTP DPP-06.
    /// <see href="https://ns.verisav.fr/dpp#TraceabilityEvent"></see></summary>
    let TraceabilityEvent =
        Namespaced_IRI.parse _namespace_name "TraceabilityEvent" |> NamespacedName

    /// <summary>
    /// Traceability information for a specific value chain process. Aligned with UNTP DPP.
    /// <see href="https://ns.verisav.fr/dpp#TraceabilityPerformance"></see></summary>
    let TraceabilityPerformance =
        Namespaced_IRI.parse _namespace_name "TraceabilityPerformance" |> NamespacedName

    /// <summary>
    /// A W3C Verifiable Credential (VCDM 2.0) that can be used to verify claims about a product passport or economic operator. Stored and managed via EU Business Wallet (EBW).
    /// <see href="https://ns.verisav.fr/dpp#VerifiableCredential"></see></summary>
    let VerifiableCredential =
        Namespaced_IRI.parse _namespace_name "VerifiableCredential" |> NamespacedName

    /// <summary>
    /// A Digital Product Passport issued as a W3C Verifiable Credential (VCDM 2.0) via EU Business Wallet (EBW). Provides cryptographic proof of authenticity and integrity.
    /// <see href="https://ns.verisav.fr/dpp#VerifiableProductPassport"></see></summary>
    let VerifiableProductPassport =
        Namespaced_IRI.parse _namespace_name "VerifiableProductPassport" |> NamespacedName

    /// <summary>
    /// A warranty covering a product, which can be of different types (manufacturer, retailer, extension, maintenance).
    /// <see href="https://ns.verisav.fr/dpp#Warranty"></see></summary>
    let Warranty = Namespaced_IRI.parse _namespace_name "Warranty" |> NamespacedName

    /// <summary>
    /// A claim made under a warranty.
    /// <see href="https://ns.verisav.fr/dpp#WarrantyClaim"></see></summary>
    let WarrantyClaim =
        Namespaced_IRI.parse _namespace_name "WarrantyClaim" |> NamespacedName

    /// <summary>
    /// An order for work to be performed on a product (repair, maintenance, etc.).
    /// <see href="https://ns.verisav.fr/dpp#WorkOrder"></see></summary>
    let WorkOrder = Namespaced_IRI.parse _namespace_name "WorkOrder" |> NamespacedName
    /// <summary>
    /// Accuracy or uncertainty of the metric value (optional).
    /// <see href="https://ns.verisav.fr/dpp#accuracy"></see></summary>
    let accuracy = Namespaced_IRI.parse _namespace_name "accuracy" |> NamespacedName

    /// <summary>
    /// Criteria within the standard or regulation against which the claim is evaluated.
    /// <see href="https://ns.verisav.fr/dpp#assessmentCriteria"></see></summary>
    let assessmentCriteria =
        Namespaced_IRI.parse _namespace_name "assessmentCriteria" |> NamespacedName

    /// <summary>
    /// Date when the claim was assessed.
    /// <see href="https://ns.verisav.fr/dpp#assessmentDate"></see></summary>
    let assessmentDate =
        Namespaced_IRI.parse _namespace_name "assessmentDate" |> NamespacedName

    /// <summary>
    /// The batch or lot number (GS1 AI 10) for production batches. Used with GTIN for batch-level granularity.
    /// <see href="https://ns.verisav.fr/dpp#batchLotNumber"></see></summary>
    let batchLotNumber =
        Namespaced_IRI.parse _namespace_name "batchLotNumber" |> NamespacedName

    /// <summary>
    /// Inverse property: links a WorkOrder or Intervention to its ProductPassport.
    /// <see href="https://ns.verisav.fr/dpp#belongsTo"></see></summary>
    let belongsTo = Namespaced_IRI.parse _namespace_name "belongsTo" |> NamespacedName

    /// <summary>
    /// Links a WorkOrder to an Intervention.
    /// <see href="https://ns.verisav.fr/dpp#hasIntervention"></see></summary>
    let hasIntervention =
        Namespaced_IRI.parse _namespace_name "hasIntervention" |> NamespacedName

    /// <summary>
    /// Links a ProductPassport to a WorkOrder.
    /// <see href="https://ns.verisav.fr/dpp#hasWorkOrder"></see></summary>
    let hasWorkOrder =
        Namespaced_IRI.parse _namespace_name "hasWorkOrder" |> NamespacedName

    /// <summary>
    /// Carbon footprint of the product in kg CO2eq per declared unit.
    /// <see href="https://ns.verisav.fr/dpp#carbonFootprint"></see></summary>
    let carbonFootprint =
        Namespaced_IRI.parse _namespace_name "carbonFootprint" |> NamespacedName

    /// <summary>
    /// A description of the service request or claim.
    /// <see href="https://ns.verisav.fr/dpp#claimDescription"></see></summary>
    let claimDescription =
        Namespaced_IRI.parse _namespace_name "claimDescription" |> NamespacedName

    /// <summary>
    /// The priority of the service request (normal, high, urgent).
    /// <see href="https://ns.verisav.fr/dpp#claimPriority"></see></summary>
    let claimPriority =
        Namespaced_IRI.parse _namespace_name "claimPriority" |> NamespacedName

    /// <summary>
    /// The status of a service request (soumise, en_cours, approuvee, resolue).
    /// <see href="https://ns.verisav.fr/dpp#claimStatus"></see></summary>
    let claimStatus =
        Namespaced_IRI.parse _namespace_name "claimStatus" |> NamespacedName

    /// <summary>
    /// Classification code according to the specified scheme.
    /// <see href="https://ns.verisav.fr/dpp#classificationCode"></see></summary>
    let classificationCode =
        Namespaced_IRI.parse _namespace_name "classificationCode" |> NamespacedName

    /// <summary>
    /// URI or identifier of the classification scheme (e.g., 'UN-CPC', 'GS1', 'NACE').
    /// <see href="https://ns.verisav.fr/dpp#classificationScheme"></see></summary>
    let classificationScheme =
        Namespaced_IRI.parse _namespace_name "classificationScheme" |> NamespacedName

    /// <summary>
    /// Indicates whether the product meets the specified criteria (true/false).
    /// <see href="https://ns.verisav.fr/dpp#conformance"></see></summary>
    let conformance =
        Namespaced_IRI.parse _namespace_name "conformance" |> NamespacedName

    /// <summary>
    /// Link to second or third party attestation, such as a UNTP Digital Conformity Credential, PDF, or other evidence format.
    /// <see href="https://ns.verisav.fr/dpp#conformityEvidence"></see></summary>
    let conformityEvidence =
        Namespaced_IRI.parse _namespace_name "conformityEvidence" |> NamespacedName

    /// <summary>
    /// Topic category of the claim (e.g., 'environment.emissions', 'social.working_conditions').
    /// <see href="https://ns.verisav.fr/dpp#conformityTopic"></see></summary>
    let conformityTopic =
        Namespaced_IRI.parse _namespace_name "conformityTopic" |> NamespacedName

    /// <summary>
    /// The authority or EconomicOperator that issued a VerifiableCredential via EU Business Wallet (EBW).
    /// <see href="https://ns.verisav.fr/dpp#credentialIssuer"></see></summary>
    let credentialIssuer =
        Namespaced_IRI.parse _namespace_name "credentialIssuer" |> NamespacedName

    /// <summary>
    /// Unique identifier for the criterion (typically a URI).
    /// <see href="https://ns.verisav.fr/dpp#criterionId"></see></summary>
    let criterionId =
        Namespaced_IRI.parse _namespace_name "criterionId" |> NamespacedName

    /// <summary>
    /// Name of the criterion.
    /// <see href="https://ns.verisav.fr/dpp#criterionName"></see></summary>
    let criterionName =
        Namespaced_IRI.parse _namespace_name "criterionName" |> NamespacedName

    /// <summary>
    /// Cryptographic hash digest ensuring the integrity of shared DPP data via EU Business Wallet (EBW). Used in SecureDataShare for tamper detection.
    /// <see href="https://ns.verisav.fr/dpp#dataIntegrityHash"></see></summary>
    let dataIntegrityHash =
        Namespaced_IRI.parse _namespace_name "dataIntegrityHash" |> NamespacedName

    /// <summary>
    /// Unit of measure for carbon footprint (e.g., 'KGM' for kg, 'C62' for unit).
    /// <see href="https://ns.verisav.fr/dpp#declaredUnit"></see></summary>
    let declaredUnit =
        Namespaced_IRI.parse _namespace_name "declaredUnit" |> NamespacedName

    /// <summary>
    /// Actual measured values, optionally including accuracy.
    /// <see href="https://ns.verisav.fr/dpp#declaredValue"></see></summary>
    let declaredValue =
        Namespaced_IRI.parse _namespace_name "declaredValue" |> NamespacedName

    /// <summary>
    /// A description of the diagnostic process and findings.
    /// <see href="https://ns.verisav.fr/dpp#diagnosticDescription"></see></summary>
    let diagnosticDescription =
        Namespaced_IRI.parse _namespace_name "diagnosticDescription" |> NamespacedName

    /// <summary>
    /// The result or conclusion of the diagnostic.
    /// <see href="https://ns.verisav.fr/dpp#diagnosticResult"></see></summary>
    let diagnosticResult =
        Namespaced_IRI.parse _namespace_name "diagnosticResult" |> NamespacedName

    /// <summary>
    /// Encryption method if applicable (e.g., 'AES', 'none').
    /// <see href="https://ns.verisav.fr/dpp#encryptionMethod"></see></summary>
    let encryptionMethod =
        Namespaced_IRI.parse _namespace_name "encryptionMethod" |> NamespacedName

    /// <summary>
    /// The European Unique Identifier (EUID) for a legal entity, issued via EU Business Wallet (EBW). Provides a unified digital identity across all 27 EU member states.
    /// <see href="https://ns.verisav.fr/dpp#euid"></see></summary>
    let euid = Namespaced_IRI.parse _namespace_name "euid" |> NamespacedName
    /// <summary>
    /// Links an Intervention to a previous Intervention (creates a chain of interventions).
    /// <see href="https://ns.verisav.fr/dpp#follows"></see></summary>
    let follows = Namespaced_IRI.parse _namespace_name "follows" |> NamespacedName

    /// <summary>
    /// The level of identification granularity: 'model' (GTIN only), 'batch' (GTIN + batch/lot number), or 'serial' (GTIN + serial number). Determined by EU delegated acts per product category.
    /// <see href="https://ns.verisav.fr/dpp#granularityLevel"></see></summary>
    let granularityLevel =
        Namespaced_IRI.parse _namespace_name "granularityLevel" |> NamespacedName

    /// <summary>
    /// The standard GS1 Digital Link URI for the product, resolving to the DPP. Uses uncompressed GS1 Digital Link URI syntax per GS1 standards.
    /// <see href="https://ns.verisav.fr/dpp#gs1DigitalLink"></see></summary>
    let gs1DigitalLink =
        Namespaced_IRI.parse _namespace_name "gs1DigitalLink" |> NamespacedName

    /// <summary>
    /// Links a ProductPassport to its circularity scorecard. Aligned with UNTP DPP.
    /// <see href="https://ns.verisav.fr/dpp#hasCircularityScorecard"></see></summary>
    let hasCircularityScorecard =
        Namespaced_IRI.parse _namespace_name "hasCircularityScorecard" |> NamespacedName

    /// <summary>
    /// Links a ProductPassport to a CompoundIdentifier (GTIN + variant/batch/serial).
    /// <see href="https://ns.verisav.fr/dpp#hasCompoundIdentifier"></see></summary>
    let hasCompoundIdentifier =
        Namespaced_IRI.parse _namespace_name "hasCompoundIdentifier" |> NamespacedName

    /// <summary>
    /// Links a ProductPassport to a conformity claim. Aligned with UNTP DPP.
    /// <see href="https://ns.verisav.fr/dpp#hasConformityClaim"></see></summary>
    let hasConformityClaim =
        Namespaced_IRI.parse _namespace_name "hasConformityClaim" |> NamespacedName

    /// <summary>
    /// Link to a DPP of a constituent product in the value chain. Enables multi-level traceability.
    /// <see href="https://ns.verisav.fr/dpp#hasConstituentProduct"></see></summary>
    let hasConstituentProduct =
        Namespaced_IRI.parse _namespace_name "hasConstituentProduct" |> NamespacedName

    /// <summary>
    /// Links a ProductPassport to its Consumer.
    /// <see href="https://ns.verisav.fr/dpp#hasConsumer"></see></summary>
    let hasConsumer =
        Namespaced_IRI.parse _namespace_name "hasConsumer" |> NamespacedName

    /// <summary>
    /// Links a ProductPassport to its current ProductStatus.
    /// <see href="https://ns.verisav.fr/dpp#hasCurrentStatus"></see></summary>
    let hasCurrentStatus =
        Namespaced_IRI.parse _namespace_name "hasCurrentStatus" |> NamespacedName

    /// <summary>
    /// Links an Intervention to a Diagnostic.
    /// <see href="https://ns.verisav.fr/dpp#hasDiagnostic"></see></summary>
    let hasDiagnostic =
        Namespaced_IRI.parse _namespace_name "hasDiagnostic" |> NamespacedName

    /// <summary>
    /// Links a ProductPassport to a Document.
    /// <see href="https://ns.verisav.fr/dpp#hasDocument"></see></summary>
    let hasDocument =
        Namespaced_IRI.parse _namespace_name "hasDocument" |> NamespacedName

    /// <summary>
    /// Links a ProductPassport to its EconomicOperator (manufacturer, importer, distributor, etc.).
    /// <see href="https://ns.verisav.fr/dpp#hasEconomicOperator"></see></summary>
    let hasEconomicOperator =
        Namespaced_IRI.parse _namespace_name "hasEconomicOperator" |> NamespacedName

    /// <summary>
    /// Links a ProductPassport to its emissions scorecard. Aligned with UNTP DPP.
    /// <see href="https://ns.verisav.fr/dpp#hasEmissionsScorecard"></see></summary>
    let hasEmissionsScorecard =
        Namespaced_IRI.parse _namespace_name "hasEmissionsScorecard" |> NamespacedName

    /// <summary>
    /// Links a ProductPassport to the Facility where it was produced.
    /// <see href="https://ns.verisav.fr/dpp#hasFacility"></see></summary>
    let hasFacility =
        Namespaced_IRI.parse _namespace_name "hasFacility" |> NamespacedName

    /// <summary>
    /// The GS1 Global Location Number identifying the organization or facility. Used for economic operators and facilities per EU ESPR regulation.
    /// <see href="https://ns.verisav.fr/dpp#hasGln"></see></summary>
    let hasGln = Namespaced_IRI.parse _namespace_name "hasGln" |> NamespacedName
    /// <summary>
    /// The GS1 Global Trade Item Number (GTIN) in one of the formats: GTIN-8, GTIN-12, GTIN-13, or GTIN-14. Used with AI (01) for Made-to-Stock products or AI (03) for Made-to-Order products.
    /// <see href="https://ns.verisav.fr/dpp#hasGtin"></see></summary>
    let hasGtin = Namespaced_IRI.parse _namespace_name "hasGtin" |> NamespacedName

    /// <summary>
    /// Links a ProductPassport to a ProductLifecycleStage.
    /// <see href="https://ns.verisav.fr/dpp#hasLifecycleStage"></see></summary>
    let hasLifecycleStage =
        Namespaced_IRI.parse _namespace_name "hasLifecycleStage" |> NamespacedName

    /// <summary>
    /// Links a ProductPassport to its Manufacturer.
    /// <see href="https://ns.verisav.fr/dpp#hasManufacturer"></see></summary>
    let hasManufacturer =
        Namespaced_IRI.parse _namespace_name "hasManufacturer" |> NamespacedName

    /// <summary>
    /// Links a ProductPassport to material provenance information. Aligned with UNTP DPP-03.
    /// <see href="https://ns.verisav.fr/dpp#hasMaterialProvenance"></see></summary>
    let hasMaterialProvenance =
        Namespaced_IRI.parse _namespace_name "hasMaterialProvenance" |> NamespacedName

    /// <summary>
    /// Links a ProductPassport to product classification. Aligned with UNTP DPP-02.
    /// <see href="https://ns.verisav.fr/dpp#hasProductClassification"></see></summary>
    let hasProductClassification =
        Namespaced_IRI.parse _namespace_name "hasProductClassification" |> NamespacedName

    /// <summary>
    /// Links a ProductPassport to RecyclingInstructions.
    /// <see href="https://ns.verisav.fr/dpp#hasRecyclingInstructions"></see></summary>
    let hasRecyclingInstructions =
        Namespaced_IRI.parse _namespace_name "hasRecyclingInstructions" |> NamespacedName

    /// <summary>
    /// Links an Intervention to its Repairer.
    /// <see href="https://ns.verisav.fr/dpp#hasRepairer"></see></summary>
    let hasRepairer =
        Namespaced_IRI.parse _namespace_name "hasRepairer" |> NamespacedName

    /// <summary>
    /// Links an Intervention to a ReplacementPart.
    /// <see href="https://ns.verisav.fr/dpp#hasReplacementPart"></see></summary>
    let hasReplacementPart =
        Namespaced_IRI.parse _namespace_name "hasReplacementPart" |> NamespacedName

    /// <summary>
    /// Links a ProductPassport to its Retailer.
    /// <see href="https://ns.verisav.fr/dpp#hasRetailer"></see></summary>
    let hasRetailer =
        Namespaced_IRI.parse _namespace_name "hasRetailer" |> NamespacedName

    /// <summary>
    /// Links a ProductPassport to a SecureDataShare action via EU Business Wallet (EBW).
    /// <see href="https://ns.verisav.fr/dpp#hasSecureDataShare"></see></summary>
    let hasSecureDataShare =
        Namespaced_IRI.parse _namespace_name "hasSecureDataShare" |> NamespacedName

    /// <summary>
    /// Links a ProductPassport to a ServiceRequest.
    /// <see href="https://ns.verisav.fr/dpp#hasServiceRequest"></see></summary>
    let hasServiceRequest =
        Namespaced_IRI.parse _namespace_name "hasServiceRequest" |> NamespacedName

    /// <summary>
    /// Links a ProductPassport or TraceabilityPerformance to a traceability event. Aligned with UNTP DPP-06.
    /// <see href="https://ns.verisav.fr/dpp#hasTraceabilityEvent"></see></summary>
    let hasTraceabilityEvent =
        Namespaced_IRI.parse _namespace_name "hasTraceabilityEvent" |> NamespacedName

    /// <summary>
    /// Links a ProductPassport to traceability information. Aligned with UNTP DPP-06.
    /// <see href="https://ns.verisav.fr/dpp#hasTraceabilityInformation"></see></summary>
    let hasTraceabilityInformation =
        Namespaced_IRI.parse _namespace_name "hasTraceabilityInformation" |> NamespacedName

    /// <summary>
    /// Links a VerifiableProductPassport or ConformityClaim to its W3C Verifiable Credential (VCDM 2.0) stored in EU Business Wallet (EBW).
    /// <see href="https://ns.verisav.fr/dpp#hasVerifiableCredential"></see></summary>
    let hasVerifiableCredential =
        Namespaced_IRI.parse _namespace_name "hasVerifiableCredential" |> NamespacedName

    /// <summary>
    /// Indicates whether the EconomicOperator's identity has been verified via EU Business Wallet (EBW).
    /// <see href="https://ns.verisav.fr/dpp#hasVerifiedIdentity"></see></summary>
    let hasVerifiedIdentity =
        Namespaced_IRI.parse _namespace_name "hasVerifiedIdentity" |> NamespacedName

    /// <summary>
    /// Links a ProductPassport to its Warranty.
    /// <see href="https://ns.verisav.fr/dpp#hasWarranty"></see></summary>
    let hasWarranty =
        Namespaced_IRI.parse _namespace_name "hasWarranty" |> NamespacedName

    /// <summary>
    /// Links a ProductPassport to a WarrantyClaim.
    /// <see href="https://ns.verisav.fr/dpp#hasWarrantyClaim"></see></summary>
    let hasWarrantyClaim =
        Namespaced_IRI.parse _namespace_name "hasWarrantyClaim" |> NamespacedName

    /// <summary>
    /// Hash digest for verification of link integrity.
    /// <see href="https://ns.verisav.fr/dpp#hashDigest"></see></summary>
    let hashDigest = Namespaced_IRI.parse _namespace_name "hashDigest" |> NamespacedName
    /// <summary>
    /// Method used for hashing (e.g., 'SHA-256', 'SHA-512').
    /// <see href="https://ns.verisav.fr/dpp#hashMethod"></see></summary>
    let hashMethod = Namespaced_IRI.parse _namespace_name "hashMethod" |> NamespacedName

    /// <summary>
    /// The duration of the intervention in minutes.
    /// <see href="https://ns.verisav.fr/dpp#interventionDuration"></see></summary>
    let interventionDuration =
        Namespaced_IRI.parse _namespace_name "interventionDuration" |> NamespacedName

    /// <summary>
    /// The end date and time of the intervention.
    /// <see href="https://ns.verisav.fr/dpp#interventionEndDate"></see></summary>
    let interventionEndDate =
        Namespaced_IRI.parse _namespace_name "interventionEndDate" |> NamespacedName

    /// <summary>
    /// The start date and time of the intervention.
    /// <see href="https://ns.verisav.fr/dpp#interventionStartDate"></see></summary>
    let interventionStartDate =
        Namespaced_IRI.parse _namespace_name "interventionStartDate" |> NamespacedName

    /// <summary>
    /// The type of intervention (diagnostic, reparation, maintenance, remplacement, retour_fabricant).
    /// <see href="https://ns.verisav.fr/dpp#interventionType"></see></summary>
    let interventionType =
        Namespaced_IRI.parse _namespace_name "interventionType" |> NamespacedName

    /// <summary>
    /// Date when the standard or regulation was issued.
    /// <see href="https://ns.verisav.fr/dpp#issueDate"></see></summary>
    let issueDate = Namespaced_IRI.parse _namespace_name "issueDate" |> NamespacedName
    /// <summary>
    /// Links a VerifiableProductPassport to the EconomicOperator that issued it via EU Business Wallet (EBW).
    /// <see href="https://ns.verisav.fr/dpp#issuedBy"></see></summary>
    let issuedBy = Namespaced_IRI.parse _namespace_name "issuedBy" |> NamespacedName

    /// <summary>
    /// Organization that issued the standard or regulation.
    /// <see href="https://ns.verisav.fr/dpp#issuingParty"></see></summary>
    let issuingParty =
        Namespaced_IRI.parse _namespace_name "issuingParty" |> NamespacedName

    /// <summary>
    /// The cost of labor for the intervention.
    /// <see href="https://ns.verisav.fr/dpp#laborCost"></see></summary>
    let laborCost = Namespaced_IRI.parse _namespace_name "laborCost" |> NamespacedName

    /// <summary>
    /// The date when the product entered this lifecycle stage.
    /// <see href="https://ns.verisav.fr/dpp#lifecycleStageDate"></see></summary>
    let lifecycleStageDate =
        Namespaced_IRI.parse _namespace_name "lifecycleStageDate" |> NamespacedName

    /// <summary>
    /// The name of the lifecycle stage (manufacturing, purchase, usage, end_of_life, recycling).
    /// <see href="https://ns.verisav.fr/dpp#lifecycleStageName"></see></summary>
    let lifecycleStageName =
        Namespaced_IRI.parse _namespace_name "lifecycleStageName" |> NamespacedName

    /// <summary>
    /// Human-readable name for the link.
    /// <see href="https://ns.verisav.fr/dpp#linkName"></see></summary>
    let linkName = Namespaced_IRI.parse _namespace_name "linkName" |> NamespacedName
    /// <summary>
    /// Type identifier for the link (e.g., URI to a vocabulary term).
    /// <see href="https://ns.verisav.fr/dpp#linkType"></see></summary>
    let linkType = Namespaced_IRI.parse _namespace_name "linkType" |> NamespacedName
    /// <summary>
    /// URL or link to a resource.
    /// <see href="https://ns.verisav.fr/dpp#linkURL"></see></summary>
    let linkURL = Namespaced_IRI.parse _namespace_name "linkURL" |> NamespacedName

    /// <summary>
    /// The date when the product was manufactured.
    /// <see href="https://ns.verisav.fr/dpp#manufacturingDate"></see></summary>
    let manufacturingDate =
        Namespaced_IRI.parse _namespace_name "manufacturingDate" |> NamespacedName

    /// <summary>
    /// The location where the product was manufactured.
    /// <see href="https://ns.verisav.fr/dpp#manufacturingLocation"></see></summary>
    let manufacturingLocation =
        Namespaced_IRI.parse _namespace_name "manufacturingLocation" |> NamespacedName

    /// <summary>
    /// Mass fraction of the material in the product (decimal value between 0 and 1).
    /// <see href="https://ns.verisav.fr/dpp#massFraction"></see></summary>
    let massFraction =
        Namespaced_IRI.parse _namespace_name "massFraction" |> NamespacedName

    /// <summary>
    /// Overall circularity score (MCI) calculated as 1 - (V + W) / (2 * D), where V = virgin material proportion, W = waste leakage proportion, D = utility factor (0-1).
    /// <see href="https://ns.verisav.fr/dpp#materialCircularityIndicator"></see></summary>
    let materialCircularityIndicator =
        Namespaced_IRI.parse _namespace_name "materialCircularityIndicator" |> NamespacedName

    /// <summary>
    /// Name of the material (e.g., 'Aluminum', 'Steel', 'Plastic').
    /// <see href="https://ns.verisav.fr/dpp#materialName"></see></summary>
    let materialName =
        Namespaced_IRI.parse _namespace_name "materialName" |> NamespacedName

    /// <summary>
    /// Name of the metric (e.g., 'GHG Emissions Intensity').
    /// <see href="https://ns.verisav.fr/dpp#metricName"></see></summary>
    let metricName = Namespaced_IRI.parse _namespace_name "metricName" |> NamespacedName

    /// <summary>
    /// Value of the metric with unit.
    /// <see href="https://ns.verisav.fr/dpp#metricValue"></see></summary>
    let metricValue =
        Namespaced_IRI.parse _namespace_name "metricValue" |> NamespacedName

    /// <summary>
    /// Scope of emissions calculation (e.g., 'CradleToGate', 'CradleToGrave', 'GateToGate').
    /// <see href="https://ns.verisav.fr/dpp#operationalScope"></see></summary>
    let operationalScope =
        Namespaced_IRI.parse _namespace_name "operationalScope" |> NamespacedName

    /// <summary>
    /// Origin country code of the material (ISO 3166-1 alpha-2 or alpha-3).
    /// <see href="https://ns.verisav.fr/dpp#originCountry"></see></summary>
    let originCountry =
        Namespaced_IRI.parse _namespace_name "originCountry" |> NamespacedName

    /// <summary>
    /// Specific region of origin for the material (optional).
    /// <see href="https://ns.verisav.fr/dpp#originRegion"></see></summary>
    let originRegion =
        Namespaced_IRI.parse _namespace_name "originRegion" |> NamespacedName

    /// <summary>
    /// The name of the replacement part.
    /// <see href="https://ns.verisav.fr/dpp#partName"></see></summary>
    let partName = Namespaced_IRI.parse _namespace_name "partName" |> NamespacedName

    /// <summary>
    /// The reference number of the replacement part.
    /// <see href="https://ns.verisav.fr/dpp#partReference"></see></summary>
    let partReference =
        Namespaced_IRI.parse _namespace_name "partReference" |> NamespacedName

    /// <summary>
    /// The cost of replacement parts for the intervention.
    /// <see href="https://ns.verisav.fr/dpp#partsCost"></see></summary>
    let partsCost = Namespaced_IRI.parse _namespace_name "partsCost" |> NamespacedName

    /// <summary>
    /// Ratio of materials from primary sources (0-1).
    /// <see href="https://ns.verisav.fr/dpp#primarySourcedRatio"></see></summary>
    let primarySourcedRatio =
        Namespaced_IRI.parse _namespace_name "primarySourcedRatio" |> NamespacedName

    /// <summary>
    /// The status of the product (sous_garantie, hors_garantie, contrat_maintenance, en_panne, repare).
    /// <see href="https://ns.verisav.fr/dpp#productStatus"></see></summary>
    let productStatus =
        Namespaced_IRI.parse _namespace_name "productStatus" |> NamespacedName

    /// <summary>
    /// The date when the product status was set.
    /// <see href="https://ns.verisav.fr/dpp#productStatusDate"></see></summary>
    let productStatusDate =
        Namespaced_IRI.parse _namespace_name "productStatusDate" |> NamespacedName

    /// <summary>
    /// The date when the product was purchased.
    /// <see href="https://ns.verisav.fr/dpp#purchaseDate"></see></summary>
    let purchaseDate =
        Namespaced_IRI.parse _namespace_name "purchaseDate" |> NamespacedName

    /// <summary>
    /// The price paid for the product.
    /// <see href="https://ns.verisav.fr/dpp#purchasePrice"></see></summary>
    let purchasePrice =
        Namespaced_IRI.parse _namespace_name "purchasePrice" |> NamespacedName

    /// <summary>
    /// Proportion of product mass designed to be recyclable or reusable (0-1).
    /// <see href="https://ns.verisav.fr/dpp#recyclableContent"></see></summary>
    let recyclableContent =
        Namespaced_IRI.parse _namespace_name "recyclableContent" |> NamespacedName

    /// <summary>
    /// Proportion of product mass made from recycled or repurposed materials (0-1).
    /// <see href="https://ns.verisav.fr/dpp#recycledContent"></see></summary>
    let recycledContent =
        Namespaced_IRI.parse _namespace_name "recycledContent" |> NamespacedName

    /// <summary>
    /// Reference regulation for the conformity claim.
    /// <see href="https://ns.verisav.fr/dpp#referenceRegulation"></see></summary>
    let referenceRegulation =
        Namespaced_IRI.parse _namespace_name "referenceRegulation" |> NamespacedName

    /// <summary>
    /// Reference standard for the conformity claim.
    /// <see href="https://ns.verisav.fr/dpp#referenceStandard"></see></summary>
    let referenceStandard =
        Namespaced_IRI.parse _namespace_name "referenceStandard" |> NamespacedName

    /// <summary>
    /// Link to repair instructions for end users or repair service centers.
    /// <see href="https://ns.verisav.fr/dpp#repairInformation"></see></summary>
    let repairInformation =
        Namespaced_IRI.parse _namespace_name "repairInformation" |> NamespacedName

    /// <summary>
    /// The status of a repair event (pending, in_progress, completed, failed).
    /// <see href="https://ns.verisav.fr/dpp#repairStatus"></see></summary>
    let repairStatus =
        Namespaced_IRI.parse _namespace_name "repairStatus" |> NamespacedName

    /// <summary>
    /// Links a ReplacementPart to the original part it replaces.
    /// <see href="https://ns.verisav.fr/dpp#replaces"></see></summary>
    let replaces = Namespaced_IRI.parse _namespace_name "replaces" |> NamespacedName

    /// <summary>
    /// Standard used for emissions reporting.
    /// <see href="https://ns.verisav.fr/dpp#reportingStandard"></see></summary>
    let reportingStandard =
        Namespaced_IRI.parse _namespace_name "reportingStandard" |> NamespacedName

    /// <summary>
    /// A description of how the issue was resolved.
    /// <see href="https://ns.verisav.fr/dpp#resolutionDescription"></see></summary>
    let resolutionDescription =
        Namespaced_IRI.parse _namespace_name "resolutionDescription" |> NamespacedName

    /// <summary>
    /// The serial number of the product.
    /// <see href="https://ns.verisav.fr/dpp#serialNumber"></see></summary>
    let serialNumber =
        Namespaced_IRI.parse _namespace_name "serialNumber" |> NamespacedName

    /// <summary>
    /// Links a SecureDataShare to the EconomicOperator with whom DPP data is shared via EU Business Wallet (EBW).
    /// <see href="https://ns.verisav.fr/dpp#sharedWith"></see></summary>
    let sharedWith = Namespaced_IRI.parse _namespace_name "sharedWith" |> NamespacedName
    /// <summary>
    /// Unique identifier for the standard (URI or string).
    /// <see href="https://ns.verisav.fr/dpp#standardId"></see></summary>
    let standardId = Namespaced_IRI.parse _namespace_name "standardId" |> NamespacedName

    /// <summary>
    /// Name of the standard.
    /// <see href="https://ns.verisav.fr/dpp#standardName"></see></summary>
    let standardName =
        Namespaced_IRI.parse _namespace_name "standardName" |> NamespacedName

    /// <summary>
    /// The total cost of the intervention (labor + parts).
    /// <see href="https://ns.verisav.fr/dpp#totalCost"></see></summary>
    let totalCost = Namespaced_IRI.parse _namespace_name "totalCost" |> NamespacedName

    /// <summary>
    /// Product durability relative to industry average (e.g., 1.2 = 20% more durable).
    /// <see href="https://ns.verisav.fr/dpp#utilityFactor"></see></summary>
    let utilityFactor =
        Namespaced_IRI.parse _namespace_name "utilityFactor" |> NamespacedName

    /// <summary>
    /// Human-readable description of the specific value chain step (e.g., 'Canning', 'Assembly').
    /// <see href="https://ns.verisav.fr/dpp#valueChainProcess"></see></summary>
    let valueChainProcess =
        Namespaced_IRI.parse _namespace_name "valueChainProcess" |> NamespacedName

    /// <summary>
    /// Proportion of materials or components in this step that have been verifiably traced using digital traceability events (0-1).
    /// <see href="https://ns.verisav.fr/dpp#verifiedRatio"></see></summary>
    let verifiedRatio =
        Namespaced_IRI.parse _namespace_name "verifiedRatio" |> NamespacedName

    /// <summary>
    /// The GTIN version number (GS1 AI 22) for product changes that do not require a GTIN change per GTIN Management Standard.
    /// <see href="https://ns.verisav.fr/dpp#versionNumber"></see></summary>
    let versionNumber =
        Namespaced_IRI.parse _namespace_name "versionNumber" |> NamespacedName

    /// <summary>
    /// The duration of the warranty in months.
    /// <see href="https://ns.verisav.fr/dpp#warrantyDurationMonths"></see></summary>
    let warrantyDurationMonths =
        Namespaced_IRI.parse _namespace_name "warrantyDurationMonths" |> NamespacedName

    /// <summary>
    /// The end date of the warranty.
    /// <see href="https://ns.verisav.fr/dpp#warrantyEndDate"></see></summary>
    let warrantyEndDate =
        Namespaced_IRI.parse _namespace_name "warrantyEndDate" |> NamespacedName

    /// <summary>
    /// The start date of the warranty.
    /// <see href="https://ns.verisav.fr/dpp#warrantyStartDate"></see></summary>
    let warrantyStartDate =
        Namespaced_IRI.parse _namespace_name "warrantyStartDate" |> NamespacedName

    /// <summary>
    /// The status of the warranty (active, expiree, suspendue, annulee).
    /// <see href="https://ns.verisav.fr/dpp#warrantyStatus"></see></summary>
    let warrantyStatus =
        Namespaced_IRI.parse _namespace_name "warrantyStatus" |> NamespacedName

    /// <summary>
    /// The type of warranty (constructeur, retailer, extension, maintenance).
    /// <see href="https://ns.verisav.fr/dpp#warrantyType"></see></summary>
    let warrantyType =
        Namespaced_IRI.parse _namespace_name "warrantyType" |> NamespacedName

    /// <summary>
    /// The unique identifier for the work order.
    /// <see href="https://ns.verisav.fr/dpp#workOrderNumber"></see></summary>
    let workOrderNumber =
        Namespaced_IRI.parse _namespace_name "workOrderNumber" |> NamespacedName

    /// <summary>
    /// The priority of the work order (basse, normale, haute, urgente).
    /// <see href="https://ns.verisav.fr/dpp#workOrderPriority"></see></summary>
    let workOrderPriority =
        Namespaced_IRI.parse _namespace_name "workOrderPriority" |> NamespacedName

    /// <summary>
    /// The status of the work order (cree, assigne, en_cours, en_attente_pieces, complete, facture, annule).
    /// <see href="https://ns.verisav.fr/dpp#workOrderStatus"></see></summary>
    let workOrderStatus =
        Namespaced_IRI.parse _namespace_name "workOrderStatus" |> NamespacedName
