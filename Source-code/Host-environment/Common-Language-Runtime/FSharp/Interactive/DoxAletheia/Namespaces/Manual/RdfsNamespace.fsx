#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\RDFErgonomics.fsx"
open RDFErgonomics

module rdfs =
    let _prefix = prefix_label "rdfs"


    /// The class of classes.
    let Class = _prefix "Class"


    /// The class of RDF containers.
    let Container = _prefix "Container"


    /// The class of container membership properties, rdf:_1, rdf:_2, ...,
    ///                     all of which are sub-properties of 'member'.
    let ContainerMembershipProperty = _prefix "ContainerMembershipProperty"


    /// The class of RDF datatypes.
    let Datatype = _prefix "Datatype"


    /// The class of literal values, eg. textual strings and integers.
    let Literal = _prefix "Literal"


    /// The class resource, everything.
    let Resource = _prefix "Resource"


    /// A description of the subject resource.
    let comment = _prefix "comment"


    /// A domain of the subject property.
    let domain = _prefix "domain"


    /// The defininition of the subject resource.
    let isDefinedBy = _prefix "isDefinedBy"


    /// A human-readable name for the subject.
    let label = _prefix "label"


    /// A member of the subject resource.
    let ``member`` = _prefix "member"


    /// A range of the subject property.
    let range = _prefix "range"


    /// Further information about the subject resource.
    let seeAlso = _prefix "seeAlso"


    /// The subject is a subclass of a class.
    let subClassOf = _prefix "subClassOf"


    /// The subject is a subproperty of a property.
    let subPropertyOf = _prefix "subPropertyOf"
