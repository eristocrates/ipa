namespace http.idi.fundacionctic.org.cruzar.turismo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module turismo =
    let _namespace_iri = Namespace_Iri turismo |> NamespaceIRI

    /// <summary>
    ///   <para>turismo:Accesibilidad-completa</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Accesibilidad-de-movilidad-reducida</para>
    ///
    /// labels<para>"Accessibilité complète"</para><para>"Voll Zugänglichkeit"</para><para>"Acessibilidade completa"</para><para>"Full accessibility"</para><para>"Accessibilità completa"</para><para>"Accesibilidad completa"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Accesibilidad-completa">http://idi.fundacionctic.org/cruzar/turismo#Accesibilidad-completa</seealso>
    let Accesibilidad_completa =
        Prefixed_Name(turismo, "Accesibilidad-completa") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Accesibilidad-con-acompanyante</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Accesibilidad-de-movilidad-reducida</para>
    ///
    /// labels<para>"Acessível com acompanhante"</para><para>"Accessible avec accompagnateur"</para><para>"Accessibile con addetto"</para><para>"Accesible con acompañante"</para><para>"Accessible with attendant"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Accesibilidad-con-acompanyante">http://idi.fundacionctic.org/cruzar/turismo#Accesibilidad-con-acompanyante</seealso>
    let Accesibilidad_con_acompanyante =
        Prefixed_Name(turismo, "Accesibilidad-con-acompanyante") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Accesibilidad-con-muletas</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Accesibilidad-de-movilidad-reducida</para>
    ///
    /// labels<para>"Acessível com muletas"</para><para>"Accesible con muletas"</para><para>"Accesible with crutches"</para><para>"Accesibile con le gruccie"</para><para>"Accessible avec des béquilles"</para><para>"Zugänglichkeit auf Krücken"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Accesibilidad-con-muletas">http://idi.fundacionctic.org/cruzar/turismo#Accesibilidad-con-muletas</seealso>
    let Accesibilidad_con_muletas =
        Prefixed_Name(turismo, "Accesibilidad-con-muletas") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Accesibilidad-de-movilidad-reducida</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"La accesibilidad es el grado con el que algo puede ser usado, visitado o accedido por todas las personas, independientemente de sus capacidades técnicas o físicas. En el caso de personas con movilidad reducida (que implique el uso de ayudas técnicas como muletas, sillas de ruedas, etc.), el grado de accesibilidad se mide de acuerdo a la facilidad de desplazamiento de los turistas por el entorno de los distintos recursos de la ciudad. La descripción del grado de accesibilidad de cada monumento se ha extraído de la base de datos de Monumentos."</para>
    /// labels<para>"Accesibilidad de movilidad reducida"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Accesibilidad-de-movilidad-reducida">http://idi.fundacionctic.org/cruzar/turismo#Accesibilidad-de-movilidad-reducida</seealso>
    let Accesibilidad_de_movilidad_reducida =
        Prefixed_Name(turismo, "Accesibilidad-de-movilidad-reducida") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Alojamiento</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Establecimiento de hostelería en Zaragoza en el que se proporciona alojamiento. La elección de un alojamiento determinado modifica el lugar de inicio de la ruta, tomando como punto de partida el alojamiento en el que se hospeda el usuario."</para>
    /// labels<para>"Alojamiento"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Alojamiento">http://idi.fundacionctic.org/cruzar/turismo#Alojamiento</seealso>
    let Alojamiento = Prefixed_Name(turismo, "Alojamiento") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Calificacion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Calificación oficial proporcionada por el Patronato de Turismo para los distintos restaurantes de la ciudad de Zaragoza."</para>
    /// labels<para>"Calificación"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Calificacion">http://idi.fundacionctic.org/cruzar/turismo#Calificacion</seealso>
    let Calificacion = Prefixed_Name(turismo, "Calificacion") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Caminar-velocidad-lenta</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-ruta</para>
    ///
    /// labels<para>"Velocità bassa di passeggio"</para><para>"Slow walking"</para><para>"Velocidade lenta de passeio"</para><para>"Velocidad de paseo lenta"</para><para>"Vitesse lente de marche"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Caminar-velocidad-lenta">http://idi.fundacionctic.org/cruzar/turismo#Caminar-velocidad-lenta</seealso>
    let Caminar_velocidad_lenta =
        Prefixed_Name(turismo, "Caminar-velocidad-lenta") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Caminar-velocidad-rapida</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-ruta</para>
    ///
    /// labels<para>"Velocidade ligeira de passeio"</para><para>"Velocidad de paseo rápida"</para><para>"Velocità leggera di passeggio"</para><para>"Fast walking"</para><para>"Vitesse légère de marche"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Caminar-velocidad-rapida">http://idi.fundacionctic.org/cruzar/turismo#Caminar-velocidad-rapida</seealso>
    let Caminar_velocidad_rapida =
        Prefixed_Name(turismo, "Caminar-velocidad-rapida") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Conocer-expo</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Conocer-expo">http://idi.fundacionctic.org/cruzar/turismo#Conocer-expo</seealso>
    let Conocer_expo = Prefixed_Name(turismo, "Conocer-expo") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Conocer-zaragoza-verde</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Conocer-zaragoza-verde">http://idi.fundacionctic.org/cruzar/turismo#Conocer-zaragoza-verde</seealso>
    let Conocer_zaragoza_verde =
        Prefixed_Name(turismo, "Conocer-zaragoza-verde") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Curiosear-por-calles</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Curiosear-por-calles">http://idi.fundacionctic.org/cruzar/turismo#Curiosear-por-calles</seealso>
    let Curiosear_por_calles =
        Prefixed_Name(turismo, "Curiosear-por-calles") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Dia-Festivo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Día no laborable relacionado con alguna fiesta local o nacional: Fiesta del Pilar, Navidad, etc. Estos días requieren un tratamiento independiente ya que los recursos turísticos tienen estos días un horario especial."</para>
    /// labels<para>"Día festivo"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Dia-Festivo">http://idi.fundacionctic.org/cruzar/turismo#Dia-Festivo</seealso>
    let Dia_Festivo = Prefixed_Name(turismo, "Dia-Festivo") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Dia-de-la-semana</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cada uno de los días de la semana"</para>
    /// labels<para>"Día de la semana"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Dia-de-la-semana">http://idi.fundacionctic.org/cruzar/turismo#Dia-de-la-semana</seealso>
    let Dia_de_la_semana = Prefixed_Name(turismo, "Dia-de-la-semana") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Dia-de-visita-turistica</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cada uno de los días de visita turística por la ciudad de Zaragoza que escoge el turista. Para cada uno de estos días, el sistema construirá una ruta específica atendiendo a su perfil y a la disponibilidad de los recursos de la ciudad."</para>
    /// labels<para>"Día de visita turística"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Dia-de-visita-turistica">http://idi.fundacionctic.org/cruzar/turismo#Dia-de-visita-turistica</seealso>
    let Dia_de_visita_turistica =
        Prefixed_Name(turismo, "Dia-de-visita-turistica") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Dia-de-visita-turistica_6</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Dia-de-visita-turistica</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Dia-de-visita-turistica_6">http://idi.fundacionctic.org/cruzar/turismo#Dia-de-visita-turistica_6</seealso>
    let Dia_de_visita_turistica_6 =
        Prefixed_Name(turismo, "Dia-de-visita-turistica_6") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Dia-de-visita-turistica_7</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Dia-de-visita-turistica</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Dia-de-visita-turistica_7">http://idi.fundacionctic.org/cruzar/turismo#Dia-de-visita-turistica_7</seealso>
    let Dia_de_visita_turistica_7 =
        Prefixed_Name(turismo, "Dia-de-visita-turistica_7") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Domingo</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Dia-de-la-semana</para>
    ///
    /// labels<para>"Domingo"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Domingo">http://idi.fundacionctic.org/cruzar/turismo#Domingo</seealso>
    let Domingo = Prefixed_Name(turismo, "Domingo") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Dos-tenedores</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Calificacion</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Dos-tenedores">http://idi.fundacionctic.org/cruzar/turismo#Dos-tenedores</seealso>
    let Dos_tenedores = Prefixed_Name(turismo, "Dos-tenedores") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Edificio-historico</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Edificio de carácter histórico con interés cultural o arquitectónico."</para>
    /// labels<para>"Edificio histórico"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Edificio-historico">http://idi.fundacionctic.org/cruzar/turismo#Edificio-historico</seealso>
    let Edificio_historico =
        Prefixed_Name(turismo, "Edificio-historico") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Edificio-religioso</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Edificio de carácter religioso, como pueden ser iglesias, conventos, catedrales, etc."</para>
    /// labels<para>"Edificio religioso"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Edificio-religioso">http://idi.fundacionctic.org/cruzar/turismo#Edificio-religioso</seealso>
    let Edificio_religioso =
        Prefixed_Name(turismo, "Edificio-religioso") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Entorno-natural</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Zona de verde de excepcional singularidad debido a su paisaje, protección medioambiental e interés turístico."</para>
    /// labels<para>"Entorno natural"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Entorno-natural">http://idi.fundacionctic.org/cruzar/turismo#Entorno-natural</seealso>
    let Entorno_natural = Prefixed_Name(turismo, "Entorno-natural") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Escultura</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Fuentes y estatuas"</para>
    /// labels<para>"Escultura"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Escultura">http://idi.fundacionctic.org/cruzar/turismo#Escultura</seealso>
    let Escultura = Prefixed_Name(turismo, "Escultura") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Estilo-artistico</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"El estilo es el conjunto de características que individualizan la tendencia artística de una época: barroco, mudéjar, renacentista, etc. La descripción de los estilos de cada monumento se ha extraído de la base de datos de Monumentos."</para>
    /// labels<para>"Estilo artístico"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Estilo-artistico">http://idi.fundacionctic.org/cruzar/turismo#Estilo-artistico</seealso>
    let Estilo_artistico = Prefixed_Name(turismo, "Estilo-artistico") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Estilo-barroco</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Estilo-artistico</para>
    ///
    /// labels<para>"Estilo barroco"</para><para>"Baroque style"</para><para>"Style baroque"</para><para>"Stile barocco"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Estilo-barroco">http://idi.fundacionctic.org/cruzar/turismo#Estilo-barroco</seealso>
    let Estilo_barroco = Prefixed_Name(turismo, "Estilo-barroco") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Estilo-contemporaneo</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Estilo-artistico</para>
    ///
    /// labels<para>"Contemporary style"</para><para>"Estilo contemporâneo"</para><para>"Estilo contemporáneo"</para><para>"Style contemporain"</para><para>"Stile contemporaneo"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Estilo-contemporaneo">http://idi.fundacionctic.org/cruzar/turismo#Estilo-contemporaneo</seealso>
    let Estilo_contemporaneo =
        Prefixed_Name(turismo, "Estilo-contemporaneo") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Estilo-gotico</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Estilo-artistico</para>
    ///
    /// labels<para>"Gothic style"</para><para>"Estilo gótico"</para><para>"Style gothique"</para><para>"Stile gotico"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Estilo-gotico">http://idi.fundacionctic.org/cruzar/turismo#Estilo-gotico</seealso>
    let Estilo_gotico = Prefixed_Name(turismo, "Estilo-gotico") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Estilo-modernista</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Estilo-artistico</para>
    ///
    /// labels<para>"Estilo modernista"</para><para>"Modernist style"</para><para>"Stile modernista"</para><para>"Style moderniste"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Estilo-modernista">http://idi.fundacionctic.org/cruzar/turismo#Estilo-modernista</seealso>
    let Estilo_modernista = Prefixed_Name(turismo, "Estilo-modernista") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Estilo-mudejar</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Estilo-artistico</para>
    ///
    /// labels<para>"Mudéjar style"</para><para>"Style mudéjar"</para><para>"Estilo mudéjar"</para><para>"Stile mudéjar"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Estilo-mudejar">http://idi.fundacionctic.org/cruzar/turismo#Estilo-mudejar</seealso>
    let Estilo_mudejar = Prefixed_Name(turismo, "Estilo-mudejar") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Estilo-neoclasico</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Estilo-artistico</para>
    ///
    /// labels<para>"Neoclassical style"</para><para>"Style néoclassique"</para><para>"Estilo neoclássico"</para><para>"Stile neoclassico"</para><para>"Estilo neoclásico"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Estilo-neoclasico">http://idi.fundacionctic.org/cruzar/turismo#Estilo-neoclasico</seealso>
    let Estilo_neoclasico = Prefixed_Name(turismo, "Estilo-neoclasico") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Estilo-renacentista</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Estilo-artistico</para>
    ///
    /// labels<para>"Renaissance style"</para><para>"Estilo renascentista"</para><para>"Style de la Renaissance"</para><para>"Stile del Renascimento"</para><para>"Estilo renacentista"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Estilo-renacentista">http://idi.fundacionctic.org/cruzar/turismo#Estilo-renacentista</seealso>
    let Estilo_renacentista =
        Prefixed_Name(turismo, "Estilo-renacentista") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Estilo-romano</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Estilo-artistico</para>
    ///
    /// labels<para>"Style romain"</para><para>"Estilo romano"</para><para>"Stile romano"</para><para>"Roman style"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Estilo-romano">http://idi.fundacionctic.org/cruzar/turismo#Estilo-romano</seealso>
    let Estilo_romano = Prefixed_Name(turismo, "Estilo-romano") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Evento-de-zaragoza</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Esta clase conceptualiza la Agenda de actividades de la ciudad de Zaragoza. Cada uno de los eventos de la Agenda son instancias de este concepto. Los eventos se utilizan como sugerencias complementarias a la ruta definida por el sistema."</para>
    /// labels<para>"Evento de Zaragoza"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Evento-de-zaragoza">http://idi.fundacionctic.org/cruzar/turismo#Evento-de-zaragoza</seealso>
    let Evento_de_zaragoza =
        Prefixed_Name(turismo, "Evento-de-zaragoza") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Fortaleza</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Construcción fortificada como murallas o torreones de defensa."</para>
    /// labels<para>"Fortaleza"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Fortaleza">http://idi.fundacionctic.org/cruzar/turismo#Fortaleza</seealso>
    let Fortaleza = Prefixed_Name(turismo, "Fortaleza") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Grupo-con-ninyos</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Grupo-de-viaje</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Grupo-con-ninyos">http://idi.fundacionctic.org/cruzar/turismo#Grupo-con-ninyos</seealso>
    let Grupo_con_ninyos = Prefixed_Name(turismo, "Grupo-con-ninyos") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Grupo-con-personas-con-discapacidad</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Grupo-de-viaje</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Grupo-con-personas-con-discapacidad">http://idi.fundacionctic.org/cruzar/turismo#Grupo-con-personas-con-discapacidad</seealso>
    let Grupo_con_personas_con_discapacidad =
        Prefixed_Name(turismo, "Grupo-con-personas-con-discapacidad") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Grupo-de-pareja</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Grupo-de-viaje</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Grupo-de-pareja">http://idi.fundacionctic.org/cruzar/turismo#Grupo-de-pareja</seealso>
    let Grupo_de_pareja = Prefixed_Name(turismo, "Grupo-de-pareja") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Grupo-de-varias-personas</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Grupo-de-viaje</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Grupo-de-varias-personas">http://idi.fundacionctic.org/cruzar/turismo#Grupo-de-varias-personas</seealso>
    let Grupo_de_varias_personas =
        Prefixed_Name(turismo, "Grupo-de-varias-personas") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Grupo-de-viaje</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Colectivo de personas que realizan una visita turística a la ciudad de Zaragoza, y para los que el sistema calculará una ruta contextualizada."</para>
    /// labels<para>"Grupo de viaje"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Grupo-de-viaje">http://idi.fundacionctic.org/cruzar/turismo#Grupo-de-viaje</seealso>
    let Grupo_de_viaje = Prefixed_Name(turismo, "Grupo-de-viaje") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Grupo-individual</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Grupo-de-viaje</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Grupo-individual">http://idi.fundacionctic.org/cruzar/turismo#Grupo-individual</seealso>
    let Grupo_individual = Prefixed_Name(turismo, "Grupo-individual") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Horario-de-visita</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Horarios de visita de los recursos turísticos: museos, edificios, iglesias, etc. Para construir el horario de visita, se utiliza el horario de apertura y cierre del recurso, el día de la semana y la temporada."</para>
    /// labels<para>"Horario de visita"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Horario-de-visita">http://idi.fundacionctic.org/cruzar/turismo#Horario-de-visita</seealso>
    let Horario_de_visita = Prefixed_Name(turismo, "Horario-de-visita") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Horario-de-visita_11</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Horario-de-visita</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Horario-de-visita_11">http://idi.fundacionctic.org/cruzar/turismo#Horario-de-visita_11</seealso>
    let Horario_de_visita_11 =
        Prefixed_Name(turismo, "Horario-de-visita_11") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Horario-de-visita_7</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Horario-de-visita</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Horario-de-visita_7">http://idi.fundacionctic.org/cruzar/turismo#Horario-de-visita_7</seealso>
    let Horario_de_visita_7 =
        Prefixed_Name(turismo, "Horario-de-visita_7") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Horario-de-visita_8</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Horario-de-visita</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Horario-de-visita_8">http://idi.fundacionctic.org/cruzar/turismo#Horario-de-visita_8</seealso>
    let Horario_de_visita_8 =
        Prefixed_Name(turismo, "Horario-de-visita_8") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Interes-en-accesibilidad</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Interes-turistico</para>
    ///
    /// labels<para>"Interesse por monumentos acessíveis"</para><para>"Interesse per i monumenti accessibili"</para><para>"Intérêt pour les monuments accessibles"</para><para>"Interest in accessible monuments"</para><para>"Interés en monumentos con medidas de accesibilidad"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-accesibilidad">http://idi.fundacionctic.org/cruzar/turismo#Interes-en-accesibilidad</seealso>
    let Interes_en_accesibilidad =
        Prefixed_Name(turismo, "Interes-en-accesibilidad") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Interes-en-arquitectura</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Interes-turistico</para>
    ///
    /// labels<para>"Interesse pela arquitectura"</para><para>"Interesse per l'architettura"</para><para>"Interés en arquitectura urbana"</para><para>"Intérêt pour l'architecture"</para><para>"Interest in architecture"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-arquitectura">http://idi.fundacionctic.org/cruzar/turismo#Interes-en-arquitectura</seealso>
    let Interes_en_arquitectura =
        Prefixed_Name(turismo, "Interes-en-arquitectura") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Interes-en-arte</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Interes-turistico</para>
    ///
    /// labels<para>"Interesse pela arte"</para><para>"Interés en arte de la ciudad"</para><para>"Interesse per l'arte"</para><para>"Intérêt pour l'art"</para><para>"Interest in art"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-arte">http://idi.fundacionctic.org/cruzar/turismo#Interes-en-arte</seealso>
    let Interes_en_arte = Prefixed_Name(turismo, "Interes-en-arte") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Interes-en-compras</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Interes-turistico</para>
    ///
    /// labels<para>"Intérêt pour faire du shopping et faire du lèche-vitrines"</para><para>"Interest in shopping"</para><para>"Interés en ir de compras"</para><para>"Interesse per i acquisti e per guardare le vetrine dei negozi"</para><para>"Interesse pelas compras e por ver vitrines"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-compras">http://idi.fundacionctic.org/cruzar/turismo#Interes-en-compras</seealso>
    let Interes_en_compras =
        Prefixed_Name(turismo, "Interes-en-compras") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Interes-en-edificio-historico</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Interes-turistico</para>
    ///
    /// labels<para>"Interesse per i edifici storici"</para><para>"Interest in historical buildings"</para><para>"Intérêt pour les bâtiments historiques"</para><para>"Interés en edificios historicos"</para><para>"Interesse pelos edifícios históricos"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-edificio-historico">http://idi.fundacionctic.org/cruzar/turismo#Interes-en-edificio-historico</seealso>
    let Interes_en_edificio_historico =
        Prefixed_Name(turismo, "Interes-en-edificio-historico") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Interes-en-edificio-religioso</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Interes-turistico</para>
    ///
    /// labels<para>"Intérêt pour les bâtiments religieux"</para><para>"Interesse per i edifici religiosi"</para><para>"Interest in religious buildings"</para><para>"Interés por los edificios religiosos"</para><para>"Interesse pelos edifícios religiosos"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-edificio-religioso">http://idi.fundacionctic.org/cruzar/turismo#Interes-en-edificio-religioso</seealso>
    let Interes_en_edificio_religioso =
        Prefixed_Name(turismo, "Interes-en-edificio-religioso") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Interes-en-entorno-natural</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Interes-turistico</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Intérêt pour les espaces et les environements naturaux"</para><para>"Interest in natural spaces and environment"</para><para>"Interesse per gli spazi e ambienti naturali"</para><para>"Interesse por áreas e ambientes naturais"</para><para>"Interés en espacios y entornos naturales"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-entorno-natural">http://idi.fundacionctic.org/cruzar/turismo#Interes-en-entorno-natural</seealso>
    let Interes_en_entorno_natural =
        Prefixed_Name(turismo, "Interes-en-entorno-natural") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Interes-en-escultura</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Interes-turistico</para>
    ///
    /// labels<para>"Interés en esculturas"</para><para>"Interest in sculpture"</para><para>"Interesse pela escultura"</para><para>"Interesse per la scultura"</para><para>"Intérêt pour la sculpture"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-escultura">http://idi.fundacionctic.org/cruzar/turismo#Interes-en-escultura</seealso>
    let Interes_en_escultura =
        Prefixed_Name(turismo, "Interes-en-escultura") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Interes-en-estilo-barroco</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Interes-turistico</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Interesse per lo stile barocco"</para><para>"Interest in baroque style"</para><para>"Interés en estilo barroco"</para><para>"Intérêt pour le style baroque"</para><para>"Interesse pelo estilo barroco"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-barroco">http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-barroco</seealso>
    let Interes_en_estilo_barroco =
        Prefixed_Name(turismo, "Interes-en-estilo-barroco") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Interes-en-estilo-contemporaneo</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Interes-turistico</para>
    ///
    /// labels<para>"Interesse per lo stile contemporaneo"</para><para>"Intérêt pour le style contemporain"</para><para>"Interest in contemporary style"</para><para>"Interés en estilo contemporáneo"</para><para>"Interesse pelo estilo contemporâneo"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-contemporaneo">http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-contemporaneo</seealso>
    let Interes_en_estilo_contemporaneo =
        Prefixed_Name(turismo, "Interes-en-estilo-contemporaneo") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Interes-en-estilo-gotico</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Interes-turistico</para>
    ///
    /// labels<para>"Interés en estilo gótico"</para><para>"Interesse per lo stile gotico"</para><para>"Intérêt pour le style gothique"</para><para>"Interest in gothic style"</para><para>"Interesse pelo estilo gótico"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-gotico">http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-gotico</seealso>
    let Interes_en_estilo_gotico =
        Prefixed_Name(turismo, "Interes-en-estilo-gotico") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Interes-en-estilo-modernista</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Interes-turistico</para>
    ///
    /// labels<para>"Interest in modernistic style"</para><para>"Intérêt pour le style moderniste"</para><para>"Interesse pelo estilo modernista"</para><para>"Interés en estilo modernista"</para><para>"Interesse per lo stile modernista"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-modernista">http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-modernista</seealso>
    let Interes_en_estilo_modernista =
        Prefixed_Name(turismo, "Interes-en-estilo-modernista") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Interes-en-estilo-mudejar</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Interes-turistico</para>
    ///
    /// labels<para>"Interesse pelo estilo mudéjar"</para><para>"Interés en estilo mudéjar"</para><para>"Interest in mudéjar style"</para><para>"Interesse per lo stile mudéjar"</para><para>"Intérêt pour le style mudéjar"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-mudejar">http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-mudejar</seealso>
    let Interes_en_estilo_mudejar =
        Prefixed_Name(turismo, "Interes-en-estilo-mudejar") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Interes-en-estilo-neoclasico</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Interes-turistico</para>
    ///
    /// labels<para>"Intérêt pour le style néoclassique"</para><para>"Interesse pelo estilo neoclássico"</para><para>"Interesse per lo stile neoclassico"</para><para>"Interés en estilo neoclásico"</para><para>"Interest in neoclassical style"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-neoclasico">http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-neoclasico</seealso>
    let Interes_en_estilo_neoclasico =
        Prefixed_Name(turismo, "Interes-en-estilo-neoclasico") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Interes-en-estilo-renacentista</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Interes-turistico</para>
    ///
    /// labels<para>"Intérêt pour le style de la Renaissance"</para><para>"Interés en estilo renacentista"</para><para>"Interesse per lo stile del Renascimento"</para><para>"Interesse pelo estilo renascentista"</para><para>"Interest in Renaissance style"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-renacentista">http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-renacentista</seealso>
    let Interes_en_estilo_renacentista =
        Prefixed_Name(turismo, "Interes-en-estilo-renacentista") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Interes-en-estilo-romano</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Interes-turistico</para>
    ///
    /// labels<para>"Intérêt pour le style romain"</para><para>"Interesse per lo stile romano"</para><para>"Interesse pelo estilo romano"</para><para>"Interés en estilo romano"</para><para>"Interest in roman style"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-romano">http://idi.fundacionctic.org/cruzar/turismo#Interes-en-estilo-romano</seealso>
    let Interes_en_estilo_romano =
        Prefixed_Name(turismo, "Interes-en-estilo-romano") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Interes-en-expo</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Interes-turistico</para>
    ///
    /// labels<para>"Intérêt pour l'EXPO 2008"</para><para>"Interesse per l'EXPO 2008"</para><para>"Interest in EXPO 2008"</para><para>"Interesse pela EXPO 2008"</para><para>"Interés en conocer la EXPO 2008"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-expo">http://idi.fundacionctic.org/cruzar/turismo#Interes-en-expo</seealso>
    let Interes_en_expo = Prefixed_Name(turismo, "Interes-en-expo") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Interes-en-fortalezas</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Interes-turistico</para>
    ///
    /// labels<para>"Interesse per le fortezze"</para><para>"Intérêt pour les forteresses"</para><para>"Interest in fortress"</para><para>"Interesse por fortalezas"</para><para>"Interés en edificios fortificados"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-fortalezas">http://idi.fundacionctic.org/cruzar/turismo#Interes-en-fortalezas</seealso>
    let Interes_en_fortalezas =
        Prefixed_Name(turismo, "Interes-en-fortalezas") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Interes-en-museos</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Interes-turistico</para>
    ///
    /// labels<para>"Intérêt pour les musées"</para><para>"Interesse pelos museus"</para><para>"Interés en museos"</para><para>"Interest in museums"</para><para>"Interesse per i musei"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-museos">http://idi.fundacionctic.org/cruzar/turismo#Interes-en-museos</seealso>
    let Interes_en_museos = Prefixed_Name(turismo, "Interes-en-museos") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Interes-en-palacios</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Interes-turistico</para>
    ///
    /// labels<para>"Interest in palaces"</para><para>"Interés en palacios"</para><para>"Interesse pelos paços"</para><para>"Intérêt pour les palais"</para><para>"Interesse per i palazzi"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-palacios">http://idi.fundacionctic.org/cruzar/turismo#Interes-en-palacios</seealso>
    let Interes_en_palacios =
        Prefixed_Name(turismo, "Interes-en-palacios") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Interes-en-zona-verde</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Interes-turistico</para>
    ///
    /// labels<para>"Interés en zonas verdes (parques, jardines, etc.)"</para><para>"Intérêt pour les espaces verts (parcs, jardins, etc)"</para><para>"Interest in green spaces (parks, public gardens, etc)"</para><para>"Interesse per gli spazi verdi (giardini, parchi, etc)"</para><para>"Interesse pelas áreas verdes (parques, jardins, etc)"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Interes-en-zona-verde">http://idi.fundacionctic.org/cruzar/turismo#Interes-en-zona-verde</seealso>
    let Interes_en_zona_verde =
        Prefixed_Name(turismo, "Interes-en-zona-verde") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Interes-turistico</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"El interés turístico es el grado de relevancia que tiene un recurso de la ciudad de Zaragoza para un determinado perfil de turista. Por ejemplo, si a un turista le gusta el arte barroco, el turista tendrá interés en el arte barroco y, por tanto, en cualquier monumento que se englobe dentro de este estilo. Los intereses de los perfiles se calculan a partir de las preferencias declaradas por el usuario y utilizando las reglas de negocio."</para>
    /// labels<para>"Interés turístico"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Interes-turistico">http://idi.fundacionctic.org/cruzar/turismo#Interes-turistico</seealso>
    let Interes_turistico = Prefixed_Name(turismo, "Interes-turistico") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Ir-de-compras</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Ir-de-compras">http://idi.fundacionctic.org/cruzar/turismo#Ir-de-compras</seealso>
    let Ir_de_compras = Prefixed_Name(turismo, "Ir-de-compras") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Jueves</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Dia-de-la-semana</para>
    ///
    /// labels<para>"Jueves"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Jueves">http://idi.fundacionctic.org/cruzar/turismo#Jueves</seealso>
    let Jueves = Prefixed_Name(turismo, "Jueves") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Lunes</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Dia-de-la-semana</para>
    ///
    /// labels<para>"Lunes"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Lunes">http://idi.fundacionctic.org/cruzar/turismo#Lunes</seealso>
    let Lunes = Prefixed_Name(turismo, "Lunes") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Martes</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Dia-de-la-semana</para>
    ///
    /// labels<para>"Martes"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Martes">http://idi.fundacionctic.org/cruzar/turismo#Martes</seealso>
    let Martes = Prefixed_Name(turismo, "Martes") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Mercado</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sitio público destinado a vender o comprar productos. Los mercados se ofrecen como sugerencias a la ruta en base al perfil del turista y sólo se ofrecen en los días señalados."</para>
    /// labels<para>"Mercado"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Mercado">http://idi.fundacionctic.org/cruzar/turismo#Mercado</seealso>
    let Mercado = Prefixed_Name(turismo, "Mercado") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Miercoles</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Dia-de-la-semana</para>
    ///
    /// labels<para>"Miércoles"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Miercoles">http://idi.fundacionctic.org/cruzar/turismo#Miercoles</seealso>
    let Miercoles = Prefixed_Name(turismo, "Miercoles") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Monumento</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Construcción que posee valor artístico, arqueológico, histórico, etc. Las bases de datos de Monumentos y el Catálogo de Edificios de la Ciudad de Zaragoza se han mapeado a este concepto. Se ha subclasificado este concepto para conseguir una organización más rica de los monumentos. Esta información es usada por el sistema para configurar la ruta de manera más acorde a las preferencias del usuario mediante las reglas de negocio. Por ejemplo, si el usuario viaja con niños, el sistema por defecto no le ofrecerá museos en la ruta."</para>
    /// labels<para>"Monumento"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Monumento">http://idi.fundacionctic.org/cruzar/turismo#Monumento</seealso>
    let Monumento = Prefixed_Name(turismo, "Monumento") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Museo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lugar de Zaragoza en que se exponen colecciones de objetos artísticos de distinto estilo y época: romana, mudéjar, etc."</para>
    /// labels<para>"Museo"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Museo">http://idi.fundacionctic.org/cruzar/turismo#Museo</seealso>
    let Museo = Prefixed_Name(turismo, "Museo") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Palacio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Edificio de gran transcendencia artística y de relevancia social ya que nacen como lugar de residencia de personajes importanes: palacio ducal, arzobispal."</para>
    /// labels<para>"Palacio"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Palacio">http://idi.fundacionctic.org/cruzar/turismo#Palacio</seealso>
    let Palacio = Prefixed_Name(turismo, "Palacio") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Pasear</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Pasear">http://idi.fundacionctic.org/cruzar/turismo#Pasear</seealso>
    let Pasear = Prefixed_Name(turismo, "Pasear") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Perfil-de-prueba1</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Perfil-de-turista</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Perfil-de-prueba1">http://idi.fundacionctic.org/cruzar/turismo#Perfil-de-prueba1</seealso>
    let Perfil_de_prueba1 = Prefixed_Name(turismo, "Perfil-de-prueba1") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Perfil-de-prueba2</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Perfil-de-turista</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Perfil-de-prueba2">http://idi.fundacionctic.org/cruzar/turismo#Perfil-de-prueba2</seealso>
    let Perfil_de_prueba2 = Prefixed_Name(turismo, "Perfil-de-prueba2") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Perfil-de-turista</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"El perfil de turista es el conjunto de rasgos particulares que caracterizan a un turista en particular para el cual se va a calcular la ruta. El perfil de turista contempla desde los días de visita a la ciudad de Zaragoza (único dato obligatorio), el tipo de viaje, si es un viaje en grupo, los intereses y las preferencias turísticas del perfil."</para>
    /// labels<para>"Perfil de turista"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Perfil-de-turista">http://idi.fundacionctic.org/cruzar/turismo#Perfil-de-turista</seealso>
    let Perfil_de_turista = Prefixed_Name(turismo, "Perfil-de-turista") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Preferencia-de-ruta</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Una preferencia de ruta es una constricción contextual para el cálculo dinámico de la ruta. Los perfiles de turista pueden requerir configuraciones particulares de los parámetros que afectan a la confección de la ruta, por ejemplo, que la velocidad de desplazamiento se vea afectada por características de movilidad de los turistas. Las preferencias de ruta para cada perfil se calculan mediante las reglas de negocio: duración de la visita y velocidad de desplazamiento."</para>
    /// labels<para>"Preferencia de ruta"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Preferencia-de-ruta">http://idi.fundacionctic.org/cruzar/turismo#Preferencia-de-ruta</seealso>
    let Preferencia_de_ruta =
        Prefixed_Name(turismo, "Preferencia-de-ruta") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Actividades que el turista puede estar interesado en realizar como visitar museos, pasear, ir de compras, etc."</para>
    /// labels<para>"Preferencia de usuario"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Preferencia-de-usuario">http://idi.fundacionctic.org/cruzar/turismo#Preferencia-de-usuario</seealso>
    let Preferencia_de_usuario =
        Prefixed_Name(turismo, "Preferencia-de-usuario") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Recurso-comercial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Recurso de interés comercial que ofrece la ciudad de Zaragoza. La información tanto de los mercados como de los sectores se ha extraído directamente de la página web municipal del Ayuntamiento. Los recursos comerciales se muestran como sugerencias en la ruta, y siempre bajo demanda del usuario (selección de la casilla "Me gusta ir de compras")."</para>
    /// labels<para>"Recurso comercial"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Recurso-comercial">http://idi.fundacionctic.org/cruzar/turismo#Recurso-comercial</seealso>
    let Recurso_comercial = Prefixed_Name(turismo, "Recurso-comercial") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Recurso-de-zaragoza</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Recursos de interés comercial, turístico o de hostelería, que ofrece la ciudad de Zaragoza."</para>
    /// labels<para>"Recurso de Zaragoza"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Recurso-de-zaragoza">http://idi.fundacionctic.org/cruzar/turismo#Recurso-de-zaragoza</seealso>
    let Recurso_de_zaragoza =
        Prefixed_Name(turismo, "Recurso-de-zaragoza") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Recurso-hostelero</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Recurso de interés hostelero que ofrece la ciudad de Zaragoza. Las bases de datos de restaurantes y alojamientos se han mapeado a sus subclases."</para>
    /// labels<para>"Recurso hostelero"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Recurso-hostelero">http://idi.fundacionctic.org/cruzar/turismo#Recurso-hostelero</seealso>
    let Recurso_hostelero = Prefixed_Name(turismo, "Recurso-hostelero") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Recurso-turistico</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Recurso de interés turístico que ofrece la ciudad de Zaragoza."</para>
    /// labels<para>"Recurso turístico"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Recurso-turistico">http://idi.fundacionctic.org/cruzar/turismo#Recurso-turistico</seealso>
    let Recurso_turistico = Prefixed_Name(turismo, "Recurso-turistico") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Restaurante</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Establecimiento público donde se sirven comidas. Los restaurantes se sugieren al usuario a la hora de la comida y de la cena. Se sugieren 5 restaurantes por cada slot de tiempo utilizando dos criterios: proximidad con el último POI de la ruta turística y calificación gastronómica."</para>
    /// labels<para>"Restaurante"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Restaurante">http://idi.fundacionctic.org/cruzar/turismo#Restaurante</seealso>
    let Restaurante = Prefixed_Name(turismo, "Restaurante") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Ruta-turistica</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Es el itinerario calculado dinámicamente por el sistema. Para cada día de estancia del turista se confecciona una ruta específica que consiste en una serie de visitas a determinados recursos turísticos de la ciudad de Zaragoza. La ruta se adapta además a las características del perfil del usuario como las preferencias, las limitaciones de movilidad, el alojamiento, los horarios de visitas de los monumentos, etc. El sistema no sólo genera un itinerario en el tiempo y espacio correspondientes, sino que además proporciona una serie de sugerencias para el turista que complementan su visita a la ciudad: eventos de interés, restaurantes cercanos y sectores comerciales."</para>
    /// labels<para>"Ruta turística"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Ruta-turistica">http://idi.fundacionctic.org/cruzar/turismo#Ruta-turistica</seealso>
    let Ruta_turistica = Prefixed_Name(turismo, "Ruta-turistica") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Ruta-turistica_propuesta1</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Ruta-turistica</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Ruta-turistica_propuesta1">http://idi.fundacionctic.org/cruzar/turismo#Ruta-turistica_propuesta1</seealso>
    let Ruta_turistica_propuesta1 =
        Prefixed_Name(turismo, "Ruta-turistica_propuesta1") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Ruta-turistica_propuesta2</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Ruta-turistica</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Ruta-turistica_propuesta2">http://idi.fundacionctic.org/cruzar/turismo#Ruta-turistica_propuesta2</seealso>
    let Ruta_turistica_propuesta2 =
        Prefixed_Name(turismo, "Ruta-turistica_propuesta2") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Sabado</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Dia-de-la-semana</para>
    ///
    /// labels<para>"Sábado"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Sabado">http://idi.fundacionctic.org/cruzar/turismo#Sabado</seealso>
    let Sabado = Prefixed_Name(turismo, "Sabado") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Salir-de-marcha</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Salir-de-marcha">http://idi.fundacionctic.org/cruzar/turismo#Salir-de-marcha</seealso>
    let Salir_de_marcha = Prefixed_Name(turismo, "Salir-de-marcha") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Sector-comercial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Un sector es un conjunto de negocios que se engloban en un área diferenciada de la ciudad de Zaragoza."</para>
    /// labels<para>"Sector comercial"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Sector-comercial">http://idi.fundacionctic.org/cruzar/turismo#Sector-comercial</seealso>
    let Sector_comercial = Prefixed_Name(turismo, "Sector-comercial") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Sin-gluten</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Calificacion</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Sin-gluten">http://idi.fundacionctic.org/cruzar/turismo#Sin-gluten</seealso>
    let Sin_gluten = Prefixed_Name(turismo, "Sin-gluten") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Temporada</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Espacio temporal de varios meses. A nivel turístico, el año se divide en temporada de verano y temporada de invierno. La temporada influye en los horarios de apertura y cierre de los recursos turísticos: museos, iglesias, etc. El mismo monumento, pongamos por caso, la Basílica del
    /// Pilar, no tiene el mismo horario de visita en la temporada de invierno, que en la temporada de verano. En esta ontología, se siguen los siguientes
    /// criterios: 1) Temporada de invierno: desde el 9 de octubre hasta el 30 de abril; 2) Temporada de verano: desde el 1 de mayo hasta el 8 de octubre."</para>
    /// labels<para>"Temporada"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Temporada">http://idi.fundacionctic.org/cruzar/turismo#Temporada</seealso>
    let Temporada = Prefixed_Name(turismo, "Temporada") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Temporada-de-invierno</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Temporada</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Temporada-de-invierno">http://idi.fundacionctic.org/cruzar/turismo#Temporada-de-invierno</seealso>
    let Temporada_de_invierno =
        Prefixed_Name(turismo, "Temporada-de-invierno") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Temporada-de-verano</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Temporada</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Temporada-de-verano">http://idi.fundacionctic.org/cruzar/turismo#Temporada-de-verano</seealso>
    let Temporada_de_verano =
        Prefixed_Name(turismo, "Temporada-de-verano") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Tres-tenedores</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Calificacion</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Tres-tenedores">http://idi.fundacionctic.org/cruzar/turismo#Tres-tenedores</seealso>
    let Tres_tenedores = Prefixed_Name(turismo, "Tres-tenedores") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Un-tenedor</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Calificacion</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Un-tenedor">http://idi.fundacionctic.org/cruzar/turismo#Un-tenedor</seealso>
    let Un_tenedor = Prefixed_Name(turismo, "Un-tenedor") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Ver-arquitectura</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Ver-arquitectura">http://idi.fundacionctic.org/cruzar/turismo#Ver-arquitectura</seealso>
    let Ver_arquitectura = Prefixed_Name(turismo, "Ver-arquitectura") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Ver-arte</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Ver-arte">http://idi.fundacionctic.org/cruzar/turismo#Ver-arte</seealso>
    let Ver_arte = Prefixed_Name(turismo, "Ver-arte") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Ver-edificio-historico</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Ver-edificio-historico">http://idi.fundacionctic.org/cruzar/turismo#Ver-edificio-historico</seealso>
    let Ver_edificio_historico =
        Prefixed_Name(turismo, "Ver-edificio-historico") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Ver-edificio-religioso</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Ver-edificio-religioso">http://idi.fundacionctic.org/cruzar/turismo#Ver-edificio-religioso</seealso>
    let Ver_edificio_religioso =
        Prefixed_Name(turismo, "Ver-edificio-religioso") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Ver-escultura</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Ver-escultura">http://idi.fundacionctic.org/cruzar/turismo#Ver-escultura</seealso>
    let Ver_escultura = Prefixed_Name(turismo, "Ver-escultura") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Ver-estilo-barroco</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-barroco">http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-barroco</seealso>
    let Ver_estilo_barroco =
        Prefixed_Name(turismo, "Ver-estilo-barroco") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Ver-estilo-contemporaneo</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-contemporaneo">http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-contemporaneo</seealso>
    let Ver_estilo_contemporaneo =
        Prefixed_Name(turismo, "Ver-estilo-contemporaneo") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Ver-estilo-gotico</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-gotico">http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-gotico</seealso>
    let Ver_estilo_gotico = Prefixed_Name(turismo, "Ver-estilo-gotico") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Ver-estilo-modernista</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-modernista">http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-modernista</seealso>
    let Ver_estilo_modernista =
        Prefixed_Name(turismo, "Ver-estilo-modernista") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Ver-estilo-mudejar</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-mudejar">http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-mudejar</seealso>
    let Ver_estilo_mudejar =
        Prefixed_Name(turismo, "Ver-estilo-mudejar") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Ver-estilo-neoclasico</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-neoclasico">http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-neoclasico</seealso>
    let Ver_estilo_neoclasico =
        Prefixed_Name(turismo, "Ver-estilo-neoclasico") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Ver-estilo-renacentista</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-renacentista">http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-renacentista</seealso>
    let Ver_estilo_renacentista =
        Prefixed_Name(turismo, "Ver-estilo-renacentista") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Ver-estilo-romano</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-romano">http://idi.fundacionctic.org/cruzar/turismo#Ver-estilo-romano</seealso>
    let Ver_estilo_romano = Prefixed_Name(turismo, "Ver-estilo-romano") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Ver-fortaleza</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Ver-fortaleza">http://idi.fundacionctic.org/cruzar/turismo#Ver-fortaleza</seealso>
    let Ver_fortaleza = Prefixed_Name(turismo, "Ver-fortaleza") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Ver-museo</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Ver-museo">http://idi.fundacionctic.org/cruzar/turismo#Ver-museo</seealso>
    let Ver_museo = Prefixed_Name(turismo, "Ver-museo") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Ver-palacio</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Ver-palacio">http://idi.fundacionctic.org/cruzar/turismo#Ver-palacio</seealso>
    let Ver_palacio = Prefixed_Name(turismo, "Ver-palacio") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Ver-zona-verde</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-usuario</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Ver-zona-verde">http://idi.fundacionctic.org/cruzar/turismo#Ver-zona-verde</seealso>
    let Ver_zona_verde = Prefixed_Name(turismo, "Ver-zona-verde") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Viaje</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Un viaje a la ciudad de Zaragoza puede realizarse por distintos motivos. En esta ontología, se contamplan cuatro posibilidades: puramente turísticos, por motivos laborales, asistencia a un congreso o conferencia y por descanso."</para>
    /// labels<para>"Viaje"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Viaje">http://idi.fundacionctic.org/cruzar/turismo#Viaje</seealso>
    let Viaje = Prefixed_Name(turismo, "Viaje") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Viaje-de-congreso</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Viaje</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Viaje-de-congreso">http://idi.fundacionctic.org/cruzar/turismo#Viaje-de-congreso</seealso>
    let Viaje_de_congreso = Prefixed_Name(turismo, "Viaje-de-congreso") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Viaje-de-descanso</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Viaje</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Viaje-de-descanso">http://idi.fundacionctic.org/cruzar/turismo#Viaje-de-descanso</seealso>
    let Viaje_de_descanso = Prefixed_Name(turismo, "Viaje-de-descanso") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Viaje-de-negocios</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Viaje</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Viaje-de-negocios">http://idi.fundacionctic.org/cruzar/turismo#Viaje-de-negocios</seealso>
    let Viaje_de_negocios = Prefixed_Name(turismo, "Viaje-de-negocios") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Viaje-de-turismo</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Viaje</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Viaje-de-turismo">http://idi.fundacionctic.org/cruzar/turismo#Viaje-de-turismo</seealso>
    let Viaje_de_turismo = Prefixed_Name(turismo, "Viaje-de-turismo") |> PrefixedName
    /// <summary>
    ///   <para>turismo:Viernes</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Dia-de-la-semana</para>
    ///
    /// labels<para>"Viernes"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Viernes">http://idi.fundacionctic.org/cruzar/turismo#Viernes</seealso>
    let Viernes = Prefixed_Name(turismo, "Viernes") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Visita-planificada_01</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Visita-turistica</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_01">http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_01</seealso>
    let Visita_planificada_01 =
        Prefixed_Name(turismo, "Visita-planificada_01") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Visita-planificada_02</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Visita-turistica</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_02">http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_02</seealso>
    let Visita_planificada_02 =
        Prefixed_Name(turismo, "Visita-planificada_02") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Visita-planificada_03</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Visita-turistica</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_03">http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_03</seealso>
    let Visita_planificada_03 =
        Prefixed_Name(turismo, "Visita-planificada_03") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Visita-planificada_04</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Visita-turistica</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_04">http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_04</seealso>
    let Visita_planificada_04 =
        Prefixed_Name(turismo, "Visita-planificada_04") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Visita-planificada_04bis</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Visita-turistica</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_04bis">http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_04bis</seealso>
    let Visita_planificada_04bis =
        Prefixed_Name(turismo, "Visita-planificada_04bis") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Visita-planificada_05</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Visita-turistica</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_05">http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_05</seealso>
    let Visita_planificada_05 =
        Prefixed_Name(turismo, "Visita-planificada_05") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Visita-planificada_05bis</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Visita-turistica</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_05bis">http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_05bis</seealso>
    let Visita_planificada_05bis =
        Prefixed_Name(turismo, "Visita-planificada_05bis") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Visita-planificada_06</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Visita-turistica</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_06">http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_06</seealso>
    let Visita_planificada_06 =
        Prefixed_Name(turismo, "Visita-planificada_06") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Visita-planificada_07</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Visita-turistica</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_07">http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_07</seealso>
    let Visita_planificada_07 =
        Prefixed_Name(turismo, "Visita-planificada_07") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Visita-planificada_08</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Visita-turistica</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_08">http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_08</seealso>
    let Visita_planificada_08 =
        Prefixed_Name(turismo, "Visita-planificada_08") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Visita-planificada_09</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Visita-turistica</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_09">http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_09</seealso>
    let Visita_planificada_09 =
        Prefixed_Name(turismo, "Visita-planificada_09") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Visita-planificada_10</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Visita-turistica</para>
    /// </remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_10">http://idi.fundacionctic.org/cruzar/turismo#Visita-planificada_10</seealso>
    let Visita_planificada_10 =
        Prefixed_Name(turismo, "Visita-planificada_10") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Visita-turistica</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Una visita turística es cada una de las partes de las que se compone una ruta turística. Una visita turística tiene como objetivo uno y sólo un recurso de Zaragoza que forma parte del itinerario de la ruta. Las visitas turísticas están ordenadas temporalmente y el sistema procura minimizar la distancia entre unas y otras de acuerdo a las características del perfil."</para>
    /// labels<para>"Visita turística"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Visita-turistica">http://idi.fundacionctic.org/cruzar/turismo#Visita-turistica</seealso>
    let Visita_turistica = Prefixed_Name(turismo, "Visita-turistica") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Visitar-tiempo-corto</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-ruta</para>
    ///
    /// labels<para>"Tempo di visita breve"</para><para>"Tiempo de visita corto"</para><para>"Short time of visit"</para><para>"Durée breve de visite"</para><para>"Tempo de visita breve"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Visitar-tiempo-corto">http://idi.fundacionctic.org/cruzar/turismo#Visitar-tiempo-corto</seealso>
    let Visitar_tiempo_corto =
        Prefixed_Name(turismo, "Visitar-tiempo-corto") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Visitar-tiempo-largo</para>
    /// </summary>
    /// <remarks>
    ///   <para>turismo:Preferencia-de-ruta</para>
    ///
    /// labels<para>"Long time of visit"</para><para>"Tempo di visita lungo"</para><para>"Tempo longo de visita"</para><para>"Durée longue de visite"</para><para>"Tiempo de visita largo"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Visitar-tiempo-largo">http://idi.fundacionctic.org/cruzar/turismo#Visitar-tiempo-largo</seealso>
    let Visitar_tiempo_largo =
        Prefixed_Name(turismo, "Visitar-tiempo-largo") |> PrefixedName

    /// <summary>
    ///   <para>turismo:Zona-verde</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Espacio verde en la ciudad de Zaragoza como puede ser parques, zonas ajardinadas, etc."</para>
    /// labels<para>"Zona verde"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#Zona-verde">http://idi.fundacionctic.org/cruzar/turismo#Zona-verde</seealso>
    let Zona_verde = Prefixed_Name(turismo, "Zona-verde") |> PrefixedName
    /// <summary>
    ///   <para>turismo:address</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Guarda la dirección postal del recurso"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dirección Postal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#address">http://idi.fundacionctic.org/cruzar/turismo#address</seealso>
    let address = Prefixed_Name(turismo, "address") |> PrefixedName
    /// <summary>
    ///   <para>turismo:begining-date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Día de inicio de cada temporada del año. Se distinguen las temporadas de invierno y de verano. Es importante para los horarios de los monumentos."</para>
    /// labels<para>"Fecha de inicio"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#begining-date">http://idi.fundacionctic.org/cruzar/turismo#begining-date</seealso>
    let begining_date = Prefixed_Name(turismo, "begining-date") |> PrefixedName
    /// <summary>
    ///   <para>turismo:closing-time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Hora de cierre del horario de visita de un punto de interés. Por ejemplo, de un museo o de una iglesia."</para>
    /// labels<para>"Horario de cierre"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#closing-time">http://idi.fundacionctic.org/cruzar/turismo#closing-time</seealso>
    let closing_time = Prefixed_Name(turismo, "closing-time") |> PrefixedName
    /// <summary>
    ///   <para>turismo:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indica la fecha de cada uno de los días de visita que el turista va a estar en Zaragoza. También se aplica a Días Festivos."</para>
    /// labels<para>"Fecha"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#date">http://idi.fundacionctic.org/cruzar/turismo#date</seealso>
    let date = Prefixed_Name(turismo, "date") |> PrefixedName
    /// <summary>
    ///   <para>turismo:ending-date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Día de finalización de las temporadas del año. Se contemplan temporada de verano y temporada de invierno."</para>
    /// labels<para>"Fecha de finalización"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#ending-date">http://idi.fundacionctic.org/cruzar/turismo#ending-date</seealso>
    let ending_date = Prefixed_Name(turismo, "ending-date") |> PrefixedName
    /// <summary>
    ///   <para>turismo:final-date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Día de finalización de un determinado evento en la ciudad de Zaragoza."</para>
    /// labels<para>"Día final"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#final-date">http://idi.fundacionctic.org/cruzar/turismo#final-date</seealso>
    let final_date = Prefixed_Name(turismo, "final-date") |> PrefixedName
    /// <summary>
    ///   <para>turismo:has-interest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Esta relación entre recursos e intereses se obtiene a partir de un conjunto de reglas de negocio de turismo. Estas reglas permiten inferir a partir de las preferencias de los usuarios (edns:desire-towards, cúales son sus intereses turísticos. Lo mismo ocurre en el caso de los puntos de interés de la ciudad. Se deduce cuál es el interés potencial que tiene cada recurso para un turista. A partir de la descripción de los intereses de los perfiles y recursos, se calcula la relevancia o importancia subjetiva de cada recurso para un determinado perfil ("matchmaking")."</para>
    /// labels<para>"Tiene interés"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#has-interest">http://idi.fundacionctic.org/cruzar/turismo#has-interest</seealso>
    let has_interest = Prefixed_Name(turismo, "has-interest") |> PrefixedName
    /// <summary>
    ///   <para>turismo:has-no-interest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Representa el valor negativo de la propiedad "has-interest"."</para>
    /// labels<para>"No tiene interés"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#has-no-interest">http://idi.fundacionctic.org/cruzar/turismo#has-no-interest</seealso>
    let has_no_interest = Prefixed_Name(turismo, "has-no-interest") |> PrefixedName
    /// <summary>
    ///   <para>turismo:horario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Guarda el texto con el horario de visita del recurso."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Horario"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#horario">http://idi.fundacionctic.org/cruzar/turismo#horario</seealso>
    let horario = Prefixed_Name(turismo, "horario") |> PrefixedName
    /// <summary>
    ///   <para>turismo:id-idezar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"Guarda el identificador del servicio de IDEZar"</para>
    /// labels<para>"Identificador de IDEZar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#id-idezar">http://idi.fundacionctic.org/cruzar/turismo#id-idezar</seealso>
    let id_idezar = Prefixed_Name(turismo, "id-idezar") |> PrefixedName
    /// <summary>
    ///   <para>turismo:initial-date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Día de inicio de un determinado evento de Zaragoza. Por ejemplo, un musical o una exposición. En el caso de eventos puntuales, tanto el día de inicio como el final será el mismo."</para>
    /// labels<para>"Día inicial"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#initial-date">http://idi.fundacionctic.org/cruzar/turismo#initial-date</seealso>
    let initial_date = Prefixed_Name(turismo, "initial-date") |> PrefixedName

    /// <summary>
    ///   <para>turismo:interest-relevance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indica el grado de interés objetivo de una determinada preferencia. Por ejemplo, cuál es la relevancia del gusto por la arquitectura o la preferencia por ir de compras."</para>
    /// labels<para>"Relevancia de los intereses turísticos"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#interest-relevance">http://idi.fundacionctic.org/cruzar/turismo#interest-relevance</seealso>
    let interest_relevance =
        Prefixed_Name(turismo, "interest-relevance") |> PrefixedName

    /// <summary>
    ///   <para>turismo:interest-towards</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indica los recursos que el usuario quiere que figuren obligatoriamente en la ruta propuesta por el sistema"</para>
    /// labels<para>"Tiene interés en determinados recursos"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#interest-towards">http://idi.fundacionctic.org/cruzar/turismo#interest-towards</seealso>
    let interest_towards = Prefixed_Name(turismo, "interest-towards") |> PrefixedName

    /// <summary>
    ///   <para>turismo:necessity-relevance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Representa el valor de cada una de las preferencias de ruta. Estas preferencias actúan como restricciones para el planificador. Los valores de estos recursos modifican los parámetros iniciales del sistema de planificador."</para>
    /// labels<para>"Relevancia de las preferencias de ruta"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#necessity-relevance">http://idi.fundacionctic.org/cruzar/turismo#necessity-relevance</seealso>
    let necessity_relevance =
        Prefixed_Name(turismo, "necessity-relevance") |> PrefixedName

    /// <summary>
    ///   <para>turismo:not-desire-towards</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Representa el valor negativo de la propiedad "desire-towards". Indica las actividades que el turista no quiere realizar. Esta propiedad, como "desire-towards" servirán de entrada para el cálculo de los intereses de los perfiles de turista en las reglas de negocio de turismo de la aplicación."</para>
    /// labels<para>"No tiene preferencia"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#not-desire-towards">http://idi.fundacionctic.org/cruzar/turismo#not-desire-towards</seealso>
    let not_desire_towards =
        Prefixed_Name(turismo, "not-desire-towards") |> PrefixedName

    /// <summary>
    ///   <para>turismo:not-interest-towards</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indica los recursos que el usuario no quiere que figuren en la ruta propuesta por el sistema"</para>
    /// labels<para>"No tiene interés en determinados recursos"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#not-interest-towards">http://idi.fundacionctic.org/cruzar/turismo#not-interest-towards</seealso>
    let not_interest_towards =
        Prefixed_Name(turismo, "not-interest-towards") |> PrefixedName

    /// <summary>
    ///   <para>turismo:opening-time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Hora de apertura del horario de visita de un punto de interés de la ciudad."</para>
    /// labels<para>"Horario de apertura"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#opening-time">http://idi.fundacionctic.org/cruzar/turismo#opening-time</seealso>
    let opening_time = Prefixed_Name(turismo, "opening-time") |> PrefixedName
    /// <summary>
    ///   <para>turismo:poi-relevance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DataRange</para>
    ///   <para>"Es la relevancia o importancia objetiva de cada uno de los puntos de interés de la ciudad de Zaragoza."</para>
    /// labels<para>"Relevancia de los Puntos de Interés"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#poi-relevance">http://idi.fundacionctic.org/cruzar/turismo#poi-relevance</seealso>
    let poi_relevance = Prefixed_Name(turismo, "poi-relevance") |> PrefixedName
    /// <summary>
    ///   <para>turismo:visit-duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tiempo estimado de duración de las visitas a los distintos monumentos y puntos de interés de la ciudad de Zaragoza. Se utiliza para el cálculo de la ruta."</para>
    /// labels<para>"Duración de la visita"</para></remarks>
    /// <seealso href="http://idi.fundacionctic.org/cruzar/turismo#visit-duration">http://idi.fundacionctic.org/cruzar/turismo#visit-duration</seealso>
    let visit_duration = Prefixed_Name(turismo, "visit-duration") |> PrefixedName
