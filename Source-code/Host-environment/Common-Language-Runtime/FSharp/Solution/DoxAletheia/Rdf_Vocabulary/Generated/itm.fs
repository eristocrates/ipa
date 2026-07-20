namespace http.spi_fm.uca.es.spdef.models.genericTools.itm._1._0.hash

open DoxAletheia

module itm =
    let _namespace_name = "http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#ruizrube"></see>
    /// </summary>
    let ruizrube = _prefix "ruizrube"
    /// <summary>
    /// Clase para describir una tarea o unidad concreta de
    ///    trabajo, necesaria para evolucionar un sistema informático, como
    ///    añadir una nueva característica, arreglo de un fallo, etc.
    ///
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Issue"></see></summary>
    let Issue = _prefix "Issue"
    /// <summary>
    /// Clase que permite realizar una clasificación específica
    ///    de los issues de un determinado proyecto.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#IssueCategory"></see></summary>
    let IssueCategory = _prefix "IssueCategory"
    /// <summary>
    ///   <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#IssueDependency"></see>
    /// </summary>
    let IssueDependency = _prefix "IssueDependency"
    /// <summary>
    /// Clase contenedora de todos los proyectos software
    ///    gestionados en la herramienta.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#IssueTrackingDatabase"></see></summary>
    let IssueTrackingDatabase = _prefix "IssueTrackingDatabase"
    /// <summary>
    /// Clase utilizada para asociar un determinado usuario a un
    ///    proyecto, haciendo uso de un rol determinado.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Member"></see></summary>
    let Member = _prefix "Member"
    /// <summary>
    /// Clase que representa a un proyecto software controlado
    ///    desde la herramienta.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Project"></see></summary>
    let Project = _prefix "Project"
    /// <summary>
    /// Clase que representa el rol que juega un usuario en los
    ///    proyectos.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// Clase utilizada para identificar el listado de issues o
    ///    tareas de un determinado tipo, típicamente bugs, features, o patchs.
    ///
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Tracker"></see></summary>
    let Tracker = _prefix "Tracker"
    /// <summary>
    /// Clase que representa a un usuario registrado en la
    ///    herramienta.
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#User"></see></summary>
    let User = _prefix "User"
    /// <summary>
    /// Clase que describe cada una de las versiones del
    ///    software objeto del proyecto gestionado en la herramienta.
    ///
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Version"></see></summary>
    let Version = _prefix "Version"
    /// <summary>
    /// Categoría de la tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#category"></see></summary>
    let category = _prefix "category"
    /// <summary>
    /// Fecha de compleción de una tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#completedDate"></see></summary>
    let completedDate = _prefix "completedDate"
    /// <summary>
    /// Dependencias de una tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#dependencies"></see></summary>
    let dependencies = _prefix "dependencies"
    /// <summary>
    /// Tarea dependiente de una tarea dada
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#dependentTask"></see></summary>
    let dependentTask = _prefix "dependentTask"
    /// <summary>
    /// Descripción de un proyecto, versión o tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// Porcentaje completado de la tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#doneRatio"></see></summary>
    let doneRatio = _prefix "doneRatio"
    /// <summary>
    /// Fecha estimada de finalización de una tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#dueDate"></see></summary>
    let dueDate = _prefix "dueDate"
    /// <summary>
    /// Horas trabajadas en una tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#elapsedHours"></see></summary>
    let elapsedHours = _prefix "elapsedHours"
    /// <summary>
    /// Número de horas estimadas para una tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#estimatedHours"></see></summary>
    let estimatedHours = _prefix "estimatedHours"
    /// <summary>
    /// Categorías de las tareas registradas para un proyecto determinado
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#issueCategories"></see></summary>
    let issueCategories = _prefix "issueCategories"
    /// <summary>
    /// Tareas asociadas a una versión de software
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#issues"></see></summary>
    let issues = _prefix "issues"
    /// <summary>
    /// Lenguaje de un usuario
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// Login de un usuario
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#login"></see></summary>
    let login = _prefix "login"
    /// <summary>
    /// Miembros del proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#members"></see></summary>
    let members = _prefix "members"
    /// <summary>
    /// Nombre del proyecto, versión, tarea, tracker, categoría de tarea o rol
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// Propietario de la tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#owner"></see></summary>
    let owner = _prefix "owner"
    /// <summary>
    /// Permisos que dispone de un determinado rol
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#permissions"></see></summary>
    let permissions = _prefix "permissions"
    /// <summary>
    /// Prioridad en la realización de una tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#priority"></see></summary>
    let priority = _prefix "priority"
    /// <summary>
    /// Conjunto de proyectos registrados en el sistema de gestión de proyectos
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#projects"></see></summary>
    let projects = _prefix "projects"
    /// <summary>
    /// Miembro responsable de la tarea
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#responsible"></see></summary>
    let responsible = _prefix "responsible"
    /// <summary>
    /// Rol que desempeña un miembro del proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#role"></see></summary>
    let role = _prefix "role"
    /// <summary>
    /// Roles registrados en el sistema de gestión de proyectos
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#roles"></see></summary>
    let roles = _prefix "roles"
    /// <summary>
    /// Estado de una versión o tarea de un proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#status"></see></summary>
    let status = _prefix "status"
    /// <summary>
    /// Tracker al que está asociado una tarea determinada
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#tracker"></see></summary>
    let tracker = _prefix "tracker"
    /// <summary>
    /// Conjunto de trackers registrados en el sistema de gestión de proyectos
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#trackers"></see></summary>
    let trackers = _prefix "trackers"
    /// <summary>
    /// Tipo de dependencia entre tareas
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#type"></see></summary>
    let type_ = _prefix "type"
    /// <summary>
    /// Usuario que es miembro de un proyecto
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#user"></see></summary>
    let user = _prefix "user"
    /// <summary>
    /// Usuarios registrados en el sistema de gestión de proyectos
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#users"></see></summary>
    let users = _prefix "users"
    /// <summary>
    /// Versiones definidas para un proyecto software
    /// <see href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#versions"></see></summary>
    let versions = _prefix "versions"
