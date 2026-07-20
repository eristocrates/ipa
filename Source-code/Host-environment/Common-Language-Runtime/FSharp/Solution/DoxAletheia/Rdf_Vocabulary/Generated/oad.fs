namespace http.culturalis.org.oad.hash

open DoxAletheia

module oad =
    let _namespace_name = "http://culturalis.org/oad#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The class represents the administrative and biographical history.
    /// <see href="http://culturalis.org/oad#AdministrativeBiographicalHistory"></see></summary>
    let AdministrativeBiographicalHistory = _prefix "AdministrativeBiographicalHistory"
    /// <summary>
    /// oad:ArchivalResource is the class that represents the object of the description (i.e., a single document or a set of document).
    /// <see href="http://culturalis.org/oad#ArchivalResource"></see></summary>
    let ArchivalResource = _prefix "ArchivalResource"
    /// <summary>
    ///   <see href="http://culturalis.org/oad#Custody"></see>
    /// </summary>
    let Custody = _prefix "Custody"
    /// <summary>
    ///   <see href="http://culturalis.org/oad#EadElement"></see>
    /// </summary>
    let EadElement = _prefix "EadElement"
    /// <summary>
    /// The class represents the description about extent and medium.
    /// <see href="http://culturalis.org/oad#ExtentAndMedium"></see></summary>
    let ExtentAndMedium = _prefix "ExtentAndMedium"
    /// <summary>
    /// The class represents a finding aid.
    /// <see href="http://culturalis.org/oad#FindingAid"></see></summary>
    let FindingAid = _prefix "FindingAid"
    /// <summary>
    /// The class represents the descriptive entry of an archival resource
    /// <see href="http://culturalis.org/oad#Instance"></see></summary>
    let Instance = _prefix "Instance"
    /// <summary>
    /// The class represents the archival description level
    /// <see href="http://culturalis.org/oad#LevelOfDescription"></see></summary>
    let LevelOfDescription = _prefix "LevelOfDescription"
    /// <summary>
    /// The class represents a physical place
    /// <see href="http://culturalis.org/oad#Place"></see></summary>
    let Place = _prefix "Place"
    /// <summary>
    ///   <see href="http://culturalis.org/oad#Production"></see>
    /// </summary>
    let Production = _prefix "Production"
    /// <summary>
    /// The class represents a bibliography
    /// <see href="http://culturalis.org/oad#PublicationNote"></see></summary>
    let PublicationNote = _prefix "PublicationNote"
    /// <summary>
    ///   <see href="http://culturalis.org/oad#UoD"></see>
    /// </summary>
    let UoD = _prefix "UoD"
    /// <summary>
    /// The property represents expected increase.
    /// <see href="http://culturalis.org/oad#accruals"></see></summary>
    let accruals = _prefix "accruals"

    /// <summary>
    /// The property represents appraisal, destruction and scheduling information
    /// <see href="http://culturalis.org/oad#appraisalDestructionAndSchedulingInformation"></see></summary>
    let appraisalDestructionAndSchedulingInformation =
        _prefix "appraisalDestructionAndSchedulingInformation"

    /// <summary>
    /// The property represents information about the history of the instance
    /// <see href="http://culturalis.org/oad#archivalHistory"></see></summary>
    let archivalHistory = _prefix "archivalHistory"
    /// <summary>
    ///   <see href="http://culturalis.org/oad#archivistsNote"></see>
    /// </summary>
    let archivistsNote = _prefix "archivistsNote"
    /// <summary>
    /// The property represents condition governing access of the instance
    /// <see href="http://culturalis.org/oad#conditionsGoverningAccess"></see></summary>
    let conditionsGoverningAccess = _prefix "conditionsGoverningAccess"
    /// <summary>
    /// The property represents condition governing reproduction of the instance
    /// <see href="http://culturalis.org/oad#conditionsGoverningReproduction"></see></summary>
    let conditionsGoverningReproduction = _prefix "conditionsGoverningReproduction"
    /// <summary>
    /// Inverse property of oad:isContainedIn
    /// <see href="http://culturalis.org/oad#contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    ///   <see href="http://culturalis.org/oad#custody"></see>
    /// </summary>
    let custody = _prefix "custody"
    /// <summary>
    /// The property represents a date
    /// <see href="http://culturalis.org/oad#date"></see></summary>
    let date = _prefix "date"
    /// <summary>
    /// This functional property links a finding aid to the archival resource described
    /// <see href="http://culturalis.org/oad#describes"></see></summary>
    let describes = _prefix "describes"
    /// <summary>
    /// Inverse property of oad:describes
    /// <see href="http://culturalis.org/oad#isDescribedBy"></see></summary>
    let isDescribedBy = _prefix "isDescribedBy"
    /// <summary>
    /// The property represents the existence and location of copies
    /// <see href="http://culturalis.org/oad#existenceAndLocationOfCopies"></see></summary>
    let existenceAndLocationOfCopies = _prefix "existenceAndLocationOfCopies"
    /// <summary>
    /// The property represents the existence and location of originals
    /// <see href="http://culturalis.org/oad#existenceAndLocationOfOriginals"></see></summary>
    let existenceAndLocationOfOriginals = _prefix "existenceAndLocationOfOriginals"
    /// <summary>
    ///   <see href="http://culturalis.org/oad#extentAndMedium"></see>
    /// </summary>
    let extentAndMedium = _prefix "extentAndMedium"
    /// <summary>
    /// The property represents an access point
    /// <see href="http://culturalis.org/oad#hasAccessPoint"></see></summary>
    let hasAccessPoint = _prefix "hasAccessPoint"
    /// <summary>
    ///   <see href="http://culturalis.org/oad#hasAccessPointCorporateBody"></see>
    /// </summary>
    let hasAccessPointCorporateBody = _prefix "hasAccessPointCorporateBody"
    /// <summary>
    ///   <see href="http://culturalis.org/oad#hasAccessPointFamily"></see>
    /// </summary>
    let hasAccessPointFamily = _prefix "hasAccessPointFamily"
    /// <summary>
    ///   <see href="http://culturalis.org/oad#hasAccessPointPerson"></see>
    /// </summary>
    let hasAccessPointPerson = _prefix "hasAccessPointPerson"
    /// <summary>
    ///   <see href="http://culturalis.org/oad#hasAccessPointPlace"></see>
    /// </summary>
    let hasAccessPointPlace = _prefix "hasAccessPointPlace"

    /// <summary>
    /// The property links and instace to information about administrative and biographica history.
    /// <see href="http://culturalis.org/oad#hasAdministrativeBiographicalHistory"></see></summary>
    let hasAdministrativeBiographicalHistory =
        _prefix "hasAdministrativeBiographicalHistory"

    /// <summary>
    ///   <see href="http://culturalis.org/oad#hasCustody"></see>
    /// </summary>
    let hasCustody = _prefix "hasCustody"
    /// <summary>
    ///   <see href="http://culturalis.org/oad#hasEntity"></see>
    /// </summary>
    let hasEntity = _prefix "hasEntity"
    /// <summary>
    ///   <see href="http://culturalis.org/oad#hasEntry"></see>
    /// </summary>
    let hasEntry = _prefix "hasEntry"
    /// <summary>
    /// The property links an instance to information about extent and medium
    /// <see href="http://culturalis.org/oad#hasExtentAndMedium"></see></summary>
    let hasExtentAndMedium = _prefix "hasExtentAndMedium"
    /// <summary>
    /// The property represents an extent type and it is related to a skos vocabulary
    /// <see href="http://culturalis.org/oad#hasExtentType"></see></summary>
    let hasExtentType = _prefix "hasExtentType"
    /// <summary>
    /// The property links an instance to a classification system
    /// <see href="http://culturalis.org/oad#hasFilePlan"></see></summary>
    let hasFilePlan = _prefix "hasFilePlan"
    /// <summary>
    ///   <see href="http://culturalis.org/oad#hasFindingAid"></see>
    /// </summary>
    let hasFindingAid = _prefix "hasFindingAid"
    /// <summary>
    /// The property links an instance to its language information
    /// <see href="http://culturalis.org/oad#hasLanguageScriptsOfMaterial"></see></summary>
    let hasLanguageScriptsOfMaterial = _prefix "hasLanguageScriptsOfMaterial"
    /// <summary>
    /// The property links an archival resource to its level of description
    /// <see href="http://culturalis.org/oad#hasLevel"></see></summary>
    let hasLevel = _prefix "hasLevel"
    /// <summary>
    ///   <see href="http://culturalis.org/oad#hasNameOfCreator"></see>
    /// </summary>
    let hasNameOfCreator = _prefix "hasNameOfCreator"
    /// <summary>
    /// The property links an instance to the following sibling
    /// <see href="http://culturalis.org/oad#hasNextInSequence"></see></summary>
    let hasNextInSequence = _prefix "hasNextInSequence"
    /// <summary>
    ///   <see href="http://culturalis.org/oad#hasProduction"></see>
    /// </summary>
    let hasProduction = _prefix "hasProduction"
    /// <summary>
    /// The property links an instance to its bibliography information
    /// <see href="http://culturalis.org/oad#hasPublicationNote"></see></summary>
    let hasPublicationNote = _prefix "hasPublicationNote"
    /// <summary>
    /// The property links two or more instances related
    /// <see href="http://culturalis.org/oad#hasRelatedInstance"></see></summary>
    let hasRelatedInstance = _prefix "hasRelatedInstance"
    /// <summary>
    ///   <see href="http://culturalis.org/oad#hasRepository"></see>
    /// </summary>
    let hasRepository = _prefix "hasRepository"

    /// <summary>
    /// The property represents an immediate source of acquisition or transfer
    /// <see href="http://culturalis.org/oad#immediateSourceOfAcquisitionOrTransfer"></see></summary>
    let immediateSourceOfAcquisitionOrTransfer =
        _prefix "immediateSourceOfAcquisitionOrTransfer"

    /// <summary>
    /// The property represents the relationship between an instance and the finding aid in which it is contained
    /// <see href="http://culturalis.org/oad#isContainedIn"></see></summary>
    let isContainedIn = _prefix "isContainedIn"
    /// <summary>
    /// The property links an instance to an archival resource
    /// <see href="http://culturalis.org/oad#isEntryOf"></see></summary>
    let isEntryOf = _prefix "isEntryOf"
    /// <summary>
    /// The property links the archival resource described to the entity responsible for the production of the resource
    /// <see href="http://culturalis.org/oad#isProducedBy"></see></summary>
    let isProducedBy = _prefix "isProducedBy"
    /// <summary>
    /// The property represents information that cannot be accommodated in any of the other properties.
    /// <see href="http://culturalis.org/oad#note"></see></summary>
    let note = _prefix "note"
    /// <summary>
    /// The property represents an otherlevel of description
    /// <see href="http://culturalis.org/oad#otherlevel"></see></summary>
    let otherlevel = _prefix "otherlevel"

    /// <summary>
    /// The property represents physical characteristics and technical requirements
    /// <see href="http://culturalis.org/oad#physicalCharacteristicsAndTechnicalRequirements"></see></summary>
    let physicalCharacteristicsAndTechnicalRequirements =
        _prefix "physicalCharacteristicsAndTechnicalRequirements"

    /// <summary>
    ///   <see href="http://culturalis.org/oad#production"></see>
    /// </summary>
    let production = _prefix "production"
    /// <summary>
    /// The property represents an identification code of the described resource
    /// <see href="http://culturalis.org/oad#referenceCode"></see></summary>
    let referenceCode = _prefix "referenceCode"
    /// <summary>
    /// The property represents the scope and the content of the described resource
    /// <see href="http://culturalis.org/oad#scopeAndContent"></see></summary>
    let scopeAndContent = _prefix "scopeAndContent"
    /// <summary>
    /// The property represents the internal structure, the order and/or the system of classification of the described resource
    /// <see href="http://culturalis.org/oad#systemOfArrangement"></see></summary>
    let systemOfArrangement = _prefix "systemOfArrangement"
    /// <summary>
    /// The property represents the name shown in a description
    /// <see href="http://culturalis.org/oad#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    ///   <see href="http://culturalis.org/oad#useEadElement"></see>
    /// </summary>
    let useEadElement = _prefix "useEadElement"
