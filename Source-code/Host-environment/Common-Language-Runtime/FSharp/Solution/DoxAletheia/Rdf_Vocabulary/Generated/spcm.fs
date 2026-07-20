namespace http.spi_fm.uca.es.spdef.models.deployment.spcm._1._0.hash

open DoxAletheia

module spcm =
    let _namespace_name = "http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#ruizrube"></see>
    /// </summary>
    let ruizrube = _prefix "ruizrube"
    /// <summary>
    /// Clase que representa los hitos del desarrollo o
    ///    versiones del software durante el transcurso de los proyectos.
    ///
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#Milestone"></see></summary>
    let Milestone = _prefix "Milestone"
    /// <summary>
    /// Clase contenedora de todos las tareas y milestones
    ///    establecidos para la planificación y monitorización de un proyecto
    ///    software.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#Project"></see></summary>
    let Project = _prefix "Project"
    /// <summary>
    /// Clase que representa el papel que juega un determinado
    ///    miembro de un proyecto de desarrollo o mantenimiento de software.
    ///
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// Clase que define la acción de realizar una labor
    ///    necesaria para conseguir los objetivos del proyecto.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#Task"></see></summary>
    let Task = _prefix "Task"
    /// <summary>
    /// Clase que permite categorizar una tarea según su ámbito
    ///    de aplicación.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#TaskCategory"></see></summary>
    let TaskCategory = _prefix "TaskCategory"
    /// <summary>
    /// Clase de asociación que permite representar la
    ///    dependencia entre dos tareas concretas.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#TaskDependency"></see></summary>
    let TaskDependency = _prefix "TaskDependency"
    /// <summary>
    /// Categoría de una tarea dada
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#category"></see></summary>
    let category = _prefix "category"
    /// <summary>
    /// Dependencias de una tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#dependencies"></see></summary>
    let dependencies = _prefix "dependencies"
    /// <summary>
    /// Tarea dependiente de una tarea dada
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#dependentTask"></see></summary>
    let dependentTask = _prefix "dependentTask"
    /// <summary>
    /// Descripción de un proyecto, un hito o una tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// Roles asignados a un proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#members"></see></summary>
    let members = _prefix "members"
    /// <summary>
    /// Conjunto de milestones o hitos de un proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#milestones"></see></summary>
    let milestones = _prefix "milestones"
    /// <summary>
    /// Tareas asociadas a un determinado hito del proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// Rol responsable de realizar una determinada tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#responsible"></see></summary>
    let responsible = _prefix "responsible"
    /// <summary>
    /// Habilidades específicas de un determinado rol.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#skills"></see></summary>
    let skills = _prefix "skills"
    /// <summary>
    /// Categorías definidas para las tareas de un proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#taskCategories"></see></summary>
    let taskCategories = _prefix "taskCategories"
    /// <summary>
    /// Tareas asociadas a un determinado hito del proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#tasks"></see></summary>
    let tasks = _prefix "tasks"
    /// <summary>
    /// Tipo de dependencia entre tareas
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#type"></see></summary>
    let type_ = _prefix "type"
