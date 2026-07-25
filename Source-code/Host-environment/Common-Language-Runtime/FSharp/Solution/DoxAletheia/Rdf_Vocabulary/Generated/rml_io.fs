namespace http.w3id.org.rml.io.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rml_io =
    let _namespace_iri = Namespace_Iri rml_io |> NamespaceIRI
    /// <summary>
    ///   <para>rml_io:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/rml/io/">http://w3id.org/rml/io/</seealso>
    let _prefix_iri = Prefixed_Name(rml_io, "") |> PrefixedName
