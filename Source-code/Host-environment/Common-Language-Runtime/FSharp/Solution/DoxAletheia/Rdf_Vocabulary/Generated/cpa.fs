namespace http.www.ontologydesignpatterns.org.schemas.cpannotationschema.owl.hash

open DoxAletheia.Rdf_Vocabulary

module cpa =
    let _namespace_name =
        "http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#"

    /// <summary>
    /// This annotation property is used for exemplifying possible requirements the content pattern provides a solution for. Requirements are expressed as natural language competency questions.
    /// <see href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#coversRequirements"></see></summary>
    let coversRequirements =
        Namespaced_IRI.parse _namespace_name "coversRequirements" |> NamespacedName

    /// <summary>
    /// This annotation property should be assigned with a URI, which points to the possible reference ontology which the annotated pattern was extracted from (i.e. the reference ontology that the ontology elements have been deeply or partially cloned by). The range is not explicit in the definition of the annotation property because it would turn the ontology to OWL Full. E.g. The participation pattern is extracted from the Dolce Ultra Lite ontology, hence the value for this annotation property is http://www.ontologydesignpatterns.org/ont/dul/DUL.owl
    /// <see href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#extractedFrom"></see></summary>
    let extractedFrom =
        Namespaced_IRI.parse _namespace_name "extractedFrom" |> NamespacedName

    /// <summary>
    /// This annotation property is useful for content ontology design patterns. Its value is a URI, which refers to another content ontology design pattern which is a component of the annotated one.
    /// <see href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#hasComponent"></see></summary>
    let hasComponent =
        Namespaced_IRI.parse _namespace_name "hasComponent" |> NamespacedName

    /// <summary>
    /// This annotation property is used for briefly describing the benefits and/or possible trade-offs when using the CP.
    /// <see href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#hasConsequences"></see></summary>
    let hasConsequences =
        Namespaced_IRI.parse _namespace_name "hasConsequences" |> NamespacedName

    /// <summary>
    /// This annotation property is used in order to describe the intent of the content pattern.
    /// <see href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#hasIntent"></see></summary>
    let hasIntent = Namespaced_IRI.parse _namespace_name "hasIntent" |> NamespacedName

    /// <summary>
    /// This property can be used to annotate a unit test (e.g. in the form of a SPARQL query) to be launched to evaluate an ontology against a requirement-based task.
    /// <see href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#hasUnitTest"></see></summary>
    let hasUnitTest =
        Namespaced_IRI.parse _namespace_name "hasUnitTest" |> NamespacedName

    /// <summary>
    /// This annotation property is used for referring a cloned ontology entity to its cloning source.
    /// <see href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#isCloneOf"></see></summary>
    let isCloneOf = Namespaced_IRI.parse _namespace_name "isCloneOf" |> NamespacedName

    /// <summary>
    /// This annotation property is useful for content ontology design patterns and its elements. Its value is a URI, which refers either to a content ontology design pattern that is specialized by the annotated one, or to an ontology element that is specialized by the annotated one.
    /// <see href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#isSpecializationOf"></see></summary>
    let isSpecializationOf =
        Namespaced_IRI.parse _namespace_name "isSpecializationOf" |> NamespacedName

    /// <summary>
    /// This annotation property should be assigned with a URI, which points to the concept schema, page, or anything else from which the annotated pattern was reengineered.  If the source does not have any URI e.g., a printed book, this property value should provide information as precise as possible in order to identify the source. This property is alternative to the extractedFrom property because it is used when the pattern come from a concept schema which is not an owl ontology. For example content ontology design patterns, which are reengineered from data model patterns, rdf schemas, etc. should be annotatd with this property. E.g. The basicpersonalfoaf pattern is extracted from the rdf FOAF specification, hence the value for this annotation property is http://xmlns.com/foaf/spec/20071002.rdf
    /// <see href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#reengineeredFrom"></see></summary>
    let reengineeredFrom =
        Namespaced_IRI.parse _namespace_name "reengineeredFrom" |> NamespacedName

    /// <summary>
    /// This annotation property can be used to indicate other CPs (if any) that specialize, generalize, inlcude, or are components of the CP. Furthermore, this field may indicate other CPs that are typically used in conjunction with the described one. Important similarities and differences with other patterns can be also described here.
    /// <see href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#relatedCPs"></see></summary>
    let relatedCPs = Namespaced_IRI.parse _namespace_name "relatedCPs" |> NamespacedName
    /// <summary>
    /// This annotation property is used for describing examples of instantiation of the Content OP. For example, for the part-of Content OP (which represents part-whole relations) a possible scenario is the sentence: "the brain is part of the human body". Scenarios are expressed as natural language sentences.
    /// <see href="http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#scenarios"></see></summary>
    let scenarios = Namespaced_IRI.parse _namespace_name "scenarios" |> NamespacedName
