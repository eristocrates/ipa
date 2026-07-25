namespace http.www.w3.org._2011.http_methods.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module httpm =
    let _namespace_iri = Namespace_Iri httpm |> NamespaceIRI
    /// <summary>
    ///   <para>httpm:DELETE</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:Method</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-methods#DELETE">http://www.w3.org/2011/http-methods#DELETE</seealso>
    let DELETE = Prefixed_Name(httpm, "DELETE") |> PrefixedName
    /// <summary>
    ///   <para>httpm:GET</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:Method</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-methods#GET">http://www.w3.org/2011/http-methods#GET</seealso>
    let GET = Prefixed_Name(httpm, "GET") |> PrefixedName
    /// <summary>
    ///   <para>httpm:HEAD</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:Method</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-methods#HEAD">http://www.w3.org/2011/http-methods#HEAD</seealso>
    let HEAD = Prefixed_Name(httpm, "HEAD") |> PrefixedName
    /// <summary>
    ///   <para>httpm:PUT</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:Method</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-methods#PUT">http://www.w3.org/2011/http-methods#PUT</seealso>
    let PUT = Prefixed_Name(httpm, "PUT") |> PrefixedName
    /// <summary>
    ///   <para>httpm:OPTIONS</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:Method</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-methods#OPTIONS">http://www.w3.org/2011/http-methods#OPTIONS</seealso>
    let OPTIONS = Prefixed_Name(httpm, "OPTIONS") |> PrefixedName
    /// <summary>
    ///   <para>httpm:PATCH</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:Method</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-methods#PATCH">http://www.w3.org/2011/http-methods#PATCH</seealso>
    let PATCH = Prefixed_Name(httpm, "PATCH") |> PrefixedName
    /// <summary>
    ///   <para>httpm:TRACE</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:Method</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-methods#TRACE">http://www.w3.org/2011/http-methods#TRACE</seealso>
    let TRACE = Prefixed_Name(httpm, "TRACE") |> PrefixedName
    /// <summary>
    ///   <para>httpm:POST</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:Method</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-methods#POST">http://www.w3.org/2011/http-methods#POST</seealso>
    let POST = Prefixed_Name(httpm, "POST") |> PrefixedName
    /// <summary>
    ///   <para>httpm:CONNECT</para>
    /// </summary>
    /// <remarks>
    ///   <para>htir:Method</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2011/http-methods#CONNECT">http://www.w3.org/2011/http-methods#CONNECT</seealso>
    let CONNECT = Prefixed_Name(httpm, "CONNECT") |> PrefixedName
