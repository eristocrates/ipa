namespace http.eulersharp.sourceforge.net._2003._03swap.organization.hash

open DoxAletheia.Rdf_Vocabulary

module organiz =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/organization#"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organization#Company"></see>
    /// </summary>
    let Company = Namespaced_IRI.parse _namespace_name "Company" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organization#Department"></see>
    /// </summary>
    let Department = Namespaced_IRI.parse _namespace_name "Department" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organization#Enterprise"></see>
    /// </summary>
    let Enterprise = Namespaced_IRI.parse _namespace_name "Enterprise" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organization#LegalPerson"></see>
    /// </summary>
    let LegalPerson =
        Namespaced_IRI.parse _namespace_name "LegalPerson" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organization#University"></see>
    /// </summary>
    let University = Namespaced_IRI.parse _namespace_name "University" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organization#hasSeat"></see>
    /// </summary>
    let hasSeat = Namespaced_IRI.parse _namespace_name "hasSeat" |> NamespacedName
