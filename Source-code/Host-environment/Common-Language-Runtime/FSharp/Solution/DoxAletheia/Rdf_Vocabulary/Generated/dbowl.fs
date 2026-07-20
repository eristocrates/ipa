namespace http.ontology.cybershare.utep.edu.dbowl.relational_to_ontology_mapping_primitive.owl.hash

open DoxAletheia

module dbowl =
    let _namespace_name =
        "http://ontology.cybershare.utep.edu/dbowl/relational-to-ontology-mapping-primitive.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName
