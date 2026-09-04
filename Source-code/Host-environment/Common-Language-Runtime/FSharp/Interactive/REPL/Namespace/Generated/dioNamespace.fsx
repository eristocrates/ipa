#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module dio =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/dio#" "dio"
    let _namespaceIri = _prefixId.prefix ""
    let Active = _prefixId.prefix "Active"
    /// <summary>
    ///   <para>dce:description : An entity representing the proposed solution.^^xsd:string</para>
    ///   <para>rdfs:label : Alternative Solution^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#AlternativeSolution">dio:AlternativeSolution</a>
    /// </summary>
    let AlternativeSolution = _prefixId.prefix "AlternativeSolution"
    /// <summary>
    ///   <para>dce:description : A reason presented against a proposed solution.^^xsd:string</para>
    ///   <para>rdfs:label : Argument^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#Argument">dio:Argument</a>
    /// </summary>
    let Argument = _prefixId.prefix "Argument"
    /// <summary>
    ///   <para>dce:description : The assumption on which a proposed solution is based.^^xsd:string</para>
    ///   <para>rdfs:label : Assumption^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#Assumption">dio:Assumption</a>
    /// </summary>
    let Assumption = _prefixId.prefix "Assumption"
    /// <summary>
    ///   <para>dce:description : A comment made by an agent in response to an argument, a justification or another comment^^xsd:string</para>
    ///   <para>rdfs:label : Comment^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#Comment">dio:Comment</a>
    /// </summary>
    let Comment = _prefixId.prefix "Comment"
    /// <summary>
    ///   <para>dce:description : A constraint that underlies the proposed solution.^^xsd:string</para>
    ///   <para>rdfs:label : Constraint^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#Constraint">dio:Constraint</a>
    /// </summary>
    let Constraint = _prefixId.prefix "Constraint"
    /// <summary>
    ///   <para>dce:description : A design is a specification of an object, manifested by an agent, intended to accomplish goals, in a particular environment, using a set of  components, satisfying a set of requirements, subject to constraints.^^xsd:string</para>
    ///   <para>rdfs:label : Design^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#Design">dio:Design</a>
    /// </summary>
    let Design = _prefixId.prefix "Design"
    /// <summary>
    ///   <para>dce:description : The final design decision made based on the various alternative solutions proposed. A design decision is driven by a mandated solution.^^xsd:string</para>
    ///   <para>rdfs:label : Design Decision^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#DesignDecision">dio:DesignDecision</a>
    /// </summary>
    let DesignDecision = _prefixId.prefix "DesignDecision"
    /// <summary>
    ///   <para>dce:description : An entity representing the problem, goal, question or issue the design intent aims to address.^^xsd:string</para>
    ///   <para>rdfs:label : Design Goal^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#DesignGoal">dio:DesignGoal</a>
    /// </summary>
    let DesignGoal = _prefixId.prefix "DesignGoal"
    /// <summary>
    ///   <para>dce:description : A entity defining the notion of a design intent, i.e., the rationale underpinning the choices that are made from the alternatives available during various phases of the overall design lifecycle.^^xsd:string</para>
    ///   <para>rdfs:label : Design Intent^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#DesignIntent">dio:DesignIntent</a>
    /// </summary>
    let DesignIntent = _prefixId.prefix "DesignIntent"
    /// <summary>
    ///   <para>dce:description : An entity representing any artifact that plays a part in capturing the design intent. The minimum ontological commitment required for this entity is a brief description of the artifact, the version info and the date.^^xsd:string</para>
    ///   <para>rdfs:label : Design Intent Artifact^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#DesignIntentArtifact">dio:DesignIntentArtifact</a>
    /// </summary>
    let DesignIntentArtifact = _prefixId.prefix "DesignIntentArtifact"
    /// <summary>
    ///   <para>dce:description : An entity representing the problem, goal, question or issue the design intent aims to address.^^xsd:string</para>
    ///   <para>rdfs:label : Design Issue^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#DesignIssue">dio:DesignIssue</a>
    /// </summary>
    let DesignIssue = _prefixId.prefix "DesignIssue"
    /// <summary>
    ///   <para>dce:description : An entity capturing the requirements that result in the design intent^^xsd:string</para>
    ///   <para>rdfs:label : Design Requirements^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#DesignRequirement">dio:DesignRequirement</a>
    /// </summary>
    let DesignRequirement = _prefixId.prefix "DesignRequirement"
    /// <summary>
    ///   <para>dce:description : An entity representing the evaluation that supports the solution.^^xsd:string</para>
    ///   <para>rdfs:label : Evaluation^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#Evaluation">dio:Evaluation</a>
    /// </summary>
    let Evaluation = _prefixId.prefix "Evaluation"
    /// <summary>
    ///   <para>dce:description : An entity representing an evidence that supports a proposed solution.^^xsd:stringdce:description : Evidence^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#Evidence">dio:Evidence</a>
    /// </summary>
    let Evidence = _prefixId.prefix "Evidence"
    /// <summary>
    ///   <para>dce:description : An entity representing the requirements to be fulfilled for realising the solution^^xsd:string</para>
    ///   <para>rdfs:label : Heuristic^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#Heuristic">dio:Heuristic</a>
    /// </summary>
    let Heuristic = _prefixId.prefix "Heuristic"
    /// <summary>
    ///   <para>rdfs:label : A reason supporting the proposed solution.^^xsd:stringrdfs:label : Justification^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#Justification">dio:Justification</a>
    /// </summary>
    let Justification = _prefixId.prefix "Justification"
    /// <summary>
    ///   <para>dce:description : An entity representing the solution accepted as a result of the design deliberation process.^^xsd:string</para>
    ///   <para>rdfs:label : Mandated Solution^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#MandatedSolution">dio:MandatedSolution</a>
    /// </summary>
    let MandatedSolution = _prefixId.prefix "MandatedSolution"
    let OnHold = _prefixId.prefix "OnHold"
    /// <summary>
    ///   <para>dce:description : An entity representing the methodology used to capture the design intent artifact^^xsd:string</para>
    ///   <para>rdfs:label : Rationale Capture Methodology^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#RationaleCaptureMethod">dio:RationaleCaptureMethod</a>
    /// </summary>
    let RationaleCaptureMethod = _prefixId.prefix "RationaleCaptureMethod"
    let Resolved = _prefixId.prefix "Resolved"
    /// <summary>
    ///   <para>rdfs:label : Solution^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#Solution">dio:Solution</a>
    /// </summary>
    let Solution = _prefixId.prefix "Solution"
    /// <summary>
    ///   <para>dce:description : An entity representing the status of a design issue.^^xsd:string</para>
    ///   <para>rdfs:label : Status^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#Status">dio:Status</a>
    /// </summary>
    let Status = _prefixId.prefix "Status"
    let Terminated = _prefixId.prefix "Terminated"
    /// <summary>
    ///   <para>rdfs:label : addressedBy^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#addressedBy">dio:addressedBy</a>
    /// </summary>
    let addressedBy = _prefixId.prefix "addressedBy"
    /// <summary>
    ///   <para>rdfs:label : captureMethodology^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#captureMethodology">dio:captureMethodology</a>
    /// </summary>
    let captureMethodology = _prefixId.prefix "captureMethodology"
    /// <summary>
    ///   <para>rdfs:label : contradicts^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#contradicts">dio:contradicts</a>
    /// </summary>
    let contradicts = _prefixId.prefix "contradicts"
    /// <summary>
    ///   <para>rdfs:label : fullfillsRequirements^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#fulfillsRequirement">dio:fulfillsRequirement</a>
    /// </summary>
    let fulfillsRequirement = _prefixId.prefix "fulfillsRequirement"
    /// <summary>
    ///   <para>rdfs:label : governsDesign^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#governsDesign">dio:governsDesign</a>
    /// </summary>
    let governsDesign = _prefixId.prefix "governsDesign"
    /// <summary>
    ///   <para>rdfs:label : hasAlternativeSolution^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#hasAlternativeSolution">dio:hasAlternativeSolution</a>
    /// </summary>
    let hasAlternativeSolution = _prefixId.prefix "hasAlternativeSolution"
    /// <summary>
    ///   <para>rdfs:label : hasArgument^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#hasArgument">dio:hasArgument</a>
    /// </summary>
    let hasArgument = _prefixId.prefix "hasArgument"
    /// <summary>
    ///   <para>rdfs:label : hasComment^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#hasComment">dio:hasComment</a>
    /// </summary>
    let hasComment = _prefixId.prefix "hasComment"
    /// <summary>
    ///   <para>rdfs:label : hasConstraint^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#hasConstraint">dio:hasConstraint</a>
    /// </summary>
    let hasConstraint = _prefixId.prefix "hasConstraint"
    /// <summary>
    ///   <para>rdfs:label : hasEvidence^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#hasEvidence">dio:hasEvidence</a>
    /// </summary>
    let hasEvidence = _prefixId.prefix "hasEvidence"
    /// <summary>
    ///   <para>rdfs:label : hasJustification^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#hasJustification">dio:hasJustification</a>
    /// </summary>
    let hasJustification = _prefixId.prefix "hasJustification"
    /// <summary>
    ///   <para>rdfs:label : hasMandatedSolution^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#hasMandatedSolution">dio:hasMandatedSolution</a>
    /// </summary>
    let hasMandatedSolution = _prefixId.prefix "hasMandatedSolution"
    /// <summary>
    ///   <para>rdfs:label : hasStatus^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#hasStatus">dio:hasStatus</a>
    /// </summary>
    let hasStatus = _prefixId.prefix "hasStatus"
    /// <summary>
    ///   <para>rdfs:label : intentAddresses^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#intentAddresses">dio:intentAddresses</a>
    /// </summary>
    let intentAddresses = _prefixId.prefix "intentAddresses"
    /// <summary>
    ///   <para>rdfs:label : leadsTo^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#leadsTo">dio:leadsTo</a>
    /// </summary>
    let leadsTo = _prefixId.prefix "leadsTo"
    /// <summary>
    ///   <para>rdfs:label : providesAlternativeSolution^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#providesAlternativeSolution">dio:providesAlternativeSolution</a>
    /// </summary>
    let providesAlternativeSolution = _prefixId.prefix "providesAlternativeSolution"
    /// <summary>
    ///   <para>rdfs:label : providesMandatedSolution^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#providesMandatedSolution">dio:providesMandatedSolution</a>
    /// </summary>
    let providesMandatedSolution = _prefixId.prefix "providesMandatedSolution"
    /// <summary>
    ///   <para>rdfs:label : rationaleCapturedUsing^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#rationaleCapturedUsing">dio:rationaleCapturedUsing</a>
    /// </summary>
    let rationaleCapturedUsing = _prefixId.prefix "rationaleCapturedUsing"
    /// <summary>
    ///   <para>rdfs:label : refines^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#refines">dio:refines</a>
    /// </summary>
    let refines = _prefixId.prefix "refines"
    /// <summary>
    ///   <para>rdfs:label : requirementFulfilledBy^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#requirementFulfilledBy">dio:requirementFulfilledBy</a>
    /// </summary>
    let requirementFulfilledBy = _prefixId.prefix "requirementFulfilledBy"
    /// <summary>
    ///   <para>rdfs:label : supports^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#supports">dio:supports</a>
    /// </summary>
    let supports = _prefixId.prefix "supports"
    /// <summary>
    ///   <para>rdfs:label : usesAssumption^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#usesAssumption">dio:usesAssumption</a>
    /// </summary>
    let usesAssumption = _prefixId.prefix "usesAssumption"
    /// <summary>
    ///   <para>rdfs:label : usesHeuristic^^xsd:string</para>
    ///   <a href="https://w3id.org/dio#usesHeuristic">dio:usesHeuristic</a>
    /// </summary>
    let usesHeuristic = _prefixId.prefix "usesHeuristic"
    let version = _prefixId.prefix "version"
