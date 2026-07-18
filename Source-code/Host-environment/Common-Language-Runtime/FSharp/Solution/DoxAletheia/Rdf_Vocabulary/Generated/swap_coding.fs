namespace http.eulersharp.sourceforge.net._2003._03swap.coding.hash

open DoxAletheia.Rdf_Vocabulary

module swap_coding =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/coding#"
    /// <summary>
    /// A code system is declared using &lt;http://www.w3.org/2004/02/skos/core#inScheme&gt;. A system version is declared using &lt;http://purl.org/dc/terms/hasVersion&gt;.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/coding#Code"></see></summary>
    let Code = Namespaced_IRI.parse _namespace_name "Code" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/coding#codes"></see>
    /// </summary>
    let codes = Namespaced_IRI.parse _namespace_name "codes" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasCode"></see>
    /// </summary>
    let hasCode = Namespaced_IRI.parse _namespace_name "hasCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasBroadCode"></see>
    /// </summary>
    let hasBroadCode =
        Namespaced_IRI.parse _namespace_name "hasBroadCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasMappingCode"></see>
    /// </summary>
    let hasMappingCode =
        Namespaced_IRI.parse _namespace_name "hasMappingCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasCodeAuthority"></see>
    /// </summary>
    let hasCodeAuthority =
        Namespaced_IRI.parse _namespace_name "hasCodeAuthority" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasCodeExpirationDate"></see>
    /// </summary>
    let hasCodeExpirationDate =
        Namespaced_IRI.parse _namespace_name "hasCodeExpirationDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasCodeValue"></see>
    /// </summary>
    let hasCodeValue =
        Namespaced_IRI.parse _namespace_name "hasCodeValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasExactCode"></see>
    /// </summary>
    let hasExactCode =
        Namespaced_IRI.parse _namespace_name "hasExactCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasNarrowCode"></see>
    /// </summary>
    let hasNarrowCode =
        Namespaced_IRI.parse _namespace_name "hasNarrowCode" |> NamespacedName
