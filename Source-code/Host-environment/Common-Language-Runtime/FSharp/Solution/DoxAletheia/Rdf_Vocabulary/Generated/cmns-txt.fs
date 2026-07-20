namespace https.www.omg.org.spec.Commons.TextDatatype.slash

open DoxAletheia

module cmns_txt =
    let _namespace_name = "https://www.omg.org/spec/Commons/TextDatatype/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
