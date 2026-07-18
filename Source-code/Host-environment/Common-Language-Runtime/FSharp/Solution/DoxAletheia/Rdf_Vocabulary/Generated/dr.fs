namespace http.purl.org.swan._2._0.discourse_relationships.slash

open DoxAletheia.Rdf_Vocabulary

module dr =
    let _namespace_name = "http://purl.org/swan/2.0/discourse-relationships/"

    /// <summary>
    /// It connects two different resources that can be
    /// 	    		considered alternative interpretations of the same experimental results
    /// <see href="http://purl.org/swan/2.0/discourse-relationships/alternativeTo"></see></summary>
    let alternativeTo =
        Namespaced_IRI.parse _namespace_name "alternativeTo" |> NamespacedName

    /// <summary>
    /// The most generic relationship: it expresses connection
    /// 			between two resources without specifying the nature of such connection
    /// <see href="http://purl.org/swan/2.0/discourse-relationships/relatesTo"></see></summary>
    let relatesTo = Namespaced_IRI.parse _namespace_name "relatesTo" |> NamespacedName
    /// <summary>
    /// Something (question, doubt...) that arises because of something else
    /// <see href="http://purl.org/swan/2.0/discourse-relationships/arisesFrom"></see></summary>
    let arisesFrom = Namespaced_IRI.parse _namespace_name "arisesFrom" |> NamespacedName
    /// <summary>
    /// It connects an entity with another entity in an
    /// 				unidirectional way
    /// <see href="http://purl.org/swan/2.0/discourse-relationships/refersTo"></see></summary>
    let refersTo = Namespaced_IRI.parse _namespace_name "refersTo" |> NamespacedName

    /// <summary>
    /// It expresses consistency between two resources.
    /// 	    		It is a bidirectional relationship
    /// <see href="http://purl.org/swan/2.0/discourse-relationships/consistentWith"></see></summary>
    let consistentWith =
        Namespaced_IRI.parse _namespace_name "consistentWith" |> NamespacedName

    /// <summary>
    /// It expresses inconsistency between two resources.
    /// 	    		It is a bidirectional relationship
    /// <see href="http://purl.org/swan/2.0/discourse-relationships/inconsistentWith"></see></summary>
    let inconsistentWith =
        Namespaced_IRI.parse _namespace_name "inconsistentWith" |> NamespacedName

    /// <summary>
    /// Something (hypothesis, doubt...) that motivates something else like an experiment
    /// <see href="http://purl.org/swan/2.0/discourse-relationships/motivates"></see></summary>
    let motivates = Namespaced_IRI.parse _namespace_name "motivates" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/discourse-relationships/referencesAsInconsistentEvidence"></see>
    /// </summary>
    let referencesAsInconsistentEvidence =
        Namespaced_IRI.parse _namespace_name "referencesAsInconsistentEvidence" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/discourse-relationships/referencesAsRelevantEvidence"></see>
    /// </summary>
    let referencesAsRelevantEvidence =
        Namespaced_IRI.parse _namespace_name "referencesAsRelevantEvidence" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/discourse-relationships/referencesAsSupportiveEvidence"></see>
    /// </summary>
    let referencesAsSupportiveEvidence =
        Namespaced_IRI.parse _namespace_name "referencesAsSupportiveEvidence" |> NamespacedName

    /// <summary>
    /// It expresses the fact that a resource is
    /// 	    		relevant for another one and vice-versa
    /// <see href="http://purl.org/swan/2.0/discourse-relationships/relevantTo"></see></summary>
    let relevantTo = Namespaced_IRI.parse _namespace_name "relevantTo" |> NamespacedName

    /// <summary>
    /// It expresses the fact that one entity is talking
    /// 				    		about another one expressing disagreement
    /// <see href="http://purl.org/swan/2.0/discourse-relationships/respondsNegativelyTo"></see></summary>
    let respondsNegativelyTo =
        Namespaced_IRI.parse _namespace_name "respondsNegativelyTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/swan/2.0/discourse-relationships/respondsTo"></see>
    /// </summary>
    let respondsTo = Namespaced_IRI.parse _namespace_name "respondsTo" |> NamespacedName

    /// <summary>
    /// It expresses the fact that one entity is
    /// 				    		talking about another one without expressing agreement or disagreement
    /// <see href="http://purl.org/swan/2.0/discourse-relationships/respondsNeutrallyTo"></see></summary>
    let respondsNeutrallyTo =
        Namespaced_IRI.parse _namespace_name "respondsNeutrallyTo" |> NamespacedName

    /// <summary>
    /// It expresses the fact that one entity is talking
    /// 				    		about another one expressing agreement
    /// <see href="http://purl.org/swan/2.0/discourse-relationships/respondsPositivelyTo"></see></summary>
    let respondsPositivelyTo =
        Namespaced_IRI.parse _namespace_name "respondsPositivelyTo" |> NamespacedName
