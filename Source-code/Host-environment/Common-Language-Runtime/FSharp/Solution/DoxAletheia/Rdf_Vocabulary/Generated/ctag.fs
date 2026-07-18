namespace http.commontag.org.ns.hash

open DoxAletheia.Rdf_Vocabulary

module ctag =
    let _namespace_name = "http://commontag.org/ns#"
    /// <summary>
    /// A Tag asserted by the author of a content resource.
    /// <see href="http://commontag.org/ns#AuthorTag"></see></summary>
    let AuthorTag = Namespaced_IRI.parse _namespace_name "AuthorTag" |> NamespacedName
    /// <summary>
    /// A Common Tag associating a URI and a keyword to annotate a resource.
    /// <see href="http://commontag.org/ns#Tag"></see></summary>
    let Tag = Namespaced_IRI.parse _namespace_name "Tag" |> NamespacedName
    /// <summary>
    /// A Tag asserted by an automated tool on a content resource.
    /// <see href="http://commontag.org/ns#AutoTag"></see></summary>
    let AutoTag = Namespaced_IRI.parse _namespace_name "AutoTag" |> NamespacedName
    /// <summary>
    /// A Tag asserted by the reader (consumer) of a content resource.
    /// <see href="http://commontag.org/ns#ReaderTag"></see></summary>
    let ReaderTag = Namespaced_IRI.parse _namespace_name "ReaderTag" |> NamespacedName

    /// <summary>
    /// Content which has one or more Common Tag.
    /// <see href="http://commontag.org/ns#TaggedContent"></see></summary>
    let TaggedContent =
        Namespaced_IRI.parse _namespace_name "TaggedContent" |> NamespacedName

    /// <summary>
    /// A resource (URI) representing the concepts described by the content.
    /// <see href="http://commontag.org/ns#isAbout"></see></summary>
    let isAbout = Namespaced_IRI.parse _namespace_name "isAbout" |> NamespacedName
    /// <summary>
    /// A local, human-readable name for a Tag.
    /// <see href="http://commontag.org/ns#label"></see></summary>
    let label = Namespaced_IRI.parse _namespace_name "label" |> NamespacedName
    /// <summary>
    /// A a resource (URI) representing the conceptual meaning of a Tag.
    /// <see href="http://commontag.org/ns#means"></see></summary>
    let means = Namespaced_IRI.parse _namespace_name "means" |> NamespacedName
    /// <summary>
    /// Links a resource to a Common Tag.
    /// <see href="http://commontag.org/ns#tagged"></see></summary>
    let tagged = Namespaced_IRI.parse _namespace_name "tagged" |> NamespacedName

    /// <summary>
    /// The date the Tag was assigned.
    /// <see href="http://commontag.org/ns#taggingDate"></see></summary>
    let taggingDate =
        Namespaced_IRI.parse _namespace_name "taggingDate" |> NamespacedName
