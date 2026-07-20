namespace https.w3id.org.mdo.calculation.slash

open DoxAletheia

module mdo_calc =
    let _namespace_name = "https://w3id.org/mdo/calculation/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/mdo/calculation/1.0/"></see>
    /// </summary>
    let ``_1.0/`` = _prefix "1.0/"
    /// <summary>
    /// A computational method is a way to process structures and/or properties into output structures and/or calculated properties.
    /// <see href="https://w3id.org/mdo/calculation/ComputationalMethod"></see></summary>
    let ComputationalMethod = _prefix "ComputationalMethod"
    /// <summary>
    /// A computational method parameter is a parameter used in a computational method.
    /// <see href="https://w3id.org/mdo/calculation/ComputationalMethodParameter"></see></summary>
    let ComputationalMethodParameter = _prefix "ComputationalMethodParameter"
    /// <summary>
    /// hasParameter represents the relationship between a calculation and the parameters it has.
    /// <see href="https://w3id.org/mdo/calculation/hasParameter"></see></summary>
    let hasParameter = _prefix "hasParameter"
    /// <summary>
    /// A DFT method is a computational quantum mechanical modelling method used to investigate the electronic structure based on optimization of the energy over electronic densities.
    /// <see href="https://w3id.org/mdo/calculation/DensityFunctionalTheoryMethod"></see></summary>
    let DensityFunctionalTheoryMethod = _prefix "DensityFunctionalTheoryMethod"

    /// <summary>
    /// An ExchangeCorrelationEnergyFunctional is a functional to compute the exchange correlation energy.
    /// <see href="https://w3id.org/mdo/calculation/ExchangeCorrelationEnergyFunctional"></see></summary>
    let ExchangeCorrelationEnergyFunctional =
        _prefix "ExchangeCorrelationEnergyFunctional"

    /// <summary>
    /// hasXCFunctional represents the relationship between a density functional theory method and the exchange-correlation energy functionals it takes.
    /// <see href="https://w3id.org/mdo/calculation/hasXCFunctional"></see></summary>
    let hasXCFunctional = _prefix "hasXCFunctional"
    /// <summary>
    /// A GeneralizedGradientApproximation is a classification of exchange correlation energy functionals that only use the local value of the electronic density and its gradient.
    /// <see href="https://w3id.org/mdo/calculation/GeneralizedGradientApproximation"></see></summary>
    let GeneralizedGradientApproximation = _prefix "GeneralizedGradientApproximation"
    /// <summary>
    /// A Hartree Fock method is a computational quantum mechanical modelling method used to investigate the electronic structure based on variational search over wave functions.
    /// <see href="https://w3id.org/mdo/calculation/HartreeFockMethod"></see></summary>
    let HartreeFockMethod = _prefix "HartreeFockMethod"
    /// <summary>
    /// A hybrid functional is a classification of exchange correlation energy functionals that combine exact exchange from HartreeFock theory with another exchange correlation energy approximation.
    /// <see href="https://w3id.org/mdo/calculation/HybridFunctional"></see></summary>
    let HybridFunctional = _prefix "HybridFunctional"

    /// <summary>
    /// A hybrid generalized gradient approximation is a classification of exchange correlation energy functionals that combine exact exchange from Hartree–Fock theory with generalized gradient approximation.
    /// <see href="https://w3id.org/mdo/calculation/HybridGeneralizedGradientApproximation"></see></summary>
    let HybridGeneralizedGradientApproximation =
        _prefix "HybridGeneralizedGradientApproximation"

    /// <summary>
    /// A hybrid meta generalized gradient approximation is a classification of exchange correlation energy functionals that combine exact exchange from Hartree–Fock theory with meta generalized gradient approximation.
    /// <see href="https://w3id.org/mdo/calculation/HybridmetaGeneralizedGradientApproximation"></see></summary>
    let HybridmetaGeneralizedGradientApproximation =
        _prefix "HybridmetaGeneralizedGradientApproximation"

    /// <summary>
    /// An LDA is a classification of exchange correlation energy functionals that only use the local value of the electronic density.
    /// <see href="https://w3id.org/mdo/calculation/LocalDensityApproximation"></see></summary>
    let LocalDensityApproximation = _prefix "LocalDensityApproximation"
    /// <summary>
    /// ParameterName represents that a computational method parameter has the name in a string.
    /// <see href="https://w3id.org/mdo/calculation/ParameterName"></see></summary>
    let ParameterName = _prefix "ParameterName"
    /// <summary>
    /// ParameterValue represents that a computational method parameter has the value in a string.
    /// <see href="https://w3id.org/mdo/calculation/ParameterValue"></see></summary>
    let ParameterValue = _prefix "ParameterValue"
    /// <summary>
    /// hasComputationalMethod represents the relationship between a calculation and a computational method it uses.
    /// <see href="https://w3id.org/mdo/calculation/hasComputationalMethod"></see></summary>
    let hasComputationalMethod = _prefix "hasComputationalMethod"

    /// <summary>
    /// A metaGeneralizedGradientApproximation is a classification of exchange correlation energy functionals that only use the local value of the electronic density and its gradient and the Kohn–Sham orbital kinetic energy density.
    /// <see href="https://w3id.org/mdo/calculation/metaGeneralizedGradientApproximation"></see></summary>
    let metaGeneralizedGradientApproximation =
        _prefix "metaGeneralizedGradientApproximation"
