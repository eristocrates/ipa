namespace http.premon.fbk.eu.ontology.fn.hash

open DoxAletheia

module pmofn =
    let _namespace_name = "http://premon.fbk.eu/ontology/fn#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#inheritsFrom"></see>
    /// </summary>
    let inheritsFrom = _prefix "inheritsFrom"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#isCausativeOf"></see>
    /// </summary>
    let isCausativeOf = _prefix "isCausativeOf"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#isInchoativeOf"></see>
    /// </summary>
    let isInchoativeOf = _prefix "isInchoativeOf"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#perspectiveOn"></see>
    /// </summary>
    let perspectiveOn = _prefix "perspectiveOn"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#precedes"></see>
    /// </summary>
    let precedes = _prefix "precedes"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#reFrameMapping"></see>
    /// </summary>
    let reFrameMapping = _prefix "reFrameMapping"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#seeAlso"></see>
    /// </summary>
    let seeAlso = _prefix "seeAlso"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#subframeOf"></see>
    /// </summary>
    let subframeOf = _prefix "subframeOf"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#uses"></see>
    /// </summary>
    let uses = _prefix "uses"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#CoreFrameElement"></see>
    /// </summary>
    let CoreFrameElement = _prefix "CoreFrameElement"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#FrameElement"></see>
    /// </summary>
    let FrameElement = _prefix "FrameElement"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#CoreUnexpressedFrameElement"></see>
    /// </summary>
    let CoreUnexpressedFrameElement = _prefix "CoreUnexpressedFrameElement"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#ExtraThematicFrameElement"></see>
    /// </summary>
    let ExtraThematicFrameElement = _prefix "ExtraThematicFrameElement"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#FECoreSet"></see>
    /// </summary>
    let FECoreSet = _prefix "FECoreSet"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#Frame"></see>
    /// </summary>
    let Frame = _prefix "Frame"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#LexicalUnit"></see>
    /// </summary>
    let LexicalUnit = _prefix "LexicalUnit"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#PeripheralFrameElement"></see>
    /// </summary>
    let PeripheralFrameElement = _prefix "PeripheralFrameElement"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#LUStatus"></see>
    /// </summary>
    let LUStatus = _prefix "LUStatus"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#SemType"></see>
    /// </summary>
    let SemType = _prefix "SemType"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#excludesFrameElement"></see>
    /// </summary>
    let excludesFrameElement = _prefix "excludesFrameElement"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#requiresFrameElement"></see>
    /// </summary>
    let requiresFrameElement = _prefix "requiresFrameElement"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#feCoreSet"></see>
    /// </summary>
    let feCoreSet = _prefix "feCoreSet"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#frameRelation"></see>
    /// </summary>
    let frameRelation = _prefix "frameRelation"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#implicitIn"></see>
    /// </summary>
    let implicitIn = _prefix "implicitIn"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#incorporatedFrameElement"></see>
    /// </summary>
    let incorporatedFrameElement = _prefix "incorporatedFrameElement"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#inheritsFromFER"></see>
    /// </summary>
    let inheritsFromFER = _prefix "inheritsFromFER"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#isCausativeOfFER"></see>
    /// </summary>
    let isCausativeOfFER = _prefix "isCausativeOfFER"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#isInchoativeOfFER"></see>
    /// </summary>
    let isInchoativeOfFER = _prefix "isInchoativeOfFER"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#perspectiveOnFER"></see>
    /// </summary>
    let perspectiveOnFER = _prefix "perspectiveOnFER"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#precedesFER"></see>
    /// </summary>
    let precedesFER = _prefix "precedesFER"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#reFrameMappingFER"></see>
    /// </summary>
    let reFrameMappingFER = _prefix "reFrameMappingFER"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#seeAlsoFER"></see>
    /// </summary>
    let seeAlsoFER = _prefix "seeAlsoFER"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#semType"></see>
    /// </summary>
    let semType = _prefix "semType"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#status"></see>
    /// </summary>
    let status = _prefix "status"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#subTypeOf"></see>
    /// </summary>
    let subTypeOf = _prefix "subTypeOf"
    /// <summary>
    ///   <see href="http://premon.fbk.eu/ontology/fn#subframeOfFER"></see>
    /// </summary>
    let subframeOfFER = _prefix "subframeOfFER"
