#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-arr-rt`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/" "fibo-fnd-arr-rt"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : qualitative rating score^^xsd:string</para>
    ///   <para>skos:definition : rating score that is represented as a qualitative code with respect to some rating scale^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Ratings for the creditworthiness of securities are often qualitative, rather than quantitative, such as a triple-A (i.e., AAA). Many ratings for products and businesses on the Internet are also qualitative, such as 5-star ratings for something.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/QualitativeRatingScore">fibo-fnd-arr-rt:QualitativeRatingScore</a>
    /// </summary>
    let QualitativeRatingScore = _prefixId.prefix "QualitativeRatingScore"
    /// <summary>
    ///   <para>rdfs:label : quantitative rating score^^xsd:string</para>
    ///   <para>skos:definition : rating score that is a simple numeric value on some scale, such as a credit rating for an individual^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/QuantitativeRatingScore">fibo-fnd-arr-rt:QuantitativeRatingScore</a>
    /// </summary>
    let QuantitativeRatingScore = _prefixId.prefix "QuantitativeRatingScore"
    /// <summary>
    ///   <para>rdfs:label : rating^^xsd:string</para>
    ///   <para>skos:definition : standing of something at a particular time, indicated by at least one scores with respect to some scale, based on an assessment by some party^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/Rating">fibo-fnd-arr-rt:Rating</a>
    /// </summary>
    let Rating = _prefixId.prefix "Rating"
    /// <summary>
    ///   <para>rdfs:label : rating agency^^xsd:string</para>
    ///   <para>skos:definition : rating issuer that is also a rating scale publisher, frequently but not always an independent rating service^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingAgency">fibo-fnd-arr-rt:RatingAgency</a>
    /// </summary>
    let RatingAgency = _prefixId.prefix "RatingAgency"
    /// <summary>
    ///   <para>rdfs:label : rating assessment activity^^xsd:string</para>
    ///   <para>skos:definition : assessment activity resulting in a grade or score and potentially a report describing the score and the process used to determine that score^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingAssessmentActivity">fibo-fnd-arr-rt:RatingAssessmentActivity</a>
    /// </summary>
    let RatingAssessmentActivity = _prefixId.prefix "RatingAssessmentActivity"
    /// <summary>
    ///   <para>rdfs:label : rating assessment event^^xsd:string</para>
    ///   <para>skos:definition : individual assessment resulting in a grade or score and potentially a report describing the score^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingAssessmentEvent">fibo-fnd-arr-rt:RatingAssessmentEvent</a>
    /// </summary>
    let RatingAssessmentEvent = _prefixId.prefix "RatingAssessmentEvent"
    /// <summary>
    ///   <para>rdfs:label : rating issuer^^xsd:string</para>
    ///   <para>skos:definition : party that is responsible for issuing ratings^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : A rating issuer is frequently, but not always the rating scale publisher. A rating issuer may delegate responsibility for producing a rating to a rating party.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingIssuer">fibo-fnd-arr-rt:RatingIssuer</a>
    /// </summary>
    let RatingIssuer = _prefixId.prefix "RatingIssuer"
    /// <summary>
    ///   <para>rdfs:label : rating party^^xsd:string</para>
    ///   <para>skos:definition : person, organization or group that analyzes some aspect of something and develops a rating^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingParty">fibo-fnd-arr-rt:RatingParty</a>
    /// </summary>
    let RatingParty = _prefixId.prefix "RatingParty"
    /// <summary>
    ///   <para>rdfs:label : rating report^^xsd:string</para>
    ///   <para>skos:definition : report describing a set of ratings^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingReport">fibo-fnd-arr-rt:RatingReport</a>
    /// </summary>
    let RatingReport = _prefixId.prefix "RatingReport"
    /// <summary>
    ///   <para>rdfs:label : rating scale^^xsd:string</para>
    ///   <para>skos:definition : system for assigning a value to something according to some scale with respect to quality, a standard, or ranking^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingScale">fibo-fnd-arr-rt:RatingScale</a>
    /// </summary>
    let RatingScale = _prefixId.prefix "RatingScale"
    /// <summary>
    ///   <para>rdfs:label : rating scale publisher^^xsd:string</para>
    ///   <para>skos:definition : party responsible for managing one or more rating schemes and potentially publishing ratings based on those schemes^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Rating scale publishers are frequently also rating agencies.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingScalePublisher">fibo-fnd-arr-rt:RatingScalePublisher</a>
    /// </summary>
    let RatingScalePublisher = _prefixId.prefix "RatingScalePublisher"
    /// <summary>
    ///   <para>rdfs:label : rating score^^xsd:string</para>
    ///   <para>skos:definition : grade, classification, or ranking of for something in accordance with some rating scale^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : The meaning and methodology for determining a rating score for the rating of something is determined by a rating issuer. A given rating may apply at some point in time, as a part of a lifecycle or process, or generally. Typically ratings reflect an assessment of a state of affairs at some point in time.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/RatingScore">fibo-fnd-arr-rt:RatingScore</a>
    /// </summary>
    let RatingScore = _prefixId.prefix "RatingScore"
    /// <summary>
    ///   <para>rdfs:label : has best measure^^xsd:string</para>
    ///   <para>skos:definition : indicates the 'best' (most desirable) possible value for a rating score's hasMeasureWithinScale property^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that hasBestMeasure and hasWorstMeasure may be used together to determine the direction and range of a scale's measure values.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasBestMeasure">fibo-fnd-arr-rt:hasBestMeasure</a>
    /// </summary>
    let hasBestMeasure = _prefixId.prefix "hasBestMeasure"
    /// <summary>
    ///   <para>rdfs:label : has measure within scale^^xsd:string</para>
    ///   <para>skos:definition : indicates a relative, numeric measure or ordering on a rating scale^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasMeasureWithinScale">fibo-fnd-arr-rt:hasMeasureWithinScale</a>
    /// </summary>
    let hasMeasureWithinScale = _prefixId.prefix "hasMeasureWithinScale"
    /// <summary>
    ///   <para>rdfs:label : has rating^^xsd:string</para>
    ///   <para>skos:definition : indicates the rating assigned to a thing based on a grade or score according to a particular rating scale^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasRating">fibo-fnd-arr-rt:hasRating</a>
    /// </summary>
    let hasRating = _prefixId.prefix "hasRating"
    /// <summary>
    ///   <para>rdfs:label : has rating score^^xsd:string</para>
    ///   <para>skos:definition : indicates the grade or score associated with a rating with respect to a particular rating scale^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasRatingScore">fibo-fnd-arr-rt:hasRatingScore</a>
    /// </summary>
    let hasRatingScore = _prefixId.prefix "hasRatingScore"
    /// <summary>
    ///   <para>rdfs:label : has worst measure^^xsd:string</para>
    ///   <para>skos:definition : indicates the 'worst' (least desirable) possible value for a rating score's hasMeasureWithinScale property^^xsd:string</para>
    ///   <para>cmns-av:explanatoryNote : Note that hasBestMeasure and hasWorstMeasure may be used together to determine the direction and range of a scale's measure values.^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/hasWorstMeasure">fibo-fnd-arr-rt:hasWorstMeasure</a>
    /// </summary>
    let hasWorstMeasure = _prefixId.prefix "hasWorstMeasure"
    /// <summary>
    ///   <para>rdfs:label : produces ratings for^^xsd:string</para>
    ///   <para>skos:definition : issuer for which ratings are produced or posted through^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/producesRatingsFor">fibo-fnd-arr-rt:producesRatingsFor</a>
    /// </summary>
    let producesRatingsFor = _prefixId.prefix "producesRatingsFor"
    /// <summary>
    ///   <para>rdfs:label : rates^^xsd:string</para>
    ///   <para>skos:definition : indicates the instrument, party or something else to which a rating applies^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/rates">fibo-fnd-arr-rt:rates</a>
    /// </summary>
    let rates = _prefixId.prefix "rates"
    /// <summary>
    ///   <para>rdfs:label : uses rating performer^^xsd:string</para>
    ///   <para>skos:definition : rating performer an issuer uses to assess ratings^^xsd:string</para>
    ///   <a href="https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/usesRatingParty">fibo-fnd-arr-rt:usesRatingParty</a>
    /// </summary>
    let usesRatingParty = _prefixId.prefix "usesRatingParty"
