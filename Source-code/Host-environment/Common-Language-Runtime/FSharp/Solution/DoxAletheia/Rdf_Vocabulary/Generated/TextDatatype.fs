namespace https.www.omg.org.spec.Commons.TextDatatype.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module TextDatatype =
    let _namespace_iri = Namespace_Iri TextDatatype |> NamespaceIRI
    /// <summary>
    ///   <para>TextDatatype:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/TextDatatype/">https://www.omg.org/spec/Commons/TextDatatype/</seealso>
    let _prefix_iri = Prefixed_Name(TextDatatype, "") |> PrefixedName
    /// <summary>
    ///   <para>TextDatatype:Text</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/TextDatatype/Text">https://www.omg.org/spec/Commons/TextDatatype/Text</seealso>
    let Text = Prefixed_Name(TextDatatype, "Text") |> PrefixedName
    /// <summary>
    ///   <para>TextDatatype:hasTextValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/TextDatatype/hasTextValue">https://www.omg.org/spec/Commons/TextDatatype/hasTextValue</seealso>
    let hasTextValue = Prefixed_Name(TextDatatype, "hasTextValue") |> PrefixedName
