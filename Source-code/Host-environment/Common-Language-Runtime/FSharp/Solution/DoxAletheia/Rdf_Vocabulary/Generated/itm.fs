namespace http.spi_fm.uca.es.spdef.models.genericTools.itm._1._0.hash

open DoxAletheia.Rdf_Vocabulary

module itm =
    let _namespace_name = "http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#"
    /// <summary>
    ///   <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#ruizrube"></see>
    /// </summary>
    let ruizrube = Namespaced_IRI.parse _namespace_name "ruizrube" |> NamespacedName
    /// <summary>
    /// Clase para describir una tarea o unidad concreta de
    ///    trabajo, necesaria para evolucionar un sistema informático, como
    ///    añadir una nueva característica, arreglo de un fallo, etc.
    ///
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Issue"></see></summary>
    let Issue = Namespaced_IRI.parse _namespace_name "Issue" |> NamespacedName

    /// <summary>
    /// Clase que permite realizar una clasificación específica
    ///    de los issues de un determinado proyecto.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#IssueCategory"></see></summary>
    let IssueCategory =
        Namespaced_IRI.parse _namespace_name "IssueCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#IssueDependency"></see>
    /// </summary>
    let IssueDependency =
        Namespaced_IRI.parse _namespace_name "IssueDependency" |> NamespacedName

    /// <summary>
    /// Clase contenedora de todos los proyectos software
    ///    gestionados en la herramienta.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#IssueTrackingDatabase"></see></summary>
    let IssueTrackingDatabase =
        Namespaced_IRI.parse _namespace_name "IssueTrackingDatabase" |> NamespacedName

    /// <summary>
    /// Clase utilizada para asociar un determinado usuario a un
    ///    proyecto, haciendo uso de un rol determinado.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Member"></see></summary>
    let Member = Namespaced_IRI.parse _namespace_name "Member" |> NamespacedName
    /// <summary>
    /// Clase que representa a un proyecto software controlado
    ///    desde la herramienta.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Project"></see></summary>
    let Project = Namespaced_IRI.parse _namespace_name "Project" |> NamespacedName
    /// <summary>
    /// Clase que representa el rol que juega un usuario en los
    ///    proyectos.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName
    /// <summary>
    /// Clase utilizada para identificar el listado de issues o
    ///    tareas de un determinado tipo, típicamente bugs, features, o patchs.
    ///
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Tracker"></see></summary>
    let Tracker = Namespaced_IRI.parse _namespace_name "Tracker" |> NamespacedName
    /// <summary>
    /// Clase que representa a un usuario registrado en la
    ///    herramienta.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#User"></see></summary>
    let User = Namespaced_IRI.parse _namespace_name "User" |> NamespacedName
    /// <summary>
    /// Clase que describe cada una de las versiones del
    ///    software objeto del proyecto gestionado en la herramienta.
    ///
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Version"></see></summary>
    let Version = Namespaced_IRI.parse _namespace_name "Version" |> NamespacedName
    /// <summary>
    /// Categoría de la tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#category"></see></summary>
    let category = Namespaced_IRI.parse _namespace_name "category" |> NamespacedName

    /// <summary>
    /// Fecha de compleción de una tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#completedDate"></see></summary>
    let completedDate =
        Namespaced_IRI.parse _namespace_name "completedDate" |> NamespacedName

    /// <summary>
    /// Dependencias de una tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#dependencies"></see></summary>
    let dependencies =
        Namespaced_IRI.parse _namespace_name "dependencies" |> NamespacedName

    /// <summary>
    /// Tarea dependiente de una tarea dada
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#dependentTask"></see></summary>
    let dependentTask =
        Namespaced_IRI.parse _namespace_name "dependentTask" |> NamespacedName

    /// <summary>
    /// Descripción de un proyecto, versión o tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// Porcentaje completado de la tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#doneRatio"></see></summary>
    let doneRatio = Namespaced_IRI.parse _namespace_name "doneRatio" |> NamespacedName
    /// <summary>
    /// Fecha estimada de finalización de una tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#dueDate"></see></summary>
    let dueDate = Namespaced_IRI.parse _namespace_name "dueDate" |> NamespacedName

    /// <summary>
    /// Horas trabajadas en una tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#elapsedHours"></see></summary>
    let elapsedHours =
        Namespaced_IRI.parse _namespace_name "elapsedHours" |> NamespacedName

    /// <summary>
    /// Número de horas estimadas para una tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#estimatedHours"></see></summary>
    let estimatedHours =
        Namespaced_IRI.parse _namespace_name "estimatedHours" |> NamespacedName

    /// <summary>
    /// Categorías de las tareas registradas para un proyecto determinado
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#issueCategories"></see></summary>
    let issueCategories =
        Namespaced_IRI.parse _namespace_name "issueCategories" |> NamespacedName

    /// <summary>
    /// Tareas asociadas a una versión de software
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#issues"></see></summary>
    let issues = Namespaced_IRI.parse _namespace_name "issues" |> NamespacedName
    /// <summary>
    /// Lenguaje de un usuario
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName
    /// <summary>
    /// Login de un usuario
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#login"></see></summary>
    let login = Namespaced_IRI.parse _namespace_name "login" |> NamespacedName
    /// <summary>
    /// Miembros del proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#members"></see></summary>
    let members = Namespaced_IRI.parse _namespace_name "members" |> NamespacedName
    /// <summary>
    /// Nombre del proyecto, versión, tarea, tracker, categoría de tarea o rol
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    /// Propietario de la tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#owner"></see></summary>
    let owner = Namespaced_IRI.parse _namespace_name "owner" |> NamespacedName

    /// <summary>
    /// Permisos que dispone de un determinado rol
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#permissions"></see></summary>
    let permissions =
        Namespaced_IRI.parse _namespace_name "permissions" |> NamespacedName

    /// <summary>
    /// Prioridad en la realización de una tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#priority"></see></summary>
    let priority = Namespaced_IRI.parse _namespace_name "priority" |> NamespacedName
    /// <summary>
    /// Conjunto de proyectos registrados en el sistema de gestión de proyectos
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#projects"></see></summary>
    let projects = Namespaced_IRI.parse _namespace_name "projects" |> NamespacedName

    /// <summary>
    /// Miembro responsable de la tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#responsible"></see></summary>
    let responsible =
        Namespaced_IRI.parse _namespace_name "responsible" |> NamespacedName

    /// <summary>
    /// Rol que desempeña un miembro del proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#role"></see></summary>
    let role = Namespaced_IRI.parse _namespace_name "role" |> NamespacedName
    /// <summary>
    /// Roles registrados en el sistema de gestión de proyectos
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#roles"></see></summary>
    let roles = Namespaced_IRI.parse _namespace_name "roles" |> NamespacedName
    /// <summary>
    /// Estado de una versión o tarea de un proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#status"></see></summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName
    /// <summary>
    /// Tracker al que está asociado una tarea determinada
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#tracker"></see></summary>
    let tracker = Namespaced_IRI.parse _namespace_name "tracker" |> NamespacedName
    /// <summary>
    /// Conjunto de trackers registrados en el sistema de gestión de proyectos
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#trackers"></see></summary>
    let trackers = Namespaced_IRI.parse _namespace_name "trackers" |> NamespacedName
    /// <summary>
    /// Tipo de dependencia entre tareas
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#type"></see></summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName
    /// <summary>
    /// Usuario que es miembro de un proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#user"></see></summary>
    let user = Namespaced_IRI.parse _namespace_name "user" |> NamespacedName
    /// <summary>
    /// Usuarios registrados en el sistema de gestión de proyectos
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#users"></see></summary>
    let users = Namespaced_IRI.parse _namespace_name "users" |> NamespacedName
    /// <summary>
    /// Versiones definidas para un proyecto software
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#versions"></see></summary>
    let versions = Namespaced_IRI.parse _namespace_name "versions" |> NamespacedName
