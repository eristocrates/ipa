namespace http.www.w3.org._2002._07.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module owl =
    let _namespace_iri = Namespace_Iri owl |> NamespaceIRI
    /// <summary>
    ///   <para>owl:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#">http://www.w3.org/2002/07/owl#</seealso>
    let _prefix_iri = Prefixed_Name(owl, "") |> PrefixedName
    /// <summary>
    ///   <para>owl:AbbreviatedIRI</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#AbbreviatedIRI">http://www.w3.org/2002/07/owl#AbbreviatedIRI</seealso>
    let AbbreviatedIRI = Prefixed_Name(owl, "AbbreviatedIRI") |> PrefixedName
    /// <summary>
    ///   <para>owl:AllDifferent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of collections of pairwise different individuals."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AllDifferent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#AllDifferent">http://www.w3.org/2002/07/owl#AllDifferent</seealso>
    let AllDifferent = Prefixed_Name(owl, "AllDifferent") |> PrefixedName
    /// <summary>
    ///   <para>owl:AllDisjointClasses</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The class of collections of pairwise disjoint classes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AllDisjointClasses"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#AllDisjointClasses">http://www.w3.org/2002/07/owl#AllDisjointClasses</seealso>
    let AllDisjointClasses = Prefixed_Name(owl, "AllDisjointClasses") |> PrefixedName

    /// <summary>
    ///   <para>owl:AllDisjointProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of collections of pairwise disjoint properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AllDisjointProperties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#AllDisjointProperties">http://www.w3.org/2002/07/owl#AllDisjointProperties</seealso>
    let AllDisjointProperties =
        Prefixed_Name(owl, "AllDisjointProperties") |> PrefixedName

    /// <summary>
    ///   <para>owl:Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of annotated annotations for which the RDF serialization consists of an annotated subject, predicate and object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Annotation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#Annotation">http://www.w3.org/2002/07/owl#Annotation</seealso>
    let Annotation = Prefixed_Name(owl, "Annotation") |> PrefixedName
    /// <summary>
    ///   <para>owl:AnnotationAssertion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#AnnotationAssertion">http://www.w3.org/2002/07/owl#AnnotationAssertion</seealso>
    let AnnotationAssertion = Prefixed_Name(owl, "AnnotationAssertion") |> PrefixedName
    /// <summary>
    ///   <para>owl:AnnotationProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of annotation properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AnnotationProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#AnnotationProperty">http://www.w3.org/2002/07/owl#AnnotationProperty</seealso>
    let AnnotationProperty = Prefixed_Name(owl, "AnnotationProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:AsymmetricProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of asymmetric properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AsymmetricProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#AsymmetricProperty">http://www.w3.org/2002/07/owl#AsymmetricProperty</seealso>
    let AsymmetricProperty = Prefixed_Name(owl, "AsymmetricProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:Axiom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of annotated axioms for which the RDF serialization consists of an annotated subject, predicate and object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Axiom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#Axiom">http://www.w3.org/2002/07/owl#Axiom</seealso>
    let Axiom = Prefixed_Name(owl, "Axiom") |> PrefixedName
    /// <summary>
    ///   <para>owl:Class</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of OWL classes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#Class">http://www.w3.org/2002/07/owl#Class</seealso>
    let Class = Prefixed_Name(owl, "Class") |> PrefixedName
    /// <summary>
    ///   <para>owl:ClassAssertion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#ClassAssertion">http://www.w3.org/2002/07/owl#ClassAssertion</seealso>
    let ClassAssertion = Prefixed_Name(owl, "ClassAssertion") |> PrefixedName

    /// <summary>
    ///   <para>owl:DataExactCardinality</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#DataExactCardinality">http://www.w3.org/2002/07/owl#DataExactCardinality</seealso>
    let DataExactCardinality =
        Prefixed_Name(owl, "DataExactCardinality") |> PrefixedName

    /// <summary>
    ///   <para>owl:DataHasValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#DataHasValue">http://www.w3.org/2002/07/owl#DataHasValue</seealso>
    let DataHasValue = Prefixed_Name(owl, "DataHasValue") |> PrefixedName
    /// <summary>
    ///   <para>owl:DataProperty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#DataProperty">http://www.w3.org/2002/07/owl#DataProperty</seealso>
    let DataProperty = Prefixed_Name(owl, "DataProperty") |> PrefixedName

    /// <summary>
    ///   <para>owl:DataPropertyAssertion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#DataPropertyAssertion">http://www.w3.org/2002/07/owl#DataPropertyAssertion</seealso>
    let DataPropertyAssertion =
        Prefixed_Name(owl, "DataPropertyAssertion") |> PrefixedName

    /// <summary>
    ///   <para>owl:DataPropertyDomain</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#DataPropertyDomain">http://www.w3.org/2002/07/owl#DataPropertyDomain</seealso>
    let DataPropertyDomain = Prefixed_Name(owl, "DataPropertyDomain") |> PrefixedName
    /// <summary>
    ///   <para>owl:DataPropertyRange</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#DataPropertyRange">http://www.w3.org/2002/07/owl#DataPropertyRange</seealso>
    let DataPropertyRange = Prefixed_Name(owl, "DataPropertyRange") |> PrefixedName
    /// <summary>
    ///   <para>owl:DataRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of OWL data ranges, which are special kinds of datatypes. Note: The use of the IRI owl:DataRange has been deprecated as of OWL 2. The IRI rdfs:Datatype SHOULD be used instead."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DataRange"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#DataRange">http://www.w3.org/2002/07/owl#DataRange</seealso>
    let DataRange = Prefixed_Name(owl, "DataRange") |> PrefixedName
    /// <summary>
    ///   <para>owl:DataSomeValuesFrom</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#DataSomeValuesFrom">http://www.w3.org/2002/07/owl#DataSomeValuesFrom</seealso>
    let DataSomeValuesFrom = Prefixed_Name(owl, "DataSomeValuesFrom") |> PrefixedName
    /// <summary>
    ///   <para>owl:DataTypeProperty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#DataTypeProperty">http://www.w3.org/2002/07/owl#DataTypeProperty</seealso>
    let DataTypeProperty = Prefixed_Name(owl, "DataTypeProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:Datatype</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#Datatype">http://www.w3.org/2002/07/owl#Datatype</seealso>
    let Datatype = Prefixed_Name(owl, "Datatype") |> PrefixedName
    /// <summary>
    ///   <para>owl:DatatypeProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The class of data properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DatatypeProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#DatatypeProperty">http://www.w3.org/2002/07/owl#DatatypeProperty</seealso>
    let DatatypeProperty = Prefixed_Name(owl, "DatatypeProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:DatatypeRestriction</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#DatatypeRestriction">http://www.w3.org/2002/07/owl#DatatypeRestriction</seealso>
    let DatatypeRestriction = Prefixed_Name(owl, "DatatypeRestriction") |> PrefixedName
    /// <summary>
    ///   <para>owl:Declaration</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#Declaration">http://www.w3.org/2002/07/owl#Declaration</seealso>
    let Declaration = Prefixed_Name(owl, "Declaration") |> PrefixedName
    /// <summary>
    ///   <para>owl:DeprecatedClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of deprecated classes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DeprecatedClass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#DeprecatedClass">http://www.w3.org/2002/07/owl#DeprecatedClass</seealso>
    let DeprecatedClass = Prefixed_Name(owl, "DeprecatedClass") |> PrefixedName
    /// <summary>
    ///   <para>owl:DeprecatedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of deprecated properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"deprecated property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"DeprecatedProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#DeprecatedProperty">http://www.w3.org/2002/07/owl#DeprecatedProperty</seealso>
    let DeprecatedProperty = Prefixed_Name(owl, "DeprecatedProperty") |> PrefixedName

    /// <summary>
    ///   <para>owl:DifferentIndividuals</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#DifferentIndividuals">http://www.w3.org/2002/07/owl#DifferentIndividuals</seealso>
    let DifferentIndividuals =
        Prefixed_Name(owl, "DifferentIndividuals") |> PrefixedName

    /// <summary>
    ///   <para>owl:DisjointClasses</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#DisjointClasses">http://www.w3.org/2002/07/owl#DisjointClasses</seealso>
    let DisjointClasses = Prefixed_Name(owl, "DisjointClasses") |> PrefixedName
    /// <summary>
    ///   <para>owl:FacetRestriction</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#FacetRestriction">http://www.w3.org/2002/07/owl#FacetRestriction</seealso>
    let FacetRestriction = Prefixed_Name(owl, "FacetRestriction") |> PrefixedName

    /// <summary>
    ///   <para>owl:FunctionalDataProperty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#FunctionalDataProperty">http://www.w3.org/2002/07/owl#FunctionalDataProperty</seealso>
    let FunctionalDataProperty =
        Prefixed_Name(owl, "FunctionalDataProperty") |> PrefixedName

    /// <summary>
    ///   <para>owl:FunctionalObjectProperty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#FunctionalObjectProperty">http://www.w3.org/2002/07/owl#FunctionalObjectProperty</seealso>
    let FunctionalObjectProperty =
        Prefixed_Name(owl, "FunctionalObjectProperty") |> PrefixedName

    /// <summary>
    ///   <para>owl:FunctionalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of functional properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FunctionalProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#FunctionalProperty">http://www.w3.org/2002/07/owl#FunctionalProperty</seealso>
    let FunctionalProperty = Prefixed_Name(owl, "FunctionalProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:IRI</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#IRI">http://www.w3.org/2002/07/owl#IRI</seealso>
    let IRI = Prefixed_Name(owl, "IRI") |> PrefixedName
    /// <summary>
    ///   <para>owl:Import</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#Import">http://www.w3.org/2002/07/owl#Import</seealso>
    let Import = Prefixed_Name(owl, "Import") |> PrefixedName
    /// <summary>
    ///   <para>owl:Individual</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#Individual">http://www.w3.org/2002/07/owl#Individual</seealso>
    let Individual = Prefixed_Name(owl, "Individual") |> PrefixedName

    /// <summary>
    ///   <para>owl:InverseFunctionalObjectProperty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#InverseFunctionalObjectProperty">http://www.w3.org/2002/07/owl#InverseFunctionalObjectProperty</seealso>
    let InverseFunctionalObjectProperty =
        Prefixed_Name(owl, "InverseFunctionalObjectProperty") |> PrefixedName

    /// <summary>
    ///   <para>owl:InverseFunctionalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The class of inverse-functional properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"InverseFunctionalProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"InverseFunctionalProperty"</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#InverseFunctionalProperty">http://www.w3.org/2002/07/owl#InverseFunctionalProperty</seealso>
    let InverseFunctionalProperty =
        Prefixed_Name(owl, "InverseFunctionalProperty") |> PrefixedName

    /// <summary>
    ///   <para>owl:InverseObjectProperties</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#InverseObjectProperties">http://www.w3.org/2002/07/owl#InverseObjectProperties</seealso>
    let InverseObjectProperties =
        Prefixed_Name(owl, "InverseObjectProperties") |> PrefixedName

    /// <summary>
    ///   <para>owl:IrreflexiveProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"The class of irreflexive properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IrreflexiveProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#IrreflexiveProperty">http://www.w3.org/2002/07/owl#IrreflexiveProperty</seealso>
    let IrreflexiveProperty = Prefixed_Name(owl, "IrreflexiveProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:Literal</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#Literal">http://www.w3.org/2002/07/owl#Literal</seealso>
    let Literal = Prefixed_Name(owl, "Literal") |> PrefixedName
    /// <summary>
    ///   <para>owl:NamedIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of named individuals."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NamedIndividual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#NamedIndividual">http://www.w3.org/2002/07/owl#NamedIndividual</seealso>
    let NamedIndividual = Prefixed_Name(owl, "NamedIndividual") |> PrefixedName

    /// <summary>
    ///   <para>owl:NegativePropertyAssertion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of negative property assertions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NegativePropertyAssertion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#NegativePropertyAssertion">http://www.w3.org/2002/07/owl#NegativePropertyAssertion</seealso>
    let NegativePropertyAssertion =
        Prefixed_Name(owl, "NegativePropertyAssertion") |> PrefixedName

    /// <summary>
    ///   <para>owl:Nothing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is the empty class."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nothing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#Nothing">http://www.w3.org/2002/07/owl#Nothing</seealso>
    let Nothing = Prefixed_Name(owl, "Nothing") |> PrefixedName
    /// <summary>
    ///   <para>owl:ObjectAllValuesFrom</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#ObjectAllValuesFrom">http://www.w3.org/2002/07/owl#ObjectAllValuesFrom</seealso>
    let ObjectAllValuesFrom = Prefixed_Name(owl, "ObjectAllValuesFrom") |> PrefixedName

    /// <summary>
    ///   <para>owl:ObjectExactCardinality</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#ObjectExactCardinality">http://www.w3.org/2002/07/owl#ObjectExactCardinality</seealso>
    let ObjectExactCardinality =
        Prefixed_Name(owl, "ObjectExactCardinality") |> PrefixedName

    /// <summary>
    ///   <para>owl:ObjectMinCardinality</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#ObjectMinCardinality">http://www.w3.org/2002/07/owl#ObjectMinCardinality</seealso>
    let ObjectMinCardinality =
        Prefixed_Name(owl, "ObjectMinCardinality") |> PrefixedName

    /// <summary>
    ///   <para>owl:ObjectProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of object properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ObjectProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"ObjectProperty"</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#ObjectProperty">http://www.w3.org/2002/07/owl#ObjectProperty</seealso>
    let ObjectProperty = Prefixed_Name(owl, "ObjectProperty") |> PrefixedName

    /// <summary>
    ///   <para>owl:ObjectPropertyAssertion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#ObjectPropertyAssertion">http://www.w3.org/2002/07/owl#ObjectPropertyAssertion</seealso>
    let ObjectPropertyAssertion =
        Prefixed_Name(owl, "ObjectPropertyAssertion") |> PrefixedName

    /// <summary>
    ///   <para>owl:ObjectPropertyDomain</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#ObjectPropertyDomain">http://www.w3.org/2002/07/owl#ObjectPropertyDomain</seealso>
    let ObjectPropertyDomain =
        Prefixed_Name(owl, "ObjectPropertyDomain") |> PrefixedName

    /// <summary>
    ///   <para>owl:ObjectPropertyRange</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#ObjectPropertyRange">http://www.w3.org/2002/07/owl#ObjectPropertyRange</seealso>
    let ObjectPropertyRange = Prefixed_Name(owl, "ObjectPropertyRange") |> PrefixedName

    /// <summary>
    ///   <para>owl:ObjectSomeValuesFrom</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#ObjectSomeValuesFrom">http://www.w3.org/2002/07/owl#ObjectSomeValuesFrom</seealso>
    let ObjectSomeValuesFrom =
        Prefixed_Name(owl, "ObjectSomeValuesFrom") |> PrefixedName

    /// <summary>
    ///   <para>owl:ObjectUnionOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#ObjectUnionOf">http://www.w3.org/2002/07/owl#ObjectUnionOf</seealso>
    let ObjectUnionOf = Prefixed_Name(owl, "ObjectUnionOf") |> PrefixedName
    /// <summary>
    ///   <para>owl:Ontology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of ontologies."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#Ontology">http://www.w3.org/2002/07/owl#Ontology</seealso>
    let Ontology = Prefixed_Name(owl, "Ontology") |> PrefixedName
    /// <summary>
    ///   <para>owl:OntologyProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of ontology properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OntologyProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#OntologyProperty">http://www.w3.org/2002/07/owl#OntologyProperty</seealso>
    let OntologyProperty = Prefixed_Name(owl, "OntologyProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:Prefix</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#Prefix">http://www.w3.org/2002/07/owl#Prefix</seealso>
    let Prefix = Prefixed_Name(owl, "Prefix") |> PrefixedName
    /// <summary>
    ///   <para>owl:PropertyChainAxiom</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#PropertyChainAxiom">http://www.w3.org/2002/07/owl#PropertyChainAxiom</seealso>
    let PropertyChainAxiom = Prefixed_Name(owl, "PropertyChainAxiom") |> PrefixedName
    /// <summary>
    ///   <para>owl:ReflexiveProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of reflexive properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ReflexiveProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#ReflexiveProperty">http://www.w3.org/2002/07/owl#ReflexiveProperty</seealso>
    let ReflexiveProperty = Prefixed_Name(owl, "ReflexiveProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:Restriction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of property restrictions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Restriction"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#Restriction">http://www.w3.org/2002/07/owl#Restriction</seealso>
    let Restriction = Prefixed_Name(owl, "Restriction") |> PrefixedName
    /// <summary>
    ///   <para>owl:SubClassOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#SubClassOf">http://www.w3.org/2002/07/owl#SubClassOf</seealso>
    let SubClassOf = Prefixed_Name(owl, "SubClassOf") |> PrefixedName
    /// <summary>
    ///   <para>owl:SubDataPropertyOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#SubDataPropertyOf">http://www.w3.org/2002/07/owl#SubDataPropertyOf</seealso>
    let SubDataPropertyOf = Prefixed_Name(owl, "SubDataPropertyOf") |> PrefixedName
    /// <summary>
    ///   <para>owl:SubObjectPropertyOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#SubObjectPropertyOf">http://www.w3.org/2002/07/owl#SubObjectPropertyOf</seealso>
    let SubObjectPropertyOf = Prefixed_Name(owl, "SubObjectPropertyOf") |> PrefixedName

    /// <summary>
    ///   <para>owl:SymmetricObjectProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#SymmetricObjectProperty">http://www.w3.org/2002/07/owl#SymmetricObjectProperty</seealso>
    let SymmetricObjectProperty =
        Prefixed_Name(owl, "SymmetricObjectProperty") |> PrefixedName

    /// <summary>
    ///   <para>owl:SymmetricProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of symmetric properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SymmetricProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#SymmetricProperty">http://www.w3.org/2002/07/owl#SymmetricProperty</seealso>
    let SymmetricProperty = Prefixed_Name(owl, "SymmetricProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:Thing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Thing contains four major taxonomies: - DescriptionTemplate - DramaEntity -
    ///             ExternalReference - DataStructure"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Identité numérique, agents et données."</para>
    ///   <para>"The class of OWL individuals."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The ontology is dedicated to store information of the hydrogen fuel cell domain. Since all sub-classes are providing detailed information to the general subject, 'owl:Thing' can be seen here as the Hydrogen Fuel Cell Domain."</para>
    /// labels<para>"Thing"</para><para>"Thing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"thing"</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#Thing">http://www.w3.org/2002/07/owl#Thing</seealso>
    let Thing = Prefixed_Name(owl, "Thing") |> PrefixedName
    /// <summary>
    ///   <para>owl:TopObjectProperty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#TopObjectProperty">http://www.w3.org/2002/07/owl#TopObjectProperty</seealso>
    let TopObjectProperty = Prefixed_Name(owl, "TopObjectProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:TransitiveProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"The class of transitive properties."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TransitiveProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#TransitiveProperty">http://www.w3.org/2002/07/owl#TransitiveProperty</seealso>
    let TransitiveProperty = Prefixed_Name(owl, "TransitiveProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:allValuesFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the class that a universal property restriction refers to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"allValuesFrom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#allValuesFrom">http://www.w3.org/2002/07/owl#allValuesFrom</seealso>
    let allValuesFrom = Prefixed_Name(owl, "allValuesFrom") |> PrefixedName
    /// <summary>
    ///   <para>owl:annotatedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the predicate of an annotated axiom or annotated annotation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"annotatedProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#annotatedProperty">http://www.w3.org/2002/07/owl#annotatedProperty</seealso>
    let annotatedProperty = Prefixed_Name(owl, "annotatedProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:annotatedSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the subject of an annotated axiom or annotated annotation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"annotatedSource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#annotatedSource">http://www.w3.org/2002/07/owl#annotatedSource</seealso>
    let annotatedSource = Prefixed_Name(owl, "annotatedSource") |> PrefixedName
    /// <summary>
    ///   <para>owl:annotatedTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the object of an annotated axiom or annotated annotation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"annotatedTarget"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#annotatedTarget">http://www.w3.org/2002/07/owl#annotatedTarget</seealso>
    let annotatedTarget = Prefixed_Name(owl, "annotatedTarget") |> PrefixedName
    /// <summary>
    ///   <para>owl:assertionProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the predicate of a negative property assertion."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"assertionProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#assertionProperty">http://www.w3.org/2002/07/owl#assertionProperty</seealso>
    let assertionProperty = Prefixed_Name(owl, "assertionProperty") |> PrefixedName

    /// <summary>
    ///   <para>owl:backwardCompatibleWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:OntologyProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The annotation property that indicates that a given ontology is backward compatible with another ontology."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"backwardCompatibleWith"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#backwardCompatibleWith">http://www.w3.org/2002/07/owl#backwardCompatibleWith</seealso>
    let backwardCompatibleWith =
        Prefixed_Name(owl, "backwardCompatibleWith") |> PrefixedName

    /// <summary>
    ///   <para>owl:bottomDataProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The data property that does not relate any individual to any data value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"bottomDataProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#bottomDataProperty">http://www.w3.org/2002/07/owl#bottomDataProperty</seealso>
    let bottomDataProperty = Prefixed_Name(owl, "bottomDataProperty") |> PrefixedName

    /// <summary>
    ///   <para>owl:bottomObjectProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The object property that does not relate any two individuals."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"bottomObjectProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#bottomObjectProperty">http://www.w3.org/2002/07/owl#bottomObjectProperty</seealso>
    let bottomObjectProperty =
        Prefixed_Name(owl, "bottomObjectProperty") |> PrefixedName

    /// <summary>
    ///   <para>owl:cardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the cardinality of an exact cardinality restriction."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"cardinality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#cardinality">http://www.w3.org/2002/07/owl#cardinality</seealso>
    let cardinality = Prefixed_Name(owl, "cardinality") |> PrefixedName
    /// <summary>
    ///   <para>owl:class</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#class">http://www.w3.org/2002/07/owl#class</seealso>
    let class_ = Prefixed_Name(owl, "class") |> PrefixedName
    /// <summary>
    ///   <para>owl:comment</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#comment">http://www.w3.org/2002/07/owl#comment</seealso>
    let comment = Prefixed_Name(owl, "comment") |> PrefixedName
    /// <summary>
    ///   <para>owl:complementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines that a given class is the complement of another class."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"complementOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#complementOf">http://www.w3.org/2002/07/owl#complementOf</seealso>
    let complementOf = Prefixed_Name(owl, "complementOf") |> PrefixedName
    /// <summary>
    ///   <para>owl:dataPropertyDomain</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#dataPropertyDomain">http://www.w3.org/2002/07/owl#dataPropertyDomain</seealso>
    let dataPropertyDomain = Prefixed_Name(owl, "dataPropertyDomain") |> PrefixedName
    /// <summary>
    ///   <para>owl:dataPropertyRange</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#dataPropertyRange">http://www.w3.org/2002/07/owl#dataPropertyRange</seealso>
    let dataPropertyRange = Prefixed_Name(owl, "dataPropertyRange") |> PrefixedName

    /// <summary>
    ///   <para>owl:datatypeComplementOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines that a given data range is the complement of another data range with respect to the data domain."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"datatypeComplementOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#datatypeComplementOf">http://www.w3.org/2002/07/owl#datatypeComplementOf</seealso>
    let datatypeComplementOf =
        Prefixed_Name(owl, "datatypeComplementOf") |> PrefixedName

    /// <summary>
    ///   <para>owl:deprecated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The annotation property that indicates that a given entity has been deprecated."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"deprecated"</para><para>"deprecated"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#deprecated">http://www.w3.org/2002/07/owl#deprecated</seealso>
    let deprecated = Prefixed_Name(owl, "deprecated") |> PrefixedName
    /// <summary>
    ///   <para>owl:differentFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines that two given individuals are different."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"differentFrom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#differentFrom">http://www.w3.org/2002/07/owl#differentFrom</seealso>
    let differentFrom = Prefixed_Name(owl, "differentFrom") |> PrefixedName
    /// <summary>
    ///   <para>owl:disjointUnionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines that a given class is equivalent to the disjoint union of a collection of other classes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"disjointUnionOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#disjointUnionOf">http://www.w3.org/2002/07/owl#disjointUnionOf</seealso>
    let disjointUnionOf = Prefixed_Name(owl, "disjointUnionOf") |> PrefixedName
    /// <summary>
    ///   <para>owl:disjointWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines that two given classes are disjoint."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"disjointWith"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"disjointWith"</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#disjointWith">http://www.w3.org/2002/07/owl#disjointWith</seealso>
    let disjointWith = Prefixed_Name(owl, "disjointWith") |> PrefixedName
    /// <summary>
    ///   <para>owl:distinctMembers</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the collection of pairwise different individuals in a owl:AllDifferent axiom."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"distinctMembers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#distinctMembers">http://www.w3.org/2002/07/owl#distinctMembers</seealso>
    let distinctMembers = Prefixed_Name(owl, "distinctMembers") |> PrefixedName
    /// <summary>
    ///   <para>owl:equivalentClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines that two given classes are equivalent, and that is used to specify datatype definitions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"equivalentClass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#equivalentClass">http://www.w3.org/2002/07/owl#equivalentClass</seealso>
    let equivalentClass = Prefixed_Name(owl, "equivalentClass") |> PrefixedName
    /// <summary>
    ///   <para>owl:equivalentProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines that two given properties are equivalent."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"equivalentProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#equivalentProperty">http://www.w3.org/2002/07/owl#equivalentProperty</seealso>
    let equivalentProperty = Prefixed_Name(owl, "equivalentProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:hasKey</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the collection of properties that jointly build a key."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasKey"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#hasKey">http://www.w3.org/2002/07/owl#hasKey</seealso>
    let hasKey = Prefixed_Name(owl, "hasKey") |> PrefixedName
    /// <summary>
    ///   <para>owl:hasSelf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the property that a self restriction refers to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasSelf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#hasSelf">http://www.w3.org/2002/07/owl#hasSelf</seealso>
    let hasSelf = Prefixed_Name(owl, "hasSelf") |> PrefixedName
    /// <summary>
    ///   <para>owl:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the individual that a has-value restriction refers to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#hasValue">http://www.w3.org/2002/07/owl#hasValue</seealso>
    let hasValue = Prefixed_Name(owl, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>owl:imports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:OntologyProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The property that is used for importing other ontologies into a given ontology."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"imports"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#imports">http://www.w3.org/2002/07/owl#imports</seealso>
    let imports = Prefixed_Name(owl, "imports") |> PrefixedName
    /// <summary>
    ///   <para>owl:incompatibleWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:OntologyProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The annotation property that indicates that a given ontology is incompatible with another ontology."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"incompatibleWith"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#incompatibleWith">http://www.w3.org/2002/07/owl#incompatibleWith</seealso>
    let incompatibleWith = Prefixed_Name(owl, "incompatibleWith") |> PrefixedName
    /// <summary>
    ///   <para>owl:intersectionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the collection of classes or data ranges that build an intersection."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"intersectionOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#intersectionOf">http://www.w3.org/2002/07/owl#intersectionOf</seealso>
    let intersectionOf = Prefixed_Name(owl, "intersectionOf") |> PrefixedName
    /// <summary>
    ///   <para>owl:inverse</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#inverse">http://www.w3.org/2002/07/owl#inverse</seealso>
    let inverse = Prefixed_Name(owl, "inverse") |> PrefixedName

    /// <summary>
    ///   <para>owl:inverseFunctionalProperty</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#inverseFunctionalProperty">http://www.w3.org/2002/07/owl#inverseFunctionalProperty</seealso>
    let inverseFunctionalProperty =
        Prefixed_Name(owl, "inverseFunctionalProperty") |> PrefixedName

    /// <summary>
    ///   <para>owl:inverseOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines that two given properties are inverse."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"inverseOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"inverseOf"</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#inverseOf">http://www.w3.org/2002/07/owl#inverseOf</seealso>
    let inverseOf = Prefixed_Name(owl, "inverseOf") |> PrefixedName
    /// <summary>
    ///   <para>owl:isEquivalentTo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#isEquivalentTo">http://www.w3.org/2002/07/owl#isEquivalentTo</seealso>
    let isEquivalentTo = Prefixed_Name(owl, "isEquivalentTo") |> PrefixedName
    /// <summary>
    ///   <para>owl:isPartOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#isPartOf">http://www.w3.org/2002/07/owl#isPartOf</seealso>
    let isPartOf = Prefixed_Name(owl, "isPartOf") |> PrefixedName
    /// <summary>
    ///   <para>owl:maxCardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the cardinality of a maximum cardinality restriction."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"maxCardinality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#maxCardinality">http://www.w3.org/2002/07/owl#maxCardinality</seealso>
    let maxCardinality = Prefixed_Name(owl, "maxCardinality") |> PrefixedName
    /// <summary>
    ///   <para>owl:maxInclusive</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#maxInclusive">http://www.w3.org/2002/07/owl#maxInclusive</seealso>
    let maxInclusive = Prefixed_Name(owl, "maxInclusive") |> PrefixedName

    /// <summary>
    ///   <para>owl:maxQualifiedCardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the cardinality of a maximum qualified cardinality restriction."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"maxQualifiedCardinality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#maxQualifiedCardinality">http://www.w3.org/2002/07/owl#maxQualifiedCardinality</seealso>
    let maxQualifiedCardinality =
        Prefixed_Name(owl, "maxQualifiedCardinality") |> PrefixedName

    /// <summary>
    ///   <para>owl:members</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the collection of members in either a owl:AllDifferent, owl:AllDisjointClasses or owl:AllDisjointProperties axiom."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"members"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#members">http://www.w3.org/2002/07/owl#members</seealso>
    let members = Prefixed_Name(owl, "members") |> PrefixedName
    /// <summary>
    ///   <para>owl:minCardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the cardinality of a minimum cardinality restriction."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"minCardinality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#minCardinality">http://www.w3.org/2002/07/owl#minCardinality</seealso>
    let minCardinality = Prefixed_Name(owl, "minCardinality") |> PrefixedName
    /// <summary>
    ///   <para>owl:minInclusive</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#minInclusive">http://www.w3.org/2002/07/owl#minInclusive</seealso>
    let minInclusive = Prefixed_Name(owl, "minInclusive") |> PrefixedName

    /// <summary>
    ///   <para>owl:minQualifiedCardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the cardinality of a minimum qualified cardinality restriction."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"minQualifiedCardinality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#minQualifiedCardinality">http://www.w3.org/2002/07/owl#minQualifiedCardinality</seealso>
    let minQualifiedCardinality =
        Prefixed_Name(owl, "minQualifiedCardinality") |> PrefixedName

    /// <summary>
    ///   <para>owl:onClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the class that a qualified object cardinality restriction refers to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"onClass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#onClass">http://www.w3.org/2002/07/owl#onClass</seealso>
    let onClass = Prefixed_Name(owl, "onClass") |> PrefixedName
    /// <summary>
    ///   <para>owl:onDataRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the data range that a qualified data cardinality restriction refers to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"onDataRange"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#onDataRange">http://www.w3.org/2002/07/owl#onDataRange</seealso>
    let onDataRange = Prefixed_Name(owl, "onDataRange") |> PrefixedName
    /// <summary>
    ///   <para>owl:onDataType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#onDataType">http://www.w3.org/2002/07/owl#onDataType</seealso>
    let onDataType = Prefixed_Name(owl, "onDataType") |> PrefixedName
    /// <summary>
    ///   <para>owl:onDatatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the datatype that a datatype restriction refers to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"onDatatype"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#onDatatype">http://www.w3.org/2002/07/owl#onDatatype</seealso>
    let onDatatype = Prefixed_Name(owl, "onDatatype") |> PrefixedName
    /// <summary>
    ///   <para>owl:onProperties</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the n-tuple of properties that a property restriction on an n-ary data range refers to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"onProperties"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#onProperties">http://www.w3.org/2002/07/owl#onProperties</seealso>
    let onProperties = Prefixed_Name(owl, "onProperties") |> PrefixedName
    /// <summary>
    ///   <para>owl:onProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the property that a property restriction refers to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"onProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#onProperty">http://www.w3.org/2002/07/owl#onProperty</seealso>
    let onProperty = Prefixed_Name(owl, "onProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:oneOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the collection of individuals or data values that build an enumeration."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"oneOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#oneOf">http://www.w3.org/2002/07/owl#oneOf</seealso>
    let oneOf = Prefixed_Name(owl, "oneOf") |> PrefixedName
    /// <summary>
    ///   <para>owl:priorVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:OntologyProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The annotation property that indicates the predecessor ontology of a given ontology."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"priorVersion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#priorVersion">http://www.w3.org/2002/07/owl#priorVersion</seealso>
    let priorVersion = Prefixed_Name(owl, "priorVersion") |> PrefixedName
    /// <summary>
    ///   <para>owl:propertyChainAxiom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the n-tuple of properties that build a sub property chain of a given property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"propertyChainAxiom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#propertyChainAxiom">http://www.w3.org/2002/07/owl#propertyChainAxiom</seealso>
    let propertyChainAxiom = Prefixed_Name(owl, "propertyChainAxiom") |> PrefixedName

    /// <summary>
    ///   <para>owl:propertyDisjointWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines that two given properties are disjoint."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"propertyDisjointWith"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#propertyDisjointWith">http://www.w3.org/2002/07/owl#propertyDisjointWith</seealso>
    let propertyDisjointWith =
        Prefixed_Name(owl, "propertyDisjointWith") |> PrefixedName

    /// <summary>
    ///   <para>owl:qualifiedCardinality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The property that determines the cardinality of an exact qualified cardinality restriction."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"qualifiedCardinality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#qualifiedCardinality">http://www.w3.org/2002/07/owl#qualifiedCardinality</seealso>
    let qualifiedCardinality =
        Prefixed_Name(owl, "qualifiedCardinality") |> PrefixedName

    /// <summary>
    ///   <para>owl:rational</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#rational">http://www.w3.org/2002/07/owl#rational</seealso>
    let rational = Prefixed_Name(owl, "rational") |> PrefixedName
    /// <summary>
    ///   <para>owl:rdfValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#rdfValue">http://www.w3.org/2002/07/owl#rdfValue</seealso>
    let rdfValue = Prefixed_Name(owl, "rdfValue") |> PrefixedName
    /// <summary>
    ///   <para>owl:real</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#real">http://www.w3.org/2002/07/owl#real</seealso>
    let real = Prefixed_Name(owl, "real") |> PrefixedName
    /// <summary>
    ///   <para>owl:sameAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The property that determines that two given individuals are equal."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"same as"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"sameAs"</para><para>"sameAs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"mismo que"</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#sameAs">http://www.w3.org/2002/07/owl#sameAs</seealso>
    let sameAs = Prefixed_Name(owl, "sameAs") |> PrefixedName
    /// <summary>
    ///   <para>owl:seeAlso</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#seeAlso">http://www.w3.org/2002/07/owl#seeAlso</seealso>
    let seeAlso = Prefixed_Name(owl, "seeAlso") |> PrefixedName
    /// <summary>
    ///   <para>owl:someValuesFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the class that an existential property restriction refers to."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"someValuesFrom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#someValuesFrom">http://www.w3.org/2002/07/owl#someValuesFrom</seealso>
    let someValuesFrom = Prefixed_Name(owl, "someValuesFrom") |> PrefixedName
    /// <summary>
    ///   <para>owl:sourceIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the subject of a negative property assertion."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sourceIndividual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#sourceIndividual">http://www.w3.org/2002/07/owl#sourceIndividual</seealso>
    let sourceIndividual = Prefixed_Name(owl, "sourceIndividual") |> PrefixedName
    /// <summary>
    ///   <para>owl:subClass</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#subClass">http://www.w3.org/2002/07/owl#subClass</seealso>
    let subClass = Prefixed_Name(owl, "subClass") |> PrefixedName
    /// <summary>
    ///   <para>owl:subClassOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#subClassOf">http://www.w3.org/2002/07/owl#subClassOf</seealso>
    let subClassOf = Prefixed_Name(owl, "subClassOf") |> PrefixedName
    /// <summary>
    ///   <para>owl:subPropertyOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#subPropertyOf">http://www.w3.org/2002/07/owl#subPropertyOf</seealso>
    let subPropertyOf = Prefixed_Name(owl, "subPropertyOf") |> PrefixedName
    /// <summary>
    ///   <para>owl:targetIndividual</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the object of a negative object property assertion."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"targetIndividual"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#targetIndividual">http://www.w3.org/2002/07/owl#targetIndividual</seealso>
    let targetIndividual = Prefixed_Name(owl, "targetIndividual") |> PrefixedName
    /// <summary>
    ///   <para>owl:targetValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the value of a negative data property assertion."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"targetValue"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#targetValue">http://www.w3.org/2002/07/owl#targetValue</seealso>
    let targetValue = Prefixed_Name(owl, "targetValue") |> PrefixedName
    /// <summary>
    ///   <para>owl:thing</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#thing">http://www.w3.org/2002/07/owl#thing</seealso>
    let thing = Prefixed_Name(owl, "thing") |> PrefixedName
    /// <summary>
    ///   <para>owl:topDataProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"All these properties are data associated with classes. Labels are
    ///             self-explaining (e.g., isIntentional) or have Thing as domain. In
    ///             non-obvious names, the domain class is in the prefix of the name (e.g. Goal_type)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The data property that relates every individual to every data value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"topDataProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#topDataProperty">http://www.w3.org/2002/07/owl#topDataProperty</seealso>
    let topDataProperty = Prefixed_Name(owl, "topDataProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:topObjectProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasIssuer"</para>
    ///   <para>"The object property that relates every two individuals."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"topObjectProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#topObjectProperty">http://www.w3.org/2002/07/owl#topObjectProperty</seealso>
    let topObjectProperty = Prefixed_Name(owl, "topObjectProperty") |> PrefixedName
    /// <summary>
    ///   <para>owl:unionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the collection of classes or data ranges that build a union."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"unionOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#unionOf">http://www.w3.org/2002/07/owl#unionOf</seealso>
    let unionOf = Prefixed_Name(owl, "unionOf") |> PrefixedName
    /// <summary>
    ///   <para>owl:versionIRI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:OntologyProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The property that identifies the version IRI of an ontology."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"versionIRI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#versionIRI">http://www.w3.org/2002/07/owl#versionIRI</seealso>
    let versionIRI = Prefixed_Name(owl, "versionIRI") |> PrefixedName
    /// <summary>
    ///   <para>owl:versionInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The version information of the ontology."</para>
    ///   <para>"v1.0"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The annotation property that provides version information for an ontology or another OWL construct."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"version info"</para><para>"versionInfo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Version Info"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#versionInfo">http://www.w3.org/2002/07/owl#versionInfo</seealso>
    let versionInfo = Prefixed_Name(owl, "versionInfo") |> PrefixedName
    /// <summary>
    ///   <para>owl:versionURI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#versionURI">http://www.w3.org/2002/07/owl#versionURI</seealso>
    let versionURI = Prefixed_Name(owl, "versionURI") |> PrefixedName
    /// <summary>
    ///   <para>owl:withRestrictions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The property that determines the collection of facet-value pairs that define a datatype restriction."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"withRestrictions"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2002/07/owl#withRestrictions">http://www.w3.org/2002/07/owl#withRestrictions</seealso>
    let withRestrictions = Prefixed_Name(owl, "withRestrictions") |> PrefixedName
