namespace http.rs.tdwg.org.ac.terms.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ac =
    let _namespace_iri = Namespace_Iri ac |> NamespaceIRI
    /// <summary>
    ///   <para>ac:</para>
    /// </summary>
    /// <remarks>
    ///   <para>dwc:attributes/TermList</para>
    ///   <para>This term list includes all currently valid terms that have been defined in the core Audubon Core namespace ac:.</para>
    /// labels<para>Core terms defined by Audubon Core</para></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/">http://rs.tdwg.org/ac/terms/</seealso>
    let _prefix_iri = Prefixed_Name(ac, "") |> PrefixedName
    /// <summary>
    ///   <para>ac:reviewerLiteral</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/reviewerLiteral">http://rs.tdwg.org/ac/terms/reviewerLiteral</seealso>
    let reviewerLiteral = Prefixed_Name(ac, "reviewerLiteral") |> PrefixedName
    /// <summary>
    ///   <para>ac:variant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/variant">http://rs.tdwg.org/ac/terms/variant</seealso>
    let variant = Prefixed_Name(ac, "variant") |> PrefixedName

    /// <summary>
    ///   <para>ac:associatedObservationReference</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/associatedObservationReference">http://rs.tdwg.org/ac/terms/associatedObservationReference</seealso>
    let associatedObservationReference =
        Prefixed_Name(ac, "associatedObservationReference") |> PrefixedName

    /// <summary>
    ///   <para>ac:metadataLanguageLiteral</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/metadataLanguageLiteral">http://rs.tdwg.org/ac/terms/metadataLanguageLiteral</seealso>
    let metadataLanguageLiteral =
        Prefixed_Name(ac, "metadataLanguageLiteral") |> PrefixedName

    /// <summary>
    ///   <para>ac:freqLow</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/freqLow">http://rs.tdwg.org/ac/terms/freqLow</seealso>
    let freqLow = Prefixed_Name(ac, "freqLow") |> PrefixedName
    /// <summary>
    ///   <para>ac:endTime</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/endTime">http://rs.tdwg.org/ac/terms/endTime</seealso>
    let endTime = Prefixed_Name(ac, "endTime") |> PrefixedName
    /// <summary>
    ///   <para>ac:tag</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/tag">http://rs.tdwg.org/ac/terms/tag</seealso>
    let tag = Prefixed_Name(ac, "tag") |> PrefixedName
    /// <summary>
    ///   <para>ac:otherScientificName</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/otherScientificName">http://rs.tdwg.org/ac/terms/otherScientificName</seealso>
    let otherScientificName = Prefixed_Name(ac, "otherScientificName") |> PrefixedName
    /// <summary>
    ///   <para>ac:ServiceAccessPoint</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/ServiceAccessPoint">http://rs.tdwg.org/ac/terms/ServiceAccessPoint</seealso>
    let ServiceAccessPoint = Prefixed_Name(ac, "ServiceAccessPoint") |> PrefixedName
    /// <summary>
    ///   <para>ac:captureDevice</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/captureDevice">http://rs.tdwg.org/ac/terms/captureDevice</seealso>
    let captureDevice = Prefixed_Name(ac, "captureDevice") |> PrefixedName
    /// <summary>
    ///   <para>ac:attributionLinkURL</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/attributionLinkURL">http://rs.tdwg.org/ac/terms/attributionLinkURL</seealso>
    let attributionLinkURL = Prefixed_Name(ac, "attributionLinkURL") |> PrefixedName
    /// <summary>
    ///   <para>ac:isROIOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/isROIOf">http://rs.tdwg.org/ac/terms/isROIOf</seealso>
    let isROIOf = Prefixed_Name(ac, "isROIOf") |> PrefixedName
    /// <summary>
    ///   <para>ac:subjectOrientation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/subjectOrientation">http://rs.tdwg.org/ac/terms/subjectOrientation</seealso>
    let subjectOrientation = Prefixed_Name(ac, "subjectOrientation") |> PrefixedName
    /// <summary>
    ///   <para>ac:providerID</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/providerID">http://rs.tdwg.org/ac/terms/providerID</seealso>
    let providerID = Prefixed_Name(ac, "providerID") |> PrefixedName

    /// <summary>
    ///   <para>ac:hasServiceAccessPoint</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/hasServiceAccessPoint">http://rs.tdwg.org/ac/terms/hasServiceAccessPoint</seealso>
    let hasServiceAccessPoint =
        Prefixed_Name(ac, "hasServiceAccessPoint") |> PrefixedName

    /// <summary>
    ///   <para>ac:widthFrac</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/widthFrac">http://rs.tdwg.org/ac/terms/widthFrac</seealso>
    let widthFrac = Prefixed_Name(ac, "widthFrac") |> PrefixedName
    /// <summary>
    ///   <para>ac:metadataLanguage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/metadataLanguage">http://rs.tdwg.org/ac/terms/metadataLanguage</seealso>
    let metadataLanguage = Prefixed_Name(ac, "metadataLanguage") |> PrefixedName

    /// <summary>
    ///   <para>ac:metadataProviderLiteral</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/metadataProviderLiteral">http://rs.tdwg.org/ac/terms/metadataProviderLiteral</seealso>
    let metadataProviderLiteral =
        Prefixed_Name(ac, "metadataProviderLiteral") |> PrefixedName

    /// <summary>
    ///   <para>ac:licenseLogoURL</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/licenseLogoURL">http://rs.tdwg.org/ac/terms/licenseLogoURL</seealso>
    let licenseLogoURL = Prefixed_Name(ac, "licenseLogoURL") |> PrefixedName
    /// <summary>
    ///   <para>ac:hashFunction</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/hashFunction">http://rs.tdwg.org/ac/terms/hashFunction</seealso>
    let hashFunction = Prefixed_Name(ac, "hashFunction") |> PrefixedName
    /// <summary>
    ///   <para>ac:hashValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/hashValue">http://rs.tdwg.org/ac/terms/hashValue</seealso>
    let hashValue = Prefixed_Name(ac, "hashValue") |> PrefixedName
    /// <summary>
    ///   <para>ac:subtypeLiteral</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/subtypeLiteral">http://rs.tdwg.org/ac/terms/subtypeLiteral</seealso>
    let subtypeLiteral = Prefixed_Name(ac, "subtypeLiteral") |> PrefixedName
    /// <summary>
    ///   <para>ac:startTimestamp</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/startTimestamp">http://rs.tdwg.org/ac/terms/startTimestamp</seealso>
    let startTimestamp = Prefixed_Name(ac, "startTimestamp") |> PrefixedName
    /// <summary>
    ///   <para>ac:metadataProvider</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/metadataProvider">http://rs.tdwg.org/ac/terms/metadataProvider</seealso>
    let metadataProvider = Prefixed_Name(ac, "metadataProvider") |> PrefixedName
    /// <summary>
    ///   <para>ac:licensingException</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/licensingException">http://rs.tdwg.org/ac/terms/licensingException</seealso>
    let licensingException = Prefixed_Name(ac, "licensingException") |> PrefixedName
    /// <summary>
    ///   <para>ac:radius</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/radius">http://rs.tdwg.org/ac/terms/radius</seealso>
    let radius = Prefixed_Name(ac, "radius") |> PrefixedName
    /// <summary>
    ///   <para>ac:physicalSetting</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/physicalSetting">http://rs.tdwg.org/ac/terms/physicalSetting</seealso>
    let physicalSetting = Prefixed_Name(ac, "physicalSetting") |> PrefixedName
    /// <summary>
    ///   <para>ac:caption</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/caption">http://rs.tdwg.org/ac/terms/caption</seealso>
    let caption = Prefixed_Name(ac, "caption") |> PrefixedName
    /// <summary>
    ///   <para>ac:commenter</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/commenter">http://rs.tdwg.org/ac/terms/commenter</seealso>
    let commenter = Prefixed_Name(ac, "commenter") |> PrefixedName
    /// <summary>
    ///   <para>ac:taxonCoverage</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/taxonCoverage">http://rs.tdwg.org/ac/terms/taxonCoverage</seealso>
    let taxonCoverage = Prefixed_Name(ac, "taxonCoverage") |> PrefixedName
    /// <summary>
    ///   <para>ac:taxonCount</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/taxonCount">http://rs.tdwg.org/ac/terms/taxonCount</seealso>
    let taxonCount = Prefixed_Name(ac, "taxonCount") |> PrefixedName
    /// <summary>
    ///   <para>ac:derivedFrom</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/derivedFrom">http://rs.tdwg.org/ac/terms/derivedFrom</seealso>
    let derivedFrom = Prefixed_Name(ac, "derivedFrom") |> PrefixedName
    /// <summary>
    ///   <para>ac:xFrac</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/xFrac">http://rs.tdwg.org/ac/terms/xFrac</seealso>
    let xFrac = Prefixed_Name(ac, "xFrac") |> PrefixedName

    /// <summary>
    ///   <para>ac:metadataCreatorLiteral</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/metadataCreatorLiteral">http://rs.tdwg.org/ac/terms/metadataCreatorLiteral</seealso>
    let metadataCreatorLiteral =
        Prefixed_Name(ac, "metadataCreatorLiteral") |> PrefixedName

    /// <summary>
    ///   <para>ac:provider</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/provider">http://rs.tdwg.org/ac/terms/provider</seealso>
    let provider = Prefixed_Name(ac, "provider") |> PrefixedName
    /// <summary>
    ///   <para>ac:fundingAttribution</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/fundingAttribution">http://rs.tdwg.org/ac/terms/fundingAttribution</seealso>
    let fundingAttribution = Prefixed_Name(ac, "fundingAttribution") |> PrefixedName
    /// <summary>
    ///   <para>ac:metadataCreator</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/metadataCreator">http://rs.tdwg.org/ac/terms/metadataCreator</seealso>
    let metadataCreator = Prefixed_Name(ac, "metadataCreator") |> PrefixedName
    /// <summary>
    ///   <para>ac:startTime</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/startTime">http://rs.tdwg.org/ac/terms/startTime</seealso>
    let startTime = Prefixed_Name(ac, "startTime") |> PrefixedName
    /// <summary>
    ///   <para>ac:serviceExpectation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/serviceExpectation">http://rs.tdwg.org/ac/terms/serviceExpectation</seealso>
    let serviceExpectation = Prefixed_Name(ac, "serviceExpectation") |> PrefixedName
    /// <summary>
    ///   <para>ac:mediaSpeed</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/mediaSpeed">http://rs.tdwg.org/ac/terms/mediaSpeed</seealso>
    let mediaSpeed = Prefixed_Name(ac, "mediaSpeed") |> PrefixedName
    /// <summary>
    ///   <para>ac:reviewerComments</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/reviewerComments">http://rs.tdwg.org/ac/terms/reviewerComments</seealso>
    let reviewerComments = Prefixed_Name(ac, "reviewerComments") |> PrefixedName
    /// <summary>
    ///   <para>ac:digitizationDate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/digitizationDate">http://rs.tdwg.org/ac/terms/digitizationDate</seealso>
    let digitizationDate = Prefixed_Name(ac, "digitizationDate") |> PrefixedName
    /// <summary>
    ///   <para>ac:relatedResourceID</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/relatedResourceID">http://rs.tdwg.org/ac/terms/relatedResourceID</seealso>
    let relatedResourceID = Prefixed_Name(ac, "relatedResourceID") |> PrefixedName
    /// <summary>
    ///   <para>ac:subtype</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/subtype">http://rs.tdwg.org/ac/terms/subtype</seealso>
    let subtype = Prefixed_Name(ac, "subtype") |> PrefixedName
    /// <summary>
    ///   <para>ac:subjectPart</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/subjectPart">http://rs.tdwg.org/ac/terms/subjectPart</seealso>
    let subjectPart = Prefixed_Name(ac, "subjectPart") |> PrefixedName
    /// <summary>
    ///   <para>ac:freqHigh</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/freqHigh">http://rs.tdwg.org/ac/terms/freqHigh</seealso>
    let freqHigh = Prefixed_Name(ac, "freqHigh") |> PrefixedName

    /// <summary>
    ///   <para>ac:resourceCreationTechnique</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/resourceCreationTechnique">http://rs.tdwg.org/ac/terms/resourceCreationTechnique</seealso>
    let resourceCreationTechnique =
        Prefixed_Name(ac, "resourceCreationTechnique") |> PrefixedName

    /// <summary>
    ///   <para>ac:mediaDuration</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/mediaDuration">http://rs.tdwg.org/ac/terms/mediaDuration</seealso>
    let mediaDuration = Prefixed_Name(ac, "mediaDuration") |> PrefixedName
    /// <summary>
    ///   <para>ac:yFrac</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/yFrac">http://rs.tdwg.org/ac/terms/yFrac</seealso>
    let yFrac = Prefixed_Name(ac, "yFrac") |> PrefixedName
    /// <summary>
    ///   <para>ac:endTimestamp</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/endTimestamp">http://rs.tdwg.org/ac/terms/endTimestamp</seealso>
    let endTimestamp = Prefixed_Name(ac, "endTimestamp") |> PrefixedName
    /// <summary>
    ///   <para>ac:commenterLiteral</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/commenterLiteral">http://rs.tdwg.org/ac/terms/commenterLiteral</seealso>
    let commenterLiteral = Prefixed_Name(ac, "commenterLiteral") |> PrefixedName
    /// <summary>
    ///   <para>ac:frameRate</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/frameRate">http://rs.tdwg.org/ac/terms/frameRate</seealso>
    let frameRate = Prefixed_Name(ac, "frameRate") |> PrefixedName

    /// <summary>
    ///   <para>ac:subjectOrientationLiteral</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/subjectOrientationLiteral">http://rs.tdwg.org/ac/terms/subjectOrientationLiteral</seealso>
    let subjectOrientationLiteral =
        Prefixed_Name(ac, "subjectOrientationLiteral") |> PrefixedName

    /// <summary>
    ///   <para>ac:subjectPartLiteral</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/subjectPartLiteral">http://rs.tdwg.org/ac/terms/subjectPartLiteral</seealso>
    let subjectPartLiteral = Prefixed_Name(ac, "subjectPartLiteral") |> PrefixedName
    /// <summary>
    ///   <para>ac:attributionLogoURL</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/attributionLogoURL">http://rs.tdwg.org/ac/terms/attributionLogoURL</seealso>
    let attributionLogoURL = Prefixed_Name(ac, "attributionLogoURL") |> PrefixedName
    /// <summary>
    ///   <para>ac:variantLiteral</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/variantLiteral">http://rs.tdwg.org/ac/terms/variantLiteral</seealso>
    let variantLiteral = Prefixed_Name(ac, "variantLiteral") |> PrefixedName

    /// <summary>
    ///   <para>ac:subjectCategoryVocabulary</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/subjectCategoryVocabulary">http://rs.tdwg.org/ac/terms/subjectCategoryVocabulary</seealso>
    let subjectCategoryVocabulary =
        Prefixed_Name(ac, "subjectCategoryVocabulary") |> PrefixedName

    /// <summary>
    ///   <para>ac:IDofContainingCollection</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/IDofContainingCollection">http://rs.tdwg.org/ac/terms/IDofContainingCollection</seealso>
    let IDofContainingCollection =
        Prefixed_Name(ac, "IDofContainingCollection") |> PrefixedName

    /// <summary>
    ///   <para>ac:comments</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/comments">http://rs.tdwg.org/ac/terms/comments</seealso>
    let comments = Prefixed_Name(ac, "comments") |> PrefixedName
    /// <summary>
    ///   <para>ac:RegionOfInterest</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/RegionOfInterest">http://rs.tdwg.org/ac/terms/RegionOfInterest</seealso>
    let RegionOfInterest = Prefixed_Name(ac, "RegionOfInterest") |> PrefixedName

    /// <summary>
    ///   <para>ac:furtherInformationURL</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/furtherInformationURL">http://rs.tdwg.org/ac/terms/furtherInformationURL</seealso>
    let furtherInformationURL =
        Prefixed_Name(ac, "furtherInformationURL") |> PrefixedName

    /// <summary>
    ///   <para>ac:associatedSpecimenReference</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/associatedSpecimenReference">http://rs.tdwg.org/ac/terms/associatedSpecimenReference</seealso>
    let associatedSpecimenReference =
        Prefixed_Name(ac, "associatedSpecimenReference") |> PrefixedName

    /// <summary>
    ///   <para>ac:accessURI</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/accessURI">http://rs.tdwg.org/ac/terms/accessURI</seealso>
    let accessURI = Prefixed_Name(ac, "accessURI") |> PrefixedName
    /// <summary>
    ///   <para>ac:variantDescription</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/variantDescription">http://rs.tdwg.org/ac/terms/variantDescription</seealso>
    let variantDescription = Prefixed_Name(ac, "variantDescription") |> PrefixedName
    /// <summary>
    ///   <para>ac:reviewer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/reviewer">http://rs.tdwg.org/ac/terms/reviewer</seealso>
    let reviewer = Prefixed_Name(ac, "reviewer") |> PrefixedName
    /// <summary>
    ///   <para>ac:providerLiteral</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/providerLiteral">http://rs.tdwg.org/ac/terms/providerLiteral</seealso>
    let providerLiteral = Prefixed_Name(ac, "providerLiteral") |> PrefixedName
    /// <summary>
    ///   <para>ac:hasROI</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/hasROI">http://rs.tdwg.org/ac/terms/hasROI</seealso>
    let hasROI = Prefixed_Name(ac, "hasROI") |> PrefixedName
    /// <summary>
    ///   <para>ac:heightFrac</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/heightFrac">http://rs.tdwg.org/ac/terms/heightFrac</seealso>
    let heightFrac = Prefixed_Name(ac, "heightFrac") |> PrefixedName
    /// <summary>
    ///   <para>ac:timeOfDay</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/timeOfDay">http://rs.tdwg.org/ac/terms/timeOfDay</seealso>
    let timeOfDay = Prefixed_Name(ac, "timeOfDay") |> PrefixedName
    /// <summary>
    ///   <para>ac:providerManagedID</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rs.tdwg.org/ac/terms/providerManagedID">http://rs.tdwg.org/ac/terms/providerManagedID</seealso>
    let providerManagedID = Prefixed_Name(ac, "providerManagedID") |> PrefixedName
