namespace https.www.omg.org.spec.Commons.AnnotationVocabulary.slash

open DoxAletheia

module cmns_av =
    let _namespace_name = "https://www.omg.org/spec/Commons/AnnotationVocabulary/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
