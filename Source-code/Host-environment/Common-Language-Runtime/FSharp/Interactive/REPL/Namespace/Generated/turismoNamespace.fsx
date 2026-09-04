#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module turismo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://idi.fundacionctic.org/cruzar/turismo#" "turismo"

    let Accesibilidad_completa = _prefixId.prefix "Accesibilidad-completa"

    let Accesibilidad_con_acompanyante =
        _prefixId.prefix "Accesibilidad-con-acompanyante"

    let Accesibilidad_con_muletas = _prefixId.prefix "Accesibilidad-con-muletas"

    /// <summary>
    ///   <para>rdfs:label : Accesibilidad de movilidad reducida</para>
    ///   <para>rdfs:comment : La accesibilidad es el grado con el que algo puede ser usado, visitado o accedido por todas las personas, independientemente de sus capacidades técnicas o físicas. En el caso de personas con movilidad reducida (que implique el uso de ayudas técnicas como muletas, sillas de ruedas, etc.), el grado de accesibilidad se mide de acuerdo a la facilidad de desplazamiento de los turistas por el entorno de los distintos recursos de la ciudad. La descripción del grado de accesibilidad de cada monumento se ha extraído de la base de datos de Monumentos.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Accesibilidad-de-movilidad-reducida">turismo:Accesibilidad-de-movilidad-reducida</a>
    /// </summary>
    let Accesibilidad_de_movilidad_reducida =
        _prefixId.prefix "Accesibilidad-de-movilidad-reducida"

    /// <summary>
    ///   <para>rdfs:label : Alojamiento</para>
    ///   <para>rdfs:comment : Establecimiento de hostelería en Zaragoza en el que se proporciona alojamiento. La elección de un alojamiento determinado modifica el lugar de inicio de la ruta, tomando como punto de partida el alojamiento en el que se hospeda el usuario.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Alojamiento">turismo:Alojamiento</a>
    /// </summary>
    let Alojamiento = _prefixId.prefix "Alojamiento"
    /// <summary>
    ///   <para>rdfs:comment : Calificación oficial proporcionada por el Patronato de Turismo para los distintos restaurantes de la ciudad de Zaragoza.</para>
    ///   <para>rdfs:label : Calificación</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Calificacion">turismo:Calificacion</a>
    /// </summary>
    let Calificacion = _prefixId.prefix "Calificacion"
    let Caminar_velocidad_lenta = _prefixId.prefix "Caminar-velocidad-lenta"
    let Caminar_velocidad_rapida = _prefixId.prefix "Caminar-velocidad-rapida"
    let Conocer_expo = _prefixId.prefix "Conocer-expo"
    let Conocer_zaragoza_verde = _prefixId.prefix "Conocer-zaragoza-verde"
    let Curiosear_por_calles = _prefixId.prefix "Curiosear-por-calles"
    /// <summary>
    ///   <para>rdfs:comment : Día no laborable relacionado con alguna fiesta local o nacional: Fiesta del Pilar, Navidad, etc. Estos días requieren un tratamiento independiente ya que los recursos turísticos tienen estos días un horario especial.</para>
    ///   <para>rdfs:label : Día festivo</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Dia-Festivo">turismo:Dia-Festivo</a>
    /// </summary>
    let Dia_Festivo = _prefixId.prefix "Dia-Festivo"
    /// <summary>
    ///   <para>rdfs:comment : Cada uno de los días de la semana</para>
    ///   <para>rdfs:label : Día de la semana</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Dia-de-la-semana">turismo:Dia-de-la-semana</a>
    /// </summary>
    let Dia_de_la_semana = _prefixId.prefix "Dia-de-la-semana"
    /// <summary>
    ///   <para>rdfs:label : Día de visita turística</para>
    ///   <para>rdfs:comment : Cada uno de los días de visita turística por la ciudad de Zaragoza que escoge el turista. Para cada uno de estos días, el sistema construirá una ruta específica atendiendo a su perfil y a la disponibilidad de los recursos de la ciudad.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Dia-de-visita-turistica">turismo:Dia-de-visita-turistica</a>
    /// </summary>
    let Dia_de_visita_turistica = _prefixId.prefix "Dia-de-visita-turistica"
    let Dia_de_visita_turistica_6 = _prefixId.prefix "Dia-de-visita-turistica_6"
    let Dia_de_visita_turistica_7 = _prefixId.prefix "Dia-de-visita-turistica_7"
    let Domingo = _prefixId.prefix "Domingo"
    let Dos_tenedores = _prefixId.prefix "Dos-tenedores"
    /// <summary>
    ///   <para>rdfs:comment : Edificio de carácter histórico con interés cultural o arquitectónico.</para>
    ///   <para>rdfs:label : Edificio histórico</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Edificio-historico">turismo:Edificio-historico</a>
    /// </summary>
    let Edificio_historico = _prefixId.prefix "Edificio-historico"
    /// <summary>
    ///   <para>rdfs:comment : Edificio de carácter religioso, como pueden ser iglesias, conventos, catedrales, etc.</para>
    ///   <para>rdfs:label : Edificio religioso</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Edificio-religioso">turismo:Edificio-religioso</a>
    /// </summary>
    let Edificio_religioso = _prefixId.prefix "Edificio-religioso"
    /// <summary>
    ///   <para>rdfs:label : Entorno natural</para>
    ///   <para>rdfs:comment : Zona de verde de excepcional singularidad debido a su paisaje, protección medioambiental e interés turístico.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Entorno-natural">turismo:Entorno-natural</a>
    /// </summary>
    let Entorno_natural = _prefixId.prefix "Entorno-natural"
    /// <summary>
    ///   <para>rdfs:label : Escultura</para>
    ///   <para>rdfs:comment : Fuentes y estatuas</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Escultura">turismo:Escultura</a>
    /// </summary>
    let Escultura = _prefixId.prefix "Escultura"
    /// <summary>
    ///   <para>rdfs:comment : El estilo es el conjunto de características que individualizan la tendencia artística de una época: barroco, mudéjar, renacentista, etc. La descripción de los estilos de cada monumento se ha extraído de la base de datos de Monumentos.</para>
    ///   <para>rdfs:label : Estilo artístico</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Estilo-artistico">turismo:Estilo-artistico</a>
    /// </summary>
    let Estilo_artistico = _prefixId.prefix "Estilo-artistico"
    let Estilo_barroco = _prefixId.prefix "Estilo-barroco"
    let Estilo_contemporaneo = _prefixId.prefix "Estilo-contemporaneo"
    let Estilo_gotico = _prefixId.prefix "Estilo-gotico"
    let Estilo_modernista = _prefixId.prefix "Estilo-modernista"
    let Estilo_mudejar = _prefixId.prefix "Estilo-mudejar"
    let Estilo_neoclasico = _prefixId.prefix "Estilo-neoclasico"
    let Estilo_renacentista = _prefixId.prefix "Estilo-renacentista"
    let Estilo_romano = _prefixId.prefix "Estilo-romano"
    /// <summary>
    ///   <para>rdfs:comment : Esta clase conceptualiza la Agenda de actividades de la ciudad de Zaragoza. Cada uno de los eventos de la Agenda son instancias de este concepto. Los eventos se utilizan como sugerencias complementarias a la ruta definida por el sistema.</para>
    ///   <para>rdfs:label : Evento de Zaragoza</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Evento-de-zaragoza">turismo:Evento-de-zaragoza</a>
    /// </summary>
    let Evento_de_zaragoza = _prefixId.prefix "Evento-de-zaragoza"
    /// <summary>
    ///   <para>rdfs:comment : Construcción fortificada como murallas o torreones de defensa.</para>
    ///   <para>rdfs:label : Fortaleza</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Fortaleza">turismo:Fortaleza</a>
    /// </summary>
    let Fortaleza = _prefixId.prefix "Fortaleza"
    let Grupo_con_ninyos = _prefixId.prefix "Grupo-con-ninyos"

    let Grupo_con_personas_con_discapacidad =
        _prefixId.prefix "Grupo-con-personas-con-discapacidad"

    let Grupo_de_pareja = _prefixId.prefix "Grupo-de-pareja"
    let Grupo_de_varias_personas = _prefixId.prefix "Grupo-de-varias-personas"
    /// <summary>
    ///   <para>rdfs:label : Grupo de viaje</para>
    ///   <para>rdfs:comment : Colectivo de personas que realizan una visita turística a la ciudad de Zaragoza, y para los que el sistema calculará una ruta contextualizada.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Grupo-de-viaje">turismo:Grupo-de-viaje</a>
    /// </summary>
    let Grupo_de_viaje = _prefixId.prefix "Grupo-de-viaje"
    let Grupo_individual = _prefixId.prefix "Grupo-individual"
    /// <summary>
    ///   <para>rdfs:label : Horario de visita</para>
    ///   <para>rdfs:comment : Horarios de visita de los recursos turísticos: museos, edificios, iglesias, etc. Para construir el horario de visita, se utiliza el horario de apertura y cierre del recurso, el día de la semana y la temporada.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Horario-de-visita">turismo:Horario-de-visita</a>
    /// </summary>
    let Horario_de_visita = _prefixId.prefix "Horario-de-visita"
    let Horario_de_visita_11 = _prefixId.prefix "Horario-de-visita_11"
    let Horario_de_visita_7 = _prefixId.prefix "Horario-de-visita_7"
    let Horario_de_visita_8 = _prefixId.prefix "Horario-de-visita_8"
    let Interes_en_accesibilidad = _prefixId.prefix "Interes-en-accesibilidad"
    let Interes_en_arquitectura = _prefixId.prefix "Interes-en-arquitectura"
    let Interes_en_arte = _prefixId.prefix "Interes-en-arte"
    let Interes_en_compras = _prefixId.prefix "Interes-en-compras"
    let Interes_en_edificio_historico = _prefixId.prefix "Interes-en-edificio-historico"
    let Interes_en_edificio_religioso = _prefixId.prefix "Interes-en-edificio-religioso"
    let Interes_en_entorno_natural = _prefixId.prefix "Interes-en-entorno-natural"
    let Interes_en_escultura = _prefixId.prefix "Interes-en-escultura"
    let Interes_en_estilo_barroco = _prefixId.prefix "Interes-en-estilo-barroco"

    let Interes_en_estilo_contemporaneo =
        _prefixId.prefix "Interes-en-estilo-contemporaneo"

    let Interes_en_estilo_gotico = _prefixId.prefix "Interes-en-estilo-gotico"
    let Interes_en_estilo_modernista = _prefixId.prefix "Interes-en-estilo-modernista"
    let Interes_en_estilo_mudejar = _prefixId.prefix "Interes-en-estilo-mudejar"
    let Interes_en_estilo_neoclasico = _prefixId.prefix "Interes-en-estilo-neoclasico"

    let Interes_en_estilo_renacentista =
        _prefixId.prefix "Interes-en-estilo-renacentista"

    let Interes_en_estilo_romano = _prefixId.prefix "Interes-en-estilo-romano"
    let Interes_en_expo = _prefixId.prefix "Interes-en-expo"
    let Interes_en_fortalezas = _prefixId.prefix "Interes-en-fortalezas"
    let Interes_en_museos = _prefixId.prefix "Interes-en-museos"
    let Interes_en_palacios = _prefixId.prefix "Interes-en-palacios"
    let Interes_en_zona_verde = _prefixId.prefix "Interes-en-zona-verde"
    /// <summary>
    ///   <para>rdfs:comment : El interés turístico es el grado de relevancia que tiene un recurso de la ciudad de Zaragoza para un determinado perfil de turista. Por ejemplo, si a un turista le gusta el arte barroco, el turista tendrá interés en el arte barroco y, por tanto, en cualquier monumento que se englobe dentro de este estilo. Los intereses de los perfiles se calculan a partir de las preferencias declaradas por el usuario y utilizando las reglas de negocio.</para>
    ///   <para>rdfs:label : Interés turístico</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Interes-turistico">turismo:Interes-turistico</a>
    /// </summary>
    let Interes_turistico = _prefixId.prefix "Interes-turistico"
    let Ir_de_compras = _prefixId.prefix "Ir-de-compras"
    let Jueves = _prefixId.prefix "Jueves"
    let Lunes = _prefixId.prefix "Lunes"
    let Martes = _prefixId.prefix "Martes"
    /// <summary>
    ///   <para>rdfs:label : Mercado</para>
    ///   <para>rdfs:comment : Sitio público destinado a vender o comprar productos. Los mercados se ofrecen como sugerencias a la ruta en base al perfil del turista y sólo se ofrecen en los días señalados.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Mercado">turismo:Mercado</a>
    /// </summary>
    let Mercado = _prefixId.prefix "Mercado"
    let Miercoles = _prefixId.prefix "Miercoles"
    /// <summary>
    ///   <para>rdfs:label : Monumento</para>
    ///   <para>rdfs:comment : Construcción que posee valor artístico, arqueológico, histórico, etc. Las bases de datos de Monumentos y el Catálogo de Edificios de la Ciudad de Zaragoza se han mapeado a este concepto. Se ha subclasificado este concepto para conseguir una organización más rica de los monumentos. Esta información es usada por el sistema para configurar la ruta de manera más acorde a las preferencias del usuario mediante las reglas de negocio. Por ejemplo, si el usuario viaja con niños, el sistema por defecto no le ofrecerá museos en la ruta.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Monumento">turismo:Monumento</a>
    /// </summary>
    let Monumento = _prefixId.prefix "Monumento"
    /// <summary>
    ///   <para>rdfs:comment : Lugar de Zaragoza en que se exponen colecciones de objetos artísticos de distinto estilo y época: romana, mudéjar, etc.</para>
    ///   <para>rdfs:label : Museo</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Museo">turismo:Museo</a>
    /// </summary>
    let Museo = _prefixId.prefix "Museo"
    /// <summary>
    ///   <para>rdfs:label : Palacio</para>
    ///   <para>rdfs:comment : Edificio de gran transcendencia artística y de relevancia social ya que nacen como lugar de residencia de personajes importanes: palacio ducal, arzobispal.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Palacio">turismo:Palacio</a>
    /// </summary>
    let Palacio = _prefixId.prefix "Palacio"
    let Pasear = _prefixId.prefix "Pasear"
    let Perfil_de_prueba1 = _prefixId.prefix "Perfil-de-prueba1"
    let Perfil_de_prueba2 = _prefixId.prefix "Perfil-de-prueba2"
    /// <summary>
    ///   <para>rdfs:label : Perfil de turista</para>
    ///   <para>rdfs:comment : El perfil de turista es el conjunto de rasgos particulares que caracterizan a un turista en particular para el cual se va a calcular la ruta. El perfil de turista contempla desde los días de visita a la ciudad de Zaragoza (único dato obligatorio), el tipo de viaje, si es un viaje en grupo, los intereses y las preferencias turísticas del perfil.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Perfil-de-turista">turismo:Perfil-de-turista</a>
    /// </summary>
    let Perfil_de_turista = _prefixId.prefix "Perfil-de-turista"
    /// <summary>
    ///   <para>rdfs:label : Preferencia de ruta</para>
    ///   <para>rdfs:comment : Una preferencia de ruta es una constricción contextual para el cálculo dinámico de la ruta. Los perfiles de turista pueden requerir configuraciones particulares de los parámetros que afectan a la confección de la ruta, por ejemplo, que la velocidad de desplazamiento se vea afectada por características de movilidad de los turistas. Las preferencias de ruta para cada perfil se calculan mediante las reglas de negocio: duración de la visita y velocidad de desplazamiento.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Preferencia-de-ruta">turismo:Preferencia-de-ruta</a>
    /// </summary>
    let Preferencia_de_ruta = _prefixId.prefix "Preferencia-de-ruta"
    /// <summary>
    ///   <para>rdfs:label : Preferencia de usuario</para>
    ///   <para>rdfs:comment : Actividades que el turista puede estar interesado en realizar como visitar museos, pasear, ir de compras, etc.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Preferencia-de-usuario">turismo:Preferencia-de-usuario</a>
    /// </summary>
    let Preferencia_de_usuario = _prefixId.prefix "Preferencia-de-usuario"
    /// <summary>
    ///   <para>rdfs:comment : Recurso de interés comercial que ofrece la ciudad de Zaragoza. La información tanto de los mercados como de los sectores se ha extraído directamente de la página web municipal del Ayuntamiento. Los recursos comerciales se muestran como sugerencias en la ruta, y siempre bajo demanda del usuario (selección de la casilla "Me gusta ir de compras").</para>
    ///   <para>rdfs:label : Recurso comercial</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Recurso-comercial">turismo:Recurso-comercial</a>
    /// </summary>
    let Recurso_comercial = _prefixId.prefix "Recurso-comercial"
    /// <summary>
    ///   <para>rdfs:label : Recurso de Zaragoza</para>
    ///   <para>rdfs:comment : Recursos de interés comercial, turístico o de hostelería, que ofrece la ciudad de Zaragoza.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Recurso-de-zaragoza">turismo:Recurso-de-zaragoza</a>
    /// </summary>
    let Recurso_de_zaragoza = _prefixId.prefix "Recurso-de-zaragoza"
    /// <summary>
    ///   <para>rdfs:label : Recurso hostelero</para>
    ///   <para>rdfs:comment : Recurso de interés hostelero que ofrece la ciudad de Zaragoza. Las bases de datos de restaurantes y alojamientos se han mapeado a sus subclases.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Recurso-hostelero">turismo:Recurso-hostelero</a>
    /// </summary>
    let Recurso_hostelero = _prefixId.prefix "Recurso-hostelero"
    /// <summary>
    ///   <para>rdfs:label : Recurso turístico</para>
    ///   <para>rdfs:comment : Recurso de interés turístico que ofrece la ciudad de Zaragoza.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Recurso-turistico">turismo:Recurso-turistico</a>
    /// </summary>
    let Recurso_turistico = _prefixId.prefix "Recurso-turistico"
    /// <summary>
    ///   <para>rdfs:label : Restaurante</para>
    ///   <para>rdfs:comment : Establecimiento público donde se sirven comidas. Los restaurantes se sugieren al usuario a la hora de la comida y de la cena. Se sugieren 5 restaurantes por cada slot de tiempo utilizando dos criterios: proximidad con el último POI de la ruta turística y calificación gastronómica.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Restaurante">turismo:Restaurante</a>
    /// </summary>
    let Restaurante = _prefixId.prefix "Restaurante"
    /// <summary>
    ///   <para>rdfs:comment : Es el itinerario calculado dinámicamente por el sistema. Para cada día de estancia del turista se confecciona una ruta específica que consiste en una serie de visitas a determinados recursos turísticos de la ciudad de Zaragoza. La ruta se adapta además a las características del perfil del usuario como las preferencias, las limitaciones de movilidad, el alojamiento, los horarios de visitas de los monumentos, etc. El sistema no sólo genera un itinerario en el tiempo y espacio correspondientes, sino que además proporciona una serie de sugerencias para el turista que complementan su visita a la ciudad: eventos de interés, restaurantes cercanos y sectores comerciales.</para>
    ///   <para>rdfs:label : Ruta turística</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Ruta-turistica">turismo:Ruta-turistica</a>
    /// </summary>
    let Ruta_turistica = _prefixId.prefix "Ruta-turistica"
    let Ruta_turistica_propuesta1 = _prefixId.prefix "Ruta-turistica_propuesta1"
    let Ruta_turistica_propuesta2 = _prefixId.prefix "Ruta-turistica_propuesta2"
    let Sabado = _prefixId.prefix "Sabado"
    let Salir_de_marcha = _prefixId.prefix "Salir-de-marcha"
    /// <summary>
    ///   <para>rdfs:label : Sector comercial</para>
    ///   <para>rdfs:comment : Un sector es un conjunto de negocios que se engloban en un área diferenciada de la ciudad de Zaragoza.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Sector-comercial">turismo:Sector-comercial</a>
    /// </summary>
    let Sector_comercial = _prefixId.prefix "Sector-comercial"
    let Sin_gluten = _prefixId.prefix "Sin-gluten"
    /// <summary>
    ///   <para>rdfs:label : Temporada</para>
    ///   <para>rdfs:comment : Espacio temporal de varios meses. A nivel turístico, el año se divide en temporada de verano y temporada de invierno. La temporada influye en los horarios de apertura y cierre de los recursos turísticos: museos, iglesias, etc. El mismo monumento, pongamos por caso, la Basílica del
    /// Pilar, no tiene el mismo horario de visita en la temporada de invierno, que en la temporada de verano. En esta ontología, se siguen los siguientes
    /// criterios: 1) Temporada de invierno: desde el 9 de octubre hasta el 30 de abril; 2) Temporada de verano: desde el 1 de mayo hasta el 8 de octubre.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Temporada">turismo:Temporada</a>
    /// </summary>
    let Temporada = _prefixId.prefix "Temporada"
    let Temporada_de_invierno = _prefixId.prefix "Temporada-de-invierno"
    let Temporada_de_verano = _prefixId.prefix "Temporada-de-verano"
    let Tres_tenedores = _prefixId.prefix "Tres-tenedores"
    let Un_tenedor = _prefixId.prefix "Un-tenedor"
    let Ver_arquitectura = _prefixId.prefix "Ver-arquitectura"
    let Ver_arte = _prefixId.prefix "Ver-arte"
    let Ver_edificio_historico = _prefixId.prefix "Ver-edificio-historico"
    let Ver_edificio_religioso = _prefixId.prefix "Ver-edificio-religioso"
    let Ver_escultura = _prefixId.prefix "Ver-escultura"
    let Ver_estilo_barroco = _prefixId.prefix "Ver-estilo-barroco"
    let Ver_estilo_contemporaneo = _prefixId.prefix "Ver-estilo-contemporaneo"
    let Ver_estilo_gotico = _prefixId.prefix "Ver-estilo-gotico"
    let Ver_estilo_modernista = _prefixId.prefix "Ver-estilo-modernista"
    let Ver_estilo_mudejar = _prefixId.prefix "Ver-estilo-mudejar"
    let Ver_estilo_neoclasico = _prefixId.prefix "Ver-estilo-neoclasico"
    let Ver_estilo_renacentista = _prefixId.prefix "Ver-estilo-renacentista"
    let Ver_estilo_romano = _prefixId.prefix "Ver-estilo-romano"
    let Ver_fortaleza = _prefixId.prefix "Ver-fortaleza"
    let Ver_museo = _prefixId.prefix "Ver-museo"
    let Ver_palacio = _prefixId.prefix "Ver-palacio"
    let Ver_zona_verde = _prefixId.prefix "Ver-zona-verde"
    /// <summary>
    ///   <para>rdfs:comment : Un viaje a la ciudad de Zaragoza puede realizarse por distintos motivos. En esta ontología, se contamplan cuatro posibilidades: puramente turísticos, por motivos laborales, asistencia a un congreso o conferencia y por descanso.</para>
    ///   <para>rdfs:label : Viaje</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Viaje">turismo:Viaje</a>
    /// </summary>
    let Viaje = _prefixId.prefix "Viaje"
    let Viaje_de_congreso = _prefixId.prefix "Viaje-de-congreso"
    let Viaje_de_descanso = _prefixId.prefix "Viaje-de-descanso"
    let Viaje_de_negocios = _prefixId.prefix "Viaje-de-negocios"
    let Viaje_de_turismo = _prefixId.prefix "Viaje-de-turismo"
    let Viernes = _prefixId.prefix "Viernes"
    let Visita_planificada_01 = _prefixId.prefix "Visita-planificada_01"
    let Visita_planificada_02 = _prefixId.prefix "Visita-planificada_02"
    let Visita_planificada_03 = _prefixId.prefix "Visita-planificada_03"
    let Visita_planificada_04 = _prefixId.prefix "Visita-planificada_04"
    let Visita_planificada_04bis = _prefixId.prefix "Visita-planificada_04bis"
    let Visita_planificada_05 = _prefixId.prefix "Visita-planificada_05"
    let Visita_planificada_05bis = _prefixId.prefix "Visita-planificada_05bis"
    let Visita_planificada_06 = _prefixId.prefix "Visita-planificada_06"
    let Visita_planificada_07 = _prefixId.prefix "Visita-planificada_07"
    let Visita_planificada_08 = _prefixId.prefix "Visita-planificada_08"
    let Visita_planificada_09 = _prefixId.prefix "Visita-planificada_09"
    let Visita_planificada_10 = _prefixId.prefix "Visita-planificada_10"
    /// <summary>
    ///   <para>rdfs:label : Visita turística</para>
    ///   <para>rdfs:comment : Una visita turística es cada una de las partes de las que se compone una ruta turística. Una visita turística tiene como objetivo uno y sólo un recurso de Zaragoza que forma parte del itinerario de la ruta. Las visitas turísticas están ordenadas temporalmente y el sistema procura minimizar la distancia entre unas y otras de acuerdo a las características del perfil.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Visita-turistica">turismo:Visita-turistica</a>
    /// </summary>
    let Visita_turistica = _prefixId.prefix "Visita-turistica"
    let Visitar_tiempo_corto = _prefixId.prefix "Visitar-tiempo-corto"
    let Visitar_tiempo_largo = _prefixId.prefix "Visitar-tiempo-largo"
    /// <summary>
    ///   <para>rdfs:label : Zona verde</para>
    ///   <para>rdfs:comment : Espacio verde en la ciudad de Zaragoza como puede ser parques, zonas ajardinadas, etc.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#Zona-verde">turismo:Zona-verde</a>
    /// </summary>
    let Zona_verde = _prefixId.prefix "Zona-verde"
    /// <summary>
    ///   <para>rdfs:label : Dirección Postal^^xsd:string</para>
    ///   <para>rdfs:comment : Guarda la dirección postal del recurso^^xsd:string</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#address">turismo:address</a>
    /// </summary>
    let address = _prefixId.prefix "address"
    /// <summary>
    ///   <para>rdfs:comment : Día de inicio de cada temporada del año. Se distinguen las temporadas de invierno y de verano. Es importante para los horarios de los monumentos.</para>
    ///   <para>rdfs:label : Fecha de inicio^^xsd:string</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#begining-date">turismo:begining-date</a>
    /// </summary>
    let begining_date = _prefixId.prefix "begining-date"
    /// <summary>
    ///   <para>rdfs:comment : Hora de cierre del horario de visita de un punto de interés. Por ejemplo, de un museo o de una iglesia.</para>
    ///   <para>rdfs:label : Horario de cierre</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#closing-time">turismo:closing-time</a>
    /// </summary>
    let closing_time = _prefixId.prefix "closing-time"
    /// <summary>
    ///   <para>rdfs:comment : Indica la fecha de cada uno de los días de visita que el turista va a estar en Zaragoza. También se aplica a Días Festivos.</para>
    ///   <para>rdfs:label : Fecha</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#date">turismo:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>rdfs:label : Fecha de finalización^^xsd:string</para>
    ///   <para>rdfs:comment : Día de finalización de las temporadas del año. Se contemplan temporada de verano y temporada de invierno.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#ending-date">turismo:ending-date</a>
    /// </summary>
    let ending_date = _prefixId.prefix "ending-date"
    /// <summary>
    ///   <para>rdfs:comment : Día de finalización de un determinado evento en la ciudad de Zaragoza.</para>
    ///   <para>rdfs:label : Día final^^xsd:string</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#final-date">turismo:final-date</a>
    /// </summary>
    let final_date = _prefixId.prefix "final-date"
    /// <summary>
    ///   <para>rdfs:comment : Esta relación entre recursos e intereses se obtiene a partir de un conjunto de reglas de negocio de turismo. Estas reglas permiten inferir a partir de las preferencias de los usuarios (edns:desire-towards, cúales son sus intereses turísticos. Lo mismo ocurre en el caso de los puntos de interés de la ciudad. Se deduce cuál es el interés potencial que tiene cada recurso para un turista. A partir de la descripción de los intereses de los perfiles y recursos, se calcula la relevancia o importancia subjetiva de cada recurso para un determinado perfil ("matchmaking").</para>
    ///   <para>rdfs:label : Tiene interés</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#has-interest">turismo:has-interest</a>
    /// </summary>
    let has_interest = _prefixId.prefix "has-interest"
    /// <summary>
    ///   <para>rdfs:comment : Representa el valor negativo de la propiedad "has-interest".</para>
    ///   <para>rdfs:label : No tiene interés</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#has-no-interest">turismo:has-no-interest</a>
    /// </summary>
    let has_no_interest = _prefixId.prefix "has-no-interest"
    /// <summary>
    ///   <para>rdfs:comment : Guarda el texto con el horario de visita del recurso.^^xsd:string</para>
    ///   <para>rdfs:label : Horario^^xsd:string</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#horario">turismo:horario</a>
    /// </summary>
    let horario = _prefixId.prefix "horario"
    /// <summary>
    ///   <para>rdfs:comment : Guarda el identificador del servicio de IDEZar</para>
    ///   <para>rdfs:label : Identificador de IDEZar^^xsd:string</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#id-idezar">turismo:id-idezar</a>
    /// </summary>
    let id_idezar = _prefixId.prefix "id-idezar"
    /// <summary>
    ///   <para>rdfs:label : Día inicial^^xsd:string</para>
    ///   <para>rdfs:comment : Día de inicio de un determinado evento de Zaragoza. Por ejemplo, un musical o una exposición. En el caso de eventos puntuales, tanto el día de inicio como el final será el mismo.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#initial-date">turismo:initial-date</a>
    /// </summary>
    let initial_date = _prefixId.prefix "initial-date"
    /// <summary>
    ///   <para>rdfs:label : Relevancia de los intereses turísticos^^xsd:string</para>
    ///   <para>rdfs:comment : Indica el grado de interés objetivo de una determinada preferencia. Por ejemplo, cuál es la relevancia del gusto por la arquitectura o la preferencia por ir de compras.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#interest-relevance">turismo:interest-relevance</a>
    /// </summary>
    let interest_relevance = _prefixId.prefix "interest-relevance"
    /// <summary>
    ///   <para>rdfs:label : Tiene interés en determinados recursos</para>
    ///   <para>rdfs:comment : Indica los recursos que el usuario quiere que figuren obligatoriamente en la ruta propuesta por el sistema</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#interest-towards">turismo:interest-towards</a>
    /// </summary>
    let interest_towards = _prefixId.prefix "interest-towards"
    /// <summary>
    ///   <para>rdfs:comment : Representa el valor de cada una de las preferencias de ruta. Estas preferencias actúan como restricciones para el planificador. Los valores de estos recursos modifican los parámetros iniciales del sistema de planificador.</para>
    ///   <para>rdfs:label : Relevancia de las preferencias de ruta^^xsd:string</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#necessity-relevance">turismo:necessity-relevance</a>
    /// </summary>
    let necessity_relevance = _prefixId.prefix "necessity-relevance"
    /// <summary>
    ///   <para>rdfs:comment : Representa el valor negativo de la propiedad "desire-towards". Indica las actividades que el turista no quiere realizar. Esta propiedad, como "desire-towards" servirán de entrada para el cálculo de los intereses de los perfiles de turista en las reglas de negocio de turismo de la aplicación.</para>
    ///   <para>rdfs:label : No tiene preferencia</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#not-desire-towards">turismo:not-desire-towards</a>
    /// </summary>
    let not_desire_towards = _prefixId.prefix "not-desire-towards"
    /// <summary>
    ///   <para>rdfs:label : No tiene interés en determinados recursos</para>
    ///   <para>rdfs:comment : Indica los recursos que el usuario no quiere que figuren en la ruta propuesta por el sistema</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#not-interest-towards">turismo:not-interest-towards</a>
    /// </summary>
    let not_interest_towards = _prefixId.prefix "not-interest-towards"
    /// <summary>
    ///   <para>rdfs:label : Horario de apertura</para>
    ///   <para>rdfs:comment : Hora de apertura del horario de visita de un punto de interés de la ciudad.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#opening-time">turismo:opening-time</a>
    /// </summary>
    let opening_time = _prefixId.prefix "opening-time"
    /// <summary>
    ///   <para>rdfs:comment : Es la relevancia o importancia objetiva de cada uno de los puntos de interés de la ciudad de Zaragoza.</para>
    ///   <para>rdfs:label : Relevancia de los Puntos de Interés</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#poi-relevance">turismo:poi-relevance</a>
    /// </summary>
    let poi_relevance = _prefixId.prefix "poi-relevance"
    /// <summary>
    ///   <para>rdfs:label : Duración de la visita</para>
    ///   <para>rdfs:comment : Tiempo estimado de duración de las visitas a los distintos monumentos y puntos de interés de la ciudad de Zaragoza. Se utiliza para el cálculo de la ruta.</para>
    ///   <a href="http://idi.fundacionctic.org/cruzar/turismo#visit-duration">turismo:visit-duration</a>
    /// </summary>
    let visit_duration = _prefixId.prefix "visit-duration"
