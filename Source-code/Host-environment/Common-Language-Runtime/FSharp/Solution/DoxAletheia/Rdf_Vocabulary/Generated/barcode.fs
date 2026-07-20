namespace https.www.commoncoreontologies.org.BarcodeOntology.slash

open DoxAletheia

module barcode =
    let _namespace_name = "https://www.commoncoreontologies.org/BarcodeOntology/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
