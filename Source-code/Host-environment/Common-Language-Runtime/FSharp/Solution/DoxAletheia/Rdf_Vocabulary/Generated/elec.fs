namespace http.purl.org.ctic.sector_publico.elecciones.hash

open DoxAletheia

module elec =
    let _namespace_name = "http://purl.org/ctic/sector-publico/elecciones#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#AreaElectoral"></see>
    /// </summary>
    let AreaElectoral = _prefix "AreaElectoral"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#Candidato"></see>
    /// </summary>
    let Candidato = _prefix "Candidato"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#Candidatura"></see>
    /// </summary>
    let Candidatura = _prefix "Candidatura"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#Partido"></see>
    /// </summary>
    let Partido = _prefix "Partido"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#ProcesoElectoral"></see>
    /// </summary>
    let ProcesoElectoral = _prefix "ProcesoElectoral"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#Votacion"></see>
    /// </summary>
    let Votacion = _prefix "Votacion"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#censoElectoral"></see>
    /// </summary>
    let censoElectoral = _prefix "censoElectoral"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#esCandidaturaDe"></see>
    /// </summary>
    let esCandidaturaDe = _prefix "esCandidaturaDe"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#tieneCandidatura"></see>
    /// </summary>
    let tieneCandidatura = _prefix "tieneCandidatura"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#esCandidaturaDelPartido"></see>
    /// </summary>
    let esCandidaturaDelPartido = _prefix "esCandidaturaDelPartido"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#partidoTieneCandidatura"></see>
    /// </summary>
    let partidoTieneCandidatura = _prefix "partidoTieneCandidatura"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#esSeleccionada"></see>
    /// </summary>
    let esSeleccionada = _prefix "esSeleccionada"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#esVotacionDe"></see>
    /// </summary>
    let esVotacionDe = _prefix "esVotacionDe"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#tieneVotacion"></see>
    /// </summary>
    let tieneVotacion = _prefix "tieneVotacion"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#participacion"></see>
    /// </summary>
    let participacion = _prefix "participacion"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#representantesObtenidos"></see>
    /// </summary>
    let representantesObtenidos = _prefix "representantesObtenidos"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#tieneAreaElectoral"></see>
    /// </summary>
    let tieneAreaElectoral = _prefix "tieneAreaElectoral"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#tieneCandidato"></see>
    /// </summary>
    let tieneCandidato = _prefix "tieneCandidato"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#votosEmitidos"></see>
    /// </summary>
    let votosEmitidos = _prefix "votosEmitidos"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#votosEnBlanco"></see>
    /// </summary>
    let votosEnBlanco = _prefix "votosEnBlanco"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#votosEnBlancoPorcentaje"></see>
    /// </summary>
    let votosEnBlancoPorcentaje = _prefix "votosEnBlancoPorcentaje"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#votosNulos"></see>
    /// </summary>
    let votosNulos = _prefix "votosNulos"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#votosNulosPorcentaje"></see>
    /// </summary>
    let votosNulosPorcentaje = _prefix "votosNulosPorcentaje"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#votosPorcentajeSobreElectores"></see>
    /// </summary>
    let votosPorcentajeSobreElectores = _prefix "votosPorcentajeSobreElectores"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#votosRecibidos"></see>
    /// </summary>
    let votosRecibidos = _prefix "votosRecibidos"
    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#votosValidos"></see>
    /// </summary>
    let votosValidos = _prefix "votosValidos"
