namespace http.linkedgeodata.org.meta.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lgdm =
    let _namespace_iri = Namespace_Iri lgdm |> NamespaceIRI
    /// <summary>
    ///   <para>lgdm:sourceKey</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linkedgeodata.org/meta/sourceKey">http://linkedgeodata.org/meta/sourceKey</seealso>
    let sourceKey = Prefixed_Name(lgdm, "sourceKey") |> PrefixedName
    /// <summary>
    ///   <para>lgdm:sourceTag</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://linkedgeodata.org/meta/sourceTag">http://linkedgeodata.org/meta/sourceTag</seealso>
    let sourceTag = Prefixed_Name(lgdm, "sourceTag") |> PrefixedName
