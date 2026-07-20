namespace https.www.omg.org.spec.Commons.QuantitiesAndUnits.slash

open DoxAletheia

module cmns_qtu =
    let _namespace_name = "https://www.omg.org/spec/Commons/QuantitiesAndUnits/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
