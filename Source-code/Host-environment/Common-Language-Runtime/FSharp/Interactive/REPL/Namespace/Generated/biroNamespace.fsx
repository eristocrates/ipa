#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module biro =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/spar/biro/" "biro"
    /// <summary>
    ///   <para>rdfs:comment : A collection of bibliographic records, each of which references a publication (or a work in preparation for publication). Examples of bibliographic collections include a collection of the bibliographic records of all the publications that a single individual has authored, or a collection of those bibliographic records to be included in a research paper, where they are expressed as a reference list.</para>
    ///   <para>dce:description : A bibliographic collection is composed only of items containing bibliographic records.  Moreover, it cannot be part of other bibliographic collections, and it is realized only by bibliographic lists.</para>
    ///   <para>rdfs:label : bibliographic collection</para>
    ///   <a href="http://purl.org/spar/biro/BibliographicCollection">biro:BibliographicCollection</a>
    /// </summary>
    let BibliographicCollection = _prefixId.prefix "BibliographicCollection"
    /// <summary>
    ///   <para>rdfs:comment : An ordered list of bibliographic items, each of which contains a bibliographic reference.</para>
    ///   <para>dce:description : A bibliographic list is composed only of items containing bibliographic references.  Moreover, it is always a realization of a bibliographic collection.</para>
    ///   <para>rdfs:label : bibliographic list</para>
    ///   <a href="http://purl.org/spar/biro/BibliographicList">biro:BibliographicList</a>
    /// </summary>
    let BibliographicList = _prefixId.prefix "BibliographicList"
    /// <summary>
    ///   <para>rdfs:comment : A record that uniquely describes a particular textual or data publication (or a work in preparation for publication). Each bibliographic record is a set of entities describing aspects of the referenced work, including, for example, but not restricted to: authors, title, journal, publication year, DOI, ISSN, publisher and copyright information, or, in the case of a data publication: creators, title, version, archive, publication year, DOI or other identifier). The FRBR expression of a bibliographic record is a bibliographic reference, which usually contains only a sub-set of these entities, ordered in a particular way that corresponds to the house style of the publication in which it occurs.</para>
    ///   <para>dce:description : A bibliographic record is realized only through bibliographic references.</para>
    ///   <para>rdfs:label : bibliographic record</para>
    ///   <a href="http://purl.org/spar/biro/BibliographicRecord">biro:BibliographicRecord</a>
    /// </summary>
    let BibliographicRecord = _prefixId.prefix "BibliographicRecord"
    /// <summary>
    ///   <para>rdfs:comment : An expression of a bibliographic record in a specific format, that references a particular textual or data publication (or a work in preparation for publication). Each bibliographic reference is a list of items containing entities that describe aspects of the referenced work - for example authors, title, journal, publication year - selected from the bibliographic record.  Note that because different journal styles may require omission of elements of the bibliographic record in references included in a paper's reference list (e.g. the title, the identifier, the names of the eighth and subsequent authors), and because errors can be introduced when an author creates a bibliographic reference, the bibliographic reference to a published work may not be a complete or fully accurate expression of the information contained within the authoritative bibliographic record for that work.</para>
    ///   <para>dce:description : A bibliographic reference is a realization of a bibliographic record. Moreover, it can contain only items referring to elements contained by the bibliographic record it realizes.</para>
    ///   <para>rdfs:label : bibliographic reference</para>
    ///   <a href="http://purl.org/spar/biro/BibliographicReference">biro:BibliographicReference</a>
    /// </summary>
    let BibliographicReference = _prefixId.prefix "BibliographicReference"
    /// <summary>
    ///   <para>rdfs:comment : A catalogue of the bibliographic holdings of a library.</para>
    ///   <para>rdfs:label : library catalogue</para>
    ///   <a href="http://purl.org/spar/biro/LibraryCatalogue">biro:LibraryCatalogue</a>
    /// </summary>
    let LibraryCatalogue = _prefixId.prefix "LibraryCatalogue"
    /// <summary>
    ///   <para>rdfs:comment : A list used to describe the bibliography of a research paper, a journal article, a book, a book chapter or similar publication.</para>
    ///   <para>rdfs:label : reference list</para>
    ///   <a href="http://purl.org/spar/biro/ReferenceList">biro:ReferenceList</a>
    /// </summary>
    let ReferenceList = _prefixId.prefix "ReferenceList"
    /// <summary>
    ///   <para>rdfs:comment : The relation between a publication and the bibliographic record or bibliographic reference describing it.</para>
    ///   <para>rdfs:label : is referenced by</para>
    ///   <a href="http://purl.org/spar/biro/isReferencedBy">biro:isReferencedBy</a>
    /// </summary>
    let isReferencedBy = _prefixId.prefix "isReferencedBy"
    /// <summary>
    ///   <para>rdfs:comment : The relation between a bibliographic record or a bibliographic reference and the publication being referenced.</para>
    ///   <para>rdfs:label : references</para>
    ///   <a href="http://purl.org/spar/biro/references">biro:references</a>
    /// </summary>
    let references = _prefixId.prefix "references"
