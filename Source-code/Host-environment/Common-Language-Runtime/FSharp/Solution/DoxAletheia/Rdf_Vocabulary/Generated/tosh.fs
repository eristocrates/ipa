namespace http.topbraid.org.tosh.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tosh =
    let _namespace_iri = Namespace_Iri tosh |> NamespaceIRI
    /// <summary>
    ///   <para>tosh:AboutPropertyGroup</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://topbraid.org/tosh#AboutPropertyGroup">http://topbraid.org/tosh#AboutPropertyGroup</seealso>
    let AboutPropertyGroup = Prefixed_Name(tosh, "AboutPropertyGroup") |> PrefixedName
    /// <summary>
    ///   <para>tosh:PropertyShapeShape</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://topbraid.org/tosh#PropertyShapeShape">http://topbraid.org/tosh#PropertyShapeShape</seealso>
    let PropertyShapeShape = Prefixed_Name(tosh, "PropertyShapeShape") |> PrefixedName

    /// <summary>
    ///   <para>tosh:PropertyShapeShape-name</para>
    /// </summary>
    /// <remarks>
    ///   <para>shacl:PropertyShape</para>
    /// </remarks>
    /// <seealso href="http://topbraid.org/tosh#PropertyShapeShape-name">http://topbraid.org/tosh#PropertyShapeShape-name</seealso>
    let PropertyShapeShape_name =
        Prefixed_Name(tosh, "PropertyShapeShape-name") |> PrefixedName

    /// <summary>
    ///   <para>tosh:editGroupDescription</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://topbraid.org/tosh#editGroupDescription">http://topbraid.org/tosh#editGroupDescription</seealso>
    let editGroupDescription =
        Prefixed_Name(tosh, "editGroupDescription") |> PrefixedName

    /// <summary>
    ///   <para>tosh:editWidget</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://topbraid.org/tosh#editWidget">http://topbraid.org/tosh#editWidget</seealso>
    let editWidget = Prefixed_Name(tosh, "editWidget") |> PrefixedName
    /// <summary>
    ///   <para>tosh:openable</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://topbraid.org/tosh#openable">http://topbraid.org/tosh#openable</seealso>
    let openable = Prefixed_Name(tosh, "openable") |> PrefixedName
