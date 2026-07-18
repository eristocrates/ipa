namespace https.privatealpha.com.ontology.content_inventory._1.hash

open DoxAletheia.Rdf_Vocabulary

module ci =
    let _namespace_name = "https://privatealpha.com/ontology/content-inventory/1#"
    /// <summary>
    /// An action, as its name implies, is meant to represent something a person or other agent ought to do to a document.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#Action"></see></summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName
    /// <summary>
    /// In order to merge a document, we must define the target to which it ought to be merged. This class is identical to an Action, save for such a property.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#Merge"></see></summary>
    let Merge = Namespaced_IRI.parse _namespace_name "Merge" |> NamespacedName
    /// <summary>
    /// use this to signal an action to take with the document in question.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#action"></see></summary>
    let action = Namespaced_IRI.parse _namespace_name "action" |> NamespacedName
    /// <summary>
    /// This is an alternate URI for the subject resource. It is simply meant to annotate a resource with another address. It differs from owl:sameAs in that it does not imply that &lt;a&gt; = &lt;b&gt; as well as &lt;b&gt; = &lt;a&gt;.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#alias"></see></summary>
    let alias = Namespaced_IRI.parse _namespace_name "alias" |> NamespacedName
    /// <summary>
    /// The document assumes the audience is familiar with this concept, and may not mention it explicitly.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#assumes"></see></summary>
    let assumes = Namespaced_IRI.parse _namespace_name "assumes" |> NamespacedName
    /// <summary>
    /// A block count is conceptually similar to a word or section count, though it counts the total of elements in the document considered to be text blocks, such as paragraphs, tables, lists and figures. It is suited for document types that have no concept of (semantic) sections, such as HTML. The purpose of this measurement is to provide a sort of ratio to the word count, to glean how well-proportioned the document is.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#block"></see></summary>
    let block = Namespaced_IRI.parse _namespace_name "block" |> NamespacedName
    /// <summary>
    /// This is the canonical URI of the subject resource, i.e., the one you always want to publish in content or redirect Web requests to.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#canonical"></see></summary>
    let canonical = Namespaced_IRI.parse _namespace_name "canonical" |> NamespacedName

    /// <summary>
    /// This is the canonical slug associated with the resource, and should be populated with the slug which is actually in use.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#canonical-slug"></see></summary>
    let ``canonical-slug`` =
        Namespaced_IRI.parse _namespace_name "canonical-slug" |> NamespacedName

    /// <summary>
    /// The slug is a text token which represents either the full path or terminal path segment of an HTTP(S) URL by which a resource can be located. This property is mainly for the purpose of archiving old or alternative URL paths in a content inventory, for such tasks as generating URL rewriting maps.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#slug"></see></summary>
    let slug = Namespaced_IRI.parse _namespace_name "slug" |> NamespacedName
    /// <summary>
    /// This indicates the number of characters in a document, with punctuation and the XPath normalize-space function applied. Note this is characters, not bytes.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#characters"></see></summary>
    let characters = Namespaced_IRI.parse _namespace_name "characters" |> NamespacedName

    /// <summary>
    /// This property is intended to indicate what the document is supposed to do—what material effect it is supposed to produce. It is intentionally open-ended, and as such can point to something like a skos:Concept, another document, or a literal string of text describing the outcome.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#desired-outcome"></see></summary>
    let ``desired-outcome`` =
        Namespaced_IRI.parse _namespace_name "desired-outcome" |> NamespacedName

    /// <summary>
    /// Document Reference
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#document"></see></summary>
    let document = Namespaced_IRI.parse _namespace_name "document" |> NamespacedName
    /// <summary>
    /// This property specifies an embedded resource which is visible in the subject's user interface.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#embed"></see></summary>
    let embed = Namespaced_IRI.parse _namespace_name "embed" |> NamespacedName
    /// <summary>
    /// The document contains no content.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#empty"></see></summary>
    let empty = Namespaced_IRI.parse _namespace_name "empty" |> NamespacedName

    /// <summary>
    /// Third Quartile
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#high-quartile"></see></summary>
    let ``high-quartile`` =
        Namespaced_IRI.parse _namespace_name "high-quartile" |> NamespacedName

    /// <summary>
    /// The document has been started, but is clearly not finished.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#incomplete"></see></summary>
    let incomplete = Namespaced_IRI.parse _namespace_name "incomplete" |> NamespacedName
    /// <summary>
    /// The content of this document is factually wrong.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#incorrect"></see></summary>
    let incorrect = Namespaced_IRI.parse _namespace_name "incorrect" |> NamespacedName
    /// <summary>
    /// The number of links pointing at the specified resource.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#indegree"></see></summary>
    let indegree = Namespaced_IRI.parse _namespace_name "indegree" |> NamespacedName
    /// <summary>
    /// The document defines, describes, or otherwise introduces the audience to this concept.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#introduces"></see></summary>
    let introduces = Namespaced_IRI.parse _namespace_name "introduces" |> NamespacedName
    /// <summary>
    /// The document explicitly mentions this concept.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#mentions"></see></summary>
    let mentions = Namespaced_IRI.parse _namespace_name "mentions" |> NamespacedName
    /// <summary>
    /// Keep this document to which this is associated; make no changes to it at this time.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#keep"></see></summary>
    let keep = Namespaced_IRI.parse _namespace_name "keep" |> NamespacedName
    /// <summary>
    /// The resource is a landing page from some other medium (e.g. e-mail, television, billboard). This status is a hint to automated systems which would otherwise orphan or retire a landing page with no inbound links.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#landing"></see></summary>
    let landing = Namespaced_IRI.parse _namespace_name "landing" |> NamespacedName
    /// <summary>
    /// This property specifies a linked resource which is visible in the subject's user interface.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#link"></see></summary>
    let link = Namespaced_IRI.parse _namespace_name "link" |> NamespacedName

    /// <summary>
    /// Equivalent to the bottom quarter, or 25th percentile, of the observed data.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#low-quartile"></see></summary>
    let ``low-quartile`` =
        Namespaced_IRI.parse _namespace_name "low-quartile" |> NamespacedName

    /// <summary>
    /// Maximum
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#max"></see></summary>
    let max = Namespaced_IRI.parse _namespace_name "max" |> NamespacedName
    /// <summary>
    /// Mean
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#mean"></see></summary>
    let mean = Namespaced_IRI.parse _namespace_name "mean" |> NamespacedName
    /// <summary>
    /// The median of a population
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#median"></see></summary>
    let median = Namespaced_IRI.parse _namespace_name "median" |> NamespacedName
    /// <summary>
    /// The smallest observation in the sample.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#min"></see></summary>
    let min = Namespaced_IRI.parse _namespace_name "min" |> NamespacedName

    /// <summary>
    /// This property complements dct:audience insofar as enabling the author or editor to designate a set of entities who are explicitly not the intended audience of the document.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#non-audience"></see></summary>
    let ``non-audience`` =
        Namespaced_IRI.parse _namespace_name "non-audience" |> NamespacedName

    /// <summary>
    /// The content of this document was correct and relevant at one point, but external circumstances have caused it to lapse in relevance or factual accuracy.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#obsolete"></see></summary>
    let obsolete = Namespaced_IRI.parse _namespace_name "obsolete" |> NamespacedName
    /// <summary>
    /// The resource is not explicitly pending or removed from publication, however it has managed to be disconnected from the rest of the site: There is no path to it from a landing page, and it is not a landing page on its own. That is to say that the resource either has no inbound links, or if it does, those links are from other resources that are in the same situation. Documents which are only linked from retired documents are also considered orphans.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#orphan"></see></summary>
    let orphan = Namespaced_IRI.parse _namespace_name "orphan" |> NamespacedName
    /// <summary>
    /// The number of links emanating from the specified resource.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#outdegree"></see></summary>
    let outdegree = Namespaced_IRI.parse _namespace_name "outdegree" |> NamespacedName
    /// <summary>
    /// Proofread this document.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#proofread"></see></summary>
    let proofread = Namespaced_IRI.parse _namespace_name "proofread" |> NamespacedName
    /// <summary>
    /// Remove all references to this document and consign it to the archive.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#retire"></see></summary>
    let retire = Namespaced_IRI.parse _namespace_name "retire" |> NamespacedName
    /// <summary>
    /// The document has been explicitly retired by an editor or curator, but still exists in the archive.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#retired"></see></summary>
    let retired = Namespaced_IRI.parse _namespace_name "retired" |> NamespacedName
    /// <summary>
    /// Revise or restructure this document.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#revise"></see></summary>
    let revise = Namespaced_IRI.parse _namespace_name "revise" |> NamespacedName
    /// <summary>
    /// Rewrite this document from scratch.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#rewrite"></see></summary>
    let rewrite = Namespaced_IRI.parse _namespace_name "rewrite" |> NamespacedName
    /// <summary>
    /// Standard Deviation
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#sd"></see></summary>
    let sd = Namespaced_IRI.parse _namespace_name "sd" |> NamespacedName
    /// <summary>
    /// For document types that have a concrete representation of sections, this property may be used to capture their sum.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#sections"></see></summary>
    let sections = Namespaced_IRI.parse _namespace_name "sections" |> NamespacedName
    /// <summary>
    /// Split this document into multiple pieces.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#split"></see></summary>
    let split = Namespaced_IRI.parse _namespace_name "split" |> NamespacedName
    /// <summary>
    /// Specify the URI of the target resource into which this document should be merged.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#target"></see></summary>
    let target = Namespaced_IRI.parse _namespace_name "target" |> NamespacedName

    /// <summary>
    /// Merge this document into some other document, though unspecified at this time as to which.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#tentative-merge"></see></summary>
    let ``tentative-merge`` =
        Namespaced_IRI.parse _namespace_name "tentative-merge" |> NamespacedName

    /// <summary>
    /// The resource at the subject address is unavailable for reasons other than explicit retirement, e.g. HTTP 404 or 403, or going out of print.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#unavailable"></see></summary>
    let unavailable =
        Namespaced_IRI.parse _namespace_name "unavailable" |> NamespacedName

    /// <summary>
    /// Update the metadata of this document, such as keywords, audience, etc.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#update-metadata"></see></summary>
    let ``update-metadata`` =
        Namespaced_IRI.parse _namespace_name "update-metadata" |> NamespacedName

    /// <summary>
    /// This indicates the number of words in a document, similar to the familiar function in a word processor. The exact method of counting words may vary by document type, language etc., and is thus out of scope from this document.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#words"></see></summary>
    let words = Namespaced_IRI.parse _namespace_name "words" |> NamespacedName

    /// <summary>
    /// A set of descriptive statistics pertaining to the number of words per block of text in a given document.
    /// <see href="https://privatealpha.com/ontology/content-inventory/1#words-and-blocks"></see></summary>
    let ``words-and-blocks`` =
        Namespaced_IRI.parse _namespace_name "words-and-blocks" |> NamespacedName

    /// <summary>
    ///   <see href="https://privatealpha.com/ontology/content-inventory/1#blocks"></see>
    /// </summary>
    let blocks = Namespaced_IRI.parse _namespace_name "blocks" |> NamespacedName
