namespace http.commontag.org.ns.hash

open DoxAletheia

module ctag =
    let _namespace_name = "http://commontag.org/ns#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A Tag asserted by the author of a content resource.
    /// <see href="http://commontag.org/ns#AuthorTag"></see></summary>
    let AuthorTag = _prefix "AuthorTag"
    /// <summary>
    /// A Common Tag associating a URI and a keyword to annotate a resource.
    /// <see href="http://commontag.org/ns#Tag"></see></summary>
    let Tag = _prefix "Tag"
    /// <summary>
    /// A Tag asserted by an automated tool on a content resource.
    /// <see href="http://commontag.org/ns#AutoTag"></see></summary>
    let AutoTag = _prefix "AutoTag"
    /// <summary>
    /// A Tag asserted by the reader (consumer) of a content resource.
    /// <see href="http://commontag.org/ns#ReaderTag"></see></summary>
    let ReaderTag = _prefix "ReaderTag"
    /// <summary>
    /// Content which has one or more Common Tag.
    /// <see href="http://commontag.org/ns#TaggedContent"></see></summary>
    let TaggedContent = _prefix "TaggedContent"
    /// <summary>
    /// A resource (URI) representing the concepts described by the content.
    /// <see href="http://commontag.org/ns#isAbout"></see></summary>
    let isAbout = _prefix "isAbout"
    /// <summary>
    /// A local, human-readable name for a Tag.
    /// <see href="http://commontag.org/ns#label"></see></summary>
    let label = _prefix "label"
    /// <summary>
    /// A a resource (URI) representing the conceptual meaning of a Tag.
    /// <see href="http://commontag.org/ns#means"></see></summary>
    let means = _prefix "means"
    /// <summary>
    /// Links a resource to a Common Tag.
    /// <see href="http://commontag.org/ns#tagged"></see></summary>
    let tagged = _prefix "tagged"
    /// <summary>
    /// The date the Tag was assigned.
    /// <see href="http://commontag.org/ns#taggingDate"></see></summary>
    let taggingDate = _prefix "taggingDate"
