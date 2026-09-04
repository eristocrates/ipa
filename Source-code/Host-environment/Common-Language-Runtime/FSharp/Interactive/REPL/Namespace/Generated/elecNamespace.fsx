#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module elec =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/ctic/sector-publico/elecciones#" "elec"

    /// <summary>
    ///   <para>dcterms:issued : 2012-09-14^^xsd:string</para>
    ///   <para>rdfs:comment : Una región o área geográfica donde se lleva a cabo una votación</para>
    ///   <para>rdfs:label : Área electoral</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#AreaElectoral">elec:AreaElectoral</a>
    /// </summary>
    let AreaElectoral = _prefixId.prefix "AreaElectoral"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-14^^xsd:string</para>
    ///   <para>rdfs:comment : Candidato de una formación política que se presenta a una votación</para>
    ///   <para>rdfs:label : Candidato</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#Candidato">elec:Candidato</a>
    /// </summary>
    let Candidato = _prefixId.prefix "Candidato"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-14^^xsd:string</para>
    ///   <para>rdfs:comment : Una candidatura para una votación correspondiente a un partido político</para>
    ///   <para>rdfs:label : Candidatura</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#Candidatura">elec:Candidatura</a>
    /// </summary>
    let Candidatura = _prefixId.prefix "Candidatura"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-14^^xsd:string</para>
    ///   <para>rdfs:comment : Una formación política que se presenta a una votación</para>
    ///   <para>rdfs:label : Partido político</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#Partido">elec:Partido</a>
    /// </summary>
    let Partido = _prefixId.prefix "Partido"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-14^^xsd:string</para>
    ///   <para>rdfs:comment : Un proceso electoral diferenciado en un periodo de tiempo que incluye una o varias votaciones</para>
    ///   <para>rdfs:label : Proceso electoral</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#ProcesoElectoral">elec:ProcesoElectoral</a>
    /// </summary>
    let ProcesoElectoral = _prefixId.prefix "ProcesoElectoral"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-14^^xsd:string</para>
    ///   <para>rdfs:comment : Una votación específica, dentro de un proceso electoral, para seleccionar una representación o dirimir un referendum</para>
    ///   <para>rdfs:label : Votación</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#Votacion">elec:Votacion</a>
    /// </summary>
    let Votacion = _prefixId.prefix "Votacion"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-14^^xsd:string</para>
    ///   <para>rdfs:comment : Número de personas con derecho a voto en una votación</para>
    ///   <para>rdfs:label : Censo electoral</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#censoElectoral">elec:censoElectoral</a>
    /// </summary>
    let censoElectoral = _prefixId.prefix "censoElectoral"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-14^^xsd:string</para>
    ///   <para>rdfs:comment : Una candidatura pertenece a una votación específica</para>
    ///   <para>rdfs:label : Es candidatura de</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#esCandidaturaDe">elec:esCandidaturaDe</a>
    /// </summary>
    let esCandidaturaDe = _prefixId.prefix "esCandidaturaDe"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-14^^xsd:string</para>
    ///   <para>rdfs:comment : Una candidatura especifica es de un partido político</para>
    ///   <para>rdfs:label : Es candidatura del partido</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#esCandidaturaDelPartido">elec:esCandidaturaDelPartido</a>
    /// </summary>
    let esCandidaturaDelPartido = _prefixId.prefix "esCandidaturaDelPartido"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-14^^xsd:string</para>
    ///   <para>rdfs:comment : Si la candidatura ha sido seleccionada como resultado de la votación</para>
    ///   <para>rdfs:label : Es seleccionada</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#esSeleccionada">elec:esSeleccionada</a>
    /// </summary>
    let esSeleccionada = _prefixId.prefix "esSeleccionada"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-14^^xsd:string</para>
    ///   <para>rdfs:comment : Una votación pertenece a un proceso electoral</para>
    ///   <para>rdfs:label : Es votación de</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#esVotacionDe">elec:esVotacionDe</a>
    /// </summary>
    let esVotacionDe = _prefixId.prefix "esVotacionDe"
    /// <summary>
    ///   <para>dcterms:issued : 2013-01-17^^xsd:string</para>
    ///   <para>rdfs:comment : Porcentaje de participación (votos emitidos en relación al número de electores) en una votación</para>
    ///   <para>rdfs:label : Porcentaje de participación</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#participacion">elec:participacion</a>
    /// </summary>
    let participacion = _prefixId.prefix "participacion"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-14^^xsd:string</para>
    ///   <para>rdfs:comment : Un partido político puede tener varias candidaturas</para>
    ///   <para>rdfs:label : Partido tiene candidatura</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#partidoTieneCandidatura">elec:partidoTieneCandidatura</a>
    /// </summary>
    let partidoTieneCandidatura = _prefixId.prefix "partidoTieneCandidatura"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-14^^xsd:string</para>
    ///   <para>rdfs:comment : Número de representantes obtenidos (diputados, escaños,...) que consigue una candidatura seleccionada</para>
    ///   <para>rdfs:label : Representantes obtenidos</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#representantesObtenidos">elec:representantesObtenidos</a>
    /// </summary>
    let representantesObtenidos = _prefixId.prefix "representantesObtenidos"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-14^^xsd:string</para>
    ///   <para>rdfs:comment : Una votación se realiza sobre un área electoral</para>
    ///   <para>rdfs:label : Tiene área electoral</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#tieneAreaElectoral">elec:tieneAreaElectoral</a>
    /// </summary>
    let tieneAreaElectoral = _prefixId.prefix "tieneAreaElectoral"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-14^^xsd:string</para>
    ///   <para>rdfs:comment : Una candidatura especifica es de un partido político</para>
    ///   <para>rdfs:label : Tiene candidato</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#tieneCandidato">elec:tieneCandidato</a>
    /// </summary>
    let tieneCandidato = _prefixId.prefix "tieneCandidato"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-14^^xsd:string</para>
    ///   <para>rdfs:comment : Una votación puede tener muchas candidaturas</para>
    ///   <para>rdfs:label : Tiene candidatura</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#tieneCandidatura">elec:tieneCandidatura</a>
    /// </summary>
    let tieneCandidatura = _prefixId.prefix "tieneCandidatura"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-14^^xsd:string</para>
    ///   <para>rdfs:comment : Un proceso electoral tiene una votación</para>
    ///   <para>rdfs:label : Tiene votación</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#tieneVotacion">elec:tieneVotacion</a>
    /// </summary>
    let tieneVotacion = _prefixId.prefix "tieneVotacion"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-14^^xsd:string</para>
    ///   <para>rdfs:comment : Número de votos emitidos en una votación</para>
    ///   <para>rdfs:label : Votos emitidos</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#votosEmitidos">elec:votosEmitidos</a>
    /// </summary>
    let votosEmitidos = _prefixId.prefix "votosEmitidos"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-14^^xsd:string</para>
    ///   <para>rdfs:comment : Número de votos en blanco en una votación</para>
    ///   <para>rdfs:label : Votos en blanco</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#votosEnBlanco">elec:votosEnBlanco</a>
    /// </summary>
    let votosEnBlanco = _prefixId.prefix "votosEnBlanco"
    /// <summary>
    ///   <para>dcterms:issued : 2013-01-17^^xsd:string</para>
    ///   <para>rdfs:comment : Porcentaje de votos en blanco respecto a los votos emitidos en una votación</para>
    ///   <para>rdfs:label : Porcentaje de votos en blanco</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#votosEnBlancoPorcentaje">elec:votosEnBlancoPorcentaje</a>
    /// </summary>
    let votosEnBlancoPorcentaje = _prefixId.prefix "votosEnBlancoPorcentaje"
    /// <summary>
    ///   <para>dcterms:issued : 2013-01-17^^xsd:string</para>
    ///   <para>rdfs:comment : Número de votos nulos en una votación</para>
    ///   <para>rdfs:label : Votos nulos</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#votosNulos">elec:votosNulos</a>
    /// </summary>
    let votosNulos = _prefixId.prefix "votosNulos"
    /// <summary>
    ///   <para>dcterms:issued : 2013-01-17^^xsd:string</para>
    ///   <para>rdfs:comment : Porcentaje de votos nulos respecto a los votos emitidos en una votación</para>
    ///   <para>rdfs:label : Porcentaje de votos nulos</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#votosNulosPorcentaje">elec:votosNulosPorcentaje</a>
    /// </summary>
    let votosNulosPorcentaje = _prefixId.prefix "votosNulosPorcentaje"
    /// <summary>
    ///   <para>rdfs:comment : Porcentaje de votos recibidos por una candidatura en una votación sobre el total de votantesrdfs:comment : Porcentaje de votos recibidos por una candidatura en una votación sobre el total de electores</para>
    ///   <para>rdfs:label : Porcentaje de votos recibidos sobre el total de votantesrdfs:label : Porcentaje de votos recibidos sobre el total de electores</para>
    ///   <para>dcterms:issued : 2013-01-17^^xsd:string</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#votosPorcentajeSobreElectores">elec:votosPorcentajeSobreElectores</a>
    /// </summary>
    let votosPorcentajeSobreElectores = _prefixId.prefix "votosPorcentajeSobreElectores"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-14^^xsd:string</para>
    ///   <para>rdfs:comment : Número de votos recibidos por una candidatura en una votación</para>
    ///   <para>rdfs:label : Votos recibidos</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#votosRecibidos">elec:votosRecibidos</a>
    /// </summary>
    let votosRecibidos = _prefixId.prefix "votosRecibidos"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-14^^xsd:string</para>
    ///   <para>rdfs:comment : Número de votos válidos en una votación</para>
    ///   <para>rdfs:label : Votos válidos</para>
    ///   <a href="http://purl.org/ctic/sector-publico/elecciones#votosValidos">elec:votosValidos</a>
    /// </summary>
    let votosValidos = _prefixId.prefix "votosValidos"
