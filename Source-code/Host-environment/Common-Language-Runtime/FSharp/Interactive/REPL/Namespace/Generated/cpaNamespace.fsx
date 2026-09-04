#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module cpa =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#" "cpa"

    /// <summary>
    ///   <para>rdfs:comment : This annotation property is used for exemplifying possible requirements the content pattern provides a solution for. Requirements are expressed as natural language competency questions.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#coversRequirements">cpa:coversRequirements</a>
    /// </summary>
    let coversRequirements = _prefixId.prefix "coversRequirements"
    /// <summary>
    ///   <para>rdfs:comment : This annotation property should be assigned with a URI, which points to the possible reference ontology which the annotated pattern was extracted from (i.e. the reference ontology that the ontology elements have been deeply or partially cloned by). The range is not explicit in the definition of the annotation property because it would turn the ontology to OWL Full. E.g. The participation pattern is extracted from the Dolce Ultra Lite ontology, hence the value for this annotation property is http://www.ontologydesignpatterns.org/ont/dul/DUL.owl^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#extractedFrom">cpa:extractedFrom</a>
    /// </summary>
    let extractedFrom = _prefixId.prefix "extractedFrom"
    /// <summary>
    ///   <para>rdfs:comment : This annotation property is useful for content ontology design patterns. Its value is a URI, which refers to another content ontology design pattern which is a component of the annotated one.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#hasComponent">cpa:hasComponent</a>
    /// </summary>
    let hasComponent = _prefixId.prefix "hasComponent"
    /// <summary>
    ///   <para>rdfs:comment : This annotation property is used for briefly describing the benefits and/or possible trade-offs when using the CP.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#hasConsequences">cpa:hasConsequences</a>
    /// </summary>
    let hasConsequences = _prefixId.prefix "hasConsequences"
    /// <summary>
    ///   <para>rdfs:comment : This annotation property is used in order to describe the intent of the content pattern.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#hasIntent">cpa:hasIntent</a>
    /// </summary>
    let hasIntent = _prefixId.prefix "hasIntent"
    /// <summary>
    ///   <para>rdfs:comment : This property can be used to annotate a unit test (e.g. in the form of a SPARQL query) to be launched to evaluate an ontology against a requirement-based task.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#hasUnitTest">cpa:hasUnitTest</a>
    /// </summary>
    let hasUnitTest = _prefixId.prefix "hasUnitTest"
    /// <summary>
    ///   <para>rdfs:comment : This annotation property is used for referring a cloned ontology entity to its cloning source.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#isCloneOf">cpa:isCloneOf</a>
    /// </summary>
    let isCloneOf = _prefixId.prefix "isCloneOf"
    /// <summary>
    ///   <para>rdfs:comment : This annotation property is useful for content ontology design patterns and its elements. Its value is a URI, which refers either to a content ontology design pattern that is specialized by the annotated one, or to an ontology element that is specialized by the annotated one.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#isSpecializationOf">cpa:isSpecializationOf</a>
    /// </summary>
    let isSpecializationOf = _prefixId.prefix "isSpecializationOf"
    /// <summary>
    ///   <para>rdfs:comment : This annotation property should be assigned with a URI, which points to the concept schema, page, or anything else from which the annotated pattern was reengineered.  If the source does not have any URI e.g., a printed book, this property value should provide information as precise as possible in order to identify the source. This property is alternative to the extractedFrom property because it is used when the pattern come from a concept schema which is not an owl ontology. For example content ontology design patterns, which are reengineered from data model patterns, rdf schemas, etc. should be annotatd with this property. E.g. The basicpersonalfoaf pattern is extracted from the rdf FOAF specification, hence the value for this annotation property is http://xmlns.com/foaf/spec/20071002.rdf^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#reengineeredFrom">cpa:reengineeredFrom</a>
    /// </summary>
    let reengineeredFrom = _prefixId.prefix "reengineeredFrom"
    /// <summary>
    ///   <para>rdfs:comment : This annotation property can be used to indicate other CPs (if any) that specialize, generalize, inlcude, or are components of the CP. Furthermore, this field may indicate other CPs that are typically used in conjunction with the described one. Important similarities and differences with other patterns can be also described here.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#relatedCPs">cpa:relatedCPs</a>
    /// </summary>
    let relatedCPs = _prefixId.prefix "relatedCPs"
    /// <summary>
    ///   <para>rdfs:comment : This annotation property is used for describing examples of instantiation of the Content OP. For example, for the part-of Content OP (which represents part-whole relations) a possible scenario is the sentence: "the brain is part of the human body". Scenarios are expressed as natural language sentences.^^xsd:string</para>
    ///   <a href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#scenarios">cpa:scenarios</a>
    /// </summary>
    let scenarios = _prefixId.prefix "scenarios"
