namespace http.purl.org.lobid.lv.hash

open DoxAletheia.Rdf_Vocabulary

module lv =
    let _namespace_name = "http://purl.org/lobid/lv#"

    /// <summary>
    /// An archival resource that is product of archiving a web page.
    /// <see href="http://purl.org/lobid/lv#ArchivedWebPage"></see></summary>
    let ArchivedWebPage =
        Namespaced_IRI.parse _namespace_name "ArchivedWebPage" |> NamespacedName

    /// <summary>
    /// A collection of documents relevant to a particular subject or author.
    /// <see href="http://purl.org/lobid/lv#Bibliography"></see></summary>
    let Bibliography =
        Namespaced_IRI.parse _namespace_name "Bibliography" |> NamespacedName

    /// <summary>
    /// A detailed description or account of a person's life
    /// <see href="http://purl.org/lobid/lv#Biography"></see></summary>
    let Biography = Namespaced_IRI.parse _namespace_name "Biography" |> NamespacedName

    /// <summary>
    /// a collection of scholarly or scientific articles written by different authors
    /// <see href="http://purl.org/lobid/lv#EditedVolume"></see></summary>
    let EditedVolume =
        Namespaced_IRI.parse _namespace_name "EditedVolume" |> NamespacedName

    /// <summary>
    /// A publication honoring a respected person, especially an academic.
    /// <see href="http://purl.org/lobid/lv#Festschrift"></see></summary>
    let Festschrift =
        Namespaced_IRI.parse _namespace_name "Festschrift" |> NamespacedName

    /// <summary>
    /// This class covers all publication types that are not covered by existing class definitions. It is used to enable facets over seldomly found publication types in library catalogs.
    /// <see href="http://purl.org/lobid/lv#Miscellaneous"></see></summary>
    let Miscellaneous =
        Namespaced_IRI.parse _namespace_name "Miscellaneous" |> NamespacedName

    /// <summary>
    /// A publication that records the business and proceedings of a government agency.
    /// <see href="http://purl.org/lobid/lv#OfficialPublication"></see></summary>
    let OfficialPublication =
        Namespaced_IRI.parse _namespace_name "OfficialPublication" |> NamespacedName

    /// <summary>
    /// A textbook used by school teachers in their classes.
    /// <see href="http://purl.org/lobid/lv#Schoolbook"></see></summary>
    let Schoolbook = Namespaced_IRI.parse _namespace_name "Schoolbook" |> NamespacedName
    /// <summary>
    /// Amtlicher Gemeindeschlüssel (AGS) of the region a spatial resource is located in.
    /// <see href="http://purl.org/lobid/lv#ags"></see></summary>
    let ags = Namespaced_IRI.parse _namespace_name "ags" |> NamespacedName
    /// <summary>
    /// Relates a person, organization or other agent to a QR code that encodes the agent's contact information.
    /// <see href="http://purl.org/lobid/lv#contactqr"></see></summary>
    let contactqr = Namespaced_IRI.parse _namespace_name "contactqr" |> NamespacedName
    /// <summary>
    /// The identifier that was assigned to a library in the context of the German Library Statistics (DBS).
    /// <see href="http://purl.org/lobid/lv#dbsID"></see></summary>
    let dbsID = Namespaced_IRI.parse _namespace_name "dbsID" |> NamespacedName

    /// <summary>
    /// Relates a bibliographic resource to an online resource (full text in HTML, PDFs or landing pages in OA repositories, on publishers' websites etc.) that represents the full text of the bibliographic resource or contains a link to a full text of the resource.
    /// <see href="http://purl.org/lobid/lv#fulltextOnline"></see></summary>
    let fulltextOnline =
        Namespaced_IRI.parse _namespace_name "fulltextOnline" |> NamespacedName

    /// <summary>
    /// Indicates which type an institution's funder is of. It should be used with a controlled vocabulary like http://purl.org/lobid/fundertype.
    /// <see href="http://purl.org/lobid/lv#fundertype"></see></summary>
    let fundertype = Namespaced_IRI.parse _namespace_name "fundertype" |> NamespacedName
    /// <summary>
    /// The identifier that is assigned to a bibliographic resource in the hbz union catalogue.
    /// <see href="http://purl.org/lobid/lv#hbzID"></see></summary>
    let hbzID = Namespaced_IRI.parse _namespace_name "hbzID" |> NamespacedName
    /// <summary>
    /// International Standard Identifier for Libraries and Related Organizations (ISIL). 'An ISIL identifies an organization, i.e., a library or a related organization, or one of its subordinate units, which is responsible for an action or service in a bibliographic environment (e.g. creation of machine-readable information). It can be used to identify the originator or holder of a resource (e.g. library material).' The literal should conform to this regular expression: [A-Z]{1,4}-[0-9a-zA-Z:-/]{1,11} .
    /// <see href="http://purl.org/lobid/lv#isil"></see></summary>
    let isil = Namespaced_IRI.parse _namespace_name "isil" |> NamespacedName

    /// <summary>
    /// Links a resource in the Northrhine-Westphalian Bibliography (NWBib) to a concept in NWBib's spatial classification.
    /// <see href="http://purl.org/lobid/lv#nwbibspatial"></see></summary>
    let nwbibspatial =
        Namespaced_IRI.parse _namespace_name "nwbibspatial" |> NamespacedName

    /// <summary>
    /// Links a resource in the Northrhine-Westphalian Bibliography (NWBib) to a concept in NWBib's subject classification.
    /// <see href="http://purl.org/lobid/lv#nwbibsubject"></see></summary>
    let nwbibsubject =
        Namespaced_IRI.parse _namespace_name "nwbibsubject" |> NamespacedName

    /// <summary>
    /// Key of the region a spatial resource is located in.
    /// <see href="http://purl.org/lobid/lv#rs"></see></summary>
    let rs = Namespaced_IRI.parse _namespace_name "rs" |> NamespacedName
    /// <summary>
    /// Indicates an institution's stock size. This property is especially used to indicate the size of a library's collection. It is recommended to be used with the controlled vocabulary at http://purl.org/lobid/stocksize.
    /// <see href="http://purl.org/lobid/lv#stocksize"></see></summary>
    let stocksize = Namespaced_IRI.parse _namespace_name "stocksize" |> NamespacedName

    /// <summary>
    /// A pipe-separated list of subject terms, optionally followed by a comma-seperated list of permutations (in parentheses).
    /// <see href="http://purl.org/lobid/lv#subjectChain"></see></summary>
    let subjectChain =
        Namespaced_IRI.parse _namespace_name "subjectChain" |> NamespacedName

    /// <summary>
    /// Indicates a title keyword, possibly in a different spelling than used in the original title.
    /// <see href="http://purl.org/lobid/lv#titleKeyword"></see></summary>
    let titleKeyword =
        Namespaced_IRI.parse _namespace_name "titleKeyword" |> NamespacedName

    /// <summary>
    /// This property is used to indicate the uniform resource name (URN) of a bibliographic resource. The URN must be stated as a string not as URI, thus identifying the identifier itself and not the resource that is identified by the URN.
    /// <see href="http://purl.org/lobid/lv#urn"></see></summary>
    let urn = Namespaced_IRI.parse _namespace_name "urn" |> NamespacedName

    /// <summary>
    /// This property is used to link the product of archiving a web page to the web page being archived.
    /// <see href="http://purl.org/lobid/lv#webPageArchived"></see></summary>
    let webPageArchived =
        Namespaced_IRI.parse _namespace_name "webPageArchived" |> NamespacedName

    /// <summary>
    /// The identifier that is assigned to a bibliographic resource in the German Journal Database (Zeitschriftendatenbank, ZDB).
    /// <see href="http://purl.org/lobid/lv#zdbID"></see></summary>
    let zdbID = Namespaced_IRI.parse _namespace_name "zdbID" |> NamespacedName
