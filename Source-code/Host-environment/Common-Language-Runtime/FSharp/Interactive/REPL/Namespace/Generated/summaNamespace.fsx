#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module summa =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/voc/summa/" "summa"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : summary</para>
    ///   <a href="http://purl.org/voc/summa/Summary">summa:Summary</a>
    /// </summary>
    let Summary = _prefixId.prefix "Summary"
    /// <summary>
    ///   <para>rdfs:label : summary group</para>
    ///   <a href="http://purl.org/voc/summa/SummaryGroup">summa:SummaryGroup</a>
    /// </summary>
    let SummaryGroup = _prefixId.prefix "SummaryGroup"
    /// <summary>
    ///   <para>rdfs:label : entity</para>
    ///   <a href="http://purl.org/voc/summa/entity">summa:entity</a>
    /// </summary>
    let entity = _prefixId.prefix "entity"
    /// <summary>
    ///   <para>rdfs:label : fixed property</para>
    ///   <a href="http://purl.org/voc/summa/fixedProperty">summa:fixedProperty</a>
    /// </summary>
    let fixedProperty = _prefixId.prefix "fixedProperty"
    /// <summary>
    ///   <para>rdfs:label : group</para>
    ///   <a href="http://purl.org/voc/summa/group">summa:group</a>
    /// </summary>
    let group = _prefixId.prefix "group"
    /// <summary>
    ///   <para>rdfs:label : langauge</para>
    ///   <a href="http://purl.org/voc/summa/language">summa:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>rdfs:label : maximum number of hops</para>
    ///   <a href="http://purl.org/voc/summa/maxHops">summa:maxHops</a>
    /// </summary>
    let maxHops = _prefixId.prefix "maxHops"
    /// <summary>
    ///   <para>rdfs:label : path</para>
    ///   <a href="http://purl.org/voc/summa/path">summa:path</a>
    /// </summary>
    let path = _prefixId.prefix "path"
    /// <summary>
    ///   <para>rdfs:label : statement</para>
    ///   <a href="http://purl.org/voc/summa/statement">summa:statement</a>
    /// </summary>
    let statement = _prefixId.prefix "statement"
    /// <summary>
    ///   <para>rdfs:label : top k</para>
    ///   <a href="http://purl.org/voc/summa/topK">summa:topK</a>
    /// </summary>
    let topK = _prefixId.prefix "topK"
