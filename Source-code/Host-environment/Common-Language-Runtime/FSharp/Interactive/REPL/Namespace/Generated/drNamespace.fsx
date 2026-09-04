#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dr =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/swan/2.0/discourse-relationships/" "dr"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : It connects two different resources that can be
    /// 	    		considered alternative interpretations of the same experimental results^^xsd:string</para>
    ///   <para>rdfs:label : alternativeTo^^xsd:string</para>
    ///   <a href="http://purl.org/swan/2.0/discourse-relationships/alternativeTo">dr:alternativeTo</a>
    /// </summary>
    let alternativeTo = _prefixId.prefix "alternativeTo"
    /// <summary>
    ///   <para>rdfs:comment : Something (question, doubt...) that arises because of something else^^xsd:string</para>
    ///   <para>rdfs:label : arisesFrom^^xsd:string</para>
    ///   <a href="http://purl.org/swan/2.0/discourse-relationships/arisesFrom">dr:arisesFrom</a>
    /// </summary>
    let arisesFrom = _prefixId.prefix "arisesFrom"
    /// <summary>
    ///   <para>rdfs:comment : It expresses consistency between two resources.
    /// 	    		It is a bidirectional relationship^^xsd:string</para>
    ///   <para>rdfs:label : consistentWith^^xsd:string</para>
    ///   <a href="http://purl.org/swan/2.0/discourse-relationships/consistentWith">dr:consistentWith</a>
    /// </summary>
    let consistentWith = _prefixId.prefix "consistentWith"
    /// <summary>
    ///   <para>rdfs:comment : It expresses inconsistency between two resources.
    /// 	    		It is a bidirectional relationship^^xsd:string</para>
    ///   <para>rdfs:label : inconsistentWith^^xsd:string</para>
    ///   <a href="http://purl.org/swan/2.0/discourse-relationships/inconsistentWith">dr:inconsistentWith</a>
    /// </summary>
    let inconsistentWith = _prefixId.prefix "inconsistentWith"
    /// <summary>
    ///   <para>rdfs:comment : Something (hypothesis, doubt...) that motivates something else like an experiment^^xsd:string</para>
    ///   <para>rdfs:label : motivates^^xsd:string</para>
    ///   <a href="http://purl.org/swan/2.0/discourse-relationships/motivates">dr:motivates</a>
    /// </summary>
    let motivates = _prefixId.prefix "motivates"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : referencesAsInconsistentEvidence^^xsd:string</para>
    ///   <a href="http://purl.org/swan/2.0/discourse-relationships/referencesAsInconsistentEvidence">dr:referencesAsInconsistentEvidence</a>
    /// </summary>
    let referencesAsInconsistentEvidence =
        _prefixId.prefix "referencesAsInconsistentEvidence"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : referencesAsRelevantEvidence^^xsd:string</para>
    ///   <a href="http://purl.org/swan/2.0/discourse-relationships/referencesAsRelevantEvidence">dr:referencesAsRelevantEvidence</a>
    /// </summary>
    let referencesAsRelevantEvidence = _prefixId.prefix "referencesAsRelevantEvidence"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : referencesAsSupportiveEvidence^^xsd:string</para>
    ///   <a href="http://purl.org/swan/2.0/discourse-relationships/referencesAsSupportiveEvidence">dr:referencesAsSupportiveEvidence</a>
    /// </summary>
    let referencesAsSupportiveEvidence =
        _prefixId.prefix "referencesAsSupportiveEvidence"

    /// <summary>
    ///   <para>rdfs:comment : It connects an entity with another entity in an
    /// 				unidirectional way^^xsd:string</para>
    ///   <para>rdfs:label : refersTo^^xsd:string</para>
    ///   <a href="http://purl.org/swan/2.0/discourse-relationships/refersTo">dr:refersTo</a>
    /// </summary>
    let refersTo = _prefixId.prefix "refersTo"
    /// <summary>
    ///   <para>rdfs:comment : The most generic relationship: it expresses connection
    /// 			between two resources without specifying the nature of such connection^^xsd:string</para>
    ///   <para>rdfs:label : relatesTo^^xsd:string</para>
    ///   <a href="http://purl.org/swan/2.0/discourse-relationships/relatesTo">dr:relatesTo</a>
    /// </summary>
    let relatesTo = _prefixId.prefix "relatesTo"
    /// <summary>
    ///   <para>rdfs:comment : It expresses the fact that a resource is
    /// 	    		relevant for another one and vice-versa^^xsd:string</para>
    ///   <para>rdfs:label : relevantTo^^xsd:string</para>
    ///   <a href="http://purl.org/swan/2.0/discourse-relationships/relevantTo">dr:relevantTo</a>
    /// </summary>
    let relevantTo = _prefixId.prefix "relevantTo"
    /// <summary>
    ///   <para>rdfs:comment : It expresses the fact that one entity is talking
    /// 				    		about another one expressing disagreement^^xsd:string</para>
    ///   <para>rdfs:label : respondsNegativelyTo^^xsd:string</para>
    ///   <a href="http://purl.org/swan/2.0/discourse-relationships/respondsNegativelyTo">dr:respondsNegativelyTo</a>
    /// </summary>
    let respondsNegativelyTo = _prefixId.prefix "respondsNegativelyTo"
    /// <summary>
    ///   <para>rdfs:comment : It expresses the fact that one entity is
    /// 				    		talking about another one without expressing agreement or disagreement^^xsd:string</para>
    ///   <para>rdfs:label : respondsNeutrallyTo^^xsd:string</para>
    ///   <a href="http://purl.org/swan/2.0/discourse-relationships/respondsNeutrallyTo">dr:respondsNeutrallyTo</a>
    /// </summary>
    let respondsNeutrallyTo = _prefixId.prefix "respondsNeutrallyTo"
    /// <summary>
    ///   <para>rdfs:comment : It expresses the fact that one entity is talking
    /// 				    		about another one expressing agreement^^xsd:string</para>
    ///   <para>rdfs:label : respondsPositivelyTo^^xsd:string</para>
    ///   <a href="http://purl.org/swan/2.0/discourse-relationships/respondsPositivelyTo">dr:respondsPositivelyTo</a>
    /// </summary>
    let respondsPositivelyTo = _prefixId.prefix "respondsPositivelyTo"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : respondsTo^^xsd:string</para>
    ///   <a href="http://purl.org/swan/2.0/discourse-relationships/respondsTo">dr:respondsTo</a>
    /// </summary>
    let respondsTo = _prefixId.prefix "respondsTo"
