#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module eccrev =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://vocab.eccenca.com/revision/" "eccrev"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Branch</para>
    ///   <para>dcterms:issued : 2014-12-22^^xsd:date</para>
    ///   <para>rdfs:comment : Represents a branch</para>
    ///   <para>dcterms:modified : 2014-12-30^^xsd:date</para>
    ///   <a href="https://vocab.eccenca.com/revision/Branch">eccrev:Branch</a>
    /// </summary>
    let Branch = _prefixId.prefix "Branch"
    /// <summary>
    ///   <para>dcterms:issued : 2014-12-15^^xsd:date</para>
    ///   <para>rdfs:comment : Represents a modification of the datastore. A commit consists typically on a collection of :Revision (connected with a :hasRevision relationship</para>
    ///   <para>dcterms:modified : 2014-12-30^^xsd:date</para>
    ///   <para>rdfs:label : Commit</para>
    ///   <a href="https://vocab.eccenca.com/revision/Commit">eccrev:Commit</a>
    /// </summary>
    let Commit = _prefixId.prefix "Commit"
    /// <summary>
    ///   <para>dcterms:issued : 2014-12-15^^xsd:date</para>
    ///   <para>dcterms:modified : 2014-12-30^^xsd:date</para>
    ///   <para>rdfs:label : Revision</para>
    ///   <para>rdfs:comment : Represents a modification on a specific named graph</para>
    ///   <a href="https://vocab.eccenca.com/revision/Revision">eccrev:Revision</a>
    /// </summary>
    let Revision = _prefixId.prefix "Revision"
    /// <summary>
    ///   <para>dcterms:modified : 2014-12-30^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-12-22^^xsd:date</para>
    ///   <para>rdfs:comment : Represents a tag</para>
    ///   <para>rdfs:label : Tag</para>
    ///   <a href="https://vocab.eccenca.com/revision/Tag">eccrev:Tag</a>
    /// </summary>
    let Tag = _prefixId.prefix "Tag"
    /// <summary>
    ///   <para>dcterms:modified : 2014-12-30^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-12-29^^xsd:date</para>
    ///   <para>rdfs:label : commit author</para>
    ///   <para>rdfs:comment : The author of the commit</para>
    ///   <a href="https://vocab.eccenca.com/revision/commitAuthor">eccrev:commitAuthor</a>
    /// </summary>
    let commitAuthor = _prefixId.prefix "commitAuthor"
    /// <summary>
    ///   <para>dcterms:modified : 2014-12-30^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-12-15^^xsd:date</para>
    ///   <para>rdfs:label : commit message</para>
    ///   <para>rdfs:comment : A message describing the commit</para>
    ///   <a href="https://vocab.eccenca.com/revision/commitMessage">eccrev:commitMessage</a>
    /// </summary>
    let commitMessage = _prefixId.prefix "commitMessage"
    /// <summary>
    ///   <para>dcterms:modified : 2014-12-16^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-12-15^^xsd:date</para>
    ///   <para>rdfs:label : delete delta</para>
    ///   <para>rdfs:comment : The IRI of the named graph containing the deleted triples of a revision (compared to its previous revision)</para>
    ///   <a href="https://vocab.eccenca.com/revision/deltaDelete">eccrev:deltaDelete</a>
    /// </summary>
    let deltaDelete = _prefixId.prefix "deltaDelete"
    /// <summary>
    ///   <para>dcterms:modified : 2014-12-16^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-12-15^^xsd:date</para>
    ///   <para>rdfs:label : insert delta</para>
    ///   <para>rdfs:comment : The IRI of the named graph containing the inserted triples of a revision (compared to its previous revision)</para>
    ///   <a href="https://vocab.eccenca.com/revision/deltaInsert">eccrev:deltaInsert</a>
    /// </summary>
    let deltaInsert = _prefixId.prefix "deltaInsert"
    /// <summary>
    ///   <para>dcterms:modified : 2014-12-16^^xsd:date</para>
    ///   <para>rdfs:comment : A named graph revision belonging to the commit</para>
    ///   <para>dcterms:issued : 2014-12-16^^xsd:date</para>
    ///   <para>rdfs:label : has revision</para>
    ///   <a href="https://vocab.eccenca.com/revision/hasRevision">eccrev:hasRevision</a>
    /// </summary>
    let hasRevision = _prefixId.prefix "hasRevision"
    /// <summary>
    ///   <para>dcterms:modified : 2014-12-29^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-12-29^^xsd:date</para>
    ///   <para>rdfs:label : has revision graph</para>
    ///   <para>rdfs:comment : The named graph the revision refers to</para>
    ///   <a href="https://vocab.eccenca.com/revision/hasRevisionGraph">eccrev:hasRevisionGraph</a>
    /// </summary>
    let hasRevisionGraph = _prefixId.prefix "hasRevisionGraph"
    /// <summary>
    ///   <para>dcterms:modified : 2014-12-16^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-12-15^^xsd:date</para>
    ///   <para>rdfs:label : previous commit</para>
    ///   <para>rdfs:comment : Connects to the previous commit (or pair of commits in the case of a merge commit)</para>
    ///   <a href="https://vocab.eccenca.com/revision/previousCommit">eccrev:previousCommit</a>
    /// </summary>
    let previousCommit = _prefixId.prefix "previousCommit"
    /// <summary>
    ///   <para>dcterms:modified : 2014-12-22^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-12-22^^xsd:date</para>
    ///   <para>rdfs:label : references commit</para>
    ///   <para>rdfs:comment : The commit to which this branch or tag references</para>
    ///   <a href="https://vocab.eccenca.com/revision/referencesCommit">eccrev:referencesCommit</a>
    /// </summary>
    let referencesCommit = _prefixId.prefix "referencesCommit"
    /// <summary>
    ///   <para>dcterms:modified : 2014-12-19^^xsd:date</para>
    ///   <para>dcterms:issued : 2014-12-19^^xsd:date</para>
    ///   <para>rdfs:label : sha256 digest</para>
    ///   <para>rdfs:comment : A sha256 digest of a commit based on the RDF NC14 algorithm described in "Signing RDF Graphs" by Jeremy J. Carroll (DOI: 10.1007/F978-3-540-39718-2_24).</para>
    ///   <a href="https://vocab.eccenca.com/revision/sha256">eccrev:sha256</a>
    /// </summary>
    let sha256 = _prefixId.prefix "sha256"
