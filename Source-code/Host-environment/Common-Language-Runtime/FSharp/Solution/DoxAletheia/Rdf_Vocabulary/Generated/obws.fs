namespace http.delicias.dia.fi.upm.es.ontologies.ObjectWithStates.owl.hash

open DoxAletheia

module obws =
    let _namespace_name =
        "http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Objects are entities that have different states and that in each state different restrictions on their properties apply.
    /// <see href="http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#Object"></see></summary>
    let Object = _prefix "Object"
    /// <summary>
    /// Defines the state of an object.
    /// <see href="http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#hasState"></see></summary>
    let hasState = _prefix "hasState"
    /// <summary>
    /// States are the different states that an object can have. States must belong to a single collection of non-duplicate elements (i.e., to a set).
    /// <see href="http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#State"></see></summary>
    let State = _prefix "State"
    /// <summary>
    /// State sets are sets of states (i.e., collections of non-duplicate states).
    /// <see href="http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#StateSet"></see></summary>
    let StateSet = _prefix "StateSet"
    /// <summary>
    /// Defines the object that has an state
    /// <see href="http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#isStateOf"></see></summary>
    let isStateOf = _prefix "isStateOf"
