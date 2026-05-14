#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\RDFErgonomics.fsx"
open RDFErgonomics

module rdfs =
    let prefix = prefix_label "rdfs"

    /// rdfs:comment "The class of classes." ;
    let Resource = prefix "Resource"
    /// rdfs:comment "The subject is a subclass of a class." ;
    let Class = prefix "Class"
    /// rdfs:comment "The subject is a subproperty of a property." ;
    let subClassOf = prefix "subClassOf"
    /// rdfs:comment a rdf:Property ;
    let subPropertyOf = prefix "subPropertyOf"
    /// rdfs:comment "A description of the subject resource." ;
    let comment = prefix "comment"
    /// rdfs:comment "A human-readable name for the subject." ;
    let label = prefix "label"
    /// rdfs:comment "A domain of the subject property." ;
    let domain = prefix "domain"
    /// rdfs:comment "A range of the subject property." ;
    let range = prefix "range"
    /// rdfs:comment "Further information about the subject resource." ;
    let seeAlso = prefix "seeAlso"
    /// rdfs:comment "The definition of the subject resource." ;
    let isDefinedBy = prefix "isDefinedBy"
    /// rdfs:comment "The class of literal values, eg. textual strings and integers." ;
    let Literal = prefix "Literal"
    /// rdfs:comment "The class of RDF containers." .
    let Container = prefix "Container"
    /// rdfs:comment """The class of container membership properties, rdf:_1, rdf:_2, ..., all of which are sub-properties of 'member'.""" ;
    let ContainerMembershipProperty = prefix "ContainerMembershipProperty"
    /// rdfs:comment "A member of the subject resource." ;
    let ``member`` = prefix "member"
    /// rdfs:comment "The class of RDF datatypes." ;
    let Datatype = prefix "Datatype"
