#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``mdo-calc`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/mdo/calculation/" "mdo-calc"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Computational Method</para>
    ///   <para>rdfs:comment : A computational method is a way to process structures and/or properties into output structures and/or calculated properties.</para>
    ///   <a href="https://w3id.org/mdo/calculation/ComputationalMethod">mdo-calc:ComputationalMethod</a>
    /// </summary>
    let ComputationalMethod = _prefixId.prefix "ComputationalMethod"
    /// <summary>
    ///   <para>rdfs:label : Computational Method Parameter</para>
    ///   <para>rdfs:comment : A computational method parameter is a parameter used in a computational method.</para>
    ///   <a href="https://w3id.org/mdo/calculation/ComputationalMethodParameter">mdo-calc:ComputationalMethodParameter</a>
    /// </summary>
    let ComputationalMethodParameter = _prefixId.prefix "ComputationalMethodParameter"
    /// <summary>
    ///   <para>rdfs:label : Density Functional Theory Method</para>
    ///   <para>rdfs:comment : A DFT method is a computational quantum mechanical modelling method used to investigate the electronic structure based on optimization of the energy over electronic densities.</para>
    ///   <a href="https://w3id.org/mdo/calculation/DensityFunctionalTheoryMethod">mdo-calc:DensityFunctionalTheoryMethod</a>
    /// </summary>
    let DensityFunctionalTheoryMethod = _prefixId.prefix "DensityFunctionalTheoryMethod"

    /// <summary>
    ///   <para>rdfs:label : Exchange Correlation Energy Functional</para>
    ///   <para>rdfs:comment : An ExchangeCorrelationEnergyFunctional is a functional to compute the exchange correlation energy.</para>
    ///   <a href="https://w3id.org/mdo/calculation/ExchangeCorrelationEnergyFunctional">mdo-calc:ExchangeCorrelationEnergyFunctional</a>
    /// </summary>
    let ExchangeCorrelationEnergyFunctional =
        _prefixId.prefix "ExchangeCorrelationEnergyFunctional"

    /// <summary>
    ///   <para>rdfs:label : Generalized Gradient Approximation</para>
    ///   <para>rdfs:comment : A GeneralizedGradientApproximation is a classification of exchange correlation energy functionals that only use the local value of the electronic density and its gradient.</para>
    ///   <a href="https://w3id.org/mdo/calculation/GeneralizedGradientApproximation">mdo-calc:GeneralizedGradientApproximation</a>
    /// </summary>
    let GeneralizedGradientApproximation =
        _prefixId.prefix "GeneralizedGradientApproximation"

    /// <summary>
    ///   <para>rdfs:label : Hartree Fock Method</para>
    ///   <para>rdfs:comment : A Hartree Fock method is a computational quantum mechanical modelling method used to investigate the electronic structure based on variational search over wave functions.</para>
    ///   <a href="https://w3id.org/mdo/calculation/HartreeFockMethod">mdo-calc:HartreeFockMethod</a>
    /// </summary>
    let HartreeFockMethod = _prefixId.prefix "HartreeFockMethod"
    /// <summary>
    ///   <para>rdfs:label : Hybrid Functional</para>
    ///   <para>rdfs:comment : A hybrid functional is a classification of exchange correlation energy functionals that combine exact exchange from HartreeFock theory with another exchange correlation energy approximation.</para>
    ///   <a href="https://w3id.org/mdo/calculation/HybridFunctional">mdo-calc:HybridFunctional</a>
    /// </summary>
    let HybridFunctional = _prefixId.prefix "HybridFunctional"

    /// <summary>
    ///   <para>rdfs:label : Hybrid Generalized Gradient Approximation</para>
    ///   <para>rdfs:comment : A hybrid generalized gradient approximation is a classification of exchange correlation energy functionals that combine exact exchange from Hartree–Fock theory with generalized gradient approximation.</para>
    ///   <a href="https://w3id.org/mdo/calculation/HybridGeneralizedGradientApproximation">mdo-calc:HybridGeneralizedGradientApproximation</a>
    /// </summary>
    let HybridGeneralizedGradientApproximation =
        _prefixId.prefix "HybridGeneralizedGradientApproximation"

    /// <summary>
    ///   <para>rdfs:label : Hybrid meta Generalized Gradient Approximation</para>
    ///   <para>rdfs:comment : A hybrid meta generalized gradient approximation is a classification of exchange correlation energy functionals that combine exact exchange from Hartree–Fock theory with meta generalized gradient approximation.</para>
    ///   <a href="https://w3id.org/mdo/calculation/HybridmetaGeneralizedGradientApproximation">mdo-calc:HybridmetaGeneralizedGradientApproximation</a>
    /// </summary>
    let HybridmetaGeneralizedGradientApproximation =
        _prefixId.prefix "HybridmetaGeneralizedGradientApproximation"

    /// <summary>
    ///   <para>rdfs:label : Local Density Approximation</para>
    ///   <para>rdfs:comment : An LDA is a classification of exchange correlation energy functionals that only use the local value of the electronic density.</para>
    ///   <a href="https://w3id.org/mdo/calculation/LocalDensityApproximation">mdo-calc:LocalDensityApproximation</a>
    /// </summary>
    let LocalDensityApproximation = _prefixId.prefix "LocalDensityApproximation"
    /// <summary>
    ///   <para>rdfs:label : parameter name</para>
    ///   <para>rdfs:comment : ParameterName represents that a computational method parameter has the name in a string.</para>
    ///   <a href="https://w3id.org/mdo/calculation/ParameterName">mdo-calc:ParameterName</a>
    /// </summary>
    let ParameterName = _prefixId.prefix "ParameterName"
    /// <summary>
    ///   <para>rdfs:label : parameter value</para>
    ///   <para>rdfs:comment : ParameterValue represents that a computational method parameter has the value in a string.</para>
    ///   <a href="https://w3id.org/mdo/calculation/ParameterValue">mdo-calc:ParameterValue</a>
    /// </summary>
    let ParameterValue = _prefixId.prefix "ParameterValue"
    /// <summary>
    ///   <para>rdfs:label : has computational method</para>
    ///   <para>rdfs:comment : hasComputationalMethod represents the relationship between a calculation and a computational method it uses.</para>
    ///   <a href="https://w3id.org/mdo/calculation/hasComputationalMethod">mdo-calc:hasComputationalMethod</a>
    /// </summary>
    let hasComputationalMethod = _prefixId.prefix "hasComputationalMethod"
    /// <summary>
    ///   <para>rdfs:label : has parameter</para>
    ///   <para>rdfs:comment : hasParameter represents the relationship between a calculation and the parameters it has.</para>
    ///   <a href="https://w3id.org/mdo/calculation/hasParameter">mdo-calc:hasParameter</a>
    /// </summary>
    let hasParameter = _prefixId.prefix "hasParameter"
    /// <summary>
    ///   <para>rdfs:label : has XC functional</para>
    ///   <para>rdfs:comment : hasXCFunctional represents the relationship between a density functional theory method and the exchange-correlation energy functionals it takes.</para>
    ///   <a href="https://w3id.org/mdo/calculation/hasXCFunctional">mdo-calc:hasXCFunctional</a>
    /// </summary>
    let hasXCFunctional = _prefixId.prefix "hasXCFunctional"

    /// <summary>
    ///   <para>rdfs:label : meta Generalized Gradient Approximation</para>
    ///   <para>rdfs:comment : A metaGeneralizedGradientApproximation is a classification of exchange correlation energy functionals that only use the local value of the electronic density and its gradient and the Kohn–Sham orbital kinetic energy density.</para>
    ///   <a href="https://w3id.org/mdo/calculation/metaGeneralizedGradientApproximation">mdo-calc:metaGeneralizedGradientApproximation</a>
    /// </summary>
    let metaGeneralizedGradientApproximation =
        _prefixId.prefix "metaGeneralizedGradientApproximation"
