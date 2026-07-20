namespace http.ns.ottr.xyz._0._4.slash

open DoxAletheia

module ottr =
    let _namespace_name = "http://ns.ottr.xyz/0.4/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
