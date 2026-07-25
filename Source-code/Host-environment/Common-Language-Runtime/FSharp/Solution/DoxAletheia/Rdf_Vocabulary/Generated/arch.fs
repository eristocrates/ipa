namespace http.purl.org.archival.vocab.arch.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module arch =
    let _namespace_iri = Namespace_Iri arch |> NamespaceIRI
    /// <summary>
    ///   <para>arch:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of documents organized according to the principle of provenance.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/archival/vocab/arch#Collection">http://purl.org/archival/vocab/arch#Collection</seealso>
    let Collection = Prefixed_Name(arch, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>arch:Manuscript</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An unpublished document in an arch:Collection</para>
    /// </remarks>
    /// <seealso href="http://purl.org/archival/vocab/arch#Manuscript">http://purl.org/archival/vocab/arch#Manuscript</seealso>
    let Manuscript = Prefixed_Name(arch, "Manuscript") |> PrefixedName
    /// <summary>
    ///   <para>arch:bulkEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The end of a collection's bulk dates</para>
    /// </remarks>
    /// <seealso href="http://purl.org/archival/vocab/arch#bulkEnd">http://purl.org/archival/vocab/arch#bulkEnd</seealso>
    let bulkEnd = Prefixed_Name(arch, "bulkEnd") |> PrefixedName
    /// <summary>
    ///   <para>arch:bulkStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The beginning of a collection's bulk dates</para>
    /// </remarks>
    /// <seealso href="http://purl.org/archival/vocab/arch#bulkStart">http://purl.org/archival/vocab/arch#bulkStart</seealso>
    let bulkStart = Prefixed_Name(arch, "bulkStart") |> PrefixedName
    /// <summary>
    ///   <para>arch:appearsWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Name appears with another name in an archival collection</para>
    /// </remarks>
    /// <seealso href="http://purl.org/archival/vocab/arch#appearsWith">http://purl.org/archival/vocab/arch#appearsWith</seealso>
    let appearsWith = Prefixed_Name(arch, "appearsWith") |> PrefixedName
    /// <summary>
    ///   <para>arch:correspondedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/archival/vocab/arch#correspondedWith">http://purl.org/archival/vocab/arch#correspondedWith</seealso>
    let correspondedWith = Prefixed_Name(arch, "correspondedWith") |> PrefixedName
    /// <summary>
    ///   <para>arch:inclusiveEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The end of a collection's inclusive dates</para>
    /// </remarks>
    /// <seealso href="http://purl.org/archival/vocab/arch#inclusiveEnd">http://purl.org/archival/vocab/arch#inclusiveEnd</seealso>
    let inclusiveEnd = Prefixed_Name(arch, "inclusiveEnd") |> PrefixedName
    /// <summary>
    ///   <para>arch:relatedSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Related Subject</para>
    ///   <para>Subjects related to a name in an archival collection.  Usually represents the subjects from a collection that a name is the arch:primaryProvenanceOf</para>
    /// </remarks>
    /// <seealso href="http://purl.org/archival/vocab/arch#relatedSubject">http://purl.org/archival/vocab/arch#relatedSubject</seealso>
    let relatedSubject = Prefixed_Name(arch, "relatedSubject") |> PrefixedName
    /// <summary>
    ///   <para>arch:holds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an arch:Archive to a collection that it holds.  Inverse of arch:heldBy</para>
    /// </remarks>
    /// <seealso href="http://purl.org/archival/vocab/arch#holds">http://purl.org/archival/vocab/arch#holds</seealso>
    let holds = Prefixed_Name(arch, "holds") |> PrefixedName
    /// <summary>
    ///   <para>arch:referencedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a foaf:Person, foaf:Organization, or arch:Family to a arch:Collection that they are referenced in.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/archival/vocab/arch#referencedIn">http://purl.org/archival/vocab/arch#referencedIn</seealso>
    let referencedIn = Prefixed_Name(arch, "referencedIn") |> PrefixedName
    /// <summary>
    ///   <para>arch:Archive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An organization that holds archival collections.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/archival/vocab/arch#Archive">http://purl.org/archival/vocab/arch#Archive</seealso>
    let Archive = Prefixed_Name(arch, "Archive") |> PrefixedName
    /// <summary>
    ///   <para>arch:Family</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>For representing a family, a subclass of foaf:Group.  This class might be equivalent to a similar class in genealogical vocabularies.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/archival/vocab/arch#Family">http://purl.org/archival/vocab/arch#Family</seealso>
    let Family = Prefixed_Name(arch, "Family") |> PrefixedName
    /// <summary>
    ///   <para>arch:hasProvenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Property relating a arch:Collection to the names that are the provenance of that collection.  Inverse of arch:primaryProvenanceOf.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/archival/vocab/arch#hasProvenance">http://purl.org/archival/vocab/arch#hasProvenance</seealso>
    let hasProvenance = Prefixed_Name(arch, "hasProvenance") |> PrefixedName
    /// <summary>
    ///   <para>arch:primaryProvenanceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a foaf:Person, foaf:Organization, or arch:Family to the arch:Collection that they created.  This might be more than one entity.  Inverse of arch:hasProvenance.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/archival/vocab/arch#primaryProvenanceOf">http://purl.org/archival/vocab/arch#primaryProvenanceOf</seealso>
    let primaryProvenanceOf = Prefixed_Name(arch, "primaryProvenanceOf") |> PrefixedName
    /// <summary>
    ///   <para>arch:heldBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a arch:Collection to the archive that holds it.  Inverse of arch:holds</para>
    /// </remarks>
    /// <seealso href="http://purl.org/archival/vocab/arch#heldBy">http://purl.org/archival/vocab/arch#heldBy</seealso>
    let heldBy = Prefixed_Name(arch, "heldBy") |> PrefixedName
    /// <summary>
    ///   <para>arch:inclusiveStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The beginning of a collection's inclusive dates</para>
    /// </remarks>
    /// <seealso href="http://purl.org/archival/vocab/arch#inclusiveStart">http://purl.org/archival/vocab/arch#inclusiveStart</seealso>
    let inclusiveStart = Prefixed_Name(arch, "inclusiveStart") |> PrefixedName
