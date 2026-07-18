namespace https.w3id.org.dio.hash

open DoxAletheia.Rdf_Vocabulary

module dio =
    let _namespace_name = "https://w3id.org/dio#"
    /// <summary>
    ///   <see href="https://w3id.org/dio#Active"></see>
    /// </summary>
    let Active = Namespaced_IRI.parse _namespace_name "Active" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dio#Status"></see>
    /// </summary>
    let Status = Namespaced_IRI.parse _namespace_name "Status" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#AlternativeSolution"></see>
    /// </summary>
    let AlternativeSolution =
        Namespaced_IRI.parse _namespace_name "AlternativeSolution" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#Solution"></see>
    /// </summary>
    let Solution = Namespaced_IRI.parse _namespace_name "Solution" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dio#Argument"></see>
    /// </summary>
    let Argument = Namespaced_IRI.parse _namespace_name "Argument" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#DesignIntentArtifact"></see>
    /// </summary>
    let DesignIntentArtifact =
        Namespaced_IRI.parse _namespace_name "DesignIntentArtifact" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#Assumption"></see>
    /// </summary>
    let Assumption = Namespaced_IRI.parse _namespace_name "Assumption" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dio#Comment"></see>
    /// </summary>
    let Comment = Namespaced_IRI.parse _namespace_name "Comment" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dio#Constraint"></see>
    /// </summary>
    let Constraint = Namespaced_IRI.parse _namespace_name "Constraint" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dio#Design"></see>
    /// </summary>
    let Design = Namespaced_IRI.parse _namespace_name "Design" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#DesignDecision"></see>
    /// </summary>
    let DesignDecision =
        Namespaced_IRI.parse _namespace_name "DesignDecision" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#DesignGoal"></see>
    /// </summary>
    let DesignGoal = Namespaced_IRI.parse _namespace_name "DesignGoal" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#hasAlternativeSolution"></see>
    /// </summary>
    let hasAlternativeSolution =
        Namespaced_IRI.parse _namespace_name "hasAlternativeSolution" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#MandatedSolution"></see>
    /// </summary>
    let MandatedSolution =
        Namespaced_IRI.parse _namespace_name "MandatedSolution" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#hasMandatedSolution"></see>
    /// </summary>
    let hasMandatedSolution =
        Namespaced_IRI.parse _namespace_name "hasMandatedSolution" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#DesignIssue"></see>
    /// </summary>
    let DesignIssue =
        Namespaced_IRI.parse _namespace_name "DesignIssue" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#DesignIntent"></see>
    /// </summary>
    let DesignIntent =
        Namespaced_IRI.parse _namespace_name "DesignIntent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#version"></see>
    /// </summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#DesignRequirement"></see>
    /// </summary>
    let DesignRequirement =
        Namespaced_IRI.parse _namespace_name "DesignRequirement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#Evaluation"></see>
    /// </summary>
    let Evaluation = Namespaced_IRI.parse _namespace_name "Evaluation" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dio#Evidence"></see>
    /// </summary>
    let Evidence = Namespaced_IRI.parse _namespace_name "Evidence" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dio#Heuristic"></see>
    /// </summary>
    let Heuristic = Namespaced_IRI.parse _namespace_name "Heuristic" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#Justification"></see>
    /// </summary>
    let Justification =
        Namespaced_IRI.parse _namespace_name "Justification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#OnHold"></see>
    /// </summary>
    let OnHold = Namespaced_IRI.parse _namespace_name "OnHold" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#RationaleCaptureMethod"></see>
    /// </summary>
    let RationaleCaptureMethod =
        Namespaced_IRI.parse _namespace_name "RationaleCaptureMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#Resolved"></see>
    /// </summary>
    let Resolved = Namespaced_IRI.parse _namespace_name "Resolved" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dio#Terminated"></see>
    /// </summary>
    let Terminated = Namespaced_IRI.parse _namespace_name "Terminated" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#addressedBy"></see>
    /// </summary>
    let addressedBy =
        Namespaced_IRI.parse _namespace_name "addressedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#captureMethodology"></see>
    /// </summary>
    let captureMethodology =
        Namespaced_IRI.parse _namespace_name "captureMethodology" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#contradicts"></see>
    /// </summary>
    let contradicts =
        Namespaced_IRI.parse _namespace_name "contradicts" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#fulfillsRequirement"></see>
    /// </summary>
    let fulfillsRequirement =
        Namespaced_IRI.parse _namespace_name "fulfillsRequirement" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#requirementFulfilledBy"></see>
    /// </summary>
    let requirementFulfilledBy =
        Namespaced_IRI.parse _namespace_name "requirementFulfilledBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#governsDesign"></see>
    /// </summary>
    let governsDesign =
        Namespaced_IRI.parse _namespace_name "governsDesign" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#hasArgument"></see>
    /// </summary>
    let hasArgument =
        Namespaced_IRI.parse _namespace_name "hasArgument" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#hasComment"></see>
    /// </summary>
    let hasComment = Namespaced_IRI.parse _namespace_name "hasComment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#hasConstraint"></see>
    /// </summary>
    let hasConstraint =
        Namespaced_IRI.parse _namespace_name "hasConstraint" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#hasEvidence"></see>
    /// </summary>
    let hasEvidence =
        Namespaced_IRI.parse _namespace_name "hasEvidence" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#hasJustification"></see>
    /// </summary>
    let hasJustification =
        Namespaced_IRI.parse _namespace_name "hasJustification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#hasStatus"></see>
    /// </summary>
    let hasStatus = Namespaced_IRI.parse _namespace_name "hasStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#intentAddresses"></see>
    /// </summary>
    let intentAddresses =
        Namespaced_IRI.parse _namespace_name "intentAddresses" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#leadsTo"></see>
    /// </summary>
    let leadsTo = Namespaced_IRI.parse _namespace_name "leadsTo" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#providesAlternativeSolution"></see>
    /// </summary>
    let providesAlternativeSolution =
        Namespaced_IRI.parse _namespace_name "providesAlternativeSolution" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#providesMandatedSolution"></see>
    /// </summary>
    let providesMandatedSolution =
        Namespaced_IRI.parse _namespace_name "providesMandatedSolution" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#rationaleCapturedUsing"></see>
    /// </summary>
    let rationaleCapturedUsing =
        Namespaced_IRI.parse _namespace_name "rationaleCapturedUsing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#refines"></see>
    /// </summary>
    let refines = Namespaced_IRI.parse _namespace_name "refines" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/dio#supports"></see>
    /// </summary>
    let supports = Namespaced_IRI.parse _namespace_name "supports" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#usesAssumption"></see>
    /// </summary>
    let usesAssumption =
        Namespaced_IRI.parse _namespace_name "usesAssumption" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/dio#usesHeuristic"></see>
    /// </summary>
    let usesHeuristic =
        Namespaced_IRI.parse _namespace_name "usesHeuristic" |> NamespacedName
