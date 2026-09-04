#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dpp =
    let _prefixId = PrefixId.fromNamespaceLabel "https://ns.verisav.fr/dpp#" "dpp"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Circularity Performancerdfs:label : Performance Circularité</para>
    ///   <para>rdfs:comment : Tableau de bord de la circularité du produit. Aligné avec UNTP DPP.rdfs:comment : Product circularity scorecard. Aligned with UNTP DPP.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#CircularityPerformance">dpp:CircularityPerformance</a>
    /// </summary>
    let CircularityPerformance = _prefixId.prefix "CircularityPerformance"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Un identifiant complexe combinant un GTIN avec un variant, lot ou numéro de série (produits sur mesure).rdfs:comment : A complex identifier combining a GTIN with a variant, batch, or serial number (Made-to-Order products).</para>
    ///   <para>rdfs:label : Identifiant Composérdfs:label : Compound Identifier</para>
    ///   <a href="https://ns.verisav.fr/dpp#CompoundIdentifier">dpp:CompoundIdentifier</a>
    /// </summary>
    let CompoundIdentifier = _prefixId.prefix "CompoundIdentifier"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Déclaration de conformité à un standard ou réglementation. Aligné avec UNTP DPP.rdfs:comment : Claim of conformity to a standard or regulation. Aligned with UNTP DPP.</para>
    ///   <para>rdfs:label : Déclaration de Conformitérdfs:label : Conformity Claim</para>
    ///   <a href="https://ns.verisav.fr/dpp#ConformityClaim">dpp:ConformityClaim</a>
    /// </summary>
    let ConformityClaim = _prefixId.prefix "ConformityClaim"
    /// <summary>
    ///   <para>rdfs:comment : Un consommateur qui possède ou utilise un produit.rdfs:comment : A consumer who owns or uses a product.</para>
    ///   <para>rdfs:label : Consommateurrdfs:label : Consumer</para>
    ///   <a href="https://ns.verisav.fr/dpp#Consumer">dpp:Consumer</a>
    /// </summary>
    let Consumer = _prefixId.prefix "Consumer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Critère ou règle dans un standard ou réglementation contre lequel une déclaration est évaluée.rdfs:comment : A criterion or rule within a standard or regulation against which a claim is evaluated.</para>
    ///   <para>rdfs:label : Critèrerdfs:label : Criterion</para>
    ///   <a href="https://ns.verisav.fr/dpp#Criterion">dpp:Criterion</a>
    /// </summary>
    let Criterion = _prefixId.prefix "Criterion"
    /// <summary>
    ///   <para>rdfs:comment : Une évaluation de diagnostic effectuée sur un produit pour identifier les problèmes.rdfs:comment : A diagnostic assessment performed on a product to identify issues.</para>
    ///   <para>rdfs:label : Diagnosticrdfs:label : Diagnostic</para>
    ///   <a href="https://ns.verisav.fr/dpp#Diagnostic">dpp:Diagnostic</a>
    /// </summary>
    let Diagnostic = _prefixId.prefix "Diagnostic"
    /// <summary>
    ///   <para>rdfs:comment : Un document associé à un produit (manuels, factures, certificats, etc.).rdfs:comment : A document associated with a product (manuals, invoices, certificates, etc.).</para>
    ///   <para>rdfs:label : Documentrdfs:label : Document</para>
    ///   <a href="https://ns.verisav.fr/dpp#Document">dpp:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Un opérateur économique dans la chaîne de valeur (fabricant, importateur, distributeur, revendeur, réparateur) selon la réglementation européenne ESPR. Peut être authentifié via EU Business Wallet (EBW) avec EUID (European Unique Identifier).rdfs:comment : An economic operator in the value chain (manufacturer, importer, distributor, dealer, repairer) as per EU ESPR regulation. Can be authenticated via EU Business Wallet (EBW) with EUID (European Unique Identifier).</para>
    ///   <para>rdfs:label : Opérateur Économiquerdfs:label : Economic Operator</para>
    ///   <a href="https://ns.verisav.fr/dpp#EconomicOperator">dpp:EconomicOperator</a>
    /// </summary>
    let EconomicOperator = _prefixId.prefix "EconomicOperator"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Tableau de bord des émissions de gaz à effet de serre du produit. Aligné avec UNTP DPP.rdfs:comment : Greenhouse gas emissions scorecard for a product. Aligned with UNTP DPP.</para>
    ///   <para>rdfs:label : Performance Émissionsrdfs:label : Emissions Performance</para>
    ///   <a href="https://ns.verisav.fr/dpp#EmissionsPerformance">dpp:EmissionsPerformance</a>
    /// </summary>
    let EmissionsPerformance = _prefixId.prefix "EmissionsPerformance"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Un lieu ou bâtiment impliqué dans la chaîne de valeur d'un produit (usine de fabrication, entrepôt, etc.) selon la réglementation européenne ESPR. Aligné avec UNTP DPP-04.rdfs:comment : A location or building involved in the value chain of a product (manufacturing facility, warehouse, etc.) as per EU ESPR regulation. Aligned with UNTP DPP-04.</para>
    ///   <para>rdfs:label : Installationrdfs:label : Facility</para>
    ///   <a href="https://ns.verisav.fr/dpp#Facility">dpp:Facility</a>
    /// </summary>
    let Facility = _prefixId.prefix "Facility"
    /// <summary>
    ///   <para>rdfs:comment : Une intervention technique sur un produit (diagnostic, réparation, maintenance, remplacement, retour fabricant).rdfs:comment : A technical intervention on a product (diagnostic, repair, maintenance, replacement, return to manufacturer).</para>
    ///   <para>rdfs:label : Interventionrdfs:label : Intervention</para>
    ///   <a href="https://ns.verisav.fr/dpp#Intervention">dpp:Intervention</a>
    /// </summary>
    let Intervention = _prefixId.prefix "Intervention"
    /// <summary>
    ///   <para>rdfs:comment : Le fabricant d'un produit.rdfs:comment : The manufacturer of a product.</para>
    ///   <para>rdfs:label : Fabricantrdfs:label : Manufacturer</para>
    ///   <a href="https://ns.verisav.fr/dpp#Manufacturer">dpp:Manufacturer</a>
    /// </summary>
    let Manufacturer = _prefixId.prefix "Manufacturer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Information sur la provenance d'un matériau : nom, fraction massique, pays d'origine. Aligné avec UNTP DPP-03.rdfs:comment : Information about material provenance: name, mass fraction, origin country. Aligned with UNTP DPP-03.</para>
    ///   <para>rdfs:label : Provenance des Matériauxrdfs:label : Material Provenance</para>
    ///   <a href="https://ns.verisav.fr/dpp#MaterialProvenance">dpp:MaterialProvenance</a>
    /// </summary>
    let MaterialProvenance = _prefixId.prefix "MaterialProvenance"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Métrique définissant les valeurs mesurées réelles, incluant optionnellement la précision.rdfs:comment : A metric defining actual measured values, optionally including accuracy.</para>
    ///   <para>rdfs:label : Métriquerdfs:label : Metric</para>
    ///   <a href="https://ns.verisav.fr/dpp#Metric">dpp:Metric</a>
    /// </summary>
    let Metric = _prefixId.prefix "Metric"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Classification d'un produit selon un schéma standardisé (UN-CPC, GS1, NACE, etc.). Aligné avec UNTP DPP-02.rdfs:comment : Product classification according to a standardized scheme (UN-CPC, GS1, NACE, etc.). Aligned with UNTP DPP-02.</para>
    ///   <para>rdfs:label : Classification Produitrdfs:label : Product Classification</para>
    ///   <a href="https://ns.verisav.fr/dpp#ProductClassification">dpp:ProductClassification</a>
    /// </summary>
    let ProductClassification = _prefixId.prefix "ProductClassification"
    /// <summary>
    ///   <para>rdfs:comment : Une étape dans le cycle de vie du produit (fabrication, achat, usage, fin de vie, recyclage).rdfs:comment : A stage in the product lifecycle (manufacturing, purchase, usage, end of life, recycling).</para>
    ///   <para>rdfs:label : Étape du Cycle de Vie du Produitrdfs:label : Product Lifecycle Stage</para>
    ///   <a href="https://ns.verisav.fr/dpp#ProductLifecycleStage">dpp:ProductLifecycleStage</a>
    /// </summary>
    let ProductLifecycleStage = _prefixId.prefix "ProductLifecycleStage"
    /// <summary>
    ///   <para>rdfs:comment : Un Passeport Produit Numérique qui suit un produit tout au long de son cycle de vie.rdfs:comment : A Digital Product Passport that tracks a product throughout its entire lifecycle.</para>
    ///   <para>rdfs:label : Passeport Produitrdfs:label : Product Passport</para>
    ///   <a href="https://ns.verisav.fr/dpp#ProductPassport">dpp:ProductPassport</a>
    /// </summary>
    let ProductPassport = _prefixId.prefix "ProductPassport"
    /// <summary>
    ///   <para>rdfs:comment : Le statut actuel d'un produit (sous garantie, hors garantie, en panne, réparé, etc.).rdfs:comment : The current status of a product (under warranty, out of warranty, broken, repaired, etc.).</para>
    ///   <para>rdfs:label : Statut Produitrdfs:label : Product Status</para>
    ///   <a href="https://ns.verisav.fr/dpp#ProductStatus">dpp:ProductStatus</a>
    /// </summary>
    let ProductStatus = _prefixId.prefix "ProductStatus"
    /// <summary>
    ///   <para>rdfs:comment : Instructions pour recycler ou éliminer un produit en fin de vie.rdfs:comment : Instructions for recycling or disposing of a product at end of life.</para>
    ///   <para>rdfs:label : Consignes de Recyclagerdfs:label : Recycling Instructions</para>
    ///   <a href="https://ns.verisav.fr/dpp#RecyclingInstructions">dpp:RecyclingInstructions</a>
    /// </summary>
    let RecyclingInstructions = _prefixId.prefix "RecyclingInstructions"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Réglementation de référence pour une déclaration de conformité.rdfs:comment : Reference regulation for a conformity claim.</para>
    ///   <para>rdfs:label : Réglementationrdfs:label : Regulation</para>
    ///   <a href="https://ns.verisav.fr/dpp#Regulation">dpp:Regulation</a>
    /// </summary>
    let Regulation = _prefixId.prefix "Regulation"
    /// <summary>
    ///   <para>rdfs:comment : Une intervention de réparation ou maintenance spécifique effectuée sur un produit.rdfs:comment : A specific repair or maintenance intervention performed on a product.</para>
    ///   <para>rdfs:label : Événement de Réparationrdfs:label : Repair Event</para>
    ///   <a href="https://ns.verisav.fr/dpp#RepairEvent">dpp:RepairEvent</a>
    /// </summary>
    let RepairEvent = _prefixId.prefix "RepairEvent"
    /// <summary>
    ///   <para>rdfs:comment : Une personne ou organisation qui répare des produits.rdfs:comment : A person or organization that repairs products.</para>
    ///   <para>rdfs:label : Réparateurrdfs:label : Repairer</para>
    ///   <a href="https://ns.verisav.fr/dpp#Repairer">dpp:Repairer</a>
    /// </summary>
    let Repairer = _prefixId.prefix "Repairer"
    /// <summary>
    ///   <para>rdfs:comment : Une pièce utilisée pour remplacer un composant dans un produit lors d'une réparation ou maintenance.rdfs:comment : A part used to replace a component in a product during repair or maintenance.</para>
    ///   <para>rdfs:label : Pièce de Rechangerdfs:label : Replacement Part</para>
    ///   <a href="https://ns.verisav.fr/dpp#ReplacementPart">dpp:ReplacementPart</a>
    /// </summary>
    let ReplacementPart = _prefixId.prefix "ReplacementPart"
    /// <summary>
    ///   <para>rdfs:comment : Un distributeur qui vend des produits.rdfs:comment : A retailer or distributor who sells products.</para>
    ///   <para>rdfs:label : Distributeurrdfs:label : Retailer</para>
    ///   <a href="https://ns.verisav.fr/dpp#Retailer">dpp:Retailer</a>
    /// </summary>
    let Retailer = _prefixId.prefix "Retailer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Un partage sécurisé de données DPP entre opérateurs économiques via EU Business Wallet (EBW). Inclut la vérification d'intégrité cryptographique et l'horodatage.rdfs:comment : A secure sharing of DPP data between economic operators via EU Business Wallet (EBW). Includes cryptographic integrity verification and timestamping.</para>
    ///   <para>rdfs:label : Partage de Données Sécurisérdfs:label : Secure Data Share</para>
    ///   <a href="https://ns.verisav.fr/dpp#SecureDataShare">dpp:SecureDataShare</a>
    /// </summary>
    let SecureDataShare = _prefixId.prefix "SecureDataShare"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Lien sécurisé avec digest de hash et méthode de cryptage pour vérification.rdfs:comment : A secure link with hash digest and encryption method for verification.</para>
    ///   <para>rdfs:label : Lien Sécurisérdfs:label : Secure Link</para>
    ///   <a href="https://ns.verisav.fr/dpp#SecureLink">dpp:SecureLink</a>
    /// </summary>
    let SecureLink = _prefixId.prefix "SecureLink"
    /// <summary>
    ///   <para>rdfs:comment : Une demande de service après-vente (SAV) pour un produit.rdfs:comment : A request for after-sales service (SAV) for a product.</para>
    ///   <para>rdfs:label : Demande de Servicerdfs:label : Service Request</para>
    ///   <a href="https://ns.verisav.fr/dpp#ServiceRequest">dpp:ServiceRequest</a>
    /// </summary>
    let ServiceRequest = _prefixId.prefix "ServiceRequest"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Standard, norme ou schéma de référence pour une déclaration de conformité.rdfs:comment : Standard, norm, or reference scheme for a conformity claim.</para>
    ///   <para>rdfs:label : Standardrdfs:label : Standard</para>
    ///   <a href="https://ns.verisav.fr/dpp#Standard">dpp:Standard</a>
    /// </summary>
    let Standard = _prefixId.prefix "Standard"
    /// <summary>
    ///   <para>rdfs:comment : Événement de traçabilité basé sur ISO/IEC 19987 (EPCIS) ou standards similaires. Aligné avec UNTP DPP-06.rdfs:comment : Traceability event based on ISO/IEC 19987 (EPCIS) or similar standards. Aligned with UNTP DPP-06.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Traceability Eventrdfs:label : Événement de Traçabilité</para>
    ///   <a href="https://ns.verisav.fr/dpp#TraceabilityEvent">dpp:TraceabilityEvent</a>
    /// </summary>
    let TraceabilityEvent = _prefixId.prefix "TraceabilityEvent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Information de traçabilité pour un processus spécifique de la chaîne de valeur. Aligné avec UNTP DPP.rdfs:comment : Traceability information for a specific value chain process. Aligned with UNTP DPP.</para>
    ///   <para>rdfs:label : Performance Traçabilitérdfs:label : Traceability Performance</para>
    ///   <a href="https://ns.verisav.fr/dpp#TraceabilityPerformance">dpp:TraceabilityPerformance</a>
    /// </summary>
    let TraceabilityPerformance = _prefixId.prefix "TraceabilityPerformance"
    /// <summary>
    ///   <para>rdfs:label : Credential Vérifiablerdfs:label : Verifiable Credential</para>
    ///   <para>rdfs:comment : Un W3C Verifiable Credential (VCDM 2.0) qui peut être utilisé pour vérifier des déclarations sur un passeport produit ou un opérateur économique. Stocké et géré via EU Business Wallet (EBW).rdfs:comment : A W3C Verifiable Credential (VCDM 2.0) that can be used to verify claims about a product passport or economic operator. Stored and managed via EU Business Wallet (EBW).</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#VerifiableCredential">dpp:VerifiableCredential</a>
    /// </summary>
    let VerifiableCredential = _prefixId.prefix "VerifiableCredential"
    /// <summary>
    ///   <para>rdfs:label : Verifiable Product Passportrdfs:label : Passeport Produit Vérifiable</para>
    ///   <para>rdfs:comment : A Digital Product Passport issued as a W3C Verifiable Credential (VCDM 2.0) via EU Business Wallet (EBW). Provides cryptographic proof of authenticity and integrity.rdfs:comment : Un Passeport Produit Numérique émis comme W3C Verifiable Credential (VCDM 2.0) via EU Business Wallet (EBW). Fournit une preuve cryptographique d'authenticité et d'intégrité.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#VerifiableProductPassport">dpp:VerifiableProductPassport</a>
    /// </summary>
    let VerifiableProductPassport = _prefixId.prefix "VerifiableProductPassport"
    /// <summary>
    ///   <para>rdfs:comment : Une garantie couvrant un produit, qui peut être de différents types (constructeur, distributeur, extension, maintenance).rdfs:comment : A warranty covering a product, which can be of different types (manufacturer, retailer, extension, maintenance).</para>
    ///   <para>rdfs:label : Garantierdfs:label : Warranty</para>
    ///   <a href="https://ns.verisav.fr/dpp#Warranty">dpp:Warranty</a>
    /// </summary>
    let Warranty = _prefixId.prefix "Warranty"
    /// <summary>
    ///   <para>rdfs:comment : Une réclamation effectuée sous garantie.rdfs:comment : A claim made under a warranty.</para>
    ///   <para>rdfs:label : Réclamation de Garantierdfs:label : Warranty Claim</para>
    ///   <a href="https://ns.verisav.fr/dpp#WarrantyClaim">dpp:WarrantyClaim</a>
    /// </summary>
    let WarrantyClaim = _prefixId.prefix "WarrantyClaim"
    /// <summary>
    ///   <para>rdfs:comment : Un ordre de travail à effectuer sur un produit (réparation, maintenance, etc.).rdfs:comment : An order for work to be performed on a product (repair, maintenance, etc.).</para>
    ///   <para>rdfs:label : Ordre de Travailrdfs:label : Work Order</para>
    ///   <a href="https://ns.verisav.fr/dpp#WorkOrder">dpp:WorkOrder</a>
    /// </summary>
    let WorkOrder = _prefixId.prefix "WorkOrder"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Précision ou incertitude de la valeur de la métrique (optionnel).rdfs:comment : Accuracy or uncertainty of the metric value (optional).</para>
    ///   <para>rdfs:label : précisionrdfs:label : accuracy</para>
    ///   <a href="https://ns.verisav.fr/dpp#accuracy">dpp:accuracy</a>
    /// </summary>
    let accuracy = _prefixId.prefix "accuracy"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Critères dans le standard ou réglementation contre lesquels la déclaration est évaluée.rdfs:comment : Criteria within the standard or regulation against which the claim is evaluated.</para>
    ///   <para>rdfs:label : critères d'évaluationrdfs:label : assessment criteria</para>
    ///   <a href="https://ns.verisav.fr/dpp#assessmentCriteria">dpp:assessmentCriteria</a>
    /// </summary>
    let assessmentCriteria = _prefixId.prefix "assessmentCriteria"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Date à laquelle la déclaration a été évaluée.rdfs:comment : Date when the claim was assessed.</para>
    ///   <para>rdfs:label : date d'évaluationrdfs:label : assessment date</para>
    ///   <a href="https://ns.verisav.fr/dpp#assessmentDate">dpp:assessmentDate</a>
    /// </summary>
    let assessmentDate = _prefixId.prefix "assessmentDate"
    /// <summary>
    ///   <para>rdfs:comment : The batch or lot number (GS1 AI 10) for production batches. Used with GTIN for batch-level granularity.rdfs:comment : Le numéro de lot ou batch (GS1 AI 10) pour les lots de production. Utilisé avec GTIN pour la granularité au niveau lot.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Batch/Lot Numberrdfs:label : Numéro de Lot</para>
    ///   <a href="https://ns.verisav.fr/dpp#batchLotNumber">dpp:batchLotNumber</a>
    /// </summary>
    let batchLotNumber = _prefixId.prefix "batchLotNumber"
    /// <summary>
    ///   <para>rdfs:comment : Propriété inverse : lie un WorkOrder ou Intervention à son ProductPassport.rdfs:comment : Inverse property: links a WorkOrder or Intervention to its ProductPassport.</para>
    ///   <para>rdfs:label : appartient àrdfs:label : belongs to</para>
    ///   <a href="https://ns.verisav.fr/dpp#belongsTo">dpp:belongsTo</a>
    /// </summary>
    let belongsTo = _prefixId.prefix "belongsTo"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Empreinte carbone du produit en kg CO2eq par unité déclarée.rdfs:comment : Carbon footprint of the product in kg CO2eq per declared unit.</para>
    ///   <para>rdfs:label : empreinte carbonerdfs:label : carbon footprint</para>
    ///   <a href="https://ns.verisav.fr/dpp#carbonFootprint">dpp:carbonFootprint</a>
    /// </summary>
    let carbonFootprint = _prefixId.prefix "carbonFootprint"
    /// <summary>
    ///   <para>rdfs:comment : Une description de la demande de service ou réclamation.rdfs:comment : A description of the service request or claim.</para>
    ///   <para>rdfs:label : description de la réclamationrdfs:label : claim description</para>
    ///   <a href="https://ns.verisav.fr/dpp#claimDescription">dpp:claimDescription</a>
    /// </summary>
    let claimDescription = _prefixId.prefix "claimDescription"
    /// <summary>
    ///   <para>rdfs:comment : La priorité de la demande de service (normal, haute, urgente).rdfs:comment : The priority of the service request (normal, high, urgent).</para>
    ///   <para>rdfs:label : priorité de la réclamationrdfs:label : claim priority</para>
    ///   <a href="https://ns.verisav.fr/dpp#claimPriority">dpp:claimPriority</a>
    /// </summary>
    let claimPriority = _prefixId.prefix "claimPriority"
    /// <summary>
    ///   <para>rdfs:comment : Le statut d'une demande de service (soumise, en cours, approuvée, résolue).rdfs:comment : The status of a service request (soumise, en_cours, approuvee, resolue).</para>
    ///   <para>rdfs:label : statut de la réclamationrdfs:label : claim status</para>
    ///   <a href="https://ns.verisav.fr/dpp#claimStatus">dpp:claimStatus</a>
    /// </summary>
    let claimStatus = _prefixId.prefix "claimStatus"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Code de classification selon le schéma spécifié.rdfs:comment : Classification code according to the specified scheme.</para>
    ///   <para>rdfs:label : code de classificationrdfs:label : classification code</para>
    ///   <a href="https://ns.verisav.fr/dpp#classificationCode">dpp:classificationCode</a>
    /// </summary>
    let classificationCode = _prefixId.prefix "classificationCode"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : URI ou identifiant du schéma de classification (ex: 'UN-CPC', 'GS1', 'NACE').rdfs:comment : URI or identifier of the classification scheme (e.g., 'UN-CPC', 'GS1', 'NACE').</para>
    ///   <para>rdfs:label : schéma de classificationrdfs:label : classification scheme</para>
    ///   <a href="https://ns.verisav.fr/dpp#classificationScheme">dpp:classificationScheme</a>
    /// </summary>
    let classificationScheme = _prefixId.prefix "classificationScheme"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indique si le produit est conforme aux critères spécifiés (true/false).rdfs:comment : Indicates whether the product meets the specified criteria (true/false).</para>
    ///   <para>rdfs:label : conformitérdfs:label : conformance</para>
    ///   <a href="https://ns.verisav.fr/dpp#conformance">dpp:conformance</a>
    /// </summary>
    let conformance = _prefixId.prefix "conformance"
    /// <summary>
    ///   <para>rdfs:label : preuve de conformitérdfs:label : conformity evidence</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Lien vers attestation de deuxième ou troisième partie, comme un Digital Conformity Credential UNTP, PDF, ou autre format de preuve.rdfs:comment : Link to second or third party attestation, such as a UNTP Digital Conformity Credential, PDF, or other evidence format.</para>
    ///   <a href="https://ns.verisav.fr/dpp#conformityEvidence">dpp:conformityEvidence</a>
    /// </summary>
    let conformityEvidence = _prefixId.prefix "conformityEvidence"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Catégorie thématique de la déclaration (ex: 'environment.emissions', 'social.working_conditions').rdfs:comment : Topic category of the claim (e.g., 'environment.emissions', 'social.working_conditions').</para>
    ///   <para>rdfs:label : thème de conformitérdfs:label : conformity topic</para>
    ///   <a href="https://ns.verisav.fr/dpp#conformityTopic">dpp:conformityTopic</a>
    /// </summary>
    let conformityTopic = _prefixId.prefix "conformityTopic"
    /// <summary>
    ///   <para>rdfs:comment : L'autorité ou Opérateur Économique qui a émis un VerifiableCredential via EU Business Wallet (EBW).rdfs:comment : The authority or EconomicOperator that issued a VerifiableCredential via EU Business Wallet (EBW).</para>
    ///   <para>rdfs:label : émetteur de credentialrdfs:label : credential issuer</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#credentialIssuer">dpp:credentialIssuer</a>
    /// </summary>
    let credentialIssuer = _prefixId.prefix "credentialIssuer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Identifiant unique du critère (typiquement une URI).rdfs:comment : Unique identifier for the criterion (typically a URI).</para>
    ///   <para>rdfs:label : ID critèrerdfs:label : criterion ID</para>
    ///   <a href="https://ns.verisav.fr/dpp#criterionId">dpp:criterionId</a>
    /// </summary>
    let criterionId = _prefixId.prefix "criterionId"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Nom du critère.rdfs:comment : Name of the criterion.</para>
    ///   <para>rdfs:label : nom du critèrerdfs:label : criterion name</para>
    ///   <a href="https://ns.verisav.fr/dpp#criterionName">dpp:criterionName</a>
    /// </summary>
    let criterionName = _prefixId.prefix "criterionName"
    /// <summary>
    ///   <para>rdfs:comment : Digest de hash cryptographique garantissant l'intégrité des données DPP partagées via EU Business Wallet (EBW). Utilisé dans SecureDataShare pour la détection de falsification.rdfs:comment : Cryptographic hash digest ensuring the integrity of shared DPP data via EU Business Wallet (EBW). Used in SecureDataShare for tamper detection.</para>
    ///   <para>rdfs:label : hash d'intégrité des donnéesrdfs:label : data integrity hash</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#dataIntegrityHash">dpp:dataIntegrityHash</a>
    /// </summary>
    let dataIntegrityHash = _prefixId.prefix "dataIntegrityHash"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Unité de mesure pour l'empreinte carbone (ex: 'KGM' pour kg, 'C62' pour unité).rdfs:comment : Unit of measure for carbon footprint (e.g., 'KGM' for kg, 'C62' for unit).</para>
    ///   <para>rdfs:label : unité déclaréerdfs:label : declared unit</para>
    ///   <a href="https://ns.verisav.fr/dpp#declaredUnit">dpp:declaredUnit</a>
    /// </summary>
    let declaredUnit = _prefixId.prefix "declaredUnit"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Valeurs mesurées réelles, incluant optionnellement la précision.rdfs:comment : Actual measured values, optionally including accuracy.</para>
    ///   <para>rdfs:label : valeur déclaréerdfs:label : declared value</para>
    ///   <a href="https://ns.verisav.fr/dpp#declaredValue">dpp:declaredValue</a>
    /// </summary>
    let declaredValue = _prefixId.prefix "declaredValue"
    /// <summary>
    ///   <para>rdfs:comment : Une description du processus de diagnostic et des résultats.rdfs:comment : A description of the diagnostic process and findings.</para>
    ///   <para>rdfs:label : description du diagnosticrdfs:label : diagnostic description</para>
    ///   <a href="https://ns.verisav.fr/dpp#diagnosticDescription">dpp:diagnosticDescription</a>
    /// </summary>
    let diagnosticDescription = _prefixId.prefix "diagnosticDescription"
    /// <summary>
    ///   <para>rdfs:comment : Le résultat ou conclusion du diagnostic.rdfs:comment : The result or conclusion of the diagnostic.</para>
    ///   <para>rdfs:label : résultat du diagnosticrdfs:label : diagnostic result</para>
    ///   <a href="https://ns.verisav.fr/dpp#diagnosticResult">dpp:diagnosticResult</a>
    /// </summary>
    let diagnosticResult = _prefixId.prefix "diagnosticResult"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Méthode de cryptage si applicable (ex: 'AES', 'none').rdfs:comment : Encryption method if applicable (e.g., 'AES', 'none').</para>
    ///   <para>rdfs:label : méthode de cryptagerdfs:label : encryption method</para>
    ///   <a href="https://ns.verisav.fr/dpp#encryptionMethod">dpp:encryptionMethod</a>
    /// </summary>
    let encryptionMethod = _prefixId.prefix "encryptionMethod"
    /// <summary>
    ///   <para>rdfs:label : Identifiant Unique Européen (EUID)rdfs:label : European Unique Identifier (EUID)</para>
    ///   <para>rdfs:comment : L'Identifiant Unique Européen (EUID) pour une entité légale, émis via EU Business Wallet (EBW). Fournit une identité numérique unifiée dans les 27 États membres de l'UE.rdfs:comment : The European Unique Identifier (EUID) for a legal entity, issued via EU Business Wallet (EBW). Provides a unified digital identity across all 27 EU member states.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#euid">dpp:euid</a>
    /// </summary>
    let euid = _prefixId.prefix "euid"
    /// <summary>
    ///   <para>rdfs:comment : Lie une Intervention à une Intervention précédente (crée une chaîne d'interventions).rdfs:comment : Links an Intervention to a previous Intervention (creates a chain of interventions).</para>
    ///   <para>rdfs:label : suitrdfs:label : follows</para>
    ///   <a href="https://ns.verisav.fr/dpp#follows">dpp:follows</a>
    /// </summary>
    let follows = _prefixId.prefix "follows"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Le niveau de granularité d'identification : 'model' (GTIN seul), 'batch' (GTIN + numéro de lot), ou 'serial' (GTIN + numéro de série). Déterminé par les actes délégués UE par catégorie de produit.rdfs:comment : The level of identification granularity: 'model' (GTIN only), 'batch' (GTIN + batch/lot number), or 'serial' (GTIN + serial number). Determined by EU delegated acts per product category.</para>
    ///   <para>rdfs:label : Niveau de Granularitérdfs:label : Granularity Level</para>
    ///   <a href="https://ns.verisav.fr/dpp#granularityLevel">dpp:granularityLevel</a>
    /// </summary>
    let granularityLevel = _prefixId.prefix "granularityLevel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The standard GS1 Digital Link URI for the product, resolving to the DPP. Uses uncompressed GS1 Digital Link URI syntax per GS1 standards.rdfs:comment : L'URI standard GS1 Digital Link pour le produit, résolvant vers le DPP. Utilise la syntaxe GS1 Digital Link URI non compressée selon les standards GS1.</para>
    ///   <para>rdfs:label : GS1 Digital Link URIrdfs:label : URI GS1 Digital Link</para>
    ///   <a href="https://ns.verisav.fr/dpp#gs1DigitalLink">dpp:gs1DigitalLink</a>
    /// </summary>
    let gs1DigitalLink = _prefixId.prefix "gs1DigitalLink"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a ProductPassport to its circularity scorecard. Aligned with UNTP DPP.rdfs:comment : Lie un ProductPassport à son tableau de bord de circularité. Aligné avec UNTP DPP.</para>
    ///   <para>rdfs:label : has circularity scorecardrdfs:label : a pour tableau de bord circularité</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasCircularityScorecard">dpp:hasCircularityScorecard</a>
    /// </summary>
    let hasCircularityScorecard = _prefixId.prefix "hasCircularityScorecard"
    /// <summary>
    ///   <para>rdfs:comment : Lie un ProductPassport à un Identifiant Composé (GTIN + variant/lot/série).rdfs:comment : Links a ProductPassport to a CompoundIdentifier (GTIN + variant/batch/serial).</para>
    ///   <para>rdfs:label : a pour identifiant composérdfs:label : has compound identifier</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasCompoundIdentifier">dpp:hasCompoundIdentifier</a>
    /// </summary>
    let hasCompoundIdentifier = _prefixId.prefix "hasCompoundIdentifier"
    /// <summary>
    ///   <para>rdfs:label : has conformity claimrdfs:label : a pour déclaration de conformité</para>
    ///   <para>rdfs:comment : Lie un ProductPassport à une déclaration de conformité. Aligné avec UNTP DPP.rdfs:comment : Links a ProductPassport to a conformity claim. Aligned with UNTP DPP.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasConformityClaim">dpp:hasConformityClaim</a>
    /// </summary>
    let hasConformityClaim = _prefixId.prefix "hasConformityClaim"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : a pour produit constituantrdfs:label : has constituent product</para>
    ///   <para>rdfs:comment : Link to a DPP of a constituent product in the value chain. Enables multi-level traceability.rdfs:comment : Lien vers un DPP de produit constituant dans la chaîne de valeur. Permet la traçabilité multi-niveau.</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasConstituentProduct">dpp:hasConstituentProduct</a>
    /// </summary>
    let hasConstituentProduct = _prefixId.prefix "hasConstituentProduct"
    /// <summary>
    ///   <para>rdfs:comment : Lie un ProductPassport à son Consommateur.rdfs:comment : Links a ProductPassport to its Consumer.</para>
    ///   <para>rdfs:label : a pour consommateurrdfs:label : has consumer</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasConsumer">dpp:hasConsumer</a>
    /// </summary>
    let hasConsumer = _prefixId.prefix "hasConsumer"
    /// <summary>
    ///   <para>rdfs:comment : Lie un ProductPassport à son ProductStatus actuel.rdfs:comment : Links a ProductPassport to its current ProductStatus.</para>
    ///   <para>rdfs:label : a pour statut actuelrdfs:label : has current status</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasCurrentStatus">dpp:hasCurrentStatus</a>
    /// </summary>
    let hasCurrentStatus = _prefixId.prefix "hasCurrentStatus"
    /// <summary>
    ///   <para>rdfs:comment : Lie une Intervention à un Diagnostic.rdfs:comment : Links an Intervention to a Diagnostic.</para>
    ///   <para>rdfs:label : a pour diagnosticrdfs:label : has diagnostic</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasDiagnostic">dpp:hasDiagnostic</a>
    /// </summary>
    let hasDiagnostic = _prefixId.prefix "hasDiagnostic"
    /// <summary>
    ///   <para>rdfs:comment : Lie un ProductPassport à un Document.rdfs:comment : Links a ProductPassport to a Document.</para>
    ///   <para>rdfs:label : a pour documentrdfs:label : has document</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasDocument">dpp:hasDocument</a>
    /// </summary>
    let hasDocument = _prefixId.prefix "hasDocument"
    /// <summary>
    ///   <para>rdfs:comment : Lie un ProductPassport à son Opérateur Économique (fabricant, importateur, distributeur, etc.).rdfs:comment : Links a ProductPassport to its EconomicOperator (manufacturer, importer, distributor, etc.).</para>
    ///   <para>rdfs:label : a pour opérateur économiquerdfs:label : has economic operator</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasEconomicOperator">dpp:hasEconomicOperator</a>
    /// </summary>
    let hasEconomicOperator = _prefixId.prefix "hasEconomicOperator"
    /// <summary>
    ///   <para>rdfs:label : a pour tableau de bord émissionsrdfs:label : has emissions scorecard</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Links a ProductPassport to its emissions scorecard. Aligned with UNTP DPP.rdfs:comment : Lie un ProductPassport à son tableau de bord d'émissions. Aligné avec UNTP DPP.</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasEmissionsScorecard">dpp:hasEmissionsScorecard</a>
    /// </summary>
    let hasEmissionsScorecard = _prefixId.prefix "hasEmissionsScorecard"
    /// <summary>
    ///   <para>rdfs:comment : Lie un ProductPassport à l'Installation où il a été produit.rdfs:comment : Links a ProductPassport to the Facility where it was produced.</para>
    ///   <para>rdfs:label : a pour installationrdfs:label : has facility</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasFacility">dpp:hasFacility</a>
    /// </summary>
    let hasFacility = _prefixId.prefix "hasFacility"
    /// <summary>
    ///   <para>rdfs:label : Global Location Number (GLN)rdfs:label : Code Lieu International (GLN)</para>
    ///   <para>rdfs:comment : Le Code Lieu International GS1 identifiant l'organisation ou l'installation. Utilisé pour les opérateurs économiques et installations selon la réglementation européenne ESPR.rdfs:comment : The GS1 Global Location Number identifying the organization or facility. Used for economic operators and facilities per EU ESPR regulation.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasGln">dpp:hasGln</a>
    /// </summary>
    let hasGln = _prefixId.prefix "hasGln"
    /// <summary>
    ///   <para>rdfs:label : Global Trade Item Number (GTIN)rdfs:label : Numéro d'Article Global (GTIN)</para>
    ///   <para>rdfs:comment : The GS1 Global Trade Item Number (GTIN) in one of the formats: GTIN-8, GTIN-12, GTIN-13, or GTIN-14. Used with AI (01) for Made-to-Stock products or AI (03) for Made-to-Order products.rdfs:comment : Le Numéro d'Article Global GS1 (GTIN) dans l'un des formats : GTIN-8, GTIN-12, GTIN-13 ou GTIN-14. Utilisé avec AI (01) pour produits Made-to-Stock ou AI (03) pour produits Made-to-Order.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasGtin">dpp:hasGtin</a>
    /// </summary>
    let hasGtin = _prefixId.prefix "hasGtin"
    /// <summary>
    ///   <para>rdfs:comment : Lie un WorkOrder à une Intervention.rdfs:comment : Links a WorkOrder to an Intervention.</para>
    ///   <para>rdfs:label : a pour interventionrdfs:label : has intervention</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasIntervention">dpp:hasIntervention</a>
    /// </summary>
    let hasIntervention = _prefixId.prefix "hasIntervention"
    /// <summary>
    ///   <para>rdfs:comment : Lie un ProductPassport à une Étape du Cycle de Vie.rdfs:comment : Links a ProductPassport to a ProductLifecycleStage.</para>
    ///   <para>rdfs:label : a pour étape de cycle de vierdfs:label : has lifecycle stage</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasLifecycleStage">dpp:hasLifecycleStage</a>
    /// </summary>
    let hasLifecycleStage = _prefixId.prefix "hasLifecycleStage"
    /// <summary>
    ///   <para>rdfs:comment : Lie un ProductPassport à son Fabricant.rdfs:comment : Links a ProductPassport to its Manufacturer.</para>
    ///   <para>rdfs:label : a pour fabricantrdfs:label : has manufacturer</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasManufacturer">dpp:hasManufacturer</a>
    /// </summary>
    let hasManufacturer = _prefixId.prefix "hasManufacturer"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has material provenancerdfs:label : a pour provenance de matériau</para>
    ///   <para>rdfs:comment : Lie un ProductPassport à des informations de provenance des matériaux. Aligné avec UNTP DPP-03.rdfs:comment : Links a ProductPassport to material provenance information. Aligned with UNTP DPP-03.</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasMaterialProvenance">dpp:hasMaterialProvenance</a>
    /// </summary>
    let hasMaterialProvenance = _prefixId.prefix "hasMaterialProvenance"
    /// <summary>
    ///   <para>rdfs:comment : Links a ProductPassport to product classification. Aligned with UNTP DPP-02.rdfs:comment : Lie un ProductPassport à une classification produit. Aligné avec UNTP DPP-02.</para>
    ///   <para>rdfs:label : a pour classification produitrdfs:label : has product classification</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasProductClassification">dpp:hasProductClassification</a>
    /// </summary>
    let hasProductClassification = _prefixId.prefix "hasProductClassification"
    /// <summary>
    ///   <para>rdfs:comment : Lie un ProductPassport à des Consignes de Recyclage.rdfs:comment : Links a ProductPassport to RecyclingInstructions.</para>
    ///   <para>rdfs:label : a pour consignes de recyclagerdfs:label : has recycling instructions</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasRecyclingInstructions">dpp:hasRecyclingInstructions</a>
    /// </summary>
    let hasRecyclingInstructions = _prefixId.prefix "hasRecyclingInstructions"
    /// <summary>
    ///   <para>rdfs:comment : Lie une Intervention à son Réparateur.rdfs:comment : Links an Intervention to its Repairer.</para>
    ///   <para>rdfs:label : a pour réparateurrdfs:label : has repairer</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasRepairer">dpp:hasRepairer</a>
    /// </summary>
    let hasRepairer = _prefixId.prefix "hasRepairer"
    /// <summary>
    ///   <para>rdfs:comment : Lie une Intervention à une Pièce de Rechange.rdfs:comment : Links an Intervention to a ReplacementPart.</para>
    ///   <para>rdfs:label : a pour pièce de rechangerdfs:label : has replacement part</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasReplacementPart">dpp:hasReplacementPart</a>
    /// </summary>
    let hasReplacementPart = _prefixId.prefix "hasReplacementPart"
    /// <summary>
    ///   <para>rdfs:comment : Lie un ProductPassport à son Distributeur.rdfs:comment : Links a ProductPassport to its Retailer.</para>
    ///   <para>rdfs:label : a pour distributeurrdfs:label : has retailer</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasRetailer">dpp:hasRetailer</a>
    /// </summary>
    let hasRetailer = _prefixId.prefix "hasRetailer"
    /// <summary>
    ///   <para>rdfs:comment : Lie un ProductPassport à une action SecureDataShare via EU Business Wallet (EBW).rdfs:comment : Links a ProductPassport to a SecureDataShare action via EU Business Wallet (EBW).</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : has secure data sharerdfs:label : a pour partage de données sécurisé</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasSecureDataShare">dpp:hasSecureDataShare</a>
    /// </summary>
    let hasSecureDataShare = _prefixId.prefix "hasSecureDataShare"
    /// <summary>
    ///   <para>rdfs:comment : Lie un ProductPassport à une Demande de Service.rdfs:comment : Links a ProductPassport to a ServiceRequest.</para>
    ///   <para>rdfs:label : a pour demande de servicerdfs:label : has service request</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasServiceRequest">dpp:hasServiceRequest</a>
    /// </summary>
    let hasServiceRequest = _prefixId.prefix "hasServiceRequest"
    /// <summary>
    ///   <para>rdfs:comment : Links a ProductPassport or TraceabilityPerformance to a traceability event. Aligned with UNTP DPP-06.rdfs:comment : Lie un ProductPassport ou TraceabilityPerformance à un événement de traçabilité. Aligné avec UNTP DPP-06.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : a pour événement de traçabilitérdfs:label : has traceability event</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasTraceabilityEvent">dpp:hasTraceabilityEvent</a>
    /// </summary>
    let hasTraceabilityEvent = _prefixId.prefix "hasTraceabilityEvent"
    /// <summary>
    ///   <para>rdfs:comment : Lie un ProductPassport à des informations de traçabilité. Aligné avec UNTP DPP-06.rdfs:comment : Links a ProductPassport to traceability information. Aligned with UNTP DPP-06.</para>
    ///   <para>rdfs:label : a pour information traçabilitérdfs:label : has traceability information</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasTraceabilityInformation">dpp:hasTraceabilityInformation</a>
    /// </summary>
    let hasTraceabilityInformation = _prefixId.prefix "hasTraceabilityInformation"
    /// <summary>
    ///   <para>rdfs:comment : Lie un VerifiableProductPassport ou ConformityClaim à son W3C Verifiable Credential (VCDM 2.0) stocké dans EU Business Wallet (EBW).rdfs:comment : Links a VerifiableProductPassport or ConformityClaim to its W3C Verifiable Credential (VCDM 2.0) stored in EU Business Wallet (EBW).</para>
    ///   <para>rdfs:label : a pour credential vérifiablerdfs:label : has verifiable credential</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasVerifiableCredential">dpp:hasVerifiableCredential</a>
    /// </summary>
    let hasVerifiableCredential = _prefixId.prefix "hasVerifiableCredential"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates whether the EconomicOperator's identity has been verified via EU Business Wallet (EBW).rdfs:comment : Indique si l'identité de l'Opérateur Économique a été vérifiée via EU Business Wallet (EBW).</para>
    ///   <para>rdfs:label : a identité vérifiéerdfs:label : has verified identity</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasVerifiedIdentity">dpp:hasVerifiedIdentity</a>
    /// </summary>
    let hasVerifiedIdentity = _prefixId.prefix "hasVerifiedIdentity"
    /// <summary>
    ///   <para>rdfs:comment : Lie un ProductPassport à sa Garantie.rdfs:comment : Links a ProductPassport to its Warranty.</para>
    ///   <para>rdfs:label : a pour garantierdfs:label : has warranty</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasWarranty">dpp:hasWarranty</a>
    /// </summary>
    let hasWarranty = _prefixId.prefix "hasWarranty"
    /// <summary>
    ///   <para>rdfs:comment : Lie un ProductPassport à une Réclamation de Garantie.rdfs:comment : Links a ProductPassport to a WarrantyClaim.</para>
    ///   <para>rdfs:label : a pour réclamationrdfs:label : has warranty claim</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasWarrantyClaim">dpp:hasWarrantyClaim</a>
    /// </summary>
    let hasWarrantyClaim = _prefixId.prefix "hasWarrantyClaim"
    /// <summary>
    ///   <para>rdfs:comment : Lie un ProductPassport à un Ordre de Travail.rdfs:comment : Links a ProductPassport to a WorkOrder.</para>
    ///   <para>rdfs:label : a pour ordre de travailrdfs:label : has work order</para>
    ///   <a href="https://ns.verisav.fr/dpp#hasWorkOrder">dpp:hasWorkOrder</a>
    /// </summary>
    let hasWorkOrder = _prefixId.prefix "hasWorkOrder"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Digest de hash pour vérification de l'intégrité du lien.rdfs:comment : Hash digest for verification of link integrity.</para>
    ///   <para>rdfs:label : digest de hashrdfs:label : hash digest</para>
    ///   <a href="https://ns.verisav.fr/dpp#hashDigest">dpp:hashDigest</a>
    /// </summary>
    let hashDigest = _prefixId.prefix "hashDigest"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Méthode utilisée pour le hash (ex: 'SHA-256', 'SHA-512').rdfs:comment : Method used for hashing (e.g., 'SHA-256', 'SHA-512').</para>
    ///   <para>rdfs:label : méthode de hashrdfs:label : hash method</para>
    ///   <a href="https://ns.verisav.fr/dpp#hashMethod">dpp:hashMethod</a>
    /// </summary>
    let hashMethod = _prefixId.prefix "hashMethod"
    /// <summary>
    ///   <para>rdfs:comment : La durée de l'intervention en minutes.rdfs:comment : The duration of the intervention in minutes.</para>
    ///   <para>rdfs:label : durée d'interventionrdfs:label : intervention duration</para>
    ///   <a href="https://ns.verisav.fr/dpp#interventionDuration">dpp:interventionDuration</a>
    /// </summary>
    let interventionDuration = _prefixId.prefix "interventionDuration"
    /// <summary>
    ///   <para>rdfs:comment : La date et heure de fin de l'intervention.rdfs:comment : The end date and time of the intervention.</para>
    ///   <para>rdfs:label : date de fin d'interventionrdfs:label : intervention end date</para>
    ///   <a href="https://ns.verisav.fr/dpp#interventionEndDate">dpp:interventionEndDate</a>
    /// </summary>
    let interventionEndDate = _prefixId.prefix "interventionEndDate"
    /// <summary>
    ///   <para>rdfs:comment : La date et heure de début de l'intervention.rdfs:comment : The start date and time of the intervention.</para>
    ///   <para>rdfs:label : date de début d'interventionrdfs:label : intervention start date</para>
    ///   <a href="https://ns.verisav.fr/dpp#interventionStartDate">dpp:interventionStartDate</a>
    /// </summary>
    let interventionStartDate = _prefixId.prefix "interventionStartDate"
    /// <summary>
    ///   <para>rdfs:comment : Le type d'intervention (diagnostic, réparation, maintenance, remplacement, retour fabricant).rdfs:comment : The type of intervention (diagnostic, reparation, maintenance, remplacement, retour_fabricant).</para>
    ///   <para>rdfs:label : type d'interventionrdfs:label : intervention type</para>
    ///   <a href="https://ns.verisav.fr/dpp#interventionType">dpp:interventionType</a>
    /// </summary>
    let interventionType = _prefixId.prefix "interventionType"
    /// <summary>
    ///   <para>rdfs:label : issue daterdfs:label : date de publication</para>
    ///   <para>rdfs:comment : Date when the standard or regulation was issued.rdfs:comment : Date à laquelle le standard ou réglementation a été publié.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#issueDate">dpp:issueDate</a>
    /// </summary>
    let issueDate = _prefixId.prefix "issueDate"
    /// <summary>
    ///   <para>rdfs:comment : Links a VerifiableProductPassport to the EconomicOperator that issued it via EU Business Wallet (EBW).rdfs:comment : Lie un VerifiableProductPassport à l'Opérateur Économique qui l'a émis via EU Business Wallet (EBW).</para>
    ///   <para>rdfs:label : issued byrdfs:label : émis par</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#issuedBy">dpp:issuedBy</a>
    /// </summary>
    let issuedBy = _prefixId.prefix "issuedBy"
    /// <summary>
    ///   <para>rdfs:comment : Organisation qui a publié le standard ou réglementation.rdfs:comment : Organization that issued the standard or regulation.</para>
    ///   <para>rdfs:label : issuing partyrdfs:label : partie émettrice</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#issuingParty">dpp:issuingParty</a>
    /// </summary>
    let issuingParty = _prefixId.prefix "issuingParty"
    /// <summary>
    ///   <para>rdfs:comment : Le coût de la main d'œuvre pour l'intervention.rdfs:comment : The cost of labor for the intervention.</para>
    ///   <para>rdfs:label : coût main d'œuvrerdfs:label : labor cost</para>
    ///   <a href="https://ns.verisav.fr/dpp#laborCost">dpp:laborCost</a>
    /// </summary>
    let laborCost = _prefixId.prefix "laborCost"
    /// <summary>
    ///   <para>rdfs:comment : La date à laquelle le produit est entré dans cette étape du cycle de vie.rdfs:comment : The date when the product entered this lifecycle stage.</para>
    ///   <para>rdfs:label : date de l'étape du cycle de vierdfs:label : lifecycle stage date</para>
    ///   <a href="https://ns.verisav.fr/dpp#lifecycleStageDate">dpp:lifecycleStageDate</a>
    /// </summary>
    let lifecycleStageDate = _prefixId.prefix "lifecycleStageDate"
    /// <summary>
    ///   <para>rdfs:comment : Le nom de l'étape du cycle de vie (fabrication, achat, usage, fin de vie, recyclage).rdfs:comment : The name of the lifecycle stage (manufacturing, purchase, usage, end_of_life, recycling).</para>
    ///   <para>rdfs:label : nom de l'étape du cycle de vierdfs:label : lifecycle stage name</para>
    ///   <a href="https://ns.verisav.fr/dpp#lifecycleStageName">dpp:lifecycleStageName</a>
    /// </summary>
    let lifecycleStageName = _prefixId.prefix "lifecycleStageName"
    /// <summary>
    ///   <para>rdfs:comment : Nom lisible par humain pour le lien.rdfs:comment : Human-readable name for the link.</para>
    ///   <para>rdfs:label : link namerdfs:label : nom du lien</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#linkName">dpp:linkName</a>
    /// </summary>
    let linkName = _prefixId.prefix "linkName"
    /// <summary>
    ///   <para>rdfs:label : type de lienrdfs:label : link type</para>
    ///   <para>rdfs:comment : Identifiant de type pour le lien (ex: URI vers un terme de vocabulaire).rdfs:comment : Type identifier for the link (e.g., URI to a vocabulary term).</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#linkType">dpp:linkType</a>
    /// </summary>
    let linkType = _prefixId.prefix "linkType"
    /// <summary>
    ///   <para>rdfs:comment : URL or link to a resource.rdfs:comment : URL ou lien vers une ressource.</para>
    ///   <para>rdfs:label : link URLrdfs:label : URL du lien</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#linkURL">dpp:linkURL</a>
    /// </summary>
    let linkURL = _prefixId.prefix "linkURL"
    /// <summary>
    ///   <para>rdfs:comment : La date à laquelle le produit a été fabriqué.rdfs:comment : The date when the product was manufactured.</para>
    ///   <para>rdfs:label : date de fabricationrdfs:label : manufacturing date</para>
    ///   <a href="https://ns.verisav.fr/dpp#manufacturingDate">dpp:manufacturingDate</a>
    /// </summary>
    let manufacturingDate = _prefixId.prefix "manufacturingDate"
    /// <summary>
    ///   <para>rdfs:comment : Le lieu où le produit a été fabriqué.rdfs:comment : The location where the product was manufactured.</para>
    ///   <para>rdfs:label : lieu de fabricationrdfs:label : manufacturing location</para>
    ///   <a href="https://ns.verisav.fr/dpp#manufacturingLocation">dpp:manufacturingLocation</a>
    /// </summary>
    let manufacturingLocation = _prefixId.prefix "manufacturingLocation"
    /// <summary>
    ///   <para>rdfs:comment : Mass fraction of the material in the product (decimal value between 0 and 1).rdfs:comment : Fraction massique du matériau dans le produit (valeur décimale entre 0 et 1).</para>
    ///   <para>rdfs:label : mass fractionrdfs:label : fraction massique</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#massFraction">dpp:massFraction</a>
    /// </summary>
    let massFraction = _prefixId.prefix "massFraction"
    /// <summary>
    ///   <para>rdfs:label : material circularity indicatorrdfs:label : indicateur de circularité matérielle</para>
    ///   <para>rdfs:comment : Overall circularity score (MCI) calculated as 1 - (V + W) / (2 * D), where V = virgin material proportion, W = waste leakage proportion, D = utility factor (0-1).rdfs:comment : Score global de circularité (MCI) calculé comme 1 - (V + W) / (2 * D), où V = proportion matériaux vierges, W = proportion pertes, D = facteur d'utilité (0-1).</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#materialCircularityIndicator">dpp:materialCircularityIndicator</a>
    /// </summary>
    let materialCircularityIndicator = _prefixId.prefix "materialCircularityIndicator"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Nom du matériau (ex: 'Aluminium', 'Acier', 'Plastique').rdfs:comment : Name of the material (e.g., 'Aluminum', 'Steel', 'Plastic').</para>
    ///   <para>rdfs:label : nom du matériaurdfs:label : material name</para>
    ///   <a href="https://ns.verisav.fr/dpp#materialName">dpp:materialName</a>
    /// </summary>
    let materialName = _prefixId.prefix "materialName"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Nom de la métrique (ex: 'Intensité Émissions GES').rdfs:comment : Name of the metric (e.g., 'GHG Emissions Intensity').</para>
    ///   <para>rdfs:label : nom de la métriquerdfs:label : metric name</para>
    ///   <a href="https://ns.verisav.fr/dpp#metricName">dpp:metricName</a>
    /// </summary>
    let metricName = _prefixId.prefix "metricName"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Valeur de la métrique avec unité.rdfs:comment : Value of the metric with unit.</para>
    ///   <para>rdfs:label : valeur de la métriquerdfs:label : metric value</para>
    ///   <a href="https://ns.verisav.fr/dpp#metricValue">dpp:metricValue</a>
    /// </summary>
    let metricValue = _prefixId.prefix "metricValue"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Périmètre du calcul d'émissions (ex: 'CradleToGate', 'CradleToGrave', 'GateToGate').rdfs:comment : Scope of emissions calculation (e.g., 'CradleToGate', 'CradleToGrave', 'GateToGate').</para>
    ///   <para>rdfs:label : périmètre opérationnelrdfs:label : operational scope</para>
    ///   <a href="https://ns.verisav.fr/dpp#operationalScope">dpp:operationalScope</a>
    /// </summary>
    let operationalScope = _prefixId.prefix "operationalScope"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Code pays d'origine du matériau (ISO 3166-1 alpha-2 ou alpha-3).rdfs:comment : Origin country code of the material (ISO 3166-1 alpha-2 or alpha-3).</para>
    ///   <para>rdfs:label : pays d'originerdfs:label : origin country</para>
    ///   <a href="https://ns.verisav.fr/dpp#originCountry">dpp:originCountry</a>
    /// </summary>
    let originCountry = _prefixId.prefix "originCountry"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Région spécifique d'origine du matériau (optionnel).rdfs:comment : Specific region of origin for the material (optional).</para>
    ///   <para>rdfs:label : région d'originerdfs:label : origin region</para>
    ///   <a href="https://ns.verisav.fr/dpp#originRegion">dpp:originRegion</a>
    /// </summary>
    let originRegion = _prefixId.prefix "originRegion"
    /// <summary>
    ///   <para>rdfs:comment : Le nom de la pièce de rechange.rdfs:comment : The name of the replacement part.</para>
    ///   <para>rdfs:label : nom de la piècerdfs:label : part name</para>
    ///   <a href="https://ns.verisav.fr/dpp#partName">dpp:partName</a>
    /// </summary>
    let partName = _prefixId.prefix "partName"
    /// <summary>
    ///   <para>rdfs:comment : Le numéro de référence de la pièce de rechange.rdfs:comment : The reference number of the replacement part.</para>
    ///   <para>rdfs:label : référence de piècerdfs:label : part reference</para>
    ///   <a href="https://ns.verisav.fr/dpp#partReference">dpp:partReference</a>
    /// </summary>
    let partReference = _prefixId.prefix "partReference"
    /// <summary>
    ///   <para>rdfs:comment : Le coût des pièces de rechange pour l'intervention.rdfs:comment : The cost of replacement parts for the intervention.</para>
    ///   <para>rdfs:label : coût des piècesrdfs:label : parts cost</para>
    ///   <a href="https://ns.verisav.fr/dpp#partsCost">dpp:partsCost</a>
    /// </summary>
    let partsCost = _prefixId.prefix "partsCost"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Ratio de matériaux provenant de sources primaires (0-1).rdfs:comment : Ratio of materials from primary sources (0-1).</para>
    ///   <para>rdfs:label : ratio de sourcing primairerdfs:label : primary sourced ratio</para>
    ///   <a href="https://ns.verisav.fr/dpp#primarySourcedRatio">dpp:primarySourcedRatio</a>
    /// </summary>
    let primarySourcedRatio = _prefixId.prefix "primarySourcedRatio"
    /// <summary>
    ///   <para>rdfs:comment : Le statut du produit (sous garantie, hors garantie, contrat maintenance, en panne, réparé).rdfs:comment : The status of the product (sous_garantie, hors_garantie, contrat_maintenance, en_panne, repare).</para>
    ///   <para>rdfs:label : statut du produitrdfs:label : product status</para>
    ///   <a href="https://ns.verisav.fr/dpp#productStatus">dpp:productStatus</a>
    /// </summary>
    let productStatus = _prefixId.prefix "productStatus"
    /// <summary>
    ///   <para>rdfs:comment : La date à laquelle le statut du produit a été défini.rdfs:comment : The date when the product status was set.</para>
    ///   <para>rdfs:label : date du statut produitrdfs:label : product status date</para>
    ///   <a href="https://ns.verisav.fr/dpp#productStatusDate">dpp:productStatusDate</a>
    /// </summary>
    let productStatusDate = _prefixId.prefix "productStatusDate"
    /// <summary>
    ///   <para>rdfs:comment : La date à laquelle le produit a été acheté.rdfs:comment : The date when the product was purchased.</para>
    ///   <para>rdfs:label : date d'achatrdfs:label : purchase date</para>
    ///   <a href="https://ns.verisav.fr/dpp#purchaseDate">dpp:purchaseDate</a>
    /// </summary>
    let purchaseDate = _prefixId.prefix "purchaseDate"
    /// <summary>
    ///   <para>rdfs:comment : Le prix payé pour le produit.rdfs:comment : The price paid for the product.</para>
    ///   <para>rdfs:label : prix d'achatrdfs:label : purchase price</para>
    ///   <a href="https://ns.verisav.fr/dpp#purchasePrice">dpp:purchasePrice</a>
    /// </summary>
    let purchasePrice = _prefixId.prefix "purchasePrice"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Proportion de la masse du produit conçue pour être recyclable ou réutilisable (0-1).rdfs:comment : Proportion of product mass designed to be recyclable or reusable (0-1).</para>
    ///   <para>rdfs:label : contenu recyclablerdfs:label : recyclable content</para>
    ///   <a href="https://ns.verisav.fr/dpp#recyclableContent">dpp:recyclableContent</a>
    /// </summary>
    let recyclableContent = _prefixId.prefix "recyclableContent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Proportion de la masse du produit faite de matériaux recyclés ou réutilisés (0-1).rdfs:comment : Proportion of product mass made from recycled or repurposed materials (0-1).</para>
    ///   <para>rdfs:label : contenu recyclérdfs:label : recycled content</para>
    ///   <a href="https://ns.verisav.fr/dpp#recycledContent">dpp:recycledContent</a>
    /// </summary>
    let recycledContent = _prefixId.prefix "recycledContent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Réglementation de référence pour la déclaration de conformité.rdfs:comment : Reference regulation for the conformity claim.</para>
    ///   <para>rdfs:label : référence réglementationrdfs:label : reference regulation</para>
    ///   <a href="https://ns.verisav.fr/dpp#referenceRegulation">dpp:referenceRegulation</a>
    /// </summary>
    let referenceRegulation = _prefixId.prefix "referenceRegulation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Standard de référence pour la déclaration de conformité.rdfs:comment : Reference standard for the conformity claim.</para>
    ///   <para>rdfs:label : référence standardrdfs:label : reference standard</para>
    ///   <a href="https://ns.verisav.fr/dpp#referenceStandard">dpp:referenceStandard</a>
    /// </summary>
    let referenceStandard = _prefixId.prefix "referenceStandard"
    /// <summary>
    ///   <para>rdfs:comment : Lien vers instructions de réparation pour utilisateurs finaux ou centres de service de réparation.rdfs:comment : Link to repair instructions for end users or repair service centers.</para>
    ///   <para>rdfs:label : repair informationrdfs:label : information réparation</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#repairInformation">dpp:repairInformation</a>
    /// </summary>
    let repairInformation = _prefixId.prefix "repairInformation"
    /// <summary>
    ///   <para>rdfs:comment : Le statut d'un événement de réparation (en attente, en cours, complété, échoué).rdfs:comment : The status of a repair event (pending, in_progress, completed, failed).</para>
    ///   <para>rdfs:label : statut de réparationrdfs:label : repair status</para>
    ///   <a href="https://ns.verisav.fr/dpp#repairStatus">dpp:repairStatus</a>
    /// </summary>
    let repairStatus = _prefixId.prefix "repairStatus"
    /// <summary>
    ///   <para>rdfs:comment : Lie une Pièce de Rechange à la pièce originale qu'elle remplace.rdfs:comment : Links a ReplacementPart to the original part it replaces.</para>
    ///   <para>rdfs:label : remplacerdfs:label : replaces</para>
    ///   <a href="https://ns.verisav.fr/dpp#replaces">dpp:replaces</a>
    /// </summary>
    let replaces = _prefixId.prefix "replaces"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Standard utilisé pour le reporting des émissions.rdfs:comment : Standard used for emissions reporting.</para>
    ///   <para>rdfs:label : standard de reportingrdfs:label : reporting standard</para>
    ///   <a href="https://ns.verisav.fr/dpp#reportingStandard">dpp:reportingStandard</a>
    /// </summary>
    let reportingStandard = _prefixId.prefix "reportingStandard"
    /// <summary>
    ///   <para>rdfs:comment : Une description de la façon dont le problème a été résolu.rdfs:comment : A description of how the issue was resolved.</para>
    ///   <para>rdfs:label : description de la résolutionrdfs:label : resolution description</para>
    ///   <a href="https://ns.verisav.fr/dpp#resolutionDescription">dpp:resolutionDescription</a>
    /// </summary>
    let resolutionDescription = _prefixId.prefix "resolutionDescription"
    /// <summary>
    ///   <para>rdfs:comment : Le numéro de série du produit.rdfs:comment : The serial number of the product.</para>
    ///   <para>rdfs:label : numéro de sérierdfs:label : serial number</para>
    ///   <a href="https://ns.verisav.fr/dpp#serialNumber">dpp:serialNumber</a>
    /// </summary>
    let serialNumber = _prefixId.prefix "serialNumber"
    /// <summary>
    ///   <para>rdfs:label : shared withrdfs:label : partagé avec</para>
    ///   <para>rdfs:comment : Lie un SecureDataShare à l'Opérateur Économique avec qui les données DPP sont partagées via EU Business Wallet (EBW).rdfs:comment : Links a SecureDataShare to the EconomicOperator with whom DPP data is shared via EU Business Wallet (EBW).</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#sharedWith">dpp:sharedWith</a>
    /// </summary>
    let sharedWith = _prefixId.prefix "sharedWith"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Identifiant unique du standard (URI ou chaîne).rdfs:comment : Unique identifier for the standard (URI or string).</para>
    ///   <para>rdfs:label : ID standardrdfs:label : standard ID</para>
    ///   <a href="https://ns.verisav.fr/dpp#standardId">dpp:standardId</a>
    /// </summary>
    let standardId = _prefixId.prefix "standardId"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Nom du standard.rdfs:comment : Name of the standard.</para>
    ///   <para>rdfs:label : nom du standardrdfs:label : standard name</para>
    ///   <a href="https://ns.verisav.fr/dpp#standardName">dpp:standardName</a>
    /// </summary>
    let standardName = _prefixId.prefix "standardName"
    /// <summary>
    ///   <para>rdfs:comment : Le coût total de l'intervention (main d'œuvre + pièces).rdfs:comment : The total cost of the intervention (labor + parts).</para>
    ///   <para>rdfs:label : coût totalrdfs:label : total cost</para>
    ///   <a href="https://ns.verisav.fr/dpp#totalCost">dpp:totalCost</a>
    /// </summary>
    let totalCost = _prefixId.prefix "totalCost"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Durabilité du produit relative à la moyenne de l'industrie (ex: 1.2 = 20% plus durable).rdfs:comment : Product durability relative to industry average (e.g., 1.2 = 20% more durable).</para>
    ///   <para>rdfs:label : facteur d'utilitérdfs:label : utility factor</para>
    ///   <a href="https://ns.verisav.fr/dpp#utilityFactor">dpp:utilityFactor</a>
    /// </summary>
    let utilityFactor = _prefixId.prefix "utilityFactor"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Description lisible par humain de l'étape spécifique de la chaîne de valeur (ex: 'Mise en conserve', 'Assemblage').rdfs:comment : Human-readable description of the specific value chain step (e.g., 'Canning', 'Assembly').</para>
    ///   <para>rdfs:label : processus chaîne de valeurrdfs:label : value chain process</para>
    ///   <a href="https://ns.verisav.fr/dpp#valueChainProcess">dpp:valueChainProcess</a>
    /// </summary>
    let valueChainProcess = _prefixId.prefix "valueChainProcess"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Proportion de matériaux ou composants dans cette étape qui ont été tracés de manière vérifiable avec des événements de traçabilité numériques (0-1).rdfs:comment : Proportion of materials or components in this step that have been verifiably traced using digital traceability events (0-1).</para>
    ///   <para>rdfs:label : ratio vérifiérdfs:label : verified ratio</para>
    ///   <a href="https://ns.verisav.fr/dpp#verifiedRatio">dpp:verifiedRatio</a>
    /// </summary>
    let verifiedRatio = _prefixId.prefix "verifiedRatio"
    /// <summary>
    ///   <para>rdfs:comment : The GTIN version number (GS1 AI 22) for product changes that do not require a GTIN change per GTIN Management Standard.rdfs:comment : Le numéro de version GTIN (GS1 AI 22) pour les changements de produit qui ne nécessitent pas un changement de GTIN selon le GTIN Management Standard.</para>
    ///   <para>rdfs:label : Version Numberrdfs:label : Numéro de Version</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="https://ns.verisav.fr/dpp#versionNumber">dpp:versionNumber</a>
    /// </summary>
    let versionNumber = _prefixId.prefix "versionNumber"
    /// <summary>
    ///   <para>rdfs:comment : La durée de la garantie en mois.rdfs:comment : The duration of the warranty in months.</para>
    ///   <para>rdfs:label : durée de garantie en moisrdfs:label : warranty duration in months</para>
    ///   <a href="https://ns.verisav.fr/dpp#warrantyDurationMonths">dpp:warrantyDurationMonths</a>
    /// </summary>
    let warrantyDurationMonths = _prefixId.prefix "warrantyDurationMonths"
    /// <summary>
    ///   <para>rdfs:comment : La date de fin de la garantie.rdfs:comment : The end date of the warranty.</para>
    ///   <para>rdfs:label : date de fin de garantierdfs:label : warranty end date</para>
    ///   <a href="https://ns.verisav.fr/dpp#warrantyEndDate">dpp:warrantyEndDate</a>
    /// </summary>
    let warrantyEndDate = _prefixId.prefix "warrantyEndDate"
    /// <summary>
    ///   <para>rdfs:comment : La date de début de la garantie.rdfs:comment : The start date of the warranty.</para>
    ///   <para>rdfs:label : date de début de garantierdfs:label : warranty start date</para>
    ///   <a href="https://ns.verisav.fr/dpp#warrantyStartDate">dpp:warrantyStartDate</a>
    /// </summary>
    let warrantyStartDate = _prefixId.prefix "warrantyStartDate"
    /// <summary>
    ///   <para>rdfs:comment : Le statut de la garantie (active, expirée, suspendue, annulée).rdfs:comment : The status of the warranty (active, expiree, suspendue, annulee).</para>
    ///   <para>rdfs:label : statut de garantierdfs:label : warranty status</para>
    ///   <a href="https://ns.verisav.fr/dpp#warrantyStatus">dpp:warrantyStatus</a>
    /// </summary>
    let warrantyStatus = _prefixId.prefix "warrantyStatus"
    /// <summary>
    ///   <para>rdfs:comment : Le type de garantie (constructeur, distributeur, extension, maintenance).rdfs:comment : The type of warranty (constructeur, retailer, extension, maintenance).</para>
    ///   <para>rdfs:label : type de garantierdfs:label : warranty type</para>
    ///   <a href="https://ns.verisav.fr/dpp#warrantyType">dpp:warrantyType</a>
    /// </summary>
    let warrantyType = _prefixId.prefix "warrantyType"
    /// <summary>
    ///   <para>rdfs:comment : L'identifiant unique de l'ordre de travail.rdfs:comment : The unique identifier for the work order.</para>
    ///   <para>rdfs:label : numéro d'ordre de travailrdfs:label : work order number</para>
    ///   <a href="https://ns.verisav.fr/dpp#workOrderNumber">dpp:workOrderNumber</a>
    /// </summary>
    let workOrderNumber = _prefixId.prefix "workOrderNumber"
    /// <summary>
    ///   <para>rdfs:comment : La priorité de l'ordre de travail (basse, normale, haute, urgente).rdfs:comment : The priority of the work order (basse, normale, haute, urgente).</para>
    ///   <para>rdfs:label : priorité de l'ordre de travailrdfs:label : work order priority</para>
    ///   <a href="https://ns.verisav.fr/dpp#workOrderPriority">dpp:workOrderPriority</a>
    /// </summary>
    let workOrderPriority = _prefixId.prefix "workOrderPriority"
    /// <summary>
    ///   <para>rdfs:comment : Le statut de l'ordre de travail (créé, assigné, en cours, en attente de pièces, complété, facturé, annulé).rdfs:comment : The status of the work order (cree, assigne, en_cours, en_attente_pieces, complete, facture, annule).</para>
    ///   <para>rdfs:label : statut de l'ordre de travailrdfs:label : work order status</para>
    ///   <a href="https://ns.verisav.fr/dpp#workOrderStatus">dpp:workOrderStatus</a>
    /// </summary>
    let workOrderStatus = _prefixId.prefix "workOrderStatus"
