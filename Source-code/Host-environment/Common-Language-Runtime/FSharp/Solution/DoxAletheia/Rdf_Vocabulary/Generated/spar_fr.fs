namespace http.purl.org.spar.fr.slash

open DoxAletheia.Rdf_Vocabulary

module spar_fr =
    let _namespace_name = "http://purl.org/spar/fr/"

    /// <summary>
    /// A venue (e.g. conference, workshop), a expression collection (e.g. journal, special issue), or an individual agent (e.g. organization, researcher) collecting scientific contributions.
    /// <see href="http://purl.org/spar/fr/ConveningOrganization"></see></summary>
    let ConveningOrganization =
        Namespaced_IRI.parse _namespace_name "ConveningOrganization" |> NamespacedName

    /// <summary>
    /// A version of a given review, defining its content and rating, which may vary over the time .
    /// <see href="http://purl.org/spar/fr/ReviewVersion"></see></summary>
    let ReviewVersion =
        Namespaced_IRI.parse _namespace_name "ReviewVersion" |> NamespacedName

    /// <summary>
    /// The platform where the review process takes place.
    /// <see href="http://purl.org/spar/fr/TrackingSystem"></see></summary>
    let TrackingSystem =
        Namespaced_IRI.parse _namespace_name "TrackingSystem" |> NamespacedName

    /// <summary>
    /// The relation between a review and a given rating assigned by a reviewer.
    /// <see href="http://purl.org/spar/fr/hasRating"></see></summary>
    let hasRating = Namespaced_IRI.parse _namespace_name "hasRating" |> NamespacedName

    /// <summary>
    /// Relation between a review the confidence set by the author about the review topic. As the review can be written only by one author the confidence is assumed to be for such author about the given paper without need of creating a new class involving the three actors in a n-ary alike solution.
    /// <see href="http://purl.org/spar/fr/hasReviewerConfidence"></see></summary>
    let hasReviewerConfidence =
        Namespaced_IRI.parse _namespace_name "hasReviewerConfidence" |> NamespacedName

    /// <summary>
    /// The relation between a review and agents that have contributed to the overall review as sub-reviwers.
    /// <see href="http://purl.org/spar/fr/hasSubReviewer"></see></summary>
    let hasSubReviewer =
        Namespaced_IRI.parse _namespace_name "hasSubReviewer" |> NamespacedName

    /// <summary>
    /// The relation between a review and the tracking or scholarly venue management system where the reviewing process took place.
    /// <see href="http://purl.org/spar/fr/issuedAt"></see></summary>
    let issuedAt = Namespaced_IRI.parse _namespace_name "issuedAt" |> NamespacedName
    /// <summary>
    /// The realation between a review and the entity (e.g. conference, journal) that it was issued for (usually the one that requested the review).
    /// <see href="http://purl.org/spar/fr/issuedFor"></see></summary>
    let issuedFor = Namespaced_IRI.parse _namespace_name "issuedFor" |> NamespacedName

    /// <summary>
    /// Numerical value of the rating given to a review.
    /// <see href="http://purl.org/spar/fr/ratingValue"></see></summary>
    let ratingValue =
        Namespaced_IRI.parse _namespace_name "ratingValue" |> NamespacedName

    /// <summary>
    /// The relation between the review and the agent publishing it. It might be the the author of the review or conference or journal to which the scientific resource was submitted to.
    /// <see href="http://purl.org/spar/fr/releasedBy"></see></summary>
    let releasedBy = Namespaced_IRI.parse _namespace_name "releasedBy" |> NamespacedName
