#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pmofn =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://premon.fbk.eu/ontology/fn#" "pmofn"

    /// <summary>
    ///   <para>rdfs:label : Core Frame Element (FN)</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#CoreFrameElement">pmofn:CoreFrameElement</a>
    /// </summary>
    let CoreFrameElement = _prefixId.prefix "CoreFrameElement"
    /// <summary>
    ///   <para>rdfs:label : Core-unexpressed Frame Element (FN)</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#CoreUnexpressedFrameElement">pmofn:CoreUnexpressedFrameElement</a>
    /// </summary>
    let CoreUnexpressedFrameElement = _prefixId.prefix "CoreUnexpressedFrameElement"
    /// <summary>
    ///   <para>rdfs:label : Extra-thematic Frame Element (FN)</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#ExtraThematicFrameElement">pmofn:ExtraThematicFrameElement</a>
    /// </summary>
    let ExtraThematicFrameElement = _prefixId.prefix "ExtraThematicFrameElement"
    /// <summary>
    ///   <para>rdfs:label : Frame Element Core Set</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#FECoreSet">pmofn:FECoreSet</a>
    /// </summary>
    let FECoreSet = _prefixId.prefix "FECoreSet"
    /// <summary>
    ///   <para>rdfs:label : Frame (FN)</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#Frame">pmofn:Frame</a>
    /// </summary>
    let Frame = _prefixId.prefix "Frame"
    /// <summary>
    ///   <para>rdfs:label : Frame Element (FN)</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#FrameElement">pmofn:FrameElement</a>
    /// </summary>
    let FrameElement = _prefixId.prefix "FrameElement"
    /// <summary>
    ///   <para>rdfs:label : Lexical Unit Status</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#LUStatus">pmofn:LUStatus</a>
    /// </summary>
    let LUStatus = _prefixId.prefix "LUStatus"
    /// <summary>
    ///   <para>rdfs:label : Lexical Unit</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#LexicalUnit">pmofn:LexicalUnit</a>
    /// </summary>
    let LexicalUnit = _prefixId.prefix "LexicalUnit"
    /// <summary>
    ///   <para>rdfs:label : Peripheral Frame Element (FN)</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#PeripheralFrameElement">pmofn:PeripheralFrameElement</a>
    /// </summary>
    let PeripheralFrameElement = _prefixId.prefix "PeripheralFrameElement"
    /// <summary>
    ///   <para>rdfs:label : Semantic Type</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#SemType">pmofn:SemType</a>
    /// </summary>
    let SemType = _prefixId.prefix "SemType"
    /// <summary>
    ///   <para>rdfs:label : excludes frame element</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#excludesFrameElement">pmofn:excludesFrameElement</a>
    /// </summary>
    let excludesFrameElement = _prefixId.prefix "excludesFrameElement"
    /// <summary>
    ///   <para>rdfs:label : frame element core set</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#feCoreSet">pmofn:feCoreSet</a>
    /// </summary>
    let feCoreSet = _prefixId.prefix "feCoreSet"
    /// <summary>
    ///   <para>rdfs:label : frame relation</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#frameRelation">pmofn:frameRelation</a>
    /// </summary>
    let frameRelation = _prefixId.prefix "frameRelation"
    /// <summary>
    ///   <para>rdfs:label : implicit in</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#implicitIn">pmofn:implicitIn</a>
    /// </summary>
    let implicitIn = _prefixId.prefix "implicitIn"
    /// <summary>
    ///   <para>rdfs:label : incorporated frame element</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#incorporatedFrameElement">pmofn:incorporatedFrameElement</a>
    /// </summary>
    let incorporatedFrameElement = _prefixId.prefix "incorporatedFrameElement"
    /// <summary>
    ///   <para>rdfs:label : inherits from</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#inheritsFrom">pmofn:inheritsFrom</a>
    /// </summary>
    let inheritsFrom = _prefixId.prefix "inheritsFrom"
    /// <summary>
    ///   <para>rdfs:label : frame element mapping (on inheritsFrom frame relation)</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#inheritsFromFER">pmofn:inheritsFromFER</a>
    /// </summary>
    let inheritsFromFER = _prefixId.prefix "inheritsFromFER"
    /// <summary>
    ///   <para>rdfs:label : is causative of</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#isCausativeOf">pmofn:isCausativeOf</a>
    /// </summary>
    let isCausativeOf = _prefixId.prefix "isCausativeOf"
    /// <summary>
    ///   <para>rdfs:label : frame element mapping (on isCausativeOf frame relation)</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#isCausativeOfFER">pmofn:isCausativeOfFER</a>
    /// </summary>
    let isCausativeOfFER = _prefixId.prefix "isCausativeOfFER"
    /// <summary>
    ///   <para>rdfs:label : is inchoative of</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#isInchoativeOf">pmofn:isInchoativeOf</a>
    /// </summary>
    let isInchoativeOf = _prefixId.prefix "isInchoativeOf"
    /// <summary>
    ///   <para>rdfs:label : frame element mapping (on isInchoativeOf frame relation)</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#isInchoativeOfFER">pmofn:isInchoativeOfFER</a>
    /// </summary>
    let isInchoativeOfFER = _prefixId.prefix "isInchoativeOfFER"
    /// <summary>
    ///   <para>rdfs:label : perspective on</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#perspectiveOn">pmofn:perspectiveOn</a>
    /// </summary>
    let perspectiveOn = _prefixId.prefix "perspectiveOn"
    /// <summary>
    ///   <para>rdfs:label : frame element mapping (on perspectiveOn frame relation)</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#perspectiveOnFER">pmofn:perspectiveOnFER</a>
    /// </summary>
    let perspectiveOnFER = _prefixId.prefix "perspectiveOnFER"
    /// <summary>
    ///   <para>rdfs:label : precedes</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#precedes">pmofn:precedes</a>
    /// </summary>
    let precedes = _prefixId.prefix "precedes"
    /// <summary>
    ///   <para>rdfs:label : frame element mapping (on precedes frame relation)</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#precedesFER">pmofn:precedesFER</a>
    /// </summary>
    let precedesFER = _prefixId.prefix "precedesFER"
    /// <summary>
    ///   <para>rdfs:label : re-frame mapping</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#reFrameMapping">pmofn:reFrameMapping</a>
    /// </summary>
    let reFrameMapping = _prefixId.prefix "reFrameMapping"
    /// <summary>
    ///   <para>rdfs:label : frame element mapping (on reFrameMapping frame relation)</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#reFrameMappingFER">pmofn:reFrameMappingFER</a>
    /// </summary>
    let reFrameMappingFER = _prefixId.prefix "reFrameMappingFER"
    /// <summary>
    ///   <para>rdfs:label : requires frame element</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#requiresFrameElement">pmofn:requiresFrameElement</a>
    /// </summary>
    let requiresFrameElement = _prefixId.prefix "requiresFrameElement"
    /// <summary>
    ///   <para>rdfs:label : see also</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#seeAlso">pmofn:seeAlso</a>
    /// </summary>
    let seeAlso = _prefixId.prefix "seeAlso"
    /// <summary>
    ///   <para>rdfs:label : frame element mapping (on seeAlso frame relation)</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#seeAlsoFER">pmofn:seeAlsoFER</a>
    /// </summary>
    let seeAlsoFER = _prefixId.prefix "seeAlsoFER"
    /// <summary>
    ///   <para>rdfs:label : semantic type</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#semType">pmofn:semType</a>
    /// </summary>
    let semType = _prefixId.prefix "semType"
    /// <summary>
    ///   <para>rdfs:label : status</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#status">pmofn:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>rdfs:label : sub-type of</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#subTypeOf">pmofn:subTypeOf</a>
    /// </summary>
    let subTypeOf = _prefixId.prefix "subTypeOf"
    /// <summary>
    ///   <para>rdfs:label : sub-frame of</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#subframeOf">pmofn:subframeOf</a>
    /// </summary>
    let subframeOf = _prefixId.prefix "subframeOf"
    /// <summary>
    ///   <para>rdfs:label : frame element mapping (on subframeOf frame relation)</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#subframeOfFER">pmofn:subframeOfFER</a>
    /// </summary>
    let subframeOfFER = _prefixId.prefix "subframeOfFER"
    /// <summary>
    ///   <para>rdfs:label : uses</para>
    ///   <a href="http://premon.fbk.eu/ontology/fn#uses">pmofn:uses</a>
    /// </summary>
    let uses = _prefixId.prefix "uses"
