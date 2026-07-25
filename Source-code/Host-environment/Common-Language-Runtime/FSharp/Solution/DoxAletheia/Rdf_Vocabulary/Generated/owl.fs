namespace http.www.w3.org._2002._07.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module owl =
    let _namespace_iri = Namespace_Iri owl |> NamespaceIRI
    /// <summary>
    ///   <para>owl:Ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of ontologies.</para>
    /// labels<para>Ontology</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#Ontology">http://www.w3.org/2002/07/owl#Ontology</seealso>
    let Ontology = Prefixed_Name(owl, "Ontology") |> PrefixedName
    /// <summary>
    ///   <para>owl:AllDifferent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of collections of pairwise different individuals.</para>
    /// labels<para>AllDifferent</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#AllDifferent">http://www.w3.org/2002/07/owl#AllDifferent</seealso>
    let AllDifferent = Prefixed_Name(owl, "AllDifferent") |> PrefixedName
    /// <summary>
    ///   <para>owl:Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of annotated annotations for which the RDF serialization consists of an annotated subject, predicate and object.</para>
    /// labels<para>Annotation</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#Annotation">http://www.w3.org/2002/07/owl#Annotation</seealso>
    let Annotation = Prefixed_Name(owl, "Annotation") |> PrefixedName
    /// <summary>
    ///   <para>owl:AsymmetricProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of asymmetric properties.</para>
    /// labels<para>AsymmetricProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#AsymmetricProperty">http://www.w3.org/2002/07/owl#AsymmetricProperty</seealso>
    let AsymmetricProperty = Prefixed_Name(owl, "AsymmetricProperty") |> PrefixedName

    /// <summary>
    ///   <para>owl:maxQualifiedCardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the cardinality of a maximum qualified cardinality restriction.</para>
    /// labels<para>maxQualifiedCardinality</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#maxQualifiedCardinality">http://www.w3.org/2002/07/owl#maxQualifiedCardinality</seealso>
    let maxQualifiedCardinality =
        Prefixed_Name(owl, "maxQualifiedCardinality") |> PrefixedName

    /// <summary>
    ///   <para>owl:minCardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the cardinality of a minimum cardinality restriction.</para>
    /// labels<para>minCardinality</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#minCardinality">http://www.w3.org/2002/07/owl#minCardinality</seealso>
    let minCardinality = Prefixed_Name(owl, "minCardinality") |> PrefixedName
    /// <summary>
    ///   <para>owl:versionIRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:OntologyProperty</para>
    ///   <para>The property that identifies the version IRI of an ontology.</para>
    /// labels<para>versionIRI</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#versionIRI">http://www.w3.org/2002/07/owl#versionIRI</seealso>
    let versionIRI = Prefixed_Name(owl, "versionIRI") |> PrefixedName
    /// <summary>
    ///   <para>owl:versionInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The annotation property that provides version information for an ontology or another OWL construct.</para>
    /// labels<para>versionInfo</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#versionInfo">http://www.w3.org/2002/07/owl#versionInfo</seealso>
    let versionInfo = Prefixed_Name(owl, "versionInfo") |> PrefixedName
    /// <summary>
    ///   <para>owl:AllDisjointClasses</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of collections of pairwise disjoint classes.</para>
    /// labels<para>AllDisjointClasses</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#AllDisjointClasses">http://www.w3.org/2002/07/owl#AllDisjointClasses</seealso>
    let AllDisjointClasses = Prefixed_Name(owl, "AllDisjointClasses") |> PrefixedName
    /// <summary>
    ///   <para>owl:Axiom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of annotated axioms for which the RDF serialization consists of an annotated subject, predicate and object.</para>
    /// labels<para>Axiom</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#Axiom">http://www.w3.org/2002/07/owl#Axiom</seealso>
    let Axiom = Prefixed_Name(owl, "Axiom") |> PrefixedName
    /// <summary>
    ///   <para>owl:Class</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of OWL classes.</para>
    /// labels<para>Class</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#Class">http://www.w3.org/2002/07/owl#Class</seealso>
    let Class = Prefixed_Name(owl, "Class") |> PrefixedName
    /// <summary>
    ///   <para>owl:DataRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of OWL data ranges, which are special kinds of datatypes. Note: The use of the IRI owl:DataRange has been deprecated as of OWL 2. The IRI rdfs:Datatype SHOULD be used instead.</para>
    /// labels<para>DataRange</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#DataRange">http://www.w3.org/2002/07/owl#DataRange</seealso>
    let DataRange = Prefixed_Name(owl, "DataRange") |> PrefixedName
    /// <summary>
    ///   <para>owl:DatatypeProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of data properties.</para>
    /// labels<para>DatatypeProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#DatatypeProperty">http://www.w3.org/2002/07/owl#DatatypeProperty</seealso>
    let DatatypeProperty = Prefixed_Name(owl, "DatatypeProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:DeprecatedClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of deprecated classes.</para>
    /// labels<para>DeprecatedClass</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#DeprecatedClass">http://www.w3.org/2002/07/owl#DeprecatedClass</seealso>
    let DeprecatedClass = Prefixed_Name(owl, "DeprecatedClass") |> PrefixedName
    /// <summary>
    ///   <para>owl:FunctionalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of functional properties.</para>
    /// labels<para>FunctionalProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#FunctionalProperty">http://www.w3.org/2002/07/owl#FunctionalProperty</seealso>
    let FunctionalProperty = Prefixed_Name(owl, "FunctionalProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:sameAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines that two given individuals are equal.</para>
    /// labels<para>sameAs</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#sameAs">http://www.w3.org/2002/07/owl#sameAs</seealso>
    let sameAs = Prefixed_Name(owl, "sameAs") |> PrefixedName
    /// <summary>
    ///   <para>owl:oneOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the collection of individuals or data values that build an enumeration.</para>
    /// labels<para>oneOf</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#oneOf">http://www.w3.org/2002/07/owl#oneOf</seealso>
    let oneOf = Prefixed_Name(owl, "oneOf") |> PrefixedName
    /// <summary>
    ///   <para>owl:propertyChainAxiom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the n-tuple of properties that build a sub property chain of a given property.</para>
    /// labels<para>propertyChainAxiom</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#propertyChainAxiom">http://www.w3.org/2002/07/owl#propertyChainAxiom</seealso>
    let propertyChainAxiom = Prefixed_Name(owl, "propertyChainAxiom") |> PrefixedName

    /// <summary>
    ///   <para>owl:qualifiedCardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the cardinality of an exact qualified cardinality restriction.</para>
    /// labels<para>qualifiedCardinality</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#qualifiedCardinality">http://www.w3.org/2002/07/owl#qualifiedCardinality</seealso>
    let qualifiedCardinality =
        Prefixed_Name(owl, "qualifiedCardinality") |> PrefixedName

    /// <summary>
    ///   <para>owl:sourceIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the subject of a negative property assertion.</para>
    /// labels<para>sourceIndividual</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#sourceIndividual">http://www.w3.org/2002/07/owl#sourceIndividual</seealso>
    let sourceIndividual = Prefixed_Name(owl, "sourceIndividual") |> PrefixedName
    /// <summary>
    ///   <para>owl:targetValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the value of a negative data property assertion.</para>
    /// labels<para>targetValue</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#targetValue">http://www.w3.org/2002/07/owl#targetValue</seealso>
    let targetValue = Prefixed_Name(owl, "targetValue") |> PrefixedName
    /// <summary>
    ///   <para>owl:topObjectProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The object property that relates every two individuals.</para>
    /// labels<para>topObjectProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#topObjectProperty">http://www.w3.org/2002/07/owl#topObjectProperty</seealso>
    let topObjectProperty = Prefixed_Name(owl, "topObjectProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:withRestrictions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the collection of facet-value pairs that define a datatype restriction.</para>
    /// labels<para>withRestrictions</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#withRestrictions">http://www.w3.org/2002/07/owl#withRestrictions</seealso>
    let withRestrictions = Prefixed_Name(owl, "withRestrictions") |> PrefixedName
    /// <summary>
    ///   <para>owl:DeprecatedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of deprecated properties.</para>
    /// labels<para>DeprecatedProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#DeprecatedProperty">http://www.w3.org/2002/07/owl#DeprecatedProperty</seealso>
    let DeprecatedProperty = Prefixed_Name(owl, "DeprecatedProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:IrreflexiveProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of irreflexive properties.</para>
    /// labels<para>IrreflexiveProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#IrreflexiveProperty">http://www.w3.org/2002/07/owl#IrreflexiveProperty</seealso>
    let IrreflexiveProperty = Prefixed_Name(owl, "IrreflexiveProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:NamedIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of named individuals.</para>
    /// labels<para>NamedIndividual</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#NamedIndividual">http://www.w3.org/2002/07/owl#NamedIndividual</seealso>
    let NamedIndividual = Prefixed_Name(owl, "NamedIndividual") |> PrefixedName
    /// <summary>
    ///   <para>owl:Nothing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This is the empty class.</para>
    /// labels<para>Nothing</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#Nothing">http://www.w3.org/2002/07/owl#Nothing</seealso>
    let Nothing = Prefixed_Name(owl, "Nothing") |> PrefixedName

    /// <summary>
    ///   <para>owl:InverseFunctionalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of inverse-functional properties.</para>
    /// labels<para>InverseFunctionalProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#InverseFunctionalProperty">http://www.w3.org/2002/07/owl#InverseFunctionalProperty</seealso>
    let InverseFunctionalProperty =
        Prefixed_Name(owl, "InverseFunctionalProperty") |> PrefixedName

    /// <summary>
    ///   <para>owl:Thing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class of OWL individuals.</para>
    /// labels<para>Thing</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#Thing">http://www.w3.org/2002/07/owl#Thing</seealso>
    let Thing = Prefixed_Name(owl, "Thing") |> PrefixedName
    /// <summary>
    ///   <para>owl:OntologyProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of ontology properties.</para>
    /// labels<para>OntologyProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#OntologyProperty">http://www.w3.org/2002/07/owl#OntologyProperty</seealso>
    let OntologyProperty = Prefixed_Name(owl, "OntologyProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:ReflexiveProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of reflexive properties.</para>
    /// labels<para>ReflexiveProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#ReflexiveProperty">http://www.w3.org/2002/07/owl#ReflexiveProperty</seealso>
    let ReflexiveProperty = Prefixed_Name(owl, "ReflexiveProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:SymmetricProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of symmetric properties.</para>
    /// labels<para>SymmetricProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#SymmetricProperty">http://www.w3.org/2002/07/owl#SymmetricProperty</seealso>
    let SymmetricProperty = Prefixed_Name(owl, "SymmetricProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:allValuesFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the class that a universal property restriction refers to.</para>
    /// labels<para>allValuesFrom</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#allValuesFrom">http://www.w3.org/2002/07/owl#allValuesFrom</seealso>
    let allValuesFrom = Prefixed_Name(owl, "allValuesFrom") |> PrefixedName
    /// <summary>
    ///   <para>owl:annotatedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the predicate of an annotated axiom or annotated annotation.</para>
    /// labels<para>annotatedProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#annotatedProperty">http://www.w3.org/2002/07/owl#annotatedProperty</seealso>
    let annotatedProperty = Prefixed_Name(owl, "annotatedProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:annotatedTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the object of an annotated axiom or annotated annotation.</para>
    /// labels<para>annotatedTarget</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#annotatedTarget">http://www.w3.org/2002/07/owl#annotatedTarget</seealso>
    let annotatedTarget = Prefixed_Name(owl, "annotatedTarget") |> PrefixedName
    /// <summary>
    ///   <para>owl:bottomDataProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The data property that does not relate any individual to any data value.</para>
    /// labels<para>bottomDataProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#bottomDataProperty">http://www.w3.org/2002/07/owl#bottomDataProperty</seealso>
    let bottomDataProperty = Prefixed_Name(owl, "bottomDataProperty") |> PrefixedName

    /// <summary>
    ///   <para>owl:bottomObjectProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The object property that does not relate any two individuals.</para>
    /// labels<para>bottomObjectProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#bottomObjectProperty">http://www.w3.org/2002/07/owl#bottomObjectProperty</seealso>
    let bottomObjectProperty =
        Prefixed_Name(owl, "bottomObjectProperty") |> PrefixedName

    /// <summary>
    ///   <para>owl:cardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the cardinality of an exact cardinality restriction.</para>
    /// labels<para>cardinality</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#cardinality">http://www.w3.org/2002/07/owl#cardinality</seealso>
    let cardinality = Prefixed_Name(owl, "cardinality") |> PrefixedName
    /// <summary>
    ///   <para>owl:deprecated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The annotation property that indicates that a given entity has been deprecated.</para>
    /// labels<para>deprecated</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#deprecated">http://www.w3.org/2002/07/owl#deprecated</seealso>
    let deprecated = Prefixed_Name(owl, "deprecated") |> PrefixedName
    /// <summary>
    ///   <para>owl:disjointWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines that two given classes are disjoint.</para>
    /// labels<para>disjointWith</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#disjointWith">http://www.w3.org/2002/07/owl#disjointWith</seealso>
    let disjointWith = Prefixed_Name(owl, "disjointWith") |> PrefixedName
    /// <summary>
    ///   <para>owl:equivalentClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines that two given classes are equivalent, and that is used to specify datatype definitions.</para>
    /// labels<para>equivalentClass</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#equivalentClass">http://www.w3.org/2002/07/owl#equivalentClass</seealso>
    let equivalentClass = Prefixed_Name(owl, "equivalentClass") |> PrefixedName

    /// <summary>
    ///   <para>owl:NegativePropertyAssertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of negative property assertions.</para>
    /// labels<para>NegativePropertyAssertion</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#NegativePropertyAssertion">http://www.w3.org/2002/07/owl#NegativePropertyAssertion</seealso>
    let NegativePropertyAssertion =
        Prefixed_Name(owl, "NegativePropertyAssertion") |> PrefixedName

    /// <summary>
    ///   <para>owl:Restriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of property restrictions.</para>
    /// labels<para>Restriction</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#Restriction">http://www.w3.org/2002/07/owl#Restriction</seealso>
    let Restriction = Prefixed_Name(owl, "Restriction") |> PrefixedName
    /// <summary>
    ///   <para>owl:TransitiveProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of transitive properties.</para>
    /// labels<para>TransitiveProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#TransitiveProperty">http://www.w3.org/2002/07/owl#TransitiveProperty</seealso>
    let TransitiveProperty = Prefixed_Name(owl, "TransitiveProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:assertionProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the predicate of a negative property assertion.</para>
    /// labels<para>assertionProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#assertionProperty">http://www.w3.org/2002/07/owl#assertionProperty</seealso>
    let assertionProperty = Prefixed_Name(owl, "assertionProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:annotatedSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the subject of an annotated axiom or annotated annotation.</para>
    /// labels<para>annotatedSource</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#annotatedSource">http://www.w3.org/2002/07/owl#annotatedSource</seealso>
    let annotatedSource = Prefixed_Name(owl, "annotatedSource") |> PrefixedName

    /// <summary>
    ///   <para>owl:backwardCompatibleWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:OntologyProperty</para>
    ///   <para>The annotation property that indicates that a given ontology is backward compatible with another ontology.</para>
    /// labels<para>backwardCompatibleWith</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#backwardCompatibleWith">http://www.w3.org/2002/07/owl#backwardCompatibleWith</seealso>
    let backwardCompatibleWith =
        Prefixed_Name(owl, "backwardCompatibleWith") |> PrefixedName

    /// <summary>
    ///   <para>owl:datatypeComplementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines that a given data range is the complement of another data range with respect to the data domain.</para>
    /// labels<para>datatypeComplementOf</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#datatypeComplementOf">http://www.w3.org/2002/07/owl#datatypeComplementOf</seealso>
    let datatypeComplementOf =
        Prefixed_Name(owl, "datatypeComplementOf") |> PrefixedName

    /// <summary>
    ///   <para>owl:differentFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines that two given individuals are different.</para>
    /// labels<para>differentFrom</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#differentFrom">http://www.w3.org/2002/07/owl#differentFrom</seealso>
    let differentFrom = Prefixed_Name(owl, "differentFrom") |> PrefixedName
    /// <summary>
    ///   <para>owl:distinctMembers</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the collection of pairwise different individuals in a owl:AllDifferent axiom.</para>
    /// labels<para>distinctMembers</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#distinctMembers">http://www.w3.org/2002/07/owl#distinctMembers</seealso>
    let distinctMembers = Prefixed_Name(owl, "distinctMembers") |> PrefixedName
    /// <summary>
    ///   <para>owl:hasKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the collection of properties that jointly build a key.</para>
    /// labels<para>hasKey</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#hasKey">http://www.w3.org/2002/07/owl#hasKey</seealso>
    let hasKey = Prefixed_Name(owl, "hasKey") |> PrefixedName
    /// <summary>
    ///   <para>owl:complementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines that a given class is the complement of another class.</para>
    /// labels<para>complementOf</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#complementOf">http://www.w3.org/2002/07/owl#complementOf</seealso>
    let complementOf = Prefixed_Name(owl, "complementOf") |> PrefixedName
    /// <summary>
    ///   <para>owl:disjointUnionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines that a given class is equivalent to the disjoint union of a collection of other classes.</para>
    /// labels<para>disjointUnionOf</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#disjointUnionOf">http://www.w3.org/2002/07/owl#disjointUnionOf</seealso>
    let disjointUnionOf = Prefixed_Name(owl, "disjointUnionOf") |> PrefixedName
    /// <summary>
    ///   <para>owl:equivalentProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines that two given properties are equivalent.</para>
    /// labels<para>equivalentProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#equivalentProperty">http://www.w3.org/2002/07/owl#equivalentProperty</seealso>
    let equivalentProperty = Prefixed_Name(owl, "equivalentProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:hasSelf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the property that a self restriction refers to.</para>
    /// labels<para>hasSelf</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#hasSelf">http://www.w3.org/2002/07/owl#hasSelf</seealso>
    let hasSelf = Prefixed_Name(owl, "hasSelf") |> PrefixedName
    /// <summary>
    ///   <para>owl:incompatibleWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:OntologyProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The annotation property that indicates that a given ontology is incompatible with another ontology.</para>
    /// labels<para>incompatibleWith</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#incompatibleWith">http://www.w3.org/2002/07/owl#incompatibleWith</seealso>
    let incompatibleWith = Prefixed_Name(owl, "incompatibleWith") |> PrefixedName
    /// <summary>
    ///   <para>owl:intersectionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the collection of classes or data ranges that build an intersection.</para>
    /// labels<para>intersectionOf</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#intersectionOf">http://www.w3.org/2002/07/owl#intersectionOf</seealso>
    let intersectionOf = Prefixed_Name(owl, "intersectionOf") |> PrefixedName
    /// <summary>
    ///   <para>owl:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the individual that a has-value restriction refers to.</para>
    /// labels<para>hasValue</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#hasValue">http://www.w3.org/2002/07/owl#hasValue</seealso>
    let hasValue = Prefixed_Name(owl, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>owl:inverseOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines that two given properties are inverse.</para>
    /// labels<para>inverseOf</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#inverseOf">http://www.w3.org/2002/07/owl#inverseOf</seealso>
    let inverseOf = Prefixed_Name(owl, "inverseOf") |> PrefixedName
    /// <summary>
    ///   <para>owl:maxCardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the cardinality of a maximum cardinality restriction.</para>
    /// labels<para>maxCardinality</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#maxCardinality">http://www.w3.org/2002/07/owl#maxCardinality</seealso>
    let maxCardinality = Prefixed_Name(owl, "maxCardinality") |> PrefixedName

    /// <summary>
    ///   <para>owl:minQualifiedCardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the cardinality of a minimum qualified cardinality restriction.</para>
    /// labels<para>minQualifiedCardinality</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#minQualifiedCardinality">http://www.w3.org/2002/07/owl#minQualifiedCardinality</seealso>
    let minQualifiedCardinality =
        Prefixed_Name(owl, "minQualifiedCardinality") |> PrefixedName

    /// <summary>
    ///   <para>owl:onDatatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the datatype that a datatype restriction refers to.</para>
    /// labels<para>onDatatype</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#onDatatype">http://www.w3.org/2002/07/owl#onDatatype</seealso>
    let onDatatype = Prefixed_Name(owl, "onDatatype") |> PrefixedName
    /// <summary>
    ///   <para>owl:onProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the n-tuple of properties that a property restriction on an n-ary data range refers to.</para>
    /// labels<para>onProperties</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#onProperties">http://www.w3.org/2002/07/owl#onProperties</seealso>
    let onProperties = Prefixed_Name(owl, "onProperties") |> PrefixedName
    /// <summary>
    ///   <para>owl:members</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the collection of members in either a owl:AllDifferent, owl:AllDisjointClasses or owl:AllDisjointProperties axiom.</para>
    /// labels<para>members</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#members">http://www.w3.org/2002/07/owl#members</seealso>
    let members = Prefixed_Name(owl, "members") |> PrefixedName
    /// <summary>
    ///   <para>owl:onClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the class that a qualified object cardinality restriction refers to.</para>
    /// labels<para>onClass</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#onClass">http://www.w3.org/2002/07/owl#onClass</seealso>
    let onClass = Prefixed_Name(owl, "onClass") |> PrefixedName
    /// <summary>
    ///   <para>owl:onDataRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the data range that a qualified data cardinality restriction refers to.</para>
    /// labels<para>onDataRange</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#onDataRange">http://www.w3.org/2002/07/owl#onDataRange</seealso>
    let onDataRange = Prefixed_Name(owl, "onDataRange") |> PrefixedName
    /// <summary>
    ///   <para>owl:onProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the property that a property restriction refers to.</para>
    /// labels<para>onProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#onProperty">http://www.w3.org/2002/07/owl#onProperty</seealso>
    let onProperty = Prefixed_Name(owl, "onProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:priorVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:OntologyProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The annotation property that indicates the predecessor ontology of a given ontology.</para>
    /// labels<para>priorVersion</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#priorVersion">http://www.w3.org/2002/07/owl#priorVersion</seealso>
    let priorVersion = Prefixed_Name(owl, "priorVersion") |> PrefixedName

    /// <summary>
    ///   <para>owl:propertyDisjointWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines that two given properties are disjoint.</para>
    /// labels<para>propertyDisjointWith</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#propertyDisjointWith">http://www.w3.org/2002/07/owl#propertyDisjointWith</seealso>
    let propertyDisjointWith =
        Prefixed_Name(owl, "propertyDisjointWith") |> PrefixedName

    /// <summary>
    ///   <para>owl:someValuesFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the class that an existential property restriction refers to.</para>
    /// labels<para>someValuesFrom</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#someValuesFrom">http://www.w3.org/2002/07/owl#someValuesFrom</seealso>
    let someValuesFrom = Prefixed_Name(owl, "someValuesFrom") |> PrefixedName
    /// <summary>
    ///   <para>owl:targetIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the object of a negative object property assertion.</para>
    /// labels<para>targetIndividual</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#targetIndividual">http://www.w3.org/2002/07/owl#targetIndividual</seealso>
    let targetIndividual = Prefixed_Name(owl, "targetIndividual") |> PrefixedName
    /// <summary>
    ///   <para>owl:topDataProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The data property that relates every individual to every data value.</para>
    /// labels<para>topDataProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#topDataProperty">http://www.w3.org/2002/07/owl#topDataProperty</seealso>
    let topDataProperty = Prefixed_Name(owl, "topDataProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:unionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The property that determines the collection of classes or data ranges that build a union.</para>
    /// labels<para>unionOf</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#unionOf">http://www.w3.org/2002/07/owl#unionOf</seealso>
    let unionOf = Prefixed_Name(owl, "unionOf") |> PrefixedName
    /// <summary>
    ///   <para>owl:imports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:OntologyProperty</para>
    ///   <para>The property that is used for importing other ontologies into a given ontology.</para>
    /// labels<para>imports</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#imports">http://www.w3.org/2002/07/owl#imports</seealso>
    let imports = Prefixed_Name(owl, "imports") |> PrefixedName
    /// <summary>
    ///   <para>owl:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#">http://www.w3.org/2002/07/owl#</seealso>
    let _prefix_iri = Prefixed_Name(owl, "") |> PrefixedName

    /// <summary>
    ///   <para>owl:AllDisjointProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of collections of pairwise disjoint properties.</para>
    /// labels<para>AllDisjointProperties</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#AllDisjointProperties">http://www.w3.org/2002/07/owl#AllDisjointProperties</seealso>
    let AllDisjointProperties =
        Prefixed_Name(owl, "AllDisjointProperties") |> PrefixedName

    /// <summary>
    ///   <para>owl:AnnotationProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of annotation properties.</para>
    /// labels<para>AnnotationProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#AnnotationProperty">http://www.w3.org/2002/07/owl#AnnotationProperty</seealso>
    let AnnotationProperty = Prefixed_Name(owl, "AnnotationProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:ObjectProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class of object properties.</para>
    /// labels<para>ObjectProperty</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#ObjectProperty">http://www.w3.org/2002/07/owl#ObjectProperty</seealso>
    let ObjectProperty = Prefixed_Name(owl, "ObjectProperty") |> PrefixedName
