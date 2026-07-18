namespace http.purl.org.archival.vocab.arch.hash

open DoxAletheia.Rdf_Vocabulary

module arch =
    let _namespace_name = "http://purl.org/archival/vocab/arch#"
    /// <summary>
    /// An organization that holds archival collections.
    /// <see href="http://purl.org/archival/vocab/arch#Archive"></see></summary>
    let Archive = Namespaced_IRI.parse _namespace_name "Archive" |> NamespacedName
    /// <summary>
    /// A collection of documents organized according to the principle of provenance.
    /// <see href="http://purl.org/archival/vocab/arch#Collection"></see></summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName
    /// <summary>
    /// For representing a family, a subclass of foaf:Group.  This class might be equivalent to a similar class in genealogical vocabularies.
    /// <see href="http://purl.org/archival/vocab/arch#Family"></see></summary>
    let Family = Namespaced_IRI.parse _namespace_name "Family" |> NamespacedName
    /// <summary>
    /// An unpublished document in an arch:Collection
    /// <see href="http://purl.org/archival/vocab/arch#Manuscript"></see></summary>
    let Manuscript = Namespaced_IRI.parse _namespace_name "Manuscript" |> NamespacedName

    /// <summary>
    /// Name appears with another name in an archival collection
    /// <see href="http://purl.org/archival/vocab/arch#appearsWith"></see></summary>
    let appearsWith =
        Namespaced_IRI.parse _namespace_name "appearsWith" |> NamespacedName

    /// <summary>
    /// The end of a collection's bulk dates
    /// <see href="http://purl.org/archival/vocab/arch#bulkEnd"></see></summary>
    let bulkEnd = Namespaced_IRI.parse _namespace_name "bulkEnd" |> NamespacedName
    /// <summary>
    /// The beginning of a collection's bulk dates
    /// <see href="http://purl.org/archival/vocab/arch#bulkStart"></see></summary>
    let bulkStart = Namespaced_IRI.parse _namespace_name "bulkStart" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/archival/vocab/arch#correspondedWith"></see>
    /// </summary>
    let correspondedWith =
        Namespaced_IRI.parse _namespace_name "correspondedWith" |> NamespacedName

    /// <summary>
    /// Property relating a arch:Collection to the names that are the provenance of that collection.  Inverse of arch:primaryProvenanceOf.
    /// <see href="http://purl.org/archival/vocab/arch#hasProvenance"></see></summary>
    let hasProvenance =
        Namespaced_IRI.parse _namespace_name "hasProvenance" |> NamespacedName

    /// <summary>
    /// Relates a foaf:Person, foaf:Organization, or arch:Family to the arch:Collection that they created.  This might be more than one entity.  Inverse of arch:hasProvenance.
    /// <see href="http://purl.org/archival/vocab/arch#primaryProvenanceOf"></see></summary>
    let primaryProvenanceOf =
        Namespaced_IRI.parse _namespace_name "primaryProvenanceOf" |> NamespacedName

    /// <summary>
    /// Relates a arch:Collection to the archive that holds it.  Inverse of arch:holds
    /// <see href="http://purl.org/archival/vocab/arch#heldBy"></see></summary>
    let heldBy = Namespaced_IRI.parse _namespace_name "heldBy" |> NamespacedName
    /// <summary>
    /// Relates an arch:Archive to a collection that it holds.  Inverse of arch:heldBy
    /// <see href="http://purl.org/archival/vocab/arch#holds"></see></summary>
    let holds = Namespaced_IRI.parse _namespace_name "holds" |> NamespacedName

    /// <summary>
    /// The end of a collection's inclusive dates
    /// <see href="http://purl.org/archival/vocab/arch#inclusiveEnd"></see></summary>
    let inclusiveEnd =
        Namespaced_IRI.parse _namespace_name "inclusiveEnd" |> NamespacedName

    /// <summary>
    /// The beginning of a collection's inclusive dates
    /// <see href="http://purl.org/archival/vocab/arch#inclusiveStart"></see></summary>
    let inclusiveStart =
        Namespaced_IRI.parse _namespace_name "inclusiveStart" |> NamespacedName

    /// <summary>
    /// Relates a foaf:Person, foaf:Organization, or arch:Family to a arch:Collection that they are referenced in.
    /// <see href="http://purl.org/archival/vocab/arch#referencedIn"></see></summary>
    let referencedIn =
        Namespaced_IRI.parse _namespace_name "referencedIn" |> NamespacedName

    /// <summary>
    /// Related Subject
    /// Subjects related to a name in an archival collection.  Usually represents the subjects from a collection that a name is the arch:primaryProvenanceOf
    /// <see href="http://purl.org/archival/vocab/arch#relatedSubject"></see></summary>
    let relatedSubject =
        Namespaced_IRI.parse _namespace_name "relatedSubject" |> NamespacedName
