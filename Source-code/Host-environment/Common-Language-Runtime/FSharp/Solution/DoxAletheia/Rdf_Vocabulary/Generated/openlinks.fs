namespace http.www.openlinksw.com.schemas.virtrdf.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module openlinks =
    let _namespace_iri = Namespace_Iri openlinks |> NamespaceIRI
    /// <summary>
    ///   <para>openlinks:geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"geometry"</para>
    /// </remarks>
    /// <seealso href="http://www.openlinksw.com/schemas/virtrdf#geometry">http://www.openlinksw.com/schemas/virtrdf#geometry</seealso>
    let geometry = Prefixed_Name(openlinks, "geometry") |> PrefixedName
