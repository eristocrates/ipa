namespace http.purl.org.spar.fr.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sparfr =
    let _namespace_iri = Namespace_Iri sparfr |> NamespaceIRI
    /// <summary>
    ///   <para>sparfr:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/fr/">http://purl.org/spar/fr/</seealso>
    let _prefix_iri = Prefixed_Name(sparfr, "") |> PrefixedName

    /// <summary>
    ///   <para>sparfr:ConveningOrganization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A venue (e.g. conference, workshop), a expression collection (e.g. journal, special issue), or an individual agent (e.g. organization, researcher) collecting scientific contributions."</para>
    /// labels<para>"Convening organization"</para></remarks>
    /// <seealso href="http://purl.org/spar/fr/ConveningOrganization">http://purl.org/spar/fr/ConveningOrganization</seealso>
    let ConveningOrganization =
        Prefixed_Name(sparfr, "ConveningOrganization") |> PrefixedName

    /// <summary>
    ///   <para>sparfr:ReviewVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A version of a given review, defining its content and rating, which may vary over the time ."</para>
    /// labels<para>"Review Version"</para></remarks>
    /// <seealso href="http://purl.org/spar/fr/ReviewVersion">http://purl.org/spar/fr/ReviewVersion</seealso>
    let ReviewVersion = Prefixed_Name(sparfr, "ReviewVersion") |> PrefixedName
    /// <summary>
    ///   <para>sparfr:TrackingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The platform where the review process takes place."</para>
    /// labels<para>"Tracking system"</para></remarks>
    /// <seealso href="http://purl.org/spar/fr/TrackingSystem">http://purl.org/spar/fr/TrackingSystem</seealso>
    let TrackingSystem = Prefixed_Name(sparfr, "TrackingSystem") |> PrefixedName
    /// <summary>
    ///   <para>sparfr:hasRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a review and a given rating assigned by a reviewer."</para>
    /// labels<para>"has rating"</para></remarks>
    /// <seealso href="http://purl.org/spar/fr/hasRating">http://purl.org/spar/fr/hasRating</seealso>
    let hasRating = Prefixed_Name(sparfr, "hasRating") |> PrefixedName

    /// <summary>
    ///   <para>sparfr:hasReviewerConfidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a review the confidence set by the author about the review topic. As the review can be written only by one author the confidence is assumed to be for such author about the given paper without need of creating a new class involving the three actors in a n-ary alike solution."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has reviewer confidence"</para></remarks>
    /// <seealso href="http://purl.org/spar/fr/hasReviewerConfidence">http://purl.org/spar/fr/hasReviewerConfidence</seealso>
    let hasReviewerConfidence =
        Prefixed_Name(sparfr, "hasReviewerConfidence") |> PrefixedName

    /// <summary>
    ///   <para>sparfr:hasSubReviewer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a review and agents that have contributed to the overall review as sub-reviwers."</para>
    /// labels<para>"has sub-reviewer"</para></remarks>
    /// <seealso href="http://purl.org/spar/fr/hasSubReviewer">http://purl.org/spar/fr/hasSubReviewer</seealso>
    let hasSubReviewer = Prefixed_Name(sparfr, "hasSubReviewer") |> PrefixedName
    /// <summary>
    ///   <para>sparfr:issuedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a review and the tracking or scholarly venue management system where the reviewing process took place."</para>
    /// labels<para>"issued at"</para></remarks>
    /// <seealso href="http://purl.org/spar/fr/issuedAt">http://purl.org/spar/fr/issuedAt</seealso>
    let issuedAt = Prefixed_Name(sparfr, "issuedAt") |> PrefixedName
    /// <summary>
    ///   <para>sparfr:issuedFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The realation between a review and the entity (e.g. conference, journal) that it was issued for (usually the one that requested the review)."</para>
    /// labels<para>"issued for"</para></remarks>
    /// <seealso href="http://purl.org/spar/fr/issuedFor">http://purl.org/spar/fr/issuedFor</seealso>
    let issuedFor = Prefixed_Name(sparfr, "issuedFor") |> PrefixedName
    /// <summary>
    ///   <para>sparfr:ratingValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Numerical value of the rating given to a review."</para>
    /// labels<para>"rating value"</para></remarks>
    /// <seealso href="http://purl.org/spar/fr/ratingValue">http://purl.org/spar/fr/ratingValue</seealso>
    let ratingValue = Prefixed_Name(sparfr, "ratingValue") |> PrefixedName
    /// <summary>
    ///   <para>sparfr:releasedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between the review and the agent publishing it. It might be the the author of the review or conference or journal to which the scientific resource was submitted to."</para>
    /// labels<para>"released by"</para></remarks>
    /// <seealso href="http://purl.org/spar/fr/releasedBy">http://purl.org/spar/fr/releasedBy</seealso>
    let releasedBy = Prefixed_Name(sparfr, "releasedBy") |> PrefixedName
