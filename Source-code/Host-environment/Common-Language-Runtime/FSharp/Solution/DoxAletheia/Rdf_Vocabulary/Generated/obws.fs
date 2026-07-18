namespace http.delicias.dia.fi.upm.es.ontologies.ObjectWithStates.owl.hash

open DoxAletheia.Rdf_Vocabulary

module obws =
    let _namespace_name =
        "http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#"

    /// <summary>
    /// Objects are entities that have different states and that in each state different restrictions on their properties apply.
    /// <see href="http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#Object"></see></summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName
    /// <summary>
    /// Defines the state of an object.
    /// <see href="http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#hasState"></see></summary>
    let hasState = Namespaced_IRI.parse _namespace_name "hasState" |> NamespacedName
    /// <summary>
    /// States are the different states that an object can have. States must belong to a single collection of non-duplicate elements (i.e., to a set).
    /// <see href="http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#State"></see></summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName
    /// <summary>
    /// State sets are sets of states (i.e., collections of non-duplicate states).
    /// <see href="http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#StateSet"></see></summary>
    let StateSet = Namespaced_IRI.parse _namespace_name "StateSet" |> NamespacedName
    /// <summary>
    /// Defines the object that has an state
    /// <see href="http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#isStateOf"></see></summary>
    let isStateOf = Namespaced_IRI.parse _namespace_name "isStateOf" |> NamespacedName
