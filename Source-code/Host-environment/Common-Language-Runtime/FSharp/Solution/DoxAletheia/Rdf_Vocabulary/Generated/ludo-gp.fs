namespace http.ns.inria.fr.ludo.v1.gamepresentation.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ludo_gp =
    let _namespace_iri = Namespace_Iri ludo_gp |> NamespaceIRI
    /// <summary>
    ///   <para>ludo-gp:FrontEndDisplay</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamepresentation#FrontEndDisplay">http://ns.inria.fr/ludo/v1/gamepresentation#FrontEndDisplay</seealso>
    let FrontEndDisplay = Prefixed_Name(ludo_gp, "FrontEndDisplay") |> PrefixedName
