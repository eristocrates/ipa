namespace https.www.omg.org.spec.Commons.CodesAndCodeSets.slash

open DoxAletheia

module cmns_cds =
    let _namespace_name = "https://www.omg.org/spec/Commons/CodesAndCodeSets/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
