namespace http.purl.org.spar.fivestars.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sparfivestars =
    let _namespace_iri = Namespace_Iri sparfivestars |> NamespaceIRI

    /// <summary>
    ///   <para>sparfivestars:availableDatasetsRatingComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Comment explaining Five Stars ratings given to journal artice relating to available datasets.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/fivestars/availableDatasetsRatingComment">http://purl.org/spar/fivestars/availableDatasetsRatingComment</seealso>
    let availableDatasetsRatingComment =
        Prefixed_Name(sparfivestars, "availableDatasetsRatingComment") |> PrefixedName

    /// <summary>
    ///   <para>sparfivestars:hasEnhancedContentRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Integer rating (from 0 to 4) given to journal artice for enhanced content.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/fivestars/hasEnhancedContentRating">http://purl.org/spar/fivestars/hasEnhancedContentRating</seealso>
    let hasEnhancedContentRating =
        Prefixed_Name(sparfivestars, "hasEnhancedContentRating") |> PrefixedName

    /// <summary>
    ///   <para>sparfivestars:hasOverallFiveStarsRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Overall Five stars rating (on integer scale from from 0 to 20) given to journal artice, obtained by summing the individual ratings given for each of the Five Stars of Online Journal Articles.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/fivestars/hasOverallFiveStarsRating">http://purl.org/spar/fivestars/hasOverallFiveStarsRating</seealso>
    let hasOverallFiveStarsRating =
        Prefixed_Name(sparfivestars, "hasOverallFiveStarsRating") |> PrefixedName

    /// <summary>
    ///   <para>sparfivestars:openAccessRatingComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Comment explaining Five Stars ratings given to journal artice relating to open access.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/fivestars/openAccessRatingComment">http://purl.org/spar/fivestars/openAccessRatingComment</seealso>
    let openAccessRatingComment =
        Prefixed_Name(sparfivestars, "openAccessRatingComment") |> PrefixedName

    /// <summary>
    ///   <para>sparfivestars:enhancedContentRatingComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Comment explaining Five Stars ratings given to journal artice relating to enhanced content.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/fivestars/enhancedContentRatingComment">http://purl.org/spar/fivestars/enhancedContentRatingComment</seealso>
    let enhancedContentRatingComment =
        Prefixed_Name(sparfivestars, "enhancedContentRatingComment") |> PrefixedName

    /// <summary>
    ///   <para>sparfivestars:hasMachine-readableMetadataRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Integer rating (from 0 to 4) given to journal artice for machine-readable metadata.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/fivestars/hasMachine-readableMetadataRating">http://purl.org/spar/fivestars/hasMachine-readableMetadataRating</seealso>
    let hasMachine_readableMetadataRating =
        Prefixed_Name(sparfivestars, "hasMachine-readableMetadataRating") |> PrefixedName

    /// <summary>
    ///   <para>sparfivestars:machine-readableMetadataRatingComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Comment explaining Five Stars ratings given to journal artice relating to machine-readable metadata.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/fivestars/machine-readableMetadataRatingComment">http://purl.org/spar/fivestars/machine-readableMetadataRatingComment</seealso>
    let machine_readableMetadataRatingComment =
        Prefixed_Name(sparfivestars, "machine-readableMetadataRatingComment") |> PrefixedName

    /// <summary>
    ///   <para>sparfivestars:overallFiveStarsRatingComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Comment on overall Five Stars rating given to journal artice.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/fivestars/overallFiveStarsRatingComment">http://purl.org/spar/fivestars/overallFiveStarsRatingComment</seealso>
    let overallFiveStarsRatingComment =
        Prefixed_Name(sparfivestars, "overallFiveStarsRatingComment") |> PrefixedName

    /// <summary>
    ///   <para>sparfivestars:2012-01-16</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/spar/fivestars/2012-01-16">http://purl.org/spar/fivestars/2012-01-16</seealso>
    let _2012_01_16 = Prefixed_Name(sparfivestars, "2012-01-16") |> PrefixedName

    /// <summary>
    ///   <para>sparfivestars:hasAvailableDatasetsRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Integer rating (from 0 to 4) given to journal artice for available datasets.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/fivestars/hasAvailableDatasetsRating">http://purl.org/spar/fivestars/hasAvailableDatasetsRating</seealso>
    let hasAvailableDatasetsRating =
        Prefixed_Name(sparfivestars, "hasAvailableDatasetsRating") |> PrefixedName

    /// <summary>
    ///   <para>sparfivestars:hasOpenAccessRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Integer rating (from 0 to 4) given to journal artice for open access.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/fivestars/hasOpenAccessRating">http://purl.org/spar/fivestars/hasOpenAccessRating</seealso>
    let hasOpenAccessRating =
        Prefixed_Name(sparfivestars, "hasOpenAccessRating") |> PrefixedName

    /// <summary>
    ///   <para>sparfivestars:hasPeerReviewRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Integer rating (from 0 to 4) given to journal artice for peer review.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/fivestars/hasPeerReviewRating">http://purl.org/spar/fivestars/hasPeerReviewRating</seealso>
    let hasPeerReviewRating =
        Prefixed_Name(sparfivestars, "hasPeerReviewRating") |> PrefixedName

    /// <summary>
    ///   <para>sparfivestars:peerReviewRatingComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Comment explaining Five Stars ratings given to journal artice relating to peer review.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/fivestars/peerReviewRatingComment">http://purl.org/spar/fivestars/peerReviewRatingComment</seealso>
    let peerReviewRatingComment =
        Prefixed_Name(sparfivestars, "peerReviewRatingComment") |> PrefixedName
