namespace http.lod.nl.go.kr.ontology.slash

open DoxAletheia.Rdf_Vocabulary

module nlon =
    let _namespace_name = "http://lod.nl.go.kr/ontology/"

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/AlternativeMaterial"></see>
    /// </summary>
    let AlternativeMaterial =
        Namespaced_IRI.parse _namespace_name "AlternativeMaterial" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/Archives"></see>
    /// </summary>
    let Archives = Namespaced_IRI.parse _namespace_name "Archives" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/Author"></see>
    /// </summary>
    let Author = Namespaced_IRI.parse _namespace_name "Author" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/Book"></see>
    /// </summary>
    let Book = Namespaced_IRI.parse _namespace_name "Book" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/OfflineMaterial"></see>
    /// </summary>
    let OfflineMaterial =
        Namespaced_IRI.parse _namespace_name "OfflineMaterial" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/Classification"></see>
    /// </summary>
    let Classification =
        Namespaced_IRI.parse _namespace_name "Classification" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/ComplexDocument"></see>
    /// </summary>
    let ComplexDocument =
        Namespaced_IRI.parse _namespace_name "ComplexDocument" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/Concept"></see>
    /// </summary>
    let Concept = Namespaced_IRI.parse _namespace_name "Concept" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/ContinuousDataType"></see>
    /// </summary>
    let ContinuousDataType =
        Namespaced_IRI.parse _namespace_name "ContinuousDataType" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/Country"></see>
    /// </summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/DataType"></see>
    /// </summary>
    let DataType = Namespaced_IRI.parse _namespace_name "DataType" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/ElectronicDocument"></see>
    /// </summary>
    let ElectronicDocument =
        Namespaced_IRI.parse _namespace_name "ElectronicDocument" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/Government"></see>
    /// </summary>
    let Government = Namespaced_IRI.parse _namespace_name "Government" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/Librarian"></see>
    /// </summary>
    let Librarian = Namespaced_IRI.parse _namespace_name "Librarian" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/Library"></see>
    /// </summary>
    let Library = Namespaced_IRI.parse _namespace_name "Library" |> NamespacedName
    /// <summary>
    /// 지역
    /// <see href="http://lod.nl.go.kr/ontology/Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/NonBook"></see>
    /// </summary>
    let NonBook = Namespaced_IRI.parse _namespace_name "NonBook" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/OldBook"></see>
    /// </summary>
    let OldBook = Namespaced_IRI.parse _namespace_name "OldBook" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/OnlineMaterial"></see>
    /// </summary>
    let OnlineMaterial =
        Namespaced_IRI.parse _namespace_name "OnlineMaterial" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/OnlineMaterialType"></see>
    /// </summary>
    let OnlineMaterialType =
        Namespaced_IRI.parse _namespace_name "OnlineMaterialType" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/PublicationFrequencyType"></see>
    /// </summary>
    let PublicationFrequencyType =
        Namespaced_IRI.parse _namespace_name "PublicationFrequencyType" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/PublicationStatusType"></see>
    /// </summary>
    let PublicationStatusType =
        Namespaced_IRI.parse _namespace_name "PublicationStatusType" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/Score"></see>
    /// </summary>
    let Score = Namespaced_IRI.parse _namespace_name "Score" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/University"></see>
    /// </summary>
    let University = Namespaced_IRI.parse _namespace_name "University" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/abbreviatedTitle"></see>
    /// </summary>
    let abbreviatedTitle =
        Namespaced_IRI.parse _namespace_name "abbreviatedTitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/antecedentSource"></see>
    /// </summary>
    let antecedentSource =
        Namespaced_IRI.parse _namespace_name "antecedentSource" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/audienceNote"></see>
    /// </summary>
    let audienceNote =
        Namespaced_IRI.parse _namespace_name "audienceNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/authenticationCode"></see>
    /// </summary>
    let authenticationCode =
        Namespaced_IRI.parse _namespace_name "authenticationCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/awardedFrom"></see>
    /// </summary>
    let awardedFrom =
        Namespaced_IRI.parse _namespace_name "awardedFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/awardsNote"></see>
    /// </summary>
    let awardsNote = Namespaced_IRI.parse _namespace_name "awardsNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/bibliography"></see>
    /// </summary>
    let bibliography =
        Namespaced_IRI.parse _namespace_name "bibliography" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/biographicalNote"></see>
    /// </summary>
    let biographicalNote =
        Namespaced_IRI.parse _namespace_name "biographicalNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/birthYear"></see>
    /// </summary>
    let birthYear = Namespaced_IRI.parse _namespace_name "birthYear" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/cip"></see>
    /// </summary>
    let cip = Namespaced_IRI.parse _namespace_name "cip" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/citationReferenceNote"></see>
    /// </summary>
    let citationReferenceNote =
        Namespaced_IRI.parse _namespace_name "citationReferenceNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/classificationNumber"></see>
    /// </summary>
    let classificationNumber =
        Namespaced_IRI.parse _namespace_name "classificationNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/classificationNumberOfLC"></see>
    /// </summary>
    let classificationNumberOfLC =
        Namespaced_IRI.parse _namespace_name "classificationNumberOfLC" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/classificationNumberOfNLK"></see>
    /// </summary>
    let classificationNumberOfNLK =
        Namespaced_IRI.parse _namespace_name "classificationNumberOfNLK" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/confirmDate"></see>
    /// </summary>
    let confirmDate =
        Namespaced_IRI.parse _namespace_name "confirmDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/confirmedBy"></see>
    /// </summary>
    let confirmedBy =
        Namespaced_IRI.parse _namespace_name "confirmedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/managedBy"></see>
    /// </summary>
    let managedBy = Namespaced_IRI.parse _namespace_name "managedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/create"></see>
    /// </summary>
    let create = Namespaced_IRI.parse _namespace_name "create" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/currentPublicationFrequency"></see>
    /// </summary>
    let currentPublicationFrequency =
        Namespaced_IRI.parse _namespace_name "currentPublicationFrequency" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/dateLinked"></see>
    /// </summary>
    let dateLinked = Namespaced_IRI.parse _namespace_name "dateLinked" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/dateOfClosed"></see>
    /// </summary>
    let dateOfClosed =
        Namespaced_IRI.parse _namespace_name "dateOfClosed" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/dateOfCurrentPublicationFrequency"></see>
    /// </summary>
    let dateOfCurrentPublicationFrequency =
        Namespaced_IRI.parse _namespace_name "dateOfCurrentPublicationFrequency" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/dateOfDistribute"></see>
    /// </summary>
    let dateOfDistribute =
        Namespaced_IRI.parse _namespace_name "dateOfDistribute" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/dateOfFormerPublicationFrequency"></see>
    /// </summary>
    let dateOfFormerPublicationFrequency =
        Namespaced_IRI.parse _namespace_name "dateOfFormerPublicationFrequency" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/dateOfManufacture"></see>
    /// </summary>
    let dateOfManufacture =
        Namespaced_IRI.parse _namespace_name "dateOfManufacture" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/dateOfOpening"></see>
    /// </summary>
    let dateOfOpening =
        Namespaced_IRI.parse _namespace_name "dateOfOpening" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/dateOfPublicationSequentialDesignation"></see>
    /// </summary>
    let dateOfPublicationSequentialDesignation =
        Namespaced_IRI.parse _namespace_name "dateOfPublicationSequentialDesignation" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/datePublished"></see>
    /// </summary>
    let datePublished =
        Namespaced_IRI.parse _namespace_name "datePublished" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/dateSequentialDesignation"></see>
    /// </summary>
    let dateSequentialDesignation =
        Namespaced_IRI.parse _namespace_name "dateSequentialDesignation" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/ddc"></see>
    /// </summary>
    let ddc = Namespaced_IRI.parse _namespace_name "ddc" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/ddcn"></see>
    /// </summary>
    let ddcn = Namespaced_IRI.parse _namespace_name "ddcn" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/deathYear"></see>
    /// </summary>
    let deathYear = Namespaced_IRI.parse _namespace_name "deathYear" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/degreeYear"></see>
    /// </summary>
    let degreeYear = Namespaced_IRI.parse _namespace_name "degreeYear" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/department"></see>
    /// </summary>
    let department = Namespaced_IRI.parse _namespace_name "department" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/distributionPlace"></see>
    /// </summary>
    let distributionPlace =
        Namespaced_IRI.parse _namespace_name "distributionPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/distributor"></see>
    /// </summary>
    let distributor =
        Namespaced_IRI.parse _namespace_name "distributor" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/editionOfDDC"></see>
    /// </summary>
    let editionOfDDC =
        Namespaced_IRI.parse _namespace_name "editionOfDDC" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/editionOfKDC"></see>
    /// </summary>
    let editionOfKDC =
        Namespaced_IRI.parse _namespace_name "editionOfKDC" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/exhibition"></see>
    /// </summary>
    let exhibition = Namespaced_IRI.parse _namespace_name "exhibition" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/fax"></see>
    /// </summary>
    let fax = Namespaced_IRI.parse _namespace_name "fax" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/formerPublicationFrequency"></see>
    /// </summary>
    let formerPublicationFrequency =
        Namespaced_IRI.parse _namespace_name "formerPublicationFrequency" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/formerTitle"></see>
    /// </summary>
    let formerTitle =
        Namespaced_IRI.parse _namespace_name "formerTitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/formerTitleComplexityNote"></see>
    /// </summary>
    let formerTitleComplexityNote =
        Namespaced_IRI.parse _namespace_name "formerTitleComplexityNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/genre"></see>
    /// </summary>
    let genre = Namespaced_IRI.parse _namespace_name "genre" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/gpo"></see>
    /// </summary>
    let gpo = Namespaced_IRI.parse _namespace_name "gpo" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/gprn"></see>
    /// </summary>
    let gprn = Namespaced_IRI.parse _namespace_name "gprn" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/headingOfOriginalLanguage"></see>
    /// </summary>
    let headingOfOriginalLanguage =
        Namespaced_IRI.parse _namespace_name "headingOfOriginalLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/headingOfTranslation"></see>
    /// </summary>
    let headingOfTranslation =
        Namespaced_IRI.parse _namespace_name "headingOfTranslation" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/holdingInstitution"></see>
    /// </summary>
    let holdingInstitution =
        Namespaced_IRI.parse _namespace_name "holdingInstitution" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/holdingItemNote"></see>
    /// </summary>
    let holdingItemNote =
        Namespaced_IRI.parse _namespace_name "holdingItemNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/inputDate"></see>
    /// </summary>
    let inputDate = Namespaced_IRI.parse _namespace_name "inputDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/inputedBy"></see>
    /// </summary>
    let inputedBy = Namespaced_IRI.parse _namespace_name "inputedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/isClosed"></see>
    /// </summary>
    let isClosed = Namespaced_IRI.parse _namespace_name "isClosed" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/isGeographicAreaOf"></see>
    /// </summary>
    let isGeographicAreaOf =
        Namespaced_IRI.parse _namespace_name "isGeographicAreaOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/isSubjectOf"></see>
    /// </summary>
    let isSubjectOf =
        Namespaced_IRI.parse _namespace_name "isSubjectOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/issuingBodyNote"></see>
    /// </summary>
    let issuingBodyNote =
        Namespaced_IRI.parse _namespace_name "issuingBodyNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/itemNumber"></see>
    /// </summary>
    let itemNumber = Namespaced_IRI.parse _namespace_name "itemNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/itemNumberOfDDC"></see>
    /// </summary>
    let itemNumberOfDDC =
        Namespaced_IRI.parse _namespace_name "itemNumberOfDDC" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/itemNumberOfLC"></see>
    /// </summary>
    let itemNumberOfLC =
        Namespaced_IRI.parse _namespace_name "itemNumberOfLC" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/itemNumberOfNLK"></see>
    /// </summary>
    let itemNumberOfNLK =
        Namespaced_IRI.parse _namespace_name "itemNumberOfNLK" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/itemNumberOfOtherNumber"></see>
    /// </summary>
    let itemNumberOfOtherNumber =
        Namespaced_IRI.parse _namespace_name "itemNumberOfOtherNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/itermNumberOfKDC"></see>
    /// </summary>
    let itermNumberOfKDC =
        Namespaced_IRI.parse _namespace_name "itermNumberOfKDC" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/kdc"></see>
    /// </summary>
    let kdc = Namespaced_IRI.parse _namespace_name "kdc" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/kdcn"></see>
    /// </summary>
    let kdcn = Namespaced_IRI.parse _namespace_name "kdcn" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/keyTitle"></see>
    /// </summary>
    let keyTitle = Namespaced_IRI.parse _namespace_name "keyTitle" |> NamespacedName
    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/keyword"></see>
    /// </summary>
    let keyword = Namespaced_IRI.parse _namespace_name "keyword" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/languageNote"></see>
    /// </summary>
    let languageNote =
        Namespaced_IRI.parse _namespace_name "languageNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/libraryType"></see>
    /// </summary>
    let libraryType =
        Namespaced_IRI.parse _namespace_name "libraryType" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/linkingEntryComplexityNote"></see>
    /// </summary>
    let linkingEntryComplexityNote =
        Namespaced_IRI.parse _namespace_name "linkingEntryComplexityNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/localHolding"></see>
    /// </summary>
    let localHolding =
        Namespaced_IRI.parse _namespace_name "localHolding" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/locationNote"></see>
    /// </summary>
    let locationNote =
        Namespaced_IRI.parse _namespace_name "locationNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/mainEntryHeading"></see>
    /// </summary>
    let mainEntryHeading =
        Namespaced_IRI.parse _namespace_name "mainEntryHeading" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/manufacturer"></see>
    /// </summary>
    let manufacturer =
        Namespaced_IRI.parse _namespace_name "manufacturer" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/manufacturingPlace"></see>
    /// </summary>
    let manufacturingPlace =
        Namespaced_IRI.parse _namespace_name "manufacturingPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/medium"></see>
    /// </summary>
    let medium = Namespaced_IRI.parse _namespace_name "medium" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/meetingInformation"></see>
    /// </summary>
    let meetingInformation =
        Namespaced_IRI.parse _namespace_name "meetingInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/modificationDate"></see>
    /// </summary>
    let modificationDate =
        Namespaced_IRI.parse _namespace_name "modificationDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/modifiedBy"></see>
    /// </summary>
    let modifiedBy = Namespaced_IRI.parse _namespace_name "modifiedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/municipalLevel"></see>
    /// </summary>
    let municipalLevel =
        Namespaced_IRI.parse _namespace_name "municipalLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/numberMark"></see>
    /// </summary>
    let numberMark = Namespaced_IRI.parse _namespace_name "numberMark" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/numberingPeculiaritiesNote"></see>
    /// </summary>
    let numberingPeculiaritiesNote =
        Namespaced_IRI.parse _namespace_name "numberingPeculiaritiesNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/openingYear"></see>
    /// </summary>
    let openingYear =
        Namespaced_IRI.parse _namespace_name "openingYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/originalVersionNote"></see>
    /// </summary>
    let originalVersionNote =
        Namespaced_IRI.parse _namespace_name "originalVersionNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/otherNumber"></see>
    /// </summary>
    let otherNumber =
        Namespaced_IRI.parse _namespace_name "otherNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/physicalFormAvailableNote"></see>
    /// </summary>
    let physicalFormAvailableNote =
        Namespaced_IRI.parse _namespace_name "physicalFormAvailableNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/producer"></see>
    /// </summary>
    let producer = Namespaced_IRI.parse _namespace_name "producer" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/productionPlace"></see>
    /// </summary>
    let productionPlace =
        Namespaced_IRI.parse _namespace_name "productionPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/projection"></see>
    /// </summary>
    let projection = Namespaced_IRI.parse _namespace_name "projection" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/provincialLevel"></see>
    /// </summary>
    let provincialLevel =
        Namespaced_IRI.parse _namespace_name "provincialLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/publicationPlace"></see>
    /// </summary>
    let publicationPlace =
        Namespaced_IRI.parse _namespace_name "publicationPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/publish"></see>
    /// </summary>
    let publish = Namespaced_IRI.parse _namespace_name "publish" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/publishedIn"></see>
    /// </summary>
    let publishedIn =
        Namespaced_IRI.parse _namespace_name "publishedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/rank"></see>
    /// </summary>
    let rank = Namespaced_IRI.parse _namespace_name "rank" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/relatedParts"></see>
    /// </summary>
    let relatedParts =
        Namespaced_IRI.parse _namespace_name "relatedParts" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/relationshipInformation"></see>
    /// </summary>
    let relationshipInformation =
        Namespaced_IRI.parse _namespace_name "relationshipInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/remainderOfTitle"></see>
    /// </summary>
    let remainderOfTitle =
        Namespaced_IRI.parse _namespace_name "remainderOfTitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/reproductionDate"></see>
    /// </summary>
    let reproductionDate =
        Namespaced_IRI.parse _namespace_name "reproductionDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/reproductionNote"></see>
    /// </summary>
    let reproductionNote =
        Namespaced_IRI.parse _namespace_name "reproductionNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/reproductionInstitution"></see>
    /// </summary>
    let reproductionInstitution =
        Namespaced_IRI.parse _namespace_name "reproductionInstitution" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/reproductionPlace"></see>
    /// </summary>
    let reproductionPlace =
        Namespaced_IRI.parse _namespace_name "reproductionPlace" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/restriction"></see>
    /// </summary>
    let restriction =
        Namespaced_IRI.parse _namespace_name "restriction" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/scale"></see>
    /// </summary>
    let scale = Namespaced_IRI.parse _namespace_name "scale" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/sourceOfInformation"></see>
    /// </summary>
    let sourceOfInformation =
        Namespaced_IRI.parse _namespace_name "sourceOfInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/sourceOfOtherNumber"></see>
    /// </summary>
    let sourceOfOtherNumber =
        Namespaced_IRI.parse _namespace_name "sourceOfOtherNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/strn"></see>
    /// </summary>
    let strn = Namespaced_IRI.parse _namespace_name "strn" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/subseriesEntryHeading"></see>
    /// </summary>
    let subseriesEntryHeading =
        Namespaced_IRI.parse _namespace_name "subseriesEntryHeading" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/subtitle"></see>
    /// </summary>
    let subtitle = Namespaced_IRI.parse _namespace_name "subtitle" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/summerOpenTime"></see>
    /// </summary>
    let summerOpenTime =
        Namespaced_IRI.parse _namespace_name "summerOpenTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/supplementNote"></see>
    /// </summary>
    let supplementNote =
        Namespaced_IRI.parse _namespace_name "supplementNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfAdditionalPhysicalForm"></see>
    /// </summary>
    let titleOfAdditionalPhysicalForm =
        Namespaced_IRI.parse _namespace_name "titleOfAdditionalPhysicalForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfConstituentUnit"></see>
    /// </summary>
    let titleOfConstituentUnit =
        Namespaced_IRI.parse _namespace_name "titleOfConstituentUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfHostItem"></see>
    /// </summary>
    let titleOfHostItem =
        Namespaced_IRI.parse _namespace_name "titleOfHostItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfMainSeries"></see>
    /// </summary>
    let titleOfMainSeries =
        Namespaced_IRI.parse _namespace_name "titleOfMainSeries" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfOriginalLanguage"></see>
    /// </summary>
    let titleOfOriginalLanguage =
        Namespaced_IRI.parse _namespace_name "titleOfOriginalLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfOtherEdition"></see>
    /// </summary>
    let titleOfOtherEdition =
        Namespaced_IRI.parse _namespace_name "titleOfOtherEdition" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfPreceding"></see>
    /// </summary>
    let titleOfPreceding =
        Namespaced_IRI.parse _namespace_name "titleOfPreceding" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfSeries"></see>
    /// </summary>
    let titleOfSeries =
        Namespaced_IRI.parse _namespace_name "titleOfSeries" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfSubSeries"></see>
    /// </summary>
    let titleOfSubSeries =
        Namespaced_IRI.parse _namespace_name "titleOfSubSeries" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfSucceeding"></see>
    /// </summary>
    let titleOfSucceeding =
        Namespaced_IRI.parse _namespace_name "titleOfSucceeding" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfSupplement"></see>
    /// </summary>
    let titleOfSupplement =
        Namespaced_IRI.parse _namespace_name "titleOfSupplement" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfSupplementParent"></see>
    /// </summary>
    let titleOfSupplementParent =
        Namespaced_IRI.parse _namespace_name "titleOfSupplementParent" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/titleOfTranslation"></see>
    /// </summary>
    let titleOfTranslation =
        Namespaced_IRI.parse _namespace_name "titleOfTranslation" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/typeOfContinuousData"></see>
    /// </summary>
    let typeOfContinuousData =
        Namespaced_IRI.parse _namespace_name "typeOfContinuousData" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/typeOfData"></see>
    /// </summary>
    let typeOfData = Namespaced_IRI.parse _namespace_name "typeOfData" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/typeOfPublicationFrequency"></see>
    /// </summary>
    let typeOfPublicationFrequency =
        Namespaced_IRI.parse _namespace_name "typeOfPublicationFrequency" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/typeOfPublicationStatus"></see>
    /// </summary>
    let typeOfPublicationStatus =
        Namespaced_IRI.parse _namespace_name "typeOfPublicationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/typeOfResource"></see>
    /// </summary>
    let typeOfResource =
        Namespaced_IRI.parse _namespace_name "typeOfResource" |> NamespacedName

    /// <summary>
    /// 한국형 URN 식별 체계
    /// <see href="http://lod.nl.go.kr/ontology/uci"></see></summary>
    let uci = Namespaced_IRI.parse _namespace_name "uci" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/uniformTitleOfSeries"></see>
    /// </summary>
    let uniformTitleOfSeries =
        Namespaced_IRI.parse _namespace_name "uniformTitleOfSeries" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/useAndReproductionNote"></see>
    /// </summary>
    let useAndReproductionNote =
        Namespaced_IRI.parse _namespace_name "useAndReproductionNote" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/volumeOfNLK"></see>
    /// </summary>
    let volumeOfNLK =
        Namespaced_IRI.parse _namespace_name "volumeOfNLK" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/volumeOfSeries"></see>
    /// </summary>
    let volumeOfSeries =
        Namespaced_IRI.parse _namespace_name "volumeOfSeries" |> NamespacedName

    /// <summary>
    ///   <see href="http://lod.nl.go.kr/ontology/winterOpenTime"></see>
    /// </summary>
    let winterOpenTime =
        Namespaced_IRI.parse _namespace_name "winterOpenTime" |> NamespacedName
