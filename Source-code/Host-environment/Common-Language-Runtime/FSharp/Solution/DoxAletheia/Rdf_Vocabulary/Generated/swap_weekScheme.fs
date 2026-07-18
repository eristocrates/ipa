namespace http.eulersharp.sourceforge.net._2003._03swap.weekScheme.hash

open DoxAletheia.Rdf_Vocabulary

module swap_weekScheme =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/weekScheme#"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/weekScheme#Day"></see>
    /// </summary>
    let Day = Namespaced_IRI.parse _namespace_name "Day" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/weekScheme#Duty"></see>
    /// </summary>
    let Duty = Namespaced_IRI.parse _namespace_name "Duty" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/weekScheme#hasDayEnd"></see>
    /// </summary>
    let hasDayEnd = Namespaced_IRI.parse _namespace_name "hasDayEnd" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/weekScheme#hasDayStart"></see>
    /// </summary>
    let hasDayStart =
        Namespaced_IRI.parse _namespace_name "hasDayStart" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/weekScheme#hasDutyEnd"></see>
    /// </summary>
    let hasDutyEnd = Namespaced_IRI.parse _namespace_name "hasDutyEnd" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/weekScheme#hasDutyStart"></see>
    /// </summary>
    let hasDutyStart =
        Namespaced_IRI.parse _namespace_name "hasDutyStart" |> NamespacedName
