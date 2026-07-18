namespace http.eulersharp.sourceforge.net._2003._03swap.environment.hash

open DoxAletheia.Rdf_Vocabulary

module environ =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/environment#"

    /// <summary>
    /// E.g. the human colon as an environment for bacteria.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/environment#CommunityEnvironment"></see></summary>
    let CommunityEnvironment =
        Namespaced_IRI.parse _namespace_name "CommunityEnvironment" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/environment#Environment"></see>
    /// </summary>
    let Environment =
        Namespaced_IRI.parse _namespace_name "Environment" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/environment#Home"></see>
    /// </summary>
    let Home = Namespaced_IRI.parse _namespace_name "Home" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/environment#HumanCommunityEnvironment"></see>
    /// </summary>
    let HumanCommunityEnvironment =
        Namespaced_IRI.parse _namespace_name "HumanCommunityEnvironment" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/environment#environmentOf"></see>
    /// </summary>
    let environmentOf =
        Namespaced_IRI.parse _namespace_name "environmentOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/environment#hasEnvironment"></see>
    /// </summary>
    let hasEnvironment =
        Namespaced_IRI.parse _namespace_name "hasEnvironment" |> NamespacedName
