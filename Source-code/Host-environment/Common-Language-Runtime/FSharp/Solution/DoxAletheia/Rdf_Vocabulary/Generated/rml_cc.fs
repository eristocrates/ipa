namespace http.w3id.org.rml.cc.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rml_cc =
    let _namespace_iri = Namespace_Iri rml_cc |> NamespaceIRI
    /// <summary>
    ///   <para>rml:cc/</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/rml/cc/">http://w3id.org/rml/cc/</seealso>
    let _prefix_iri = Prefixed_Name(rml_cc, "") |> PrefixedName
