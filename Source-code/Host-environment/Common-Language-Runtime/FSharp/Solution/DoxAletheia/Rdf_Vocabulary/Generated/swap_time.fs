namespace http.eulersharp.sourceforge.net._2003._03swap.time.hash

open DoxAletheia.Rdf_Vocabulary

module swap_time =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/time#"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#after"></see>
    /// </summary>
    let after = Namespaced_IRI.parse _namespace_name "after" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#timeRelatedTo"></see>
    /// </summary>
    let timeRelatedTo =
        Namespaced_IRI.parse _namespace_name "timeRelatedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#before"></see>
    /// </summary>
    let before = Namespaced_IRI.parse _namespace_name "before" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#begins"></see>
    /// </summary>
    let begins = Namespaced_IRI.parse _namespace_name "begins" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#beginsAfter"></see>
    /// </summary>
    let beginsAfter =
        Namespaced_IRI.parse _namespace_name "beginsAfter" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#beginsBefore"></see>
    /// </summary>
    let beginsBefore =
        Namespaced_IRI.parse _namespace_name "beginsBefore" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#beginsBeforeEndOf"></see>
    /// </summary>
    let beginsBeforeEndOf =
        Namespaced_IRI.parse _namespace_name "beginsBeforeEndOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#beginsDuring"></see>
    /// </summary>
    let beginsDuring =
        Namespaced_IRI.parse _namespace_name "beginsDuring" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#endsBefore"></see>
    /// </summary>
    let endsBefore = Namespaced_IRI.parse _namespace_name "endsBefore" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#beginsSameAsEndOf"></see>
    /// </summary>
    let beginsSameAsEndOf =
        Namespaced_IRI.parse _namespace_name "beginsSameAsEndOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#endsSameAsBeginningOf"></see>
    /// </summary>
    let endsSameAsBeginningOf =
        Namespaced_IRI.parse _namespace_name "endsSameAsBeginningOf" |> NamespacedName

    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingAfter"></see></summary>
    let calculatingAfter =
        Namespaced_IRI.parse _namespace_name "calculatingAfter" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingAge"></see>
    /// </summary>
    let calculatingAge =
        Namespaced_IRI.parse _namespace_name "calculatingAge" |> NamespacedName

    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingBefore"></see></summary>
    let calculatingBefore =
        Namespaced_IRI.parse _namespace_name "calculatingBefore" |> NamespacedName

    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingBeginsAfter"></see></summary>
    let calculatingBeginsAfter =
        Namespaced_IRI.parse _namespace_name "calculatingBeginsAfter" |> NamespacedName

    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingBeginsBefore"></see></summary>
    let calculatingBeginsBefore =
        Namespaced_IRI.parse _namespace_name "calculatingBeginsBefore" |> NamespacedName

    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule calculating an event's duration in premise and returning the duration.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingDuration"></see></summary>
    let calculatingDuration =
        Namespaced_IRI.parse _namespace_name "calculatingDuration" |> NamespacedName

    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingDuring"></see></summary>
    let calculatingDuring =
        Namespaced_IRI.parse _namespace_name "calculatingDuring" |> NamespacedName

    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingEndsAfter"></see></summary>
    let calculatingEndsAfter =
        Namespaced_IRI.parse _namespace_name "calculatingEndsAfter" |> NamespacedName

    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingEndsBefore"></see></summary>
    let calculatingEndsBefore =
        Namespaced_IRI.parse _namespace_name "calculatingEndsBefore" |> NamespacedName

    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingIncludes"></see></summary>
    let calculatingIncludes =
        Namespaced_IRI.parse _namespace_name "calculatingIncludes" |> NamespacedName

    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingOverlaps"></see></summary>
    let calculatingOverlaps =
        Namespaced_IRI.parse _namespace_name "calculatingOverlaps" |> NamespacedName

    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingSameBeginning"></see></summary>
    let calculatingSameBeginning =
        Namespaced_IRI.parse _namespace_name "calculatingSameBeginning" |> NamespacedName

    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingSameDuration"></see></summary>
    let calculatingSameDuration =
        Namespaced_IRI.parse _namespace_name "calculatingSameDuration" |> NamespacedName

    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingSameEnd"></see></summary>
    let calculatingSameEnd =
        Namespaced_IRI.parse _namespace_name "calculatingSameEnd" |> NamespacedName

    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingSameTime"></see></summary>
    let calculatingSameTime =
        Namespaced_IRI.parse _namespace_name "calculatingSameTime" |> NamespacedName

    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingTakesLessLongThan"></see></summary>
    let calculatingTakesLessLongThan =
        Namespaced_IRI.parse _namespace_name "calculatingTakesLessLongThan" |> NamespacedName

    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingTakesLongerThan"></see></summary>
    let calculatingTakesLongerThan =
        Namespaced_IRI.parse _namespace_name "calculatingTakesLongerThan" |> NamespacedName

    /// <summary>
    /// Used in an N3 rule triple to invoke a backward N3 rule converting a date described by 3 literals to a period described by beginning and end date time, in this way explicitly stating the implicit period of a day margin.
    /// In N3 rules universally quantified variables are declared to pick up the respective values: (?yearLiteral ?monthLiteral ?dayLiteral) time:dateLiteralToPeriod (?beginning ?end).
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#dateLiteralToPeriod"></see></summary>
    let dateLiteralToPeriod =
        Namespaced_IRI.parse _namespace_name "dateLiteralToPeriod" |> NamespacedName

    /// <summary>
    /// Used in a triple to invoke a backward N3 rule converting an xsd:date typed literal to a period described by beginning and end date time, in this way explicitly stating the implicit time period margin.
    /// In N3 rules universally quantified variables are declared to pick up the respective values: ?date time:dateToPeriod (?beginning ?end).
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#dateToPeriod"></see></summary>
    let dateToPeriod =
        Namespaced_IRI.parse _namespace_name "dateToPeriod" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#during"></see>
    /// </summary>
    let during = Namespaced_IRI.parse _namespace_name "during" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#ends"></see>
    /// </summary>
    let ends = Namespaced_IRI.parse _namespace_name "ends" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#endsAfter"></see>
    /// </summary>
    let endsAfter = Namespaced_IRI.parse _namespace_name "endsAfter" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#endsAfterBeginningOf"></see>
    /// </summary>
    let endsAfterBeginningOf =
        Namespaced_IRI.parse _namespace_name "endsAfterBeginningOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#endsDuring"></see>
    /// </summary>
    let endsDuring = Namespaced_IRI.parse _namespace_name "endsDuring" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasAge"></see>
    /// </summary>
    let hasAge = Namespaced_IRI.parse _namespace_name "hasAge" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasAges"></see>
    /// </summary>
    let hasAges = Namespaced_IRI.parse _namespace_name "hasAges" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasBeginDate"></see>
    /// </summary>
    let hasBeginDate =
        Namespaced_IRI.parse _namespace_name "hasBeginDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasBeginningPeriodMargin"></see>
    /// </summary>
    let hasBeginningPeriodMargin =
        Namespaced_IRI.parse _namespace_name "hasBeginningPeriodMargin" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasDate"></see>
    /// </summary>
    let hasDate = Namespaced_IRI.parse _namespace_name "hasDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasDateTime"></see>
    /// </summary>
    let hasDateTime =
        Namespaced_IRI.parse _namespace_name "hasDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasDiagnosingPeriodMargin"></see>
    /// </summary>
    let hasDiagnosingPeriodMargin =
        Namespaced_IRI.parse _namespace_name "hasDiagnosingPeriodMargin" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasDuration"></see>
    /// </summary>
    let hasDuration =
        Namespaced_IRI.parse _namespace_name "hasDuration" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasDurationDescription"></see>
    /// </summary>
    let hasDurationDescription =
        Namespaced_IRI.parse _namespace_name "hasDurationDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasEndDate"></see>
    /// </summary>
    let hasEndDate = Namespaced_IRI.parse _namespace_name "hasEndDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasEndPeriodMargin"></see>
    /// </summary>
    let hasEndPeriodMargin =
        Namespaced_IRI.parse _namespace_name "hasEndPeriodMargin" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasEvaluatingPeriodMargin"></see>
    /// </summary>
    let hasEvaluatingPeriodMargin =
        Namespaced_IRI.parse _namespace_name "hasEvaluatingPeriodMargin" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasExaminingPeriodMargin"></see>
    /// </summary>
    let hasExaminingPeriodMargin =
        Namespaced_IRI.parse _namespace_name "hasExaminingPeriodMargin" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasMedianAge"></see>
    /// </summary>
    let hasMedianAge =
        Namespaced_IRI.parse _namespace_name "hasMedianAge" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasObservingPeriodMargin"></see>
    /// </summary>
    let hasObservingPeriodMargin =
        Namespaced_IRI.parse _namespace_name "hasObservingPeriodMargin" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasObtainingPeriodMargin"></see>
    /// </summary>
    let hasObtainingPeriodMargin =
        Namespaced_IRI.parse _namespace_name "hasObtainingPeriodMargin" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasOutputDateTime"></see>
    /// </summary>
    let hasOutputDateTime =
        Namespaced_IRI.parse _namespace_name "hasOutputDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasPerformingPeriodMargin"></see>
    /// </summary>
    let hasPerformingPeriodMargin =
        Namespaced_IRI.parse _namespace_name "hasPerformingPeriodMargin" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasSameBeginningAs"></see>
    /// </summary>
    let hasSameBeginningAs =
        Namespaced_IRI.parse _namespace_name "hasSameBeginningAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasSameDurationAs"></see>
    /// </summary>
    let hasSameDurationAs =
        Namespaced_IRI.parse _namespace_name "hasSameDurationAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasSameEndAs"></see>
    /// </summary>
    let hasSameEndAs =
        Namespaced_IRI.parse _namespace_name "hasSameEndAs" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasSameTimeAs"></see>
    /// </summary>
    let hasSameTimeAs =
        Namespaced_IRI.parse _namespace_name "hasSameTimeAs" |> NamespacedName

    /// <summary>
    /// A snapshot is an event with coinciding beginning and end.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasSnapshotDate"></see></summary>
    let hasSnapshotDate =
        Namespaced_IRI.parse _namespace_name "hasSnapshotDate" |> NamespacedName

    /// <summary>
    /// A snapshot is an event with coinciding beginning and end.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasSnapshotDateTime"></see></summary>
    let hasSnapshotDateTime =
        Namespaced_IRI.parse _namespace_name "hasSnapshotDateTime" |> NamespacedName

    /// <summary>
    /// Time zone extracted from an xsd:date, xsd:dateTime or xsd:time typed literal with rif builtin functions.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasTimeZone"></see></summary>
    let hasTimeZone =
        Namespaced_IRI.parse _namespace_name "hasTimeZone" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasTreatingPeriodMargin"></see>
    /// </summary>
    let hasTreatingPeriodMargin =
        Namespaced_IRI.parse _namespace_name "hasTreatingPeriodMargin" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#includes"></see>
    /// </summary>
    let includes = Namespaced_IRI.parse _namespace_name "includes" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#overlaps"></see>
    /// </summary>
    let overlaps = Namespaced_IRI.parse _namespace_name "overlaps" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#takesLessLongThan"></see>
    /// </summary>
    let takesLessLongThan =
        Namespaced_IRI.parse _namespace_name "takesLessLongThan" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#takesLongerThan"></see>
    /// </summary>
    let takesLongerThan =
        Namespaced_IRI.parse _namespace_name "takesLongerThan" |> NamespacedName

    /// <summary>
    /// Used in a triple to invoke a backward N3 rule converting a literal to a period described by beginning and end date time, in this way explicitly stating the implicit period of a year margin.
    /// In N3 rules universally quantified variables are declared to pick up the respective values: ?yearLiteral time:yearLiteralToPeriod (?beginning ?end).
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#yearLiteralToPeriod"></see></summary>
    let yearLiteralToPeriod =
        Namespaced_IRI.parse _namespace_name "yearLiteralToPeriod" |> NamespacedName

    /// <summary>
    /// Used in an N3 rule triple to invoke a backward N3 rule converting 2 literals to a period described by beginning and end date time, in this way explicitly stating the implicit period of a month margin.
    /// In N3 rules universally quantified variables are declared to pick up the respective values: (?yearLiteral ?monthLiteral) time:yearMonthLiteralToPeriod (?beginning ?end); at runtime this will generate e.g. subject ("2010" "3") and object (.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#yearMonthLiteralToPeriod"></see></summary>
    let yearMonthLiteralToPeriod =
        Namespaced_IRI.parse _namespace_name "yearMonthLiteralToPeriod" |> NamespacedName
