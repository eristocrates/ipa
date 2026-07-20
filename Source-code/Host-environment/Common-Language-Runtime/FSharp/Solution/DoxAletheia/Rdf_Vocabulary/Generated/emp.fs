namespace http.purl.org.ctic.empleo.oferta.hash

open DoxAletheia

module emp =
    let _namespace_name = "http://purl.org/ctic/empleo/oferta#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#AnuncioOferta"></see>
    /// </summary>
    let AnuncioOferta = _prefix "AnuncioOferta"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#OfertaEmpleo"></see>
    /// </summary>
    let OfertaEmpleo = _prefix "OfertaEmpleo"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#PlantillaPersonal"></see>
    /// </summary>
    let PlantillaPersonal = _prefix "PlantillaPersonal"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#anoOferta"></see>
    /// </summary>
    let anoOferta = _prefix "anoOferta"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#anuncio"></see>
    /// </summary>
    let anuncio = _prefix "anuncio"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#bases"></see>
    /// </summary>
    let bases = _prefix "bases"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#boa"></see>
    /// </summary>
    let boa = _prefix "boa"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#boe"></see>
    /// </summary>
    let boe = _prefix "boe"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#bop"></see>
    /// </summary>
    let bop = _prefix "bop"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#categoriaProfesional"></see>
    /// </summary>
    let categoriaProfesional = _prefix "categoriaProfesional"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#duracionContrato"></see>
    /// </summary>
    let duracionContrato = _prefix "duracionContrato"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#escalaProfesional"></see>
    /// </summary>
    let escalaProfesional = _prefix "escalaProfesional"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias"></see>
    /// </summary>
    let esquemaCategorias = _prefix "esquemaCategorias"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-administracion"></see>
    /// </summary>
    let ``esquemaCategorias-administracion`` =
        _prefix "esquemaCategorias-administracion"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-agricultura_alimentacion"></see>
    /// </summary>
    let ``esquemaCategorias-agricultura_alimentacion`` =
        _prefix "esquemaCategorias-agricultura_alimentacion"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-almacenes"></see>
    /// </summary>
    let ``esquemaCategorias-almacenes`` = _prefix "esquemaCategorias-almacenes"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-arquitectura_dise%C3%B1o"></see>
    /// </summary>
    let ``esquemaCategorias-arquitectura_dise%C3%B1o`` =
        _prefix "esquemaCategorias-arquitectura_dise%C3%B1o"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-comercial_ventas"></see>
    /// </summary>
    let ``esquemaCategorias-comercial_ventas`` =
        _prefix "esquemaCategorias-comercial_ventas"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-comunicacion_cultura"></see>
    /// </summary>
    let ``esquemaCategorias-comunicacion_cultura`` =
        _prefix "esquemaCategorias-comunicacion_cultura"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-construccion"></see>
    /// </summary>
    let ``esquemaCategorias-construccion`` = _prefix "esquemaCategorias-construccion"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-derecho_psicologia"></see>
    /// </summary>
    let ``esquemaCategorias-derecho_psicologia`` =
        _prefix "esquemaCategorias-derecho_psicologia"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-directivos"></see>
    /// </summary>
    let ``esquemaCategorias-directivos`` = _prefix "esquemaCategorias-directivos"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-educacion_serviciossociales"></see>
    /// </summary>
    let ``esquemaCategorias-educacion_serviciossociales`` =
        _prefix "esquemaCategorias-educacion_serviciossociales"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-electricidad_energia"></see>
    /// </summary>
    let ``esquemaCategorias-electricidad_energia`` =
        _prefix "esquemaCategorias-electricidad_energia"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-industria"></see>
    /// </summary>
    let ``esquemaCategorias-industria`` = _prefix "esquemaCategorias-industria"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-informacion"></see>
    /// </summary>
    let ``esquemaCategorias-informacion`` = _prefix "esquemaCategorias-informacion"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-informatica_telecomunicaciones"></see>
    /// </summary>
    let ``esquemaCategorias-informatica_telecomunicaciones`` =
        _prefix "esquemaCategorias-informatica_telecomunicaciones"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-ingenieria_ciencias"></see>
    /// </summary>
    let ``esquemaCategorias-ingenieria_ciencias`` =
        _prefix "esquemaCategorias-ingenieria_ciencias"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-limpieza_cuidadopersonas"></see>
    /// </summary>
    let ``esquemaCategorias-limpieza_cuidadopersonas`` =
        _prefix "esquemaCategorias-limpieza_cuidadopersonas"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-metal_mecanica"></see>
    /// </summary>
    let ``esquemaCategorias-metal_mecanica`` =
        _prefix "esquemaCategorias-metal_mecanica"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-peluqueria_estetica"></see>
    /// </summary>
    let ``esquemaCategorias-peluqueria_estetica`` =
        _prefix "esquemaCategorias-peluqueria_estetica"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-primer_empleo"></see>
    /// </summary>
    let ``esquemaCategorias-primer_empleo`` = _prefix "esquemaCategorias-primer_empleo"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-salud_deporte"></see>
    /// </summary>
    let ``esquemaCategorias-salud_deporte`` = _prefix "esquemaCategorias-salud_deporte"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-transporte"></see>
    /// </summary>
    let ``esquemaCategorias-transporte`` = _prefix "esquemaCategorias-transporte"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-turismo_hosteleria"></see>
    /// </summary>
    let ``esquemaCategorias-turismo_hosteleria`` =
        _prefix "esquemaCategorias-turismo_hosteleria"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-vigilancia_servicios"></see>
    /// </summary>
    let ``esquemaCategorias-vigilancia_servicios`` =
        _prefix "esquemaCategorias-vigilancia_servicios"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaTiposContrato"></see>
    /// </summary>
    let esquemaTiposContrato = _prefix "esquemaTiposContrato"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaTiposContrato-laboral_indefinido"></see>
    /// </summary>
    let ``esquemaTiposContrato-laboral_indefinido`` =
        _prefix "esquemaTiposContrato-laboral_indefinido"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaTiposContrato-laboral_temporal"></see>
    /// </summary>
    let ``esquemaTiposContrato-laboral_temporal`` =
        _prefix "esquemaTiposContrato-laboral_temporal"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaTiposContrato-mercantil"></see>
    /// </summary>
    let ``esquemaTiposContrato-mercantil`` = _prefix "esquemaTiposContrato-mercantil"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#examen"></see>
    /// </summary>
    let examen = _prefix "examen"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#expediente"></see>
    /// </summary>
    let expediente = _prefix "expediente"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#fechaPresentacion"></see>
    /// </summary>
    let fechaPresentacion = _prefix "fechaPresentacion"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#grupoProfesional"></see>
    /// </summary>
    let grupoProfesional = _prefix "grupoProfesional"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#jornada"></see>
    /// </summary>
    let jornada = _prefix "jornada"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#plantillaPersonal"></see>
    /// </summary>
    let plantillaPersonal = _prefix "plantillaPersonal"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#plazasInternas"></see>
    /// </summary>
    let plazasInternas = _prefix "plazasInternas"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#plazasMinusvalidos"></see>
    /// </summary>
    let plazasMinusvalidos = _prefix "plazasMinusvalidos"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#plazasTotal"></see>
    /// </summary>
    let plazasTotal = _prefix "plazasTotal"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#requisito"></see>
    /// </summary>
    let requisito = _prefix "requisito"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#requisito-experiencia"></see>
    /// </summary>
    let ``requisito-experiencia`` = _prefix "requisito-experiencia"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#requisito-formacion"></see>
    /// </summary>
    let ``requisito-formacion`` = _prefix "requisito-formacion"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#requisito-idiomas"></see>
    /// </summary>
    let ``requisito-idiomas`` = _prefix "requisito-idiomas"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#requisito-inform%C3%A1tica"></see>
    /// </summary>
    let ``requisito-inform%C3%A1tica`` = _prefix "requisito-inform%C3%A1tica"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#salario"></see>
    /// </summary>
    let salario = _prefix "salario"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#tipoContrato"></see>
    /// </summary>
    let tipoContrato = _prefix "tipoContrato"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#titulacion"></see>
    /// </summary>
    let titulacion = _prefix "titulacion"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#tribunal"></see>
    /// </summary>
    let tribunal = _prefix "tribunal"
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#turno"></see>
    /// </summary>
    let turno = _prefix "turno"
