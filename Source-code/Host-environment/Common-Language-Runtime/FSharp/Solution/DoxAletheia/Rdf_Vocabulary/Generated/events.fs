namespace http.eulersharp.sourceforge.net._2003._03swap._event.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module events =
    let _namespace_iri = Namespace_Iri events |> NamespaceIRI
    /// <summary>
    ///   <para>events:hasOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOutput">http://eulersharp.sourceforge.net/2003/03swap/event#hasOutput</seealso>
    let hasOutput = Prefixed_Name(events, "hasOutput") |> PrefixedName
    /// <summary>
    ///   <para>events:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>event</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Event">http://eulersharp.sourceforge.net/2003/03swap/event#Event</seealso>
    let Event = Prefixed_Name(events, "Event") |> PrefixedName
    /// <summary>
    ///   <para>events:AvailabilityState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>availability state</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#AvailabilityState">http://eulersharp.sourceforge.net/2003/03swap/event#AvailabilityState</seealso>
    let AvailabilityState = Prefixed_Name(events, "AvailabilityState") |> PrefixedName
    /// <summary>
    ///   <para>events:Biphasic</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:CourseMode</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>biphasic</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Biphasic">http://eulersharp.sourceforge.net/2003/03swap/event#Biphasic</seealso>
    let Biphasic = Prefixed_Name(events, "Biphasic") |> PrefixedName
    /// <summary>
    ///   <para>events:Cause</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>cause</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Cause">http://eulersharp.sourceforge.net/2003/03swap/event#Cause</seealso>
    let Cause = Prefixed_Name(events, "Cause") |> PrefixedName
    /// <summary>
    ///   <para>events:Causing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>causing</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Causing">http://eulersharp.sourceforge.net/2003/03swap/event#Causing</seealso>
    let Causing = Prefixed_Name(events, "Causing") |> PrefixedName
    /// <summary>
    ///   <para>events:Effect</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>effect</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Effect">http://eulersharp.sourceforge.net/2003/03swap/event#Effect</seealso>
    let Effect = Prefixed_Name(events, "Effect") |> PrefixedName
    /// <summary>
    ///   <para>events:Certain</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:OutputLikelihood</para>
    ///
    /// labels<para>certain</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Certain">http://eulersharp.sourceforge.net/2003/03swap/event#Certain</seealso>
    let Certain = Prefixed_Name(events, "Certain") |> PrefixedName
    /// <summary>
    ///   <para>events:OutputLikelihood</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>output likelihood</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#OutputLikelihood">http://eulersharp.sourceforge.net/2003/03swap/event#OutputLikelihood</seealso>
    let OutputLikelihood = Prefixed_Name(events, "OutputLikelihood") |> PrefixedName
    /// <summary>
    ///   <para>events:Completing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>completing</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Completing">http://eulersharp.sourceforge.net/2003/03swap/event#Completing</seealso>
    let Completing = Prefixed_Name(events, "Completing") |> PrefixedName
    /// <summary>
    ///   <para>events:hasNow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Using the Unix Epoch time.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasNow">http://eulersharp.sourceforge.net/2003/03swap/event#hasNow</seealso>
    let hasNow = Prefixed_Name(events, "hasNow") |> PrefixedName

    /// <summary>
    ///   <para>events:hasSnapshotDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A snapshot is an event with coinciding beginning and end.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSnapshotDateTime">http://eulersharp.sourceforge.net/2003/03swap/event#hasSnapshotDateTime</seealso>
    let hasSnapshotDateTime =
        Prefixed_Name(events, "hasSnapshotDateTime") |> PrefixedName

    /// <summary>
    ///   <para>events:hasNowDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasNowDate">http://eulersharp.sourceforge.net/2003/03swap/event#hasNowDate</seealso>
    let hasNowDate = Prefixed_Name(events, "hasNowDate") |> PrefixedName
    /// <summary>
    ///   <para>events:hasSnapshotDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>A snapshot is an event with coinciding beginning and end.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSnapshotDate">http://eulersharp.sourceforge.net/2003/03swap/event#hasSnapshotDate</seealso>
    let hasSnapshotDate = Prefixed_Name(events, "hasSnapshotDate") |> PrefixedName
    /// <summary>
    ///   <para>events:hasOnsetMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOnsetMode">http://eulersharp.sourceforge.net/2003/03swap/event#hasOnsetMode</seealso>
    let hasOnsetMode = Prefixed_Name(events, "hasOnsetMode") |> PrefixedName
    /// <summary>
    ///   <para>events:hasOrderDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOrderDateTime">http://eulersharp.sourceforge.net/2003/03swap/event#hasOrderDateTime</seealso>
    let hasOrderDateTime = Prefixed_Name(events, "hasOrderDateTime") |> PrefixedName

    /// <summary>
    ///   <para>events:hasOriginationDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOriginationDateTime">http://eulersharp.sourceforge.net/2003/03swap/event#hasOriginationDateTime</seealso>
    let hasOriginationDateTime =
        Prefixed_Name(events, "hasOriginationDateTime") |> PrefixedName

    /// <summary>
    ///   <para>events:hasOutputDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Related to event:ends</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOutputDateTime">http://eulersharp.sourceforge.net/2003/03swap/event#hasOutputDateTime</seealso>
    let hasOutputDateTime = Prefixed_Name(events, "hasOutputDateTime") |> PrefixedName

    /// <summary>
    ///   <para>events:hasOutputLikelihood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOutputLikelihood">http://eulersharp.sourceforge.net/2003/03swap/event#hasOutputLikelihood</seealso>
    let hasOutputLikelihood =
        Prefixed_Name(events, "hasOutputLikelihood") |> PrefixedName

    /// <summary>
    ///   <para>events:Indication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>indication</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Indication">http://eulersharp.sourceforge.net/2003/03swap/event#Indication</seealso>
    let Indication = Prefixed_Name(events, "Indication") |> PrefixedName
    /// <summary>
    ///   <para>events:Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>process</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Process">http://eulersharp.sourceforge.net/2003/03swap/event#Process</seealso>
    let Process = Prefixed_Name(events, "Process") |> PrefixedName
    /// <summary>
    ///   <para>events:AdverseOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>adverse output</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#AdverseOutput">http://eulersharp.sourceforge.net/2003/03swap/event#AdverseOutput</seealso>
    let AdverseOutput = Prefixed_Name(events, "AdverseOutput") |> PrefixedName
    /// <summary>
    ///   <para>events:hasDemandState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDemandState">http://eulersharp.sourceforge.net/2003/03swap/event#hasDemandState</seealso>
    let hasDemandState = Prefixed_Name(events, "hasDemandState") |> PrefixedName
    /// <summary>
    ///   <para>events:ends</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Using the Unix Epoch time; related to event:hasDateTime.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#ends">http://eulersharp.sourceforge.net/2003/03swap/event#ends</seealso>
    let ends = Prefixed_Name(events, "ends") |> PrefixedName
    /// <summary>
    ///   <para>events:endsAfter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#endsAfter">http://eulersharp.sourceforge.net/2003/03swap/event#endsAfter</seealso>
    let endsAfter = Prefixed_Name(events, "endsAfter") |> PrefixedName
    /// <summary>
    ///   <para>events:endsBefore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#endsBefore">http://eulersharp.sourceforge.net/2003/03swap/event#endsBefore</seealso>
    let endsBefore = Prefixed_Name(events, "endsBefore") |> PrefixedName
    /// <summary>
    ///   <para>events:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#">http://eulersharp.sourceforge.net/2003/03swap/event#</seealso>
    let _prefix_iri = Prefixed_Name(events, "") |> PrefixedName
    /// <summary>
    ///   <para>events:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>action</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Action">http://eulersharp.sourceforge.net/2003/03swap/event#Action</seealso>
    let Action = Prefixed_Name(events, "Action") |> PrefixedName
    /// <summary>
    ///   <para>events:Delivering</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>delivering</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Delivering">http://eulersharp.sourceforge.net/2003/03swap/event#Delivering</seealso>
    let Delivering = Prefixed_Name(events, "Delivering") |> PrefixedName
    /// <summary>
    ///   <para>events:Demanded</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:DemandState</para>
    ///
    /// labels<para>demanded</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Demanded">http://eulersharp.sourceforge.net/2003/03swap/event#Demanded</seealso>
    let Demanded = Prefixed_Name(events, "Demanded") |> PrefixedName
    /// <summary>
    ///   <para>events:createdIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#createdIn">http://eulersharp.sourceforge.net/2003/03swap/event#createdIn</seealso>
    let createdIn = Prefixed_Name(events, "createdIn") |> PrefixedName
    /// <summary>
    ///   <para>events:takesLessLongThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#takesLessLongThan">http://eulersharp.sourceforge.net/2003/03swap/event#takesLessLongThan</seealso>
    let takesLessLongThan = Prefixed_Name(events, "takesLessLongThan") |> PrefixedName
    /// <summary>
    ///   <para>events:takesLongerThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#takesLongerThan">http://eulersharp.sourceforge.net/2003/03swap/event#takesLongerThan</seealso>
    let takesLongerThan = Prefixed_Name(events, "takesLongerThan") |> PrefixedName
    /// <summary>
    ///   <para>events:transferOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/space#&gt;</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#transferOf">http://eulersharp.sourceforge.net/2003/03swap/event#transferOf</seealso>
    let transferOf = Prefixed_Name(events, "transferOf") |> PrefixedName
    /// <summary>
    ///   <para>events:Contraindication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>contraindication</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Contraindication">http://eulersharp.sourceforge.net/2003/03swap/event#Contraindication</seealso>
    let Contraindication = Prefixed_Name(events, "Contraindication") |> PrefixedName
    /// <summary>
    ///   <para>events:AbsoluteIndication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>absolute indication</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#AbsoluteIndication">http://eulersharp.sourceforge.net/2003/03swap/event#AbsoluteIndication</seealso>
    let AbsoluteIndication = Prefixed_Name(events, "AbsoluteIndication") |> PrefixedName
    /// <summary>
    ///   <para>events:hasSameEndAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSameEndAs">http://eulersharp.sourceforge.net/2003/03swap/event#hasSameEndAs</seealso>
    let hasSameEndAs = Prefixed_Name(events, "hasSameEndAs") |> PrefixedName
    /// <summary>
    ///   <para>events:hasSponsor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSponsor">http://eulersharp.sourceforge.net/2003/03swap/event#hasSponsor</seealso>
    let hasSponsor = Prefixed_Name(events, "hasSponsor") |> PrefixedName
    /// <summary>
    ///   <para>events:hasStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasStage">http://eulersharp.sourceforge.net/2003/03swap/event#hasStage</seealso>
    let hasStage = Prefixed_Name(events, "hasStage") |> PrefixedName
    /// <summary>
    ///   <para>events:hasSubAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSubAction">http://eulersharp.sourceforge.net/2003/03swap/event#hasSubAction</seealso>
    let hasSubAction = Prefixed_Name(events, "hasSubAction") |> PrefixedName
    /// <summary>
    ///   <para>events:includes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#includes">http://eulersharp.sourceforge.net/2003/03swap/event#includes</seealso>
    let includes = Prefixed_Name(events, "includes") |> PrefixedName

    /// <summary>
    ///   <para>events:hasSubmissionDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSubmissionDateTime">http://eulersharp.sourceforge.net/2003/03swap/event#hasSubmissionDateTime</seealso>
    let hasSubmissionDateTime =
        Prefixed_Name(events, "hasSubmissionDateTime") |> PrefixedName

    /// <summary>
    ///   <para>events:hasSusceptibilityStateFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSusceptibilityStateFor">http://eulersharp.sourceforge.net/2003/03swap/event#hasSusceptibilityStateFor</seealso>
    let hasSusceptibilityStateFor =
        Prefixed_Name(events, "hasSusceptibilityStateFor") |> PrefixedName

    /// <summary>
    ///   <para>events:susceptibilityStateFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#susceptibilityStateFor">http://eulersharp.sourceforge.net/2003/03swap/event#susceptibilityStateFor</seealso>
    let susceptibilityStateFor =
        Prefixed_Name(events, "susceptibilityStateFor") |> PrefixedName

    /// <summary>
    ///   <para>events:hasValidityState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasValidityState">http://eulersharp.sourceforge.net/2003/03swap/event#hasValidityState</seealso>
    let hasValidityState = Prefixed_Name(events, "hasValidityState") |> PrefixedName
    /// <summary>
    ///   <para>events:hasWarning</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasWarning">http://eulersharp.sourceforge.net/2003/03swap/event#hasWarning</seealso>
    let hasWarning = Prefixed_Name(events, "hasWarning") |> PrefixedName
    /// <summary>
    ///   <para>events:indicates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#indicates">http://eulersharp.sourceforge.net/2003/03swap/event#indicates</seealso>
    let indicates = Prefixed_Name(events, "indicates") |> PrefixedName
    /// <summary>
    ///   <para>events:isAssociatedWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is associated with</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#isAssociatedWith">http://eulersharp.sourceforge.net/2003/03swap/event#isAssociatedWith</seealso>
    let isAssociatedWith = Prefixed_Name(events, "isAssociatedWith") |> PrefixedName
    /// <summary>
    ///   <para>events:modifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#modifiedBy">http://eulersharp.sourceforge.net/2003/03swap/event#modifiedBy</seealso>
    let modifiedBy = Prefixed_Name(events, "modifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>events:nonCompliantWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>non-compliant with</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#nonCompliantWith">http://eulersharp.sourceforge.net/2003/03swap/event#nonCompliantWith</seealso>
    let nonCompliantWith = Prefixed_Name(events, "nonCompliantWith") |> PrefixedName
    /// <summary>
    ///   <para>events:notPerformedDuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#notPerformedDuring">http://eulersharp.sourceforge.net/2003/03swap/event#notPerformedDuring</seealso>
    let notPerformedDuring = Prefixed_Name(events, "notPerformedDuring") |> PrefixedName
    /// <summary>
    ///   <para>events:observedDuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The longer ago, the broader a timescope; e.g. observed in 1986: formally stating a period from "1985-12-31T23:00:00.000000Z"^^xsd:dateTime to "1986-12-31T22:59:59.999998Z"^^xsd:dateTime for time zone offset +01:00; observed in 2008 in May: stating a period from "2008-04-30T23:00:00.000000Z"^^xsd:dateTime to "2008-05-31T22:59:59.999998Z"^^xsd:dateTime; observed last month the 5 th: stating a period from "2011-12-04T23:00:00.000000Z"^^xsd:dateTime to "2011-12-05T22:59:59.999998Z"^^xsd:dateTime; observed Monday last week at 11AM: stating a moment "2012-01-30T10:00:00.000000Z"^^xsd:dateTime.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#observedDuring">http://eulersharp.sourceforge.net/2003/03swap/event#observedDuring</seealso>
    let observedDuring = Prefixed_Name(events, "observedDuring") |> PrefixedName
    /// <summary>
    ///   <para>events:obtainedDuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The longer ago, the broader a timescope; e.g. obtained in 1986: formally stating a period from "1985-12-31T23:00:00.000000Z"^^xsd:dateTime to "1986-12-31T22:59:59.999998Z"^^xsd:dateTime for time zone offset +01:00; obtained in 2008 in May: stating a period from "2008-04-30T23:00:00.000000Z"^^xsd:dateTime to "2008-05-31T22:59:59.999998Z"^^xsd:dateTime; obtained last month the 5 th: stating a period from "2011-12-04T23:00:00.000000Z"^^xsd:dateTime to "2011-12-05T22:59:59.999998Z"^^xsd:dateTime; obtained Monday last week at 11AM: stating a moment "2012-01-30T10:00:00.000000Z"^^xsd:dateTime.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#obtainedDuring">http://eulersharp.sourceforge.net/2003/03swap/event#obtainedDuring</seealso>
    let obtainedDuring = Prefixed_Name(events, "obtainedDuring") |> PrefixedName
    /// <summary>
    ///   <para>events:openFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#openFrom">http://eulersharp.sourceforge.net/2003/03swap/event#openFrom</seealso>
    let openFrom = Prefixed_Name(events, "openFrom") |> PrefixedName
    /// <summary>
    ///   <para>events:openUntil</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#openUntil">http://eulersharp.sourceforge.net/2003/03swap/event#openUntil</seealso>
    let openUntil = Prefixed_Name(events, "openUntil") |> PrefixedName
    /// <summary>
    ///   <para>events:orderOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#orderOf">http://eulersharp.sourceforge.net/2003/03swap/event#orderOf</seealso>
    let orderOf = Prefixed_Name(events, "orderOf") |> PrefixedName
    /// <summary>
    ///   <para>events:orderedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#orderedTo">http://eulersharp.sourceforge.net/2003/03swap/event#orderedTo</seealso>
    let orderedTo = Prefixed_Name(events, "orderedTo") |> PrefixedName
    /// <summary>
    ///   <para>events:originatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#originatedIn">http://eulersharp.sourceforge.net/2003/03swap/event#originatedIn</seealso>
    let originatedIn = Prefixed_Name(events, "originatedIn") |> PrefixedName
    /// <summary>
    ///   <para>events:overlaps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#overlaps">http://eulersharp.sourceforge.net/2003/03swap/event#overlaps</seealso>
    let overlaps = Prefixed_Name(events, "overlaps") |> PrefixedName
    /// <summary>
    ///   <para>events:performedDuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The longer ago, the broader a timescope; e.g. performed in 1986: formally stating a period from "1985-12-31T23:00:00.000000Z"^^xsd:dateTime to "1986-12-31T22:59:59.999998Z"^^xsd:dateTime for time zone offset +01:00; performed in 2008 in May: stating a period from "2008-04-30T23:00:00.000000Z"^^xsd:dateTime to "2008-05-31T22:59:59.999998Z"^^xsd:dateTime; performed last month the 5 th: stating a period from "2011-12-04T23:00:00.000000Z"^^xsd:dateTime to "2011-12-05T22:59:59.999998Z"^^xsd:dateTime; performed Monday last week at 11AM: stating a moment "2012-01-30T10:00:00.000000Z"^^xsd:dateTime.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#performedDuring">http://eulersharp.sourceforge.net/2003/03swap/event#performedDuring</seealso>
    let performedDuring = Prefixed_Name(events, "performedDuring") |> PrefixedName
    /// <summary>
    ///   <para>events:performedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#performedIn">http://eulersharp.sourceforge.net/2003/03swap/event#performedIn</seealso>
    let performedIn = Prefixed_Name(events, "performedIn") |> PrefixedName
    /// <summary>
    ///   <para>events:planOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#planOf">http://eulersharp.sourceforge.net/2003/03swap/event#planOf</seealso>
    let planOf = Prefixed_Name(events, "planOf") |> PrefixedName
    /// <summary>
    ///   <para>events:resistantTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#resistantTo">http://eulersharp.sourceforge.net/2003/03swap/event#resistantTo</seealso>
    let resistantTo = Prefixed_Name(events, "resistantTo") |> PrefixedName
    /// <summary>
    ///   <para>events:riskFactorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#riskFactorOf">http://eulersharp.sourceforge.net/2003/03swap/event#riskFactorOf</seealso>
    let riskFactorOf = Prefixed_Name(events, "riskFactorOf") |> PrefixedName
    /// <summary>
    ///   <para>events:stageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#stageOf">http://eulersharp.sourceforge.net/2003/03swap/event#stageOf</seealso>
    let stageOf = Prefixed_Name(events, "stageOf") |> PrefixedName
    /// <summary>
    ///   <para>events:stagedDuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The longer ago, the broader a timescope; e.g. staged in 1986: formally stating a period 01/01/1986-31/12/1986; staged last year in May: stating a period 01/05/2010-31/05/2010; staged last week: stating a day 01/01/2012; staged yesterday: stating a moment 20/01/2012, 02PM.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#stagedDuring">http://eulersharp.sourceforge.net/2003/03swap/event#stagedDuring</seealso>
    let stagedDuring = Prefixed_Name(events, "stagedDuring") |> PrefixedName
    /// <summary>
    ///   <para>events:startProcedureOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#startProcedureOf">http://eulersharp.sourceforge.net/2003/03swap/event#startProcedureOf</seealso>
    let startProcedureOf = Prefixed_Name(events, "startProcedureOf") |> PrefixedName
    /// <summary>
    ///   <para>events:stateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#stateOf">http://eulersharp.sourceforge.net/2003/03swap/event#stateOf</seealso>
    let stateOf = Prefixed_Name(events, "stateOf") |> PrefixedName
    /// <summary>
    ///   <para>events:subActionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#subActionOf">http://eulersharp.sourceforge.net/2003/03swap/event#subActionOf</seealso>
    let subActionOf = Prefixed_Name(events, "subActionOf") |> PrefixedName
    /// <summary>
    ///   <para>events:subOutputOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#subOutputOf">http://eulersharp.sourceforge.net/2003/03swap/event#subOutputOf</seealso>
    let subOutputOf = Prefixed_Name(events, "subOutputOf") |> PrefixedName
    /// <summary>
    ///   <para>events:susceptibleTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#susceptibleTo">http://eulersharp.sourceforge.net/2003/03swap/event#susceptibleTo</seealso>
    let susceptibleTo = Prefixed_Name(events, "susceptibleTo") |> PrefixedName
    /// <summary>
    ///   <para>events:UnSuspected</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:State</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>unsuspected</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#UnSuspected">http://eulersharp.sourceforge.net/2003/03swap/event#UnSuspected</seealso>
    let UnSuspected = Prefixed_Name(events, "UnSuspected") |> PrefixedName
    /// <summary>
    ///   <para>events:Educating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>educating</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Educating">http://eulersharp.sourceforge.net/2003/03swap/event#Educating</seealso>
    let Educating = Prefixed_Name(events, "Educating") |> PrefixedName
    /// <summary>
    ///   <para>events:Output</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>output</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Output">http://eulersharp.sourceforge.net/2003/03swap/event#Output</seealso>
    let Output = Prefixed_Name(events, "Output") |> PrefixedName
    /// <summary>
    ///   <para>events:AdverseProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>adverse process</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#AdverseProcess">http://eulersharp.sourceforge.net/2003/03swap/event#AdverseProcess</seealso>
    let AdverseProcess = Prefixed_Name(events, "AdverseProcess") |> PrefixedName
    /// <summary>
    ///   <para>events:Fast</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:CourseMode</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>fast</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Fast">http://eulersharp.sourceforge.net/2003/03swap/event#Fast</seealso>
    let Fast = Prefixed_Name(events, "Fast") |> PrefixedName
    /// <summary>
    ///   <para>events:FinalOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>final output</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#FinalOutput">http://eulersharp.sourceforge.net/2003/03swap/event#FinalOutput</seealso>
    let FinalOutput = Prefixed_Name(events, "FinalOutput") |> PrefixedName
    /// <summary>
    ///   <para>events:Friday</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:Weekday</para>
    ///
    /// labels<para>Friday</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Friday">http://eulersharp.sourceforge.net/2003/03swap/event#Friday</seealso>
    let Friday = Prefixed_Name(events, "Friday") |> PrefixedName
    /// <summary>
    ///   <para>events:Weekday</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>weekday</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Weekday">http://eulersharp.sourceforge.net/2003/03swap/event#Weekday</seealso>
    let Weekday = Prefixed_Name(events, "Weekday") |> PrefixedName
    /// <summary>
    ///   <para>events:HighPriority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:PriorityState</para>
    ///
    /// labels<para>high priority</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#HighPriority">http://eulersharp.sourceforge.net/2003/03swap/event#HighPriority</seealso>
    let HighPriority = Prefixed_Name(events, "HighPriority") |> PrefixedName
    /// <summary>
    ///   <para>events:PriorityState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>priority state</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#PriorityState">http://eulersharp.sourceforge.net/2003/03swap/event#PriorityState</seealso>
    let PriorityState = Prefixed_Name(events, "PriorityState") |> PrefixedName
    /// <summary>
    ///   <para>events:Intent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>intent</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Intent">http://eulersharp.sourceforge.net/2003/03swap/event#Intent</seealso>
    let Intent = Prefixed_Name(events, "Intent") |> PrefixedName
    /// <summary>
    ///   <para>events:IntentionState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>intention state</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#IntentionState">http://eulersharp.sourceforge.net/2003/03swap/event#IntentionState</seealso>
    let IntentionState = Prefixed_Name(events, "IntentionState") |> PrefixedName
    /// <summary>
    ///   <para>events:Unintentional</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:State</para>
    ///
    /// labels<para>unintentional</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Unintentional">http://eulersharp.sourceforge.net/2003/03swap/event#Unintentional</seealso>
    let Unintentional = Prefixed_Name(events, "Unintentional") |> PrefixedName
    /// <summary>
    ///   <para>events:IntermediateOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>intermediate output</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#IntermediateOutput">http://eulersharp.sourceforge.net/2003/03swap/event#IntermediateOutput</seealso>
    let IntermediateOutput = Prefixed_Name(events, "IntermediateOutput") |> PrefixedName

    /// <summary>
    ///   <para>events:SusceptibilityState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>susceptibility state</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#SusceptibilityState">http://eulersharp.sourceforge.net/2003/03swap/event#SusceptibilityState</seealso>
    let SusceptibilityState =
        Prefixed_Name(events, "SusceptibilityState") |> PrefixedName

    /// <summary>
    ///   <para>events:Intermittent</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:CourseMode</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>intermittent</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Intermittent">http://eulersharp.sourceforge.net/2003/03swap/event#Intermittent</seealso>
    let Intermittent = Prefixed_Name(events, "Intermittent") |> PrefixedName
    /// <summary>
    ///   <para>events:ValidityState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>validity state</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#ValidityState">http://eulersharp.sourceforge.net/2003/03swap/event#ValidityState</seealso>
    let ValidityState = Prefixed_Name(events, "ValidityState") |> PrefixedName

    /// <summary>
    ///   <para>events:LegalAuthenticating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>legal authenticating</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#LegalAuthenticating">http://eulersharp.sourceforge.net/2003/03swap/event#LegalAuthenticating</seealso>
    let LegalAuthenticating =
        Prefixed_Name(events, "LegalAuthenticating") |> PrefixedName

    /// <summary>
    ///   <para>events:Likelihood</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>likelihood</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Likelihood">http://eulersharp.sourceforge.net/2003/03swap/event#Likelihood</seealso>
    let Likelihood = Prefixed_Name(events, "Likelihood") |> PrefixedName
    /// <summary>
    ///   <para>events:Likely</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:OutputLikelihood</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>likely</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Likely">http://eulersharp.sourceforge.net/2003/03swap/event#Likely</seealso>
    let Likely = Prefixed_Name(events, "Likely") |> PrefixedName
    /// <summary>
    ///   <para>events:Method</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>method</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Method">http://eulersharp.sourceforge.net/2003/03swap/event#Method</seealso>
    let Method = Prefixed_Name(events, "Method") |> PrefixedName
    /// <summary>
    ///   <para>events:Modification</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>modification</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Modification">http://eulersharp.sourceforge.net/2003/03swap/event#Modification</seealso>
    let Modification = Prefixed_Name(events, "Modification") |> PrefixedName
    /// <summary>
    ///   <para>events:Modifying</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>modifying</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Modifying">http://eulersharp.sourceforge.net/2003/03swap/event#Modifying</seealso>
    let Modifying = Prefixed_Name(events, "Modifying") |> PrefixedName
    /// <summary>
    ///   <para>events:Monday</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:Weekday</para>
    ///
    /// labels<para>Monday</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Monday">http://eulersharp.sourceforge.net/2003/03swap/event#Monday</seealso>
    let Monday = Prefixed_Name(events, "Monday") |> PrefixedName
    /// <summary>
    ///   <para>events:MostLikely</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:OutputLikelihood</para>
    ///   <para>Near sure.</para>
    /// labels<para>most likely</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#MostLikely">http://eulersharp.sourceforge.net/2003/03swap/event#MostLikely</seealso>
    let MostLikely = Prefixed_Name(events, "MostLikely") |> PrefixedName
    /// <summary>
    ///   <para>events:MostUnlikely</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:OutputLikelihood</para>
    ///
    /// labels<para>most unlikely</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#MostUnlikely">http://eulersharp.sourceforge.net/2003/03swap/event#MostUnlikely</seealso>
    let MostUnlikely = Prefixed_Name(events, "MostUnlikely") |> PrefixedName
    /// <summary>
    ///   <para>events:Order</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>order</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Order">http://eulersharp.sourceforge.net/2003/03swap/event#Order</seealso>
    let Order = Prefixed_Name(events, "Order") |> PrefixedName
    /// <summary>
    ///   <para>events:Ordering</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>ordering</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Ordering">http://eulersharp.sourceforge.net/2003/03swap/event#Ordering</seealso>
    let Ordering = Prefixed_Name(events, "Ordering") |> PrefixedName
    /// <summary>
    ///   <para>events:Pathway</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>pathway</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Pathway">http://eulersharp.sourceforge.net/2003/03swap/event#Pathway</seealso>
    let Pathway = Prefixed_Name(events, "Pathway") |> PrefixedName
    /// <summary>
    ///   <para>events:Plan</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>plan</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Plan">http://eulersharp.sourceforge.net/2003/03swap/event#Plan</seealso>
    let Plan = Prefixed_Name(events, "Plan") |> PrefixedName
    /// <summary>
    ///   <para>events:Previous</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:State</para>
    ///   <para>rdfs:Class</para>
    ///   <para>E.g. previous 3 months: before current month.</para>
    /// labels<para>previous</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Previous">http://eulersharp.sourceforge.net/2003/03swap/event#Previous</seealso>
    let Previous = Prefixed_Name(events, "Previous") |> PrefixedName

    /// <summary>
    ///   <para>events:RelativeContraindication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>relative contraindication</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#RelativeContraindication">http://eulersharp.sourceforge.net/2003/03swap/event#RelativeContraindication</seealso>
    let RelativeContraindication =
        Prefixed_Name(events, "RelativeContraindication") |> PrefixedName

    /// <summary>
    ///   <para>events:RelativeIndication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>relative indication</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#RelativeIndication">http://eulersharp.sourceforge.net/2003/03swap/event#RelativeIndication</seealso>
    let RelativeIndication = Prefixed_Name(events, "RelativeIndication") |> PrefixedName
    /// <summary>
    ///   <para>events:Request</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>request</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Request">http://eulersharp.sourceforge.net/2003/03swap/event#Request</seealso>
    let Request = Prefixed_Name(events, "Request") |> PrefixedName
    /// <summary>
    ///   <para>events:Requesting</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>requesting</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Requesting">http://eulersharp.sourceforge.net/2003/03swap/event#Requesting</seealso>
    let Requesting = Prefixed_Name(events, "Requesting") |> PrefixedName
    /// <summary>
    ///   <para>events:Resistant</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:SusceptibilityState</para>
    ///
    /// labels<para>resistant</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Resistant">http://eulersharp.sourceforge.net/2003/03swap/event#Resistant</seealso>
    let Resistant = Prefixed_Name(events, "Resistant") |> PrefixedName
    /// <summary>
    ///   <para>events:Risk</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>risk</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Risk">http://eulersharp.sourceforge.net/2003/03swap/event#Risk</seealso>
    let Risk = Prefixed_Name(events, "Risk") |> PrefixedName
    /// <summary>
    ///   <para>events:RiskFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>risk factor</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#RiskFactor">http://eulersharp.sourceforge.net/2003/03swap/event#RiskFactor</seealso>
    let RiskFactor = Prefixed_Name(events, "RiskFactor") |> PrefixedName
    /// <summary>
    ///   <para>events:Routine</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:PriorityState</para>
    ///
    /// labels<para>routine</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Routine">http://eulersharp.sourceforge.net/2003/03swap/event#Routine</seealso>
    let Routine = Prefixed_Name(events, "Routine") |> PrefixedName
    /// <summary>
    ///   <para>events:Slow</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:CourseMode</para>
    ///   <para>events:EndingMode</para>
    ///   <para>rdfs:Class</para>
    ///   <para>events:OnsetMode</para>
    ///
    /// labels<para>slow</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Slow">http://eulersharp.sourceforge.net/2003/03swap/event#Slow</seealso>
    let Slow = Prefixed_Name(events, "Slow") |> PrefixedName
    /// <summary>
    ///   <para>events:Sponsoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>E.g. a business enterprise paying for radio or television programming in return for advertising time.</para>
    /// labels<para>sponsoring</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Sponsoring">http://eulersharp.sourceforge.net/2003/03swap/event#Sponsoring</seealso>
    let Sponsoring = Prefixed_Name(events, "Sponsoring") |> PrefixedName
    /// <summary>
    ///   <para>events:Stage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>stage</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Stage">http://eulersharp.sourceforge.net/2003/03swap/event#Stage</seealso>
    let Stage = Prefixed_Name(events, "Stage") |> PrefixedName
    /// <summary>
    ///   <para>events:Staging</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>staging</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Staging">http://eulersharp.sourceforge.net/2003/03swap/event#Staging</seealso>
    let Staging = Prefixed_Name(events, "Staging") |> PrefixedName
    /// <summary>
    ///   <para>events:Subacute</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:OnsetMode</para>
    ///   <para>rdfs:Class</para>
    ///   <para>events:EndingMode</para>
    ///
    /// labels<para>subacute</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Subacute">http://eulersharp.sourceforge.net/2003/03swap/event#Subacute</seealso>
    let Subacute = Prefixed_Name(events, "Subacute") |> PrefixedName
    /// <summary>
    ///   <para>events:Submission</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>submission</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Submission">http://eulersharp.sourceforge.net/2003/03swap/event#Submission</seealso>
    let Submission = Prefixed_Name(events, "Submission") |> PrefixedName
    /// <summary>
    ///   <para>events:Submitting</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>submitting</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Submitting">http://eulersharp.sourceforge.net/2003/03swap/event#Submitting</seealso>
    let Submitting = Prefixed_Name(events, "Submitting") |> PrefixedName
    /// <summary>
    ///   <para>events:SubmissionState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>submission state</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#SubmissionState">http://eulersharp.sourceforge.net/2003/03swap/event#SubmissionState</seealso>
    let SubmissionState = Prefixed_Name(events, "SubmissionState") |> PrefixedName
    /// <summary>
    ///   <para>events:Submitted</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:SubmissionState</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>submitted</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Submitted">http://eulersharp.sourceforge.net/2003/03swap/event#Submitted</seealso>
    let Submitted = Prefixed_Name(events, "Submitted") |> PrefixedName
    /// <summary>
    ///   <para>events:UnSubmitted</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:SubmissionState</para>
    ///
    /// labels<para>unsubmitted</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#UnSubmitted">http://eulersharp.sourceforge.net/2003/03swap/event#UnSubmitted</seealso>
    let UnSubmitted = Prefixed_Name(events, "UnSubmitted") |> PrefixedName
    /// <summary>
    ///   <para>events:Sudden</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:EndingMode</para>
    ///   <para>rdfs:Class</para>
    ///   <para>events:OnsetMode</para>
    ///
    /// labels<para>sudden</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Sudden">http://eulersharp.sourceforge.net/2003/03swap/event#Sudden</seealso>
    let Sudden = Prefixed_Name(events, "Sudden") |> PrefixedName
    /// <summary>
    ///   <para>events:Sunday</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:Weekday</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Sunday</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Sunday">http://eulersharp.sourceforge.net/2003/03swap/event#Sunday</seealso>
    let Sunday = Prefixed_Name(events, "Sunday") |> PrefixedName
    /// <summary>
    ///   <para>events:Susceptible</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:SusceptibilityState</para>
    ///
    /// labels<para>susceptible</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Susceptible">http://eulersharp.sourceforge.net/2003/03swap/event#Susceptible</seealso>
    let Susceptible = Prefixed_Name(events, "Susceptible") |> PrefixedName
    /// <summary>
    ///   <para>events:Thursday</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:Weekday</para>
    ///
    /// labels<para>Thursday</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Thursday">http://eulersharp.sourceforge.net/2003/03swap/event#Thursday</seealso>
    let Thursday = Prefixed_Name(events, "Thursday") |> PrefixedName
    /// <summary>
    ///   <para>events:Transfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/space#&gt;</para>
    /// labels<para>transfer</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Transfer">http://eulersharp.sourceforge.net/2003/03swap/event#Transfer</seealso>
    let Transfer = Prefixed_Name(events, "Transfer") |> PrefixedName
    /// <summary>
    ///   <para>events:Transferring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedClass</para>
    ///   <para>Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/space#&gt;</para>
    /// labels<para>transferring</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Transferring">http://eulersharp.sourceforge.net/2003/03swap/event#Transferring</seealso>
    let Transferring = Prefixed_Name(events, "Transferring") |> PrefixedName
    /// <summary>
    ///   <para>events:Tuesday</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:Weekday</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Tuesday</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Tuesday">http://eulersharp.sourceforge.net/2003/03swap/event#Tuesday</seealso>
    let Tuesday = Prefixed_Name(events, "Tuesday") |> PrefixedName
    /// <summary>
    ///   <para>events:Unavailability</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>unavailability</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Unavailability">http://eulersharp.sourceforge.net/2003/03swap/event#Unavailability</seealso>
    let Unavailability = Prefixed_Name(events, "Unavailability") |> PrefixedName
    /// <summary>
    ///   <para>events:Unlikely</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:OutputLikelihood</para>
    ///
    /// labels<para>unlikely</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Unlikely">http://eulersharp.sourceforge.net/2003/03swap/event#Unlikely</seealso>
    let Unlikely = Prefixed_Name(events, "Unlikely") |> PrefixedName
    /// <summary>
    ///   <para>events:Valid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:ValidityState</para>
    ///
    /// labels<para>valid</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Valid">http://eulersharp.sourceforge.net/2003/03swap/event#Valid</seealso>
    let Valid = Prefixed_Name(events, "Valid") |> PrefixedName
    /// <summary>
    ///   <para>events:Validating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>validating</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Validating">http://eulersharp.sourceforge.net/2003/03swap/event#Validating</seealso>
    let Validating = Prefixed_Name(events, "Validating") |> PrefixedName
    /// <summary>
    ///   <para>events:Validation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>validation</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Validation">http://eulersharp.sourceforge.net/2003/03swap/event#Validation</seealso>
    let Validation = Prefixed_Name(events, "Validation") |> PrefixedName
    /// <summary>
    ///   <para>events:Wednesday</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:Weekday</para>
    ///
    /// labels<para>Wednesday</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Wednesday">http://eulersharp.sourceforge.net/2003/03swap/event#Wednesday</seealso>
    let Wednesday = Prefixed_Name(events, "Wednesday") |> PrefixedName
    /// <summary>
    ///   <para>events:Week</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>week</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Week">http://eulersharp.sourceforge.net/2003/03swap/event#Week</seealso>
    let Week = Prefixed_Name(events, "Week") |> PrefixedName
    /// <summary>
    ///   <para>events:after</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#after">http://eulersharp.sourceforge.net/2003/03swap/event#after</seealso>
    let after = Prefixed_Name(events, "after") |> PrefixedName
    /// <summary>
    ///   <para>events:timeRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#timeRelatedTo">http://eulersharp.sourceforge.net/2003/03swap/event#timeRelatedTo</seealso>
    let timeRelatedTo = Prefixed_Name(events, "timeRelatedTo") |> PrefixedName
    /// <summary>
    ///   <para>events:before</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#before">http://eulersharp.sourceforge.net/2003/03swap/event#before</seealso>
    let before = Prefixed_Name(events, "before") |> PrefixedName
    /// <summary>
    ///   <para>events:basedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>E.g. a diagnosis, e.g. infection, based on an evaluation, e.g. fever, in turn based on an examination, e.g. body temperature measurement.</para>
    /// labels<para>based on</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#basedOn">http://eulersharp.sourceforge.net/2003/03swap/event#basedOn</seealso>
    let basedOn = Prefixed_Name(events, "basedOn") |> PrefixedName
    /// <summary>
    ///   <para>events:basisFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>E.g. an examination, e.g. body temperature measurement, as basis for an evaluation, e.g. fever, in turn basis for a diagnosis, e.g. infection.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#basisFor">http://eulersharp.sourceforge.net/2003/03swap/event#basisFor</seealso>
    let basisFor = Prefixed_Name(events, "basisFor") |> PrefixedName
    /// <summary>
    ///   <para>events:beginDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#beginDate">http://eulersharp.sourceforge.net/2003/03swap/event#beginDate</seealso>
    let beginDate = Prefixed_Name(events, "beginDate") |> PrefixedName
    /// <summary>
    ///   <para>events:beginsAfter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#beginsAfter">http://eulersharp.sourceforge.net/2003/03swap/event#beginsAfter</seealso>
    let beginsAfter = Prefixed_Name(events, "beginsAfter") |> PrefixedName
    /// <summary>
    ///   <para>events:beginsBefore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#beginsBefore">http://eulersharp.sourceforge.net/2003/03swap/event#beginsBefore</seealso>
    let beginsBefore = Prefixed_Name(events, "beginsBefore") |> PrefixedName
    /// <summary>
    ///   <para>events:beginsDuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#beginsDuring">http://eulersharp.sourceforge.net/2003/03swap/event#beginsDuring</seealso>
    let beginsDuring = Prefixed_Name(events, "beginsDuring") |> PrefixedName
    /// <summary>
    ///   <para>events:causedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#causedBy">http://eulersharp.sourceforge.net/2003/03swap/event#causedBy</seealso>
    let causedBy = Prefixed_Name(events, "causedBy") |> PrefixedName
    /// <summary>
    ///   <para>events:causes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#causes">http://eulersharp.sourceforge.net/2003/03swap/event#causes</seealso>
    let causes = Prefixed_Name(events, "causes") |> PrefixedName
    /// <summary>
    ///   <para>events:compliesWith</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>complies with</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#compliesWith">http://eulersharp.sourceforge.net/2003/03swap/event#compliesWith</seealso>
    let compliesWith = Prefixed_Name(events, "compliesWith") |> PrefixedName
    /// <summary>
    ///   <para>events:confirmedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>confirmed by</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#confirmedBy">http://eulersharp.sourceforge.net/2003/03swap/event#confirmedBy</seealso>
    let confirmedBy = Prefixed_Name(events, "confirmedBy") |> PrefixedName
    /// <summary>
    ///   <para>events:confirms</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>confirms</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#confirms">http://eulersharp.sourceforge.net/2003/03swap/event#confirms</seealso>
    let confirms = Prefixed_Name(events, "confirms") |> PrefixedName
    /// <summary>
    ///   <para>events:contraindicatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#contraindicatedBy">http://eulersharp.sourceforge.net/2003/03swap/event#contraindicatedBy</seealso>
    let contraindicatedBy = Prefixed_Name(events, "contraindicatedBy") |> PrefixedName
    /// <summary>
    ///   <para>events:contraindicates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#contraindicates">http://eulersharp.sourceforge.net/2003/03swap/event#contraindicates</seealso>
    let contraindicates = Prefixed_Name(events, "contraindicates") |> PrefixedName
    /// <summary>
    ///   <para>events:createdBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#createdBy">http://eulersharp.sourceforge.net/2003/03swap/event#createdBy</seealso>
    let createdBy = Prefixed_Name(events, "createdBy") |> PrefixedName
    /// <summary>
    ///   <para>events:hasCreated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCreated">http://eulersharp.sourceforge.net/2003/03swap/event#hasCreated</seealso>
    let hasCreated = Prefixed_Name(events, "hasCreated") |> PrefixedName
    /// <summary>
    ///   <para>events:creationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#creationOf">http://eulersharp.sourceforge.net/2003/03swap/event#creationOf</seealso>
    let creationOf = Prefixed_Name(events, "creationOf") |> PrefixedName
    /// <summary>
    ///   <para>events:deliveredIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#deliveredIn">http://eulersharp.sourceforge.net/2003/03swap/event#deliveredIn</seealso>
    let deliveredIn = Prefixed_Name(events, "deliveredIn") |> PrefixedName
    /// <summary>
    ///   <para>events:whereinDelivered</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#whereinDelivered">http://eulersharp.sourceforge.net/2003/03swap/event#whereinDelivered</seealso>
    let whereinDelivered = Prefixed_Name(events, "whereinDelivered") |> PrefixedName
    /// <summary>
    ///   <para>events:deliveredTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#deliveredTo">http://eulersharp.sourceforge.net/2003/03swap/event#deliveredTo</seealso>
    let deliveredTo = Prefixed_Name(events, "deliveredTo") |> PrefixedName
    /// <summary>
    ///   <para>events:deliveryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#deliveryOf">http://eulersharp.sourceforge.net/2003/03swap/event#deliveryOf</seealso>
    let deliveryOf = Prefixed_Name(events, "deliveryOf") |> PrefixedName
    /// <summary>
    ///   <para>events:diagnosedDuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>The longer ago, the broader a timescope; e.g. diagnosed in 1986: formally stating a period from "1985-12-31T23:00:00.000000Z"^^xsd:dateTime to "1986-12-31T22:59:59.999998Z"^^xsd:dateTime for time zone offset +01:00; diagnosed in 2008 in May: stating a period from "2008-04-30T23:00:00.000000Z"^^xsd:dateTime to "2008-05-31T22:59:59.999998Z"^^xsd:dateTime; diagnosed last month the 5 th: stating a period from "2011-12-04T23:00:00.000000Z"^^xsd:dateTime to "2011-12-05T22:59:59.999998Z"^^xsd:dateTime; diagnosed Monday last week at 11AM: stating a moment "2012-01-30T10:00:00.000000Z"^^xsd:dateTime.</para>
    /// labels<para>diagnosed during</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#diagnosedDuring">http://eulersharp.sourceforge.net/2003/03swap/event#diagnosedDuring</seealso>
    let diagnosedDuring = Prefixed_Name(events, "diagnosedDuring") |> PrefixedName
    /// <summary>
    ///   <para>events:diagnosedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///
    /// labels<para>diagnosed in</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#diagnosedIn">http://eulersharp.sourceforge.net/2003/03swap/event#diagnosedIn</seealso>
    let diagnosedIn = Prefixed_Name(events, "diagnosedIn") |> PrefixedName
    /// <summary>
    ///   <para>events:during</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#during">http://eulersharp.sourceforge.net/2003/03swap/event#during</seealso>
    let during = Prefixed_Name(events, "during") |> PrefixedName
    /// <summary>
    ///   <para>events:diagnosisOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#diagnosisOf">http://eulersharp.sourceforge.net/2003/03swap/event#diagnosisOf</seealso>
    let diagnosisOf = Prefixed_Name(events, "diagnosisOf") |> PrefixedName
    /// <summary>
    ///   <para>events:endDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#endDate">http://eulersharp.sourceforge.net/2003/03swap/event#endDate</seealso>
    let endDate = Prefixed_Name(events, "endDate") |> PrefixedName
    /// <summary>
    ///   <para>events:endProcedureOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#endProcedureOf">http://eulersharp.sourceforge.net/2003/03swap/event#endProcedureOf</seealso>
    let endProcedureOf = Prefixed_Name(events, "endProcedureOf") |> PrefixedName
    /// <summary>
    ///   <para>events:subProcedureOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#subProcedureOf">http://eulersharp.sourceforge.net/2003/03swap/event#subProcedureOf</seealso>
    let subProcedureOf = Prefixed_Name(events, "subProcedureOf") |> PrefixedName
    /// <summary>
    ///   <para>events:hasEndProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasEndProcedure">http://eulersharp.sourceforge.net/2003/03swap/event#hasEndProcedure</seealso>
    let hasEndProcedure = Prefixed_Name(events, "hasEndProcedure") |> PrefixedName
    /// <summary>
    ///   <para>events:endsDuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#endsDuring">http://eulersharp.sourceforge.net/2003/03swap/event#endsDuring</seealso>
    let endsDuring = Prefixed_Name(events, "endsDuring") |> PrefixedName
    /// <summary>
    ///   <para>events:evaluatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#evaluatedBy">http://eulersharp.sourceforge.net/2003/03swap/event#evaluatedBy</seealso>
    let evaluatedBy = Prefixed_Name(events, "evaluatedBy") |> PrefixedName
    /// <summary>
    ///   <para>events:hasEvaluated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasEvaluated">http://eulersharp.sourceforge.net/2003/03swap/event#hasEvaluated</seealso>
    let hasEvaluated = Prefixed_Name(events, "hasEvaluated") |> PrefixedName
    /// <summary>
    ///   <para>events:evaluatedDuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>The longer ago, the broader a timescope; e.g. evaluated in 1986: formally stating a period from "1985-12-31T23:00:00.000000Z"^^xsd:dateTime to "1986-12-31T22:59:59.999998Z"^^xsd:dateTime for time zone offset +01:00; evaluated in 2008 in May: stating a period from "2008-04-30T23:00:00.000000Z"^^xsd:dateTime to "2008-05-31T22:59:59.999998Z"^^xsd:dateTime; evaluated last month the 5 th: stating a period from "2011-12-04T23:00:00.000000Z"^^xsd:dateTime to "2011-12-05T22:59:59.999998Z"^^xsd:dateTime; evaluated Monday last week at 11AM: stating a moment "2012-01-30T10:00:00.000000Z"^^xsd:dateTime.</para>
    /// labels<para>evaluated during</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#evaluatedDuring">http://eulersharp.sourceforge.net/2003/03swap/event#evaluatedDuring</seealso>
    let evaluatedDuring = Prefixed_Name(events, "evaluatedDuring") |> PrefixedName
    /// <summary>
    ///   <para>events:evaluatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#evaluatedIn">http://eulersharp.sourceforge.net/2003/03swap/event#evaluatedIn</seealso>
    let evaluatedIn = Prefixed_Name(events, "evaluatedIn") |> PrefixedName
    /// <summary>
    ///   <para>events:inputOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#inputOf">http://eulersharp.sourceforge.net/2003/03swap/event#inputOf</seealso>
    let inputOf = Prefixed_Name(events, "inputOf") |> PrefixedName
    /// <summary>
    ///   <para>events:evaluationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#evaluationOf">http://eulersharp.sourceforge.net/2003/03swap/event#evaluationOf</seealso>
    let evaluationOf = Prefixed_Name(events, "evaluationOf") |> PrefixedName
    /// <summary>
    ///   <para>events:examinationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>examination of</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#examinationOf">http://eulersharp.sourceforge.net/2003/03swap/event#examinationOf</seealso>
    let examinationOf = Prefixed_Name(events, "examinationOf") |> PrefixedName
    /// <summary>
    ///   <para>events:examinedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#examinedBy">http://eulersharp.sourceforge.net/2003/03swap/event#examinedBy</seealso>
    let examinedBy = Prefixed_Name(events, "examinedBy") |> PrefixedName
    /// <summary>
    ///   <para>events:hasExamining</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has examining</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasExamining">http://eulersharp.sourceforge.net/2003/03swap/event#hasExamining</seealso>
    let hasExamining = Prefixed_Name(events, "hasExamining") |> PrefixedName
    /// <summary>
    ///   <para>events:hasExamined</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasExamined">http://eulersharp.sourceforge.net/2003/03swap/event#hasExamined</seealso>
    let hasExamined = Prefixed_Name(events, "hasExamined") |> PrefixedName
    /// <summary>
    ///   <para>events:examinedDuring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The longer ago, the broader a timescope; e.g. examined in 1986: formally stating a period from "1985-12-31T23:00:00.000000Z"^^xsd:dateTime to "1986-12-31T22:59:59.999998Z"^^xsd:dateTime for time zone offset +01:00; examined in 2008 in May: stating a period from "2008-04-30T23:00:00.000000Z"^^xsd:dateTime to "2008-05-31T22:59:59.999998Z"^^xsd:dateTime; examined last month the 5 th: stating a period from "2011-12-04T23:00:00.000000Z"^^xsd:dateTime to "2011-12-05T22:59:59.999998Z"^^xsd:dateTime; examined Monday last week at 11AM: stating a moment "2012-01-30T10:00:00.000000Z"^^xsd:dateTime.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#examinedDuring">http://eulersharp.sourceforge.net/2003/03swap/event#examinedDuring</seealso>
    let examinedDuring = Prefixed_Name(events, "examinedDuring") |> PrefixedName
    /// <summary>
    ///   <para>events:existsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#existsOn">http://eulersharp.sourceforge.net/2003/03swap/event#existsOn</seealso>
    let existsOn = Prefixed_Name(events, "existsOn") |> PrefixedName
    /// <summary>
    ///   <para>events:expires</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#expires">http://eulersharp.sourceforge.net/2003/03swap/event#expires</seealso>
    let expires = Prefixed_Name(events, "expires") |> PrefixedName
    /// <summary>
    ///   <para>events:gotDelivered</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#gotDelivered">http://eulersharp.sourceforge.net/2003/03swap/event#gotDelivered</seealso>
    let gotDelivered = Prefixed_Name(events, "gotDelivered") |> PrefixedName
    /// <summary>
    ///   <para>events:gotExamined</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#gotExamined">http://eulersharp.sourceforge.net/2003/03swap/event#gotExamined</seealso>
    let gotExamined = Prefixed_Name(events, "gotExamined") |> PrefixedName
    /// <summary>
    ///   <para>events:gotOrdered</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#gotOrdered">http://eulersharp.sourceforge.net/2003/03swap/event#gotOrdered</seealso>
    let gotOrdered = Prefixed_Name(events, "gotOrdered") |> PrefixedName
    /// <summary>
    ///   <para>events:orderedFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#orderedFor">http://eulersharp.sourceforge.net/2003/03swap/event#orderedFor</seealso>
    let orderedFor = Prefixed_Name(events, "orderedFor") |> PrefixedName
    /// <summary>
    ///   <para>events:hasAdverseOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasAdverseOutput">http://eulersharp.sourceforge.net/2003/03swap/event#hasAdverseOutput</seealso>
    let hasAdverseOutput = Prefixed_Name(events, "hasAdverseOutput") |> PrefixedName
    /// <summary>
    ///   <para>events:hasAge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasAge">http://eulersharp.sourceforge.net/2003/03swap/event#hasAge</seealso>
    let hasAge = Prefixed_Name(events, "hasAge") |> PrefixedName

    /// <summary>
    ///   <para>events:hasCompletionDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCompletionDateTime">http://eulersharp.sourceforge.net/2003/03swap/event#hasCompletionDateTime</seealso>
    let hasCompletionDateTime =
        Prefixed_Name(events, "hasCompletionDateTime") |> PrefixedName

    /// <summary>
    ///   <para>events:hasCompletionState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCompletionState">http://eulersharp.sourceforge.net/2003/03swap/event#hasCompletionState</seealso>
    let hasCompletionState = Prefixed_Name(events, "hasCompletionState") |> PrefixedName

    /// <summary>
    ///   <para>events:hasContraindicationDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasContraindicationDateTime">http://eulersharp.sourceforge.net/2003/03swap/event#hasContraindicationDateTime</seealso>
    let hasContraindicationDateTime =
        Prefixed_Name(events, "hasContraindicationDateTime") |> PrefixedName

    /// <summary>
    ///   <para>events:hasDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDateTime">http://eulersharp.sourceforge.net/2003/03swap/event#hasDateTime</seealso>
    let hasDateTime = Prefixed_Name(events, "hasDateTime") |> PrefixedName
    /// <summary>
    ///   <para>events:Undemanded</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:DemandState</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>undemanded</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Undemanded">http://eulersharp.sourceforge.net/2003/03swap/event#Undemanded</seealso>
    let Undemanded = Prefixed_Name(events, "Undemanded") |> PrefixedName
    /// <summary>
    ///   <para>events:Examination</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>examination</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Examination">http://eulersharp.sourceforge.net/2003/03swap/event#Examination</seealso>
    let Examination = Prefixed_Name(events, "Examination") |> PrefixedName
    /// <summary>
    ///   <para>events:Examining</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>examining</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Examining">http://eulersharp.sourceforge.net/2003/03swap/event#Examining</seealso>
    let Examining = Prefixed_Name(events, "Examining") |> PrefixedName
    /// <summary>
    ///   <para>events:Examined</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:State</para>
    ///
    /// labels<para>examined</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Examined">http://eulersharp.sourceforge.net/2003/03swap/event#Examined</seealso>
    let Examined = Prefixed_Name(events, "Examined") |> PrefixedName
    /// <summary>
    ///   <para>events:Existence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>existence</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Existence">http://eulersharp.sourceforge.net/2003/03swap/event#Existence</seealso>
    let Existence = Prefixed_Name(events, "Existence") |> PrefixedName
    /// <summary>
    ///   <para>events:Experimental</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>experimental</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Experimental">http://eulersharp.sourceforge.net/2003/03swap/event#Experimental</seealso>
    let Experimental = Prefixed_Name(events, "Experimental") |> PrefixedName
    /// <summary>
    ///   <para>events:Finding</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>finding</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Finding">http://eulersharp.sourceforge.net/2003/03swap/event#Finding</seealso>
    let Finding = Prefixed_Name(events, "Finding") |> PrefixedName
    /// <summary>
    ///   <para>events:Gradual</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:OnsetMode</para>
    ///   <para>events:CourseMode</para>
    ///   <para>rdfs:Class</para>
    ///   <para>events:EndingMode</para>
    ///
    /// labels<para>gradual</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Gradual">http://eulersharp.sourceforge.net/2003/03swap/event#Gradual</seealso>
    let Gradual = Prefixed_Name(events, "Gradual") |> PrefixedName
    /// <summary>
    ///   <para>events:OnsetMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>onset mode</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#OnsetMode">http://eulersharp.sourceforge.net/2003/03swap/event#OnsetMode</seealso>
    let OnsetMode = Prefixed_Name(events, "OnsetMode") |> PrefixedName
    /// <summary>
    ///   <para>events:Input</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>input</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Input">http://eulersharp.sourceforge.net/2003/03swap/event#Input</seealso>
    let Input = Prefixed_Name(events, "Input") |> PrefixedName
    /// <summary>
    ///   <para>events:Intentional</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:State</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>intentional</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Intentional">http://eulersharp.sourceforge.net/2003/03swap/event#Intentional</seealso>
    let Intentional = Prefixed_Name(events, "Intentional") |> PrefixedName
    /// <summary>
    ///   <para>events:hasCreation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCreation">http://eulersharp.sourceforge.net/2003/03swap/event#hasCreation</seealso>
    let hasCreation = Prefixed_Name(events, "hasCreation") |> PrefixedName
    /// <summary>
    ///   <para>events:hasCreationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCreationDate">http://eulersharp.sourceforge.net/2003/03swap/event#hasCreationDate</seealso>
    let hasCreationDate = Prefixed_Name(events, "hasCreationDate") |> PrefixedName
    /// <summary>
    ///   <para>events:hasCreator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCreator">http://eulersharp.sourceforge.net/2003/03swap/event#hasCreator</seealso>
    let hasCreator = Prefixed_Name(events, "hasCreator") |> PrefixedName

    /// <summary>
    ///   <para>events:hasDeliveryDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDeliveryDateTime">http://eulersharp.sourceforge.net/2003/03swap/event#hasDeliveryDateTime</seealso>
    let hasDeliveryDateTime =
        Prefixed_Name(events, "hasDeliveryDateTime") |> PrefixedName

    /// <summary>
    ///   <para>events:hasDeliveryDelay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDeliveryDelay">http://eulersharp.sourceforge.net/2003/03swap/event#hasDeliveryDelay</seealso>
    let hasDeliveryDelay = Prefixed_Name(events, "hasDeliveryDelay") |> PrefixedName
    /// <summary>
    ///   <para>events:hasDiagnosis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDiagnosis">http://eulersharp.sourceforge.net/2003/03swap/event#hasDiagnosis</seealso>
    let hasDiagnosis = Prefixed_Name(events, "hasDiagnosis") |> PrefixedName

    /// <summary>
    ///   <para>events:hasDiagnosisDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDiagnosisDateTime">http://eulersharp.sourceforge.net/2003/03swap/event#hasDiagnosisDateTime</seealso>
    let hasDiagnosisDateTime =
        Prefixed_Name(events, "hasDiagnosisDateTime") |> PrefixedName

    /// <summary>
    ///   <para>events:hasDiagnosisState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDiagnosisState">http://eulersharp.sourceforge.net/2003/03swap/event#hasDiagnosisState</seealso>
    let hasDiagnosisState = Prefixed_Name(events, "hasDiagnosisState") |> PrefixedName
    /// <summary>
    ///   <para>events:hasDonor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDonor">http://eulersharp.sourceforge.net/2003/03swap/event#hasDonor</seealso>
    let hasDonor = Prefixed_Name(events, "hasDonor") |> PrefixedName
    /// <summary>
    ///   <para>events:hasEndingMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasEndingMode">http://eulersharp.sourceforge.net/2003/03swap/event#hasEndingMode</seealso>
    let hasEndingMode = Prefixed_Name(events, "hasEndingMode") |> PrefixedName
    /// <summary>
    ///   <para>events:hasEvaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasEvaluation">http://eulersharp.sourceforge.net/2003/03swap/event#hasEvaluation</seealso>
    let hasEvaluation = Prefixed_Name(events, "hasEvaluation") |> PrefixedName

    /// <summary>
    ///   <para>events:hasEvaluationDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasEvaluationDateTime">http://eulersharp.sourceforge.net/2003/03swap/event#hasEvaluationDateTime</seealso>
    let hasEvaluationDateTime =
        Prefixed_Name(events, "hasEvaluationDateTime") |> PrefixedName

    /// <summary>
    ///   <para>events:Authenticating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>authenticating</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Authenticating">http://eulersharp.sourceforge.net/2003/03swap/event#Authenticating</seealso>
    let Authenticating = Prefixed_Name(events, "Authenticating") |> PrefixedName
    /// <summary>
    ///   <para>events:Availability</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>availability</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Availability">http://eulersharp.sourceforge.net/2003/03swap/event#Availability</seealso>
    let Availability = Prefixed_Name(events, "Availability") |> PrefixedName

    /// <summary>
    ///   <para>events:hasAvailabilityState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasAvailabilityState">http://eulersharp.sourceforge.net/2003/03swap/event#hasAvailabilityState</seealso>
    let hasAvailabilityState =
        Prefixed_Name(events, "hasAvailabilityState") |> PrefixedName

    /// <summary>
    ///   <para>events:IntermediatelySusceptible</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:SusceptibilityState</para>
    ///
    /// labels<para>intermediately susceptible</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#IntermediatelySusceptible">http://eulersharp.sourceforge.net/2003/03swap/event#IntermediatelySusceptible</seealso>
    let IntermediatelySusceptible =
        Prefixed_Name(events, "IntermediatelySusceptible") |> PrefixedName

    /// <summary>
    ///   <para>events:Observable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>observable</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Observable">http://eulersharp.sourceforge.net/2003/03swap/event#Observable</seealso>
    let Observable = Prefixed_Name(events, "Observable") |> PrefixedName
    /// <summary>
    ///   <para>events:Past</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:State</para>
    ///   <para>E.g. past 3 months: before now.</para>
    /// labels<para>past</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Past">http://eulersharp.sourceforge.net/2003/03swap/event#Past</seealso>
    let Past = Prefixed_Name(events, "Past") |> PrefixedName
    /// <summary>
    ///   <para>events:Persistent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:CourseMode</para>
    ///
    /// labels<para>persistent</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Persistent">http://eulersharp.sourceforge.net/2003/03swap/event#Persistent</seealso>
    let Persistent = Prefixed_Name(events, "Persistent") |> PrefixedName
    /// <summary>
    ///   <para>events:Planning</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>planning</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Planning">http://eulersharp.sourceforge.net/2003/03swap/event#Planning</seealso>
    let Planning = Prefixed_Name(events, "Planning") |> PrefixedName
    /// <summary>
    ///   <para>events:hasEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has event</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasEvent">http://eulersharp.sourceforge.net/2003/03swap/event#hasEvent</seealso>
    let hasEvent = Prefixed_Name(events, "hasEvent") |> PrefixedName
    /// <summary>
    ///   <para>events:hasFindingDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasFindingDateTime">http://eulersharp.sourceforge.net/2003/03swap/event#hasFindingDateTime</seealso>
    let hasFindingDateTime = Prefixed_Name(events, "hasFindingDateTime") |> PrefixedName

    /// <summary>
    ///   <para>events:hasIndicationDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasIndicationDateTime">http://eulersharp.sourceforge.net/2003/03swap/event#hasIndicationDateTime</seealso>
    let hasIndicationDateTime =
        Prefixed_Name(events, "hasIndicationDateTime") |> PrefixedName

    /// <summary>
    ///   <para>events:indicatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#indicatedBy">http://eulersharp.sourceforge.net/2003/03swap/event#indicatedBy</seealso>
    let indicatedBy = Prefixed_Name(events, "indicatedBy") |> PrefixedName

    /// <summary>
    ///   <para>events:hasLastUpdateDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasLastUpdateDateTime">http://eulersharp.sourceforge.net/2003/03swap/event#hasLastUpdateDateTime</seealso>
    let hasLastUpdateDateTime =
        Prefixed_Name(events, "hasLastUpdateDateTime") |> PrefixedName

    /// <summary>
    ///   <para>events:hasLatestSubmissionDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>As used in an N3 rule.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasLatestSubmissionDateTime">http://eulersharp.sourceforge.net/2003/03swap/event#hasLatestSubmissionDateTime</seealso>
    let hasLatestSubmissionDateTime =
        Prefixed_Name(events, "hasLatestSubmissionDateTime") |> PrefixedName

    /// <summary>
    ///   <para>events:hasModification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasModification">http://eulersharp.sourceforge.net/2003/03swap/event#hasModification</seealso>
    let hasModification = Prefixed_Name(events, "hasModification") |> PrefixedName
    /// <summary>
    ///   <para>events:hasModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasModified">http://eulersharp.sourceforge.net/2003/03swap/event#hasModified</seealso>
    let hasModified = Prefixed_Name(events, "hasModified") |> PrefixedName
    /// <summary>
    ///   <para>events:Future</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:State</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>future</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Future">http://eulersharp.sourceforge.net/2003/03swap/event#Future</seealso>
    let Future = Prefixed_Name(events, "Future") |> PrefixedName
    /// <summary>
    ///   <para>events:Guideline</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>guideline</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Guideline">http://eulersharp.sourceforge.net/2003/03swap/event#Guideline</seealso>
    let Guideline = Prefixed_Name(events, "Guideline") |> PrefixedName
    /// <summary>
    ///   <para>events:hasCourseMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCourseMode">http://eulersharp.sourceforge.net/2003/03swap/event#hasCourseMode</seealso>
    let hasCourseMode = Prefixed_Name(events, "hasCourseMode") |> PrefixedName
    /// <summary>
    ///   <para>events:Available</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:AvailabilityState</para>
    ///
    /// labels<para>available</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Available">http://eulersharp.sourceforge.net/2003/03swap/event#Available</seealso>
    let Available = Prefixed_Name(events, "Available") |> PrefixedName
    /// <summary>
    ///   <para>events:Unavailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:AvailabilityState</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>unavailable</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Unavailable">http://eulersharp.sourceforge.net/2003/03swap/event#Unavailable</seealso>
    let Unavailable = Prefixed_Name(events, "Unavailable") |> PrefixedName
    /// <summary>
    ///   <para>events:Invalid</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:ValidityState</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>invalid</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Invalid">http://eulersharp.sourceforge.net/2003/03swap/event#Invalid</seealso>
    let Invalid = Prefixed_Name(events, "Invalid") |> PrefixedName

    /// <summary>
    ///   <para>events:LegalAuthentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>legal authentication</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#LegalAuthentication">http://eulersharp.sourceforge.net/2003/03swap/event#LegalAuthentication</seealso>
    let LegalAuthentication =
        Prefixed_Name(events, "LegalAuthentication") |> PrefixedName

    /// <summary>
    ///   <para>events:LowPriority</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:PriorityState</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>low priority</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#LowPriority">http://eulersharp.sourceforge.net/2003/03swap/event#LowPriority</seealso>
    let LowPriority = Prefixed_Name(events, "LowPriority") |> PrefixedName
    /// <summary>
    ///   <para>events:Modified</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:State</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>modified</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Modified">http://eulersharp.sourceforge.net/2003/03swap/event#Modified</seealso>
    let Modified = Prefixed_Name(events, "Modified") |> PrefixedName
    /// <summary>
    ///   <para>events:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>state</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#State">http://eulersharp.sourceforge.net/2003/03swap/event#State</seealso>
    let State = Prefixed_Name(events, "State") |> PrefixedName
    /// <summary>
    ///   <para>events:CourseMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>course mode</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#CourseMode">http://eulersharp.sourceforge.net/2003/03swap/event#CourseMode</seealso>
    let CourseMode = Prefixed_Name(events, "CourseMode") |> PrefixedName
    /// <summary>
    ///   <para>events:Phasic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:CourseMode</para>
    ///   <para>Human prenatal existence comprising embryonic and foetal phase.</para>
    /// labels<para>phasic</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Phasic">http://eulersharp.sourceforge.net/2003/03swap/event#Phasic</seealso>
    let Phasic = Prefixed_Name(events, "Phasic") |> PrefixedName
    /// <summary>
    ///   <para>events:hasSubProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSubProcedure">http://eulersharp.sourceforge.net/2003/03swap/event#hasSubProcedure</seealso>
    let hasSubProcedure = Prefixed_Name(events, "hasSubProcedure") |> PrefixedName
    /// <summary>
    ///   <para>events:hasInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasInput">http://eulersharp.sourceforge.net/2003/03swap/event#hasInput</seealso>
    let hasInput = Prefixed_Name(events, "hasInput") |> PrefixedName
    /// <summary>
    ///   <para>events:hasIntentionState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasIntentionState">http://eulersharp.sourceforge.net/2003/03swap/event#hasIntentionState</seealso>
    let hasIntentionState = Prefixed_Name(events, "hasIntentionState") |> PrefixedName
    /// <summary>
    ///   <para>events:hasSubmissionState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSubmissionState">http://eulersharp.sourceforge.net/2003/03swap/event#hasSubmissionState</seealso>
    let hasSubmissionState = Prefixed_Name(events, "hasSubmissionState") |> PrefixedName

    /// <summary>
    ///   <para>events:hasModificationDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasModificationDateTime">http://eulersharp.sourceforge.net/2003/03swap/event#hasModificationDateTime</seealso>
    let hasModificationDateTime =
        Prefixed_Name(events, "hasModificationDateTime") |> PrefixedName

    /// <summary>
    ///   <para>events:hasModifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasModifier">http://eulersharp.sourceforge.net/2003/03swap/event#hasModifier</seealso>
    let hasModifier = Prefixed_Name(events, "hasModifier") |> PrefixedName
    /// <summary>
    ///   <para>events:CompletionState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>completion state</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#CompletionState">http://eulersharp.sourceforge.net/2003/03swap/event#CompletionState</seealso>
    let CompletionState = Prefixed_Name(events, "CompletionState") |> PrefixedName
    /// <summary>
    ///   <para>events:outputOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#outputOf">http://eulersharp.sourceforge.net/2003/03swap/event#outputOf</seealso>
    let outputOf = Prefixed_Name(events, "outputOf") |> PrefixedName
    /// <summary>
    ///   <para>events:hasIntent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasIntent">http://eulersharp.sourceforge.net/2003/03swap/event#hasIntent</seealso>
    let hasIntent = Prefixed_Name(events, "hasIntent") |> PrefixedName

    /// <summary>
    ///   <para>events:hasLatestSubmissionState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>As used in an N3 rule.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasLatestSubmissionState">http://eulersharp.sourceforge.net/2003/03swap/event#hasLatestSubmissionState</seealso>
    let hasLatestSubmissionState =
        Prefixed_Name(events, "hasLatestSubmissionState") |> PrefixedName

    /// <summary>
    ///   <para>events:Completed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:CompletionState</para>
    ///
    /// labels<para>completed</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Completed">http://eulersharp.sourceforge.net/2003/03swap/event#Completed</seealso>
    let Completed = Prefixed_Name(events, "Completed") |> PrefixedName
    /// <summary>
    ///   <para>events:Completion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>completion</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Completion">http://eulersharp.sourceforge.net/2003/03swap/event#Completion</seealso>
    let Completion = Prefixed_Name(events, "Completion") |> PrefixedName
    /// <summary>
    ///   <para>events:UnCompleted</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:CompletionState</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>uncompleted</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#UnCompleted">http://eulersharp.sourceforge.net/2003/03swap/event#UnCompleted</seealso>
    let UnCompleted = Prefixed_Name(events, "UnCompleted") |> PrefixedName
    /// <summary>
    ///   <para>events:Reason</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>reason</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Reason">http://eulersharp.sourceforge.net/2003/03swap/event#Reason</seealso>
    let Reason = Prefixed_Name(events, "Reason") |> PrefixedName
    /// <summary>
    ///   <para>events:hasStartProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasStartProcedure">http://eulersharp.sourceforge.net/2003/03swap/event#hasStartProcedure</seealso>
    let hasStartProcedure = Prefixed_Name(events, "hasStartProcedure") |> PrefixedName
    /// <summary>
    ///   <para>events:hasSubOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has sub output</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSubOutput">http://eulersharp.sourceforge.net/2003/03swap/event#hasSubOutput</seealso>
    let hasSubOutput = Prefixed_Name(events, "hasSubOutput") |> PrefixedName

    /// <summary>
    ///   <para>events:hasSusceptibilityState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSusceptibilityState">http://eulersharp.sourceforge.net/2003/03swap/event#hasSusceptibilityState</seealso>
    let hasSusceptibilityState =
        Prefixed_Name(events, "hasSusceptibilityState") |> PrefixedName

    /// <summary>
    ///   <para>events:hasValidationDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasValidationDateTime">http://eulersharp.sourceforge.net/2003/03swap/event#hasValidationDateTime</seealso>
    let hasValidationDateTime =
        Prefixed_Name(events, "hasValidationDateTime") |> PrefixedName

    /// <summary>
    ///   <para>events:hasVanishingDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasVanishingDateTime">http://eulersharp.sourceforge.net/2003/03swap/event#hasVanishingDateTime</seealso>
    let hasVanishingDateTime =
        Prefixed_Name(events, "hasVanishingDateTime") |> PrefixedName

    /// <summary>
    ///   <para>events:hasWeekday</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasWeekday">http://eulersharp.sourceforge.net/2003/03swap/event#hasWeekday</seealso>
    let hasWeekday = Prefixed_Name(events, "hasWeekday") |> PrefixedName

    /// <summary>
    ///   <para>events:intermediatelySusceptibleTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#intermediatelySusceptibleTo">http://eulersharp.sourceforge.net/2003/03swap/event#intermediatelySusceptibleTo</seealso>
    let intermediatelySusceptibleTo =
        Prefixed_Name(events, "intermediatelySusceptibleTo") |> PrefixedName

    /// <summary>
    ///   <para>events:wheretoSusceptibilityState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#wheretoSusceptibilityState">http://eulersharp.sourceforge.net/2003/03swap/event#wheretoSusceptibilityState</seealso>
    let wheretoSusceptibilityState =
        Prefixed_Name(events, "wheretoSusceptibilityState") |> PrefixedName

    /// <summary>
    ///   <para>events:isReasonFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#isReasonFor">http://eulersharp.sourceforge.net/2003/03swap/event#isReasonFor</seealso>
    let isReasonFor = Prefixed_Name(events, "isReasonFor") |> PrefixedName
    /// <summary>
    ///   <para>events:modificationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#modificationOf">http://eulersharp.sourceforge.net/2003/03swap/event#modificationOf</seealso>
    let modificationOf = Prefixed_Name(events, "modificationOf") |> PrefixedName
    /// <summary>
    ///   <para>events:modifiedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#modifiedIn">http://eulersharp.sourceforge.net/2003/03swap/event#modifiedIn</seealso>
    let modifiedIn = Prefixed_Name(events, "modifiedIn") |> PrefixedName
    /// <summary>
    ///   <para>events:whereinModified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#whereinModified">http://eulersharp.sourceforge.net/2003/03swap/event#whereinModified</seealso>
    let whereinModified = Prefixed_Name(events, "whereinModified") |> PrefixedName
    /// <summary>
    ///   <para>events:obtainedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#obtainedBy">http://eulersharp.sourceforge.net/2003/03swap/event#obtainedBy</seealso>
    let obtainedBy = Prefixed_Name(events, "obtainedBy") |> PrefixedName
    /// <summary>
    ///   <para>events:Saturday</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:Weekday</para>
    ///
    /// labels<para>Saturday</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Saturday">http://eulersharp.sourceforge.net/2003/03swap/event#Saturday</seealso>
    let Saturday = Prefixed_Name(events, "Saturday") |> PrefixedName
    /// <summary>
    ///   <para>events:Strategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>strategy</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Strategy">http://eulersharp.sourceforge.net/2003/03swap/event#Strategy</seealso>
    let Strategy = Prefixed_Name(events, "Strategy") |> PrefixedName
    /// <summary>
    ///   <para>events:hasOutputObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>E.g. a clinical finding, e.g. fever, as object of output of clinical evaluating of a body temperature measurement; a disease as object of a diagnosing; a drug product as object of a prescribing.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOutputObject">http://eulersharp.sourceforge.net/2003/03swap/event#hasOutputObject</seealso>
    let hasOutputObject = Prefixed_Name(events, "hasOutputObject") |> PrefixedName
    /// <summary>
    ///   <para>events:hasPriorityState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasPriorityState">http://eulersharp.sourceforge.net/2003/03swap/event#hasPriorityState</seealso>
    let hasPriorityState = Prefixed_Name(events, "hasPriorityState") |> PrefixedName
    /// <summary>
    ///   <para>events:hasRiskFactor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasRiskFactor">http://eulersharp.sourceforge.net/2003/03swap/event#hasRiskFactor</seealso>
    let hasRiskFactor = Prefixed_Name(events, "hasRiskFactor") |> PrefixedName
    /// <summary>
    ///   <para>events:hasSameDurationAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSameDurationAs">http://eulersharp.sourceforge.net/2003/03swap/event#hasSameDurationAs</seealso>
    let hasSameDurationAs = Prefixed_Name(events, "hasSameDurationAs") |> PrefixedName
    /// <summary>
    ///   <para>events:hasSameTimeAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSameTimeAs">http://eulersharp.sourceforge.net/2003/03swap/event#hasSameTimeAs</seealso>
    let hasSameTimeAs = Prefixed_Name(events, "hasSameTimeAs") |> PrefixedName
    /// <summary>
    ///   <para>events:hasOriginationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasOriginationDate">http://eulersharp.sourceforge.net/2003/03swap/event#hasOriginationDate</seealso>
    let hasOriginationDate = Prefixed_Name(events, "hasOriginationDate") |> PrefixedName
    /// <summary>
    ///   <para>events:hasPathway</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasPathway">http://eulersharp.sourceforge.net/2003/03swap/event#hasPathway</seealso>
    let hasPathway = Prefixed_Name(events, "hasPathway") |> PrefixedName
    /// <summary>
    ///   <para>events:hasReason</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasReason">http://eulersharp.sourceforge.net/2003/03swap/event#hasReason</seealso>
    let hasReason = Prefixed_Name(events, "hasReason") |> PrefixedName
    /// <summary>
    ///   <para>events:hasRecipient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasRecipient">http://eulersharp.sourceforge.net/2003/03swap/event#hasRecipient</seealso>
    let hasRecipient = Prefixed_Name(events, "hasRecipient") |> PrefixedName
    /// <summary>
    ///   <para>events:hasSameBeginningAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasSameBeginningAs">http://eulersharp.sourceforge.net/2003/03swap/event#hasSameBeginningAs</seealso>
    let hasSameBeginningAs = Prefixed_Name(events, "hasSameBeginningAs") |> PrefixedName
    /// <summary>
    ///   <para>events:Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>condition</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Condition">http://eulersharp.sourceforge.net/2003/03swap/event#Condition</seealso>
    let Condition = Prefixed_Name(events, "Condition") |> PrefixedName
    /// <summary>
    ///   <para>events:Created</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:State</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>created</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Created">http://eulersharp.sourceforge.net/2003/03swap/event#Created</seealso>
    let Created = Prefixed_Name(events, "Created") |> PrefixedName
    /// <summary>
    ///   <para>events:Creation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>creation</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Creation">http://eulersharp.sourceforge.net/2003/03swap/event#Creation</seealso>
    let Creation = Prefixed_Name(events, "Creation") |> PrefixedName
    /// <summary>
    ///   <para>events:Creating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>creating</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Creating">http://eulersharp.sourceforge.net/2003/03swap/event#Creating</seealso>
    let Creating = Prefixed_Name(events, "Creating") |> PrefixedName
    /// <summary>
    ///   <para>events:hasObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>E.g. a clinical finding, e.g. fever, as object of a clinical evaluation of a body temperature measurement; a disease as object of a diagnosis; a drug product as object of a prescription.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasObject">http://eulersharp.sourceforge.net/2003/03swap/event#hasObject</seealso>
    let hasObject = Prefixed_Name(events, "hasObject") |> PrefixedName
    /// <summary>
    ///   <para>events:Day</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>day</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Day">http://eulersharp.sourceforge.net/2003/03swap/event#Day</seealso>
    let Day = Prefixed_Name(events, "Day") |> PrefixedName
    /// <summary>
    ///   <para>events:objectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#objectOf">http://eulersharp.sourceforge.net/2003/03swap/event#objectOf</seealso>
    let objectOf = Prefixed_Name(events, "objectOf") |> PrefixedName
    /// <summary>
    ///   <para>events:outputObjectOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#outputObjectOf">http://eulersharp.sourceforge.net/2003/03swap/event#outputObjectOf</seealso>
    let outputObjectOf = Prefixed_Name(events, "outputObjectOf") |> PrefixedName
    /// <summary>
    ///   <para>events:whereinCreated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#whereinCreated">http://eulersharp.sourceforge.net/2003/03swap/event#whereinCreated</seealso>
    let whereinCreated = Prefixed_Name(events, "whereinCreated") |> PrefixedName
    /// <summary>
    ///   <para>events:validationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#validationOf">http://eulersharp.sourceforge.net/2003/03swap/event#validationOf</seealso>
    let validationOf = Prefixed_Name(events, "validationOf") |> PrefixedName
    /// <summary>
    ///   <para>events:whereinDiagnosed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#whereinDiagnosed">http://eulersharp.sourceforge.net/2003/03swap/event#whereinDiagnosed</seealso>
    let whereinDiagnosed = Prefixed_Name(events, "whereinDiagnosed") |> PrefixedName
    /// <summary>
    ///   <para>events:whereinEvaluated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#whereinEvaluated">http://eulersharp.sourceforge.net/2003/03swap/event#whereinEvaluated</seealso>
    let whereinEvaluated = Prefixed_Name(events, "whereinEvaluated") |> PrefixedName
    /// <summary>
    ///   <para>events:whereinTransferred</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>Moved to &lt;http://eulersharp.sourceforge.net/2003/03swap/space#&gt;</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#whereinTransferred">http://eulersharp.sourceforge.net/2003/03swap/event#whereinTransferred</seealso>
    let whereinTransferred = Prefixed_Name(events, "whereinTransferred") |> PrefixedName
    /// <summary>
    ///   <para>events:Urgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:PriorityState</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>urgent</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Urgent">http://eulersharp.sourceforge.net/2003/03swap/event#Urgent</seealso>
    let Urgent = Prefixed_Name(events, "Urgent") |> PrefixedName
    /// <summary>
    ///   <para>events:plannedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#plannedIn">http://eulersharp.sourceforge.net/2003/03swap/event#plannedIn</seealso>
    let plannedIn = Prefixed_Name(events, "plannedIn") |> PrefixedName
    /// <summary>
    ///   <para>events:hasState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasState">http://eulersharp.sourceforge.net/2003/03swap/event#hasState</seealso>
    let hasState = Prefixed_Name(events, "hasState") |> PrefixedName
    /// <summary>
    ///   <para>events:Cyclic</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:CourseMode</para>
    ///
    /// labels<para>cyclic</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Cyclic">http://eulersharp.sourceforge.net/2003/03swap/event#Cyclic</seealso>
    let Cyclic = Prefixed_Name(events, "Cyclic") |> PrefixedName
    /// <summary>
    ///   <para>events:hasDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDuration">http://eulersharp.sourceforge.net/2003/03swap/event#hasDuration</seealso>
    let hasDuration = Prefixed_Name(events, "hasDuration") |> PrefixedName
    /// <summary>
    ///   <para>events:Delivery</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>delivery</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Delivery">http://eulersharp.sourceforge.net/2003/03swap/event#Delivery</seealso>
    let Delivery = Prefixed_Name(events, "Delivery") |> PrefixedName
    /// <summary>
    ///   <para>events:DemandState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>demand state</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#DemandState">http://eulersharp.sourceforge.net/2003/03swap/event#DemandState</seealso>
    let DemandState = Prefixed_Name(events, "DemandState") |> PrefixedName
    /// <summary>
    ///   <para>events:Diagnosing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>diagnosing</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Diagnosing">http://eulersharp.sourceforge.net/2003/03swap/event#Diagnosing</seealso>
    let Diagnosing = Prefixed_Name(events, "Diagnosing") |> PrefixedName
    /// <summary>
    ///   <para>events:Diagnosis</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>diagnosis</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Diagnosis">http://eulersharp.sourceforge.net/2003/03swap/event#Diagnosis</seealso>
    let Diagnosis = Prefixed_Name(events, "Diagnosis") |> PrefixedName
    /// <summary>
    ///   <para>events:DiagnosisState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>diagnosis state</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#DiagnosisState">http://eulersharp.sourceforge.net/2003/03swap/event#DiagnosisState</seealso>
    let DiagnosisState = Prefixed_Name(events, "DiagnosisState") |> PrefixedName
    /// <summary>
    ///   <para>events:Suspected</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:State</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>suspected</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Suspected">http://eulersharp.sourceforge.net/2003/03swap/event#Suspected</seealso>
    let Suspected = Prefixed_Name(events, "Suspected") |> PrefixedName
    /// <summary>
    ///   <para>events:Verified</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:State</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>verified</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Verified">http://eulersharp.sourceforge.net/2003/03swap/event#Verified</seealso>
    let Verified = Prefixed_Name(events, "Verified") |> PrefixedName
    /// <summary>
    ///   <para>events:UnVerified</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:State</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>unverified</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#UnVerified">http://eulersharp.sourceforge.net/2003/03swap/event#UnVerified</seealso>
    let UnVerified = Prefixed_Name(events, "UnVerified") |> PrefixedName
    /// <summary>
    ///   <para>events:Procedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>procedure</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Procedure">http://eulersharp.sourceforge.net/2003/03swap/event#Procedure</seealso>
    let Procedure = Prefixed_Name(events, "Procedure") |> PrefixedName
    /// <summary>
    ///   <para>events:Education</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>education</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Education">http://eulersharp.sourceforge.net/2003/03swap/event#Education</seealso>
    let Education = Prefixed_Name(events, "Education") |> PrefixedName
    /// <summary>
    ///   <para>events:EndingMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>ending mode</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#EndingMode">http://eulersharp.sourceforge.net/2003/03swap/event#EndingMode</seealso>
    let EndingMode = Prefixed_Name(events, "EndingMode") |> PrefixedName
    /// <summary>
    ///   <para>events:Evaluated</para>
    /// </summary>
    /// <remarks>
    ///   <para>events:State</para>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>evaluated</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Evaluated">http://eulersharp.sourceforge.net/2003/03swap/event#Evaluated</seealso>
    let Evaluated = Prefixed_Name(events, "Evaluated") |> PrefixedName
    /// <summary>
    ///   <para>events:Evaluating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>evaluating</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Evaluating">http://eulersharp.sourceforge.net/2003/03swap/event#Evaluating</seealso>
    let Evaluating = Prefixed_Name(events, "Evaluating") |> PrefixedName
    /// <summary>
    ///   <para>events:Evaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>evaluation</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Evaluation">http://eulersharp.sourceforge.net/2003/03swap/event#Evaluation</seealso>
    let Evaluation = Prefixed_Name(events, "Evaluation") |> PrefixedName
    /// <summary>
    ///   <para>events:examiningOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>examining of</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#examiningOf">http://eulersharp.sourceforge.net/2003/03swap/event#examiningOf</seealso>
    let examiningOf = Prefixed_Name(events, "examiningOf") |> PrefixedName
    /// <summary>
    ///   <para>events:exists</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#exists">http://eulersharp.sourceforge.net/2003/03swap/event#exists</seealso>
    let exists = Prefixed_Name(events, "exists") |> PrefixedName
    /// <summary>
    ///   <para>events:begins</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Using the Unix Epoch time.</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#begins">http://eulersharp.sourceforge.net/2003/03swap/event#begins</seealso>
    let begins = Prefixed_Name(events, "begins") |> PrefixedName

    /// <summary>
    ///   <para>events:AbsoluteContraindication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>absolute contraindication</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#AbsoluteContraindication">http://eulersharp.sourceforge.net/2003/03swap/event#AbsoluteContraindication</seealso>
    let AbsoluteContraindication =
        Prefixed_Name(events, "AbsoluteContraindication") |> PrefixedName

    /// <summary>
    ///   <para>events:Authentication</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>authentication</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Authentication">http://eulersharp.sourceforge.net/2003/03swap/event#Authentication</seealso>
    let Authentication = Prefixed_Name(events, "Authentication") |> PrefixedName
    /// <summary>
    ///   <para>events:Interacting</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>interacting</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Interacting">http://eulersharp.sourceforge.net/2003/03swap/event#Interacting</seealso>
    let Interacting = Prefixed_Name(events, "Interacting") |> PrefixedName
    /// <summary>
    ///   <para>events:Interaction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>interaction</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#Interaction">http://eulersharp.sourceforge.net/2003/03swap/event#Interaction</seealso>
    let Interaction = Prefixed_Name(events, "Interaction") |> PrefixedName

    /// <summary>
    ///   <para>events:hasCreationDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasCreationDateTime">http://eulersharp.sourceforge.net/2003/03swap/event#hasCreationDateTime</seealso>
    let hasCreationDateTime =
        Prefixed_Name(events, "hasCreationDateTime") |> PrefixedName

    /// <summary>
    ///   <para>events:hasDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/event#hasDate">http://eulersharp.sourceforge.net/2003/03swap/event#hasDate</seealso>
    let hasDate = Prefixed_Name(events, "hasDate") |> PrefixedName
