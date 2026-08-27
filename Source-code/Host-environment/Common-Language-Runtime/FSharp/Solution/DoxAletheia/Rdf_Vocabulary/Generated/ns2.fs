namespace http.ogp.me.ns.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ns2 =
    let _namespace_iri = Namespace_Iri ns2 |> NamespaceIRI
    /// <summary>
    ///   <para>ogp:video:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The height of a video."</para>
    /// labels<para>"video height"</para></remarks>
    /// <seealso href="http://ogp.me/ns#video:height">http://ogp.me/ns#video:height</seealso>
    let height = Prefixed_Name(ns2, "height") |> PrefixedName
    /// <summary>
    ///   <para>ogp:video:secure_url</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A relevant, secure video URL for your object."</para>
    /// labels<para>"video secure URL"</para></remarks>
    /// <seealso href="http://ogp.me/ns#video:secure_url">http://ogp.me/ns#video:secure_url</seealso>
    let secure_url = Prefixed_Name(ns2, "secure_url") |> PrefixedName
    /// <summary>
    ///   <para>ogp:video:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The mime type of a video e.g., "application/x-shockwave-flash""</para>
    /// labels<para>"video type"</para></remarks>
    /// <seealso href="http://ogp.me/ns#video:type">http://ogp.me/ns#video:type</seealso>
    let type_ = Prefixed_Name(ns2, "type") |> PrefixedName
    /// <summary>
    ///   <para>ogp:video:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The width of a video."</para>
    /// labels<para>"video width"</para></remarks>
    /// <seealso href="http://ogp.me/ns#video:width">http://ogp.me/ns#video:width</seealso>
    let width = Prefixed_Name(ns2, "width") |> PrefixedName
