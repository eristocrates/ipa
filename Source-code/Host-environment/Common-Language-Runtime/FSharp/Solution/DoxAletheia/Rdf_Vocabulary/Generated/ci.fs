namespace https.privatealpha.com.ontology.content_inventory._1.hash

open DoxAletheia

module ci =
    let _namespace_name = "https://privatealpha.com/ontology/content-inventory/1#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An action, as its name implies, is meant to represent something a person or other agent ought to do to a document.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#Action"></see></summary>
    let Action = _prefix "Action"
    /// <summary>
    /// In order to merge a document, we must define the target to which it ought to be merged. This class is identical to an Action, save for such a property.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#Merge"></see></summary>
    let Merge = _prefix "Merge"
    /// <summary>
    /// use this to signal an action to take with the document in question.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#action"></see></summary>
    let action = _prefix "action"
    /// <summary>
    /// This is an alternate URI for the subject resource. It is simply meant to annotate a resource with another address. It differs from owl:sameAs in that it does not imply that &lt;a&gt; = &lt;b&gt; as well as &lt;b&gt; = &lt;a&gt;.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#alias"></see></summary>
    let alias = _prefix "alias"
    /// <summary>
    /// The document assumes the audience is familiar with this concept, and may not mention it explicitly.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#assumes"></see></summary>
    let assumes = _prefix "assumes"
    /// <summary>
    /// A block count is conceptually similar to a word or section count, though it counts the total of elements in the document considered to be text blocks, such as paragraphs, tables, lists and figures. It is suited for document types that have no concept of (semantic) sections, such as HTML. The purpose of this measurement is to provide a sort of ratio to the word count, to glean how well-proportioned the document is.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#block"></see></summary>
    let block = _prefix "block"
    /// <summary>
    /// This is the canonical URI of the subject resource, i.e., the one you always want to publish in content or redirect Web requests to.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#canonical"></see></summary>
    let canonical = _prefix "canonical"
    /// <summary>
    /// This is the canonical slug associated with the resource, and should be populated with the slug which is actually in use.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#canonical-slug"></see></summary>
    let ``canonical-slug`` = _prefix "canonical-slug"
    /// <summary>
    /// The slug is a text token which represents either the full path or terminal path segment of an HTTP(S) URL by which a resource can be located. This property is mainly for the purpose of archiving old or alternative URL paths in a content inventory, for such tasks as generating URL rewriting maps.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#slug"></see></summary>
    let slug = _prefix "slug"
    /// <summary>
    /// This indicates the number of characters in a document, with punctuation and the XPath normalize-space function applied. Note this is characters, not bytes.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#characters"></see></summary>
    let characters = _prefix "characters"
    /// <summary>
    /// This property is intended to indicate what the document is supposed to do—what material effect it is supposed to produce. It is intentionally open-ended, and as such can point to something like a skos:Concept, another document, or a literal string of text describing the outcome.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#desired-outcome"></see></summary>
    let ``desired-outcome`` = _prefix "desired-outcome"
    /// <summary>
    /// Document Reference
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#document"></see></summary>
    let document = _prefix "document"
    /// <summary>
    /// This property specifies an embedded resource which is visible in the subject's user interface.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#embed"></see></summary>
    let embed = _prefix "embed"
    /// <summary>
    /// The document contains no content.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#empty"></see></summary>
    let empty = _prefix "empty"
    /// <summary>
    /// Third Quartile
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#high-quartile"></see></summary>
    let ``high-quartile`` = _prefix "high-quartile"
    /// <summary>
    /// The document has been started, but is clearly not finished.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#incomplete"></see></summary>
    let incomplete = _prefix "incomplete"
    /// <summary>
    /// The content of this document is factually wrong.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#incorrect"></see></summary>
    let incorrect = _prefix "incorrect"
    /// <summary>
    /// The number of links pointing at the specified resource.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#indegree"></see></summary>
    let indegree = _prefix "indegree"
    /// <summary>
    /// The document defines, describes, or otherwise introduces the audience to this concept.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#introduces"></see></summary>
    let introduces = _prefix "introduces"
    /// <summary>
    /// The document explicitly mentions this concept.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#mentions"></see></summary>
    let mentions = _prefix "mentions"
    /// <summary>
    /// Keep this document to which this is associated; make no changes to it at this time.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#keep"></see></summary>
    let keep = _prefix "keep"
    /// <summary>
    /// The resource is a landing page from some other medium (e.g. e-mail, television, billboard). This status is a hint to automated systems which would otherwise orphan or retire a landing page with no inbound links.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#landing"></see></summary>
    let landing = _prefix "landing"
    /// <summary>
    /// This property specifies a linked resource which is visible in the subject's user interface.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#link"></see></summary>
    let link = _prefix "link"
    /// <summary>
    /// Equivalent to the bottom quarter, or 25th percentile, of the observed data.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#low-quartile"></see></summary>
    let ``low-quartile`` = _prefix "low-quartile"
    /// <summary>
    /// Maximum
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#max"></see></summary>
    let max = _prefix "max"
    /// <summary>
    /// Mean
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#mean"></see></summary>
    let mean = _prefix "mean"
    /// <summary>
    /// The median of a population
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#median"></see></summary>
    let median = _prefix "median"
    /// <summary>
    /// The smallest observation in the sample.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#min"></see></summary>
    let min = _prefix "min"
    /// <summary>
    /// This property complements dct:audience insofar as enabling the author or editor to designate a set of entities who are explicitly not the intended audience of the document.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#non-audience"></see></summary>
    let ``non-audience`` = _prefix "non-audience"
    /// <summary>
    /// The content of this document was correct and relevant at one point, but external circumstances have caused it to lapse in relevance or factual accuracy.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#obsolete"></see></summary>
    let obsolete = _prefix "obsolete"
    /// <summary>
    /// The resource is not explicitly pending or removed from publication, however it has managed to be disconnected from the rest of the site: There is no path to it from a landing page, and it is not a landing page on its own. That is to say that the resource either has no inbound links, or if it does, those links are from other resources that are in the same situation. Documents which are only linked from retired documents are also considered orphans.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#orphan"></see></summary>
    let orphan = _prefix "orphan"
    /// <summary>
    /// The number of links emanating from the specified resource.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#outdegree"></see></summary>
    let outdegree = _prefix "outdegree"
    /// <summary>
    /// Proofread this document.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#proofread"></see></summary>
    let proofread = _prefix "proofread"
    /// <summary>
    /// Remove all references to this document and consign it to the archive.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#retire"></see></summary>
    let retire = _prefix "retire"
    /// <summary>
    /// The document has been explicitly retired by an editor or curator, but still exists in the archive.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#retired"></see></summary>
    let retired = _prefix "retired"
    /// <summary>
    /// Revise or restructure this document.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#revise"></see></summary>
    let revise = _prefix "revise"
    /// <summary>
    /// Rewrite this document from scratch.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#rewrite"></see></summary>
    let rewrite = _prefix "rewrite"
    /// <summary>
    /// Standard Deviation
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#sd"></see></summary>
    let sd = _prefix "sd"
    /// <summary>
    /// For document types that have a concrete representation of sections, this property may be used to capture their sum.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#sections"></see></summary>
    let sections = _prefix "sections"
    /// <summary>
    /// Split this document into multiple pieces.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#split"></see></summary>
    let split = _prefix "split"
    /// <summary>
    /// Specify the URI of the target resource into which this document should be merged.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#target"></see></summary>
    let target = _prefix "target"
    /// <summary>
    /// Merge this document into some other document, though unspecified at this time as to which.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#tentative-merge"></see></summary>
    let ``tentative-merge`` = _prefix "tentative-merge"
    /// <summary>
    /// The resource at the subject address is unavailable for reasons other than explicit retirement, e.g. HTTP 404 or 403, or going out of print.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#unavailable"></see></summary>
    let unavailable = _prefix "unavailable"
    /// <summary>
    /// Update the metadata of this document, such as keywords, audience, etc.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#update-metadata"></see></summary>
    let ``update-metadata`` = _prefix "update-metadata"
    /// <summary>
    /// This indicates the number of words in a document, similar to the familiar function in a word processor. The exact method of counting words may vary by document type, language etc., and is thus out of scope from this document.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#words"></see></summary>
    let words = _prefix "words"
    /// <summary>
    /// A set of descriptive statistics pertaining to the number of words per block of text in a given document.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#words-and-blocks"></see></summary>
    let ``words-and-blocks`` = _prefix "words-and-blocks"
    /// <summary>
    ///   <see href="https://privatealpha.com/ontology/content-inventory/1#blocks"></see>
    /// </summary>
    let blocks = _prefix "blocks"
