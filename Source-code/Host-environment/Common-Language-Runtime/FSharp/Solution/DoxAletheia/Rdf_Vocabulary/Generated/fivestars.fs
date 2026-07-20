namespace http.purl.org.spar.fivestars.slash

open DoxAletheia

module fivestars =
    let _namespace_name = "http://purl.org/spar/fivestars/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/spar/fivestars/2012-01-16"></see>
    /// </summary>
    let ``_2012-01-16`` = _prefix "2012-01-16"
    /// <summary>
    /// Comment explaining Five Stars ratings given to journal artice relating to available datasets.
    /// <see href="http://purl.org/spar/fivestars/availableDatasetsRatingComment"></see></summary>
    let availableDatasetsRatingComment = _prefix "availableDatasetsRatingComment"
    /// <summary>
    /// Comment explaining Five Stars ratings given to journal artice relating to enhanced content.
    /// <see href="http://purl.org/spar/fivestars/enhancedContentRatingComment"></see></summary>
    let enhancedContentRatingComment = _prefix "enhancedContentRatingComment"
    /// <summary>
    /// Integer rating (from 0 to 4) given to journal artice for available datasets.
    /// <see href="http://purl.org/spar/fivestars/hasAvailableDatasetsRating"></see></summary>
    let hasAvailableDatasetsRating = _prefix "hasAvailableDatasetsRating"
    /// <summary>
    /// Integer rating (from 0 to 4) given to journal artice for enhanced content.
    /// <see href="http://purl.org/spar/fivestars/hasEnhancedContentRating"></see></summary>
    let hasEnhancedContentRating = _prefix "hasEnhancedContentRating"

    /// <summary>
    /// Integer rating (from 0 to 4) given to journal artice for machine-readable metadata.
    /// <see href="http://purl.org/spar/fivestars/hasMachine-readableMetadataRating"></see></summary>
    let ``hasMachine-readableMetadataRating`` =
        _prefix "hasMachine-readableMetadataRating"

    /// <summary>
    /// Integer rating (from 0 to 4) given to journal artice for open access.
    /// <see href="http://purl.org/spar/fivestars/hasOpenAccessRating"></see></summary>
    let hasOpenAccessRating = _prefix "hasOpenAccessRating"
    /// <summary>
    /// Overall Five stars rating (on integer scale from from 0 to 20) given to journal artice, obtained by summing the individual ratings given for each of the Five Stars of Online Journal Articles.
    /// <see href="http://purl.org/spar/fivestars/hasOverallFiveStarsRating"></see></summary>
    let hasOverallFiveStarsRating = _prefix "hasOverallFiveStarsRating"
    /// <summary>
    /// Integer rating (from 0 to 4) given to journal artice for peer review.
    /// <see href="http://purl.org/spar/fivestars/hasPeerReviewRating"></see></summary>
    let hasPeerReviewRating = _prefix "hasPeerReviewRating"

    /// <summary>
    /// Comment explaining Five Stars ratings given to journal artice relating to machine-readable metadata.
    /// <see href="http://purl.org/spar/fivestars/machine-readableMetadataRatingComment"></see></summary>
    let ``machine-readableMetadataRatingComment`` =
        _prefix "machine-readableMetadataRatingComment"

    /// <summary>
    /// Comment explaining Five Stars ratings given to journal artice relating to open access.
    /// <see href="http://purl.org/spar/fivestars/openAccessRatingComment"></see></summary>
    let openAccessRatingComment = _prefix "openAccessRatingComment"
    /// <summary>
    /// Comment on overall Five Stars rating given to journal artice.
    /// <see href="http://purl.org/spar/fivestars/overallFiveStarsRatingComment"></see></summary>
    let overallFiveStarsRatingComment = _prefix "overallFiveStarsRatingComment"
    /// <summary>
    /// Comment explaining Five Stars ratings given to journal artice relating to peer review.
    /// <see href="http://purl.org/spar/fivestars/peerReviewRatingComment"></see></summary>
    let peerReviewRatingComment = _prefix "peerReviewRatingComment"
