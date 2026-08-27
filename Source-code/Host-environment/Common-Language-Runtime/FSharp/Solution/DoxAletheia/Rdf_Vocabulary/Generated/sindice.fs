namespace http.vocab.sindice.net.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sindice =
    let _namespace_iri = Namespace_Iri sindice |> NamespaceIRI
    /// <summary>
    ///   <para>sindice:date</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://vocab.sindice.net/date">http://vocab.sindice.net/date</seealso>
    let date = Prefixed_Name(sindice, "date") |> PrefixedName
    /// <summary>
    ///   <para>sindice:size</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://vocab.sindice.net/size">http://vocab.sindice.net/size</seealso>
    let size = Prefixed_Name(sindice, "size") |> PrefixedName
