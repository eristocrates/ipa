namespace http.cs_www.cs.yale.edu.homes.dvm.daml.drsonto040520.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module drs =
    let _namespace_iri = Namespace_Iri drs |> NamespaceIRI
    /// <summary>
    ///   <para>drs:Formula</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://cs-www.cs.yale.edu/homes/dvm/daml/drsonto040520.owl#Formula">http://cs-www.cs.yale.edu/homes/dvm/daml/drsonto040520.owl#Formula</seealso>
    let Formula = Prefixed_Name(drs, "Formula") |> PrefixedName
