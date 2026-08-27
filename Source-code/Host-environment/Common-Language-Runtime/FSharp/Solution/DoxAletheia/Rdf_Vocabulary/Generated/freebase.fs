namespace http.rdf.freebase.com.ns.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module freebase =
    let _namespace_iri = Namespace_Iri freebase |> NamespaceIRI

    /// <summary>
    ///   <para>freebase:biology.organism_classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.freebase.com/ns/biology.organism_classification">http://rdf.freebase.com/ns/biology.organism_classification</seealso>
    let ``biology.organism_classification`` =
        Prefixed_Name(freebase, "biology.organism_classification") |> PrefixedName
