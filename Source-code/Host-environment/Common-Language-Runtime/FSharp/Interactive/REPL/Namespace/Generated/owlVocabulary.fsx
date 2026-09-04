module owl =
    let _namespaceIri = owlVocabulary.prefixId.prefix ""

    /// <summary>
    ///   <para>rdfs:comment : The class of collections of pairwise different individuals.^^xsd:string</para>
    ///   <para>rdfs:label : AllDifferent^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#AllDifferent">owl:AllDifferent</a>
    /// </summary>
    let AllDifferent = owlVocabulary.prefixId.prefix "AllDifferent"

    /// <summary>
    ///   <para>rdfs:comment : The class of collections of pairwise disjoint classes.^^xsd:string</para>
    ///   <para>rdfs:label : AllDisjointClasses^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#AllDisjointClasses">owl:AllDisjointClasses</a>
    /// </summary>
    let AllDisjointClasses = owlVocabulary.prefixId.prefix "AllDisjointClasses"

    /// <summary>
    ///   <para>rdfs:comment : The class of collections of pairwise disjoint properties.^^xsd:string</para>
    ///   <para>rdfs:label : AllDisjointProperties^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#AllDisjointProperties">owl:AllDisjointProperties</a>
    /// </summary>
    let AllDisjointProperties = owlVocabulary.prefixId.prefix "AllDisjointProperties"

    /// <summary>
    ///   <para>rdfs:comment : The class of annotated annotations for which the RDF serialization consists of an annotated subject, predicate and object.^^xsd:string</para>
    ///   <para>rdfs:label : Annotation^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Annotation">owl:Annotation</a>
    /// </summary>
    let Annotation = owlVocabulary.prefixId.prefix "Annotation"

    /// <summary>
    ///   <para>rdfs:comment : The class of annotation properties.^^xsd:string</para>
    ///   <para>rdfs:label : AnnotationProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#AnnotationProperty">owl:AnnotationProperty</a>
    /// </summary>
    let AnnotationProperty = owlVocabulary.prefixId.prefix "AnnotationProperty"

    /// <summary>
    ///   <para>rdfs:comment : The class of asymmetric properties.^^xsd:string</para>
    ///   <para>rdfs:label : AsymmetricProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#AsymmetricProperty">owl:AsymmetricProperty</a>
    /// </summary>
    let AsymmetricProperty = owlVocabulary.prefixId.prefix "AsymmetricProperty"

    /// <summary>
    ///   <para>rdfs:comment : The class of annotated axioms for which the RDF serialization consists of an annotated subject, predicate and object.^^xsd:string</para>
    ///   <para>rdfs:label : Axiom^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Axiom">owl:Axiom</a>
    /// </summary>
    let Axiom = owlVocabulary.prefixId.prefix "Axiom"

    /// <summary>
    ///   <para>rdfs:comment : The class of OWL classes.^^xsd:string</para>
    ///   <para>rdfs:label : Class^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Class">owl:Class</a>
    /// </summary>
    let Class = owlVocabulary.prefixId.prefix "Class"

    /// <summary>
    ///   <para>rdfs:comment : The class of OWL data ranges, which are special kinds of datatypes. Note: The use of the IRI owl:DataRange has been deprecated as of OWL 2. The IRI rdfs:Datatype SHOULD be used instead.^^xsd:string</para>
    ///   <para>rdfs:label : DataRange^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#DataRange">owl:DataRange</a>
    /// </summary>
    let DataRange = owlVocabulary.prefixId.prefix "DataRange"

    /// <summary>
    ///   <para>rdfs:comment : The class of data properties.^^xsd:string</para>
    ///   <para>rdfs:label : DatatypeProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#DatatypeProperty">owl:DatatypeProperty</a>
    /// </summary>
    let DatatypeProperty = owlVocabulary.prefixId.prefix "DatatypeProperty"

    /// <summary>
    ///   <para>rdfs:comment : The class of deprecated classes.^^xsd:string</para>
    ///   <para>rdfs:label : DeprecatedClass^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#DeprecatedClass">owl:DeprecatedClass</a>
    /// </summary>
    let DeprecatedClass = owlVocabulary.prefixId.prefix "DeprecatedClass"

    /// <summary>
    ///   <para>rdfs:comment : The class of deprecated properties.^^xsd:string</para>
    ///   <para>rdfs:label : DeprecatedProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#DeprecatedProperty">owl:DeprecatedProperty</a>
    /// </summary>
    let DeprecatedProperty = owlVocabulary.prefixId.prefix "DeprecatedProperty"

    /// <summary>
    ///   <para>rdfs:comment : The class of functional properties.^^xsd:string</para>
    ///   <para>rdfs:label : FunctionalProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#FunctionalProperty">owl:FunctionalProperty</a>
    /// </summary>
    let FunctionalProperty = owlVocabulary.prefixId.prefix "FunctionalProperty"

    /// <summary>
    ///   <para>rdfs:comment : The class of inverse-functional properties.^^xsd:string</para>
    ///   <para>rdfs:label : InverseFunctionalProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#InverseFunctionalProperty">owl:InverseFunctionalProperty</a>
    /// </summary>
    let InverseFunctionalProperty =
        owlVocabulary.prefixId.prefix "InverseFunctionalProperty"

    /// <summary>
    ///   <para>rdfs:comment : The class of irreflexive properties.^^xsd:string</para>
    ///   <para>rdfs:label : IrreflexiveProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#IrreflexiveProperty">owl:IrreflexiveProperty</a>
    /// </summary>
    let IrreflexiveProperty = owlVocabulary.prefixId.prefix "IrreflexiveProperty"

    /// <summary>
    ///   <para>rdfs:comment : The class of named individuals.^^xsd:string</para>
    ///   <para>rdfs:label : NamedIndividual^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#NamedIndividual">owl:NamedIndividual</a>
    /// </summary>
    let NamedIndividual = owlVocabulary.prefixId.prefix "NamedIndividual"

    /// <summary>
    ///   <para>rdfs:comment : The class of negative property assertions.^^xsd:string</para>
    ///   <para>rdfs:label : NegativePropertyAssertion^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#NegativePropertyAssertion">owl:NegativePropertyAssertion</a>
    /// </summary>
    let NegativePropertyAssertion =
        owlVocabulary.prefixId.prefix "NegativePropertyAssertion"

    /// <summary>
    ///   <para>rdfs:comment : This is the empty class.^^xsd:string</para>
    ///   <para>rdfs:label : Nothing^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Nothing">owl:Nothing</a>
    /// </summary>
    let Nothing = owlVocabulary.prefixId.prefix "Nothing"

    /// <summary>
    ///   <para>rdfs:comment : The class of object properties.^^xsd:string</para>
    ///   <para>rdfs:label : ObjectProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#ObjectProperty">owl:ObjectProperty</a>
    /// </summary>
    let ObjectProperty = owlVocabulary.prefixId.prefix "ObjectProperty"

    /// <summary>
    ///   <para>rdfs:comment : The class of ontologies.^^xsd:string</para>
    ///   <para>rdfs:label : Ontology^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Ontology">owl:Ontology</a>
    /// </summary>
    let Ontology = owlVocabulary.prefixId.prefix "Ontology"

    /// <summary>
    ///   <para>rdfs:comment : The class of ontology properties.^^xsd:string</para>
    ///   <para>rdfs:label : OntologyProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#OntologyProperty">owl:OntologyProperty</a>
    /// </summary>
    let OntologyProperty = owlVocabulary.prefixId.prefix "OntologyProperty"

    /// <summary>
    ///   <para>rdfs:comment : The class of reflexive properties.^^xsd:string</para>
    ///   <para>rdfs:label : ReflexiveProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#ReflexiveProperty">owl:ReflexiveProperty</a>
    /// </summary>
    let ReflexiveProperty = owlVocabulary.prefixId.prefix "ReflexiveProperty"

    /// <summary>
    ///   <para>rdfs:comment : The class of property restrictions.^^xsd:string</para>
    ///   <para>rdfs:label : Restriction^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Restriction">owl:Restriction</a>
    /// </summary>
    let Restriction = owlVocabulary.prefixId.prefix "Restriction"

    /// <summary>
    ///   <para>rdfs:comment : The class of symmetric properties.^^xsd:string</para>
    ///   <para>rdfs:label : SymmetricProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#SymmetricProperty">owl:SymmetricProperty</a>
    /// </summary>
    let SymmetricProperty = owlVocabulary.prefixId.prefix "SymmetricProperty"

    /// <summary>
    ///   <para>rdfs:comment : The class of OWL individuals.^^xsd:string</para>
    ///   <para>rdfs:label : Thing^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Thing">owl:Thing</a>
    /// </summary>
    let Thing = owlVocabulary.prefixId.prefix "Thing"

    /// <summary>
    ///   <para>rdfs:comment : The class of transitive properties.^^xsd:string</para>
    ///   <para>rdfs:label : TransitiveProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#TransitiveProperty">owl:TransitiveProperty</a>
    /// </summary>
    let TransitiveProperty = owlVocabulary.prefixId.prefix "TransitiveProperty"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the class that a universal property restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : allValuesFrom^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#allValuesFrom">owl:allValuesFrom</a>
    /// </summary>
    let allValuesFrom = owlVocabulary.prefixId.prefix "allValuesFrom"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the predicate of an annotated axiom or annotated annotation.^^xsd:string</para>
    ///   <para>rdfs:label : annotatedProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#annotatedProperty">owl:annotatedProperty</a>
    /// </summary>
    let annotatedProperty = owlVocabulary.prefixId.prefix "annotatedProperty"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the subject of an annotated axiom or annotated annotation.^^xsd:string</para>
    ///   <para>rdfs:label : annotatedSource^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#annotatedSource">owl:annotatedSource</a>
    /// </summary>
    let annotatedSource = owlVocabulary.prefixId.prefix "annotatedSource"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the object of an annotated axiom or annotated annotation.^^xsd:string</para>
    ///   <para>rdfs:label : annotatedTarget^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#annotatedTarget">owl:annotatedTarget</a>
    /// </summary>
    let annotatedTarget = owlVocabulary.prefixId.prefix "annotatedTarget"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the predicate of a negative property assertion.^^xsd:string</para>
    ///   <para>rdfs:label : assertionProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#assertionProperty">owl:assertionProperty</a>
    /// </summary>
    let assertionProperty = owlVocabulary.prefixId.prefix "assertionProperty"

    /// <summary>
    ///   <para>rdfs:comment : The annotation property that indicates that a given ontology is backward compatible with another ontology.^^xsd:string</para>
    ///   <para>rdfs:label : backwardCompatibleWith^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#backwardCompatibleWith">owl:backwardCompatibleWith</a>
    /// </summary>
    let backwardCompatibleWith = owlVocabulary.prefixId.prefix "backwardCompatibleWith"

    /// <summary>
    ///   <para>rdfs:comment : The data property that does not relate any individual to any data value.^^xsd:string</para>
    ///   <para>rdfs:label : bottomDataProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#bottomDataProperty">owl:bottomDataProperty</a>
    /// </summary>
    let bottomDataProperty = owlVocabulary.prefixId.prefix "bottomDataProperty"

    /// <summary>
    ///   <para>rdfs:comment : The object property that does not relate any two individuals.^^xsd:string</para>
    ///   <para>rdfs:label : bottomObjectProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#bottomObjectProperty">owl:bottomObjectProperty</a>
    /// </summary>
    let bottomObjectProperty = owlVocabulary.prefixId.prefix "bottomObjectProperty"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the cardinality of an exact cardinality restriction.^^xsd:string</para>
    ///   <para>rdfs:label : cardinality^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#cardinality">owl:cardinality</a>
    /// </summary>
    let cardinality = owlVocabulary.prefixId.prefix "cardinality"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines that a given class is the complement of another class.^^xsd:string</para>
    ///   <para>rdfs:label : complementOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#complementOf">owl:complementOf</a>
    /// </summary>
    let complementOf = owlVocabulary.prefixId.prefix "complementOf"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines that a given data range is the complement of another data range with respect to the data domain.^^xsd:string</para>
    ///   <para>rdfs:label : datatypeComplementOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#datatypeComplementOf">owl:datatypeComplementOf</a>
    /// </summary>
    let datatypeComplementOf = owlVocabulary.prefixId.prefix "datatypeComplementOf"

    /// <summary>
    ///   <para>rdfs:comment : The annotation property that indicates that a given entity has been deprecated.^^xsd:string</para>
    ///   <para>rdfs:label : deprecated^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#deprecated">owl:deprecated</a>
    /// </summary>
    let deprecated = owlVocabulary.prefixId.prefix "deprecated"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines that two given individuals are different.^^xsd:string</para>
    ///   <para>rdfs:label : differentFrom^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#differentFrom">owl:differentFrom</a>
    /// </summary>
    let differentFrom = owlVocabulary.prefixId.prefix "differentFrom"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines that a given class is equivalent to the disjoint union of a collection of other classes.^^xsd:string</para>
    ///   <para>rdfs:label : disjointUnionOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#disjointUnionOf">owl:disjointUnionOf</a>
    /// </summary>
    let disjointUnionOf = owlVocabulary.prefixId.prefix "disjointUnionOf"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines that two given classes are disjoint.^^xsd:string</para>
    ///   <para>rdfs:label : disjointWith^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#disjointWith">owl:disjointWith</a>
    /// </summary>
    let disjointWith = owlVocabulary.prefixId.prefix "disjointWith"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the collection of pairwise different individuals in a owl:AllDifferent axiom.^^xsd:string</para>
    ///   <para>rdfs:label : distinctMembers^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#distinctMembers">owl:distinctMembers</a>
    /// </summary>
    let distinctMembers = owlVocabulary.prefixId.prefix "distinctMembers"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines that two given classes are equivalent, and that is used to specify datatype definitions.^^xsd:string</para>
    ///   <para>rdfs:label : equivalentClass^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#equivalentClass">owl:equivalentClass</a>
    /// </summary>
    let equivalentClass = owlVocabulary.prefixId.prefix "equivalentClass"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines that two given properties are equivalent.^^xsd:string</para>
    ///   <para>rdfs:label : equivalentProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#equivalentProperty">owl:equivalentProperty</a>
    /// </summary>
    let equivalentProperty = owlVocabulary.prefixId.prefix "equivalentProperty"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the collection of properties that jointly build a key.^^xsd:string</para>
    ///   <para>rdfs:label : hasKey^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#hasKey">owl:hasKey</a>
    /// </summary>
    let hasKey = owlVocabulary.prefixId.prefix "hasKey"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the property that a self restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : hasSelf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#hasSelf">owl:hasSelf</a>
    /// </summary>
    let hasSelf = owlVocabulary.prefixId.prefix "hasSelf"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the individual that a has-value restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : hasValue^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#hasValue">owl:hasValue</a>
    /// </summary>
    let hasValue = owlVocabulary.prefixId.prefix "hasValue"

    let imports = owlVocabulary.prefixId.prefix "imports"

    /// <summary>
    ///   <para>rdfs:comment : The annotation property that indicates that a given ontology is incompatible with another ontology.^^xsd:string</para>
    ///   <para>rdfs:label : incompatibleWith^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#incompatibleWith">owl:incompatibleWith</a>
    /// </summary>
    let incompatibleWith = owlVocabulary.prefixId.prefix "incompatibleWith"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the collection of classes or data ranges that build an intersection.^^xsd:string</para>
    ///   <para>rdfs:label : intersectionOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#intersectionOf">owl:intersectionOf</a>
    /// </summary>
    let intersectionOf = owlVocabulary.prefixId.prefix "intersectionOf"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines that two given properties are inverse.^^xsd:string</para>
    ///   <para>rdfs:label : inverseOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#inverseOf">owl:inverseOf</a>
    /// </summary>
    let inverseOf = owlVocabulary.prefixId.prefix "inverseOf"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the cardinality of a maximum cardinality restriction.^^xsd:string</para>
    ///   <para>rdfs:label : maxCardinality^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#maxCardinality">owl:maxCardinality</a>
    /// </summary>
    let maxCardinality = owlVocabulary.prefixId.prefix "maxCardinality"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the cardinality of a maximum qualified cardinality restriction.^^xsd:string</para>
    ///   <para>rdfs:label : maxQualifiedCardinality^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#maxQualifiedCardinality">owl:maxQualifiedCardinality</a>
    /// </summary>
    let maxQualifiedCardinality =
        owlVocabulary.prefixId.prefix "maxQualifiedCardinality"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the collection of members in either a owl:AllDifferent, owl:AllDisjointClasses or owl:AllDisjointProperties axiom.^^xsd:string</para>
    ///   <para>rdfs:label : members^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#members">owl:members</a>
    /// </summary>
    let members = owlVocabulary.prefixId.prefix "members"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the cardinality of a minimum cardinality restriction.^^xsd:string</para>
    ///   <para>rdfs:label : minCardinality^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#minCardinality">owl:minCardinality</a>
    /// </summary>
    let minCardinality = owlVocabulary.prefixId.prefix "minCardinality"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the cardinality of a minimum qualified cardinality restriction.^^xsd:string</para>
    ///   <para>rdfs:label : minQualifiedCardinality^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#minQualifiedCardinality">owl:minQualifiedCardinality</a>
    /// </summary>
    let minQualifiedCardinality =
        owlVocabulary.prefixId.prefix "minQualifiedCardinality"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the class that a qualified object cardinality restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : onClass^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#onClass">owl:onClass</a>
    /// </summary>
    let onClass = owlVocabulary.prefixId.prefix "onClass"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the data range that a qualified data cardinality restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : onDataRange^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#onDataRange">owl:onDataRange</a>
    /// </summary>
    let onDataRange = owlVocabulary.prefixId.prefix "onDataRange"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the datatype that a datatype restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : onDatatype^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#onDatatype">owl:onDatatype</a>
    /// </summary>
    let onDatatype = owlVocabulary.prefixId.prefix "onDatatype"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the n-tuple of properties that a property restriction on an n-ary data range refers to.^^xsd:string</para>
    ///   <para>rdfs:label : onProperties^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#onProperties">owl:onProperties</a>
    /// </summary>
    let onProperties = owlVocabulary.prefixId.prefix "onProperties"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the property that a property restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : onProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#onProperty">owl:onProperty</a>
    /// </summary>
    let onProperty = owlVocabulary.prefixId.prefix "onProperty"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the collection of individuals or data values that build an enumeration.^^xsd:string</para>
    ///   <para>rdfs:label : oneOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#oneOf">owl:oneOf</a>
    /// </summary>
    let oneOf = owlVocabulary.prefixId.prefix "oneOf"

    /// <summary>
    ///   <para>rdfs:comment : The annotation property that indicates the predecessor ontology of a given ontology.^^xsd:string</para>
    ///   <para>rdfs:label : priorVersion^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#priorVersion">owl:priorVersion</a>
    /// </summary>
    let priorVersion = owlVocabulary.prefixId.prefix "priorVersion"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the n-tuple of properties that build a sub property chain of a given property.^^xsd:string</para>
    ///   <para>rdfs:label : propertyChainAxiom^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#propertyChainAxiom">owl:propertyChainAxiom</a>
    /// </summary>
    let propertyChainAxiom = owlVocabulary.prefixId.prefix "propertyChainAxiom"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines that two given properties are disjoint.^^xsd:string</para>
    ///   <para>rdfs:label : propertyDisjointWith^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#propertyDisjointWith">owl:propertyDisjointWith</a>
    /// </summary>
    let propertyDisjointWith = owlVocabulary.prefixId.prefix "propertyDisjointWith"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the cardinality of an exact qualified cardinality restriction.^^xsd:string</para>
    ///   <para>rdfs:label : qualifiedCardinality^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#qualifiedCardinality">owl:qualifiedCardinality</a>
    /// </summary>
    let qualifiedCardinality = owlVocabulary.prefixId.prefix "qualifiedCardinality"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines that two given individuals are equal.^^xsd:string</para>
    ///   <para>rdfs:label : sameAs^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#sameAs">owl:sameAs</a>
    /// </summary>
    let sameAs = owlVocabulary.prefixId.prefix "sameAs"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the class that an existential property restriction refers to.^^xsd:string</para>
    ///   <para>rdfs:label : someValuesFrom^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#someValuesFrom">owl:someValuesFrom</a>
    /// </summary>
    let someValuesFrom = owlVocabulary.prefixId.prefix "someValuesFrom"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the subject of a negative property assertion.^^xsd:string</para>
    ///   <para>rdfs:label : sourceIndividual^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#sourceIndividual">owl:sourceIndividual</a>
    /// </summary>
    let sourceIndividual = owlVocabulary.prefixId.prefix "sourceIndividual"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the object of a negative object property assertion.^^xsd:string</para>
    ///   <para>rdfs:label : targetIndividual^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#targetIndividual">owl:targetIndividual</a>
    /// </summary>
    let targetIndividual = owlVocabulary.prefixId.prefix "targetIndividual"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the value of a negative data property assertion.^^xsd:string</para>
    ///   <para>rdfs:label : targetValue^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#targetValue">owl:targetValue</a>
    /// </summary>
    let targetValue = owlVocabulary.prefixId.prefix "targetValue"

    /// <summary>
    ///   <para>rdfs:comment : The data property that relates every individual to every data value.^^xsd:string</para>
    ///   <para>rdfs:label : topDataProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#topDataProperty">owl:topDataProperty</a>
    /// </summary>
    let topDataProperty = owlVocabulary.prefixId.prefix "topDataProperty"

    /// <summary>
    ///   <para>rdfs:comment : The object property that relates every two individuals.^^xsd:string</para>
    ///   <para>rdfs:label : topObjectProperty^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#topObjectProperty">owl:topObjectProperty</a>
    /// </summary>
    let topObjectProperty = owlVocabulary.prefixId.prefix "topObjectProperty"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the collection of classes or data ranges that build a union.^^xsd:string</para>
    ///   <para>rdfs:label : unionOf^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#unionOf">owl:unionOf</a>
    /// </summary>
    let unionOf = owlVocabulary.prefixId.prefix "unionOf"

    let versionIRI = owlVocabulary.prefixId.prefix "versionIRI"

    /// <summary>
    ///   <para>rdfs:comment : The annotation property that provides version information for an ontology or another OWL construct.^^xsd:string</para>
    ///   <para>rdfs:label : versionInfo^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#versionInfo">owl:versionInfo</a>
    /// </summary>
    let versionInfo = owlVocabulary.prefixId.prefix "versionInfo"

    /// <summary>
    ///   <para>rdfs:comment : The property that determines the collection of facet-value pairs that define a datatype restriction.^^xsd:string</para>
    ///   <para>rdfs:label : withRestrictions^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#withRestrictions">owl:withRestrictions</a>
    /// </summary>
    let withRestrictions = owlVocabulary.prefixId.prefix "withRestrictions"
