namespace https.w3id.org.cto.hash

open DoxAletheia

module cto =
    let _namespace_name = "https://w3id.org/cto#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A specialized type of a (planned or executed) construction task that indicates that a construction element, spatial zone and/or damage are inspected. When a construction component or spatial zone is inspected and a damage is detected, the result of the inspection task is the damage description connected to the inspected object. Note that existing known damage, e.g. covered by previous inspections, can be the subject of subsequent inspection tasks.
    /// <see href="https://w3id.org/cto#InspectionTask"></see></summary>
    let InspectionTask = _prefix "InspectionTask"
    /// <summary>
    /// A generic class for defining (planned or executed) construction tasks. Instances of this class are connected with the construction element(s), spatial zone(s) or construction damages they operate on (cto:isSubjectOfTask). In addition, they might also be linked to a (planned or executed) moment or time span of performance (prov:atTime/prov:startedAtTime/prov:endedAtTime) and one or more task contexts (cto:hasTaskContext), task methods (cto:hasTaskMethod), assigned persons and/or organizations (prov:wasAssociatedWith), other tasks that must be finalized before the task can start (cto:afterFinishedTask) and reified statements that are added or deleted (cto:resultsInAddedStatement or cto:resultsInDeletedStatement).
    /// <see href="https://w3id.org/cto#Task"></see></summary>
    let Task = _prefix "Task"
    /// <summary>
    /// A specialized type of a (planned or executed) construction task that physically installs a construction component as part of the construction. The installment results in the addition of asserted triple(s) connecting the installed object to other construction elements and/or spatial zones and other triples describing the object through classification, properties and/or geometry.
    /// <see href="https://w3id.org/cto#InstallmentTask"></see></summary>
    let InstallmentTask = _prefix "InstallmentTask"
    /// <summary>
    /// A specialized type of a (planned or executed) construction task that physically modifies a construction component, spatial zone or damage. The modification results in a change to one or more properties and/or geometry descriptions of the modified subject. It should not be used to repair a damaged construction element or spatial zone as cto:RepairTask should be used instead.
    /// <see href="https://w3id.org/cto#ModificationTask"></see></summary>
    let ModificationTask = _prefix "ModificationTask"
    /// <summary>
    /// A specialized type of a (planned or executed) construction task that physically removes a construction component from the construction. The removal results in the removal of all the (directly or indirectly) asserted triples related to the thing that is subject of this task, including triples that use terminology from BOT (building topology), DOT (damage topology), OMG/FOG (geometry, properties, etc.
    /// <see href="https://w3id.org/cto#RemovalTask"></see></summary>
    let RemovalTask = _prefix "RemovalTask"
    /// <summary>
    /// A specialized type of a (planned or executed) construction task that repairs a damaged construction element or spatial zone. The subjects of this type of task are construction damages. Depending on the degree of modeling, a repair task can either directly result in the lifting of a damage (and its influence on properties of the damaged object) or subtasks can be defined e.g. to remove a damaged construction component and replace it by a new one.
    /// <see href="https://w3id.org/cto#RepairTask"></see></summary>
    let RepairTask = _prefix "RepairTask"
    /// <summary>
    /// A task context allows to group certain tasks that are related. Examples are tasks that fall under the responsibility of a certain organization, tasks grouped per activity or project (e.g. inspections, demolition, construction, etc.), work item (cost estimation) or a larger task that can be subdivided in smaller tasks.
    /// <see href="https://w3id.org/cto#TaskContext"></see></summary>
    let TaskContext = _prefix "TaskContext"
    /// <summary>
    /// A task method description defines how a task should be or was executed, depending on the construction dataset context (planning or progress monitoring). The cto:hasTaskMethod property connects a task to instances of this class that in turn point to a task method described in text using the cto:hasSimpleTaskMethodDescription. If RDF-based task method descriptions are applied instead of text, they can be connected using cto:hasComplexTaskMethodDescription.
    /// <see href="https://w3id.org/cto#TaskMethod"></see></summary>
    let TaskMethod = _prefix "TaskMethod"
    /// <summary>
    /// Connects the subject task to one ore more other tasks have to be finished before it is allowed to start.
    /// <see href="https://w3id.org/cto#afterFinishedTask"></see></summary>
    let afterFinishedTask = _prefix "afterFinishedTask"
    /// <summary>
    /// Property to connect a certain construction task (cto:Task) to the topnode of an RDF-based description of a task method.
    /// Depending on the property level used, this property get's a different location. In case of L1, a task is directly connected with the task method description. When using L2, a task is first connected to an intermediate property node via cp:hasTaskMethod. The intermediate node is then connected using cp:hasComplexTaskMethodDescription. In case of L3, the first intermediate node from L2 receives an outgoing opm:hasPropertyState property. The property state node is then connected to the task method description using cp:hasComplexTaskMethodDescrription. A task method description contains a step-by-step description of the procedure, used materials and equipment.
    /// <see href="https://w3id.org/cto#hasComplexTaskMethodDescription"></see></summary>
    let hasComplexTaskMethodDescription = _prefix "hasComplexTaskMethodDescription"
    /// <summary>
    /// Property to connect a construction task method node to an RDF literal containing either a text description for human interpretation (rdf:langString with language tag) and/or embedded or referenced file content (diagrams, movies, webpages, etc.). In case of a referenced external file, the literal contain the reference is of datatype xsd:anyURI. When the content of a file is embedded in the literal and file format is text-based the xsd:string datatype is used. If the file format is binary, a binary-to-text encoded version is located inside the RDF literal combined with a datatype to indicate the encoding scheme (xsd:base64Binary, xsd:hexBinary, or a custom datatype for other encoding schemes).
    /// <see href="https://w3id.org/cto#hasSimpleTaskMethodDescription"></see></summary>
    let hasSimpleTaskMethodDescription = _prefix "hasSimpleTaskMethodDescription"
    /// <summary>
    /// Connects a task to a task context that forms a group of tasks with shared properties.
    /// <see href="https://w3id.org/cto#hasTaskContext"></see></summary>
    let hasTaskContext = _prefix "hasTaskContext"
    /// <summary>
    /// Property to connect a certain construction task (cto:Task) to an intermediate property node when applied on property level 2 or 3. The intermediate property node then connects to a task method description directly using cto:hasSimpleTaskMethodDescription or cto:hasComplexTaskMethodDescription (L2) or to a property state using opm:hasPropertyState (L3) to indicate a versioned task method description connected using cto:hasSimpleTaskMethodDescription or cto:hasComplexTaskMethodDescription. A task method description contains a step-by-step description of the procedure, used materials and equipment.
    /// <see href="https://w3id.org/cto#hasTaskMethod"></see></summary>
    let hasTaskMethod = _prefix "hasTaskMethod"
    /// <summary>
    /// Connects a construction component (e.g. bot:Element instance), a spatial zone (e.g. bot:Zone instance) or a construction damage (e.g. dot:Damage instance) to a (planned or executed) task that is related to it.
    /// <see href="https://w3id.org/cto#isSubjectOfTask"></see></summary>
    let isSubjectOfTask = _prefix "isSubjectOfTask"
    /// <summary>
    /// Connects a (planned or executed) task to a reified statement that is added to the construction description as a result of the task.
    /// <see href="https://w3id.org/cto#resultsInAddedStatement"></see></summary>
    let resultsInAddedStatement = _prefix "resultsInAddedStatement"
    /// <summary>
    /// Connects a (planned or executed) task to a reified statement that is either added or deleted as a result of the task. The subproperties of this property (cto:resultsInAddedStatement and cto:resultsInDeletedStatement) should be used to express the consequence of the task to the statement. A cto:InstalmentTask and dot:Inspection task typically result in the use of cto:resultsInAddedStatement, a cto:RemovalTask typically results in the use of cto:resultsInDeletedStatement while a cto:ModificationTask results in the use of cto:resultsInAddedStatement and/or cto:resultsInDeletedStatement.
    /// <see href="https://w3id.org/cto#resultsInStatement"></see></summary>
    let resultsInStatement = _prefix "resultsInStatement"
    /// <summary>
    /// Connects a (planned or executed) task to a reified statement that is deleted from the construction description as a result of the task.
    /// <see href="https://w3id.org/cto#resultsInDeletedStatement"></see></summary>
    let resultsInDeletedStatement = _prefix "resultsInDeletedStatement"
