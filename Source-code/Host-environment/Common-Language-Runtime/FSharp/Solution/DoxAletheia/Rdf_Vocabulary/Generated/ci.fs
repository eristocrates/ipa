namespace https.privatealpha.com.ontology.content_inventory._1.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ci =
    let _namespace_iri = Namespace_Iri ci |> NamespaceIRI
    /// <summary>
    ///   <para>ci:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>bibo:Webpage</para>
    ///   <para>This vocabulary defines a number of concepts peculiar to content strategy which are not accounted for by other vocabularies.</para>
    /// </remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#">https://privatealpha.com/ontology/content-inventory/1#</seealso>
    let _prefix_iri = Prefixed_Name(ci, "") |> PrefixedName
    /// <summary>
    ///   <para>ci:unavailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:DocumentStatus</para>
    ///   <para>The resource at the subject address is unavailable for reasons other than explicit retirement, e.g. HTTP 404 or 403, or going out of print.</para>
    /// labels<para>unavailable</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#unavailable">https://privatealpha.com/ontology/content-inventory/1#unavailable</seealso>
    let unavailable = Prefixed_Name(ci, "unavailable") |> PrefixedName
    /// <summary>
    ///   <para>ci:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An action, as its name implies, is meant to represent something a person or other agent ought to do to a document.</para>
    /// labels<para>Action</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#Action">https://privatealpha.com/ontology/content-inventory/1#Action</seealso>
    let Action = Prefixed_Name(ci, "Action") |> PrefixedName
    /// <summary>
    ///   <para>ci:block</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>A block count is conceptually similar to a word or section count, though it counts the total of elements in the document considered to be text blocks, such as paragraphs, tables, lists and figures. It is suited for document types that have no concept of (semantic) sections, such as HTML. The purpose of this measurement is to provide a sort of ratio to the word count, to glean how well-proportioned the document is.</para>
    /// labels<para>blocks</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#block">https://privatealpha.com/ontology/content-inventory/1#block</seealso>
    let block = Prefixed_Name(ci, "block") |> PrefixedName
    /// <summary>
    ///   <para>ci:canonical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This is the canonical URI of the subject resource, i.e., the one you always want to publish in content or redirect Web requests to.</para>
    /// labels<para>canonical</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#canonical">https://privatealpha.com/ontology/content-inventory/1#canonical</seealso>
    let canonical = Prefixed_Name(ci, "canonical") |> PrefixedName
    /// <summary>
    ///   <para>ci:canonical-slug</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>This is the canonical slug associated with the resource, and should be populated with the slug which is actually in use.</para>
    /// labels<para>canonical-slug</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#canonical-slug">https://privatealpha.com/ontology/content-inventory/1#canonical-slug</seealso>
    let canonical_slug = Prefixed_Name(ci, "canonical-slug") |> PrefixedName
    /// <summary>
    ///   <para>ci:slug</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The slug is a text token which represents either the full path or terminal path segment of an HTTP(S) URL by which a resource can be located. This property is mainly for the purpose of archiving old or alternative URL paths in a content inventory, for such tasks as generating URL rewriting maps.</para>
    /// labels<para>slug</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#slug">https://privatealpha.com/ontology/content-inventory/1#slug</seealso>
    let slug = Prefixed_Name(ci, "slug") |> PrefixedName
    /// <summary>
    ///   <para>ci:characters</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>This indicates the number of characters in a document, with punctuation and the XPath normalize-space function applied. Note this is characters, not bytes.</para>
    /// labels<para>characters</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#characters">https://privatealpha.com/ontology/content-inventory/1#characters</seealso>
    let characters = Prefixed_Name(ci, "characters") |> PrefixedName
    /// <summary>
    ///   <para>ci:document</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DimensionProperty</para>
    ///   <para>Document Reference</para>
    /// labels<para>document</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#document">https://privatealpha.com/ontology/content-inventory/1#document</seealso>
    let document = Prefixed_Name(ci, "document") |> PrefixedName
    /// <summary>
    ///   <para>ci:Merge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>In order to merge a document, we must define the target to which it ought to be merged. This class is identical to an Action, save for such a property.</para>
    /// labels<para>Merge</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#Merge">https://privatealpha.com/ontology/content-inventory/1#Merge</seealso>
    let Merge = Prefixed_Name(ci, "Merge") |> PrefixedName
    /// <summary>
    ///   <para>ci:alias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This is an alternate URI for the subject resource. It is simply meant to annotate a resource with another address. It differs from owl:sameAs in that it does not imply that &lt;a&gt; = &lt;b&gt; as well as &lt;b&gt; = &lt;a&gt;.</para>
    /// labels<para>alias</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#alias">https://privatealpha.com/ontology/content-inventory/1#alias</seealso>
    let alias = Prefixed_Name(ci, "alias") |> PrefixedName
    /// <summary>
    ///   <para>ci:action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>use this to signal an action to take with the document in question.</para>
    /// labels<para>action</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#action">https://privatealpha.com/ontology/content-inventory/1#action</seealso>
    let action = Prefixed_Name(ci, "action") |> PrefixedName
    /// <summary>
    ///   <para>ci:assumes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The document assumes the audience is familiar with this concept, and may not mention it explicitly.</para>
    /// labels<para>assumes</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#assumes">https://privatealpha.com/ontology/content-inventory/1#assumes</seealso>
    let assumes = Prefixed_Name(ci, "assumes") |> PrefixedName
    /// <summary>
    ///   <para>ci:desired-outcome</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is intended to indicate what the document is supposed to do—what material effect it is supposed to produce. It is intentionally open-ended, and as such can point to something like a skos:Concept, another document, or a literal string of text describing the outcome.</para>
    /// labels<para>desired-outcome</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#desired-outcome">https://privatealpha.com/ontology/content-inventory/1#desired-outcome</seealso>
    let desired_outcome = Prefixed_Name(ci, "desired-outcome") |> PrefixedName
    /// <summary>
    ///   <para>ci:embed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies an embedded resource which is visible in the subject's user interface.</para>
    /// labels<para>embed</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#embed">https://privatealpha.com/ontology/content-inventory/1#embed</seealso>
    let embed = Prefixed_Name(ci, "embed") |> PrefixedName
    /// <summary>
    ///   <para>ci:high-quartile</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>Third Quartile</para>
    /// labels<para>high-quartile</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#high-quartile">https://privatealpha.com/ontology/content-inventory/1#high-quartile</seealso>
    let high_quartile = Prefixed_Name(ci, "high-quartile") |> PrefixedName
    /// <summary>
    ///   <para>ci:incorrect</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:DocumentStatus</para>
    ///   <para>The content of this document is factually wrong.</para>
    /// labels<para>incorrect</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#incorrect">https://privatealpha.com/ontology/content-inventory/1#incorrect</seealso>
    let incorrect = Prefixed_Name(ci, "incorrect") |> PrefixedName
    /// <summary>
    ///   <para>ci:introduces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The document defines, describes, or otherwise introduces the audience to this concept.</para>
    /// labels<para>introduces</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#introduces">https://privatealpha.com/ontology/content-inventory/1#introduces</seealso>
    let introduces = Prefixed_Name(ci, "introduces") |> PrefixedName
    /// <summary>
    ///   <para>ci:mentions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The document explicitly mentions this concept.</para>
    /// labels<para>mentions</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#mentions">https://privatealpha.com/ontology/content-inventory/1#mentions</seealso>
    let mentions = Prefixed_Name(ci, "mentions") |> PrefixedName
    /// <summary>
    ///   <para>ci:landing</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:DocumentStatus</para>
    ///   <para>The resource is a landing page from some other medium (e.g. e-mail, television, billboard). This status is a hint to automated systems which would otherwise orphan or retire a landing page with no inbound links.</para>
    /// labels<para>landing</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#landing">https://privatealpha.com/ontology/content-inventory/1#landing</seealso>
    let landing = Prefixed_Name(ci, "landing") |> PrefixedName
    /// <summary>
    ///   <para>ci:low-quartile</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>Equivalent to the bottom quarter, or 25th percentile, of the observed data.</para>
    /// labels<para>low-quartile</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#low-quartile">https://privatealpha.com/ontology/content-inventory/1#low-quartile</seealso>
    let low_quartile = Prefixed_Name(ci, "low-quartile") |> PrefixedName
    /// <summary>
    ///   <para>ci:mean</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>Mean</para>
    /// labels<para>mean</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#mean">https://privatealpha.com/ontology/content-inventory/1#mean</seealso>
    let mean = Prefixed_Name(ci, "mean") |> PrefixedName
    /// <summary>
    ///   <para>ci:empty</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:DocumentStatus</para>
    ///   <para>The document contains no content.</para>
    /// labels<para>empty</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#empty">https://privatealpha.com/ontology/content-inventory/1#empty</seealso>
    let empty = Prefixed_Name(ci, "empty") |> PrefixedName
    /// <summary>
    ///   <para>ci:incomplete</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:DocumentStatus</para>
    ///   <para>The document has been started, but is clearly not finished.</para>
    /// labels<para>incomplete</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#incomplete">https://privatealpha.com/ontology/content-inventory/1#incomplete</seealso>
    let incomplete = Prefixed_Name(ci, "incomplete") |> PrefixedName
    /// <summary>
    ///   <para>ci:indegree</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>The number of links pointing at the specified resource.</para>
    /// labels<para>indegree</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#indegree">https://privatealpha.com/ontology/content-inventory/1#indegree</seealso>
    let indegree = Prefixed_Name(ci, "indegree") |> PrefixedName
    /// <summary>
    ///   <para>ci:keep</para>
    /// </summary>
    /// <remarks>
    ///   <para>ci:Action</para>
    ///   <para>Keep this document to which this is associated; make no changes to it at this time.</para>
    /// labels<para>keep</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#keep">https://privatealpha.com/ontology/content-inventory/1#keep</seealso>
    let keep = Prefixed_Name(ci, "keep") |> PrefixedName
    /// <summary>
    ///   <para>ci:link</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property specifies a linked resource which is visible in the subject's user interface.</para>
    /// labels<para>link</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#link">https://privatealpha.com/ontology/content-inventory/1#link</seealso>
    let link = Prefixed_Name(ci, "link") |> PrefixedName
    /// <summary>
    ///   <para>ci:max</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>Maximum</para>
    /// labels<para>max</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#max">https://privatealpha.com/ontology/content-inventory/1#max</seealso>
    let max = Prefixed_Name(ci, "max") |> PrefixedName
    /// <summary>
    ///   <para>ci:median</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>The median of a population </para>
    /// labels<para>median</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#median">https://privatealpha.com/ontology/content-inventory/1#median</seealso>
    let median = Prefixed_Name(ci, "median") |> PrefixedName
    /// <summary>
    ///   <para>ci:non-audience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property complements dct:audience insofar as enabling the author or editor to designate a set of entities who are explicitly not the intended audience of the document.</para>
    /// labels<para>non-audience</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#non-audience">https://privatealpha.com/ontology/content-inventory/1#non-audience</seealso>
    let non_audience = Prefixed_Name(ci, "non-audience") |> PrefixedName
    /// <summary>
    ///   <para>ci:outdegree</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>The number of links emanating from the specified resource.</para>
    /// labels<para>outdegree</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#outdegree">https://privatealpha.com/ontology/content-inventory/1#outdegree</seealso>
    let outdegree = Prefixed_Name(ci, "outdegree") |> PrefixedName
    /// <summary>
    ///   <para>ci:revise</para>
    /// </summary>
    /// <remarks>
    ///   <para>ci:Action</para>
    ///   <para>Revise or restructure this document.</para>
    /// labels<para>revise</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#revise">https://privatealpha.com/ontology/content-inventory/1#revise</seealso>
    let revise = Prefixed_Name(ci, "revise") |> PrefixedName
    /// <summary>
    ///   <para>ci:sd</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>Standard Deviation</para>
    /// labels<para>sd</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#sd">https://privatealpha.com/ontology/content-inventory/1#sd</seealso>
    let sd = Prefixed_Name(ci, "sd") |> PrefixedName
    /// <summary>
    ///   <para>ci:split</para>
    /// </summary>
    /// <remarks>
    ///   <para>ci:Action</para>
    ///   <para>Split this document into multiple pieces.</para>
    /// labels<para>split</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#split">https://privatealpha.com/ontology/content-inventory/1#split</seealso>
    let split = Prefixed_Name(ci, "split") |> PrefixedName
    /// <summary>
    ///   <para>ci:target</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Specify the URI of the target resource into which this document should be merged.</para>
    /// labels<para>target</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#target">https://privatealpha.com/ontology/content-inventory/1#target</seealso>
    let target = Prefixed_Name(ci, "target") |> PrefixedName
    /// <summary>
    ///   <para>ci:update-metadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>ci:Action</para>
    ///   <para>Update the metadata of this document, such as keywords, audience, etc.</para>
    /// labels<para>update-metadata</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#update-metadata">https://privatealpha.com/ontology/content-inventory/1#update-metadata</seealso>
    let update_metadata = Prefixed_Name(ci, "update-metadata") |> PrefixedName
    /// <summary>
    ///   <para>ci:min</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>The smallest observation in the sample.</para>
    /// labels<para>min</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#min">https://privatealpha.com/ontology/content-inventory/1#min</seealso>
    let min = Prefixed_Name(ci, "min") |> PrefixedName
    /// <summary>
    ///   <para>ci:orphan</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:DocumentStatus</para>
    ///   <para>The resource is not explicitly pending or removed from publication, however it has managed to be disconnected from the rest of the site: There is no path to it from a landing page, and it is not a landing page on its own. That is to say that the resource either has no inbound links, or if it does, those links are from other resources that are in the same situation. Documents which are only linked from retired documents are also considered orphans.</para>
    /// labels<para>orphan</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#orphan">https://privatealpha.com/ontology/content-inventory/1#orphan</seealso>
    let orphan = Prefixed_Name(ci, "orphan") |> PrefixedName
    /// <summary>
    ///   <para>ci:proofread</para>
    /// </summary>
    /// <remarks>
    ///   <para>ci:Action</para>
    ///   <para>Proofread this document.</para>
    /// labels<para>proofread</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#proofread">https://privatealpha.com/ontology/content-inventory/1#proofread</seealso>
    let proofread = Prefixed_Name(ci, "proofread") |> PrefixedName
    /// <summary>
    ///   <para>ci:retired</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:DocumentStatus</para>
    ///   <para>The document has been explicitly retired by an editor or curator, but still exists in the archive.</para>
    /// labels<para>retired</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#retired">https://privatealpha.com/ontology/content-inventory/1#retired</seealso>
    let retired = Prefixed_Name(ci, "retired") |> PrefixedName
    /// <summary>
    ///   <para>ci:rewrite</para>
    /// </summary>
    /// <remarks>
    ///   <para>ci:Action</para>
    ///   <para>Rewrite this document from scratch.</para>
    /// labels<para>rewrite</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#rewrite">https://privatealpha.com/ontology/content-inventory/1#rewrite</seealso>
    let rewrite = Prefixed_Name(ci, "rewrite") |> PrefixedName
    /// <summary>
    ///   <para>ci:sections</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>For document types that have a concrete representation of sections, this property may be used to capture their sum.</para>
    /// labels<para>sections</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#sections">https://privatealpha.com/ontology/content-inventory/1#sections</seealso>
    let sections = Prefixed_Name(ci, "sections") |> PrefixedName
    /// <summary>
    ///   <para>ci:tentative-merge</para>
    /// </summary>
    /// <remarks>
    ///   <para>ci:Merge</para>
    ///   <para>Merge this document into some other document, though unspecified at this time as to which.</para>
    /// labels<para>tentative-merge</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#tentative-merge">https://privatealpha.com/ontology/content-inventory/1#tentative-merge</seealso>
    let tentative_merge = Prefixed_Name(ci, "tentative-merge") |> PrefixedName
    /// <summary>
    ///   <para>ci:words</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:MeasureProperty</para>
    ///   <para>This indicates the number of words in a document, similar to the familiar function in a word processor. The exact method of counting words may vary by document type, language etc., and is thus out of scope from this document.</para>
    /// labels<para>words</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#words">https://privatealpha.com/ontology/content-inventory/1#words</seealso>
    let words = Prefixed_Name(ci, "words") |> PrefixedName
    /// <summary>
    ///   <para>ci:words-and-blocks</para>
    /// </summary>
    /// <remarks>
    ///   <para>qb:DataStructureDefinition</para>
    ///   <para>A set of descriptive statistics pertaining to the number of words per block of text in a given document.</para>
    /// labels<para>words-and-blocks</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#words-and-blocks">https://privatealpha.com/ontology/content-inventory/1#words-and-blocks</seealso>
    let words_and_blocks = Prefixed_Name(ci, "words-and-blocks") |> PrefixedName
    /// <summary>
    ///   <para>ci:blocks</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#blocks">https://privatealpha.com/ontology/content-inventory/1#blocks</seealso>
    let blocks = Prefixed_Name(ci, "blocks") |> PrefixedName
    /// <summary>
    ///   <para>ci:obsolete</para>
    /// </summary>
    /// <remarks>
    ///   <para>bibo:DocumentStatus</para>
    ///   <para>The content of this document was correct and relevant at one point, but external circumstances have caused it to lapse in relevance or factual accuracy.</para>
    /// labels<para>obsolete</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#obsolete">https://privatealpha.com/ontology/content-inventory/1#obsolete</seealso>
    let obsolete = Prefixed_Name(ci, "obsolete") |> PrefixedName
    /// <summary>
    ///   <para>ci:retire</para>
    /// </summary>
    /// <remarks>
    ///   <para>ci:Action</para>
    ///   <para>Remove all references to this document and consign it to the archive.</para>
    /// labels<para>retire</para></remarks>
    /// <seealso href="https://privatealpha.com/ontology/content-inventory/1#retire">https://privatealpha.com/ontology/content-inventory/1#retire</seealso>
    let retire = Prefixed_Name(ci, "retire") |> PrefixedName
