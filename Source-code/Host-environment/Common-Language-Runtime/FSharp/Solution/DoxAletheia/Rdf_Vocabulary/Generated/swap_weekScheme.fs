namespace http.eulersharp.sourceforge.net._2003._03swap.weekScheme.hash

open DoxAletheia

module swap_weekScheme =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/weekScheme#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/weekScheme#Day"></see>
    /// </summary>
    let Day = _prefix "Day"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/weekScheme#Duty"></see>
    /// </summary>
    let Duty = _prefix "Duty"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/weekScheme#hasDayEnd"></see>
    /// </summary>
    let hasDayEnd = _prefix "hasDayEnd"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/weekScheme#hasDayStart"></see>
    /// </summary>
    let hasDayStart = _prefix "hasDayStart"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/weekScheme#hasDutyEnd"></see>
    /// </summary>
    let hasDutyEnd = _prefix "hasDutyEnd"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/weekScheme#hasDutyStart"></see>
    /// </summary>
    let hasDutyStart = _prefix "hasDutyStart"
