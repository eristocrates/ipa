#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cdtype =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/cld/cdtype/" "cdtype"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : A collection of individual records describing the items, and the intellectual content of those items, of a second collection. The records provide information about individual items. There are no intrinsic relationships between the records, and each record is essentially self-contained.</para>
    ///   <para>skos:prefLabel : Analytic Finding Aid</para>
    ///   <para>dce:description : There may, in the individual records, be information about collections but that is not the focus of the catalogue. AnalyticFindingAids are typically created with significant human input.</para>
    ///   <a href="http://purl.org/cld/cdtype/AnalyticFindingAid">cdtype:AnalyticFindingAid</a>
    /// </summary>
    let AnalyticFindingAid = _prefixId.prefix "AnalyticFindingAid"
    /// <summary>
    ///   <para>rdfs:comment : A catalogue for, or index of, a collection.</para>
    ///   <para>skos:prefLabel : Catalogue or Index</para>
    ///   <a href="http://purl.org/cld/cdtype/CatalogueOrIndex">cdtype:CatalogueOrIndex</a>
    /// </summary>
    let CatalogueOrIndex = _prefixId.prefix "CatalogueOrIndex"
    /// <summary>
    ///   <para>dce:description : The records are grounded within the overall arrangement of the collection, e.g. grouping together all the letters, account books etc. in an ordered sequence or sequences. Items are often not uniquely identifiable when considered in isolation, so the context of the collection is an essential element in compiling the hierarchic finding-aid. Hierarchic finding-aids are typically created with significant human input.</para>
    ///   <para>rdfs:comment : A collection of records describing the individual items, and the intellectual content of those items, of a second collection. The records provide information about the collection and/or about the individual items, including contextual information about the relations between items and the collection. Relationships exist between records, and records are interpreted in the context of those relationships.</para>
    ///   <para>skos:prefLabel : Hierarchic Finding Aid</para>
    ///   <a href="http://purl.org/cld/cdtype/HierarchicFindingAid">cdtype:HierarchicFindingAid</a>
    /// </summary>
    let HierarchicFindingAid = _prefixId.prefix "HierarchicFindingAid"
    /// <summary>
    ///   <para>skos:prefLabel : Indexing Finding Aid</para>
    ///   <para>dce:description : For example, a robotic search engine will create an index of the words in a document (or catalogue record) regardless of their context and without trying to identify the discrete elements of intellectual content contained therein. IndexingFindingAides are typically generated automatically by a software robot or other harvesting technology, but may be created by human effort.</para>
    ///   <para>rdfs:comment : A collection of records consisting of information derived from items in a second collection, regardless of the content of those items.</para>
    ///   <a href="http://purl.org/cld/cdtype/IndexingFindingAid">cdtype:IndexingFindingAid</a>
    /// </summary>
    let IndexingFindingAid = _prefixId.prefix "IndexingFindingAid"
