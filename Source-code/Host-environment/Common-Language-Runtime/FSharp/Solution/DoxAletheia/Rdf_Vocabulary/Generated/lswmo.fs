namespace http.ontology.cybershare.utep.edu.ELSEWeb.elseweb_modelling.owl.hash

open DoxAletheia.Rdf_Vocabulary

module lswmo =
    let _namespace_name =
        "http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#"

    /// <summary>
    /// Following SIO's definition of algorithm, a species modelling algorithm is an effective method expressed as a finite list of well-defined instructions for calculating a model about species.
    /// <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#SpeciesModellingAlgorithm"></see></summary>
    let SpeciesModellingAlgorithm =
        Namespaced_IRI.parse _namespace_name "SpeciesModellingAlgorithm" |> NamespacedName

    /// <summary>
    /// A set of modelling parameter(s) required by a specific species modeling algorithm.
    /// <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#SpeciesModellingParameters"></see></summary>
    let SpeciesModellingParameters =
        Namespaced_IRI.parse _namespace_name "SpeciesModellingParameters" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#behaviorControlledBy"></see>
    /// </summary>
    let behaviorControlledBy =
        Namespaced_IRI.parse _namespace_name "behaviorControlledBy" |> NamespacedName

    /// <summary>
    /// Following SIO's definition of software application, a species modelling software is a software that can be directly executed by some processing unit and offers species modelling services.
    /// <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#SpeciesModellingSoftware"></see></summary>
    let SpeciesModellingSoftware =
        Namespaced_IRI.parse _namespace_name "SpeciesModellingSoftware" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#implementedIn"></see>
    /// </summary>
    let implementedIn =
        Namespaced_IRI.parse _namespace_name "implementedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#hasAlgorithmName"></see>
    /// </summary>
    let hasAlgorithmName =
        Namespaced_IRI.parse _namespace_name "hasAlgorithmName" |> NamespacedName

    /// <summary>
    /// Following SIO's definition of parameter, a species modelling parameter  is variable whose value changes the characteristics of a species model.
    /// <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#SpeciesModellingParameter"></see></summary>
    let SpeciesModellingParameter =
        Namespaced_IRI.parse _namespace_name "SpeciesModellingParameter" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#boundToValue"></see>
    /// </summary>
    let boundToValue =
        Namespaced_IRI.parse _namespace_name "boundToValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#hasParameterName"></see>
    /// </summary>
    let hasParameterName =
        Namespaced_IRI.parse _namespace_name "hasParameterName" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#hasParameterMember"></see>
    /// </summary>
    let hasParameterMember =
        Namespaced_IRI.parse _namespace_name "hasParameterMember" |> NamespacedName

    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#controlsBehaviorOf"></see>
    /// </summary>
    let controlsBehaviorOf =
        Namespaced_IRI.parse _namespace_name "controlsBehaviorOf" |> NamespacedName
