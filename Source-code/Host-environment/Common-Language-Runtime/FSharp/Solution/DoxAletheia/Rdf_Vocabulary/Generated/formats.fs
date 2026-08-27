namespace http.www.w3.org.ns.formats.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module formats =
    let _namespace_iri = Namespace_Iri formats |> NamespaceIRI
    /// <summary>
    ///   <para>formats:Format</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/formats/Format">http://www.w3.org/ns/formats/Format</seealso>
    let Format = Prefixed_Name(formats, "Format") |> PrefixedName
    /// <summary>
    ///   <para>formats:Turtle</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/formats/Turtle">http://www.w3.org/ns/formats/Turtle</seealso>
    let Turtle = Prefixed_Name(formats, "Turtle") |> PrefixedName
    /// <summary>
    ///   <para>formats:data/JSON-LD</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/formats/data/JSON-LD">http://www.w3.org/ns/formats/data/JSON-LD</seealso>
    let ``data/JSON_LD`` = Prefixed_Name(formats, "data/JSON-LD") |> PrefixedName
    /// <summary>
    ///   <para>formats:data/RDF_XML</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/formats/data/RDF_XML">http://www.w3.org/ns/formats/data/RDF_XML</seealso>
    let ``data/RDF_XML`` = Prefixed_Name(formats, "data/RDF_XML") |> PrefixedName
    /// <summary>
    ///   <para>formats:data/Turtle</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/ns/formats/data/Turtle">http://www.w3.org/ns/formats/data/Turtle</seealso>
    let ``data/Turtle`` = Prefixed_Name(formats, "data/Turtle") |> PrefixedName
