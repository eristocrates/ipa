namespace http.purl.org.ctic.infraestructuras.localizacion.hash

open DoxAletheia

module loc =
    let _namespace_name = "http://purl.org/ctic/infraestructuras/localizacion#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#Autonomia"></see>
    /// </summary>
    let Autonomia = _prefix "Autonomia"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#Barrio"></see>
    /// </summary>
    let Barrio = _prefix "Barrio"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#Calle"></see>
    /// </summary>
    let Calle = _prefix "Calle"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#Direccion"></see>
    /// </summary>
    let Direccion = _prefix "Direccion"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#Distrito"></see>
    /// </summary>
    let Distrito = _prefix "Distrito"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#JuntaAdministrativa"></see>
    /// </summary>
    let JuntaAdministrativa = _prefix "JuntaAdministrativa"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#Municipio"></see>
    /// </summary>
    let Municipio = _prefix "Municipio"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#Pais"></see>
    /// </summary>
    let Pais = _prefix "Pais"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#Provincia"></see>
    /// </summary>
    let Provincia = _prefix "Provincia"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#TramoCalle"></see>
    /// </summary>
    let TramoCalle = _prefix "TramoCalle"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#barrio"></see>
    /// </summary>
    let barrio = _prefix "barrio"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#calle"></see>
    /// </summary>
    let calle = _prefix "calle"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#iae"></see>
    /// </summary>
    let iae = _prefix "iae"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#juntaAdministrativa"></see>
    /// </summary>
    let juntaAdministrativa = _prefix "juntaAdministrativa"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#numeroFinTramo"></see>
    /// </summary>
    let numeroFinTramo = _prefix "numeroFinTramo"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/localizacion#numeroInicioTramo"></see>
    /// </summary>
    let numeroInicioTramo = _prefix "numeroInicioTramo"
