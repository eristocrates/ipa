#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module itm =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#" "itm"

    /// <summary>
    ///   <para>rdfs:label : The Issue entity^^xsd:string</para>
    ///   <para>rdfs:comment : Clase para describir una tarea o unidad concreta de
    ///    trabajo, necesaria para evolucionar un sistema informático, como
    ///    añadir una nueva característica, arreglo de un fallo, etc.
    ///   ^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Issue">itm:Issue</a>
    /// </summary>
    let Issue = _prefixId.prefix "Issue"
    /// <summary>
    ///   <para>rdfs:label : The IssueCategory entity^^xsd:string</para>
    ///   <para>rdfs:comment : Clase que permite realizar una clasificación específica
    ///    de los issues de un determinado proyecto.^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#IssueCategory">itm:IssueCategory</a>
    /// </summary>
    let IssueCategory = _prefixId.prefix "IssueCategory"
    /// <summary>
    ///   <para>rdfs:label : The IssueDependency entity^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#IssueDependency">itm:IssueDependency</a>
    /// </summary>
    let IssueDependency = _prefixId.prefix "IssueDependency"
    /// <summary>
    ///   <para>rdfs:label : The IssueTrackingDatabase entity^^xsd:string</para>
    ///   <para>rdfs:comment : Clase contenedora de todos los proyectos software
    ///    gestionados en la herramienta.^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#IssueTrackingDatabase">itm:IssueTrackingDatabase</a>
    /// </summary>
    let IssueTrackingDatabase = _prefixId.prefix "IssueTrackingDatabase"
    /// <summary>
    ///   <para>rdfs:label : The Member entity^^xsd:string</para>
    ///   <para>rdfs:comment : Clase utilizada para asociar un determinado usuario a un
    ///    proyecto, haciendo uso de un rol determinado.^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Member">itm:Member</a>
    /// </summary>
    let Member = _prefixId.prefix "Member"
    /// <summary>
    ///   <para>rdfs:label : The Project entity^^xsd:string</para>
    ///   <para>rdfs:comment : Clase que representa a un proyecto software controlado
    ///    desde la herramienta.^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Project">itm:Project</a>
    /// </summary>
    let Project = _prefixId.prefix "Project"
    /// <summary>
    ///   <para>rdfs:label : The Role entity^^xsd:string</para>
    ///   <para>rdfs:comment : Clase que representa el rol que juega un usuario en los
    ///    proyectos.^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Role">itm:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : The Tracker entity^^xsd:string</para>
    ///   <para>rdfs:comment : Clase utilizada para identificar el listado de issues o
    ///    tareas de un determinado tipo, típicamente bugs, features, o patchs.
    ///   ^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Tracker">itm:Tracker</a>
    /// </summary>
    let Tracker = _prefixId.prefix "Tracker"
    /// <summary>
    ///   <para>rdfs:label : The User entity^^xsd:string</para>
    ///   <para>rdfs:comment : Clase que representa a un usuario registrado en la
    ///    herramienta.^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#User">itm:User</a>
    /// </summary>
    let User = _prefixId.prefix "User"
    /// <summary>
    ///   <para>rdfs:label : The Version entity^^xsd:string</para>
    ///   <para>rdfs:comment : Clase que describe cada una de las versiones del
    ///    software objeto del proyecto gestionado en la herramienta.
    ///   ^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Version">itm:Version</a>
    /// </summary>
    let Version = _prefixId.prefix "Version"
    /// <summary>
    ///   <para>rdfs:label : The category reference^^xsd:string</para>
    ///   <para>rdfs:comment : Categoría de la tarea^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#category">itm:category</a>
    /// </summary>
    let category = _prefixId.prefix "category"
    /// <summary>
    ///   <para>rdfs:label : The completedDate attribute^^xsd:string</para>
    ///   <para>rdfs:comment : Fecha de compleción de una tarea^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#completedDate">itm:completedDate</a>
    /// </summary>
    let completedDate = _prefixId.prefix "completedDate"
    /// <summary>
    ///   <para>rdfs:label : The dependencies reference^^xsd:string</para>
    ///   <para>rdfs:comment : Dependencias de una tarea^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#dependencies">itm:dependencies</a>
    /// </summary>
    let dependencies = _prefixId.prefix "dependencies"
    /// <summary>
    ///   <para>rdfs:label : The dependentTask reference^^xsd:string</para>
    ///   <para>rdfs:comment : Tarea dependiente de una tarea dada^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#dependentTask">itm:dependentTask</a>
    /// </summary>
    let dependentTask = _prefixId.prefix "dependentTask"
    /// <summary>
    ///   <para>rdfs:comment : Descripción de un proyecto, versión o tarea^^xsd:string</para>
    ///   <para>rdfs:label : The description attribute^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#description">itm:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : The doneRatio attribute^^xsd:string</para>
    ///   <para>rdfs:comment : Porcentaje completado de la tarea^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#doneRatio">itm:doneRatio</a>
    /// </summary>
    let doneRatio = _prefixId.prefix "doneRatio"
    /// <summary>
    ///   <para>rdfs:label : The dueDate attribute^^xsd:string</para>
    ///   <para>rdfs:comment : Fecha estimada de finalización de una tarea^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#dueDate">itm:dueDate</a>
    /// </summary>
    let dueDate = _prefixId.prefix "dueDate"
    /// <summary>
    ///   <para>rdfs:label : The elapsedHours attribute^^xsd:string</para>
    ///   <para>rdfs:comment : Horas trabajadas en una tarea^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#elapsedHours">itm:elapsedHours</a>
    /// </summary>
    let elapsedHours = _prefixId.prefix "elapsedHours"
    /// <summary>
    ///   <para>rdfs:label : The estimatedHours attribute^^xsd:string</para>
    ///   <para>rdfs:comment : Número de horas estimadas para una tarea^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#estimatedHours">itm:estimatedHours</a>
    /// </summary>
    let estimatedHours = _prefixId.prefix "estimatedHours"
    /// <summary>
    ///   <para>rdfs:label : The issueCategories reference^^xsd:string</para>
    ///   <para>rdfs:comment : Categorías de las tareas registradas para un proyecto determinado^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#issueCategories">itm:issueCategories</a>
    /// </summary>
    let issueCategories = _prefixId.prefix "issueCategories"
    /// <summary>
    ///   <para>rdfs:label : The issues reference^^xsd:string</para>
    ///   <para>rdfs:comment : Tareas asociadas a una versión de software^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#issues">itm:issues</a>
    /// </summary>
    let issues = _prefixId.prefix "issues"
    /// <summary>
    ///   <para>rdfs:label : The language attribute^^xsd:string</para>
    ///   <para>rdfs:comment : Lenguaje de un usuario^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#language">itm:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>rdfs:label : The login attribute^^xsd:string</para>
    ///   <para>rdfs:comment : Login de un usuario^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#login">itm:login</a>
    /// </summary>
    let login = _prefixId.prefix "login"
    /// <summary>
    ///   <para>rdfs:label : The members reference^^xsd:string</para>
    ///   <para>rdfs:comment : Miembros del proyecto^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#members">itm:members</a>
    /// </summary>
    let members = _prefixId.prefix "members"
    /// <summary>
    ///   <para>rdfs:label : The name attribute^^xsd:string</para>
    ///   <para>rdfs:comment : Nombre del proyecto, versión, tarea, tracker, categoría de tarea o rol^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#name">itm:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:label : The owner reference^^xsd:string</para>
    ///   <para>rdfs:comment : Propietario de la tarea^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#owner">itm:owner</a>
    /// </summary>
    let owner = _prefixId.prefix "owner"
    /// <summary>
    ///   <para>rdfs:label : The permissions attribute^^xsd:string</para>
    ///   <para>rdfs:comment : Permisos que dispone de un determinado rol^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#permissions">itm:permissions</a>
    /// </summary>
    let permissions = _prefixId.prefix "permissions"
    /// <summary>
    ///   <para>rdfs:label : The priority attribute^^xsd:string</para>
    ///   <para>rdfs:comment : Prioridad en la realización de una tarea^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#priority">itm:priority</a>
    /// </summary>
    let priority = _prefixId.prefix "priority"
    /// <summary>
    ///   <para>rdfs:label : The projects reference^^xsd:string</para>
    ///   <para>rdfs:comment : Conjunto de proyectos registrados en el sistema de gestión de proyectos^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#projects">itm:projects</a>
    /// </summary>
    let projects = _prefixId.prefix "projects"
    /// <summary>
    ///   <para>rdfs:label : The responsible reference^^xsd:string</para>
    ///   <para>rdfs:comment : Miembro responsable de la tarea^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#responsible">itm:responsible</a>
    /// </summary>
    let responsible = _prefixId.prefix "responsible"
    /// <summary>
    ///   <para>rdfs:label : The role reference^^xsd:string</para>
    ///   <para>rdfs:comment : Rol que desempeña un miembro del proyecto^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#role">itm:role</a>
    /// </summary>
    let role = _prefixId.prefix "role"
    /// <summary>
    ///   <para>rdfs:label : The roles reference^^xsd:string</para>
    ///   <para>rdfs:comment : Roles registrados en el sistema de gestión de proyectos^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#roles">itm:roles</a>
    /// </summary>
    let roles = _prefixId.prefix "roles"
    let ruizrube = _prefixId.prefix "ruizrube"
    /// <summary>
    ///   <para>rdfs:label : The status attribute^^xsd:string</para>
    ///   <para>rdfs:comment : Estado de una versión o tarea de un proyecto^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#status">itm:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>rdfs:label : The tracker reference^^xsd:string</para>
    ///   <para>rdfs:comment : Tracker al que está asociado una tarea determinada^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#tracker">itm:tracker</a>
    /// </summary>
    let tracker = _prefixId.prefix "tracker"
    /// <summary>
    ///   <para>rdfs:label : The trackers reference^^xsd:string</para>
    ///   <para>rdfs:comment : Conjunto de trackers registrados en el sistema de gestión de proyectos^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#trackers">itm:trackers</a>
    /// </summary>
    let trackers = _prefixId.prefix "trackers"
    /// <summary>
    ///   <para>rdfs:label : The type attribute^^xsd:string</para>
    ///   <para>rdfs:comment : Tipo de dependencia entre tareas^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#type">itm:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
    /// <summary>
    ///   <para>rdfs:label : The user reference^^xsd:string</para>
    ///   <para>rdfs:comment : Usuario que es miembro de un proyecto^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#user">itm:user</a>
    /// </summary>
    let user = _prefixId.prefix "user"
    /// <summary>
    ///   <para>rdfs:label : The users reference^^xsd:string</para>
    ///   <para>rdfs:comment : Usuarios registrados en el sistema de gestión de proyectos^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#users">itm:users</a>
    /// </summary>
    let users = _prefixId.prefix "users"
    /// <summary>
    ///   <para>rdfs:label : The versions reference^^xsd:string</para>
    ///   <para>rdfs:comment : Versiones definidas para un proyecto software^^xsd:string</para>
    ///   <a href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#versions">itm:versions</a>
    /// </summary>
    let versions = _prefixId.prefix "versions"
