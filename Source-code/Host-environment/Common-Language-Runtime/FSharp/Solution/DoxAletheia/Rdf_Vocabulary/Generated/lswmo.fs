namespace http.ontology.cybershare.utep.edu.ELSEWeb.elseweb_modelling.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lswmo =
    let _namespace_iri = Namespace_Iri lswmo |> NamespaceIRI

    /// <summary>
    ///   <para>lswmo:SpeciesModellingParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Following SIO's definition of parameter, a species modelling parameter  is variable whose value changes the characteristics of a species model.</para>
    /// labels<para>species modelling parameter</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#SpeciesModellingParameter">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#SpeciesModellingParameter</seealso>
    let SpeciesModellingParameter =
        Prefixed_Name(lswmo, "SpeciesModellingParameter") |> PrefixedName

    /// <summary>
    ///   <para>lswmo:SpeciesModellingParameters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A set of modelling parameter(s) required by a specific species modeling algorithm.</para>
    /// labels<para>species modelling parameters</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#SpeciesModellingParameters">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#SpeciesModellingParameters</seealso>
    let SpeciesModellingParameters =
        Prefixed_Name(lswmo, "SpeciesModellingParameters") |> PrefixedName

    /// <summary>
    ///   <para>lswmo:SpeciesModellingAlgorithm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Following SIO's definition of algorithm, a species modelling algorithm is an effective method expressed as a finite list of well-defined instructions for calculating a model about species.</para>
    /// labels<para>species modelling algorithm</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#SpeciesModellingAlgorithm">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#SpeciesModellingAlgorithm</seealso>
    let SpeciesModellingAlgorithm =
        Prefixed_Name(lswmo, "SpeciesModellingAlgorithm") |> PrefixedName

    /// <summary>
    ///   <para>lswmo:SpeciesModellingSoftware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Following SIO's definition of software application, a species modelling software is a software that can be directly executed by some processing unit and offers species modelling services.</para>
    /// labels<para>species modelling software</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#SpeciesModellingSoftware">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#SpeciesModellingSoftware</seealso>
    let SpeciesModellingSoftware =
        Prefixed_Name(lswmo, "SpeciesModellingSoftware") |> PrefixedName

    /// <summary>
    ///   <para>lswmo:implementedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>implemented in</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#implementedIn">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#implementedIn</seealso>
    let implementedIn = Prefixed_Name(lswmo, "implementedIn") |> PrefixedName

    /// <summary>
    ///   <para>lswmo:behaviorControlledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>behaviour controlled by</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#behaviorControlledBy">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#behaviorControlledBy</seealso>
    let behaviorControlledBy =
        Prefixed_Name(lswmo, "behaviorControlledBy") |> PrefixedName

    /// <summary>
    ///   <para>lswmo:hasAlgorithmName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has algorithm name</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#hasAlgorithmName">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#hasAlgorithmName</seealso>
    let hasAlgorithmName = Prefixed_Name(lswmo, "hasAlgorithmName") |> PrefixedName
    /// <summary>
    ///   <para>lswmo:boundToValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>bound to value</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#boundToValue">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#boundToValue</seealso>
    let boundToValue = Prefixed_Name(lswmo, "boundToValue") |> PrefixedName
    /// <summary>
    ///   <para>lswmo:hasParameterName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>has parameter name</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#hasParameterName">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#hasParameterName</seealso>
    let hasParameterName = Prefixed_Name(lswmo, "hasParameterName") |> PrefixedName
    /// <summary>
    ///   <para>lswmo:hasParameterMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has parameter member</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#hasParameterMember">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#hasParameterMember</seealso>
    let hasParameterMember = Prefixed_Name(lswmo, "hasParameterMember") |> PrefixedName
    /// <summary>
    ///   <para>lswmo:controlsBehaviorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>controls behavior of</para></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#controlsBehaviorOf">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#controlsBehaviorOf</seealso>
    let controlsBehaviorOf = Prefixed_Name(lswmo, "controlsBehaviorOf") |> PrefixedName
