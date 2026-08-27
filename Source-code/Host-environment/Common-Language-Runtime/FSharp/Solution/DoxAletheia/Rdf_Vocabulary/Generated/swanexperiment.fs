namespace http.purl.org.swan._2._0.experiment.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swanexperiment =
    let _namespace_iri = Namespace_Iri swanexperiment |> NamespaceIRI
    /// <summary>
    ///   <para>swan:experiment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///
    /// labels<para>"v. 0.1"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/experiment">http://purl.org/swan/2.0/experiment</seealso>
    let _prefix_iri = Prefixed_Name(swanexperiment, "") |> PrefixedName
