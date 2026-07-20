namespace https.w3id.org.arco.ontology.catalogue.slash

open DoxAletheia

module ctlog =
    let _namespace_name = "https://w3id.org/arco/ontology/catalogue/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This class represents an identifier of a catalogue record in information systems other than ICCD.
    /// <see href="https://w3id.org/arco/ontology/catalogue/AlternativeIdentifier"></see></summary>
    let AlternativeIdentifier = _prefix "AlternativeIdentifier"
    /// <summary>
    /// This class represents a catalogue record, that is a descriptive model collecting and organising information on a cultural property, and which can have more than one version (after editing and updating).
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecord"></see></summary>
    let CatalogueRecord = _prefix "CatalogueRecord"
    /// <summary>
    /// This class represents a version (after creation, editing, updating) of a catalogue record on a cultural property.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordVersion"></see></summary>
    let CatalogueRecordVersion = _prefix "CatalogueRecordVersion"
    /// <summary>
    /// This class represents a record describing a cultural property for purposes other than cataloguing cultural heritage.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CulturalPropertyRecord"></see></summary>
    let CulturalPropertyRecord = _prefix "CulturalPropertyRecord"
    /// <summary>
    /// This class represents an information form, an ICCD standard for cultural heritage census and reporting activities, used to acquire information for any type of entity, with a minimum set of mandatory standardized data.
    /// <see href="https://w3id.org/arco/ontology/catalogue/InformationForm"></see></summary>
    let InformationForm = _prefix "InformationForm"
    /// <summary>
    /// This class represents the catalogue record describing Architecture.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordA"></see></summary>
    let CatalogueRecordA = _prefix "CatalogueRecordA"
    /// <summary>
    /// This class represents the catalogue record describing Anthropological materials.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordAT"></see></summary>
    let CatalogueRecordAT = _prefix "CatalogueRecordAT"
    /// <summary>
    /// This class represents the catalogue record describing Intangible demo-ethno-anthropological heritage.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBDI"></see></summary>
    let CatalogueRecordBDI = _prefix "CatalogueRecordBDI"
    /// <summary>
    /// This class represents the catalogue record describing Tangible demo-ethno-anthropological heritage.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBDM"></see></summary>
    let CatalogueRecordBDM = _prefix "CatalogueRecordBDM"
    /// <summary>
    /// This class represents the catalogue record describing Natural heritage - botany.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNB"></see></summary>
    let CatalogueRecordBNB = _prefix "CatalogueRecordBNB"
    /// <summary>
    /// This class represents the catalogue record describing Natural heritage - mineralogy.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNM"></see></summary>
    let CatalogueRecordBNM = _prefix "CatalogueRecordBNM"
    /// <summary>
    /// This class represents the catalogue record describing Natural heritage - paleontology.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNP"></see></summary>
    let CatalogueRecordBNP = _prefix "CatalogueRecordBNP"
    /// <summary>
    /// This class represents the catalogue record describing Natural heritage - petrology.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNPE"></see></summary>
    let CatalogueRecordBNPE = _prefix "CatalogueRecordBNPE"
    /// <summary>
    /// This class represents the catalogue record describing Natural heritage - planetary science.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNPL"></see></summary>
    let CatalogueRecordBNPL = _prefix "CatalogueRecordBNPL"
    /// <summary>
    /// This class represents the catalogue record describing Natural heritage - zoology.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNZ"></see></summary>
    let CatalogueRecordBNZ = _prefix "CatalogueRecordBNZ"
    /// <summary>
    /// This class represents the catalogue record describing Natural heritage - archaeological complexes.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordCA"></see></summary>
    let CatalogueRecordCA = _prefix "CatalogueRecordCA"
    /// <summary>
    /// This class represents the catalogue record describing Natural heritage - historic cities / town centres.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordCNS"></see></summary>
    let CatalogueRecordCNS = _prefix "CatalogueRecordCNS"
    /// <summary>
    /// This class represents the catalogue record describing Natural heritage - drawings.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordD"></see></summary>
    let CatalogueRecordD = _prefix "CatalogueRecordD"
    /// <summary>
    /// This class represents the catalogue record describing Photography.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordF"></see></summary>
    let CatalogueRecordF = _prefix "CatalogueRecordF"
    /// <summary>
    /// This class represents the catalogue record describing Photographic Fonds.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordFF"></see></summary>
    let CatalogueRecordFF = _prefix "CatalogueRecordFF"
    /// <summary>
    /// This class represents the catalogue record describing Archaeological monuments.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordMA"></see></summary>
    let CatalogueRecordMA = _prefix "CatalogueRecordMA"
    /// <summary>
    /// This class represents the catalogue record describing Printing plates.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordMI"></see></summary>
    let CatalogueRecordMI = _prefix "CatalogueRecordMI"
    /// <summary>
    /// This class represents the catalogue record describing Numismatic properties.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordNU"></see></summary>
    let CatalogueRecordNU = _prefix "CatalogueRecordNU"
    /// <summary>
    /// This class represents the catalogue record describing Artworks.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordOA"></see></summary>
    let CatalogueRecordOA = _prefix "CatalogueRecordOA"
    /// <summary>
    /// This class represents the catalogue record describing Contemporary artworks.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordOAC"></see></summary>
    let CatalogueRecordOAC = _prefix "CatalogueRecordOAC"
    /// <summary>
    /// This class represents the catalogue record describing Parks / Gardens.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordPG"></see></summary>
    let CatalogueRecordPG = _prefix "CatalogueRecordPG"
    /// <summary>
    /// This class represents the catalogue record describing Scientific and technological heritage.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordPST"></see></summary>
    let CatalogueRecordPST = _prefix "CatalogueRecordPST"
    /// <summary>
    /// This class represents the catalogue record describing Archaeological objects.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordRA"></see></summary>
    let CatalogueRecordRA = _prefix "CatalogueRecordRA"
    /// <summary>
    /// This class represents the catalogue record describing Prints.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordS"></see></summary>
    let CatalogueRecordS = _prefix "CatalogueRecordS"
    /// <summary>
    /// This class represents the catalogue record describing Stratigraphic records.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordSAS"></see></summary>
    let CatalogueRecordSAS = _prefix "CatalogueRecordSAS"
    /// <summary>
    /// This class represents the catalogue record describing Archaeological sites.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordSI"></see></summary>
    let CatalogueRecordSI = _prefix "CatalogueRecordSI"
    /// <summary>
    /// This class represents the catalogue record describing Musical instruments.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordSM"></see></summary>
    let CatalogueRecordSM = _prefix "CatalogueRecordSM"
    /// <summary>
    /// This class represents the catalogue record describing Organs.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordSMO"></see></summary>
    let CatalogueRecordSMO = _prefix "CatalogueRecordSMO"
    /// <summary>
    /// This class represents the catalogue record describing Archaeological materials tables.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordTMA"></see></summary>
    let CatalogueRecordTMA = _prefix "CatalogueRecordTMA"
    /// <summary>
    /// This class represents the catalogue record describing Historic and contemporary garments.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordVeAC"></see></summary>
    let CatalogueRecordVeAC = _prefix "CatalogueRecordVeAC"
    /// <summary>
    /// This class represents the access profile to the data recorded in a catalogue record, giving instructions for public dissemination of data on the web.
    /// <see href="https://w3id.org/arco/ontology/catalogue/AccessProfile"></see></summary>
    let AccessProfile = _prefix "AccessProfile"
    /// <summary>
    /// This class represents the cataloguing level, defining the level of detail of the survey carried out on the cultural property (Minimum, Medium, Detailed)
    /// <see href="https://w3id.org/arco/ontology/catalogue/CataloguingLevel"></see></summary>
    let CataloguingLevel = _prefix "CataloguingLevel"
    /// <summary>
    /// This class represents the privacy level of the data recorded in a catalogue record (Minimum, Medium, Maximum).
    /// <see href="https://w3id.org/arco/ontology/catalogue/PrivacyLevel"></see></summary>
    let PrivacyLevel = _prefix "PrivacyLevel"
    /// <summary>
    /// This is the inverse property of "has access profile".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isAccessProfileOf"></see></summary>
    let isAccessProfileOf = _prefix "isAccessProfileOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasPrivacyLevel"></see>
    /// </summary>
    let hasPrivacyLevel = _prefix "hasPrivacyLevel"
    /// <summary>
    /// This class represents the reason for the adoption of a specific access profile for a catalogue record.
    /// <see href="https://w3id.org/arco/ontology/catalogue/PrivacyReason"></see></summary>
    let PrivacyReason = _prefix "PrivacyReason"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasPrivacyReason"></see>
    /// </summary>
    let hasPrivacyReason = _prefix "hasPrivacyReason"
    /// <summary>
    /// This property annotates the field or the fields of the ICCD regulation to which a specific class or property refers.
    /// <see href="https://w3id.org/arco/ontology/catalogue/iccdNormTag"></see></summary>
    let iccdNormTag = _prefix "iccdNormTag"
    /// <summary>
    /// This class represents an additional form, that describes specific information about a cultural property (epigraphic documents, stratigraphy, unit, wall typology)
    /// <see href="https://w3id.org/arco/ontology/catalogue/AdditionalForm"></see></summary>
    let AdditionalForm = _prefix "AdditionalForm"
    /// <summary>
    /// This property represents the additional form identifier.
    /// <see href="https://w3id.org/arco/ontology/catalogue/additionalFormIdentifier"></see></summary>
    let additionalFormIdentifier = _prefix "additionalFormIdentifier"
    /// <summary>
    /// This property was created as a generic property for specific subproperties, and represents the relationship between an entity that describes another entity.
    /// <see href="https://w3id.org/arco/ontology/catalogue/describes"></see></summary>
    let describes = _prefix "describes"
    /// <summary>
    /// This class represents the additional form type (Stratigraphic Unit, Wall Typology, Epigraphy)
    /// <see href="https://w3id.org/arco/ontology/catalogue/AdditionalFormType"></see></summary>
    let AdditionalFormType = _prefix "AdditionalFormType"
    /// <summary>
    /// This property relates an additional form to its type (Stratigraphic Unit, Epigraphy, Wall Typology).
    /// <see href="https://w3id.org/arco/ontology/catalogue/hasAdditionalFormType"></see></summary>
    let hasAdditionalFormType = _prefix "hasAdditionalFormType"
    /// <summary>
    /// This is the inverse property of "has additional form type".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isAdditionalFormTypeOf"></see></summary>
    let isAdditionalFormTypeOf = _prefix "isAdditionalFormTypeOf"
    /// <summary>
    /// This is the inverse property of "has alternative identifier".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isAlternativeIdentifierOf"></see></summary>
    let isAlternativeIdentifierOf = _prefix "isAlternativeIdentifierOf"
    /// <summary>
    /// This property represents the reference project of a record about a cultural property.
    /// <see href="https://w3id.org/arco/ontology/catalogue/referenceProject"></see></summary>
    let referenceProject = _prefix "referenceProject"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/C"></see>
    /// </summary>
    let C = _prefix "C"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasAccessProfile"></see>
    /// </summary>
    let hasAccessProfile = _prefix "hasAccessProfile"
    /// <summary>
    /// Property used to associate a catalogue record to one of its versions (e.g. after update)
    /// <see href="https://w3id.org/arco/ontology/catalogue/hasCatalogueRecordVersion"></see></summary>
    let hasCatalogueRecordVersion = _prefix "hasCatalogueRecordVersion"
    /// <summary>
    /// Property used to associate the catalogue record with the cultural property that the catalogue record describes.
    /// <see href="https://w3id.org/arco/ontology/catalogue/describesCulturalProperty"></see></summary>
    let describesCulturalProperty = _prefix "describesCulturalProperty"
    /// <summary>
    /// This property represents the identifier of a catalogue record describing a cultural property.
    /// <see href="https://w3id.org/arco/ontology/catalogue/catalogueRecordIdentifier"></see></summary>
    let catalogueRecordIdentifier = _prefix "catalogueRecordIdentifier"
    /// <summary>
    /// This property represents the identifier associated in the context of the SIGECweb to the xml file containing a catalogue record.
    /// <see href="https://w3id.org/arco/ontology/catalogue/systemRecordCode"></see></summary>
    let systemRecordCode = _prefix "systemRecordCode"
    /// <summary>
    /// This class represents the catalogue record describing Ethnology.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordE"></see></summary>
    let CatalogueRecordE = _prefix "CatalogueRecordE"
    /// <summary>
    /// Property used to associate a catalogue record version with the time interval in which it was edited.
    /// <see href="https://w3id.org/arco/ontology/catalogue/editedAtTime"></see></summary>
    let editedAtTime = _prefix "editedAtTime"
    /// <summary>
    /// Property used to associate a catalogue record version one of its next version.
    /// <see href="https://w3id.org/arco/ontology/catalogue/isPreviousVersionOf"></see></summary>
    let isPreviousVersionOf = _prefix "isPreviousVersionOf"
    /// <summary>
    /// This property is used to associate a particular version of a catalogue record to the role in time of an agent that plays a role in updating the catalogue record.
    /// <see href="https://w3id.org/arco/ontology/catalogue/hasCatalogueRecordVersionRiT"></see></summary>
    let hasCatalogueRecordVersionRiT = _prefix "hasCatalogueRecordVersionRiT"
    /// <summary>
    /// Property used to associate a catalogue record version to its immediate next version.
    /// <see href="https://w3id.org/arco/ontology/catalogue/isImmediatePreviousVersionOf"></see></summary>
    let isImmediatePreviousVersionOf = _prefix "isImmediatePreviousVersionOf"
    /// <summary>
    /// Property used to associate a catalogue record version to its immediate previous version.
    /// <see href="https://w3id.org/arco/ontology/catalogue/hasImmediatePreviousVersion"></see></summary>
    let hasImmediatePreviousVersion = _prefix "hasImmediatePreviousVersion"
    /// <summary>
    /// Property used to associate a catalogue record version to its previous version.
    /// <see href="https://w3id.org/arco/ontology/catalogue/hasPreviousVersion"></see></summary>
    let hasPreviousVersion = _prefix "hasPreviousVersion"
    /// <summary>
    /// Property, inverse of "has catalogue record version", used to associate a catalogue record version (e.g. after update) to the catalogue record.
    /// <see href="https://w3id.org/arco/ontology/catalogue/isCatalogueRecordVersionOf"></see></summary>
    let isCatalogueRecordVersionOf = _prefix "isCatalogueRecordVersionOf"
    /// <summary>
    /// This property is used to associate a catalogue record to an agent playing a role in cataloguing activities.
    /// <see href="https://w3id.org/arco/ontology/catalogue/hasCataloguingAgent"></see></summary>
    let hasCataloguingAgent = _prefix "hasCataloguingAgent"
    /// <summary>
    /// This is the inverse property of "has cataloguing level".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isCataloguingLevelOf"></see></summary>
    let isCataloguingLevelOf = _prefix "isCataloguingLevelOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/I"></see>
    /// </summary>
    let I = _prefix "I"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/P"></see>
    /// </summary>
    let P = _prefix "P"
    /// <summary>
    /// This class represents a catalogue record describing a complex cultural property.
    /// <see href="https://w3id.org/arco/ontology/catalogue/ComplexCPCatalogueRecord"></see></summary>
    let ComplexCPCatalogueRecord = _prefix "ComplexCPCatalogueRecord"
    /// <summary>
    /// This property is used to associate the identifier to a catalogue record that analyze the cultural property for reasons other than cataloguing the cultural heritage.
    /// <see href="https://w3id.org/arco/ontology/catalogue/culturalPropertyRecordIdentifier"></see></summary>
    let culturalPropertyRecordIdentifier = _prefix "culturalPropertyRecordIdentifier"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/EpigraphyForm"></see>
    /// </summary>
    let EpigraphyForm = _prefix "EpigraphyForm"
    /// <summary>
    /// This property represents the identifier assigned to a cultural property by ICCD.
    /// <see href="https://w3id.org/arco/ontology/catalogue/ICCDIdentifier"></see></summary>
    let ICCDIdentifier = _prefix "ICCDIdentifier"
    /// <summary>
    /// This property links an identifier to an information form related to a cultural property.
    /// <see href="https://w3id.org/arco/ontology/catalogue/informationFormIdentifier"></see></summary>
    let informationFormIdentifier = _prefix "informationFormIdentifier"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/MaximumPrivacy"></see>
    /// </summary>
    let MaximumPrivacy = _prefix "MaximumPrivacy"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/MediumPrivacy"></see>
    /// </summary>
    let MediumPrivacy = _prefix "MediumPrivacy"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/MinimumPrivacy"></see>
    /// </summary>
    let MinimumPrivacy = _prefix "MinimumPrivacy"
    /// <summary>
    /// This is the inverse property of "has privacy level".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isPrivacyLevelOf"></see></summary>
    let isPrivacyLevelOf = _prefix "isPrivacyLevelOf"
    /// <summary>
    /// This is the inverse property of "has privacy reason".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isPrivacyReasonOf"></see></summary>
    let isPrivacyReasonOf = _prefix "isPrivacyReasonOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/StratigraphicUnitForm"></see>
    /// </summary>
    let StratigraphicUnitForm = _prefix "StratigraphicUnitForm"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/WallTypologyForm"></see>
    /// </summary>
    let WallTypologyForm = _prefix "WallTypologyForm"
    /// <summary>
    /// This property represents the ICCD's identifier deleted for many reasons, used to search for obsolete catalogue records.
    /// <see href="https://w3id.org/arco/ontology/catalogue/deletedICCDIdentifier"></see></summary>
    let deletedICCDIdentifier = _prefix "deletedICCDIdentifier"
    /// <summary>
    /// This property, inverse property of "describes", was created as a generic property for specific subproperties, and represents the relationship between an entity described by another entity.
    /// <see href="https://w3id.org/arco/ontology/catalogue/isDescribedBy"></see></summary>
    let isDescribedBy = _prefix "isDescribedBy"
    /// <summary>
    /// This property, inverse of "describes", is used to associate a cultural property with the catalogue record that describes it.
    /// <see href="https://w3id.org/arco/ontology/catalogue/isDescribedByCatalogueRecord"></see></summary>
    let isDescribedByCatalogueRecord = _prefix "isDescribedByCatalogueRecord"
    /// <summary>
    /// This is the inverse property of "edited at time".
    /// <see href="https://w3id.org/arco/ontology/catalogue/editingTimeOf"></see></summary>
    let editingTimeOf = _prefix "editingTimeOf"
    /// <summary>
    /// This property relates an additional form to the responsible agent of that form in the SIGECweb.
    /// <see href="https://w3id.org/arco/ontology/catalogue/hasAdditionalFormResponsibleAgent"></see></summary>
    let hasAdditionalFormResponsibleAgent = _prefix "hasAdditionalFormResponsibleAgent"

    /// <summary>
    /// This is the inverse property of "has additional form responsible agent"
    /// <see href="https://w3id.org/arco/ontology/catalogue/isAdditionalFormResponsibleAgentOf"></see></summary>
    let isAdditionalFormResponsibleAgentOf =
        _prefix "isAdditionalFormResponsibleAgentOf"

    /// <summary>
    /// Property used to associate a catalogue record with an identifier created in the context of information systems other than ICCD's SIGECweb.
    /// <see href="https://w3id.org/arco/ontology/catalogue/hasAlternativeIdentifier"></see></summary>
    let hasAlternativeIdentifier = _prefix "hasAlternativeIdentifier"
    /// <summary>
    /// Property, inverse of "has catalogue record version role in time", used to associate a role in time to the agent playing that role, in the updating of a particular version of a catalogue record.
    /// <see href="https://w3id.org/arco/ontology/catalogue/isCatalogueRecordVersionRiTOf"></see></summary>
    let isCatalogueRecordVersionRiTOf = _prefix "isCatalogueRecordVersionRiTOf"
    /// <summary>
    /// This property, inverse of "has cataloguin agent", is used to associate an agent playing a role in cataloguing activities to the catalogue record.
    /// <see href="https://w3id.org/arco/ontology/catalogue/isCataloguingAgentOf"></see></summary>
    let isCataloguingAgentOf = _prefix "isCataloguingAgentOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasCataloguingLevel"></see>
    /// </summary>
    let hasCataloguingLevel = _prefix "hasCataloguingLevel"

    /// <summary>
    /// This property relates a cultural property record to the agency or the person that created that record or manages the database where the record is.
    /// <see href="https://w3id.org/arco/ontology/catalogue/hasCulturalPropertyRecordResponsibleAgent"></see></summary>
    let hasCulturalPropertyRecordResponsibleAgent =
        _prefix "hasCulturalPropertyRecordResponsibleAgent"

    /// <summary>
    /// This property, inverse of "has cultural property record responsible agent", relates the agency or the person that created the record or manages the database where the record is to the record itself.
    /// <see href="https://w3id.org/arco/ontology/catalogue/isResponsibleAgentOfCulturalPropertyRecord"></see></summary>
    let isResponsibleAgentOfCulturalPropertyRecord =
        _prefix "isResponsibleAgentOfCulturalPropertyRecord"

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasDigitalTranscriptionOperator"></see>
    /// </summary>
    let hasDigitalTranscriptionOperator = _prefix "hasDigitalTranscriptionOperator"
    /// <summary>
    /// This is the inverse property of "has digital transcription operator".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isDigitalTranscriptionOperatorOf"></see></summary>
    let isDigitalTranscriptionOperatorOf = _prefix "isDigitalTranscriptionOperatorOf"

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasDigitalTranscriptionResponsibleAgent"></see>
    /// </summary>
    let hasDigitalTranscriptionResponsibleAgent =
        _prefix "hasDigitalTranscriptionResponsibleAgent"

    /// <summary>
    /// This is the inverse property of "has digital transcription responsible agent".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isDigitalTranscriptionResponsibleAgentOf"></see></summary>
    let isDigitalTranscriptionResponsibleAgentOf =
        _prefix "isDigitalTranscriptionResponsibleAgentOf"

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasOfficialInCharge"></see>
    /// </summary>
    let hasOfficialInCharge = _prefix "hasOfficialInCharge"
    /// <summary>
    /// This is the inverse property of "has official in charge".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isOfficialInChargeOf"></see></summary>
    let isOfficialInChargeOf = _prefix "isOfficialInChargeOf"

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasResponsibleResearchAndCompilation"></see>
    /// </summary>
    let hasResponsibleResearchAndCompilation =
        _prefix "hasResponsibleResearchAndCompilation"

    /// <summary>
    /// This is the inverse property of "has responsible research and compilation".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isResponsibleResearchAndCompilationOf"></see></summary>
    let isResponsibleResearchAndCompilationOf =
        _prefix "isResponsibleResearchAndCompilationOf"

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasScientificDirector"></see>
    /// </summary>
    let hasScientificDirector = _prefix "hasScientificDirector"
    /// <summary>
    /// This is the inverse property of "has scientific director".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isScientificDirectorOf"></see></summary>
    let isScientificDirectorOf = _prefix "isScientificDirectorOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasUpdateOfficialInCharge"></see>
    /// </summary>
    let hasUpdateOfficialInCharge = _prefix "hasUpdateOfficialInCharge"
    /// <summary>
    /// This is the inverse property of "has update official in charge".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isUpdateOfficialInChargeOf"></see></summary>
    let isUpdateOfficialInChargeOf = _prefix "isUpdateOfficialInChargeOf"
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasUpdateResponsibleAgent"></see>
    /// </summary>
    let hasUpdateResponsibleAgent = _prefix "hasUpdateResponsibleAgent"
    /// <summary>
    /// This is the inverse property of "has update responsible agent",
    /// <see href="https://w3id.org/arco/ontology/catalogue/isUpdateResponsibleAgentOf"></see></summary>
    let isUpdateResponsibleAgentOf = _prefix "isUpdateResponsibleAgentOf"

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasUpdateResponsibleResearchAndCompilation"></see>
    /// </summary>
    let hasUpdateResponsibleResearchAndCompilation =
        _prefix "hasUpdateResponsibleResearchAndCompilation"

    /// <summary>
    /// This is the inverse property of "has update responsible research and compilation".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isUpdateResponsibleResearchAndCompilationOf"></see></summary>
    let isUpdateResponsibleResearchAndCompilationOf =
        _prefix "isUpdateResponsibleResearchAndCompilationOf"

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasUpdateScientificRevisor"></see>
    /// </summary>
    let hasUpdateScientificRevisor = _prefix "hasUpdateScientificRevisor"
    /// <summary>
    /// This is the inverse property of "has update scientific revisor".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isUpdateScientificRevisorOf"></see></summary>
    let isUpdateScientificRevisorOf = _prefix "isUpdateScientificRevisorOf"
    /// <summary>
    /// This property relates a cultural property to an additional form.
    /// <see href="https://w3id.org/arco/ontology/catalogue/isRelatedToAdditionalForm"></see></summary>
    let isRelatedToAdditionalForm = _prefix "isRelatedToAdditionalForm"
    /// <summary>
    /// This property relates a cultural property to an information form.
    /// <see href="https://w3id.org/arco/ontology/catalogue/isRelatedToInformationForm"></see></summary>
    let isRelatedToInformationForm = _prefix "isRelatedToInformationForm"
    /// <summary>
    /// This property represents a unique identifier of an entity, within a local inventory.
    /// <see href="https://w3id.org/arco/ontology/catalogue/localIdentifier"></see></summary>
    let localIdentifier = _prefix "localIdentifier"
    /// <summary>
    /// This property represents information extracted from versions of a catalogue record using obsolete standards.
    /// <see href="https://w3id.org/arco/ontology/catalogue/recoveredData"></see></summary>
    let recoveredData = _prefix "recoveredData"
