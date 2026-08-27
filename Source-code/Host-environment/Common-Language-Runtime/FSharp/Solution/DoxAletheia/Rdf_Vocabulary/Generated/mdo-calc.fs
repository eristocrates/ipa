namespace https.w3id.org.mdo.calculation.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module mdo_calc =
    let _namespace_iri = Namespace_Iri mdo_calc |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:mdo/calculation/</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"This is the calculation module of Materials Design Ontology."</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/mdo/calculation/">https://w3id.org/mdo/calculation/</seealso>
    let _prefix_iri = Prefixed_Name(mdo_calc, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/calculation/1.0/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/mdo/calculation/1.0/">https://w3id.org/mdo/calculation/1.0/</seealso>
    let ``_1.0/`` = Prefixed_Name(mdo_calc, "1.0/") |> PrefixedName

    /// <summary>
    ///   <para>w3id:mdo/calculation/ComputationalMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A computational method is a way to process structures and/or properties into output structures and/or calculated properties."</para>
    /// labels<para>"Computational Method"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/calculation/ComputationalMethod">https://w3id.org/mdo/calculation/ComputationalMethod</seealso>
    let ComputationalMethod =
        Prefixed_Name(mdo_calc, "ComputationalMethod") |> PrefixedName

    /// <summary>
    ///   <para>w3id:mdo/calculation/ComputationalMethodParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A computational method parameter is a parameter used in a computational method."</para>
    /// labels<para>"Computational Method Parameter"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/calculation/ComputationalMethodParameter">https://w3id.org/mdo/calculation/ComputationalMethodParameter</seealso>
    let ComputationalMethodParameter =
        Prefixed_Name(mdo_calc, "ComputationalMethodParameter") |> PrefixedName

    /// <summary>
    ///   <para>w3id:mdo/calculation/DensityFunctionalTheoryMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A DFT method is a computational quantum mechanical modelling method used to investigate the electronic structure based on optimization of the energy over electronic densities."</para>
    /// labels<para>"Density Functional Theory Method"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/calculation/DensityFunctionalTheoryMethod">https://w3id.org/mdo/calculation/DensityFunctionalTheoryMethod</seealso>
    let DensityFunctionalTheoryMethod =
        Prefixed_Name(mdo_calc, "DensityFunctionalTheoryMethod") |> PrefixedName

    /// <summary>
    ///   <para>w3id:mdo/calculation/ExchangeCorrelationEnergyFunctional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An ExchangeCorrelationEnergyFunctional is a functional to compute the exchange correlation energy."</para>
    /// labels<para>"Exchange Correlation Energy Functional"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/calculation/ExchangeCorrelationEnergyFunctional">https://w3id.org/mdo/calculation/ExchangeCorrelationEnergyFunctional</seealso>
    let ExchangeCorrelationEnergyFunctional =
        Prefixed_Name(mdo_calc, "ExchangeCorrelationEnergyFunctional") |> PrefixedName

    /// <summary>
    ///   <para>w3id:mdo/calculation/GeneralizedGradientApproximation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A GeneralizedGradientApproximation is a classification of exchange correlation energy functionals that only use the local value of the electronic density and its gradient."</para>
    /// labels<para>"Generalized Gradient Approximation"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/calculation/GeneralizedGradientApproximation">https://w3id.org/mdo/calculation/GeneralizedGradientApproximation</seealso>
    let GeneralizedGradientApproximation =
        Prefixed_Name(mdo_calc, "GeneralizedGradientApproximation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:mdo/calculation/HartreeFockMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Hartree Fock method is a computational quantum mechanical modelling method used to investigate the electronic structure based on variational search over wave functions."</para>
    /// labels<para>"Hartree Fock Method"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/calculation/HartreeFockMethod">https://w3id.org/mdo/calculation/HartreeFockMethod</seealso>
    let HartreeFockMethod = Prefixed_Name(mdo_calc, "HartreeFockMethod") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/calculation/HybridFunctional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A hybrid functional is a classification of exchange correlation energy functionals that combine exact exchange from HartreeFock theory with another exchange correlation energy approximation."</para>
    /// labels<para>"Hybrid Functional"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/calculation/HybridFunctional">https://w3id.org/mdo/calculation/HybridFunctional</seealso>
    let HybridFunctional = Prefixed_Name(mdo_calc, "HybridFunctional") |> PrefixedName

    /// <summary>
    ///   <para>w3id:mdo/calculation/HybridGeneralizedGradientApproximation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A hybrid generalized gradient approximation is a classification of exchange correlation energy functionals that combine exact exchange from Hartree–Fock theory with generalized gradient approximation."</para>
    /// labels<para>"Hybrid Generalized Gradient Approximation"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/calculation/HybridGeneralizedGradientApproximation">https://w3id.org/mdo/calculation/HybridGeneralizedGradientApproximation</seealso>
    let HybridGeneralizedGradientApproximation =
        Prefixed_Name(mdo_calc, "HybridGeneralizedGradientApproximation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:mdo/calculation/HybridmetaGeneralizedGradientApproximation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A hybrid meta generalized gradient approximation is a classification of exchange correlation energy functionals that combine exact exchange from Hartree–Fock theory with meta generalized gradient approximation."</para>
    /// labels<para>"Hybrid meta Generalized Gradient Approximation"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/calculation/HybridmetaGeneralizedGradientApproximation">https://w3id.org/mdo/calculation/HybridmetaGeneralizedGradientApproximation</seealso>
    let HybridmetaGeneralizedGradientApproximation =
        Prefixed_Name(mdo_calc, "HybridmetaGeneralizedGradientApproximation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:mdo/calculation/LocalDensityApproximation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An LDA is a classification of exchange correlation energy functionals that only use the local value of the electronic density."</para>
    /// labels<para>"Local Density Approximation"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/calculation/LocalDensityApproximation">https://w3id.org/mdo/calculation/LocalDensityApproximation</seealso>
    let LocalDensityApproximation =
        Prefixed_Name(mdo_calc, "LocalDensityApproximation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:mdo/calculation/ParameterName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"ParameterName represents that a computational method parameter has the name in a string."</para>
    /// labels<para>"parameter name"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/calculation/ParameterName">https://w3id.org/mdo/calculation/ParameterName</seealso>
    let ParameterName = Prefixed_Name(mdo_calc, "ParameterName") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/calculation/ParameterValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"ParameterValue represents that a computational method parameter has the value in a string."</para>
    /// labels<para>"parameter value"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/calculation/ParameterValue">https://w3id.org/mdo/calculation/ParameterValue</seealso>
    let ParameterValue = Prefixed_Name(mdo_calc, "ParameterValue") |> PrefixedName

    /// <summary>
    ///   <para>w3id:mdo/calculation/hasComputationalMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasComputationalMethod represents the relationship between a calculation and a computational method it uses."</para>
    /// labels<para>"has computational method"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/calculation/hasComputationalMethod">https://w3id.org/mdo/calculation/hasComputationalMethod</seealso>
    let hasComputationalMethod =
        Prefixed_Name(mdo_calc, "hasComputationalMethod") |> PrefixedName

    /// <summary>
    ///   <para>w3id:mdo/calculation/hasParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasParameter represents the relationship between a calculation and the parameters it has."</para>
    /// labels<para>"has parameter"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/calculation/hasParameter">https://w3id.org/mdo/calculation/hasParameter</seealso>
    let hasParameter = Prefixed_Name(mdo_calc, "hasParameter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:mdo/calculation/hasXCFunctional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"hasXCFunctional represents the relationship between a density functional theory method and the exchange-correlation energy functionals it takes."</para>
    /// labels<para>"has XC functional"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/calculation/hasXCFunctional">https://w3id.org/mdo/calculation/hasXCFunctional</seealso>
    let hasXCFunctional = Prefixed_Name(mdo_calc, "hasXCFunctional") |> PrefixedName

    /// <summary>
    ///   <para>w3id:mdo/calculation/metaGeneralizedGradientApproximation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A metaGeneralizedGradientApproximation is a classification of exchange correlation energy functionals that only use the local value of the electronic density and its gradient and the Kohn–Sham orbital kinetic energy density."</para>
    /// labels<para>"meta Generalized Gradient Approximation"</para></remarks>
    /// <seealso href="https://w3id.org/mdo/calculation/metaGeneralizedGradientApproximation">https://w3id.org/mdo/calculation/metaGeneralizedGradientApproximation</seealso>
    let metaGeneralizedGradientApproximation =
        Prefixed_Name(mdo_calc, "metaGeneralizedGradientApproximation") |> PrefixedName
