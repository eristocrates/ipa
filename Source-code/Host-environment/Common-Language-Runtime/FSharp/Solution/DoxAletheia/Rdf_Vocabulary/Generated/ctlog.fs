namespace https.w3id.org.arco.ontology.catalogue.slash

open DoxAletheia.Rdf_Vocabulary

module ctlog =
    let _namespace_name = "https://w3id.org/arco/ontology/catalogue/"

    /// <summary>
    /// This class represents an identifier of a catalogue record in information systems other than ICCD.
    /// <see href="https://w3id.org/arco/ontology/catalogue/AlternativeIdentifier"></see></summary>
    let AlternativeIdentifier =
        Namespaced_IRI.parse _namespace_name "AlternativeIdentifier" |> NamespacedName

    /// <summary>
    /// This class represents a catalogue record, that is a descriptive model collecting and organising information on a cultural property, and which can have more than one version (after editing and updating).
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecord"></see></summary>
    let CatalogueRecord =
        Namespaced_IRI.parse _namespace_name "CatalogueRecord" |> NamespacedName

    /// <summary>
    /// This class represents a version (after creation, editing, updating) of a catalogue record on a cultural property.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordVersion"></see></summary>
    let CatalogueRecordVersion =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordVersion" |> NamespacedName

    /// <summary>
    /// This class represents a record describing a cultural property for purposes other than cataloguing cultural heritage.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CulturalPropertyRecord"></see></summary>
    let CulturalPropertyRecord =
        Namespaced_IRI.parse _namespace_name "CulturalPropertyRecord" |> NamespacedName

    /// <summary>
    /// This class represents an information form, an ICCD standard for cultural heritage census and reporting activities, used to acquire information for any type of entity, with a minimum set of mandatory standardized data.
    /// <see href="https://w3id.org/arco/ontology/catalogue/InformationForm"></see></summary>
    let InformationForm =
        Namespaced_IRI.parse _namespace_name "InformationForm" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Architecture.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordA"></see></summary>
    let CatalogueRecordA =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordA" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Anthropological materials.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordAT"></see></summary>
    let CatalogueRecordAT =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordAT" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Intangible demo-ethno-anthropological heritage.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBDI"></see></summary>
    let CatalogueRecordBDI =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordBDI" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Tangible demo-ethno-anthropological heritage.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBDM"></see></summary>
    let CatalogueRecordBDM =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordBDM" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Natural heritage - botany.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNB"></see></summary>
    let CatalogueRecordBNB =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordBNB" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Natural heritage - mineralogy.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNM"></see></summary>
    let CatalogueRecordBNM =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordBNM" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Natural heritage - paleontology.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNP"></see></summary>
    let CatalogueRecordBNP =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordBNP" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Natural heritage - petrology.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNPE"></see></summary>
    let CatalogueRecordBNPE =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordBNPE" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Natural heritage - planetary science.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNPL"></see></summary>
    let CatalogueRecordBNPL =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordBNPL" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Natural heritage - zoology.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordBNZ"></see></summary>
    let CatalogueRecordBNZ =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordBNZ" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Natural heritage - archaeological complexes.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordCA"></see></summary>
    let CatalogueRecordCA =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordCA" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Natural heritage - historic cities / town centres.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordCNS"></see></summary>
    let CatalogueRecordCNS =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordCNS" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Natural heritage - drawings.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordD"></see></summary>
    let CatalogueRecordD =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordD" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Photography.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordF"></see></summary>
    let CatalogueRecordF =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordF" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Photographic Fonds.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordFF"></see></summary>
    let CatalogueRecordFF =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordFF" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Archaeological monuments.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordMA"></see></summary>
    let CatalogueRecordMA =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordMA" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Printing plates.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordMI"></see></summary>
    let CatalogueRecordMI =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordMI" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Numismatic properties.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordNU"></see></summary>
    let CatalogueRecordNU =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordNU" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Artworks.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordOA"></see></summary>
    let CatalogueRecordOA =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordOA" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Contemporary artworks.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordOAC"></see></summary>
    let CatalogueRecordOAC =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordOAC" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Parks / Gardens.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordPG"></see></summary>
    let CatalogueRecordPG =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordPG" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Scientific and technological heritage.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordPST"></see></summary>
    let CatalogueRecordPST =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordPST" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Archaeological objects.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordRA"></see></summary>
    let CatalogueRecordRA =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordRA" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Prints.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordS"></see></summary>
    let CatalogueRecordS =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordS" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Stratigraphic records.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordSAS"></see></summary>
    let CatalogueRecordSAS =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordSAS" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Archaeological sites.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordSI"></see></summary>
    let CatalogueRecordSI =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordSI" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Musical instruments.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordSM"></see></summary>
    let CatalogueRecordSM =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordSM" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Organs.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordSMO"></see></summary>
    let CatalogueRecordSMO =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordSMO" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Archaeological materials tables.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordTMA"></see></summary>
    let CatalogueRecordTMA =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordTMA" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Historic and contemporary garments.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordVeAC"></see></summary>
    let CatalogueRecordVeAC =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordVeAC" |> NamespacedName

    /// <summary>
    /// This class represents the access profile to the data recorded in a catalogue record, giving instructions for public dissemination of data on the web.
    /// <see href="https://w3id.org/arco/ontology/catalogue/AccessProfile"></see></summary>
    let AccessProfile =
        Namespaced_IRI.parse _namespace_name "AccessProfile" |> NamespacedName

    /// <summary>
    /// This class represents the cataloguing level, defining the level of detail of the survey carried out on the cultural property (Minimum, Medium, Detailed)
    /// <see href="https://w3id.org/arco/ontology/catalogue/CataloguingLevel"></see></summary>
    let CataloguingLevel =
        Namespaced_IRI.parse _namespace_name "CataloguingLevel" |> NamespacedName

    /// <summary>
    /// This class represents the privacy level of the data recorded in a catalogue record (Minimum, Medium, Maximum).
    /// <see href="https://w3id.org/arco/ontology/catalogue/PrivacyLevel"></see></summary>
    let PrivacyLevel =
        Namespaced_IRI.parse _namespace_name "PrivacyLevel" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has access profile".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isAccessProfileOf"></see></summary>
    let isAccessProfileOf =
        Namespaced_IRI.parse _namespace_name "isAccessProfileOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasPrivacyLevel"></see>
    /// </summary>
    let hasPrivacyLevel =
        Namespaced_IRI.parse _namespace_name "hasPrivacyLevel" |> NamespacedName

    /// <summary>
    /// This class represents the reason for the adoption of a specific access profile for a catalogue record.
    /// <see href="https://w3id.org/arco/ontology/catalogue/PrivacyReason"></see></summary>
    let PrivacyReason =
        Namespaced_IRI.parse _namespace_name "PrivacyReason" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasPrivacyReason"></see>
    /// </summary>
    let hasPrivacyReason =
        Namespaced_IRI.parse _namespace_name "hasPrivacyReason" |> NamespacedName

    /// <summary>
    /// This property annotates the field or the fields of the ICCD regulation to which a specific class or property refers.
    /// <see href="https://w3id.org/arco/ontology/catalogue/iccdNormTag"></see></summary>
    let iccdNormTag =
        Namespaced_IRI.parse _namespace_name "iccdNormTag" |> NamespacedName

    /// <summary>
    /// This class represents an additional form, that describes specific information about a cultural property (epigraphic documents, stratigraphy, unit, wall typology)
    /// <see href="https://w3id.org/arco/ontology/catalogue/AdditionalForm"></see></summary>
    let AdditionalForm =
        Namespaced_IRI.parse _namespace_name "AdditionalForm" |> NamespacedName

    /// <summary>
    /// This property represents the additional form identifier.
    /// <see href="https://w3id.org/arco/ontology/catalogue/additionalFormIdentifier"></see></summary>
    let additionalFormIdentifier =
        Namespaced_IRI.parse _namespace_name "additionalFormIdentifier" |> NamespacedName

    /// <summary>
    /// This property was created as a generic property for specific subproperties, and represents the relationship between an entity that describes another entity.
    /// <see href="https://w3id.org/arco/ontology/catalogue/describes"></see></summary>
    let describes = Namespaced_IRI.parse _namespace_name "describes" |> NamespacedName

    /// <summary>
    /// This class represents the additional form type (Stratigraphic Unit, Wall Typology, Epigraphy)
    /// <see href="https://w3id.org/arco/ontology/catalogue/AdditionalFormType"></see></summary>
    let AdditionalFormType =
        Namespaced_IRI.parse _namespace_name "AdditionalFormType" |> NamespacedName

    /// <summary>
    /// This property relates an additional form to its type (Stratigraphic Unit, Epigraphy, Wall Typology).
    /// <see href="https://w3id.org/arco/ontology/catalogue/hasAdditionalFormType"></see></summary>
    let hasAdditionalFormType =
        Namespaced_IRI.parse _namespace_name "hasAdditionalFormType" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has additional form type".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isAdditionalFormTypeOf"></see></summary>
    let isAdditionalFormTypeOf =
        Namespaced_IRI.parse _namespace_name "isAdditionalFormTypeOf" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has alternative identifier".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isAlternativeIdentifierOf"></see></summary>
    let isAlternativeIdentifierOf =
        Namespaced_IRI.parse _namespace_name "isAlternativeIdentifierOf" |> NamespacedName

    /// <summary>
    /// This property represents the reference project of a record about a cultural property.
    /// <see href="https://w3id.org/arco/ontology/catalogue/referenceProject"></see></summary>
    let referenceProject =
        Namespaced_IRI.parse _namespace_name "referenceProject" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/C"></see>
    /// </summary>
    let C = Namespaced_IRI.parse _namespace_name "C" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasAccessProfile"></see>
    /// </summary>
    let hasAccessProfile =
        Namespaced_IRI.parse _namespace_name "hasAccessProfile" |> NamespacedName

    /// <summary>
    /// Property used to associate a catalogue record to one of its versions (e.g. after update)
    /// <see href="https://w3id.org/arco/ontology/catalogue/hasCatalogueRecordVersion"></see></summary>
    let hasCatalogueRecordVersion =
        Namespaced_IRI.parse _namespace_name "hasCatalogueRecordVersion" |> NamespacedName

    /// <summary>
    /// Property used to associate the catalogue record with the cultural property that the catalogue record describes.
    /// <see href="https://w3id.org/arco/ontology/catalogue/describesCulturalProperty"></see></summary>
    let describesCulturalProperty =
        Namespaced_IRI.parse _namespace_name "describesCulturalProperty" |> NamespacedName

    /// <summary>
    /// This property represents the identifier of a catalogue record describing a cultural property.
    /// <see href="https://w3id.org/arco/ontology/catalogue/catalogueRecordIdentifier"></see></summary>
    let catalogueRecordIdentifier =
        Namespaced_IRI.parse _namespace_name "catalogueRecordIdentifier" |> NamespacedName

    /// <summary>
    /// This property represents the identifier associated in the context of the SIGECweb to the xml file containing a catalogue record.
    /// <see href="https://w3id.org/arco/ontology/catalogue/systemRecordCode"></see></summary>
    let systemRecordCode =
        Namespaced_IRI.parse _namespace_name "systemRecordCode" |> NamespacedName

    /// <summary>
    /// This class represents the catalogue record describing Ethnology.
    /// <see href="https://w3id.org/arco/ontology/catalogue/CatalogueRecordE"></see></summary>
    let CatalogueRecordE =
        Namespaced_IRI.parse _namespace_name "CatalogueRecordE" |> NamespacedName

    /// <summary>
    /// Property used to associate a catalogue record version with the time interval in which it was edited.
    /// <see href="https://w3id.org/arco/ontology/catalogue/editedAtTime"></see></summary>
    let editedAtTime =
        Namespaced_IRI.parse _namespace_name "editedAtTime" |> NamespacedName

    /// <summary>
    /// Property used to associate a catalogue record version one of its next version.
    /// <see href="https://w3id.org/arco/ontology/catalogue/isPreviousVersionOf"></see></summary>
    let isPreviousVersionOf =
        Namespaced_IRI.parse _namespace_name "isPreviousVersionOf" |> NamespacedName

    /// <summary>
    /// This property is used to associate a particular version of a catalogue record to the role in time of an agent that plays a role in updating the catalogue record.
    /// <see href="https://w3id.org/arco/ontology/catalogue/hasCatalogueRecordVersionRiT"></see></summary>
    let hasCatalogueRecordVersionRiT =
        Namespaced_IRI.parse _namespace_name "hasCatalogueRecordVersionRiT" |> NamespacedName

    /// <summary>
    /// Property used to associate a catalogue record version to its immediate next version.
    /// <see href="https://w3id.org/arco/ontology/catalogue/isImmediatePreviousVersionOf"></see></summary>
    let isImmediatePreviousVersionOf =
        Namespaced_IRI.parse _namespace_name "isImmediatePreviousVersionOf" |> NamespacedName

    /// <summary>
    /// Property used to associate a catalogue record version to its immediate previous version.
    /// <see href="https://w3id.org/arco/ontology/catalogue/hasImmediatePreviousVersion"></see></summary>
    let hasImmediatePreviousVersion =
        Namespaced_IRI.parse _namespace_name "hasImmediatePreviousVersion" |> NamespacedName

    /// <summary>
    /// Property used to associate a catalogue record version to its previous version.
    /// <see href="https://w3id.org/arco/ontology/catalogue/hasPreviousVersion"></see></summary>
    let hasPreviousVersion =
        Namespaced_IRI.parse _namespace_name "hasPreviousVersion" |> NamespacedName

    /// <summary>
    /// Property, inverse of "has catalogue record version", used to associate a catalogue record version (e.g. after update) to the catalogue record.
    /// <see href="https://w3id.org/arco/ontology/catalogue/isCatalogueRecordVersionOf"></see></summary>
    let isCatalogueRecordVersionOf =
        Namespaced_IRI.parse _namespace_name "isCatalogueRecordVersionOf" |> NamespacedName

    /// <summary>
    /// This property is used to associate a catalogue record to an agent playing a role in cataloguing activities.
    /// <see href="https://w3id.org/arco/ontology/catalogue/hasCataloguingAgent"></see></summary>
    let hasCataloguingAgent =
        Namespaced_IRI.parse _namespace_name "hasCataloguingAgent" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has cataloguing level".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isCataloguingLevelOf"></see></summary>
    let isCataloguingLevelOf =
        Namespaced_IRI.parse _namespace_name "isCataloguingLevelOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/I"></see>
    /// </summary>
    let I = Namespaced_IRI.parse _namespace_name "I" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/P"></see>
    /// </summary>
    let P = Namespaced_IRI.parse _namespace_name "P" |> NamespacedName

    /// <summary>
    /// This class represents a catalogue record describing a complex cultural property.
    /// <see href="https://w3id.org/arco/ontology/catalogue/ComplexCPCatalogueRecord"></see></summary>
    let ComplexCPCatalogueRecord =
        Namespaced_IRI.parse _namespace_name "ComplexCPCatalogueRecord" |> NamespacedName

    /// <summary>
    /// This property is used to associate the identifier to a catalogue record that analyze the cultural property for reasons other than cataloguing the cultural heritage.
    /// <see href="https://w3id.org/arco/ontology/catalogue/culturalPropertyRecordIdentifier"></see></summary>
    let culturalPropertyRecordIdentifier =
        Namespaced_IRI.parse _namespace_name "culturalPropertyRecordIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/EpigraphyForm"></see>
    /// </summary>
    let EpigraphyForm =
        Namespaced_IRI.parse _namespace_name "EpigraphyForm" |> NamespacedName

    /// <summary>
    /// This property represents the identifier assigned to a cultural property by ICCD.
    /// <see href="https://w3id.org/arco/ontology/catalogue/ICCDIdentifier"></see></summary>
    let ICCDIdentifier =
        Namespaced_IRI.parse _namespace_name "ICCDIdentifier" |> NamespacedName

    /// <summary>
    /// This property links an identifier to an information form related to a cultural property.
    /// <see href="https://w3id.org/arco/ontology/catalogue/informationFormIdentifier"></see></summary>
    let informationFormIdentifier =
        Namespaced_IRI.parse _namespace_name "informationFormIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/MaximumPrivacy"></see>
    /// </summary>
    let MaximumPrivacy =
        Namespaced_IRI.parse _namespace_name "MaximumPrivacy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/MediumPrivacy"></see>
    /// </summary>
    let MediumPrivacy =
        Namespaced_IRI.parse _namespace_name "MediumPrivacy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/MinimumPrivacy"></see>
    /// </summary>
    let MinimumPrivacy =
        Namespaced_IRI.parse _namespace_name "MinimumPrivacy" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has privacy level".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isPrivacyLevelOf"></see></summary>
    let isPrivacyLevelOf =
        Namespaced_IRI.parse _namespace_name "isPrivacyLevelOf" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has privacy reason".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isPrivacyReasonOf"></see></summary>
    let isPrivacyReasonOf =
        Namespaced_IRI.parse _namespace_name "isPrivacyReasonOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/StratigraphicUnitForm"></see>
    /// </summary>
    let StratigraphicUnitForm =
        Namespaced_IRI.parse _namespace_name "StratigraphicUnitForm" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/WallTypologyForm"></see>
    /// </summary>
    let WallTypologyForm =
        Namespaced_IRI.parse _namespace_name "WallTypologyForm" |> NamespacedName

    /// <summary>
    /// This property represents the ICCD's identifier deleted for many reasons, used to search for obsolete catalogue records.
    /// <see href="https://w3id.org/arco/ontology/catalogue/deletedICCDIdentifier"></see></summary>
    let deletedICCDIdentifier =
        Namespaced_IRI.parse _namespace_name "deletedICCDIdentifier" |> NamespacedName

    /// <summary>
    /// This property, inverse property of "describes", was created as a generic property for specific subproperties, and represents the relationship between an entity described by another entity.
    /// <see href="https://w3id.org/arco/ontology/catalogue/isDescribedBy"></see></summary>
    let isDescribedBy =
        Namespaced_IRI.parse _namespace_name "isDescribedBy" |> NamespacedName

    /// <summary>
    /// This property, inverse of "describes", is used to associate a cultural property with the catalogue record that describes it.
    /// <see href="https://w3id.org/arco/ontology/catalogue/isDescribedByCatalogueRecord"></see></summary>
    let isDescribedByCatalogueRecord =
        Namespaced_IRI.parse _namespace_name "isDescribedByCatalogueRecord" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "edited at time".
    /// <see href="https://w3id.org/arco/ontology/catalogue/editingTimeOf"></see></summary>
    let editingTimeOf =
        Namespaced_IRI.parse _namespace_name "editingTimeOf" |> NamespacedName

    /// <summary>
    /// This property relates an additional form to the responsible agent of that form in the SIGECweb.
    /// <see href="https://w3id.org/arco/ontology/catalogue/hasAdditionalFormResponsibleAgent"></see></summary>
    let hasAdditionalFormResponsibleAgent =
        Namespaced_IRI.parse _namespace_name "hasAdditionalFormResponsibleAgent" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has additional form responsible agent"
    /// <see href="https://w3id.org/arco/ontology/catalogue/isAdditionalFormResponsibleAgentOf"></see></summary>
    let isAdditionalFormResponsibleAgentOf =
        Namespaced_IRI.parse _namespace_name "isAdditionalFormResponsibleAgentOf" |> NamespacedName

    /// <summary>
    /// Property used to associate a catalogue record with an identifier created in the context of information systems other than ICCD's SIGECweb.
    /// <see href="https://w3id.org/arco/ontology/catalogue/hasAlternativeIdentifier"></see></summary>
    let hasAlternativeIdentifier =
        Namespaced_IRI.parse _namespace_name "hasAlternativeIdentifier" |> NamespacedName

    /// <summary>
    /// Property, inverse of "has catalogue record version role in time", used to associate a role in time to the agent playing that role, in the updating of a particular version of a catalogue record.
    /// <see href="https://w3id.org/arco/ontology/catalogue/isCatalogueRecordVersionRiTOf"></see></summary>
    let isCatalogueRecordVersionRiTOf =
        Namespaced_IRI.parse _namespace_name "isCatalogueRecordVersionRiTOf" |> NamespacedName

    /// <summary>
    /// This property, inverse of "has cataloguin agent", is used to associate an agent playing a role in cataloguing activities to the catalogue record.
    /// <see href="https://w3id.org/arco/ontology/catalogue/isCataloguingAgentOf"></see></summary>
    let isCataloguingAgentOf =
        Namespaced_IRI.parse _namespace_name "isCataloguingAgentOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasCataloguingLevel"></see>
    /// </summary>
    let hasCataloguingLevel =
        Namespaced_IRI.parse _namespace_name "hasCataloguingLevel" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property record to the agency or the person that created that record or manages the database where the record is.
    /// <see href="https://w3id.org/arco/ontology/catalogue/hasCulturalPropertyRecordResponsibleAgent"></see></summary>
    let hasCulturalPropertyRecordResponsibleAgent =
        Namespaced_IRI.parse _namespace_name "hasCulturalPropertyRecordResponsibleAgent" |> NamespacedName

    /// <summary>
    /// This property, inverse of "has cultural property record responsible agent", relates the agency or the person that created the record or manages the database where the record is to the record itself.
    /// <see href="https://w3id.org/arco/ontology/catalogue/isResponsibleAgentOfCulturalPropertyRecord"></see></summary>
    let isResponsibleAgentOfCulturalPropertyRecord =
        Namespaced_IRI.parse _namespace_name "isResponsibleAgentOfCulturalPropertyRecord" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasDigitalTranscriptionOperator"></see>
    /// </summary>
    let hasDigitalTranscriptionOperator =
        Namespaced_IRI.parse _namespace_name "hasDigitalTranscriptionOperator" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has digital transcription operator".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isDigitalTranscriptionOperatorOf"></see></summary>
    let isDigitalTranscriptionOperatorOf =
        Namespaced_IRI.parse _namespace_name "isDigitalTranscriptionOperatorOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasDigitalTranscriptionResponsibleAgent"></see>
    /// </summary>
    let hasDigitalTranscriptionResponsibleAgent =
        Namespaced_IRI.parse _namespace_name "hasDigitalTranscriptionResponsibleAgent" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has digital transcription responsible agent".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isDigitalTranscriptionResponsibleAgentOf"></see></summary>
    let isDigitalTranscriptionResponsibleAgentOf =
        Namespaced_IRI.parse _namespace_name "isDigitalTranscriptionResponsibleAgentOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasOfficialInCharge"></see>
    /// </summary>
    let hasOfficialInCharge =
        Namespaced_IRI.parse _namespace_name "hasOfficialInCharge" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has official in charge".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isOfficialInChargeOf"></see></summary>
    let isOfficialInChargeOf =
        Namespaced_IRI.parse _namespace_name "isOfficialInChargeOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasResponsibleResearchAndCompilation"></see>
    /// </summary>
    let hasResponsibleResearchAndCompilation =
        Namespaced_IRI.parse _namespace_name "hasResponsibleResearchAndCompilation" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has responsible research and compilation".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isResponsibleResearchAndCompilationOf"></see></summary>
    let isResponsibleResearchAndCompilationOf =
        Namespaced_IRI.parse _namespace_name "isResponsibleResearchAndCompilationOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasScientificDirector"></see>
    /// </summary>
    let hasScientificDirector =
        Namespaced_IRI.parse _namespace_name "hasScientificDirector" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has scientific director".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isScientificDirectorOf"></see></summary>
    let isScientificDirectorOf =
        Namespaced_IRI.parse _namespace_name "isScientificDirectorOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasUpdateOfficialInCharge"></see>
    /// </summary>
    let hasUpdateOfficialInCharge =
        Namespaced_IRI.parse _namespace_name "hasUpdateOfficialInCharge" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has update official in charge".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isUpdateOfficialInChargeOf"></see></summary>
    let isUpdateOfficialInChargeOf =
        Namespaced_IRI.parse _namespace_name "isUpdateOfficialInChargeOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasUpdateResponsibleAgent"></see>
    /// </summary>
    let hasUpdateResponsibleAgent =
        Namespaced_IRI.parse _namespace_name "hasUpdateResponsibleAgent" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has update responsible agent",
    /// <see href="https://w3id.org/arco/ontology/catalogue/isUpdateResponsibleAgentOf"></see></summary>
    let isUpdateResponsibleAgentOf =
        Namespaced_IRI.parse _namespace_name "isUpdateResponsibleAgentOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasUpdateResponsibleResearchAndCompilation"></see>
    /// </summary>
    let hasUpdateResponsibleResearchAndCompilation =
        Namespaced_IRI.parse _namespace_name "hasUpdateResponsibleResearchAndCompilation" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has update responsible research and compilation".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isUpdateResponsibleResearchAndCompilationOf"></see></summary>
    let isUpdateResponsibleResearchAndCompilationOf =
        Namespaced_IRI.parse _namespace_name "isUpdateResponsibleResearchAndCompilationOf" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/arco/ontology/catalogue/hasUpdateScientificRevisor"></see>
    /// </summary>
    let hasUpdateScientificRevisor =
        Namespaced_IRI.parse _namespace_name "hasUpdateScientificRevisor" |> NamespacedName

    /// <summary>
    /// This is the inverse property of "has update scientific revisor".
    /// <see href="https://w3id.org/arco/ontology/catalogue/isUpdateScientificRevisorOf"></see></summary>
    let isUpdateScientificRevisorOf =
        Namespaced_IRI.parse _namespace_name "isUpdateScientificRevisorOf" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property to an additional form.
    /// <see href="https://w3id.org/arco/ontology/catalogue/isRelatedToAdditionalForm"></see></summary>
    let isRelatedToAdditionalForm =
        Namespaced_IRI.parse _namespace_name "isRelatedToAdditionalForm" |> NamespacedName

    /// <summary>
    /// This property relates a cultural property to an information form.
    /// <see href="https://w3id.org/arco/ontology/catalogue/isRelatedToInformationForm"></see></summary>
    let isRelatedToInformationForm =
        Namespaced_IRI.parse _namespace_name "isRelatedToInformationForm" |> NamespacedName

    /// <summary>
    /// This property represents a unique identifier of an entity, within a local inventory.
    /// <see href="https://w3id.org/arco/ontology/catalogue/localIdentifier"></see></summary>
    let localIdentifier =
        Namespaced_IRI.parse _namespace_name "localIdentifier" |> NamespacedName

    /// <summary>
    /// This property represents information extracted from versions of a catalogue record using obsolete standards.
    /// <see href="https://w3id.org/arco/ontology/catalogue/recoveredData"></see></summary>
    let recoveredData =
        Namespaced_IRI.parse _namespace_name "recoveredData" |> NamespacedName
