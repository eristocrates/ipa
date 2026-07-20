namespace https.w3id.org.arco.ontology.core.slash

open DoxAletheia

module arco =
    let _namespace_name = "https://w3id.org/arco/ontology/core/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The class representing the generic concept of situation.
    /// <see href="https://w3id.org/arco/ontology/core/Situation"></see></summary>
    let Situation = _prefix "Situation"
    /// <summary>
    /// This class represents a situation in which an agent holds a role, regardless of the timing.
    /// <see href="https://w3id.org/arco/ontology/core/AgentRole"></see></summary>
    let AgentRole = _prefix "AgentRole"
    /// <summary>
    /// This property relates a situation in which an agent holds a role to that role.
    /// <see href="https://w3id.org/arco/ontology/core/hasRole"></see></summary>
    let hasRole = _prefix "hasRole"
    /// <summary>
    /// This property relates a situation in which an agent holds a role to that agent.
    /// <see href="https://w3id.org/arco/ontology/core/hasAgent"></see></summary>
    let hasAgent = _prefix "hasAgent"
    /// <summary>
    /// The class that models the concept of classification.
    /// <see href="https://w3id.org/arco/ontology/core/Classification"></see></summary>
    let Classification = _prefix "Classification"
    /// <summary>
    /// The class representing a category.
    /// <see href="https://w3id.org/arco/ontology/core/Category"></see></summary>
    let Category = _prefix "Category"
    /// <summary>
    /// The class representing a concept.
    /// <see href="https://w3id.org/arco/ontology/core/Concept"></see></summary>
    let Concept = _prefix "Concept"
    /// <summary>
    /// The class representing the characteristic of a cultural entity (e.g. a cultural property).
    /// <see href="https://w3id.org/arco/ontology/core/CulturalEntityCharacteristic"></see></summary>
    let CulturalEntityCharacteristic = _prefix "CulturalEntityCharacteristic"
    /// <summary>
    /// The class that models the concept of cultural entity classification.
    /// <see href="https://w3id.org/arco/ontology/core/CulturalEntityClassification"></see></summary>
    let CulturalEntityClassification = _prefix "CulturalEntityClassification"
    /// <summary>
    /// The class representing the concept of method.
    /// <see href="https://w3id.org/arco/ontology/core/Method"></see></summary>
    let Method = _prefix "Method"
    /// <summary>
    /// The class representing the generic concept of time indexed situation.
    /// <see href="https://w3id.org/arco/ontology/core/TimeIndexedSituation"></see></summary>
    let TimeIndexedSituation = _prefix "TimeIndexedSituation"
    /// <summary>
    /// The class representing the concept of type.
    /// <see href="https://w3id.org/arco/ontology/core/Type"></see></summary>
    let Type = _prefix "Type"
    /// <summary>
    /// This property relates a description associated to an entity, in order to add details and some more information.
    /// <see href="https://w3id.org/arco/ontology/core/description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// This property relates an agent to a situation in which that agent holds a role.
    /// <see href="https://w3id.org/arco/ontology/core/isAgentOf"></see></summary>
    let isAgentOf = _prefix "isAgentOf"
    /// <summary>
    /// This property relates an entity to a situation in which an agent holds a role connected to that entity.
    /// <see href="https://w3id.org/arco/ontology/core/hasAgentRole"></see></summary>
    let hasAgentRole = _prefix "hasAgentRole"
    /// <summary>
    /// The property that links any object to a situation.
    /// <see href="https://w3id.org/arco/ontology/core/hasSituation"></see></summary>
    let hasSituation = _prefix "hasSituation"
    /// <summary>
    /// This property relates a situation in which an agent holds a role connected to an entity to that entity.
    /// <see href="https://w3id.org/arco/ontology/core/isAgentRoleOf"></see></summary>
    let isAgentRoleOf = _prefix "isAgentRoleOf"
    /// <summary>
    /// The object property that associates any object with a category.
    /// <see href="https://w3id.org/arco/ontology/core/hasCategory"></see></summary>
    let hasCategory = _prefix "hasCategory"
    /// <summary>
    /// The object property that associates any object with a concept, classifying it.
    /// <see href="https://w3id.org/arco/ontology/core/hasConcept"></see></summary>
    let hasConcept = _prefix "hasConcept"
    /// <summary>
    /// The object property that associates a category to any object.
    /// <see href="https://w3id.org/arco/ontology/core/isCategoryOf"></see></summary>
    let isCategoryOf = _prefix "isCategoryOf"
    /// <summary>
    /// The object property that links an entity to one of its characteristics.
    /// <see href="https://w3id.org/arco/ontology/core/hasCharacteristic"></see></summary>
    let hasCharacteristic = _prefix "hasCharacteristic"
    /// <summary>
    /// The object property that links an entity characteristic to the entity.
    /// <see href="https://w3id.org/arco/ontology/core/isCharacteristicOf"></see></summary>
    let isCharacteristicOf = _prefix "isCharacteristicOf"
    /// <summary>
    /// The object property that allows to add a classification to any object.
    /// <see href="https://w3id.org/arco/ontology/core/hasClassification"></see></summary>
    let hasClassification = _prefix "hasClassification"
    /// <summary>
    /// The inverse object property of hasClassification, that links an object to a classification.
    /// <see href="https://w3id.org/arco/ontology/core/isClassificationOf"></see></summary>
    let isClassificationOf = _prefix "isClassificationOf"
    /// <summary>
    /// This property relates, non-transitively, an entity to a component.
    /// <see href="https://w3id.org/arco/ontology/core/hasComponent"></see></summary>
    let hasComponent = _prefix "hasComponent"
    /// <summary>
    /// This property relates an entity to its part.
    /// <see href="https://w3id.org/arco/ontology/core/hasPart"></see></summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    /// This property relates, non-transitively, a component to an entity of which it is component.
    /// <see href="https://w3id.org/arco/ontology/core/isComponentOf"></see></summary>
    let isComponentOf = _prefix "isComponentOf"
    /// <summary>
    /// The inverse property of hasConcept, that relates a concept to any object.
    /// <see href="https://w3id.org/arco/ontology/core/isConceptOf"></see></summary>
    let isConceptOf = _prefix "isConceptOf"
    /// <summary>
    /// The object property that links a cultural entity to one of its characteristics.
    /// <see href="https://w3id.org/arco/ontology/core/hasCulturalEntityCharacteristic"></see></summary>
    let hasCulturalEntityCharacteristic = _prefix "hasCulturalEntityCharacteristic"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/core/isCulturalEntityCharacteristicOf"></see>
    /// </summary>
    let isCulturalEntityCharacteristicOf = _prefix "isCulturalEntityCharacteristicOf"
    /// <summary>
    /// The object property that associates an entity to a location.
    /// <see href="https://w3id.org/arco/ontology/core/hasLocation"></see></summary>
    let hasLocation = _prefix "hasLocation"
    /// <summary>
    /// The object property that associates a location to an entity located there.
    /// <see href="https://w3id.org/arco/ontology/core/isLocationOf"></see></summary>
    let isLocationOf = _prefix "isLocationOf"
    /// <summary>
    /// The object property that links an entity to a method.
    /// <see href="https://w3id.org/arco/ontology/core/hasMethod"></see></summary>
    let hasMethod = _prefix "hasMethod"
    /// <summary>
    /// The object property that links a method to an entity.
    /// <see href="https://w3id.org/arco/ontology/core/isMethodOf"></see></summary>
    let isMethodOf = _prefix "isMethodOf"
    /// <summary>
    /// This property relates the part of an entity to that entity.
    /// <see href="https://w3id.org/arco/ontology/core/isPartOf"></see></summary>
    let isPartOf = _prefix "isPartOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/core/iccdNormTag"></see>
    /// </summary>
    let iccdNormTag = _prefix "iccdNormTag"
    /// <summary>
    /// This property relates a role to a situation in which an agent holds that role.
    /// <see href="https://w3id.org/arco/ontology/core/isRoleOf"></see></summary>
    let isRoleOf = _prefix "isRoleOf"
    /// <summary>
    /// The property that links a situation to any object. The property is modelled as inverse object property of hasSituation.
    /// <see href="https://w3id.org/arco/ontology/core/isSituationOf"></see></summary>
    let isSituationOf = _prefix "isSituationOf"
    /// <summary>
    /// The property that links any object to a time indexed situation.
    /// <see href="https://w3id.org/arco/ontology/core/hasTimeIndexedSituation"></see></summary>
    let hasTimeIndexedSituation = _prefix "hasTimeIndexedSituation"
    /// <summary>
    /// The property that links a time indexed situation to any object. The property is modelled as inverse object property of hasTimeIndexedSituation.
    /// <see href="https://w3id.org/arco/ontology/core/isTimeIndexedSituationOf"></see></summary>
    let isTimeIndexedSituationOf = _prefix "isTimeIndexedSituationOf"
    /// <summary>
    /// The object property that associates any object with a type.
    /// <see href="https://w3id.org/arco/ontology/core/hasType"></see></summary>
    let hasType = _prefix "hasType"
    /// <summary>
    /// The object property that associates a type to any object.
    /// <see href="https://w3id.org/arco/ontology/core/isTypeOf"></see></summary>
    let isTypeOf = _prefix "isTypeOf"
    /// <summary>
    /// This property represents a keyword related to an entity, used to search for that entity.
    /// <see href="https://w3id.org/arco/ontology/core/keyword"></see></summary>
    let keyword = _prefix "keyword"
    /// <summary>
    /// This property represents notes associated to a piece of information.
    /// <see href="https://w3id.org/arco/ontology/core/note"></see></summary>
    let note = _prefix "note"
    /// <summary>
    /// This property represents specifications associated to a piece of information.
    /// <see href="https://w3id.org/arco/ontology/core/specifications"></see></summary>
    let specifications = _prefix "specifications"
