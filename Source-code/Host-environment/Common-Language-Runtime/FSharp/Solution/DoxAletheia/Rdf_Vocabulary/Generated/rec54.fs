namespace http.www.w3.org._2001._02pd.rec54.hash

open DoxAletheia

module rec54 =
    let _namespace_name = "http://www.w3.org/2001/02pd/rec54#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#APreview"></see>
    /// </summary>
    let APreview = _prefix "APreview"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#ACaction"></see>
    /// </summary>
    let ACaction = _prefix "ACaction"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#cites"></see>
    /// </summary>
    let cites = _prefix "cites"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#OrgJoins"></see>
    /// </summary>
    let OrgJoins = _prefix "OrgJoins"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#ActivityProposal"></see>
    /// </summary>
    let ActivityProposal = _prefix "ActivityProposal"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#ActivityCreation"></see>
    /// </summary>
    let ActivityCreation = _prefix "ActivityCreation"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#ACnotice"></see>
    /// </summary>
    let ACnotice = _prefix "ACnotice"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#effect"></see>
    /// </summary>
    let effect = _prefix "effect"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#ActivityStatement"></see>
    /// </summary>
    let ActivityStatement = _prefix "ActivityStatement"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#CFI"></see>
    /// </summary>
    let CFI = _prefix "CFI"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#CRreq"></see>
    /// </summary>
    let CRreq = _prefix "CRreq"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#CR"></see>
    /// </summary>
    let CR = _prefix "CR"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#CFP"></see>
    /// </summary>
    let CFP = _prefix "CFP"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#Charter"></see>
    /// </summary>
    let Charter = _prefix "Charter"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#CFR"></see>
    /// </summary>
    let CFR = _prefix "CFR"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#PRreq"></see>
    /// </summary>
    let PRreq = _prefix "PRreq"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#PR"></see>
    /// </summary>
    let PR = _prefix "PR"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#TRPub"></see>
    /// </summary>
    let TRPub = _prefix "TRPub"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#WD"></see>
    /// </summary>
    let WD = _prefix "WD"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#WGAction"></see>
    /// </summary>
    let WGAction = _prefix "WGAction"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#LastCall"></see>
    /// </summary>
    let LastCall = _prefix "LastCall"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#ED"></see>
    /// </summary>
    let ED = _prefix "ED"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#FirstEdition"></see>
    /// </summary>
    let FirstEdition = _prefix "FirstEdition"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#REC"></see>
    /// </summary>
    let REC = _prefix "REC"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#ImpEvidence"></see>
    /// </summary>
    let ImpEvidence = _prefix "ImpEvidence"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#LCann"></see>
    /// </summary>
    let LCann = _prefix "LCann"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#NOTE"></see>
    /// </summary>
    let NOTE = _prefix "NOTE"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#PER"></see>
    /// </summary>
    let PER = _prefix "PER"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#PRReview"></see>
    /// </summary>
    let PRReview = _prefix "PRReview"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#RECdd"></see>
    /// </summary>
    let RECdd = _prefix "RECdd"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#RSCND"></see>
    /// </summary>
    let RSCND = _prefix "RSCND"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#Retired"></see>
    /// </summary>
    let Retired = _prefix "Retired"
    /// <summary>
    /// Another work has superseded this one, which should not be considered as current any more.
    /// <see href="http://www.w3.org/2001/02pd/rec54#Superseded"></see></summary>
    let Superseded = _prefix "Superseded"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#WDreq"></see>
    /// </summary>
    let WDreq = _prefix "WDreq"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#editor"></see>
    /// </summary>
    let editor = _prefix "editor"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#formerShortname"></see>
    /// </summary>
    let formerShortname = _prefix "formerShortname"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#fromSubmission"></see>
    /// </summary>
    let fromSubmission = _prefix "fromSubmission"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#implementationFeedbackDue"></see>
    /// </summary>
    let implementationFeedbackDue = _prefix "implementationFeedbackDue"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#lastCallFeedBackDue"></see>
    /// </summary>
    let lastCallFeedBackDue = _prefix "lastCallFeedBackDue"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#nomination"></see>
    /// </summary>
    let nomination = _prefix "nomination"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#participation"></see>
    /// </summary>
    let participation = _prefix "participation"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#patentRules"></see>
    /// </summary>
    let patentRules = _prefix "patentRules"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#prReviewsDue"></see>
    /// </summary>
    let prReviewsDue = _prefix "prReviewsDue"
    /// <summary>
    ///   <see href="http://www.w3.org/2001/02pd/rec54#previousEdition"></see>
    /// </summary>
    let previousEdition = _prefix "previousEdition"
    /// <summary>
    /// Specs that shouldn't be used anymore because a newer one is available
    /// <see href="http://www.w3.org/2001/02pd/rec54#replaces"></see></summary>
    let replaces = _prefix "replaces"
    /// <summary>
    /// this Work supersedes what was one in that Work
    /// <see href="http://www.w3.org/2001/02pd/rec54#supersedes"></see></summary>
    let supersedes = _prefix "supersedes"
