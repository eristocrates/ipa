namespace http.eulersharp.sourceforge.net._2003._03swap.coding.hash

open DoxAletheia

module swap_coding =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/coding#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A code system is declared using &lt;http://www.w3.org/2004/02/skos/core#inScheme&gt;. A system version is declared using &lt;http://purl.org/dc/terms/hasVersion&gt;.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/coding#Code"></see></summary>
    let Code = _prefix "Code"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/coding#codes"></see>
    /// </summary>
    let codes = _prefix "codes"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasCode"></see>
    /// </summary>
    let hasCode = _prefix "hasCode"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasBroadCode"></see>
    /// </summary>
    let hasBroadCode = _prefix "hasBroadCode"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasMappingCode"></see>
    /// </summary>
    let hasMappingCode = _prefix "hasMappingCode"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasCodeAuthority"></see>
    /// </summary>
    let hasCodeAuthority = _prefix "hasCodeAuthority"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasCodeExpirationDate"></see>
    /// </summary>
    let hasCodeExpirationDate = _prefix "hasCodeExpirationDate"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasCodeValue"></see>
    /// </summary>
    let hasCodeValue = _prefix "hasCodeValue"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasExactCode"></see>
    /// </summary>
    let hasExactCode = _prefix "hasExactCode"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/coding#hasNarrowCode"></see>
    /// </summary>
    let hasNarrowCode = _prefix "hasNarrowCode"
