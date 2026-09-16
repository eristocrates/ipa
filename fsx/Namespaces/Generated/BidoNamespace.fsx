#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module bido =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/spar/bido/" "bido"
    let _0_1 = _prefixId.prefix "0-1"
    let _1_3 = _prefixId.prefix "1-3"
    let _10_years_beginning = _prefixId.prefix "10-years-beginning"
    let _15_years_beginning = _prefixId.prefix "15-years-beginning"
    let _19683_59049 = _prefixId.prefix "19683-59049"
    let _2015_07_13 = _prefixId.prefix "2015-07-13"
    let _2026_08_14 = _prefixId.prefix "2026-08-14"
    let _2187_6561 = _prefixId.prefix "2187-6561"
    let _243_729 = _prefixId.prefix "243-729"
    let _27_81 = _prefixId.prefix "27-81"
    let _3_9 = _prefixId.prefix "3-9"
    let _5_years_beginning = _prefixId.prefix "5-years-beginning"
    let _6561_19683 = _prefixId.prefix "6561-19683"
    let _729_2187 = _prefixId.prefix "729-2187"
    let _81_243 = _prefixId.prefix "81-243"
    let _9_27 = _prefixId.prefix "9-27"
    /// <summary>
    ///   <para>rdfs:label : acceleration point</para>
    ///   <para>vann:example :
    ///     :my-research-career-activity a bido:ResearchCareerCategory ;
    ///         bido:hasCurve :my-curve .
    ///
    ///     :my-curve a bido:Curve ;
    ///         bido:hasAccelerationPoint bido:premature-deceleration .
    ///
    ///     bido:premature-deceleration a bido:AccelerationPoint .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The acceleration or deceleration point (none or premature, median, overdue acceleration/deceleration) of the curve, if any.</para>
    ///   <a href="http://purl.org/spar/bido/AccelerationPoint">bido:AccelerationPoint</a>
    /// </summary>
    let AccelerationPoint = _prefixId.prefix "AccelerationPoint"
    /// <summary>
    ///   <para>rdfs:label : bibliometric data^^xsd:stringrdfs:label : bibliometric data</para>
    ///   <para>vann:example :
    ///     :my-bibliometric-data-in-time a bido:BibliometricDataInTime ;
    ///         bido:accordingTo :my-organization ;
    ///         bido:withBibliometricData :my-bibliometric-data .
    ///
    ///     :my-bibliometric-data a bido:BibliometricData .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : Any kind of bibliometric data. In particular, they are organised according two sub-concepts: numeric data and categorial data.^^xsd:stringrdfs:comment : Any kind of bibliometric data. In particular, they are organised according two sub-concepts: numeric data and categorial data.</para>
    ///   <a href="http://purl.org/spar/bido/BibliometricData">bido:BibliometricData</a>
    /// </summary>
    let BibliometricData = _prefixId.prefix "BibliometricData"
    /// <summary>
    ///   <para>rdfs:label : bibliometric data in time^^xsd:stringrdfs:label : bibliometric data in time</para>
    ///   <para>vann:example :
    ///     :my-bibliometric-data-in-time a bido:BibliometricDataInTime ;
    ///         tvc:atTime :my-time-interval ;
    ///         bido:accordingTo :my-organization ;
    ///         bido:withBibliometricData :my-bibliometric-data .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : A particular situation that describes a bibliometric data a person, an article, or any other publication-related entity may have, that can be restricted to a particular time interval.^^xsd:stringrdfs:comment : A particular situation that describes a bibliometric data a person, an article, or any other publication-related entity may have, that can be restricted to a particular time interval.</para>
    ///   <a href="http://purl.org/spar/bido/BibliometricDataInTime">bido:BibliometricDataInTime</a>
    /// </summary>
    let BibliometricDataInTime = _prefixId.prefix "BibliometricDataInTime"
    /// <summary>
    ///   <para>rdfs:label : bibliometric measure^^xsd:stringrdfs:label : bibliometric measure</para>
    ///   <para>vann:example :
    ///     :my-numeric-bibliometric-data a bido:NumericBibliometricData ;
    ///         bido:hasMeasure bido:journal-impact-factor .
    ///
    ///     bido:journal-impact-factor a bido:BibliometricMeasure .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : Any kind of measure related with a bibliometric data (e.g., h-index, e-index, journal impact factor).^^xsd:stringrdfs:comment : Any kind of measure related with a bibliometric data (e.g., h-index, e-index, journal impact factor).</para>
    ///   <a href="http://purl.org/spar/bido/BibliometricMeasure">bido:BibliometricMeasure</a>
    /// </summary>
    let BibliometricMeasure = _prefixId.prefix "BibliometricMeasure"
    /// <summary>
    ///   <para>rdfs:label : categorial bibliometric data</para>
    ///   <para>vann:example :
    ///     :my-person a foaf:Person ;
    ///         bido:holdsBibliometricDataInTime :my-bibliometric-data-in-time .
    ///
    ///     :my-bibliometric-data-in-time a bido:BibliometricDataInTime ;
    ///         bido:accordingTo :my-organization ;
    ///         bido:withBibliometricData :my-categorial-bibliometric-data .
    ///
    ///     :my-categorial-bibliometric-data a bido:CategorialBibliometricData .
    ///     ^^xsd:stringvann:example :
    ///     :my-research-category a bido:ResearchCareerCategory ;
    ///         bido:hasCurve :my-curve ;
    ///         bido:hasSlope :my-slope ;
    ///         bido:hasOrderOfMagnitude bido:243-729 ;
    ///         bido:concernsResearchPeriod bido:5-years-beginning .
    ///
    ///     bido:ResearchCareerCategory rdfs:subClassOf bido:CategorialBibliometricData .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : Categorical information that characterises publication-related entities from a bibliometric point of view.</para>
    ///   <a href="http://purl.org/spar/bido/CategorialBibliometricData">bido:CategorialBibliometricData</a>
    /// </summary>
    let CategorialBibliometricData = _prefixId.prefix "CategorialBibliometricData"
    /// <summary>
    ///   <para>rdfs:label : conference ranking</para>
    ///   <para>vann:example :
    ///     :my-bibliometric-data-in-time a bido:BibliometricDataInTime ;
    ///         tvc:atTime :my-time-interval ;
    ///         bido:accordingTo :my-organization ;
    ///         bido:withBibliometricData bido:core-a .
    ///
    ///     bido:core-a
    ///         bido:isDefinedIn bido:core-conference-ranking .
    ///
    ///     bido:core-conference-ranking a bido:ConferenceRanking .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : A ranking involving conferences that is composed by categories identifying different rankings.</para>
    ///   <a href="http://purl.org/spar/bido/ConferenceRanking">bido:ConferenceRanking</a>
    /// </summary>
    let ConferenceRanking = _prefixId.prefix "ConferenceRanking"
    /// <summary>
    ///   <para>rdfs:label : conference ranking category</para>
    ///   <para>vann:example :
    ///     :my-bibliometric-data-in-time a bido:BibliometricDataInTime ;
    ///         tvc:atTime :my-time-interval ;
    ///         bido:accordingTo :my-organization ;
    ///         bido:withBibliometricData bido:core-a .
    ///
    ///     bido:core-a a bido:ConferenceRankingCategory .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : A category that can be used for ranking a conference according to the related ranking that defines it.</para>
    ///   <a href="http://purl.org/spar/bido/ConferenceRankingCategory">bido:ConferenceRankingCategory</a>
    /// </summary>
    let ConferenceRankingCategory = _prefixId.prefix "ConferenceRankingCategory"
    /// <summary>
    ///   <para>rdfs:label : curve</para>
    ///   <para>vann:example :
    ///     :my-research-career-activity a bido:ResearchCareerCategory ;
    ///         bido:hasCurve :my-curve .
    ///
    ///     :my-curve a bido:Curve ;
    ///         bido:hasTrend bido:increasing ;
    ///         bido:hasAccelerationPoint bido:premature-deceleration .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The specific shape proper to the clusters identified by the algorithm, which is characterised by a trend (flat/increasing/decreasing) and, in the latter two cases, by an acceleration or deceleration point (none or premature, median, overdue acceleration/deceleration).</para>
    ///   <a href="http://purl.org/spar/bido/Curve">bido:Curve</a>
    /// </summary>
    let Curve = _prefixId.prefix "Curve"
    /// <summary>
    ///   <para>rdfs:label : discrete review rating scale</para>
    ///   <para>vann:example :
    ///     :my-bibliometric-data-in-time a bido:BibliometricDataInTime ;
    ///         tvc:atTime :my-time-interval ;
    ///         bido:accordingTo :my-organization ;
    ///         bido:withBibliometricData bido:dis-n2-p2-0 .
    ///
    ///     bido:dis-n2-p2-0
    ///         bido:isDefinedIn bido:dis-n2-p2 .
    ///
    ///     bido:dis-n2-p2 a bido:DiscreteReviewRatingScale .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : A discrete scale defining the rating given by a reviewer for a specific scientific contribution.</para>
    ///   <a href="http://purl.org/spar/bido/DiscreteReviewRatingScale">bido:DiscreteReviewRatingScale</a>
    /// </summary>
    let DiscreteReviewRatingScale = _prefixId.prefix "DiscreteReviewRatingScale"

    /// <summary>
    ///   <para>rdfs:label : discrete reviewer confidence scale</para>
    ///   <para>vann:example :
    ///     :my-bibliometric-data-in-time a bido:BibliometricDataInTime ;
    ///         tvc:atTime :my-time-interval ;
    ///         bido:accordingTo :my-organization ;
    ///         bido:withBibliometricData bido:acl-1-5-acl1 .
    ///
    ///     bido:acl-1-5-acl1 a bido:ReviewerConfidenceValue ;
    ///         bido:isDefinedIn bido:acl-1-5 .
    ///
    ///     bido:acl-1-5 a bido:DiscreteReviewerConfidenceScale .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : A discrete scale defining the confidence of a reviewer for a given topic.</para>
    ///   <a href="http://purl.org/spar/bido/DiscreteReviewerConfidenceScale">bido:DiscreteReviewerConfidenceScale</a>
    /// </summary>
    let DiscreteReviewerConfidenceScale = _prefixId.prefix "DiscreteReviewerConfidenceScale"

    /// <summary>
    ///   <para>rdfs:label : growth</para>
    ///   <para>vann:example :
    ///     :my-research-career-activity a bido:ResearchCareerCategory ;
    ///         bido:hasSlope :my-slope .
    ///
    ///     :my-slope a bido:Slope ;
    ///         bido:hasGrowth bido:logarithmic .
    ///
    ///     bido:logarithmic a bido:Growth .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : A kind of growth - i.e., linear/polynomial/exponential/logarithmic - that can characterise a slope.</para>
    ///   <a href="http://purl.org/spar/bido/Growth">bido:Growth</a>
    /// </summary>
    let Growth = _prefixId.prefix "Growth"
    /// <summary>
    ///   <para>rdfs:label : numeric bibliometric data</para>
    ///   <para>vann:example :
    ///     :my-numeric-bibliometric-data a bido:NumericBibliometricData ;
    ///         bido:hasMeasure bido:journal-impact-factor ;
    ///         bido:hasNumericValue "2.464"^^xsd:float .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : Bibliometric data represented by numbers. Such numeric data are those characterised by a certain integer or float value related to a particular bibliometric measure.</para>
    ///   <a href="http://purl.org/spar/bido/NumericBibliometricData">bido:NumericBibliometricData</a>
    /// </summary>
    let NumericBibliometricData = _prefixId.prefix "NumericBibliometricData"
    /// <summary>
    ///   <para>rdfs:label : order of magnitude</para>
    ///   <para>vann:example :
    ///     :my-research-career-activity a bido:ResearchCareerCategory ;
    ///         bido:hasOrderOfMagnitude bido:243-729 .
    ///
    ///     bido:243-729 a bido:OrderOfMagnitude .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : A categorization of the number of citations received in the considered period according to a uniform model of common-sense estimation, which describes intervals of half-order of magnitude - i.e., “[0,1)”, “[1,3)”, “[3,9)”, “[9,27)”, “[27,81)”, “[81,243)”, “[243,729)”, etc.</para>
    ///   <a href="http://purl.org/spar/bido/OrderOfMagnitude">bido:OrderOfMagnitude</a>
    /// </summary>
    let OrderOfMagnitude = _prefixId.prefix "OrderOfMagnitude"
    /// <summary>
    ///   <para>rdfs:label : peer review type</para>
    ///   <para>vann:example :
    ///     :my-bibliometric-data-in-time a bido:BibliometricDataInTime ;
    ///         tvc:atTime :my-time-interval ;
    ///         bido:accordingTo :my-organization ;
    ///         bido:withBibliometricData bido:double-blind-peer-review .
    ///
    ///     :double-blind-peer-review a bido:PeerReviewType .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : A type of of peer review process, such as 'double-blind' or 'open'.</para>
    ///   <a href="http://purl.org/spar/bido/PeerReviewType">bido:PeerReviewType</a>
    /// </summary>
    let PeerReviewType = _prefixId.prefix "PeerReviewType"
    /// <summary>
    ///   <para>rdfs:label : research career category</para>
    ///   <para>vann:example :
    ///     :my-research-career-activity a bido:ResearchCareerCategory ;
    ///         bido:hasCurve :my-curve ;
    ///         bido:hasSlope :my-slope ;
    ///         bido:hasOrderOfMagnitude bido:243-729 ;
    ///         bido:concernsResearchPeriod bido:5-years-beginning .
    ///
    ///     :my-curve a bido:Curve ;
    ///         bido:hasTrend bido:increasing ;
    ///         bido:hasAccelerationPoint bido:premature-deceleration .
    ///
    ///     :my-slope a bido:Slope ;
    ///         bido:hasStrength bido:low ;
    ///         bido:hasGrowth bido:logarithmic .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : Bibliometric data that includes categories describing the research career of people. Each of such categories is characterised by four specific dimensions: the research period considered, the curve of the choosed citation distribution, the slope of such curve, and the order of magnitude of the citation of such research period.</para>
    ///   <a href="http://purl.org/spar/bido/ResearchCareerCategory">bido:ResearchCareerCategory</a>
    /// </summary>
    let ResearchCareerCategory = _prefixId.prefix "ResearchCareerCategory"
    /// <summary>
    ///   <para>rdfs:label : review rating scale</para>
    ///   <para>vann:example :
    ///     :my-bibliometric-data-in-time a bido:BibliometricDataInTime ;
    ///         tvc:atTime :my-time-interval ;
    ///         bido:accordingTo :my-organization ;
    ///         bido:withBibliometricData :my-review-rating-value .
    ///
    ///     :my-review-rating-value
    ///         bido:isDefinedIn bido:to-5-continuous .
    ///
    ///     bido:to-5-continuous a bido:ReviewRatingScale .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : A scale defining the rating given by a reviewer for a specific scientific contribution.</para>
    ///   <a href="http://purl.org/spar/bido/ReviewRatingScale">bido:ReviewRatingScale</a>
    /// </summary>
    let ReviewRatingScale = _prefixId.prefix "ReviewRatingScale"
    /// <summary>
    ///   <para>rdfs:label : review rating value</para>
    ///   <para>vann:example :
    ///     :my-bibliometric-data-in-time a bido:BibliometricDataInTime ;
    ///         tvc:atTime :my-time-interval ;
    ///         bido:accordingTo :my-organization ;
    ///         bido:withBibliometricData bido:a-r-ts-rejps .
    ///
    ///     bido:a-r-ts-rejps a bido:ReviewRatingValue .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The set of values compliant with a given review rating scale.</para>
    ///   <a href="http://purl.org/spar/bido/ReviewRatingValue">bido:ReviewRatingValue</a>
    /// </summary>
    let ReviewRatingValue = _prefixId.prefix "ReviewRatingValue"
    /// <summary>
    ///   <para>rdfs:label : reviewer confidence scale</para>
    ///   <para>vann:example :
    ///     :my-bibliometric-data-in-time a bido:BibliometricDataInTime ;
    ///         tvc:atTime :my-time-interval ;
    ///         bido:accordingTo :my-organization ;
    ///         bido:withBibliometricData bido:acl-1-5-acl1 .
    ///
    ///     bido:acl-1-5-acl1 a bido:ReviewerConfidenceValue ;
    ///         bido:isDefinedIn bido:acl-1-5 .
    ///
    ///     bido:acl-1-5 a bido:DiscreteReviewerConfidenceScale .
    ///
    ///     bido:DiscreteReviewerConfidenceScale rdfs:subClassOf bido:ReviewerConfidenceScale .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : A scale defining the confidence of a reviewer for a given topic.</para>
    ///   <a href="http://purl.org/spar/bido/ReviewerConfidenceScale">bido:ReviewerConfidenceScale</a>
    /// </summary>
    let ReviewerConfidenceScale = _prefixId.prefix "ReviewerConfidenceScale"
    /// <summary>
    ///   <para>rdfs:label : reviewer confidence value</para>
    ///   <para>vann:example :
    ///     :my-bibliometric-data-in-time a bido:BibliometricDataInTime ;
    ///         tvc:atTime :my-time-interval ;
    ///         bido:accordingTo :my-organization ;
    ///         bido:withBibliometricData bido:ex-null-null .
    ///
    ///     bido:ex-null-null a bido:ReviewerConfidenceValue .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The set of values compliant with a given reviewer confidence scale.</para>
    ///   <a href="http://purl.org/spar/bido/ReviewerConfidenceValue">bido:ReviewerConfidenceValue</a>
    /// </summary>
    let ReviewerConfidenceValue = _prefixId.prefix "ReviewerConfidenceValue"

    /// <summary>
    ///   <para>rdfs:label : scholarly venue management system</para>
    ///   <para>vann:example :
    ///     :my-academic-event a swc:AcademicEvent ;
    ///         bido:holdsBibliometricDataInTime :my-bibliometric-data-in-time .
    ///
    ///     :my-bibliometric-data-in-time a bido:BibliometricDataInTime ;
    ///         tvc:atTime :my-time-interval ;
    ///         bido:accordingTo :my-organization ;
    ///         bido:withBibliometricData bido:conference-management-toolkit .
    ///
    ///     bido:conference-management-toolkit a bido:ScholarlyVenueManagementSystem .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : A venue management system (such as a conference management system, or a journal management system) that can be used for managing scholarly venues.</para>
    ///   <a href="http://purl.org/spar/bido/ScholarlyVenueManagementSystem">bido:ScholarlyVenueManagementSystem</a>
    /// </summary>
    let ScholarlyVenueManagementSystem = _prefixId.prefix "ScholarlyVenueManagementSystem"

    /// <summary>
    ///   <para>rdfs:label : slope</para>
    ///   <para>vann:example :
    ///     :my-research-career-activity a bido:ResearchCareerCategory ;
    ///         bido:hasSlope :my-slope .
    ///
    ///     :my-slope a bido:Slope ;
    ///         bido:hasStrength bido:low ;
    ///         bido:hasGrowth bido:logarithmic .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The slope of a curve, in terms of strength (low/moderate/high) and kind of growth (linear/polynomial/exponential/logarithmic).</para>
    ///   <a href="http://purl.org/spar/bido/Slope">bido:Slope</a>
    /// </summary>
    let Slope = _prefixId.prefix "Slope"
    /// <summary>
    ///   <para>rdfs:label : strength</para>
    ///   <para>vann:example :
    ///     :my-research-career-activity a bido:ResearchCareerCategory ;
    ///         bido:hasSlope :my-slope .
    ///
    ///     :my-slope a bido:Slope ;
    ///         bido:hasStrength bido:low .
    ///
    ///     bido:low a bido:Strength .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : A kind of strength - i.e., low/moderate/high - that can characterise a slope.</para>
    ///   <a href="http://purl.org/spar/bido/Strength">bido:Strength</a>
    /// </summary>
    let Strength = _prefixId.prefix "Strength"
    /// <summary>
    ///   <para>rdfs:label : trend</para>
    ///   <para>vann:example :
    ///     :my-research-career-activity a bido:ResearchCareerCategory ;
    ///         bido:hasCurve :my-curve .
    ///
    ///     :my-curve a bido:Curve ;
    ///         bido:hasTrend bido:increasing .
    ///
    ///     bido:increasing a bido:Trend .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The flat/decreasing/increasing trend characterising the curve.</para>
    ///   <a href="http://purl.org/spar/bido/Trend">bido:Trend</a>
    /// </summary>
    let Trend = _prefixId.prefix "Trend"
    let a_na_wr = _prefixId.prefix "a-na-wr"
    let a_na_wr_app = _prefixId.prefix "a-na-wr-app"
    let a_na_wr_appwr = _prefixId.prefix "a-na-wr-appwr"
    let a_na_wr_napp = _prefixId.prefix "a-na-wr-napp"
    let a_r_ts = _prefixId.prefix "a-r-ts"
    let a_r_ts_acc = _prefixId.prefix "a-r-ts-acc"
    let a_r_ts_majrev = _prefixId.prefix "a-r-ts-majrev"
    let a_r_ts_minrev = _prefixId.prefix "a-r-ts-minrev"
    let a_r_ts_rej = _prefixId.prefix "a-r-ts-rej"
    let a_r_ts_rejps = _prefixId.prefix "a-r-ts-rejps"
    let a_r_ts_rejts = _prefixId.prefix "a-r-ts-rejts"
    /// <summary>
    ///   <para>rdfs:label : according to</para>
    ///   <para>vann:example :
    ///     :my-bibliometric-data-in-time a bido:BibliometricDataInTime ;
    ///         bido:accordingTo :my-organization ;
    ///         bido:withBibliometricData :my-numeric-bibliometric-data .
    ///
    ///     :my-organization a prov:Agent .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between a bibliometric data in time situation and an agent who provided such data.</para>
    ///   <a href="http://purl.org/spar/bido/accordingTo">bido:accordingTo</a>
    /// </summary>
    let accordingTo = _prefixId.prefix "accordingTo"
    let acl_1_5 = _prefixId.prefix "acl-1-5"
    let acl_1_5_acl1 = _prefixId.prefix "acl-1-5-acl1"
    let acl_1_5_acl2 = _prefixId.prefix "acl-1-5-acl2"
    let acl_1_5_acl3 = _prefixId.prefix "acl-1-5-acl3"
    let acl_1_5_acl4 = _prefixId.prefix "acl-1-5-acl4"
    let acl_1_5_acl5 = _prefixId.prefix "acl-1-5-acl5"
    let author_citation_count = _prefixId.prefix "author-citation-count"
    let average_of_reviews_per_paper = _prefixId.prefix "average-of-reviews-per-paper"
    /// <summary>
    ///   <para>rdfs:label : concerns research period</para>
    ///   <para>vann:example :
    ///     :my-research-category a bido:ResearchCareerCategory ;
    ///         bido:concernsResearchPeriod bido:5-years-beginning .
    ///
    ///     bido:5-years-beginning a time:Interval .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between a research career category and the research period that caracterises it.</para>
    ///   <a href="http://purl.org/spar/bido/concernsResearchPeriod">bido:concernsResearchPeriod</a>
    /// </summary>
    let concernsResearchPeriod = _prefixId.prefix "concernsResearchPeriod"
    let conference_management_toolkit = _prefixId.prefix "conference-management-toolkit"
    let core_a = _prefixId.prefix "core-a"
    let core_a_star = _prefixId.prefix "core-a-star"
    let core_b = _prefixId.prefix "core-b"
    let core_c = _prefixId.prefix "core-c"
    let core_conference_ranking = _prefixId.prefix "core-conference-ranking"
    let core_unranked = _prefixId.prefix "core-unranked"
    let decreasing = _prefixId.prefix "decreasing"
    let demo_paper_accepted = _prefixId.prefix "demo-paper-accepted"
    let dis_0_10 = _prefixId.prefix "dis-0-10"
    let dis_0_10_0 = _prefixId.prefix "dis-0-10-0"
    let dis_0_10_1 = _prefixId.prefix "dis-0-10-1"
    let dis_0_10_10 = _prefixId.prefix "dis-0-10-10"
    let dis_0_10_2 = _prefixId.prefix "dis-0-10-2"
    let dis_0_10_3 = _prefixId.prefix "dis-0-10-3"
    let dis_0_10_4 = _prefixId.prefix "dis-0-10-4"
    let dis_0_10_5 = _prefixId.prefix "dis-0-10-5"
    let dis_0_10_6 = _prefixId.prefix "dis-0-10-6"
    let dis_0_10_7 = _prefixId.prefix "dis-0-10-7"
    let dis_0_10_8 = _prefixId.prefix "dis-0-10-8"
    let dis_0_10_9 = _prefixId.prefix "dis-0-10-9"
    let dis_0_5 = _prefixId.prefix "dis-0-5"
    let dis_0_5_0 = _prefixId.prefix "dis-0-5-0"
    let dis_0_5_1 = _prefixId.prefix "dis-0-5-1"
    let dis_0_5_2 = _prefixId.prefix "dis-0-5-2"
    let dis_0_5_3 = _prefixId.prefix "dis-0-5-3"
    let dis_0_5_4 = _prefixId.prefix "dis-0-5-4"
    let dis_0_5_5 = _prefixId.prefix "dis-0-5-5"
    let dis_n2_p2 = _prefixId.prefix "dis-n2-p2"
    let dis_n2_p2_0 = _prefixId.prefix "dis-n2-p2-0"
    let dis_n2_p2_neg1 = _prefixId.prefix "dis-n2-p2-neg1"
    let dis_n2_p2_neg2 = _prefixId.prefix "dis-n2-p2-neg2"
    let dis_n2_p2_pos1 = _prefixId.prefix "dis-n2-p2-pos1"
    let dis_n2_p2_pos2 = _prefixId.prefix "dis-n2-p2-pos2"
    let double_blind_peer_review = _prefixId.prefix "double-blind-peer-review"
    let e_index = _prefixId.prefix "e-index"
    let easychair = _prefixId.prefix "easychair"
    let ex_null = _prefixId.prefix "ex-null"
    let ex_null_exp = _prefixId.prefix "ex-null-exp"
    let ex_null_high = _prefixId.prefix "ex-null-high"
    let ex_null_low = _prefixId.prefix "ex-null-low"
    let ex_null_med = _prefixId.prefix "ex-null-med"
    let ex_null_null = _prefixId.prefix "ex-null-null"
    let exponential = _prefixId.prefix "exponential"
    let external_reviewers_involved = _prefixId.prefix "external-reviewers-involved"
    let flat = _prefixId.prefix "flat"
    let full_papers_accepted = _prefixId.prefix "full-papers-accepted"
    let h_index = _prefixId.prefix "h-index"
    /// <summary>
    ///   <para>rdfs:label : has acceleration point^^xsd:string</para>
    ///   <para>vann:example :
    ///     :my-research-category a bido:ResearchCareerCategory ;
    ///         bido:hasCurve :my-curve .
    ///
    ///     :my-curve a bido:Curve ;
    ///         bido:hasAccelerationPoint bido:premature-deceleration .
    ///
    ///     bido:premature-deceleration a bido:AccelerationPoint .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between a curve and its acceleration point.^^xsd:string</para>
    ///   <a href="http://purl.org/spar/bido/hasAccelerationPoint">bido:hasAccelerationPoint</a>
    /// </summary>
    let hasAccelerationPoint = _prefixId.prefix "hasAccelerationPoint"
    /// <summary>
    ///   <para>rdfs:label : has confidence value</para>
    ///   <para>vann:example :
    ///     :my-bibliometric-data-in-time a bido:BibliometricDataInTime ;
    ///         tvc:atTime :my-time-interval ;
    ///         bido:accordingTo :my-organization ;
    ///         bido:withBibliometricData bido:acl-1-5-acl1 .
    ///
    ///     bido:acl-1-5-acl1 a bido:ReviewerConfidenceValue ;
    ///         bido:hasConfidenceValue "1"^^xsd:int .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The confidence value of expertise in the review topic given by the reviwer.</para>
    ///   <a href="http://purl.org/spar/bido/hasConfidenceValue">bido:hasConfidenceValue</a>
    /// </summary>
    let hasConfidenceValue = _prefixId.prefix "hasConfidenceValue"
    /// <summary>
    ///   <para>rdfs:label : has curve</para>
    ///   <para>vann:example :
    ///     :my-research-category a bido:ResearchCareerCategory ;
    ///         bido:hasCurve :my-curve .
    ///
    ///     :my-curve a bido:Curve ;
    ///         bido:hasTrend bido:increasing ;
    ///         bido:hasAccelerationPoint bido:premature-deceleration .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between a research career category and the curve that characterises it.</para>
    ///   <a href="http://purl.org/spar/bido/hasCurve">bido:hasCurve</a>
    /// </summary>
    let hasCurve = _prefixId.prefix "hasCurve"
    /// <summary>
    ///   <para>rdfs:label : has growth</para>
    ///   <para>vann:example :
    ///     :my-research-category a bido:ResearchCareerCategory ;
    ///         bido:hasSlope :my-slope .
    ///
    ///     :my-slope a bido:Slope ;
    ///         bido:hasGrowth bido:exponential .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between the slope and the related growth.</para>
    ///   <a href="http://purl.org/spar/bido/hasGrowth">bido:hasGrowth</a>
    /// </summary>
    let hasGrowth = _prefixId.prefix "hasGrowth"
    /// <summary>
    ///   <para>rdfs:label : has measure^^xsd:stringrdfs:label : has measure</para>
    ///   <para>vann:example :
    ///     :my-numeric-bibliometric-data a bido:NumericBibliometricData ;
    ///         bido:hasMeasure bido:journal-impact-factor .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The kind of measure related with a bibliometric data (e.g., h-index, e-index, journal impact factor).^^xsd:stringrdfs:comment : The relation between some bibliometric data and a measure (e.g., h-index, e-index, journal impact factor).</para>
    ///   <a href="http://purl.org/spar/bido/hasMeasure">bido:hasMeasure</a>
    /// </summary>
    let hasMeasure = _prefixId.prefix "hasMeasure"
    /// <summary>
    ///   <para>rdfs:label : has numeric value</para>
    ///   <para>vann:example :
    ///     :my-numeric-bibliometric-data a bido:NumericBibliometricData ;
    ///         bido:hasNumericValue "2.464"^^xsd:float .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The actual value of the bibliometric data in consideration.</para>
    ///   <a href="http://purl.org/spar/bido/hasNumericValue">bido:hasNumericValue</a>
    /// </summary>
    let hasNumericValue = _prefixId.prefix "hasNumericValue"
    /// <summary>
    ///   <para>rdfs:label : has order of magnitude</para>
    ///   <para>vann:example :
    ///     :my-research-category a bido:ResearchCareerCategory ;
    ///         bido:hasOrderOfMagnitude bido:243-729 .
    ///
    ///     bido:243-729 a bido:OrderOfMagnitude .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between a research career category and the order of magnitude of the citation distribution that characterises it.</para>
    ///   <a href="http://purl.org/spar/bido/hasOrderOfMagnitude">bido:hasOrderOfMagnitude</a>
    /// </summary>
    let hasOrderOfMagnitude = _prefixId.prefix "hasOrderOfMagnitude"
    /// <summary>
    ///   <para>rdfs:label : has rating value</para>
    ///   <para>vann:example :
    ///     :my-bibliometric-data-in-time a bido:BibliometricDataInTime ;
    ///         tvc:atTime :my-time-interval ;
    ///         bido:accordingTo :my-organization ;
    ///         bido:withBibliometricData bido:dis-n2-p2-neg1 .
    ///
    ///     bido:dis-n2-p2-neg1 a bido:ReviewRatingValue ;
    ///         bido:hasRatingValue "-1"^^xsd:int .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The value of the rating given to a review.</para>
    ///   <a href="http://purl.org/spar/bido/hasRatingValue">bido:hasRatingValue</a>
    /// </summary>
    let hasRatingValue = _prefixId.prefix "hasRatingValue"
    /// <summary>
    ///   <para>rdfs:label : has slope</para>
    ///   <para>vann:example :
    ///     :my-research-category a bido:ResearchCareerCategory ;
    ///         bido:hasSlope :my-slope .
    ///
    ///     :my-slope a bido:Slope ;
    ///         bido:hasStrength bido:low ;
    ///         bido:hasGrowth bido:exponential .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between a research career category and the slope of the curve that characterises it.</para>
    ///   <a href="http://purl.org/spar/bido/hasSlope">bido:hasSlope</a>
    /// </summary>
    let hasSlope = _prefixId.prefix "hasSlope"
    /// <summary>
    ///   <para>rdfs:label : has strength</para>
    ///   <para>vann:example :
    ///     :my-research-category a bido:ResearchCareerCategory ;
    ///         bido:hasSlope :my-slope .
    ///
    ///     :my-slope a bido:Slope ;
    ///         bido:hasStrength bido:low .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between the slope and the related strength.</para>
    ///   <a href="http://purl.org/spar/bido/hasStrength">bido:hasStrength</a>
    /// </summary>
    let hasStrength = _prefixId.prefix "hasStrength"
    /// <summary>
    ///   <para>rdfs:label : has trend^^xsd:string</para>
    ///   <para>vann:example :
    ///     :my-research-category a bido:ResearchCareerCategory ;
    ///         bido:hasCurve :my-curve .
    ///
    ///     :my-curve a bido:Curve ;
    ///         bido:hasTrend bido:increasing .
    ///
    ///     bido:increasing a bido:Trend .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between a curve and its trend.^^xsd:string</para>
    ///   <a href="http://purl.org/spar/bido/hasTrend">bido:hasTrend</a>
    /// </summary>
    let hasTrend = _prefixId.prefix "hasTrend"
    let high = _prefixId.prefix "high"
    /// <summary>
    ///   <para>rdfs:label : holds bibliometric data in time^^xsd:stringrdfs:label : holds bibliometric data in time</para>
    ///   <para>vann:example :
    ///     :my-journal a fabio:Journal ;
    ///         bido:holdsBibliometricDataInTime :my-bibliometric-data-in-time .
    ///
    ///     :my-bibliometric-data-in-time a bido:BibliometricDataInTime ;
    ///         bido:accordingTo :my-organization ;
    ///         bido:withBibliometricData :my-numeric-bibliometric-data .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : A relation between a person or any other publication-related entity and bibliometric data that the entity holds. The ontology permits one to specify the time period over which a bibliometric data is held, and the other contextual entities responsible for having provided such bibliometric data.^^xsd:stringrdfs:comment : The relation between a person or any other publication-related entity and bibliometric data that the entity holds. The ontology permits one to specify the time period over which a bibliometric data is held, and the other contextual entities responsible for having provided such bibliometric data.^^xsd:stringrdfs:comment : The relation between a person or any other publication-related entity and bibliometric data that the entity holds.</para>
    ///   <para>skos:note :
    /// The ontology permits one to specify the time period over which a bibliometric data is held, and the other contextual entities responsible for having provided such bibliometric data.
    ///     </para>
    ///   <a href="http://purl.org/spar/bido/holdsBibliometricDataInTime">bido:holdsBibliometricDataInTime</a>
    /// </summary>
    let holdsBibliometricDataInTime = _prefixId.prefix "holdsBibliometricDataInTime"
    let increasing = _prefixId.prefix "increasing"
    /// <summary>
    ///   <para>rdfs:label : is defined in ranking</para>
    ///   <para>vann:example :
    ///     bido:core-a a bido:ConferenceRankingCategory ;
    ///         bido:isDefinedIn bido:core-conference-ranking .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : A relation between a ranking category and the ranking that defines it.</para>
    ///   <a href="http://purl.org/spar/bido/isDefinedIn">bido:isDefinedIn</a>
    /// </summary>
    let isDefinedIn = _prefixId.prefix "isDefinedIn"
    /// <summary>
    ///   <para>rdfs:label : is higher than</para>
    ///   <para>vann:example :
    ///     bido:core-a a bido:ConferenceRankingCategory ;
    ///         bido:isHigherThan bido:core-b .
    ///
    ///     bido:core-b a bido:ConferenceRankingCategory .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : A relation between a ranking category and another that is less important.</para>
    ///   <a href="http://purl.org/spar/bido/isHigherThan">bido:isHigherThan</a>
    /// </summary>
    let isHigherThan = _prefixId.prefix "isHigherThan"
    /// <summary>
    ///   <para>rdfs:label : is lower than</para>
    ///   <para>vann:example :
    ///     bido:core-b a bido:ConferenceRankingCategory ;
    ///         bido:isLowerThan bido:core-a .
    ///
    ///     bido:core-a a bido:ConferenceRankingCategory .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : A relation between a ranking category and another that is more important.</para>
    ///   <a href="http://purl.org/spar/bido/isLowerThan">bido:isLowerThan</a>
    /// </summary>
    let isLowerThan = _prefixId.prefix "isLowerThan"
    let journal_impact_factor = _prefixId.prefix "journal-impact-factor"
    let linear = _prefixId.prefix "linear"
    let logarithmic = _prefixId.prefix "logarithmic"
    let low = _prefixId.prefix "low"
    let median_acceleration = _prefixId.prefix "median-acceleration"
    let median_deceleration = _prefixId.prefix "median-deceleration"
    let moderate = _prefixId.prefix "moderate"
    let none = _prefixId.prefix "none"
    let open_peer_review = _prefixId.prefix "open-peer-review"
    let overdue_acceleration = _prefixId.prefix "overdue-acceleration"
    let overdue_deceleration = _prefixId.prefix "overdue-deceleration"
    let polynomial = _prefixId.prefix "polynomial"
    let poster_papers_accepted = _prefixId.prefix "poster-papers-accepted"
    let premature_acceleration = _prefixId.prefix "premature-acceleration"
    let premature_deceleration = _prefixId.prefix "premature-deceleration"
    let sa_sr_bl = _prefixId.prefix "sa-sr-bl"
    let sa_sr_bl_acc = _prefixId.prefix "sa-sr-bl-acc"
    let sa_sr_bl_bdl = _prefixId.prefix "sa-sr-bl-bdl"
    let sa_sr_bl_rej = _prefixId.prefix "sa-sr-bl-rej"
    let sa_sr_bl_sacc = _prefixId.prefix "sa-sr-bl-sacc"
    let sa_sr_bl_srej = _prefixId.prefix "sa-sr-bl-srej"
    let sa_sr_bl_wacc = _prefixId.prefix "sa-sr-bl-wacc"
    let sa_sr_bl_wrej = _prefixId.prefix "sa-sr-bl-wrej"
    let sa_sr_nb = _prefixId.prefix "sa-sr-nb"
    let sa_sr_nb_acc = _prefixId.prefix "sa-sr-nb-acc"
    let sa_sr_nb_rej = _prefixId.prefix "sa-sr-nb-rej"
    let sa_sr_nb_sacc = _prefixId.prefix "sa-sr-nb-sacc"
    let sa_sr_nb_srej = _prefixId.prefix "sa-sr-nb-srej"
    let sa_sr_nb_wacc = _prefixId.prefix "sa-sr-nb-wacc"
    let sa_sr_nb_wrej = _prefixId.prefix "sa-sr-nb-wrej"
    let short_papers_accepted = _prefixId.prefix "short-papers-accepted"
    let single_blind_peer_review = _prefixId.prefix "single-blind-peer-review"
    let submissions_sent_for_review = _prefixId.prefix "submissions-sent-for-review"
    let to_10_continuous = _prefixId.prefix "to-10-continuous"
    let to_15_continuous = _prefixId.prefix "to-15-continuous"
    let to_5_continuous = _prefixId.prefix "to-5-continuous"
    /// <summary>
    ///   <para>rdfs:label : with bibliometric data^^xsd:stringrdfs:label : with bibliometric data</para>
    ///   <para>vann:example :
    ///     :my-journal a fabio:Journal ;
    ///         bido:holdsBibliometricDataInTime :my-bibliometric-data-in-time .
    ///
    ///     :my-bibliometric-data-in-time a bido:BibliometricDataInTime ;
    ///         bido:accordingTo :my-organization ;
    ///         bido:withBibliometricData :my-numeric-bibliometric-data .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : A relation between an entity's bibliometric data in time and a definition of the type of bibliometric data held by this entity.^^xsd:stringrdfs:comment : The relation between an entity's bibliometric data in time and a definition of the type of bibliometric data held by this entity.^^xsd:stringrdfs:comment : The relation between an entity's bibliometric data in time and a definition of the type of bibliometric data held by this entity.</para>
    ///   <a href="http://purl.org/spar/bido/withBibliometricData">bido:withBibliometricData</a>
    /// </summary>
    let withBibliometricData = _prefixId.prefix "withBibliometricData"
