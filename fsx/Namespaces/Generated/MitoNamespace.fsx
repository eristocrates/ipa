#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module mito =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/spar/mito/" "mito"
    let _namespaceIri = _prefixId.prefix ""
    let _2024_05_09 = _prefixId.prefix "2024-05-09"
    let _2026_08_14 = _prefixId.prefix "2026-08-14"
    /// <summary>
    ///   <para>rdfs:label : mention</para>
    ///   <para>vann:example :
    ///     :my-mention a mito:Mention ;
    ///         mito:hasMentioningEntity :my-mentioning-entity ;
    ///         mito:hasMentionedEntity :my-mentioned-entity ;
    ///         mito:hasMentionType mito:explicit .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment :
    /// The action or an act of referring to, remarking upon, or introducing the name of a person or thing in spoken or written discourse, often incidentally and as not necessarily essential to the discussion.
    /// </para>
    ///   <para>skos:note :
    /// Originally: the action of calling to mind or commemorating something in speech or writing.
    ///     </para>
    ///   <a href="http://purl.org/spar/mito/Mention">mito:Mention</a>
    /// </summary>
    let Mention = _prefixId.prefix "Mention"
    /// <summary>
    ///   <para>rdfs:label : mention type</para>
    ///   <para>vann:example :
    ///     :my-mention a mito:Mention ;
    ///         mito:hasMentionType mito:explicit .
    ///
    ///     mito:explicit a mito:MentionType .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The reified implicit or explicit characteristic of a mention.</para>
    ///   <a href="http://purl.org/spar/mito/MentionType">mito:MentionType</a>
    /// </summary>
    let MentionType = _prefixId.prefix "MentionType"
    let explicit = _prefixId.prefix "explicit"
    /// <summary>
    ///   <para>rdfs:label : has mention type</para>
    ///   <para>vann:example :
    ///     :my-mention a mito:Mention ;
    ///         mito:hasMentionType mito:explicit .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The implicit or explicit characterisation of the mention it is describing.</para>
    ///   <a href="http://purl.org/spar/mito/hasMentionType">mito:hasMentionType</a>
    /// </summary>
    let hasMentionType = _prefixId.prefix "hasMentionType"
    /// <summary>
    ///   <para>rdfs:label : has mentioned entity</para>
    ///   <para>vann:example :
    ///     :my-mention a mito:Mention ;
    ///         mito:hasMentionedEntity :my-mentioned-entity .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between a mention and a mentioned entity.</para>
    ///   <a href="http://purl.org/spar/mito/hasMentionedEntity">mito:hasMentionedEntity</a>
    /// </summary>
    let hasMentionedEntity = _prefixId.prefix "hasMentionedEntity"
    /// <summary>
    ///   <para>rdfs:label : has mentioning entity</para>
    ///   <para>vann:example :
    ///     :my-mention a mito:Mention ;
    ///         mito:hasMentioningEntity :my-mentioning-entity .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between a mention and a mentioning entity.</para>
    ///   <a href="http://purl.org/spar/mito/hasMentioningEntity">mito:hasMentioningEntity</a>
    /// </summary>
    let hasMentioningEntity = _prefixId.prefix "hasMentioningEntity"
    let implicit = _prefixId.prefix "implicit"
    /// <summary>
    ///   <para>rdfs:label : is mentioned by</para>
    ///   <para>vann:example :
    ///     :my-software a fabio:Software ;
    ///         dcterms:title "Tensorflow" ;
    ///         mito:isMentionedBy :my-journal-article .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between the two sides involved in the act of mentioning, with one entity being mentioned by the other.</para>
    ///   <a href="http://purl.org/spar/mito/isMentionedBy">mito:isMentionedBy</a>
    /// </summary>
    let isMentionedBy = _prefixId.prefix "isMentionedBy"
    /// <summary>
    ///   <para>rdfs:label : mentions</para>
    ///   <para>vann:example :
    /// 	:my-journal-article a fabio:JournalArticle ;
    ///         dcterms:title "Deep Learning Approaches for Medical Image Segmentation" ;
    ///         mito:mentions :my-software .
    ///     ^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between the two sides involved in the act of mentioning, with one entity mentioning the other.</para>
    ///   <a href="http://purl.org/spar/mito/mentions">mito:mentions</a>
    /// </summary>
    let mentions = _prefixId.prefix "mentions"
