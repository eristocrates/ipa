namespace http.ontologydesignpatterns.org.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module odp =
    let _namespace_iri = Namespace_Iri odp |> NamespaceIRI

    /// <summary>
    ///   <para>odp:cp/owl/classification.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ontologydesignpatterns.org/cp/owl/classification.owl">http://ontologydesignpatterns.org/cp/owl/classification.owl</seealso>
    let ``cp/owl/classification.owl`` =
        Prefixed_Name(odp, "cp/owl/classification.owl") |> PrefixedName

    /// <summary>
    ///   <para>odp:cp/owl/collectionentity.owl#isMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ontologydesignpatterns.org/cp/owl/collectionentity.owl#isMemberOf">http://ontologydesignpatterns.org/cp/owl/collectionentity.owl#isMemberOf</seealso>
    let ``cp/owl/collectionentity.owl#isMemberOf`` =
        Prefixed_Name(odp, "cp/owl/collectionentity.owl#isMemberOf") |> PrefixedName

    /// <summary>
    ///   <para>odp:cp/owl/descriptionandsituation.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ontologydesignpatterns.org/cp/owl/descriptionandsituation.owl">http://ontologydesignpatterns.org/cp/owl/descriptionandsituation.owl</seealso>
    let ``cp/owl/descriptionandsituation.owl`` =
        Prefixed_Name(odp, "cp/owl/descriptionandsituation.owl") |> PrefixedName

    /// <summary>
    ///   <para>odp:cp/owl/parameterregion.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ontologydesignpatterns.org/cp/owl/parameterregion.owl">http://ontologydesignpatterns.org/cp/owl/parameterregion.owl</seealso>
    let ``cp/owl/parameterregion.owl`` =
        Prefixed_Name(odp, "cp/owl/parameterregion.owl") |> PrefixedName

    /// <summary>
    ///   <para>odp:cp/owl/sequence.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ontologydesignpatterns.org/cp/owl/sequence.owl">http://ontologydesignpatterns.org/cp/owl/sequence.owl</seealso>
    let ``cp/owl/sequence.owl`` =
        Prefixed_Name(odp, "cp/owl/sequence.owl") |> PrefixedName

    /// <summary>
    ///   <para>odp:cp/owl/timeindexedsituation.owl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl">http://ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl</seealso>
    let ``cp/owl/timeindexedsituation.owl`` =
        Prefixed_Name(odp, "cp/owl/timeindexedsituation.owl") |> PrefixedName

    /// <summary>
    ///   <para>odp:ont/web/irw.owl#WebRepresentation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ontologydesignpatterns.org/ont/web/irw.owl#WebRepresentation">http://ontologydesignpatterns.org/ont/web/irw.owl#WebRepresentation</seealso>
    let ``ont/web/irw.owl#WebRepresentation`` =
        Prefixed_Name(odp, "ont/web/irw.owl#WebRepresentation") |> PrefixedName

    /// <summary>
    ///   <para>odp:opla-sd#entityPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://ontologydesignpatterns.org/opla-sd#entityPosition">http://ontologydesignpatterns.org/opla-sd#entityPosition</seealso>
    let ``opla_sd#entityPosition`` =
        Prefixed_Name(odp, "opla-sd#entityPosition") |> PrefixedName

    /// <summary>
    ///   <para>odp:opla-sd#entityPositionX</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://ontologydesignpatterns.org/opla-sd#entityPositionX">http://ontologydesignpatterns.org/opla-sd#entityPositionX</seealso>
    let ``opla_sd#entityPositionX`` =
        Prefixed_Name(odp, "opla-sd#entityPositionX") |> PrefixedName

    /// <summary>
    ///   <para>odp:opla-sd#entityPositionY</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://ontologydesignpatterns.org/opla-sd#entityPositionY">http://ontologydesignpatterns.org/opla-sd#entityPositionY</seealso>
    let ``opla_sd#entityPositionY`` =
        Prefixed_Name(odp, "opla-sd#entityPositionY") |> PrefixedName

    /// <summary>
    ///   <para>odp:opla/isNativeTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://ontologydesignpatterns.org/opla/isNativeTo">http://ontologydesignpatterns.org/opla/isNativeTo</seealso>
    let ``opla/isNativeTo`` = Prefixed_Name(odp, "opla/isNativeTo") |> PrefixedName

    /// <summary>
    ///   <para>odp:opla/reusesPatternAsTemplate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://ontologydesignpatterns.org/opla/reusesPatternAsTemplate">http://ontologydesignpatterns.org/opla/reusesPatternAsTemplate</seealso>
    let ``opla/reusesPatternAsTemplate`` =
        Prefixed_Name(odp, "opla/reusesPatternAsTemplate") |> PrefixedName

    /// <summary>
    ///   <para>odp:wiki/Submissions:Componency</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ontologydesignpatterns.org/wiki/Submissions:Componency">http://ontologydesignpatterns.org/wiki/Submissions:Componency</seealso>
    let ``wiki/Submissions:Componency`` =
        Prefixed_Name(odp, "wiki/Submissions:Componency") |> PrefixedName
