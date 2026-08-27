namespace http.rdf.muninn_project.org.ontologies.religion.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module religion =
    let _namespace_iri = Namespace_Iri religion |> NamespaceIRI
    /// <summary>
    ///   <para>religion:Religion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.muninn-project.org/ontologies/religion#Religion">http://rdf.muninn-project.org/ontologies/religion#Religion</seealso>
    let Religion = Prefixed_Name(religion, "Religion") |> PrefixedName
