namespace http.eulersharp.sourceforge.net._2003._03swap.environment.hash

open DoxAletheia

module environ =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/environment#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// E.g. the human colon as an environment for bacteria.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/environment#CommunityEnvironment"></see></summary>
    let CommunityEnvironment = _prefix "CommunityEnvironment"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/environment#Environment"></see>
    /// </summary>
    let Environment = _prefix "Environment"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/environment#Home"></see>
    /// </summary>
    let Home = _prefix "Home"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/environment#HumanCommunityEnvironment"></see>
    /// </summary>
    let HumanCommunityEnvironment = _prefix "HumanCommunityEnvironment"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/environment#environmentOf"></see>
    /// </summary>
    let environmentOf = _prefix "environmentOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/environment#hasEnvironment"></see>
    /// </summary>
    let hasEnvironment = _prefix "hasEnvironment"
