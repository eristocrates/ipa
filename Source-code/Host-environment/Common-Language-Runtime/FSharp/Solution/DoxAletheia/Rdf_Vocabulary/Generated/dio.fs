namespace https.w3id.org.dio.hash

open DoxAletheia

module dio =
    let _namespace_name = "https://w3id.org/dio#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#Active"></see>
    /// </summary>
    let Active = _prefix "Active"
    /// <summary>
    ///   <see href="https://w3id.org/dio#Status"></see>
    /// </summary>
    let Status = _prefix "Status"
    /// <summary>
    ///   <see href="https://w3id.org/dio#AlternativeSolution"></see>
    /// </summary>
    let AlternativeSolution = _prefix "AlternativeSolution"
    /// <summary>
    ///   <see href="https://w3id.org/dio#Solution"></see>
    /// </summary>
    let Solution = _prefix "Solution"
    /// <summary>
    ///   <see href="https://w3id.org/dio#Argument"></see>
    /// </summary>
    let Argument = _prefix "Argument"
    /// <summary>
    ///   <see href="https://w3id.org/dio#DesignIntentArtifact"></see>
    /// </summary>
    let DesignIntentArtifact = _prefix "DesignIntentArtifact"
    /// <summary>
    ///   <see href="https://w3id.org/dio#Assumption"></see>
    /// </summary>
    let Assumption = _prefix "Assumption"
    /// <summary>
    ///   <see href="https://w3id.org/dio#Comment"></see>
    /// </summary>
    let Comment = _prefix "Comment"
    /// <summary>
    ///   <see href="https://w3id.org/dio#Constraint"></see>
    /// </summary>
    let Constraint = _prefix "Constraint"
    /// <summary>
    ///   <see href="https://w3id.org/dio#Design"></see>
    /// </summary>
    let Design = _prefix "Design"
    /// <summary>
    ///   <see href="https://w3id.org/dio#DesignDecision"></see>
    /// </summary>
    let DesignDecision = _prefix "DesignDecision"
    /// <summary>
    ///   <see href="https://w3id.org/dio#DesignGoal"></see>
    /// </summary>
    let DesignGoal = _prefix "DesignGoal"
    /// <summary>
    ///   <see href="https://w3id.org/dio#hasAlternativeSolution"></see>
    /// </summary>
    let hasAlternativeSolution = _prefix "hasAlternativeSolution"
    /// <summary>
    ///   <see href="https://w3id.org/dio#MandatedSolution"></see>
    /// </summary>
    let MandatedSolution = _prefix "MandatedSolution"
    /// <summary>
    ///   <see href="https://w3id.org/dio#hasMandatedSolution"></see>
    /// </summary>
    let hasMandatedSolution = _prefix "hasMandatedSolution"
    /// <summary>
    ///   <see href="https://w3id.org/dio#DesignIssue"></see>
    /// </summary>
    let DesignIssue = _prefix "DesignIssue"
    /// <summary>
    ///   <see href="https://w3id.org/dio#DesignIntent"></see>
    /// </summary>
    let DesignIntent = _prefix "DesignIntent"
    /// <summary>
    ///   <see href="https://w3id.org/dio#version"></see>
    /// </summary>
    let version = _prefix "version"
    /// <summary>
    ///   <see href="https://w3id.org/dio#DesignRequirement"></see>
    /// </summary>
    let DesignRequirement = _prefix "DesignRequirement"
    /// <summary>
    ///   <see href="https://w3id.org/dio#Evaluation"></see>
    /// </summary>
    let Evaluation = _prefix "Evaluation"
    /// <summary>
    ///   <see href="https://w3id.org/dio#Evidence"></see>
    /// </summary>
    let Evidence = _prefix "Evidence"
    /// <summary>
    ///   <see href="https://w3id.org/dio#Heuristic"></see>
    /// </summary>
    let Heuristic = _prefix "Heuristic"
    /// <summary>
    ///   <see href="https://w3id.org/dio#Justification"></see>
    /// </summary>
    let Justification = _prefix "Justification"
    /// <summary>
    ///   <see href="https://w3id.org/dio#OnHold"></see>
    /// </summary>
    let OnHold = _prefix "OnHold"
    /// <summary>
    ///   <see href="https://w3id.org/dio#RationaleCaptureMethod"></see>
    /// </summary>
    let RationaleCaptureMethod = _prefix "RationaleCaptureMethod"
    /// <summary>
    ///   <see href="https://w3id.org/dio#Resolved"></see>
    /// </summary>
    let Resolved = _prefix "Resolved"
    /// <summary>
    ///   <see href="https://w3id.org/dio#Terminated"></see>
    /// </summary>
    let Terminated = _prefix "Terminated"
    /// <summary>
    ///   <see href="https://w3id.org/dio#addressedBy"></see>
    /// </summary>
    let addressedBy = _prefix "addressedBy"
    /// <summary>
    ///   <see href="https://w3id.org/dio#captureMethodology"></see>
    /// </summary>
    let captureMethodology = _prefix "captureMethodology"
    /// <summary>
    ///   <see href="https://w3id.org/dio#contradicts"></see>
    /// </summary>
    let contradicts = _prefix "contradicts"
    /// <summary>
    ///   <see href="https://w3id.org/dio#fulfillsRequirement"></see>
    /// </summary>
    let fulfillsRequirement = _prefix "fulfillsRequirement"
    /// <summary>
    ///   <see href="https://w3id.org/dio#requirementFulfilledBy"></see>
    /// </summary>
    let requirementFulfilledBy = _prefix "requirementFulfilledBy"
    /// <summary>
    ///   <see href="https://w3id.org/dio#governsDesign"></see>
    /// </summary>
    let governsDesign = _prefix "governsDesign"
    /// <summary>
    ///   <see href="https://w3id.org/dio#hasArgument"></see>
    /// </summary>
    let hasArgument = _prefix "hasArgument"
    /// <summary>
    ///   <see href="https://w3id.org/dio#hasComment"></see>
    /// </summary>
    let hasComment = _prefix "hasComment"
    /// <summary>
    ///   <see href="https://w3id.org/dio#hasConstraint"></see>
    /// </summary>
    let hasConstraint = _prefix "hasConstraint"
    /// <summary>
    ///   <see href="https://w3id.org/dio#hasEvidence"></see>
    /// </summary>
    let hasEvidence = _prefix "hasEvidence"
    /// <summary>
    ///   <see href="https://w3id.org/dio#hasJustification"></see>
    /// </summary>
    let hasJustification = _prefix "hasJustification"
    /// <summary>
    ///   <see href="https://w3id.org/dio#hasStatus"></see>
    /// </summary>
    let hasStatus = _prefix "hasStatus"
    /// <summary>
    ///   <see href="https://w3id.org/dio#intentAddresses"></see>
    /// </summary>
    let intentAddresses = _prefix "intentAddresses"
    /// <summary>
    ///   <see href="https://w3id.org/dio#leadsTo"></see>
    /// </summary>
    let leadsTo = _prefix "leadsTo"
    /// <summary>
    ///   <see href="https://w3id.org/dio#providesAlternativeSolution"></see>
    /// </summary>
    let providesAlternativeSolution = _prefix "providesAlternativeSolution"
    /// <summary>
    ///   <see href="https://w3id.org/dio#providesMandatedSolution"></see>
    /// </summary>
    let providesMandatedSolution = _prefix "providesMandatedSolution"
    /// <summary>
    ///   <see href="https://w3id.org/dio#rationaleCapturedUsing"></see>
    /// </summary>
    let rationaleCapturedUsing = _prefix "rationaleCapturedUsing"
    /// <summary>
    ///   <see href="https://w3id.org/dio#refines"></see>
    /// </summary>
    let refines = _prefix "refines"
    /// <summary>
    ///   <see href="https://w3id.org/dio#supports"></see>
    /// </summary>
    let supports = _prefix "supports"
    /// <summary>
    ///   <see href="https://w3id.org/dio#usesAssumption"></see>
    /// </summary>
    let usesAssumption = _prefix "usesAssumption"
    /// <summary>
    ///   <see href="https://w3id.org/dio#usesHeuristic"></see>
    /// </summary>
    let usesHeuristic = _prefix "usesHeuristic"
