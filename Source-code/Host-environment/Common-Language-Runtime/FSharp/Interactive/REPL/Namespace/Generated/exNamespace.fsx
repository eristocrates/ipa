#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ex =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/net/ns/ex#" "ex"
    /// <summary>
    ///   <para>rdfs:label : Example^^xsd:string</para>
    ///   <para>rdfs:comment : A class represents one example.^^xsd:stringrdfs:comment : ひとつの例を表すクラス</para>
    ///   <a href="http://purl.org/net/ns/ex#Example">ex:Example</a>
    /// </summary>
    let Example = _prefixId.prefix "Example"
    /// <summary>
    ///   <para>rdfs:label : Code^^xsd:string</para>
    ///   <para>rdfs:comment : Has an example code of an RDF/XML statements that use the schema. Content may be CDATA section or rdf:parseType="Literal".^^xsd:stringrdfs:comment : スキーマを使ったRDF/XMLのサンプルを記述する。CDATAセクションもしくはrdf:parseType="Literal"にすると、タグをそのまま記述できて便利。</para>
    ///   <a href="http://purl.org/net/ns/ex#code">ex:code</a>
    /// </summary>
    let code = _prefixId.prefix "code"
    /// <summary>
    ///   <para>rdfs:label : Example^^xsd:string</para>
    ///   <para>rdfs:comment : The subject has an Example. Use to include example(s) in a term definition.^^xsd:stringrdfs:comment : 主語となる語彙定義が例を持つ。</para>
    ///   <a href="http://purl.org/net/ns/ex#example">ex:example</a>
    /// </summary>
    let example = _prefixId.prefix "example"
    /// <summary>
    ///   <para>rdfs:label : Example of^^xsd:string</para>
    ///   <para>rdfs:comment : The subject is an example of the object vocabulary.^^xsd:stringrdfs:comment : 主語は目的語語彙の用例である。</para>
    ///   <a href="http://purl.org/net/ns/ex#exampleOf">ex:exampleOf</a>
    /// </summary>
    let exampleOf = _prefixId.prefix "exampleOf"
    /// <summary>
    ///   <para>rdfs:label : Image^^xsd:string</para>
    ///   <para>rdfs:comment : A pointer to an image that helps to understand the vocabulary.^^xsd:stringrdfs:comment : 語彙の理解を助ける画像へのポインタ。</para>
    ///   <a href="http://purl.org/net/ns/ex#image">ex:image</a>
    /// </summary>
    let image = _prefixId.prefix "image"
    /// <summary>
    ///   <para>rdfs:label : Prefix^^xsd:string</para>
    ///   <para>rdfs:comment : A prefix used in the example to represent the schema namespace. A rendaring application may use this value to distinguish target terms in the example.^^xsd:stringrdfs:comment : 例の中でスキーマを表すために用いている名前空間接頭辞。例をレンダリングする場合、この値を使ってスキーマの語彙を他の語彙と区別することができる。</para>
    ///   <a href="http://purl.org/net/ns/ex#pfx">ex:pfx</a>
    /// </summary>
    let pfx = _prefixId.prefix "pfx"
    /// <summary>
    ///   <para>rdfs:label : Trial^^xsd:string</para>
    ///   <para>rdfs:comment : A pointer to a real example or a trial page.^^xsd:stringrdfs:comment : 語彙が使われている実例、あるいはトライアルページへのポインタ。</para>
    ///   <a href="http://purl.org/net/ns/ex#trial">ex:trial</a>
    /// </summary>
    let trial = _prefixId.prefix "trial"
