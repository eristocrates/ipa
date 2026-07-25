namespace http.www.w3.org._2000._10.swap.string.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swap_string =
    let _namespace_iri = Namespace_Iri swap_string |> NamespaceIRI
    /// <summary>
    ///   <para>swap_string:concat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>(obsolete - (was backwards!) - use: string:concatenation)</para>
    /// labels<para>is concatenation of</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/string#concat">http://www.w3.org/2000/10/swap/string#concat</seealso>
    let concat = Prefixed_Name(swap_string, "concat") |> PrefixedName
    /// <summary>
    ///   <para>swap_string:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>True iff the subject string contains the object string.</para>
    /// labels<para>contains</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/string#contains">http://www.w3.org/2000/10/swap/string#contains</seealso>
    let contains = Prefixed_Name(swap_string, "contains") |> PrefixedName
    /// <summary>
    ///   <para>swap_string:endsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>True iff the subject string ends with the object string.</para>
    /// labels<para>ends with</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/string#endsWith">http://www.w3.org/2000/10/swap/string#endsWith</seealso>
    let endsWith = Prefixed_Name(swap_string, "endsWith") |> PrefixedName
    /// <summary>
    ///   <para>swap_string:format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The subject is a list, whose first member is a format string,
    ///         and whose remaining members are arguments to the format string.
    ///         The formating string is in the style of python's % operator,
    ///         very similar to C's sprintf().
    ///         The object is calculated from the subject.</para>
    /// labels<para>is the string formatted function of</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/string#format">http://www.w3.org/2000/10/swap/string#format</seealso>
    let format = Prefixed_Name(swap_string, "format") |> PrefixedName

    /// <summary>
    ///   <para>swap_string:equalIgnoringCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>True iff the subject string is the same as object string
    /// ignoring differences between upper and lower case.</para>
    /// labels<para>contains</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/string#equalIgnoringCase">http://www.w3.org/2000/10/swap/string#equalIgnoringCase</seealso>
    let equalIgnoringCase =
        Prefixed_Name(swap_string, "equalIgnoringCase") |> PrefixedName

    /// <summary>
    ///   <para>swap_string:concatenation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The subject is a list of strings. The object is calculated as
    /// 		a concatenation of those strings.</para>
    /// labels<para>is the concatenation of the strings in</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/string#concatenation">http://www.w3.org/2000/10/swap/string#concatenation</seealso>
    let concatenation = Prefixed_Name(swap_string, "concatenation") |> PrefixedName

    /// <summary>
    ///   <para>swap_string:containsIgnoringCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>True iff the subject string contains the object string,
    /// with the comparison done ignoring the difference between upper case and
    /// lower case characters.</para>
    /// labels<para>contains</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/string#containsIgnoringCase">http://www.w3.org/2000/10/swap/string#containsIgnoringCase</seealso>
    let containsIgnoringCase =
        Prefixed_Name(swap_string, "containsIgnoringCase") |> PrefixedName

    /// <summary>
    ///   <para>swap_string:matches</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject is a string;
    /// the object is is a regular expression in the perl, python style.
    /// It is true iff the string matches the regexp.</para>
    /// labels<para>contains</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/string#matches">http://www.w3.org/2000/10/swap/string#matches</seealso>
    let matches = Prefixed_Name(swap_string, "matches") |> PrefixedName
    /// <summary>
    ///   <para>swap_string:greaterThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>True iff the string is greater than the object
    /// 	when ordered according to Unicode(tm) code order.</para>
    /// labels<para>is greater than</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/string#greaterThan">http://www.w3.org/2000/10/swap/string#greaterThan</seealso>
    let greaterThan = Prefixed_Name(swap_string, "greaterThan") |> PrefixedName
    /// <summary>
    ///   <para>swap_string:lessThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>True iff the string is less than the object
    /// 	when ordered according to Unicode(tm) code order.</para>
    /// labels<para>is less than</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/string#lessThan">http://www.w3.org/2000/10/swap/string#lessThan</seealso>
    let lessThan = Prefixed_Name(swap_string, "lessThan") |> PrefixedName
    /// <summary>
    ///   <para>swap_string:notGreaterThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>True iff the string is NOT greater than the object
    /// 	when ordered according to Unicode(tm) code order.</para>
    /// labels<para>is not greater than</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/string#notGreaterThan">http://www.w3.org/2000/10/swap/string#notGreaterThan</seealso>
    let notGreaterThan = Prefixed_Name(swap_string, "notGreaterThan") |> PrefixedName
    /// <summary>
    ///   <para>swap_string:notMatches</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject string;
    /// the object is is a regular expression in the perl, python style.
    /// It is true iff the string does NOT match the regexp.</para>
    /// labels<para>contains</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/string#notMatches">http://www.w3.org/2000/10/swap/string#notMatches</seealso>
    let notMatches = Prefixed_Name(swap_string, "notMatches") |> PrefixedName
    /// <summary>
    ///   <para>swap_string:startsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>True iff the subject string starts with the object string.</para>
    /// labels<para>starts with</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/string#startsWith">http://www.w3.org/2000/10/swap/string#startsWith</seealso>
    let startsWith = Prefixed_Name(swap_string, "startsWith") |> PrefixedName
    /// <summary>
    ///   <para>swap_string:String</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>string</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/string#String">http://www.w3.org/2000/10/swap/string#String</seealso>
    let String = Prefixed_Name(swap_string, "String") |> PrefixedName

    /// <summary>
    ///   <para>swap_string:notEqualIgnoringCase</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>True iff the subject string is the NOT same as object string
    /// ignoring differences between upper and lower case.</para>
    /// labels<para>contains</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/string#notEqualIgnoringCase">http://www.w3.org/2000/10/swap/string#notEqualIgnoringCase</seealso>
    let notEqualIgnoringCase =
        Prefixed_Name(swap_string, "notEqualIgnoringCase") |> PrefixedName

    /// <summary>
    ///   <para>swap_string:notLessThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>True iff the string is NOT less than the object
    /// 	when ordered according to Unicode(tm) code order.</para>
    /// labels<para>is not less than</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/string#notLessThan">http://www.w3.org/2000/10/swap/string#notLessThan</seealso>
    let notLessThan = Prefixed_Name(swap_string, "notLessThan") |> PrefixedName
    /// <summary>
    ///   <para>swap_string:replace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A built-in for replacing characters or sub.
    ///     takes a list of 3 strings; the first is the
    ///     input data, the second the old and the third the new string.
    ///     The object is calculated as the rplaced string.
    ///     For example, ("fofof bar", "of", "baz") string:replace "fbazbaz bar"
    ///     </para>
    /// labels<para>replace</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/string#replace">http://www.w3.org/2000/10/swap/string#replace</seealso>
    let replace = Prefixed_Name(swap_string, "replace") |> PrefixedName
    /// <summary>
    ///   <para>swap_string:scrape</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The subject is a list of two strings. The second string is
    /// a regular expression in the perl, python style.
    /// It must contain one group (a part in parentheses).  If the first string in the list matches
    /// the regular expression, then the object is calculated as being the
    /// part of the first string which matches the group.</para>
    /// labels<para>scrape</para></remarks>
    /// <seealso href="http://www.w3.org/2000/10/swap/string#scrape">http://www.w3.org/2000/10/swap/string#scrape</seealso>
    let scrape = Prefixed_Name(swap_string, "scrape") |> PrefixedName
