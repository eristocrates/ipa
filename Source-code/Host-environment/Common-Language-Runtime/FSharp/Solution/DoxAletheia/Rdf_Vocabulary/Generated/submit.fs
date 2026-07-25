namespace https.ns.verisav.fr.dpp.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module submit =
    let _namespace_iri = Namespace_Iri submit |> NamespaceIRI
    /// <summary>
    ///   <para>submit:ServiceRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A request for after-sales service (SAV) for a product.</para>
    ///   <para>Une demande de service après-vente (SAV) pour un produit.</para>
    /// labels<para>Demande de Service</para><para>Service Request</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#ServiceRequest">https://ns.verisav.fr/dpp#ServiceRequest</seealso>
    let ServiceRequest = Prefixed_Name(submit, "ServiceRequest") |> PrefixedName

    /// <summary>
    ///   <para>submit:ProductClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Classification d'un produit selon un schéma standardisé (UN-CPC, GS1, NACE, etc.). Aligné avec UNTP DPP-02.</para>
    ///   <para>Product classification according to a standardized scheme (UN-CPC, GS1, NACE, etc.). Aligned with UNTP DPP-02.</para>
    /// labels<para>Classification Produit</para><para>Product Classification</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#ProductClassification">https://ns.verisav.fr/dpp#ProductClassification</seealso>
    let ProductClassification =
        Prefixed_Name(submit, "ProductClassification") |> PrefixedName

    /// <summary>
    ///   <para>submit:ProductStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The current status of a product (under warranty, out of warranty, broken, repaired, etc.).</para>
    ///   <para>Le statut actuel d'un produit (sous garantie, hors garantie, en panne, réparé, etc.).</para>
    /// labels<para>Statut Produit</para><para>Product Status</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#ProductStatus">https://ns.verisav.fr/dpp#ProductStatus</seealso>
    let ProductStatus = Prefixed_Name(submit, "ProductStatus") |> PrefixedName
    /// <summary>
    ///   <para>submit:Regulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Reference regulation for a conformity claim.</para>
    ///   <para>Réglementation de référence pour une déclaration de conformité.</para>
    /// labels<para>Réglementation</para><para>Regulation</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#Regulation">https://ns.verisav.fr/dpp#Regulation</seealso>
    let Regulation = Prefixed_Name(submit, "Regulation") |> PrefixedName
    /// <summary>
    ///   <para>submit:Repairer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Une personne ou organisation qui répare des produits.</para>
    ///   <para>A person or organization that repairs products.</para>
    /// labels<para>Réparateur</para><para>Repairer</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#Repairer">https://ns.verisav.fr/dpp#Repairer</seealso>
    let Repairer = Prefixed_Name(submit, "Repairer") |> PrefixedName
    /// <summary>
    ///   <para>submit:totalCost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The total cost of the intervention (labor + parts).</para>
    ///   <para>Le coût total de l'intervention (main d'œuvre + pièces).</para>
    /// labels<para>total cost</para><para>coût total</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#totalCost">https://ns.verisav.fr/dpp#totalCost</seealso>
    let totalCost = Prefixed_Name(submit, "totalCost") |> PrefixedName
    /// <summary>
    ///   <para>submit:versionNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Le numéro de version GTIN (GS1 AI 22) pour les changements de produit qui ne nécessitent pas un changement de GTIN selon le GTIN Management Standard.</para>
    ///   <para>The GTIN version number (GS1 AI 22) for product changes that do not require a GTIN change per GTIN Management Standard.</para>
    /// labels<para>Numéro de Version</para><para>Version Number</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#versionNumber">https://ns.verisav.fr/dpp#versionNumber</seealso>
    let versionNumber = Prefixed_Name(submit, "versionNumber") |> PrefixedName
    /// <summary>
    ///   <para>submit:warrantyStartDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The start date of the warranty.</para>
    ///   <para>La date de début de la garantie.</para>
    /// labels<para>date de début de garantie</para><para>warranty start date</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#warrantyStartDate">https://ns.verisav.fr/dpp#warrantyStartDate</seealso>
    let warrantyStartDate = Prefixed_Name(submit, "warrantyStartDate") |> PrefixedName
    /// <summary>
    ///   <para>submit:assessmentDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date à laquelle la déclaration a été évaluée.</para>
    ///   <para>Date when the claim was assessed.</para>
    /// labels<para>date d'évaluation</para><para>assessment date</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#assessmentDate">https://ns.verisav.fr/dpp#assessmentDate</seealso>
    let assessmentDate = Prefixed_Name(submit, "assessmentDate") |> PrefixedName
    /// <summary>
    ///   <para>submit:claimDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Une description de la demande de service ou réclamation.</para>
    ///   <para>A description of the service request or claim.</para>
    /// labels<para>description de la réclamation</para><para>claim description</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#claimDescription">https://ns.verisav.fr/dpp#claimDescription</seealso>
    let claimDescription = Prefixed_Name(submit, "claimDescription") |> PrefixedName
    /// <summary>
    ///   <para>submit:classificationCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Code de classification selon le schéma spécifié.</para>
    ///   <para>Classification code according to the specified scheme.</para>
    /// labels<para>code de classification</para><para>classification code</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#classificationCode">https://ns.verisav.fr/dpp#classificationCode</seealso>
    let classificationCode = Prefixed_Name(submit, "classificationCode") |> PrefixedName
    /// <summary>
    ///   <para>submit:Warranty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A warranty covering a product, which can be of different types (manufacturer, retailer, extension, maintenance).</para>
    ///   <para>Une garantie couvrant un produit, qui peut être de différents types (constructeur, distributeur, extension, maintenance).</para>
    /// labels<para>Garantie</para><para>Warranty</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#Warranty">https://ns.verisav.fr/dpp#Warranty</seealso>
    let Warranty = Prefixed_Name(submit, "Warranty") |> PrefixedName
    /// <summary>
    ///   <para>submit:WarrantyClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Une réclamation effectuée sous garantie.</para>
    ///   <para>A claim made under a warranty.</para>
    /// labels<para>Réclamation de Garantie</para><para>Warranty Claim</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#WarrantyClaim">https://ns.verisav.fr/dpp#WarrantyClaim</seealso>
    let WarrantyClaim = Prefixed_Name(submit, "WarrantyClaim") |> PrefixedName
    /// <summary>
    ///   <para>submit:WorkOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An order for work to be performed on a product (repair, maintenance, etc.).</para>
    ///   <para>Un ordre de travail à effectuer sur un produit (réparation, maintenance, etc.).</para>
    /// labels<para>Ordre de Travail</para><para>Work Order</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#WorkOrder">https://ns.verisav.fr/dpp#WorkOrder</seealso>
    let WorkOrder = Prefixed_Name(submit, "WorkOrder") |> PrefixedName
    /// <summary>
    ///   <para>submit:accuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Accuracy or uncertainty of the metric value (optional).</para>
    ///   <para>Précision ou incertitude de la valeur de la métrique (optionnel).</para>
    /// labels<para>précision</para><para>accuracy</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#accuracy">https://ns.verisav.fr/dpp#accuracy</seealso>
    let accuracy = Prefixed_Name(submit, "accuracy") |> PrefixedName
    /// <summary>
    ///   <para>submit:assessmentCriteria</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Critères dans le standard ou réglementation contre lesquels la déclaration est évaluée.</para>
    ///   <para>Criteria within the standard or regulation against which the claim is evaluated.</para>
    /// labels<para>critères d'évaluation</para><para>assessment criteria</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#assessmentCriteria">https://ns.verisav.fr/dpp#assessmentCriteria</seealso>
    let assessmentCriteria = Prefixed_Name(submit, "assessmentCriteria") |> PrefixedName
    /// <summary>
    ///   <para>submit:batchLotNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Le numéro de lot ou batch (GS1 AI 10) pour les lots de production. Utilisé avec GTIN pour la granularité au niveau lot.</para>
    ///   <para>The batch or lot number (GS1 AI 10) for production batches. Used with GTIN for batch-level granularity.</para>
    /// labels<para>Batch/Lot Number</para><para>Numéro de Lot</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#batchLotNumber">https://ns.verisav.fr/dpp#batchLotNumber</seealso>
    let batchLotNumber = Prefixed_Name(submit, "batchLotNumber") |> PrefixedName
    /// <summary>
    ///   <para>submit:belongsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse property: links a WorkOrder or Intervention to its ProductPassport.</para>
    ///   <para>Propriété inverse : lie un WorkOrder ou Intervention à son ProductPassport.</para>
    /// labels<para>appartient à</para><para>belongs to</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#belongsTo">https://ns.verisav.fr/dpp#belongsTo</seealso>
    let belongsTo = Prefixed_Name(submit, "belongsTo") |> PrefixedName
    /// <summary>
    ///   <para>submit:hasIntervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Lie un WorkOrder à une Intervention.</para>
    ///   <para>Links a WorkOrder to an Intervention.</para>
    /// labels<para>a pour intervention</para><para>has intervention</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasIntervention">https://ns.verisav.fr/dpp#hasIntervention</seealso>
    let hasIntervention = Prefixed_Name(submit, "hasIntervention") |> PrefixedName
    /// <summary>
    ///   <para>submit:hasWorkOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a ProductPassport to a WorkOrder.</para>
    ///   <para>Lie un ProductPassport à un Ordre de Travail.</para>
    /// labels<para>a pour ordre de travail</para><para>has work order</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasWorkOrder">https://ns.verisav.fr/dpp#hasWorkOrder</seealso>
    let hasWorkOrder = Prefixed_Name(submit, "hasWorkOrder") |> PrefixedName
    /// <summary>
    ///   <para>submit:carbonFootprint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Carbon footprint of the product in kg CO2eq per declared unit.</para>
    ///   <para>Empreinte carbone du produit en kg CO2eq par unité déclarée.</para>
    /// labels<para>empreinte carbone</para><para>carbon footprint</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#carbonFootprint">https://ns.verisav.fr/dpp#carbonFootprint</seealso>
    let carbonFootprint = Prefixed_Name(submit, "carbonFootprint") |> PrefixedName
    /// <summary>
    ///   <para>submit:claimPriority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La priorité de la demande de service (normal, haute, urgente).</para>
    ///   <para>The priority of the service request (normal, high, urgent).</para>
    /// labels<para>priorité de la réclamation</para><para>claim priority</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#claimPriority">https://ns.verisav.fr/dpp#claimPriority</seealso>
    let claimPriority = Prefixed_Name(submit, "claimPriority") |> PrefixedName

    /// <summary>
    ///   <para>submit:classificationScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>URI ou identifiant du schéma de classification (ex: 'UN-CPC', 'GS1', 'NACE').</para>
    ///   <para>URI or identifier of the classification scheme (e.g., 'UN-CPC', 'GS1', 'NACE').</para>
    /// labels<para>schéma de classification</para><para>classification scheme</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#classificationScheme">https://ns.verisav.fr/dpp#classificationScheme</seealso>
    let classificationScheme =
        Prefixed_Name(submit, "classificationScheme") |> PrefixedName

    /// <summary>
    ///   <para>submit:conformityEvidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Lien vers attestation de deuxième ou troisième partie, comme un Digital Conformity Credential UNTP, PDF, ou autre format de preuve.</para>
    ///   <para>Link to second or third party attestation, such as a UNTP Digital Conformity Credential, PDF, or other evidence format.</para>
    /// labels<para>preuve de conformité</para><para>conformity evidence</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#conformityEvidence">https://ns.verisav.fr/dpp#conformityEvidence</seealso>
    let conformityEvidence = Prefixed_Name(submit, "conformityEvidence") |> PrefixedName
    /// <summary>
    ///   <para>submit:conformityTopic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Catégorie thématique de la déclaration (ex: 'environment.emissions', 'social.working_conditions').</para>
    ///   <para>Topic category of the claim (e.g., 'environment.emissions', 'social.working_conditions').</para>
    /// labels<para>thème de conformité</para><para>conformity topic</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#conformityTopic">https://ns.verisav.fr/dpp#conformityTopic</seealso>
    let conformityTopic = Prefixed_Name(submit, "conformityTopic") |> PrefixedName
    /// <summary>
    ///   <para>submit:credentialIssuer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>L'autorité ou Opérateur Économique qui a émis un VerifiableCredential via EU Business Wallet (EBW).</para>
    ///   <para>The authority or EconomicOperator that issued a VerifiableCredential via EU Business Wallet (EBW).</para>
    /// labels<para>émetteur de credential</para><para>credential issuer</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#credentialIssuer">https://ns.verisav.fr/dpp#credentialIssuer</seealso>
    let credentialIssuer = Prefixed_Name(submit, "credentialIssuer") |> PrefixedName
    /// <summary>
    ///   <para>submit:criterionName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Nom du critère.</para>
    ///   <para>Name of the criterion.</para>
    /// labels<para>criterion name</para><para>nom du critère</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#criterionName">https://ns.verisav.fr/dpp#criterionName</seealso>
    let criterionName = Prefixed_Name(submit, "criterionName") |> PrefixedName
    /// <summary>
    ///   <para>submit:declaredUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Unit of measure for carbon footprint (e.g., 'KGM' for kg, 'C62' for unit).</para>
    ///   <para>Unité de mesure pour l'empreinte carbone (ex: 'KGM' pour kg, 'C62' pour unité).</para>
    /// labels<para>unité déclarée</para><para>declared unit</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#declaredUnit">https://ns.verisav.fr/dpp#declaredUnit</seealso>
    let declaredUnit = Prefixed_Name(submit, "declaredUnit") |> PrefixedName

    /// <summary>
    ///   <para>submit:diagnosticDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A description of the diagnostic process and findings.</para>
    ///   <para>Une description du processus de diagnostic et des résultats.</para>
    /// labels<para>description du diagnostic</para><para>diagnostic description</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#diagnosticDescription">https://ns.verisav.fr/dpp#diagnosticDescription</seealso>
    let diagnosticDescription =
        Prefixed_Name(submit, "diagnosticDescription") |> PrefixedName

    /// <summary>
    ///   <para>submit:encryptionMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Encryption method if applicable (e.g., 'AES', 'none').</para>
    ///   <para>Méthode de cryptage si applicable (ex: 'AES', 'none').</para>
    /// labels<para>méthode de cryptage</para><para>encryption method</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#encryptionMethod">https://ns.verisav.fr/dpp#encryptionMethod</seealso>
    let encryptionMethod = Prefixed_Name(submit, "encryptionMethod") |> PrefixedName
    /// <summary>
    ///   <para>submit:follows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an Intervention to a previous Intervention (creates a chain of interventions).</para>
    ///   <para>Lie une Intervention à une Intervention précédente (crée une chaîne d'interventions).</para>
    /// labels<para>follows</para><para>suit</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#follows">https://ns.verisav.fr/dpp#follows</seealso>
    let follows = Prefixed_Name(submit, "follows") |> PrefixedName

    /// <summary>
    ///   <para>submit:hasCircularityScorecard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Lie un ProductPassport à son tableau de bord de circularité. Aligné avec UNTP DPP.</para>
    ///   <para>Links a ProductPassport to its circularity scorecard. Aligned with UNTP DPP.</para>
    /// labels<para>a pour tableau de bord circularité</para><para>has circularity scorecard</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasCircularityScorecard">https://ns.verisav.fr/dpp#hasCircularityScorecard</seealso>
    let hasCircularityScorecard =
        Prefixed_Name(submit, "hasCircularityScorecard") |> PrefixedName

    /// <summary>
    ///   <para>submit:hasConformityClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Lie un ProductPassport à une déclaration de conformité. Aligné avec UNTP DPP.</para>
    ///   <para>Links a ProductPassport to a conformity claim. Aligned with UNTP DPP.</para>
    /// labels<para>a pour déclaration de conformité</para><para>has conformity claim</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasConformityClaim">https://ns.verisav.fr/dpp#hasConformityClaim</seealso>
    let hasConformityClaim = Prefixed_Name(submit, "hasConformityClaim") |> PrefixedName

    /// <summary>
    ///   <para>submit:hasConstituentProduct</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Link to a DPP of a constituent product in the value chain. Enables multi-level traceability.</para>
    ///   <para>Lien vers un DPP de produit constituant dans la chaîne de valeur. Permet la traçabilité multi-niveau.</para>
    /// labels<para>a pour produit constituant</para><para>has constituent product</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasConstituentProduct">https://ns.verisav.fr/dpp#hasConstituentProduct</seealso>
    let hasConstituentProduct =
        Prefixed_Name(submit, "hasConstituentProduct") |> PrefixedName

    /// <summary>
    ///   <para>submit:hasConsumer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a ProductPassport to its Consumer.</para>
    ///   <para>Lie un ProductPassport à son Consommateur.</para>
    /// labels<para>a pour consommateur</para><para>has consumer</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasConsumer">https://ns.verisav.fr/dpp#hasConsumer</seealso>
    let hasConsumer = Prefixed_Name(submit, "hasConsumer") |> PrefixedName
    /// <summary>
    ///   <para>submit:hasCurrentStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a ProductPassport to its current ProductStatus.</para>
    ///   <para>Lie un ProductPassport à son ProductStatus actuel.</para>
    /// labels<para>a pour statut actuel</para><para>has current status</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasCurrentStatus">https://ns.verisav.fr/dpp#hasCurrentStatus</seealso>
    let hasCurrentStatus = Prefixed_Name(submit, "hasCurrentStatus") |> PrefixedName
    /// <summary>
    ///   <para>submit:hasDiagnostic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an Intervention to a Diagnostic.</para>
    ///   <para>Lie une Intervention à un Diagnostic.</para>
    /// labels<para>a pour diagnostic</para><para>has diagnostic</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasDiagnostic">https://ns.verisav.fr/dpp#hasDiagnostic</seealso>
    let hasDiagnostic = Prefixed_Name(submit, "hasDiagnostic") |> PrefixedName
    /// <summary>
    ///   <para>submit:hasDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Lie un ProductPassport à un Document.</para>
    ///   <para>Links a ProductPassport to a Document.</para>
    /// labels<para>a pour document</para><para>has document</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasDocument">https://ns.verisav.fr/dpp#hasDocument</seealso>
    let hasDocument = Prefixed_Name(submit, "hasDocument") |> PrefixedName

    /// <summary>
    ///   <para>submit:hasEmissionsScorecard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Lie un ProductPassport à son tableau de bord d'émissions. Aligné avec UNTP DPP.</para>
    ///   <para>Links a ProductPassport to its emissions scorecard. Aligned with UNTP DPP.</para>
    /// labels<para>a pour tableau de bord émissions</para><para>has emissions scorecard</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasEmissionsScorecard">https://ns.verisav.fr/dpp#hasEmissionsScorecard</seealso>
    let hasEmissionsScorecard =
        Prefixed_Name(submit, "hasEmissionsScorecard") |> PrefixedName

    /// <summary>
    ///   <para>submit:hasFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a ProductPassport to the Facility where it was produced.</para>
    ///   <para>Lie un ProductPassport à l'Installation où il a été produit.</para>
    /// labels<para>a pour installation</para><para>has facility</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasFacility">https://ns.verisav.fr/dpp#hasFacility</seealso>
    let hasFacility = Prefixed_Name(submit, "hasFacility") |> PrefixedName
    /// <summary>
    ///   <para>submit:hasGln</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The GS1 Global Location Number identifying the organization or facility. Used for economic operators and facilities per EU ESPR regulation.</para>
    ///   <para>Le Code Lieu International GS1 identifiant l'organisation ou l'installation. Utilisé pour les opérateurs économiques et installations selon la réglementation européenne ESPR.</para>
    /// labels<para>Code Lieu International (GLN)</para><para>Global Location Number (GLN)</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasGln">https://ns.verisav.fr/dpp#hasGln</seealso>
    let hasGln = Prefixed_Name(submit, "hasGln") |> PrefixedName
    /// <summary>
    ///   <para>submit:claimStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The status of a service request (soumise, en_cours, approuvee, resolue).</para>
    ///   <para>Le statut d'une demande de service (soumise, en cours, approuvée, résolue).</para>
    /// labels<para>statut de la réclamation</para><para>claim status</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#claimStatus">https://ns.verisav.fr/dpp#claimStatus</seealso>
    let claimStatus = Prefixed_Name(submit, "claimStatus") |> PrefixedName
    /// <summary>
    ///   <para>submit:conformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indique si le produit est conforme aux critères spécifiés (true/false).</para>
    ///   <para>Indicates whether the product meets the specified criteria (true/false).</para>
    /// labels<para>conformance</para><para>conformité</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#conformance">https://ns.verisav.fr/dpp#conformance</seealso>
    let conformance = Prefixed_Name(submit, "conformance") |> PrefixedName
    /// <summary>
    ///   <para>submit:criterionId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identifiant unique du critère (typiquement une URI).</para>
    ///   <para>Unique identifier for the criterion (typically a URI).</para>
    /// labels<para>criterion ID</para><para>ID critère</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#criterionId">https://ns.verisav.fr/dpp#criterionId</seealso>
    let criterionId = Prefixed_Name(submit, "criterionId") |> PrefixedName
    /// <summary>
    ///   <para>submit:dataIntegrityHash</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Digest de hash cryptographique garantissant l'intégrité des données DPP partagées via EU Business Wallet (EBW). Utilisé dans SecureDataShare pour la détection de falsification.</para>
    ///   <para>Cryptographic hash digest ensuring the integrity of shared DPP data via EU Business Wallet (EBW). Used in SecureDataShare for tamper detection.</para>
    /// labels<para>hash d'intégrité des données</para><para>data integrity hash</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#dataIntegrityHash">https://ns.verisav.fr/dpp#dataIntegrityHash</seealso>
    let dataIntegrityHash = Prefixed_Name(submit, "dataIntegrityHash") |> PrefixedName
    /// <summary>
    ///   <para>submit:declaredValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Valeurs mesurées réelles, incluant optionnellement la précision.</para>
    ///   <para>Actual measured values, optionally including accuracy.</para>
    /// labels<para>valeur déclarée</para><para>declared value</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#declaredValue">https://ns.verisav.fr/dpp#declaredValue</seealso>
    let declaredValue = Prefixed_Name(submit, "declaredValue") |> PrefixedName
    /// <summary>
    ///   <para>submit:diagnosticResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The result or conclusion of the diagnostic.</para>
    ///   <para>Le résultat ou conclusion du diagnostic.</para>
    /// labels<para>résultat du diagnostic</para><para>diagnostic result</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#diagnosticResult">https://ns.verisav.fr/dpp#diagnosticResult</seealso>
    let diagnosticResult = Prefixed_Name(submit, "diagnosticResult") |> PrefixedName
    /// <summary>
    ///   <para>submit:euid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The European Unique Identifier (EUID) for a legal entity, issued via EU Business Wallet (EBW). Provides a unified digital identity across all 27 EU member states.</para>
    ///   <para>L'Identifiant Unique Européen (EUID) pour une entité légale, émis via EU Business Wallet (EBW). Fournit une identité numérique unifiée dans les 27 États membres de l'UE.</para>
    /// labels<para>Identifiant Unique Européen (EUID)</para><para>European Unique Identifier (EUID)</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#euid">https://ns.verisav.fr/dpp#euid</seealso>
    let euid = Prefixed_Name(submit, "euid") |> PrefixedName
    /// <summary>
    ///   <para>submit:granularityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The level of identification granularity: 'model' (GTIN only), 'batch' (GTIN + batch/lot number), or 'serial' (GTIN + serial number). Determined by EU delegated acts per product category.</para>
    ///   <para>Le niveau de granularité d'identification : 'model' (GTIN seul), 'batch' (GTIN + numéro de lot), ou 'serial' (GTIN + numéro de série). Déterminé par les actes délégués UE par catégorie de produit.</para>
    /// labels<para>Niveau de Granularité</para><para>Granularity Level</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#granularityLevel">https://ns.verisav.fr/dpp#granularityLevel</seealso>
    let granularityLevel = Prefixed_Name(submit, "granularityLevel") |> PrefixedName
    /// <summary>
    ///   <para>submit:gs1DigitalLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The standard GS1 Digital Link URI for the product, resolving to the DPP. Uses uncompressed GS1 Digital Link URI syntax per GS1 standards.</para>
    ///   <para>L'URI standard GS1 Digital Link pour le produit, résolvant vers le DPP. Utilise la syntaxe GS1 Digital Link URI non compressée selon les standards GS1.</para>
    /// labels<para>GS1 Digital Link URI</para><para>URI GS1 Digital Link</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#gs1DigitalLink">https://ns.verisav.fr/dpp#gs1DigitalLink</seealso>
    let gs1DigitalLink = Prefixed_Name(submit, "gs1DigitalLink") |> PrefixedName

    /// <summary>
    ///   <para>submit:hasCompoundIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a ProductPassport to a CompoundIdentifier (GTIN + variant/batch/serial).</para>
    ///   <para>Lie un ProductPassport à un Identifiant Composé (GTIN + variant/lot/série).</para>
    /// labels<para>a pour identifiant composé</para><para>has compound identifier</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasCompoundIdentifier">https://ns.verisav.fr/dpp#hasCompoundIdentifier</seealso>
    let hasCompoundIdentifier =
        Prefixed_Name(submit, "hasCompoundIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>submit:CircularityPerformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Tableau de bord de la circularité du produit. Aligné avec UNTP DPP.</para>
    ///   <para>Product circularity scorecard. Aligned with UNTP DPP.</para>
    /// labels<para>Performance Circularité</para><para>Circularity Performance</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#CircularityPerformance">https://ns.verisav.fr/dpp#CircularityPerformance</seealso>
    let CircularityPerformance =
        Prefixed_Name(submit, "CircularityPerformance") |> PrefixedName

    /// <summary>
    ///   <para>submit:CompoundIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Un identifiant complexe combinant un GTIN avec un variant, lot ou numéro de série (produits sur mesure).</para>
    ///   <para>A complex identifier combining a GTIN with a variant, batch, or serial number (Made-to-Order products).</para>
    /// labels<para>Compound Identifier</para><para>Identifiant Composé</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#CompoundIdentifier">https://ns.verisav.fr/dpp#CompoundIdentifier</seealso>
    let CompoundIdentifier = Prefixed_Name(submit, "CompoundIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>submit:hasEconomicOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Lie un ProductPassport à son Opérateur Économique (fabricant, importateur, distributeur, etc.).</para>
    ///   <para>Links a ProductPassport to its EconomicOperator (manufacturer, importer, distributor, etc.).</para>
    /// labels<para>a pour opérateur économique</para><para>has economic operator</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasEconomicOperator">https://ns.verisav.fr/dpp#hasEconomicOperator</seealso>
    let hasEconomicOperator =
        Prefixed_Name(submit, "hasEconomicOperator") |> PrefixedName

    /// <summary>
    ///   <para>submit:hasGtin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The GS1 Global Trade Item Number (GTIN) in one of the formats: GTIN-8, GTIN-12, GTIN-13, or GTIN-14. Used with AI (01) for Made-to-Stock products or AI (03) for Made-to-Order products.</para>
    ///   <para>Le Numéro d'Article Global GS1 (GTIN) dans l'un des formats : GTIN-8, GTIN-12, GTIN-13 ou GTIN-14. Utilisé avec AI (01) pour produits Made-to-Stock ou AI (03) pour produits Made-to-Order.</para>
    /// labels<para>Global Trade Item Number (GTIN)</para><para>Numéro d'Article Global (GTIN)</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasGtin">https://ns.verisav.fr/dpp#hasGtin</seealso>
    let hasGtin = Prefixed_Name(submit, "hasGtin") |> PrefixedName
    /// <summary>
    ///   <para>submit:hasManufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Lie un ProductPassport à son Fabricant.</para>
    ///   <para>Links a ProductPassport to its Manufacturer.</para>
    /// labels<para>a pour fabricant</para><para>has manufacturer</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasManufacturer">https://ns.verisav.fr/dpp#hasManufacturer</seealso>
    let hasManufacturer = Prefixed_Name(submit, "hasManufacturer") |> PrefixedName
    /// <summary>
    ///   <para>submit:hasRepairer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an Intervention to its Repairer.</para>
    ///   <para>Lie une Intervention à son Réparateur.</para>
    /// labels<para>a pour réparateur</para><para>has repairer</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasRepairer">https://ns.verisav.fr/dpp#hasRepairer</seealso>
    let hasRepairer = Prefixed_Name(submit, "hasRepairer") |> PrefixedName
    /// <summary>
    ///   <para>submit:hasReplacementPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an Intervention to a ReplacementPart.</para>
    ///   <para>Lie une Intervention à une Pièce de Rechange.</para>
    /// labels<para>a pour pièce de rechange</para><para>has replacement part</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasReplacementPart">https://ns.verisav.fr/dpp#hasReplacementPart</seealso>
    let hasReplacementPart = Prefixed_Name(submit, "hasReplacementPart") |> PrefixedName
    /// <summary>
    ///   <para>submit:hasServiceRequest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Lie un ProductPassport à une Demande de Service.</para>
    ///   <para>Links a ProductPassport to a ServiceRequest.</para>
    /// labels<para>a pour demande de service</para><para>has service request</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasServiceRequest">https://ns.verisav.fr/dpp#hasServiceRequest</seealso>
    let hasServiceRequest = Prefixed_Name(submit, "hasServiceRequest") |> PrefixedName
    /// <summary>
    ///   <para>submit:ConformityClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Déclaration de conformité à un standard ou réglementation. Aligné avec UNTP DPP.</para>
    ///   <para>Claim of conformity to a standard or regulation. Aligned with UNTP DPP.</para>
    /// labels<para>Déclaration de Conformité</para><para>Conformity Claim</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#ConformityClaim">https://ns.verisav.fr/dpp#ConformityClaim</seealso>
    let ConformityClaim = Prefixed_Name(submit, "ConformityClaim") |> PrefixedName
    /// <summary>
    ///   <para>submit:Consumer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A consumer who owns or uses a product.</para>
    ///   <para>Un consommateur qui possède ou utilise un produit.</para>
    /// labels<para>Consommateur</para><para>Consumer</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#Consumer">https://ns.verisav.fr/dpp#Consumer</seealso>
    let Consumer = Prefixed_Name(submit, "Consumer") |> PrefixedName
    /// <summary>
    ///   <para>submit:Criterion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A criterion or rule within a standard or regulation against which a claim is evaluated.</para>
    ///   <para>Critère ou règle dans un standard ou réglementation contre lequel une déclaration est évaluée.</para>
    /// labels<para>Criterion</para><para>Critère</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#Criterion">https://ns.verisav.fr/dpp#Criterion</seealso>
    let Criterion = Prefixed_Name(submit, "Criterion") |> PrefixedName
    /// <summary>
    ///   <para>submit:Diagnostic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Une évaluation de diagnostic effectuée sur un produit pour identifier les problèmes.</para>
    ///   <para>A diagnostic assessment performed on a product to identify issues.</para>
    /// labels<para>Diagnostic</para><para>Diagnostic</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#Diagnostic">https://ns.verisav.fr/dpp#Diagnostic</seealso>
    let Diagnostic = Prefixed_Name(submit, "Diagnostic") |> PrefixedName

    /// <summary>
    ///   <para>submit:EmissionsPerformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Greenhouse gas emissions scorecard for a product. Aligned with UNTP DPP.</para>
    ///   <para>Tableau de bord des émissions de gaz à effet de serre du produit. Aligné avec UNTP DPP.</para>
    /// labels<para>Performance Émissions</para><para>Emissions Performance</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#EmissionsPerformance">https://ns.verisav.fr/dpp#EmissionsPerformance</seealso>
    let EmissionsPerformance =
        Prefixed_Name(submit, "EmissionsPerformance") |> PrefixedName

    /// <summary>
    ///   <para>submit:Intervention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Une intervention technique sur un produit (diagnostic, réparation, maintenance, remplacement, retour fabricant).</para>
    ///   <para>A technical intervention on a product (diagnostic, repair, maintenance, replacement, return to manufacturer).</para>
    /// labels<para>Intervention</para><para>Intervention</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#Intervention">https://ns.verisav.fr/dpp#Intervention</seealso>
    let Intervention = Prefixed_Name(submit, "Intervention") |> PrefixedName
    /// <summary>
    ///   <para>submit:RepairEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Une intervention de réparation ou maintenance spécifique effectuée sur un produit.</para>
    ///   <para>A specific repair or maintenance intervention performed on a product.</para>
    /// labels<para>Événement de Réparation</para><para>Repair Event</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#RepairEvent">https://ns.verisav.fr/dpp#RepairEvent</seealso>
    let RepairEvent = Prefixed_Name(submit, "RepairEvent") |> PrefixedName
    /// <summary>
    ///   <para>submit:Manufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The manufacturer of a product.</para>
    ///   <para>Le fabricant d'un produit.</para>
    /// labels<para>Manufacturer</para><para>Fabricant</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#Manufacturer">https://ns.verisav.fr/dpp#Manufacturer</seealso>
    let Manufacturer = Prefixed_Name(submit, "Manufacturer") |> PrefixedName
    /// <summary>
    ///   <para>submit:Metric</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A metric defining actual measured values, optionally including accuracy.</para>
    ///   <para>Métrique définissant les valeurs mesurées réelles, incluant optionnellement la précision.</para>
    /// labels<para>Métrique</para><para>Metric</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#Metric">https://ns.verisav.fr/dpp#Metric</seealso>
    let Metric = Prefixed_Name(submit, "Metric") |> PrefixedName

    /// <summary>
    ///   <para>submit:ProductLifecycleStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A stage in the product lifecycle (manufacturing, purchase, usage, end of life, recycling).</para>
    ///   <para>Une étape dans le cycle de vie du produit (fabrication, achat, usage, fin de vie, recyclage).</para>
    /// labels<para>Étape du Cycle de Vie du Produit</para><para>Product Lifecycle Stage</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#ProductLifecycleStage">https://ns.verisav.fr/dpp#ProductLifecycleStage</seealso>
    let ProductLifecycleStage =
        Prefixed_Name(submit, "ProductLifecycleStage") |> PrefixedName

    /// <summary>
    ///   <para>submit:originCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Origin country code of the material (ISO 3166-1 alpha-2 or alpha-3).</para>
    ///   <para>Code pays d'origine du matériau (ISO 3166-1 alpha-2 ou alpha-3).</para>
    /// labels<para>origin country</para><para>pays d'origine</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#originCountry">https://ns.verisav.fr/dpp#originCountry</seealso>
    let originCountry = Prefixed_Name(submit, "originCountry") |> PrefixedName
    /// <summary>
    ///   <para>submit:partReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Le numéro de référence de la pièce de rechange.</para>
    ///   <para>The reference number of the replacement part.</para>
    /// labels<para>référence de pièce</para><para>part reference</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#partReference">https://ns.verisav.fr/dpp#partReference</seealso>
    let partReference = Prefixed_Name(submit, "partReference") |> PrefixedName
    /// <summary>
    ///   <para>submit:partsCost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Le coût des pièces de rechange pour l'intervention.</para>
    ///   <para>The cost of replacement parts for the intervention.</para>
    /// labels<para>coût des pièces</para><para>parts cost</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#partsCost">https://ns.verisav.fr/dpp#partsCost</seealso>
    let partsCost = Prefixed_Name(submit, "partsCost") |> PrefixedName
    /// <summary>
    ///   <para>submit:productStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The status of the product (sous_garantie, hors_garantie, contrat_maintenance, en_panne, repare).</para>
    ///   <para>Le statut du produit (sous garantie, hors garantie, contrat maintenance, en panne, réparé).</para>
    /// labels<para>statut du produit</para><para>product status</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#productStatus">https://ns.verisav.fr/dpp#productStatus</seealso>
    let productStatus = Prefixed_Name(submit, "productStatus") |> PrefixedName
    /// <summary>
    ///   <para>submit:productStatusDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date when the product status was set.</para>
    ///   <para>La date à laquelle le statut du produit a été défini.</para>
    /// labels<para>date du statut produit</para><para>product status date</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#productStatusDate">https://ns.verisav.fr/dpp#productStatusDate</seealso>
    let productStatusDate = Prefixed_Name(submit, "productStatusDate") |> PrefixedName
    /// <summary>
    ///   <para>submit:purchaseDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date when the product was purchased.</para>
    ///   <para>La date à laquelle le produit a été acheté.</para>
    /// labels<para>purchase date</para><para>date d'achat</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#purchaseDate">https://ns.verisav.fr/dpp#purchaseDate</seealso>
    let purchaseDate = Prefixed_Name(submit, "purchaseDate") |> PrefixedName
    /// <summary>
    ///   <para>submit:recyclableContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Proportion of product mass designed to be recyclable or reusable (0-1).</para>
    ///   <para>Proportion de la masse du produit conçue pour être recyclable ou réutilisable (0-1).</para>
    /// labels<para>contenu recyclable</para><para>recyclable content</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#recyclableContent">https://ns.verisav.fr/dpp#recyclableContent</seealso>
    let recyclableContent = Prefixed_Name(submit, "recyclableContent") |> PrefixedName
    /// <summary>
    ///   <para>submit:hasLifecycleStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Lie un ProductPassport à une Étape du Cycle de Vie.</para>
    ///   <para>Links a ProductPassport to a ProductLifecycleStage.</para>
    /// labels<para>a pour étape de cycle de vie</para><para>has lifecycle stage</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasLifecycleStage">https://ns.verisav.fr/dpp#hasLifecycleStage</seealso>
    let hasLifecycleStage = Prefixed_Name(submit, "hasLifecycleStage") |> PrefixedName

    /// <summary>
    ///   <para>submit:hasMaterialProvenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a ProductPassport to material provenance information. Aligned with UNTP DPP-03.</para>
    ///   <para>Lie un ProductPassport à des informations de provenance des matériaux. Aligné avec UNTP DPP-03.</para>
    /// labels<para>a pour provenance de matériau</para><para>has material provenance</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasMaterialProvenance">https://ns.verisav.fr/dpp#hasMaterialProvenance</seealso>
    let hasMaterialProvenance =
        Prefixed_Name(submit, "hasMaterialProvenance") |> PrefixedName

    /// <summary>
    ///   <para>submit:hasProductClassification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a ProductPassport to product classification. Aligned with UNTP DPP-02.</para>
    ///   <para>Lie un ProductPassport à une classification produit. Aligné avec UNTP DPP-02.</para>
    /// labels<para>a pour classification produit</para><para>has product classification</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasProductClassification">https://ns.verisav.fr/dpp#hasProductClassification</seealso>
    let hasProductClassification =
        Prefixed_Name(submit, "hasProductClassification") |> PrefixedName

    /// <summary>
    ///   <para>submit:hasRetailer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Lie un ProductPassport à son Distributeur.</para>
    ///   <para>Links a ProductPassport to its Retailer.</para>
    /// labels<para>a pour distributeur</para><para>has retailer</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasRetailer">https://ns.verisav.fr/dpp#hasRetailer</seealso>
    let hasRetailer = Prefixed_Name(submit, "hasRetailer") |> PrefixedName
    /// <summary>
    ///   <para>submit:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A document associated with a product (manuals, invoices, certificates, etc.).</para>
    ///   <para>Un document associé à un produit (manuels, factures, certificats, etc.).</para>
    /// labels<para>Document</para><para>Document</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#Document">https://ns.verisav.fr/dpp#Document</seealso>
    let Document = Prefixed_Name(submit, "Document") |> PrefixedName

    /// <summary>
    ///   <para>submit:hasRecyclingInstructions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a ProductPassport to RecyclingInstructions.</para>
    ///   <para>Lie un ProductPassport à des Consignes de Recyclage.</para>
    /// labels<para>a pour consignes de recyclage</para><para>has recycling instructions</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasRecyclingInstructions">https://ns.verisav.fr/dpp#hasRecyclingInstructions</seealso>
    let hasRecyclingInstructions =
        Prefixed_Name(submit, "hasRecyclingInstructions") |> PrefixedName

    /// <summary>
    ///   <para>submit:EconomicOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An economic operator in the value chain (manufacturer, importer, distributor, dealer, repairer) as per EU ESPR regulation. Can be authenticated via EU Business Wallet (EBW) with EUID (European Unique Identifier).</para>
    ///   <para>Un opérateur économique dans la chaîne de valeur (fabricant, importateur, distributeur, revendeur, réparateur) selon la réglementation européenne ESPR. Peut être authentifié via EU Business Wallet (EBW) avec EUID (European Unique Identifier).</para>
    /// labels<para>Opérateur Économique</para><para>Economic Operator</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#EconomicOperator">https://ns.verisav.fr/dpp#EconomicOperator</seealso>
    let EconomicOperator = Prefixed_Name(submit, "EconomicOperator") |> PrefixedName

    /// <summary>
    ///   <para>submit:hasVerifiedIdentity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates whether the EconomicOperator's identity has been verified via EU Business Wallet (EBW).</para>
    ///   <para>Indique si l'identité de l'Opérateur Économique a été vérifiée via EU Business Wallet (EBW).</para>
    /// labels<para>has verified identity</para><para>a identité vérifiée</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasVerifiedIdentity">https://ns.verisav.fr/dpp#hasVerifiedIdentity</seealso>
    let hasVerifiedIdentity =
        Prefixed_Name(submit, "hasVerifiedIdentity") |> PrefixedName

    /// <summary>
    ///   <para>submit:hasWarranty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a ProductPassport to its Warranty.</para>
    ///   <para>Lie un ProductPassport à sa Garantie.</para>
    /// labels<para>a pour garantie</para><para>has warranty</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasWarranty">https://ns.verisav.fr/dpp#hasWarranty</seealso>
    let hasWarranty = Prefixed_Name(submit, "hasWarranty") |> PrefixedName
    /// <summary>
    ///   <para>submit:hashDigest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Digest de hash pour vérification de l'intégrité du lien.</para>
    ///   <para>Hash digest for verification of link integrity.</para>
    /// labels<para>digest de hash</para><para>hash digest</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hashDigest">https://ns.verisav.fr/dpp#hashDigest</seealso>
    let hashDigest = Prefixed_Name(submit, "hashDigest") |> PrefixedName

    /// <summary>
    ///   <para>submit:interventionDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La durée de l'intervention en minutes.</para>
    ///   <para>The duration of the intervention in minutes.</para>
    /// labels<para>intervention duration</para><para>durée d'intervention</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#interventionDuration">https://ns.verisav.fr/dpp#interventionDuration</seealso>
    let interventionDuration =
        Prefixed_Name(submit, "interventionDuration") |> PrefixedName

    /// <summary>
    ///   <para>submit:interventionStartDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La date et heure de début de l'intervention.</para>
    ///   <para>The start date and time of the intervention.</para>
    /// labels<para>date de début d'intervention</para><para>intervention start date</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#interventionStartDate">https://ns.verisav.fr/dpp#interventionStartDate</seealso>
    let interventionStartDate =
        Prefixed_Name(submit, "interventionStartDate") |> PrefixedName

    /// <summary>
    ///   <para>submit:interventionType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Le type d'intervention (diagnostic, réparation, maintenance, remplacement, retour fabricant).</para>
    ///   <para>The type of intervention (diagnostic, reparation, maintenance, remplacement, retour_fabricant).</para>
    /// labels<para>type d'intervention</para><para>intervention type</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#interventionType">https://ns.verisav.fr/dpp#interventionType</seealso>
    let interventionType = Prefixed_Name(submit, "interventionType") |> PrefixedName
    /// <summary>
    ///   <para>submit:issuedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a VerifiableProductPassport to the EconomicOperator that issued it via EU Business Wallet (EBW).</para>
    ///   <para>Lie un VerifiableProductPassport à l'Opérateur Économique qui l'a émis via EU Business Wallet (EBW).</para>
    /// labels<para>issued by</para><para>émis par</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#issuedBy">https://ns.verisav.fr/dpp#issuedBy</seealso>
    let issuedBy = Prefixed_Name(submit, "issuedBy") |> PrefixedName
    /// <summary>
    ///   <para>submit:laborCost</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The cost of labor for the intervention.</para>
    ///   <para>Le coût de la main d'œuvre pour l'intervention.</para>
    /// labels<para>coût main d'œuvre</para><para>labor cost</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#laborCost">https://ns.verisav.fr/dpp#laborCost</seealso>
    let laborCost = Prefixed_Name(submit, "laborCost") |> PrefixedName
    /// <summary>
    ///   <para>submit:lifecycleStageName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Le nom de l'étape du cycle de vie (fabrication, achat, usage, fin de vie, recyclage).</para>
    ///   <para>The name of the lifecycle stage (manufacturing, purchase, usage, end_of_life, recycling).</para>
    /// labels<para>nom de l'étape du cycle de vie</para><para>lifecycle stage name</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#lifecycleStageName">https://ns.verisav.fr/dpp#lifecycleStageName</seealso>
    let lifecycleStageName = Prefixed_Name(submit, "lifecycleStageName") |> PrefixedName
    /// <summary>
    ///   <para>submit:linkName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Nom lisible par humain pour le lien.</para>
    ///   <para>Human-readable name for the link.</para>
    /// labels<para>nom du lien</para><para>link name</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#linkName">https://ns.verisav.fr/dpp#linkName</seealso>
    let linkName = Prefixed_Name(submit, "linkName") |> PrefixedName
    /// <summary>
    ///   <para>submit:linkType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Identifiant de type pour le lien (ex: URI vers un terme de vocabulaire).</para>
    ///   <para>Type identifier for the link (e.g., URI to a vocabulary term).</para>
    /// labels<para>type de lien</para><para>link type</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#linkType">https://ns.verisav.fr/dpp#linkType</seealso>
    let linkType = Prefixed_Name(submit, "linkType") |> PrefixedName
    /// <summary>
    ///   <para>submit:linkURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>URL or link to a resource.</para>
    ///   <para>URL ou lien vers une ressource.</para>
    /// labels<para>URL du lien</para><para>link URL</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#linkURL">https://ns.verisav.fr/dpp#linkURL</seealso>
    let linkURL = Prefixed_Name(submit, "linkURL") |> PrefixedName
    /// <summary>
    ///   <para>submit:massFraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Fraction massique du matériau dans le produit (valeur décimale entre 0 et 1).</para>
    ///   <para>Mass fraction of the material in the product (decimal value between 0 and 1).</para>
    /// labels<para>fraction massique</para><para>mass fraction</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#massFraction">https://ns.verisav.fr/dpp#massFraction</seealso>
    let massFraction = Prefixed_Name(submit, "massFraction") |> PrefixedName
    /// <summary>
    ///   <para>submit:materialName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Name of the material (e.g., 'Aluminum', 'Steel', 'Plastic').</para>
    ///   <para>Nom du matériau (ex: 'Aluminium', 'Acier', 'Plastique').</para>
    /// labels<para>nom du matériau</para><para>material name</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#materialName">https://ns.verisav.fr/dpp#materialName</seealso>
    let materialName = Prefixed_Name(submit, "materialName") |> PrefixedName
    /// <summary>
    ///   <para>submit:metricName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Name of the metric (e.g., 'GHG Emissions Intensity').</para>
    ///   <para>Nom de la métrique (ex: 'Intensité Émissions GES').</para>
    /// labels<para>nom de la métrique</para><para>metric name</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#metricName">https://ns.verisav.fr/dpp#metricName</seealso>
    let metricName = Prefixed_Name(submit, "metricName") |> PrefixedName
    /// <summary>
    ///   <para>submit:operationalScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Périmètre du calcul d'émissions (ex: 'CradleToGate', 'CradleToGrave', 'GateToGate').</para>
    ///   <para>Scope of emissions calculation (e.g., 'CradleToGate', 'CradleToGrave', 'GateToGate').</para>
    /// labels<para>périmètre opérationnel</para><para>operational scope</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#operationalScope">https://ns.verisav.fr/dpp#operationalScope</seealso>
    let operationalScope = Prefixed_Name(submit, "operationalScope") |> PrefixedName
    /// <summary>
    ///   <para>submit:originRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Specific region of origin for the material (optional).</para>
    ///   <para>Région spécifique d'origine du matériau (optionnel).</para>
    /// labels<para>région d'origine</para><para>origin region</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#originRegion">https://ns.verisav.fr/dpp#originRegion</seealso>
    let originRegion = Prefixed_Name(submit, "originRegion") |> PrefixedName
    /// <summary>
    ///   <para>submit:partName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Le nom de la pièce de rechange.</para>
    ///   <para>The name of the replacement part.</para>
    /// labels<para>nom de la pièce</para><para>part name</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#partName">https://ns.verisav.fr/dpp#partName</seealso>
    let partName = Prefixed_Name(submit, "partName") |> PrefixedName
    /// <summary>
    ///   <para>submit:hasSecureDataShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a ProductPassport to a SecureDataShare action via EU Business Wallet (EBW).</para>
    ///   <para>Lie un ProductPassport à une action SecureDataShare via EU Business Wallet (EBW).</para>
    /// labels<para>a pour partage de données sécurisé</para><para>has secure data share</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasSecureDataShare">https://ns.verisav.fr/dpp#hasSecureDataShare</seealso>
    let hasSecureDataShare = Prefixed_Name(submit, "hasSecureDataShare") |> PrefixedName

    /// <summary>
    ///   <para>submit:hasTraceabilityEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Lie un ProductPassport ou TraceabilityPerformance à un événement de traçabilité. Aligné avec UNTP DPP-06.</para>
    ///   <para>Links a ProductPassport or TraceabilityPerformance to a traceability event. Aligned with UNTP DPP-06.</para>
    /// labels<para>a pour événement de traçabilité</para><para>has traceability event</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasTraceabilityEvent">https://ns.verisav.fr/dpp#hasTraceabilityEvent</seealso>
    let hasTraceabilityEvent =
        Prefixed_Name(submit, "hasTraceabilityEvent") |> PrefixedName

    /// <summary>
    ///   <para>submit:hasTraceabilityInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Lie un ProductPassport à des informations de traçabilité. Aligné avec UNTP DPP-06.</para>
    ///   <para>Links a ProductPassport to traceability information. Aligned with UNTP DPP-06.</para>
    /// labels<para>a pour information traçabilité</para><para>has traceability information</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasTraceabilityInformation">https://ns.verisav.fr/dpp#hasTraceabilityInformation</seealso>
    let hasTraceabilityInformation =
        Prefixed_Name(submit, "hasTraceabilityInformation") |> PrefixedName

    /// <summary>
    ///   <para>submit:hasVerifiableCredential</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Lie un VerifiableProductPassport ou ConformityClaim à son W3C Verifiable Credential (VCDM 2.0) stocké dans EU Business Wallet (EBW).</para>
    ///   <para>Links a VerifiableProductPassport or ConformityClaim to its W3C Verifiable Credential (VCDM 2.0) stored in EU Business Wallet (EBW).</para>
    /// labels<para>a pour credential vérifiable</para><para>has verifiable credential</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasVerifiableCredential">https://ns.verisav.fr/dpp#hasVerifiableCredential</seealso>
    let hasVerifiableCredential =
        Prefixed_Name(submit, "hasVerifiableCredential") |> PrefixedName

    /// <summary>
    ///   <para>submit:Facility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Un lieu ou bâtiment impliqué dans la chaîne de valeur d'un produit (usine de fabrication, entrepôt, etc.) selon la réglementation européenne ESPR. Aligné avec UNTP DPP-04.</para>
    ///   <para>A location or building involved in the value chain of a product (manufacturing facility, warehouse, etc.) as per EU ESPR regulation. Aligned with UNTP DPP-04.</para>
    /// labels<para>Installation</para><para>Facility</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#Facility">https://ns.verisav.fr/dpp#Facility</seealso>
    let Facility = Prefixed_Name(submit, "Facility") |> PrefixedName
    /// <summary>
    ///   <para>submit:MaterialProvenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information about material provenance: name, mass fraction, origin country. Aligned with UNTP DPP-03.</para>
    ///   <para>Information sur la provenance d'un matériau : nom, fraction massique, pays d'origine. Aligné avec UNTP DPP-03.</para>
    /// labels<para>Provenance des Matériaux</para><para>Material Provenance</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#MaterialProvenance">https://ns.verisav.fr/dpp#MaterialProvenance</seealso>
    let MaterialProvenance = Prefixed_Name(submit, "MaterialProvenance") |> PrefixedName
    /// <summary>
    ///   <para>submit:hasWarrantyClaim</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a ProductPassport to a WarrantyClaim.</para>
    ///   <para>Lie un ProductPassport à une Réclamation de Garantie.</para>
    /// labels<para>a pour réclamation</para><para>has warranty claim</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hasWarrantyClaim">https://ns.verisav.fr/dpp#hasWarrantyClaim</seealso>
    let hasWarrantyClaim = Prefixed_Name(submit, "hasWarrantyClaim") |> PrefixedName
    /// <summary>
    ///   <para>submit:hashMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Méthode utilisée pour le hash (ex: 'SHA-256', 'SHA-512').</para>
    ///   <para>Method used for hashing (e.g., 'SHA-256', 'SHA-512').</para>
    /// labels<para>méthode de hash</para><para>hash method</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#hashMethod">https://ns.verisav.fr/dpp#hashMethod</seealso>
    let hashMethod = Prefixed_Name(submit, "hashMethod") |> PrefixedName

    /// <summary>
    ///   <para>submit:interventionEndDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The end date and time of the intervention.</para>
    ///   <para>La date et heure de fin de l'intervention.</para>
    /// labels<para>date de fin d'intervention</para><para>intervention end date</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#interventionEndDate">https://ns.verisav.fr/dpp#interventionEndDate</seealso>
    let interventionEndDate =
        Prefixed_Name(submit, "interventionEndDate") |> PrefixedName

    /// <summary>
    ///   <para>submit:issueDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Date when the standard or regulation was issued.</para>
    ///   <para>Date à laquelle le standard ou réglementation a été publié.</para>
    /// labels<para>date de publication</para><para>issue date</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#issueDate">https://ns.verisav.fr/dpp#issueDate</seealso>
    let issueDate = Prefixed_Name(submit, "issueDate") |> PrefixedName
    /// <summary>
    ///   <para>submit:issuingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Organization that issued the standard or regulation.</para>
    ///   <para>Organisation qui a publié le standard ou réglementation.</para>
    /// labels<para>partie émettrice</para><para>issuing party</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#issuingParty">https://ns.verisav.fr/dpp#issuingParty</seealso>
    let issuingParty = Prefixed_Name(submit, "issuingParty") |> PrefixedName
    /// <summary>
    ///   <para>submit:lifecycleStageDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date when the product entered this lifecycle stage.</para>
    ///   <para>La date à laquelle le produit est entré dans cette étape du cycle de vie.</para>
    /// labels<para>date de l'étape du cycle de vie</para><para>lifecycle stage date</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#lifecycleStageDate">https://ns.verisav.fr/dpp#lifecycleStageDate</seealso>
    let lifecycleStageDate = Prefixed_Name(submit, "lifecycleStageDate") |> PrefixedName
    /// <summary>
    ///   <para>submit:manufacturingDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>La date à laquelle le produit a été fabriqué.</para>
    ///   <para>The date when the product was manufactured.</para>
    /// labels<para>date de fabrication</para><para>manufacturing date</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#manufacturingDate">https://ns.verisav.fr/dpp#manufacturingDate</seealso>
    let manufacturingDate = Prefixed_Name(submit, "manufacturingDate") |> PrefixedName

    /// <summary>
    ///   <para>submit:manufacturingLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The location where the product was manufactured.</para>
    ///   <para>Le lieu où le produit a été fabriqué.</para>
    /// labels<para>manufacturing location</para><para>lieu de fabrication</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#manufacturingLocation">https://ns.verisav.fr/dpp#manufacturingLocation</seealso>
    let manufacturingLocation =
        Prefixed_Name(submit, "manufacturingLocation") |> PrefixedName

    /// <summary>
    ///   <para>submit:materialCircularityIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Score global de circularité (MCI) calculé comme 1 - (V + W) / (2 * D), où V = proportion matériaux vierges, W = proportion pertes, D = facteur d'utilité (0-1).</para>
    ///   <para>Overall circularity score (MCI) calculated as 1 - (V + W) / (2 * D), where V = virgin material proportion, W = waste leakage proportion, D = utility factor (0-1).</para>
    /// labels<para>indicateur de circularité matérielle</para><para>material circularity indicator</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#materialCircularityIndicator">https://ns.verisav.fr/dpp#materialCircularityIndicator</seealso>
    let materialCircularityIndicator =
        Prefixed_Name(submit, "materialCircularityIndicator") |> PrefixedName

    /// <summary>
    ///   <para>submit:metricValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Valeur de la métrique avec unité.</para>
    ///   <para>Value of the metric with unit.</para>
    /// labels<para>valeur de la métrique</para><para>metric value</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#metricValue">https://ns.verisav.fr/dpp#metricValue</seealso>
    let metricValue = Prefixed_Name(submit, "metricValue") |> PrefixedName

    /// <summary>
    ///   <para>submit:RecyclingInstructions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Instructions pour recycler ou éliminer un produit en fin de vie.</para>
    ///   <para>Instructions for recycling or disposing of a product at end of life.</para>
    /// labels<para>Recycling Instructions</para><para>Consignes de Recyclage</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#RecyclingInstructions">https://ns.verisav.fr/dpp#RecyclingInstructions</seealso>
    let RecyclingInstructions =
        Prefixed_Name(submit, "RecyclingInstructions") |> PrefixedName

    /// <summary>
    ///   <para>submit:ProductPassport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Digital Product Passport that tracks a product throughout its entire lifecycle.</para>
    ///   <para>Un Passeport Produit Numérique qui suit un produit tout au long de son cycle de vie.</para>
    /// labels<para>Passeport Produit</para><para>Product Passport</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#ProductPassport">https://ns.verisav.fr/dpp#ProductPassport</seealso>
    let ProductPassport = Prefixed_Name(submit, "ProductPassport") |> PrefixedName

    /// <summary>
    ///   <para>submit:primarySourcedRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Ratio of materials from primary sources (0-1).</para>
    ///   <para>Ratio de matériaux provenant de sources primaires (0-1).</para>
    /// labels<para>ratio de sourcing primaire</para><para>primary sourced ratio</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#primarySourcedRatio">https://ns.verisav.fr/dpp#primarySourcedRatio</seealso>
    let primarySourcedRatio =
        Prefixed_Name(submit, "primarySourcedRatio") |> PrefixedName

    /// <summary>
    ///   <para>submit:purchasePrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Le prix payé pour le produit.</para>
    ///   <para>The price paid for the product.</para>
    /// labels<para>purchase price</para><para>prix d'achat</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#purchasePrice">https://ns.verisav.fr/dpp#purchasePrice</seealso>
    let purchasePrice = Prefixed_Name(submit, "purchasePrice") |> PrefixedName

    /// <summary>
    ///   <para>submit:referenceRegulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Reference regulation for the conformity claim.</para>
    ///   <para>Réglementation de référence pour la déclaration de conformité.</para>
    /// labels<para>référence réglementation</para><para>reference regulation</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#referenceRegulation">https://ns.verisav.fr/dpp#referenceRegulation</seealso>
    let referenceRegulation =
        Prefixed_Name(submit, "referenceRegulation") |> PrefixedName

    /// <summary>
    ///   <para>submit:repairStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The status of a repair event (pending, in_progress, completed, failed).</para>
    ///   <para>Le statut d'un événement de réparation (en attente, en cours, complété, échoué).</para>
    /// labels<para>statut de réparation</para><para>repair status</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#repairStatus">https://ns.verisav.fr/dpp#repairStatus</seealso>
    let repairStatus = Prefixed_Name(submit, "repairStatus") |> PrefixedName
    /// <summary>
    ///   <para>submit:reportingStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Standard used for emissions reporting.</para>
    ///   <para>Standard utilisé pour le reporting des émissions.</para>
    /// labels<para>standard de reporting</para><para>reporting standard</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#reportingStandard">https://ns.verisav.fr/dpp#reportingStandard</seealso>
    let reportingStandard = Prefixed_Name(submit, "reportingStandard") |> PrefixedName
    /// <summary>
    ///   <para>submit:serialNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Le numéro de série du produit.</para>
    ///   <para>The serial number of the product.</para>
    /// labels<para>numéro de série</para><para>serial number</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#serialNumber">https://ns.verisav.fr/dpp#serialNumber</seealso>
    let serialNumber = Prefixed_Name(submit, "serialNumber") |> PrefixedName
    /// <summary>
    ///   <para>submit:sharedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a SecureDataShare to the EconomicOperator with whom DPP data is shared via EU Business Wallet (EBW).</para>
    ///   <para>Lie un SecureDataShare à l'Opérateur Économique avec qui les données DPP sont partagées via EU Business Wallet (EBW).</para>
    /// labels<para>partagé avec</para><para>shared with</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#sharedWith">https://ns.verisav.fr/dpp#sharedWith</seealso>
    let sharedWith = Prefixed_Name(submit, "sharedWith") |> PrefixedName
    /// <summary>
    ///   <para>submit:standardName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Nom du standard.</para>
    ///   <para>Name of the standard.</para>
    /// labels<para>nom du standard</para><para>standard name</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#standardName">https://ns.verisav.fr/dpp#standardName</seealso>
    let standardName = Prefixed_Name(submit, "standardName") |> PrefixedName
    /// <summary>
    ///   <para>submit:valueChainProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Description lisible par humain de l'étape spécifique de la chaîne de valeur (ex: 'Mise en conserve', 'Assemblage').</para>
    ///   <para>Human-readable description of the specific value chain step (e.g., 'Canning', 'Assembly').</para>
    /// labels<para>processus chaîne de valeur</para><para>value chain process</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#valueChainProcess">https://ns.verisav.fr/dpp#valueChainProcess</seealso>
    let valueChainProcess = Prefixed_Name(submit, "valueChainProcess") |> PrefixedName

    /// <summary>
    ///   <para>submit:warrantyDurationMonths</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The duration of the warranty in months.</para>
    ///   <para>La durée de la garantie en mois.</para>
    /// labels<para>warranty duration in months</para><para>durée de garantie en mois</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#warrantyDurationMonths">https://ns.verisav.fr/dpp#warrantyDurationMonths</seealso>
    let warrantyDurationMonths =
        Prefixed_Name(submit, "warrantyDurationMonths") |> PrefixedName

    /// <summary>
    ///   <para>submit:warrantyType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Le type de garantie (constructeur, distributeur, extension, maintenance).</para>
    ///   <para>The type of warranty (constructeur, retailer, extension, maintenance).</para>
    /// labels<para>type de garantie</para><para>warranty type</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#warrantyType">https://ns.verisav.fr/dpp#warrantyType</seealso>
    let warrantyType = Prefixed_Name(submit, "warrantyType") |> PrefixedName
    /// <summary>
    ///   <para>submit:workOrderStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The status of the work order (cree, assigne, en_cours, en_attente_pieces, complete, facture, annule).</para>
    ///   <para>Le statut de l'ordre de travail (créé, assigné, en cours, en attente de pièces, complété, facturé, annulé).</para>
    /// labels<para>statut de l'ordre de travail</para><para>work order status</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#workOrderStatus">https://ns.verisav.fr/dpp#workOrderStatus</seealso>
    let workOrderStatus = Prefixed_Name(submit, "workOrderStatus") |> PrefixedName
    /// <summary>
    ///   <para>submit:recycledContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Proportion de la masse du produit faite de matériaux recyclés ou réutilisés (0-1).</para>
    ///   <para>Proportion of product mass made from recycled or repurposed materials (0-1).</para>
    /// labels<para>recycled content</para><para>contenu recyclé</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#recycledContent">https://ns.verisav.fr/dpp#recycledContent</seealso>
    let recycledContent = Prefixed_Name(submit, "recycledContent") |> PrefixedName
    /// <summary>
    ///   <para>submit:referenceStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Standard de référence pour la déclaration de conformité.</para>
    ///   <para>Reference standard for the conformity claim.</para>
    /// labels<para>reference standard</para><para>référence standard</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#referenceStandard">https://ns.verisav.fr/dpp#referenceStandard</seealso>
    let referenceStandard = Prefixed_Name(submit, "referenceStandard") |> PrefixedName
    /// <summary>
    ///   <para>submit:repairInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Link to repair instructions for end users or repair service centers.</para>
    ///   <para>Lien vers instructions de réparation pour utilisateurs finaux ou centres de service de réparation.</para>
    /// labels<para>information réparation</para><para>repair information</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#repairInformation">https://ns.verisav.fr/dpp#repairInformation</seealso>
    let repairInformation = Prefixed_Name(submit, "repairInformation") |> PrefixedName
    /// <summary>
    ///   <para>submit:replaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links a ReplacementPart to the original part it replaces.</para>
    ///   <para>Lie une Pièce de Rechange à la pièce originale qu'elle remplace.</para>
    /// labels<para>remplace</para><para>replaces</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#replaces">https://ns.verisav.fr/dpp#replaces</seealso>
    let replaces = Prefixed_Name(submit, "replaces") |> PrefixedName

    /// <summary>
    ///   <para>submit:resolutionDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Une description de la façon dont le problème a été résolu.</para>
    ///   <para>A description of how the issue was resolved.</para>
    /// labels<para>description de la résolution</para><para>resolution description</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#resolutionDescription">https://ns.verisav.fr/dpp#resolutionDescription</seealso>
    let resolutionDescription =
        Prefixed_Name(submit, "resolutionDescription") |> PrefixedName

    /// <summary>
    ///   <para>submit:standardId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Unique identifier for the standard (URI or string).</para>
    ///   <para>Identifiant unique du standard (URI ou chaîne).</para>
    /// labels<para>standard ID</para><para>ID standard</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#standardId">https://ns.verisav.fr/dpp#standardId</seealso>
    let standardId = Prefixed_Name(submit, "standardId") |> PrefixedName
    /// <summary>
    ///   <para>submit:utilityFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Durabilité du produit relative à la moyenne de l'industrie (ex: 1.2 = 20% plus durable).</para>
    ///   <para>Product durability relative to industry average (e.g., 1.2 = 20% more durable).</para>
    /// labels<para>facteur d'utilité</para><para>utility factor</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#utilityFactor">https://ns.verisav.fr/dpp#utilityFactor</seealso>
    let utilityFactor = Prefixed_Name(submit, "utilityFactor") |> PrefixedName
    /// <summary>
    ///   <para>submit:verifiedRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Proportion de matériaux ou composants dans cette étape qui ont été tracés de manière vérifiable avec des événements de traçabilité numériques (0-1).</para>
    ///   <para>Proportion of materials or components in this step that have been verifiably traced using digital traceability events (0-1).</para>
    /// labels<para>verified ratio</para><para>ratio vérifié</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#verifiedRatio">https://ns.verisav.fr/dpp#verifiedRatio</seealso>
    let verifiedRatio = Prefixed_Name(submit, "verifiedRatio") |> PrefixedName
    /// <summary>
    ///   <para>submit:warrantyEndDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The end date of the warranty.</para>
    ///   <para>La date de fin de la garantie.</para>
    /// labels<para>date de fin de garantie</para><para>warranty end date</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#warrantyEndDate">https://ns.verisav.fr/dpp#warrantyEndDate</seealso>
    let warrantyEndDate = Prefixed_Name(submit, "warrantyEndDate") |> PrefixedName
    /// <summary>
    ///   <para>submit:warrantyStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The status of the warranty (active, expiree, suspendue, annulee).</para>
    ///   <para>Le statut de la garantie (active, expirée, suspendue, annulée).</para>
    /// labels<para>statut de garantie</para><para>warranty status</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#warrantyStatus">https://ns.verisav.fr/dpp#warrantyStatus</seealso>
    let warrantyStatus = Prefixed_Name(submit, "warrantyStatus") |> PrefixedName
    /// <summary>
    ///   <para>submit:workOrderNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>L'identifiant unique de l'ordre de travail.</para>
    ///   <para>The unique identifier for the work order.</para>
    /// labels<para>numéro d'ordre de travail</para><para>work order number</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#workOrderNumber">https://ns.verisav.fr/dpp#workOrderNumber</seealso>
    let workOrderNumber = Prefixed_Name(submit, "workOrderNumber") |> PrefixedName
    /// <summary>
    ///   <para>submit:workOrderPriority</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The priority of the work order (basse, normale, haute, urgente).</para>
    ///   <para>La priorité de l'ordre de travail (basse, normale, haute, urgente).</para>
    /// labels<para>priorité de l'ordre de travail</para><para>work order priority</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#workOrderPriority">https://ns.verisav.fr/dpp#workOrderPriority</seealso>
    let workOrderPriority = Prefixed_Name(submit, "workOrderPriority") |> PrefixedName
    /// <summary>
    ///   <para>submit:ReplacementPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Une pièce utilisée pour remplacer un composant dans un produit lors d'une réparation ou maintenance.</para>
    ///   <para>A part used to replace a component in a product during repair or maintenance.</para>
    /// labels<para>Pièce de Rechange</para><para>Replacement Part</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#ReplacementPart">https://ns.verisav.fr/dpp#ReplacementPart</seealso>
    let ReplacementPart = Prefixed_Name(submit, "ReplacementPart") |> PrefixedName
    /// <summary>
    ///   <para>submit:SecureDataShare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A secure sharing of DPP data between economic operators via EU Business Wallet (EBW). Includes cryptographic integrity verification and timestamping.</para>
    ///   <para>Un partage sécurisé de données DPP entre opérateurs économiques via EU Business Wallet (EBW). Inclut la vérification d'intégrité cryptographique et l'horodatage.</para>
    /// labels<para>Partage de Données Sécurisé</para><para>Secure Data Share</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#SecureDataShare">https://ns.verisav.fr/dpp#SecureDataShare</seealso>
    let SecureDataShare = Prefixed_Name(submit, "SecureDataShare") |> PrefixedName
    /// <summary>
    ///   <para>submit:Retailer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A retailer or distributor who sells products.</para>
    ///   <para>Un distributeur qui vend des produits.</para>
    /// labels<para>Distributeur</para><para>Retailer</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#Retailer">https://ns.verisav.fr/dpp#Retailer</seealso>
    let Retailer = Prefixed_Name(submit, "Retailer") |> PrefixedName
    /// <summary>
    ///   <para>submit:SecureLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Lien sécurisé avec digest de hash et méthode de cryptage pour vérification.</para>
    ///   <para>A secure link with hash digest and encryption method for verification.</para>
    /// labels<para>Lien Sécurisé</para><para>Secure Link</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#SecureLink">https://ns.verisav.fr/dpp#SecureLink</seealso>
    let SecureLink = Prefixed_Name(submit, "SecureLink") |> PrefixedName
    /// <summary>
    ///   <para>submit:Standard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Standard, norm, or reference scheme for a conformity claim.</para>
    ///   <para>Standard, norme ou schéma de référence pour une déclaration de conformité.</para>
    /// labels<para>Standard</para><para>Standard</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#Standard">https://ns.verisav.fr/dpp#Standard</seealso>
    let Standard = Prefixed_Name(submit, "Standard") |> PrefixedName
    /// <summary>
    ///   <para>submit:TraceabilityEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Événement de traçabilité basé sur ISO/IEC 19987 (EPCIS) ou standards similaires. Aligné avec UNTP DPP-06.</para>
    ///   <para>Traceability event based on ISO/IEC 19987 (EPCIS) or similar standards. Aligned with UNTP DPP-06.</para>
    /// labels<para>Événement de Traçabilité</para><para>Traceability Event</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#TraceabilityEvent">https://ns.verisav.fr/dpp#TraceabilityEvent</seealso>
    let TraceabilityEvent = Prefixed_Name(submit, "TraceabilityEvent") |> PrefixedName

    /// <summary>
    ///   <para>submit:VerifiableCredential</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A W3C Verifiable Credential (VCDM 2.0) that can be used to verify claims about a product passport or economic operator. Stored and managed via EU Business Wallet (EBW).</para>
    ///   <para>Un W3C Verifiable Credential (VCDM 2.0) qui peut être utilisé pour vérifier des déclarations sur un passeport produit ou un opérateur économique. Stocké et géré via EU Business Wallet (EBW).</para>
    /// labels<para>Credential Vérifiable</para><para>Verifiable Credential</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#VerifiableCredential">https://ns.verisav.fr/dpp#VerifiableCredential</seealso>
    let VerifiableCredential =
        Prefixed_Name(submit, "VerifiableCredential") |> PrefixedName

    /// <summary>
    ///   <para>submit:VerifiableProductPassport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Digital Product Passport issued as a W3C Verifiable Credential (VCDM 2.0) via EU Business Wallet (EBW). Provides cryptographic proof of authenticity and integrity.</para>
    ///   <para>Un Passeport Produit Numérique émis comme W3C Verifiable Credential (VCDM 2.0) via EU Business Wallet (EBW). Fournit une preuve cryptographique d'authenticité et d'intégrité.</para>
    /// labels<para>Passeport Produit Vérifiable</para><para>Verifiable Product Passport</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#VerifiableProductPassport">https://ns.verisav.fr/dpp#VerifiableProductPassport</seealso>
    let VerifiableProductPassport =
        Prefixed_Name(submit, "VerifiableProductPassport") |> PrefixedName

    /// <summary>
    ///   <para>submit:TraceabilityPerformance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Traceability information for a specific value chain process. Aligned with UNTP DPP.</para>
    ///   <para>Information de traçabilité pour un processus spécifique de la chaîne de valeur. Aligné avec UNTP DPP.</para>
    /// labels<para>Traceability Performance</para><para>Performance Traçabilité</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#TraceabilityPerformance">https://ns.verisav.fr/dpp#TraceabilityPerformance</seealso>
    let TraceabilityPerformance =
        Prefixed_Name(submit, "TraceabilityPerformance") |> PrefixedName

    /// <summary>
    ///   <para>submit:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>Version 1.2.0 (2026-01-23): Added EU Business Wallet (EBW) support - VerifiableProductPassport, VerifiableCredential, EUID support for EconomicOperator, SecureDataShare. Version 1.1.0 (2025-01-XX): Added UNTP alignment - Material Provenance, Product Classification, Emissions Performance, Circularity Performance, Conformity Claims, Traceability Events. Initial release (1.0.0) with GS1 Digital Link alignment and ESPR (EU 2024/1781) support. Added properties: gs1DigitalLink, hasGln, hasGtin, granularityLevel, batchLotNumber, versionNumber. Added classes: EconomicOperator, Facility, CompoundIdentifier.</para>
    ///   <para>Ce vocabulaire est aligné avec la spécification UNTP DPP pour la durabilité et la traçabilité, EU Business Wallet (EBW) pour les credentials vérifiables et l'identité d'entreprise, tout en conservant un focus spécifique sur le service après-vente (SAV).</para>
    ///   <para>This vocabulary is accessible via GraphQL API at https://www.verisav.fr/api/graphql. Use the 'vocabulary(id: "dpp")' query to access DPP vocabulary data.</para>
    ///   <para>Ce vocabulaire est accessible via l'API GraphQL à https://www.verisav.fr/api/graphql. Utilisez la requête 'vocabulary(id: "dpp")' pour accéder aux données du vocabulaire DPP.</para>
    ///   <para>Version 1.2.0 (2026-01-23): Ajout support EU Business Wallet (EBW) - VerifiableProductPassport, VerifiableCredential, support EUID pour EconomicOperator, SecureDataShare. Version 1.1.0 (2025-01-XX): Ajout alignement UNTP - Provenance Matériaux, Classification Produit, Performance Émissions, Performance Circularité, Déclarations Conformité, Événements Traçabilité. Version initiale (1.0.0) avec alignement GS1 Digital Link et support ESPR (EU 2024/1781). Propriétés ajoutées : gs1DigitalLink, hasGln, hasGtin, granularityLevel, batchLotNumber, versionNumber. Classes ajoutées : EconomicOperator, Facility, CompoundIdentifier.</para>
    ///   <para>This vocabulary is aligned with UNTP DPP specification for sustainability and traceability, EU Business Wallet (EBW) for verifiable credentials and enterprise identity, while maintaining a specific focus on after-sales service (SAV).</para>
    /// labels<para>Vocabulaire Passeport Produit Numérique Verisav</para><para>Verisav Digital Product Passport Vocabulary</para></remarks>
    /// <seealso href="https://ns.verisav.fr/dpp#">https://ns.verisav.fr/dpp#</seealso>
    let _prefix_iri = Prefixed_Name(submit, "") |> PrefixedName
