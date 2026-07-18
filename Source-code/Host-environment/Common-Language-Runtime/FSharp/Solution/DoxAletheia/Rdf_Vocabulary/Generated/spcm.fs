namespace http.spi_fm.uca.es.spdef.models.deployment.spcm._1._0.hash

open DoxAletheia.Rdf_Vocabulary

module spcm =
    let _namespace_name = "http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#"
    /// <summary>
    ///   <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#ruizrube"></see>
    /// </summary>
    let ruizrube = Namespaced_IRI.parse _namespace_name "ruizrube" |> NamespacedName
    /// <summary>
    /// Clase que representa los hitos del desarrollo o
    ///    versiones del software durante el transcurso de los proyectos.
    ///
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#Milestone"></see></summary>
    let Milestone = Namespaced_IRI.parse _namespace_name "Milestone" |> NamespacedName
    /// <summary>
    /// Clase contenedora de todos las tareas y milestones
    ///    establecidos para la planificación y monitorización de un proyecto
    ///    software.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#Project"></see></summary>
    let Project = Namespaced_IRI.parse _namespace_name "Project" |> NamespacedName
    /// <summary>
    /// Clase que representa el papel que juega un determinado
    ///    miembro de un proyecto de desarrollo o mantenimiento de software.
    ///
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName
    /// <summary>
    /// Clase que define la acción de realizar una labor
    ///    necesaria para conseguir los objetivos del proyecto.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#Task"></see></summary>
    let Task = Namespaced_IRI.parse _namespace_name "Task" |> NamespacedName

    /// <summary>
    /// Clase que permite categorizar una tarea según su ámbito
    ///    de aplicación.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#TaskCategory"></see></summary>
    let TaskCategory =
        Namespaced_IRI.parse _namespace_name "TaskCategory" |> NamespacedName

    /// <summary>
    /// Clase de asociación que permite representar la
    ///    dependencia entre dos tareas concretas.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#TaskDependency"></see></summary>
    let TaskDependency =
        Namespaced_IRI.parse _namespace_name "TaskDependency" |> NamespacedName

    /// <summary>
    /// Categoría de una tarea dada
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#category"></see></summary>
    let category = Namespaced_IRI.parse _namespace_name "category" |> NamespacedName

    /// <summary>
    /// Dependencias de una tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#dependencies"></see></summary>
    let dependencies =
        Namespaced_IRI.parse _namespace_name "dependencies" |> NamespacedName

    /// <summary>
    /// Tarea dependiente de una tarea dada
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#dependentTask"></see></summary>
    let dependentTask =
        Namespaced_IRI.parse _namespace_name "dependentTask" |> NamespacedName

    /// <summary>
    /// Descripción de un proyecto, un hito o una tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// Roles asignados a un proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#members"></see></summary>
    let members = Namespaced_IRI.parse _namespace_name "members" |> NamespacedName
    /// <summary>
    /// Conjunto de milestones o hitos de un proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#milestones"></see></summary>
    let milestones = Namespaced_IRI.parse _namespace_name "milestones" |> NamespacedName
    /// <summary>
    /// Tareas asociadas a un determinado hito del proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

    /// <summary>
    /// Rol responsable de realizar una determinada tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#responsible"></see></summary>
    let responsible =
        Namespaced_IRI.parse _namespace_name "responsible" |> NamespacedName

    /// <summary>
    /// Habilidades específicas de un determinado rol.
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#skills"></see></summary>
    let skills = Namespaced_IRI.parse _namespace_name "skills" |> NamespacedName

    /// <summary>
    /// Categorías definidas para las tareas de un proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#taskCategories"></see></summary>
    let taskCategories =
        Namespaced_IRI.parse _namespace_name "taskCategories" |> NamespacedName

    /// <summary>
    /// Tareas asociadas a un determinado hito del proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#tasks"></see></summary>
    let tasks = Namespaced_IRI.parse _namespace_name "tasks" |> NamespacedName
    /// <summary>
    /// Tipo de dependencia entre tareas
    /// <see href="http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#type"></see></summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName
