namespace http.umbel.org.umbel.hash

open DoxAletheia

module umbel =
    let _namespace_name = "http://umbel.org/umbel#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#AbstractLevel"></see>
    /// </summary>
    let AbstractLevel = _prefix "AbstractLevel"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#SuperType"></see>
    /// </summary>
    let SuperType = _prefix "SuperType"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Activities"></see>
    /// </summary>
    let Activities = _prefix "Activities"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Animals"></see>
    /// </summary>
    let Animals = _prefix "Animals"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#AudioInfo"></see>
    /// </summary>
    let AudioInfo = _prefix "AudioInfo"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Chemistry"></see>
    /// </summary>
    let Chemistry = _prefix "Chemistry"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Drugs"></see>
    /// </summary>
    let Drugs = _prefix "Drugs"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Earthscape"></see>
    /// </summary>
    let Earthscape = _prefix "Earthscape"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Extraterrestrial"></see>
    /// </summary>
    let Extraterrestrial = _prefix "Extraterrestrial"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Facilities"></see>
    /// </summary>
    let Facilities = _prefix "Facilities"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Geopolitical"></see>
    /// </summary>
    let Geopolitical = _prefix "Geopolitical"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#NaturalSubstances"></see>
    /// </summary>
    let NaturalSubstances = _prefix "NaturalSubstances"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Numbers"></see>
    /// </summary>
    let Numbers = _prefix "Numbers"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Organizations"></see>
    /// </summary>
    let Organizations = _prefix "Organizations"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#PersonTypes"></see>
    /// </summary>
    let PersonTypes = _prefix "PersonTypes"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Plants"></see>
    /// </summary>
    let Plants = _prefix "Plants"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Prokaryotes"></see>
    /// </summary>
    let Prokaryotes = _prefix "Prokaryotes"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#ProtistsFungus"></see>
    /// </summary>
    let ProtistsFungus = _prefix "ProtistsFungus"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Society"></see>
    /// </summary>
    let Society = _prefix "Society"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Time"></see>
    /// </summary>
    let Time = _prefix "Time"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Workplaces"></see>
    /// </summary>
    let Workplaces = _prefix "Workplaces"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Events"></see>
    /// </summary>
    let Events = _prefix "Events"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#FinanceEconomy"></see>
    /// </summary>
    let FinanceEconomy = _prefix "FinanceEconomy"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#NaturalPhenomena"></see>
    /// </summary>
    let NaturalPhenomena = _prefix "NaturalPhenomena"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Notations"></see>
    /// </summary>
    let Notations = _prefix "Notations"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#StructuredInfo"></see>
    /// </summary>
    let StructuredInfo = _prefix "StructuredInfo"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#VisualInfo"></see>
    /// </summary>
    let VisualInfo = _prefix "VisualInfo"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#WrittenInfo"></see>
    /// </summary>
    let WrittenInfo = _prefix "WrittenInfo"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Attributes"></see>
    /// </summary>
    let Attributes = _prefix "Attributes"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Diseases"></see>
    /// </summary>
    let Diseases = _prefix "Diseases"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#FoodDrink"></see>
    /// </summary>
    let FoodDrink = _prefix "FoodDrink"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#AutomaticInspectedSMatch"></see>
    /// </summary>
    let AutomaticInspectedSMatch = _prefix "AutomaticInspectedSMatch"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Qualifier"></see>
    /// </summary>
    let Qualifier = _prefix "Qualifier"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#AutomaticInspectedSV"></see>
    /// </summary>
    let AutomaticInspectedSV = _prefix "AutomaticInspectedSV"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#AutomaticNotSpecified"></see>
    /// </summary>
    let AutomaticNotSpecified = _prefix "AutomaticNotSpecified"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Products"></see>
    /// </summary>
    let Products = _prefix "Products"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#ExternalDBOntologyMapping"></see>
    /// </summary>
    let ExternalDBOntologyMapping = _prefix "ExternalDBOntologyMapping"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#ExternalGeoNamesMapping"></see>
    /// </summary>
    let ExternalGeoNamesMapping = _prefix "ExternalGeoNamesMapping"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#ExternalOpenCycMapping"></see>
    /// </summary>
    let ExternalOpenCycMapping = _prefix "ExternalOpenCycMapping"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#HeuristicListOfBasis"></see>
    /// </summary>
    let HeuristicListOfBasis = _prefix "HeuristicListOfBasis"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#HeuristicNotSpecified"></see>
    /// </summary>
    let HeuristicNotSpecified = _prefix "HeuristicNotSpecified"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#ManualNearlyEquivalent"></see>
    /// </summary>
    let ManualNearlyEquivalent = _prefix "ManualNearlyEquivalent"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#ManualSimilarSense"></see>
    /// </summary>
    let ManualSimilarSense = _prefix "ManualSimilarSense"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#MarketsIndustries"></see>
    /// </summary>
    let MarketsIndustries = _prefix "MarketsIndustries"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#RefConcept"></see>
    /// </summary>
    let RefConcept = _prefix "RefConcept"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#isRelatedTo"></see>
    /// </summary>
    let isRelatedTo = _prefix "isRelatedTo"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#TopicsCategories"></see>
    /// </summary>
    let TopicsCategories = _prefix "TopicsCategories"
    /// <summary>
    /// The property umbel:correspondsTo is used to assert a close correspondence between an external class, named entity, individual or instance with a Reference Concept class. umbel:correspondsTo relates the external class, named entity, individual or instance to the class through the basis of both its subject matter and intended scope. This predicate should be used where the correspondence between the two entities is felt to be nearly equivalent to a sameAs assertion, and is reflexive, but without the full entailments of intensional class memberships. In these cases, both entities are understood to have the same type and intended scope, but without asserting a full class-level or sameAs individual relationship.
    ///
    /// This predicate is designed for the circumstance of aligning two different ontologies or knowledge bases based on node-level correspondences, but without entailing the actual ontological relationships and structure of the object source. For example, the umbel:correspondsTo predicate is used to assert close correspondence between UMBEL Reference Concepts and Wikipedia categories or pages, yet without entailing the actual Wikipedia category structure.
    ///
    /// This property asserts a different and stronger relationship than umbel:isAbout. One practical use is to guide specific instance member determinations when, say, the native structure of the external ontology or knowledge base is to be analyzed and replaced with an UMBEL-based structure.
    ///
    /// This property is therefore used to create a nearly equivalent assertion (however, with the degree of that equivalence being unknown or unknowable) between an external instance or class and a Reference Concept class
    /// <see href="http://umbel.org/umbel#correspondsTo"></see></summary>
    let correspondsTo = _prefix "correspondsTo"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#hasCharacteristic"></see>
    /// </summary>
    let hasCharacteristic = _prefix "hasCharacteristic"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#hasMapping"></see>
    /// </summary>
    let hasMapping = _prefix "hasMapping"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#isAbout"></see>
    /// </summary>
    let isAbout = _prefix "isAbout"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#isCharacteristicOf"></see>
    /// </summary>
    let isCharacteristicOf = _prefix "isCharacteristicOf"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#isLike"></see>
    /// </summary>
    let isLike = _prefix "isLike"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToAbstraction"></see>
    /// </summary>
    let relatesToAbstraction = _prefix "relatesToAbstraction"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToActivity"></see>
    /// </summary>
    let relatesToActivity = _prefix "relatesToActivity"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToAnimal"></see>
    /// </summary>
    let relatesToAnimal = _prefix "relatesToAnimal"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToAttribute"></see>
    /// </summary>
    let relatesToAttribute = _prefix "relatesToAttribute"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToAudioInfo"></see>
    /// </summary>
    let relatesToAudioInfo = _prefix "relatesToAudioInfo"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToChemistry"></see>
    /// </summary>
    let relatesToChemistry = _prefix "relatesToChemistry"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToDisease"></see>
    /// </summary>
    let relatesToDisease = _prefix "relatesToDisease"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToDrug"></see>
    /// </summary>
    let relatesToDrug = _prefix "relatesToDrug"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToEarth"></see>
    /// </summary>
    let relatesToEarth = _prefix "relatesToEarth"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToEvent"></see>
    /// </summary>
    let relatesToEvent = _prefix "relatesToEvent"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToFacility"></see>
    /// </summary>
    let relatesToFacility = _prefix "relatesToFacility"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToFinanceEconomy"></see>
    /// </summary>
    let relatesToFinanceEconomy = _prefix "relatesToFinanceEconomy"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToFoodDrink"></see>
    /// </summary>
    let relatesToFoodDrink = _prefix "relatesToFoodDrink"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToGeoEntity"></see>
    /// </summary>
    let relatesToGeoEntity = _prefix "relatesToGeoEntity"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToHeavens"></see>
    /// </summary>
    let relatesToHeavens = _prefix "relatesToHeavens"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToMarketIndustry"></see>
    /// </summary>
    let relatesToMarketIndustry = _prefix "relatesToMarketIndustry"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToNotation"></see>
    /// </summary>
    let relatesToNotation = _prefix "relatesToNotation"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToNumbers"></see>
    /// </summary>
    let relatesToNumbers = _prefix "relatesToNumbers"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToOrganizationType"></see>
    /// </summary>
    let relatesToOrganizationType = _prefix "relatesToOrganizationType"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToOtherOrganism"></see>
    /// </summary>
    let relatesToOtherOrganism = _prefix "relatesToOtherOrganism"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToPersonType"></see>
    /// </summary>
    let relatesToPersonType = _prefix "relatesToPersonType"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToPhenomenon"></see>
    /// </summary>
    let relatesToPhenomenon = _prefix "relatesToPhenomenon"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToPlant"></see>
    /// </summary>
    let relatesToPlant = _prefix "relatesToPlant"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToProductType"></see>
    /// </summary>
    let relatesToProductType = _prefix "relatesToProductType"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToSociety"></see>
    /// </summary>
    let relatesToSociety = _prefix "relatesToSociety"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToStructuredInfo"></see>
    /// </summary>
    let relatesToStructuredInfo = _prefix "relatesToStructuredInfo"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToSubstance"></see>
    /// </summary>
    let relatesToSubstance = _prefix "relatesToSubstance"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToTime"></see>
    /// </summary>
    let relatesToTime = _prefix "relatesToTime"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToTopic"></see>
    /// </summary>
    let relatesToTopic = _prefix "relatesToTopic"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToVisualInfo"></see>
    /// </summary>
    let relatesToVisualInfo = _prefix "relatesToVisualInfo"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToWorkplace"></see>
    /// </summary>
    let relatesToWorkplace = _prefix "relatesToWorkplace"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToWrittenInfo"></see>
    /// </summary>
    let relatesToWrittenInfo = _prefix "relatesToWrittenInfo"
    /// <summary>
    ///   <see href="http://umbel.org/umbel#superPropertyOf"></see>
    /// </summary>
    let superPropertyOf = _prefix "superPropertyOf"
