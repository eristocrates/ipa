namespace http.eulersharp.sourceforge.net._2003._03swap.computer.hash

open DoxAletheia.Rdf_Vocabulary

module swap_computer =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/computer#"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/computer#Computer"></see>
    /// </summary>
    let Computer = Namespaced_IRI.parse _namespace_name "Computer" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/computer#Data"></see>
    /// </summary>
    let Data = Namespaced_IRI.parse _namespace_name "Data" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/computer#Hardware"></see>
    /// </summary>
    let Hardware = Namespaced_IRI.parse _namespace_name "Hardware" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/computer#SearchEngine"></see>
    /// </summary>
    let SearchEngine =
        Namespaced_IRI.parse _namespace_name "SearchEngine" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/computer#Software"></see>
    /// </summary>
    let Software = Namespaced_IRI.parse _namespace_name "Software" |> NamespacedName
