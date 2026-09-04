#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module opmw =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.opmw.org/ontology/" "opmw"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Data Variable</para>
    ///   <para>rdfs:comment : A Data variable is a workflow template artifact that represents a variable in the workflow specification.
    ///
    /// Example:
    /// @prefix rdfs: &lt;http://www.w3.org/2000/01/rdf-schema#&gt; .
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/DataVariable/AQUAFLOW_NTM_SUM_CORRDO&gt;
    ///       a      opmw:WorkflowTemplateArtifact , opmw:DataVariable ;
    ///       rdfs:label "Data variable Sum_CorrDO" ;
    ///       opmw:hasDimensionality "0"^^xsd:int ;
    ///       opmw:isGeneratedBy              &lt;http://www.opmw.org/export/resource/WorkflowTemplateProcess/AQUAFLOW_NTM_CREATEPLOTS&gt; ;
    ///       opmw:template              &lt;http://www.opmw.org/export/resource/WorkflowTemplate/AQUAFLOW_NTM&gt; .^^xsd:string</para>
    ///   <a href="http://www.opmw.org/ontology/DataVariable">opmw:DataVariable</a>
    /// </summary>
    let DataVariable = _prefixId.prefix "DataVariable"
    /// <summary>
    ///   <para>rdfs:label : Parameter Variable</para>
    ///   <para>rdfs:comment : An parameter variable represents a description of an input parameter of a process. Parameter variables can only be used by process.
    ///
    /// Example:
    /// @prefix rdfs: &lt;http://www.w3.org/2000/01/rdf-schema#&gt; .
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/ParameterVariable/AQUAFLOW_NTM_LATITUDE&gt;
    ///       a      opmw:/WorkflowTemplateArtifact , opmw:ParameterVariable ;
    ///       rdfs:label "Parameter variable Latitude" ;
    ///       opmw:template              &lt;http://www.opmw.org/export/resource/WorkflowTemplate/AQUAFLOW_NTM&gt; .</para>
    ///   <a href="http://www.opmw.org/ontology/ParameterVariable">opmw:ParameterVariable</a>
    /// </summary>
    let ParameterVariable = _prefixId.prefix "ParameterVariable"
    /// <summary>
    ///   <para>rdfs:label : Workflow Execution Account</para>
    ///   <para>rdfs:comment : A workflow execution account represents the execution from the perspective of the system.
    ///
    /// Example:
    /// @prefix rdfs: &lt;http://www.w3.org/2000/01/rdf-schema#&gt; .
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    /// @prefix opmo: &lt;http://openprovenance.org/model/opmo#&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowExecutionAccount/ACCOUNT1335533097598&gt;
    ///       a       opmo:Account , opmw:WorkflowExecutionAccount&gt; ;
    ///       rdfs:label "Execution account created on 1335533097598" ;
    ///       opmw:executedInWorkflowSystem
    ///               &lt;http://www.opmw.org/export/resource/Agent/SHELL&gt; ;
    ///      opmw:hasEndTime
    ///               "2012-04-25T07:17:48-07:00"^^xsd:dateTime ;
    ///       opmw:hasExecutionDiagram "http://wind.isi.edu/marbles/assets/components/workflow_portal/users/1/Water/runs/run_144.png"^^xsd:anyURI ;
    ///       opmw:hasStartTime               "2012-04-25T07:17:05-07:00"^^xsd:dateTime ;
    ///       opmw:hasStatus "SUCCESS" ;</para>
    ///   <a href="http://www.opmw.org/ontology/WorkflowExecutionAccount">opmw:WorkflowExecutionAccount</a>
    /// </summary>
    let WorkflowExecutionAccount = _prefixId.prefix "WorkflowExecutionAccount"
    /// <summary>
    ///   <para>rdfs:label : Workflow Execution Artifact</para>
    ///   <para>rdfs:comment : A workflow execution artifact represents a resource used or generated in the execution of a workflow.
    ///
    /// Example:
    /// @prefix rdfs: &lt;http://www.w3.org/2000/01/rdf-schema#&gt; .
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    /// @prefix opmv: &lt;http://purl.org/net/opmv/ns#&gt; .
    /// @prefix opmo: &lt;http://openprovenance.org/model/opmo#&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowExecutionArtifact/25F1016C12EBE301EE7AADBC0B085C45&gt;
    ///       a       opmw:WorkflowExecutionArtifact , opmv:Artifact;
    ///       rdfs:label "Execution artifact with id: 25f1016c12ebe301ee7aadbc0b085c45" ;
    ///       opmo:account              &lt;http://www.opmw.org/export/resource/WorkflowExecutionAccount/ACCOUNT1335533097598&gt; ;
    ///       opmv:wasGeneratedBy     &lt;http://www.opmw.org/export/resource/WorkflowExecutionProcess/p1&gt; ;
    ///       opmw:hasLocation     "http://wings.isi.edu/opmexport/resource/1/144/Formatted_SMN_2010_03_10Z"^^xsd:anyURI ;
    ///       opmw:hasSize "8618"^^xsd:int ;
    ///       opmw:hasWorkflowTemplateArtifact              &lt;http://www.opmw.org/export/resource/DataVariable/AQUAFLOW_EDM_FORMATTEDDATA&gt;.</para>
    ///   <a href="http://www.opmw.org/ontology/WorkflowExecutionArtifact">opmw:WorkflowExecutionArtifact</a>
    /// </summary>
    let WorkflowExecutionArtifact = _prefixId.prefix "WorkflowExecutionArtifact"
    /// <summary>
    ///   <para>rdfs:label : Workflow Execution Process</para>
    ///   <para>rdfs:comment : A workflow execution process represents the execution of a step in workflow template. The execution process also describes the specific method used to acomplish the task described in the proces template.
    ///
    /// Example:
    /// @prefix rdfs: &lt;http://www.w3.org/2000/01/rdf-schema#&gt; .
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    /// @prefix opmv: &lt;http://purl.org/net/opmv/ns#&gt; .
    /// @prefix opmo: &lt;http://openprovenance.org/model/opmo#&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowExecutionProcess/CONVERTTOSTANDARDFORMAT133553&gt;
    ///       a      opmw:/WorkflowExecutionProcess , opmv:Process ;
    ///       rdfs:label "Execution process ConvertToStandardFormat" ;
    ///       opmo:account              &lt;http://www.opmw.org/export/resource/WorkflowExecutionAccount/ACCOUNT1335533097598&gt; ;
    ///       opmv:used              &lt;http://www.opmw.org/export/resource/WorkflowExecutionArtifact/6C7CF277338D9590EE18534D4D78924F&gt; ;
    ///       opmv:wasControlledBy               &lt;http://www.opmw.org/export/resource/Agent/ADMIN&gt; ;
    ///       opmw:hasWorkflowTemplateProcess              &lt;http://www.opmw.org/export/resource/WorkflowTemplateProcess/AQUAFLOW_EDM_CONVERTTOSTANDARDFORMAT&gt; .</para>
    ///   <a href="http://www.opmw.org/ontology/WorkflowExecutionProcess">opmw:WorkflowExecutionProcess</a>
    /// </summary>
    let WorkflowExecutionProcess = _prefixId.prefix "WorkflowExecutionProcess"
    /// <summary>
    ///   <para>rdfs:label : Workflow Template</para>
    ///   <para>rdfs:comment : A workflow template represents the design of the workflow. In such design, the different steps and inputs don't have to be bound to a specific tool or dataset. It is a generic view of the workflow, which is instantiated in each execution.
    ///
    /// Example:
    /// @prefix dc:  &lt;http://purl.org/dc/terms/&gt; .
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    /// &lt;http://www.opmw.org/export/resource/WorkflowTemplate/AQUAFLOW_NTM&gt;
    ///      a opmw:WorkflowTemplate;
    ///      rdfs:label "AquaFlow_NTM" ;
    ///      dc.contributor
    ///               &lt;http://www.opmw.org/export/resource/Agent/WATER&gt; ;
    ///      dc:modified
    ///               "2011-06-08T09:57:12-07:00"^^xsd:dateTime ;
    ///      opmw:hasVersion "2"^^xsd:int .</para>
    ///   <a href="http://www.opmw.org/ontology/WorkflowTemplate">opmw:WorkflowTemplate</a>
    /// </summary>
    let WorkflowTemplate = _prefixId.prefix "WorkflowTemplate"
    /// <summary>
    ///   <para>rdfs:label : Workflow Template Artifact</para>
    ///   <para>rdfs:comment : A workflow template artifact is part of a workflow template. It explains what kind of artifact is used or generated by the process template, along with possible restrictions that it may have.
    ///
    /// There are two different types of workflow template artifacts: data variables and parameter variables.</para>
    ///   <a href="http://www.opmw.org/ontology/WorkflowTemplateArtifact">opmw:WorkflowTemplateArtifact</a>
    /// </summary>
    let WorkflowTemplateArtifact = _prefixId.prefix "WorkflowTemplateArtifact"
    /// <summary>
    ///   <para>rdfs:label : Workflow Template Process</para>
    ///   <para>rdfs:comment : A workflow process template is an abstraction of the workflow execution process step that aims to describe the method followed by the scientist instead of its specific instantiation.
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    /// @prefix water: &lt;http://www.isi.edu/ac/Water/library.owl#&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowTemplateProcess/AQUAFLOW_NTM_CALCULATEHOURLYAVERAGES&gt;
    ///       a opmw:ProcessTemplate, water:CalculateHourlyAverages;
    ///       opmw:template &lt;http://www.opmw.org/export/resource/WorkflowTemplate/AQUAFLOW_NTM&gt;;
    ///       opmw:uses &lt;http://www.opmw.org/export/resource/DataVariable/AQUAFLOW_NTM_FILTEREDDATA&gt;.
    ///       </para>
    ///   <a href="http://www.opmw.org/ontology/WorkflowTemplateProcess">opmw:WorkflowTemplateProcess</a>
    /// </summary>
    let WorkflowTemplateProcess = _prefixId.prefix "WorkflowTemplateProcess"
    /// <summary>
    ///   <para>rdfs:label : corresponds to Template</para>
    ///   <para>rdfs:comment : Property that binds an execution account to the template of the whole workflow. The template contains the plan for the workflow.
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    /// @prefix opmo: &lt;http://openprovenance.org/model/opmo#&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowExecutionProcess/acc1&gt;
    ///      a opmo:Account, opmw:workflowExecutionAccount;
    ///      opmw:correspondsToTemplate &lt;http://www.opmw.org/export/resource/WorkflowTemplate/AQUAFLOW_EDM&gt;.</para>
    ///   <a href="http://www.opmw.org/ontology/correspondsToTemplate">opmw:correspondsToTemplate</a>
    /// </summary>
    let correspondsToTemplate = _prefixId.prefix "correspondsToTemplate"
    /// <summary>
    ///   <para>rdfs:label : corresponds to Template Artifact</para>
    ///   <para>rdfs:comment : Property that binds a workflow execution artifact to its correspondant workflow template artifact.
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    /// @prefix opmv: &lt;http://purl.org/net/opmv/ns#&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowExecutionArtifact/DEPTH1.2150836&gt;
    ///        a opmv:Artifact, opmw:WorkflowExecutionArtifact;
    ///        opmw:correspondsToTemplateArtifact &lt;http://www.opmw.org/export/resource/ParameterVariable/AQUAFLOW_EDM_DEPTH&gt;.</para>
    ///   <a href="http://www.opmw.org/ontology/correspondsToTemplateArtifact">opmw:correspondsToTemplateArtifact</a>
    /// </summary>
    let correspondsToTemplateArtifact = _prefixId.prefix "correspondsToTemplateArtifact"
    /// <summary>
    ///   <para>rdfs:label : corresponds to Template Process</para>
    ///   <para>rdfs:comment : Property that binds a workflow execution process  to its correspondant process template.
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    /// @prefix opmv: &lt;http://purl.org/net/opmv/ns#&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowExecutionProcess/REAERATIONEDM133549210450086&gt;
    ///      a opmv:Process, opmw:WorkflowExecutionProcess;
    ///      opmw:correspondsToTemplateProcess &lt;http://www.opmw.org/export/resource/WorkflowTemplateProcess/AQUAFLOW_EDM_REAERATIONEDM&gt;. </para>
    ///   <a href="http://www.opmw.org/ontology/correspondsToTemplateProcess">opmw:correspondsToTemplateProcess</a>
    /// </summary>
    let correspondsToTemplateProcess = _prefixId.prefix "correspondsToTemplateProcess"
    /// <summary>
    ///   <para>rdfs:label : created in Workflow System</para>
    ///   <para>rdfs:comment : This data property binds a workflow template to the tool used for its design and creation. The tool is represented by its URL.
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowTemplate/AQUAFLOW_EDM&gt;
    ///          a opmw:WorkflowTemplate;
    ///          opmw:createdInWorkflowSystem "http://wings.isi.edu"^^xsd:anyURI.</para>
    ///   <a href="http://www.opmw.org/ontology/createdInWorkflowSystem">opmw:createdInWorkflowSystem</a>
    /// </summary>
    let createdInWorkflowSystem = _prefixId.prefix "createdInWorkflowSystem"
    /// <summary>
    ///   <para>rdfs:label : executed in Workflow System</para>
    ///   <para>rdfs:comment : Property to bind an execution account to the system where it was executed (which could be different from the one used for designing its workflow template).
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    /// @prefix opmo: &lt;http://openprovenance.org/model/opmo#&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowExecutionAccount/acc1&gt;
    ///       a opmo:Account, opmw:executionAccount;
    ///       opmw:executedInWorkflowSystem &lt;http://www.opmw.org/export/resource/Agent/SHELL&gt;.
    ///
    /// &lt;http://www.opmw.org/export/resource/Agent/SHELL&gt;
    ///      a opmw:Agent.</para>
    ///   <a href="http://www.opmw.org/ontology/executedInWorkflowSystem">opmw:executedInWorkflowSystem</a>
    /// </summary>
    let executedInWorkflowSystem = _prefixId.prefix "executedInWorkflowSystem"
    /// <summary>
    ///   <para>rdfs:label : has Dimensionality</para>
    ///   <para>rdfs:comment : Property that represents the dimensionality of the artifact: 0 is a single file, 1 for a collection, etc.
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/DataVariable/AQUAFLOW_NTM_DAILYDATA&gt;
    ///      a opmw:DataVariable, opmw:WorkflowTemplateArtifact;
    ///      opmw:hasDimensionality "1"^^xsd:int.
    /// </para>
    ///   <a href="http://www.opmw.org/ontology/hasDimensionality">opmw:hasDimensionality</a>
    /// </summary>
    let hasDimensionality = _prefixId.prefix "hasDimensionality"
    /// <summary>
    ///   <para>rdfs:label : has Documentation</para>
    ///   <para>rdfs:comment : Property that binds a workflow template to its documentation.
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    /// &lt;http://www.opmw.org/export/resource/WorkflowTemplate/AQUAFLOW_NTM&gt;
    ///       a opmw:WorkflowTemplate;
    ///       opmw:hasDocumentation "A copy of the documentation related to this template "^^xsd:string.</para>
    ///   <a href="http://www.opmw.org/ontology/hasDocumentation">opmw:hasDocumentation</a>
    /// </summary>
    let hasDocumentation = _prefixId.prefix "hasDocumentation"
    /// <summary>
    ///   <para>rdfs:label : has Executable Component</para>
    ///   <para>rdfs:comment : Property that binds a workflow execution process to the specific component (code, scripts, etc.) used in the execution.
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    /// @prefix opmv: &lt;http://purl.org/net/opmv/ns#&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowExecutionProcess/REAERATIONEDM133549210450086&gt;
    ///      a opmv:Process, opmw:WorkflowExecutionProcess;
    ///      opmw:hasExecutableComponent &lt;http://www.opmw.org/export/resource/ReaerationEDM/COMPONENTREAERATIONEDM&gt;.</para>
    ///   <a href="http://www.opmw.org/ontology/hasExecutableComponent">opmw:hasExecutableComponent</a>
    /// </summary>
    let hasExecutableComponent = _prefixId.prefix "hasExecutableComponent"
    /// <summary>
    ///   <para>rdfs:label : has Execution Diagram</para>
    ///   <para>rdfs:comment : Property that links an execution account to its diagram. The diagram shows how the template has been instantiated with different components.
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    /// @prefix opmo: &lt;http://openprovenance.org/model/opmo#&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowExecutionAccount/ACCOUNT1335506667949&gt;
    ///      a opmw:WorkflowExecutionAccount,opmo:Account;
    ///      opmw:hasExecutionDiagram "http://wind.isi.edu/marbles/assets/components/workflow_portal/users/1/Water/runs/run_148.png"^^sxd:anyURI.</para>
    ///   <a href="http://www.opmw.org/ontology/hasExecutionDiagram">opmw:hasExecutionDiagram</a>
    /// </summary>
    let hasExecutionDiagram = _prefixId.prefix "hasExecutionDiagram"
    /// <summary>
    ///   <para>rdfs:label : has File Name</para>
    ///   <para>rdfs:comment : Property used to link an execution artifact to its file name (independently of its URI).
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    /// @prefix opmv: &lt;http://purl.org/net/opmv/ns#&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowExecutionArtifact/DCF49186981194248009E24BAD6A6412&gt;
    ///       a opmv:Artifact, opmw:WorkflowExecutionArtifact.
    ///       opmw:hasFileName "NTMParams_SMN_2010_03_14Z"^^xsd:string.</para>
    ///   <a href="http://www.opmw.org/ontology/hasFileName">opmw:hasFileName</a>
    /// </summary>
    let hasFileName = _prefixId.prefix "hasFileName"
    /// <summary>
    ///   <para>rdfs:label : has Location</para>
    ///   <para>rdfs:comment : Property used to link an execution artifact to the physical location of its file in the server.
    ///
    /// Example
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    /// @prefix opmv: &lt;http://purl.org/net/opmv/ns#&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowExecutionArtifact/DCF49186981194248009E24BAD6A6412&gt;
    ///       a opmv:Artifact, opmw:WorkflowExecutionArtifact.
    ///       opmw:hasLocation "http://www.opmw.org/datasets/resource/1/148/NTMParams_SMN_2010_03_14Z"^^xsd:anyURI.</para>
    ///   <a href="http://www.opmw.org/ontology/hasLocation">opmw:hasLocation</a>
    /// </summary>
    let hasLocation = _prefixId.prefix "hasLocation"
    /// <summary>
    ///   <para>rdfs:label : has Native System Template</para>
    ///   <para>rdfs:comment : Property used to link a workflow template to its native template (encoded in the syntax of the workflow system where it was designed: scufl, owl, etc.).
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowTemplate/AQUAFLOW_NTM&gt;
    ///      a opmw:WorkflowTemplate;
    ///      opmw:hasNativeSystemTemplate "http://wind.isi.edu/marbles/assets/components/workflow_portal/users/1/Water/ontology/Water/AquaFlow_NTM.owl"xsd:anyURI.</para>
    ///   <a href="http://www.opmw.org/ontology/hasNativeSystemTemplate">opmw:hasNativeSystemTemplate</a>
    /// </summary>
    let hasNativeSystemTemplate = _prefixId.prefix "hasNativeSystemTemplate"
    /// <summary>
    ///   <para>rdfs:label : has Original Log File</para>
    ///   <para>rdfs:comment : Property used to link an execution account or a workflow execution process to the correspondent log file produced by the enacting workflow engine.
    ///
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    /// @prefix opmo: &lt;http://openprovenance.org/model/opmo#&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowExecutionAccount/ACCOUNT1335506667949&gt;
    ///      a opmw:WorkflowExecutionAccount,opmo:Account;
    ///      opmw:hasOriginalLogFile "http://wind.isi.edu/marbles/assets/components/workflow_portal/users/1/Water/runs/run_148.ttl"^^sxd:anyURI.</para>
    ///   <a href="http://www.opmw.org/ontology/hasOriginalLogFile">opmw:hasOriginalLogFile</a>
    /// </summary>
    let hasOriginalLogFile = _prefixId.prefix "hasOriginalLogFile"
    /// <summary>
    ///   <para>rdfs:label : has Size</para>
    ///   <para>rdfs:comment : Property used to annotate a workflow execution artifact with the size in bytes of its file.
    ///
    /// Example
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    /// @prefix opmv: &lt;http://purl.org/net/opmv/ns#&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowExecutionArtifact/DCF49186981194248009E24BAD6A6412&gt;
    ///       a opmv:Artifact, opmw:WorkflowExecutionArtifact.
    ///       opmw:hasLocation "68"^^xsd:int.</para>
    ///   <a href="http://www.opmw.org/ontology/hasSize">opmw:hasSize</a>
    /// </summary>
    let hasSize = _prefixId.prefix "hasSize"
    /// <summary>
    ///   <para>rdfs:label : has Status</para>
    ///   <para>rdfs:comment : Property used to state whether an ececution account was successful or not.
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    /// @prefix opmo: &lt;http://openprovenance.org/model/opmo#&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowExecutionAccount/ACCOUNT1335506667949&gt;
    ///       a opmo:Account, opmw:ExecutionAccount;
    ///       opmw:hasStatus "SUCCESS"^^xsd.string.</para>
    ///   <a href="http://www.opmw.org/ontology/hasStatus">opmw:hasStatus</a>
    /// </summary>
    let hasStatus = _prefixId.prefix "hasStatus"
    /// <summary>
    ///   <para>rdfs:label : has Template Diagram</para>
    ///   <para>rdfs:comment : Property used to link a workflow template to its graphical representation.
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowTemplate/AQUAFLOW_NTM&gt;
    ///      a opmw:WorkflowTemplate;
    ///      opmw:hasTemplateDiagram "http://wind.isi.edu/marbles/assets/components/workflow_portal/users/1/Water/runs/run_148.png"xsd:anyURI.</para>
    ///   <a href="http://www.opmw.org/ontology/hasTemplateDiagram">opmw:hasTemplateDiagram</a>
    /// </summary>
    let hasTemplateDiagram = _prefixId.prefix "hasTemplateDiagram"
    /// <summary>
    ///   <para>rdfs:label : has Value</para>
    ///   <para>rdfs:comment : Property used to state the value of the artifact (in case of being a parameter).
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    /// @prefix opmv: &lt;http://purl.org/net/opmv/ns#&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowExecutionArtifact/DEPTH0.61959237&gt;
    ///      a opmv:Artifact, opmw:WorkflowExecutionArtifact;
    ///      opmw:hasValue "0.61959237"^^xsd:string.</para>
    ///   <a href="http://www.opmw.org/ontology/hasValue">opmw:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>rdfs:label : is Concrete</para>
    ///   <para>rdfs:comment : Property that specifies whether a component is abstract or not.</para>
    ///   <a href="http://www.opmw.org/ontology/isConcrete">opmw:isConcrete</a>
    /// </summary>
    let isConcrete = _prefixId.prefix "isConcrete"
    /// <summary>
    ///   <para>rdfs:label : is Generated By</para>
    ///   <para>rdfs:comment : Property that binds a workflow template artifact to the workflow template process that generates it.
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/DataVariable/AQUAFLOW_EDM_REAERATIONPARAMS&gt;
    ///      a opmw:DataVariable, opmw:WorkflowTemplateArtifact;
    ///      opmw:isGeneratedBy &lt;http://www.opmw.org/export/resource/WorkflowTemplateProcess/AQUAFLOW_EDM_REAERATIONEDM&gt;.
    ///
    /// </para>
    ///   <a href="http://www.opmw.org/ontology/isGeneratedBy">opmw:isGeneratedBy</a>
    /// </summary>
    let isGeneratedBy = _prefixId.prefix "isGeneratedBy"
    /// <summary>
    ///   <para>rdfs:label : is Parameter of Template^^xsd:string</para>
    ///   <para>rdfs:comment : Property used to dessignate which workflow Parameter Variables belong to a workflow template.
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/ParameterVariable/AQUAFLOW_EDM_DATE&gt;
    ///      a opmw:ParameterVariable;
    ///      opmw:isParameterOfTemplate &lt;http://www.opmw.org/export/resource/WorkflowTemplate/AQUAFLOW_EDM&gt;.^^xsd:string</para>
    ///   <a href="http://www.opmw.org/ontology/isParameterOfTemplate">opmw:isParameterOfTemplate</a>
    /// </summary>
    let isParameterOfTemplate = _prefixId.prefix "isParameterOfTemplate"
    /// <summary>
    ///   <para>rdfs:label : is Step of Template^^xsd:string</para>
    ///   <para>rdfs:comment : Property used to dessignate which workflow Steps (or Workflow Template Processes) belong to a workflow template.
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowTemplateProcess/AQUAFLOW_EDM_CALCULATEHOURLYAVERAGES&gt;
    ///      a opmw:WorkflowTemplateProcess;
    ///      opmw:isStepOfTemplate &lt;http://www.opmw.org/export/resource/WorkflowTemplate/AQUAFLOW_EDM&gt;.^^xsd:string</para>
    ///   <a href="http://www.opmw.org/ontology/isStepOfTemplate">opmw:isStepOfTemplate</a>
    /// </summary>
    let isStepOfTemplate = _prefixId.prefix "isStepOfTemplate"
    /// <summary>
    ///   <para>rdfs:label : is Variable of Template^^xsd:string</para>
    ///   <para>rdfs:comment : Property used to dessignate which workflow Data Variables belong to a workflow template.
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    ///
    /// &lt;http://www.opmw.org/export/page/resource/DataVariable/AQUAFLOW_EDM_HOURLYDATA&gt;
    ///      a opmw:DataVariable;
    ///      opmw:isVariableOfTemplate &lt;http://www.opmw.org/export/resource/WorkflowTemplate/AQUAFLOW_EDM&gt;.^^xsd:string</para>
    ///   <a href="http://www.opmw.org/ontology/isVariableOfTemplate">opmw:isVariableOfTemplate</a>
    /// </summary>
    let isVariableOfTemplate = _prefixId.prefix "isVariableOfTemplate"
    /// <summary>
    ///   <para>rdfs:label : overall End Time</para>
    ///   <para>rdfs:comment : Property which states that none of the activities contained in the account finished executing after the End Time.
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    /// @prefix opmo: &lt;http://openprovenance.org/model/opmo#&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowExecutionAccount/ACCOUNT1335506667949&gt;
    ///      a opmw:WorkflowExecutionAccount,opmo:Account;
    ///      opmw:overallEndTime "2012-04-25T10:28:55-07:00"^^xsd:dateTime.</para>
    ///   <a href="http://www.opmw.org/ontology/overallEndTime">opmw:overallEndTime</a>
    /// </summary>
    let overallEndTime = _prefixId.prefix "overallEndTime"
    /// <summary>
    ///   <para>rdfs:label : overall Start Time</para>
    ///   <para>rdfs:comment : Property which states that none of the activities in the current account started executing before the start time.
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    /// @prefix opmo: &lt;http://openprovenance.org/model/opmo#&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowExecutionAccount/ACCOUNT1335506667949&gt;
    ///      a opmw:WorkflowExecutionAccount,opmo:Account;
    ///      opmw:overallStartTime "2012-04-25T10:28:07-07:00"^^xsd:dateTime.</para>
    ///   <a href="http://www.opmw.org/ontology/overallStartTime">opmw:overallStartTime</a>
    /// </summary>
    let overallStartTime = _prefixId.prefix "overallStartTime"
    /// <summary>
    ///   <para>rdfs:label : uses</para>
    ///   <para>rdfs:comment : Property that binds a workflow template process to the workflow template artifact that generates it.
    ///
    /// Example:
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowTemplateProcess/AQUAFLOW_EDM_REAERATIONEDM&gt;
    ///      a opmw:WorkflowTemplateProcess;
    ///      opmw:uses &lt;http://www.opmw.org/export/resource/DataVariable/PARAMETERSFILE&gt;.</para>
    ///   <a href="http://www.opmw.org/ontology/uses">opmw:uses</a>
    /// </summary>
    let uses = _prefixId.prefix "uses"
    /// <summary>
    ///   <para>rdfs:label : version Number</para>
    ///   <para>rdfs:comment : Property used to annotate a resource with it version number.
    ///
    /// Example:
    /// @prefix rdfs: &lt;http://www.w3.org/2000/01/rdf-schema#&gt; .
    /// @prefix xsd:  &lt;http://www.w3.org/2001/XMLSchema#&gt; .
    /// @prefix owl:  &lt;http://www.w3.org/2002/07/owl#&gt; .
    /// @prefix opmw: &lt;http://www.opmw.org/ontology/&gt; .
    /// @prefix opmv: &lt;http://purl.org/net/opmv/ns#&gt; .
    /// @prefix opmo: &lt;http://openprovenance.org/model/opmo#&gt; .
    ///
    /// &lt;http://www.opmw.org/export/resource/WorkflowTemplate/AQUAFLOW_NTM&gt;
    ///      a opmw:WorkflowTemplate;
    ///      opmw:versionNumber "2"^^xsd:int.</para>
    ///   <a href="http://www.opmw.org/ontology/versionNumber">opmw:versionNumber</a>
    /// </summary>
    let versionNumber = _prefixId.prefix "versionNumber"
