namespace http.www.observedchange.com.moac.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module moac =
    let _namespace_iri = Namespace_Iri moac |> NamespaceIRI
    /// <summary>
    ///   <para>moac:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>hartigprov:DataItem</para>
    /// </remarks>
    /// <seealso href="http://www.observedchange.com/moac/ns#">http://www.observedchange.com/moac/ns#</seealso>
    let _prefix_iri = Prefixed_Name(moac, "") |> PrefixedName
