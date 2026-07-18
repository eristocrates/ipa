namespace http.purl.org.ctic.infraestructuras.organizacion.hash

open DoxAletheia.Rdf_Vocabulary

module ctorg =
    let _namespace_name = "http://purl.org/ctic/infraestructuras/organizacion#"

    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#CentroServicios"></see>
    /// </summary>
    let CentroServicios =
        Namespaced_IRI.parse _namespace_name "CentroServicios" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#Edificio"></see>
    /// </summary>
    let Edificio = Namespaced_IRI.parse _namespace_name "Edificio" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#EdificioMunicipal"></see>
    /// </summary>
    let EdificioMunicipal =
        Namespaced_IRI.parse _namespace_name "EdificioMunicipal" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#OrganoPublico"></see>
    /// </summary>
    let OrganoPublico =
        Namespaced_IRI.parse _namespace_name "OrganoPublico" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#accesibilidad"></see>
    /// </summary>
    let accesibilidad =
        Namespaced_IRI.parse _namespace_name "accesibilidad" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#areaOrganizativa"></see>
    /// </summary>
    let areaOrganizativa =
        Namespaced_IRI.parse _namespace_name "areaOrganizativa" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#bus"></see>
    /// </summary>
    let bus = Namespaced_IRI.parse _namespace_name "bus" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#centroServicios"></see>
    /// </summary>
    let centroServicios =
        Namespaced_IRI.parse _namespace_name "centroServicios" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#clasificacionServicios"></see>
    /// </summary>
    let clasificacionServicios =
        Namespaced_IRI.parse _namespace_name "clasificacionServicios" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#depende"></see>
    /// </summary>
    let depende = Namespaced_IRI.parse _namespace_name "depende" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#dependeDe"></see>
    /// </summary>
    let dependeDe = Namespaced_IRI.parse _namespace_name "dependeDe" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#direccion"></see>
    /// </summary>
    let direccion = Namespaced_IRI.parse _namespace_name "direccion" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#edificio"></see>
    /// </summary>
    let edificio = Namespaced_IRI.parse _namespace_name "edificio" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#horario"></see>
    /// </summary>
    let horario = Namespaced_IRI.parse _namespace_name "horario" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#numeroPortal"></see>
    /// </summary>
    let numeroPortal =
        Namespaced_IRI.parse _namespace_name "numeroPortal" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#organoPublico"></see>
    /// </summary>
    let organoPublico =
        Namespaced_IRI.parse _namespace_name "organoPublico" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#plantaEdificio"></see>
    /// </summary>
    let plantaEdificio =
        Namespaced_IRI.parse _namespace_name "plantaEdificio" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#servicios"></see>
    /// </summary>
    let servicios = Namespaced_IRI.parse _namespace_name "servicios" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/infraestructuras/organizacion#tipoCentro"></see>
    /// </summary>
    let tipoCentro = Namespaced_IRI.parse _namespace_name "tipoCentro" |> NamespacedName
