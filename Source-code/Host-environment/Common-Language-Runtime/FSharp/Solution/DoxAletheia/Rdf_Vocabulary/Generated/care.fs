namespace http.eulersharp.sourceforge.net._2003._03swap.care.hash

open DoxAletheia.Rdf_Vocabulary

module care =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/care#"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/care#Caring"></see>
    /// </summary>
    let Caring = Namespaced_IRI.parse _namespace_name "Caring" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/care#ElderlyHome"></see>
    /// </summary>
    let ElderlyHome =
        Namespaced_IRI.parse _namespace_name "ElderlyHome" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/care#Environment"></see>
    /// </summary>
    let Environment =
        Namespaced_IRI.parse _namespace_name "Environment" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/care#caresFor"></see>
    /// </summary>
    let caresFor = Namespaced_IRI.parse _namespace_name "caresFor" |> NamespacedName
