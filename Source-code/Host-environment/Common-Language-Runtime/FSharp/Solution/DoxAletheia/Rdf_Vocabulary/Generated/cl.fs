namespace http.advene.org.ns.cinelab.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cl =
    let _namespace_iri = Namespace_Iri cl |> NamespaceIRI
    /// <summary>
    ///   <para>cl:ld</para>
    /// </summary>
    /// <remarks>
    ///   <para>vann:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para>"This ontology allows to represent in RDF the Cinelab model &lt;http://advene.org/cinelab/&gt;."</para>
    ///   <para>"Cette ontologie permet de représenter en RDF le modèle Cinelab &lt;http://advene.org/cinelab/&gt;."</para>
    /// </remarks>
    /// <seealso href="http://advene.org/ns/cinelab/ld">http://advene.org/ns/cinelab/ld</seealso>
    let ld = Prefixed_Name(cl, "ld") |> PrefixedName
