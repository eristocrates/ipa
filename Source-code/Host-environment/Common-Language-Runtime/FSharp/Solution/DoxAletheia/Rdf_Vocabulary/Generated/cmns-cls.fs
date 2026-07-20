namespace https.www.omg.org.spec.Commons.Classifiers.slash

open DoxAletheia

module cmns_cls =
    let _namespace_name = "https://www.omg.org/spec/Commons/Classifiers/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
