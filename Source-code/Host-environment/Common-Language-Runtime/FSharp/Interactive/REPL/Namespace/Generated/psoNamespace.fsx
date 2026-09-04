#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pso =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/spar/pso/" "pso"
    let APC_fully_waived = _prefixId.prefix "APC-fully-waived"
    let APC_not_charged = _prefixId.prefix "APC-not-charged"
    let APC_not_required = _prefixId.prefix "APC-not-required"
    let APC_paid = _prefixId.prefix "APC-paid"
    let APC_partially_waived = _prefixId.prefix "APC-partially-waived"
    /// <summary>
    ///   <para>rdfs:label : agent</para>
    ///   <para>rdfs:comment : An entity, such as a person, a group, an organization or a software agent, involved in one or more events.</para>
    ///   <a href="http://purl.org/spar/pso/Agent">pso:Agent</a>
    /// </summary>
    let Agent = _prefixId.prefix "Agent"
    /// <summary>
    ///   <para>rdfs:label : article processing charge status</para>
    ///   <para>rdfs:comment : A state or condition that a document may have that relates to a fee levied by a publisher on an author or an institution to cover the cost of publishing an Open Access journal article.</para>
    ///   <a href="http://purl.org/spar/pso/ArticleProcessingChargeStatus">pso:ArticleProcessingChargeStatus</a>
    /// </summary>
    let ArticleProcessingChargeStatus = _prefixId.prefix "ArticleProcessingChargeStatus"
    /// <summary>
    ///   <para>rdfs:label : publishing status</para>
    ///   <para>rdfs:comment : A state or condition that a document may have that relates to the publication of such document.</para>
    ///   <a href="http://purl.org/spar/pso/PublicationStatus">pso:PublicationStatus</a>
    /// </summary>
    let PublicationStatus = _prefixId.prefix "PublicationStatus"
    /// <summary>
    ///   <para>rdfs:label : status</para>
    ///   <para>rdfs:comment : A state or condition that a document may have.</para>
    ///   <a href="http://purl.org/spar/pso/Status">pso:Status</a>
    /// </summary>
    let Status = _prefixId.prefix "Status"
    /// <summary>
    ///   <para>dce:description : A status in time describes always:
    /// - a particular status S
    /// - a particular document D holding S
    /// - a particular time interval T in which D holds S
    /// - a particular event that causes the acquisition of S by D</para>
    ///   <para>rdfs:label : status in time</para>
    ///   <para>rdfs:comment : A particular situation that describe a state or condition some documents may have at a particular time as consequence of one or more events.</para>
    ///   <a href="http://purl.org/spar/pso/StatusInTime">pso:StatusInTime</a>
    /// </summary>
    let StatusInTime = _prefixId.prefix "StatusInTime"
    let accepted_for_publication = _prefixId.prefix "accepted-for-publication"
    let anonymized = _prefixId.prefix "anonymized"
    let archived = _prefixId.prefix "archived"
    let catalogued = _prefixId.prefix "catalogued"
    let closed_access = _prefixId.prefix "closed-access"
    let confidential = _prefixId.prefix "confidential"
    let copy_edited = _prefixId.prefix "copy-edited"
    let corrected = _prefixId.prefix "corrected"
    let draft = _prefixId.prefix "draft"
    let embargoed = _prefixId.prefix "embargoed"
    let enhanced = _prefixId.prefix "enhanced"
    let final_draft = _prefixId.prefix "final-draft"
    let gold_open_access = _prefixId.prefix "gold-open-access"
    let gratis_open_access = _prefixId.prefix "gratis-open-access"
    let green_open_access = _prefixId.prefix "green-open-access"
    /// <summary>
    ///   <para>rdfs:label : holds status in time</para>
    ///   <para>rdfs:comment : A property relating a document, a dataset or some other thing to a status that it holds at a specific time.</para>
    ///   <a href="http://purl.org/spar/pso/holdsStatusInTime">pso:holdsStatusInTime</a>
    /// </summary>
    let holdsStatusInTime = _prefixId.prefix "holdsStatusInTime"
    let in_press = _prefixId.prefix "in-press"
    let initial_draft = _prefixId.prefix "initial-draft"
    let intermediate_draft = _prefixId.prefix "intermediate-draft"
    /// <summary>
    ///   <para>rdfs:label : is acquired as consequence of</para>
    ///   <para>rdfs:comment : The property relating a particular publishing status to the event that causes its acquisition.</para>
    ///   <a href="http://purl.org/spar/pso/isAcquiredAsConsequenceOf">pso:isAcquiredAsConsequenceOf</a>
    /// </summary>
    let isAcquiredAsConsequenceOf = _prefixId.prefix "isAcquiredAsConsequenceOf"
    /// <summary>
    ///   <para>rdfs:label : is lost as consequence of</para>
    ///   <para>rdfs:comment : The property relating a particular publishing status to the event that causes its loss.</para>
    ///   <a href="http://purl.org/spar/pso/isLostAsConsequenceOf">pso:isLostAsConsequenceOf</a>
    /// </summary>
    let isLostAsConsequenceOf = _prefixId.prefix "isLostAsConsequenceOf"
    /// <summary>
    ///   <para>rdfs:label : is status held by</para>
    ///   <para>rdfs:comment : A property relating a status held at a specific time to the document, dataset or other thing holding that status.</para>
    ///   <a href="http://purl.org/spar/pso/isStatusHeldBy">pso:isStatusHeldBy</a>
    /// </summary>
    let isStatusHeldBy = _prefixId.prefix "isStatusHeldBy"
    /// <summary>
    ///   <para>rdfs:label : is status in</para>
    ///   <para>rdfs:comment : The property relating the definition of a specific status to the situation of the document, a dataset or something else holding that status at a specific time.</para>
    ///   <a href="http://purl.org/spar/pso/isStatusIn">pso:isStatusIn</a>
    /// </summary>
    let isStatusIn = _prefixId.prefix "isStatusIn"
    let libre_open_access = _prefixId.prefix "libre-open-access"
    let non_confidential = _prefixId.prefix "non-confidential"
    let open_access = _prefixId.prefix "open-access"
    let peer_reviewed = _prefixId.prefix "peer-reviewed"
    let proof = _prefixId.prefix "proof"
    let published = _prefixId.prefix "published"
    let rejected_for_publication = _prefixId.prefix "rejected-for-publication"
    let republished = _prefixId.prefix "republished"
    let restricted_access = _prefixId.prefix "restricted-access"
    /// <summary>
    ///   <para>rdfs:label : results in acquiring</para>
    ///   <para>rdfs:comment : The property relating an event to the consequential acquisition of a particular publishing status.</para>
    ///   <a href="http://purl.org/spar/pso/resultsInAcquiring">pso:resultsInAcquiring</a>
    /// </summary>
    let resultsInAcquiring = _prefixId.prefix "resultsInAcquiring"
    /// <summary>
    ///   <para>rdfs:label : results in losing</para>
    ///   <para>rdfs:comment : The property relating an event to the consequential loss of a particular publishing status.</para>
    ///   <a href="http://purl.org/spar/pso/resultsInLosing">pso:resultsInLosing</a>
    /// </summary>
    let resultsInLosing = _prefixId.prefix "resultsInLosing"
    let retracted_from_publication = _prefixId.prefix "retracted-from-publication"
    let reviewed = _prefixId.prefix "reviewed"
    let revised = _prefixId.prefix "revised"
    let submitted = _prefixId.prefix "submitted"
    let subscription_access = _prefixId.prefix "subscription-access"
    let under_review = _prefixId.prefix "under-review"
    let unpublished = _prefixId.prefix "unpublished"
    let version_of_record = _prefixId.prefix "version-of-record"
    /// <summary>
    ///   <para>rdfs:label : with status</para>
    ///   <para>rdfs:comment : The property relating the holding of a status by a document, a dataset or something else at a specific time to the definition of that status.</para>
    ///   <a href="http://purl.org/spar/pso/withStatus">pso:withStatus</a>
    /// </summary>
    let withStatus = _prefixId.prefix "withStatus"
    let withdrawn_from_submission = _prefixId.prefix "withdrawn-from-submission"
