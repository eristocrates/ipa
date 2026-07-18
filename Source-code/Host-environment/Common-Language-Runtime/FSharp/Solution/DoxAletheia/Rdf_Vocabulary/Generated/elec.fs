namespace http.purl.org.ctic.sector_publico.elecciones.hash

open DoxAletheia.Rdf_Vocabulary

module elec =
    let _namespace_name = "http://purl.org/ctic/sector-publico/elecciones#"

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#AreaElectoral"></see>
    /// </summary>
    let AreaElectoral =
        Namespaced_IRI.parse _namespace_name "AreaElectoral" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#Candidato"></see>
    /// </summary>
    let Candidato = Namespaced_IRI.parse _namespace_name "Candidato" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#Candidatura"></see>
    /// </summary>
    let Candidatura =
        Namespaced_IRI.parse _namespace_name "Candidatura" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#Partido"></see>
    /// </summary>
    let Partido = Namespaced_IRI.parse _namespace_name "Partido" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#ProcesoElectoral"></see>
    /// </summary>
    let ProcesoElectoral =
        Namespaced_IRI.parse _namespace_name "ProcesoElectoral" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#Votacion"></see>
    /// </summary>
    let Votacion = Namespaced_IRI.parse _namespace_name "Votacion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#censoElectoral"></see>
    /// </summary>
    let censoElectoral =
        Namespaced_IRI.parse _namespace_name "censoElectoral" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#esCandidaturaDe"></see>
    /// </summary>
    let esCandidaturaDe =
        Namespaced_IRI.parse _namespace_name "esCandidaturaDe" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#tieneCandidatura"></see>
    /// </summary>
    let tieneCandidatura =
        Namespaced_IRI.parse _namespace_name "tieneCandidatura" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#esCandidaturaDelPartido"></see>
    /// </summary>
    let esCandidaturaDelPartido =
        Namespaced_IRI.parse _namespace_name "esCandidaturaDelPartido" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#partidoTieneCandidatura"></see>
    /// </summary>
    let partidoTieneCandidatura =
        Namespaced_IRI.parse _namespace_name "partidoTieneCandidatura" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#esSeleccionada"></see>
    /// </summary>
    let esSeleccionada =
        Namespaced_IRI.parse _namespace_name "esSeleccionada" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#esVotacionDe"></see>
    /// </summary>
    let esVotacionDe =
        Namespaced_IRI.parse _namespace_name "esVotacionDe" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#tieneVotacion"></see>
    /// </summary>
    let tieneVotacion =
        Namespaced_IRI.parse _namespace_name "tieneVotacion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#participacion"></see>
    /// </summary>
    let participacion =
        Namespaced_IRI.parse _namespace_name "participacion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#representantesObtenidos"></see>
    /// </summary>
    let representantesObtenidos =
        Namespaced_IRI.parse _namespace_name "representantesObtenidos" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#tieneAreaElectoral"></see>
    /// </summary>
    let tieneAreaElectoral =
        Namespaced_IRI.parse _namespace_name "tieneAreaElectoral" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#tieneCandidato"></see>
    /// </summary>
    let tieneCandidato =
        Namespaced_IRI.parse _namespace_name "tieneCandidato" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#votosEmitidos"></see>
    /// </summary>
    let votosEmitidos =
        Namespaced_IRI.parse _namespace_name "votosEmitidos" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#votosEnBlanco"></see>
    /// </summary>
    let votosEnBlanco =
        Namespaced_IRI.parse _namespace_name "votosEnBlanco" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#votosEnBlancoPorcentaje"></see>
    /// </summary>
    let votosEnBlancoPorcentaje =
        Namespaced_IRI.parse _namespace_name "votosEnBlancoPorcentaje" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#votosNulos"></see>
    /// </summary>
    let votosNulos = Namespaced_IRI.parse _namespace_name "votosNulos" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#votosNulosPorcentaje"></see>
    /// </summary>
    let votosNulosPorcentaje =
        Namespaced_IRI.parse _namespace_name "votosNulosPorcentaje" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#votosPorcentajeSobreElectores"></see>
    /// </summary>
    let votosPorcentajeSobreElectores =
        Namespaced_IRI.parse _namespace_name "votosPorcentajeSobreElectores" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#votosRecibidos"></see>
    /// </summary>
    let votosRecibidos =
        Namespaced_IRI.parse _namespace_name "votosRecibidos" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/sector-publico/elecciones#votosValidos"></see>
    /// </summary>
    let votosValidos =
        Namespaced_IRI.parse _namespace_name "votosValidos" |> NamespacedName
