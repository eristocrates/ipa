namespace https.ekgf.github.io.dprod.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dprod =
    let _namespace_iri = Namespace_Iri dprod |> NamespaceIRI
    /// <summary>
    ///   <para>dprod:InputPort</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://ekgf.github.io/dprod/InputPort">https://ekgf.github.io/dprod/InputPort</seealso>
    let InputPort = Prefixed_Name(dprod, "InputPort") |> PrefixedName
    /// <summary>
    ///   <para>dprod:OutputPort</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://ekgf.github.io/dprod/OutputPort">https://ekgf.github.io/dprod/OutputPort</seealso>
    let OutputPort = Prefixed_Name(dprod, "OutputPort") |> PrefixedName

    /// <summary>
    ///   <para>dprod:ServiceLevelAgreement</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://ekgf.github.io/dprod/ServiceLevelAgreement">https://ekgf.github.io/dprod/ServiceLevelAgreement</seealso>
    let ServiceLevelAgreement =
        Prefixed_Name(dprod, "ServiceLevelAgreement") |> PrefixedName

    /// <summary>
    ///   <para>dprod:consumesFrom</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://ekgf.github.io/dprod/consumesFrom">https://ekgf.github.io/dprod/consumesFrom</seealso>
    let consumesFrom = Prefixed_Name(dprod, "consumesFrom") |> PrefixedName
    /// <summary>
    ///   <para>dprod:hasInputPort</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://ekgf.github.io/dprod/hasInputPort">https://ekgf.github.io/dprod/hasInputPort</seealso>
    let hasInputPort = Prefixed_Name(dprod, "hasInputPort") |> PrefixedName
    /// <summary>
    ///   <para>dprod:hasOutputPort</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://ekgf.github.io/dprod/hasOutputPort">https://ekgf.github.io/dprod/hasOutputPort</seealso>
    let hasOutputPort = Prefixed_Name(dprod, "hasOutputPort") |> PrefixedName
    /// <summary>
    ///   <para>dprod:providesTo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://ekgf.github.io/dprod/providesTo">https://ekgf.github.io/dprod/providesTo</seealso>
    let providesTo = Prefixed_Name(dprod, "providesTo") |> PrefixedName
