namespace http.eulersharp.sourceforge.net._2003._03swap.care.hash

open DoxAletheia

module care =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/care#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/care#Caring"></see>
    /// </summary>
    let Caring = _prefix "Caring"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/care#ElderlyHome"></see>
    /// </summary>
    let ElderlyHome = _prefix "ElderlyHome"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/care#Environment"></see>
    /// </summary>
    let Environment = _prefix "Environment"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/care#caresFor"></see>
    /// </summary>
    let caresFor = _prefix "caresFor"
