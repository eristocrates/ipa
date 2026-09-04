#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ep =
    let _prefixId = PrefixId.fromNamespaceLabel "http://eprints.org/ontology/" "ep"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : A single document that is part of an ep:EPrint record. It may be a machine generated version of another document,  eg. a thumbnail, in which case this will be expressed with relations from the http://eprints.org/relation/ namespace. It will have one or more files associated. Some documents can have multilple files, such as an HTML page plus image files. Resolving a document URI will redirect you to the primary file of the document.</para>
    ///   <para>rdfs:label : Document</para>
    ///   <a href="http://eprints.org/ontology/Document">ep:Document</a>
    /// </summary>
    let Document = _prefixId.prefix "Document"
    /// <summary>
    ///   <para>rdfs:comment : A single record in an EPrints Repository. Generally this will be described as BIBO and Dublin Core, and may have a number of associated ep:Documents. Resolving a URI of class ep:EPrint will direct to the HTML summary page for the record, in an HTML browser, or to an RDF (XML or N3) document in an RDF client. The RDF document will contain all available RDF information about the record including all attached ep:Document records and their metadata and links from the document to the files via ep:hasFile. Not all files may be available without authentication. If the files themselves contain semantic information of interest these will need to be resolved separately. References to people, organisations, publications and locations may be given URIs of the form /id/&lt;typeofthing&gt;/ext-&lt;somevalue&gt; -- in this case the URI will be resolvable as RDF+XML or N3 and may yield additional records in the repository referencing the same thing, although this is usually based on the hashing of metadata strings and may not be complete or perfect. The ext- indicates that this concept is not something the repository actually stores information about, it is just referenced by one or more records. For example, the RDF for an EPrint about a paper given at a conference may reference that conference with a URI of the form /id/event/ext-a43de4454. That URI will be resolvable but the repository does not contain full information about that event, just information derived from EPrint record metadata. It is hoped that the community may develop systems to link such URIs to the more definitive URI for an event, person, location etc.</para>
    ///   <para>rdfs:label : EPrint Record</para>
    ///   <a href="http://eprints.org/ontology/EPrint">ep:EPrint</a>
    /// </summary>
    let EPrint = _prefixId.prefix "EPrint"
    /// <summary>
    ///   <para>rdfs:comment : The base URL to use to query this repository via OAI-PMH. Note that the domain is set to any dataset, not just an EPrints Repository, so as not to limit use by non-eprints repositories.</para>
    ///   <para>rdfs:label : OAI-PMH URL</para>
    ///   <a href="http://eprints.org/ontology/OAIPMH2">ep:OAIPMH2</a>
    /// </summary>
    let OAIPMH2 = _prefixId.prefix "OAIPMH2"
    /// <summary>
    ///   <para>rdfs:comment : An EPrints Repository. This will have a number of EPrints records associated with it via the ep:hasEPrint predicate, and the records will generally be expressed as BIBO &amp; Dublin Core, plus EPrints extensions to describe the attached documents and files. Resolving the URI of this class using a client which prefers RDF XML (or text/n3) will return an RDF document describing the repository using voID and Dublin Core, plus a ep:hasEPrint link to every current record in the public part of the repository. See ep:EPrint for more description about such records. EPrints generally supports a sitemap.xml file which describes a set of data-dump-locations. Resolving these is the fastest way to obtain every bit of RDF data from an EPrints repository.</para>
    ///   <para>rdfs:label : EPrints Repository</para>
    ///   <a href="http://eprints.org/ontology/Repository">ep:Repository</a>
    /// </summary>
    let Repository = _prefixId.prefix "Repository"
    /// <summary>
    ///   <para>rdfs:comment : A SKOS concept scheme employed by this dataset.</para>
    ///   <para>rdfs:label : SKOS Concept Scheme</para>
    ///   <a href="http://eprints.org/ontology/hasConceptScheme">ep:hasConceptScheme</a>
    /// </summary>
    let hasConceptScheme = _prefixId.prefix "hasConceptScheme"
    /// <summary>
    ///   <para>rdfs:comment : A Document which is part of this EPrint Record.</para>
    ///   <para>rdfs:label : has Document</para>
    ///   <a href="http://eprints.org/ontology/hasDocument">ep:hasDocument</a>
    /// </summary>
    let hasDocument = _prefixId.prefix "hasDocument"
    /// <summary>
    ///   <para>rdfs:comment : An EPrint record which is part of this Repository.</para>
    ///   <para>rdfs:label : has EPrint Record</para>
    ///   <a href="http://eprints.org/ontology/hasEPrint">ep:hasEPrint</a>
    /// </summary>
    let hasEPrint = _prefixId.prefix "hasEPrint"
    /// <summary>
    ///   <para>rdfs:comment : A File which is part of this Document.</para>
    ///   <para>rdfs:label : has File</para>
    ///   <a href="http://eprints.org/ontology/hasFile">ep:hasFile</a>
    /// </summary>
    let hasFile = _prefixId.prefix "hasFile"
