namespace https.vocab.eccenca.com.revision.slash

open DoxAletheia

module eccrev =
    let _namespace_name = "https://vocab.eccenca.com/revision/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Represents a branch
    /// <see href="https://vocab.eccenca.com/revision/Branch"></see></summary>
    let Branch = _prefix "Branch"
    /// <summary>
    /// The commit to which this branch or tag references
    /// <see href="https://vocab.eccenca.com/revision/referencesCommit"></see></summary>
    let referencesCommit = _prefix "referencesCommit"
    /// <summary>
    /// Represents a modification on a specific named graph
    /// <see href="https://vocab.eccenca.com/revision/Revision"></see></summary>
    let Revision = _prefix "Revision"
    /// <summary>
    /// Represents a tag
    /// <see href="https://vocab.eccenca.com/revision/Tag"></see></summary>
    let Tag = _prefix "Tag"
    /// <summary>
    /// Represents a modification of the datastore. A commit consists typically on a collection of :Revision (connected with a :hasRevision relationship
    /// <see href="https://vocab.eccenca.com/revision/Commit"></see></summary>
    let Commit = _prefix "Commit"
    /// <summary>
    /// The author of the commit
    /// <see href="https://vocab.eccenca.com/revision/commitAuthor"></see></summary>
    let commitAuthor = _prefix "commitAuthor"
    /// <summary>
    /// A message describing the commit
    /// <see href="https://vocab.eccenca.com/revision/commitMessage"></see></summary>
    let commitMessage = _prefix "commitMessage"
    /// <summary>
    /// Connects to the previous commit (or pair of commits in the case of a merge commit)
    /// <see href="https://vocab.eccenca.com/revision/previousCommit"></see></summary>
    let previousCommit = _prefix "previousCommit"
    /// <summary>
    /// A named graph revision belonging to the commit
    /// <see href="https://vocab.eccenca.com/revision/hasRevision"></see></summary>
    let hasRevision = _prefix "hasRevision"
    /// <summary>
    /// The IRI of the named graph containing the deleted triples of a revision (compared to its previous revision)
    /// <see href="https://vocab.eccenca.com/revision/deltaDelete"></see></summary>
    let deltaDelete = _prefix "deltaDelete"
    /// <summary>
    /// The named graph the revision refers to
    /// <see href="https://vocab.eccenca.com/revision/hasRevisionGraph"></see></summary>
    let hasRevisionGraph = _prefix "hasRevisionGraph"
    /// <summary>
    /// The IRI of the named graph containing the inserted triples of a revision (compared to its previous revision)
    /// <see href="https://vocab.eccenca.com/revision/deltaInsert"></see></summary>
    let deltaInsert = _prefix "deltaInsert"
    /// <summary>
    /// A sha256 digest of a commit based on the RDF NC14 algorithm described in "Signing RDF Graphs" by Jeremy J. Carroll (DOI: 10.1007/F978-3-540-39718-2_24).
    /// <see href="https://vocab.eccenca.com/revision/sha256"></see></summary>
    let sha256 = _prefix "sha256"
