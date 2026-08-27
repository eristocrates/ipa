namespace http.dbpedia.org._class.yago.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dbyago =
    let _namespace_iri = Namespace_Iri dbyago |> NamespaceIRI
    /// <summary>
    ///   <para>planet:class/yago/Containers</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://dbpedia.org/class/yago/Containers">http://dbpedia.org/class/yago/Containers</seealso>
    let Containers = Prefixed_Name(dbyago, "Containers") |> PrefixedName
