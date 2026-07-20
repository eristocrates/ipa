namespace http.eulersharp.sourceforge.net._2003._03swap.time.hash

open DoxAletheia

module swap_time =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/time#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#after"></see>
    /// </summary>
    let after = _prefix "after"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#timeRelatedTo"></see>
    /// </summary>
    let timeRelatedTo = _prefix "timeRelatedTo"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#before"></see>
    /// </summary>
    let before = _prefix "before"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#begins"></see>
    /// </summary>
    let begins = _prefix "begins"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#beginsAfter"></see>
    /// </summary>
    let beginsAfter = _prefix "beginsAfter"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#beginsBefore"></see>
    /// </summary>
    let beginsBefore = _prefix "beginsBefore"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#beginsBeforeEndOf"></see>
    /// </summary>
    let beginsBeforeEndOf = _prefix "beginsBeforeEndOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#beginsDuring"></see>
    /// </summary>
    let beginsDuring = _prefix "beginsDuring"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#endsBefore"></see>
    /// </summary>
    let endsBefore = _prefix "endsBefore"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#beginsSameAsEndOf"></see>
    /// </summary>
    let beginsSameAsEndOf = _prefix "beginsSameAsEndOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#endsSameAsBeginningOf"></see>
    /// </summary>
    let endsSameAsBeginningOf = _prefix "endsSameAsBeginningOf"
    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingAfter"></see></summary>
    let calculatingAfter = _prefix "calculatingAfter"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingAge"></see>
    /// </summary>
    let calculatingAge = _prefix "calculatingAge"
    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingBefore"></see></summary>
    let calculatingBefore = _prefix "calculatingBefore"
    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingBeginsAfter"></see></summary>
    let calculatingBeginsAfter = _prefix "calculatingBeginsAfter"
    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingBeginsBefore"></see></summary>
    let calculatingBeginsBefore = _prefix "calculatingBeginsBefore"
    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule calculating an event's duration in premise and returning the duration.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingDuration"></see></summary>
    let calculatingDuration = _prefix "calculatingDuration"
    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingDuring"></see></summary>
    let calculatingDuring = _prefix "calculatingDuring"
    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingEndsAfter"></see></summary>
    let calculatingEndsAfter = _prefix "calculatingEndsAfter"
    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingEndsBefore"></see></summary>
    let calculatingEndsBefore = _prefix "calculatingEndsBefore"
    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingIncludes"></see></summary>
    let calculatingIncludes = _prefix "calculatingIncludes"
    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingOverlaps"></see></summary>
    let calculatingOverlaps = _prefix "calculatingOverlaps"
    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingSameBeginning"></see></summary>
    let calculatingSameBeginning = _prefix "calculatingSameBeginning"
    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingSameDuration"></see></summary>
    let calculatingSameDuration = _prefix "calculatingSameDuration"
    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingSameEnd"></see></summary>
    let calculatingSameEnd = _prefix "calculatingSameEnd"
    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingSameTime"></see></summary>
    let calculatingSameTime = _prefix "calculatingSameTime"
    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingTakesLessLongThan"></see></summary>
    let calculatingTakesLessLongThan = _prefix "calculatingTakesLessLongThan"
    /// <summary>
    /// Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingTakesLongerThan"></see></summary>
    let calculatingTakesLongerThan = _prefix "calculatingTakesLongerThan"
    /// <summary>
    /// Used in an N3 rule triple to invoke a backward N3 rule converting a date described by 3 literals to a period described by beginning and end date time, in this way explicitly stating the implicit period of a day margin.
    /// In N3 rules universally quantified variables are declared to pick up the respective values: (?yearLiteral ?monthLiteral ?dayLiteral) time:dateLiteralToPeriod (?beginning ?end).
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#dateLiteralToPeriod"></see></summary>
    let dateLiteralToPeriod = _prefix "dateLiteralToPeriod"
    /// <summary>
    /// Used in a triple to invoke a backward N3 rule converting an xsd:date typed literal to a period described by beginning and end date time, in this way explicitly stating the implicit time period margin.
    /// In N3 rules universally quantified variables are declared to pick up the respective values: ?date time:dateToPeriod (?beginning ?end).
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#dateToPeriod"></see></summary>
    let dateToPeriod = _prefix "dateToPeriod"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#during"></see>
    /// </summary>
    let during = _prefix "during"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#ends"></see>
    /// </summary>
    let ends = _prefix "ends"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#endsAfter"></see>
    /// </summary>
    let endsAfter = _prefix "endsAfter"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#endsAfterBeginningOf"></see>
    /// </summary>
    let endsAfterBeginningOf = _prefix "endsAfterBeginningOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#endsDuring"></see>
    /// </summary>
    let endsDuring = _prefix "endsDuring"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasAge"></see>
    /// </summary>
    let hasAge = _prefix "hasAge"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasAges"></see>
    /// </summary>
    let hasAges = _prefix "hasAges"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasBeginDate"></see>
    /// </summary>
    let hasBeginDate = _prefix "hasBeginDate"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasBeginningPeriodMargin"></see>
    /// </summary>
    let hasBeginningPeriodMargin = _prefix "hasBeginningPeriodMargin"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasDate"></see>
    /// </summary>
    let hasDate = _prefix "hasDate"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasDateTime"></see>
    /// </summary>
    let hasDateTime = _prefix "hasDateTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasDiagnosingPeriodMargin"></see>
    /// </summary>
    let hasDiagnosingPeriodMargin = _prefix "hasDiagnosingPeriodMargin"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasDuration"></see>
    /// </summary>
    let hasDuration = _prefix "hasDuration"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasDurationDescription"></see>
    /// </summary>
    let hasDurationDescription = _prefix "hasDurationDescription"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasEndDate"></see>
    /// </summary>
    let hasEndDate = _prefix "hasEndDate"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasEndPeriodMargin"></see>
    /// </summary>
    let hasEndPeriodMargin = _prefix "hasEndPeriodMargin"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasEvaluatingPeriodMargin"></see>
    /// </summary>
    let hasEvaluatingPeriodMargin = _prefix "hasEvaluatingPeriodMargin"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasExaminingPeriodMargin"></see>
    /// </summary>
    let hasExaminingPeriodMargin = _prefix "hasExaminingPeriodMargin"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasMedianAge"></see>
    /// </summary>
    let hasMedianAge = _prefix "hasMedianAge"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasObservingPeriodMargin"></see>
    /// </summary>
    let hasObservingPeriodMargin = _prefix "hasObservingPeriodMargin"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasObtainingPeriodMargin"></see>
    /// </summary>
    let hasObtainingPeriodMargin = _prefix "hasObtainingPeriodMargin"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasOutputDateTime"></see>
    /// </summary>
    let hasOutputDateTime = _prefix "hasOutputDateTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasPerformingPeriodMargin"></see>
    /// </summary>
    let hasPerformingPeriodMargin = _prefix "hasPerformingPeriodMargin"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasSameBeginningAs"></see>
    /// </summary>
    let hasSameBeginningAs = _prefix "hasSameBeginningAs"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasSameDurationAs"></see>
    /// </summary>
    let hasSameDurationAs = _prefix "hasSameDurationAs"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasSameEndAs"></see>
    /// </summary>
    let hasSameEndAs = _prefix "hasSameEndAs"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasSameTimeAs"></see>
    /// </summary>
    let hasSameTimeAs = _prefix "hasSameTimeAs"
    /// <summary>
    /// A snapshot is an event with coinciding beginning and end.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasSnapshotDate"></see></summary>
    let hasSnapshotDate = _prefix "hasSnapshotDate"
    /// <summary>
    /// A snapshot is an event with coinciding beginning and end.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasSnapshotDateTime"></see></summary>
    let hasSnapshotDateTime = _prefix "hasSnapshotDateTime"
    /// <summary>
    /// Time zone extracted from an xsd:date, xsd:dateTime or xsd:time typed literal with rif builtin functions.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasTimeZone"></see></summary>
    let hasTimeZone = _prefix "hasTimeZone"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#hasTreatingPeriodMargin"></see>
    /// </summary>
    let hasTreatingPeriodMargin = _prefix "hasTreatingPeriodMargin"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#includes"></see>
    /// </summary>
    let includes = _prefix "includes"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#overlaps"></see>
    /// </summary>
    let overlaps = _prefix "overlaps"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#takesLessLongThan"></see>
    /// </summary>
    let takesLessLongThan = _prefix "takesLessLongThan"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/time#takesLongerThan"></see>
    /// </summary>
    let takesLongerThan = _prefix "takesLongerThan"
    /// <summary>
    /// Used in a triple to invoke a backward N3 rule converting a literal to a period described by beginning and end date time, in this way explicitly stating the implicit period of a year margin.
    /// In N3 rules universally quantified variables are declared to pick up the respective values: ?yearLiteral time:yearLiteralToPeriod (?beginning ?end).
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#yearLiteralToPeriod"></see></summary>
    let yearLiteralToPeriod = _prefix "yearLiteralToPeriod"
    /// <summary>
    /// Used in an N3 rule triple to invoke a backward N3 rule converting 2 literals to a period described by beginning and end date time, in this way explicitly stating the implicit period of a month margin.
    /// In N3 rules universally quantified variables are declared to pick up the respective values: (?yearLiteral ?monthLiteral) time:yearMonthLiteralToPeriod (?beginning ?end); at runtime this will generate e.g. subject ("2010" "3") and object (.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/time#yearMonthLiteralToPeriod"></see></summary>
    let yearMonthLiteralToPeriod = _prefix "yearMonthLiteralToPeriod"
