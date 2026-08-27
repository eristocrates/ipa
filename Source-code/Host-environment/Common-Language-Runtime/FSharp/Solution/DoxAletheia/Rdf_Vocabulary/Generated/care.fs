namespace http.eulersharp.sourceforge.net._2003._03swap.care.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module care =
    let _namespace_iri = Namespace_Iri care |> NamespaceIRI
    /// <summary>
    ///   <para>care:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/care#">http://eulersharp.sourceforge.net/2003/03swap/care#</seealso>
    let _prefix_iri = Prefixed_Name(care, "") |> PrefixedName
    /// <summary>
    ///   <para>care:Caring</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"caring"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/care#Caring">http://eulersharp.sourceforge.net/2003/03swap/care#Caring</seealso>
    let Caring = Prefixed_Name(care, "Caring") |> PrefixedName
    /// <summary>
    ///   <para>care:ElderlyHome</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>skos:Concept</para>
    ///
    /// labels<para>"home for the elderly"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/care#ElderlyHome">http://eulersharp.sourceforge.net/2003/03swap/care#ElderlyHome</seealso>
    let ElderlyHome = Prefixed_Name(care, "ElderlyHome") |> PrefixedName
    /// <summary>
    ///   <para>care:Environment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"care environment"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/care#Environment">http://eulersharp.sourceforge.net/2003/03swap/care#Environment</seealso>
    let Environment = Prefixed_Name(care, "Environment") |> PrefixedName
    /// <summary>
    ///   <para>care:caresFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/care#caresFor">http://eulersharp.sourceforge.net/2003/03swap/care#caresFor</seealso>
    let caresFor = Prefixed_Name(care, "caresFor") |> PrefixedName
