namespace http.www.w3.org._2000._10.swap.string.hash

open DoxAletheia.Rdf_Vocabulary

module string =
    let _namespace_name = "http://www.w3.org/2000/10/swap/string#"
    /// <summary>
    ///   <see href="http://www.w3.org/2000/10/swap/string#String"></see>
    /// </summary>
    let String = Namespaced_IRI.parse _namespace_name "String" |> NamespacedName
    /// <summary>
    /// (obsolete - (was backwards!) - use: string:concatenation)
    /// <see href="http://www.w3.org/2000/10/swap/string#concat"></see></summary>
    let concat = Namespaced_IRI.parse _namespace_name "concat" |> NamespacedName

    /// <summary>
    /// The subject is a list of strings. The object is calculated as
    /// 		a concatenation of those strings.
    /// <see href="http://www.w3.org/2000/10/swap/string#concatenation"></see></summary>
    let concatenation =
        Namespaced_IRI.parse _namespace_name "concatenation" |> NamespacedName

    /// <summary>
    /// True iff the subject string contains the object string.
    /// <see href="http://www.w3.org/2000/10/swap/string#contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName

    /// <summary>
    /// True iff the subject string contains the object string,
    /// with the comparison done ignoring the difference between upper case and
    /// lower case characters.
    /// <see href="http://www.w3.org/2000/10/swap/string#containsIgnoringCase"></see></summary>
    let containsIgnoringCase =
        Namespaced_IRI.parse _namespace_name "containsIgnoringCase" |> NamespacedName

    /// <summary>
    /// True iff the subject string ends with the object string.
    /// <see href="http://www.w3.org/2000/10/swap/string#endsWith"></see></summary>
    let endsWith = Namespaced_IRI.parse _namespace_name "endsWith" |> NamespacedName

    /// <summary>
    /// True iff the subject string is the same as object string
    /// ignoring differences between upper and lower case.
    /// <see href="http://www.w3.org/2000/10/swap/string#equalIgnoringCase"></see></summary>
    let equalIgnoringCase =
        Namespaced_IRI.parse _namespace_name "equalIgnoringCase" |> NamespacedName

    /// <summary>
    /// The subject is a list, whose first member is a format string,
    ///         and whose remaining members are arguments to the format string.
    ///         The formating string is in the style of python's % operator,
    ///         very similar to C's sprintf().
    ///         The object is calculated from the subject.
    /// <see href="http://www.w3.org/2000/10/swap/string#format"></see></summary>
    let format = Namespaced_IRI.parse _namespace_name "format" |> NamespacedName

    /// <summary>
    /// True iff the string is greater than the object
    /// 	when ordered according to Unicode(tm) code order.
    /// <see href="http://www.w3.org/2000/10/swap/string#greaterThan"></see></summary>
    let greaterThan =
        Namespaced_IRI.parse _namespace_name "greaterThan" |> NamespacedName

    /// <summary>
    /// True iff the string is less than the object
    /// 	when ordered according to Unicode(tm) code order.
    /// <see href="http://www.w3.org/2000/10/swap/string#lessThan"></see></summary>
    let lessThan = Namespaced_IRI.parse _namespace_name "lessThan" |> NamespacedName
    /// <summary>
    /// The subject is a string;
    /// the object is is a regular expression in the perl, python style.
    /// It is true iff the string matches the regexp.
    /// <see href="http://www.w3.org/2000/10/swap/string#matches"></see></summary>
    let matches = Namespaced_IRI.parse _namespace_name "matches" |> NamespacedName

    /// <summary>
    /// True iff the subject string is the NOT same as object string
    /// ignoring differences between upper and lower case.
    /// <see href="http://www.w3.org/2000/10/swap/string#notEqualIgnoringCase"></see></summary>
    let notEqualIgnoringCase =
        Namespaced_IRI.parse _namespace_name "notEqualIgnoringCase" |> NamespacedName

    /// <summary>
    /// True iff the string is NOT greater than the object
    /// 	when ordered according to Unicode(tm) code order.
    /// <see href="http://www.w3.org/2000/10/swap/string#notGreaterThan"></see></summary>
    let notGreaterThan =
        Namespaced_IRI.parse _namespace_name "notGreaterThan" |> NamespacedName

    /// <summary>
    /// True iff the string is NOT less than the object
    /// 	when ordered according to Unicode(tm) code order.
    /// <see href="http://www.w3.org/2000/10/swap/string#notLessThan"></see></summary>
    let notLessThan =
        Namespaced_IRI.parse _namespace_name "notLessThan" |> NamespacedName

    /// <summary>
    /// The subject string;
    /// the object is is a regular expression in the perl, python style.
    /// It is true iff the string does NOT match the regexp.
    /// <see href="http://www.w3.org/2000/10/swap/string#notMatches"></see></summary>
    let notMatches = Namespaced_IRI.parse _namespace_name "notMatches" |> NamespacedName
    /// <summary>
    /// A built-in for replacing characters or sub.
    ///     takes a list of 3 strings; the first is the
    ///     input data, the second the old and the third the new string.
    ///     The object is calculated as the rplaced string.
    ///     For example, ("fofof bar", "of", "baz") string:replace "fbazbaz bar"
    ///
    /// <see href="http://www.w3.org/2000/10/swap/string#replace"></see></summary>
    let replace = Namespaced_IRI.parse _namespace_name "replace" |> NamespacedName
    /// <summary>
    /// The subject is a list of two strings. The second string is
    /// a regular expression in the perl, python style.
    /// It must contain one group (a part in parentheses).  If the first string in the list matches
    /// the regular expression, then the object is calculated as being the
    /// part of the first string which matches the group.
    /// <see href="http://www.w3.org/2000/10/swap/string#scrape"></see></summary>
    let scrape = Namespaced_IRI.parse _namespace_name "scrape" |> NamespacedName
    /// <summary>
    /// True iff the subject string starts with the object string.
    /// <see href="http://www.w3.org/2000/10/swap/string#startsWith"></see></summary>
    let startsWith = Namespaced_IRI.parse _namespace_name "startsWith" |> NamespacedName
