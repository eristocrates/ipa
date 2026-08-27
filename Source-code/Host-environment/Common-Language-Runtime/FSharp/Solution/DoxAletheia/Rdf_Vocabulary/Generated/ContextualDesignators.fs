namespace https.www.omg.org.spec.Commons.ContextualDesignators.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ContextualDesignators =
    let _namespace_iri = Namespace_Iri ContextualDesignators |> NamespaceIRI
    /// <summary>
    ///   <para>ContextualDesignators:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/ContextualDesignators/">https://www.omg.org/spec/Commons/ContextualDesignators/</seealso>
    let _prefix_iri = Prefixed_Name(ContextualDesignators, "") |> PrefixedName
    /// <summary>
    ///   <para>ContextualDesignators:Context</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/ContextualDesignators/Context">https://www.omg.org/spec/Commons/ContextualDesignators/Context</seealso>
    let Context = Prefixed_Name(ContextualDesignators, "Context") |> PrefixedName

    /// <summary>
    ///   <para>ContextualDesignators:ContextualName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/ContextualDesignators/ContextualName">https://www.omg.org/spec/Commons/ContextualDesignators/ContextualName</seealso>
    let ContextualName =
        Prefixed_Name(ContextualDesignators, "ContextualName") |> PrefixedName

    /// <summary>
    ///   <para>ContextualDesignators:appliesTo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/ContextualDesignators/appliesTo">https://www.omg.org/spec/Commons/ContextualDesignators/appliesTo</seealso>
    let appliesTo = Prefixed_Name(ContextualDesignators, "appliesTo") |> PrefixedName

    /// <summary>
    ///   <para>ContextualDesignators:hasApplicablePeriod</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/ContextualDesignators/hasApplicablePeriod">https://www.omg.org/spec/Commons/ContextualDesignators/hasApplicablePeriod</seealso>
    let hasApplicablePeriod =
        Prefixed_Name(ContextualDesignators, "hasApplicablePeriod") |> PrefixedName

    /// <summary>
    ///   <para>ContextualDesignators:isApplicableIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/ContextualDesignators/isApplicableIn">https://www.omg.org/spec/Commons/ContextualDesignators/isApplicableIn</seealso>
    let isApplicableIn =
        Prefixed_Name(ContextualDesignators, "isApplicableIn") |> PrefixedName

    /// <summary>
    ///   <para>ContextualDesignators:isUsedBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/ContextualDesignators/isUsedBy">https://www.omg.org/spec/Commons/ContextualDesignators/isUsedBy</seealso>
    let isUsedBy = Prefixed_Name(ContextualDesignators, "isUsedBy") |> PrefixedName
    /// <summary>
    ///   <para>ContextualDesignators:uses</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://www.omg.org/spec/Commons/ContextualDesignators/uses">https://www.omg.org/spec/Commons/ContextualDesignators/uses</seealso>
    let uses = Prefixed_Name(ContextualDesignators, "uses") |> PrefixedName
