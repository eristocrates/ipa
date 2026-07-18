namespace https.w3id.org.nen2660.def.hash

open DoxAletheia.Rdf_Vocabulary

module nen2660 =
    let _namespace_name = "https://w3id.org/nen2660/def#"

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#EnumerationType"></see>
    /// </summary>
    let EnumerationType =
        Namespaced_IRI.parse _namespace_name "EnumerationType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Representation"></see>
    /// </summary>
    let Representation =
        Namespaced_IRI.parse _namespace_name "Representation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#AbstractConcept"></see>
    /// </summary>
    let AbstractConcept =
        Namespaced_IRI.parse _namespace_name "AbstractConcept" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#TopConcept"></see>
    /// </summary>
    let TopConcept = Namespaced_IRI.parse _namespace_name "TopConcept" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Activity"></see>
    /// </summary>
    let Activity = Namespaced_IRI.parse _namespace_name "Activity" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasPart"></see>
    /// </summary>
    let hasPart = Namespaced_IRI.parse _namespace_name "hasPart" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Entity"></see>
    /// </summary>
    let Entity = Namespaced_IRI.parse _namespace_name "Entity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasBoundary"></see>
    /// </summary>
    let hasBoundary =
        Namespaced_IRI.parse _namespace_name "hasBoundary" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#GeometricEntity"></see>
    /// </summary>
    let GeometricEntity =
        Namespaced_IRI.parse _namespace_name "GeometricEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasInterior"></see>
    /// </summary>
    let hasInterior =
        Namespaced_IRI.parse _namespace_name "hasInterior" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#transforms"></see>
    /// </summary>
    let transforms = Namespaced_IRI.parse _namespace_name "transforms" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Object"></see>
    /// </summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasPeriod"></see>
    /// </summary>
    let hasPeriod = Namespaced_IRI.parse _namespace_name "hasPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#AggregationStateType"></see>
    /// </summary>
    let AggregationStateType =
        Namespaced_IRI.parse _namespace_name "AggregationStateType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Solid"></see>
    /// </summary>
    let Solid = Namespaced_IRI.parse _namespace_name "Solid" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Liquid"></see>
    /// </summary>
    let Liquid = Namespaced_IRI.parse _namespace_name "Liquid" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Gas"></see>
    /// </summary>
    let Gas = Namespaced_IRI.parse _namespace_name "Gas" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Plasma"></see>
    /// </summary>
    let Plasma = Namespaced_IRI.parse _namespace_name "Plasma" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#AllDisjointClassesShape"></see>
    /// </summary>
    let AllDisjointClassesShape =
        Namespaced_IRI.parse _namespace_name "AllDisjointClassesShape" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#RealObject"></see>
    /// </summary>
    let RealObject = Namespaced_IRI.parse _namespace_name "RealObject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#SpatialRegion"></see>
    /// </summary>
    let SpatialRegion =
        Namespaced_IRI.parse _namespace_name "SpatialRegion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#FunctionalEntity"></see>
    /// </summary>
    let FunctionalEntity =
        Namespaced_IRI.parse _namespace_name "FunctionalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#TechnicalEntity"></see>
    /// </summary>
    let TechnicalEntity =
        Namespaced_IRI.parse _namespace_name "TechnicalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#PlannedEntity"></see>
    /// </summary>
    let PlannedEntity =
        Namespaced_IRI.parse _namespace_name "PlannedEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#RealizedEntity"></see>
    /// </summary>
    let RealizedEntity =
        Namespaced_IRI.parse _namespace_name "RealizedEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#PhysicalObject"></see>
    /// </summary>
    let PhysicalObject =
        Namespaced_IRI.parse _namespace_name "PhysicalObject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#InformationObject"></see>
    /// </summary>
    let InformationObject =
        Namespaced_IRI.parse _namespace_name "InformationObject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#State"></see>
    /// </summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Event"></see>
    /// </summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#AllDisjointClasses_1"></see>
    /// </summary>
    let AllDisjointClasses_1 =
        Namespaced_IRI.parse _namespace_name "AllDisjointClasses_1" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#AllDisjointClasses_2"></see>
    /// </summary>
    let AllDisjointClasses_2 =
        Namespaced_IRI.parse _namespace_name "AllDisjointClasses_2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#AllDisjointClasses_3"></see>
    /// </summary>
    let AllDisjointClasses_3 =
        Namespaced_IRI.parse _namespace_name "AllDisjointClasses_3" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#AllDisjointClasses_4"></see>
    /// </summary>
    let AllDisjointClasses_4 =
        Namespaced_IRI.parse _namespace_name "AllDisjointClasses_4" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#AmountOfBulkMatter"></see>
    /// </summary>
    let AmountOfBulkMatter =
        Namespaced_IRI.parse _namespace_name "AmountOfBulkMatter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#ChemicalCompound"></see>
    /// </summary>
    let ChemicalCompound =
        Namespaced_IRI.parse _namespace_name "ChemicalCompound" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#PureSubstance"></see>
    /// </summary>
    let PureSubstance =
        Namespaced_IRI.parse _namespace_name "PureSubstance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#ChemicalElement"></see>
    /// </summary>
    let ChemicalElement =
        Namespaced_IRI.parse _namespace_name "ChemicalElement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#ConceptType"></see>
    /// </summary>
    let ConceptType =
        Namespaced_IRI.parse _namespace_name "ConceptType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Type"></see>
    /// </summary>
    let Type = Namespaced_IRI.parse _namespace_name "Type" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#ConcreteConcept"></see>
    /// </summary>
    let ConcreteConcept =
        Namespaced_IRI.parse _namespace_name "ConcreteConcept" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasTemporalEntity"></see>
    /// </summary>
    let hasTemporalEntity =
        Namespaced_IRI.parse _namespace_name "hasTemporalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasPartsGroup"></see>
    /// </summary>
    let hasPartsGroup =
        Namespaced_IRI.parse _namespace_name "hasPartsGroup" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Connection"></see>
    /// </summary>
    let Connection = Namespaced_IRI.parse _namespace_name "Connection" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#connectsObject"></see>
    /// </summary>
    let connectsObject =
        Namespaced_IRI.parse _namespace_name "connectsObject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#connectsPort"></see>
    /// </summary>
    let connectsPort =
        Namespaced_IRI.parse _namespace_name "connectsPort" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Port"></see>
    /// </summary>
    let Port = Namespaced_IRI.parse _namespace_name "Port" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#DiscreteObject"></see>
    /// </summary>
    let DiscreteObject =
        Namespaced_IRI.parse _namespace_name "DiscreteObject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#EnergyFlow"></see>
    /// </summary>
    let EnergyFlow = Namespaced_IRI.parse _namespace_name "EnergyFlow" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#TransferType"></see>
    /// </summary>
    let TransferType =
        Namespaced_IRI.parse _namespace_name "TransferType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasState"></see>
    /// </summary>
    let hasState = Namespaced_IRI.parse _namespace_name "hasState" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#triggers"></see>
    /// </summary>
    let triggers = Namespaced_IRI.parse _namespace_name "triggers" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#ends"></see>
    /// </summary>
    let ends = Namespaced_IRI.parse _namespace_name "ends" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#begins"></see>
    /// </summary>
    let begins = Namespaced_IRI.parse _namespace_name "begins" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Force"></see>
    /// </summary>
    let Force = Namespaced_IRI.parse _namespace_name "Force" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasSolution"></see>
    /// </summary>
    let hasSolution =
        Namespaced_IRI.parse _namespace_name "hasSolution" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasFunctionalPart"></see>
    /// </summary>
    let hasFunctionalPart =
        Namespaced_IRI.parse _namespace_name "hasFunctionalPart" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#HeterogeneousMixture"></see>
    /// </summary>
    let HeterogeneousMixture =
        Namespaced_IRI.parse _namespace_name "HeterogeneousMixture" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Mixture"></see>
    /// </summary>
    let Mixture = Namespaced_IRI.parse _namespace_name "Mixture" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#HomogeneousMixture"></see>
    /// </summary>
    let HomogeneousMixture =
        Namespaced_IRI.parse _namespace_name "HomogeneousMixture" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#InformationFlow"></see>
    /// </summary>
    let InformationFlow =
        Namespaced_IRI.parse _namespace_name "InformationFlow" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Interaction"></see>
    /// </summary>
    let Interaction =
        Namespaced_IRI.parse _namespace_name "Interaction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#overConnection"></see>
    /// </summary>
    let overConnection =
        Namespaced_IRI.parse _namespace_name "overConnection" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#transferType"></see>
    /// </summary>
    let transferType =
        Namespaced_IRI.parse _namespace_name "transferType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#overInterface"></see>
    /// </summary>
    let overInterface =
        Namespaced_IRI.parse _namespace_name "overInterface" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Interface"></see>
    /// </summary>
    let Interface = Namespaced_IRI.parse _namespace_name "Interface" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#MaterialFlow"></see>
    /// </summary>
    let MaterialFlow =
        Namespaced_IRI.parse _namespace_name "MaterialFlow" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Matter"></see>
    /// </summary>
    let Matter = Namespaced_IRI.parse _namespace_name "Matter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#aggregationStateType"></see>
    /// </summary>
    let aggregationStateType =
        Namespaced_IRI.parse _namespace_name "aggregationStateType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#chemicalFormula"></see>
    /// </summary>
    let chemicalFormula =
        Namespaced_IRI.parse _namespace_name "chemicalFormula" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#MatterPortion"></see>
    /// </summary>
    let MatterPortion =
        Namespaced_IRI.parse _namespace_name "MatterPortion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#portion"></see>
    /// </summary>
    let portion = Namespaced_IRI.parse _namespace_name "portion" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#RelationReference"></see>
    /// </summary>
    let RelationReference =
        Namespaced_IRI.parse _namespace_name "RelationReference" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#QuantityValue"></see>
    /// </summary>
    let QuantityValue =
        Namespaced_IRI.parse _namespace_name "QuantityValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#consistsOf"></see>
    /// </summary>
    let consistsOf = Namespaced_IRI.parse _namespace_name "consistsOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Objectification"></see>
    /// </summary>
    let Objectification =
        Namespaced_IRI.parse _namespace_name "Objectification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#isDescribedBy"></see>
    /// </summary>
    let isDescribedBy =
        Namespaced_IRI.parse _namespace_name "isDescribedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#isConnectedTo"></see>
    /// </summary>
    let isConnectedTo =
        Namespaced_IRI.parse _namespace_name "isConnectedTo" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#executes"></see>
    /// </summary>
    let executes = Namespaced_IRI.parse _namespace_name "executes" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#participatesIn"></see>
    /// </summary>
    let participatesIn =
        Namespaced_IRI.parse _namespace_name "participatesIn" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#isPlanFor"></see>
    /// </summary>
    let isPlanFor = Namespaced_IRI.parse _namespace_name "isPlanFor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#QualityValue"></see>
    /// </summary>
    let QualityValue =
        Namespaced_IRI.parse _namespace_name "QualityValue" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#Requirement"></see>
    /// </summary>
    let Requirement =
        Namespaced_IRI.parse _namespace_name "Requirement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#requirementSeverityType"></see>
    /// </summary>
    let requirementSeverityType =
        Namespaced_IRI.parse _namespace_name "requirementSeverityType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#RequirementSeverityType"></see>
    /// </summary>
    let RequirementSeverityType =
        Namespaced_IRI.parse _namespace_name "RequirementSeverityType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#requirementTopicType"></see>
    /// </summary>
    let requirementTopicType =
        Namespaced_IRI.parse _namespace_name "requirementTopicType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#RequirementTopicType"></see>
    /// </summary>
    let RequirementTopicType =
        Namespaced_IRI.parse _namespace_name "RequirementTopicType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#requirementSourceType"></see>
    /// </summary>
    let requirementSourceType =
        Namespaced_IRI.parse _namespace_name "requirementSourceType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#RequirementSourceType"></see>
    /// </summary>
    let RequirementSourceType =
        Namespaced_IRI.parse _namespace_name "RequirementSourceType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#isBoundBy"></see>
    /// </summary>
    let isBoundBy = Namespaced_IRI.parse _namespace_name "isBoundBy" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#contains"></see>
    /// </summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasTechnicalPart"></see>
    /// </summary>
    let hasTechnicalPart =
        Namespaced_IRI.parse _namespace_name "hasTechnicalPart" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#abbreviation"></see>
    /// </summary>
    let abbreviation =
        Namespaced_IRI.parse _namespace_name "abbreviation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasRequirement"></see>
    /// </summary>
    let hasRequirement =
        Namespaced_IRI.parse _namespace_name "hasRequirement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasQuantityKind"></see>
    /// </summary>
    let hasQuantityKind =
        Namespaced_IRI.parse _namespace_name "hasQuantityKind" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasQuantityKindShape"></see>
    /// </summary>
    let hasQuantityKindShape =
        Namespaced_IRI.parse _namespace_name "hasQuantityKindShape" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasUnit"></see>
    /// </summary>
    let hasUnit = Namespaced_IRI.parse _namespace_name "hasUnit" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#hasUnitShape"></see>
    /// </summary>
    let hasUnitShape =
        Namespaced_IRI.parse _namespace_name "hasUnitShape" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#isImplementedBy"></see>
    /// </summary>
    let isImplementedBy =
        Namespaced_IRI.parse _namespace_name "isImplementedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/nen2660/def#isRealizedBy"></see>
    /// </summary>
    let isRealizedBy =
        Namespaced_IRI.parse _namespace_name "isRealizedBy" |> NamespacedName
