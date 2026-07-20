namespace http.www.w3.org._2002._07.owl.hash

open DoxAletheia

module owl =
    let _namespace_name = "http://www.w3.org/2002/07/owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The class of ontologies.
    /// <see href="http://www.w3.org/2002/07/owl#Ontology"></see></summary>
    let Ontology = _prefix "Ontology"
    /// <summary>
    /// The property that is used for importing other ontologies into a given ontology.
    /// <see href="http://www.w3.org/2002/07/owl#imports"></see></summary>
    let imports = _prefix "imports"
    /// <summary>
    /// The property that identifies the version IRI of an ontology.
    /// <see href="http://www.w3.org/2002/07/owl#versionIRI"></see></summary>
    let versionIRI = _prefix "versionIRI"
    /// <summary>
    /// The annotation property that provides version information for an ontology or another OWL construct.
    /// <see href="http://www.w3.org/2002/07/owl#versionInfo"></see></summary>
    let versionInfo = _prefix "versionInfo"
    /// <summary>
    /// The class of collections of pairwise different individuals.
    /// <see href="http://www.w3.org/2002/07/owl#AllDifferent"></see></summary>
    let AllDifferent = _prefix "AllDifferent"
    /// <summary>
    /// The class of collections of pairwise disjoint classes.
    /// <see href="http://www.w3.org/2002/07/owl#AllDisjointClasses"></see></summary>
    let AllDisjointClasses = _prefix "AllDisjointClasses"
    /// <summary>
    /// The class of collections of pairwise disjoint properties.
    /// <see href="http://www.w3.org/2002/07/owl#AllDisjointProperties"></see></summary>
    let AllDisjointProperties = _prefix "AllDisjointProperties"
    /// <summary>
    /// The class of annotated annotations for which the RDF serialization consists of an annotated subject, predicate and object.
    /// <see href="http://www.w3.org/2002/07/owl#Annotation"></see></summary>
    let Annotation = _prefix "Annotation"
    /// <summary>
    /// The class of annotation properties.
    /// <see href="http://www.w3.org/2002/07/owl#AnnotationProperty"></see></summary>
    let AnnotationProperty = _prefix "AnnotationProperty"
    /// <summary>
    /// The class of asymmetric properties.
    /// <see href="http://www.w3.org/2002/07/owl#AsymmetricProperty"></see></summary>
    let AsymmetricProperty = _prefix "AsymmetricProperty"
    /// <summary>
    /// The class of object properties.
    /// <see href="http://www.w3.org/2002/07/owl#ObjectProperty"></see></summary>
    let ObjectProperty = _prefix "ObjectProperty"
    /// <summary>
    /// The class of annotated axioms for which the RDF serialization consists of an annotated subject, predicate and object.
    /// <see href="http://www.w3.org/2002/07/owl#Axiom"></see></summary>
    let Axiom = _prefix "Axiom"
    /// <summary>
    /// The class of OWL classes.
    /// <see href="http://www.w3.org/2002/07/owl#Class"></see></summary>
    let Class = _prefix "Class"
    /// <summary>
    /// The class of OWL data ranges, which are special kinds of datatypes. Note: The use of the IRI owl:DataRange has been deprecated as of OWL 2. The IRI rdfs:Datatype SHOULD be used instead.
    /// <see href="http://www.w3.org/2002/07/owl#DataRange"></see></summary>
    let DataRange = _prefix "DataRange"
    /// <summary>
    /// The class of data properties.
    /// <see href="http://www.w3.org/2002/07/owl#DatatypeProperty"></see></summary>
    let DatatypeProperty = _prefix "DatatypeProperty"
    /// <summary>
    /// The class of deprecated classes.
    /// <see href="http://www.w3.org/2002/07/owl#DeprecatedClass"></see></summary>
    let DeprecatedClass = _prefix "DeprecatedClass"
    /// <summary>
    /// The class of deprecated properties.
    /// <see href="http://www.w3.org/2002/07/owl#DeprecatedProperty"></see></summary>
    let DeprecatedProperty = _prefix "DeprecatedProperty"
    /// <summary>
    /// The class of functional properties.
    /// <see href="http://www.w3.org/2002/07/owl#FunctionalProperty"></see></summary>
    let FunctionalProperty = _prefix "FunctionalProperty"
    /// <summary>
    /// The class of inverse-functional properties.
    /// <see href="http://www.w3.org/2002/07/owl#InverseFunctionalProperty"></see></summary>
    let InverseFunctionalProperty = _prefix "InverseFunctionalProperty"
    /// <summary>
    /// The class of irreflexive properties.
    /// <see href="http://www.w3.org/2002/07/owl#IrreflexiveProperty"></see></summary>
    let IrreflexiveProperty = _prefix "IrreflexiveProperty"
    /// <summary>
    /// The class of named individuals.
    /// <see href="http://www.w3.org/2002/07/owl#NamedIndividual"></see></summary>
    let NamedIndividual = _prefix "NamedIndividual"
    /// <summary>
    /// The class of OWL individuals.
    /// <see href="http://www.w3.org/2002/07/owl#Thing"></see></summary>
    let Thing = _prefix "Thing"
    /// <summary>
    /// The class of negative property assertions.
    /// <see href="http://www.w3.org/2002/07/owl#NegativePropertyAssertion"></see></summary>
    let NegativePropertyAssertion = _prefix "NegativePropertyAssertion"
    /// <summary>
    /// This is the empty class.
    /// <see href="http://www.w3.org/2002/07/owl#Nothing"></see></summary>
    let Nothing = _prefix "Nothing"
    /// <summary>
    /// The class of ontology properties.
    /// <see href="http://www.w3.org/2002/07/owl#OntologyProperty"></see></summary>
    let OntologyProperty = _prefix "OntologyProperty"
    /// <summary>
    /// The class of reflexive properties.
    /// <see href="http://www.w3.org/2002/07/owl#ReflexiveProperty"></see></summary>
    let ReflexiveProperty = _prefix "ReflexiveProperty"
    /// <summary>
    /// The class of property restrictions.
    /// <see href="http://www.w3.org/2002/07/owl#Restriction"></see></summary>
    let Restriction = _prefix "Restriction"
    /// <summary>
    /// The class of symmetric properties.
    /// <see href="http://www.w3.org/2002/07/owl#SymmetricProperty"></see></summary>
    let SymmetricProperty = _prefix "SymmetricProperty"
    /// <summary>
    /// The class of transitive properties.
    /// <see href="http://www.w3.org/2002/07/owl#TransitiveProperty"></see></summary>
    let TransitiveProperty = _prefix "TransitiveProperty"
    /// <summary>
    /// The property that determines the class that a universal property restriction refers to.
    /// <see href="http://www.w3.org/2002/07/owl#allValuesFrom"></see></summary>
    let allValuesFrom = _prefix "allValuesFrom"
    /// <summary>
    /// The property that determines the predicate of an annotated axiom or annotated annotation.
    /// <see href="http://www.w3.org/2002/07/owl#annotatedProperty"></see></summary>
    let annotatedProperty = _prefix "annotatedProperty"
    /// <summary>
    /// The property that determines the subject of an annotated axiom or annotated annotation.
    /// <see href="http://www.w3.org/2002/07/owl#annotatedSource"></see></summary>
    let annotatedSource = _prefix "annotatedSource"
    /// <summary>
    /// The property that determines the object of an annotated axiom or annotated annotation.
    /// <see href="http://www.w3.org/2002/07/owl#annotatedTarget"></see></summary>
    let annotatedTarget = _prefix "annotatedTarget"
    /// <summary>
    /// The property that determines the predicate of a negative property assertion.
    /// <see href="http://www.w3.org/2002/07/owl#assertionProperty"></see></summary>
    let assertionProperty = _prefix "assertionProperty"
    /// <summary>
    /// The annotation property that indicates that a given ontology is backward compatible with another ontology.
    /// <see href="http://www.w3.org/2002/07/owl#backwardCompatibleWith"></see></summary>
    let backwardCompatibleWith = _prefix "backwardCompatibleWith"
    /// <summary>
    /// The data property that does not relate any individual to any data value.
    /// <see href="http://www.w3.org/2002/07/owl#bottomDataProperty"></see></summary>
    let bottomDataProperty = _prefix "bottomDataProperty"
    /// <summary>
    /// The object property that does not relate any two individuals.
    /// <see href="http://www.w3.org/2002/07/owl#bottomObjectProperty"></see></summary>
    let bottomObjectProperty = _prefix "bottomObjectProperty"
    /// <summary>
    /// The property that determines the cardinality of an exact cardinality restriction.
    /// <see href="http://www.w3.org/2002/07/owl#cardinality"></see></summary>
    let cardinality = _prefix "cardinality"
    /// <summary>
    /// The property that determines that a given class is the complement of another class.
    /// <see href="http://www.w3.org/2002/07/owl#complementOf"></see></summary>
    let complementOf = _prefix "complementOf"
    /// <summary>
    /// The property that determines that a given data range is the complement of another data range with respect to the data domain.
    /// <see href="http://www.w3.org/2002/07/owl#datatypeComplementOf"></see></summary>
    let datatypeComplementOf = _prefix "datatypeComplementOf"
    /// <summary>
    /// The annotation property that indicates that a given entity has been deprecated.
    /// <see href="http://www.w3.org/2002/07/owl#deprecated"></see></summary>
    let deprecated = _prefix "deprecated"
    /// <summary>
    /// The property that determines that two given individuals are different.
    /// <see href="http://www.w3.org/2002/07/owl#differentFrom"></see></summary>
    let differentFrom = _prefix "differentFrom"
    /// <summary>
    /// The property that determines that a given class is equivalent to the disjoint union of a collection of other classes.
    /// <see href="http://www.w3.org/2002/07/owl#disjointUnionOf"></see></summary>
    let disjointUnionOf = _prefix "disjointUnionOf"
    /// <summary>
    /// The property that determines that two given classes are disjoint.
    /// <see href="http://www.w3.org/2002/07/owl#disjointWith"></see></summary>
    let disjointWith = _prefix "disjointWith"
    /// <summary>
    /// The property that determines the collection of pairwise different individuals in a owl:AllDifferent axiom.
    /// <see href="http://www.w3.org/2002/07/owl#distinctMembers"></see></summary>
    let distinctMembers = _prefix "distinctMembers"
    /// <summary>
    /// The property that determines that two given classes are equivalent, and that is used to specify datatype definitions.
    /// <see href="http://www.w3.org/2002/07/owl#equivalentClass"></see></summary>
    let equivalentClass = _prefix "equivalentClass"
    /// <summary>
    /// The property that determines that two given properties are equivalent.
    /// <see href="http://www.w3.org/2002/07/owl#equivalentProperty"></see></summary>
    let equivalentProperty = _prefix "equivalentProperty"
    /// <summary>
    /// The property that determines the collection of properties that jointly build a key.
    /// <see href="http://www.w3.org/2002/07/owl#hasKey"></see></summary>
    let hasKey = _prefix "hasKey"
    /// <summary>
    /// The property that determines the property that a self restriction refers to.
    /// <see href="http://www.w3.org/2002/07/owl#hasSelf"></see></summary>
    let hasSelf = _prefix "hasSelf"
    /// <summary>
    /// The property that determines the individual that a has-value restriction refers to.
    /// <see href="http://www.w3.org/2002/07/owl#hasValue"></see></summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    /// The annotation property that indicates that a given ontology is incompatible with another ontology.
    /// <see href="http://www.w3.org/2002/07/owl#incompatibleWith"></see></summary>
    let incompatibleWith = _prefix "incompatibleWith"
    /// <summary>
    /// The property that determines the collection of classes or data ranges that build an intersection.
    /// <see href="http://www.w3.org/2002/07/owl#intersectionOf"></see></summary>
    let intersectionOf = _prefix "intersectionOf"
    /// <summary>
    /// The property that determines that two given properties are inverse.
    /// <see href="http://www.w3.org/2002/07/owl#inverseOf"></see></summary>
    let inverseOf = _prefix "inverseOf"
    /// <summary>
    /// The property that determines the cardinality of a maximum cardinality restriction.
    /// <see href="http://www.w3.org/2002/07/owl#maxCardinality"></see></summary>
    let maxCardinality = _prefix "maxCardinality"
    /// <summary>
    /// The property that determines the cardinality of a maximum qualified cardinality restriction.
    /// <see href="http://www.w3.org/2002/07/owl#maxQualifiedCardinality"></see></summary>
    let maxQualifiedCardinality = _prefix "maxQualifiedCardinality"
    /// <summary>
    /// The property that determines the collection of members in either a owl:AllDifferent, owl:AllDisjointClasses or owl:AllDisjointProperties axiom.
    /// <see href="http://www.w3.org/2002/07/owl#members"></see></summary>
    let members = _prefix "members"
    /// <summary>
    /// The property that determines the cardinality of a minimum cardinality restriction.
    /// <see href="http://www.w3.org/2002/07/owl#minCardinality"></see></summary>
    let minCardinality = _prefix "minCardinality"
    /// <summary>
    /// The property that determines the cardinality of a minimum qualified cardinality restriction.
    /// <see href="http://www.w3.org/2002/07/owl#minQualifiedCardinality"></see></summary>
    let minQualifiedCardinality = _prefix "minQualifiedCardinality"
    /// <summary>
    /// The property that determines the class that a qualified object cardinality restriction refers to.
    /// <see href="http://www.w3.org/2002/07/owl#onClass"></see></summary>
    let onClass = _prefix "onClass"
    /// <summary>
    /// The property that determines the data range that a qualified data cardinality restriction refers to.
    /// <see href="http://www.w3.org/2002/07/owl#onDataRange"></see></summary>
    let onDataRange = _prefix "onDataRange"
    /// <summary>
    /// The property that determines the datatype that a datatype restriction refers to.
    /// <see href="http://www.w3.org/2002/07/owl#onDatatype"></see></summary>
    let onDatatype = _prefix "onDatatype"
    /// <summary>
    /// The property that determines the n-tuple of properties that a property restriction on an n-ary data range refers to.
    /// <see href="http://www.w3.org/2002/07/owl#onProperties"></see></summary>
    let onProperties = _prefix "onProperties"
    /// <summary>
    /// The property that determines the property that a property restriction refers to.
    /// <see href="http://www.w3.org/2002/07/owl#onProperty"></see></summary>
    let onProperty = _prefix "onProperty"
    /// <summary>
    /// The property that determines the collection of individuals or data values that build an enumeration.
    /// <see href="http://www.w3.org/2002/07/owl#oneOf"></see></summary>
    let oneOf = _prefix "oneOf"
    /// <summary>
    /// The annotation property that indicates the predecessor ontology of a given ontology.
    /// <see href="http://www.w3.org/2002/07/owl#priorVersion"></see></summary>
    let priorVersion = _prefix "priorVersion"
    /// <summary>
    /// The property that determines the n-tuple of properties that build a sub property chain of a given property.
    /// <see href="http://www.w3.org/2002/07/owl#propertyChainAxiom"></see></summary>
    let propertyChainAxiom = _prefix "propertyChainAxiom"
    /// <summary>
    /// The property that determines that two given properties are disjoint.
    /// <see href="http://www.w3.org/2002/07/owl#propertyDisjointWith"></see></summary>
    let propertyDisjointWith = _prefix "propertyDisjointWith"
    /// <summary>
    /// The property that determines the cardinality of an exact qualified cardinality restriction.
    /// <see href="http://www.w3.org/2002/07/owl#qualifiedCardinality"></see></summary>
    let qualifiedCardinality = _prefix "qualifiedCardinality"
    /// <summary>
    /// The property that determines that two given individuals are equal.
    /// <see href="http://www.w3.org/2002/07/owl#sameAs"></see></summary>
    let sameAs = _prefix "sameAs"
    /// <summary>
    /// The property that determines the class that an existential property restriction refers to.
    /// <see href="http://www.w3.org/2002/07/owl#someValuesFrom"></see></summary>
    let someValuesFrom = _prefix "someValuesFrom"
    /// <summary>
    /// The property that determines the subject of a negative property assertion.
    /// <see href="http://www.w3.org/2002/07/owl#sourceIndividual"></see></summary>
    let sourceIndividual = _prefix "sourceIndividual"
    /// <summary>
    /// The property that determines the object of a negative object property assertion.
    /// <see href="http://www.w3.org/2002/07/owl#targetIndividual"></see></summary>
    let targetIndividual = _prefix "targetIndividual"
    /// <summary>
    /// The property that determines the value of a negative data property assertion.
    /// <see href="http://www.w3.org/2002/07/owl#targetValue"></see></summary>
    let targetValue = _prefix "targetValue"
    /// <summary>
    /// The data property that relates every individual to every data value.
    /// <see href="http://www.w3.org/2002/07/owl#topDataProperty"></see></summary>
    let topDataProperty = _prefix "topDataProperty"
    /// <summary>
    /// The object property that relates every two individuals.
    /// <see href="http://www.w3.org/2002/07/owl#topObjectProperty"></see></summary>
    let topObjectProperty = _prefix "topObjectProperty"
    /// <summary>
    /// The property that determines the collection of classes or data ranges that build a union.
    /// <see href="http://www.w3.org/2002/07/owl#unionOf"></see></summary>
    let unionOf = _prefix "unionOf"
    /// <summary>
    /// The property that determines the collection of facet-value pairs that define a datatype restriction.
    /// <see href="http://www.w3.org/2002/07/owl#withRestrictions"></see></summary>
    let withRestrictions = _prefix "withRestrictions"
