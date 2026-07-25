namespace https.w3id.org.dio.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module dio =
    let _namespace_iri = Namespace_Iri dio |> NamespaceIRI
    /// <summary>
    ///   <para>dio:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dio#">https://w3id.org/dio#</seealso>
    let _prefix_iri = Prefixed_Name(dio, "") |> PrefixedName
    /// <summary>
    ///   <para>dio:Active</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:dio#Status</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dio#Active">https://w3id.org/dio#Active</seealso>
    let Active = Prefixed_Name(dio, "Active") |> PrefixedName
    /// <summary>
    ///   <para>dio:Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Status</para></remarks>
    /// <seealso href="https://w3id.org/dio#Status">https://w3id.org/dio#Status</seealso>
    let Status = Prefixed_Name(dio, "Status") |> PrefixedName
    /// <summary>
    ///   <para>dio:Argument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Argument</para></remarks>
    /// <seealso href="https://w3id.org/dio#Argument">https://w3id.org/dio#Argument</seealso>
    let Argument = Prefixed_Name(dio, "Argument") |> PrefixedName
    /// <summary>
    ///   <para>dio:Assumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Assumption</para></remarks>
    /// <seealso href="https://w3id.org/dio#Assumption">https://w3id.org/dio#Assumption</seealso>
    let Assumption = Prefixed_Name(dio, "Assumption") |> PrefixedName
    /// <summary>
    ///   <para>dio:Justification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>A reason supporting the proposed solution.</para><para>Justification</para></remarks>
    /// <seealso href="https://w3id.org/dio#Justification">https://w3id.org/dio#Justification</seealso>
    let Justification = Prefixed_Name(dio, "Justification") |> PrefixedName
    /// <summary>
    ///   <para>dio:DesignGoal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Design Goal</para></remarks>
    /// <seealso href="https://w3id.org/dio#DesignGoal">https://w3id.org/dio#DesignGoal</seealso>
    let DesignGoal = Prefixed_Name(dio, "DesignGoal") |> PrefixedName
    /// <summary>
    ///   <para>dio:addressedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>addressedBy</para></remarks>
    /// <seealso href="https://w3id.org/dio#addressedBy">https://w3id.org/dio#addressedBy</seealso>
    let addressedBy = Prefixed_Name(dio, "addressedBy") |> PrefixedName
    /// <summary>
    ///   <para>dio:fulfillsRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>fullfillsRequirements</para></remarks>
    /// <seealso href="https://w3id.org/dio#fulfillsRequirement">https://w3id.org/dio#fulfillsRequirement</seealso>
    let fulfillsRequirement = Prefixed_Name(dio, "fulfillsRequirement") |> PrefixedName

    /// <summary>
    ///   <para>dio:requirementFulfilledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>requirementFulfilledBy</para></remarks>
    /// <seealso href="https://w3id.org/dio#requirementFulfilledBy">https://w3id.org/dio#requirementFulfilledBy</seealso>
    let requirementFulfilledBy =
        Prefixed_Name(dio, "requirementFulfilledBy") |> PrefixedName

    /// <summary>
    ///   <para>dio:hasComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasComment</para></remarks>
    /// <seealso href="https://w3id.org/dio#hasComment">https://w3id.org/dio#hasComment</seealso>
    let hasComment = Prefixed_Name(dio, "hasComment") |> PrefixedName
    /// <summary>
    ///   <para>dio:usesHeuristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>usesHeuristic</para></remarks>
    /// <seealso href="https://w3id.org/dio#usesHeuristic">https://w3id.org/dio#usesHeuristic</seealso>
    let usesHeuristic = Prefixed_Name(dio, "usesHeuristic") |> PrefixedName
    /// <summary>
    ///   <para>dio:AlternativeSolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Alternative Solution</para></remarks>
    /// <seealso href="https://w3id.org/dio#AlternativeSolution">https://w3id.org/dio#AlternativeSolution</seealso>
    let AlternativeSolution = Prefixed_Name(dio, "AlternativeSolution") |> PrefixedName
    /// <summary>
    ///   <para>dio:Solution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Solution</para></remarks>
    /// <seealso href="https://w3id.org/dio#Solution">https://w3id.org/dio#Solution</seealso>
    let Solution = Prefixed_Name(dio, "Solution") |> PrefixedName
    /// <summary>
    ///   <para>dio:Comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Comment</para></remarks>
    /// <seealso href="https://w3id.org/dio#Comment">https://w3id.org/dio#Comment</seealso>
    let Comment = Prefixed_Name(dio, "Comment") |> PrefixedName
    /// <summary>
    ///   <para>dio:DesignDecision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Design Decision</para></remarks>
    /// <seealso href="https://w3id.org/dio#DesignDecision">https://w3id.org/dio#DesignDecision</seealso>
    let DesignDecision = Prefixed_Name(dio, "DesignDecision") |> PrefixedName
    /// <summary>
    ///   <para>dio:hasMandatedSolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasMandatedSolution</para></remarks>
    /// <seealso href="https://w3id.org/dio#hasMandatedSolution">https://w3id.org/dio#hasMandatedSolution</seealso>
    let hasMandatedSolution = Prefixed_Name(dio, "hasMandatedSolution") |> PrefixedName
    /// <summary>
    ///   <para>dio:Constraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Constraint</para></remarks>
    /// <seealso href="https://w3id.org/dio#Constraint">https://w3id.org/dio#Constraint</seealso>
    let Constraint = Prefixed_Name(dio, "Constraint") |> PrefixedName
    /// <summary>
    ///   <para>dio:Design</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Design</para></remarks>
    /// <seealso href="https://w3id.org/dio#Design">https://w3id.org/dio#Design</seealso>
    let Design = Prefixed_Name(dio, "Design") |> PrefixedName
    /// <summary>
    ///   <para>dio:MandatedSolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Mandated Solution</para></remarks>
    /// <seealso href="https://w3id.org/dio#MandatedSolution">https://w3id.org/dio#MandatedSolution</seealso>
    let MandatedSolution = Prefixed_Name(dio, "MandatedSolution") |> PrefixedName

    /// <summary>
    ///   <para>dio:hasAlternativeSolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasAlternativeSolution</para></remarks>
    /// <seealso href="https://w3id.org/dio#hasAlternativeSolution">https://w3id.org/dio#hasAlternativeSolution</seealso>
    let hasAlternativeSolution =
        Prefixed_Name(dio, "hasAlternativeSolution") |> PrefixedName

    /// <summary>
    ///   <para>dio:DesignIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Design Issue</para></remarks>
    /// <seealso href="https://w3id.org/dio#DesignIssue">https://w3id.org/dio#DesignIssue</seealso>
    let DesignIssue = Prefixed_Name(dio, "DesignIssue") |> PrefixedName
    /// <summary>
    ///   <para>dio:DesignIntent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Design Intent</para></remarks>
    /// <seealso href="https://w3id.org/dio#DesignIntent">https://w3id.org/dio#DesignIntent</seealso>
    let DesignIntent = Prefixed_Name(dio, "DesignIntent") |> PrefixedName
    /// <summary>
    ///   <para>dio:version</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dio#version">https://w3id.org/dio#version</seealso>
    let version = Prefixed_Name(dio, "version") |> PrefixedName
    /// <summary>
    ///   <para>dio:DesignRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Design Requirements</para></remarks>
    /// <seealso href="https://w3id.org/dio#DesignRequirement">https://w3id.org/dio#DesignRequirement</seealso>
    let DesignRequirement = Prefixed_Name(dio, "DesignRequirement") |> PrefixedName
    /// <summary>
    ///   <para>dio:Evidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dio#Evidence">https://w3id.org/dio#Evidence</seealso>
    let Evidence = Prefixed_Name(dio, "Evidence") |> PrefixedName
    /// <summary>
    ///   <para>dio:Evaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Evaluation</para></remarks>
    /// <seealso href="https://w3id.org/dio#Evaluation">https://w3id.org/dio#Evaluation</seealso>
    let Evaluation = Prefixed_Name(dio, "Evaluation") |> PrefixedName
    /// <summary>
    ///   <para>dio:Heuristic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Heuristic</para></remarks>
    /// <seealso href="https://w3id.org/dio#Heuristic">https://w3id.org/dio#Heuristic</seealso>
    let Heuristic = Prefixed_Name(dio, "Heuristic") |> PrefixedName
    /// <summary>
    ///   <para>dio:OnHold</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dio#Status</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dio#OnHold">https://w3id.org/dio#OnHold</seealso>
    let OnHold = Prefixed_Name(dio, "OnHold") |> PrefixedName

    /// <summary>
    ///   <para>dio:RationaleCaptureMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Rationale Capture Methodology</para></remarks>
    /// <seealso href="https://w3id.org/dio#RationaleCaptureMethod">https://w3id.org/dio#RationaleCaptureMethod</seealso>
    let RationaleCaptureMethod =
        Prefixed_Name(dio, "RationaleCaptureMethod") |> PrefixedName

    /// <summary>
    ///   <para>dio:Terminated</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:dio#Status</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dio#Terminated">https://w3id.org/dio#Terminated</seealso>
    let Terminated = Prefixed_Name(dio, "Terminated") |> PrefixedName
    /// <summary>
    ///   <para>dio:Resolved</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:dio#Status</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/dio#Resolved">https://w3id.org/dio#Resolved</seealso>
    let Resolved = Prefixed_Name(dio, "Resolved") |> PrefixedName
    /// <summary>
    ///   <para>dio:captureMethodology</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>captureMethodology</para></remarks>
    /// <seealso href="https://w3id.org/dio#captureMethodology">https://w3id.org/dio#captureMethodology</seealso>
    let captureMethodology = Prefixed_Name(dio, "captureMethodology") |> PrefixedName
    /// <summary>
    ///   <para>dio:contradicts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>contradicts</para></remarks>
    /// <seealso href="https://w3id.org/dio#contradicts">https://w3id.org/dio#contradicts</seealso>
    let contradicts = Prefixed_Name(dio, "contradicts") |> PrefixedName
    /// <summary>
    ///   <para>dio:hasArgument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasArgument</para></remarks>
    /// <seealso href="https://w3id.org/dio#hasArgument">https://w3id.org/dio#hasArgument</seealso>
    let hasArgument = Prefixed_Name(dio, "hasArgument") |> PrefixedName
    /// <summary>
    ///   <para>dio:hasJustification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasJustification</para></remarks>
    /// <seealso href="https://w3id.org/dio#hasJustification">https://w3id.org/dio#hasJustification</seealso>
    let hasJustification = Prefixed_Name(dio, "hasJustification") |> PrefixedName
    /// <summary>
    ///   <para>dio:intentAddresses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>intentAddresses</para></remarks>
    /// <seealso href="https://w3id.org/dio#intentAddresses">https://w3id.org/dio#intentAddresses</seealso>
    let intentAddresses = Prefixed_Name(dio, "intentAddresses") |> PrefixedName

    /// <summary>
    ///   <para>dio:providesAlternativeSolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>providesAlternativeSolution</para></remarks>
    /// <seealso href="https://w3id.org/dio#providesAlternativeSolution">https://w3id.org/dio#providesAlternativeSolution</seealso>
    let providesAlternativeSolution =
        Prefixed_Name(dio, "providesAlternativeSolution") |> PrefixedName

    /// <summary>
    ///   <para>dio:rationaleCapturedUsing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>rationaleCapturedUsing</para></remarks>
    /// <seealso href="https://w3id.org/dio#rationaleCapturedUsing">https://w3id.org/dio#rationaleCapturedUsing</seealso>
    let rationaleCapturedUsing =
        Prefixed_Name(dio, "rationaleCapturedUsing") |> PrefixedName

    /// <summary>
    ///   <para>dio:supports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>supports</para></remarks>
    /// <seealso href="https://w3id.org/dio#supports">https://w3id.org/dio#supports</seealso>
    let supports = Prefixed_Name(dio, "supports") |> PrefixedName
    /// <summary>
    ///   <para>dio:usesAssumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>usesAssumption</para></remarks>
    /// <seealso href="https://w3id.org/dio#usesAssumption">https://w3id.org/dio#usesAssumption</seealso>
    let usesAssumption = Prefixed_Name(dio, "usesAssumption") |> PrefixedName
    /// <summary>
    ///   <para>dio:governsDesign</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>governsDesign</para></remarks>
    /// <seealso href="https://w3id.org/dio#governsDesign">https://w3id.org/dio#governsDesign</seealso>
    let governsDesign = Prefixed_Name(dio, "governsDesign") |> PrefixedName
    /// <summary>
    ///   <para>dio:hasEvidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasEvidence</para></remarks>
    /// <seealso href="https://w3id.org/dio#hasEvidence">https://w3id.org/dio#hasEvidence</seealso>
    let hasEvidence = Prefixed_Name(dio, "hasEvidence") |> PrefixedName
    /// <summary>
    ///   <para>dio:leadsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>leadsTo</para></remarks>
    /// <seealso href="https://w3id.org/dio#leadsTo">https://w3id.org/dio#leadsTo</seealso>
    let leadsTo = Prefixed_Name(dio, "leadsTo") |> PrefixedName

    /// <summary>
    ///   <para>dio:providesMandatedSolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>providesMandatedSolution</para></remarks>
    /// <seealso href="https://w3id.org/dio#providesMandatedSolution">https://w3id.org/dio#providesMandatedSolution</seealso>
    let providesMandatedSolution =
        Prefixed_Name(dio, "providesMandatedSolution") |> PrefixedName

    /// <summary>
    ///   <para>dio:refines</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>refines</para></remarks>
    /// <seealso href="https://w3id.org/dio#refines">https://w3id.org/dio#refines</seealso>
    let refines = Prefixed_Name(dio, "refines") |> PrefixedName
    /// <summary>
    ///   <para>dio:hasConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasConstraint</para></remarks>
    /// <seealso href="https://w3id.org/dio#hasConstraint">https://w3id.org/dio#hasConstraint</seealso>
    let hasConstraint = Prefixed_Name(dio, "hasConstraint") |> PrefixedName
    /// <summary>
    ///   <para>dio:hasStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasStatus</para></remarks>
    /// <seealso href="https://w3id.org/dio#hasStatus">https://w3id.org/dio#hasStatus</seealso>
    let hasStatus = Prefixed_Name(dio, "hasStatus") |> PrefixedName

    /// <summary>
    ///   <para>dio:DesignIntentArtifact</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Design Intent Artifact</para></remarks>
    /// <seealso href="https://w3id.org/dio#DesignIntentArtifact">https://w3id.org/dio#DesignIntentArtifact</seealso>
    let DesignIntentArtifact =
        Prefixed_Name(dio, "DesignIntentArtifact") |> PrefixedName
