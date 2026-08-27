namespace http.w3id.org.nkos.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nkos =
    let _namespace_iri = Namespace_Iri nkos |> NamespaceIRI
    /// <summary>
    ///   <para>nkos:alignedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A related resource with which the described resource is aligned."</para>
    /// labels<para>"aligned with"</para></remarks>
    /// <seealso href="http://w3id.org/nkos#alignedWith">http://w3id.org/nkos#alignedWith</seealso>
    let alignedWith = Prefixed_Name(nkos, "alignedWith") |> PrefixedName
    /// <summary>
    ///   <para>nkos:basedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A resource used as the source for a derivative resource."</para>
    /// labels<para>"based on"</para></remarks>
    /// <seealso href="http://w3id.org/nkos#basedOn">http://w3id.org/nkos#basedOn</seealso>
    let basedOn = Prefixed_Name(nkos, "basedOn") |> PrefixedName
    /// <summary>
    ///   <para>nkos:updateFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The period in which a KOS is typically updated."</para>
    /// labels<para>"update frequency"</para></remarks>
    /// <seealso href="http://w3id.org/nkos#updateFrequency">http://w3id.org/nkos#updateFrequency</seealso>
    let updateFrequency = Prefixed_Name(nkos, "updateFrequency") |> PrefixedName
    /// <summary>
    ///   <para>nkos:usedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Agent using the described KOS."</para>
    /// labels<para>"used by"</para></remarks>
    /// <seealso href="http://w3id.org/nkos#usedBy">http://w3id.org/nkos#usedBy</seealso>
    let usedBy = Prefixed_Name(nkos, "usedBy") |> PrefixedName
