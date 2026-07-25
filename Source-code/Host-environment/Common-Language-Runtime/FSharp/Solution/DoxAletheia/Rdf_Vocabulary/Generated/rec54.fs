namespace http.www.w3.org._2001._02pd.rec54.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module rec54 =
    let _namespace_iri = Namespace_Iri rec54 |> NamespaceIRI
    /// <summary>
    ///   <para>rec54:APreview</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>A.P. review</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#APreview">http://www.w3.org/2001/02pd/rec54#APreview</seealso>
    let APreview = Prefixed_Name(rec54, "APreview") |> PrefixedName
    /// <summary>
    ///   <para>rec54:OrgJoins</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Org. Joins</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#OrgJoins">http://www.w3.org/2001/02pd/rec54#OrgJoins</seealso>
    let OrgJoins = Prefixed_Name(rec54, "OrgJoins") |> PrefixedName
    /// <summary>
    ///   <para>rec54:ActivityProposal</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Activity Proposal</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#ActivityProposal">http://www.w3.org/2001/02pd/rec54#ActivityProposal</seealso>
    let ActivityProposal = Prefixed_Name(rec54, "ActivityProposal") |> PrefixedName
    /// <summary>
    ///   <para>rec54:ACnotice</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#ACnotice">http://www.w3.org/2001/02pd/rec54#ACnotice</seealso>
    let ACnotice = Prefixed_Name(rec54, "ACnotice") |> PrefixedName
    /// <summary>
    ///   <para>rec54:ActivityStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Activity Statement</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#ActivityStatement">http://www.w3.org/2001/02pd/rec54#ActivityStatement</seealso>
    let ActivityStatement = Prefixed_Name(rec54, "ActivityStatement") |> PrefixedName
    /// <summary>
    ///   <para>rec54:CRreq</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>CR req.</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#CRreq">http://www.w3.org/2001/02pd/rec54#CRreq</seealso>
    let CRreq = Prefixed_Name(rec54, "CRreq") |> PrefixedName
    /// <summary>
    ///   <para>rec54:PRreq</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>PR req.</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#PRreq">http://www.w3.org/2001/02pd/rec54#PRreq</seealso>
    let PRreq = Prefixed_Name(rec54, "PRreq") |> PrefixedName
    /// <summary>
    ///   <para>rec54:PR</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>W3C Proposed Reccommendation</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#PR">http://www.w3.org/2001/02pd/rec54#PR</seealso>
    let PR = Prefixed_Name(rec54, "PR") |> PrefixedName
    /// <summary>
    ///   <para>rec54:ED</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Editor's draft</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#ED">http://www.w3.org/2001/02pd/rec54#ED</seealso>
    let ED = Prefixed_Name(rec54, "ED") |> PrefixedName
    /// <summary>
    ///   <para>rec54:REC</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>W3C Recommendation</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#REC">http://www.w3.org/2001/02pd/rec54#REC</seealso>
    let REC = Prefixed_Name(rec54, "REC") |> PrefixedName
    /// <summary>
    ///   <para>rec54:ImpEvidence</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Impl. Evidence</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#ImpEvidence">http://www.w3.org/2001/02pd/rec54#ImpEvidence</seealso>
    let ImpEvidence = Prefixed_Name(rec54, "ImpEvidence") |> PrefixedName
    /// <summary>
    ///   <para>rec54:LCann</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Last Call Ann.</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#LCann">http://www.w3.org/2001/02pd/rec54#LCann</seealso>
    let LCann = Prefixed_Name(rec54, "LCann") |> PrefixedName
    /// <summary>
    ///   <para>rec54:RECdd</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Rec. dd</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#RECdd">http://www.w3.org/2001/02pd/rec54#RECdd</seealso>
    let RECdd = Prefixed_Name(rec54, "RECdd") |> PrefixedName
    /// <summary>
    ///   <para>rec54:Superseded</para>
    /// </summary>
    /// <remarks>
    ///   <para>Another work has superseded this one, which should not be considered as current any more.</para>
    /// labels<para>supersed Work</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#Superseded">http://www.w3.org/2001/02pd/rec54#Superseded</seealso>
    let Superseded = Prefixed_Name(rec54, "Superseded") |> PrefixedName
    /// <summary>
    ///   <para>rec54:WDreq</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>WD req.</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#WDreq">http://www.w3.org/2001/02pd/rec54#WDreq</seealso>
    let WDreq = Prefixed_Name(rec54, "WDreq") |> PrefixedName
    /// <summary>
    ///   <para>rec54:formerShortname</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>former short name</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#formerShortname">http://www.w3.org/2001/02pd/rec54#formerShortname</seealso>
    let formerShortname = Prefixed_Name(rec54, "formerShortname") |> PrefixedName

    /// <summary>
    ///   <para>rec54:lastCallFeedBackDue</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>last call feedbackdue</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#lastCallFeedBackDue">http://www.w3.org/2001/02pd/rec54#lastCallFeedBackDue</seealso>
    let lastCallFeedBackDue =
        Prefixed_Name(rec54, "lastCallFeedBackDue") |> PrefixedName

    /// <summary>
    ///   <para>rec54:nomination</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>nomination</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#nomination">http://www.w3.org/2001/02pd/rec54#nomination</seealso>
    let nomination = Prefixed_Name(rec54, "nomination") |> PrefixedName
    /// <summary>
    ///   <para>rec54:prReviewsDue</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>proposed recommendation feedback due</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#prReviewsDue">http://www.w3.org/2001/02pd/rec54#prReviewsDue</seealso>
    let prReviewsDue = Prefixed_Name(rec54, "prReviewsDue") |> PrefixedName
    /// <summary>
    ///   <para>rec54:previousEdition</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>previous edition</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#previousEdition">http://www.w3.org/2001/02pd/rec54#previousEdition</seealso>
    let previousEdition = Prefixed_Name(rec54, "previousEdition") |> PrefixedName
    /// <summary>
    ///   <para>rec54:replaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>Specs that shouldn't be used anymore because a newer one is available</para>
    /// labels<para>replaces</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#replaces">http://www.w3.org/2001/02pd/rec54#replaces</seealso>
    let replaces = Prefixed_Name(rec54, "replaces") |> PrefixedName
    /// <summary>
    ///   <para>rec54:ACaction</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#ACaction">http://www.w3.org/2001/02pd/rec54#ACaction</seealso>
    let ACaction = Prefixed_Name(rec54, "ACaction") |> PrefixedName
    /// <summary>
    ///   <para>rec54:effect</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>has an effect on</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#effect">http://www.w3.org/2001/02pd/rec54#effect</seealso>
    let effect = Prefixed_Name(rec54, "effect") |> PrefixedName
    /// <summary>
    ///   <para>rec54:CFP</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>CFP</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#CFP">http://www.w3.org/2001/02pd/rec54#CFP</seealso>
    let CFP = Prefixed_Name(rec54, "CFP") |> PrefixedName
    /// <summary>
    ///   <para>rec54:RSCND</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>W3C Rescinded Recommendation</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#RSCND">http://www.w3.org/2001/02pd/rec54#RSCND</seealso>
    let RSCND = Prefixed_Name(rec54, "RSCND") |> PrefixedName
    /// <summary>
    ///   <para>rec54:participation</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>participation</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#participation">http://www.w3.org/2001/02pd/rec54#participation</seealso>
    let participation = Prefixed_Name(rec54, "participation") |> PrefixedName
    /// <summary>
    ///   <para>rec54:supersedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>this Work supersedes what was one in that Work</para>
    /// labels<para>supersedes</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#supersedes">http://www.w3.org/2001/02pd/rec54#supersedes</seealso>
    let supersedes = Prefixed_Name(rec54, "supersedes") |> PrefixedName
    /// <summary>
    ///   <para>rec54:CR</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Candidate Recommendation</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#CR">http://www.w3.org/2001/02pd/rec54#CR</seealso>
    let CR = Prefixed_Name(rec54, "CR") |> PrefixedName
    /// <summary>
    ///   <para>rec54:PRReview</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>PR review</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#PRReview">http://www.w3.org/2001/02pd/rec54#PRReview</seealso>
    let PRReview = Prefixed_Name(rec54, "PRReview") |> PrefixedName

    /// <summary>
    ///   <para>rec54:implementationFeedbackDue</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>implementation feedback due</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#implementationFeedbackDue">http://www.w3.org/2001/02pd/rec54#implementationFeedbackDue</seealso>
    let implementationFeedbackDue =
        Prefixed_Name(rec54, "implementationFeedbackDue") |> PrefixedName

    /// <summary>
    ///   <para>rec54:patentRules</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>governed by patent rules</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#patentRules">http://www.w3.org/2001/02pd/rec54#patentRules</seealso>
    let patentRules = Prefixed_Name(rec54, "patentRules") |> PrefixedName
    /// <summary>
    ///   <para>rec54:CFR</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Call for Review</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#CFR">http://www.w3.org/2001/02pd/rec54#CFR</seealso>
    let CFR = Prefixed_Name(rec54, "CFR") |> PrefixedName
    /// <summary>
    ///   <para>rec54:fromSubmission</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>published per Member Submission request</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#fromSubmission">http://www.w3.org/2001/02pd/rec54#fromSubmission</seealso>
    let fromSubmission = Prefixed_Name(rec54, "fromSubmission") |> PrefixedName
    /// <summary>
    ///   <para>rec54:FirstEdition</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>first Edition of a Recommendation</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#FirstEdition">http://www.w3.org/2001/02pd/rec54#FirstEdition</seealso>
    let FirstEdition = Prefixed_Name(rec54, "FirstEdition") |> PrefixedName
    /// <summary>
    ///   <para>rec54:PER</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>W3C Proposed Edited Recommendation</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#PER">http://www.w3.org/2001/02pd/rec54#PER</seealso>
    let PER = Prefixed_Name(rec54, "PER") |> PrefixedName
    /// <summary>
    ///   <para>rec54:Retired</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>WD not longer in development</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#Retired">http://www.w3.org/2001/02pd/rec54#Retired</seealso>
    let Retired = Prefixed_Name(rec54, "Retired") |> PrefixedName
    /// <summary>
    ///   <para>rec54:editor</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>editor</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#editor">http://www.w3.org/2001/02pd/rec54#editor</seealso>
    let editor = Prefixed_Name(rec54, "editor") |> PrefixedName
    /// <summary>
    ///   <para>rec54:</para>
    /// </summary>
    /// <remarks>
    ///   <para>$Id: rec54.rdf,v 1.20 2014-06-12 11:03:50 denis Exp $</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#">http://www.w3.org/2001/02pd/rec54#</seealso>
    let _prefix_iri = Prefixed_Name(rec54, "") |> PrefixedName
    /// <summary>
    ///   <para>rec54:cites</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>cites</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#cites">http://www.w3.org/2001/02pd/rec54#cites</seealso>
    let cites = Prefixed_Name(rec54, "cites") |> PrefixedName
    /// <summary>
    ///   <para>rec54:ActivityCreation</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Activity Creation</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#ActivityCreation">http://www.w3.org/2001/02pd/rec54#ActivityCreation</seealso>
    let ActivityCreation = Prefixed_Name(rec54, "ActivityCreation") |> PrefixedName
    /// <summary>
    ///   <para>rec54:CFI</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>CFI</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#CFI">http://www.w3.org/2001/02pd/rec54#CFI</seealso>
    let CFI = Prefixed_Name(rec54, "CFI") |> PrefixedName
    /// <summary>
    ///   <para>rec54:Charter</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>charter</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#Charter">http://www.w3.org/2001/02pd/rec54#Charter</seealso>
    let Charter = Prefixed_Name(rec54, "Charter") |> PrefixedName
    /// <summary>
    ///   <para>rec54:TRPub</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>a W3C Technical Report</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#TRPub">http://www.w3.org/2001/02pd/rec54#TRPub</seealso>
    let TRPub = Prefixed_Name(rec54, "TRPub") |> PrefixedName
    /// <summary>
    ///   <para>rec54:WD</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>W3C Working Draft</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#WD">http://www.w3.org/2001/02pd/rec54#WD</seealso>
    let WD = Prefixed_Name(rec54, "WD") |> PrefixedName
    /// <summary>
    ///   <para>rec54:WGAction</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#WGAction">http://www.w3.org/2001/02pd/rec54#WGAction</seealso>
    let WGAction = Prefixed_Name(rec54, "WGAction") |> PrefixedName
    /// <summary>
    ///   <para>rec54:LastCall</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>a WD in Last Call</para><para>Last Call WD</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#LastCall">http://www.w3.org/2001/02pd/rec54#LastCall</seealso>
    let LastCall = Prefixed_Name(rec54, "LastCall") |> PrefixedName
    /// <summary>
    ///   <para>rec54:NOTE</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>W3C Note</para></remarks>
    /// <seealso href="http://www.w3.org/2001/02pd/rec54#NOTE">http://www.w3.org/2001/02pd/rec54#NOTE</seealso>
    let NOTE = Prefixed_Name(rec54, "NOTE") |> PrefixedName
