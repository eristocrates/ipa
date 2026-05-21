#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\RDFErgonomics.fsx"
open RDFErgonomics

module owl =

    let _prefix = prefix_label "owl"

    /// The class of collections of pairwise different individuals.
    let AllDifferent = _prefix "AllDifferent"


    /// The class of collections of pairwise disjoint classes.
    let AllDisjointClasses = _prefix "AllDisjointClasses"


    /// The class of collections of pairwise disjoint properties.
    let AllDisjointProperties = _prefix "AllDisjointProperties"


    /// The class of annotated annotations for which the RDF serialization consists of an annotated subject, predicate and object.
    let Annotation = _prefix "Annotation"


    /// The class of annotation properties.
    let AnnotationProperty = _prefix "AnnotationProperty"


    /// The class of asymmetric properties.
    let AsymmetricProperty = _prefix "AsymmetricProperty"


    /// The class of annotated axioms for which the RDF serialization consists of an annotated subject, predicate and object.
    let Axiom = _prefix "Axiom"


    /// The class of OWL classes.
    let Class = _prefix "Class"


    /// The class of OWL data ranges, which are special kinds of datatypes. Note: The use of the IRI owl:DataRange has been deprecated as of OWL 2. The IRI rdfs:Datatype SHOULD be used instead.
    let DataRange = _prefix "DataRange"


    /// The class of data properties.
    let DatatypeProperty = _prefix "DatatypeProperty"


    /// The class of deprecated classes.
    let DeprecatedClass = _prefix "DeprecatedClass"


    /// The class of deprecated properties.
    let DeprecatedProperty = _prefix "DeprecatedProperty"


    /// The class of functional properties.
    let FunctionalProperty = _prefix "FunctionalProperty"


    /// The class of inverse-functional properties.
    let InverseFunctionalProperty = _prefix "InverseFunctionalProperty"


    /// The class of irreflexive properties.
    let IrreflexiveProperty = _prefix "IrreflexiveProperty"


    /// The class of named individuals.
    let NamedIndividual = _prefix "NamedIndividual"


    /// The class of negative property assertions.
    let NegativePropertyAssertion = _prefix "NegativePropertyAssertion"


    /// This is the empty class.
    let Nothing = _prefix "Nothing"


    /// The class of object properties.
    let ObjectProperty = _prefix "ObjectProperty"


    /// The class of ontologies.
    let Ontology = _prefix "Ontology"


    /// The class of ontology properties.
    let OntologyProperty = _prefix "OntologyProperty"


    /// The class of reflexive properties.
    let ReflexiveProperty = _prefix "ReflexiveProperty"


    /// The class of property restrictions.
    let Restriction = _prefix "Restriction"


    /// The class of symmetric properties.
    let SymmetricProperty = _prefix "SymmetricProperty"


    /// The class of OWL individuals.
    let Thing = _prefix "Thing"


    /// The class of transitive properties.
    let TransitiveProperty = _prefix "TransitiveProperty"


    /// The property that determines the class that a universal property restriction refers to.
    let allValuesFrom = _prefix "allValuesFrom"


    /// The property that determines the predicate of an annotated axiom or annotated annotation.
    let annotatedProperty = _prefix "annotatedProperty"


    /// The property that determines the subject of an annotated axiom or annotated annotation.
    let annotatedSource = _prefix "annotatedSource"


    /// The property that determines the object of an annotated axiom or annotated annotation.
    let annotatedTarget = _prefix "annotatedTarget"


    /// The property that determines the predicate of a negative property assertion.
    let assertionProperty = _prefix "assertionProperty"


    /// The annotation property that indicates that a given ontology is backward compatible with another ontology.
    let backwardCompatibleWith = _prefix "backwardCompatibleWith"


    /// The data property that does not relate any individual to any data value.
    let bottomDataProperty = _prefix "bottomDataProperty"


    /// The object property that does not relate any two individuals.
    let bottomObjectProperty = _prefix "bottomObjectProperty"


    /// The property that determines the cardinality of an exact cardinality restriction.
    let cardinality = _prefix "cardinality"


    /// The property that determines that a given class is the complement of another class.
    let complementOf = _prefix "complementOf"


    /// The property that determines that a given data range is the complement of another data range with respect to the data domain.
    let datatypeComplementOf = _prefix "datatypeComplementOf"


    /// The annotation property that indicates that a given entity has been deprecated.
    let deprecated = _prefix "deprecated"


    /// The property that determines that two given individuals are different.
    let differentFrom = _prefix "differentFrom"


    /// The property that determines that a given class is equivalent to the disjoint union of a collection of other classes.
    let disjointUnionOf = _prefix "disjointUnionOf"


    /// The property that determines that two given classes are disjoint.
    let disjointWith = _prefix "disjointWith"


    /// The property that determines the collection of pairwise different individuals in a owl:AllDifferent axiom.
    let distinctMembers = _prefix "distinctMembers"


    /// The property that determines that two given classes are equivalent, and that is used to specify datatype definitions.
    let equivalentClass = _prefix "equivalentClass"


    /// The property that determines that two given properties are equivalent.
    let equivalentProperty = _prefix "equivalentProperty"


    /// The property that determines the collection of properties that jointly build a key.
    let hasKey = _prefix "hasKey"


    /// The property that determines the property that a self restriction refers to.
    let hasSelf = _prefix "hasSelf"


    /// The property that determines the individual that a has-value restriction refers to.
    let hasValue = _prefix "hasValue"


    /// The property that is used for importing other ontologies into a given ontology.
    let imports = _prefix "imports"


    /// The annotation property that indicates that a given ontology is incompatible with another ontology.
    let incompatibleWith = _prefix "incompatibleWith"


    /// The property that determines the collection of classes or data ranges that build an intersection.
    let intersectionOf = _prefix "intersectionOf"


    /// The property that determines that two given properties are inverse.
    let inverseOf = _prefix "inverseOf"


    /// The property that determines the cardinality of a maximum cardinality restriction.
    let maxCardinality = _prefix "maxCardinality"


    /// The property that determines the cardinality of a maximum qualified cardinality restriction.
    let maxQualifiedCardinality = _prefix "maxQualifiedCardinality"


    /// The property that determines the collection of members in either a owl:AllDifferent, owl:AllDisjointClasses or owl:AllDisjointProperties axiom.
    let members = _prefix "members"


    /// The property that determines the cardinality of a minimum cardinality restriction.
    let minCardinality = _prefix "minCardinality"


    /// The property that determines the cardinality of a minimum qualified cardinality restriction.
    let minQualifiedCardinality = _prefix "minQualifiedCardinality"


    /// The property that determines the class that a qualified object cardinality restriction refers to.
    let onClass = _prefix "onClass"


    /// The property that determines the data range that a qualified data cardinality restriction refers to.
    let onDataRange = _prefix "onDataRange"


    /// The property that determines the datatype that a datatype restriction refers to.
    let onDatatype = _prefix "onDatatype"


    /// The property that determines the n-tuple of properties that a property restriction on an n-ary data range refers to.
    let onProperties = _prefix "onProperties"


    /// The property that determines the property that a property restriction refers to.
    let onProperty = _prefix "onProperty"


    /// The property that determines the collection of individuals or data values that build an enumeration.
    let oneOf = _prefix "oneOf"


    /// The annotation property that indicates the predecessor ontology of a given ontology.
    let priorVersion = _prefix "priorVersion"


    /// The property that determines the n-tuple of properties that build a sub property chain of a given property.
    let propertyChainAxiom = _prefix "propertyChainAxiom"


    /// The property that determines that two given properties are disjoint.
    let propertyDisjointWith = _prefix "propertyDisjointWith"


    /// The property that determines the cardinality of an exact qualified cardinality restriction.
    let qualifiedCardinality = _prefix "qualifiedCardinality"


    /// The property that determines that two given individuals are equal.
    let sameAs = _prefix "sameAs"


    /// The property that determines the class that an existential property restriction refers to.
    let someValuesFrom = _prefix "someValuesFrom"


    /// The property that determines the subject of a negative property assertion.
    let sourceIndividual = _prefix "sourceIndividual"


    /// The property that determines the object of a negative object property assertion.
    let targetIndividual = _prefix "targetIndividual"


    /// The property that determines the value of a negative data property assertion.
    let targetValue = _prefix "targetValue"


    /// The data property that relates every individual to every data value.
    let topDataProperty = _prefix "topDataProperty"


    /// The object property that relates every two individuals.
    let topObjectProperty = _prefix "topObjectProperty"


    /// The property that determines the collection of classes or data ranges that build a union.
    let unionOf = _prefix "unionOf"


    /// The property that identifies the version IRI of an ontology.
    let versionIRI = _prefix "versionIRI"


    /// The annotation property that provides version information for an ontology or another OWL construct.
    let versionInfo = _prefix "versionInfo"


    /// The property that determines the collection of facet-value pairs that define a datatype restriction.
    let withRestrictions = _prefix "withRestrictions"
