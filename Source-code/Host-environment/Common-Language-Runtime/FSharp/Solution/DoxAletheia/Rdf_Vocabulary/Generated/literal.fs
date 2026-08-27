namespace http.www.essepuntato.it._2010._06.literalreification.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module literal =
    let _namespace_iri = Namespace_Iri literal |> NamespaceIRI
    /// <summary>
    ///   <para>literal:Literal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.essepuntato.it/2010/06/literalreification/Literal">http://www.essepuntato.it/2010/06/literalreification/Literal</seealso>
    let Literal = Prefixed_Name(literal, "Literal") |> PrefixedName
