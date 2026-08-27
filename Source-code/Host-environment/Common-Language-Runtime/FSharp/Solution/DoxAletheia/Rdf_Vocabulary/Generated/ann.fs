namespace http.www.w3.org._2000._10.annotation_ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ann =
    let _namespace_iri = Namespace_Iri ann |> NamespaceIRI
    /// <summary>
    ///   <para>ann:Annotation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2000/10/annotation-ns#Annotation">http://www.w3.org/2000/10/annotation-ns#Annotation</seealso>
    let Annotation = Prefixed_Name(ann, "Annotation") |> PrefixedName
