namespace http.data.press.net.ontology.tag.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pnt =
    let _namespace_iri = Namespace_Iri pnt |> NamespaceIRI
    /// <summary>
    ///   <para>pnt:Tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Generic Tag Class - Taggables are tagged with a Tag</para>
    /// labels<para>Generic Tag Class</para></remarks>
    /// <seealso href="http://data.press.net/ontology/tag/Tag">http://data.press.net/ontology/tag/Tag</seealso>
    let Tag = Prefixed_Name(pnt, "Tag") |> PrefixedName
    /// <summary>
    ///   <para>pnt:isTaggedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that associates Tags with Taggables:  Taggable X isTaggedWith Tag Y</para>
    /// labels<para>Property that associates Tags with Taggables</para></remarks>
    /// <seealso href="http://data.press.net/ontology/tag/isTaggedWith">http://data.press.net/ontology/tag/isTaggedWith</seealso>
    let isTaggedWith = Prefixed_Name(pnt, "isTaggedWith") |> PrefixedName
    /// <summary>
    ///   <para>pnt:about</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that associates Tags with Taggables, refines pnt:isTaggedWith:  Taggable X about Tag Y.  pnt:about is a stronger relationship that pnt:mentions</para>
    /// labels<para>Property that associates Tags with Taggables refining pnt:isTaggedWith</para></remarks>
    /// <seealso href="http://data.press.net/ontology/tag/about">http://data.press.net/ontology/tag/about</seealso>
    let about = Prefixed_Name(pnt, "about") |> PrefixedName
    /// <summary>
    ///   <para>pnt:mentions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property that associates Tags with Taggables, refines pnt:isTaggedWith:  Taggable X mentions Tag Y.  pnt:mentions is a weaker relationship that pnt:about</para>
    /// labels<para>Property that associates Tags with Taggables refining pnt:isTaggedWith</para></remarks>
    /// <seealso href="http://data.press.net/ontology/tag/mentions">http://data.press.net/ontology/tag/mentions</seealso>
    let mentions = Prefixed_Name(pnt, "mentions") |> PrefixedName
    /// <summary>
    ///   <para>pnt:Taggable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Generic Taggable Class - Taggable things can be tagged</para>
    /// labels<para>Generic Taggable Class</para></remarks>
    /// <seealso href="http://data.press.net/ontology/tag/Taggable">http://data.press.net/ontology/tag/Taggable</seealso>
    let Taggable = Prefixed_Name(pnt, "Taggable") |> PrefixedName
    /// <summary>
    ///   <para>pnt:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>The Tag Ontology defines relationships for semantically annotating taggable things (for example news assets) with domain entities (stuff) and events.</para>
    /// </remarks>
    /// <seealso href="http://data.press.net/ontology/tag/">http://data.press.net/ontology/tag/</seealso>
    let _prefix_iri = Prefixed_Name(pnt, "") |> PrefixedName
