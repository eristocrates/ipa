namespace http.datos.gob.es.def.sector_publico.organizacion.hash

open DoxAletheia

module orges =
    let _namespace_name = "http://datos.gob.es/def/sector-publico/organizacion#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#1.0.0"></see>
    /// </summary>
    let ``_1.0.0`` = _prefix "1.0.0"
    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#EntidadDerechoPublico"></see>
    /// </summary>
    let EntidadDerechoPublico = _prefix "EntidadDerechoPublico"
    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#UnidadOrganicaNoRaiz"></see>
    /// </summary>
    let UnidadOrganicaNoRaiz = _prefix "UnidadOrganicaNoRaiz"
    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#Oficina"></see>
    /// </summary>
    let Oficina = _prefix "Oficina"
    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#UGEP"></see>
    /// </summary>
    let UGEP = _prefix "UGEP"
    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#ambitoCompetencias"></see>
    /// </summary>
    let ambitoCompetencias = _prefix "ambitoCompetencias"
    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#diasInhabiles"></see>
    /// </summary>
    let diasInhabiles = _prefix "diasInhabiles"
    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#disposicionLegal"></see>
    /// </summary>
    let disposicionLegal = _prefix "disposicionLegal"
    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#estado"></see>
    /// </summary>
    let estado = _prefix "estado"
    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#horarioAtencion"></see>
    /// </summary>
    let horarioAtencion = _prefix "horarioAtencion"
    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#identificadorExterno"></see>
    /// </summary>
    let identificadorExterno = _prefix "identificadorExterno"
    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#nivelAdministracion"></see>
    /// </summary>
    let nivelAdministracion = _prefix "nivelAdministracion"
    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#nivelJerarquico"></see>
    /// </summary>
    let nivelJerarquico = _prefix "nivelJerarquico"
    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#observacionBaja"></see>
    /// </summary>
    let observacionBaja = _prefix "observacionBaja"
    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#otroContacto"></see>
    /// </summary>
    let otroContacto = _prefix "otroContacto"
    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#servicio"></see>
    /// </summary>
    let servicio = _prefix "servicio"
    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#tieneUORaiz"></see>
    /// </summary>
    let tieneUORaiz = _prefix "tieneUORaiz"
