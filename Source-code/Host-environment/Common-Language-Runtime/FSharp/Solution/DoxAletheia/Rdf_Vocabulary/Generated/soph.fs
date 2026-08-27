namespace http.sweetontology.net.phen.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module soph =
    let _namespace_iri = Namespace_Iri soph |> NamespaceIRI
    /// <summary>
    ///   <para>sweet:phen/Phenomenon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A phenomenon, in a scientific context, is something that is observed to occur or to exist."</para>
    /// labels<para>"Phenomenon"</para></remarks>
    /// <seealso href="http://sweetontology.net/phen/Phenomenon">http://sweetontology.net/phen/Phenomenon</seealso>
    let Phenomenon = Prefixed_Name(soph, "Phenomenon") |> PrefixedName
