namespace http.www.ontologydesignpatterns.org.schemas.cpannotationschema.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cpa =
    let _namespace_iri = Namespace_Iri cpa |> NamespaceIRI
    /// <summary>
    ///   <para>cpa:coversRequirements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"This annotation property is used for exemplifying possible requirements the content pattern provides a solution for. Requirements are expressed as natural language competency questions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#coversRequirements">http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#coversRequirements</seealso>
    let coversRequirements = Prefixed_Name(cpa, "coversRequirements") |> PrefixedName
    /// <summary>
    ///   <para>cpa:extractedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"This annotation property should be assigned with a URI, which points to the possible reference ontology which the annotated pattern was extracted from (i.e. the reference ontology that the ontology elements have been deeply or partially cloned by). The range is not explicit in the definition of the annotation property because it would turn the ontology to OWL Full. E.g. The participation pattern is extracted from the Dolce Ultra Lite ontology, hence the value for this annotation property is http://www.ontologydesignpatterns.org/ont/dul/DUL.owl"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#extractedFrom">http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#extractedFrom</seealso>
    let extractedFrom = Prefixed_Name(cpa, "extractedFrom") |> PrefixedName
    /// <summary>
    ///   <para>cpa:hasAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#hasAuthor">http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#hasAuthor</seealso>
    let hasAuthor = Prefixed_Name(cpa, "hasAuthor") |> PrefixedName
    /// <summary>
    ///   <para>cpa:hasComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"This annotation property is useful for content ontology design patterns. Its value is a URI, which refers to another content ontology design pattern which is a component of the annotated one."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#hasComponent">http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#hasComponent</seealso>
    let hasComponent = Prefixed_Name(cpa, "hasComponent") |> PrefixedName
    /// <summary>
    ///   <para>cpa:hasConsequences</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"This annotation property is used for briefly describing the benefits and/or possible trade-offs when using the CP."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#hasConsequences">http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#hasConsequences</seealso>
    let hasConsequences = Prefixed_Name(cpa, "hasConsequences") |> PrefixedName
    /// <summary>
    ///   <para>cpa:hasIntent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"This annotation property is used in order to describe the intent of the content pattern."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#hasIntent">http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#hasIntent</seealso>
    let hasIntent = Prefixed_Name(cpa, "hasIntent") |> PrefixedName
    /// <summary>
    ///   <para>cpa:hasUnitTest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"This property can be used to annotate a unit test (e.g. in the form of a SPARQL query) to be launched to evaluate an ontology against a requirement-based task."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#hasUnitTest">http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#hasUnitTest</seealso>
    let hasUnitTest = Prefixed_Name(cpa, "hasUnitTest") |> PrefixedName
    /// <summary>
    ///   <para>cpa:isCloneOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"This annotation property is used for referring a cloned ontology entity to its cloning source."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#isCloneOf">http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#isCloneOf</seealso>
    let isCloneOf = Prefixed_Name(cpa, "isCloneOf") |> PrefixedName
    /// <summary>
    ///   <para>cpa:isSpecializationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"This annotation property is useful for content ontology design patterns and its elements. Its value is a URI, which refers either to a content ontology design pattern that is specialized by the annotated one, or to an ontology element that is specialized by the annotated one."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#isSpecializationOf">http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#isSpecializationOf</seealso>
    let isSpecializationOf = Prefixed_Name(cpa, "isSpecializationOf") |> PrefixedName
    /// <summary>
    ///   <para>cpa:reengineeredFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"This annotation property should be assigned with a URI, which points to the concept schema, page, or anything else from which the annotated pattern was reengineered.  If the source does not have any URI e.g., a printed book, this property value should provide information as precise as possible in order to identify the source. This property is alternative to the extractedFrom property because it is used when the pattern come from a concept schema which is not an owl ontology. For example content ontology design patterns, which are reengineered from data model patterns, rdf schemas, etc. should be annotatd with this property. E.g. The basicpersonalfoaf pattern is extracted from the rdf FOAF specification, hence the value for this annotation property is http://xmlns.com/foaf/spec/20071002.rdf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#reengineeredFrom">http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#reengineeredFrom</seealso>
    let reengineeredFrom = Prefixed_Name(cpa, "reengineeredFrom") |> PrefixedName
    /// <summary>
    ///   <para>cpa:relatedCPs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"This annotation property can be used to indicate other CPs (if any) that specialize, generalize, inlcude, or are components of the CP. Furthermore, this field may indicate other CPs that are typically used in conjunction with the described one. Important similarities and differences with other patterns can be also described here."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#relatedCPs">http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#relatedCPs</seealso>
    let relatedCPs = Prefixed_Name(cpa, "relatedCPs") |> PrefixedName
    /// <summary>
    ///   <para>cpa:scenarios</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"This annotation property is used for describing examples of instantiation of the Content OP. For example, for the part-of Content OP (which represents part-whole relations) a possible scenario is the sentence: "the brain is part of the human body". Scenarios are expressed as natural language sentences."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#scenarios">http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#scenarios</seealso>
    let scenarios = Prefixed_Name(cpa, "scenarios") |> PrefixedName
