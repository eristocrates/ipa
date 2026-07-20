namespace http.rs.tdwg.org.ac.terms.slash

open DoxAletheia

module ac =
    let _namespace_name = "http://rs.tdwg.org/ac/terms/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/freqHigh"></see>
    /// </summary>
    let freqHigh = _prefix "freqHigh"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/radius"></see>
    /// </summary>
    let radius = _prefix "radius"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/reviewerLiteral"></see>
    /// </summary>
    let reviewerLiteral = _prefix "reviewerLiteral"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/resourceCreationTechnique"></see>
    /// </summary>
    let resourceCreationTechnique = _prefix "resourceCreationTechnique"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/mediaDuration"></see>
    /// </summary>
    let mediaDuration = _prefix "mediaDuration"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/variant"></see>
    /// </summary>
    let variant = _prefix "variant"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/associatedObservationReference"></see>
    /// </summary>
    let associatedObservationReference = _prefix "associatedObservationReference"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/physicalSetting"></see>
    /// </summary>
    let physicalSetting = _prefix "physicalSetting"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/yFrac"></see>
    /// </summary>
    let yFrac = _prefix "yFrac"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/endTimestamp"></see>
    /// </summary>
    let endTimestamp = _prefix "endTimestamp"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/metadataLanguageLiteral"></see>
    /// </summary>
    let metadataLanguageLiteral = _prefix "metadataLanguageLiteral"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/caption"></see>
    /// </summary>
    let caption = _prefix "caption"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/freqLow"></see>
    /// </summary>
    let freqLow = _prefix "freqLow"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/commenterLiteral"></see>
    /// </summary>
    let commenterLiteral = _prefix "commenterLiteral"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/frameRate"></see>
    /// </summary>
    let frameRate = _prefix "frameRate"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/commenter"></see>
    /// </summary>
    let commenter = _prefix "commenter"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/endTime"></see>
    /// </summary>
    let endTime = _prefix "endTime"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/tag"></see>
    /// </summary>
    let tag = _prefix "tag"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/taxonCoverage"></see>
    /// </summary>
    let taxonCoverage = _prefix "taxonCoverage"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/subjectOrientationLiteral"></see>
    /// </summary>
    let subjectOrientationLiteral = _prefix "subjectOrientationLiteral"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/subjectPartLiteral"></see>
    /// </summary>
    let subjectPartLiteral = _prefix "subjectPartLiteral"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/otherScientificName"></see>
    /// </summary>
    let otherScientificName = _prefix "otherScientificName"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/ServiceAccessPoint"></see>
    /// </summary>
    let ServiceAccessPoint = _prefix "ServiceAccessPoint"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/taxonCount"></see>
    /// </summary>
    let taxonCount = _prefix "taxonCount"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/derivedFrom"></see>
    /// </summary>
    let derivedFrom = _prefix "derivedFrom"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/attributionLogoURL"></see>
    /// </summary>
    let attributionLogoURL = _prefix "attributionLogoURL"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/variantLiteral"></see>
    /// </summary>
    let variantLiteral = _prefix "variantLiteral"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/subjectCategoryVocabulary"></see>
    /// </summary>
    let subjectCategoryVocabulary = _prefix "subjectCategoryVocabulary"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/IDofContainingCollection"></see>
    /// </summary>
    let IDofContainingCollection = _prefix "IDofContainingCollection"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/captureDevice"></see>
    /// </summary>
    let captureDevice = _prefix "captureDevice"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/attributionLinkURL"></see>
    /// </summary>
    let attributionLinkURL = _prefix "attributionLinkURL"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/xFrac"></see>
    /// </summary>
    let xFrac = _prefix "xFrac"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/metadataCreatorLiteral"></see>
    /// </summary>
    let metadataCreatorLiteral = _prefix "metadataCreatorLiteral"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/provider"></see>
    /// </summary>
    let provider = _prefix "provider"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/isROIOf"></see>
    /// </summary>
    let isROIOf = _prefix "isROIOf"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/subjectOrientation"></see>
    /// </summary>
    let subjectOrientation = _prefix "subjectOrientation"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/fundingAttribution"></see>
    /// </summary>
    let fundingAttribution = _prefix "fundingAttribution"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/metadataCreator"></see>
    /// </summary>
    let metadataCreator = _prefix "metadataCreator"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/providerID"></see>
    /// </summary>
    let providerID = _prefix "providerID"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/hasServiceAccessPoint"></see>
    /// </summary>
    let hasServiceAccessPoint = _prefix "hasServiceAccessPoint"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/comments"></see>
    /// </summary>
    let comments = _prefix "comments"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/RegionOfInterest"></see>
    /// </summary>
    let RegionOfInterest = _prefix "RegionOfInterest"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/furtherInformationURL"></see>
    /// </summary>
    let furtherInformationURL = _prefix "furtherInformationURL"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/associatedSpecimenReference"></see>
    /// </summary>
    let associatedSpecimenReference = _prefix "associatedSpecimenReference"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/startTime"></see>
    /// </summary>
    let startTime = _prefix "startTime"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/serviceExpectation"></see>
    /// </summary>
    let serviceExpectation = _prefix "serviceExpectation"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/widthFrac"></see>
    /// </summary>
    let widthFrac = _prefix "widthFrac"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/metadataLanguage"></see>
    /// </summary>
    let metadataLanguage = _prefix "metadataLanguage"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/mediaSpeed"></see>
    /// </summary>
    let mediaSpeed = _prefix "mediaSpeed"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/reviewerComments"></see>
    /// </summary>
    let reviewerComments = _prefix "reviewerComments"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/metadataProviderLiteral"></see>
    /// </summary>
    let metadataProviderLiteral = _prefix "metadataProviderLiteral"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/licenseLogoURL"></see>
    /// </summary>
    let licenseLogoURL = _prefix "licenseLogoURL"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/accessURI"></see>
    /// </summary>
    let accessURI = _prefix "accessURI"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/variantDescription"></see>
    /// </summary>
    let variantDescription = _prefix "variantDescription"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/reviewer"></see>
    /// </summary>
    let reviewer = _prefix "reviewer"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/providerLiteral"></see>
    /// </summary>
    let providerLiteral = _prefix "providerLiteral"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/digitizationDate"></see>
    /// </summary>
    let digitizationDate = _prefix "digitizationDate"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/relatedResourceID"></see>
    /// </summary>
    let relatedResourceID = _prefix "relatedResourceID"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/hashFunction"></see>
    /// </summary>
    let hashFunction = _prefix "hashFunction"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/hashValue"></see>
    /// </summary>
    let hashValue = _prefix "hashValue"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/subtype"></see>
    /// </summary>
    let subtype = _prefix "subtype"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/subjectPart"></see>
    /// </summary>
    let subjectPart = _prefix "subjectPart"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/subtypeLiteral"></see>
    /// </summary>
    let subtypeLiteral = _prefix "subtypeLiteral"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/startTimestamp"></see>
    /// </summary>
    let startTimestamp = _prefix "startTimestamp"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/metadataProvider"></see>
    /// </summary>
    let metadataProvider = _prefix "metadataProvider"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/licensingException"></see>
    /// </summary>
    let licensingException = _prefix "licensingException"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/hasROI"></see>
    /// </summary>
    let hasROI = _prefix "hasROI"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/heightFrac"></see>
    /// </summary>
    let heightFrac = _prefix "heightFrac"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/timeOfDay"></see>
    /// </summary>
    let timeOfDay = _prefix "timeOfDay"
    /// <summary>
    ///   <see href="http://rs.tdwg.org/ac/terms/providerManagedID"></see>
    /// </summary>
    let providerManagedID = _prefix "providerManagedID"
