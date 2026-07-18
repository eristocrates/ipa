namespace http.www.w3.org._2007._05.powder_s.hash

open DoxAletheia.Rdf_Vocabulary

module wdrs =
    let _namespace_name = "http://www.w3.org/2007/05/powder-s#"
    /// <summary>
    /// A POWDER document.
    /// <see href="http://www.w3.org/2007/05/powder-s#Document"></see></summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName
    /// <summary>
    /// A software agent able to process POWDER documents.
    /// <see href="http://www.w3.org/2007/05/powder-s#Processor"></see></summary>
    let Processor = Namespaced_IRI.parse _namespace_name "Processor" |> NamespacedName

    /// <summary>
    /// A pointer to a document that describes how Description Resources created by a FOAF Agent or a DC Terms Agent may be authenticated
    /// <see href="http://www.w3.org/2007/05/powder-s#authenticate"></see></summary>
    let authenticate =
        Namespaced_IRI.parse _namespace_name "authenticate" |> NamespacedName

    /// <summary>
    /// A property that takes a Boolean value to declare whether the author of the data certifies the described resource.
    /// <see href="http://www.w3.org/2007/05/powder-s#certified"></see></summary>
    let certified = Namespaced_IRI.parse _namespace_name "certified" |> NamespacedName

    /// <summary>
    /// A property that links a resource to a POWDER document that certifies it.
    /// <see href="http://www.w3.org/2007/05/powder-s#certifiedby"></see></summary>
    let certifiedby =
        Namespaced_IRI.parse _namespace_name "certifiedby" |> NamespacedName

    /// <summary>
    /// A property denoting a description of the specific error found in a given POWDER document.
    /// <see href="http://www.w3.org/2007/05/powder-s#data_error"></see></summary>
    let data_error = Namespaced_IRI.parse _namespace_name "data_error" |> NamespacedName

    /// <summary>
    /// An RDF property to exactly match the describedby relationship type introduced in http://www.w3.org/TR/powder-dr/#assoc-linking and formally defined in appendix D of the same document, i.e. the relationship A 'describedby' B asserts that resource B provides a description of resource A. There are no constraints on the format or representation of either A or B, neither are there any further constraints on either resource.
    /// <see href="http://www.w3.org/2007/05/powder-s#describedby"></see></summary>
    let describedby =
        Namespaced_IRI.parse _namespace_name "describedby" |> NamespacedName

    /// <summary>
    /// A property denoting the code of any error encountered by the POWDER processor.
    /// <see href="http://www.w3.org/2007/05/powder-s#error_code"></see></summary>
    let error_code = Namespaced_IRI.parse _namespace_name "error_code" |> NamespacedName
    /// <summary>
    /// This property is meant to be used in OWL2 instead of wdrs:matchesregex. It denotes the string data range corresponding to a set of IRIs.
    /// <see href="http://www.w3.org/2007/05/powder-s#hasIRI"></see></summary>
    let hasIRI = Namespaced_IRI.parse _namespace_name "hasIRI" |> NamespacedName
    /// <summary>
    /// This property denotes the author of a POWDER document.
    /// <see href="http://www.w3.org/2007/05/powder-s#issuedby"></see></summary>
    let issuedby = Namespaced_IRI.parse _namespace_name "issuedby" |> NamespacedName
    /// <summary>
    /// Points to a graphic summary for the resources in a given class. Typically, it is a logo denoting conformance of a given (set of) resource(s) to a given set of criteria.
    /// <see href="http://www.w3.org/2007/05/powder-s#logo"></see></summary>
    let logo = Namespaced_IRI.parse _namespace_name "logo" |> NamespacedName

    /// <summary>
    /// This is the key 'include' property for IRI set definitions in POWDER-S. It is necessary to take account of the POWDER Semantic Extension to process this fully. The value is a regular expression that is matched against an IRI.
    /// <see href="http://www.w3.org/2007/05/powder-s#matchesregex"></see></summary>
    let matchesregex =
        Namespaced_IRI.parse _namespace_name "matchesregex" |> NamespacedName

    /// <summary>
    /// Property used in results returned from a POWDER Processor that has no data about the candidate resource. The value is the IRI of the processor.
    /// <see href="http://www.w3.org/2007/05/powder-s#notknownto"></see></summary>
    let notknownto = Namespaced_IRI.parse _namespace_name "notknownto" |> NamespacedName

    /// <summary>
    /// This is the key 'exclude' property for IRI set definitions in POWDER-S. It is necessary to take account of the POWDER Semantic Extension to process this fully. The value is a regular expression that is matched against an IRI.
    /// <see href="http://www.w3.org/2007/05/powder-s#notmatchesregex"></see></summary>
    let notmatchesregex =
        Namespaced_IRI.parse _namespace_name "notmatchesregex" |> NamespacedName

    /// <summary>
    /// A property denoting a description of the specific software error.
    /// <see href="http://www.w3.org/2007/05/powder-s#proc_error"></see></summary>
    let proc_error = Namespaced_IRI.parse _namespace_name "proc_error" |> NamespacedName
    /// <summary>
    /// Links to a Base64-encoded binary SHA-1 hash of the described resource. May be used by POWDER Processors when assessing trustworthiness of a DR.
    /// <see href="http://www.w3.org/2007/05/powder-s#sha1sum"></see></summary>
    let sha1sum = Namespaced_IRI.parse _namespace_name "sha1sum" |> NamespacedName

    /// <summary>
    /// A property that links a POWDER document to some other data source that supports the descriptions provided.
    /// <see href="http://www.w3.org/2007/05/powder-s#supportedby"></see></summary>
    let supportedby =
        Namespaced_IRI.parse _namespace_name "supportedby" |> NamespacedName

    /// <summary>
    /// Property linking to a free-text tag which may include spaces.
    /// <see href="http://www.w3.org/2007/05/powder-s#tag"></see></summary>
    let tag = Namespaced_IRI.parse _namespace_name "tag" |> NamespacedName
    /// <summary>
    /// This property provides a summary of the descriptorset that it annotates, suitable for display to end users.
    /// <see href="http://www.w3.org/2007/05/powder-s#text"></see></summary>
    let text = Namespaced_IRI.parse _namespace_name "text" |> NamespacedName
    /// <summary>
    /// Provides a timestamp that a POWDER Processor may use when assessing trustworthiness of a POWDER document. Informally, a POWDER Processor should normally ignore data in the document before the given date.
    /// <see href="http://www.w3.org/2007/05/powder-s#validfrom"></see></summary>
    let validfrom = Namespaced_IRI.parse _namespace_name "validfrom" |> NamespacedName
    /// <summary>
    /// Provides a timestamp that a POWDER Processor may use when assessing trustworthiness of a POWDER document. Informally, a POWDER Processor should normally ignore data in the document after the given date.
    /// <see href="http://www.w3.org/2007/05/powder-s#validuntil"></see></summary>
    let validuntil = Namespaced_IRI.parse _namespace_name "validuntil" |> NamespacedName
