namespace http.www.w3.org._2003._06.sw_vocab_status.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module status =
    let _namespace_iri = Namespace_Iri status |> NamespaceIRI
    /// <summary>
    ///   <para>status:term_status</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>the status of a vocabulary term, expressed as a short symbolic string; known values include 'unstable','testing', 'stable' and 'archaic'</para>
    /// labels<para>term status</para></remarks>
    /// <seealso href="http://www.w3.org/2003/06/sw-vocab-status/ns#term_status">http://www.w3.org/2003/06/sw-vocab-status/ns#term_status</seealso>
    let term_status = Prefixed_Name(status, "term_status") |> PrefixedName
    /// <summary>
    ///   <para>status:moreinfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>more information about the status etc of a term, typically human oriented</para>
    /// labels<para>more info</para></remarks>
    /// <seealso href="http://www.w3.org/2003/06/sw-vocab-status/ns#moreinfo">http://www.w3.org/2003/06/sw-vocab-status/ns#moreinfo</seealso>
    let moreinfo = Prefixed_Name(status, "moreinfo") |> PrefixedName
    /// <summary>
    ///   <para>status:userdocs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>human-oriented documentation, examples etc for use of this term</para>
    /// labels<para>user docs</para></remarks>
    /// <seealso href="http://www.w3.org/2003/06/sw-vocab-status/ns#userdocs">http://www.w3.org/2003/06/sw-vocab-status/ns#userdocs</seealso>
    let userdocs = Prefixed_Name(status, "userdocs") |> PrefixedName
    /// <summary>
    ///   <para>status:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2003/06/sw-vocab-status/ns#">http://www.w3.org/2003/06/sw-vocab-status/ns#</seealso>
    let _prefix_iri = Prefixed_Name(status, "") |> PrefixedName
