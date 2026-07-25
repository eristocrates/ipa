namespace https.vocab.eccenca.com.revision.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module eccrev =
    let _namespace_iri = Namespace_Iri eccrev |> NamespaceIRI
    /// <summary>
    ///   <para>eccrev:Revision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a modification on a specific named graph</para>
    /// labels<para>Revision</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/revision/Revision">https://vocab.eccenca.com/revision/Revision</seealso>
    let Revision = Prefixed_Name(eccrev, "Revision") |> PrefixedName
    /// <summary>
    ///   <para>eccrev:Tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a tag</para>
    /// labels<para>Tag</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/revision/Tag">https://vocab.eccenca.com/revision/Tag</seealso>
    let Tag = Prefixed_Name(eccrev, "Tag") |> PrefixedName
    /// <summary>
    ///   <para>eccrev:previousCommit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects to the previous commit (or pair of commits in the case of a merge commit)</para>
    /// labels<para>previous commit</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/revision/previousCommit">https://vocab.eccenca.com/revision/previousCommit</seealso>
    let previousCommit = Prefixed_Name(eccrev, "previousCommit") |> PrefixedName
    /// <summary>
    ///   <para>eccrev:deltaDelete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The IRI of the named graph containing the deleted triples of a revision (compared to its previous revision)</para>
    /// labels<para>delete delta</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/revision/deltaDelete">https://vocab.eccenca.com/revision/deltaDelete</seealso>
    let deltaDelete = Prefixed_Name(eccrev, "deltaDelete") |> PrefixedName
    /// <summary>
    ///   <para>eccrev:hasRevisionGraph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The named graph the revision refers to</para>
    /// labels<para>has revision graph</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/revision/hasRevisionGraph">https://vocab.eccenca.com/revision/hasRevisionGraph</seealso>
    let hasRevisionGraph = Prefixed_Name(eccrev, "hasRevisionGraph") |> PrefixedName
    /// <summary>
    ///   <para>eccrev:sha256</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A sha256 digest of a commit based on the RDF NC14 algorithm described in "Signing RDF Graphs" by Jeremy J. Carroll (DOI: 10.1007/F978-3-540-39718-2_24).</para>
    /// labels<para>sha256 digest</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/revision/sha256">https://vocab.eccenca.com/revision/sha256</seealso>
    let sha256 = Prefixed_Name(eccrev, "sha256") |> PrefixedName
    /// <summary>
    ///   <para>eccrev:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>A vocabulary &amp; data model for describing RDF changes and revisions. It defines the Commit &amp; Revision classes together with their expected properties.</para>
    /// labels<para>eccrev: RDF changes and revisions vocabulary</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/revision/">https://vocab.eccenca.com/revision/</seealso>
    let _prefix_iri = Prefixed_Name(eccrev, "") |> PrefixedName
    /// <summary>
    ///   <para>eccrev:Branch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a branch</para>
    /// labels<para>Branch</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/revision/Branch">https://vocab.eccenca.com/revision/Branch</seealso>
    let Branch = Prefixed_Name(eccrev, "Branch") |> PrefixedName
    /// <summary>
    ///   <para>eccrev:Commit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents a modification of the datastore. A commit consists typically on a collection of :Revision (connected with a :hasRevision relationship</para>
    /// labels<para>Commit</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/revision/Commit">https://vocab.eccenca.com/revision/Commit</seealso>
    let Commit = Prefixed_Name(eccrev, "Commit") |> PrefixedName
    /// <summary>
    ///   <para>eccrev:referencesCommit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The commit to which this branch or tag references</para>
    /// labels<para>references commit</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/revision/referencesCommit">https://vocab.eccenca.com/revision/referencesCommit</seealso>
    let referencesCommit = Prefixed_Name(eccrev, "referencesCommit") |> PrefixedName
    /// <summary>
    ///   <para>eccrev:commitAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The author of the commit</para>
    /// labels<para>commit author</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/revision/commitAuthor">https://vocab.eccenca.com/revision/commitAuthor</seealso>
    let commitAuthor = Prefixed_Name(eccrev, "commitAuthor") |> PrefixedName
    /// <summary>
    ///   <para>eccrev:commitMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A message describing the commit</para>
    /// labels<para>commit message</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/revision/commitMessage">https://vocab.eccenca.com/revision/commitMessage</seealso>
    let commitMessage = Prefixed_Name(eccrev, "commitMessage") |> PrefixedName
    /// <summary>
    ///   <para>eccrev:hasRevision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A named graph revision belonging to the commit</para>
    /// labels<para>has revision</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/revision/hasRevision">https://vocab.eccenca.com/revision/hasRevision</seealso>
    let hasRevision = Prefixed_Name(eccrev, "hasRevision") |> PrefixedName
    /// <summary>
    ///   <para>eccrev:deltaInsert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The IRI of the named graph containing the inserted triples of a revision (compared to its previous revision)</para>
    /// labels<para>insert delta</para></remarks>
    /// <seealso href="https://vocab.eccenca.com/revision/deltaInsert">https://vocab.eccenca.com/revision/deltaInsert</seealso>
    let deltaInsert = Prefixed_Name(eccrev, "deltaInsert") |> PrefixedName
