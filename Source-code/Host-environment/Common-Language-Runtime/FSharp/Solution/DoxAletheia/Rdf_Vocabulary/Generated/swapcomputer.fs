namespace http.eulersharp.sourceforge.net._2003._03swap.computer.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swapcomputer =
    let _namespace_iri = Namespace_Iri swapcomputer |> NamespaceIRI
    /// <summary>
    ///   <para>swapcomputer:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/computer#">http://eulersharp.sourceforge.net/2003/03swap/computer#</seealso>
    let _prefix_iri = Prefixed_Name(swapcomputer, "") |> PrefixedName
    /// <summary>
    ///   <para>swapcomputer:Software</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>digital computer software</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/computer#Software">http://eulersharp.sourceforge.net/2003/03swap/computer#Software</seealso>
    let Software = Prefixed_Name(swapcomputer, "Software") |> PrefixedName
    /// <summary>
    ///   <para>swapcomputer:Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>digital computer data</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/computer#Data">http://eulersharp.sourceforge.net/2003/03swap/computer#Data</seealso>
    let Data = Prefixed_Name(swapcomputer, "Data") |> PrefixedName
    /// <summary>
    ///   <para>swapcomputer:Hardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>digital computer hardware</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/computer#Hardware">http://eulersharp.sourceforge.net/2003/03swap/computer#Hardware</seealso>
    let Hardware = Prefixed_Name(swapcomputer, "Hardware") |> PrefixedName
    /// <summary>
    ///   <para>swapcomputer:Computer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>digital computer</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/computer#Computer">http://eulersharp.sourceforge.net/2003/03swap/computer#Computer</seealso>
    let Computer = Prefixed_Name(swapcomputer, "Computer") |> PrefixedName
    /// <summary>
    ///   <para>swapcomputer:SearchEngine</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>digital computer search engine</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/computer#SearchEngine">http://eulersharp.sourceforge.net/2003/03swap/computer#SearchEngine</seealso>
    let SearchEngine = Prefixed_Name(swapcomputer, "SearchEngine") |> PrefixedName
