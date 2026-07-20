namespace https.w3id.org.arco.ontology.denotative_description.slash

open DoxAletheia

module ddesc =
    let _namespace_name = "https://w3id.org/arco/ontology/denotative-description/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This class represents the type (i.e. civil, religious) of an inscription, emblem, postmark, crest, etc.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/AffixedElementType"></see></summary>
    let AffixedElementType = _prefix "AffixedElementType"
    /// <summary>
    /// This class represents the type of communication medium.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CommunicationMediumType"></see></summary>
    let CommunicationMediumType = _prefix "CommunicationMediumType"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/ConservationStatusType"></see>
    /// </summary>
    let ConservationStatusType = _prefix "ConservationStatusType"
    /// <summary>
    /// This class represents a cultural property's type, that is the term or expression which specifies the cultural propery that is being catalogued and additional information on the cultural property's definition.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CulturalPropertyType"></see></summary>
    let CulturalPropertyType = _prefix "CulturalPropertyType"
    /// <summary>
    /// This class represents a cultural property's denomination or dedication type, or its title (i.e. other language, current, attributed, dialectal).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/DesignationType"></see></summary>
    let DesignationType = _prefix "DesignationType"

    /// <summary>
    /// This class represents the iconographic or decorative apparatus' type (iconographic, decorative, iconographic-decorative) of a cultual property.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/IconographicOrDecorativeApparatusType"></see></summary>
    let IconographicOrDecorativeApparatusType =
        _prefix "IconographicOrDecorativeApparatusType"

    /// <summary>
    /// This class represents the observed measurement type (width, height, diameter, etc).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/MeasurementType"></see></summary>
    let MeasurementType = _prefix "MeasurementType"
    /// <summary>
    /// This class represents the sample type collected from an archaeologiacal property (i.e. coal, pottery, grout)
    /// <see href="https://w3id.org/arco/ontology/denotative-description/SampleCollectedType"></see></summary>
    let SampleCollectedType = _prefix "SampleCollectedType"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Accessible"></see>
    /// </summary>
    let Accessible = _prefix "Accessible"
    /// <summary>
    /// This class represents the cultural property accessibility, that is the possibility to reach or enter that cultural property, for example for cataloguing activities (e.g.: an immovable cultural property located in a walled area, a movable cultural property located on the top shelf, a totally accessible cultural property, etc.)
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CulturalPropertyAccessibility"></see></summary>
    let CulturalPropertyAccessibility = _prefix "CulturalPropertyAccessibility"
    /// <summary>
    /// This class represents an accessory of a musical property, both if it is functional to the sound production, or if it is the sound's production or conservation medium.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Accessory"></see></summary>
    let Accessory = _prefix "Accessory"
    /// <summary>
    /// This property represents the date of construction of a musical instrument's accessory.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/creationDate"></see></summary>
    let creationDate = _prefix "creationDate"
    /// <summary>
    /// This is the inverse property of "has accessory".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isAccessoryOf"></see></summary>
    let isAccessoryOf = _prefix "isAccessoryOf"
    /// <summary>
    /// This class represents an element (i.e. crest, trademark, postmark, inscription) which is affixed on a cultural property.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/AffixedElement"></see></summary>
    let AffixedElement = _prefix "AffixedElement"
    /// <summary>
    /// This property connects an inscription, emblem etc., to the text's transcription, using scientifically accepted integrations.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/transcript"></see></summary>
    let transcript = _prefix "transcript"
    /// <summary>
    /// This property represents the italian translation of a text transcription contained in an inscription, emblem etc.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/italianTranslation"></see></summary>
    let italianTranslation = _prefix "italianTranslation"
    /// <summary>
    /// This property connects an inscription, stamp, emblem etc., represented on a cultural entity to the support on which the entity is located.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasSupport"></see></summary>
    let hasSupport = _prefix "hasSupport"
    /// <summary>
    /// This class represents the support on which an element can be located, for instance an inscription, emblem, postmark represented on a cultural property (i.e. "paper label").
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Support"></see></summary>
    let Support = _prefix "Support"
    /// <summary>
    /// This property realtes an object (e.g. cultural entity, iconographic/decorative apparatus, affixed element like an inscription) to its functional purpose, intended as the function the object has to perform (decorative, religious, symbolic, magic-offensive etc.).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasFunctionalPurpose"></see></summary>
    let hasFunctionalPurpose = _prefix "hasFunctionalPurpose"
    /// <summary>
    /// This class represents the functional purpose (i.e. decorative, religious, symbolic, magic-offensive) of an object (i.e. culural property or iconographic/decorative apparatus or affixed element on a cultural property like an inscription). The functional purpose is intended as the function that an object has to perform.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/FunctionalPurpose"></see></summary>
    let FunctionalPurpose = _prefix "FunctionalPurpose"
    /// <summary>
    /// This property connects an inscription, stamp, crest etc., to the adopted writing system or alphabet.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasWritingSystem"></see></summary>
    let hasWritingSystem = _prefix "hasWritingSystem"
    /// <summary>
    /// This class represents the writing system or alphabet of an inscription, postmark, crest etc.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/WritingSystem"></see></summary>
    let WritingSystem = _prefix "WritingSystem"
    /// <summary>
    /// This property connects an inscription or emblem, postmark, crest, etc. to the font style which has been adopted (e.g.: italic, bold, gothic etc).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasFontStyle"></see></summary>
    let hasFontStyle = _prefix "hasFontStyle"
    /// <summary>
    /// This class represents the font style used in a text (i.e. italic, bold, gothic)
    /// <see href="https://w3id.org/arco/ontology/denotative-description/FontStyle"></see></summary>
    let FontStyle = _prefix "FontStyle"
    /// <summary>
    /// This is the inverse property of "has affixed element".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isElementAffixedOn"></see></summary>
    let isElementAffixedOn = _prefix "isElementAffixedOn"
    /// <summary>
    /// This property connects a cultural entity to its technical status, valid until a specific moment, that is represented by the technical characteristics that a cultural entity has in that moment.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasTechnicalStatus"></see></summary>
    let hasTechnicalStatus = _prefix "hasTechnicalStatus"
    /// <summary>
    /// This class represents the technical status of a cultural entity, that is a situation in which the cultural entity is associated to technical characteristics. The technical status has a temporal validity, related to the moment when the characteristics were observed. For instance, a cultural property techncal status is: "the cultural property X realized with pottery material and cylindrical in shape".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CulturalEntityTechnicalStatus"></see></summary>
    let CulturalEntityTechnicalStatus = _prefix "CulturalEntityTechnicalStatus"
    /// <summary>
    /// This is the inverse property of "has affixed element type".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isAffixedElementTypeOf"></see></summary>
    let isAffixedElementTypeOf = _prefix "isAffixedElementTypeOf"
    /// <summary>
    /// This class represents the age range (child, teenager, adult, old person) of a person.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/AgeRange"></see></summary>
    let AgeRange = _prefix "AgeRange"
    /// <summary>
    /// This class represents the communication medium of an object, defined by the communication medium type (e.g.: verbal, written, instrumental), the implementation method, the number of voices or instruments involved, etc.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CommunicationMedium"></see></summary>
    let CommunicationMedium = _prefix "CommunicationMedium"
    /// <summary>
    /// This is the inverse property of "involves age range".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isAgeRangeInvolvedIn"></see></summary>
    let isAgeRangeInvolvedIn = _prefix "isAgeRangeInvolvedIn"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Area"></see>
    /// </summary>
    let Area = _prefix "Area"
    /// <summary>
    /// This individual represents an attributed denomination.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/AssignedDesignation"></see></summary>
    let AssignedDesignation = _prefix "AssignedDesignation"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Available"></see>
    /// </summary>
    let Available = _prefix "Available"
    /// <summary>
    /// This class represents the availability of a cultural property, wheter the cultural property is available or not (e.g.: theft, destruction) for example for cataloguing activities.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CulturalPropertyAvailability"></see></summary>
    let CulturalPropertyAvailability = _prefix "CulturalPropertyAvailability"
    /// <summary>
    /// This individual represents playable notes by a musical instrument, from low to high.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/AvailableNotes"></see></summary>
    let AvailableNotes = _prefix "AvailableNotes"
    /// <summary>
    /// This class represents a technical concept, a particular type of concept that classifies a technical characteristic of an entity, e.g. cultural property. For instance, "material" is a techincal concept that classifies the technical characteristic "pottery" related to a cultural property.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/TechnicalConcept"></see></summary>
    let TechnicalConcept = _prefix "TechnicalConcept"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/BackTotalLength"></see>
    /// </summary>
    let BackTotalLength = _prefix "BackTotalLength"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/BackWidth"></see>
    /// </summary>
    let BackWidth = _prefix "BackWidth"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/BadConservationStatus"></see>
    /// </summary>
    let BadConservationStatus = _prefix "BadConservationStatus"
    /// <summary>
    /// This class represents a brand, that is a sign, an image, a symbol affixed on an object for identification.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Brand"></see></summary>
    let Brand = _prefix "Brand"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Capacity"></see>
    /// </summary>
    let Capacity = _prefix "Capacity"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/ChestCircumference"></see>
    /// </summary>
    let ChestCircumference = _prefix "ChestCircumference"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Circumference"></see>
    /// </summary>
    let Circumference = _prefix "Circumference"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/CoatOfArms"></see>
    /// </summary>
    let CoatOfArms = _prefix "CoatOfArms"
    /// <summary>
    /// This class represents the design on the reverse or the obverse of a numismatic property, as the graphical part of what is represented on a side of a coin, together with the legend (lettering and wording).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CoinDesign"></see></summary>
    let CoinDesign = _prefix "CoinDesign"
    /// <summary>
    /// This class represents the lettering and wording on the reverse or the obverse of a numismatic property.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CoinLegend"></see></summary>
    let CoinLegend = _prefix "CoinLegend"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Inscription"></see>
    /// </summary>
    let Inscription = _prefix "Inscription"
    /// <summary>
    /// This is the inverse property of "has communication medium".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isCommunicationMediumOf"></see></summary>
    let isCommunicationMediumOf = _prefix "isCommunicationMediumOf"
    /// <summary>
    /// This property relates a communication medium (proxemics, kinesic) to the age range of the participants to the communication.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/involvesAgeRange"></see></summary>
    let involvesAgeRange = _prefix "involvesAgeRange"
    /// <summary>
    /// This property represents the number of the child participants to a communication (verbal, singing, kinesic).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/numberOfChildParticipants"></see></summary>
    let numberOfChildParticipants = _prefix "numberOfChildParticipants"
    /// <summary>
    /// This property relates a verbal or singing or instrumental communication medium to its implementation method (e.g.: polyphonic) associated to it.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasImplementationMethod"></see></summary>
    let hasImplementationMethod = _prefix "hasImplementationMethod"
    /// <summary>
    /// This class represents the implementation method (e.g.: polyphonic) associated to a verbale or singing or instrumental communication medium.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/ImplementationMethod"></see></summary>
    let ImplementationMethod = _prefix "ImplementationMethod"
    /// <summary>
    /// This property represents the number of the male participants to a communication (verbal, singing, kinesic).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/numberOfMaleParticipants"></see></summary>
    let numberOfMaleParticipants = _prefix "numberOfMaleParticipants"
    /// <summary>
    /// This property represents the number of the male participants to a communication (verbal, singing, kinesic).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/numberOfFemaleParticipants"></see></summary>
    let numberOfFemaleParticipants = _prefix "numberOfFemaleParticipants"
    /// <summary>
    /// This property relates a communication medium to its type (e.g.: verbal, singing, etc.)
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasCommunicationMediumType"></see></summary>
    let hasCommunicationMediumType = _prefix "hasCommunicationMediumType"
    /// <summary>
    /// This is the inverse property of "has communication medium type".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isCommunicationMediumTypeOf"></see></summary>
    let isCommunicationMediumTypeOf = _prefix "isCommunicationMediumTypeOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/CompleteLegibility"></see>
    /// </summary>
    let CompleteLegibility = _prefix "CompleteLegibility"
    /// <summary>
    /// This class represents the legibility status (complete, decent, good, lowered, impossible) of a numinsmatic property. It is related to the property's conservation status.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Legibility"></see></summary>
    let Legibility = _prefix "Legibility"
    /// <summary>
    /// This class represents the conservation status of the cultural property.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/ConservationStatus"></see></summary>
    let ConservationStatus = _prefix "ConservationStatus"
    /// <summary>
    /// This property relates a conservation status to one of its type's values.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasConservationStatusType"></see></summary>
    let hasConservationStatusType = _prefix "hasConservationStatusType"
    /// <summary>
    /// This property relates a conservation status of a cultural property to that cultural property.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isConservationStatusOf"></see></summary>
    let isConservationStatusOf = _prefix "isConservationStatusOf"
    /// <summary>
    /// This property relates a numismatic entity's conservation status to its legibility status.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasLegibility"></see></summary>
    let hasLegibility = _prefix "hasLegibility"
    /// <summary>
    /// This is the inverse property of "has conservation status type".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isConservationStatusTypeOf"></see></summary>
    let isConservationStatusTypeOf = _prefix "isConservationStatusTypeOf"
    /// <summary>
    /// This class represent a counterstamp (or countermark), that is a partial or complete over-stamping of a coin, generally affixed in order to change its value or issuing authority.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Counterstamp"></see></summary>
    let Counterstamp = _prefix "Counterstamp"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/CoveredArea"></see>
    /// </summary>
    let CoveredArea = _prefix "CoveredArea"

    /// <summary>
    /// This class represents the technical description of a cultural entity, which uses all the technical concepts classifying the technical characteristics that a cultural entity can have. This class is a particular type of the class Description, which is the class for socially constructed objects (i.e. texts, values, categories, relations, contexts) used to describe other objects in a structured manner.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CulturalEntityTechnicalDescription"></see></summary>
    let CulturalEntityTechnicalDescription =
        _prefix "CulturalEntityTechnicalDescription"

    /// <summary>
    /// This property relates a technical description of a cultural property to one of the concepts used in that description.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/usesTechnicalConcept"></see></summary>
    let usesTechnicalConcept = _prefix "usesTechnicalConcept"
    /// <summary>
    /// This property relates a technical description of a cultural entity to a situation that satisfies that description.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isTechnicalDescriptionSatisfiedBy"></see></summary>
    let isTechnicalDescriptionSatisfiedBy = _prefix "isTechnicalDescriptionSatisfiedBy"
    /// <summary>
    /// This class represents a characteristic of a cultural property. For example it can represent a cultural property's particular costituent material or the technique with which it was made or its shape or color. Each technical characteristic is classified by a concept (i.e. "clay" is a techical characteristic classified by the technical concept "material" related to a cultural property). For each cultural property typology can be registered some specific technical characteristics.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/TechnicalCharacteristic"></see></summary>
    let TechnicalCharacteristic = _prefix "TechnicalCharacteristic"
    /// <summary>
    /// This property connects a technical status, with respect to a specific entity (as a cultural entity) to one of the technical characteristics related to that status.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/includesTechnicalCharacteristic"></see></summary>
    let includesTechnicalCharacteristic = _prefix "includesTechnicalCharacteristic"
    /// <summary>
    /// This property connects a technical status to a cultural entity. This status is valid until a specific moment and is represented by the technical characteristics that a cultural entity has in that moment.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isTechnicalStatusOf"></see></summary>
    let isTechnicalStatusOf = _prefix "isTechnicalStatusOf"
    /// <summary>
    /// This is the inverse property of "has cultural property accessibility".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isCulturalPropertyAccessibilityOf"></see></summary>
    let isCulturalPropertyAccessibilityOf = _prefix "isCulturalPropertyAccessibilityOf"
    /// <summary>
    /// This is the inverse property of "has cultural property availability".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isCulturalPropertyAvailabilityOf"></see></summary>
    let isCulturalPropertyAvailabilityOf = _prefix "isCulturalPropertyAvailabilityOf"
    /// <summary>
    /// This class represents the definition of a cultural property. It is the term or expression which identifies the property that is being catalogued.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CulturalPropertyDefinition"></see></summary>
    let CulturalPropertyDefinition = _prefix "CulturalPropertyDefinition"
    /// <summary>
    /// This is the inverse property of "has cultural property definition".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isCulturalPropertyDefinitionOf"></see></summary>
    let isCulturalPropertyDefinitionOf = _prefix "isCulturalPropertyDefinitionOf"
    /// <summary>
    /// This class represents the morphological or functional specification, which are useful to define a cultural property for a more precise individuation.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CulturalPropertySpecification"></see></summary>
    let CulturalPropertySpecification = _prefix "CulturalPropertySpecification"
    /// <summary>
    /// This is the inverse property of "has cultural property specification".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isCulturalPropertySpecificationOf"></see></summary>
    let isCulturalPropertySpecificationOf = _prefix "isCulturalPropertySpecificationOf"
    /// <summary>
    /// This is the inverse property of "has cultural property type".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isCulturalPropertyTypeOf"></see></summary>
    let isCulturalPropertyTypeOf = _prefix "isCulturalPropertyTypeOf"
    /// <summary>
    /// This property relates a cultural entity's typology to one of its components, i.e.  its definition.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertyDefinition"></see></summary>
    let hasCulturalPropertyDefinition = _prefix "hasCulturalPropertyDefinition"
    /// <summary>
    /// This property relates a cultural entity's typology to its components, i.e. morphological and functional specifications.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertySpecification"></see></summary>
    let hasCulturalPropertySpecification = _prefix "hasCulturalPropertySpecification"
    /// <summary>
    /// This individual represents the current designation.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CurrentDesignation"></see></summary>
    let CurrentDesignation = _prefix "CurrentDesignation"
    /// <summary>
    /// This individual represents the usual designation.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/CustomaryDesignation"></see></summary>
    let CustomaryDesignation = _prefix "CustomaryDesignation"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/DecentConservationStatus"></see>
    /// </summary>
    let DecentConservationStatus = _prefix "DecentConservationStatus"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/DecentLegibility"></see>
    /// </summary>
    let DecentLegibility = _prefix "DecentLegibility"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/DecorativeApparatus"></see>
    /// </summary>
    let DecorativeApparatus = _prefix "DecorativeApparatus"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Dedication"></see>
    /// </summary>
    let Dedication = _prefix "Dedication"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Depth"></see>
    /// </summary>
    let Depth = _prefix "Depth"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/DepthOrHeight"></see>
    /// </summary>
    let DepthOrHeight = _prefix "DepthOrHeight"
    /// <summary>
    /// This class represents a certain cultural property's designation/denomination attested over time.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/DesignationInTime"></see></summary>
    let DesignationInTime = _prefix "DesignationInTime"
    /// <summary>
    /// This property relates a cultural entity designation to its type.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasDesignationType"></see></summary>
    let hasDesignationType = _prefix "hasDesignationType"
    /// <summary>
    /// This is the inverse property of "has designation in time".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isDesignationInTimeOf"></see></summary>
    let isDesignationInTimeOf = _prefix "isDesignationInTimeOf"
    /// <summary>
    /// This is the inverse property of "has designation type".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isDesignationTypeOf"></see></summary>
    let isDesignationTypeOf = _prefix "isDesignationTypeOf"
    /// <summary>
    /// This individual represents the dialect designation.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/DialectalDesignation"></see></summary>
    let DialectalDesignation = _prefix "DialectalDesignation"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Diameter"></see>
    /// </summary>
    let Diameter = _prefix "Diameter"
    /// <summary>
    /// This individual represents the identified diapason (note, temperature and eventually humidity during the detection).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Diapason"></see></summary>
    let Diapason = _prefix "Diapason"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Duration"></see>
    /// </summary>
    let Duration = _prefix "Duration"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/EdgeCircumference"></see>
    /// </summary>
    let EdgeCircumference = _prefix "EdgeCircumference"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Emblem"></see>
    /// </summary>
    let Emblem = _prefix "Emblem"
    /// <summary>
    /// This individual represents a musical instrument's musical extension.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Extension"></see></summary>
    let Extension = _prefix "Extension"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/ExternalInternalLength"></see>
    /// </summary>
    let ExternalInternalLength = _prefix "ExternalInternalLength"
    /// <summary>
    /// This individual represents the format used to write a digital resource on a data medium.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/FileFormat"></see></summary>
    let FileFormat = _prefix "FileFormat"
    /// <summary>
    /// This individual represents the filigree of an artwork, painting, photography, print.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Filigree"></see></summary>
    let Filigree = _prefix "Filigree"
    /// <summary>
    /// This is the inverse property of "has font style".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isFontStyleOf"></see></summary>
    let isFontStyleOf = _prefix "isFontStyleOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/FrontTotalLength"></see>
    /// </summary>
    let FrontTotalLength = _prefix "FrontTotalLength"
    /// <summary>
    /// This is the inverse property of "has functional purpose".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isFunctionalPurposeOf"></see></summary>
    let isFunctionalPurposeOf = _prefix "isFunctionalPurposeOf"
    /// <summary>
    /// This individual represents the techincal definition of textured fabrics of an ancient or contemporary garment, according to the standard provided by C.I.E.T.A., or laces. It can also represent the dinstrinction between plain fabric and textured fabric.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/GarmentAnalysis"></see></summary>
    let GarmentAnalysis = _prefix "GarmentAnalysis"
    /// <summary>
    /// This individual represents the dominant color of a ancient and contemporary garment, usually it is base fabric's color, or the interlaced decoration's color.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/GarmentColour"></see></summary>
    let GarmentColour = _prefix "GarmentColour"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/GoodConservationStatus"></see>
    /// </summary>
    let GoodConservationStatus = _prefix "GoodConservationStatus"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/GoodLegibility"></see>
    /// </summary>
    let GoodLegibility = _prefix "GoodLegibility"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Height"></see>
    /// </summary>
    let Height = _prefix "Height"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/HeightLength"></see>
    /// </summary>
    let HeightLength = _prefix "HeightLength"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/HeightLengthWidth"></see>
    /// </summary>
    let HeightLengthWidth = _prefix "HeightLengthWidth"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/HeightWidthThickness"></see>
    /// </summary>
    let HeightWidthThickness = _prefix "HeightWidthThickness"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/HipCircumference"></see>
    /// </summary>
    let HipCircumference = _prefix "HipCircumference"
    /// <summary>
    /// This individual represents a historical designation.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/HistoricalDesignation"></see></summary>
    let HistoricalDesignation = _prefix "HistoricalDesignation"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/HistoricalPlaque"></see>
    /// </summary>
    let HistoricalPlaque = _prefix "HistoricalPlaque"

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/IconographicAndDecorativeApparatus"></see>
    /// </summary>
    let IconographicAndDecorativeApparatus =
        _prefix "IconographicAndDecorativeApparatus"

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/IconographicApparatus"></see>
    /// </summary>
    let IconographicApparatus = _prefix "IconographicApparatus"
    /// <summary>
    /// This class represents the iconographic or decorative apparaturs of a cultural property. It is intended as the more or less complex set of iconographic or decorative representations on the cultural property.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/IconographicOrDecorativeApparatus"></see></summary>
    let IconographicOrDecorativeApparatus = _prefix "IconographicOrDecorativeApparatus"

    /// <summary>
    /// This is the inverse property of "has iconographic or decorative apparatus".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isIconographicOrDecorativeApparatusOf"></see></summary>
    let isIconographicOrDecorativeApparatusOf =
        _prefix "isIconographicOrDecorativeApparatusOf"

    /// <summary>
    /// This property relates a iconographic or decorative apparatus to its type.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasIconographicOrDecorativeApparatusType"></see></summary>
    let hasIconographicOrDecorativeApparatusType =
        _prefix "hasIconographicOrDecorativeApparatusType"

    /// <summary>
    /// This property connects a cultural entity's iconographic or decorative apparatus to its ornamental motif (anthropomorphic, zoomorphic, geometric).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasOrnamentalMotif"></see></summary>
    let hasOrnamentalMotif = _prefix "hasOrnamentalMotif"
    /// <summary>
    /// This class represents the ornamental motif (anthropomorphous, zoomorphic, geometric) represented by a cultural property's iconographic and decorative apparatus.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/OrnamentalMotif"></see></summary>
    let OrnamentalMotif = _prefix "OrnamentalMotif"

    /// <summary>
    /// This is the inverse property of "has iconographic or decorative apparatus type".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isIconographicOrDecorativeApparatusTypeOf"></see></summary>
    let isIconographicOrDecorativeApparatusTypeOf =
        _prefix "isIconographicOrDecorativeApparatusTypeOf"

    /// <summary>
    /// This individual represents an idiomatic designation.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/IdiomaticDesignation"></see></summary>
    let IdiomaticDesignation = _prefix "IdiomaticDesignation"
    /// <summary>
    /// This is the inverse property of "has implementation method".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isImplementationMethodOf"></see></summary>
    let isImplementationMethodOf = _prefix "isImplementationMethodOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/ImpossibleLegibility"></see>
    /// </summary>
    let ImpossibleLegibility = _prefix "ImpossibleLegibility"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Inaccessible"></see>
    /// </summary>
    let Inaccessible = _prefix "Inaccessible"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/InstrumentalCommunication"></see>
    /// </summary>
    let InstrumentalCommunication = _prefix "InstrumentalCommunication"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/KinesicCommunication"></see>
    /// </summary>
    let KinesicCommunication = _prefix "KinesicCommunication"
    /// <summary>
    /// This is the inverse property of "has legibility".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isLegibilityOf"></see></summary>
    let isLegibilityOf = _prefix "isLegibilityOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Length"></see>
    /// </summary>
    let Length = _prefix "Length"
    /// <summary>
    /// This individual represents an local designation.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/LocalDesignation"></see></summary>
    let LocalDesignation = _prefix "LocalDesignation"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Logo"></see>
    /// </summary>
    let Logo = _prefix "Logo"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/LoweredLegibility"></see>
    /// </summary>
    let LoweredLegibility = _prefix "LoweredLegibility"
    /// <summary>
    /// This individual represents the mass storage where a digital photograph is stored.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/MassStorage"></see></summary>
    let MassStorage = _prefix "MassStorage"
    /// <summary>
    /// This individual represents the material through which an object has been realized, e.g. a cultural entity.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Material"></see></summary>
    let Material = _prefix "Material"
    /// <summary>
    /// This individual represents the material or technique through which an object has been realized, e.g. a cultural entity. In ICCD standard for cataloguing cultural entities, this label is necessary when material and techinque are registered in the same field.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/MaterialOrTechnique"></see></summary>
    let MaterialOrTechnique = _prefix "MaterialOrTechnique"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/MaximumMinimumWidth"></see>
    /// </summary>
    let MaximumMinimumWidth = _prefix "MaximumMinimumWidth"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/MaximumTotalLength"></see>
    /// </summary>
    let MaximumTotalLength = _prefix "MaximumTotalLength"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/MaximumTotalWidth"></see>
    /// </summary>
    let MaximumTotalWidth = _prefix "MaximumTotalWidth"
    /// <summary>
    /// This class represents a measurement of an object. Measurements realte to the cultural property's dimensions.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Measurement"></see></summary>
    let Measurement = _prefix "Measurement"
    /// <summary>
    /// This property relates a measurement to its type.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasMeasurementType"></see></summary>
    let hasMeasurementType = _prefix "hasMeasurementType"
    /// <summary>
    /// This property relates a measurement to its value.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasValue"></see></summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    /// This class represents the set of measurments observed for an object.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/MeasurementCollection"></see></summary>
    let MeasurementCollection = _prefix "MeasurementCollection"
    /// <summary>
    /// This property connects an object's measure to the observed measures' collection of that object. It is the inverse property of hasMeasurement.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isMeasurementIn"></see></summary>
    let isMeasurementIn = _prefix "isMeasurementIn"
    /// <summary>
    /// This is the inverse property of "has measurement collection".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isMeasurementCollectionOf"></see></summary>
    let isMeasurementCollectionOf = _prefix "isMeasurementCollectionOf"
    /// <summary>
    /// This property connects a set of observed measures on an object to one of those measures.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasMeasurement"></see></summary>
    let hasMeasurement = _prefix "hasMeasurement"
    /// <summary>
    /// This is the inverse property of "has measurement type".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isMeasurementTypeOf"></see></summary>
    let isMeasurementTypeOf = _prefix "isMeasurementTypeOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/MediocreConservationStatus"></see>
    /// </summary>
    let MediocreConservationStatus = _prefix "MediocreConservationStatus"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/NoLongerAvailable"></see>
    /// </summary>
    let NoLongerAvailable = _prefix "NoLongerAvailable"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/OccupiedStorageSpace"></see>
    /// </summary>
    let OccupiedStorageSpace = _prefix "OccupiedStorageSpace"
    /// <summary>
    /// This class represents the orientation of an object (i.e. N.W., S.E.), considering the main axis.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Orientation"></see></summary>
    let Orientation = _prefix "Orientation"
    /// <summary>
    /// This is the inverse property of "has orientation".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isOrientationOf"></see></summary>
    let isOrientationOf = _prefix "isOrientationOf"
    /// <summary>
    /// This individual represents original designation.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/OriginalDesignation"></see></summary>
    let OriginalDesignation = _prefix "OriginalDesignation"
    /// <summary>
    /// This is the inverse property of "has ornamental motif".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isOrnamentalMotifOf"></see></summary>
    let isOrnamentalMotifOf = _prefix "isOrnamentalMotifOf"
    /// <summary>
    /// This individual represents a designation in other language.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/OtherLanguageDesignation"></see></summary>
    let OtherLanguageDesignation = _prefix "OtherLanguageDesignation"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/PartiallyAccessible"></see>
    /// </summary>
    let PartiallyAccessible = _prefix "PartiallyAccessible"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Perimeter"></see>
    /// </summary>
    let Perimeter = _prefix "Perimeter"
    /// <summary>
    /// This individual represents a digital photograph's colour, i.e. black and white or colours.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/PhotoColour"></see></summary>
    let PhotoColour = _prefix "PhotoColour"
    /// <summary>
    /// This individual represents the visualization, storage and processing program used for a digital photograph.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/PhotoProgram"></see></summary>
    let PhotoProgram = _prefix "PhotoProgram"
    /// <summary>
    /// This individual represents a digital photograph format, intended as the photogrphic material's standardised size (e.g. negative, positives).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/PhotoSize"></see></summary>
    let PhotoSize = _prefix "PhotoSize"
    /// <summary>
    /// This individual represents a digital photograph size in pixels.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/PixelDimension"></see></summary>
    let PixelDimension = _prefix "PixelDimension"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Power"></see>
    /// </summary>
    let Power = _prefix "Power"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/ProxemicsCommunication"></see>
    /// </summary>
    let ProxemicsCommunication = _prefix "ProxemicsCommunication"
    /// <summary>
    /// This individual represents a digital resource's quality level, e.g. high-resolution, low-resolution, preview.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/QualityLevel"></see></summary>
    let QualityLevel = _prefix "QualityLevel"
    /// <summary>
    /// This individual represents the specific value and resolution used for storing a digital photograph.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Resolution"></see></summary>
    let Resolution = _prefix "Resolution"
    /// <summary>
    /// This class represents a sample collected from an archeological property.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/SampleCollected"></see></summary>
    let SampleCollected = _prefix "SampleCollected"
    /// <summary>
    /// This property represents a cultural entity's postion (e.g. elements like crests, emblems, stamps or the depicted subjects), with respect to the whole entity or to its specific part.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/positionOnCulturalProperty"></see></summary>
    let positionOnCulturalProperty = _prefix "positionOnCulturalProperty"
    /// <summary>
    /// This property represents the seample collected identifier.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/sampleCollectedIdentifier"></see></summary>
    let sampleCollectedIdentifier = _prefix "sampleCollectedIdentifier"
    /// <summary>
    /// This property relates a sample collected to its type.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasSampleCollectedType"></see></summary>
    let hasSampleCollectedType = _prefix "hasSampleCollectedType"
    /// <summary>
    /// This is the inverse property of "has sample collected".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isSampleCollectedFrom"></see></summary>
    let isSampleCollectedFrom = _prefix "isSampleCollectedFrom"
    /// <summary>
    /// This is the inverse property of "has sample collected type".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isSampleCollectedTypeOf"></see></summary>
    let isSampleCollectedTypeOf = _prefix "isSampleCollectedTypeOf"
    /// <summary>
    /// This individual represents an object's shape. It is used for bidimensional objects, e.g. octagonal or round shape.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Shape"></see></summary>
    let Shape = _prefix "Shape"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/SingingCommunication"></see>
    /// </summary>
    let SingingCommunication = _prefix "SingingCommunication"
    /// <summary>
    /// This individual represents a slang designation.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/SlangDesignation"></see></summary>
    let SlangDesignation = _prefix "SlangDesignation"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Stamp"></see>
    /// </summary>
    let Stamp = _prefix "Stamp"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/StorageCapacity"></see>
    /// </summary>
    let StorageCapacity = _prefix "StorageCapacity"
    /// <summary>
    /// This individual represents the method and color depth through which a digital photograph has been stored.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/StorageMethodColourDepth"></see></summary>
    let StorageMethodColourDepth = _prefix "StorageMethodColourDepth"
    /// <summary>
    /// This property connects a support (e.g. "paper label") to an element (stamp, embelem, inscription, mark) which has been represented on it. It is the inverse property of hasSupport.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isSupportOf"></see></summary>
    let isSupportOf = _prefix "isSupportOf"
    /// <summary>
    /// This property connects an entity's techincal characteristic to a technical concept, which classifies that characteristic.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isCharacteristicClassifiedBy"></see></summary>
    let isCharacteristicClassifiedBy = _prefix "isCharacteristicClassifiedBy"
    /// <summary>
    /// This property relates a technical characteristic (e.g. marble) to the status of a cultural entity that includes that characteristic.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isIncludedInTechnicalStatus"></see></summary>
    let isIncludedInTechnicalStatus = _prefix "isIncludedInTechnicalStatus"
    /// <summary>
    /// This individual represents an object's execution technique.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Technique"></see></summary>
    let Technique = _prefix "Technique"
    /// <summary>
    /// This individual represents a musical instrument adopted temperament, especially in relation to an object in its original conditions, or after its restoration. For idiophones with fixed keys (e.g. xylophone, litophone, metallophone) the temperament represents the succession of intervals.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Temperament"></see></summary>
    let Temperament = _prefix "Temperament"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Thickness"></see>
    /// </summary>
    let Thickness = _prefix "Thickness"
    /// <summary>
    /// This individual represents a musical instrument tuning.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/Tuning"></see></summary>
    let Tuning = _prefix "Tuning"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/UnavailableConservationStatus"></see>
    /// </summary>
    let UnavailableConservationStatus = _prefix "UnavailableConservationStatus"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/UndetectedMeasurements"></see>
    /// </summary>
    let UndetectedMeasurements = _prefix "UndetectedMeasurements"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/VariousMeasurements"></see>
    /// </summary>
    let VariousMeasurements = _prefix "VariousMeasurements"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/VerbalCommunication"></see>
    /// </summary>
    let VerbalCommunication = _prefix "VerbalCommunication"
    /// <summary>
    /// This individual represents a musical instrument vibrating length, in particular a chordophone.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/VibratingLenght"></see></summary>
    let VibratingLenght = _prefix "VibratingLenght"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Volume"></see>
    /// </summary>
    let Volume = _prefix "Volume"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/VolumetricDiamensions"></see>
    /// </summary>
    let VolumetricDiamensions = _prefix "VolumetricDiamensions"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/WaistCircumference"></see>
    /// </summary>
    let WaistCircumference = _prefix "WaistCircumference"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Weight"></see>
    /// </summary>
    let Weight = _prefix "Weight"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/Width"></see>
    /// </summary>
    let Width = _prefix "Width"
    /// <summary>
    /// This is the inverse property of "has writing system".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isWritingSystemOf"></see></summary>
    let isWritingSystemOf = _prefix "isWritingSystemOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/denotative-description/WrittenCommunication"></see>
    /// </summary>
    let WrittenCommunication = _prefix "WrittenCommunication"
    /// <summary>
    /// This property represents the morphology of an anthropological material.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/anthropologicalMaterialMorphology"></see></summary>
    let anthropologicalMaterialMorphology = _prefix "anthropologicalMaterialMorphology"
    /// <summary>
    /// This is the inverse property of "has available notes".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/areAvailableNotesOf"></see></summary>
    let areAvailableNotesOf = _prefix "areAvailableNotesOf"
    /// <summary>
    /// This property relates a technical characteristic to an entity.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isTechnicalCharacteristicOf"></see></summary>
    let isTechnicalCharacteristicOf = _prefix "isTechnicalCharacteristicOf"
    /// <summary>
    /// This property relates a musical instrument to the playable notes by it, from low to high.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasAvailableNotes"></see></summary>
    let hasAvailableNotes = _prefix "hasAvailableNotes"
    /// <summary>
    /// This property connects a techical concept to an entity's technical characteristic. It is the inverse property of isCharacteristicClassifiedBy.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/classifiesCharacteristic"></see></summary>
    let classifiesCharacteristic = _prefix "classifiesCharacteristic"
    /// <summary>
    /// This property relates a musical good to one of its accessories. In other words, it is an object linkable to a musical object, whether it is functional to the sound production, or if it is the sound's production or conservation medium.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasAccessory"></see></summary>
    let hasAccessory = _prefix "hasAccessory"
    /// <summary>
    /// This property relates a cultural property to an element affixed on it (e.g. inscription, stamp, etc.)
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasAffixedElement"></see></summary>
    let hasAffixedElement = _prefix "hasAffixedElement"
    /// <summary>
    /// This property relatesan inscription (or an emblem, a mark, etc.) to its type.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasAffixedElementType"></see></summary>
    let hasAffixedElementType = _prefix "hasAffixedElementType"
    /// <summary>
    /// This property relates an entity to a technical characteristic (e.g. material, technique, colour, quality level).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasTechnicalCharacteristic"></see></summary>
    let hasTechnicalCharacteristic = _prefix "hasTechnicalCharacteristic"
    /// <summary>
    /// This property relates an intangible cultural property to a communication medium.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasCommunicationMedium"></see></summary>
    let hasCommunicationMedium = _prefix "hasCommunicationMedium"
    /// <summary>
    /// This property relates the cultural property with its conservation status.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasConservationStatus"></see></summary>
    let hasConservationStatus = _prefix "hasConservationStatus"
    /// <summary>
    /// This property relates the cultural property to its accessibility, that is the possibility to reach or enter that cultural property, for example for cataloguing activities (e.g.: an immovable cultural property located in a walled area, a movable cultural property located on the top shelf, a totally accessible cultural property, etc.)
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertyAccessibility"></see></summary>
    let hasCulturalPropertyAccessibility = _prefix "hasCulturalPropertyAccessibility"
    /// <summary>
    /// This class relates the cultural property to its availability, that is wheter the cultural property is available or not (e.g.: theft, destruction) for example for cataloguing activities.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertyAvailability"></see></summary>
    let hasCulturalPropertyAvailability = _prefix "hasCulturalPropertyAvailability"
    /// <summary>
    /// This property relates a cultural property to its type.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasCulturalPropertyType"></see></summary>
    let hasCulturalPropertyType = _prefix "hasCulturalPropertyType"
    /// <summary>
    /// This property connects a dedication to its dedicaatee, which is the person or institution to whom the dedication is addressed.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasDedicatee"></see></summary>
    let hasDedicatee = _prefix "hasDedicatee"
    /// <summary>
    /// This is the inverse property of "has dedicatee".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isDedicateeOf"></see></summary>
    let isDedicateeOf = _prefix "isDedicateeOf"
    /// <summary>
    /// This property connects a cultural entity to its denomination and/or dedication, or title (for FF legislation) over time.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasDesignationInTime"></see></summary>
    let hasDesignationInTime = _prefix "hasDesignationInTime"
    /// <summary>
    /// This property relates a musical instrument to the identified diapason (note, temperature and eventually humidity during the detection).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasDiapason"></see></summary>
    let hasDiapason = _prefix "hasDiapason"
    /// <summary>
    /// This is the inverse property of "has diapason".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isDiapasonOf"></see></summary>
    let isDiapasonOf = _prefix "isDiapasonOf"
    /// <summary>
    /// This property relates a musical instrument to its extension.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasExtension"></see></summary>
    let hasExtension = _prefix "hasExtension"
    /// <summary>
    /// This is the inverse property of "has extension".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isExtensionOf"></see></summary>
    let isExtensionOf = _prefix "isExtensionOf"
    /// <summary>
    /// This property relates a digital resource to the format used to write it on a data medium.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasFileFormat"></see></summary>
    let hasFileFormat = _prefix "hasFileFormat"
    /// <summary>
    /// This is the inverse property of "has file format"
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isFileFormatOf"></see></summary>
    let isFileFormatOf = _prefix "isFileFormatOf"
    /// <summary>
    /// This property relates an artwork, painting, photography, print to its filigree.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasFiligree"></see></summary>
    let hasFiligree = _prefix "hasFiligree"
    /// <summary>
    /// This is the inverse property of "has filigree".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isFiligreeOf"></see></summary>
    let isFiligreeOf = _prefix "isFiligreeOf"
    /// <summary>
    /// This property relates an ancient or contemporary garment to the technical definition of textured fabrics, according to the standard provided by C.I.E.T.A., or laces. It can represent the dinstinction between plain fabric and textured fabric.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasGarmentAnalysis"></see></summary>
    let hasGarmentAnalysis = _prefix "hasGarmentAnalysis"
    /// <summary>
    /// This is the inverse property of "has garment analysis".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isGarmentAnalysisOf"></see></summary>
    let isGarmentAnalysisOf = _prefix "isGarmentAnalysisOf"
    /// <summary>
    /// This property relates an ancient and contemporary garment to its dominant color, usually it is base fabric's color, or the interlaced decoration's color.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasGarmentColour"></see></summary>
    let hasGarmentColour = _prefix "hasGarmentColour"
    /// <summary>
    /// This is the inverse property of "has garment colour".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isGarmentColourOf"></see></summary>
    let isGarmentColourOf = _prefix "isGarmentColourOf"

    /// <summary>
    /// This property relates a cultural enitity to its iconographic or decorative apparatus.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasIconographicOrDecorativeApparatus"></see></summary>
    let hasIconographicOrDecorativeApparatus =
        _prefix "hasIconographicOrDecorativeApparatus"

    /// <summary>
    /// This property represent the location as a subject of a cultural entity.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasLocationSubject"></see></summary>
    let hasLocationSubject = _prefix "hasLocationSubject"
    /// <summary>
    /// This is the inverse property of "has location subject".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isLocationSubjectOf"></see></summary>
    let isLocationSubjectOf = _prefix "isLocationSubjectOf"
    /// <summary>
    /// This property relates a digital photograph to the mass storage where a digital photograph is stored.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasMassStorage"></see></summary>
    let hasMassStorage = _prefix "hasMassStorage"
    /// <summary>
    /// This is the inverse property of "has mass storage".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isMassStorageOf"></see></summary>
    let isMassStorageOf = _prefix "isMassStorageOf"
    /// <summary>
    /// This property relates an object to its material.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasMaterial"></see></summary>
    let hasMaterial = _prefix "hasMaterial"
    /// <summary>
    /// This property relates an object to the material or technique through which an object has been realized, e.g. a cultural entity. In ICCD standards for cataloguing cultural entities, this label is necessary when material and technique are registered in the same field.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasMaterialOrTechnique"></see></summary>
    let hasMaterialOrTechnique = _prefix "hasMaterialOrTechnique"
    /// <summary>
    /// This is the inverse property of "has material"
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isMaterialOf"></see></summary>
    let isMaterialOf = _prefix "isMaterialOf"
    /// <summary>
    /// This is the inverse property of "has material or technique"
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isMaterialOrTechniqueOf"></see></summary>
    let isMaterialOrTechniqueOf = _prefix "isMaterialOrTechniqueOf"
    /// <summary>
    /// This property connects an object to the collection of observed measures on it.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasMeasurementCollection"></see></summary>
    let hasMeasurementCollection = _prefix "hasMeasurementCollection"
    /// <summary>
    /// This property connects an object to its orientation, considering its major axis.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasOrientation"></see></summary>
    let hasOrientation = _prefix "hasOrientation"
    /// <summary>
    /// This property relates a digital photograph to its colour, i.e. black and white or colours.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasPhotoColour"></see></summary>
    let hasPhotoColour = _prefix "hasPhotoColour"
    /// <summary>
    /// This is the inverse property of "has photo colour"
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isPhotoColourOf"></see></summary>
    let isPhotoColourOf = _prefix "isPhotoColourOf"
    /// <summary>
    /// This property relates a digital photograph to the visualization, storage and processing program used for the digital photograph.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasPhotoProgram"></see></summary>
    let hasPhotoProgram = _prefix "hasPhotoProgram"
    /// <summary>
    /// This is the inverse property of "has photo program".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isPhotoProgramOf"></see></summary>
    let isPhotoProgramOf = _prefix "isPhotoProgramOf"
    /// <summary>
    /// This property relates a digital photograph to its format, intended as the photographic material's standardised size (e.g. negative, positives).
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasPhotoSize"></see></summary>
    let hasPhotoSize = _prefix "hasPhotoSize"
    /// <summary>
    /// This is the inverse property of "has photo size"
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isPhotoSizeOf"></see></summary>
    let isPhotoSizeOf = _prefix "isPhotoSizeOf"
    /// <summary>
    /// This property relates a digital resource to its size in pixels.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasPixelDimension"></see></summary>
    let hasPixelDimension = _prefix "hasPixelDimension"
    /// <summary>
    /// This is the inverse property of "has pixel dimension"
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isPixelDimensionOf"></see></summary>
    let isPixelDimensionOf = _prefix "isPixelDimensionOf"
    /// <summary>
    /// This property relates a digital resource to its quality level, e.g. high-resolution, low-resolution, preview.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasQualityLevel"></see></summary>
    let hasQualityLevel = _prefix "hasQualityLevel"
    /// <summary>
    /// This is the inverse property of "has quality level"
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isQualityLevelOf"></see></summary>
    let isQualityLevelOf = _prefix "isQualityLevelOf"
    /// <summary>
    /// This property relates a digital resource to theresolution used for storing it.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasResolution"></see></summary>
    let hasResolution = _prefix "hasResolution"
    /// <summary>
    /// This is the inverse property of "has resolution"
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isResolutionOf"></see></summary>
    let isResolutionOf = _prefix "isResolutionOf"
    /// <summary>
    /// This property connects a archaeological entity to a sample collected from it.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasSampleCollected"></see></summary>
    let hasSampleCollected = _prefix "hasSampleCollected"
    /// <summary>
    /// This property relates an object to its shape. It is used for bidimensional objects, e.g. octagonal or round shape.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasShape"></see></summary>
    let hasShape = _prefix "hasShape"
    /// <summary>
    /// This is the inverse property of "has shape"
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isShapeOf"></see></summary>
    let isShapeOf = _prefix "isShapeOf"
    /// <summary>
    /// This property relates a digital photograph to the method and color depth through which a digital photograph has been stored.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasStorageMethodOrColourDepth"></see></summary>
    let hasStorageMethodOrColourDepth = _prefix "hasStorageMethodOrColourDepth"
    /// <summary>
    /// This is the inverse property of "has storage method or colour depth".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isStorageMethodOrColourDepthOf"></see></summary>
    let isStorageMethodOrColourDepthOf = _prefix "isStorageMethodOrColourDepthOf"
    /// <summary>
    /// This property relates an object to its execution technique.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasTechnique"></see></summary>
    let hasTechnique = _prefix "hasTechnique"
    /// <summary>
    /// This is the inverse property of "has technique"
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isTechniqueOf"></see></summary>
    let isTechniqueOf = _prefix "isTechniqueOf"
    /// <summary>
    /// This property relates a musical instrument to the adopted temperament, especially in relation to an object in its original conditions, or after its restoration. For idiophones with fixed keys (e.g. xylophone, litophone, metallophone) the temperament represents the succession of intervals.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasTemperament"></see></summary>
    let hasTemperament = _prefix "hasTemperament"
    /// <summary>
    /// This is the inverse property of "has temperament".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isTemperamentOf"></see></summary>
    let isTemperamentOf = _prefix "isTemperamentOf"
    /// <summary>
    /// This property relates a musical instrument to its tuning.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasTuning"></see></summary>
    let hasTuning = _prefix "hasTuning"
    /// <summary>
    /// This is the inverse property of "has tuning".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isTuningOf"></see></summary>
    let isTuningOf = _prefix "isTuningOf"
    /// <summary>
    /// This is the inverse property of "has value".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isValueOf"></see></summary>
    let isValueOf = _prefix "isValueOf"
    /// <summary>
    /// This property relates a musical instrument to its vibrating length, in particular a chordophone.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasVibratingLenght"></see></summary>
    let hasVibratingLenght = _prefix "hasVibratingLenght"
    /// <summary>
    /// This is the inverse property of "has vibrating lenght".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isVibratingLenghtOf"></see></summary>
    let isVibratingLenghtOf = _prefix "isVibratingLenghtOf"

    /// <summary>
    /// This property connects a collection of observed measures on an object to one of these measures, when the latter is relative to an ancient or contemporary apparel's size. The volumetric dimensions measurements determine the size for storage and can be considered as the object's orthogonal coordinates.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/hasVolumetricDimensionsMeasurement"></see></summary>
    let hasVolumetricDimensionsMeasurement =
        _prefix "hasVolumetricDimensionsMeasurement"

    /// <summary>
    /// This is the inverse property of "has volumetric dimensions measurement".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isVolumetricDimensionsMeasurementIn"></see></summary>
    let isVolumetricDimensionsMeasurementIn =
        _prefix "isVolumetricDimensionsMeasurementIn"

    /// <summary>
    /// This is the inverse property of "refers to agent".
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isAgentReferredToBy"></see></summary>
    let isAgentReferredToBy = _prefix "isAgentReferredToBy"
    /// <summary>
    /// This property connects a crest, emblem, postmark etc., located on a cultural entity to the agent (e.g. family, factory, cave, silversmith) to which it refers.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/refersToAgent"></see></summary>
    let refersToAgent = _prefix "refersToAgent"
    /// <summary>
    /// This property relates a technical concept (e.g. material) used in the technical description of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isTechnicalConceptUsedIn"></see></summary>
    let isTechnicalConceptUsedIn = _prefix "isTechnicalConceptUsedIn"
    /// <summary>
    /// This property relates a technical status (intended as a situaiton) of a cultural entity to the technical description satisfied by that situation.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/satisfiesTechnicalDescription"></see></summary>
    let satisfiesTechnicalDescription = _prefix "satisfiesTechnicalDescription"
    /// <summary>
    /// This property relates a cultural entity technical status to the time interval until which that status is valid, with regard to the moment in which the characteristics are observed.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isTechnicalStatusValidAt"></see></summary>
    let isTechnicalStatusValidAt = _prefix "isTechnicalStatusValidAt"
    /// <summary>
    /// This property relates the time interval, at which a cultural entity technical status is valid, to that technical status, with regard to the moment in which the characteristics are observed.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/isTimeIntervalValidFor"></see></summary>
    let isTimeIntervalValidFor = _prefix "isTimeIntervalValidFor"
    /// <summary>
    /// This property represents the occurrences of an affixed element on a cultular entity, that is how many times the outlined element appears on the cultual entity.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/occurrences"></see></summary>
    let occurrences = _prefix "occurrences"
    /// <summary>
    /// This property represents a cultural entity's position with respect to a complex entity to which it belongs.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/positionInComplexCulturalProperty"></see></summary>
    let positionInComplexCulturalProperty = _prefix "positionInComplexCulturalProperty"
    /// <summary>
    /// This property represents potential proposals for conservative interventions after evaluating the cultual entity's conditions at time of its cataloguing.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/proposedIntervention"></see></summary>
    let proposedIntervention = _prefix "proposedIntervention"
    /// <summary>
    /// This property represents informations about the storage conditions of a cultural property.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/storageConditions"></see></summary>
    let storageConditions = _prefix "storageConditions"
    /// <summary>
    /// This property represents the validity, intended as accurancy level, of an observed measure for an object.
    /// <see href="https://w3id.org/arco/ontology/denotative-description/validity"></see></summary>
    let validity = _prefix "validity"
