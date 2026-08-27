namespace http.www.daml.org.services.owl_s._1._2.Process.owl.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module damlProcess =
    let _namespace_iri = Namespace_Iri damlProcess |> NamespaceIRI
    /// <summary>
    ///   <para>damlProcess:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"
    ///     Upper-level OWL ontology for Processes.
    ///     Part of the DAML-S/OWL-S effort; see http://www.daml.org/services/owl-s/.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.daml.org/services/owl-s/1.2/Process.owl">http://www.daml.org/services/owl-s/1.2/Process.owl</seealso>
    let _prefix_iri = Prefixed_Name(damlProcess, "") |> PrefixedName
