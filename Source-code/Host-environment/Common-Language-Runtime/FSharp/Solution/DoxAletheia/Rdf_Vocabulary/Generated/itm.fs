namespace http.spi_fm.uca.es.spdef.models.genericTools.itm._1._0.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module itm =
    let _namespace_iri = Namespace_Iri itm |> NamespaceIRI
    /// <summary>
    ///   <para>itm:IssueCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Clase que permite realizar una clasificación específica
    ///    de los issues de un determinado proyecto.</para>
    /// labels<para>The IssueCategory entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#IssueCategory">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#IssueCategory</seealso>
    let IssueCategory = Prefixed_Name(itm, "IssueCategory") |> PrefixedName

    /// <summary>
    ///   <para>itm:IssueTrackingDatabase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Clase contenedora de todos los proyectos software
    ///    gestionados en la herramienta.</para>
    /// labels<para>The IssueTrackingDatabase entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#IssueTrackingDatabase">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#IssueTrackingDatabase</seealso>
    let IssueTrackingDatabase =
        Prefixed_Name(itm, "IssueTrackingDatabase") |> PrefixedName

    /// <summary>
    ///   <para>itm:ruizrube</para>
    /// </summary>
    /// <remarks>
    ///   <para>foaf:Person</para>
    /// </remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#ruizrube">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#ruizrube</seealso>
    let ruizrube = Prefixed_Name(itm, "ruizrube") |> PrefixedName
    /// <summary>
    ///   <para>itm:Issue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Clase para describir una tarea o unidad concreta de
    ///    trabajo, necesaria para evolucionar un sistema informático, como
    ///    añadir una nueva característica, arreglo de un fallo, etc.
    ///   </para>
    /// labels<para>The Issue entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Issue">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Issue</seealso>
    let Issue = Prefixed_Name(itm, "Issue") |> PrefixedName
    /// <summary>
    ///   <para>itm:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Categoría de la tarea</para>
    /// labels<para>The category reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#category">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#category</seealso>
    let category = Prefixed_Name(itm, "category") |> PrefixedName
    /// <summary>
    ///   <para>itm:IssueDependency</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>The IssueDependency entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#IssueDependency">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#IssueDependency</seealso>
    let IssueDependency = Prefixed_Name(itm, "IssueDependency") |> PrefixedName
    /// <summary>
    ///   <para>itm:Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Clase que representa a un proyecto software controlado
    ///    desde la herramienta.</para>
    /// labels<para>The Project entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Project">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Project</seealso>
    let Project = Prefixed_Name(itm, "Project") |> PrefixedName
    /// <summary>
    ///   <para>itm:Member</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Clase utilizada para asociar un determinado usuario a un
    ///    proyecto, haciendo uso de un rol determinado.</para>
    /// labels<para>The Member entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Member">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Member</seealso>
    let Member = Prefixed_Name(itm, "Member") |> PrefixedName
    /// <summary>
    ///   <para>itm:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Clase que representa el rol que juega un usuario en los
    ///    proyectos.</para>
    /// labels<para>The Role entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Role">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Role</seealso>
    let Role = Prefixed_Name(itm, "Role") |> PrefixedName
    /// <summary>
    ///   <para>itm:Tracker</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Clase utilizada para identificar el listado de issues o
    ///    tareas de un determinado tipo, típicamente bugs, features, o patchs.
    ///   </para>
    /// labels<para>The Tracker entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Tracker">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Tracker</seealso>
    let Tracker = Prefixed_Name(itm, "Tracker") |> PrefixedName
    /// <summary>
    ///   <para>itm:Version</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Clase que describe cada una de las versiones del
    ///    software objeto del proyecto gestionado en la herramienta.
    ///   </para>
    /// labels<para>The Version entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Version">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#Version</seealso>
    let Version = Prefixed_Name(itm, "Version") |> PrefixedName
    /// <summary>
    ///   <para>itm:User</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Clase que representa a un usuario registrado en la
    ///    herramienta.</para>
    /// labels<para>The User entity</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#User">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#User</seealso>
    let User = Prefixed_Name(itm, "User") |> PrefixedName
    /// <summary>
    ///   <para>itm:completedDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Fecha de compleción de una tarea</para>
    /// labels<para>The completedDate attribute</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#completedDate">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#completedDate</seealso>
    let completedDate = Prefixed_Name(itm, "completedDate") |> PrefixedName
    /// <summary>
    ///   <para>itm:dependencies</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Dependencias de una tarea</para>
    /// labels<para>The dependencies reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#dependencies">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#dependencies</seealso>
    let dependencies = Prefixed_Name(itm, "dependencies") |> PrefixedName
    /// <summary>
    ///   <para>itm:dueDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Fecha estimada de finalización de una tarea</para>
    /// labels<para>The dueDate attribute</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#dueDate">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#dueDate</seealso>
    let dueDate = Prefixed_Name(itm, "dueDate") |> PrefixedName
    /// <summary>
    ///   <para>itm:elapsedHours</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Horas trabajadas en una tarea</para>
    /// labels<para>The elapsedHours attribute</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#elapsedHours">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#elapsedHours</seealso>
    let elapsedHours = Prefixed_Name(itm, "elapsedHours") |> PrefixedName
    /// <summary>
    ///   <para>itm:issueCategories</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Categorías de las tareas registradas para un proyecto determinado</para>
    /// labels<para>The issueCategories reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#issueCategories">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#issueCategories</seealso>
    let issueCategories = Prefixed_Name(itm, "issueCategories") |> PrefixedName
    /// <summary>
    ///   <para>itm:issues</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Tareas asociadas a una versión de software</para>
    /// labels<para>The issues reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#issues">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#issues</seealso>
    let issues = Prefixed_Name(itm, "issues") |> PrefixedName
    /// <summary>
    ///   <para>itm:dependentTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Tarea dependiente de una tarea dada</para>
    /// labels<para>The dependentTask reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#dependentTask">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#dependentTask</seealso>
    let dependentTask = Prefixed_Name(itm, "dependentTask") |> PrefixedName
    /// <summary>
    ///   <para>itm:doneRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Porcentaje completado de la tarea</para>
    /// labels<para>The doneRatio attribute</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#doneRatio">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#doneRatio</seealso>
    let doneRatio = Prefixed_Name(itm, "doneRatio") |> PrefixedName
    /// <summary>
    ///   <para>itm:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Descripción de un proyecto, versión o tarea</para>
    /// labels<para>The description attribute</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#description">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#description</seealso>
    let description = Prefixed_Name(itm, "description") |> PrefixedName
    /// <summary>
    ///   <para>itm:estimatedHours</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Número de horas estimadas para una tarea</para>
    /// labels<para>The estimatedHours attribute</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#estimatedHours">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#estimatedHours</seealso>
    let estimatedHours = Prefixed_Name(itm, "estimatedHours") |> PrefixedName
    /// <summary>
    ///   <para>itm:login</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Login de un usuario</para>
    /// labels<para>The login attribute</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#login">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#login</seealso>
    let login = Prefixed_Name(itm, "login") |> PrefixedName
    /// <summary>
    ///   <para>itm:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Nombre del proyecto, versión, tarea, tracker, categoría de tarea o rol</para>
    /// labels<para>The name attribute</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#name">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#name</seealso>
    let name = Prefixed_Name(itm, "name") |> PrefixedName
    /// <summary>
    ///   <para>itm:owner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Propietario de la tarea</para>
    /// labels<para>The owner reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#owner">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#owner</seealso>
    let owner = Prefixed_Name(itm, "owner") |> PrefixedName
    /// <summary>
    ///   <para>itm:language</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Lenguaje de un usuario</para>
    /// labels<para>The language attribute</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#language">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#language</seealso>
    let language = Prefixed_Name(itm, "language") |> PrefixedName
    /// <summary>
    ///   <para>itm:members</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Miembros del proyecto</para>
    /// labels<para>The members reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#members">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#members</seealso>
    let members = Prefixed_Name(itm, "members") |> PrefixedName
    /// <summary>
    ///   <para>itm:permissions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Permisos que dispone de un determinado rol</para>
    /// labels<para>The permissions attribute</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#permissions">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#permissions</seealso>
    let permissions = Prefixed_Name(itm, "permissions") |> PrefixedName
    /// <summary>
    ///   <para>itm:priority</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Prioridad en la realización de una tarea</para>
    /// labels<para>The priority attribute</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#priority">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#priority</seealso>
    let priority = Prefixed_Name(itm, "priority") |> PrefixedName
    /// <summary>
    ///   <para>itm:projects</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Conjunto de proyectos registrados en el sistema de gestión de proyectos</para>
    /// labels<para>The projects reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#projects">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#projects</seealso>
    let projects = Prefixed_Name(itm, "projects") |> PrefixedName
    /// <summary>
    ///   <para>itm:responsible</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Miembro responsable de la tarea</para>
    /// labels<para>The responsible reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#responsible">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#responsible</seealso>
    let responsible = Prefixed_Name(itm, "responsible") |> PrefixedName
    /// <summary>
    ///   <para>itm:roles</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Roles registrados en el sistema de gestión de proyectos</para>
    /// labels<para>The roles reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#roles">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#roles</seealso>
    let roles = Prefixed_Name(itm, "roles") |> PrefixedName
    /// <summary>
    ///   <para>itm:role</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Rol que desempeña un miembro del proyecto</para>
    /// labels<para>The role reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#role">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#role</seealso>
    let role = Prefixed_Name(itm, "role") |> PrefixedName
    /// <summary>
    ///   <para>itm:tracker</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Tracker al que está asociado una tarea determinada</para>
    /// labels<para>The tracker reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#tracker">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#tracker</seealso>
    let tracker = Prefixed_Name(itm, "tracker") |> PrefixedName
    /// <summary>
    ///   <para>itm:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Tipo de dependencia entre tareas</para>
    /// labels<para>The type attribute</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#type">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#type</seealso>
    let type_ = Prefixed_Name(itm, "type") |> PrefixedName
    /// <summary>
    ///   <para>itm:user</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Usuario que es miembro de un proyecto</para>
    /// labels<para>The user reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#user">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#user</seealso>
    let user = Prefixed_Name(itm, "user") |> PrefixedName
    /// <summary>
    ///   <para>itm:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Estado de una versión o tarea de un proyecto</para>
    /// labels<para>The status attribute</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#status">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#status</seealso>
    let status = Prefixed_Name(itm, "status") |> PrefixedName
    /// <summary>
    ///   <para>itm:trackers</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Conjunto de trackers registrados en el sistema de gestión de proyectos</para>
    /// labels<para>The trackers reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#trackers">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#trackers</seealso>
    let trackers = Prefixed_Name(itm, "trackers") |> PrefixedName
    /// <summary>
    ///   <para>itm:users</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Usuarios registrados en el sistema de gestión de proyectos</para>
    /// labels<para>The users reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#users">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#users</seealso>
    let users = Prefixed_Name(itm, "users") |> PrefixedName
    /// <summary>
    ///   <para>itm:versions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Versiones definidas para un proyecto software</para>
    /// labels<para>The versions reference</para></remarks>
    /// <seealso href="http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#versions">http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#versions</seealso>
    let versions = Prefixed_Name(itm, "versions") |> PrefixedName
