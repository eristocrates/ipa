namespace http.purl.org.archival.vocab.arch.hash

open DoxAletheia

module arch =
    let _namespace_name = "http://purl.org/archival/vocab/arch#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An organization that holds archival collections.
    /// <see href="http://purl.org/archival/vocab/arch#Archive"></see></summary>
    let Archive = _prefix "Archive"
    /// <summary>
    /// A collection of documents organized according to the principle of provenance.
    /// <see href="http://purl.org/archival/vocab/arch#Collection"></see></summary>
    let Collection = _prefix "Collection"
    /// <summary>
    /// For representing a family, a subclass of foaf:Group.  This class might be equivalent to a similar class in genealogical vocabularies.
    /// <see href="http://purl.org/archival/vocab/arch#Family"></see></summary>
    let Family = _prefix "Family"
    /// <summary>
    /// An unpublished document in an arch:Collection
    /// <see href="http://purl.org/archival/vocab/arch#Manuscript"></see></summary>
    let Manuscript = _prefix "Manuscript"
    /// <summary>
    /// Name appears with another name in an archival collection
    /// <see href="http://purl.org/archival/vocab/arch#appearsWith"></see></summary>
    let appearsWith = _prefix "appearsWith"
    /// <summary>
    /// The end of a collection's bulk dates
    /// <see href="http://purl.org/archival/vocab/arch#bulkEnd"></see></summary>
    let bulkEnd = _prefix "bulkEnd"
    /// <summary>
    /// The beginning of a collection's bulk dates
    /// <see href="http://purl.org/archival/vocab/arch#bulkStart"></see></summary>
    let bulkStart = _prefix "bulkStart"
    /// <summary>
    ///   <see href="http://purl.org/archival/vocab/arch#correspondedWith"></see>
    /// </summary>
    let correspondedWith = _prefix "correspondedWith"
    /// <summary>
    /// Property relating a arch:Collection to the names that are the provenance of that collection.  Inverse of arch:primaryProvenanceOf.
    /// <see href="http://purl.org/archival/vocab/arch#hasProvenance"></see></summary>
    let hasProvenance = _prefix "hasProvenance"
    /// <summary>
    /// Relates a foaf:Person, foaf:Organization, or arch:Family to the arch:Collection that they created.  This might be more than one entity.  Inverse of arch:hasProvenance.
    /// <see href="http://purl.org/archival/vocab/arch#primaryProvenanceOf"></see></summary>
    let primaryProvenanceOf = _prefix "primaryProvenanceOf"
    /// <summary>
    /// Relates a arch:Collection to the archive that holds it.  Inverse of arch:holds
    /// <see href="http://purl.org/archival/vocab/arch#heldBy"></see></summary>
    let heldBy = _prefix "heldBy"
    /// <summary>
    /// Relates an arch:Archive to a collection that it holds.  Inverse of arch:heldBy
    /// <see href="http://purl.org/archival/vocab/arch#holds"></see></summary>
    let holds = _prefix "holds"
    /// <summary>
    /// The end of a collection's inclusive dates
    /// <see href="http://purl.org/archival/vocab/arch#inclusiveEnd"></see></summary>
    let inclusiveEnd = _prefix "inclusiveEnd"
    /// <summary>
    /// The beginning of a collection's inclusive dates
    /// <see href="http://purl.org/archival/vocab/arch#inclusiveStart"></see></summary>
    let inclusiveStart = _prefix "inclusiveStart"
    /// <summary>
    /// Relates a foaf:Person, foaf:Organization, or arch:Family to a arch:Collection that they are referenced in.
    /// <see href="http://purl.org/archival/vocab/arch#referencedIn"></see></summary>
    let referencedIn = _prefix "referencedIn"
    /// <summary>
    /// Related Subject
    /// Subjects related to a name in an archival collection.  Usually represents the subjects from a collection that a name is the arch:primaryProvenanceOf
    /// <see href="http://purl.org/archival/vocab/arch#relatedSubject"></see></summary>
    let relatedSubject = _prefix "relatedSubject"
