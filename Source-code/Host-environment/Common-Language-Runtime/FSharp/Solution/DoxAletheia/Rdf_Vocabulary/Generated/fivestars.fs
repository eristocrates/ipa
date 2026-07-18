namespace http.purl.org.spar.fivestars.slash

open DoxAletheia.Rdf_Vocabulary

module fivestars =
    let _namespace_name = "http://purl.org/spar/fivestars/"

    /// <summary>
    ///   <see href="http://purl.org/spar/fivestars/2012-01-16"></see>
    /// </summary>
    let ``_2012-01-16`` =
        Namespaced_IRI.parse _namespace_name "2012-01-16" |> NamespacedName

    /// <summary>
    /// Comment explaining Five Stars ratings given to journal artice relating to available datasets.
    /// <see href="http://purl.org/spar/fivestars/availableDatasetsRatingComment"></see></summary>
    let availableDatasetsRatingComment =
        Namespaced_IRI.parse _namespace_name "availableDatasetsRatingComment" |> NamespacedName

    /// <summary>
    /// Comment explaining Five Stars ratings given to journal artice relating to enhanced content.
    /// <see href="http://purl.org/spar/fivestars/enhancedContentRatingComment"></see></summary>
    let enhancedContentRatingComment =
        Namespaced_IRI.parse _namespace_name "enhancedContentRatingComment" |> NamespacedName

    /// <summary>
    /// Integer rating (from 0 to 4) given to journal artice for available datasets.
    /// <see href="http://purl.org/spar/fivestars/hasAvailableDatasetsRating"></see></summary>
    let hasAvailableDatasetsRating =
        Namespaced_IRI.parse _namespace_name "hasAvailableDatasetsRating" |> NamespacedName

    /// <summary>
    /// Integer rating (from 0 to 4) given to journal artice for enhanced content.
    /// <see href="http://purl.org/spar/fivestars/hasEnhancedContentRating"></see></summary>
    let hasEnhancedContentRating =
        Namespaced_IRI.parse _namespace_name "hasEnhancedContentRating" |> NamespacedName

    /// <summary>
    /// Integer rating (from 0 to 4) given to journal artice for machine-readable metadata.
    /// <see href="http://purl.org/spar/fivestars/hasMachine-readableMetadataRating"></see></summary>
    let ``hasMachine-readableMetadataRating`` =
        Namespaced_IRI.parse _namespace_name "hasMachine-readableMetadataRating" |> NamespacedName

    /// <summary>
    /// Integer rating (from 0 to 4) given to journal artice for open access.
    /// <see href="http://purl.org/spar/fivestars/hasOpenAccessRating"></see></summary>
    let hasOpenAccessRating =
        Namespaced_IRI.parse _namespace_name "hasOpenAccessRating" |> NamespacedName

    /// <summary>
    /// Overall Five stars rating (on integer scale from from 0 to 20) given to journal artice, obtained by summing the individual ratings given for each of the Five Stars of Online Journal Articles.
    /// <see href="http://purl.org/spar/fivestars/hasOverallFiveStarsRating"></see></summary>
    let hasOverallFiveStarsRating =
        Namespaced_IRI.parse _namespace_name "hasOverallFiveStarsRating" |> NamespacedName

    /// <summary>
    /// Integer rating (from 0 to 4) given to journal artice for peer review.
    /// <see href="http://purl.org/spar/fivestars/hasPeerReviewRating"></see></summary>
    let hasPeerReviewRating =
        Namespaced_IRI.parse _namespace_name "hasPeerReviewRating" |> NamespacedName

    /// <summary>
    /// Comment explaining Five Stars ratings given to journal artice relating to machine-readable metadata.
    /// <see href="http://purl.org/spar/fivestars/machine-readableMetadataRatingComment"></see></summary>
    let ``machine-readableMetadataRatingComment`` =
        Namespaced_IRI.parse _namespace_name "machine-readableMetadataRatingComment" |> NamespacedName

    /// <summary>
    /// Comment explaining Five Stars ratings given to journal artice relating to open access.
    /// <see href="http://purl.org/spar/fivestars/openAccessRatingComment"></see></summary>
    let openAccessRatingComment =
        Namespaced_IRI.parse _namespace_name "openAccessRatingComment" |> NamespacedName

    /// <summary>
    /// Comment on overall Five Stars rating given to journal artice.
    /// <see href="http://purl.org/spar/fivestars/overallFiveStarsRatingComment"></see></summary>
    let overallFiveStarsRatingComment =
        Namespaced_IRI.parse _namespace_name "overallFiveStarsRatingComment" |> NamespacedName

    /// <summary>
    /// Comment explaining Five Stars ratings given to journal artice relating to peer review.
    /// <see href="http://purl.org/spar/fivestars/peerReviewRatingComment"></see></summary>
    let peerReviewRatingComment =
        Namespaced_IRI.parse _namespace_name "peerReviewRatingComment" |> NamespacedName
