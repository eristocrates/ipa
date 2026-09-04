#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pnt =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://data.press.net/ontology/tag/" "pnt"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Generic Tag Class - Taggables are tagged with a Tag</para>
    ///   <para>rdfs:label : Generic Tag Class</para>
    ///   <a href="http://data.press.net/ontology/tag/Tag">pnt:Tag</a>
    /// </summary>
    let Tag = _prefixId.prefix "Tag"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Generic Taggable Class - Taggable things can be tagged</para>
    ///   <para>rdfs:label : Generic Taggable Class</para>
    ///   <a href="http://data.press.net/ontology/tag/Taggable">pnt:Taggable</a>
    /// </summary>
    let Taggable = _prefixId.prefix "Taggable"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Property that associates Tags with Taggables, refines pnt:isTaggedWith:  Taggable X about Tag Y.  pnt:about is a stronger relationship that pnt:mentions</para>
    ///   <para>rdfs:label : Property that associates Tags with Taggables refining pnt:isTaggedWith</para>
    ///   <a href="http://data.press.net/ontology/tag/about">pnt:about</a>
    /// </summary>
    let about = _prefixId.prefix "about"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Property that associates Tags with Taggables:  Taggable X isTaggedWith Tag Y</para>
    ///   <para>rdfs:label : Property that associates Tags with Taggables</para>
    ///   <a href="http://data.press.net/ontology/tag/isTaggedWith">pnt:isTaggedWith</a>
    /// </summary>
    let isTaggedWith = _prefixId.prefix "isTaggedWith"
    /// <summary>
    ///   <para>vs:term_status : testing^^xsd:string</para>
    ///   <para>rdfs:comment : Property that associates Tags with Taggables, refines pnt:isTaggedWith:  Taggable X mentions Tag Y.  pnt:mentions is a weaker relationship that pnt:about</para>
    ///   <para>rdfs:label : Property that associates Tags with Taggables refining pnt:isTaggedWith</para>
    ///   <a href="http://data.press.net/ontology/tag/mentions">pnt:mentions</a>
    /// </summary>
    let mentions = _prefixId.prefix "mentions"
