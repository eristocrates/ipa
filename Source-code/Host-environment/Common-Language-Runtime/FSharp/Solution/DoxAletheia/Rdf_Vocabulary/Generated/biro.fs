namespace http.purl.org.spar.biro.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module biro =
    let _namespace_iri = Namespace_Iri biro |> NamespaceIRI
    /// <summary>
    ///   <para>biro:BibliographicList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An ordered list of bibliographic items, each of which contains a bibliographic reference.</para>
    /// labels<para>bibliographic list</para></remarks>
    /// <seealso href="http://purl.org/spar/biro/BibliographicList">http://purl.org/spar/biro/BibliographicList</seealso>
    let BibliographicList = Prefixed_Name(biro, "BibliographicList") |> PrefixedName

    /// <summary>
    ///   <para>biro:BibliographicReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An expression of a bibliographic record in a specific format, that references a particular textual or data publication (or a work in preparation for publication). Each bibliographic reference is a list of items containing entities that describe aspects of the referenced work - for example authors, title, journal, publication year - selected from the bibliographic record.  Note that because different journal styles may require omission of elements of the bibliographic record in references included in a paper's reference list (e.g. the title, the identifier, the names of the eighth and subsequent authors), and because errors can be introduced when an author creates a bibliographic reference, the bibliographic reference to a published work may not be a complete or fully accurate expression of the information contained within the authoritative bibliographic record for that work.</para>
    /// labels<para>bibliographic reference</para></remarks>
    /// <seealso href="http://purl.org/spar/biro/BibliographicReference">http://purl.org/spar/biro/BibliographicReference</seealso>
    let BibliographicReference =
        Prefixed_Name(biro, "BibliographicReference") |> PrefixedName

    /// <summary>
    ///   <para>biro:BibliographicCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of bibliographic records, each of which references a publication (or a work in preparation for publication). Examples of bibliographic collections include a collection of the bibliographic records of all the publications that a single individual has authored, or a collection of those bibliographic records to be included in a research paper, where they are expressed as a reference list.</para>
    /// labels<para>bibliographic collection</para></remarks>
    /// <seealso href="http://purl.org/spar/biro/BibliographicCollection">http://purl.org/spar/biro/BibliographicCollection</seealso>
    let BibliographicCollection =
        Prefixed_Name(biro, "BibliographicCollection") |> PrefixedName

    /// <summary>
    ///   <para>biro:BibliographicRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A record that uniquely describes a particular textual or data publication (or a work in preparation for publication). Each bibliographic record is a set of entities describing aspects of the referenced work, including, for example, but not restricted to: authors, title, journal, publication year, DOI, ISSN, publisher and copyright information, or, in the case of a data publication: creators, title, version, archive, publication year, DOI or other identifier). The FRBR expression of a bibliographic record is a bibliographic reference, which usually contains only a sub-set of these entities, ordered in a particular way that corresponds to the house style of the publication in which it occurs.</para>
    /// labels<para>bibliographic record</para></remarks>
    /// <seealso href="http://purl.org/spar/biro/BibliographicRecord">http://purl.org/spar/biro/BibliographicRecord</seealso>
    let BibliographicRecord = Prefixed_Name(biro, "BibliographicRecord") |> PrefixedName
    /// <summary>
    ///   <para>biro:LibraryCatalogue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A catalogue of the bibliographic holdings of a library.</para>
    /// labels<para>library catalogue</para></remarks>
    /// <seealso href="http://purl.org/spar/biro/LibraryCatalogue">http://purl.org/spar/biro/LibraryCatalogue</seealso>
    let LibraryCatalogue = Prefixed_Name(biro, "LibraryCatalogue") |> PrefixedName
    /// <summary>
    ///   <para>biro:isReferencedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between a publication and the bibliographic record or bibliographic reference describing it.</para>
    /// labels<para>is referenced by</para></remarks>
    /// <seealso href="http://purl.org/spar/biro/isReferencedBy">http://purl.org/spar/biro/isReferencedBy</seealso>
    let isReferencedBy = Prefixed_Name(biro, "isReferencedBy") |> PrefixedName
    /// <summary>
    ///   <para>biro:ReferenceList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A list used to describe the bibliography of a research paper, a journal article, a book, a book chapter or similar publication.</para>
    /// labels<para>reference list</para></remarks>
    /// <seealso href="http://purl.org/spar/biro/ReferenceList">http://purl.org/spar/biro/ReferenceList</seealso>
    let ReferenceList = Prefixed_Name(biro, "ReferenceList") |> PrefixedName
    /// <summary>
    ///   <para>biro:references</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between a bibliographic record or a bibliographic reference and the publication being referenced.</para>
    /// labels<para>references</para></remarks>
    /// <seealso href="http://purl.org/spar/biro/references">http://purl.org/spar/biro/references</seealso>
    let references = Prefixed_Name(biro, "references") |> PrefixedName
