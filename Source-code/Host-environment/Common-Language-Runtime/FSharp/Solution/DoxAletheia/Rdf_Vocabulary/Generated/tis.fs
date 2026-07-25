namespace http.www.ontologydesignpatterns.org.cp.owl.timeindexedsituation.owl.bare

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tis =
    let _namespace_iri = Namespace_Iri tis |> NamespaceIRI
    /// <summary>
    ///   <para>tis:#atTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>at time</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#atTime">http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#atTime</seealso>
    let ``_#atTime`` = Prefixed_Name(tis, "#atTime") |> PrefixedName
    /// <summary>
    ///   <para>tis:#forEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>for entity</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#forEntity">http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#forEntity</seealso>
    let ``_#forEntity`` = Prefixed_Name(tis, "#forEntity") |> PrefixedName
    /// <summary>
    ///   <para>tis:#isTimeIndexFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is time index for</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#isTimeIndexFor">http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#isTimeIndexFor</seealso>
    let ``_#isTimeIndexFor`` = Prefixed_Name(tis, "#isTimeIndexFor") |> PrefixedName
    /// <summary>
    ///   <para>tis:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>A generic pattern usable for all situations that require a temporal indexing.</para>
    /// </remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl">http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl</seealso>
    let _prefix_iri = Prefixed_Name(tis, "") |> PrefixedName

    /// <summary>
    ///   <para>tis:#TimeIndexedSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Situation that is explicitly indexed at some time for at least one entity.</para>
    /// labels<para>Time indexed situation</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#TimeIndexedSituation">http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#TimeIndexedSituation</seealso>
    let ``_#TimeIndexedSituation`` =
        Prefixed_Name(tis, "#TimeIndexedSituation") |> PrefixedName

    /// <summary>
    ///   <para>tis:#hasTimeIndexedSetting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has time indexed setting</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#hasTimeIndexedSetting">http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#hasTimeIndexedSetting</seealso>
    let ``_#hasTimeIndexedSetting`` =
        Prefixed_Name(tis, "#hasTimeIndexedSetting") |> PrefixedName
