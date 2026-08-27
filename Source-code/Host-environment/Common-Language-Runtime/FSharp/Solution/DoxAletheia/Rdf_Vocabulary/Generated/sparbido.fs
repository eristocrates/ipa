namespace http.purl.org.spar.bido.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sparbido =
    let _namespace_iri = Namespace_Iri sparbido |> NamespaceIRI
    /// <summary>
    ///   <para>sparbido:2015-07-13</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/spar/bido/2015-07-13">http://purl.org/spar/bido/2015-07-13</seealso>
    let _2015_07_13 = Prefixed_Name(sparbido, "2015-07-13") |> PrefixedName

    /// <summary>
    ///   <para>sparbido:DiscreteReviewRatingScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Discrete review reating scale"</para></remarks>
    /// <seealso href="http://purl.org/spar/bido/DiscreteReviewRatingScale">http://purl.org/spar/bido/DiscreteReviewRatingScale</seealso>
    let DiscreteReviewRatingScale =
        Prefixed_Name(sparbido, "DiscreteReviewRatingScale") |> PrefixedName

    /// <summary>
    ///   <para>sparbido:DiscreteReviewerConfidenceScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Discrete reviewer confidence scale"</para></remarks>
    /// <seealso href="http://purl.org/spar/bido/DiscreteReviewerConfidenceScale">http://purl.org/spar/bido/DiscreteReviewerConfidenceScale</seealso>
    let DiscreteReviewerConfidenceScale =
        Prefixed_Name(sparbido, "DiscreteReviewerConfidenceScale") |> PrefixedName

    /// <summary>
    ///   <para>sparbido:ReviewRatingScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Review rating scale"</para></remarks>
    /// <seealso href="http://purl.org/spar/bido/ReviewRatingScale">http://purl.org/spar/bido/ReviewRatingScale</seealso>
    let ReviewRatingScale = Prefixed_Name(sparbido, "ReviewRatingScale") |> PrefixedName
    /// <summary>
    ///   <para>sparbido:ReviewRatingValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The set of values of a given rating scale."</para>
    /// labels<para>"Review rating concept"</para></remarks>
    /// <seealso href="http://purl.org/spar/bido/ReviewRatingValue">http://purl.org/spar/bido/ReviewRatingValue</seealso>
    let ReviewRatingValue = Prefixed_Name(sparbido, "ReviewRatingValue") |> PrefixedName

    /// <summary>
    ///   <para>sparbido:ReviewerConfidenceScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Reviwer confidence scale"</para></remarks>
    /// <seealso href="http://purl.org/spar/bido/ReviewerConfidenceScale">http://purl.org/spar/bido/ReviewerConfidenceScale</seealso>
    let ReviewerConfidenceScale =
        Prefixed_Name(sparbido, "ReviewerConfidenceScale") |> PrefixedName

    /// <summary>
    ///   <para>sparbido:ReviewerConfidenceValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The set of values of a given confidence scale."</para>
    /// labels<para>"Reviewer confidence value"</para></remarks>
    /// <seealso href="http://purl.org/spar/bido/ReviewerConfidenceValue">http://purl.org/spar/bido/ReviewerConfidenceValue</seealso>
    let ReviewerConfidenceValue =
        Prefixed_Name(sparbido, "ReviewerConfidenceValue") |> PrefixedName

    /// <summary>
    ///   <para>sparbido:ScholarlyVenueManagementSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://purl.org/spar/bido/ScholarlyVenueManagementSystem">http://purl.org/spar/bido/ScholarlyVenueManagementSystem</seealso>
    let ScholarlyVenueManagementSystem =
        Prefixed_Name(sparbido, "ScholarlyVenueManagementSystem") |> PrefixedName

    /// <summary>
    ///   <para>sparbido:bido.png</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/spar/bido/bido.png">http://purl.org/spar/bido/bido.png</seealso>
    let ``bido.png`` = Prefixed_Name(sparbido, "bido.png") |> PrefixedName

    /// <summary>
    ///   <para>sparbido:hasConfidenceValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Confidence value of expertise in the review topic given by the reviwer"</para>
    /// labels<para>"has confidence value"</para></remarks>
    /// <seealso href="http://purl.org/spar/bido/hasConfidenceValue">http://purl.org/spar/bido/hasConfidenceValue</seealso>
    let hasConfidenceValue =
        Prefixed_Name(sparbido, "hasConfidenceValue") |> PrefixedName
