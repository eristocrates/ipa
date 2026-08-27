namespace http.www.observedchange.com.tisc.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tisc =
    let _namespace_iri = Namespace_Iri tisc |> NamespaceIRI
    /// <summary>
    ///   <para>tisc:</para>
    /// </summary>
    /// <remarks>
    ///   <para>hartigprov:DataItem</para>
    ///   <para>owl:Ontology</para>
    ///   <para>hartigprov:DataCreation</para>
    /// </remarks>
    /// <seealso href="http://www.observedchange.com/tisc/ns#">http://www.observedchange.com/tisc/ns#</seealso>
    let _prefix_iri = Prefixed_Name(tisc, "") |> PrefixedName
