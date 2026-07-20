namespace http.idi.fundacionctic.org.cruzar.turismo.hash

open DoxAletheia

module turismo =
    let _namespace_name = "http://idi.fundacionctic.org/cruzar/turismo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Viaje-de-congreso"></see>
    /// </summary>
    let ``Viaje-de-congreso`` = _prefix "Viaje-de-congreso"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Viaje-de-negocios"></see>
    /// </summary>
    let ``Viaje-de-negocios`` = _prefix "Viaje-de-negocios"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Viaje-de-turismo"></see>
    /// </summary>
    let ``Viaje-de-turismo`` = _prefix "Viaje-de-turismo"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Evento-de-zaragoza"></see>
    /// </summary>
    let ``Evento-de-zaragoza`` = _prefix "Evento-de-zaragoza"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Perfil-de-turista"></see>
    /// </summary>
    let ``Perfil-de-turista`` = _prefix "Perfil-de-turista"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Recurso-de-zaragoza"></see>
    /// </summary>
    let ``Recurso-de-zaragoza`` = _prefix "Recurso-de-zaragoza"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-accesibilidad"></see>
    /// </summary>
    let ``Interes-en-accesibilidad`` = _prefix "Interes-en-accesibilidad"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-arquitectura"></see>
    /// </summary>
    let ``Interes-en-arquitectura`` = _prefix "Interes-en-arquitectura"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-arte"></see>
    /// </summary>
    let ``Interes-en-arte`` = _prefix "Interes-en-arte"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-compras"></see>
    /// </summary>
    let ``Interes-en-compras`` = _prefix "Interes-en-compras"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-entorno-natural"></see>
    /// </summary>
    let ``Interes-en-entorno-natural`` = _prefix "Interes-en-entorno-natural"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-barroco"></see>
    /// </summary>
    let ``Interes-en-estilo-barroco`` = _prefix "Interes-en-estilo-barroco"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-contemporaneo"></see>
    /// </summary>
    let ``Interes-en-estilo-contemporaneo`` = _prefix "Interes-en-estilo-contemporaneo"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-gotico"></see>
    /// </summary>
    let ``Interes-en-estilo-gotico`` = _prefix "Interes-en-estilo-gotico"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-modernista"></see>
    /// </summary>
    let ``Interes-en-estilo-modernista`` = _prefix "Interes-en-estilo-modernista"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-mudejar"></see>
    /// </summary>
    let ``Interes-en-estilo-mudejar`` = _prefix "Interes-en-estilo-mudejar"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-neoclasico"></see>
    /// </summary>
    let ``Interes-en-estilo-neoclasico`` = _prefix "Interes-en-estilo-neoclasico"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-renacentista"></see>
    /// </summary>
    let ``Interes-en-estilo-renacentista`` = _prefix "Interes-en-estilo-renacentista"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-romano"></see>
    /// </summary>
    let ``Interes-en-estilo-romano`` = _prefix "Interes-en-estilo-romano"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-expo"></see>
    /// </summary>
    let ``Interes-en-expo`` = _prefix "Interes-en-expo"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-zona-verde"></see>
    /// </summary>
    let ``Interes-en-zona-verde`` = _prefix "Interes-en-zona-verde"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Visita-turistica"></see>
    /// </summary>
    let ``Visita-turistica`` = _prefix "Visita-turistica"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Accesibilidad-completa"></see>
    /// </summary>
    let ``Accesibilidad-completa`` = _prefix "Accesibilidad-completa"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Accesibilidad-con-acompanyante"></see>
    /// </summary>
    let ``Accesibilidad-con-acompanyante`` = _prefix "Accesibilidad-con-acompanyante"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Accesibilidad-con-muletas"></see>
    /// </summary>
    let ``Accesibilidad-con-muletas`` = _prefix "Accesibilidad-con-muletas"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Domingo"></see>
    /// </summary>
    let Domingo = _prefix "Domingo"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Jueves"></see>
    /// </summary>
    let Jueves = _prefix "Jueves"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Lunes"></see>
    /// </summary>
    let Lunes = _prefix "Lunes"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Martes"></see>
    /// </summary>
    let Martes = _prefix "Martes"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Miercoles"></see>
    /// </summary>
    let Miercoles = _prefix "Miercoles"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Sabado"></see>
    /// </summary>
    let Sabado = _prefix "Sabado"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Viernes"></see>
    /// </summary>
    let Viernes = _prefix "Viernes"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Grupo-con-ninyos"></see>
    /// </summary>
    let ``Grupo-con-ninyos`` = _prefix "Grupo-con-ninyos"

    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Grupo-con-personas-con-discapacidad"></see>
    /// </summary>
    let ``Grupo-con-personas-con-discapacidad`` =
        _prefix "Grupo-con-personas-con-discapacidad"

    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Grupo-de-pareja"></see>
    /// </summary>
    let ``Grupo-de-pareja`` = _prefix "Grupo-de-pareja"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Grupo-de-varias-personas"></see>
    /// </summary>
    let ``Grupo-de-varias-personas`` = _prefix "Grupo-de-varias-personas"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Grupo-individual"></see>
    /// </summary>
    let ``Grupo-individual`` = _prefix "Grupo-individual"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Estilo-barroco"></see>
    /// </summary>
    let ``Estilo-barroco`` = _prefix "Estilo-barroco"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Estilo-contemporaneo"></see>
    /// </summary>
    let ``Estilo-contemporaneo`` = _prefix "Estilo-contemporaneo"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Estilo-gotico"></see>
    /// </summary>
    let ``Estilo-gotico`` = _prefix "Estilo-gotico"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Estilo-modernista"></see>
    /// </summary>
    let ``Estilo-modernista`` = _prefix "Estilo-modernista"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Estilo-mudejar"></see>
    /// </summary>
    let ``Estilo-mudejar`` = _prefix "Estilo-mudejar"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Estilo-renacentista"></see>
    /// </summary>
    let ``Estilo-renacentista`` = _prefix "Estilo-renacentista"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Estilo-romano"></see>
    /// </summary>
    let ``Estilo-romano`` = _prefix "Estilo-romano"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Dos-tenedores"></see>
    /// </summary>
    let ``Dos-tenedores`` = _prefix "Dos-tenedores"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Sin-gluten"></see>
    /// </summary>
    let ``Sin-gluten`` = _prefix "Sin-gluten"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Tres-tenedores"></see>
    /// </summary>
    let ``Tres-tenedores`` = _prefix "Tres-tenedores"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Un-tenedor"></see>
    /// </summary>
    let ``Un-tenedor`` = _prefix "Un-tenedor"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Ruta-turistica"></see>
    /// </summary>
    let ``Ruta-turistica`` = _prefix "Ruta-turistica"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Conocer-expo"></see>
    /// </summary>
    let ``Conocer-expo`` = _prefix "Conocer-expo"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Conocer-zaragoza-verde"></see>
    /// </summary>
    let ``Conocer-zaragoza-verde`` = _prefix "Conocer-zaragoza-verde"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Curiosear-por-calles"></see>
    /// </summary>
    let ``Curiosear-por-calles`` = _prefix "Curiosear-por-calles"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Ir-de-compras"></see>
    /// </summary>
    let ``Ir-de-compras`` = _prefix "Ir-de-compras"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Pasear"></see>
    /// </summary>
    let Pasear = _prefix "Pasear"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Salir-de-marcha"></see>
    /// </summary>
    let ``Salir-de-marcha`` = _prefix "Salir-de-marcha"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Ver-arquitectura"></see>
    /// </summary>
    let ``Ver-arquitectura`` = _prefix "Ver-arquitectura"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Ver-arte"></see>
    /// </summary>
    let ``Ver-arte`` = _prefix "Ver-arte"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-barroco"></see>
    /// </summary>
    let ``Ver-estilo-barroco`` = _prefix "Ver-estilo-barroco"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-contemporaneo"></see>
    /// </summary>
    let ``Ver-estilo-contemporaneo`` = _prefix "Ver-estilo-contemporaneo"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-gotico"></see>
    /// </summary>
    let ``Ver-estilo-gotico`` = _prefix "Ver-estilo-gotico"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-modernista"></see>
    /// </summary>
    let ``Ver-estilo-modernista`` = _prefix "Ver-estilo-modernista"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-mudejar"></see>
    /// </summary>
    let ``Ver-estilo-mudejar`` = _prefix "Ver-estilo-mudejar"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-neoclasico"></see>
    /// </summary>
    let ``Ver-estilo-neoclasico`` = _prefix "Ver-estilo-neoclasico"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-renacentista"></see>
    /// </summary>
    let ``Ver-estilo-renacentista`` = _prefix "Ver-estilo-renacentista"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-romano"></see>
    /// </summary>
    let ``Ver-estilo-romano`` = _prefix "Ver-estilo-romano"

    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Accesibilidad-de-movilidad-reducida"></see>
    /// </summary>
    let ``Accesibilidad-de-movilidad-reducida`` =
        _prefix "Accesibilidad-de-movilidad-reducida"

    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Estilo-artistico"></see>
    /// </summary>
    let ``Estilo-artistico`` = _prefix "Estilo-artistico"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Alojamiento"></see>
    /// </summary>
    let Alojamiento = _prefix "Alojamiento"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Recurso-hostelero"></see>
    /// </summary>
    let ``Recurso-hostelero`` = _prefix "Recurso-hostelero"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Calificacion"></see>
    /// </summary>
    let Calificacion = _prefix "Calificacion"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Caminar-velocidad-lenta"></see>
    /// </summary>
    let ``Caminar-velocidad-lenta`` = _prefix "Caminar-velocidad-lenta"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#necessity-relevance"></see>
    /// </summary>
    let ``necessity-relevance`` = _prefix "necessity-relevance"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Preferencia-de-ruta"></see>
    /// </summary>
    let ``Preferencia-de-ruta`` = _prefix "Preferencia-de-ruta"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Caminar-velocidad-rapida"></see>
    /// </summary>
    let ``Caminar-velocidad-rapida`` = _prefix "Caminar-velocidad-rapida"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Preferencia-de-usuario"></see>
    /// </summary>
    let ``Preferencia-de-usuario`` = _prefix "Preferencia-de-usuario"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Dia-Festivo"></see>
    /// </summary>
    let ``Dia-Festivo`` = _prefix "Dia-Festivo"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Dia-de-la-semana"></see>
    /// </summary>
    let ``Dia-de-la-semana`` = _prefix "Dia-de-la-semana"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Dia-de-visita-turistica"></see>
    /// </summary>
    let ``Dia-de-visita-turistica`` = _prefix "Dia-de-visita-turistica"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Temporada"></see>
    /// </summary>
    let Temporada = _prefix "Temporada"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Dia-de-visita-turistica_6"></see>
    /// </summary>
    let ``Dia-de-visita-turistica_6`` = _prefix "Dia-de-visita-turistica_6"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#date"></see>
    /// </summary>
    let date = _prefix "date"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Dia-de-visita-turistica_7"></see>
    /// </summary>
    let ``Dia-de-visita-turistica_7`` = _prefix "Dia-de-visita-turistica_7"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Horario-de-visita_11"></see>
    /// </summary>
    let ``Horario-de-visita_11`` = _prefix "Horario-de-visita_11"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Edificio-historico"></see>
    /// </summary>
    let ``Edificio-historico`` = _prefix "Edificio-historico"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Monumento"></see>
    /// </summary>
    let Monumento = _prefix "Monumento"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Edificio-religioso"></see>
    /// </summary>
    let ``Edificio-religioso`` = _prefix "Edificio-religioso"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Entorno-natural"></see>
    /// </summary>
    let ``Entorno-natural`` = _prefix "Entorno-natural"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Zona-verde"></see>
    /// </summary>
    let ``Zona-verde`` = _prefix "Zona-verde"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Escultura"></see>
    /// </summary>
    let Escultura = _prefix "Escultura"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Estilo-neoclasico"></see>
    /// </summary>
    let ``Estilo-neoclasico`` = _prefix "Estilo-neoclasico"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Fortaleza"></see>
    /// </summary>
    let Fortaleza = _prefix "Fortaleza"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Grupo-de-viaje"></see>
    /// </summary>
    let ``Grupo-de-viaje`` = _prefix "Grupo-de-viaje"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Horario-de-visita"></see>
    /// </summary>
    let ``Horario-de-visita`` = _prefix "Horario-de-visita"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#closing-time"></see>
    /// </summary>
    let ``closing-time`` = _prefix "closing-time"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#opening-time"></see>
    /// </summary>
    let ``opening-time`` = _prefix "opening-time"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Temporada-de-verano"></see>
    /// </summary>
    let ``Temporada-de-verano`` = _prefix "Temporada-de-verano"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Horario-de-visita_7"></see>
    /// </summary>
    let ``Horario-de-visita_7`` = _prefix "Horario-de-visita_7"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Temporada-de-invierno"></see>
    /// </summary>
    let ``Temporada-de-invierno`` = _prefix "Temporada-de-invierno"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Horario-de-visita_8"></see>
    /// </summary>
    let ``Horario-de-visita_8`` = _prefix "Horario-de-visita_8"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#interest-relevance"></see>
    /// </summary>
    let ``interest-relevance`` = _prefix "interest-relevance"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Interes-turistico"></see>
    /// </summary>
    let ``Interes-turistico`` = _prefix "Interes-turistico"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-edificio-historico"></see>
    /// </summary>
    let ``Interes-en-edificio-historico`` = _prefix "Interes-en-edificio-historico"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-edificio-religioso"></see>
    /// </summary>
    let ``Interes-en-edificio-religioso`` = _prefix "Interes-en-edificio-religioso"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-escultura"></see>
    /// </summary>
    let ``Interes-en-escultura`` = _prefix "Interes-en-escultura"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-fortalezas"></see>
    /// </summary>
    let ``Interes-en-fortalezas`` = _prefix "Interes-en-fortalezas"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-museos"></see>
    /// </summary>
    let ``Interes-en-museos`` = _prefix "Interes-en-museos"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-palacios"></see>
    /// </summary>
    let ``Interes-en-palacios`` = _prefix "Interes-en-palacios"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Mercado"></see>
    /// </summary>
    let Mercado = _prefix "Mercado"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Recurso-comercial"></see>
    /// </summary>
    let ``Recurso-comercial`` = _prefix "Recurso-comercial"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Recurso-turistico"></see>
    /// </summary>
    let ``Recurso-turistico`` = _prefix "Recurso-turistico"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Museo"></see>
    /// </summary>
    let Museo = _prefix "Museo"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Palacio"></see>
    /// </summary>
    let Palacio = _prefix "Palacio"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Perfil-de-prueba1"></see>
    /// </summary>
    let ``Perfil-de-prueba1`` = _prefix "Perfil-de-prueba1"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Perfil-de-prueba2"></see>
    /// </summary>
    let ``Perfil-de-prueba2`` = _prefix "Perfil-de-prueba2"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Viaje"></see>
    /// </summary>
    let Viaje = _prefix "Viaje"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Restaurante"></see>
    /// </summary>
    let Restaurante = _prefix "Restaurante"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Ruta-turistica_propuesta1"></see>
    /// </summary>
    let ``Ruta-turistica_propuesta1`` = _prefix "Ruta-turistica_propuesta1"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_06"></see>
    /// </summary>
    let ``Visita-planificada_06`` = _prefix "Visita-planificada_06"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_07"></see>
    /// </summary>
    let ``Visita-planificada_07`` = _prefix "Visita-planificada_07"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_08"></see>
    /// </summary>
    let ``Visita-planificada_08`` = _prefix "Visita-planificada_08"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_09"></see>
    /// </summary>
    let ``Visita-planificada_09`` = _prefix "Visita-planificada_09"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_04"></see>
    /// </summary>
    let ``Visita-planificada_04`` = _prefix "Visita-planificada_04"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_10"></see>
    /// </summary>
    let ``Visita-planificada_10`` = _prefix "Visita-planificada_10"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_05"></see>
    /// </summary>
    let ``Visita-planificada_05`` = _prefix "Visita-planificada_05"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_02"></see>
    /// </summary>
    let ``Visita-planificada_02`` = _prefix "Visita-planificada_02"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_01"></see>
    /// </summary>
    let ``Visita-planificada_01`` = _prefix "Visita-planificada_01"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_03"></see>
    /// </summary>
    let ``Visita-planificada_03`` = _prefix "Visita-planificada_03"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Ruta-turistica_propuesta2"></see>
    /// </summary>
    let ``Ruta-turistica_propuesta2`` = _prefix "Ruta-turistica_propuesta2"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_04bis"></see>
    /// </summary>
    let ``Visita-planificada_04bis`` = _prefix "Visita-planificada_04bis"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_05bis"></see>
    /// </summary>
    let ``Visita-planificada_05bis`` = _prefix "Visita-planificada_05bis"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Sector-comercial"></see>
    /// </summary>
    let ``Sector-comercial`` = _prefix "Sector-comercial"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#begining-date"></see>
    /// </summary>
    let ``begining-date`` = _prefix "begining-date"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#ending-date"></see>
    /// </summary>
    let ``ending-date`` = _prefix "ending-date"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Ver-edificio-historico"></see>
    /// </summary>
    let ``Ver-edificio-historico`` = _prefix "Ver-edificio-historico"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Ver-edificio-religioso"></see>
    /// </summary>
    let ``Ver-edificio-religioso`` = _prefix "Ver-edificio-religioso"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Ver-escultura"></see>
    /// </summary>
    let ``Ver-escultura`` = _prefix "Ver-escultura"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Ver-fortaleza"></see>
    /// </summary>
    let ``Ver-fortaleza`` = _prefix "Ver-fortaleza"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Ver-museo"></see>
    /// </summary>
    let ``Ver-museo`` = _prefix "Ver-museo"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Ver-palacio"></see>
    /// </summary>
    let ``Ver-palacio`` = _prefix "Ver-palacio"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Ver-zona-verde"></see>
    /// </summary>
    let ``Ver-zona-verde`` = _prefix "Ver-zona-verde"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Viaje-de-descanso"></see>
    /// </summary>
    let ``Viaje-de-descanso`` = _prefix "Viaje-de-descanso"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Visitar-tiempo-corto"></see>
    /// </summary>
    let ``Visitar-tiempo-corto`` = _prefix "Visitar-tiempo-corto"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#Visitar-tiempo-largo"></see>
    /// </summary>
    let ``Visitar-tiempo-largo`` = _prefix "Visitar-tiempo-largo"
    /// <summary>
    /// Guarda la dirección postal del recurso
    /// <see href="http://idi.fundacionctic.org/cruzar/turismo#address"></see></summary>
    let address = _prefix "address"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#final-date"></see>
    /// </summary>
    let ``final-date`` = _prefix "final-date"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#has-interest"></see>
    /// </summary>
    let ``has-interest`` = _prefix "has-interest"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#has-no-interest"></see>
    /// </summary>
    let ``has-no-interest`` = _prefix "has-no-interest"
    /// <summary>
    /// Guarda el texto con el horario de visita del recurso.
    /// <see href="http://idi.fundacionctic.org/cruzar/turismo#horario"></see></summary>
    let horario = _prefix "horario"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#id-idezar"></see>
    /// </summary>
    let ``id-idezar`` = _prefix "id-idezar"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#initial-date"></see>
    /// </summary>
    let ``initial-date`` = _prefix "initial-date"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#interest-towards"></see>
    /// </summary>
    let ``interest-towards`` = _prefix "interest-towards"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#not-desire-towards"></see>
    /// </summary>
    let ``not-desire-towards`` = _prefix "not-desire-towards"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#not-interest-towards"></see>
    /// </summary>
    let ``not-interest-towards`` = _prefix "not-interest-towards"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#poi-relevance"></see>
    /// </summary>
    let ``poi-relevance`` = _prefix "poi-relevance"
    /// <summary>
    ///   <see href="http://idi.fundacionctic.org/cruzar/turismo#visit-duration"></see>
    /// </summary>
    let ``visit-duration`` = _prefix "visit-duration"
