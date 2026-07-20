namespace http.www.w3.org._2000._10.swap.pim.usps.hash

open DoxAletheia

module usps =
    let _namespace_name = "http://www.w3.org/2000/10/swap/pim/usps#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
