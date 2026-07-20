namespace http.lod.nl.go.kr.ontology.slash

open DoxAletheia

module nlon =
    let _namespace_name = "http://lod.nl.go.kr/ontology/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/AlternativeMaterial"></see>
    /// </summary>
    let AlternativeMaterial = _prefix "AlternativeMaterial"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/Archives"></see>
    /// </summary>
    let Archives = _prefix "Archives"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/Author"></see>
    /// </summary>
    let Author = _prefix "Author"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/Book"></see>
    /// </summary>
    let Book = _prefix "Book"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/OfflineMaterial"></see>
    /// </summary>
    let OfflineMaterial = _prefix "OfflineMaterial"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/Classification"></see>
    /// </summary>
    let Classification = _prefix "Classification"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/ComplexDocument"></see>
    /// </summary>
    let ComplexDocument = _prefix "ComplexDocument"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/Concept"></see>
    /// </summary>
    let Concept = _prefix "Concept"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/ContinuousDataType"></see>
    /// </summary>
    let ContinuousDataType = _prefix "ContinuousDataType"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/Country"></see>
    /// </summary>
    let Country = _prefix "Country"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/DataType"></see>
    /// </summary>
    let DataType = _prefix "DataType"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/ElectronicDocument"></see>
    /// </summary>
    let ElectronicDocument = _prefix "ElectronicDocument"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/Government"></see>
    /// </summary>
    let Government = _prefix "Government"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/Librarian"></see>
    /// </summary>
    let Librarian = _prefix "Librarian"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/Library"></see>
    /// </summary>
    let Library = _prefix "Library"
    /// <summary>
    /// 지역
    /// <see href="http://lod.nl.go.kr/ontology/Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/NonBook"></see>
    /// </summary>
    let NonBook = _prefix "NonBook"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/OldBook"></see>
    /// </summary>
    let OldBook = _prefix "OldBook"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/OnlineMaterial"></see>
    /// </summary>
    let OnlineMaterial = _prefix "OnlineMaterial"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/OnlineMaterialType"></see>
    /// </summary>
    let OnlineMaterialType = _prefix "OnlineMaterialType"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/PublicationFrequencyType"></see>
    /// </summary>
    let PublicationFrequencyType = _prefix "PublicationFrequencyType"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/PublicationStatusType"></see>
    /// </summary>
    let PublicationStatusType = _prefix "PublicationStatusType"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/Score"></see>
    /// </summary>
    let Score = _prefix "Score"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/University"></see>
    /// </summary>
    let University = _prefix "University"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/abbreviatedTitle"></see>
    /// </summary>
    let abbreviatedTitle = _prefix "abbreviatedTitle"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/antecedentSource"></see>
    /// </summary>
    let antecedentSource = _prefix "antecedentSource"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/audienceNote"></see>
    /// </summary>
    let audienceNote = _prefix "audienceNote"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/authenticationCode"></see>
    /// </summary>
    let authenticationCode = _prefix "authenticationCode"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/awardedFrom"></see>
    /// </summary>
    let awardedFrom = _prefix "awardedFrom"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/awardsNote"></see>
    /// </summary>
    let awardsNote = _prefix "awardsNote"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/bibliography"></see>
    /// </summary>
    let bibliography = _prefix "bibliography"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/biographicalNote"></see>
    /// </summary>
    let biographicalNote = _prefix "biographicalNote"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/birthYear"></see>
    /// </summary>
    let birthYear = _prefix "birthYear"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/cip"></see>
    /// </summary>
    let cip = _prefix "cip"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/citationReferenceNote"></see>
    /// </summary>
    let citationReferenceNote = _prefix "citationReferenceNote"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/classificationNumber"></see>
    /// </summary>
    let classificationNumber = _prefix "classificationNumber"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/classificationNumberOfLC"></see>
    /// </summary>
    let classificationNumberOfLC = _prefix "classificationNumberOfLC"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/classificationNumberOfNLK"></see>
    /// </summary>
    let classificationNumberOfNLK = _prefix "classificationNumberOfNLK"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/confirmDate"></see>
    /// </summary>
    let confirmDate = _prefix "confirmDate"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/confirmedBy"></see>
    /// </summary>
    let confirmedBy = _prefix "confirmedBy"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/managedBy"></see>
    /// </summary>
    let managedBy = _prefix "managedBy"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/create"></see>
    /// </summary>
    let create = _prefix "create"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/currentPublicationFrequency"></see>
    /// </summary>
    let currentPublicationFrequency = _prefix "currentPublicationFrequency"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/dateLinked"></see>
    /// </summary>
    let dateLinked = _prefix "dateLinked"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/dateOfClosed"></see>
    /// </summary>
    let dateOfClosed = _prefix "dateOfClosed"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/dateOfCurrentPublicationFrequency"></see>
    /// </summary>
    let dateOfCurrentPublicationFrequency = _prefix "dateOfCurrentPublicationFrequency"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/dateOfDistribute"></see>
    /// </summary>
    let dateOfDistribute = _prefix "dateOfDistribute"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/dateOfFormerPublicationFrequency"></see>
    /// </summary>
    let dateOfFormerPublicationFrequency = _prefix "dateOfFormerPublicationFrequency"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/dateOfManufacture"></see>
    /// </summary>
    let dateOfManufacture = _prefix "dateOfManufacture"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/dateOfOpening"></see>
    /// </summary>
    let dateOfOpening = _prefix "dateOfOpening"

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/dateOfPublicationSequentialDesignation"></see>
    /// </summary>
    let dateOfPublicationSequentialDesignation =
        _prefix "dateOfPublicationSequentialDesignation"

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/datePublished"></see>
    /// </summary>
    let datePublished = _prefix "datePublished"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/dateSequentialDesignation"></see>
    /// </summary>
    let dateSequentialDesignation = _prefix "dateSequentialDesignation"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/ddc"></see>
    /// </summary>
    let ddc = _prefix "ddc"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/ddcn"></see>
    /// </summary>
    let ddcn = _prefix "ddcn"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/deathYear"></see>
    /// </summary>
    let deathYear = _prefix "deathYear"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/degreeYear"></see>
    /// </summary>
    let degreeYear = _prefix "degreeYear"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/department"></see>
    /// </summary>
    let department = _prefix "department"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/distributionPlace"></see>
    /// </summary>
    let distributionPlace = _prefix "distributionPlace"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/distributor"></see>
    /// </summary>
    let distributor = _prefix "distributor"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/editionOfDDC"></see>
    /// </summary>
    let editionOfDDC = _prefix "editionOfDDC"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/editionOfKDC"></see>
    /// </summary>
    let editionOfKDC = _prefix "editionOfKDC"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/exhibition"></see>
    /// </summary>
    let exhibition = _prefix "exhibition"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/fax"></see>
    /// </summary>
    let fax = _prefix "fax"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/formerPublicationFrequency"></see>
    /// </summary>
    let formerPublicationFrequency = _prefix "formerPublicationFrequency"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/formerTitle"></see>
    /// </summary>
    let formerTitle = _prefix "formerTitle"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/formerTitleComplexityNote"></see>
    /// </summary>
    let formerTitleComplexityNote = _prefix "formerTitleComplexityNote"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/genre"></see>
    /// </summary>
    let genre = _prefix "genre"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/gpo"></see>
    /// </summary>
    let gpo = _prefix "gpo"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/gprn"></see>
    /// </summary>
    let gprn = _prefix "gprn"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/headingOfOriginalLanguage"></see>
    /// </summary>
    let headingOfOriginalLanguage = _prefix "headingOfOriginalLanguage"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/headingOfTranslation"></see>
    /// </summary>
    let headingOfTranslation = _prefix "headingOfTranslation"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/holdingInstitution"></see>
    /// </summary>
    let holdingInstitution = _prefix "holdingInstitution"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/holdingItemNote"></see>
    /// </summary>
    let holdingItemNote = _prefix "holdingItemNote"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/inputDate"></see>
    /// </summary>
    let inputDate = _prefix "inputDate"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/inputedBy"></see>
    /// </summary>
    let inputedBy = _prefix "inputedBy"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/isClosed"></see>
    /// </summary>
    let isClosed = _prefix "isClosed"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/isGeographicAreaOf"></see>
    /// </summary>
    let isGeographicAreaOf = _prefix "isGeographicAreaOf"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/isSubjectOf"></see>
    /// </summary>
    let isSubjectOf = _prefix "isSubjectOf"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/issuingBodyNote"></see>
    /// </summary>
    let issuingBodyNote = _prefix "issuingBodyNote"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/itemNumber"></see>
    /// </summary>
    let itemNumber = _prefix "itemNumber"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/itemNumberOfDDC"></see>
    /// </summary>
    let itemNumberOfDDC = _prefix "itemNumberOfDDC"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/itemNumberOfLC"></see>
    /// </summary>
    let itemNumberOfLC = _prefix "itemNumberOfLC"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/itemNumberOfNLK"></see>
    /// </summary>
    let itemNumberOfNLK = _prefix "itemNumberOfNLK"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/itemNumberOfOtherNumber"></see>
    /// </summary>
    let itemNumberOfOtherNumber = _prefix "itemNumberOfOtherNumber"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/itermNumberOfKDC"></see>
    /// </summary>
    let itermNumberOfKDC = _prefix "itermNumberOfKDC"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/kdc"></see>
    /// </summary>
    let kdc = _prefix "kdc"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/kdcn"></see>
    /// </summary>
    let kdcn = _prefix "kdcn"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/keyTitle"></see>
    /// </summary>
    let keyTitle = _prefix "keyTitle"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/keyword"></see>
    /// </summary>
    let keyword = _prefix "keyword"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/languageNote"></see>
    /// </summary>
    let languageNote = _prefix "languageNote"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/libraryType"></see>
    /// </summary>
    let libraryType = _prefix "libraryType"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/linkingEntryComplexityNote"></see>
    /// </summary>
    let linkingEntryComplexityNote = _prefix "linkingEntryComplexityNote"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/localHolding"></see>
    /// </summary>
    let localHolding = _prefix "localHolding"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/locationNote"></see>
    /// </summary>
    let locationNote = _prefix "locationNote"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/mainEntryHeading"></see>
    /// </summary>
    let mainEntryHeading = _prefix "mainEntryHeading"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/manufacturer"></see>
    /// </summary>
    let manufacturer = _prefix "manufacturer"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/manufacturingPlace"></see>
    /// </summary>
    let manufacturingPlace = _prefix "manufacturingPlace"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/medium"></see>
    /// </summary>
    let medium = _prefix "medium"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/meetingInformation"></see>
    /// </summary>
    let meetingInformation = _prefix "meetingInformation"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/modificationDate"></see>
    /// </summary>
    let modificationDate = _prefix "modificationDate"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/modifiedBy"></see>
    /// </summary>
    let modifiedBy = _prefix "modifiedBy"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/municipalLevel"></see>
    /// </summary>
    let municipalLevel = _prefix "municipalLevel"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/numberMark"></see>
    /// </summary>
    let numberMark = _prefix "numberMark"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/numberingPeculiaritiesNote"></see>
    /// </summary>
    let numberingPeculiaritiesNote = _prefix "numberingPeculiaritiesNote"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/openingYear"></see>
    /// </summary>
    let openingYear = _prefix "openingYear"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/originalVersionNote"></see>
    /// </summary>
    let originalVersionNote = _prefix "originalVersionNote"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/otherNumber"></see>
    /// </summary>
    let otherNumber = _prefix "otherNumber"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/physicalFormAvailableNote"></see>
    /// </summary>
    let physicalFormAvailableNote = _prefix "physicalFormAvailableNote"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/producer"></see>
    /// </summary>
    let producer = _prefix "producer"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/productionPlace"></see>
    /// </summary>
    let productionPlace = _prefix "productionPlace"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/projection"></see>
    /// </summary>
    let projection = _prefix "projection"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/provincialLevel"></see>
    /// </summary>
    let provincialLevel = _prefix "provincialLevel"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/publicationPlace"></see>
    /// </summary>
    let publicationPlace = _prefix "publicationPlace"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/publish"></see>
    /// </summary>
    let publish = _prefix "publish"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/publishedIn"></see>
    /// </summary>
    let publishedIn = _prefix "publishedIn"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/rank"></see>
    /// </summary>
    let rank = _prefix "rank"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/relatedParts"></see>
    /// </summary>
    let relatedParts = _prefix "relatedParts"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/relationshipInformation"></see>
    /// </summary>
    let relationshipInformation = _prefix "relationshipInformation"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/remainderOfTitle"></see>
    /// </summary>
    let remainderOfTitle = _prefix "remainderOfTitle"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/reproductionDate"></see>
    /// </summary>
    let reproductionDate = _prefix "reproductionDate"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/reproductionNote"></see>
    /// </summary>
    let reproductionNote = _prefix "reproductionNote"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/reproductionInstitution"></see>
    /// </summary>
    let reproductionInstitution = _prefix "reproductionInstitution"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/reproductionPlace"></see>
    /// </summary>
    let reproductionPlace = _prefix "reproductionPlace"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/restriction"></see>
    /// </summary>
    let restriction = _prefix "restriction"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/scale"></see>
    /// </summary>
    let scale = _prefix "scale"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/sourceOfInformation"></see>
    /// </summary>
    let sourceOfInformation = _prefix "sourceOfInformation"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/sourceOfOtherNumber"></see>
    /// </summary>
    let sourceOfOtherNumber = _prefix "sourceOfOtherNumber"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/strn"></see>
    /// </summary>
    let strn = _prefix "strn"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/subseriesEntryHeading"></see>
    /// </summary>
    let subseriesEntryHeading = _prefix "subseriesEntryHeading"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/subtitle"></see>
    /// </summary>
    let subtitle = _prefix "subtitle"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/summerOpenTime"></see>
    /// </summary>
    let summerOpenTime = _prefix "summerOpenTime"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/supplementNote"></see>
    /// </summary>
    let supplementNote = _prefix "supplementNote"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfAdditionalPhysicalForm"></see>
    /// </summary>
    let titleOfAdditionalPhysicalForm = _prefix "titleOfAdditionalPhysicalForm"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfConstituentUnit"></see>
    /// </summary>
    let titleOfConstituentUnit = _prefix "titleOfConstituentUnit"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfHostItem"></see>
    /// </summary>
    let titleOfHostItem = _prefix "titleOfHostItem"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfMainSeries"></see>
    /// </summary>
    let titleOfMainSeries = _prefix "titleOfMainSeries"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfOriginalLanguage"></see>
    /// </summary>
    let titleOfOriginalLanguage = _prefix "titleOfOriginalLanguage"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfOtherEdition"></see>
    /// </summary>
    let titleOfOtherEdition = _prefix "titleOfOtherEdition"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfPreceding"></see>
    /// </summary>
    let titleOfPreceding = _prefix "titleOfPreceding"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfSeries"></see>
    /// </summary>
    let titleOfSeries = _prefix "titleOfSeries"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfSubSeries"></see>
    /// </summary>
    let titleOfSubSeries = _prefix "titleOfSubSeries"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfSucceeding"></see>
    /// </summary>
    let titleOfSucceeding = _prefix "titleOfSucceeding"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfSupplement"></see>
    /// </summary>
    let titleOfSupplement = _prefix "titleOfSupplement"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfSupplementParent"></see>
    /// </summary>
    let titleOfSupplementParent = _prefix "titleOfSupplementParent"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfTranslation"></see>
    /// </summary>
    let titleOfTranslation = _prefix "titleOfTranslation"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/typeOfContinuousData"></see>
    /// </summary>
    let typeOfContinuousData = _prefix "typeOfContinuousData"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/typeOfData"></see>
    /// </summary>
    let typeOfData = _prefix "typeOfData"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/typeOfPublicationFrequency"></see>
    /// </summary>
    let typeOfPublicationFrequency = _prefix "typeOfPublicationFrequency"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/typeOfPublicationStatus"></see>
    /// </summary>
    let typeOfPublicationStatus = _prefix "typeOfPublicationStatus"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/typeOfResource"></see>
    /// </summary>
    let typeOfResource = _prefix "typeOfResource"
    /// <summary>
    /// 한국형 URN 식별 체계
    /// <see href="http://lod.nl.go.kr/ontology/uci"></see></summary>
    let uci = _prefix "uci"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/uniformTitleOfSeries"></see>
    /// </summary>
    let uniformTitleOfSeries = _prefix "uniformTitleOfSeries"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/useAndReproductionNote"></see>
    /// </summary>
    let useAndReproductionNote = _prefix "useAndReproductionNote"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/volumeOfNLK"></see>
    /// </summary>
    let volumeOfNLK = _prefix "volumeOfNLK"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/volumeOfSeries"></see>
    /// </summary>
    let volumeOfSeries = _prefix "volumeOfSeries"
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/winterOpenTime"></see>
    /// </summary>
    let winterOpenTime = _prefix "winterOpenTime"
