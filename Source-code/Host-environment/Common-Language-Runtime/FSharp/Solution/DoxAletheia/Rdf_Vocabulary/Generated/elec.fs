namespace http.purl.org.ctic.sector_publico.elecciones.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module elec =
    let _namespace_iri = Namespace_Iri elec |> NamespaceIRI
    /// <summary>
    ///   <para>elec:votosRecibidos</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Número de votos recibidos por una candidatura en una votación</para>
    /// labels<para>Votos recibidos</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#votosRecibidos">http://purl.org/ctic/sector-publico/elecciones#votosRecibidos</seealso>
    let votosRecibidos = Prefixed_Name(elec, "votosRecibidos") |> PrefixedName
    /// <summary>
    ///   <para>elec:AreaElectoral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Una región o área geográfica donde se lleva a cabo una votación</para>
    /// labels<para>Área electoral</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#AreaElectoral">http://purl.org/ctic/sector-publico/elecciones#AreaElectoral</seealso>
    let AreaElectoral = Prefixed_Name(elec, "AreaElectoral") |> PrefixedName
    /// <summary>
    ///   <para>elec:Candidato</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Candidato de una formación política que se presenta a una votación</para>
    /// labels<para>Candidato</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#Candidato">http://purl.org/ctic/sector-publico/elecciones#Candidato</seealso>
    let Candidato = Prefixed_Name(elec, "Candidato") |> PrefixedName
    /// <summary>
    ///   <para>elec:Candidatura</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Una candidatura para una votación correspondiente a un partido político</para>
    /// labels<para>Candidatura</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#Candidatura">http://purl.org/ctic/sector-publico/elecciones#Candidatura</seealso>
    let Candidatura = Prefixed_Name(elec, "Candidatura") |> PrefixedName
    /// <summary>
    ///   <para>elec:Partido</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Una formación política que se presenta a una votación</para>
    /// labels<para>Partido político</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#Partido">http://purl.org/ctic/sector-publico/elecciones#Partido</seealso>
    let Partido = Prefixed_Name(elec, "Partido") |> PrefixedName
    /// <summary>
    ///   <para>elec:Votacion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Una votación específica, dentro de un proceso electoral, para seleccionar una representación o dirimir un referendum</para>
    /// labels<para>Votación</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#Votacion">http://purl.org/ctic/sector-publico/elecciones#Votacion</seealso>
    let Votacion = Prefixed_Name(elec, "Votacion") |> PrefixedName
    /// <summary>
    ///   <para>elec:censoElectoral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Número de personas con derecho a voto en una votación</para>
    /// labels<para>Censo electoral</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#censoElectoral">http://purl.org/ctic/sector-publico/elecciones#censoElectoral</seealso>
    let censoElectoral = Prefixed_Name(elec, "censoElectoral") |> PrefixedName
    /// <summary>
    ///   <para>elec:ProcesoElectoral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Un proceso electoral diferenciado en un periodo de tiempo que incluye una o varias votaciones</para>
    /// labels<para>Proceso electoral</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#ProcesoElectoral">http://purl.org/ctic/sector-publico/elecciones#ProcesoElectoral</seealso>
    let ProcesoElectoral = Prefixed_Name(elec, "ProcesoElectoral") |> PrefixedName

    /// <summary>
    ///   <para>elec:esCandidaturaDelPartido</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Una candidatura especifica es de un partido político</para>
    /// labels<para>Es candidatura del partido</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#esCandidaturaDelPartido">http://purl.org/ctic/sector-publico/elecciones#esCandidaturaDelPartido</seealso>
    let esCandidaturaDelPartido =
        Prefixed_Name(elec, "esCandidaturaDelPartido") |> PrefixedName

    /// <summary>
    ///   <para>elec:esCandidaturaDe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Una candidatura pertenece a una votación específica</para>
    /// labels<para>Es candidatura de</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#esCandidaturaDe">http://purl.org/ctic/sector-publico/elecciones#esCandidaturaDe</seealso>
    let esCandidaturaDe = Prefixed_Name(elec, "esCandidaturaDe") |> PrefixedName

    /// <summary>
    ///   <para>elec:partidoTieneCandidatura</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Un partido político puede tener varias candidaturas</para>
    /// labels<para>Partido tiene candidatura</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#partidoTieneCandidatura">http://purl.org/ctic/sector-publico/elecciones#partidoTieneCandidatura</seealso>
    let partidoTieneCandidatura =
        Prefixed_Name(elec, "partidoTieneCandidatura") |> PrefixedName

    /// <summary>
    ///   <para>elec:esVotacionDe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Una votación pertenece a un proceso electoral</para>
    /// labels<para>Es votación de</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#esVotacionDe">http://purl.org/ctic/sector-publico/elecciones#esVotacionDe</seealso>
    let esVotacionDe = Prefixed_Name(elec, "esVotacionDe") |> PrefixedName
    /// <summary>
    ///   <para>elec:participacion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Porcentaje de participación (votos emitidos en relación al número de electores) en una votación</para>
    /// labels<para>Porcentaje de participación</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#participacion">http://purl.org/ctic/sector-publico/elecciones#participacion</seealso>
    let participacion = Prefixed_Name(elec, "participacion") |> PrefixedName

    /// <summary>
    ///   <para>elec:representantesObtenidos</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Número de representantes obtenidos (diputados, escaños,...) que consigue una candidatura seleccionada</para>
    /// labels<para>Representantes obtenidos</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#representantesObtenidos">http://purl.org/ctic/sector-publico/elecciones#representantesObtenidos</seealso>
    let representantesObtenidos =
        Prefixed_Name(elec, "representantesObtenidos") |> PrefixedName

    /// <summary>
    ///   <para>elec:tieneCandidato</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Una candidatura especifica es de un partido político</para>
    /// labels<para>Tiene candidato</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#tieneCandidato">http://purl.org/ctic/sector-publico/elecciones#tieneCandidato</seealso>
    let tieneCandidato = Prefixed_Name(elec, "tieneCandidato") |> PrefixedName
    /// <summary>
    ///   <para>elec:tieneCandidatura</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Una votación puede tener muchas candidaturas</para>
    /// labels<para>Tiene candidatura</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#tieneCandidatura">http://purl.org/ctic/sector-publico/elecciones#tieneCandidatura</seealso>
    let tieneCandidatura = Prefixed_Name(elec, "tieneCandidatura") |> PrefixedName
    /// <summary>
    ///   <para>elec:esSeleccionada</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Si la candidatura ha sido seleccionada como resultado de la votación</para>
    /// labels<para>Es seleccionada</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#esSeleccionada">http://purl.org/ctic/sector-publico/elecciones#esSeleccionada</seealso>
    let esSeleccionada = Prefixed_Name(elec, "esSeleccionada") |> PrefixedName
    /// <summary>
    ///   <para>elec:tieneVotacion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Un proceso electoral tiene una votación</para>
    /// labels<para>Tiene votación</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#tieneVotacion">http://purl.org/ctic/sector-publico/elecciones#tieneVotacion</seealso>
    let tieneVotacion = Prefixed_Name(elec, "tieneVotacion") |> PrefixedName
    /// <summary>
    ///   <para>elec:tieneAreaElectoral</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Una votación se realiza sobre un área electoral</para>
    /// labels<para>Tiene área electoral</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#tieneAreaElectoral">http://purl.org/ctic/sector-publico/elecciones#tieneAreaElectoral</seealso>
    let tieneAreaElectoral = Prefixed_Name(elec, "tieneAreaElectoral") |> PrefixedName
    /// <summary>
    ///   <para>elec:votosEmitidos</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Número de votos emitidos en una votación</para>
    /// labels<para>Votos emitidos</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#votosEmitidos">http://purl.org/ctic/sector-publico/elecciones#votosEmitidos</seealso>
    let votosEmitidos = Prefixed_Name(elec, "votosEmitidos") |> PrefixedName
    /// <summary>
    ///   <para>elec:votosEnBlanco</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Número de votos en blanco en una votación</para>
    /// labels<para>Votos en blanco</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#votosEnBlanco">http://purl.org/ctic/sector-publico/elecciones#votosEnBlanco</seealso>
    let votosEnBlanco = Prefixed_Name(elec, "votosEnBlanco") |> PrefixedName
    /// <summary>
    ///   <para>elec:votosNulos</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Número de votos nulos en una votación</para>
    /// labels<para>Votos nulos</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#votosNulos">http://purl.org/ctic/sector-publico/elecciones#votosNulos</seealso>
    let votosNulos = Prefixed_Name(elec, "votosNulos") |> PrefixedName

    /// <summary>
    ///   <para>elec:votosEnBlancoPorcentaje</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Porcentaje de votos en blanco respecto a los votos emitidos en una votación</para>
    /// labels<para>Porcentaje de votos en blanco</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#votosEnBlancoPorcentaje">http://purl.org/ctic/sector-publico/elecciones#votosEnBlancoPorcentaje</seealso>
    let votosEnBlancoPorcentaje =
        Prefixed_Name(elec, "votosEnBlancoPorcentaje") |> PrefixedName

    /// <summary>
    ///   <para>elec:votosNulosPorcentaje</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Porcentaje de votos nulos respecto a los votos emitidos en una votación</para>
    /// labels<para>Porcentaje de votos nulos</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#votosNulosPorcentaje">http://purl.org/ctic/sector-publico/elecciones#votosNulosPorcentaje</seealso>
    let votosNulosPorcentaje =
        Prefixed_Name(elec, "votosNulosPorcentaje") |> PrefixedName

    /// <summary>
    ///   <para>elec:votosPorcentajeSobreElectores</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Porcentaje de votos recibidos por una candidatura en una votación sobre el total de votantes</para>
    ///   <para>Porcentaje de votos recibidos por una candidatura en una votación sobre el total de electores</para>
    /// labels<para>Porcentaje de votos recibidos sobre el total de electores</para><para>Porcentaje de votos recibidos sobre el total de votantes</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#votosPorcentajeSobreElectores">http://purl.org/ctic/sector-publico/elecciones#votosPorcentajeSobreElectores</seealso>
    let votosPorcentajeSobreElectores =
        Prefixed_Name(elec, "votosPorcentajeSobreElectores") |> PrefixedName

    /// <summary>
    ///   <para>elec:votosValidos</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Número de votos válidos en una votación</para>
    /// labels<para>Votos válidos</para></remarks>
    /// <seealso href="http://purl.org/ctic/sector-publico/elecciones#votosValidos">http://purl.org/ctic/sector-publico/elecciones#votosValidos</seealso>
    let votosValidos = Prefixed_Name(elec, "votosValidos") |> PrefixedName
