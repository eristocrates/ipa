namespace http.eulersharp.sourceforge.net._2003._03swap.computer.hash

open DoxAletheia

module swap_computer =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/computer#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/computer#Computer"></see>
    /// </summary>
    let Computer = _prefix "Computer"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/computer#Data"></see>
    /// </summary>
    let Data = _prefix "Data"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/computer#Hardware"></see>
    /// </summary>
    let Hardware = _prefix "Hardware"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/computer#SearchEngine"></see>
    /// </summary>
    let SearchEngine = _prefix "SearchEngine"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/computer#Software"></see>
    /// </summary>
    let Software = _prefix "Software"
