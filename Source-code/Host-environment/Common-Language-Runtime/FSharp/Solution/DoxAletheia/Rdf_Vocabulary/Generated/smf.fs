namespace http.topbraid.org.sparqlmotionfunctions.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module smf =
    let _namespace_iri = Namespace_Iri smf |> NamespaceIRI
    /// <summary>
    ///   <para>smf:cast</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://topbraid.org/sparqlmotionfunctions#cast">http://topbraid.org/sparqlmotionfunctions#cast</seealso>
    let cast = Prefixed_Name(smf, "cast") |> PrefixedName
