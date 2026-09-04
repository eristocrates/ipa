#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module spcm =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#" "spcm"

    /// <summary>
    ///   <para>rdfs:comment : Clase que representa los hitos del desarrollo o
    ///    versiones del software durante el transcurso de los proyectos.
    ///   ^^xsd:string</para>
    ///   <para>rdfs:label : The Milestone entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#Milestone">spcm:Milestone</a>
    /// </summary>
    let Milestone = _prefixId.prefix "Milestone"
    /// <summary>
    ///   <para>rdfs:comment : Clase contenedora de todos las tareas y milestones
    ///    establecidos para la planificación y monitorización de un proyecto
    ///    software.^^xsd:string</para>
    ///   <para>rdfs:label : The Project entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#Project">spcm:Project</a>
    /// </summary>
    let Project = _prefixId.prefix "Project"
    /// <summary>
    ///   <para>rdfs:comment : Clase que representa el papel que juega un determinado
    ///    miembro de un proyecto de desarrollo o mantenimiento de software.
    ///   ^^xsd:string</para>
    ///   <para>rdfs:label : The Role entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#Role">spcm:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:comment : Clase que define la acción de realizar una labor
    ///    necesaria para conseguir los objetivos del proyecto.^^xsd:string</para>
    ///   <para>rdfs:label : The Task entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#Task">spcm:Task</a>
    /// </summary>
    let Task = _prefixId.prefix "Task"
    /// <summary>
    ///   <para>rdfs:comment : Clase que permite categorizar una tarea según su ámbito
    ///    de aplicación.^^xsd:string</para>
    ///   <para>rdfs:label : The TaskCategory entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#TaskCategory">spcm:TaskCategory</a>
    /// </summary>
    let TaskCategory = _prefixId.prefix "TaskCategory"
    /// <summary>
    ///   <para>rdfs:comment : Clase de asociación que permite representar la
    ///    dependencia entre dos tareas concretas.^^xsd:string</para>
    ///   <para>rdfs:label : The TaskDependency entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#TaskDependency">spcm:TaskDependency</a>
    /// </summary>
    let TaskDependency = _prefixId.prefix "TaskDependency"
    /// <summary>
    ///   <para>rdfs:comment : Categoría de una tarea dada^^xsd:string</para>
    ///   <para>rdfs:label : The category reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#category">spcm:category</a>
    /// </summary>
    let category = _prefixId.prefix "category"
    /// <summary>
    ///   <para>rdfs:comment : Dependencias de una tarea^^xsd:string</para>
    ///   <para>rdfs:label : The dependencies reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#dependencies">spcm:dependencies</a>
    /// </summary>
    let dependencies = _prefixId.prefix "dependencies"
    /// <summary>
    ///   <para>rdfs:comment : Tarea dependiente de una tarea dada^^xsd:string</para>
    ///   <para>rdfs:label : The dependentTask reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#dependentTask">spcm:dependentTask</a>
    /// </summary>
    let dependentTask = _prefixId.prefix "dependentTask"
    /// <summary>
    ///   <para>rdfs:comment : Descripción de un proyecto, un hito o una tarea^^xsd:string</para>
    ///   <para>rdfs:label : The description attribute^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#description">spcm:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:comment : Roles asignados a un proyecto^^xsd:string</para>
    ///   <para>rdfs:label : The members reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#members">spcm:members</a>
    /// </summary>
    let members = _prefixId.prefix "members"
    /// <summary>
    ///   <para>rdfs:comment : Conjunto de milestones o hitos de un proyecto^^xsd:string</para>
    ///   <para>rdfs:label : The milestones reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#milestones">spcm:milestones</a>
    /// </summary>
    let milestones = _prefixId.prefix "milestones"
    /// <summary>
    ///   <para>rdfs:label : The name attribute^^xsd:string</para>
    ///   <para>rdfs:comment : Tareas asociadas a un determinado hito del proyecto^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#name">spcm:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:comment : Rol responsable de realizar una determinada tarea^^xsd:string</para>
    ///   <para>rdfs:label : The responsible reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#responsible">spcm:responsible</a>
    /// </summary>
    let responsible = _prefixId.prefix "responsible"
    let ruizrube = _prefixId.prefix "ruizrube"
    /// <summary>
    ///   <para>rdfs:comment : Habilidades específicas de un determinado rol.^^xsd:string</para>
    ///   <para>rdfs:label : The skills attribute^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#skills">spcm:skills</a>
    /// </summary>
    let skills = _prefixId.prefix "skills"
    /// <summary>
    ///   <para>rdfs:comment : Categorías definidas para las tareas de un proyecto^^xsd:string</para>
    ///   <para>rdfs:label : The taskCategories reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#taskCategories">spcm:taskCategories</a>
    /// </summary>
    let taskCategories = _prefixId.prefix "taskCategories"
    /// <summary>
    ///   <para>rdfs:comment : Tareas asociadas a un determinado hito del proyecto^^xsd:string</para>
    ///   <para>rdfs:label : The tasks reference^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#tasks">spcm:tasks</a>
    /// </summary>
    let tasks = _prefixId.prefix "tasks"
    /// <summary>
    ///   <para>rdfs:comment : Tipo de dependencia entre tareas^^xsd:string</para>
    ///   <para>rdfs:label : The type attribute^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#type">spcm:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
