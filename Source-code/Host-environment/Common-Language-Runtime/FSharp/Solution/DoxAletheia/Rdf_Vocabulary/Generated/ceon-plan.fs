namespace http.w3id.org.CEON.ontology.plan.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ceon_plan =
    let _namespace_iri = Namespace_Iri ceon_plan |> NamespaceIRI
    /// <summary>
    ///   <para>ceon:ontology/plan/</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/plan/">http://w3id.org/CEON/ontology/plan/</seealso>
    let _prefix_iri = Prefixed_Name(ceon_plan, "") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/plan/0.1/</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/plan/0.1/">http://w3id.org/CEON/ontology/plan/0.1/</seealso>
    let ``_0.1/`` = Prefixed_Name(ceon_plan, "0.1/") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/plan/Description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Description is a SocialObject that represents a conceptualization.
    /// For example, a Plan is a Description of some actions to be executed by agents in a certain way, with certain parameters etc. Descriptions 'define' or 'use' concepts, and can be 'satisfied' by situations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Description"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/plan/Description">http://w3id.org/CEON/ontology/plan/Description</seealso>
    let Description = Prefixed_Name(ceon_plan, "Description") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/plan/Plan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Description having an explicit goal, to be achieved by executing the plan."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Plan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/plan/Plan">http://w3id.org/CEON/ontology/plan/Plan</seealso>
    let Plan = Prefixed_Name(ceon_plan, "Plan") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/plan/PlanExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Plan executions are situations that proactively satisfy a plan. Subplan executions are proper parts of the whole plan execution."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Plan Execution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/plan/PlanExecution">http://w3id.org/CEON/ontology/plan/PlanExecution</seealso>
    let PlanExecution = Prefixed_Name(ceon_plan, "PlanExecution") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/plan/followsExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The situation after the execution takes place, i.e. the state of affairs after the process event, such as the product being assembled, or the material being recycled."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"follows execution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/plan/followsExecution">http://w3id.org/CEON/ontology/plan/followsExecution</seealso>
    let followsExecution = Prefixed_Name(ceon_plan, "followsExecution") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/plan/hasPlanExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A plan can have specific executions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has plan exeution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/plan/hasPlanExecution">http://w3id.org/CEON/ontology/plan/hasPlanExecution</seealso>
    let hasPlanExecution = Prefixed_Name(ceon_plan, "hasPlanExecution") |> PrefixedName
    /// <summary>
    ///   <para>ceon:ontology/plan/occursAtTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Represents the time at which something takes place."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"occurs at time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/plan/occursAtTime">http://w3id.org/CEON/ontology/plan/occursAtTime</seealso>
    let occursAtTime = Prefixed_Name(ceon_plan, "occursAtTime") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/plan/precedesExecution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The situation before the process event takes place, i.e. the state of affairs before the execution, such as the state of the set of components before they are assembled into a product item, or the material state before being recycled."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"precedes execution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/plan/precedesExecution">http://w3id.org/CEON/ontology/plan/precedesExecution</seealso>
    let precedesExecution =
        Prefixed_Name(ceon_plan, "precedesExecution") |> PrefixedName

    /// <summary>
    ///   <para>ceon:ontology/plan/satisfiesPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a Situation and a Description, e.g. the execution of a Plan satisfies that plan."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"satisfies plan"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://w3id.org/CEON/ontology/plan/satisfiesPlan">http://w3id.org/CEON/ontology/plan/satisfiesPlan</seealso>
    let satisfiesPlan = Prefixed_Name(ceon_plan, "satisfiesPlan") |> PrefixedName
