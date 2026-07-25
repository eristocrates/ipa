namespace http.w3id.org.rml.fnml.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rml_fnml =
    let _namespace_iri = Namespace_Iri rml_fnml |> NamespaceIRI
    /// <summary>
    ///   <para>rml_fnml:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/rml/fnml/">http://w3id.org/rml/fnml/</seealso>
    let _prefix_iri = Prefixed_Name(rml_fnml, "") |> PrefixedName
