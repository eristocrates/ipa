namespace http.purl.org.ctic.infraestructuras.organizacion.hash

open DoxAletheia

module ctorg =
    let _namespace_name = "http://purl.org/ctic/infraestructuras/organizacion#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#CentroServicios"></see>
    /// </summary>
    let CentroServicios = _prefix "CentroServicios"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#Edificio"></see>
    /// </summary>
    let Edificio = _prefix "Edificio"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#EdificioMunicipal"></see>
    /// </summary>
    let EdificioMunicipal = _prefix "EdificioMunicipal"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#OrganoPublico"></see>
    /// </summary>
    let OrganoPublico = _prefix "OrganoPublico"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#accesibilidad"></see>
    /// </summary>
    let accesibilidad = _prefix "accesibilidad"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#areaOrganizativa"></see>
    /// </summary>
    let areaOrganizativa = _prefix "areaOrganizativa"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#bus"></see>
    /// </summary>
    let bus = _prefix "bus"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#centroServicios"></see>
    /// </summary>
    let centroServicios = _prefix "centroServicios"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#clasificacionServicios"></see>
    /// </summary>
    let clasificacionServicios = _prefix "clasificacionServicios"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#depende"></see>
    /// </summary>
    let depende = _prefix "depende"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#dependeDe"></see>
    /// </summary>
    let dependeDe = _prefix "dependeDe"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#direccion"></see>
    /// </summary>
    let direccion = _prefix "direccion"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#edificio"></see>
    /// </summary>
    let edificio = _prefix "edificio"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#horario"></see>
    /// </summary>
    let horario = _prefix "horario"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#numeroPortal"></see>
    /// </summary>
    let numeroPortal = _prefix "numeroPortal"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#organoPublico"></see>
    /// </summary>
    let organoPublico = _prefix "organoPublico"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#plantaEdificio"></see>
    /// </summary>
    let plantaEdificio = _prefix "plantaEdificio"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#servicios"></see>
    /// </summary>
    let servicios = _prefix "servicios"
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#tipoCentro"></see>
    /// </summary>
    let tipoCentro = _prefix "tipoCentro"
