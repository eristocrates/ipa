namespace https.www.omg.org.spec.Commons.ContextualDesignators.slash

open DoxAletheia

module cmns_cxtdsg =
    let _namespace_name = "https://www.omg.org/spec/Commons/ContextualDesignators/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
