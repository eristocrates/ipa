namespace https.w3id.org.arco.ontology.denotative_description.slash

open DoxAletheia.Rdf_Vocabulary

module ddesc =
    let _namespace_name = "https://w3id.org/arco/ontology/denotative-description/"

    /// <summary>
    /// This class represents the type (i.e. civil, religious) of an inscription, emblem, postmark, crest, etc.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/AffixedElementType"></see></summary>
    let AffixedElementType =
        Namespaced_IRI.parse _namespace_name "AffixedElementType" |> NamespacedName

    /// <summary>
    /// This class represents the type of communication medium.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CommunicationMediumType"></see></summary>
    let CommunicationMediumType =
        Namespaced_IRI.parse _namespace_name "CommunicationMediumType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/ConservationStatusType"></see>
    /// </summary>
    let ConservationStatusType =
        Namespaced_IRI.parse _namespace_name "ConservationStatusType" |> NamespacedName

    /// <summary>
    /// This class represents a cultural property's type, that is the term or expression which specifies the cultural propery that is being catalogued and additional information on the cultural property's definition.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CulturalPropertyType"></see></summary>
    let CulturalPropertyType =
        Namespaced_IRI.parse _namespace_name "CulturalPropertyType" |> NamespacedName

    /// <summary>
    /// This class represents a cultural property's denomination or dedication type, or its title (i.e. other language, current, attributed, dialectal).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/DesignationType"></see></summary>
    let DesignationType =
        Namespaced_IRI.parse _namespace_name "DesignationType" |> NamespacedName

    /// <summary>
    /// This class represents the iconographic or decorative apparatus' type (iconographic, decorative, iconographic-decorative) of a cultual property.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/IconographicOrDecorativeApparatusType"></see></summary>
    let IconographicOrDecorativeApparatusType =
        Namespaced_IRI.parse _namespace_name "IconographicOrDecorativeApparatusType" |> NamespacedName

    /// <summary>
    /// This class represents the observed measurement type (width, height, diameter, etc).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/MeasurementType"></see></summary>
    let MeasurementType =
        Namespaced_IRI.parse _namespace_name "MeasurementType" |> NamespacedName

    /// <summary>
    /// This class represents the sample type collected from an archaeologiacal property (i.e. coal, pottery, grout)
    /// <see href="https://w3id.org/arco/ontology/denotative-description/SampleCollectedType"></see></summary>
    let SampleCollectedType =
        Namespaced_IRI.parse _namespace_name "SampleCollectedType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Accessible"></see>
    /// </summary>
    let Accessible = Namespaced_IRI.parse _namespace_name "Accessible" |> NamespacedName

    /// <summary>
    /// This class represents the cultural property accessibility, that is the possibility to reach or enter that cultural property, for example for cataloguing activities (e.g.: an immovable cultural property located in a walled area, a movable cultural property located on the top shelf, a totally accessible cultural property, etc.)
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CulturalPropertyAccessibility"></see></summary>
    let CulturalPropertyAccessibility =
        Namespaced_IRI.parse _namespace_name "CulturalPropertyAccessibility" |> NamespacedName

    /// <summary>
    /// This class represents an accessory of a musical property, both if it is functional to the sound production, or if it is the sound's production or conservation medium.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Accessory"></see></summary>
    let Accessory = Namespaced_IRI.parse _namespace_name "Accessory" |> NamespacedName

    /// <summary>
    /// This property represents the date of construction of a musical instrument's accessory.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/creationDate"></see></summary>
    let creationDate =
        Namespaced_IRI.parse _namespace_name "creationDate" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has accessory".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isAccessoryOf"></see></summary>
    let isAccessoryOf =
        Namespaced_IRI.parse _namespace_name "isAccessoryOf" |> NamespacedName

    /// <summary>
    /// This class represents an element (i.e. crest, trademark, postmark, inscription) which is affixed on a cultural property.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/AffixedElement"></see></summary>
    let AffixedElement =
        Namespaced_IRI.parse _namespace_name "AffixedElement" |> NamespacedName

    /// <summary>
    /// This property connects an inscription, emblem etc., to the text's transcription, using scientifically accepted integrations.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/transcript"></see></summary>
    let transcript = Namespaced_IRI.parse _namespace_name "transcript" |> NamespacedName

    /// <summary>
    /// This property represents the italian translation of a text transcription contained in an inscription, emblem etc.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/italianTranslation"></see></summary>
    let italianTranslation =
        Namespaced_IRI.parse _namespace_name "italianTranslation" |> NamespacedName

    /// <summary>
    /// This property connects an inscription, stamp, emblem etc., represented on a cultural entity to the support on which the entity is located.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasSupport"></see></summary>
    let hasSupport = Namespaced_IRI.parse _namespace_name "hasSupport" |> NamespacedName
    /// <summary>
    /// This class represents the support on which an element can be located, for instance an inscription, emblem, postmark represented on a cultural property (i.e. "paper label").
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Support"></see></summary>
    let Support = Namespaced_IRI.parse _namespace_name "Support" |> NamespacedName

    /// <summary>
    /// This property realtes an object (e.g. cultural entity, iconographic/decorative apparatus, affixed element like an inscription) to its functional purpose, intended as the function the object has to perform (decorative, religious, symbolic, magic-offensive etc.).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasFunctionalPurpose"></see></summary>
    let hasFunctionalPurpose =
        Namespaced_IRI.parse _namespace_name "hasFunctionalPurpose" |> NamespacedName

    /// <summary>
    /// This class represents the functional purpose (i.e. decorative, religious, symbolic, magic-offensive) of an object (i.e. culural property or iconographic/decorative apparatus or affixed element on a cultural property like an inscription). The functional purpose is intended as the function that an object has to perform.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/FunctionalPurpose"></see></summary>
    let FunctionalPurpose =
        Namespaced_IRI.parse _namespace_name "FunctionalPurpose" |> NamespacedName

    /// <summary>
    /// This property connects an inscription, stamp, crest etc., to the adopted writing system or alphabet.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasWritingSystem"></see></summary>
    let hasWritingSystem =
        Namespaced_IRI.parse _namespace_name "hasWritingSystem" |> NamespacedName

    /// <summary>
    /// This class represents the writing system or alphabet of an inscription, postmark, crest etc.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/WritingSystem"></see></summary>
    let WritingSystem =
        Namespaced_IRI.parse _namespace_name "WritingSystem" |> NamespacedName

    /// <summary>
    /// This property connects an inscription or emblem, postmark, crest, etc. to the font style which has been adopted (e.g.: italic, bold, gothic etc).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasFontStyle"></see></summary>
    let hasFontStyle =
        Namespaced_IRI.parse _namespace_name "hasFontStyle" |> NamespacedName

    /// <summary>
    /// This class represents the font style used in a text (i.e. italic, bold, gothic)
    /// <see href="https://w3id.org/arco/ontology/denotative-description/FontStyle"></see></summary>
    let FontStyle = Namespaced_IRI.parse _namespace_name "FontStyle" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has affixed element".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isElementAffixedOn"></see></summary>
    let isElementAffixedOn =
        Namespaced_IRI.parse _namespace_name "isElementAffixedOn" |> NamespacedName

    /// <summary>
    /// This property connects a cultural entity to its technical status, valid until a specific moment, that is represented by the technical characteristics that a cultural entity has in that moment.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasTechnicalStatus"></see></summary>
    let hasTechnicalStatus =
        Namespaced_IRI.parse _namespace_name "hasTechnicalStatus" |> NamespacedName

    /// <summary>
    /// This class represents the technical status of a cultural entity, that is a situation in which the cultural entity is associated to technical characteristics. The technical status has a temporal validity, related to the moment when the characteristics were observed. For instance, a cultural property techncal status is: "the cultural property X realized with pottery material and cylindrical in shape".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CulturalEntityTechnicalStatus"></see></summary>
    let CulturalEntityTechnicalStatus =
        Namespaced_IRI.parse _namespace_name "CulturalEntityTechnicalStatus" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has affixed element type".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isAffixedElementTypeOf"></see></summary>
    let isAffixedElementTypeOf =
        Namespaced_IRI.parse _namespace_name "isAffixedElementTypeOf" |> NamespacedName

    /// <summary>
    /// This class represents the age range (child, teenager, adult, old person) of a person.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/AgeRange"></see></summary>
    let AgeRange = Namespaced_IRI.parse _namespace_name "AgeRange" |> NamespacedName

    /// <summary>
    /// This class represents the communication medium of an object, defined by the communication medium type (e.g.: verbal, written, instrumental), the implementation method, the number of voices or instruments involved, etc.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CommunicationMedium"></see></summary>
    let CommunicationMedium =
        Namespaced_IRI.parse _namespace_name "CommunicationMedium" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "involves age range".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isAgeRangeInvolvedIn"></see></summary>
    let isAgeRangeInvolvedIn =
        Namespaced_IRI.parse _namespace_name "isAgeRangeInvolvedIn" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Area"></see>
    /// </summary>
    let Area = Namespaced_IRI.parse _namespace_name "Area" |> NamespacedName

    /// <summary>
    /// This individual represents an attributed denomination.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/AssignedDesignation"></see></summary>
    let AssignedDesignation =
        Namespaced_IRI.parse _namespace_name "AssignedDesignation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Available"></see>
    /// </summary>
    let Available = Namespaced_IRI.parse _namespace_name "Available" |> NamespacedName

    /// <summary>
    /// This class represents the availability of a cultural property, wheter the cultural property is available or not (e.g.: theft, destruction) for example for cataloguing activities.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CulturalPropertyAvailability"></see></summary>
    let CulturalPropertyAvailability =
        Namespaced_IRI.parse _namespace_name "CulturalPropertyAvailability" |> NamespacedName

    /// <summary>
    /// This individual represents playable notes by a musical instrument, from low to high.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/AvailableNotes"></see></summary>
    let AvailableNotes =
        Namespaced_IRI.parse _namespace_name "AvailableNotes" |> NamespacedName

    /// <summary>
    /// This class represents a technical concept, a particular type of concept that classifies a technical characteristic of an entity, e.g. cultural property. For instance, "material" is a techincal concept that classifies the technical characteristic "pottery" related to a cultural property.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/TechnicalConcept"></see></summary>
    let TechnicalConcept =
        Namespaced_IRI.parse _namespace_name "TechnicalConcept" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/BackTotalLength"></see>
    /// </summary>
    let BackTotalLength =
        Namespaced_IRI.parse _namespace_name "BackTotalLength" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/BackWidth"></see>
    /// </summary>
    let BackWidth = Namespaced_IRI.parse _namespace_name "BackWidth" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/BadConservationStatus"></see>
    /// </summary>
    let BadConservationStatus =
        Namespaced_IRI.parse _namespace_name "BadConservationStatus" |> NamespacedName

    /// <summary>
    /// This class represents a brand, that is a sign, an image, a symbol affixed on an object for identification.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Brand"></see></summary>
    let Brand = Namespaced_IRI.parse _namespace_name "Brand" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Capacity"></see>
    /// </summary>
    let Capacity = Namespaced_IRI.parse _namespace_name "Capacity" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/ChestCircumference"></see>
    /// </summary>
    let ChestCircumference =
        Namespaced_IRI.parse _namespace_name "ChestCircumference" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Circumference"></see>
    /// </summary>
    let Circumference =
        Namespaced_IRI.parse _namespace_name "Circumference" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/CoatOfArms"></see>
    /// </summary>
    let CoatOfArms = Namespaced_IRI.parse _namespace_name "CoatOfArms" |> NamespacedName
    /// <summary>
    /// This class represents the design on the reverse or the obverse of a numismatic property, as the graphical part of what is represented on a side of a coin, together with the legend (lettering and wording).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CoinDesign"></see></summary>
    let CoinDesign = Namespaced_IRI.parse _namespace_name "CoinDesign" |> NamespacedName
    /// <summary>
    /// This class represents the lettering and wording on the reverse or the obverse of a numismatic property.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CoinLegend"></see></summary>
    let CoinLegend = Namespaced_IRI.parse _namespace_name "CoinLegend" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Inscription"></see>
    /// </summary>
    let Inscription =
        Namespaced_IRI.parse _namespace_name "Inscription" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has communication medium".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isCommunicationMediumOf"></see></summary>
    let isCommunicationMediumOf =
        Namespaced_IRI.parse _namespace_name "isCommunicationMediumOf" |> NamespacedName

    /// <summary>
    /// This property relates a communication medium (proxemics, kinesic) to the age range of the participants to the communication.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/involvesAgeRange"></see></summary>
    let involvesAgeRange =
        Namespaced_IRI.parse _namespace_name "involvesAgeRange" |> NamespacedName

    /// <summary>
    /// This property represents the number of the child participants to a communication (verbal, singing, kinesic).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/numberOfChildParticipants"></see></summary>
    let numberOfChildParticipants =
        Namespaced_IRI.parse _namespace_name "numberOfChildParticipants" |> NamespacedName

    /// <summary>
    /// This property relates a verbal or singing or instrumental communication medium to its implementation method (e.g.: polyphonic) associated to it.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasImplementationMethod"></see></summary>
    let hasImplementationMethod =
        Namespaced_IRI.parse _namespace_name "hasImplementationMethod" |> NamespacedName

    /// <summary>
    /// This class represents the implementation method (e.g.: polyphonic) associated to a verbale or singing or instrumental communication medium.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/ImplementationMethod"></see></summary>
    let ImplementationMethod =
        Namespaced_IRI.parse _namespace_name "ImplementationMethod" |> NamespacedName

    /// <summary>
    /// This property represents the number of the male participants to a communication (verbal, singing, kinesic).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/numberOfMaleParticipants"></see></summary>
    let numberOfMaleParticipants =
        Namespaced_IRI.parse _namespace_name "numberOfMaleParticipants" |> NamespacedName

    /// <summary>
    /// This property represents the number of the male participants to a communication (verbal, singing, kinesic).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/numberOfFemaleParticipants"></see></summary>
    let numberOfFemaleParticipants =
        Namespaced_IRI.parse _namespace_name "numberOfFemaleParticipants" |> NamespacedName

    /// <summary>
    /// This property relates a communication medium to its type (e.g.: verbal, singing, etc.)
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasCommunicationMediumType"></see></summary>
    let hasCommunicationMediumType =
        Namespaced_IRI.parse _namespace_name "hasCommunicationMediumType" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has communication medium type".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isCommunicationMediumTypeOf"></see></summary>
    let isCommunicationMediumTypeOf =
        Namespaced_IRI.parse _namespace_name "isCommunicationMediumTypeOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/CompleteLegibility"></see>
    /// </summary>
    let CompleteLegibility =
        Namespaced_IRI.parse _namespace_name "CompleteLegibility" |> NamespacedName

    /// <summary>
    /// This class represents the legibility status (complete, decent, good, lowered, impossible) of a numinsmatic property. It is related to the property's conservation status.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Legibility"></see></summary>
    let Legibility = Namespaced_IRI.parse _namespace_name "Legibility" |> NamespacedName

    /// <summary>
    /// This class represents the conservation status of the cultural property.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/ConservationStatus"></see></summary>
    let ConservationStatus =
        Namespaced_IRI.parse _namespace_name "ConservationStatus" |> NamespacedName

    /// <summary>
    /// This property relates a conservation status to one of its type's values.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasConservationStatusType"></see></summary>
    let hasConservationStatusType =
        Namespaced_IRI.parse _namespace_name "hasConservationStatusType" |> NamespacedName

    /// <summary>
    /// This property relates a conservation status of a cultural property to that cultural property.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isConservationStatusOf"></see></summary>
    let isConservationStatusOf =
        Namespaced_IRI.parse _namespace_name "isConservationStatusOf" |> NamespacedName

    /// <summary>
    /// This property relates a numismatic entity's conservation status to its legibility status.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasLegibility"></see></summary>
    let hasLegibility =
        Namespaced_IRI.parse _namespace_name "hasLegibility" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has conservation status type".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isConservationStatusTypeOf"></see></summary>
    let isConservationStatusTypeOf =
        Namespaced_IRI.parse _namespace_name "isConservationStatusTypeOf" |> NamespacedName

    /// <summary>
    /// This class represent a counterstamp (or countermark), that is a partial or complete over-stamping of a coin, generally affixed in order to change its value or issuing authority.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Counterstamp"></see></summary>
    let Counterstamp =
        Namespaced_IRI.parse _namespace_name "Counterstamp" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/CoveredArea"></see>
    /// </summary>
    let CoveredArea =
        Namespaced_IRI.parse _namespace_name "CoveredArea" |> NamespacedName

    /// <summary>
    /// This class represents the technical description of a cultural entity, which uses all the technical concepts classifying the technical characteristics that a cultural entity can have. This class is a particular type of the class Description, which is the class for socially constructed objects (i.e. texts, values, categories, relations, contexts) used to describe other objects in a structured manner.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CulturalEntityTechnicalDescription"></see></summary>
    let CulturalEntityTechnicalDescription =
        Namespaced_IRI.parse _namespace_name "CulturalEntityTechnicalDescription" |> NamespacedName

    /// <summary>
    /// This property relates a technical description of a cultural property to one of the concepts used in that description.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/usesTechnicalConcept"></see></summary>
    let usesTechnicalConcept =
        Namespaced_IRI.parse _namespace_name "usesTechnicalConcept" |> NamespacedName

    /// <summary>
    /// This property relates a technical description of a cultural entity to a situation that satisfies that description.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isTechnicalDescriptionSatisfiedBy"></see></summary>
    let isTechnicalDescriptionSatisfiedBy =
        Namespaced_IRI.parse _namespace_name "isTechnicalDescriptionSatisfiedBy" |> NamespacedName

    /// <summary>
    /// This class represents a characteristic of a cultural property. For example it can represent a cultural property's particular costituent material or the technique with which it was made or its shape or color. Each technical characteristic is classified by a concept (i.e. "clay" is a techical characteristic classified by the technical concept "material" related to a cultural property). For each cultural property typology can be registered some specific technical characteristics.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/TechnicalCharacteristic"></see></summary>
    let TechnicalCharacteristic =
        Namespaced_IRI.parse _namespace_name "TechnicalCharacteristic" |> NamespacedName

    /// <summary>
    /// This property connects a technical status, with respect to a specific entity (as a cultural entity) to one of the technical characteristics related to that status.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/includesTechnicalCharacteristic"></see></summary>
    let includesTechnicalCharacteristic =
        Namespaced_IRI.parse _namespace_name "includesTechnicalCharacteristic" |> NamespacedName

    /// <summary>
    /// This property connects a technical status to a cultural entity. This status is valid until a specific moment and is represented by the technical characteristics that a cultural entity has in that moment.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isTechnicalStatusOf"></see></summary>
    let isTechnicalStatusOf =
        Namespaced_IRI.parse _namespace_name "isTechnicalStatusOf" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has cultural property accessibility".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isCulturalPropertyAccessibilityOf"></see></summary>
    let isCulturalPropertyAccessibilityOf =
        Namespaced_IRI.parse _namespace_name "isCulturalPropertyAccessibilityOf" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has cultural property availability".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isCulturalPropertyAvailabilityOf"></see></summary>
    let isCulturalPropertyAvailabilityOf =
        Namespaced_IRI.parse _namespace_name "isCulturalPropertyAvailabilityOf" |> NamespacedName

    /// <summary>
    /// This class represents the definition of a cultural property. It is the term or expression which identifies the property that is being catalogued.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CulturalPropertyDefinition"></see></summary>
    let CulturalPropertyDefinition =
        Namespaced_IRI.parse _namespace_name "CulturalPropertyDefinition" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has cultural property definition".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isCulturalPropertyDefinitionOf"></see></summary>
    let isCulturalPropertyDefinitionOf =
        Namespaced_IRI.parse _namespace_name "isCulturalPropertyDefinitionOf" |> NamespacedName

    /// <summary>
    /// This class represents the morphological or functional specification, which are useful to define a cultural property for a more precise individuation.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CulturalPropertySpecification"></see></summary>
    let CulturalPropertySpecification =
        Namespaced_IRI.parse _namespace_name "CulturalPropertySpecification" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has cultural property specification".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isCulturalPropertySpecificationOf"></see></summary>
    let isCulturalPropertySpecificationOf =
        Namespaced_IRI.parse _namespace_name "isCulturalPropertySpecificationOf" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has cultural property type".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isCulturalPropertyTypeOf"></see></summary>
    let isCulturalPropertyTypeOf =
        Namespaced_IRI.parse _namespace_name "isCulturalPropertyTypeOf" |> NamespacedName

    /// <summary>
    /// This property relates a cultural entity's typology to one of its components, i.e.  its definition.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertyDefinition"></see></summary>
    let hasCulturalPropertyDefinition =
        Namespaced_IRI.parse _namespace_name "hasCulturalPropertyDefinition" |> NamespacedName

    /// <summary>
    /// This property relates a cultural entity's typology to its components, i.e. morphological and functional specifications.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertySpecification"></see></summary>
    let hasCulturalPropertySpecification =
        Namespaced_IRI.parse _namespace_name "hasCulturalPropertySpecification" |> NamespacedName

    /// <summary>
    /// This individual represents the current designation.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CurrentDesignation"></see></summary>
    let CurrentDesignation =
        Namespaced_IRI.parse _namespace_name "CurrentDesignation" |> NamespacedName

    /// <summary>
    /// This individual represents the usual designation.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CustomaryDesignation"></see></summary>
    let CustomaryDesignation =
        Namespaced_IRI.parse _namespace_name "CustomaryDesignation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/DecentConservationStatus"></see>
    /// </summary>
    let DecentConservationStatus =
        Namespaced_IRI.parse _namespace_name "DecentConservationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/DecentLegibility"></see>
    /// </summary>
    let DecentLegibility =
        Namespaced_IRI.parse _namespace_name "DecentLegibility" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/DecorativeApparatus"></see>
    /// </summary>
    let DecorativeApparatus =
        Namespaced_IRI.parse _namespace_name "DecorativeApparatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Dedication"></see>
    /// </summary>
    let Dedication = Namespaced_IRI.parse _namespace_name "Dedication" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Depth"></see>
    /// </summary>
    let Depth = Namespaced_IRI.parse _namespace_name "Depth" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/DepthOrHeight"></see>
    /// </summary>
    let DepthOrHeight =
        Namespaced_IRI.parse _namespace_name "DepthOrHeight" |> NamespacedName

    /// <summary>
    /// This class represents a certain cultural property's designation/denomination attested over time.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/DesignationInTime"></see></summary>
    let DesignationInTime =
        Namespaced_IRI.parse _namespace_name "DesignationInTime" |> NamespacedName

    /// <summary>
    /// This property relates a cultural entity designation to its type.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasDesignationType"></see></summary>
    let hasDesignationType =
        Namespaced_IRI.parse _namespace_name "hasDesignationType" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has designation in time".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isDesignationInTimeOf"></see></summary>
    let isDesignationInTimeOf =
        Namespaced_IRI.parse _namespace_name "isDesignationInTimeOf" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has designation type".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isDesignationTypeOf"></see></summary>
    let isDesignationTypeOf =
        Namespaced_IRI.parse _namespace_name "isDesignationTypeOf" |> NamespacedName

    /// <summary>
    /// This individual represents the dialect designation.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/DialectalDesignation"></see></summary>
    let DialectalDesignation =
        Namespaced_IRI.parse _namespace_name "DialectalDesignation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Diameter"></see>
    /// </summary>
    let Diameter = Namespaced_IRI.parse _namespace_name "Diameter" |> NamespacedName
    /// <summary>
    /// This individual represents the identified diapason (note, temperature and eventually humidity during the detection).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Diapason"></see></summary>
    let Diapason = Namespaced_IRI.parse _namespace_name "Diapason" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Duration"></see>
    /// </summary>
    let Duration = Namespaced_IRI.parse _namespace_name "Duration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/EdgeCircumference"></see>
    /// </summary>
    let EdgeCircumference =
        Namespaced_IRI.parse _namespace_name "EdgeCircumference" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Emblem"></see>
    /// </summary>
    let Emblem = Namespaced_IRI.parse _namespace_name "Emblem" |> NamespacedName
    /// <summary>
    /// This individual represents a musical instrument's musical extension.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Extension"></see></summary>
    let Extension = Namespaced_IRI.parse _namespace_name "Extension" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/ExternalInternalLength"></see>
    /// </summary>
    let ExternalInternalLength =
        Namespaced_IRI.parse _namespace_name "ExternalInternalLength" |> NamespacedName

    /// <summary>
    /// This individual represents the format used to write a digital resource on a data medium.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/FileFormat"></see></summary>
    let FileFormat = Namespaced_IRI.parse _namespace_name "FileFormat" |> NamespacedName
    /// <summary>
    /// This individual represents the filigree of an artwork, painting, photography, print.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Filigree"></see></summary>
    let Filigree = Namespaced_IRI.parse _namespace_name "Filigree" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has font style".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isFontStyleOf"></see></summary>
    let isFontStyleOf =
        Namespaced_IRI.parse _namespace_name "isFontStyleOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/FrontTotalLength"></see>
    /// </summary>
    let FrontTotalLength =
        Namespaced_IRI.parse _namespace_name "FrontTotalLength" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has functional purpose".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isFunctionalPurposeOf"></see></summary>
    let isFunctionalPurposeOf =
        Namespaced_IRI.parse _namespace_name "isFunctionalPurposeOf" |> NamespacedName

    /// <summary>
    /// This individual represents the techincal definition of textured fabrics of an ancient or contemporary garment, according to the standard provided by C.I.E.T.A., or laces. It can also represent the dinstrinction between plain fabric and textured fabric.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/GarmentAnalysis"></see></summary>
    let GarmentAnalysis =
        Namespaced_IRI.parse _namespace_name "GarmentAnalysis" |> NamespacedName

    /// <summary>
    /// This individual represents the dominant color of a ancient and contemporary garment, usually it is base fabric's color, or the interlaced decoration's color.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/GarmentColour"></see></summary>
    let GarmentColour =
        Namespaced_IRI.parse _namespace_name "GarmentColour" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/GoodConservationStatus"></see>
    /// </summary>
    let GoodConservationStatus =
        Namespaced_IRI.parse _namespace_name "GoodConservationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/GoodLegibility"></see>
    /// </summary>
    let GoodLegibility =
        Namespaced_IRI.parse _namespace_name "GoodLegibility" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Height"></see>
    /// </summary>
    let Height = Namespaced_IRI.parse _namespace_name "Height" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/HeightLength"></see>
    /// </summary>
    let HeightLength =
        Namespaced_IRI.parse _namespace_name "HeightLength" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/HeightLengthWidth"></see>
    /// </summary>
    let HeightLengthWidth =
        Namespaced_IRI.parse _namespace_name "HeightLengthWidth" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/HeightWidthThickness"></see>
    /// </summary>
    let HeightWidthThickness =
        Namespaced_IRI.parse _namespace_name "HeightWidthThickness" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/HipCircumference"></see>
    /// </summary>
    let HipCircumference =
        Namespaced_IRI.parse _namespace_name "HipCircumference" |> NamespacedName

    /// <summary>
    /// This individual represents a historical designation.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/HistoricalDesignation"></see></summary>
    let HistoricalDesignation =
        Namespaced_IRI.parse _namespace_name "HistoricalDesignation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/HistoricalPlaque"></see>
    /// </summary>
    let HistoricalPlaque =
        Namespaced_IRI.parse _namespace_name "HistoricalPlaque" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/IconographicAndDecorativeApparatus"></see>
    /// </summary>
    let IconographicAndDecorativeApparatus =
        Namespaced_IRI.parse _namespace_name "IconographicAndDecorativeApparatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/IconographicApparatus"></see>
    /// </summary>
    let IconographicApparatus =
        Namespaced_IRI.parse _namespace_name "IconographicApparatus" |> NamespacedName

    /// <summary>
    /// This class represents the iconographic or decorative apparaturs of a cultural property. It is intended as the more or less complex set of iconographic or decorative representations on the cultural property.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/IconographicOrDecorativeApparatus"></see></summary>
    let IconographicOrDecorativeApparatus =
        Namespaced_IRI.parse _namespace_name "IconographicOrDecorativeApparatus" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has iconographic or decorative apparatus".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isIconographicOrDecorativeApparatusOf"></see></summary>
    let isIconographicOrDecorativeApparatusOf =
        Namespaced_IRI.parse _namespace_name "isIconographicOrDecorativeApparatusOf" |> NamespacedName

    /// <summary>
    /// This property relates a iconographic or decorative apparatus to its type.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasIconographicOrDecorativeApparatusType"></see></summary>
    let hasIconographicOrDecorativeApparatusType =
        Namespaced_IRI.parse _namespace_name "hasIconographicOrDecorativeApparatusType" |> NamespacedName

    /// <summary>
    /// This property connects a cultural entity's iconographic or decorative apparatus to its ornamental motif (anthropomorphic, zoomorphic, geometric).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasOrnamentalMotif"></see></summary>
    let hasOrnamentalMotif =
        Namespaced_IRI.parse _namespace_name "hasOrnamentalMotif" |> NamespacedName

    /// <summary>
    /// This class represents the ornamental motif (anthropomorphous, zoomorphic, geometric) represented by a cultural property's iconographic and decorative apparatus.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/OrnamentalMotif"></see></summary>
    let OrnamentalMotif =
        Namespaced_IRI.parse _namespace_name "OrnamentalMotif" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has iconographic or decorative apparatus type".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isIconographicOrDecorativeApparatusTypeOf"></see></summary>
    let isIconographicOrDecorativeApparatusTypeOf =
        Namespaced_IRI.parse _namespace_name "isIconographicOrDecorativeApparatusTypeOf" |> NamespacedName

    /// <summary>
    /// This individual represents an idiomatic designation.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/IdiomaticDesignation"></see></summary>
    let IdiomaticDesignation =
        Namespaced_IRI.parse _namespace_name "IdiomaticDesignation" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has implementation method".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isImplementationMethodOf"></see></summary>
    let isImplementationMethodOf =
        Namespaced_IRI.parse _namespace_name "isImplementationMethodOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/ImpossibleLegibility"></see>
    /// </summary>
    let ImpossibleLegibility =
        Namespaced_IRI.parse _namespace_name "ImpossibleLegibility" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Inaccessible"></see>
    /// </summary>
    let Inaccessible =
        Namespaced_IRI.parse _namespace_name "Inaccessible" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/InstrumentalCommunication"></see>
    /// </summary>
    let InstrumentalCommunication =
        Namespaced_IRI.parse _namespace_name "InstrumentalCommunication" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/KinesicCommunication"></see>
    /// </summary>
    let KinesicCommunication =
        Namespaced_IRI.parse _namespace_name "KinesicCommunication" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has legibility".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isLegibilityOf"></see></summary>
    let isLegibilityOf =
        Namespaced_IRI.parse _namespace_name "isLegibilityOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Length"></see>
    /// </summary>
    let Length = Namespaced_IRI.parse _namespace_name "Length" |> NamespacedName

    /// <summary>
    /// This individual represents an local designation.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/LocalDesignation"></see></summary>
    let LocalDesignation =
        Namespaced_IRI.parse _namespace_name "LocalDesignation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Logo"></see>
    /// </summary>
    let Logo = Namespaced_IRI.parse _namespace_name "Logo" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/LoweredLegibility"></see>
    /// </summary>
    let LoweredLegibility =
        Namespaced_IRI.parse _namespace_name "LoweredLegibility" |> NamespacedName

    /// <summary>
    /// This individual represents the mass storage where a digital photograph is stored.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/MassStorage"></see></summary>
    let MassStorage =
        Namespaced_IRI.parse _namespace_name "MassStorage" |> NamespacedName

    /// <summary>
    /// This individual represents the material through which an object has been realized, e.g. a cultural entity.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Material"></see></summary>
    let Material = Namespaced_IRI.parse _namespace_name "Material" |> NamespacedName

    /// <summary>
    /// This individual represents the material or technique through which an object has been realized, e.g. a cultural entity. In ICCD standard for cataloguing cultural entities, this label is necessary when material and techinque are registered in the same field.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/MaterialOrTechnique"></see></summary>
    let MaterialOrTechnique =
        Namespaced_IRI.parse _namespace_name "MaterialOrTechnique" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/MaximumMinimumWidth"></see>
    /// </summary>
    let MaximumMinimumWidth =
        Namespaced_IRI.parse _namespace_name "MaximumMinimumWidth" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/MaximumTotalLength"></see>
    /// </summary>
    let MaximumTotalLength =
        Namespaced_IRI.parse _namespace_name "MaximumTotalLength" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/MaximumTotalWidth"></see>
    /// </summary>
    let MaximumTotalWidth =
        Namespaced_IRI.parse _namespace_name "MaximumTotalWidth" |> NamespacedName

    /// <summary>
    /// This class represents a measurement of an object. Measurements realte to the cultural property's dimensions.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Measurement"></see></summary>
    let Measurement =
        Namespaced_IRI.parse _namespace_name "Measurement" |> NamespacedName

    /// <summary>
    /// This property relates a measurement to its type.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasMeasurementType"></see></summary>
    let hasMeasurementType =
        Namespaced_IRI.parse _namespace_name "hasMeasurementType" |> NamespacedName

    /// <summary>
    /// This property relates a measurement to its value.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasValue"></see></summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName

    /// <summary>
    /// This class represents the set of measurments observed for an object.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/MeasurementCollection"></see></summary>
    let MeasurementCollection =
        Namespaced_IRI.parse _namespace_name "MeasurementCollection" |> NamespacedName

    /// <summary>
    /// This property connects an object's measure to the observed measures' collection of that object. It is the inverse property of hasMeasurement.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isMeasurementIn"></see></summary>
    let isMeasurementIn =
        Namespaced_IRI.parse _namespace_name "isMeasurementIn" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has measurement collection".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isMeasurementCollectionOf"></see></summary>
    let isMeasurementCollectionOf =
        Namespaced_IRI.parse _namespace_name "isMeasurementCollectionOf" |> NamespacedName

    /// <summary>
    /// This property connects a set of observed measures on an object to one of those measures.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasMeasurement"></see></summary>
    let hasMeasurement =
        Namespaced_IRI.parse _namespace_name "hasMeasurement" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has measurement type".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isMeasurementTypeOf"></see></summary>
    let isMeasurementTypeOf =
        Namespaced_IRI.parse _namespace_name "isMeasurementTypeOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/MediocreConservationStatus"></see>
    /// </summary>
    let MediocreConservationStatus =
        Namespaced_IRI.parse _namespace_name "MediocreConservationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/NoLongerAvailable"></see>
    /// </summary>
    let NoLongerAvailable =
        Namespaced_IRI.parse _namespace_name "NoLongerAvailable" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/OccupiedStorageSpace"></see>
    /// </summary>
    let OccupiedStorageSpace =
        Namespaced_IRI.parse _namespace_name "OccupiedStorageSpace" |> NamespacedName

    /// <summary>
    /// This class represents the orientation of an object (i.e. N.W., S.E.), considering the main axis.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Orientation"></see></summary>
    let Orientation =
        Namespaced_IRI.parse _namespace_name "Orientation" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has orientation".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isOrientationOf"></see></summary>
    let isOrientationOf =
        Namespaced_IRI.parse _namespace_name "isOrientationOf" |> NamespacedName

    /// <summary>
    /// This individual represents original designation.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/OriginalDesignation"></see></summary>
    let OriginalDesignation =
        Namespaced_IRI.parse _namespace_name "OriginalDesignation" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has ornamental motif".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isOrnamentalMotifOf"></see></summary>
    let isOrnamentalMotifOf =
        Namespaced_IRI.parse _namespace_name "isOrnamentalMotifOf" |> NamespacedName

    /// <summary>
    /// This individual represents a designation in other language.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/OtherLanguageDesignation"></see></summary>
    let OtherLanguageDesignation =
        Namespaced_IRI.parse _namespace_name "OtherLanguageDesignation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/PartiallyAccessible"></see>
    /// </summary>
    let PartiallyAccessible =
        Namespaced_IRI.parse _namespace_name "PartiallyAccessible" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Perimeter"></see>
    /// </summary>
    let Perimeter = Namespaced_IRI.parse _namespace_name "Perimeter" |> NamespacedName

    /// <summary>
    /// This individual represents a digital photograph's colour, i.e. black and white or colours.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/PhotoColour"></see></summary>
    let PhotoColour =
        Namespaced_IRI.parse _namespace_name "PhotoColour" |> NamespacedName

    /// <summary>
    /// This individual represents the visualization, storage and processing program used for a digital photograph.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/PhotoProgram"></see></summary>
    let PhotoProgram =
        Namespaced_IRI.parse _namespace_name "PhotoProgram" |> NamespacedName

    /// <summary>
    /// This individual represents a digital photograph format, intended as the photogrphic material's standardised size (e.g. negative, positives).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/PhotoSize"></see></summary>
    let PhotoSize = Namespaced_IRI.parse _namespace_name "PhotoSize" |> NamespacedName

    /// <summary>
    /// This individual represents a digital photograph size in pixels.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/PixelDimension"></see></summary>
    let PixelDimension =
        Namespaced_IRI.parse _namespace_name "PixelDimension" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Power"></see>
    /// </summary>
    let Power = Namespaced_IRI.parse _namespace_name "Power" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/ProxemicsCommunication"></see>
    /// </summary>
    let ProxemicsCommunication =
        Namespaced_IRI.parse _namespace_name "ProxemicsCommunication" |> NamespacedName

    /// <summary>
    /// This individual represents a digital resource's quality level, e.g. high-resolution, low-resolution, preview.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/QualityLevel"></see></summary>
    let QualityLevel =
        Namespaced_IRI.parse _namespace_name "QualityLevel" |> NamespacedName

    /// <summary>
    /// This individual represents the specific value and resolution used for storing a digital photograph.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Resolution"></see></summary>
    let Resolution = Namespaced_IRI.parse _namespace_name "Resolution" |> NamespacedName

    /// <summary>
    /// This class represents a sample collected from an archeological property.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/SampleCollected"></see></summary>
    let SampleCollected =
        Namespaced_IRI.parse _namespace_name "SampleCollected" |> NamespacedName

    /// <summary>
    /// This property represents a cultural entity's postion (e.g. elements like crests, emblems, stamps or the depicted subjects), with respect to the whole entity or to its specific part.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/positionOnCulturalProperty"></see></summary>
    let positionOnCulturalProperty =
        Namespaced_IRI.parse _namespace_name "positionOnCulturalProperty" |> NamespacedName

    /// <summary>
    /// This property represents the seample collected identifier.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/sampleCollectedIdentifier"></see></summary>
    let sampleCollectedIdentifier =
        Namespaced_IRI.parse _namespace_name "sampleCollectedIdentifier" |> NamespacedName

    /// <summary>
    /// This property relates a sample collected to its type.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasSampleCollectedType"></see></summary>
    let hasSampleCollectedType =
        Namespaced_IRI.parse _namespace_name "hasSampleCollectedType" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has sample collected".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isSampleCollectedFrom"></see></summary>
    let isSampleCollectedFrom =
        Namespaced_IRI.parse _namespace_name "isSampleCollectedFrom" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has sample collected type".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isSampleCollectedTypeOf"></see></summary>
    let isSampleCollectedTypeOf =
        Namespaced_IRI.parse _namespace_name "isSampleCollectedTypeOf" |> NamespacedName

    /// <summary>
    /// This individual represents an object's shape. It is used for bidimensional objects, e.g. octagonal or round shape.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Shape"></see></summary>
    let Shape = Namespaced_IRI.parse _namespace_name "Shape" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/SingingCommunication"></see>
    /// </summary>
    let SingingCommunication =
        Namespaced_IRI.parse _namespace_name "SingingCommunication" |> NamespacedName

    /// <summary>
    /// This individual represents a slang designation.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/SlangDesignation"></see></summary>
    let SlangDesignation =
        Namespaced_IRI.parse _namespace_name "SlangDesignation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Stamp"></see>
    /// </summary>
    let Stamp = Namespaced_IRI.parse _namespace_name "Stamp" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/StorageCapacity"></see>
    /// </summary>
    let StorageCapacity =
        Namespaced_IRI.parse _namespace_name "StorageCapacity" |> NamespacedName

    /// <summary>
    /// This individual represents the method and color depth through which a digital photograph has been stored.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/StorageMethodColourDepth"></see></summary>
    let StorageMethodColourDepth =
        Namespaced_IRI.parse _namespace_name "StorageMethodColourDepth" |> NamespacedName

    /// <summary>
    /// This property connects a support (e.g. "paper label") to an element (stamp, embelem, inscription, mark) which has been represented on it. It is the inverse property of hasSupport.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isSupportOf"></see></summary>
    let isSupportOf =
        Namespaced_IRI.parse _namespace_name "isSupportOf" |> NamespacedName

    /// <summary>
    /// This property connects an entity's techincal characteristic to a technical concept, which classifies that characteristic.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isCharacteristicClassifiedBy"></see></summary>
    let isCharacteristicClassifiedBy =
        Namespaced_IRI.parse _namespace_name "isCharacteristicClassifiedBy" |> NamespacedName

    /// <summary>
    /// This property relates a technical characteristic (e.g. marble) to the status of a cultural entity that includes that characteristic.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isIncludedInTechnicalStatus"></see></summary>
    let isIncludedInTechnicalStatus =
        Namespaced_IRI.parse _namespace_name "isIncludedInTechnicalStatus" |> NamespacedName

    /// <summary>
    /// This individual represents an object's execution technique.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Technique"></see></summary>
    let Technique = Namespaced_IRI.parse _namespace_name "Technique" |> NamespacedName

    /// <summary>
    /// This individual represents a musical instrument adopted temperament, especially in relation to an object in its original conditions, or after its restoration. For idiophones with fixed keys (e.g. xylophone, litophone, metallophone) the temperament represents the succession of intervals.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Temperament"></see></summary>
    let Temperament =
        Namespaced_IRI.parse _namespace_name "Temperament" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Thickness"></see>
    /// </summary>
    let Thickness = Namespaced_IRI.parse _namespace_name "Thickness" |> NamespacedName
    /// <summary>
    /// This individual represents a musical instrument tuning.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Tuning"></see></summary>
    let Tuning = Namespaced_IRI.parse _namespace_name "Tuning" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/UnavailableConservationStatus"></see>
    /// </summary>
    let UnavailableConservationStatus =
        Namespaced_IRI.parse _namespace_name "UnavailableConservationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/UndetectedMeasurements"></see>
    /// </summary>
    let UndetectedMeasurements =
        Namespaced_IRI.parse _namespace_name "UndetectedMeasurements" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/VariousMeasurements"></see>
    /// </summary>
    let VariousMeasurements =
        Namespaced_IRI.parse _namespace_name "VariousMeasurements" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/VerbalCommunication"></see>
    /// </summary>
    let VerbalCommunication =
        Namespaced_IRI.parse _namespace_name "VerbalCommunication" |> NamespacedName

    /// <summary>
    /// This individual represents a musical instrument vibrating length, in particular a chordophone.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/VibratingLenght"></see></summary>
    let VibratingLenght =
        Namespaced_IRI.parse _namespace_name "VibratingLenght" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Volume"></see>
    /// </summary>
    let Volume = Namespaced_IRI.parse _namespace_name "Volume" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/VolumetricDiamensions"></see>
    /// </summary>
    let VolumetricDiamensions =
        Namespaced_IRI.parse _namespace_name "VolumetricDiamensions" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/WaistCircumference"></see>
    /// </summary>
    let WaistCircumference =
        Namespaced_IRI.parse _namespace_name "WaistCircumference" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Weight"></see>
    /// </summary>
    let Weight = Namespaced_IRI.parse _namespace_name "Weight" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Width"></see>
    /// </summary>
    let Width = Namespaced_IRI.parse _namespace_name "Width" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has writing system".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isWritingSystemOf"></see></summary>
    let isWritingSystemOf =
        Namespaced_IRI.parse _namespace_name "isWritingSystemOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/WrittenCommunication"></see>
    /// </summary>
    let WrittenCommunication =
        Namespaced_IRI.parse _namespace_name "WrittenCommunication" |> NamespacedName

    /// <summary>
    /// This property represents the morphology of an anthropological material.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/anthropologicalMaterialMorphology"></see></summary>
    let anthropologicalMaterialMorphology =
        Namespaced_IRI.parse _namespace_name "anthropologicalMaterialMorphology" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has available notes".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/areAvailableNotesOf"></see></summary>
    let areAvailableNotesOf =
        Namespaced_IRI.parse _namespace_name "areAvailableNotesOf" |> NamespacedName

    /// <summary>
    /// This property relates a technical characteristic to an entity.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isTechnicalCharacteristicOf"></see></summary>
    let isTechnicalCharacteristicOf =
        Namespaced_IRI.parse _namespace_name "isTechnicalCharacteristicOf" |> NamespacedName

    /// <summary>
    /// This property relates a musical instrument to the playable notes by it, from low to high.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasAvailableNotes"></see></summary>
    let hasAvailableNotes =
        Namespaced_IRI.parse _namespace_name "hasAvailableNotes" |> NamespacedName

    /// <summary>
    /// This property connects a techical concept to an entity's technical characteristic. It is the inverse property of isCharacteristicClassifiedBy.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/classifiesCharacteristic"></see></summary>
    let classifiesCharacteristic =
        Namespaced_IRI.parse _namespace_name "classifiesCharacteristic" |> NamespacedName

    /// <summary>
    /// This property relates a musical good to one of its accessories. In other words, it is an object linkable to a musical object, whether it is functional to the sound production, or if it is the sound's production or conservation medium.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasAccessory"></see></summary>
    let hasAccessory =
        Namespaced_IRI.parse _namespace_name "hasAccessory" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property to an element affixed on it (e.g. inscription, stamp, etc.)
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasAffixedElement"></see></summary>
    let hasAffixedElement =
        Namespaced_IRI.parse _namespace_name "hasAffixedElement" |> NamespacedName

    /// <summary>
    /// This property relatesan inscription (or an emblem, a mark, etc.) to its type.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasAffixedElementType"></see></summary>
    let hasAffixedElementType =
        Namespaced_IRI.parse _namespace_name "hasAffixedElementType" |> NamespacedName

    /// <summary>
    /// This property relates an entity to a technical characteristic (e.g. material, technique, colour, quality level).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasTechnicalCharacteristic"></see></summary>
    let hasTechnicalCharacteristic =
        Namespaced_IRI.parse _namespace_name "hasTechnicalCharacteristic" |> NamespacedName

    /// <summary>
    /// This property relates an intangible cultural property to a communication medium.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasCommunicationMedium"></see></summary>
    let hasCommunicationMedium =
        Namespaced_IRI.parse _namespace_name "hasCommunicationMedium" |> NamespacedName

    /// <summary>
    /// This property relates the cultural property with its conservation status.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasConservationStatus"></see></summary>
    let hasConservationStatus =
        Namespaced_IRI.parse _namespace_name "hasConservationStatus" |> NamespacedName

    /// <summary>
    /// This property relates the cultural property to its accessibility, that is the possibility to reach or enter that cultural property, for example for cataloguing activities (e.g.: an immovable cultural property located in a walled area, a movable cultural property located on the top shelf, a totally accessible cultural property, etc.)
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertyAccessibility"></see></summary>
    let hasCulturalPropertyAccessibility =
        Namespaced_IRI.parse _namespace_name "hasCulturalPropertyAccessibility" |> NamespacedName

    /// <summary>
    /// This class relates the cultural property to its availability, that is wheter the cultural property is available or not (e.g.: theft, destruction) for example for cataloguing activities.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertyAvailability"></see></summary>
    let hasCulturalPropertyAvailability =
        Namespaced_IRI.parse _namespace_name "hasCulturalPropertyAvailability" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property to its type.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertyType"></see></summary>
    let hasCulturalPropertyType =
        Namespaced_IRI.parse _namespace_name "hasCulturalPropertyType" |> NamespacedName

    /// <summary>
    /// This property connects a dedication to its dedicaatee, which is the person or institution to whom the dedication is addressed.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasDedicatee"></see></summary>
    let hasDedicatee =
        Namespaced_IRI.parse _namespace_name "hasDedicatee" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has dedicatee".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isDedicateeOf"></see></summary>
    let isDedicateeOf =
        Namespaced_IRI.parse _namespace_name "isDedicateeOf" |> NamespacedName

    /// <summary>
    /// This property connects a cultural entity to its denomination and/or dedication, or title (for FF legislation) over time.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasDesignationInTime"></see></summary>
    let hasDesignationInTime =
        Namespaced_IRI.parse _namespace_name "hasDesignationInTime" |> NamespacedName

    /// <summary>
    /// This property relates a musical instrument to the identified diapason (note, temperature and eventually humidity during the detection).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasDiapason"></see></summary>
    let hasDiapason =
        Namespaced_IRI.parse _namespace_name "hasDiapason" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has diapason".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isDiapasonOf"></see></summary>
    let isDiapasonOf =
        Namespaced_IRI.parse _namespace_name "isDiapasonOf" |> NamespacedName

    /// <summary>
    /// This property relates a musical instrument to its extension.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasExtension"></see></summary>
    let hasExtension =
        Namespaced_IRI.parse _namespace_name "hasExtension" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has extension".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isExtensionOf"></see></summary>
    let isExtensionOf =
        Namespaced_IRI.parse _namespace_name "isExtensionOf" |> NamespacedName

    /// <summary>
    /// This property relates a digital resource to the format used to write it on a data medium.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasFileFormat"></see></summary>
    let hasFileFormat =
        Namespaced_IRI.parse _namespace_name "hasFileFormat" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has file format"
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isFileFormatOf"></see></summary>
    let isFileFormatOf =
        Namespaced_IRI.parse _namespace_name "isFileFormatOf" |> NamespacedName

    /// <summary>
    /// This property relates an artwork, painting, photography, print to its filigree.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasFiligree"></see></summary>
    let hasFiligree =
        Namespaced_IRI.parse _namespace_name "hasFiligree" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has filigree".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isFiligreeOf"></see></summary>
    let isFiligreeOf =
        Namespaced_IRI.parse _namespace_name "isFiligreeOf" |> NamespacedName

    /// <summary>
    /// This property relates an ancient or contemporary garment to the technical definition of textured fabrics, according to the standard provided by C.I.E.T.A., or laces. It can represent the dinstinction between plain fabric and textured fabric.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasGarmentAnalysis"></see></summary>
    let hasGarmentAnalysis =
        Namespaced_IRI.parse _namespace_name "hasGarmentAnalysis" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has garment analysis".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isGarmentAnalysisOf"></see></summary>
    let isGarmentAnalysisOf =
        Namespaced_IRI.parse _namespace_name "isGarmentAnalysisOf" |> NamespacedName

    /// <summary>
    /// This property relates an ancient and contemporary garment to its dominant color, usually it is base fabric's color, or the interlaced decoration's color.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasGarmentColour"></see></summary>
    let hasGarmentColour =
        Namespaced_IRI.parse _namespace_name "hasGarmentColour" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has garment colour".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isGarmentColourOf"></see></summary>
    let isGarmentColourOf =
        Namespaced_IRI.parse _namespace_name "isGarmentColourOf" |> NamespacedName

    /// <summary>
    /// This property relates a cultural enitity to its iconographic or decorative apparatus.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasIconographicOrDecorativeApparatus"></see></summary>
    let hasIconographicOrDecorativeApparatus =
        Namespaced_IRI.parse _namespace_name "hasIconographicOrDecorativeApparatus" |> NamespacedName

    /// <summary>
    /// This property represent the location as a subject of a cultural entity.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasLocationSubject"></see></summary>
    let hasLocationSubject =
        Namespaced_IRI.parse _namespace_name "hasLocationSubject" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has location subject".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isLocationSubjectOf"></see></summary>
    let isLocationSubjectOf =
        Namespaced_IRI.parse _namespace_name "isLocationSubjectOf" |> NamespacedName

    /// <summary>
    /// This property relates a digital photograph to the mass storage where a digital photograph is stored.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasMassStorage"></see></summary>
    let hasMassStorage =
        Namespaced_IRI.parse _namespace_name "hasMassStorage" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has mass storage".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isMassStorageOf"></see></summary>
    let isMassStorageOf =
        Namespaced_IRI.parse _namespace_name "isMassStorageOf" |> NamespacedName

    /// <summary>
    /// This property relates an object to its material.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasMaterial"></see></summary>
    let hasMaterial =
        Namespaced_IRI.parse _namespace_name "hasMaterial" |> NamespacedName

    /// <summary>
    /// This property relates an object to the material or technique through which an object has been realized, e.g. a cultural entity. In ICCD standards for cataloguing cultural entities, this label is necessary when material and technique are registered in the same field.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasMaterialOrTechnique"></see></summary>
    let hasMaterialOrTechnique =
        Namespaced_IRI.parse _namespace_name "hasMaterialOrTechnique" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has material"
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isMaterialOf"></see></summary>
    let isMaterialOf =
        Namespaced_IRI.parse _namespace_name "isMaterialOf" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has material or technique"
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isMaterialOrTechniqueOf"></see></summary>
    let isMaterialOrTechniqueOf =
        Namespaced_IRI.parse _namespace_name "isMaterialOrTechniqueOf" |> NamespacedName

    /// <summary>
    /// This property connects an object to the collection of observed measures on it.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasMeasurementCollection"></see></summary>
    let hasMeasurementCollection =
        Namespaced_IRI.parse _namespace_name "hasMeasurementCollection" |> NamespacedName

    /// <summary>
    /// This property connects an object to its orientation, considering its major axis.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasOrientation"></see></summary>
    let hasOrientation =
        Namespaced_IRI.parse _namespace_name "hasOrientation" |> NamespacedName

    /// <summary>
    /// This property relates a digital photograph to its colour, i.e. black and white or colours.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasPhotoColour"></see></summary>
    let hasPhotoColour =
        Namespaced_IRI.parse _namespace_name "hasPhotoColour" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has photo colour"
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isPhotoColourOf"></see></summary>
    let isPhotoColourOf =
        Namespaced_IRI.parse _namespace_name "isPhotoColourOf" |> NamespacedName

    /// <summary>
    /// This property relates a digital photograph to the visualization, storage and processing program used for the digital photograph.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasPhotoProgram"></see></summary>
    let hasPhotoProgram =
        Namespaced_IRI.parse _namespace_name "hasPhotoProgram" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has photo program".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isPhotoProgramOf"></see></summary>
    let isPhotoProgramOf =
        Namespaced_IRI.parse _namespace_name "isPhotoProgramOf" |> NamespacedName

    /// <summary>
    /// This property relates a digital photograph to its format, intended as the photographic material's standardised size (e.g. negative, positives).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasPhotoSize"></see></summary>
    let hasPhotoSize =
        Namespaced_IRI.parse _namespace_name "hasPhotoSize" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has photo size"
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isPhotoSizeOf"></see></summary>
    let isPhotoSizeOf =
        Namespaced_IRI.parse _namespace_name "isPhotoSizeOf" |> NamespacedName

    /// <summary>
    /// This property relates a digital resource to its size in pixels.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasPixelDimension"></see></summary>
    let hasPixelDimension =
        Namespaced_IRI.parse _namespace_name "hasPixelDimension" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has pixel dimension"
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isPixelDimensionOf"></see></summary>
    let isPixelDimensionOf =
        Namespaced_IRI.parse _namespace_name "isPixelDimensionOf" |> NamespacedName

    /// <summary>
    /// This property relates a digital resource to its quality level, e.g. high-resolution, low-resolution, preview.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasQualityLevel"></see></summary>
    let hasQualityLevel =
        Namespaced_IRI.parse _namespace_name "hasQualityLevel" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has quality level"
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isQualityLevelOf"></see></summary>
    let isQualityLevelOf =
        Namespaced_IRI.parse _namespace_name "isQualityLevelOf" |> NamespacedName

    /// <summary>
    /// This property relates a digital resource to theresolution used for storing it.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasResolution"></see></summary>
    let hasResolution =
        Namespaced_IRI.parse _namespace_name "hasResolution" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has resolution"
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isResolutionOf"></see></summary>
    let isResolutionOf =
        Namespaced_IRI.parse _namespace_name "isResolutionOf" |> NamespacedName

    /// <summary>
    /// This property connects a archaeological entity to a sample collected from it.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasSampleCollected"></see></summary>
    let hasSampleCollected =
        Namespaced_IRI.parse _namespace_name "hasSampleCollected" |> NamespacedName

    /// <summary>
    /// This property relates an object to its shape. It is used for bidimensional objects, e.g. octagonal or round shape.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasShape"></see></summary>
    let hasShape = Namespaced_IRI.parse _namespace_name "hasShape" |> NamespacedName
    /// <summary>
    /// This is the inverse property of "has shape"
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isShapeOf"></see></summary>
    let isShapeOf = Namespaced_IRI.parse _namespace_name "isShapeOf" |> NamespacedName

    /// <summary>
    /// This property relates a digital photograph to the method and color depth through which a digital photograph has been stored.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasStorageMethodOrColourDepth"></see></summary>
    let hasStorageMethodOrColourDepth =
        Namespaced_IRI.parse _namespace_name "hasStorageMethodOrColourDepth" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has storage method or colour depth".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isStorageMethodOrColourDepthOf"></see></summary>
    let isStorageMethodOrColourDepthOf =
        Namespaced_IRI.parse _namespace_name "isStorageMethodOrColourDepthOf" |> NamespacedName

    /// <summary>
    /// This property relates an object to its execution technique.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasTechnique"></see></summary>
    let hasTechnique =
        Namespaced_IRI.parse _namespace_name "hasTechnique" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has technique"
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isTechniqueOf"></see></summary>
    let isTechniqueOf =
        Namespaced_IRI.parse _namespace_name "isTechniqueOf" |> NamespacedName

    /// <summary>
    /// This property relates a musical instrument to the adopted temperament, especially in relation to an object in its original conditions, or after its restoration. For idiophones with fixed keys (e.g. xylophone, litophone, metallophone) the temperament represents the succession of intervals.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasTemperament"></see></summary>
    let hasTemperament =
        Namespaced_IRI.parse _namespace_name "hasTemperament" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has temperament".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isTemperamentOf"></see></summary>
    let isTemperamentOf =
        Namespaced_IRI.parse _namespace_name "isTemperamentOf" |> NamespacedName

    /// <summary>
    /// This property relates a musical instrument to its tuning.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasTuning"></see></summary>
    let hasTuning = Namespaced_IRI.parse _namespace_name "hasTuning" |> NamespacedName
    /// <summary>
    /// This is the inverse property of "has tuning".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isTuningOf"></see></summary>
    let isTuningOf = Namespaced_IRI.parse _namespace_name "isTuningOf" |> NamespacedName
    /// <summary>
    /// This is the inverse property of "has value".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isValueOf"></see></summary>
    let isValueOf = Namespaced_IRI.parse _namespace_name "isValueOf" |> NamespacedName

    /// <summary>
    /// This property relates a musical instrument to its vibrating length, in particular a chordophone.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasVibratingLenght"></see></summary>
    let hasVibratingLenght =
        Namespaced_IRI.parse _namespace_name "hasVibratingLenght" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has vibrating lenght".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isVibratingLenghtOf"></see></summary>
    let isVibratingLenghtOf =
        Namespaced_IRI.parse _namespace_name "isVibratingLenghtOf" |> NamespacedName

    /// <summary>
    /// This property connects a collection of observed measures on an object to one of these measures, when the latter is relative to an ancient or contemporary apparel's size. The volumetric dimensions measurements determine the size for storage and can be considered as the object's orthogonal coordinates.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasVolumetricDimensionsMeasurement"></see></summary>
    let hasVolumetricDimensionsMeasurement =
        Namespaced_IRI.parse _namespace_name "hasVolumetricDimensionsMeasurement" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has volumetric dimensions measurement".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isVolumetricDimensionsMeasurementIn"></see></summary>
    let isVolumetricDimensionsMeasurementIn =
        Namespaced_IRI.parse _namespace_name "isVolumetricDimensionsMeasurementIn" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "refers to agent".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isAgentReferredToBy"></see></summary>
    let isAgentReferredToBy =
        Namespaced_IRI.parse _namespace_name "isAgentReferredToBy" |> NamespacedName

    /// <summary>
    /// This property connects a crest, emblem, postmark etc., located on a cultural entity to the agent (e.g. family, factory, cave, silversmith) to which it refers.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/refersToAgent"></see></summary>
    let refersToAgent =
        Namespaced_IRI.parse _namespace_name "refersToAgent" |> NamespacedName

    /// <summary>
    /// This property relates a technical concept (e.g. material) used in the technical description of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isTechnicalConceptUsedIn"></see></summary>
    let isTechnicalConceptUsedIn =
        Namespaced_IRI.parse _namespace_name "isTechnicalConceptUsedIn" |> NamespacedName

    /// <summary>
    /// This property relates a technical status (intended as a situaiton) of a cultural entity to the technical description satisfied by that situation.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/satisfiesTechnicalDescription"></see></summary>
    let satisfiesTechnicalDescription =
        Namespaced_IRI.parse _namespace_name "satisfiesTechnicalDescription" |> NamespacedName

    /// <summary>
    /// This property relates a cultural entity technical status to the time interval until which that status is valid, with regard to the moment in which the characteristics are observed.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isTechnicalStatusValidAt"></see></summary>
    let isTechnicalStatusValidAt =
        Namespaced_IRI.parse _namespace_name "isTechnicalStatusValidAt" |> NamespacedName

    /// <summary>
    /// This property relates the time interval, at which a cultural entity technical status is valid, to that technical status, with regard to the moment in which the characteristics are observed.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isTimeIntervalValidFor"></see></summary>
    let isTimeIntervalValidFor =
        Namespaced_IRI.parse _namespace_name "isTimeIntervalValidFor" |> NamespacedName

    /// <summary>
    /// This property represents the occurrences of an affixed element on a cultular entity, that is how many times the outlined element appears on the cultual entity.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/occurrences"></see></summary>
    let occurrences =
        Namespaced_IRI.parse _namespace_name "occurrences" |> NamespacedName

    /// <summary>
    /// This property represents a cultural entity's position with respect to a complex entity to which it belongs.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/positionInComplexCulturalProperty"></see></summary>
    let positionInComplexCulturalProperty =
        Namespaced_IRI.parse _namespace_name "positionInComplexCulturalProperty" |> NamespacedName

    /// <summary>
    /// This property represents potential proposals for conservative interventions after evaluating the cultual entity's conditions at time of its cataloguing.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/proposedIntervention"></see></summary>
    let proposedIntervention =
        Namespaced_IRI.parse _namespace_name "proposedIntervention" |> NamespacedName

    /// <summary>
    /// This property represents informations about the storage conditions of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/storageConditions"></see></summary>
    let storageConditions =
        Namespaced_IRI.parse _namespace_name "storageConditions" |> NamespacedName

    /// <summary>
    /// This property represents the validity, intended as accurancy level, of an observed measure for an object.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/validity"></see></summary>
    let validity = Namespaced_IRI.parse _namespace_name "validity" |> NamespacedName
