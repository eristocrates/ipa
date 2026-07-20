namespace http.www.ontologydesignpatterns.org.schemas.cpannotationschema.owl.hash

open DoxAletheia

module cpa =
    let _namespace_name =
        "http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This annotation property is used for exemplifying possible requirements the content pattern provides a solution for. Requirements are expressed as natural language competency questions.
    /// <see href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#coversRequirements"></see></summary>
    let coversRequirements = _prefix "coversRequirements"
    /// <summary>
    /// This annotation property should be assigned with a URI, which points to the possible reference ontology which the annotated pattern was extracted from (i.e. the reference ontology that the ontology elements have been deeply or partially cloned by). The range is not explicit in the definition of the annotation property because it would turn the ontology to OWL Full. E.g. The participation pattern is extracted from the Dolce Ultra Lite ontology, hence the value for this annotation property is http://www.ontologydesignpatterns.org/ont/dul/DUL.owl
    /// <see href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#extractedFrom"></see></summary>
    let extractedFrom = _prefix "extractedFrom"
    /// <summary>
    /// This annotation property is useful for content ontology design patterns. Its value is a URI, which refers to another content ontology design pattern which is a component of the annotated one.
    /// <see href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#hasComponent"></see></summary>
    let hasComponent = _prefix "hasComponent"
    /// <summary>
    /// This annotation property is used for briefly describing the benefits and/or possible trade-offs when using the CP.
    /// <see href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#hasConsequences"></see></summary>
    let hasConsequences = _prefix "hasConsequences"
    /// <summary>
    /// This annotation property is used in order to describe the intent of the content pattern.
    /// <see href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#hasIntent"></see></summary>
    let hasIntent = _prefix "hasIntent"
    /// <summary>
    /// This property can be used to annotate a unit test (e.g. in the form of a SPARQL query) to be launched to evaluate an ontology against a requirement-based task.
    /// <see href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#hasUnitTest"></see></summary>
    let hasUnitTest = _prefix "hasUnitTest"
    /// <summary>
    /// This annotation property is used for referring a cloned ontology entity to its cloning source.
    /// <see href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#isCloneOf"></see></summary>
    let isCloneOf = _prefix "isCloneOf"
    /// <summary>
    /// This annotation property is useful for content ontology design patterns and its elements. Its value is a URI, which refers either to a content ontology design pattern that is specialized by the annotated one, or to an ontology element that is specialized by the annotated one.
    /// <see href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#isSpecializationOf"></see></summary>
    let isSpecializationOf = _prefix "isSpecializationOf"
    /// <summary>
    /// This annotation property should be assigned with a URI, which points to the concept schema, page, or anything else from which the annotated pattern was reengineered.  If the source does not have any URI e.g., a printed book, this property value should provide information as precise as possible in order to identify the source. This property is alternative to the extractedFrom property because it is used when the pattern come from a concept schema which is not an owl ontology. For example content ontology design patterns, which are reengineered from data model patterns, rdf schemas, etc. should be annotatd with this property. E.g. The basicpersonalfoaf pattern is extracted from the rdf FOAF specification, hence the value for this annotation property is http://xmlns.com/foaf/spec/20071002.rdf
    /// <see href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#reengineeredFrom"></see></summary>
    let reengineeredFrom = _prefix "reengineeredFrom"
    /// <summary>
    /// This annotation property can be used to indicate other CPs (if any) that specialize, generalize, inlcude, or are components of the CP. Furthermore, this field may indicate other CPs that are typically used in conjunction with the described one. Important similarities and differences with other patterns can be also described here.
    /// <see href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#relatedCPs"></see></summary>
    let relatedCPs = _prefix "relatedCPs"
    /// <summary>
    /// This annotation property is used for describing examples of instantiation of the Content OP. For example, for the part-of Content OP (which represents part-whole relations) a possible scenario is the sentence: "the brain is part of the human body". Scenarios are expressed as natural language sentences.
    /// <see href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#scenarios"></see></summary>
    let scenarios = _prefix "scenarios"
