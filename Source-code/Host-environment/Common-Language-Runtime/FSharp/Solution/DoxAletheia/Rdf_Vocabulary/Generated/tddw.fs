namespace https.w3id.org.todo.tododw.hash

open DoxAletheia

module tddw =
    let _namespace_name = "https://w3id.org/todo/tododw#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
