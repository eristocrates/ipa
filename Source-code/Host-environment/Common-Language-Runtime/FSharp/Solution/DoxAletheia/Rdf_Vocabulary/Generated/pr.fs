namespace http.purl.org.ontology.prv.core.hash

open DoxAletheia.Rdf_Vocabulary

module pr =
    let _namespace_name = "http://purl.org/ontology/prv/core#"

    /// <summary>
    /// The class, which describes the relations of a property reification. That means, its "shortcut relation", its
    /// reification class, and the properties that are relating to the subject and object of the "shortcut relation".
    /// <see href="http://purl.org/ontology/prv/core#PropertyReification"></see></summary>
    let PropertyReification =
        Namespaced_IRI.parse _namespace_name "PropertyReification" |> NamespacedName

    /// <summary>
    /// Relates to the property of the reification class, which relates to the object of the "shortcut relation".
    /// <see href="http://purl.org/ontology/prv/core#object_property"></see></summary>
    let object_property =
        Namespaced_IRI.parse _namespace_name "object_property" |> NamespacedName

    /// <summary>
    /// Relates to the reification class, which can be related to the object and subject property to be able to associate the
    /// object and subject of the "shortcut relation". The reification class should provide detailed descriptions of the relationship that is
    /// described in a simple form by the "shortcut relation".
    /// <see href="http://purl.org/ontology/prv/core#reification_class"></see></summary>
    let reification_class =
        Namespaced_IRI.parse _namespace_name "reification_class" |> NamespacedName

    /// <summary>
    /// This property relates an statement identifier of a shortcut relation with an instance of a reification class. Although, this is at the moment not really applicable, because it requires a notation for statement identifier as optional fourth element of a tuple; that means, triple + statement identifier.
    /// <see href="http://purl.org/ontology/prv/core#reified"></see></summary>
    let reified = Namespaced_IRI.parse _namespace_name "reified" |> NamespacedName
    /// <summary>
    /// Relates to the property of the "shortcut relation" (its predicate).
    /// <see href="http://purl.org/ontology/prv/core#shortcut"></see></summary>
    let shortcut = Namespaced_IRI.parse _namespace_name "shortcut" |> NamespacedName

    /// <summary>
    /// Relates to the property of the reification class,  which relates to the predicate of the "shortcut relation". So
    /// that the specific property reification can be "verified" (the property of the prv:shortcut relation and this one associated by the
    /// referred shortcut property should be equal).
    /// <see href="http://purl.org/ontology/prv/core#shortcut_property"></see></summary>
    let shortcut_property =
        Namespaced_IRI.parse _namespace_name "shortcut_property" |> NamespacedName

    /// <summary>
    /// Relates to the property of the reification class, which relates to the subject of the "shortcut relation".
    /// <see href="http://purl.org/ontology/prv/core#subject_property"></see></summary>
    let subject_property =
        Namespaced_IRI.parse _namespace_name "subject_property" |> NamespacedName
