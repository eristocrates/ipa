#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\RDFErgonomics.fsx"
open RDFErgonomics

module owl =

    let prefix = prefix_label "owl"

    /// rdfs:comment "The class of collections of pairwise different individuals." ;
    let AllDifferent = prefix "AllDifferent"
    /// rdfs:comment "The class of collections of pairwise disjoint classes." ;
    let AllDisjointClasses = prefix "AllDisjointClasses"
    /// rdfs:comment "The class of collections of pairwise disjoint properties." ;
    let AllDisjointProperties = prefix "AllDisjointProperties"
    /// rdfs:comment "The class of annotated annotations for which the RDF serialization consists of an annotated subject, predicate and object." ;
    let Annotation = prefix "Annotation"
    /// rdfs:comment "The class of annotation properties." ;
    let AnnotationProperty = prefix "AnnotationProperty"
    /// rdfs:comment "The class of asymmetric properties." ;
    let AsymmetricProperty = prefix "AsymmetricProperty"
    /// rdfs:comment "The class of annotated axioms for which the RDF serialization consists of an annotated subject, predicate and object." ;
    let Axiom = prefix "Axiom"
    /// rdfs:comment "The class of OWL classes." ;
    let Class = prefix "Class"
    /// rdfs:comment "The class of OWL data ranges, which are special kinds of datatypes. Note: The use of the IRI owl:DataRange has been deprecated as of OWL 2. The IRI rdfs:Datatype SHOULD be used instead." ;
    let DataRange = prefix "DataRange"
    /// rdfs:comment "The class of data properties." ;
    let DatatypeProperty = prefix "DatatypeProperty"
    /// rdfs:comment "The class of deprecated classes." ;
    let DeprecatedClass = prefix "DeprecatedClass"
    /// rdfs:comment "The class of deprecated properties." ;
    let DeprecatedProperty = prefix "DeprecatedProperty"
    /// rdfs:comment "The class of functional properties." ;
    let FunctionalProperty = prefix "FunctionalProperty"
    /// rdfs:comment "The class of inverse-functional properties." ;
    let InverseFunctionalProperty = prefix "InverseFunctionalProperty"
    /// rdfs:comment "The class of irreflexive properties." ;
    let IrreflexiveProperty = prefix "IrreflexiveProperty"
    /// rdfs:comment "The class of named individuals." ;
    let NamedIndividual = prefix "NamedIndividual"
    /// rdfs:comment "The class of negative property assertions." ;
    let NegativePropertyAssertion = prefix "NegativePropertyAssertion"
    /// rdfs:comment "This is the empty class." ;
    let Nothing = prefix "Nothing"
    /// rdfs:comment "The class of object properties." ;
    let ObjectProperty = prefix "ObjectProperty"
    /// rdfs:comment "The class of ontologies." ;
    let Ontology = prefix "Ontology"
    /// rdfs:comment "The class of ontology properties." ;
    let OntologyProperty = prefix "OntologyProperty"
    /// rdfs:comment "The class of reflexive properties." ;
    let ReflexiveProperty = prefix "ReflexiveProperty"
    /// rdfs:comment "The class of property restrictions." ;
    let Restriction = prefix "Restriction"
    /// rdfs:comment "The class of symmetric properties." ;
    let SymmetricProperty = prefix "SymmetricProperty"
    /// rdfs:comment "The class of transitive properties." ;
    let TransitiveProperty = prefix "TransitiveProperty"
    /// rdfs:comment "The class of OWL individuals." ;
    let Thing = prefix "Thing"
    /// rdfs:comment "The property that determines the class that a universal property restriction refers to." ;
    let allValuesFrom = prefix "allValuesFrom"
    /// rdfs:comment "The property that determines the predicate of an annotated axiom or annotated annotation." ;
    let annotatedProperty = prefix "annotatedProperty"
    /// rdfs:comment "The property that determines the subject of an annotated axiom or annotated annotation." ;
    let annotatedSource = prefix "annotatedSource"
    /// rdfs:comment "The property that determines the object of an annotated axiom or annotated annotation." ;
    let annotatedTarget = prefix "annotatedTarget"
    /// rdfs:comment "The property that determines the predicate of a negative property assertion." ;
    let assertionProperty = prefix "assertionProperty"
    /// rdfs:comment "The annotation property that indicates that a given ontology is backward compatible with another ontology." ;
    let backwardCompatibleWith = prefix "backwardCompatibleWith"
    /// rdfs:comment "The data property that does not relate any individual to any data value." ;
    let bottomDataProperty = prefix "bottomDataProperty"
    /// rdfs:comment "The object property that does not relate any two individuals." ;
    let bottomObjectProperty = prefix "bottomObjectProperty"
    /// rdfs:comment "The property that determines the cardinality of an exact cardinality restriction." ;
    let cardinality = prefix "cardinality"
    /// rdfs:comment "The property that determines that a given class is the complement of another class." ;
    let complementOf = prefix "complementOf"
    /// rdfs:comment "The property that determines that a given data range is the complement of another data range with respect to the data domain." ;
    let datatypeComplementOf = prefix "datatypeComplementOf"
    /// rdfs:comment "The annotation property that indicates that a given entity has been deprecated." ;
    let deprecated = prefix "deprecated"
    /// rdfs:comment "The property that determines that two given individuals are different." ;
    let differentFrom = prefix "differentFrom"
    /// rdfs:comment "The property that determines that a given class is equivalent to the disjoint union of a collection of other classes." ;
    let disjointUnionOf = prefix "disjointUnionOf"
    /// rdfs:comment "The property that determines that two given classes are disjoint." ;
    let disjointWith = prefix "disjointWith"
    /// rdfs:comment "The property that determines the collection of pairwise different individuals in a owl:AllDifferent axiom." ;
    let distinctMembers = prefix "distinctMembers"
    /// rdfs:comment "The property that determines that two given classes are equivalent, and that is used to specify datatype definitions." ;
    let equivalentClass = prefix "equivalentClass"
    /// rdfs:comment "The property that determines that two given properties are equivalent." ;
    let equivalentProperty = prefix "equivalentProperty"
    /// rdfs:comment "The property that determines the collection of properties that jointly build a key." ;
    let hasKey = prefix "hasKey"
    /// rdfs:comment "The property that determines the property that a self restriction refers to." ;
    let hasSelf = prefix "hasSelf"
    /// rdfs:comment "The property that determines the individual that a has-value restriction refers to." ;
    let hasValue = prefix "hasValue"
    /// rdfs:comment "The property that is used for importing other ontologies into a given ontology." ;
    let imports = prefix "imports"
    /// rdfs:comment "The annotation property that indicates that a given ontology is incompatible with another ontology." ;
    let incompatibleWith = prefix "incompatibleWith"
    /// rdfs:comment "The property that determines the collection of classes or data ranges that build an intersection." ;
    let intersectionOf = prefix "intersectionOf"
    /// rdfs:comment "The property that determines that two given properties are inverse." ;
    let inverseOf = prefix "inverseOf"
    /// rdfs:comment "The property that determines the cardinality of a maximum cardinality restriction." ;
    let maxCardinality = prefix "maxCardinality"
    /// rdfs:comment "The property that determines the cardinality of a maximum qualified cardinality restriction." ;
    let maxQualifiedCardinality = prefix "maxQualifiedCardinality"
    /// rdfs:comment "The property that determines the collection of members in either a owl:AllDifferent, owl:AllDisjointClasses or owl:AllDisjointProperties axiom." ;
    let members = prefix "members"
    /// rdfs:comment "The property that determines the cardinality of a minimum cardinality restriction." ;
    let minCardinality = prefix "minCardinality"
    /// rdfs:comment "The property that determines the cardinality of a minimum qualified cardinality restriction." ;
    let minQualifiedCardinality = prefix "minQualifiedCardinality"
    /// rdfs:comment "The property that determines the class that a qualified object cardinality restriction refers to." ;
    let onClass = prefix "onClass"
    /// rdfs:comment "The property that determines the data range that a qualified data cardinality restriction refers to." ;
    let onDataRange = prefix "onDataRange"
    /// rdfs:comment "The property that determines the datatype that a datatype restriction refers to." ;
    let onDatatype = prefix "onDatatype"
    /// rdfs:comment "The property that determines the collection of individuals or data values that build an enumeration." ;
    let oneOf = prefix "oneOf"
    /// rdfs:comment "The property that determines the n-tuple of properties that a property restriction on an n-ary data range refers to." ;
    let onProperties = prefix "onProperties"
    /// rdfs:comment "The property that determines the property that a property restriction refers to." ;
    let onProperty = prefix "onProperty"
    /// rdfs:comment "The annotation property that indicates the predecessor ontology of a given ontology." ;
    let priorVersion = prefix "priorVersion"
    /// rdfs:comment "The property that determines the n-tuple of properties that build a sub property chain of a given property." ;
    let propertyChainAxiom = prefix "propertyChainAxiom"
    /// rdfs:comment "The property that determines that two given properties are disjoint." ;
    let propertyDisjointWith = prefix "propertyDisjointWith"
    /// rdfs:comment "The property that determines the cardinality of an exact qualified cardinality restriction." ;
    let qualifiedCardinality = prefix "qualifiedCardinality"
    /// rdfs:comment "The property that determines that two given individuals are equal." ;
    let sameAs = prefix "sameAs"
    /// rdfs:comment "The property that determines the class that an existential property restriction refers to." ;
    let someValuesFrom = prefix "someValuesFrom"
    /// rdfs:comment "The property that determines the subject of a negative property assertion." ;
    let sourceIndividual = prefix "sourceIndividual"
    /// rdfs:comment "The property that determines the object of a negative object property assertion." ;
    let targetIndividual = prefix "targetIndividual"
    /// rdfs:comment "The property that determines the value of a negative data property assertion." ;
    let targetValue = prefix "targetValue"
    /// rdfs:comment "The data property that relates every individual to every data value." ;
    let topDataProperty = prefix "topDataProperty"
    /// rdfs:comment "The object property that relates every two individuals." ;
    let topObjectProperty = prefix "topObjectProperty"
    /// rdfs:comment "The property that determines the collection of classes or data ranges that build a union." ;
    let unionOf = prefix "unionOf"
    /// rdfs:comment "The annotation property that provides version information for an ontology or another OWL construct." ;
    let versionInfo = prefix "versionInfo"
    /// rdfs:comment "The property that identifies the version IRI of an ontology." ;
    let versionIRI = prefix "versionIRI"
    /// rdfs:comment "The property that determines the collection of facet-value pairs that define a datatype restriction." ;
    let withRestrictions = prefix "withRestrictions"
