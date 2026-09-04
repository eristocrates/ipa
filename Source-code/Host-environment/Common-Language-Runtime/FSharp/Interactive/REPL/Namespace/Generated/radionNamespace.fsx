#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module radion =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/radion#" "radion"
    let _namespaceIri = _prefixId.prefix ""
    let Asset = _prefixId.prefix "Asset"
    /// <summary>
    ///   <para>dcterms:identifier : rad:Distribution</para>
    ///   <para>rdfs:comment : A Distribution is a particular representation or concretisation of an
    ///     Asset in the form of a downloadable computer file that implements the intellectual content of an
    ///     Asset. A particular Distribution is typically associated with one Asset.</para>
    ///   <para>rdfs:label : Distribution</para>
    ///   <a href="http://www.w3.org/ns/radion#Distribution">radion:Distribution</a>
    /// </summary>
    let Distribution = _prefixId.prefix "Distribution"
    /// <summary>
    ///   <para>dcterms:identifier : rad:Repository</para>
    ///   <para>rdfs:comment : A Repository is a system or service that provides facilities for storage and
    ///     maintenance of descriptions of Assets and Distributions. A Repository will typically contain descriptions
    ///     of several Assets and functionality that allows users to search and access these descriptions. The
    ///     Distributions - the actual files themselves - will typically be available from the Repository or
    ///     elsewhere on the World Wide Web.</para>
    ///   <para>rdfs:label : Repository</para>
    ///   <a href="http://www.w3.org/ns/radion#Repository">radion:Repository</a>
    /// </summary>
    let Repository = _prefixId.prefix "Repository"
    /// <summary>
    ///   <para>dcterms:identifier : rad:distribution</para>
    ///   <para>rdfs:comment : The distribution relationship associates an Asset (its domain) with a Distribution (its range). It is the inverse of distributionOf</para>
    ///   <para>rdfs:label : distribution</para>
    ///   <a href="http://www.w3.org/ns/radion#distribution">radion:distribution</a>
    /// </summary>
    let distribution = _prefixId.prefix "distribution"
    /// <summary>
    ///   <para>dcterms:identifier : rad:distributionOf</para>
    ///   <para>rdfs:comment : The distributionOf relationship associates a Distribution (its domain) with the Asset (its range) of which it is a Distribution. It is the inverse of distribution</para>
    ///   <para>rdfs:label : distributionOf</para>
    ///   <a href="http://www.w3.org/ns/radion#distributionOf">radion:distributionOf</a>
    /// </summary>
    let distributionOf = _prefixId.prefix "distributionOf"
    /// <summary>
    ///   <para>dcterms:identifier : rad:keyword</para>
    ///   <para>rdfs:comment : A word or phrase used to succinctly descibe the Asset</para>
    ///   <para>rdfs:label : keyword</para>
    ///   <a href="http://www.w3.org/ns/radion#keyword">radion:keyword</a>
    /// </summary>
    let keyword = _prefixId.prefix "keyword"
    /// <summary>
    ///   <para>dcterms:identifier : rad:version</para>
    ///   <para>rdfs:comment : The version number or other designation of the Asset; the value should be a free text string</para>
    ///   <para>rdfs:label : version</para>
    ///   <a href="http://www.w3.org/ns/radion#version">radion:version</a>
    /// </summary>
    let version = _prefixId.prefix "version"
    /// <summary>
    ///   <para>dcterms:identifier : rad:versionNotes</para>
    ///   <para>rdfs:comment : Notes on the particular version of the Asset.</para>
    ///   <para>rdfs:label : version notes</para>
    ///   <a href="http://www.w3.org/ns/radion#versionNotes">radion:versionNotes</a>
    /// </summary>
    let versionNotes = _prefixId.prefix "versionNotes"
