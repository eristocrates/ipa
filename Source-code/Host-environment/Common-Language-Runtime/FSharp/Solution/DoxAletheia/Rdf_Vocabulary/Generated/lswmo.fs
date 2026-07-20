namespace http.ontology.cybershare.utep.edu.ELSEWeb.elseweb_modelling.owl.hash

open DoxAletheia

module lswmo =
    let _namespace_name =
        "http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Following SIO's definition of algorithm, a species modelling algorithm is an effective method expressed as a finite list of well-defined instructions for calculating a model about species.
    /// <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#SpeciesModellingAlgorithm"></see></summary>
    let SpeciesModellingAlgorithm = _prefix "SpeciesModellingAlgorithm"
    /// <summary>
    /// A set of modelling parameter(s) required by a specific species modeling algorithm.
    /// <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#SpeciesModellingParameters"></see></summary>
    let SpeciesModellingParameters = _prefix "SpeciesModellingParameters"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#behaviorControlledBy"></see>
    /// </summary>
    let behaviorControlledBy = _prefix "behaviorControlledBy"
    /// <summary>
    /// Following SIO's definition of software application, a species modelling software is a software that can be directly executed by some processing unit and offers species modelling services.
    /// <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#SpeciesModellingSoftware"></see></summary>
    let SpeciesModellingSoftware = _prefix "SpeciesModellingSoftware"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#implementedIn"></see>
    /// </summary>
    let implementedIn = _prefix "implementedIn"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#hasAlgorithmName"></see>
    /// </summary>
    let hasAlgorithmName = _prefix "hasAlgorithmName"
    /// <summary>
    /// Following SIO's definition of parameter, a species modelling parameter  is variable whose value changes the characteristics of a species model.
    /// <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#SpeciesModellingParameter"></see></summary>
    let SpeciesModellingParameter = _prefix "SpeciesModellingParameter"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#boundToValue"></see>
    /// </summary>
    let boundToValue = _prefix "boundToValue"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#hasParameterName"></see>
    /// </summary>
    let hasParameterName = _prefix "hasParameterName"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#hasParameterMember"></see>
    /// </summary>
    let hasParameterMember = _prefix "hasParameterMember"
    /// <summary>
    ///   <see href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#controlsBehaviorOf"></see>
    /// </summary>
    let controlsBehaviorOf = _prefix "controlsBehaviorOf"
