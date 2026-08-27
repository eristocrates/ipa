namespace https.prez.dev.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module prez =
    let _namespace_iri = Namespace_Iri prez |> NamespaceIRI
    /// <summary>
    ///   <para>prez:FocusNode</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://prez.dev/FocusNode">https://prez.dev/FocusNode</seealso>
    let FocusNode = Prefixed_Name(prez, "FocusNode") |> PrefixedName
    /// <summary>
    ///   <para>prez:currentProfile</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://prez.dev/currentProfile">https://prez.dev/currentProfile</seealso>
    let currentProfile = Prefixed_Name(prez, "currentProfile") |> PrefixedName
    /// <summary>
    ///   <para>prez:description</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://prez.dev/description">https://prez.dev/description</seealso>
    let description = Prefixed_Name(prez, "description") |> PrefixedName
    /// <summary>
    ///   <para>prez:identifier</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://prez.dev/identifier">https://prez.dev/identifier</seealso>
    let identifier = Prefixed_Name(prez, "identifier") |> PrefixedName
    /// <summary>
    ///   <para>prez:label</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://prez.dev/label">https://prez.dev/label</seealso>
    let label = Prefixed_Name(prez, "label") |> PrefixedName
    /// <summary>
    ///   <para>prez:link</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://prez.dev/link">https://prez.dev/link</seealso>
    let link = Prefixed_Name(prez, "link") |> PrefixedName
    /// <summary>
    ///   <para>prez:members</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://prez.dev/members">https://prez.dev/members</seealso>
    let members = Prefixed_Name(prez, "members") |> PrefixedName
    /// <summary>
    ///   <para>prez:type</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://prez.dev/type">https://prez.dev/type</seealso>
    let type_ = Prefixed_Name(prez, "type") |> PrefixedName
