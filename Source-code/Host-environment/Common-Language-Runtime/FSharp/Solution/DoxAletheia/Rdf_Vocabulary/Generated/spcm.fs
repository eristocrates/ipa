namespace http.spi_fm.uca.es.spdef.models.deployment.spcm._1._0.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module spcm =
    let _namespace_iri = Namespace_Iri spcm |> NamespaceIRI
    /// <summary>
    ///   <para>spcm:Milestone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Clase que representa los hitos del desarrollo o
    ///    versiones del software durante el transcurso de los proyectos.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The Milestone entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#Milestone">http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#Milestone</seealso>
    let Milestone = Prefixed_Name(spcm, "Milestone") |> PrefixedName
    /// <summary>
    ///   <para>spcm:Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Clase contenedora de todos las tareas y milestones
    ///    establecidos para la planificación y monitorización de un proyecto
    ///    software."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The Project entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#Project">http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#Project</seealso>
    let Project = Prefixed_Name(spcm, "Project") |> PrefixedName
    /// <summary>
    ///   <para>spcm:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Clase que representa el papel que juega un determinado
    ///    miembro de un proyecto de desarrollo o mantenimiento de software.
    ///   "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The Role entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#Role">http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#Role</seealso>
    let Role = Prefixed_Name(spcm, "Role") |> PrefixedName
    /// <summary>
    ///   <para>spcm:Task</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Clase que define la acción de realizar una labor
    ///    necesaria para conseguir los objetivos del proyecto."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The Task entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#Task">http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#Task</seealso>
    let Task = Prefixed_Name(spcm, "Task") |> PrefixedName
    /// <summary>
    ///   <para>spcm:TaskCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"Clase que permite categorizar una tarea según su ámbito
    ///    de aplicación."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The TaskCategory entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#TaskCategory">http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#TaskCategory</seealso>
    let TaskCategory = Prefixed_Name(spcm, "TaskCategory") |> PrefixedName
    /// <summary>
    ///   <para>spcm:TaskDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"Clase de asociación que permite representar la
    ///    dependencia entre dos tareas concretas."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The TaskDependency entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#TaskDependency">http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#TaskDependency</seealso>
    let TaskDependency = Prefixed_Name(spcm, "TaskDependency") |> PrefixedName
    /// <summary>
    ///   <para>spcm:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Categoría de una tarea dada"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The category reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#category">http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#category</seealso>
    let category = Prefixed_Name(spcm, "category") |> PrefixedName
    /// <summary>
    ///   <para>spcm:dependencies</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Dependencias de una tarea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The dependencies reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#dependencies">http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#dependencies</seealso>
    let dependencies = Prefixed_Name(spcm, "dependencies") |> PrefixedName
    /// <summary>
    ///   <para>spcm:dependentTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Tarea dependiente de una tarea dada"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The dependentTask reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#dependentTask">http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#dependentTask</seealso>
    let dependentTask = Prefixed_Name(spcm, "dependentTask") |> PrefixedName
    /// <summary>
    ///   <para>spcm:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Descripción de un proyecto, un hito o una tarea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The description attribute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#description">http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#description</seealso>
    let description = Prefixed_Name(spcm, "description") |> PrefixedName
    /// <summary>
    ///   <para>spcm:members</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Roles asignados a un proyecto"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The members reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#members">http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#members</seealso>
    let members = Prefixed_Name(spcm, "members") |> PrefixedName
    /// <summary>
    ///   <para>spcm:milestones</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Conjunto de milestones o hitos de un proyecto"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The milestones reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#milestones">http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#milestones</seealso>
    let milestones = Prefixed_Name(spcm, "milestones") |> PrefixedName
    /// <summary>
    ///   <para>spcm:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tareas asociadas a un determinado hito del proyecto"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The name attribute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#name">http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#name</seealso>
    let name = Prefixed_Name(spcm, "name") |> PrefixedName
    /// <summary>
    ///   <para>spcm:responsible</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Rol responsable de realizar una determinada tarea"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The responsible reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#responsible">http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#responsible</seealso>
    let responsible = Prefixed_Name(spcm, "responsible") |> PrefixedName
    /// <summary>
    ///   <para>spcm:ruizrube</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#ruizrube">http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#ruizrube</seealso>
    let ruizrube = Prefixed_Name(spcm, "ruizrube") |> PrefixedName
    /// <summary>
    ///   <para>spcm:skills</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"Habilidades específicas de un determinado rol."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The skills attribute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#skills">http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#skills</seealso>
    let skills = Prefixed_Name(spcm, "skills") |> PrefixedName
    /// <summary>
    ///   <para>spcm:taskCategories</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Categorías definidas para las tareas de un proyecto"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The taskCategories reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#taskCategories">http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#taskCategories</seealso>
    let taskCategories = Prefixed_Name(spcm, "taskCategories") |> PrefixedName
    /// <summary>
    ///   <para>spcm:tasks</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Tareas asociadas a un determinado hito del proyecto"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The tasks reference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#tasks">http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#tasks</seealso>
    let tasks = Prefixed_Name(spcm, "tasks") |> PrefixedName
    /// <summary>
    ///   <para>spcm:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Tipo de dependencia entre tareas"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"The type attribute"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#type">http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#type</seealso>
    let type_ = Prefixed_Name(spcm, "type") |> PrefixedName
