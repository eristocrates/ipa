namespace http.wordnet_rdf.princeton.edu.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module wordnet =
    let _namespace_iri = Namespace_Iri wordnet |> NamespaceIRI
    /// <summary>
    ///   <para>wordnet:Synset</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://wordnet-rdf.princeton.edu/ontology#Synset">http://wordnet-rdf.princeton.edu/ontology#Synset</seealso>
    let Synset = Prefixed_Name(wordnet, "Synset") |> PrefixedName
