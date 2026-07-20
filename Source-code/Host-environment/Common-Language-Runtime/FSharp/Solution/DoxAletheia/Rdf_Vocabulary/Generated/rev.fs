namespace http.purl.org.stuff.rev.hash

open DoxAletheia

module rev =
    let _namespace_name = "http://purl.org/stuff/rev#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A comment on a review
    /// <see href="http://purl.org/stuff/rev#Comment"></see></summary>
    let Comment = _prefix "Comment"
    /// <summary>
    /// Feedback on the review. Expresses whether the review was useful or not
    /// <see href="http://purl.org/stuff/rev#Feedback"></see></summary>
    let Feedback = _prefix "Feedback"
    /// <summary>
    /// A review of an work
    /// <see href="http://purl.org/stuff/rev#Review"></see></summary>
    let Review = _prefix "Review"
    /// <summary>
    /// The commenter on the review
    /// <see href="http://purl.org/stuff/rev#commenter"></see></summary>
    let commenter = _prefix "commenter"
    /// <summary>
    /// Used to associate a review with a comment on the review
    /// <see href="http://purl.org/stuff/rev#hasComment"></see></summary>
    let hasComment = _prefix "hasComment"
    /// <summary>
    /// Associates a review with a feedback on the review
    /// <see href="http://purl.org/stuff/rev#hasFeedback"></see></summary>
    let hasFeedback = _prefix "hasFeedback"
    /// <summary>
    /// Associates a work with a a review
    /// <see href="http://purl.org/stuff/rev#hasReview"></see></summary>
    let hasReview = _prefix "hasReview"
    /// <summary>
    /// A numeric value
    /// <see href="http://purl.org/stuff/rev#maxRating"></see></summary>
    let maxRating = _prefix "maxRating"
    /// <summary>
    /// A numeric value
    /// <see href="http://purl.org/stuff/rev#minRating"></see></summary>
    let minRating = _prefix "minRating"
    /// <summary>
    /// Number of positive usefulness votes (integer)
    /// <see href="http://purl.org/stuff/rev#positiveVotes"></see></summary>
    let positiveVotes = _prefix "positiveVotes"
    /// <summary>
    /// A numeric value
    /// <see href="http://purl.org/stuff/rev#rating"></see></summary>
    let rating = _prefix "rating"
    /// <summary>
    /// The person that has written the review
    /// <see href="http://purl.org/stuff/rev#reviewer"></see></summary>
    let reviewer = _prefix "reviewer"
    /// <summary>
    /// The text of the review
    /// <see href="http://purl.org/stuff/rev#text"></see></summary>
    let text = _prefix "text"
    /// <summary>
    /// The title of the review
    /// <see href="http://purl.org/stuff/rev#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// Number of usefulness votes (integer)
    /// <see href="http://purl.org/stuff/rev#totalVotes"></see></summary>
    let totalVotes = _prefix "totalVotes"
    /// <summary>
    /// The type of media of a work under review
    /// <see href="http://purl.org/stuff/rev#type"></see></summary>
    let type_ = _prefix "type"
