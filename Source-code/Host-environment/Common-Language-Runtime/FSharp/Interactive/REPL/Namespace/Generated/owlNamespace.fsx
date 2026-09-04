#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module owl =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/2002/07/owl#" "owl"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : AllDifferent^^xsd:string</para>
    ///   <para>rdfs:comment : The class of collections of pairwise different individuals.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#AllDifferent">owl:AllDifferent</a>
    /// </summary>
    let AllDifferent = _prefixId.prefix "AllDifferent"
    /// <summary>
    ///   <para>rdfs:label : AllDisjointClasses^^xsd:string</para>
    ///   <para>rdfs:comment : The class of collections of pairwise disjoint classes.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#AllDisjointClasses">owl:AllDisjointClasses</a>
    /// </summary>
    let AllDisjointClasses = _prefixId.prefix "AllDisjointClasses"
    /// <summary>
    ///   <para>rdfs:label : AllDisjointProperties^^xsd:string</para>
    ///   <para>rdfs:comment : The class of collections of pairwise disjoint properties.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#AllDisjointProperties">owl:AllDisjointProperties</a>
    /// </summary>
    let AllDisjointProperties = _prefixId.prefix "AllDisjointProperties"
    /// <summary>
    ///   <para>rdfs:label : Annotation^^xsd:string</para>
    ///   <para>rdfs:comment : The class of annotated annotations for which the RDF serialization consists of an annotated subject, predicate and object.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Annotation">owl:Annotation</a>
    /// </summary>
    let Annotation = _prefixId.prefix "Annotation"
    /// <summary>
    ///   <para>rdfs:label : AnnotationProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The class of annotation properties.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#AnnotationProperty">owl:AnnotationProperty</a>
    /// </summary>
    let AnnotationProperty = _prefixId.prefix "AnnotationProperty"
    /// <summary>
    ///   <para>rdfs:label : AsymmetricProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The class of asymmetric properties.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#AsymmetricProperty">owl:AsymmetricProperty</a>
    /// </summary>
    let AsymmetricProperty = _prefixId.prefix "AsymmetricProperty"
    /// <summary>
    ///   <para>rdfs:label : Axiom^^xsd:string</para>
    ///   <para>rdfs:comment : The class of annotated axioms for which the RDF serialization consists of an annotated subject, predicate and object.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Axiom">owl:Axiom</a>
    /// </summary>
    let Axiom = _prefixId.prefix "Axiom"
    /// <summary>
    ///   <para>rdfs:label : Class^^xsd:string</para>
    ///   <para>rdfs:comment : The class of OWL classes.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Class">owl:Class</a>
    /// </summary>
    let Class = _prefixId.prefix "Class"
    /// <summary>
    ///   <para>rdfs:label : DataRange^^xsd:string</para>
    ///   <para>rdfs:comment : The class of OWL data ranges, which are special kinds of datatypes. Note: The use of the IRI owl:DataRange has been deprecated as of OWL 2. The IRI rdfs:Datatype SHOULD be used instead.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#DataRange">owl:DataRange</a>
    /// </summary>
    let DataRange = _prefixId.prefix "DataRange"
    /// <summary>
    ///   <para>rdfs:label : DatatypeProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The class of data properties.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#DatatypeProperty">owl:DatatypeProperty</a>
    /// </summary>
    let DatatypeProperty = _prefixId.prefix "DatatypeProperty"
    /// <summary>
    ///   <para>rdfs:label : DeprecatedClass^^xsd:string</para>
    ///   <para>rdfs:comment : The class of deprecated classes.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#DeprecatedClass">owl:DeprecatedClass</a>
    /// </summary>
    let DeprecatedClass = _prefixId.prefix "DeprecatedClass"
    /// <summary>
    ///   <para>rdfs:label : DeprecatedProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The class of deprecated properties.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#DeprecatedProperty">owl:DeprecatedProperty</a>
    /// </summary>
    let DeprecatedProperty = _prefixId.prefix "DeprecatedProperty"
    /// <summary>
    ///   <para>rdfs:label : FunctionalProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The class of functional properties.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#FunctionalProperty">owl:FunctionalProperty</a>
    /// </summary>
    let FunctionalProperty = _prefixId.prefix "FunctionalProperty"
    /// <summary>
    ///   <para>rdfs:label : InverseFunctionalProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The class of inverse-functional properties.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#InverseFunctionalProperty">owl:InverseFunctionalProperty</a>
    /// </summary>
    let InverseFunctionalProperty = _prefixId.prefix "InverseFunctionalProperty"
    /// <summary>
    ///   <para>rdfs:label : IrreflexiveProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The class of irreflexive properties.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#IrreflexiveProperty">owl:IrreflexiveProperty</a>
    /// </summary>
    let IrreflexiveProperty = _prefixId.prefix "IrreflexiveProperty"
    /// <summary>
    ///   <para>rdfs:label : NamedIndividual^^xsd:string</para>
    ///   <para>rdfs:comment : The class of named individuals.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#NamedIndividual">owl:NamedIndividual</a>
    /// </summary>
    let NamedIndividual = _prefixId.prefix "NamedIndividual"
    /// <summary>
    ///   <para>rdfs:label : NegativePropertyAssertion^^xsd:string</para>
    ///   <para>rdfs:comment : The class of negative property assertions.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#NegativePropertyAssertion">owl:NegativePropertyAssertion</a>
    /// </summary>
    let NegativePropertyAssertion = _prefixId.prefix "NegativePropertyAssertion"
    /// <summary>
    ///   <para>rdfs:label : Nothing^^xsd:string</para>
    ///   <para>rdfs:comment : This is the empty class.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Nothing">owl:Nothing</a>
    /// </summary>
    let Nothing = _prefixId.prefix "Nothing"
    /// <summary>
    ///   <para>rdfs:label : ObjectProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The class of object properties.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#ObjectProperty">owl:ObjectProperty</a>
    /// </summary>
    let ObjectProperty = _prefixId.prefix "ObjectProperty"
    /// <summary>
    ///   <para>rdfs:label : Ontology^^xsd:string</para>
    ///   <para>rdfs:comment : The class of ontologies.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Ontology">owl:Ontology</a>
    /// </summary>
    let Ontology = _prefixId.prefix "Ontology"
    /// <summary>
    ///   <para>rdfs:label : OntologyProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The class of ontology properties.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#OntologyProperty">owl:OntologyProperty</a>
    /// </summary>
    let OntologyProperty = _prefixId.prefix "OntologyProperty"
    /// <summary>
    ///   <para>rdfs:label : ReflexiveProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The class of reflexive properties.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#ReflexiveProperty">owl:ReflexiveProperty</a>
    /// </summary>
    let ReflexiveProperty = _prefixId.prefix "ReflexiveProperty"
    /// <summary>
    ///   <para>rdfs:label : Restriction^^xsd:string</para>
    ///   <para>rdfs:comment : The class of property restrictions.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Restriction">owl:Restriction</a>
    /// </summary>
    let Restriction = _prefixId.prefix "Restriction"
    /// <summary>
    ///   <para>rdfs:label : SymmetricProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The class of symmetric properties.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#SymmetricProperty">owl:SymmetricProperty</a>
    /// </summary>
    let SymmetricProperty = _prefixId.prefix "SymmetricProperty"
    /// <summary>
    ///   <para>rdfs:label : Thing^^xsd:string</para>
    ///   <para>rdfs:comment : The class of OWL individuals.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#Thing">owl:Thing</a>
    /// </summary>
    let Thing = _prefixId.prefix "Thing"
    /// <summary>
    ///   <para>rdfs:label : TransitiveProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The class of transitive properties.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#TransitiveProperty">owl:TransitiveProperty</a>
    /// </summary>
    let TransitiveProperty = _prefixId.prefix "TransitiveProperty"
    /// <summary>
    ///   <para>rdfs:label : allValuesFrom^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the class that a universal property restriction refers to.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#allValuesFrom">owl:allValuesFrom</a>
    /// </summary>
    let allValuesFrom = _prefixId.prefix "allValuesFrom"
    /// <summary>
    ///   <para>rdfs:label : annotatedProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the predicate of an annotated axiom or annotated annotation.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#annotatedProperty">owl:annotatedProperty</a>
    /// </summary>
    let annotatedProperty = _prefixId.prefix "annotatedProperty"
    /// <summary>
    ///   <para>rdfs:label : annotatedSource^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the subject of an annotated axiom or annotated annotation.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#annotatedSource">owl:annotatedSource</a>
    /// </summary>
    let annotatedSource = _prefixId.prefix "annotatedSource"
    /// <summary>
    ///   <para>rdfs:label : annotatedTarget^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the object of an annotated axiom or annotated annotation.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#annotatedTarget">owl:annotatedTarget</a>
    /// </summary>
    let annotatedTarget = _prefixId.prefix "annotatedTarget"
    /// <summary>
    ///   <para>rdfs:label : assertionProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the predicate of a negative property assertion.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#assertionProperty">owl:assertionProperty</a>
    /// </summary>
    let assertionProperty = _prefixId.prefix "assertionProperty"
    /// <summary>
    ///   <para>rdfs:label : backwardCompatibleWith^^xsd:string</para>
    ///   <para>rdfs:comment : The annotation property that indicates that a given ontology is backward compatible with another ontology.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#backwardCompatibleWith">owl:backwardCompatibleWith</a>
    /// </summary>
    let backwardCompatibleWith = _prefixId.prefix "backwardCompatibleWith"
    /// <summary>
    ///   <para>rdfs:label : bottomDataProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The data property that does not relate any individual to any data value.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#bottomDataProperty">owl:bottomDataProperty</a>
    /// </summary>
    let bottomDataProperty = _prefixId.prefix "bottomDataProperty"
    /// <summary>
    ///   <para>rdfs:label : bottomObjectProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The object property that does not relate any two individuals.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#bottomObjectProperty">owl:bottomObjectProperty</a>
    /// </summary>
    let bottomObjectProperty = _prefixId.prefix "bottomObjectProperty"
    /// <summary>
    ///   <para>rdfs:label : cardinality^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the cardinality of an exact cardinality restriction.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#cardinality">owl:cardinality</a>
    /// </summary>
    let cardinality = _prefixId.prefix "cardinality"
    /// <summary>
    ///   <para>rdfs:label : complementOf^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines that a given class is the complement of another class.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#complementOf">owl:complementOf</a>
    /// </summary>
    let complementOf = _prefixId.prefix "complementOf"
    /// <summary>
    ///   <para>rdfs:label : datatypeComplementOf^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines that a given data range is the complement of another data range with respect to the data domain.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#datatypeComplementOf">owl:datatypeComplementOf</a>
    /// </summary>
    let datatypeComplementOf = _prefixId.prefix "datatypeComplementOf"
    /// <summary>
    ///   <para>rdfs:label : deprecated^^xsd:string</para>
    ///   <para>rdfs:comment : The annotation property that indicates that a given entity has been deprecated.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#deprecated">owl:deprecated</a>
    /// </summary>
    let deprecated = _prefixId.prefix "deprecated"
    /// <summary>
    ///   <para>rdfs:label : differentFrom^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines that two given individuals are different.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#differentFrom">owl:differentFrom</a>
    /// </summary>
    let differentFrom = _prefixId.prefix "differentFrom"
    /// <summary>
    ///   <para>rdfs:label : disjointUnionOf^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines that a given class is equivalent to the disjoint union of a collection of other classes.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#disjointUnionOf">owl:disjointUnionOf</a>
    /// </summary>
    let disjointUnionOf = _prefixId.prefix "disjointUnionOf"
    /// <summary>
    ///   <para>rdfs:label : disjointWith^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines that two given classes are disjoint.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#disjointWith">owl:disjointWith</a>
    /// </summary>
    let disjointWith = _prefixId.prefix "disjointWith"
    /// <summary>
    ///   <para>rdfs:label : distinctMembers^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the collection of pairwise different individuals in a owl:AllDifferent axiom.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#distinctMembers">owl:distinctMembers</a>
    /// </summary>
    let distinctMembers = _prefixId.prefix "distinctMembers"
    /// <summary>
    ///   <para>rdfs:label : equivalentClass^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines that two given classes are equivalent, and that is used to specify datatype definitions.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#equivalentClass">owl:equivalentClass</a>
    /// </summary>
    let equivalentClass = _prefixId.prefix "equivalentClass"
    /// <summary>
    ///   <para>rdfs:label : equivalentProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines that two given properties are equivalent.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#equivalentProperty">owl:equivalentProperty</a>
    /// </summary>
    let equivalentProperty = _prefixId.prefix "equivalentProperty"
    /// <summary>
    ///   <para>rdfs:label : hasKey^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the collection of properties that jointly build a key.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#hasKey">owl:hasKey</a>
    /// </summary>
    let hasKey = _prefixId.prefix "hasKey"
    /// <summary>
    ///   <para>rdfs:label : hasSelf^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the property that a self restriction refers to.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#hasSelf">owl:hasSelf</a>
    /// </summary>
    let hasSelf = _prefixId.prefix "hasSelf"
    /// <summary>
    ///   <para>rdfs:label : hasValue^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the individual that a has-value restriction refers to.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#hasValue">owl:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    let imports = _prefixId.prefix "imports"
    /// <summary>
    ///   <para>rdfs:label : incompatibleWith^^xsd:string</para>
    ///   <para>rdfs:comment : The annotation property that indicates that a given ontology is incompatible with another ontology.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#incompatibleWith">owl:incompatibleWith</a>
    /// </summary>
    let incompatibleWith = _prefixId.prefix "incompatibleWith"
    /// <summary>
    ///   <para>rdfs:label : intersectionOf^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the collection of classes or data ranges that build an intersection.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#intersectionOf">owl:intersectionOf</a>
    /// </summary>
    let intersectionOf = _prefixId.prefix "intersectionOf"
    /// <summary>
    ///   <para>rdfs:label : inverseOf^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines that two given properties are inverse.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#inverseOf">owl:inverseOf</a>
    /// </summary>
    let inverseOf = _prefixId.prefix "inverseOf"
    /// <summary>
    ///   <para>rdfs:label : maxCardinality^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the cardinality of a maximum cardinality restriction.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#maxCardinality">owl:maxCardinality</a>
    /// </summary>
    let maxCardinality = _prefixId.prefix "maxCardinality"
    /// <summary>
    ///   <para>rdfs:label : maxQualifiedCardinality^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the cardinality of a maximum qualified cardinality restriction.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#maxQualifiedCardinality">owl:maxQualifiedCardinality</a>
    /// </summary>
    let maxQualifiedCardinality = _prefixId.prefix "maxQualifiedCardinality"
    /// <summary>
    ///   <para>rdfs:label : members^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the collection of members in either a owl:AllDifferent, owl:AllDisjointClasses or owl:AllDisjointProperties axiom.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#members">owl:members</a>
    /// </summary>
    let members = _prefixId.prefix "members"
    /// <summary>
    ///   <para>rdfs:label : minCardinality^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the cardinality of a minimum cardinality restriction.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#minCardinality">owl:minCardinality</a>
    /// </summary>
    let minCardinality = _prefixId.prefix "minCardinality"
    /// <summary>
    ///   <para>rdfs:label : minQualifiedCardinality^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the cardinality of a minimum qualified cardinality restriction.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#minQualifiedCardinality">owl:minQualifiedCardinality</a>
    /// </summary>
    let minQualifiedCardinality = _prefixId.prefix "minQualifiedCardinality"
    /// <summary>
    ///   <para>rdfs:label : onClass^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the class that a qualified object cardinality restriction refers to.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#onClass">owl:onClass</a>
    /// </summary>
    let onClass = _prefixId.prefix "onClass"
    /// <summary>
    ///   <para>rdfs:label : onDataRange^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the data range that a qualified data cardinality restriction refers to.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#onDataRange">owl:onDataRange</a>
    /// </summary>
    let onDataRange = _prefixId.prefix "onDataRange"
    /// <summary>
    ///   <para>rdfs:label : onDatatype^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the datatype that a datatype restriction refers to.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#onDatatype">owl:onDatatype</a>
    /// </summary>
    let onDatatype = _prefixId.prefix "onDatatype"
    /// <summary>
    ///   <para>rdfs:label : onProperties^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the n-tuple of properties that a property restriction on an n-ary data range refers to.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#onProperties">owl:onProperties</a>
    /// </summary>
    let onProperties = _prefixId.prefix "onProperties"
    /// <summary>
    ///   <para>rdfs:label : onProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the property that a property restriction refers to.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#onProperty">owl:onProperty</a>
    /// </summary>
    let onProperty = _prefixId.prefix "onProperty"
    /// <summary>
    ///   <para>rdfs:label : oneOf^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the collection of individuals or data values that build an enumeration.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#oneOf">owl:oneOf</a>
    /// </summary>
    let oneOf = _prefixId.prefix "oneOf"
    /// <summary>
    ///   <para>rdfs:label : priorVersion^^xsd:string</para>
    ///   <para>rdfs:comment : The annotation property that indicates the predecessor ontology of a given ontology.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#priorVersion">owl:priorVersion</a>
    /// </summary>
    let priorVersion = _prefixId.prefix "priorVersion"
    /// <summary>
    ///   <para>rdfs:label : propertyChainAxiom^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the n-tuple of properties that build a sub property chain of a given property.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#propertyChainAxiom">owl:propertyChainAxiom</a>
    /// </summary>
    let propertyChainAxiom = _prefixId.prefix "propertyChainAxiom"
    /// <summary>
    ///   <para>rdfs:label : propertyDisjointWith^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines that two given properties are disjoint.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#propertyDisjointWith">owl:propertyDisjointWith</a>
    /// </summary>
    let propertyDisjointWith = _prefixId.prefix "propertyDisjointWith"
    /// <summary>
    ///   <para>rdfs:label : qualifiedCardinality^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the cardinality of an exact qualified cardinality restriction.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#qualifiedCardinality">owl:qualifiedCardinality</a>
    /// </summary>
    let qualifiedCardinality = _prefixId.prefix "qualifiedCardinality"
    /// <summary>
    ///   <para>rdfs:label : sameAs^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines that two given individuals are equal.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#sameAs">owl:sameAs</a>
    /// </summary>
    let sameAs = _prefixId.prefix "sameAs"
    /// <summary>
    ///   <para>rdfs:label : someValuesFrom^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the class that an existential property restriction refers to.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#someValuesFrom">owl:someValuesFrom</a>
    /// </summary>
    let someValuesFrom = _prefixId.prefix "someValuesFrom"
    /// <summary>
    ///   <para>rdfs:label : sourceIndividual^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the subject of a negative property assertion.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#sourceIndividual">owl:sourceIndividual</a>
    /// </summary>
    let sourceIndividual = _prefixId.prefix "sourceIndividual"
    /// <summary>
    ///   <para>rdfs:label : targetIndividual^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the object of a negative object property assertion.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#targetIndividual">owl:targetIndividual</a>
    /// </summary>
    let targetIndividual = _prefixId.prefix "targetIndividual"
    /// <summary>
    ///   <para>rdfs:label : targetValue^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the value of a negative data property assertion.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#targetValue">owl:targetValue</a>
    /// </summary>
    let targetValue = _prefixId.prefix "targetValue"
    /// <summary>
    ///   <para>rdfs:label : topDataProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The data property that relates every individual to every data value.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#topDataProperty">owl:topDataProperty</a>
    /// </summary>
    let topDataProperty = _prefixId.prefix "topDataProperty"
    /// <summary>
    ///   <para>rdfs:label : topObjectProperty^^xsd:string</para>
    ///   <para>rdfs:comment : The object property that relates every two individuals.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#topObjectProperty">owl:topObjectProperty</a>
    /// </summary>
    let topObjectProperty = _prefixId.prefix "topObjectProperty"
    /// <summary>
    ///   <para>rdfs:label : unionOf^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the collection of classes or data ranges that build a union.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#unionOf">owl:unionOf</a>
    /// </summary>
    let unionOf = _prefixId.prefix "unionOf"
    let versionIRI = _prefixId.prefix "versionIRI"
    /// <summary>
    ///   <para>rdfs:label : versionInfo^^xsd:string</para>
    ///   <para>rdfs:comment : The annotation property that provides version information for an ontology or another OWL construct.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#versionInfo">owl:versionInfo</a>
    /// </summary>
    let versionInfo = _prefixId.prefix "versionInfo"
    /// <summary>
    ///   <para>rdfs:label : withRestrictions^^xsd:string</para>
    ///   <para>rdfs:comment : The property that determines the collection of facet-value pairs that define a datatype restriction.^^xsd:string</para>
    ///   <a href="http://www.w3.org/2002/07/owl#withRestrictions">owl:withRestrictions</a>
    /// </summary>
    let withRestrictions = _prefixId.prefix "withRestrictions"
