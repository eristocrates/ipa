namespace http.eulersharp.sourceforge.net._2003._03swap.workflow.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swapworkflow =
    let _namespace_iri = Namespace_Iri swapworkflow |> NamespaceIRI
    /// <summary>
    ///   <para>swapworkflow:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/workflow#">http://eulersharp.sourceforge.net/2003/03swap/workflow#</seealso>
    let _prefix_iri = Prefixed_Name(swapworkflow, "") |> PrefixedName
    /// <summary>
    ///   <para>swapworkflow:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Both plan and execution."</para>
    /// labels<para>"workflow action"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Action">http://eulersharp.sourceforge.net/2003/03swap/workflow#Action</seealso>
    let Action = Prefixed_Name(swapworkflow, "Action") |> PrefixedName
    /// <summary>
    ///   <para>swapworkflow:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Agent can be e.g. person, group, organization, mechanism."</para>
    /// labels<para>"workflow agent"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Agent">http://eulersharp.sourceforge.net/2003/03swap/workflow#Agent</seealso>
    let Agent = Prefixed_Name(swapworkflow, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>swapworkflow:ExclusiveChoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"workflow exclusive choice"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/workflow#ExclusiveChoice">http://eulersharp.sourceforge.net/2003/03swap/workflow#ExclusiveChoice</seealso>
    let ExclusiveChoice = Prefixed_Name(swapworkflow, "ExclusiveChoice") |> PrefixedName
    /// <summary>
    ///   <para>swapworkflow:Input</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"workflow action input"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Input">http://eulersharp.sourceforge.net/2003/03swap/workflow#Input</seealso>
    let Input = Prefixed_Name(swapworkflow, "Input") |> PrefixedName
    /// <summary>
    ///   <para>swapworkflow:Output</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"workflow action output"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Output">http://eulersharp.sourceforge.net/2003/03swap/workflow#Output</seealso>
    let Output = Prefixed_Name(swapworkflow, "Output") |> PrefixedName
    /// <summary>
    ///   <para>swapworkflow:ParallelSplit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"workflow parallel split"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/workflow#ParallelSplit">http://eulersharp.sourceforge.net/2003/03swap/workflow#ParallelSplit</seealso>
    let ParallelSplit = Prefixed_Name(swapworkflow, "ParallelSplit") |> PrefixedName
    /// <summary>
    ///   <para>swapworkflow:Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"workflow pattern"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Pattern">http://eulersharp.sourceforge.net/2003/03swap/workflow#Pattern</seealso>
    let Pattern = Prefixed_Name(swapworkflow, "Pattern") |> PrefixedName
    /// <summary>
    ///   <para>swapworkflow:Resource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"workflow action resource"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Resource">http://eulersharp.sourceforge.net/2003/03swap/workflow#Resource</seealso>
    let Resource = Prefixed_Name(swapworkflow, "Resource") |> PrefixedName
    /// <summary>
    ///   <para>swapworkflow:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"workflow agent role"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Role">http://eulersharp.sourceforge.net/2003/03swap/workflow#Role</seealso>
    let Role = Prefixed_Name(swapworkflow, "Role") |> PrefixedName
    /// <summary>
    ///   <para>swapworkflow:Sequence</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"workflow sequence"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Sequence">http://eulersharp.sourceforge.net/2003/03swap/workflow#Sequence</seealso>
    let Sequence = Prefixed_Name(swapworkflow, "Sequence") |> PrefixedName
    /// <summary>
    ///   <para>swapworkflow:SimpleMerge</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"workflow simple merge"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/workflow#SimpleMerge">http://eulersharp.sourceforge.net/2003/03swap/workflow#SimpleMerge</seealso>
    let SimpleMerge = Prefixed_Name(swapworkflow, "SimpleMerge") |> PrefixedName
    /// <summary>
    ///   <para>swapworkflow:Synchronization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>"workflow synchronization"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Synchronization">http://eulersharp.sourceforge.net/2003/03swap/workflow#Synchronization</seealso>
    let Synchronization = Prefixed_Name(swapworkflow, "Synchronization") |> PrefixedName
    /// <summary>
    ///   <para>swapworkflow:Workflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>"Both plan and execution."</para>
    /// labels<para>"workflow"</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/workflow#Workflow">http://eulersharp.sourceforge.net/2003/03swap/workflow#Workflow</seealso>
    let Workflow = Prefixed_Name(swapworkflow, "Workflow") |> PrefixedName
    /// <summary>
    ///   <para>swapworkflow:actionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/workflow#actionOf">http://eulersharp.sourceforge.net/2003/03swap/workflow#actionOf</seealso>
    let actionOf = Prefixed_Name(swapworkflow, "actionOf") |> PrefixedName
    /// <summary>
    ///   <para>swapworkflow:hasAction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/workflow#hasAction">http://eulersharp.sourceforge.net/2003/03swap/workflow#hasAction</seealso>
    let hasAction = Prefixed_Name(swapworkflow, "hasAction") |> PrefixedName
    /// <summary>
    ///   <para>swapworkflow:hasWorkflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/workflow#hasWorkflow">http://eulersharp.sourceforge.net/2003/03swap/workflow#hasWorkflow</seealso>
    let hasWorkflow = Prefixed_Name(swapworkflow, "hasWorkflow") |> PrefixedName
