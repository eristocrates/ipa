namespace http.purl.org.swan._2._0.discourse_relationships.slash

open DoxAletheia

module dr =
    let _namespace_name = "http://purl.org/swan/2.0/discourse-relationships/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// It connects two different resources that can be
    /// 	    		considered alternative interpretations of the same experimental results
    /// <see href="http://purl.org/swan/2.0/discourse-relationships/alternativeTo"></see></summary>
    let alternativeTo = _prefix "alternativeTo"
    /// <summary>
    /// The most generic relationship: it expresses connection
    /// 			between two resources without specifying the nature of such connection
    /// <see href="http://purl.org/swan/2.0/discourse-relationships/relatesTo"></see></summary>
    let relatesTo = _prefix "relatesTo"
    /// <summary>
    /// Something (question, doubt...) that arises because of something else
    /// <see href="http://purl.org/swan/2.0/discourse-relationships/arisesFrom"></see></summary>
    let arisesFrom = _prefix "arisesFrom"
    /// <summary>
    /// It connects an entity with another entity in an
    /// 				unidirectional way
    /// <see href="http://purl.org/swan/2.0/discourse-relationships/refersTo"></see></summary>
    let refersTo = _prefix "refersTo"
    /// <summary>
    /// It expresses consistency between two resources.
    /// 	    		It is a bidirectional relationship
    /// <see href="http://purl.org/swan/2.0/discourse-relationships/consistentWith"></see></summary>
    let consistentWith = _prefix "consistentWith"
    /// <summary>
    /// It expresses inconsistency between two resources.
    /// 	    		It is a bidirectional relationship
    /// <see href="http://purl.org/swan/2.0/discourse-relationships/inconsistentWith"></see></summary>
    let inconsistentWith = _prefix "inconsistentWith"
    /// <summary>
    /// Something (hypothesis, doubt...) that motivates something else like an experiment
    /// <see href="http://purl.org/swan/2.0/discourse-relationships/motivates"></see></summary>
    let motivates = _prefix "motivates"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/discourse-relationships/referencesAsInconsistentEvidence"></see>
    /// </summary>
    let referencesAsInconsistentEvidence = _prefix "referencesAsInconsistentEvidence"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/discourse-relationships/referencesAsRelevantEvidence"></see>
    /// </summary>
    let referencesAsRelevantEvidence = _prefix "referencesAsRelevantEvidence"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/discourse-relationships/referencesAsSupportiveEvidence"></see>
    /// </summary>
    let referencesAsSupportiveEvidence = _prefix "referencesAsSupportiveEvidence"
    /// <summary>
    /// It expresses the fact that a resource is
    /// 	    		relevant for another one and vice-versa
    /// <see href="http://purl.org/swan/2.0/discourse-relationships/relevantTo"></see></summary>
    let relevantTo = _prefix "relevantTo"
    /// <summary>
    /// It expresses the fact that one entity is talking
    /// 				    		about another one expressing disagreement
    /// <see href="http://purl.org/swan/2.0/discourse-relationships/respondsNegativelyTo"></see></summary>
    let respondsNegativelyTo = _prefix "respondsNegativelyTo"
    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/discourse-relationships/respondsTo"></see>
    /// </summary>
    let respondsTo = _prefix "respondsTo"
    /// <summary>
    /// It expresses the fact that one entity is
    /// 				    		talking about another one without expressing agreement or disagreement
    /// <see href="http://purl.org/swan/2.0/discourse-relationships/respondsNeutrallyTo"></see></summary>
    let respondsNeutrallyTo = _prefix "respondsNeutrallyTo"
    /// <summary>
    /// It expresses the fact that one entity is talking
    /// 				    		about another one expressing agreement
    /// <see href="http://purl.org/swan/2.0/discourse-relationships/respondsPositivelyTo"></see></summary>
    let respondsPositivelyTo = _prefix "respondsPositivelyTo"
