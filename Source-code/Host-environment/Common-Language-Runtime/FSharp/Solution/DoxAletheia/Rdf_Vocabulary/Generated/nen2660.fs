namespace https.w3id.org.nen2660.def.hash

open DoxAletheia

module nen2660 =
    let _namespace_name = "https://w3id.org/nen2660/def#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#EnumerationType"></see>
    /// </summary>
    let EnumerationType = _prefix "EnumerationType"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Representation"></see>
    /// </summary>
    let Representation = _prefix "Representation"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#AbstractConcept"></see>
    /// </summary>
    let AbstractConcept = _prefix "AbstractConcept"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#TopConcept"></see>
    /// </summary>
    let TopConcept = _prefix "TopConcept"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Activity"></see>
    /// </summary>
    let Activity = _prefix "Activity"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasPart"></see>
    /// </summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Entity"></see>
    /// </summary>
    let Entity = _prefix "Entity"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasBoundary"></see>
    /// </summary>
    let hasBoundary = _prefix "hasBoundary"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#GeometricEntity"></see>
    /// </summary>
    let GeometricEntity = _prefix "GeometricEntity"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasInterior"></see>
    /// </summary>
    let hasInterior = _prefix "hasInterior"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#transforms"></see>
    /// </summary>
    let transforms = _prefix "transforms"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Object"></see>
    /// </summary>
    let Object = _prefix "Object"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasPeriod"></see>
    /// </summary>
    let hasPeriod = _prefix "hasPeriod"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#AggregationStateType"></see>
    /// </summary>
    let AggregationStateType = _prefix "AggregationStateType"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Solid"></see>
    /// </summary>
    let Solid = _prefix "Solid"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Liquid"></see>
    /// </summary>
    let Liquid = _prefix "Liquid"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Gas"></see>
    /// </summary>
    let Gas = _prefix "Gas"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Plasma"></see>
    /// </summary>
    let Plasma = _prefix "Plasma"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#AllDisjointClassesShape"></see>
    /// </summary>
    let AllDisjointClassesShape = _prefix "AllDisjointClassesShape"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#RealObject"></see>
    /// </summary>
    let RealObject = _prefix "RealObject"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#SpatialRegion"></see>
    /// </summary>
    let SpatialRegion = _prefix "SpatialRegion"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#FunctionalEntity"></see>
    /// </summary>
    let FunctionalEntity = _prefix "FunctionalEntity"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#TechnicalEntity"></see>
    /// </summary>
    let TechnicalEntity = _prefix "TechnicalEntity"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#PlannedEntity"></see>
    /// </summary>
    let PlannedEntity = _prefix "PlannedEntity"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#RealizedEntity"></see>
    /// </summary>
    let RealizedEntity = _prefix "RealizedEntity"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#PhysicalObject"></see>
    /// </summary>
    let PhysicalObject = _prefix "PhysicalObject"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#InformationObject"></see>
    /// </summary>
    let InformationObject = _prefix "InformationObject"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#State"></see>
    /// </summary>
    let State = _prefix "State"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Event"></see>
    /// </summary>
    let Event = _prefix "Event"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#AllDisjointClasses_1"></see>
    /// </summary>
    let AllDisjointClasses_1 = _prefix "AllDisjointClasses_1"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#AllDisjointClasses_2"></see>
    /// </summary>
    let AllDisjointClasses_2 = _prefix "AllDisjointClasses_2"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#AllDisjointClasses_3"></see>
    /// </summary>
    let AllDisjointClasses_3 = _prefix "AllDisjointClasses_3"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#AllDisjointClasses_4"></see>
    /// </summary>
    let AllDisjointClasses_4 = _prefix "AllDisjointClasses_4"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#AmountOfBulkMatter"></see>
    /// </summary>
    let AmountOfBulkMatter = _prefix "AmountOfBulkMatter"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#ChemicalCompound"></see>
    /// </summary>
    let ChemicalCompound = _prefix "ChemicalCompound"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#PureSubstance"></see>
    /// </summary>
    let PureSubstance = _prefix "PureSubstance"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#ChemicalElement"></see>
    /// </summary>
    let ChemicalElement = _prefix "ChemicalElement"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#ConceptType"></see>
    /// </summary>
    let ConceptType = _prefix "ConceptType"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Type"></see>
    /// </summary>
    let Type = _prefix "Type"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#ConcreteConcept"></see>
    /// </summary>
    let ConcreteConcept = _prefix "ConcreteConcept"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasTemporalEntity"></see>
    /// </summary>
    let hasTemporalEntity = _prefix "hasTemporalEntity"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasPartsGroup"></see>
    /// </summary>
    let hasPartsGroup = _prefix "hasPartsGroup"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Connection"></see>
    /// </summary>
    let Connection = _prefix "Connection"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#connectsObject"></see>
    /// </summary>
    let connectsObject = _prefix "connectsObject"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#connectsPort"></see>
    /// </summary>
    let connectsPort = _prefix "connectsPort"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Port"></see>
    /// </summary>
    let Port = _prefix "Port"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#DiscreteObject"></see>
    /// </summary>
    let DiscreteObject = _prefix "DiscreteObject"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#EnergyFlow"></see>
    /// </summary>
    let EnergyFlow = _prefix "EnergyFlow"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#TransferType"></see>
    /// </summary>
    let TransferType = _prefix "TransferType"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasState"></see>
    /// </summary>
    let hasState = _prefix "hasState"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#triggers"></see>
    /// </summary>
    let triggers = _prefix "triggers"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#ends"></see>
    /// </summary>
    let ends = _prefix "ends"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#begins"></see>
    /// </summary>
    let begins = _prefix "begins"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Force"></see>
    /// </summary>
    let Force = _prefix "Force"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasSolution"></see>
    /// </summary>
    let hasSolution = _prefix "hasSolution"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasFunctionalPart"></see>
    /// </summary>
    let hasFunctionalPart = _prefix "hasFunctionalPart"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#HeterogeneousMixture"></see>
    /// </summary>
    let HeterogeneousMixture = _prefix "HeterogeneousMixture"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Mixture"></see>
    /// </summary>
    let Mixture = _prefix "Mixture"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#HomogeneousMixture"></see>
    /// </summary>
    let HomogeneousMixture = _prefix "HomogeneousMixture"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#InformationFlow"></see>
    /// </summary>
    let InformationFlow = _prefix "InformationFlow"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Interaction"></see>
    /// </summary>
    let Interaction = _prefix "Interaction"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#overConnection"></see>
    /// </summary>
    let overConnection = _prefix "overConnection"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#transferType"></see>
    /// </summary>
    let transferType = _prefix "transferType"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#overInterface"></see>
    /// </summary>
    let overInterface = _prefix "overInterface"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Interface"></see>
    /// </summary>
    let Interface = _prefix "Interface"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#MaterialFlow"></see>
    /// </summary>
    let MaterialFlow = _prefix "MaterialFlow"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Matter"></see>
    /// </summary>
    let Matter = _prefix "Matter"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#aggregationStateType"></see>
    /// </summary>
    let aggregationStateType = _prefix "aggregationStateType"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#chemicalFormula"></see>
    /// </summary>
    let chemicalFormula = _prefix "chemicalFormula"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#MatterPortion"></see>
    /// </summary>
    let MatterPortion = _prefix "MatterPortion"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#portion"></see>
    /// </summary>
    let portion = _prefix "portion"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#RelationReference"></see>
    /// </summary>
    let RelationReference = _prefix "RelationReference"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#QuantityValue"></see>
    /// </summary>
    let QuantityValue = _prefix "QuantityValue"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#consistsOf"></see>
    /// </summary>
    let consistsOf = _prefix "consistsOf"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Objectification"></see>
    /// </summary>
    let Objectification = _prefix "Objectification"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#isDescribedBy"></see>
    /// </summary>
    let isDescribedBy = _prefix "isDescribedBy"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#isConnectedTo"></see>
    /// </summary>
    let isConnectedTo = _prefix "isConnectedTo"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#executes"></see>
    /// </summary>
    let executes = _prefix "executes"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#participatesIn"></see>
    /// </summary>
    let participatesIn = _prefix "participatesIn"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#isPlanFor"></see>
    /// </summary>
    let isPlanFor = _prefix "isPlanFor"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#QualityValue"></see>
    /// </summary>
    let QualityValue = _prefix "QualityValue"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Requirement"></see>
    /// </summary>
    let Requirement = _prefix "Requirement"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#requirementSeverityType"></see>
    /// </summary>
    let requirementSeverityType = _prefix "requirementSeverityType"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#RequirementSeverityType"></see>
    /// </summary>
    let RequirementSeverityType = _prefix "RequirementSeverityType"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#requirementTopicType"></see>
    /// </summary>
    let requirementTopicType = _prefix "requirementTopicType"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#RequirementTopicType"></see>
    /// </summary>
    let RequirementTopicType = _prefix "RequirementTopicType"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#requirementSourceType"></see>
    /// </summary>
    let requirementSourceType = _prefix "requirementSourceType"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#RequirementSourceType"></see>
    /// </summary>
    let RequirementSourceType = _prefix "RequirementSourceType"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#isBoundBy"></see>
    /// </summary>
    let isBoundBy = _prefix "isBoundBy"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#contains"></see>
    /// </summary>
    let contains = _prefix "contains"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasTechnicalPart"></see>
    /// </summary>
    let hasTechnicalPart = _prefix "hasTechnicalPart"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#abbreviation"></see>
    /// </summary>
    let abbreviation = _prefix "abbreviation"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasRequirement"></see>
    /// </summary>
    let hasRequirement = _prefix "hasRequirement"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasQuantityKind"></see>
    /// </summary>
    let hasQuantityKind = _prefix "hasQuantityKind"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasQuantityKindShape"></see>
    /// </summary>
    let hasQuantityKindShape = _prefix "hasQuantityKindShape"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasUnit"></see>
    /// </summary>
    let hasUnit = _prefix "hasUnit"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasUnitShape"></see>
    /// </summary>
    let hasUnitShape = _prefix "hasUnitShape"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#isImplementedBy"></see>
    /// </summary>
    let isImplementedBy = _prefix "isImplementedBy"
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#isRealizedBy"></see>
    /// </summary>
    let isRealizedBy = _prefix "isRealizedBy"
