namespace http.purl.org.net.opmv.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module opmv =
    let _namespace_iri = Namespace_Iri opmv |> NamespaceIRI
    /// <summary>
    ///   <para>opmv:</para>
    /// </summary>
    /// <remarks>
    ///   <para>hartigprov:DataCreation</para>
    ///   <para>owl:Ontology</para>
    ///   <para>hartigprov:DataItem</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/opmv/ns#">http://purl.org/net/opmv/ns#</seealso>
    let _prefix_iri = Prefixed_Name(opmv, "") |> PrefixedName
    /// <summary>
    ///   <para>opmv:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Agent is a contextual entity acting as a catalyst of a process, enabling, facilitating, controlling, or affecting its execution."</para>
    /// labels<para>"Agent"</para></remarks>
    /// <seealso href="http://purl.org/net/opmv/ns#Agent">http://purl.org/net/opmv/ns#Agent</seealso>
    let Agent = Prefixed_Name(opmv, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>opmv:Artefact</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/net/opmv/ns#Artefact">http://purl.org/net/opmv/ns#Artefact</seealso>
    let Artefact = Prefixed_Name(opmv, "Artefact") |> PrefixedName
    /// <summary>
    ///   <para>opmv:Artifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Artifact is a general concept that represents immutable piece of state, which may have a physical embodiment in a physical object, or a digital representation in a computer system."</para>
    /// labels<para>"Artifact"</para></remarks>
    /// <seealso href="http://purl.org/net/opmv/ns#Artifact">http://purl.org/net/opmv/ns#Artifact</seealso>
    let Artifact = Prefixed_Name(opmv, "Artifact") |> PrefixedName
    /// <summary>
    ///   <para>opmv:Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Process refers to an action or series of actions performed on or caused by artifacts, and resulting in new artifacts."</para>
    /// labels<para>"Process"</para></remarks>
    /// <seealso href="http://purl.org/net/opmv/ns#Process">http://purl.org/net/opmv/ns#Process</seealso>
    let Process = Prefixed_Name(opmv, "Process") |> PrefixedName
    /// <summary>
    ///   <para>opmv:used</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"used is an abstract property to express that an artifact was used by a process."</para>
    /// labels<para>"used"</para></remarks>
    /// <seealso href="http://purl.org/net/opmv/ns#used">http://purl.org/net/opmv/ns#used</seealso>
    let used = Prefixed_Name(opmv, "used") |> PrefixedName
    /// <summary>
    ///   <para>opmv:wasControlledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"wasControlledBy is an abstract property to express that a process was controlled an agent."</para>
    /// labels<para>"wasControlledBy"</para></remarks>
    /// <seealso href="http://purl.org/net/opmv/ns#wasControlledBy">http://purl.org/net/opmv/ns#wasControlledBy</seealso>
    let wasControlledBy = Prefixed_Name(opmv, "wasControlledBy") |> PrefixedName
    /// <summary>
    ///   <para>opmv:wasDerivedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"wasDerivedFrom is an abstract property to express that an artifact was derived from another artifact."</para>
    /// labels<para>"wasDerivedFrom"</para></remarks>
    /// <seealso href="http://purl.org/net/opmv/ns#wasDerivedFrom">http://purl.org/net/opmv/ns#wasDerivedFrom</seealso>
    let wasDerivedFrom = Prefixed_Name(opmv, "wasDerivedFrom") |> PrefixedName
    /// <summary>
    ///   <para>opmv:wasEncodedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"wasEncodedBy is an object property to express that an artifact is encoded by another artifact. The property is useful for expressing the relationship between the data and the file encoding the data."</para>
    /// labels<para>"wasEncodedBy"</para></remarks>
    /// <seealso href="http://purl.org/net/opmv/ns#wasEncodedBy">http://purl.org/net/opmv/ns#wasEncodedBy</seealso>
    let wasEncodedBy = Prefixed_Name(opmv, "wasEncodedBy") |> PrefixedName
    /// <summary>
    ///   <para>opmv:wasEndedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///       wasEndedAt is an object property to express that a process was finished at a specific time &lt;a xmlns="http://www.w3.org/1999/xhtml" href="http://www.w3.org/2006/time#Instant" xml:lang="en"&gt;instant&lt;/a&gt;. The property chain defines that all processes, that were performed during a specific time period which ended at a specific instant, were actually finished at that specific time instant.
    ///     "^^&lt;http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral&gt;</para>
    /// labels<para>"wasEndedAt"</para></remarks>
    /// <seealso href="http://purl.org/net/opmv/ns#wasEndedAt">http://purl.org/net/opmv/ns#wasEndedAt</seealso>
    let wasEndedAt = Prefixed_Name(opmv, "wasEndedAt") |> PrefixedName
    /// <summary>
    ///   <para>opmv:wasGeneratedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///     wasGeneratedAt is an object property to express that an artifact was generated at a specific time &lt;a xmlns="http://www.w3.org/1999/xhtml" href="http://www.w3.org/2006/time#Instant" xml:lang="en"&gt;instant&lt;/a&gt;. This property is very similar to &lt;a xmlns="http://www.w3.org/1999/xhtml" href="http://purl.org/dc/terms/created" xml:lang="en"&gt;dct:created&lt;/a&gt;. Note that in a very fine-grained case the time when an artifact was generated might not be the same as the time when the process producing that artifact finished.
    ///     "^^&lt;http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral&gt;</para>
    /// labels<para>"wasGeneratedAt"</para></remarks>
    /// <seealso href="http://purl.org/net/opmv/ns#wasGeneratedAt">http://purl.org/net/opmv/ns#wasGeneratedAt</seealso>
    let wasGeneratedAt = Prefixed_Name(opmv, "wasGeneratedAt") |> PrefixedName
    /// <summary>
    ///   <para>opmv:wasGeneratedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"wasGeneratedBy is an abstract property to express that an artifact was generated by a process."</para>
    /// labels<para>"wasGeneratedBy"</para></remarks>
    /// <seealso href="http://purl.org/net/opmv/ns#wasGeneratedBy">http://purl.org/net/opmv/ns#wasGeneratedBy</seealso>
    let wasGeneratedBy = Prefixed_Name(opmv, "wasGeneratedBy") |> PrefixedName
    /// <summary>
    ///   <para>opmv:wasPerformedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///       wasPerformedAt is an object property to express that a process was performed at a given time &lt;a xmlns="http://www.w3.org/1999/xhtml" href="http://www.w3.org/2006/time#Instant" xml:lang="en"&gt;instant&lt;/a&gt; or during a given time &lt;a xmlns="http://www.w3.org/1999/xhtml" href="http://www.w3.org/2006/time#Interval" xml:lang="en"&gt;interval&lt;/a&gt;.
    ///     "^^&lt;http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral&gt;</para>
    /// labels<para>"wasPerformedAt"</para></remarks>
    /// <seealso href="http://purl.org/net/opmv/ns#wasPerformedAt">http://purl.org/net/opmv/ns#wasPerformedAt</seealso>
    let wasPerformedAt = Prefixed_Name(opmv, "wasPerformedAt") |> PrefixedName
    /// <summary>
    ///   <para>opmv:wasPerformedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///     wasPerformedBy is an object property to express that a process was performed by an agent. It is a sub-property of &lt;a xmlns="http://www.w3.org/1999/xhtml" href="#wasControlledBy" xml:lang="en"&gt;wasControlledBy&lt;/a&gt;.
    ///   "^^&lt;http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral&gt;</para>
    /// labels<para>"wasPerformedBy"</para></remarks>
    /// <seealso href="http://purl.org/net/opmv/ns#wasPerformedBy">http://purl.org/net/opmv/ns#wasPerformedBy</seealso>
    let wasPerformedBy = Prefixed_Name(opmv, "wasPerformedBy") |> PrefixedName
    /// <summary>
    ///   <para>opmv:wasStartedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///       wasStartedAt is an object property to express that a process was started at a given time &lt;a xmlns="http://www.w3.org/1999/xhtml" href="http://www.w3.org/2006/time#Instant" xml:lang="en"&gt;instant&lt;/a&gt;. The property chain defines that all processes, that were performed during a specific time period which began at a specific instant, were actually started at that specific time instant.
    ///     "^^&lt;http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral&gt;</para>
    /// labels<para>"wasStartedAt"</para></remarks>
    /// <seealso href="http://purl.org/net/opmv/ns#wasStartedAt">http://purl.org/net/opmv/ns#wasStartedAt</seealso>
    let wasStartedAt = Prefixed_Name(opmv, "wasStartedAt") |> PrefixedName
    /// <summary>
    ///   <para>opmv:wasTriggeredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"wasTriggeredBy is an abstract property to express that a process was triggered by another process."</para>
    /// labels<para>"wasTriggeredBy"</para></remarks>
    /// <seealso href="http://purl.org/net/opmv/ns#wasTriggeredBy">http://purl.org/net/opmv/ns#wasTriggeredBy</seealso>
    let wasTriggeredBy = Prefixed_Name(opmv, "wasTriggeredBy") |> PrefixedName
    /// <summary>
    ///   <para>opmv:wasUsedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///     wasUsedAt is an object property to express that an artifact was used at a specific time &lt;a xmlns="http://www.w3.org/1999/xhtml" href="http://www.w3.org/2006/time#Instant" xml:lang="en"&gt;instant&lt;/a&gt;. An artifact might not be used at the starting time of the process that actually consumed it. Hence, we provide a different time-related property to express when an artifact was used."^^&lt;http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral&gt;</para>
    /// labels<para>"wasUsedAt"</para></remarks>
    /// <seealso href="http://purl.org/net/opmv/ns#wasUsedAt">http://purl.org/net/opmv/ns#wasUsedAt</seealso>
    let wasUsedAt = Prefixed_Name(opmv, "wasUsedAt") |> PrefixedName
    /// <summary>
    ///   <para>opmv:withRespectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"
    ///     withRespectOf is an object property to associate a time instant at which an artifact was used or generated with the process that used or generated that artifact. At a very fine-grained distinction, the time when an artifact was used or generated might not be exactly the same as the starting or ending time of the process in which the artifact was involved. The related properties &lt;a xmlns="http://www.w3.org/1999/xhtml" href="#wasUsedAt" xml:lang="en"&gt;opmv:wasUsedAt&lt;/a&gt; and &lt;a xmlns="http://www.w3.org/1999/xhtml" href="#wasGeneratedAt" xml:lang="en"&gt;opmv:wasGeneratedAt&lt;/a&gt; can be used as shortcuts to express time-related information about an artifact. The property  &lt;a xmlns="http://www.w3.org/1999/xhtml" href="#wasUsedAt" xml:lang="en"&gt;opmv:wasUsedAt&lt;/a&gt; is only used when users want to express precisely in which process an artifact was used or generated. It can be omitted in most cases."^^&lt;http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral&gt;</para>
    /// labels<para>"withRespectOf"</para></remarks>
    /// <seealso href="http://purl.org/net/opmv/ns#withRespectOf">http://purl.org/net/opmv/ns#withRespectOf</seealso>
    let withRespectOf = Prefixed_Name(opmv, "withRespectOf") |> PrefixedName
