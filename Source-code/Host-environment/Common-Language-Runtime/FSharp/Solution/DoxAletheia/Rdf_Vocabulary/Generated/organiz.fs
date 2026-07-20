namespace http.eulersharp.sourceforge.net._2003._03swap.organization.hash

open DoxAletheia

module organiz =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/organization#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organization#Company"></see>
    /// </summary>
    let Company = _prefix "Company"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organization#Department"></see>
    /// </summary>
    let Department = _prefix "Department"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organization#Enterprise"></see>
    /// </summary>
    let Enterprise = _prefix "Enterprise"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organization#LegalPerson"></see>
    /// </summary>
    let LegalPerson = _prefix "LegalPerson"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organization#University"></see>
    /// </summary>
    let University = _prefix "University"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/organization#hasSeat"></see>
    /// </summary>
    let hasSeat = _prefix "hasSeat"
