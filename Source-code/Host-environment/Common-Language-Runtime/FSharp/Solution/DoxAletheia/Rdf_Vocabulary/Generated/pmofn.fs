namespace http.premon.fbk.eu.ontology.fn.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pmofn =
    let _namespace_iri = Namespace_Iri pmofn |> NamespaceIRI
    /// <summary>
    ///   <para>pmofn:isCausativeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is causative of</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#isCausativeOf">http://premon.fbk.eu/ontology/fn#isCausativeOf</seealso>
    let isCausativeOf = Prefixed_Name(pmofn, "isCausativeOf") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:isInchoativeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is inchoative of</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#isInchoativeOf">http://premon.fbk.eu/ontology/fn#isInchoativeOf</seealso>
    let isInchoativeOf = Prefixed_Name(pmofn, "isInchoativeOf") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:seeAlso</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>see also</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#seeAlso">http://premon.fbk.eu/ontology/fn#seeAlso</seealso>
    let seeAlso = Prefixed_Name(pmofn, "seeAlso") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:reFrameMapping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>re-frame mapping</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#reFrameMapping">http://premon.fbk.eu/ontology/fn#reFrameMapping</seealso>
    let reFrameMapping = Prefixed_Name(pmofn, "reFrameMapping") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:uses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>uses</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#uses">http://premon.fbk.eu/ontology/fn#uses</seealso>
    let uses = Prefixed_Name(pmofn, "uses") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:perspectiveOnFER</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>frame element mapping (on perspectiveOn frame relation)</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#perspectiveOnFER">http://premon.fbk.eu/ontology/fn#perspectiveOnFER</seealso>
    let perspectiveOnFER = Prefixed_Name(pmofn, "perspectiveOnFER") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:semType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>semantic type</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#semType">http://premon.fbk.eu/ontology/fn#semType</seealso>
    let semType = Prefixed_Name(pmofn, "semType") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>status</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#status">http://premon.fbk.eu/ontology/fn#status</seealso>
    let status = Prefixed_Name(pmofn, "status") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:CoreFrameElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Core Frame Element (FN)</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#CoreFrameElement">http://premon.fbk.eu/ontology/fn#CoreFrameElement</seealso>
    let CoreFrameElement = Prefixed_Name(pmofn, "CoreFrameElement") |> PrefixedName

    /// <summary>
    ///   <para>pmofn:ExtraThematicFrameElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Extra-thematic Frame Element (FN)</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#ExtraThematicFrameElement">http://premon.fbk.eu/ontology/fn#ExtraThematicFrameElement</seealso>
    let ExtraThematicFrameElement =
        Prefixed_Name(pmofn, "ExtraThematicFrameElement") |> PrefixedName

    /// <summary>
    ///   <para>pmofn:Frame</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Frame (FN)</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#Frame">http://premon.fbk.eu/ontology/fn#Frame</seealso>
    let Frame = Prefixed_Name(pmofn, "Frame") |> PrefixedName

    /// <summary>
    ///   <para>pmofn:CoreUnexpressedFrameElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Core-unexpressed Frame Element (FN)</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#CoreUnexpressedFrameElement">http://premon.fbk.eu/ontology/fn#CoreUnexpressedFrameElement</seealso>
    let CoreUnexpressedFrameElement =
        Prefixed_Name(pmofn, "CoreUnexpressedFrameElement") |> PrefixedName

    /// <summary>
    ///   <para>pmofn:FrameElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Frame Element (FN)</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#FrameElement">http://premon.fbk.eu/ontology/fn#FrameElement</seealso>
    let FrameElement = Prefixed_Name(pmofn, "FrameElement") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:FECoreSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Frame Element Core Set</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#FECoreSet">http://premon.fbk.eu/ontology/fn#FECoreSet</seealso>
    let FECoreSet = Prefixed_Name(pmofn, "FECoreSet") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:LexicalUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Lexical Unit</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#LexicalUnit">http://premon.fbk.eu/ontology/fn#LexicalUnit</seealso>
    let LexicalUnit = Prefixed_Name(pmofn, "LexicalUnit") |> PrefixedName

    /// <summary>
    ///   <para>pmofn:PeripheralFrameElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Peripheral Frame Element (FN)</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#PeripheralFrameElement">http://premon.fbk.eu/ontology/fn#PeripheralFrameElement</seealso>
    let PeripheralFrameElement =
        Prefixed_Name(pmofn, "PeripheralFrameElement") |> PrefixedName

    /// <summary>
    ///   <para>pmofn:LUStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Lexical Unit Status</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#LUStatus">http://premon.fbk.eu/ontology/fn#LUStatus</seealso>
    let LUStatus = Prefixed_Name(pmofn, "LUStatus") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:SemType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Semantic Type</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#SemType">http://premon.fbk.eu/ontology/fn#SemType</seealso>
    let SemType = Prefixed_Name(pmofn, "SemType") |> PrefixedName

    /// <summary>
    ///   <para>pmofn:requiresFrameElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>requires frame element</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#requiresFrameElement">http://premon.fbk.eu/ontology/fn#requiresFrameElement</seealso>
    let requiresFrameElement =
        Prefixed_Name(pmofn, "requiresFrameElement") |> PrefixedName

    /// <summary>
    ///   <para>pmofn:frameRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>frame relation</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#frameRelation">http://premon.fbk.eu/ontology/fn#frameRelation</seealso>
    let frameRelation = Prefixed_Name(pmofn, "frameRelation") |> PrefixedName

    /// <summary>
    ///   <para>pmofn:excludesFrameElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///
    /// labels<para>excludes frame element</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#excludesFrameElement">http://premon.fbk.eu/ontology/fn#excludesFrameElement</seealso>
    let excludesFrameElement =
        Prefixed_Name(pmofn, "excludesFrameElement") |> PrefixedName

    /// <summary>
    ///   <para>pmofn:feCoreSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///
    /// labels<para>frame element core set</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#feCoreSet">http://premon.fbk.eu/ontology/fn#feCoreSet</seealso>
    let feCoreSet = Prefixed_Name(pmofn, "feCoreSet") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:inheritsFromFER</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>frame element mapping (on inheritsFrom frame relation)</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#inheritsFromFER">http://premon.fbk.eu/ontology/fn#inheritsFromFER</seealso>
    let inheritsFromFER = Prefixed_Name(pmofn, "inheritsFromFER") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:implicitIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>implicit in</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#implicitIn">http://premon.fbk.eu/ontology/fn#implicitIn</seealso>
    let implicitIn = Prefixed_Name(pmofn, "implicitIn") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:isInchoativeOfFER</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>frame element mapping (on isInchoativeOf frame relation)</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#isInchoativeOfFER">http://premon.fbk.eu/ontology/fn#isInchoativeOfFER</seealso>
    let isInchoativeOfFER = Prefixed_Name(pmofn, "isInchoativeOfFER") |> PrefixedName

    /// <summary>
    ///   <para>pmofn:incorporatedFrameElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>incorporated frame element</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#incorporatedFrameElement">http://premon.fbk.eu/ontology/fn#incorporatedFrameElement</seealso>
    let incorporatedFrameElement =
        Prefixed_Name(pmofn, "incorporatedFrameElement") |> PrefixedName

    /// <summary>
    ///   <para>pmofn:isCausativeOfFER</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>frame element mapping (on isCausativeOf frame relation)</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#isCausativeOfFER">http://premon.fbk.eu/ontology/fn#isCausativeOfFER</seealso>
    let isCausativeOfFER = Prefixed_Name(pmofn, "isCausativeOfFER") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:precedesFER</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>frame element mapping (on precedes frame relation)</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#precedesFER">http://premon.fbk.eu/ontology/fn#precedesFER</seealso>
    let precedesFER = Prefixed_Name(pmofn, "precedesFER") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:reFrameMappingFER</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>frame element mapping (on reFrameMapping frame relation)</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#reFrameMappingFER">http://premon.fbk.eu/ontology/fn#reFrameMappingFER</seealso>
    let reFrameMappingFER = Prefixed_Name(pmofn, "reFrameMappingFER") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:subTypeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>sub-type of</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#subTypeOf">http://premon.fbk.eu/ontology/fn#subTypeOf</seealso>
    let subTypeOf = Prefixed_Name(pmofn, "subTypeOf") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:seeAlsoFER</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>frame element mapping (on seeAlso frame relation)</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#seeAlsoFER">http://premon.fbk.eu/ontology/fn#seeAlsoFER</seealso>
    let seeAlsoFER = Prefixed_Name(pmofn, "seeAlsoFER") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:subframeOfFER</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>frame element mapping (on subframeOf frame relation)</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#subframeOfFER">http://premon.fbk.eu/ontology/fn#subframeOfFER</seealso>
    let subframeOfFER = Prefixed_Name(pmofn, "subframeOfFER") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:inheritsFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>inherits from</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#inheritsFrom">http://premon.fbk.eu/ontology/fn#inheritsFrom</seealso>
    let inheritsFrom = Prefixed_Name(pmofn, "inheritsFrom") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:perspectiveOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>perspective on</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#perspectiveOn">http://premon.fbk.eu/ontology/fn#perspectiveOn</seealso>
    let perspectiveOn = Prefixed_Name(pmofn, "perspectiveOn") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:precedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>precedes</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#precedes">http://premon.fbk.eu/ontology/fn#precedes</seealso>
    let precedes = Prefixed_Name(pmofn, "precedes") |> PrefixedName
    /// <summary>
    ///   <para>pmofn:subframeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>sub-frame of</para></remarks>
    /// <seealso href="http://premon.fbk.eu/ontology/fn#subframeOf">http://premon.fbk.eu/ontology/fn#subframeOf</seealso>
    let subframeOf = Prefixed_Name(pmofn, "subframeOf") |> PrefixedName
