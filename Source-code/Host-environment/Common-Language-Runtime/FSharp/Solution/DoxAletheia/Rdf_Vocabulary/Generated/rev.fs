namespace http.purl.org.stuff.rev.hash

open DoxAletheia.Rdf_Vocabulary

module rev =
    let _namespace_name = "http://purl.org/stuff/rev#"
    /// <summary>
    /// A comment on a review
    /// <see href="http://purl.org/stuff/rev#Comment"></see></summary>
    let Comment = Namespaced_IRI.parse _namespace_name "Comment" |> NamespacedName
    /// <summary>
    /// Feedback on the review. Expresses whether the review was useful or not
    /// <see href="http://purl.org/stuff/rev#Feedback"></see></summary>
    let Feedback = Namespaced_IRI.parse _namespace_name "Feedback" |> NamespacedName
    /// <summary>
    /// A review of an work
    /// <see href="http://purl.org/stuff/rev#Review"></see></summary>
    let Review = Namespaced_IRI.parse _namespace_name "Review" |> NamespacedName
    /// <summary>
    /// The commenter on the review
    /// <see href="http://purl.org/stuff/rev#commenter"></see></summary>
    let commenter = Namespaced_IRI.parse _namespace_name "commenter" |> NamespacedName
    /// <summary>
    /// Used to associate a review with a comment on the review
    /// <see href="http://purl.org/stuff/rev#hasComment"></see></summary>
    let hasComment = Namespaced_IRI.parse _namespace_name "hasComment" |> NamespacedName

    /// <summary>
    /// Associates a review with a feedback on the review
    /// <see href="http://purl.org/stuff/rev#hasFeedback"></see></summary>
    let hasFeedback =
        Namespaced_IRI.parse _namespace_name "hasFeedback" |> NamespacedName

    /// <summary>
    /// Associates a work with a a review
    /// <see href="http://purl.org/stuff/rev#hasReview"></see></summary>
    let hasReview = Namespaced_IRI.parse _namespace_name "hasReview" |> NamespacedName
    /// <summary>
    /// A numeric value
    /// <see href="http://purl.org/stuff/rev#maxRating"></see></summary>
    let maxRating = Namespaced_IRI.parse _namespace_name "maxRating" |> NamespacedName
    /// <summary>
    /// A numeric value
    /// <see href="http://purl.org/stuff/rev#minRating"></see></summary>
    let minRating = Namespaced_IRI.parse _namespace_name "minRating" |> NamespacedName

    /// <summary>
    /// Number of positive usefulness votes (integer)
    /// <see href="http://purl.org/stuff/rev#positiveVotes"></see></summary>
    let positiveVotes =
        Namespaced_IRI.parse _namespace_name "positiveVotes" |> NamespacedName

    /// <summary>
    /// A numeric value
    /// <see href="http://purl.org/stuff/rev#rating"></see></summary>
    let rating = Namespaced_IRI.parse _namespace_name "rating" |> NamespacedName
    /// <summary>
    /// The person that has written the review
    /// <see href="http://purl.org/stuff/rev#reviewer"></see></summary>
    let reviewer = Namespaced_IRI.parse _namespace_name "reviewer" |> NamespacedName
    /// <summary>
    /// The text of the review
    /// <see href="http://purl.org/stuff/rev#text"></see></summary>
    let text = Namespaced_IRI.parse _namespace_name "text" |> NamespacedName
    /// <summary>
    /// The title of the review
    /// <see href="http://purl.org/stuff/rev#title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    /// Number of usefulness votes (integer)
    /// <see href="http://purl.org/stuff/rev#totalVotes"></see></summary>
    let totalVotes = Namespaced_IRI.parse _namespace_name "totalVotes" |> NamespacedName
    /// <summary>
    /// The type of media of a work under review
    /// <see href="http://purl.org/stuff/rev#type"></see></summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName
