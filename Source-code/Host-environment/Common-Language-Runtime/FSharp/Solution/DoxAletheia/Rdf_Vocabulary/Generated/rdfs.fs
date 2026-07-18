namespace http.www.w3.org._2000._01.rdf_schema.hash

open DoxAletheia.Rdf_Vocabulary

module rdfs =
    let _namespace_name = "http://www.w3.org/2000/01/rdf-schema#"
    /// <summary>
    /// Further information about the subject resource.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#seeAlso"></see></summary>
    let seeAlso = Namespaced_IRI.parse _namespace_name "seeAlso" |> NamespacedName
    /// <summary>
    /// The class of classes.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#Class"></see></summary>
    let Class = Namespaced_IRI.parse _namespace_name "Class" |> NamespacedName
    /// <summary>
    /// A description of the subject resource.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#comment"></see></summary>
    let comment = Namespaced_IRI.parse _namespace_name "comment" |> NamespacedName

    /// <summary>
    /// The defininition of the subject resource.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#isDefinedBy"></see></summary>
    let isDefinedBy =
        Namespaced_IRI.parse _namespace_name "isDefinedBy" |> NamespacedName

    /// <summary>
    /// A human-readable name for the subject.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#label"></see></summary>
    let label = Namespaced_IRI.parse _namespace_name "label" |> NamespacedName
    /// <summary>
    /// The subject is a subclass of a class.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#subClassOf"></see></summary>
    let subClassOf = Namespaced_IRI.parse _namespace_name "subClassOf" |> NamespacedName
    /// <summary>
    /// The class resource, everything.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#Resource"></see></summary>
    let Resource = Namespaced_IRI.parse _namespace_name "Resource" |> NamespacedName
    /// <summary>
    /// The class of RDF containers.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#Container"></see></summary>
    let Container = Namespaced_IRI.parse _namespace_name "Container" |> NamespacedName

    /// <summary>
    /// The class of container membership properties, rdf:_1, rdf:_2, ...,
    ///                     all of which are sub-properties of 'member'.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#ContainerMembershipProperty"></see></summary>
    let ContainerMembershipProperty =
        Namespaced_IRI.parse _namespace_name "ContainerMembershipProperty" |> NamespacedName

    /// <summary>
    /// The class of RDF datatypes.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#Datatype"></see></summary>
    let Datatype = Namespaced_IRI.parse _namespace_name "Datatype" |> NamespacedName
    /// <summary>
    /// The class of literal values, eg. textual strings and integers.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#Literal"></see></summary>
    let Literal = Namespaced_IRI.parse _namespace_name "Literal" |> NamespacedName
    /// <summary>
    /// A domain of the subject property.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#domain"></see></summary>
    let domain = Namespaced_IRI.parse _namespace_name "domain" |> NamespacedName
    /// <summary>
    /// A range of the subject property.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#range"></see></summary>
    let range = Namespaced_IRI.parse _namespace_name "range" |> NamespacedName

    /// <summary>
    /// The subject is a subproperty of a property.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#subPropertyOf"></see></summary>
    let subPropertyOf =
        Namespaced_IRI.parse _namespace_name "subPropertyOf" |> NamespacedName

    /// <summary>
    /// A member of the subject resource.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#member"></see></summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName
