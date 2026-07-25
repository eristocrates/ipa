namespace http.purl.org.swan._2._0.discourse_relationships.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dr =
    let _namespace_iri = Namespace_Iri dr |> NamespaceIRI
    /// <summary>
    ///   <para>dr:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>These relationships don't have range and domains defined as they are meant to be reused in different contexts</para>
    /// labels<para>Discourse relationships vocabulary v. 3.0</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/">http://purl.org/swan/2.0/discourse-relationships/</seealso>
    let _prefix_iri = Prefixed_Name(dr, "") |> PrefixedName
    /// <summary>
    ///   <para>dr:inconsistentWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>It expresses inconsistency between two resources.
    /// 	    		It is a bidirectional relationship</para>
    /// labels<para>inconsistentWith</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/inconsistentWith">http://purl.org/swan/2.0/discourse-relationships/inconsistentWith</seealso>
    let inconsistentWith = Prefixed_Name(dr, "inconsistentWith") |> PrefixedName
    /// <summary>
    ///   <para>dr:arisesFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Something (question, doubt...) that arises because of something else</para>
    /// labels<para>arisesFrom</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/arisesFrom">http://purl.org/swan/2.0/discourse-relationships/arisesFrom</seealso>
    let arisesFrom = Prefixed_Name(dr, "arisesFrom") |> PrefixedName
    /// <summary>
    ///   <para>dr:relatesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The most generic relationship: it expresses connection
    /// 			between two resources without specifying the nature of such connection</para>
    /// labels<para>relatesTo</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/relatesTo">http://purl.org/swan/2.0/discourse-relationships/relatesTo</seealso>
    let relatesTo = Prefixed_Name(dr, "relatesTo") |> PrefixedName

    /// <summary>
    ///   <para>dr:referencesAsInconsistentEvidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para></para>
    /// labels<para>referencesAsInconsistentEvidence</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/referencesAsInconsistentEvidence">http://purl.org/swan/2.0/discourse-relationships/referencesAsInconsistentEvidence</seealso>
    let referencesAsInconsistentEvidence =
        Prefixed_Name(dr, "referencesAsInconsistentEvidence") |> PrefixedName

    /// <summary>
    ///   <para>dr:referencesAsSupportiveEvidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para></para>
    /// labels<para>referencesAsSupportiveEvidence</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/referencesAsSupportiveEvidence">http://purl.org/swan/2.0/discourse-relationships/referencesAsSupportiveEvidence</seealso>
    let referencesAsSupportiveEvidence =
        Prefixed_Name(dr, "referencesAsSupportiveEvidence") |> PrefixedName

    /// <summary>
    ///   <para>dr:referencesAsRelevantEvidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para></para>
    /// labels<para>referencesAsRelevantEvidence</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/referencesAsRelevantEvidence">http://purl.org/swan/2.0/discourse-relationships/referencesAsRelevantEvidence</seealso>
    let referencesAsRelevantEvidence =
        Prefixed_Name(dr, "referencesAsRelevantEvidence") |> PrefixedName

    /// <summary>
    ///   <para>dr:respondsNegativelyTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>It expresses the fact that one entity is talking
    /// 				    		about another one expressing disagreement</para>
    /// labels<para>respondsNegativelyTo</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/respondsNegativelyTo">http://purl.org/swan/2.0/discourse-relationships/respondsNegativelyTo</seealso>
    let respondsNegativelyTo = Prefixed_Name(dr, "respondsNegativelyTo") |> PrefixedName
    /// <summary>
    ///   <para>dr:respondsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para></para>
    /// labels<para>respondsTo</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/respondsTo">http://purl.org/swan/2.0/discourse-relationships/respondsTo</seealso>
    let respondsTo = Prefixed_Name(dr, "respondsTo") |> PrefixedName
    /// <summary>
    ///   <para>dr:alternativeTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>It connects two different resources that can be
    /// 	    		considered alternative interpretations of the same experimental results</para>
    /// labels<para>alternativeTo</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/alternativeTo">http://purl.org/swan/2.0/discourse-relationships/alternativeTo</seealso>
    let alternativeTo = Prefixed_Name(dr, "alternativeTo") |> PrefixedName
    /// <summary>
    ///   <para>dr:refersTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>It connects an entity with another entity in an
    /// 				unidirectional way</para>
    /// labels<para>refersTo</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/refersTo">http://purl.org/swan/2.0/discourse-relationships/refersTo</seealso>
    let refersTo = Prefixed_Name(dr, "refersTo") |> PrefixedName
    /// <summary>
    ///   <para>dr:consistentWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>It expresses consistency between two resources.
    /// 	    		It is a bidirectional relationship</para>
    /// labels<para>consistentWith</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/consistentWith">http://purl.org/swan/2.0/discourse-relationships/consistentWith</seealso>
    let consistentWith = Prefixed_Name(dr, "consistentWith") |> PrefixedName
    /// <summary>
    ///   <para>dr:motivates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Something (hypothesis, doubt...) that motivates something else like an experiment</para>
    /// labels<para>motivates</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/motivates">http://purl.org/swan/2.0/discourse-relationships/motivates</seealso>
    let motivates = Prefixed_Name(dr, "motivates") |> PrefixedName
    /// <summary>
    ///   <para>dr:relevantTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>It expresses the fact that a resource is
    /// 	    		relevant for another one and vice-versa</para>
    /// labels<para>relevantTo</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/relevantTo">http://purl.org/swan/2.0/discourse-relationships/relevantTo</seealso>
    let relevantTo = Prefixed_Name(dr, "relevantTo") |> PrefixedName
    /// <summary>
    ///   <para>dr:respondsNeutrallyTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>It expresses the fact that one entity is
    /// 				    		talking about another one without expressing agreement or disagreement</para>
    /// labels<para>respondsNeutrallyTo</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/respondsNeutrallyTo">http://purl.org/swan/2.0/discourse-relationships/respondsNeutrallyTo</seealso>
    let respondsNeutrallyTo = Prefixed_Name(dr, "respondsNeutrallyTo") |> PrefixedName
    /// <summary>
    ///   <para>dr:respondsPositivelyTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>It expresses the fact that one entity is talking
    /// 				    		about another one expressing agreement</para>
    /// labels<para>respondsPositivelyTo</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/respondsPositivelyTo">http://purl.org/swan/2.0/discourse-relationships/respondsPositivelyTo</seealso>
    let respondsPositivelyTo = Prefixed_Name(dr, "respondsPositivelyTo") |> PrefixedName
