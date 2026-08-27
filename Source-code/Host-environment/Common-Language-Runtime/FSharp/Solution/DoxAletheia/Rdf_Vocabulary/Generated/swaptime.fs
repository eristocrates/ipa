namespace http.eulersharp.sourceforge.net._2003._03swap.time.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swaptime =
    let _namespace_iri = Namespace_Iri swaptime |> NamespaceIRI
    /// <summary>
    ///   <para>swaptime:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#">http://eulersharp.sourceforge.net/2003/03swap/time#</seealso>
    let _prefix_iri = Prefixed_Name(swaptime, "") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:after</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#after">http://eulersharp.sourceforge.net/2003/03swap/time#after</seealso>
    let after = Prefixed_Name(swaptime, "after") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:before</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#before">http://eulersharp.sourceforge.net/2003/03swap/time#before</seealso>
    let before = Prefixed_Name(swaptime, "before") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:begins</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#begins">http://eulersharp.sourceforge.net/2003/03swap/time#begins</seealso>
    let begins = Prefixed_Name(swaptime, "begins") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:beginsAfter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#beginsAfter">http://eulersharp.sourceforge.net/2003/03swap/time#beginsAfter</seealso>
    let beginsAfter = Prefixed_Name(swaptime, "beginsAfter") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:beginsBefore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#beginsBefore">http://eulersharp.sourceforge.net/2003/03swap/time#beginsBefore</seealso>
    let beginsBefore = Prefixed_Name(swaptime, "beginsBefore") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:beginsBeforeEndOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#beginsBeforeEndOf">http://eulersharp.sourceforge.net/2003/03swap/time#beginsBeforeEndOf</seealso>
    let beginsBeforeEndOf = Prefixed_Name(swaptime, "beginsBeforeEndOf") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:beginsDuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#beginsDuring">http://eulersharp.sourceforge.net/2003/03swap/time#beginsDuring</seealso>
    let beginsDuring = Prefixed_Name(swaptime, "beginsDuring") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:beginsSameAsEndOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#beginsSameAsEndOf">http://eulersharp.sourceforge.net/2003/03swap/time#beginsSameAsEndOf</seealso>
    let beginsSameAsEndOf = Prefixed_Name(swaptime, "beginsSameAsEndOf") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:calculatingAfter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingAfter">http://eulersharp.sourceforge.net/2003/03swap/time#calculatingAfter</seealso>
    let calculatingAfter = Prefixed_Name(swaptime, "calculatingAfter") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:calculatingAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingAge">http://eulersharp.sourceforge.net/2003/03swap/time#calculatingAge</seealso>
    let calculatingAge = Prefixed_Name(swaptime, "calculatingAge") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:calculatingBefore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingBefore">http://eulersharp.sourceforge.net/2003/03swap/time#calculatingBefore</seealso>
    let calculatingBefore = Prefixed_Name(swaptime, "calculatingBefore") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:calculatingBeginsAfter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingBeginsAfter">http://eulersharp.sourceforge.net/2003/03swap/time#calculatingBeginsAfter</seealso>
    let calculatingBeginsAfter =
        Prefixed_Name(swaptime, "calculatingBeginsAfter") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:calculatingBeginsBefore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingBeginsBefore">http://eulersharp.sourceforge.net/2003/03swap/time#calculatingBeginsBefore</seealso>
    let calculatingBeginsBefore =
        Prefixed_Name(swaptime, "calculatingBeginsBefore") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:calculatingDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Such a triple invokes in an N3 rule a backward N3 rule calculating an event's duration in premise and returning the duration."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingDuration">http://eulersharp.sourceforge.net/2003/03swap/time#calculatingDuration</seealso>
    let calculatingDuration =
        Prefixed_Name(swaptime, "calculatingDuration") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:calculatingDuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingDuring">http://eulersharp.sourceforge.net/2003/03swap/time#calculatingDuring</seealso>
    let calculatingDuring = Prefixed_Name(swaptime, "calculatingDuring") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:calculatingEndsAfter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingEndsAfter">http://eulersharp.sourceforge.net/2003/03swap/time#calculatingEndsAfter</seealso>
    let calculatingEndsAfter =
        Prefixed_Name(swaptime, "calculatingEndsAfter") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:calculatingEndsBefore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingEndsBefore">http://eulersharp.sourceforge.net/2003/03swap/time#calculatingEndsBefore</seealso>
    let calculatingEndsBefore =
        Prefixed_Name(swaptime, "calculatingEndsBefore") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:calculatingIncludes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingIncludes">http://eulersharp.sourceforge.net/2003/03swap/time#calculatingIncludes</seealso>
    let calculatingIncludes =
        Prefixed_Name(swaptime, "calculatingIncludes") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:calculatingOverlaps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingOverlaps">http://eulersharp.sourceforge.net/2003/03swap/time#calculatingOverlaps</seealso>
    let calculatingOverlaps =
        Prefixed_Name(swaptime, "calculatingOverlaps") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:calculatingSameBeginning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingSameBeginning">http://eulersharp.sourceforge.net/2003/03swap/time#calculatingSameBeginning</seealso>
    let calculatingSameBeginning =
        Prefixed_Name(swaptime, "calculatingSameBeginning") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:calculatingSameDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingSameDuration">http://eulersharp.sourceforge.net/2003/03swap/time#calculatingSameDuration</seealso>
    let calculatingSameDuration =
        Prefixed_Name(swaptime, "calculatingSameDuration") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:calculatingSameEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingSameEnd">http://eulersharp.sourceforge.net/2003/03swap/time#calculatingSameEnd</seealso>
    let calculatingSameEnd =
        Prefixed_Name(swaptime, "calculatingSameEnd") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:calculatingSameTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingSameTime">http://eulersharp.sourceforge.net/2003/03swap/time#calculatingSameTime</seealso>
    let calculatingSameTime =
        Prefixed_Name(swaptime, "calculatingSameTime") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:calculatingTakesLessLongThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingTakesLessLongThan">http://eulersharp.sourceforge.net/2003/03swap/time#calculatingTakesLessLongThan</seealso>
    let calculatingTakesLessLongThan =
        Prefixed_Name(swaptime, "calculatingTakesLessLongThan") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:calculatingTakesLongerThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Such a triple invokes in an N3 rule a backward N3 rule checking this time relation for 2 events in premise and returning the triple."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#calculatingTakesLongerThan">http://eulersharp.sourceforge.net/2003/03swap/time#calculatingTakesLongerThan</seealso>
    let calculatingTakesLongerThan =
        Prefixed_Name(swaptime, "calculatingTakesLongerThan") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:dateLiteralToPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used in an N3 rule triple to invoke a backward N3 rule converting a date described by 3 literals to a period described by beginning and end date time, in this way explicitly stating the implicit period of a day margin."</para>
    ///   <para>"In N3 rules universally quantified variables are declared to pick up the respective values: (?yearLiteral ?monthLiteral ?dayLiteral) time:dateLiteralToPeriod (?beginning ?end)."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#dateLiteralToPeriod">http://eulersharp.sourceforge.net/2003/03swap/time#dateLiteralToPeriod</seealso>
    let dateLiteralToPeriod =
        Prefixed_Name(swaptime, "dateLiteralToPeriod") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:dateToPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Used in a triple to invoke a backward N3 rule converting an xsd:date typed literal to a period described by beginning and end date time, in this way explicitly stating the implicit time period margin."</para>
    ///   <para>"In N3 rules universally quantified variables are declared to pick up the respective values: ?date time:dateToPeriod (?beginning ?end)."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#dateToPeriod">http://eulersharp.sourceforge.net/2003/03swap/time#dateToPeriod</seealso>
    let dateToPeriod = Prefixed_Name(swaptime, "dateToPeriod") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:during</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#during">http://eulersharp.sourceforge.net/2003/03swap/time#during</seealso>
    let during = Prefixed_Name(swaptime, "during") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:ends</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#ends">http://eulersharp.sourceforge.net/2003/03swap/time#ends</seealso>
    let ends = Prefixed_Name(swaptime, "ends") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:endsAfter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#endsAfter">http://eulersharp.sourceforge.net/2003/03swap/time#endsAfter</seealso>
    let endsAfter = Prefixed_Name(swaptime, "endsAfter") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:endsAfterBeginningOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#endsAfterBeginningOf">http://eulersharp.sourceforge.net/2003/03swap/time#endsAfterBeginningOf</seealso>
    let endsAfterBeginningOf =
        Prefixed_Name(swaptime, "endsAfterBeginningOf") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:endsBefore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#endsBefore">http://eulersharp.sourceforge.net/2003/03swap/time#endsBefore</seealso>
    let endsBefore = Prefixed_Name(swaptime, "endsBefore") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:endsDuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#endsDuring">http://eulersharp.sourceforge.net/2003/03swap/time#endsDuring</seealso>
    let endsDuring = Prefixed_Name(swaptime, "endsDuring") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:endsSameAsBeginningOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#endsSameAsBeginningOf">http://eulersharp.sourceforge.net/2003/03swap/time#endsSameAsBeginningOf</seealso>
    let endsSameAsBeginningOf =
        Prefixed_Name(swaptime, "endsSameAsBeginningOf") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:hasAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasAge">http://eulersharp.sourceforge.net/2003/03swap/time#hasAge</seealso>
    let hasAge = Prefixed_Name(swaptime, "hasAge") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:hasAges</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasAges">http://eulersharp.sourceforge.net/2003/03swap/time#hasAges</seealso>
    let hasAges = Prefixed_Name(swaptime, "hasAges") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:hasBeginDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasBeginDate">http://eulersharp.sourceforge.net/2003/03swap/time#hasBeginDate</seealso>
    let hasBeginDate = Prefixed_Name(swaptime, "hasBeginDate") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:hasBeginningPeriodMargin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasBeginningPeriodMargin">http://eulersharp.sourceforge.net/2003/03swap/time#hasBeginningPeriodMargin</seealso>
    let hasBeginningPeriodMargin =
        Prefixed_Name(swaptime, "hasBeginningPeriodMargin") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:hasDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasDate">http://eulersharp.sourceforge.net/2003/03swap/time#hasDate</seealso>
    let hasDate = Prefixed_Name(swaptime, "hasDate") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:hasDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasDateTime">http://eulersharp.sourceforge.net/2003/03swap/time#hasDateTime</seealso>
    let hasDateTime = Prefixed_Name(swaptime, "hasDateTime") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:hasDiagnosingPeriodMargin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasDiagnosingPeriodMargin">http://eulersharp.sourceforge.net/2003/03swap/time#hasDiagnosingPeriodMargin</seealso>
    let hasDiagnosingPeriodMargin =
        Prefixed_Name(swaptime, "hasDiagnosingPeriodMargin") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:hasDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasDuration">http://eulersharp.sourceforge.net/2003/03swap/time#hasDuration</seealso>
    let hasDuration = Prefixed_Name(swaptime, "hasDuration") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:hasDurationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasDurationDescription">http://eulersharp.sourceforge.net/2003/03swap/time#hasDurationDescription</seealso>
    let hasDurationDescription =
        Prefixed_Name(swaptime, "hasDurationDescription") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:hasEndDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasEndDate">http://eulersharp.sourceforge.net/2003/03swap/time#hasEndDate</seealso>
    let hasEndDate = Prefixed_Name(swaptime, "hasEndDate") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:hasEndPeriodMargin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasEndPeriodMargin">http://eulersharp.sourceforge.net/2003/03swap/time#hasEndPeriodMargin</seealso>
    let hasEndPeriodMargin =
        Prefixed_Name(swaptime, "hasEndPeriodMargin") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:hasEvaluatingPeriodMargin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasEvaluatingPeriodMargin">http://eulersharp.sourceforge.net/2003/03swap/time#hasEvaluatingPeriodMargin</seealso>
    let hasEvaluatingPeriodMargin =
        Prefixed_Name(swaptime, "hasEvaluatingPeriodMargin") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:hasExaminingPeriodMargin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasExaminingPeriodMargin">http://eulersharp.sourceforge.net/2003/03swap/time#hasExaminingPeriodMargin</seealso>
    let hasExaminingPeriodMargin =
        Prefixed_Name(swaptime, "hasExaminingPeriodMargin") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:hasMedianAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasMedianAge">http://eulersharp.sourceforge.net/2003/03swap/time#hasMedianAge</seealso>
    let hasMedianAge = Prefixed_Name(swaptime, "hasMedianAge") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:hasObservingPeriodMargin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasObservingPeriodMargin">http://eulersharp.sourceforge.net/2003/03swap/time#hasObservingPeriodMargin</seealso>
    let hasObservingPeriodMargin =
        Prefixed_Name(swaptime, "hasObservingPeriodMargin") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:hasObtainingPeriodMargin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasObtainingPeriodMargin">http://eulersharp.sourceforge.net/2003/03swap/time#hasObtainingPeriodMargin</seealso>
    let hasObtainingPeriodMargin =
        Prefixed_Name(swaptime, "hasObtainingPeriodMargin") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:hasOutputDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasOutputDateTime">http://eulersharp.sourceforge.net/2003/03swap/time#hasOutputDateTime</seealso>
    let hasOutputDateTime = Prefixed_Name(swaptime, "hasOutputDateTime") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:hasPerformingPeriodMargin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasPerformingPeriodMargin">http://eulersharp.sourceforge.net/2003/03swap/time#hasPerformingPeriodMargin</seealso>
    let hasPerformingPeriodMargin =
        Prefixed_Name(swaptime, "hasPerformingPeriodMargin") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:hasSameBeginningAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasSameBeginningAs">http://eulersharp.sourceforge.net/2003/03swap/time#hasSameBeginningAs</seealso>
    let hasSameBeginningAs =
        Prefixed_Name(swaptime, "hasSameBeginningAs") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:hasSameDurationAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasSameDurationAs">http://eulersharp.sourceforge.net/2003/03swap/time#hasSameDurationAs</seealso>
    let hasSameDurationAs = Prefixed_Name(swaptime, "hasSameDurationAs") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:hasSameEndAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasSameEndAs">http://eulersharp.sourceforge.net/2003/03swap/time#hasSameEndAs</seealso>
    let hasSameEndAs = Prefixed_Name(swaptime, "hasSameEndAs") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:hasSameTimeAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasSameTimeAs">http://eulersharp.sourceforge.net/2003/03swap/time#hasSameTimeAs</seealso>
    let hasSameTimeAs = Prefixed_Name(swaptime, "hasSameTimeAs") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:hasSnapshotDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A snapshot is an event with coinciding beginning and end."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasSnapshotDate">http://eulersharp.sourceforge.net/2003/03swap/time#hasSnapshotDate</seealso>
    let hasSnapshotDate = Prefixed_Name(swaptime, "hasSnapshotDate") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:hasSnapshotDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A snapshot is an event with coinciding beginning and end."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasSnapshotDateTime">http://eulersharp.sourceforge.net/2003/03swap/time#hasSnapshotDateTime</seealso>
    let hasSnapshotDateTime =
        Prefixed_Name(swaptime, "hasSnapshotDateTime") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:hasTimeZone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Time zone extracted from an xsd:date, xsd:dateTime or xsd:time typed literal with rif builtin functions."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasTimeZone">http://eulersharp.sourceforge.net/2003/03swap/time#hasTimeZone</seealso>
    let hasTimeZone = Prefixed_Name(swaptime, "hasTimeZone") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:hasTreatingPeriodMargin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#hasTreatingPeriodMargin">http://eulersharp.sourceforge.net/2003/03swap/time#hasTreatingPeriodMargin</seealso>
    let hasTreatingPeriodMargin =
        Prefixed_Name(swaptime, "hasTreatingPeriodMargin") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:includes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#includes">http://eulersharp.sourceforge.net/2003/03swap/time#includes</seealso>
    let includes = Prefixed_Name(swaptime, "includes") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:overlaps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#overlaps">http://eulersharp.sourceforge.net/2003/03swap/time#overlaps</seealso>
    let overlaps = Prefixed_Name(swaptime, "overlaps") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:takesLessLongThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#takesLessLongThan">http://eulersharp.sourceforge.net/2003/03swap/time#takesLessLongThan</seealso>
    let takesLessLongThan = Prefixed_Name(swaptime, "takesLessLongThan") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:takesLongerThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#takesLongerThan">http://eulersharp.sourceforge.net/2003/03swap/time#takesLongerThan</seealso>
    let takesLongerThan = Prefixed_Name(swaptime, "takesLongerThan") |> PrefixedName
    /// <summary>
    ///   <para>swaptime:timeRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#timeRelatedTo">http://eulersharp.sourceforge.net/2003/03swap/time#timeRelatedTo</seealso>
    let timeRelatedTo = Prefixed_Name(swaptime, "timeRelatedTo") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:yearLiteralToPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In N3 rules universally quantified variables are declared to pick up the respective values: ?yearLiteral time:yearLiteralToPeriod (?beginning ?end)."</para>
    ///   <para>"Used in a triple to invoke a backward N3 rule converting a literal to a period described by beginning and end date time, in this way explicitly stating the implicit period of a year margin."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#yearLiteralToPeriod">http://eulersharp.sourceforge.net/2003/03swap/time#yearLiteralToPeriod</seealso>
    let yearLiteralToPeriod =
        Prefixed_Name(swaptime, "yearLiteralToPeriod") |> PrefixedName

    /// <summary>
    ///   <para>swaptime:yearMonthLiteralToPeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"In N3 rules universally quantified variables are declared to pick up the respective values: (?yearLiteral ?monthLiteral) time:yearMonthLiteralToPeriod (?beginning ?end); at runtime this will generate e.g. subject ("2010" "3") and object (."</para>
    ///   <para>"Used in an N3 rule triple to invoke a backward N3 rule converting 2 literals to a period described by beginning and end date time, in this way explicitly stating the implicit period of a month margin."</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/time#yearMonthLiteralToPeriod">http://eulersharp.sourceforge.net/2003/03swap/time#yearMonthLiteralToPeriod</seealso>
    let yearMonthLiteralToPeriod =
        Prefixed_Name(swaptime, "yearMonthLiteralToPeriod") |> PrefixedName
