namespace http.mlcommons.org.croissant.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cr =
    let _namespace_iri = Namespace_Iri cr |> NamespaceIRI
    /// <summary>
    ///   <para>cr:Field</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mlcommons.org/croissant/Field">http://mlcommons.org/croissant/Field</seealso>
    let Field = Prefixed_Name(cr, "Field") |> PrefixedName
    /// <summary>
    ///   <para>cr:FileObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mlcommons.org/croissant/FileObject">http://mlcommons.org/croissant/FileObject</seealso>
    let FileObject = Prefixed_Name(cr, "FileObject") |> PrefixedName
    /// <summary>
    ///   <para>cr:FileSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mlcommons.org/croissant/FileSet">http://mlcommons.org/croissant/FileSet</seealso>
    let FileSet = Prefixed_Name(cr, "FileSet") |> PrefixedName
    /// <summary>
    ///   <para>cr:RecordSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://mlcommons.org/croissant/RecordSet">http://mlcommons.org/croissant/RecordSet</seealso>
    let RecordSet = Prefixed_Name(cr, "RecordSet") |> PrefixedName
    /// <summary>
    ///   <para>cr:containedIn</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://mlcommons.org/croissant/containedIn">http://mlcommons.org/croissant/containedIn</seealso>
    let containedIn = Prefixed_Name(cr, "containedIn") |> PrefixedName
    /// <summary>
    ///   <para>cr:field</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://mlcommons.org/croissant/field">http://mlcommons.org/croissant/field</seealso>
    let field = Prefixed_Name(cr, "field") |> PrefixedName
    /// <summary>
    ///   <para>cr:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://mlcommons.org/croissant/source">http://mlcommons.org/croissant/source</seealso>
    let source = Prefixed_Name(cr, "source") |> PrefixedName
