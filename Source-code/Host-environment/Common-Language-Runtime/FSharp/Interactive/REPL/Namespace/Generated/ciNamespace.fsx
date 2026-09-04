#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ci =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://privatealpha.com/ontology/content-inventory/1#" "ci"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Action^^xsd:string</para>
    ///   <para>rdfs:comment : An action, as its name implies, is meant to represent something a person or other agent ought to do to a document.</para>
    ///   <a href="https://privatealpha.com/ontology/content-inventory/1#Action">ci:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>rdfs:label : Merge^^xsd:string</para>
    ///   <para>rdfs:comment : In order to merge a document, we must define the target to which it ought to be merged. This class is identical to an Action, save for such a property.</para>
    ///   <a href="https://privatealpha.com/ontology/content-inventory/1#Merge">ci:Merge</a>
    /// </summary>
    let Merge = _prefixId.prefix "Merge"
    /// <summary>
    ///   <para>rdfs:label : action^^xsd:string</para>
    ///   <para>rdfs:comment : use this to signal an action to take with the document in question.</para>
    ///   <a href="https://privatealpha.com/ontology/content-inventory/1#action">ci:action</a>
    /// </summary>
    let action = _prefixId.prefix "action"
    /// <summary>
    ///   <para>rdfs:label : alias^^xsd:string</para>
    ///   <para>rdfs:comment : This is an alternate URI for the subject resource. It is simply meant to annotate a resource with another address. It differs from owl:sameAs in that it does not imply that &lt;a&gt; = &lt;b&gt; as well as &lt;b&gt; = &lt;a&gt;.</para>
    ///   <a href="https://privatealpha.com/ontology/content-inventory/1#alias">ci:alias</a>
    /// </summary>
    let alias = _prefixId.prefix "alias"
    /// <summary>
    ///   <para>rdfs:comment : The document assumes the audience is familiar with this concept, and may not mention it explicitly.</para>
    ///   <para>rdfs:label : assumes^^xsd:string</para>
    ///   <a href="https://privatealpha.com/ontology/content-inventory/1#assumes">ci:assumes</a>
    /// </summary>
    let assumes = _prefixId.prefix "assumes"
    let block = _prefixId.prefix "block"
    let blocks = _prefixId.prefix "blocks"
    /// <summary>
    ///   <para>rdfs:label : canonical^^xsd:string</para>
    ///   <para>rdfs:comment : This is the canonical URI of the subject resource, i.e., the one you always want to publish in content or redirect Web requests to.</para>
    ///   <a href="https://privatealpha.com/ontology/content-inventory/1#canonical">ci:canonical</a>
    /// </summary>
    let canonical = _prefixId.prefix "canonical"
    /// <summary>
    ///   <para>rdfs:label : canonical-slug^^xsd:string</para>
    ///   <para>rdfs:comment : This is the canonical slug associated with the resource, and should be populated with the slug which is actually in use.</para>
    ///   <a href="https://privatealpha.com/ontology/content-inventory/1#canonical-slug">ci:canonical-slug</a>
    /// </summary>
    let canonical_slug = _prefixId.prefix "canonical-slug"
    let characters = _prefixId.prefix "characters"
    /// <summary>
    ///   <para>rdfs:label : desired-outcome^^xsd:string</para>
    ///   <para>rdfs:comment : This property is intended to indicate what the document is supposed to do—what material effect it is supposed to produce. It is intentionally open-ended, and as such can point to something like a skos:Concept, another document, or a literal string of text describing the outcome.</para>
    ///   <a href="https://privatealpha.com/ontology/content-inventory/1#desired-outcome">ci:desired-outcome</a>
    /// </summary>
    let desired_outcome = _prefixId.prefix "desired-outcome"
    let document = _prefixId.prefix "document"
    /// <summary>
    ///   <para>rdfs:label : embed^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies an embedded resource which is visible in the subject's user interface.</para>
    ///   <a href="https://privatealpha.com/ontology/content-inventory/1#embed">ci:embed</a>
    /// </summary>
    let embed = _prefixId.prefix "embed"
    let empty = _prefixId.prefix "empty"
    let high_quartile = _prefixId.prefix "high-quartile"
    let incomplete = _prefixId.prefix "incomplete"
    let incorrect = _prefixId.prefix "incorrect"
    let indegree = _prefixId.prefix "indegree"
    /// <summary>
    ///   <para>rdfs:label : introduces^^xsd:string</para>
    ///   <para>rdfs:comment : The document defines, describes, or otherwise introduces the audience to this concept.</para>
    ///   <a href="https://privatealpha.com/ontology/content-inventory/1#introduces">ci:introduces</a>
    /// </summary>
    let introduces = _prefixId.prefix "introduces"
    let keep = _prefixId.prefix "keep"
    let landing = _prefixId.prefix "landing"
    /// <summary>
    ///   <para>rdfs:label : link^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies a linked resource which is visible in the subject's user interface.</para>
    ///   <a href="https://privatealpha.com/ontology/content-inventory/1#link">ci:link</a>
    /// </summary>
    let link = _prefixId.prefix "link"
    let low_quartile = _prefixId.prefix "low-quartile"
    let max = _prefixId.prefix "max"
    let mean = _prefixId.prefix "mean"
    let median = _prefixId.prefix "median"
    /// <summary>
    ///   <para>rdfs:comment : The document explicitly mentions this concept.</para>
    ///   <para>rdfs:label : mentions^^xsd:string</para>
    ///   <a href="https://privatealpha.com/ontology/content-inventory/1#mentions">ci:mentions</a>
    /// </summary>
    let mentions = _prefixId.prefix "mentions"
    let min = _prefixId.prefix "min"
    /// <summary>
    ///   <para>rdfs:comment : This property complements dct:audience insofar as enabling the author or editor to designate a set of entities who are explicitly not the intended audience of the document.</para>
    ///   <para>rdfs:label : non-audience^^xsd:string</para>
    ///   <a href="https://privatealpha.com/ontology/content-inventory/1#non-audience">ci:non-audience</a>
    /// </summary>
    let non_audience = _prefixId.prefix "non-audience"
    let obsolete = _prefixId.prefix "obsolete"
    let orphan = _prefixId.prefix "orphan"
    let outdegree = _prefixId.prefix "outdegree"
    let proofread = _prefixId.prefix "proofread"
    let retire = _prefixId.prefix "retire"
    let retired = _prefixId.prefix "retired"
    let revise = _prefixId.prefix "revise"
    let rewrite = _prefixId.prefix "rewrite"
    let sd = _prefixId.prefix "sd"
    let sections = _prefixId.prefix "sections"
    /// <summary>
    ///   <para>rdfs:label : slug^^xsd:string</para>
    ///   <para>rdfs:comment : The slug is a text token which represents either the full path or terminal path segment of an HTTP(S) URL by which a resource can be located. This property is mainly for the purpose of archiving old or alternative URL paths in a content inventory, for such tasks as generating URL rewriting maps.</para>
    ///   <a href="https://privatealpha.com/ontology/content-inventory/1#slug">ci:slug</a>
    /// </summary>
    let slug = _prefixId.prefix "slug"
    let split = _prefixId.prefix "split"
    /// <summary>
    ///   <para>rdfs:label : target^^xsd:string</para>
    ///   <para>rdfs:comment : Specify the URI of the target resource into which this document should be merged.</para>
    ///   <a href="https://privatealpha.com/ontology/content-inventory/1#target">ci:target</a>
    /// </summary>
    let target = _prefixId.prefix "target"
    let tentative_merge = _prefixId.prefix "tentative-merge"
    let unavailable = _prefixId.prefix "unavailable"
    let update_metadata = _prefixId.prefix "update-metadata"
    let words = _prefixId.prefix "words"
    let words_and_blocks = _prefixId.prefix "words-and-blocks"
