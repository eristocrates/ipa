namespace http.purl.org.spar.biro.slash

open DoxAletheia.Rdf_Vocabulary

module biro =
    let _namespace_name = "http://purl.org/spar/biro/"

    /// <summary>
    /// A collection of bibliographic records, each of which references a publication (or a work in preparation for publication). Examples of bibliographic collections include a collection of the bibliographic records of all the publications that a single individual has authored, or a collection of those bibliographic records to be included in a research paper, where they are expressed as a reference list.
    /// <see href="http://purl.org/spar/biro/BibliographicCollection"></see></summary>
    let BibliographicCollection =
        Namespaced_IRI.parse _namespace_name "BibliographicCollection" |> NamespacedName

    /// <summary>
    /// An ordered list of bibliographic items, each of which contains a bibliographic reference.
    /// <see href="http://purl.org/spar/biro/BibliographicList"></see></summary>
    let BibliographicList =
        Namespaced_IRI.parse _namespace_name "BibliographicList" |> NamespacedName

    /// <summary>
    /// A record that uniquely describes a particular textual or data publication (or a work in preparation for publication). Each bibliographic record is a set of entities describing aspects of the referenced work, including, for example, but not restricted to: authors, title, journal, publication year, DOI, ISSN, publisher and copyright information, or, in the case of a data publication: creators, title, version, archive, publication year, DOI or other identifier). The FRBR expression of a bibliographic record is a bibliographic reference, which usually contains only a sub-set of these entities, ordered in a particular way that corresponds to the house style of the publication in which it occurs.
    /// <see href="http://purl.org/spar/biro/BibliographicRecord"></see></summary>
    let BibliographicRecord =
        Namespaced_IRI.parse _namespace_name "BibliographicRecord" |> NamespacedName

    /// <summary>
    /// An expression of a bibliographic record in a specific format, that references a particular textual or data publication (or a work in preparation for publication). Each bibliographic reference is a list of items containing entities that describe aspects of the referenced work - for example authors, title, journal, publication year - selected from the bibliographic record.  Note that because different journal styles may require omission of elements of the bibliographic record in references included in a paper's reference list (e.g. the title, the identifier, the names of the eighth and subsequent authors), and because errors can be introduced when an author creates a bibliographic reference, the bibliographic reference to a published work may not be a complete or fully accurate expression of the information contained within the authoritative bibliographic record for that work.
    /// <see href="http://purl.org/spar/biro/BibliographicReference"></see></summary>
    let BibliographicReference =
        Namespaced_IRI.parse _namespace_name "BibliographicReference" |> NamespacedName

    /// <summary>
    /// A catalogue of the bibliographic holdings of a library.
    /// <see href="http://purl.org/spar/biro/LibraryCatalogue"></see></summary>
    let LibraryCatalogue =
        Namespaced_IRI.parse _namespace_name "LibraryCatalogue" |> NamespacedName

    /// <summary>
    /// A list used to describe the bibliography of a research paper, a journal article, a book, a book chapter or similar publication.
    /// <see href="http://purl.org/spar/biro/ReferenceList"></see></summary>
    let ReferenceList =
        Namespaced_IRI.parse _namespace_name "ReferenceList" |> NamespacedName

    /// <summary>
    /// The relation between a publication and the bibliographic record or bibliographic reference describing it.
    /// <see href="http://purl.org/spar/biro/isReferencedBy"></see></summary>
    let isReferencedBy =
        Namespaced_IRI.parse _namespace_name "isReferencedBy" |> NamespacedName

    /// <summary>
    /// The relation between a bibliographic record or a bibliographic reference and the publication being referenced.
    /// <see href="http://purl.org/spar/biro/references"></see></summary>
    let references = Namespaced_IRI.parse _namespace_name "references" |> NamespacedName
