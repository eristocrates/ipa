#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``p-plan`` =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/net/p-plan#" "p-plan"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : A p-plan:Activity represents the execution process planned in a p-plan:Step</para>
    ///   <para>rdfs:label : Activity</para>
    ///   <a href="http://purl.org/net/p-plan#Activity">p-plan:Activity</a>
    /// </summary>
    let Activity = _prefixId.prefix "Activity"
    /// <summary>
    ///   <para>prov:definition : A p-plan:Bundle is a specific type of prov:Bundle that contains the provenance assertions of the execution of a p-plan:Plan</para>
    ///   <para>rdfs:label : Bundle</para>
    ///   <a href="http://purl.org/net/p-plan#Bundle">p-plan:Bundle</a>
    /// </summary>
    let Bundle = _prefixId.prefix "Bundle"
    /// <summary>
    ///   <para>prov:definition : A p-plan:Entity represents the input of the execution of a p-plan:Activity. It corresponds to a p-plan:Variable.</para>
    ///   <para>rdfs:label : Entity</para>
    ///   <a href="http://purl.org/net/p-plan#Entity">p-plan:Entity</a>
    /// </summary>
    let Entity = _prefixId.prefix "Entity"
    /// <summary>
    ///   <para>prov:definition : A multi step is the representation of a plan that appears as a step of another plan.</para>
    ///   <para>rdfs:label : MultiStep</para>
    ///   <a href="http://purl.org/net/p-plan#MultiStep">p-plan:MultiStep</a>
    /// </summary>
    let MultiStep = _prefixId.prefix "MultiStep"
    /// <summary>
    ///   <para>prov:definition : A p-plan:Plan is a specific type of prov:Plan. It is composed of smaller steps that use and produce Variables.</para>
    ///   <para>rdfs:label : Plan</para>
    ///   <a href="http://purl.org/net/p-plan#Plan">p-plan:Plan</a>
    /// </summary>
    let Plan = _prefixId.prefix "Plan"
    /// <summary>
    ///   <para>prov:definition : A p-plan:Step represents the planned execution activity</para>
    ///   <para>rdfs:label : Step</para>
    ///   <a href="http://purl.org/net/p-plan#Step">p-plan:Step</a>
    /// </summary>
    let Step = _prefixId.prefix "Step"
    /// <summary>
    ///   <para>prov:definition : A p-plan:Variable represents a description of the input of the planned Activity (p-plan:Step)</para>
    ///   <para>rdfs:label : Variable</para>
    ///   <a href="http://purl.org/net/p-plan#Variable">p-plan:Variable</a>
    /// </summary>
    let Variable = _prefixId.prefix "Variable"
    /// <summary>
    ///   <para>prov:definition : p-plan:correspondsToStep links a p-plan:Activity to its planned p-plan:Step</para>
    ///   <para>rdfs:label : correspondsToStep</para>
    ///   <a href="http://purl.org/net/p-plan#correspondsToStep">p-plan:correspondsToStep</a>
    /// </summary>
    let correspondsToStep = _prefixId.prefix "correspondsToStep"
    /// <summary>
    ///   <para>prov:definition : p-plan:correspondsToVariable binds a p-plan:Entity (used by a p-plan:Activity in the execution of a plan) to the p-plan:Variable it represented it in the p-plan:Plan.</para>
    ///   <para>rdfs:label : correspondsToVariable</para>
    ///   <a href="http://purl.org/net/p-plan#correspondsToVariable">p-plan:correspondsToVariable</a>
    /// </summary>
    let correspondsToVariable = _prefixId.prefix "correspondsToVariable"
    /// <summary>
    ///   <para>prov:definition : p-plan:hasInputVar binds a p-plan:Step to the p-plan:Variable that takes as input for the planned execution</para>
    ///   <para>rdfs:label : hasInputVar</para>
    ///   <a href="http://purl.org/net/p-plan#hasInputVar">p-plan:hasInputVar</a>
    /// </summary>
    let hasInputVar = _prefixId.prefix "hasInputVar"
    /// <summary>
    ///   <para>prov:definition : p-plan:hasOutputVar binds a p-plan:Step to the p-plan:Variable that will be produced as output in the planned execution</para>
    ///   <para>rdfs:label : hasOutputVar</para>
    ///   <a href="http://purl.org/net/p-plan#hasOutputVar">p-plan:hasOutputVar</a>
    /// </summary>
    let hasOutputVar = _prefixId.prefix "hasOutputVar"
    /// <summary>
    ///   <para>prov:definition : The p-plan:isDecomposedAsPlan relationship binds a p-plan:MultiStep to the p-plan:Plan holding the definition of that step. That is, p-plan:isDecomposedAsPlan links the MultiStep to the Plan sptecification where it is decomposed.</para>
    ///   <para>rdfs:label : isDecomposedAsPlan</para>
    ///   <a href="http://purl.org/net/p-plan#isDecomposedAsPlan">p-plan:isDecomposedAsPlan</a>
    /// </summary>
    let isDecomposedAsPlan = _prefixId.prefix "isDecomposedAsPlan"
    /// <summary>
    ///   <para>prov:definition : p-plan:isInputVarOf links an input variable of a step to the step.</para>
    ///   <para>rdfs:label : isInputVarOf</para>
    ///   <a href="http://purl.org/net/p-plan#isInputVarOf">p-plan:isInputVarOf</a>
    /// </summary>
    let isInputVarOf = _prefixId.prefix "isInputVarOf"
    /// <summary>
    ///   <para>prov:definition : p-plan:isOutputVarOf is intended to link an output variable of a step to the step.</para>
    ///   <para>rdfs:label : isOutputVarOf</para>
    ///   <a href="http://purl.org/net/p-plan#isOutputVarOf">p-plan:isOutputVarOf</a>
    /// </summary>
    let isOutputVarOf = _prefixId.prefix "isOutputVarOf"
    /// <summary>
    ///   <para>rdfs:isDefinedBy : Property that asserts which Step preceeds the current one.</para>
    ///   <para>rdfs:label : isPreceededBy</para>
    ///   <a href="http://purl.org/net/p-plan#isPreceededBy">p-plan:isPreceededBy</a>
    /// </summary>
    let isPreceededBy = _prefixId.prefix "isPreceededBy"
    /// <summary>
    ///   <para>prov:definition : p-plan:isStepOfPlan links a p-plan:Step to the p-plan:Plan which it corresponds to.</para>
    ///   <para>rdfs:label : isStepOfPlan</para>
    ///   <a href="http://purl.org/net/p-plan#isStepOfPlan">p-plan:isStepOfPlan</a>
    /// </summary>
    let isStepOfPlan = _prefixId.prefix "isStepOfPlan"
    /// <summary>
    ///   <para>prov:definition : A p-plan:Plan may be a subplan of another bigger p-plan:Plan. p-plan:isSubPlanOfPlan is used to state the link among the two different plans. Note that if p1 is a p-plan:subPlan of p2, p1will not necessarily be a step of p2. A multistep will represent p1 in p2, and link to p1 with the p-plan.hasStepDecomposition relationship.</para>
    ///   <para>rdfs:label : isSubPlanOfPlan</para>
    ///   <a href="http://purl.org/net/p-plan#isSubPlanOfPlan">p-plan:isSubPlanOfPlan</a>
    /// </summary>
    let isSubPlanOfPlan = _prefixId.prefix "isSubPlanOfPlan"
    /// <summary>
    ///   <para>prov:definition : p-plan:IsVariableOfPlan binds a p-plan:Variable to the p-plan:Plan it corresponds to.</para>
    ///   <para>rdfs:label : isVariableofPlan</para>
    ///   <a href="http://purl.org/net/p-plan#isVariableOfPlan">p-plan:isVariableOfPlan</a>
    /// </summary>
    let isVariableOfPlan = _prefixId.prefix "isVariableOfPlan"
