namespace https.w3id.org.arco.ontology.core.slash

open DoxAletheia.Rdf_Vocabulary

module arco =
    let _namespace_name = "https://w3id.org/arco/ontology/core/"
    /// <summary>
    /// The class representing the generic concept of situation.
    /// <see href="https://w3id.org/arco/ontology/core/Situation"></see></summary>
    let Situation = Namespaced_IRI.parse _namespace_name "Situation" |> NamespacedName
    /// <summary>
    /// This class represents a situation in which an agent holds a role, regardless of the timing.
    /// <see href="https://w3id.org/arco/ontology/core/AgentRole"></see></summary>
    let AgentRole = Namespaced_IRI.parse _namespace_name "AgentRole" |> NamespacedName
    /// <summary>
    /// This property relates a situation in which an agent holds a role to that role.
    /// <see href="https://w3id.org/arco/ontology/core/hasRole"></see></summary>
    let hasRole = Namespaced_IRI.parse _namespace_name "hasRole" |> NamespacedName
    /// <summary>
    /// This property relates a situation in which an agent holds a role to that agent.
    /// <see href="https://w3id.org/arco/ontology/core/hasAgent"></see></summary>
    let hasAgent = Namespaced_IRI.parse _namespace_name "hasAgent" |> NamespacedName

    /// <summary>
    /// The class that models the concept of classification.
    /// <see href="https://w3id.org/arco/ontology/core/Classification"></see></summary>
    let Classification =
        Namespaced_IRI.parse _namespace_name "Classification" |> NamespacedName

    /// <summary>
    /// The class representing a category.
    /// <see href="https://w3id.org/arco/ontology/core/Category"></see></summary>
    let Category = Namespaced_IRI.parse _namespace_name "Category" |> NamespacedName
    /// <summary>
    /// The class representing a concept.
    /// <see href="https://w3id.org/arco/ontology/core/Concept"></see></summary>
    let Concept = Namespaced_IRI.parse _namespace_name "Concept" |> NamespacedName

    /// <summary>
    /// The class representing the characteristic of a cultural entity (e.g. a cultural property).
    /// <see href="https://w3id.org/arco/ontology/core/CulturalEntityCharacteristic"></see></summary>
    let CulturalEntityCharacteristic =
        Namespaced_IRI.parse _namespace_name "CulturalEntityCharacteristic" |> NamespacedName

    /// <summary>
    /// The class that models the concept of cultural entity classification.
    /// <see href="https://w3id.org/arco/ontology/core/CulturalEntityClassification"></see></summary>
    let CulturalEntityClassification =
        Namespaced_IRI.parse _namespace_name "CulturalEntityClassification" |> NamespacedName

    /// <summary>
    /// The class representing the concept of method.
    /// <see href="https://w3id.org/arco/ontology/core/Method"></see></summary>
    let Method = Namespaced_IRI.parse _namespace_name "Method" |> NamespacedName

    /// <summary>
    /// The class representing the generic concept of time indexed situation.
    /// <see href="https://w3id.org/arco/ontology/core/TimeIndexedSituation"></see></summary>
    let TimeIndexedSituation =
        Namespaced_IRI.parse _namespace_name "TimeIndexedSituation" |> NamespacedName

    /// <summary>
    /// The class representing the concept of type.
    /// <see href="https://w3id.org/arco/ontology/core/Type"></see></summary>
    let Type = Namespaced_IRI.parse _namespace_name "Type" |> NamespacedName

    /// <summary>
    /// This property relates a description associated to an entity, in order to add details and some more information.
    /// <see href="https://w3id.org/arco/ontology/core/description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// This property relates an agent to a situation in which that agent holds a role.
    /// <see href="https://w3id.org/arco/ontology/core/isAgentOf"></see></summary>
    let isAgentOf = Namespaced_IRI.parse _namespace_name "isAgentOf" |> NamespacedName

    /// <summary>
    /// This property relates an entity to a situation in which an agent holds a role connected to that entity.
    /// <see href="https://w3id.org/arco/ontology/core/hasAgentRole"></see></summary>
    let hasAgentRole =
        Namespaced_IRI.parse _namespace_name "hasAgentRole" |> NamespacedName

    /// <summary>
    /// The property that links any object to a situation.
    /// <see href="https://w3id.org/arco/ontology/core/hasSituation"></see></summary>
    let hasSituation =
        Namespaced_IRI.parse _namespace_name "hasSituation" |> NamespacedName

    /// <summary>
    /// This property relates a situation in which an agent holds a role connected to an entity to that entity.
    /// <see href="https://w3id.org/arco/ontology/core/isAgentRoleOf"></see></summary>
    let isAgentRoleOf =
        Namespaced_IRI.parse _namespace_name "isAgentRoleOf" |> NamespacedName

    /// <summary>
    /// The object property that associates any object with a category.
    /// <see href="https://w3id.org/arco/ontology/core/hasCategory"></see></summary>
    let hasCategory =
        Namespaced_IRI.parse _namespace_name "hasCategory" |> NamespacedName

    /// <summary>
    /// The object property that associates any object with a concept, classifying it.
    /// <see href="https://w3id.org/arco/ontology/core/hasConcept"></see></summary>
    let hasConcept = Namespaced_IRI.parse _namespace_name "hasConcept" |> NamespacedName

    /// <summary>
    /// The object property that associates a category to any object.
    /// <see href="https://w3id.org/arco/ontology/core/isCategoryOf"></see></summary>
    let isCategoryOf =
        Namespaced_IRI.parse _namespace_name "isCategoryOf" |> NamespacedName

    /// <summary>
    /// The object property that links an entity to one of its characteristics.
    /// <see href="https://w3id.org/arco/ontology/core/hasCharacteristic"></see></summary>
    let hasCharacteristic =
        Namespaced_IRI.parse _namespace_name "hasCharacteristic" |> NamespacedName

    /// <summary>
    /// The object property that links an entity characteristic to the entity.
    /// <see href="https://w3id.org/arco/ontology/core/isCharacteristicOf"></see></summary>
    let isCharacteristicOf =
        Namespaced_IRI.parse _namespace_name "isCharacteristicOf" |> NamespacedName

    /// <summary>
    /// The object property that allows to add a classification to any object.
    /// <see href="https://w3id.org/arco/ontology/core/hasClassification"></see></summary>
    let hasClassification =
        Namespaced_IRI.parse _namespace_name "hasClassification" |> NamespacedName

    /// <summary>
    /// The inverse object property of hasClassification, that links an object to a classification.
    /// <see href="https://w3id.org/arco/ontology/core/isClassificationOf"></see></summary>
    let isClassificationOf =
        Namespaced_IRI.parse _namespace_name "isClassificationOf" |> NamespacedName

    /// <summary>
    /// This property relates, non-transitively, an entity to a component.
    /// <see href="https://w3id.org/arco/ontology/core/hasComponent"></see></summary>
    let hasComponent =
        Namespaced_IRI.parse _namespace_name "hasComponent" |> NamespacedName

    /// <summary>
    /// This property relates an entity to its part.
    /// <see href="https://w3id.org/arco/ontology/core/hasPart"></see></summary>
    let hasPart = Namespaced_IRI.parse _namespace_name "hasPart" |> NamespacedName

    /// <summary>
    /// This property relates, non-transitively, a component to an entity of which it is component.
    /// <see href="https://w3id.org/arco/ontology/core/isComponentOf"></see></summary>
    let isComponentOf =
        Namespaced_IRI.parse _namespace_name "isComponentOf" |> NamespacedName

    /// <summary>
    /// The inverse property of hasConcept, that relates a concept to any object.
    /// <see href="https://w3id.org/arco/ontology/core/isConceptOf"></see></summary>
    let isConceptOf =
        Namespaced_IRI.parse _namespace_name "isConceptOf" |> NamespacedName

    /// <summary>
    /// The object property that links a cultural entity to one of its characteristics.
    /// <see href="https://w3id.org/arco/ontology/core/hasCulturalEntityCharacteristic"></see></summary>
    let hasCulturalEntityCharacteristic =
        Namespaced_IRI.parse _namespace_name "hasCulturalEntityCharacteristic" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/core/isCulturalEntityCharacteristicOf"></see>
    /// </summary>
    let isCulturalEntityCharacteristicOf =
        Namespaced_IRI.parse _namespace_name "isCulturalEntityCharacteristicOf" |> NamespacedName

    /// <summary>
    /// The object property that associates an entity to a location.
    /// <see href="https://w3id.org/arco/ontology/core/hasLocation"></see></summary>
    let hasLocation =
        Namespaced_IRI.parse _namespace_name "hasLocation" |> NamespacedName

    /// <summary>
    /// The object property that associates a location to an entity located there.
    /// <see href="https://w3id.org/arco/ontology/core/isLocationOf"></see></summary>
    let isLocationOf =
        Namespaced_IRI.parse _namespace_name "isLocationOf" |> NamespacedName

    /// <summary>
    /// The object property that links an entity to a method.
    /// <see href="https://w3id.org/arco/ontology/core/hasMethod"></see></summary>
    let hasMethod = Namespaced_IRI.parse _namespace_name "hasMethod" |> NamespacedName
    /// <summary>
    /// The object property that links a method to an entity.
    /// <see href="https://w3id.org/arco/ontology/core/isMethodOf"></see></summary>
    let isMethodOf = Namespaced_IRI.parse _namespace_name "isMethodOf" |> NamespacedName
    /// <summary>
    /// This property relates the part of an entity to that entity.
    /// <see href="https://w3id.org/arco/ontology/core/isPartOf"></see></summary>
    let isPartOf = Namespaced_IRI.parse _namespace_name "isPartOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/core/iccdNormTag"></see>
    /// </summary>
    let iccdNormTag =
        Namespaced_IRI.parse _namespace_name "iccdNormTag" |> NamespacedName

    /// <summary>
    /// This property relates a role to a situation in which an agent holds that role.
    /// <see href="https://w3id.org/arco/ontology/core/isRoleOf"></see></summary>
    let isRoleOf = Namespaced_IRI.parse _namespace_name "isRoleOf" |> NamespacedName

    /// <summary>
    /// The property that links a situation to any object. The property is modelled as inverse object property of hasSituation.
    /// <see href="https://w3id.org/arco/ontology/core/isSituationOf"></see></summary>
    let isSituationOf =
        Namespaced_IRI.parse _namespace_name "isSituationOf" |> NamespacedName

    /// <summary>
    /// The property that links any object to a time indexed situation.
    /// <see href="https://w3id.org/arco/ontology/core/hasTimeIndexedSituation"></see></summary>
    let hasTimeIndexedSituation =
        Namespaced_IRI.parse _namespace_name "hasTimeIndexedSituation" |> NamespacedName

    /// <summary>
    /// The property that links a time indexed situation to any object. The property is modelled as inverse object property of hasTimeIndexedSituation.
    /// <see href="https://w3id.org/arco/ontology/core/isTimeIndexedSituationOf"></see></summary>
    let isTimeIndexedSituationOf =
        Namespaced_IRI.parse _namespace_name "isTimeIndexedSituationOf" |> NamespacedName

    /// <summary>
    /// The object property that associates any object with a type.
    /// <see href="https://w3id.org/arco/ontology/core/hasType"></see></summary>
    let hasType = Namespaced_IRI.parse _namespace_name "hasType" |> NamespacedName
    /// <summary>
    /// The object property that associates a type to any object.
    /// <see href="https://w3id.org/arco/ontology/core/isTypeOf"></see></summary>
    let isTypeOf = Namespaced_IRI.parse _namespace_name "isTypeOf" |> NamespacedName
    /// <summary>
    /// This property represents a keyword related to an entity, used to search for that entity.
    /// <see href="https://w3id.org/arco/ontology/core/keyword"></see></summary>
    let keyword = Namespaced_IRI.parse _namespace_name "keyword" |> NamespacedName
    /// <summary>
    /// This property represents notes associated to a piece of information.
    /// <see href="https://w3id.org/arco/ontology/core/note"></see></summary>
    let note = Namespaced_IRI.parse _namespace_name "note" |> NamespacedName

    /// <summary>
    /// This property represents specifications associated to a piece of information.
    /// <see href="https://w3id.org/arco/ontology/core/specifications"></see></summary>
    let specifications =
        Namespaced_IRI.parse _namespace_name "specifications" |> NamespacedName
