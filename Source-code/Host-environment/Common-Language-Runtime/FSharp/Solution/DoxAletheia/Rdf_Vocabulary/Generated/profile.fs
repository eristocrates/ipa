namespace https.prez.dev.profile.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module profile =
    let _namespace_iri = Namespace_Iri profile |> NamespaceIRI
    /// <summary>
    ///   <para>prez:profile/open-object</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://prez.dev/profile/open-object">https://prez.dev/profile/open-object</seealso>
    let open_object = Prefixed_Name(profile, "open-object") |> PrefixedName
