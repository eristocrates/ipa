namespace http.purl.org.dc.dcam.slash

open DoxAletheia.Rdf_Vocabulary

module dcam =
    let _namespace_name = "http://purl.org/dc/dcam/"

    /// <summary>
    /// An enumerated set of resources.
    /// <see href="http://purl.org/dc/dcam/VocabularyEncodingScheme"></see></summary>
    let VocabularyEncodingScheme =
        Namespaced_IRI.parse _namespace_name "VocabularyEncodingScheme" |> NamespacedName

    /// <summary>
    /// A relationship between a resource and a vocabulary encoding scheme which indicates that the resource is a member of a set.
    /// <see href="http://purl.org/dc/dcam/memberOf"></see></summary>
    let memberOf = Namespaced_IRI.parse _namespace_name "memberOf" |> NamespacedName
