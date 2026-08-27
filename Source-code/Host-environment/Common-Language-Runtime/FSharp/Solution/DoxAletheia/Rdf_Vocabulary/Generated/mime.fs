namespace https.www.iana.org.assignments.media_types.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module mime =
    let _namespace_iri = Namespace_Iri mime |> NamespaceIRI

    /// <summary>
    ///   <para>mime:application/geo+json</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.iana.org/assignments/media-types/application/geo+json">https://www.iana.org/assignments/media-types/application/geo+json</seealso>
    let ``application/geo+json`` =
        Prefixed_Name(mime, "application/geo+json") |> PrefixedName

    /// <summary>
    ///   <para>mime:application/gltf-buffer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.iana.org/assignments/media-types/application/gltf-buffer">https://www.iana.org/assignments/media-types/application/gltf-buffer</seealso>
    let ``application/gltf_buffer`` =
        Prefixed_Name(mime, "application/gltf-buffer") |> PrefixedName

    /// <summary>
    ///   <para>mime:application/ld+json</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.iana.org/assignments/media-types/application/ld+json">https://www.iana.org/assignments/media-types/application/ld+json</seealso>
    let ``application/ld+json`` =
        Prefixed_Name(mime, "application/ld+json") |> PrefixedName

    /// <summary>
    ///   <para>mime:application/rdf+xml</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.iana.org/assignments/media-types/application/rdf+xml">https://www.iana.org/assignments/media-types/application/rdf+xml</seealso>
    let ``application/rdf+xml`` =
        Prefixed_Name(mime, "application/rdf+xml") |> PrefixedName

    /// <summary>
    ///   <para>mime:image/vnd.dwg</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.iana.org/assignments/media-types/image/vnd.dwg">https://www.iana.org/assignments/media-types/image/vnd.dwg</seealso>
    let ``image/vnd.dwg`` = Prefixed_Name(mime, "image/vnd.dwg") |> PrefixedName
    /// <summary>
    ///   <para>mime:model/gltf+json</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.iana.org/assignments/media-types/model/gltf+json">https://www.iana.org/assignments/media-types/model/gltf+json</seealso>
    let ``model/gltf+json`` = Prefixed_Name(mime, "model/gltf+json") |> PrefixedName
    /// <summary>
    ///   <para>mime:model/gltf-binary</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.iana.org/assignments/media-types/model/gltf-binary">https://www.iana.org/assignments/media-types/model/gltf-binary</seealso>
    let ``model/gltf_binary`` = Prefixed_Name(mime, "model/gltf-binary") |> PrefixedName
    /// <summary>
    ///   <para>mime:model/iges</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.iana.org/assignments/media-types/model/iges">https://www.iana.org/assignments/media-types/model/iges</seealso>
    let ``model/iges`` = Prefixed_Name(mime, "model/iges") |> PrefixedName
    /// <summary>
    ///   <para>mime:model/stl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.iana.org/assignments/media-types/model/stl">https://www.iana.org/assignments/media-types/model/stl</seealso>
    let ``model/stl`` = Prefixed_Name(mime, "model/stl") |> PrefixedName

    /// <summary>
    ///   <para>mime:model/vnd.collada+xml</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.iana.org/assignments/media-types/model/vnd.collada+xml">https://www.iana.org/assignments/media-types/model/vnd.collada+xml</seealso>
    let ``model/vnd.collada+xml`` =
        Prefixed_Name(mime, "model/vnd.collada+xml") |> PrefixedName

    /// <summary>
    ///   <para>mime:model/x3d+xml</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.iana.org/assignments/media-types/model/x3d+xml">https://www.iana.org/assignments/media-types/model/x3d+xml</seealso>
    let ``model/x3d+xml`` = Prefixed_Name(mime, "model/x3d+xml") |> PrefixedName
    /// <summary>
    ///   <para>mime:model/x3d-vrml</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.iana.org/assignments/media-types/model/x3d-vrml">https://www.iana.org/assignments/media-types/model/x3d-vrml</seealso>
    let ``model/x3d_vrml`` = Prefixed_Name(mime, "model/x3d-vrml") |> PrefixedName
    /// <summary>
    ///   <para>mime:text/html</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.iana.org/assignments/media-types/text/html">https://www.iana.org/assignments/media-types/text/html</seealso>
    let ``text/html`` = Prefixed_Name(mime, "text/html") |> PrefixedName
    /// <summary>
    ///   <para>mime:text/n3</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.iana.org/assignments/media-types/text/n3">https://www.iana.org/assignments/media-types/text/n3</seealso>
    let ``text/n3`` = Prefixed_Name(mime, "text/n3") |> PrefixedName
    /// <summary>
    ///   <para>mime:text/turtle</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.iana.org/assignments/media-types/text/turtle">https://www.iana.org/assignments/media-types/text/turtle</seealso>
    let ``text/turtle`` = Prefixed_Name(mime, "text/turtle") |> PrefixedName
