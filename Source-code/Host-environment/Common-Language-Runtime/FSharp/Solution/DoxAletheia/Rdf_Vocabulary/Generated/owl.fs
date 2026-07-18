namespace http.www.w3.org._2002._07.owl.hash

open DoxAletheia.Rdf_Vocabulary

module owl =
    let _namespace_name = "http://www.w3.org/2002/07/owl#"
    /// <summary>
    /// The class of ontologies.
    /// <see href="http://www.w3.org/2002/07/owl#Ontology"></see></summary>
    let Ontology = Namespaced_IRI.parse _namespace_name "Ontology" |> NamespacedName
    /// <summary>
    /// The property that is used for importing other ontologies into a given ontology.
    /// <see href="http://www.w3.org/2002/07/owl#imports"></see></summary>
    let imports = Namespaced_IRI.parse _namespace_name "imports" |> NamespacedName
    /// <summary>
    /// The property that identifies the version IRI of an ontology.
    /// <see href="http://www.w3.org/2002/07/owl#versionIRI"></see></summary>
    let versionIRI = Namespaced_IRI.parse _namespace_name "versionIRI" |> NamespacedName

    /// <summary>
    /// The annotation property that provides version information for an ontology or another OWL construct.
    /// <see href="http://www.w3.org/2002/07/owl#versionInfo"></see></summary>
    let versionInfo =
        Namespaced_IRI.parse _namespace_name "versionInfo" |> NamespacedName

    /// <summary>
    /// The class of collections of pairwise different individuals.
    /// <see href="http://www.w3.org/2002/07/owl#AllDifferent"></see></summary>
    let AllDifferent =
        Namespaced_IRI.parse _namespace_name "AllDifferent" |> NamespacedName

    /// <summary>
    /// The class of collections of pairwise disjoint classes.
    /// <see href="http://www.w3.org/2002/07/owl#AllDisjointClasses"></see></summary>
    let AllDisjointClasses =
        Namespaced_IRI.parse _namespace_name "AllDisjointClasses" |> NamespacedName

    /// <summary>
    /// The class of collections of pairwise disjoint properties.
    /// <see href="http://www.w3.org/2002/07/owl#AllDisjointProperties"></see></summary>
    let AllDisjointProperties =
        Namespaced_IRI.parse _namespace_name "AllDisjointProperties" |> NamespacedName

    /// <summary>
    /// The class of annotated annotations for which the RDF serialization consists of an annotated subject, predicate and object.
    /// <see href="http://www.w3.org/2002/07/owl#Annotation"></see></summary>
    let Annotation = Namespaced_IRI.parse _namespace_name "Annotation" |> NamespacedName

    /// <summary>
    /// The class of annotation properties.
    /// <see href="http://www.w3.org/2002/07/owl#AnnotationProperty"></see></summary>
    let AnnotationProperty =
        Namespaced_IRI.parse _namespace_name "AnnotationProperty" |> NamespacedName

    /// <summary>
    /// The class of asymmetric properties.
    /// <see href="http://www.w3.org/2002/07/owl#AsymmetricProperty"></see></summary>
    let AsymmetricProperty =
        Namespaced_IRI.parse _namespace_name "AsymmetricProperty" |> NamespacedName

    /// <summary>
    /// The class of object properties.
    /// <see href="http://www.w3.org/2002/07/owl#ObjectProperty"></see></summary>
    let ObjectProperty =
        Namespaced_IRI.parse _namespace_name "ObjectProperty" |> NamespacedName

    /// <summary>
    /// The class of annotated axioms for which the RDF serialization consists of an annotated subject, predicate and object.
    /// <see href="http://www.w3.org/2002/07/owl#Axiom"></see></summary>
    let Axiom = Namespaced_IRI.parse _namespace_name "Axiom" |> NamespacedName
    /// <summary>
    /// The class of OWL classes.
    /// <see href="http://www.w3.org/2002/07/owl#Class"></see></summary>
    let Class = Namespaced_IRI.parse _namespace_name "Class" |> NamespacedName
    /// <summary>
    /// The class of OWL data ranges, which are special kinds of datatypes. Note: The use of the IRI owl:DataRange has been deprecated as of OWL 2. The IRI rdfs:Datatype SHOULD be used instead.
    /// <see href="http://www.w3.org/2002/07/owl#DataRange"></see></summary>
    let DataRange = Namespaced_IRI.parse _namespace_name "DataRange" |> NamespacedName

    /// <summary>
    /// The class of data properties.
    /// <see href="http://www.w3.org/2002/07/owl#DatatypeProperty"></see></summary>
    let DatatypeProperty =
        Namespaced_IRI.parse _namespace_name "DatatypeProperty" |> NamespacedName

    /// <summary>
    /// The class of deprecated classes.
    /// <see href="http://www.w3.org/2002/07/owl#DeprecatedClass"></see></summary>
    let DeprecatedClass =
        Namespaced_IRI.parse _namespace_name "DeprecatedClass" |> NamespacedName

    /// <summary>
    /// The class of deprecated properties.
    /// <see href="http://www.w3.org/2002/07/owl#DeprecatedProperty"></see></summary>
    let DeprecatedProperty =
        Namespaced_IRI.parse _namespace_name "DeprecatedProperty" |> NamespacedName

    /// <summary>
    /// The class of functional properties.
    /// <see href="http://www.w3.org/2002/07/owl#FunctionalProperty"></see></summary>
    let FunctionalProperty =
        Namespaced_IRI.parse _namespace_name "FunctionalProperty" |> NamespacedName

    /// <summary>
    /// The class of inverse-functional properties.
    /// <see href="http://www.w3.org/2002/07/owl#InverseFunctionalProperty"></see></summary>
    let InverseFunctionalProperty =
        Namespaced_IRI.parse _namespace_name "InverseFunctionalProperty" |> NamespacedName

    /// <summary>
    /// The class of irreflexive properties.
    /// <see href="http://www.w3.org/2002/07/owl#IrreflexiveProperty"></see></summary>
    let IrreflexiveProperty =
        Namespaced_IRI.parse _namespace_name "IrreflexiveProperty" |> NamespacedName

    /// <summary>
    /// The class of named individuals.
    /// <see href="http://www.w3.org/2002/07/owl#NamedIndividual"></see></summary>
    let NamedIndividual =
        Namespaced_IRI.parse _namespace_name "NamedIndividual" |> NamespacedName

    /// <summary>
    /// The class of OWL individuals.
    /// <see href="http://www.w3.org/2002/07/owl#Thing"></see></summary>
    let Thing = Namespaced_IRI.parse _namespace_name "Thing" |> NamespacedName

    /// <summary>
    /// The class of negative property assertions.
    /// <see href="http://www.w3.org/2002/07/owl#NegativePropertyAssertion"></see></summary>
    let NegativePropertyAssertion =
        Namespaced_IRI.parse _namespace_name "NegativePropertyAssertion" |> NamespacedName

    /// <summary>
    /// This is the empty class.
    /// <see href="http://www.w3.org/2002/07/owl#Nothing"></see></summary>
    let Nothing = Namespaced_IRI.parse _namespace_name "Nothing" |> NamespacedName

    /// <summary>
    /// The class of ontology properties.
    /// <see href="http://www.w3.org/2002/07/owl#OntologyProperty"></see></summary>
    let OntologyProperty =
        Namespaced_IRI.parse _namespace_name "OntologyProperty" |> NamespacedName

    /// <summary>
    /// The class of reflexive properties.
    /// <see href="http://www.w3.org/2002/07/owl#ReflexiveProperty"></see></summary>
    let ReflexiveProperty =
        Namespaced_IRI.parse _namespace_name "ReflexiveProperty" |> NamespacedName

    /// <summary>
    /// The class of property restrictions.
    /// <see href="http://www.w3.org/2002/07/owl#Restriction"></see></summary>
    let Restriction =
        Namespaced_IRI.parse _namespace_name "Restriction" |> NamespacedName

    /// <summary>
    /// The class of symmetric properties.
    /// <see href="http://www.w3.org/2002/07/owl#SymmetricProperty"></see></summary>
    let SymmetricProperty =
        Namespaced_IRI.parse _namespace_name "SymmetricProperty" |> NamespacedName

    /// <summary>
    /// The class of transitive properties.
    /// <see href="http://www.w3.org/2002/07/owl#TransitiveProperty"></see></summary>
    let TransitiveProperty =
        Namespaced_IRI.parse _namespace_name "TransitiveProperty" |> NamespacedName

    /// <summary>
    /// The property that determines the class that a universal property restriction refers to.
    /// <see href="http://www.w3.org/2002/07/owl#allValuesFrom"></see></summary>
    let allValuesFrom =
        Namespaced_IRI.parse _namespace_name "allValuesFrom" |> NamespacedName

    /// <summary>
    /// The property that determines the predicate of an annotated axiom or annotated annotation.
    /// <see href="http://www.w3.org/2002/07/owl#annotatedProperty"></see></summary>
    let annotatedProperty =
        Namespaced_IRI.parse _namespace_name "annotatedProperty" |> NamespacedName

    /// <summary>
    /// The property that determines the subject of an annotated axiom or annotated annotation.
    /// <see href="http://www.w3.org/2002/07/owl#annotatedSource"></see></summary>
    let annotatedSource =
        Namespaced_IRI.parse _namespace_name "annotatedSource" |> NamespacedName

    /// <summary>
    /// The property that determines the object of an annotated axiom or annotated annotation.
    /// <see href="http://www.w3.org/2002/07/owl#annotatedTarget"></see></summary>
    let annotatedTarget =
        Namespaced_IRI.parse _namespace_name "annotatedTarget" |> NamespacedName

    /// <summary>
    /// The property that determines the predicate of a negative property assertion.
    /// <see href="http://www.w3.org/2002/07/owl#assertionProperty"></see></summary>
    let assertionProperty =
        Namespaced_IRI.parse _namespace_name "assertionProperty" |> NamespacedName

    /// <summary>
    /// The annotation property that indicates that a given ontology is backward compatible with another ontology.
    /// <see href="http://www.w3.org/2002/07/owl#backwardCompatibleWith"></see></summary>
    let backwardCompatibleWith =
        Namespaced_IRI.parse _namespace_name "backwardCompatibleWith" |> NamespacedName

    /// <summary>
    /// The data property that does not relate any individual to any data value.
    /// <see href="http://www.w3.org/2002/07/owl#bottomDataProperty"></see></summary>
    let bottomDataProperty =
        Namespaced_IRI.parse _namespace_name "bottomDataProperty" |> NamespacedName

    /// <summary>
    /// The object property that does not relate any two individuals.
    /// <see href="http://www.w3.org/2002/07/owl#bottomObjectProperty"></see></summary>
    let bottomObjectProperty =
        Namespaced_IRI.parse _namespace_name "bottomObjectProperty" |> NamespacedName

    /// <summary>
    /// The property that determines the cardinality of an exact cardinality restriction.
    /// <see href="http://www.w3.org/2002/07/owl#cardinality"></see></summary>
    let cardinality =
        Namespaced_IRI.parse _namespace_name "cardinality" |> NamespacedName

    /// <summary>
    /// The property that determines that a given class is the complement of another class.
    /// <see href="http://www.w3.org/2002/07/owl#complementOf"></see></summary>
    let complementOf =
        Namespaced_IRI.parse _namespace_name "complementOf" |> NamespacedName

    /// <summary>
    /// The property that determines that a given data range is the complement of another data range with respect to the data domain.
    /// <see href="http://www.w3.org/2002/07/owl#datatypeComplementOf"></see></summary>
    let datatypeComplementOf =
        Namespaced_IRI.parse _namespace_name "datatypeComplementOf" |> NamespacedName

    /// <summary>
    /// The annotation property that indicates that a given entity has been deprecated.
    /// <see href="http://www.w3.org/2002/07/owl#deprecated"></see></summary>
    let deprecated = Namespaced_IRI.parse _namespace_name "deprecated" |> NamespacedName

    /// <summary>
    /// The property that determines that two given individuals are different.
    /// <see href="http://www.w3.org/2002/07/owl#differentFrom"></see></summary>
    let differentFrom =
        Namespaced_IRI.parse _namespace_name "differentFrom" |> NamespacedName

    /// <summary>
    /// The property that determines that a given class is equivalent to the disjoint union of a collection of other classes.
    /// <see href="http://www.w3.org/2002/07/owl#disjointUnionOf"></see></summary>
    let disjointUnionOf =
        Namespaced_IRI.parse _namespace_name "disjointUnionOf" |> NamespacedName

    /// <summary>
    /// The property that determines that two given classes are disjoint.
    /// <see href="http://www.w3.org/2002/07/owl#disjointWith"></see></summary>
    let disjointWith =
        Namespaced_IRI.parse _namespace_name "disjointWith" |> NamespacedName

    /// <summary>
    /// The property that determines the collection of pairwise different individuals in a owl:AllDifferent axiom.
    /// <see href="http://www.w3.org/2002/07/owl#distinctMembers"></see></summary>
    let distinctMembers =
        Namespaced_IRI.parse _namespace_name "distinctMembers" |> NamespacedName

    /// <summary>
    /// The property that determines that two given classes are equivalent, and that is used to specify datatype definitions.
    /// <see href="http://www.w3.org/2002/07/owl#equivalentClass"></see></summary>
    let equivalentClass =
        Namespaced_IRI.parse _namespace_name "equivalentClass" |> NamespacedName

    /// <summary>
    /// The property that determines that two given properties are equivalent.
    /// <see href="http://www.w3.org/2002/07/owl#equivalentProperty"></see></summary>
    let equivalentProperty =
        Namespaced_IRI.parse _namespace_name "equivalentProperty" |> NamespacedName

    /// <summary>
    /// The property that determines the collection of properties that jointly build a key.
    /// <see href="http://www.w3.org/2002/07/owl#hasKey"></see></summary>
    let hasKey = Namespaced_IRI.parse _namespace_name "hasKey" |> NamespacedName
    /// <summary>
    /// The property that determines the property that a self restriction refers to.
    /// <see href="http://www.w3.org/2002/07/owl#hasSelf"></see></summary>
    let hasSelf = Namespaced_IRI.parse _namespace_name "hasSelf" |> NamespacedName
    /// <summary>
    /// The property that determines the individual that a has-value restriction refers to.
    /// <see href="http://www.w3.org/2002/07/owl#hasValue"></see></summary>
    let hasValue = Namespaced_IRI.parse _namespace_name "hasValue" |> NamespacedName

    /// <summary>
    /// The annotation property that indicates that a given ontology is incompatible with another ontology.
    /// <see href="http://www.w3.org/2002/07/owl#incompatibleWith"></see></summary>
    let incompatibleWith =
        Namespaced_IRI.parse _namespace_name "incompatibleWith" |> NamespacedName

    /// <summary>
    /// The property that determines the collection of classes or data ranges that build an intersection.
    /// <see href="http://www.w3.org/2002/07/owl#intersectionOf"></see></summary>
    let intersectionOf =
        Namespaced_IRI.parse _namespace_name "intersectionOf" |> NamespacedName

    /// <summary>
    /// The property that determines that two given properties are inverse.
    /// <see href="http://www.w3.org/2002/07/owl#inverseOf"></see></summary>
    let inverseOf = Namespaced_IRI.parse _namespace_name "inverseOf" |> NamespacedName

    /// <summary>
    /// The property that determines the cardinality of a maximum cardinality restriction.
    /// <see href="http://www.w3.org/2002/07/owl#maxCardinality"></see></summary>
    let maxCardinality =
        Namespaced_IRI.parse _namespace_name "maxCardinality" |> NamespacedName

    /// <summary>
    /// The property that determines the cardinality of a maximum qualified cardinality restriction.
    /// <see href="http://www.w3.org/2002/07/owl#maxQualifiedCardinality"></see></summary>
    let maxQualifiedCardinality =
        Namespaced_IRI.parse _namespace_name "maxQualifiedCardinality" |> NamespacedName

    /// <summary>
    /// The property that determines the collection of members in either a owl:AllDifferent, owl:AllDisjointClasses or owl:AllDisjointProperties axiom.
    /// <see href="http://www.w3.org/2002/07/owl#members"></see></summary>
    let members = Namespaced_IRI.parse _namespace_name "members" |> NamespacedName

    /// <summary>
    /// The property that determines the cardinality of a minimum cardinality restriction.
    /// <see href="http://www.w3.org/2002/07/owl#minCardinality"></see></summary>
    let minCardinality =
        Namespaced_IRI.parse _namespace_name "minCardinality" |> NamespacedName

    /// <summary>
    /// The property that determines the cardinality of a minimum qualified cardinality restriction.
    /// <see href="http://www.w3.org/2002/07/owl#minQualifiedCardinality"></see></summary>
    let minQualifiedCardinality =
        Namespaced_IRI.parse _namespace_name "minQualifiedCardinality" |> NamespacedName

    /// <summary>
    /// The property that determines the class that a qualified object cardinality restriction refers to.
    /// <see href="http://www.w3.org/2002/07/owl#onClass"></see></summary>
    let onClass = Namespaced_IRI.parse _namespace_name "onClass" |> NamespacedName

    /// <summary>
    /// The property that determines the data range that a qualified data cardinality restriction refers to.
    /// <see href="http://www.w3.org/2002/07/owl#onDataRange"></see></summary>
    let onDataRange =
        Namespaced_IRI.parse _namespace_name "onDataRange" |> NamespacedName

    /// <summary>
    /// The property that determines the datatype that a datatype restriction refers to.
    /// <see href="http://www.w3.org/2002/07/owl#onDatatype"></see></summary>
    let onDatatype = Namespaced_IRI.parse _namespace_name "onDatatype" |> NamespacedName

    /// <summary>
    /// The property that determines the n-tuple of properties that a property restriction on an n-ary data range refers to.
    /// <see href="http://www.w3.org/2002/07/owl#onProperties"></see></summary>
    let onProperties =
        Namespaced_IRI.parse _namespace_name "onProperties" |> NamespacedName

    /// <summary>
    /// The property that determines the property that a property restriction refers to.
    /// <see href="http://www.w3.org/2002/07/owl#onProperty"></see></summary>
    let onProperty = Namespaced_IRI.parse _namespace_name "onProperty" |> NamespacedName
    /// <summary>
    /// The property that determines the collection of individuals or data values that build an enumeration.
    /// <see href="http://www.w3.org/2002/07/owl#oneOf"></see></summary>
    let oneOf = Namespaced_IRI.parse _namespace_name "oneOf" |> NamespacedName

    /// <summary>
    /// The annotation property that indicates the predecessor ontology of a given ontology.
    /// <see href="http://www.w3.org/2002/07/owl#priorVersion"></see></summary>
    let priorVersion =
        Namespaced_IRI.parse _namespace_name "priorVersion" |> NamespacedName

    /// <summary>
    /// The property that determines the n-tuple of properties that build a sub property chain of a given property.
    /// <see href="http://www.w3.org/2002/07/owl#propertyChainAxiom"></see></summary>
    let propertyChainAxiom =
        Namespaced_IRI.parse _namespace_name "propertyChainAxiom" |> NamespacedName

    /// <summary>
    /// The property that determines that two given properties are disjoint.
    /// <see href="http://www.w3.org/2002/07/owl#propertyDisjointWith"></see></summary>
    let propertyDisjointWith =
        Namespaced_IRI.parse _namespace_name "propertyDisjointWith" |> NamespacedName

    /// <summary>
    /// The property that determines the cardinality of an exact qualified cardinality restriction.
    /// <see href="http://www.w3.org/2002/07/owl#qualifiedCardinality"></see></summary>
    let qualifiedCardinality =
        Namespaced_IRI.parse _namespace_name "qualifiedCardinality" |> NamespacedName

    /// <summary>
    /// The property that determines that two given individuals are equal.
    /// <see href="http://www.w3.org/2002/07/owl#sameAs"></see></summary>
    let sameAs = Namespaced_IRI.parse _namespace_name "sameAs" |> NamespacedName

    /// <summary>
    /// The property that determines the class that an existential property restriction refers to.
    /// <see href="http://www.w3.org/2002/07/owl#someValuesFrom"></see></summary>
    let someValuesFrom =
        Namespaced_IRI.parse _namespace_name "someValuesFrom" |> NamespacedName

    /// <summary>
    /// The property that determines the subject of a negative property assertion.
    /// <see href="http://www.w3.org/2002/07/owl#sourceIndividual"></see></summary>
    let sourceIndividual =
        Namespaced_IRI.parse _namespace_name "sourceIndividual" |> NamespacedName

    /// <summary>
    /// The property that determines the object of a negative object property assertion.
    /// <see href="http://www.w3.org/2002/07/owl#targetIndividual"></see></summary>
    let targetIndividual =
        Namespaced_IRI.parse _namespace_name "targetIndividual" |> NamespacedName

    /// <summary>
    /// The property that determines the value of a negative data property assertion.
    /// <see href="http://www.w3.org/2002/07/owl#targetValue"></see></summary>
    let targetValue =
        Namespaced_IRI.parse _namespace_name "targetValue" |> NamespacedName

    /// <summary>
    /// The data property that relates every individual to every data value.
    /// <see href="http://www.w3.org/2002/07/owl#topDataProperty"></see></summary>
    let topDataProperty =
        Namespaced_IRI.parse _namespace_name "topDataProperty" |> NamespacedName

    /// <summary>
    /// The object property that relates every two individuals.
    /// <see href="http://www.w3.org/2002/07/owl#topObjectProperty"></see></summary>
    let topObjectProperty =
        Namespaced_IRI.parse _namespace_name "topObjectProperty" |> NamespacedName

    /// <summary>
    /// The property that determines the collection of classes or data ranges that build a union.
    /// <see href="http://www.w3.org/2002/07/owl#unionOf"></see></summary>
    let unionOf = Namespaced_IRI.parse _namespace_name "unionOf" |> NamespacedName

    /// <summary>
    /// The property that determines the collection of facet-value pairs that define a datatype restriction.
    /// <see href="http://www.w3.org/2002/07/owl#withRestrictions"></see></summary>
    let withRestrictions =
        Namespaced_IRI.parse _namespace_name "withRestrictions" |> NamespacedName
