namespace http.purl.org.swan._2._0.discourse_relationships.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dr =
    let _namespace_iri = Namespace_Iri dr |> NamespaceIRI
    /// <summary>
    ///   <para>swan:discourse-relationships/</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"These relationships don't have range and domains defined as they are meant to be reused in different contexts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Discourse relationships vocabulary v. 3.0"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/">http://purl.org/swan/2.0/discourse-relationships/</seealso>
    let _prefix_iri = Prefixed_Name(dr, "") |> PrefixedName
    /// <summary>
    ///   <para>swan:discourse-relationships/alternativeTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"It connects two different resources that can be
    /// 	    		considered alternative interpretations of the same experimental results"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"alternativeTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/alternativeTo">http://purl.org/swan/2.0/discourse-relationships/alternativeTo</seealso>
    let alternativeTo = Prefixed_Name(dr, "alternativeTo") |> PrefixedName
    /// <summary>
    ///   <para>swan:discourse-relationships/arisesFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Something (question, doubt...) that arises because of something else"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"arisesFrom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/arisesFrom">http://purl.org/swan/2.0/discourse-relationships/arisesFrom</seealso>
    let arisesFrom = Prefixed_Name(dr, "arisesFrom") |> PrefixedName
    /// <summary>
    ///   <para>swan:discourse-relationships/consistentWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It expresses consistency between two resources.
    /// 	    		It is a bidirectional relationship"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"consistentWith"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/consistentWith">http://purl.org/swan/2.0/discourse-relationships/consistentWith</seealso>
    let consistentWith = Prefixed_Name(dr, "consistentWith") |> PrefixedName
    /// <summary>
    ///   <para>swan:discourse-relationships/inconsistentWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It expresses inconsistency between two resources.
    /// 	    		It is a bidirectional relationship"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"inconsistentWith"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/inconsistentWith">http://purl.org/swan/2.0/discourse-relationships/inconsistentWith</seealso>
    let inconsistentWith = Prefixed_Name(dr, "inconsistentWith") |> PrefixedName
    /// <summary>
    ///   <para>swan:discourse-relationships/motivates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Something (hypothesis, doubt...) that motivates something else like an experiment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"motivates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/motivates">http://purl.org/swan/2.0/discourse-relationships/motivates</seealso>
    let motivates = Prefixed_Name(dr, "motivates") |> PrefixedName

    /// <summary>
    ///   <para>swan:discourse-relationships/referencesAsInconsistentEvidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"referencesAsInconsistentEvidence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/referencesAsInconsistentEvidence">http://purl.org/swan/2.0/discourse-relationships/referencesAsInconsistentEvidence</seealso>
    let referencesAsInconsistentEvidence =
        Prefixed_Name(dr, "referencesAsInconsistentEvidence") |> PrefixedName

    /// <summary>
    ///   <para>swan:discourse-relationships/referencesAsRelevantEvidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"referencesAsRelevantEvidence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/referencesAsRelevantEvidence">http://purl.org/swan/2.0/discourse-relationships/referencesAsRelevantEvidence</seealso>
    let referencesAsRelevantEvidence =
        Prefixed_Name(dr, "referencesAsRelevantEvidence") |> PrefixedName

    /// <summary>
    ///   <para>swan:discourse-relationships/referencesAsSupportiveEvidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"referencesAsSupportiveEvidence"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/referencesAsSupportiveEvidence">http://purl.org/swan/2.0/discourse-relationships/referencesAsSupportiveEvidence</seealso>
    let referencesAsSupportiveEvidence =
        Prefixed_Name(dr, "referencesAsSupportiveEvidence") |> PrefixedName

    /// <summary>
    ///   <para>swan:discourse-relationships/refersTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It connects an entity with another entity in an
    /// 				unidirectional way"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"refersTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/refersTo">http://purl.org/swan/2.0/discourse-relationships/refersTo</seealso>
    let refersTo = Prefixed_Name(dr, "refersTo") |> PrefixedName
    /// <summary>
    ///   <para>swan:discourse-relationships/relatesTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The most generic relationship: it expresses connection
    /// 			between two resources without specifying the nature of such connection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"relatesTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/relatesTo">http://purl.org/swan/2.0/discourse-relationships/relatesTo</seealso>
    let relatesTo = Prefixed_Name(dr, "relatesTo") |> PrefixedName
    /// <summary>
    ///   <para>swan:discourse-relationships/relevantTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It expresses the fact that a resource is
    /// 	    		relevant for another one and vice-versa"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"relevantTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/relevantTo">http://purl.org/swan/2.0/discourse-relationships/relevantTo</seealso>
    let relevantTo = Prefixed_Name(dr, "relevantTo") |> PrefixedName
    /// <summary>
    ///   <para>swan:discourse-relationships/respondsNegativelyTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It expresses the fact that one entity is talking
    /// 				    		about another one expressing disagreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"respondsNegativelyTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/respondsNegativelyTo">http://purl.org/swan/2.0/discourse-relationships/respondsNegativelyTo</seealso>
    let respondsNegativelyTo = Prefixed_Name(dr, "respondsNegativelyTo") |> PrefixedName
    /// <summary>
    ///   <para>swan:discourse-relationships/respondsNeutrallyTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It expresses the fact that one entity is
    /// 				    		talking about another one without expressing agreement or disagreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"respondsNeutrallyTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/respondsNeutrallyTo">http://purl.org/swan/2.0/discourse-relationships/respondsNeutrallyTo</seealso>
    let respondsNeutrallyTo = Prefixed_Name(dr, "respondsNeutrallyTo") |> PrefixedName
    /// <summary>
    ///   <para>swan:discourse-relationships/respondsPositivelyTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"It expresses the fact that one entity is talking
    /// 				    		about another one expressing agreement"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"respondsPositivelyTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/respondsPositivelyTo">http://purl.org/swan/2.0/discourse-relationships/respondsPositivelyTo</seealso>
    let respondsPositivelyTo = Prefixed_Name(dr, "respondsPositivelyTo") |> PrefixedName
    /// <summary>
    ///   <para>swan:discourse-relationships/respondsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"respondsTo"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/swan/2.0/discourse-relationships/respondsTo">http://purl.org/swan/2.0/discourse-relationships/respondsTo</seealso>
    let respondsTo = Prefixed_Name(dr, "respondsTo") |> PrefixedName
