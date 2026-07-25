namespace http.ns.inria.fr.ludo.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ludo =
    let _namespace_iri = Namespace_Iri ludo |> NamespaceIRI
    /// <summary>
    ///   <para>ludo:/v1/xapi.rdf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/xapi.rdf">http://ns.inria.fr/ludo/v1/xapi.rdf</seealso>
    let ``_/v1/xapi.rdf`` = Prefixed_Name(ludo, "/v1/xapi.rdf") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/gamepresentation.rdf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamepresentation.rdf">http://ns.inria.fr/ludo/v1/gamepresentation.rdf</seealso>
    let ``_/v1/gamepresentation.rdf`` =
        Prefixed_Name(ludo, "/v1/gamepresentation.rdf") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/gamemodel.rdf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/gamemodel.rdf">http://ns.inria.fr/ludo/v1/gamemodel.rdf</seealso>
    let ``_/v1/gamemodel.rdf`` =
        Prefixed_Name(ludo, "/v1/gamemodel.rdf") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/images/ludo_in_a_nutshell.png</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/images/ludo_in_a_nutshell.png">http://ns.inria.fr/ludo/images/ludo_in_a_nutshell.png</seealso>
    let ``_/images/ludo_in_a_nutshell.png`` =
        Prefixed_Name(ludo, "/images/ludo_in_a_nutshell.png") |> PrefixedName

    /// <summary>
    ///   <para>ludo:/v1/virtualcontext.rdf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.inria.fr/ludo/v1/virtualcontext.rdf">http://ns.inria.fr/ludo/v1/virtualcontext.rdf</seealso>
    let ``_/v1/virtualcontext.rdf`` =
        Prefixed_Name(ludo, "/v1/virtualcontext.rdf") |> PrefixedName
