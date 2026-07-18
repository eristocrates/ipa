namespace https.w3id.org.mdo.calculation.slash

open DoxAletheia.Rdf_Vocabulary

module mdo_calc =
    let _namespace_name = "https://w3id.org/mdo/calculation/"
    /// <summary>
    ///   <see href="https://w3id.org/mdo/calculation/1.0/"></see>
    /// </summary>
    let ``_1.0/`` = Namespaced_IRI.parse _namespace_name "1.0/" |> NamespacedName

    /// <summary>
    /// A computational method is a way to process structures and/or properties into output structures and/or calculated properties.
    /// <see href="https://w3id.org/mdo/calculation/ComputationalMethod"></see></summary>
    let ComputationalMethod =
        Namespaced_IRI.parse _namespace_name "ComputationalMethod" |> NamespacedName

    /// <summary>
    /// A computational method parameter is a parameter used in a computational method.
    /// <see href="https://w3id.org/mdo/calculation/ComputationalMethodParameter"></see></summary>
    let ComputationalMethodParameter =
        Namespaced_IRI.parse _namespace_name "ComputationalMethodParameter" |> NamespacedName

    /// <summary>
    /// hasParameter represents the relationship between a calculation and the parameters it has.
    /// <see href="https://w3id.org/mdo/calculation/hasParameter"></see></summary>
    let hasParameter =
        Namespaced_IRI.parse _namespace_name "hasParameter" |> NamespacedName

    /// <summary>
    /// A DFT method is a computational quantum mechanical modelling method used to investigate the electronic structure based on optimization of the energy over electronic densities.
    /// <see href="https://w3id.org/mdo/calculation/DensityFunctionalTheoryMethod"></see></summary>
    let DensityFunctionalTheoryMethod =
        Namespaced_IRI.parse _namespace_name "DensityFunctionalTheoryMethod" |> NamespacedName

    /// <summary>
    /// An ExchangeCorrelationEnergyFunctional is a functional to compute the exchange correlation energy.
    /// <see href="https://w3id.org/mdo/calculation/ExchangeCorrelationEnergyFunctional"></see></summary>
    let ExchangeCorrelationEnergyFunctional =
        Namespaced_IRI.parse _namespace_name "ExchangeCorrelationEnergyFunctional" |> NamespacedName

    /// <summary>
    /// hasXCFunctional represents the relationship between a density functional theory method and the exchange-correlation energy functionals it takes.
    /// <see href="https://w3id.org/mdo/calculation/hasXCFunctional"></see></summary>
    let hasXCFunctional =
        Namespaced_IRI.parse _namespace_name "hasXCFunctional" |> NamespacedName

    /// <summary>
    /// A GeneralizedGradientApproximation is a classification of exchange correlation energy functionals that only use the local value of the electronic density and its gradient.
    /// <see href="https://w3id.org/mdo/calculation/GeneralizedGradientApproximation"></see></summary>
    let GeneralizedGradientApproximation =
        Namespaced_IRI.parse _namespace_name "GeneralizedGradientApproximation" |> NamespacedName

    /// <summary>
    /// A Hartree Fock method is a computational quantum mechanical modelling method used to investigate the electronic structure based on variational search over wave functions.
    /// <see href="https://w3id.org/mdo/calculation/HartreeFockMethod"></see></summary>
    let HartreeFockMethod =
        Namespaced_IRI.parse _namespace_name "HartreeFockMethod" |> NamespacedName

    /// <summary>
    /// A hybrid functional is a classification of exchange correlation energy functionals that combine exact exchange from HartreeFock theory with another exchange correlation energy approximation.
    /// <see href="https://w3id.org/mdo/calculation/HybridFunctional"></see></summary>
    let HybridFunctional =
        Namespaced_IRI.parse _namespace_name "HybridFunctional" |> NamespacedName

    /// <summary>
    /// A hybrid generalized gradient approximation is a classification of exchange correlation energy functionals that combine exact exchange from Hartree–Fock theory with generalized gradient approximation.
    /// <see href="https://w3id.org/mdo/calculation/HybridGeneralizedGradientApproximation"></see></summary>
    let HybridGeneralizedGradientApproximation =
        Namespaced_IRI.parse _namespace_name "HybridGeneralizedGradientApproximation" |> NamespacedName

    /// <summary>
    /// A hybrid meta generalized gradient approximation is a classification of exchange correlation energy functionals that combine exact exchange from Hartree–Fock theory with meta generalized gradient approximation.
    /// <see href="https://w3id.org/mdo/calculation/HybridmetaGeneralizedGradientApproximation"></see></summary>
    let HybridmetaGeneralizedGradientApproximation =
        Namespaced_IRI.parse _namespace_name "HybridmetaGeneralizedGradientApproximation" |> NamespacedName

    /// <summary>
    /// An LDA is a classification of exchange correlation energy functionals that only use the local value of the electronic density.
    /// <see href="https://w3id.org/mdo/calculation/LocalDensityApproximation"></see></summary>
    let LocalDensityApproximation =
        Namespaced_IRI.parse _namespace_name "LocalDensityApproximation" |> NamespacedName

    /// <summary>
    /// ParameterName represents that a computational method parameter has the name in a string.
    /// <see href="https://w3id.org/mdo/calculation/ParameterName"></see></summary>
    let ParameterName =
        Namespaced_IRI.parse _namespace_name "ParameterName" |> NamespacedName

    /// <summary>
    /// ParameterValue represents that a computational method parameter has the value in a string.
    /// <see href="https://w3id.org/mdo/calculation/ParameterValue"></see></summary>
    let ParameterValue =
        Namespaced_IRI.parse _namespace_name "ParameterValue" |> NamespacedName

    /// <summary>
    /// hasComputationalMethod represents the relationship between a calculation and a computational method it uses.
    /// <see href="https://w3id.org/mdo/calculation/hasComputationalMethod"></see></summary>
    let hasComputationalMethod =
        Namespaced_IRI.parse _namespace_name "hasComputationalMethod" |> NamespacedName

    /// <summary>
    /// A metaGeneralizedGradientApproximation is a classification of exchange correlation energy functionals that only use the local value of the electronic density and its gradient and the Kohn–Sham orbital kinetic energy density.
    /// <see href="https://w3id.org/mdo/calculation/metaGeneralizedGradientApproximation"></see></summary>
    let metaGeneralizedGradientApproximation =
        Namespaced_IRI.parse _namespace_name "metaGeneralizedGradientApproximation" |> NamespacedName
