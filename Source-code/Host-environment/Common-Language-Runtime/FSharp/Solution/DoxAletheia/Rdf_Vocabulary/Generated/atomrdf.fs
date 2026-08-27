namespace http.atomowl.org.ontologies.atomrdf.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module atomrdf =
    let _namespace_iri = Namespace_Iri atomrdf |> NamespaceIRI
    /// <summary>
    ///   <para>atomrdf:Feed</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://atomowl.org/ontologies/atomrdf#Feed">http://atomowl.org/ontologies/atomrdf#Feed</seealso>
    let Feed = Prefixed_Name(atomrdf, "Feed") |> PrefixedName
