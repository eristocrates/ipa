namespace http.www.w3.org._2002._01.bookmark.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bookmark =
    let _namespace_iri = Namespace_Iri bookmark |> NamespaceIRI
    /// <summary>
    ///   <para>bookmark:Bookmark</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/01/bookmark#Bookmark">http://www.w3.org/2002/01/bookmark#Bookmark</seealso>
    let Bookmark = Prefixed_Name(bookmark, "Bookmark") |> PrefixedName
    /// <summary>
    ///   <para>bookmark:hasTopic</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/01/bookmark#hasTopic">http://www.w3.org/2002/01/bookmark#hasTopic</seealso>
    let hasTopic = Prefixed_Name(bookmark, "hasTopic") |> PrefixedName
