namespace http.elite.polito.it.ontologies.dogont.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dogont =
    let _namespace_iri = Namespace_Iri dogont |> NamespaceIRI
    /// <summary>
    ///   <para>dogont:.owl</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://elite.polito.it/ontologies/dogont.owl">http://elite.polito.it/ontologies/dogont.owl</seealso>
    let ``_.owl`` = Prefixed_Name(dogont, ".owl") |> PrefixedName
