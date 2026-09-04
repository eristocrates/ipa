#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``ceon-plan`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://w3id.org/CEON/ontology/plan/" "ceon-plan"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <para>rdfs:comment : A Description is a SocialObject that represents a conceptualization.
    /// For example, a Plan is a Description of some actions to be executed by agents in a certain way, with certain parameters etc. Descriptions 'define' or 'use' concepts, and can be 'satisfied' by situations.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/plan/Description">ceon-plan:Description</a>
    /// </summary>
    let Description = _prefixId.prefix "Description"
    /// <summary>
    ///   <para>rdfs:label : Plan^^xsd:string</para>
    ///   <para>rdfs:comment : A Description having an explicit goal, to be achieved by executing the plan.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/plan/Plan">ceon-plan:Plan</a>
    /// </summary>
    let Plan = _prefixId.prefix "Plan"
    /// <summary>
    ///   <para>rdfs:comment : Plan executions are situations that proactively satisfy a plan. Subplan executions are proper parts of the whole plan execution.^^xsd:string</para>
    ///   <para>rdfs:label : Plan Execution^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/plan/PlanExecution">ceon-plan:PlanExecution</a>
    /// </summary>
    let PlanExecution = _prefixId.prefix "PlanExecution"
    /// <summary>
    ///   <para>rdfs:label : follows execution^^xsd:string</para>
    ///   <para>rdfs:comment : The situation after the execution takes place, i.e. the state of affairs after the process event, such as the product being assembled, or the material being recycled.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/plan/followsExecution">ceon-plan:followsExecution</a>
    /// </summary>
    let followsExecution = _prefixId.prefix "followsExecution"
    /// <summary>
    ///   <para>rdfs:label : has plan exeution^^xsd:string</para>
    ///   <para>rdfs:comment : A plan can have specific executions.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/plan/hasPlanExecution">ceon-plan:hasPlanExecution</a>
    /// </summary>
    let hasPlanExecution = _prefixId.prefix "hasPlanExecution"
    /// <summary>
    ///   <para>rdfs:label : occurs at time^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the time at which something takes place.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/plan/occursAtTime">ceon-plan:occursAtTime</a>
    /// </summary>
    let occursAtTime = _prefixId.prefix "occursAtTime"
    /// <summary>
    ///   <para>rdfs:label : precedes execution^^xsd:string</para>
    ///   <para>rdfs:comment : The situation before the process event takes place, i.e. the state of affairs before the execution, such as the state of the set of components before they are assembled into a product item, or the material state before being recycled.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/plan/precedesExecution">ceon-plan:precedesExecution</a>
    /// </summary>
    let precedesExecution = _prefixId.prefix "precedesExecution"
    /// <summary>
    ///   <para>rdfs:label : satisfies plan^^xsd:string</para>
    ///   <para>rdfs:comment : A relation between a Situation and a Description, e.g. the execution of a Plan satisfies that plan.^^xsd:string</para>
    ///   <a href="http://w3id.org/CEON/ontology/plan/satisfiesPlan">ceon-plan:satisfiesPlan</a>
    /// </summary>
    let satisfiesPlan = _prefixId.prefix "satisfiesPlan"
