namespace https.www.omg.org.spec.Commons.DatesAndTimes.slash

open DoxAletheia

module cmns_dt =
    let _namespace_name = "https://www.omg.org/spec/Commons/DatesAndTimes/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
