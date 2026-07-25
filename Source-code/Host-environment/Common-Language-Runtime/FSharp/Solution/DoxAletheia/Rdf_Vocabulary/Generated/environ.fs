namespace http.eulersharp.sourceforge.net._2003._03swap.environment.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module environ =
    let _namespace_iri = Namespace_Iri environ |> NamespaceIRI

    /// <summary>
    ///   <para>environ:CommunityEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>E.g. the human colon as an environment for bacteria.</para>
    /// labels<para>community environment</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/environment#CommunityEnvironment">http://eulersharp.sourceforge.net/2003/03swap/environment#CommunityEnvironment</seealso>
    let CommunityEnvironment =
        Prefixed_Name(environ, "CommunityEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>environ:hasEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/environment#hasEnvironment">http://eulersharp.sourceforge.net/2003/03swap/environment#hasEnvironment</seealso>
    let hasEnvironment = Prefixed_Name(environ, "hasEnvironment") |> PrefixedName
    /// <summary>
    ///   <para>environ:Environment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>environment</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/environment#Environment">http://eulersharp.sourceforge.net/2003/03swap/environment#Environment</seealso>
    let Environment = Prefixed_Name(environ, "Environment") |> PrefixedName
    /// <summary>
    ///   <para>environ:Home</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>home</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/environment#Home">http://eulersharp.sourceforge.net/2003/03swap/environment#Home</seealso>
    let Home = Prefixed_Name(environ, "Home") |> PrefixedName
    /// <summary>
    ///   <para>environ:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/environment#">http://eulersharp.sourceforge.net/2003/03swap/environment#</seealso>
    let _prefix_iri = Prefixed_Name(environ, "") |> PrefixedName

    /// <summary>
    ///   <para>environ:HumanCommunityEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>human community environment</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/environment#HumanCommunityEnvironment">http://eulersharp.sourceforge.net/2003/03swap/environment#HumanCommunityEnvironment</seealso>
    let HumanCommunityEnvironment =
        Prefixed_Name(environ, "HumanCommunityEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>environ:environmentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/environment#environmentOf">http://eulersharp.sourceforge.net/2003/03swap/environment#environmentOf</seealso>
    let environmentOf = Prefixed_Name(environ, "environmentOf") |> PrefixedName
