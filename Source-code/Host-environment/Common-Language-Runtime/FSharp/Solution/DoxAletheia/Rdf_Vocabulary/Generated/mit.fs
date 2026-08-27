namespace http.purl.org.ontology.mo.mit.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module mit =
    let _namespace_iri = Namespace_Iri mit |> NamespaceIRI
    /// <summary>
    ///   <para>mo:mit#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/ontology/mo/mit#">http://purl.org/ontology/mo/mit#</seealso>
    let _prefix_iri = Prefixed_Name(mit, "") |> PrefixedName
