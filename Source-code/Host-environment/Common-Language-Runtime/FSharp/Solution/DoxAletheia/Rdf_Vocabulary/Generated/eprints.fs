namespace http.eprints.org.ontology.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module eprints =
    let _namespace_iri = Namespace_Iri eprints |> NamespaceIRI
    /// <summary>
    ///   <para>eprints:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://eprints.org/ontology/">http://eprints.org/ontology/</seealso>
    let _prefix_iri = Prefixed_Name(eprints, "") |> PrefixedName
    /// <summary>
    ///   <para>eprints:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A single document that is part of an ep:EPrint record. It may be a machine generated version of another document,  eg. a thumbnail, in which case this will be expressed with relations from the http://eprints.org/relation/ namespace. It will have one or more files associated. Some documents can have multilple files, such as an HTML page plus image files. Resolving a document URI will redirect you to the primary file of the document."</para>
    /// labels<para>"Document"</para></remarks>
    /// <seealso href="http://eprints.org/ontology/Document">http://eprints.org/ontology/Document</seealso>
    let Document = Prefixed_Name(eprints, "Document") |> PrefixedName
    /// <summary>
    ///   <para>eprints:EPrint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"A single record in an EPrints Repository. Generally this will be described as BIBO and Dublin Core, and may have a number of associated ep:Documents. Resolving a URI of class ep:EPrint will direct to the HTML summary page for the record, in an HTML browser, or to an RDF (XML or N3) document in an RDF client. The RDF document will contain all available RDF information about the record including all attached ep:Document records and their metadata and links from the document to the files via ep:hasFile. Not all files may be available without authentication. If the files themselves contain semantic information of interest these will need to be resolved separately. References to people, organisations, publications and locations may be given URIs of the form /id/&lt;typeofthing&gt;/ext-&lt;somevalue&gt; -- in this case the URI will be resolvable as RDF+XML or N3 and may yield additional records in the repository referencing the same thing, although this is usually based on the hashing of metadata strings and may not be complete or perfect. The ext- indicates that this concept is not something the repository actually stores information about, it is just referenced by one or more records. For example, the RDF for an EPrint about a paper given at a conference may reference that conference with a URI of the form /id/event/ext-a43de4454. That URI will be resolvable but the repository does not contain full information about that event, just information derived from EPrint record metadata. It is hoped that the community may develop systems to link such URIs to the more definitive URI for an event, person, location etc."</para>
    /// labels<para>"EPrint Record"</para></remarks>
    /// <seealso href="http://eprints.org/ontology/EPrint">http://eprints.org/ontology/EPrint</seealso>
    let EPrint = Prefixed_Name(eprints, "EPrint") |> PrefixedName
    /// <summary>
    ///   <para>eprints:OAIPMH2</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The base URL to use to query this repository via OAI-PMH. Note that the domain is set to any dataset, not just an EPrints Repository, so as not to limit use by non-eprints repositories."</para>
    /// labels<para>"OAI-PMH URL"</para></remarks>
    /// <seealso href="http://eprints.org/ontology/OAIPMH2">http://eprints.org/ontology/OAIPMH2</seealso>
    let OAIPMH2 = Prefixed_Name(eprints, "OAIPMH2") |> PrefixedName
    /// <summary>
    ///   <para>eprints:Repository</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An EPrints Repository. This will have a number of EPrints records associated with it via the ep:hasEPrint predicate, and the records will generally be expressed as BIBO &amp; Dublin Core, plus EPrints extensions to describe the attached documents and files. Resolving the URI of this class using a client which prefers RDF XML (or text/n3) will return an RDF document describing the repository using voID and Dublin Core, plus a ep:hasEPrint link to every current record in the public part of the repository. See ep:EPrint for more description about such records. EPrints generally supports a sitemap.xml file which describes a set of data-dump-locations. Resolving these is the fastest way to obtain every bit of RDF data from an EPrints repository."</para>
    /// labels<para>"EPrints Repository"</para></remarks>
    /// <seealso href="http://eprints.org/ontology/Repository">http://eprints.org/ontology/Repository</seealso>
    let Repository = Prefixed_Name(eprints, "Repository") |> PrefixedName
    /// <summary>
    ///   <para>eprints:hasConceptScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A SKOS concept scheme employed by this dataset."</para>
    /// labels<para>"SKOS Concept Scheme"</para></remarks>
    /// <seealso href="http://eprints.org/ontology/hasConceptScheme">http://eprints.org/ontology/hasConceptScheme</seealso>
    let hasConceptScheme = Prefixed_Name(eprints, "hasConceptScheme") |> PrefixedName
    /// <summary>
    ///   <para>eprints:hasDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A Document which is part of this EPrint Record."</para>
    /// labels<para>"has Document"</para></remarks>
    /// <seealso href="http://eprints.org/ontology/hasDocument">http://eprints.org/ontology/hasDocument</seealso>
    let hasDocument = Prefixed_Name(eprints, "hasDocument") |> PrefixedName
    /// <summary>
    ///   <para>eprints:hasEPrint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An EPrint record which is part of this Repository."</para>
    /// labels<para>"has EPrint Record"</para></remarks>
    /// <seealso href="http://eprints.org/ontology/hasEPrint">http://eprints.org/ontology/hasEPrint</seealso>
    let hasEPrint = Prefixed_Name(eprints, "hasEPrint") |> PrefixedName
    /// <summary>
    ///   <para>eprints:hasFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"A File which is part of this Document."</para>
    /// labels<para>"has File"</para></remarks>
    /// <seealso href="http://eprints.org/ontology/hasFile">http://eprints.org/ontology/hasFile</seealso>
    let hasFile = Prefixed_Name(eprints, "hasFile") |> PrefixedName
