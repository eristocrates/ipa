namespace http.purl.org.ctic.infraestructuras.localizacion.hash

open DoxAletheia.Rdf_Vocabulary

module loc =
    let _namespace_name = "http://purl.org/ctic/infraestructuras/localizacion#"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#Autonomia"></see>
    /// </summary>
    let Autonomia = Namespaced_IRI.parse _namespace_name "Autonomia" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#Barrio"></see>
    /// </summary>
    let Barrio = Namespaced_IRI.parse _namespace_name "Barrio" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#Calle"></see>
    /// </summary>
    let Calle = Namespaced_IRI.parse _namespace_name "Calle" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#Direccion"></see>
    /// </summary>
    let Direccion = Namespaced_IRI.parse _namespace_name "Direccion" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#Distrito"></see>
    /// </summary>
    let Distrito = Namespaced_IRI.parse _namespace_name "Distrito" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#JuntaAdministrativa"></see>
    /// </summary>
    let JuntaAdministrativa =
        Namespaced_IRI.parse _namespace_name "JuntaAdministrativa" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#Municipio"></see>
    /// </summary>
    let Municipio = Namespaced_IRI.parse _namespace_name "Municipio" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#Pais"></see>
    /// </summary>
    let Pais = Namespaced_IRI.parse _namespace_name "Pais" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#Provincia"></see>
    /// </summary>
    let Provincia = Namespaced_IRI.parse _namespace_name "Provincia" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#TramoCalle"></see>
    /// </summary>
    let TramoCalle = Namespaced_IRI.parse _namespace_name "TramoCalle" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#barrio"></see>
    /// </summary>
    let barrio = Namespaced_IRI.parse _namespace_name "barrio" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#calle"></see>
    /// </summary>
    let calle = Namespaced_IRI.parse _namespace_name "calle" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#iae"></see>
    /// </summary>
    let iae = Namespaced_IRI.parse _namespace_name "iae" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#juntaAdministrativa"></see>
    /// </summary>
    let juntaAdministrativa =
        Namespaced_IRI.parse _namespace_name "juntaAdministrativa" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#numeroFinTramo"></see>
    /// </summary>
    let numeroFinTramo =
        Namespaced_IRI.parse _namespace_name "numeroFinTramo" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#numeroInicioTramo"></see>
    /// </summary>
    let numeroInicioTramo =
        Namespaced_IRI.parse _namespace_name "numeroInicioTramo" |> NamespacedName
