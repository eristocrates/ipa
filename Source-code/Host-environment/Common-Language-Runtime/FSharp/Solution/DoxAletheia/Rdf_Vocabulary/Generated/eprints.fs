namespace http.eprints.org.ontology.slash

open DoxAletheia.Rdf_Vocabulary

module eprints =
    let _namespace_name = "http://eprints.org/ontology/"
    /// <summary>
    /// A single document that is part of an ep:EPrint record. It may be a machine generated version of another document,  eg. a thumbnail, in which case this will be expressed with relations from the http://eprints.org/relation/ namespace. It will have one or more files associated. Some documents can have multilple files, such as an HTML page plus image files. Resolving a document URI will redirect you to the primary file of the document.
    /// <see href="http://eprints.org/ontology/Document"></see></summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName
    /// <summary>
    /// A single record in an EPrints Repository. Generally this will be described as BIBO and Dublin Core, and may have a number of associated ep:Documents. Resolving a URI of class ep:EPrint will direct to the HTML summary page for the record, in an HTML browser, or to an RDF (XML or N3) document in an RDF client. The RDF document will contain all available RDF information about the record including all attached ep:Document records and their metadata and links from the document to the files via ep:hasFile. Not all files may be available without authentication. If the files themselves contain semantic information of interest these will need to be resolved separately. References to people, organisations, publications and locations may be given URIs of the form /id/&lt;typeofthing&gt;/ext-&lt;somevalue&gt; -- in this case the URI will be resolvable as RDF+XML or N3 and may yield additional records in the repository referencing the same thing, although this is usually based on the hashing of metadata strings and may not be complete or perfect. The ext- indicates that this concept is not something the repository actually stores information about, it is just referenced by one or more records. For example, the RDF for an EPrint about a paper given at a conference may reference that conference with a URI of the form /id/event/ext-a43de4454. That URI will be resolvable but the repository does not contain full information about that event, just information derived from EPrint record metadata. It is hoped that the community may develop systems to link such URIs to the more definitive URI for an event, person, location etc.
    /// <see href="http://eprints.org/ontology/EPrint"></see></summary>
    let EPrint = Namespaced_IRI.parse _namespace_name "EPrint" |> NamespacedName
    /// <summary>
    /// The base URL to use to query this repository via OAI-PMH. Note that the domain is set to any dataset, not just an EPrints Repository, so as not to limit use by non-eprints repositories.
    /// <see href="http://eprints.org/ontology/OAIPMH2"></see></summary>
    let OAIPMH2 = Namespaced_IRI.parse _namespace_name "OAIPMH2" |> NamespacedName
    /// <summary>
    /// An EPrints Repository. This will have a number of EPrints records associated with it via the ep:hasEPrint predicate, and the records will generally be expressed as BIBO &amp; Dublin Core, plus EPrints extensions to describe the attached documents and files. Resolving the URI of this class using a client which prefers RDF XML (or text/n3) will return an RDF document describing the repository using voID and Dublin Core, plus a ep:hasEPrint link to every current record in the public part of the repository. See ep:EPrint for more description about such records. EPrints generally supports a sitemap.xml file which describes a set of data-dump-locations. Resolving these is the fastest way to obtain every bit of RDF data from an EPrints repository.
    /// <see href="http://eprints.org/ontology/Repository"></see></summary>
    let Repository = Namespaced_IRI.parse _namespace_name "Repository" |> NamespacedName

    /// <summary>
    /// A SKOS concept scheme employed by this dataset.
    /// <see href="http://eprints.org/ontology/hasConceptScheme"></see></summary>
    let hasConceptScheme =
        Namespaced_IRI.parse _namespace_name "hasConceptScheme" |> NamespacedName

    /// <summary>
    /// A Document which is part of this EPrint Record.
    /// <see href="http://eprints.org/ontology/hasDocument"></see></summary>
    let hasDocument =
        Namespaced_IRI.parse _namespace_name "hasDocument" |> NamespacedName

    /// <summary>
    /// An EPrint record which is part of this Repository.
    /// <see href="http://eprints.org/ontology/hasEPrint"></see></summary>
    let hasEPrint = Namespaced_IRI.parse _namespace_name "hasEPrint" |> NamespacedName
    /// <summary>
    /// A File which is part of this Document.
    /// <see href="http://eprints.org/ontology/hasFile"></see></summary>
    let hasFile = Namespaced_IRI.parse _namespace_name "hasFile" |> NamespacedName
