namespace http.premon.fbk.eu.ontology.fn.hash

open DoxAletheia.Rdf_Vocabulary

module pmofn =
    let _namespace_name = "http://premon.fbk.eu/ontology/fn#"

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#inheritsFrom"></see>
    /// </summary>
    let inheritsFrom =
        Namespaced_IRI.parse _namespace_name "inheritsFrom" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#isCausativeOf"></see>
    /// </summary>
    let isCausativeOf =
        Namespaced_IRI.parse _namespace_name "isCausativeOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#isInchoativeOf"></see>
    /// </summary>
    let isInchoativeOf =
        Namespaced_IRI.parse _namespace_name "isInchoativeOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#perspectiveOn"></see>
    /// </summary>
    let perspectiveOn =
        Namespaced_IRI.parse _namespace_name "perspectiveOn" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#precedes"></see>
    /// </summary>
    let precedes = Namespaced_IRI.parse _namespace_name "precedes" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#reFrameMapping"></see>
    /// </summary>
    let reFrameMapping =
        Namespaced_IRI.parse _namespace_name "reFrameMapping" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#seeAlso"></see>
    /// </summary>
    let seeAlso = Namespaced_IRI.parse _namespace_name "seeAlso" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#subframeOf"></see>
    /// </summary>
    let subframeOf = Namespaced_IRI.parse _namespace_name "subframeOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#uses"></see>
    /// </summary>
    let uses = Namespaced_IRI.parse _namespace_name "uses" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#CoreFrameElement"></see>
    /// </summary>
    let CoreFrameElement =
        Namespaced_IRI.parse _namespace_name "CoreFrameElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#FrameElement"></see>
    /// </summary>
    let FrameElement =
        Namespaced_IRI.parse _namespace_name "FrameElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#CoreUnexpressedFrameElement"></see>
    /// </summary>
    let CoreUnexpressedFrameElement =
        Namespaced_IRI.parse _namespace_name "CoreUnexpressedFrameElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#ExtraThematicFrameElement"></see>
    /// </summary>
    let ExtraThematicFrameElement =
        Namespaced_IRI.parse _namespace_name "ExtraThematicFrameElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#FECoreSet"></see>
    /// </summary>
    let FECoreSet = Namespaced_IRI.parse _namespace_name "FECoreSet" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#Frame"></see>
    /// </summary>
    let Frame = Namespaced_IRI.parse _namespace_name "Frame" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#LexicalUnit"></see>
    /// </summary>
    let LexicalUnit =
        Namespaced_IRI.parse _namespace_name "LexicalUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#PeripheralFrameElement"></see>
    /// </summary>
    let PeripheralFrameElement =
        Namespaced_IRI.parse _namespace_name "PeripheralFrameElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#LUStatus"></see>
    /// </summary>
    let LUStatus = Namespaced_IRI.parse _namespace_name "LUStatus" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#SemType"></see>
    /// </summary>
    let SemType = Namespaced_IRI.parse _namespace_name "SemType" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#excludesFrameElement"></see>
    /// </summary>
    let excludesFrameElement =
        Namespaced_IRI.parse _namespace_name "excludesFrameElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#requiresFrameElement"></see>
    /// </summary>
    let requiresFrameElement =
        Namespaced_IRI.parse _namespace_name "requiresFrameElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#feCoreSet"></see>
    /// </summary>
    let feCoreSet = Namespaced_IRI.parse _namespace_name "feCoreSet" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#frameRelation"></see>
    /// </summary>
    let frameRelation =
        Namespaced_IRI.parse _namespace_name "frameRelation" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#implicitIn"></see>
    /// </summary>
    let implicitIn = Namespaced_IRI.parse _namespace_name "implicitIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#incorporatedFrameElement"></see>
    /// </summary>
    let incorporatedFrameElement =
        Namespaced_IRI.parse _namespace_name "incorporatedFrameElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#inheritsFromFER"></see>
    /// </summary>
    let inheritsFromFER =
        Namespaced_IRI.parse _namespace_name "inheritsFromFER" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#isCausativeOfFER"></see>
    /// </summary>
    let isCausativeOfFER =
        Namespaced_IRI.parse _namespace_name "isCausativeOfFER" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#isInchoativeOfFER"></see>
    /// </summary>
    let isInchoativeOfFER =
        Namespaced_IRI.parse _namespace_name "isInchoativeOfFER" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#perspectiveOnFER"></see>
    /// </summary>
    let perspectiveOnFER =
        Namespaced_IRI.parse _namespace_name "perspectiveOnFER" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#precedesFER"></see>
    /// </summary>
    let precedesFER =
        Namespaced_IRI.parse _namespace_name "precedesFER" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#reFrameMappingFER"></see>
    /// </summary>
    let reFrameMappingFER =
        Namespaced_IRI.parse _namespace_name "reFrameMappingFER" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#seeAlsoFER"></see>
    /// </summary>
    let seeAlsoFER = Namespaced_IRI.parse _namespace_name "seeAlsoFER" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#semType"></see>
    /// </summary>
    let semType = Namespaced_IRI.parse _namespace_name "semType" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#status"></see>
    /// </summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#subTypeOf"></see>
    /// </summary>
    let subTypeOf = Namespaced_IRI.parse _namespace_name "subTypeOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#subframeOfFER"></see>
    /// </summary>
    let subframeOfFER =
        Namespaced_IRI.parse _namespace_name "subframeOfFER" |> NamespacedName
