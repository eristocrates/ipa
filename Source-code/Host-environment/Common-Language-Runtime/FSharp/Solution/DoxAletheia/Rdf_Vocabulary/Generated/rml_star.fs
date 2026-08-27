namespace http.w3id.org.rml.star.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rml_star =
    let _namespace_iri = Namespace_Iri rml_star |> NamespaceIRI
    /// <summary>
    ///   <para>rml:star/</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/rml/star/">http://w3id.org/rml/star/</seealso>
    let _prefix_iri = Prefixed_Name(rml_star, "") |> PrefixedName
