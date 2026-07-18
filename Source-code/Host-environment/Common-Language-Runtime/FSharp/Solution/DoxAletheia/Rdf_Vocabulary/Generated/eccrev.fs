namespace https.vocab.eccenca.com.revision.slash

open DoxAletheia.Rdf_Vocabulary

module eccrev =
    let _namespace_name = "https://vocab.eccenca.com/revision/"
    /// <summary>
    /// Represents a branch
    /// <see href="https://vocab.eccenca.com/revision/Branch"></see></summary>
    let Branch = Namespaced_IRI.parse _namespace_name "Branch" |> NamespacedName

    /// <summary>
    /// The commit to which this branch or tag references
    /// <see href="https://vocab.eccenca.com/revision/referencesCommit"></see></summary>
    let referencesCommit =
        Namespaced_IRI.parse _namespace_name "referencesCommit" |> NamespacedName

    /// <summary>
    /// Represents a modification on a specific named graph
    /// <see href="https://vocab.eccenca.com/revision/Revision"></see></summary>
    let Revision = Namespaced_IRI.parse _namespace_name "Revision" |> NamespacedName
    /// <summary>
    /// Represents a tag
    /// <see href="https://vocab.eccenca.com/revision/Tag"></see></summary>
    let Tag = Namespaced_IRI.parse _namespace_name "Tag" |> NamespacedName
    /// <summary>
    /// Represents a modification of the datastore. A commit consists typically on a collection of :Revision (connected with a :hasRevision relationship
    /// <see href="https://vocab.eccenca.com/revision/Commit"></see></summary>
    let Commit = Namespaced_IRI.parse _namespace_name "Commit" |> NamespacedName

    /// <summary>
    /// The author of the commit
    /// <see href="https://vocab.eccenca.com/revision/commitAuthor"></see></summary>
    let commitAuthor =
        Namespaced_IRI.parse _namespace_name "commitAuthor" |> NamespacedName

    /// <summary>
    /// A message describing the commit
    /// <see href="https://vocab.eccenca.com/revision/commitMessage"></see></summary>
    let commitMessage =
        Namespaced_IRI.parse _namespace_name "commitMessage" |> NamespacedName

    /// <summary>
    /// Connects to the previous commit (or pair of commits in the case of a merge commit)
    /// <see href="https://vocab.eccenca.com/revision/previousCommit"></see></summary>
    let previousCommit =
        Namespaced_IRI.parse _namespace_name "previousCommit" |> NamespacedName

    /// <summary>
    /// A named graph revision belonging to the commit
    /// <see href="https://vocab.eccenca.com/revision/hasRevision"></see></summary>
    let hasRevision =
        Namespaced_IRI.parse _namespace_name "hasRevision" |> NamespacedName

    /// <summary>
    /// The IRI of the named graph containing the deleted triples of a revision (compared to its previous revision)
    /// <see href="https://vocab.eccenca.com/revision/deltaDelete"></see></summary>
    let deltaDelete =
        Namespaced_IRI.parse _namespace_name "deltaDelete" |> NamespacedName

    /// <summary>
    /// The named graph the revision refers to
    /// <see href="https://vocab.eccenca.com/revision/hasRevisionGraph"></see></summary>
    let hasRevisionGraph =
        Namespaced_IRI.parse _namespace_name "hasRevisionGraph" |> NamespacedName

    /// <summary>
    /// The IRI of the named graph containing the inserted triples of a revision (compared to its previous revision)
    /// <see href="https://vocab.eccenca.com/revision/deltaInsert"></see></summary>
    let deltaInsert =
        Namespaced_IRI.parse _namespace_name "deltaInsert" |> NamespacedName

    /// <summary>
    /// A sha256 digest of a commit based on the RDF NC14 algorithm described in "Signing RDF Graphs" by Jeremy J. Carroll (DOI: 10.1007/F978-3-540-39718-2_24).
    /// <see href="https://vocab.eccenca.com/revision/sha256"></see></summary>
    let sha256 = Namespaced_IRI.parse _namespace_name "sha256" |> NamespacedName
