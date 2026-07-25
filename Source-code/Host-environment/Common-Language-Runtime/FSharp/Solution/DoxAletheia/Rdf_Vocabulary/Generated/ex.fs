namespace http.purl.org.net.ns.ex.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ex =
    let _namespace_iri = Namespace_Iri ex |> NamespaceIRI
    /// <summary>
    ///   <para>ex:Example</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>ひとつの例を表すクラス</para>
    ///   <para>A class represents one example.</para>
    /// labels<para>Example</para></remarks>
    /// <seealso href="http://purl.org/net/ns/ex#Example">http://purl.org/net/ns/ex#Example</seealso>
    let Example = Prefixed_Name(ex, "Example") |> PrefixedName
    /// <summary>
    ///   <para>ex:code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>スキーマを使ったRDF/XMLのサンプルを記述する。CDATAセクションもしくはrdf:parseType="Literal"にすると、タグをそのまま記述できて便利。</para>
    ///   <para>Has an example code of an RDF/XML statements that use the schema. Content may be CDATA section or rdf:parseType="Literal".</para>
    /// labels<para>Code</para></remarks>
    /// <seealso href="http://purl.org/net/ns/ex#code">http://purl.org/net/ns/ex#code</seealso>
    let code = Prefixed_Name(ex, "code") |> PrefixedName
    /// <summary>
    ///   <para>ex:exampleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The subject is an example of the object vocabulary.</para>
    ///   <para>主語は目的語語彙の用例である。</para>
    /// labels<para>Example of</para></remarks>
    /// <seealso href="http://purl.org/net/ns/ex#exampleOf">http://purl.org/net/ns/ex#exampleOf</seealso>
    let exampleOf = Prefixed_Name(ex, "exampleOf") |> PrefixedName
    /// <summary>
    ///   <para>ex:pfx</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>A prefix used in the example to represent the schema namespace. A rendaring application may use this value to distinguish target terms in the example.</para>
    ///   <para>例の中でスキーマを表すために用いている名前空間接頭辞。例をレンダリングする場合、この値を使ってスキーマの語彙を他の語彙と区別することができる。</para>
    /// labels<para>Prefix</para></remarks>
    /// <seealso href="http://purl.org/net/ns/ex#pfx">http://purl.org/net/ns/ex#pfx</seealso>
    let pfx = Prefixed_Name(ex, "pfx") |> PrefixedName
    /// <summary>
    ///   <para>ex:example</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>主語となる語彙定義が例を持つ。</para>
    ///   <para>The subject has an Example. Use to include example(s) in a term definition.</para>
    /// labels<para>Example</para></remarks>
    /// <seealso href="http://purl.org/net/ns/ex#example">http://purl.org/net/ns/ex#example</seealso>
    let example = Prefixed_Name(ex, "example") |> PrefixedName
    /// <summary>
    ///   <para>ex:image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>語彙の理解を助ける画像へのポインタ。</para>
    ///   <para>A pointer to an image that helps to understand the vocabulary.</para>
    /// labels<para>Image</para></remarks>
    /// <seealso href="http://purl.org/net/ns/ex#image">http://purl.org/net/ns/ex#image</seealso>
    let image = Prefixed_Name(ex, "image") |> PrefixedName
    /// <summary>
    ///   <para>ex:trial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>語彙が使われている実例、あるいはトライアルページへのポインタ。</para>
    ///   <para>A pointer to a real example or a trial page.</para>
    /// labels<para>Trial</para></remarks>
    /// <seealso href="http://purl.org/net/ns/ex#trial">http://purl.org/net/ns/ex#trial</seealso>
    let trial = Prefixed_Name(ex, "trial") |> PrefixedName
