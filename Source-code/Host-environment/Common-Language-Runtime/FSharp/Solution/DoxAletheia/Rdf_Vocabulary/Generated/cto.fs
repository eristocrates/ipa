namespace https.w3id.org.cto.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module cto =
    let _namespace_iri = Namespace_Iri cto |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:cto#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/cto#">https://w3id.org/cto#</seealso>
    let _prefix_iri = Prefixed_Name(cto, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cto#InspectionTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specialized type of a (planned or executed) construction task that indicates that a construction element, spatial zone and/or damage are inspected. When a construction component or spatial zone is inspected and a damage is detected, the result of the inspection task is the damage description connected to the inspected object. Note that existing known damage, e.g. covered by previous inspections, can be the subject of subsequent inspection tasks."</para>
    /// labels<para>"an inspection task"</para></remarks>
    /// <seealso href="https://w3id.org/cto#InspectionTask">https://w3id.org/cto#InspectionTask</seealso>
    let InspectionTask = Prefixed_Name(cto, "InspectionTask") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cto#InstallmentTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specialized type of a (planned or executed) construction task that physically installs a construction component as part of the construction. The installment results in the addition of asserted triple(s) connecting the installed object to other construction elements and/or spatial zones and other triples describing the object through classification, properties and/or geometry."</para>
    /// labels<para>"an installment task"</para></remarks>
    /// <seealso href="https://w3id.org/cto#InstallmentTask">https://w3id.org/cto#InstallmentTask</seealso>
    let InstallmentTask = Prefixed_Name(cto, "InstallmentTask") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cto#ModificationTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specialized type of a (planned or executed) construction task that physically modifies a construction component, spatial zone or damage. The modification results in a change to one or more properties and/or geometry descriptions of the modified subject. It should not be used to repair a damaged construction element or spatial zone as cto:RepairTask should be used instead."</para>
    /// labels<para>"a modification task"</para></remarks>
    /// <seealso href="https://w3id.org/cto#ModificationTask">https://w3id.org/cto#ModificationTask</seealso>
    let ModificationTask = Prefixed_Name(cto, "ModificationTask") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cto#RemovalTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specialized type of a (planned or executed) construction task that physically removes a construction component from the construction. The removal results in the removal of all the (directly or indirectly) asserted triples related to the thing that is subject of this task, including triples that use terminology from BOT (building topology), DOT (damage topology), OMG/FOG (geometry, properties, etc."</para>
    /// labels<para>"a removal task"</para></remarks>
    /// <seealso href="https://w3id.org/cto#RemovalTask">https://w3id.org/cto#RemovalTask</seealso>
    let RemovalTask = Prefixed_Name(cto, "RemovalTask") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cto#RepairTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specialized type of a (planned or executed) construction task that repairs a damaged construction element or spatial zone. The subjects of this type of task are construction damages. Depending on the degree of modeling, a repair task can either directly result in the lifting of a damage (and its influence on properties of the damaged object) or subtasks can be defined e.g. to remove a damaged construction component and replace it by a new one."</para>
    /// labels<para>"a repair task"</para></remarks>
    /// <seealso href="https://w3id.org/cto#RepairTask">https://w3id.org/cto#RepairTask</seealso>
    let RepairTask = Prefixed_Name(cto, "RepairTask") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cto#Task</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A generic class for defining (planned or executed) construction tasks. Instances of this class are connected with the construction element(s), spatial zone(s) or construction damages they operate on (cto:isSubjectOfTask). In addition, they might also be linked to a (planned or executed) moment or time span of performance (prov:atTime/prov:startedAtTime/prov:endedAtTime) and one or more task contexts (cto:hasTaskContext), task methods (cto:hasTaskMethod), assigned persons and/or organizations (prov:wasAssociatedWith), other tasks that must be finalized before the task can start (cto:afterFinishedTask) and reified statements that are added or deleted (cto:resultsInAddedStatement or cto:resultsInDeletedStatement)."</para>
    ///   <para>"A generic class for defining (planned or executed) construction tasks according to the CTO ontology (see https://mathib.github.io/cto-ontology/)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"a construction task"</para></remarks>
    /// <seealso href="https://w3id.org/cto#Task">https://w3id.org/cto#Task</seealso>
    let Task = Prefixed_Name(cto, "Task") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cto#TaskContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A task context allows to group certain tasks that are related. Examples are tasks that fall under the responsibility of a certain organization, tasks grouped per activity or project (e.g. inspections, demolition, construction, etc.), work item (cost estimation) or a larger task that can be subdivided in smaller tasks."</para>
    /// labels<para>"a task context"</para></remarks>
    /// <seealso href="https://w3id.org/cto#TaskContext">https://w3id.org/cto#TaskContext</seealso>
    let TaskContext = Prefixed_Name(cto, "TaskContext") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cto#TaskMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"CTO task method that is used in (L2) and (L3)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A task method description defines how a task should be or was executed, depending on the construction dataset context (planning or progress monitoring). The cto:hasTaskMethod property connects a task to instances of this class that in turn point to a task method described in text using the cto:hasSimpleTaskMethodDescription. If RDF-based task method descriptions are applied instead of text, they can be connected using cto:hasComplexTaskMethodDescription."</para>
    /// labels<para>"TaskMethod"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"a task (execution) method"</para></remarks>
    /// <seealso href="https://w3id.org/cto#TaskMethod">https://w3id.org/cto#TaskMethod</seealso>
    let TaskMethod = Prefixed_Name(cto, "TaskMethod") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cto#afterFinishedTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects the subject task to one ore more other tasks have to be finished before it is allowed to start."</para>
    /// labels<para>"after finished task"</para></remarks>
    /// <seealso href="https://w3id.org/cto#afterFinishedTask">https://w3id.org/cto#afterFinishedTask</seealso>
    let afterFinishedTask = Prefixed_Name(cto, "afterFinishedTask") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cto#hasComplexTaskMethodDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property to connect a certain construction task (cto:Task) to the topnode of an RDF-based description of a task method.
    /// Depending on the property level used, this property get's a different location. In case of L1, a task is directly connected with the task method description. When using L2, a task is first connected to an intermediate property node via cp:hasTaskMethod. The intermediate node is then connected using cp:hasComplexTaskMethodDescription. In case of L3, the first intermediate node from L2 receives an outgoing opm:hasPropertyState property. The property state node is then connected to the task method description using cp:hasComplexTaskMethodDescrription. A task method description contains a step-by-step description of the procedure, used materials and equipment."</para>
    /// labels<para>"has complex task method description"</para></remarks>
    /// <seealso href="https://w3id.org/cto#hasComplexTaskMethodDescription">https://w3id.org/cto#hasComplexTaskMethodDescription</seealso>
    let hasComplexTaskMethodDescription =
        Prefixed_Name(cto, "hasComplexTaskMethodDescription") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cto#hasSimpleTaskMethodDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Property to connect a construction task method node to an RDF literal containing either a text description for human interpretation (rdf:langString with language tag) and/or embedded or referenced file content (diagrams, movies, webpages, etc.). In case of a referenced external file, the literal contain the reference is of datatype xsd:anyURI. When the content of a file is embedded in the literal and file format is text-based the xsd:string datatype is used. If the file format is binary, a binary-to-text encoded version is located inside the RDF literal combined with a datatype to indicate the encoding scheme (xsd:base64Binary, xsd:hexBinary, or a custom datatype for other encoding schemes)."</para>
    /// labels<para>"has simple task method description"</para></remarks>
    /// <seealso href="https://w3id.org/cto#hasSimpleTaskMethodDescription">https://w3id.org/cto#hasSimpleTaskMethodDescription</seealso>
    let hasSimpleTaskMethodDescription =
        Prefixed_Name(cto, "hasSimpleTaskMethodDescription") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cto#hasTaskContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a task to a task context that forms a group of tasks with shared properties."</para>
    /// labels<para>"has task context"</para></remarks>
    /// <seealso href="https://w3id.org/cto#hasTaskContext">https://w3id.org/cto#hasTaskContext</seealso>
    let hasTaskContext = Prefixed_Name(cto, "hasTaskContext") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cto#hasTaskMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Property to connect a certain construction task (cto:Task) to an intermediate property node when applied on property level 2 or 3. The intermediate property node then connects to a task method description directly using cto:hasSimpleTaskMethodDescription or cto:hasComplexTaskMethodDescription (L2) or to a property state using opm:hasPropertyState (L3) to indicate a versioned task method description connected using cto:hasSimpleTaskMethodDescription or cto:hasComplexTaskMethodDescription. A task method description contains a step-by-step description of the procedure, used materials and equipment."</para>
    /// labels<para>"has task method"</para></remarks>
    /// <seealso href="https://w3id.org/cto#hasTaskMethod">https://w3id.org/cto#hasTaskMethod</seealso>
    let hasTaskMethod = Prefixed_Name(cto, "hasTaskMethod") |> PrefixedName
    /// <summary>
    ///   <para>w3id:cto#isSubjectOfTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a construction component (e.g. bot:Element instance), a spatial zone (e.g. bot:Zone instance) or a construction damage (e.g. dot:Damage instance) to a (planned or executed) task that is related to it."</para>
    /// labels<para>"is subject of task"</para></remarks>
    /// <seealso href="https://w3id.org/cto#isSubjectOfTask">https://w3id.org/cto#isSubjectOfTask</seealso>
    let isSubjectOfTask = Prefixed_Name(cto, "isSubjectOfTask") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cto#resultsInAddedStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a (planned or executed) task to a reified statement that is added to the construction description as a result of the task."</para>
    /// labels<para>"results in added statement"</para></remarks>
    /// <seealso href="https://w3id.org/cto#resultsInAddedStatement">https://w3id.org/cto#resultsInAddedStatement</seealso>
    let resultsInAddedStatement =
        Prefixed_Name(cto, "resultsInAddedStatement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cto#resultsInDeletedStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a (planned or executed) task to a reified statement that is deleted from the construction description as a result of the task."</para>
    /// labels<para>"results in deleted statement"</para></remarks>
    /// <seealso href="https://w3id.org/cto#resultsInDeletedStatement">https://w3id.org/cto#resultsInDeletedStatement</seealso>
    let resultsInDeletedStatement =
        Prefixed_Name(cto, "resultsInDeletedStatement") |> PrefixedName

    /// <summary>
    ///   <para>w3id:cto#resultsInStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Connects a (planned or executed) task to a reified statement that is either added or deleted as a result of the task. The subproperties of this property (cto:resultsInAddedStatement and cto:resultsInDeletedStatement) should be used to express the consequence of the task to the statement. A cto:InstalmentTask and dot:Inspection task typically result in the use of cto:resultsInAddedStatement, a cto:RemovalTask typically results in the use of cto:resultsInDeletedStatement while a cto:ModificationTask results in the use of cto:resultsInAddedStatement and/or cto:resultsInDeletedStatement."</para>
    /// labels<para>"results in statement"</para></remarks>
    /// <seealso href="https://w3id.org/cto#resultsInStatement">https://w3id.org/cto#resultsInStatement</seealso>
    let resultsInStatement = Prefixed_Name(cto, "resultsInStatement") |> PrefixedName
