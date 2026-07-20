namespace http.purl.org.dc.dcam.slash

open DoxAletheia

module dcam =
    let _namespace_name = "http://purl.org/dc/dcam/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An enumerated set of resources.
    /// <see href="http://purl.org/dc/dcam/VocabularyEncodingScheme"></see></summary>
    let VocabularyEncodingScheme = _prefix "VocabularyEncodingScheme"
    /// <summary>
    /// A relationship between a resource and a vocabulary encoding scheme which indicates that the resource is a member of a set.
    /// <see href="http://purl.org/dc/dcam/memberOf"></see></summary>
    let memberOf = _prefix "memberOf"
