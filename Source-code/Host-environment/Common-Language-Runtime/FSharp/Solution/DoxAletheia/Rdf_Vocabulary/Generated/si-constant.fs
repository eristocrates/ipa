namespace https.si_digital_framework.org.constants.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module si_constant =
    let _namespace_iri = Namespace_Iri si_constant |> NamespaceIRI

    /// <summary>
    ///   <para>si-constant:AvogadroConstant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://si-digital-framework.org/constants/AvogadroConstant">https://si-digital-framework.org/constants/AvogadroConstant</seealso>
    let AvogadroConstant =
        Prefixed_Name(si_constant, "AvogadroConstant") |> PrefixedName

    /// <summary>
    ///   <para>si-constant:BoltzmannConstant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://si-digital-framework.org/constants/BoltzmannConstant">https://si-digital-framework.org/constants/BoltzmannConstant</seealso>
    let BoltzmannConstant =
        Prefixed_Name(si_constant, "BoltzmannConstant") |> PrefixedName

    /// <summary>
    ///   <para>si-constant:ElementaryCharge</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://si-digital-framework.org/constants/ElementaryCharge">https://si-digital-framework.org/constants/ElementaryCharge</seealso>
    let ElementaryCharge =
        Prefixed_Name(si_constant, "ElementaryCharge") |> PrefixedName

    /// <summary>
    ///   <para>si-constant:PlanckConstant</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://si-digital-framework.org/constants/PlanckConstant">https://si-digital-framework.org/constants/PlanckConstant</seealso>
    let PlanckConstant = Prefixed_Name(si_constant, "PlanckConstant") |> PrefixedName
    /// <summary>
    ///   <para>si-constant:SpeedOfLight</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://si-digital-framework.org/constants/SpeedOfLight">https://si-digital-framework.org/constants/SpeedOfLight</seealso>
    let SpeedOfLight = Prefixed_Name(si_constant, "SpeedOfLight") |> PrefixedName
