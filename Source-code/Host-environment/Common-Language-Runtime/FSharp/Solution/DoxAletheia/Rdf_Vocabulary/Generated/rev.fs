namespace http.purl.org.stuff.rev.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rev =
    let _namespace_iri = Namespace_Iri rev |> NamespaceIRI
    /// <summary>
    ///   <para>rev:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>RDF Review Vocabulary</para></remarks>
    /// <seealso href="http://purl.org/stuff/rev#">http://purl.org/stuff/rev#</seealso>
    let _prefix_iri = Prefixed_Name(rev, "") |> PrefixedName
    /// <summary>
    ///   <para>rev:Feedback</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Feedback on the review. Expresses whether the review was useful or not</para>
    /// labels<para>Feedback</para></remarks>
    /// <seealso href="http://purl.org/stuff/rev#Feedback">http://purl.org/stuff/rev#Feedback</seealso>
    let Feedback = Prefixed_Name(rev, "Feedback") |> PrefixedName
    /// <summary>
    ///   <para>rev:Comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A comment on a review</para>
    /// labels<para>Comment</para></remarks>
    /// <seealso href="http://purl.org/stuff/rev#Comment">http://purl.org/stuff/rev#Comment</seealso>
    let Comment = Prefixed_Name(rev, "Comment") |> PrefixedName
    /// <summary>
    ///   <para>rev:Review</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A review of an work</para>
    /// labels<para>Review</para></remarks>
    /// <seealso href="http://purl.org/stuff/rev#Review">http://purl.org/stuff/rev#Review</seealso>
    let Review = Prefixed_Name(rev, "Review") |> PrefixedName
    /// <summary>
    ///   <para>rev:hasComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Used to associate a review with a comment on the review</para>
    /// labels<para>hasComment</para></remarks>
    /// <seealso href="http://purl.org/stuff/rev#hasComment">http://purl.org/stuff/rev#hasComment</seealso>
    let hasComment = Prefixed_Name(rev, "hasComment") |> PrefixedName
    /// <summary>
    ///   <para>rev:hasReview</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Associates a work with a a review</para>
    /// labels<para>has Review</para></remarks>
    /// <seealso href="http://purl.org/stuff/rev#hasReview">http://purl.org/stuff/rev#hasReview</seealso>
    let hasReview = Prefixed_Name(rev, "hasReview") |> PrefixedName
    /// <summary>
    ///   <para>rev:positiveVotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Number of positive usefulness votes (integer)</para>
    /// labels<para>positiveVotes</para></remarks>
    /// <seealso href="http://purl.org/stuff/rev#positiveVotes">http://purl.org/stuff/rev#positiveVotes</seealso>
    let positiveVotes = Prefixed_Name(rev, "positiveVotes") |> PrefixedName
    /// <summary>
    ///   <para>rev:rating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A numeric value</para>
    /// labels<para>rating</para></remarks>
    /// <seealso href="http://purl.org/stuff/rev#rating">http://purl.org/stuff/rev#rating</seealso>
    let rating = Prefixed_Name(rev, "rating") |> PrefixedName
    /// <summary>
    ///   <para>rev:reviewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The person that has written the review</para>
    /// labels<para>reviewer</para></remarks>
    /// <seealso href="http://purl.org/stuff/rev#reviewer">http://purl.org/stuff/rev#reviewer</seealso>
    let reviewer = Prefixed_Name(rev, "reviewer") |> PrefixedName
    /// <summary>
    ///   <para>rev:text</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The text of the review</para>
    /// labels<para>text</para></remarks>
    /// <seealso href="http://purl.org/stuff/rev#text">http://purl.org/stuff/rev#text</seealso>
    let text = Prefixed_Name(rev, "text") |> PrefixedName
    /// <summary>
    ///   <para>rev:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The title of the review</para>
    /// labels<para>title</para></remarks>
    /// <seealso href="http://purl.org/stuff/rev#title">http://purl.org/stuff/rev#title</seealso>
    let title = Prefixed_Name(rev, "title") |> PrefixedName
    /// <summary>
    ///   <para>rev:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The type of media of a work under review</para>
    /// labels<para>type</para></remarks>
    /// <seealso href="http://purl.org/stuff/rev#type">http://purl.org/stuff/rev#type</seealso>
    let type_ = Prefixed_Name(rev, "type") |> PrefixedName
    /// <summary>
    ///   <para>rev:commenter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The commenter on the review</para>
    /// labels<para>commenter</para></remarks>
    /// <seealso href="http://purl.org/stuff/rev#commenter">http://purl.org/stuff/rev#commenter</seealso>
    let commenter = Prefixed_Name(rev, "commenter") |> PrefixedName
    /// <summary>
    ///   <para>rev:hasFeedback</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a review with a feedback on the review</para>
    /// labels<para>hasFeedback</para></remarks>
    /// <seealso href="http://purl.org/stuff/rev#hasFeedback">http://purl.org/stuff/rev#hasFeedback</seealso>
    let hasFeedback = Prefixed_Name(rev, "hasFeedback") |> PrefixedName
    /// <summary>
    ///   <para>rev:maxRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A numeric value</para>
    /// labels<para>max Rating</para></remarks>
    /// <seealso href="http://purl.org/stuff/rev#maxRating">http://purl.org/stuff/rev#maxRating</seealso>
    let maxRating = Prefixed_Name(rev, "maxRating") |> PrefixedName
    /// <summary>
    ///   <para>rev:totalVotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Number of usefulness votes (integer)</para>
    /// labels<para>totalVotes</para></remarks>
    /// <seealso href="http://purl.org/stuff/rev#totalVotes">http://purl.org/stuff/rev#totalVotes</seealso>
    let totalVotes = Prefixed_Name(rev, "totalVotes") |> PrefixedName
    /// <summary>
    ///   <para>rev:minRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A numeric value</para>
    /// labels<para>min Rating</para></remarks>
    /// <seealso href="http://purl.org/stuff/rev#minRating">http://purl.org/stuff/rev#minRating</seealso>
    let minRating = Prefixed_Name(rev, "minRating") |> PrefixedName
