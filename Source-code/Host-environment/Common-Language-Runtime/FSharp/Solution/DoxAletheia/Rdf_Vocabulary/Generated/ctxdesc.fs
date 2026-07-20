namespace http.www.demcare.eu.ontologies.contextdescriptor.owl.hash

open DoxAletheia

module ctxdesc =
    let _namespace_name = "http://www.demcare.eu/ontologies/contextdescriptor.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This property is used for denoting the dependencies of a particular ontology class.
    ///
    /// The model also allows annotated classes to inherit the context dependencies of the superclasses through property chain axiom (OWL 2 RL Profile).
    /// <see href="http://www.demcare.eu/ontologies/contextdescriptor.owl#dependency"></see></summary>
    let dependency = _prefix "dependency"
    /// <summary>
    /// This property is used for defining the higher level class of the ContextDescriptor
    /// <see href="http://www.demcare.eu/ontologies/contextdescriptor.owl#describes"></see></summary>
    let describes = _prefix "describes"
    /// <summary>
    ///   <see href="http://www.demcare.eu/ontologies/contextdescriptor.owl#isDescribedBy"></see>
    /// </summary>
    let isDescribedBy = _prefix "isDescribedBy"
    /// <summary>
    /// A ContextDescriptor instance is a container class that allows the definition of relationships (dependencies) among ontology classes.
    ///
    /// The goal is to define relations among classes, therefore, the proposed ontology treats classes as instances, allowing property assertions to be made among domain concepts. Intuitively, the ontology can be thought of as a conceptual (meta) layer that can be placed on top of any domain activity ontology. This way, instances of the ContextDescriptor are used to link domain activities (describes property) with one or more lower-level conceptualisations through dependency property assertions.
    ///
    /// The pattern has been used for building human activity models by defining the dependencies between low-level observations and high-level activities.
    ///
    /// For more details, please see the relevant paper:
    /// Georgios Meditskos, Efstratios Kontopoulos, Ioannis Kompatsiaris, "Knowledge-driven Activity Recognition and Segmentation Using Context Connections", International Semantic Web Conference (ISWC), pp. 260-275, Riva del Garda, Trento, Italy, 19-23 October 2014
    /// <see href="http://www.demcare.eu/ontologies/contextdescriptor.owl#ContextDescriptor"></see></summary>
    let ContextDescriptor = _prefix "ContextDescriptor"
    /// <summary>
    /// This property can be used to assign a threshold to the context descriptor of a certain complex activity, specifying a minimum value of confidence (plausability).
    /// <see href="http://www.demcare.eu/ontologies/contextdescriptor.owl#threshold"></see></summary>
    let threshold = _prefix "threshold"
