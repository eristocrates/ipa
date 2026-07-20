namespace https.www.w3.org._2001.XMLSchema_instance.hash

open DoxAletheia

/// https://www.w3.org/TR/xmlschema-1/#Instance_Document_Constructions
module xsi =
    let _namespace_name = "https://www.w3.org/2001/XMLSchema-instance#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name
        |> NamespacedName

    /// https://www.w3.org/TR/xmlschema-1/#xsi_type
    let type_ = _prefix "type"
    /// https://www.w3.org/TR/xmlschema-1/#xsi_nil
    let nil = _prefix "nil"
    /// https://www.w3.org/TR/xmlschema-1/#xsi_schemaLocation
    let schemaLocation = _prefix "schemaLocation"

    /// https://www.w3.org/TR/xmlschema-1/#xsi_schemaLocation
    let noNamespaceSchemaLocation = _prefix "noNamespaceSchemaLocation"
