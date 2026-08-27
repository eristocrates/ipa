namespace http.www.ontologydesignpatterns.org.cp.owl.timeindexedsituation.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module odptimeindexedsituation =
    let _namespace_iri = Namespace_Iri odptimeindexedsituation |> NamespaceIRI

    /// <summary>
    ///   <para>tis:#TimeIndexedSituation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Situation that is explicitly indexed at some time for at least one entity."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Time indexed situation"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#TimeIndexedSituation">http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#TimeIndexedSituation</seealso>
    let TimeIndexedSituation =
        Prefixed_Name(odptimeindexedsituation, "TimeIndexedSituation") |> PrefixedName

    /// <summary>
    ///   <para>tis:#atTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A time interval during which a status is held by a document."</para>
    ///   <para>"A time interval during which a role is held or a contribution is made by an agent."</para>
    ///   <para>"A step is performed within a time interval."</para>
    /// labels<para>"at time"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#atTime">http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#atTime</seealso>
    let atTime = Prefixed_Name(odptimeindexedsituation, "atTime") |> PrefixedName
    /// <summary>
    ///   <para>tis:#forEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"for entity"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#forEntity">http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#forEntity</seealso>
    let forEntity = Prefixed_Name(odptimeindexedsituation, "forEntity") |> PrefixedName

    /// <summary>
    ///   <para>tis:#hasTimeIndexedSetting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has time indexed setting"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#hasTimeIndexedSetting">http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#hasTimeIndexedSetting</seealso>
    let hasTimeIndexedSetting =
        Prefixed_Name(odptimeindexedsituation, "hasTimeIndexedSetting") |> PrefixedName

    /// <summary>
    ///   <para>tis:#isTimeIndexFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"is time index for"</para></remarks>
    /// <seealso href="http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#isTimeIndexFor">http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl#isTimeIndexFor</seealso>
    let isTimeIndexFor =
        Prefixed_Name(odptimeindexedsituation, "isTimeIndexFor") |> PrefixedName
