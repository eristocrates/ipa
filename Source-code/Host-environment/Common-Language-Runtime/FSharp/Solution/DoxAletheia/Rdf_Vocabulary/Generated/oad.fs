namespace http.culturalis.org.oad.hash

open DoxAletheia.Rdf_Vocabulary

module oad =
    let _namespace_name = "http://culturalis.org/oad#"

    /// <summary>
    /// The class represents the administrative and biographical history.
    /// <see href="http://culturalis.org/oad#AdministrativeBiographicalHistory"></see></summary>
    let AdministrativeBiographicalHistory =
        Namespaced_IRI.parse _namespace_name "AdministrativeBiographicalHistory" |> NamespacedName

    /// <summary>
    /// oad:ArchivalResource is the class that represents the object of the description (i.e., a single document or a set of document).
    /// <see href="http://culturalis.org/oad#ArchivalResource"></see></summary>
    let ArchivalResource =
        Namespaced_IRI.parse _namespace_name "ArchivalResource" |> NamespacedName

    /// <summary>
    ///   <see href="http://culturalis.org/oad#Custody"></see>
    /// </summary>
    let Custody = Namespaced_IRI.parse _namespace_name "Custody" |> NamespacedName
    /// <summary>
    ///   <see href="http://culturalis.org/oad#EadElement"></see>
    /// </summary>
    let EadElement = Namespaced_IRI.parse _namespace_name "EadElement" |> NamespacedName

    /// <summary>
    /// The class represents the description about extent and medium.
    /// <see href="http://culturalis.org/oad#ExtentAndMedium"></see></summary>
    let ExtentAndMedium =
        Namespaced_IRI.parse _namespace_name "ExtentAndMedium" |> NamespacedName

    /// <summary>
    /// The class represents a finding aid.
    /// <see href="http://culturalis.org/oad#FindingAid"></see></summary>
    let FindingAid = Namespaced_IRI.parse _namespace_name "FindingAid" |> NamespacedName
    /// <summary>
    /// The class represents the descriptive entry of an archival resource
    /// <see href="http://culturalis.org/oad#Instance"></see></summary>
    let Instance = Namespaced_IRI.parse _namespace_name "Instance" |> NamespacedName

    /// <summary>
    /// The class represents the archival description level
    /// <see href="http://culturalis.org/oad#LevelOfDescription"></see></summary>
    let LevelOfDescription =
        Namespaced_IRI.parse _namespace_name "LevelOfDescription" |> NamespacedName

    /// <summary>
    /// The class represents a physical place
    /// <see href="http://culturalis.org/oad#Place"></see></summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName
    /// <summary>
    ///   <see href="http://culturalis.org/oad#Production"></see>
    /// </summary>
    let Production = Namespaced_IRI.parse _namespace_name "Production" |> NamespacedName

    /// <summary>
    /// The class represents a bibliography
    /// <see href="http://culturalis.org/oad#PublicationNote"></see></summary>
    let PublicationNote =
        Namespaced_IRI.parse _namespace_name "PublicationNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://culturalis.org/oad#UoD"></see>
    /// </summary>
    let UoD = Namespaced_IRI.parse _namespace_name "UoD" |> NamespacedName
    /// <summary>
    /// The property represents expected increase.
    /// <see href="http://culturalis.org/oad#accruals"></see></summary>
    let accruals = Namespaced_IRI.parse _namespace_name "accruals" |> NamespacedName

    /// <summary>
    /// The property represents appraisal, destruction and scheduling information
    /// <see href="http://culturalis.org/oad#appraisalDestructionAndSchedulingInformation"></see></summary>
    let appraisalDestructionAndSchedulingInformation =
        Namespaced_IRI.parse _namespace_name "appraisalDestructionAndSchedulingInformation" |> NamespacedName

    /// <summary>
    /// The property represents information about the history of the instance
    /// <see href="http://culturalis.org/oad#archivalHistory"></see></summary>
    let archivalHistory =
        Namespaced_IRI.parse _namespace_name "archivalHistory" |> NamespacedName

    /// <summary>
    ///   <see href="http://culturalis.org/oad#archivistsNote"></see>
    /// </summary>
    let archivistsNote =
        Namespaced_IRI.parse _namespace_name "archivistsNote" |> NamespacedName

    /// <summary>
    /// The property represents condition governing access of the instance
    /// <see href="http://culturalis.org/oad#conditionsGoverningAccess"></see></summary>
    let conditionsGoverningAccess =
        Namespaced_IRI.parse _namespace_name "conditionsGoverningAccess" |> NamespacedName

    /// <summary>
    /// The property represents condition governing reproduction of the instance
    /// <see href="http://culturalis.org/oad#conditionsGoverningReproduction"></see></summary>
    let conditionsGoverningReproduction =
        Namespaced_IRI.parse _namespace_name "conditionsGoverningReproduction" |> NamespacedName

    /// <summary>
    /// Inverse property of oad:isContainedIn
    /// <see href="http://culturalis.org/oad#contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName
    /// <summary>
    ///   <see href="http://culturalis.org/oad#custody"></see>
    /// </summary>
    let custody = Namespaced_IRI.parse _namespace_name "custody" |> NamespacedName
    /// <summary>
    /// The property represents a date
    /// <see href="http://culturalis.org/oad#date"></see></summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName
    /// <summary>
    /// This functional property links a finding aid to the archival resource described
    /// <see href="http://culturalis.org/oad#describes"></see></summary>
    let describes = Namespaced_IRI.parse _namespace_name "describes" |> NamespacedName

    /// <summary>
    /// Inverse property of oad:describes
    /// <see href="http://culturalis.org/oad#isDescribedBy"></see></summary>
    let isDescribedBy =
        Namespaced_IRI.parse _namespace_name "isDescribedBy" |> NamespacedName

    /// <summary>
    /// The property represents the existence and location of copies
    /// <see href="http://culturalis.org/oad#existenceAndLocationOfCopies"></see></summary>
    let existenceAndLocationOfCopies =
        Namespaced_IRI.parse _namespace_name "existenceAndLocationOfCopies" |> NamespacedName

    /// <summary>
    /// The property represents the existence and location of originals
    /// <see href="http://culturalis.org/oad#existenceAndLocationOfOriginals"></see></summary>
    let existenceAndLocationOfOriginals =
        Namespaced_IRI.parse _namespace_name "existenceAndLocationOfOriginals" |> NamespacedName

    /// <summary>
    ///   <see href="http://culturalis.org/oad#extentAndMedium"></see>
    /// </summary>
    let extentAndMedium =
        Namespaced_IRI.parse _namespace_name "extentAndMedium" |> NamespacedName

    /// <summary>
    /// The property represents an access point
    /// <see href="http://culturalis.org/oad#hasAccessPoint"></see></summary>
    let hasAccessPoint =
        Namespaced_IRI.parse _namespace_name "hasAccessPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://culturalis.org/oad#hasAccessPointCorporateBody"></see>
    /// </summary>
    let hasAccessPointCorporateBody =
        Namespaced_IRI.parse _namespace_name "hasAccessPointCorporateBody" |> NamespacedName

    /// <summary>
    ///   <see href="http://culturalis.org/oad#hasAccessPointFamily"></see>
    /// </summary>
    let hasAccessPointFamily =
        Namespaced_IRI.parse _namespace_name "hasAccessPointFamily" |> NamespacedName

    /// <summary>
    ///   <see href="http://culturalis.org/oad#hasAccessPointPerson"></see>
    /// </summary>
    let hasAccessPointPerson =
        Namespaced_IRI.parse _namespace_name "hasAccessPointPerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://culturalis.org/oad#hasAccessPointPlace"></see>
    /// </summary>
    let hasAccessPointPlace =
        Namespaced_IRI.parse _namespace_name "hasAccessPointPlace" |> NamespacedName

    /// <summary>
    /// The property links and instace to information about administrative and biographica history.
    /// <see href="http://culturalis.org/oad#hasAdministrativeBiographicalHistory"></see></summary>
    let hasAdministrativeBiographicalHistory =
        Namespaced_IRI.parse _namespace_name "hasAdministrativeBiographicalHistory" |> NamespacedName

    /// <summary>
    ///   <see href="http://culturalis.org/oad#hasCustody"></see>
    /// </summary>
    let hasCustody = Namespaced_IRI.parse _namespace_name "hasCustody" |> NamespacedName
    /// <summary>
    ///   <see href="http://culturalis.org/oad#hasEntity"></see>
    /// </summary>
    let hasEntity = Namespaced_IRI.parse _namespace_name "hasEntity" |> NamespacedName
    /// <summary>
    ///   <see href="http://culturalis.org/oad#hasEntry"></see>
    /// </summary>
    let hasEntry = Namespaced_IRI.parse _namespace_name "hasEntry" |> NamespacedName

    /// <summary>
    /// The property links an instance to information about extent and medium
    /// <see href="http://culturalis.org/oad#hasExtentAndMedium"></see></summary>
    let hasExtentAndMedium =
        Namespaced_IRI.parse _namespace_name "hasExtentAndMedium" |> NamespacedName

    /// <summary>
    /// The property represents an extent type and it is related to a skos vocabulary
    /// <see href="http://culturalis.org/oad#hasExtentType"></see></summary>
    let hasExtentType =
        Namespaced_IRI.parse _namespace_name "hasExtentType" |> NamespacedName

    /// <summary>
    /// The property links an instance to a classification system
    /// <see href="http://culturalis.org/oad#hasFilePlan"></see></summary>
    let hasFilePlan =
        Namespaced_IRI.parse _namespace_name "hasFilePlan" |> NamespacedName

    /// <summary>
    ///   <see href="http://culturalis.org/oad#hasFindingAid"></see>
    /// </summary>
    let hasFindingAid =
        Namespaced_IRI.parse _namespace_name "hasFindingAid" |> NamespacedName

    /// <summary>
    /// The property links an instance to its language information
    /// <see href="http://culturalis.org/oad#hasLanguageScriptsOfMaterial"></see></summary>
    let hasLanguageScriptsOfMaterial =
        Namespaced_IRI.parse _namespace_name "hasLanguageScriptsOfMaterial" |> NamespacedName

    /// <summary>
    /// The property links an archival resource to its level of description
    /// <see href="http://culturalis.org/oad#hasLevel"></see></summary>
    let hasLevel = Namespaced_IRI.parse _namespace_name "hasLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://culturalis.org/oad#hasNameOfCreator"></see>
    /// </summary>
    let hasNameOfCreator =
        Namespaced_IRI.parse _namespace_name "hasNameOfCreator" |> NamespacedName

    /// <summary>
    /// The property links an instance to the following sibling
    /// <see href="http://culturalis.org/oad#hasNextInSequence"></see></summary>
    let hasNextInSequence =
        Namespaced_IRI.parse _namespace_name "hasNextInSequence" |> NamespacedName

    /// <summary>
    ///   <see href="http://culturalis.org/oad#hasProduction"></see>
    /// </summary>
    let hasProduction =
        Namespaced_IRI.parse _namespace_name "hasProduction" |> NamespacedName

    /// <summary>
    /// The property links an instance to its bibliography information
    /// <see href="http://culturalis.org/oad#hasPublicationNote"></see></summary>
    let hasPublicationNote =
        Namespaced_IRI.parse _namespace_name "hasPublicationNote" |> NamespacedName

    /// <summary>
    /// The property links two or more instances related
    /// <see href="http://culturalis.org/oad#hasRelatedInstance"></see></summary>
    let hasRelatedInstance =
        Namespaced_IRI.parse _namespace_name "hasRelatedInstance" |> NamespacedName

    /// <summary>
    ///   <see href="http://culturalis.org/oad#hasRepository"></see>
    /// </summary>
    let hasRepository =
        Namespaced_IRI.parse _namespace_name "hasRepository" |> NamespacedName

    /// <summary>
    /// The property represents an immediate source of acquisition or transfer
    /// <see href="http://culturalis.org/oad#immediateSourceOfAcquisitionOrTransfer"></see></summary>
    let immediateSourceOfAcquisitionOrTransfer =
        Namespaced_IRI.parse _namespace_name "immediateSourceOfAcquisitionOrTransfer" |> NamespacedName

    /// <summary>
    /// The property represents the relationship between an instance and the finding aid in which it is contained
    /// <see href="http://culturalis.org/oad#isContainedIn"></see></summary>
    let isContainedIn =
        Namespaced_IRI.parse _namespace_name "isContainedIn" |> NamespacedName

    /// <summary>
    /// The property links an instance to an archival resource
    /// <see href="http://culturalis.org/oad#isEntryOf"></see></summary>
    let isEntryOf = Namespaced_IRI.parse _namespace_name "isEntryOf" |> NamespacedName

    /// <summary>
    /// The property links the archival resource described to the entity responsible for the production of the resource
    /// <see href="http://culturalis.org/oad#isProducedBy"></see></summary>
    let isProducedBy =
        Namespaced_IRI.parse _namespace_name "isProducedBy" |> NamespacedName

    /// <summary>
    /// The property represents information that cannot be accommodated in any of the other properties.
    /// <see href="http://culturalis.org/oad#note"></see></summary>
    let note = Namespaced_IRI.parse _namespace_name "note" |> NamespacedName
    /// <summary>
    /// The property represents an otherlevel of description
    /// <see href="http://culturalis.org/oad#otherlevel"></see></summary>
    let otherlevel = Namespaced_IRI.parse _namespace_name "otherlevel" |> NamespacedName

    /// <summary>
    /// The property represents physical characteristics and technical requirements
    /// <see href="http://culturalis.org/oad#physicalCharacteristicsAndTechnicalRequirements"></see></summary>
    let physicalCharacteristicsAndTechnicalRequirements =
        Namespaced_IRI.parse _namespace_name "physicalCharacteristicsAndTechnicalRequirements" |> NamespacedName

    /// <summary>
    ///   <see href="http://culturalis.org/oad#production"></see>
    /// </summary>
    let production = Namespaced_IRI.parse _namespace_name "production" |> NamespacedName

    /// <summary>
    /// The property represents an identification code of the described resource
    /// <see href="http://culturalis.org/oad#referenceCode"></see></summary>
    let referenceCode =
        Namespaced_IRI.parse _namespace_name "referenceCode" |> NamespacedName

    /// <summary>
    /// The property represents the scope and the content of the described resource
    /// <see href="http://culturalis.org/oad#scopeAndContent"></see></summary>
    let scopeAndContent =
        Namespaced_IRI.parse _namespace_name "scopeAndContent" |> NamespacedName

    /// <summary>
    /// The property represents the internal structure, the order and/or the system of classification of the described resource
    /// <see href="http://culturalis.org/oad#systemOfArrangement"></see></summary>
    let systemOfArrangement =
        Namespaced_IRI.parse _namespace_name "systemOfArrangement" |> NamespacedName

    /// <summary>
    /// The property represents the name shown in a description
    /// <see href="http://culturalis.org/oad#title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName

    /// <summary>
    ///   <see href="http://culturalis.org/oad#useEadElement"></see>
    /// </summary>
    let useEadElement =
        Namespaced_IRI.parse _namespace_name "useEadElement" |> NamespacedName
