namespace http.purl.org.net.p_plan.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module p_plan =
    let _namespace_iri = Namespace_Iri p_plan |> NamespaceIRI
    /// <summary>
    ///   <para>p-plan:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>PROV extension for linking Plans and parts of plans to their respective executions. Created by Daniel Garijo and Yolanda Gil</para>
    /// </remarks>
    /// <seealso href="http://purl.org/net/p-plan#">http://purl.org/net/p-plan#</seealso>
    let _prefix_iri = Prefixed_Name(p_plan, "") |> PrefixedName
    /// <summary>
    ///   <para>p-plan:Bundle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bundle</para></remarks>
    /// <seealso href="http://purl.org/net/p-plan#Bundle">http://purl.org/net/p-plan#Bundle</seealso>
    let Bundle = Prefixed_Name(p_plan, "Bundle") |> PrefixedName
    /// <summary>
    ///   <para>p-plan:Entity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Entity</para></remarks>
    /// <seealso href="http://purl.org/net/p-plan#Entity">http://purl.org/net/p-plan#Entity</seealso>
    let Entity = Prefixed_Name(p_plan, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>p-plan:MultiStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>MultiStep</para></remarks>
    /// <seealso href="http://purl.org/net/p-plan#MultiStep">http://purl.org/net/p-plan#MultiStep</seealso>
    let MultiStep = Prefixed_Name(p_plan, "MultiStep") |> PrefixedName
    /// <summary>
    ///   <para>p-plan:Variable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Variable</para></remarks>
    /// <seealso href="http://purl.org/net/p-plan#Variable">http://purl.org/net/p-plan#Variable</seealso>
    let Variable = Prefixed_Name(p_plan, "Variable") |> PrefixedName

    /// <summary>
    ///   <para>p-plan:correspondsToVariable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>correspondsToVariable</para></remarks>
    /// <seealso href="http://purl.org/net/p-plan#correspondsToVariable">http://purl.org/net/p-plan#correspondsToVariable</seealso>
    let correspondsToVariable =
        Prefixed_Name(p_plan, "correspondsToVariable") |> PrefixedName

    /// <summary>
    ///   <para>p-plan:isOutputVarOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>isOutputVarOf</para></remarks>
    /// <seealso href="http://purl.org/net/p-plan#isOutputVarOf">http://purl.org/net/p-plan#isOutputVarOf</seealso>
    let isOutputVarOf = Prefixed_Name(p_plan, "isOutputVarOf") |> PrefixedName
    /// <summary>
    ///   <para>p-plan:isPreceededBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>isPreceededBy</para></remarks>
    /// <seealso href="http://purl.org/net/p-plan#isPreceededBy">http://purl.org/net/p-plan#isPreceededBy</seealso>
    let isPreceededBy = Prefixed_Name(p_plan, "isPreceededBy") |> PrefixedName
    /// <summary>
    ///   <para>p-plan:Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A p-plan:Activity represents the execution process planned in a p-plan:Step</para>
    /// labels<para>Activity</para></remarks>
    /// <seealso href="http://purl.org/net/p-plan#Activity">http://purl.org/net/p-plan#Activity</seealso>
    let Activity = Prefixed_Name(p_plan, "Activity") |> PrefixedName
    /// <summary>
    ///   <para>p-plan:Plan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Plan</para></remarks>
    /// <seealso href="http://purl.org/net/p-plan#Plan">http://purl.org/net/p-plan#Plan</seealso>
    let Plan = Prefixed_Name(p_plan, "Plan") |> PrefixedName
    /// <summary>
    ///   <para>p-plan:hasOutputVar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasOutputVar</para></remarks>
    /// <seealso href="http://purl.org/net/p-plan#hasOutputVar">http://purl.org/net/p-plan#hasOutputVar</seealso>
    let hasOutputVar = Prefixed_Name(p_plan, "hasOutputVar") |> PrefixedName
    /// <summary>
    ///   <para>p-plan:isInputVarOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>isInputVarOf</para></remarks>
    /// <seealso href="http://purl.org/net/p-plan#isInputVarOf">http://purl.org/net/p-plan#isInputVarOf</seealso>
    let isInputVarOf = Prefixed_Name(p_plan, "isInputVarOf") |> PrefixedName
    /// <summary>
    ///   <para>p-plan:Step</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Step</para></remarks>
    /// <seealso href="http://purl.org/net/p-plan#Step">http://purl.org/net/p-plan#Step</seealso>
    let Step = Prefixed_Name(p_plan, "Step") |> PrefixedName
    /// <summary>
    ///   <para>p-plan:correspondsToStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>correspondsToStep</para></remarks>
    /// <seealso href="http://purl.org/net/p-plan#correspondsToStep">http://purl.org/net/p-plan#correspondsToStep</seealso>
    let correspondsToStep = Prefixed_Name(p_plan, "correspondsToStep") |> PrefixedName
    /// <summary>
    ///   <para>p-plan:hasInputVar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasInputVar</para></remarks>
    /// <seealso href="http://purl.org/net/p-plan#hasInputVar">http://purl.org/net/p-plan#hasInputVar</seealso>
    let hasInputVar = Prefixed_Name(p_plan, "hasInputVar") |> PrefixedName
    /// <summary>
    ///   <para>p-plan:isDecomposedAsPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>isDecomposedAsPlan</para></remarks>
    /// <seealso href="http://purl.org/net/p-plan#isDecomposedAsPlan">http://purl.org/net/p-plan#isDecomposedAsPlan</seealso>
    let isDecomposedAsPlan = Prefixed_Name(p_plan, "isDecomposedAsPlan") |> PrefixedName
    /// <summary>
    ///   <para>p-plan:isStepOfPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>isStepOfPlan</para></remarks>
    /// <seealso href="http://purl.org/net/p-plan#isStepOfPlan">http://purl.org/net/p-plan#isStepOfPlan</seealso>
    let isStepOfPlan = Prefixed_Name(p_plan, "isStepOfPlan") |> PrefixedName
    /// <summary>
    ///   <para>p-plan:isVariableOfPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>isVariableofPlan</para></remarks>
    /// <seealso href="http://purl.org/net/p-plan#isVariableOfPlan">http://purl.org/net/p-plan#isVariableOfPlan</seealso>
    let isVariableOfPlan = Prefixed_Name(p_plan, "isVariableOfPlan") |> PrefixedName
    /// <summary>
    ///   <para>p-plan:isSubPlanOfPlan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>isSubPlanOfPlan</para></remarks>
    /// <seealso href="http://purl.org/net/p-plan#isSubPlanOfPlan">http://purl.org/net/p-plan#isSubPlanOfPlan</seealso>
    let isSubPlanOfPlan = Prefixed_Name(p_plan, "isSubPlanOfPlan") |> PrefixedName
