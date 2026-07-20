namespace http.www.w3.org._2000._01.rdf_schema.hash

open DoxAletheia

module rdfs =
    let _namespace_name = "http://www.w3.org/2000/01/rdf-schema#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Further information about the subject resource.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#seeAlso"></see></summary>
    let seeAlso = _prefix "seeAlso"
    /// <summary>
    /// The class of classes.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#Class"></see></summary>
    let Class = _prefix "Class"
    /// <summary>
    /// A description of the subject resource.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#comment"></see></summary>
    let comment = _prefix "comment"
    /// <summary>
    /// The defininition of the subject resource.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#isDefinedBy"></see></summary>
    let isDefinedBy = _prefix "isDefinedBy"
    /// <summary>
    /// A human-readable name for the subject.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#label"></see></summary>
    let label = _prefix "label"
    /// <summary>
    /// The subject is a subclass of a class.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#subClassOf"></see></summary>
    let subClassOf = _prefix "subClassOf"
    /// <summary>
    /// The class resource, everything.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#Resource"></see></summary>
    let Resource = _prefix "Resource"
    /// <summary>
    /// The class of RDF containers.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#Container"></see></summary>
    let Container = _prefix "Container"
    /// <summary>
    /// The class of container membership properties, rdf:_1, rdf:_2, ...,
    ///                     all of which are sub-properties of 'member'.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#ContainerMembershipProperty"></see></summary>
    let ContainerMembershipProperty = _prefix "ContainerMembershipProperty"
    /// <summary>
    /// The class of RDF datatypes.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#Datatype"></see></summary>
    let Datatype = _prefix "Datatype"
    /// <summary>
    /// The class of literal values, eg. textual strings and integers.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#Literal"></see></summary>
    let Literal = _prefix "Literal"
    /// <summary>
    /// A domain of the subject property.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#domain"></see></summary>
    let domain = _prefix "domain"
    /// <summary>
    /// A range of the subject property.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#range"></see></summary>
    let range = _prefix "range"
    /// <summary>
    /// The subject is a subproperty of a property.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#subPropertyOf"></see></summary>
    let subPropertyOf = _prefix "subPropertyOf"
    /// <summary>
    /// A member of the subject resource.
    /// <see href="http://www.w3.org/2000/01/rdf-schema#member"></see></summary>
    let member_ = _prefix "member"
