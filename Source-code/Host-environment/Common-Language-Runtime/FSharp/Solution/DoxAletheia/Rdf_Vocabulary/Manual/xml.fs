namespace http.www.w3.org.XML._1998.namespace_.hash

open DoxAletheia

/// http://www.w3.org/XML/1998/namespace
module xml =

    let _namespace_name = "http://www.w3.org/XML/1998/namespace#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name
        |> NamespacedName

    /// Designed for identifying the human language used in the scope of the element to which it's attached.
    let lang = _prefix "lang"
    /// Designed to express whether or not the document's creator wishes white space to be considered as significant in the scope of the element to which it's attached.
    let space = _prefix "space"
    /// The XML Base specification (Second edition) describes a facility, similar to that of HTML BASE, for defining base URIs for parts of XML documents. It defines a single attribute, xml:base, and describes in detail the procedure for its use in processing relative URI refeferences.
    let base_ = _prefix "base"
    /// The xml:id specification defines a single attribute, xml:id, known to be of type ID independently of any DTD or schema.
    let id = _prefix "id"
