namespace http.www.w3.org._2006.http.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module httpvoc =
    let _namespace_iri = Namespace_Iri httpvoc |> NamespaceIRI
    /// <summary>
    ///   <para>httpvoc:301</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2006/http#301">http://www.w3.org/2006/http#301</seealso>
    let _301 = Prefixed_Name(httpvoc, "301") |> PrefixedName
    /// <summary>
    ///   <para>httpvoc:302</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/http#302">http://www.w3.org/2006/http#302</seealso>
    let _302 = Prefixed_Name(httpvoc, "302") |> PrefixedName
    /// <summary>
    ///   <para>httpvoc:303</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/http#303">http://www.w3.org/2006/http#303</seealso>
    let _303 = Prefixed_Name(httpvoc, "303") |> PrefixedName
    /// <summary>
    ///   <para>httpvoc:307</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/http#307">http://www.w3.org/2006/http#307</seealso>
    let _307 = Prefixed_Name(httpvoc, "307") |> PrefixedName
    /// <summary>
    ///   <para>httpvoc:Message</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2006/http#Message">http://www.w3.org/2006/http#Message</seealso>
    let Message = Prefixed_Name(httpvoc, "Message") |> PrefixedName
    /// <summary>
    ///   <para>httpvoc:MessageHeader</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2006/http#MessageHeader">http://www.w3.org/2006/http#MessageHeader</seealso>
    let MessageHeader = Prefixed_Name(httpvoc, "MessageHeader") |> PrefixedName
    /// <summary>
    ///   <para>httpvoc:Request</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2006/http#Request">http://www.w3.org/2006/http#Request</seealso>
    let Request = Prefixed_Name(httpvoc, "Request") |> PrefixedName
