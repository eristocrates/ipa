namespace http.umbel.org.umbel.hash

open DoxAletheia.Rdf_Vocabulary

module umbel =
    let _namespace_name = "http://umbel.org/umbel#"

    /// <summary>
    ///   <see href="http://umbel.org/umbel#AbstractLevel"></see>
    /// </summary>
    let AbstractLevel =
        Namespaced_IRI.parse _namespace_name "AbstractLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#SuperType"></see>
    /// </summary>
    let SuperType = Namespaced_IRI.parse _namespace_name "SuperType" |> NamespacedName
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Activities"></see>
    /// </summary>
    let Activities = Namespaced_IRI.parse _namespace_name "Activities" |> NamespacedName
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Animals"></see>
    /// </summary>
    let Animals = Namespaced_IRI.parse _namespace_name "Animals" |> NamespacedName
    /// <summary>
    ///   <see href="http://umbel.org/umbel#AudioInfo"></see>
    /// </summary>
    let AudioInfo = Namespaced_IRI.parse _namespace_name "AudioInfo" |> NamespacedName
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Chemistry"></see>
    /// </summary>
    let Chemistry = Namespaced_IRI.parse _namespace_name "Chemistry" |> NamespacedName
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Drugs"></see>
    /// </summary>
    let Drugs = Namespaced_IRI.parse _namespace_name "Drugs" |> NamespacedName
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Earthscape"></see>
    /// </summary>
    let Earthscape = Namespaced_IRI.parse _namespace_name "Earthscape" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#Extraterrestrial"></see>
    /// </summary>
    let Extraterrestrial =
        Namespaced_IRI.parse _namespace_name "Extraterrestrial" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#Facilities"></see>
    /// </summary>
    let Facilities = Namespaced_IRI.parse _namespace_name "Facilities" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#Geopolitical"></see>
    /// </summary>
    let Geopolitical =
        Namespaced_IRI.parse _namespace_name "Geopolitical" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#NaturalSubstances"></see>
    /// </summary>
    let NaturalSubstances =
        Namespaced_IRI.parse _namespace_name "NaturalSubstances" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#Numbers"></see>
    /// </summary>
    let Numbers = Namespaced_IRI.parse _namespace_name "Numbers" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#Organizations"></see>
    /// </summary>
    let Organizations =
        Namespaced_IRI.parse _namespace_name "Organizations" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#PersonTypes"></see>
    /// </summary>
    let PersonTypes =
        Namespaced_IRI.parse _namespace_name "PersonTypes" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#Plants"></see>
    /// </summary>
    let Plants = Namespaced_IRI.parse _namespace_name "Plants" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#Prokaryotes"></see>
    /// </summary>
    let Prokaryotes =
        Namespaced_IRI.parse _namespace_name "Prokaryotes" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#ProtistsFungus"></see>
    /// </summary>
    let ProtistsFungus =
        Namespaced_IRI.parse _namespace_name "ProtistsFungus" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#Society"></see>
    /// </summary>
    let Society = Namespaced_IRI.parse _namespace_name "Society" |> NamespacedName
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Time"></see>
    /// </summary>
    let Time = Namespaced_IRI.parse _namespace_name "Time" |> NamespacedName
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Workplaces"></see>
    /// </summary>
    let Workplaces = Namespaced_IRI.parse _namespace_name "Workplaces" |> NamespacedName
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Events"></see>
    /// </summary>
    let Events = Namespaced_IRI.parse _namespace_name "Events" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#FinanceEconomy"></see>
    /// </summary>
    let FinanceEconomy =
        Namespaced_IRI.parse _namespace_name "FinanceEconomy" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#NaturalPhenomena"></see>
    /// </summary>
    let NaturalPhenomena =
        Namespaced_IRI.parse _namespace_name "NaturalPhenomena" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#Notations"></see>
    /// </summary>
    let Notations = Namespaced_IRI.parse _namespace_name "Notations" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#StructuredInfo"></see>
    /// </summary>
    let StructuredInfo =
        Namespaced_IRI.parse _namespace_name "StructuredInfo" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#VisualInfo"></see>
    /// </summary>
    let VisualInfo = Namespaced_IRI.parse _namespace_name "VisualInfo" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#WrittenInfo"></see>
    /// </summary>
    let WrittenInfo =
        Namespaced_IRI.parse _namespace_name "WrittenInfo" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#Attributes"></see>
    /// </summary>
    let Attributes = Namespaced_IRI.parse _namespace_name "Attributes" |> NamespacedName
    /// <summary>
    ///   <see href="http://umbel.org/umbel#Diseases"></see>
    /// </summary>
    let Diseases = Namespaced_IRI.parse _namespace_name "Diseases" |> NamespacedName
    /// <summary>
    ///   <see href="http://umbel.org/umbel#FoodDrink"></see>
    /// </summary>
    let FoodDrink = Namespaced_IRI.parse _namespace_name "FoodDrink" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#AutomaticInspectedSMatch"></see>
    /// </summary>
    let AutomaticInspectedSMatch =
        Namespaced_IRI.parse _namespace_name "AutomaticInspectedSMatch" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#Qualifier"></see>
    /// </summary>
    let Qualifier = Namespaced_IRI.parse _namespace_name "Qualifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#AutomaticInspectedSV"></see>
    /// </summary>
    let AutomaticInspectedSV =
        Namespaced_IRI.parse _namespace_name "AutomaticInspectedSV" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#AutomaticNotSpecified"></see>
    /// </summary>
    let AutomaticNotSpecified =
        Namespaced_IRI.parse _namespace_name "AutomaticNotSpecified" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#Products"></see>
    /// </summary>
    let Products = Namespaced_IRI.parse _namespace_name "Products" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#ExternalDBOntologyMapping"></see>
    /// </summary>
    let ExternalDBOntologyMapping =
        Namespaced_IRI.parse _namespace_name "ExternalDBOntologyMapping" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#ExternalGeoNamesMapping"></see>
    /// </summary>
    let ExternalGeoNamesMapping =
        Namespaced_IRI.parse _namespace_name "ExternalGeoNamesMapping" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#ExternalOpenCycMapping"></see>
    /// </summary>
    let ExternalOpenCycMapping =
        Namespaced_IRI.parse _namespace_name "ExternalOpenCycMapping" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#HeuristicListOfBasis"></see>
    /// </summary>
    let HeuristicListOfBasis =
        Namespaced_IRI.parse _namespace_name "HeuristicListOfBasis" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#HeuristicNotSpecified"></see>
    /// </summary>
    let HeuristicNotSpecified =
        Namespaced_IRI.parse _namespace_name "HeuristicNotSpecified" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#ManualNearlyEquivalent"></see>
    /// </summary>
    let ManualNearlyEquivalent =
        Namespaced_IRI.parse _namespace_name "ManualNearlyEquivalent" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#ManualSimilarSense"></see>
    /// </summary>
    let ManualSimilarSense =
        Namespaced_IRI.parse _namespace_name "ManualSimilarSense" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#MarketsIndustries"></see>
    /// </summary>
    let MarketsIndustries =
        Namespaced_IRI.parse _namespace_name "MarketsIndustries" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#RefConcept"></see>
    /// </summary>
    let RefConcept = Namespaced_IRI.parse _namespace_name "RefConcept" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#isRelatedTo"></see>
    /// </summary>
    let isRelatedTo =
        Namespaced_IRI.parse _namespace_name "isRelatedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#TopicsCategories"></see>
    /// </summary>
    let TopicsCategories =
        Namespaced_IRI.parse _namespace_name "TopicsCategories" |> NamespacedName

    /// <summary>
    /// The property umbel:correspondsTo is used to assert a close correspondence between an external class, named entity, individual or instance with a Reference Concept class. umbel:correspondsTo relates the external class, named entity, individual or instance to the class through the basis of both its subject matter and intended scope. This predicate should be used where the correspondence between the two entities is felt to be nearly equivalent to a sameAs assertion, and is reflexive, but without the full entailments of intensional class memberships. In these cases, both entities are understood to have the same type and intended scope, but without asserting a full class-level or sameAs individual relationship.
    ///
    /// This predicate is designed for the circumstance of aligning two different ontologies or knowledge bases based on node-level correspondences, but without entailing the actual ontological relationships and structure of the object source. For example, the umbel:correspondsTo predicate is used to assert close correspondence between UMBEL Reference Concepts and Wikipedia categories or pages, yet without entailing the actual Wikipedia category structure.
    ///
    /// This property asserts a different and stronger relationship than umbel:isAbout. One practical use is to guide specific instance member determinations when, say, the native structure of the external ontology or knowledge base is to be analyzed and replaced with an UMBEL-based structure.
    ///
    /// This property is therefore used to create a nearly equivalent assertion (however, with the degree of that equivalence being unknown or unknowable) between an external instance or class and a Reference Concept class
    /// <see href="http://umbel.org/umbel#correspondsTo"></see></summary>
    let correspondsTo =
        Namespaced_IRI.parse _namespace_name "correspondsTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#hasCharacteristic"></see>
    /// </summary>
    let hasCharacteristic =
        Namespaced_IRI.parse _namespace_name "hasCharacteristic" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#hasMapping"></see>
    /// </summary>
    let hasMapping = Namespaced_IRI.parse _namespace_name "hasMapping" |> NamespacedName
    /// <summary>
    ///   <see href="http://umbel.org/umbel#isAbout"></see>
    /// </summary>
    let isAbout = Namespaced_IRI.parse _namespace_name "isAbout" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#isCharacteristicOf"></see>
    /// </summary>
    let isCharacteristicOf =
        Namespaced_IRI.parse _namespace_name "isCharacteristicOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#isLike"></see>
    /// </summary>
    let isLike = Namespaced_IRI.parse _namespace_name "isLike" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToAbstraction"></see>
    /// </summary>
    let relatesToAbstraction =
        Namespaced_IRI.parse _namespace_name "relatesToAbstraction" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToActivity"></see>
    /// </summary>
    let relatesToActivity =
        Namespaced_IRI.parse _namespace_name "relatesToActivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToAnimal"></see>
    /// </summary>
    let relatesToAnimal =
        Namespaced_IRI.parse _namespace_name "relatesToAnimal" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToAttribute"></see>
    /// </summary>
    let relatesToAttribute =
        Namespaced_IRI.parse _namespace_name "relatesToAttribute" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToAudioInfo"></see>
    /// </summary>
    let relatesToAudioInfo =
        Namespaced_IRI.parse _namespace_name "relatesToAudioInfo" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToChemistry"></see>
    /// </summary>
    let relatesToChemistry =
        Namespaced_IRI.parse _namespace_name "relatesToChemistry" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToDisease"></see>
    /// </summary>
    let relatesToDisease =
        Namespaced_IRI.parse _namespace_name "relatesToDisease" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToDrug"></see>
    /// </summary>
    let relatesToDrug =
        Namespaced_IRI.parse _namespace_name "relatesToDrug" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToEarth"></see>
    /// </summary>
    let relatesToEarth =
        Namespaced_IRI.parse _namespace_name "relatesToEarth" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToEvent"></see>
    /// </summary>
    let relatesToEvent =
        Namespaced_IRI.parse _namespace_name "relatesToEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToFacility"></see>
    /// </summary>
    let relatesToFacility =
        Namespaced_IRI.parse _namespace_name "relatesToFacility" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToFinanceEconomy"></see>
    /// </summary>
    let relatesToFinanceEconomy =
        Namespaced_IRI.parse _namespace_name "relatesToFinanceEconomy" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToFoodDrink"></see>
    /// </summary>
    let relatesToFoodDrink =
        Namespaced_IRI.parse _namespace_name "relatesToFoodDrink" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToGeoEntity"></see>
    /// </summary>
    let relatesToGeoEntity =
        Namespaced_IRI.parse _namespace_name "relatesToGeoEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToHeavens"></see>
    /// </summary>
    let relatesToHeavens =
        Namespaced_IRI.parse _namespace_name "relatesToHeavens" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToMarketIndustry"></see>
    /// </summary>
    let relatesToMarketIndustry =
        Namespaced_IRI.parse _namespace_name "relatesToMarketIndustry" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToNotation"></see>
    /// </summary>
    let relatesToNotation =
        Namespaced_IRI.parse _namespace_name "relatesToNotation" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToNumbers"></see>
    /// </summary>
    let relatesToNumbers =
        Namespaced_IRI.parse _namespace_name "relatesToNumbers" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToOrganizationType"></see>
    /// </summary>
    let relatesToOrganizationType =
        Namespaced_IRI.parse _namespace_name "relatesToOrganizationType" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToOtherOrganism"></see>
    /// </summary>
    let relatesToOtherOrganism =
        Namespaced_IRI.parse _namespace_name "relatesToOtherOrganism" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToPersonType"></see>
    /// </summary>
    let relatesToPersonType =
        Namespaced_IRI.parse _namespace_name "relatesToPersonType" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToPhenomenon"></see>
    /// </summary>
    let relatesToPhenomenon =
        Namespaced_IRI.parse _namespace_name "relatesToPhenomenon" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToPlant"></see>
    /// </summary>
    let relatesToPlant =
        Namespaced_IRI.parse _namespace_name "relatesToPlant" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToProductType"></see>
    /// </summary>
    let relatesToProductType =
        Namespaced_IRI.parse _namespace_name "relatesToProductType" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToSociety"></see>
    /// </summary>
    let relatesToSociety =
        Namespaced_IRI.parse _namespace_name "relatesToSociety" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToStructuredInfo"></see>
    /// </summary>
    let relatesToStructuredInfo =
        Namespaced_IRI.parse _namespace_name "relatesToStructuredInfo" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToSubstance"></see>
    /// </summary>
    let relatesToSubstance =
        Namespaced_IRI.parse _namespace_name "relatesToSubstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToTime"></see>
    /// </summary>
    let relatesToTime =
        Namespaced_IRI.parse _namespace_name "relatesToTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToTopic"></see>
    /// </summary>
    let relatesToTopic =
        Namespaced_IRI.parse _namespace_name "relatesToTopic" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToVisualInfo"></see>
    /// </summary>
    let relatesToVisualInfo =
        Namespaced_IRI.parse _namespace_name "relatesToVisualInfo" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToWorkplace"></see>
    /// </summary>
    let relatesToWorkplace =
        Namespaced_IRI.parse _namespace_name "relatesToWorkplace" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#relatesToWrittenInfo"></see>
    /// </summary>
    let relatesToWrittenInfo =
        Namespaced_IRI.parse _namespace_name "relatesToWrittenInfo" |> NamespacedName

    /// <summary>
    ///   <see href="http://umbel.org/umbel#superPropertyOf"></see>
    /// </summary>
    let superPropertyOf =
        Namespaced_IRI.parse _namespace_name "superPropertyOf" |> NamespacedName
