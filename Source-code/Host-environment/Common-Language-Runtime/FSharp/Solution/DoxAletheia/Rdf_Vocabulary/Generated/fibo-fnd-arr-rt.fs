namespace https.spec.edmcouncil.org.fibo.ontology.FND.Arrangements.Ratings.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module fibo_fnd_arr_rt =
    let _namespace_iri = Namespace_Iri fibo_fnd_arr_rt |> NamespaceIRI
    /// <summary>
    ///   <para>fibo-fnd-arr-rt:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"Ratings Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/</seealso>
    let _prefix_iri = Prefixed_Name(fibo_fnd_arr_rt, "") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rt:QualitativeRatingScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"qualitative rating score"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/QualitativeRatingScore">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/QualitativeRatingScore</seealso>
    let QualitativeRatingScore =
        Prefixed_Name(fibo_fnd_arr_rt, "QualitativeRatingScore") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rt:QuantitativeRatingScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"quantitative rating score"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/QuantitativeRatingScore">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/QuantitativeRatingScore</seealso>
    let QuantitativeRatingScore =
        Prefixed_Name(fibo_fnd_arr_rt, "QuantitativeRatingScore") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rt:Rating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rating"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/Rating">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/Rating</seealso>
    let Rating = Prefixed_Name(fibo_fnd_arr_rt, "Rating") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-rt:RatingAgency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rating agency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingAgency">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingAgency</seealso>
    let RatingAgency = Prefixed_Name(fibo_fnd_arr_rt, "RatingAgency") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rt:RatingAssessmentActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rating assessment activity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingAssessmentActivity">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingAssessmentActivity</seealso>
    let RatingAssessmentActivity =
        Prefixed_Name(fibo_fnd_arr_rt, "RatingAssessmentActivity") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rt:RatingAssessmentEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rating assessment event"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingAssessmentEvent">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingAssessmentEvent</seealso>
    let RatingAssessmentEvent =
        Prefixed_Name(fibo_fnd_arr_rt, "RatingAssessmentEvent") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rt:RatingIssuer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rating issuer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingIssuer">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingIssuer</seealso>
    let RatingIssuer = Prefixed_Name(fibo_fnd_arr_rt, "RatingIssuer") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-rt:RatingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rating party"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingParty">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingParty</seealso>
    let RatingParty = Prefixed_Name(fibo_fnd_arr_rt, "RatingParty") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-rt:RatingReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rating report"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingReport">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingReport</seealso>
    let RatingReport = Prefixed_Name(fibo_fnd_arr_rt, "RatingReport") |> PrefixedName
    /// <summary>
    ///   <para>fibo-fnd-arr-rt:RatingScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rating scale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingScale">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingScale</seealso>
    let RatingScale = Prefixed_Name(fibo_fnd_arr_rt, "RatingScale") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rt:RatingScalePublisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rating scale publisher"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingScalePublisher">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingScalePublisher</seealso>
    let RatingScalePublisher =
        Prefixed_Name(fibo_fnd_arr_rt, "RatingScalePublisher") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rt:RatingScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"rating score"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingScore">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingScore</seealso>
    let RatingScore = Prefixed_Name(fibo_fnd_arr_rt, "RatingScore") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rt:hasBestMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has best measure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasBestMeasure">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasBestMeasure</seealso>
    let hasBestMeasure =
        Prefixed_Name(fibo_fnd_arr_rt, "hasBestMeasure") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rt:hasMeasureWithinScale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has measure within scale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasMeasureWithinScale">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasMeasureWithinScale</seealso>
    let hasMeasureWithinScale =
        Prefixed_Name(fibo_fnd_arr_rt, "hasMeasureWithinScale") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rt:hasRating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has rating"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasRating">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasRating</seealso>
    let hasRating = Prefixed_Name(fibo_fnd_arr_rt, "hasRating") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rt:hasRatingScore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has rating score"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasRatingScore">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasRatingScore</seealso>
    let hasRatingScore =
        Prefixed_Name(fibo_fnd_arr_rt, "hasRatingScore") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rt:hasWorstMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"has worst measure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasWorstMeasure">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasWorstMeasure</seealso>
    let hasWorstMeasure =
        Prefixed_Name(fibo_fnd_arr_rt, "hasWorstMeasure") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rt:producesRatingsFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"produces ratings for"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/producesRatingsFor">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/producesRatingsFor</seealso>
    let producesRatingsFor =
        Prefixed_Name(fibo_fnd_arr_rt, "producesRatingsFor") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rt:rates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"rates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/rates">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/rates</seealso>
    let rates = Prefixed_Name(fibo_fnd_arr_rt, "rates") |> PrefixedName

    /// <summary>
    ///   <para>fibo-fnd-arr-rt:usesRatingParty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"uses rating performer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/usesRatingParty">https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/usesRatingParty</seealso>
    let usesRatingParty =
        Prefixed_Name(fibo_fnd_arr_rt, "usesRatingParty") |> PrefixedName
