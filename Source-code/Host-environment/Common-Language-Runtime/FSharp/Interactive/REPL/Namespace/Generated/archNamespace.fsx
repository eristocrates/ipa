#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module arch =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/archival/vocab/arch#" "arch"

    /// <summary>
    ///   <para>rdfs:comment : An organization that holds archival collections.^^xsd:string</para>
    ///   <a href="http://purl.org/archival/vocab/arch#Archive">arch:Archive</a>
    /// </summary>
    let Archive = _prefixId.prefix "Archive"
    /// <summary>
    ///   <para>rdfs:comment : A collection of documents organized according to the principle of provenance.^^xsd:string</para>
    ///   <a href="http://purl.org/archival/vocab/arch#Collection">arch:Collection</a>
    /// </summary>
    let Collection = _prefixId.prefix "Collection"
    /// <summary>
    ///   <para>rdfs:comment : For representing a family, a subclass of foaf:Group.  This class might be equivalent to a similar class in genealogical vocabularies.^^xsd:string</para>
    ///   <a href="http://purl.org/archival/vocab/arch#Family">arch:Family</a>
    /// </summary>
    let Family = _prefixId.prefix "Family"
    /// <summary>
    ///   <para>rdfs:comment : An unpublished document in an arch:Collection^^xsd:string</para>
    ///   <a href="http://purl.org/archival/vocab/arch#Manuscript">arch:Manuscript</a>
    /// </summary>
    let Manuscript = _prefixId.prefix "Manuscript"
    /// <summary>
    ///   <para>rdfs:comment : Name appears with another name in an archival collection^^xsd:string</para>
    ///   <a href="http://purl.org/archival/vocab/arch#appearsWith">arch:appearsWith</a>
    /// </summary>
    let appearsWith = _prefixId.prefix "appearsWith"
    /// <summary>
    ///   <para>rdfs:comment : The end of a collection's bulk dates^^xsd:string</para>
    ///   <a href="http://purl.org/archival/vocab/arch#bulkEnd">arch:bulkEnd</a>
    /// </summary>
    let bulkEnd = _prefixId.prefix "bulkEnd"
    /// <summary>
    ///   <para>rdfs:comment : The beginning of a collection's bulk dates^^xsd:string</para>
    ///   <a href="http://purl.org/archival/vocab/arch#bulkStart">arch:bulkStart</a>
    /// </summary>
    let bulkStart = _prefixId.prefix "bulkStart"
    let correspondedWith = _prefixId.prefix "correspondedWith"
    /// <summary>
    ///   <para>rdfs:comment : Property relating a arch:Collection to the names that are the provenance of that collection.  Inverse of arch:primaryProvenanceOf.^^xsd:string</para>
    ///   <a href="http://purl.org/archival/vocab/arch#hasProvenance">arch:hasProvenance</a>
    /// </summary>
    let hasProvenance = _prefixId.prefix "hasProvenance"
    /// <summary>
    ///   <para>rdfs:comment : Relates a arch:Collection to the archive that holds it.  Inverse of arch:holds^^xsd:string</para>
    ///   <a href="http://purl.org/archival/vocab/arch#heldBy">arch:heldBy</a>
    /// </summary>
    let heldBy = _prefixId.prefix "heldBy"
    /// <summary>
    ///   <para>rdfs:comment : Relates an arch:Archive to a collection that it holds.  Inverse of arch:heldBy^^xsd:string</para>
    ///   <a href="http://purl.org/archival/vocab/arch#holds">arch:holds</a>
    /// </summary>
    let holds = _prefixId.prefix "holds"
    /// <summary>
    ///   <para>rdfs:comment : The end of a collection's inclusive dates^^xsd:string</para>
    ///   <a href="http://purl.org/archival/vocab/arch#inclusiveEnd">arch:inclusiveEnd</a>
    /// </summary>
    let inclusiveEnd = _prefixId.prefix "inclusiveEnd"
    /// <summary>
    ///   <para>rdfs:comment : The beginning of a collection's inclusive dates^^xsd:string</para>
    ///   <a href="http://purl.org/archival/vocab/arch#inclusiveStart">arch:inclusiveStart</a>
    /// </summary>
    let inclusiveStart = _prefixId.prefix "inclusiveStart"
    /// <summary>
    ///   <para>rdfs:comment : Relates a foaf:Person, foaf:Organization, or arch:Family to the arch:Collection that they created.  This might be more than one entity.  Inverse of arch:hasProvenance.^^xsd:string</para>
    ///   <a href="http://purl.org/archival/vocab/arch#primaryProvenanceOf">arch:primaryProvenanceOf</a>
    /// </summary>
    let primaryProvenanceOf = _prefixId.prefix "primaryProvenanceOf"
    /// <summary>
    ///   <para>rdfs:comment : Relates a foaf:Person, foaf:Organization, or arch:Family to a arch:Collection that they are referenced in.^^xsd:string</para>
    ///   <a href="http://purl.org/archival/vocab/arch#referencedIn">arch:referencedIn</a>
    /// </summary>
    let referencedIn = _prefixId.prefix "referencedIn"
    /// <summary>
    ///   <para>rdfs:comment : Related Subject^^xsd:stringrdfs:comment : Subjects related to a name in an archival collection.  Usually represents the subjects from a collection that a name is the arch:primaryProvenanceOf^^xsd:string</para>
    ///   <a href="http://purl.org/archival/vocab/arch#relatedSubject">arch:relatedSubject</a>
    /// </summary>
    let relatedSubject = _prefixId.prefix "relatedSubject"
