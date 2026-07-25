namespace https.www.w3.org._2001.XMLSchema_instance.hash


open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

/// https://www.w3.org/TR/xmlschema-1/#Instance_Document_Constructions
module xsi =
    let _namespace_iri= Namespace_Iri xsi |> NamespaceIRI


    /// https://www.w3.org/TR/xmlschema-1/#xsi_type
    let type_ = Prefixed_Name(xsi, "type") |> PrefixedName 
    /// https://www.w3.org/TR/xmlschema-1/#xsi_nil
    let nil = Prefixed_Name(xsi, "nil") |> PrefixedName  
    /// https://www.w3.org/TR/xmlschema-1/#xsi_schemaLocation
    let schemaLocation = Prefixed_Name(xsi, "schemaLocation") |> PrefixedName  
    /// https://www.w3.org/TR/xmlschema-1/#xsi_schemaLocation
    let noNamespaceSchemaLocation = Prefixed_Name(xsi, "noNamespaceSchemaLocation") |> PrefixedName  
