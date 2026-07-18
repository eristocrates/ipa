namespace http.datos.gob.es.def.sector_publico.organizacion.hash

open DoxAletheia.Rdf_Vocabulary

module orges =
    let _namespace_name = "http://datos.gob.es/def/sector-publico/organizacion#"
    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#1.0.0"></see>
    /// </summary>
    let ``_1.0.0`` = Namespaced_IRI.parse _namespace_name "1.0.0" |> NamespacedName

    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#EntidadDerechoPublico"></see>
    /// </summary>
    let EntidadDerechoPublico =
        Namespaced_IRI.parse _namespace_name "EntidadDerechoPublico" |> NamespacedName

    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#UnidadOrganicaNoRaiz"></see>
    /// </summary>
    let UnidadOrganicaNoRaiz =
        Namespaced_IRI.parse _namespace_name "UnidadOrganicaNoRaiz" |> NamespacedName

    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#Oficina"></see>
    /// </summary>
    let Oficina = Namespaced_IRI.parse _namespace_name "Oficina" |> NamespacedName
    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#UGEP"></see>
    /// </summary>
    let UGEP = Namespaced_IRI.parse _namespace_name "UGEP" |> NamespacedName

    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#ambitoCompetencias"></see>
    /// </summary>
    let ambitoCompetencias =
        Namespaced_IRI.parse _namespace_name "ambitoCompetencias" |> NamespacedName

    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#diasInhabiles"></see>
    /// </summary>
    let diasInhabiles =
        Namespaced_IRI.parse _namespace_name "diasInhabiles" |> NamespacedName

    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#disposicionLegal"></see>
    /// </summary>
    let disposicionLegal =
        Namespaced_IRI.parse _namespace_name "disposicionLegal" |> NamespacedName

    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#estado"></see>
    /// </summary>
    let estado = Namespaced_IRI.parse _namespace_name "estado" |> NamespacedName

    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#horarioAtencion"></see>
    /// </summary>
    let horarioAtencion =
        Namespaced_IRI.parse _namespace_name "horarioAtencion" |> NamespacedName

    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#identificadorExterno"></see>
    /// </summary>
    let identificadorExterno =
        Namespaced_IRI.parse _namespace_name "identificadorExterno" |> NamespacedName

    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#nivelAdministracion"></see>
    /// </summary>
    let nivelAdministracion =
        Namespaced_IRI.parse _namespace_name "nivelAdministracion" |> NamespacedName

    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#nivelJerarquico"></see>
    /// </summary>
    let nivelJerarquico =
        Namespaced_IRI.parse _namespace_name "nivelJerarquico" |> NamespacedName

    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#observacionBaja"></see>
    /// </summary>
    let observacionBaja =
        Namespaced_IRI.parse _namespace_name "observacionBaja" |> NamespacedName

    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#otroContacto"></see>
    /// </summary>
    let otroContacto =
        Namespaced_IRI.parse _namespace_name "otroContacto" |> NamespacedName

    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#servicio"></see>
    /// </summary>
    let servicio = Namespaced_IRI.parse _namespace_name "servicio" |> NamespacedName

    /// <summary>
    ///   <see href="http://datos.gob.es/def/sector-publico/organizacion#tieneUORaiz"></see>
    /// </summary>
    let tieneUORaiz =
        Namespaced_IRI.parse _namespace_name "tieneUORaiz" |> NamespacedName
