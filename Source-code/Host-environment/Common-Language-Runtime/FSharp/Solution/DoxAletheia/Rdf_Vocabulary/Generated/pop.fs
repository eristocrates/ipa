namespace http.wiki.dbpedia.org.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pop =
    let _namespace_iri = Namespace_Iri pop |> NamespaceIRI
    /// <summary>
    ///   <para>pop:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://wiki.dbpedia.org/">http://wiki.dbpedia.org/</seealso>
    let _prefix_iri = Prefixed_Name(pop, "") |> PrefixedName
    /// <summary>
    ///   <para>pop:Ontology</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://wiki.dbpedia.org/Ontology">http://wiki.dbpedia.org/Ontology</seealso>
    let Ontology = Prefixed_Name(pop, "Ontology") |> PrefixedName
