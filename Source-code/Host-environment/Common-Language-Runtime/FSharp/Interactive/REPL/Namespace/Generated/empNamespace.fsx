#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module emp =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/ctic/empleo/oferta#" "emp"

    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Un anuncio de una oferta de empleo</para>
    ///   <para>rdfs:label : Anuncio de oferta</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#AnuncioOferta">emp:AnuncioOferta</a>
    /// </summary>
    let AnuncioOferta = _prefixId.prefix "AnuncioOferta"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Una oferta de empleo es un documento que describe los detalles de uno o más trabajos que deben ser cubiertos. Nótese que no es lo mismo un trabajo, que una oferta de trabajo.</para>
    ///   <para>rdfs:label : Oferta de Empleo</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#OfertaEmpleo">emp:OfertaEmpleo</a>
    /// </summary>
    let OfertaEmpleo = _prefixId.prefix "OfertaEmpleo"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : La plantilla de personal es un grupo de personas contratadas bajo unas condiciones o estatutos similares</para>
    ///   <para>rdfs:label : Plantilla de personal</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#PlantillaPersonal">emp:PlantillaPersonal</a>
    /// </summary>
    let PlantillaPersonal = _prefixId.prefix "PlantillaPersonal"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Año o años de la oferta</para>
    ///   <para>rdfs:label : Año de la oferta</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#anoOferta">emp:anoOferta</a>
    /// </summary>
    let anoOferta = _prefixId.prefix "anoOferta"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Anuncio de la convocatoria de la oferta</para>
    ///   <para>rdfs:label : Anuncio</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#anuncio">emp:anuncio</a>
    /// </summary>
    let anuncio = _prefixId.prefix "anuncio"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Bases de la convocatoria</para>
    ///   <para>rdfs:label : Bases</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#bases">emp:bases</a>
    /// </summary>
    let bases = _prefixId.prefix "bases"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Ejemplar del Boletín Oficial Autonómico donde aparece información sobre la oferta</para>
    ///   <para>rdfs:label : Boletín Oficial Autonómico</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#boa">emp:boa</a>
    /// </summary>
    let boa = _prefixId.prefix "boa"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Ejemplar del Boletín Oficial del Estado donde aparece información sobre la oferta</para>
    ///   <para>rdfs:label : Boletín Oficial del Estado</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#boe">emp:boe</a>
    /// </summary>
    let boe = _prefixId.prefix "boe"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Ejemplar del Boletín Oficial Provincial donde aparece información sobre la oferta</para>
    ///   <para>rdfs:label : Boletín Oficial Provincial</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#bop">emp:bop</a>
    /// </summary>
    let bop = _prefixId.prefix "bop"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:label : Categoría profesional</para>
    ///   <para>rdfs:comment : Tipo de la categoría profesional destinataria de la oferta</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#categoriaProfesional">emp:categoriaProfesional</a>
    /// </summary>
    let categoriaProfesional = _prefixId.prefix "categoriaProfesional"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-01^^xsd:string</para>
    ///   <para>rdfs:comment : Periodo de tiempo que durará el contrato ofertado</para>
    ///   <para>rdfs:label : Duración del contrato</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#duracionContrato">emp:duracionContrato</a>
    /// </summary>
    let duracionContrato = _prefixId.prefix "duracionContrato"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Escala profesional de la oferta</para>
    ///   <para>rdfs:label : Escala profesional</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#escalaProfesional">emp:escalaProfesional</a>
    /// </summary>
    let escalaProfesional = _prefixId.prefix "escalaProfesional"
    let esquemaCategorias = _prefixId.prefix "esquemaCategorias"

    let esquemaCategorias_administracion =
        _prefixId.prefix "esquemaCategorias-administracion"

    let esquemaCategorias_agricultura_alimentacion =
        _prefixId.prefix "esquemaCategorias-agricultura_alimentacion"

    let esquemaCategorias_almacenes = _prefixId.prefix "esquemaCategorias-almacenes"

    let ``esquemaCategorias_arquitectura_dise%C3%B1o`` =
        _prefixId.prefix "esquemaCategorias-arquitectura_dise%C3%B1o"

    let esquemaCategorias_comercial_ventas =
        _prefixId.prefix "esquemaCategorias-comercial_ventas"

    let esquemaCategorias_comunicacion_cultura =
        _prefixId.prefix "esquemaCategorias-comunicacion_cultura"

    let esquemaCategorias_construccion =
        _prefixId.prefix "esquemaCategorias-construccion"

    let esquemaCategorias_derecho_psicologia =
        _prefixId.prefix "esquemaCategorias-derecho_psicologia"

    let esquemaCategorias_directivos = _prefixId.prefix "esquemaCategorias-directivos"

    let esquemaCategorias_educacion_serviciossociales =
        _prefixId.prefix "esquemaCategorias-educacion_serviciossociales"

    let esquemaCategorias_electricidad_energia =
        _prefixId.prefix "esquemaCategorias-electricidad_energia"

    let esquemaCategorias_industria = _prefixId.prefix "esquemaCategorias-industria"
    let esquemaCategorias_informacion = _prefixId.prefix "esquemaCategorias-informacion"

    let esquemaCategorias_informatica_telecomunicaciones =
        _prefixId.prefix "esquemaCategorias-informatica_telecomunicaciones"

    let esquemaCategorias_ingenieria_ciencias =
        _prefixId.prefix "esquemaCategorias-ingenieria_ciencias"

    let esquemaCategorias_limpieza_cuidadopersonas =
        _prefixId.prefix "esquemaCategorias-limpieza_cuidadopersonas"

    let esquemaCategorias_metal_mecanica =
        _prefixId.prefix "esquemaCategorias-metal_mecanica"

    let esquemaCategorias_peluqueria_estetica =
        _prefixId.prefix "esquemaCategorias-peluqueria_estetica"

    let esquemaCategorias_primer_empleo =
        _prefixId.prefix "esquemaCategorias-primer_empleo"

    let esquemaCategorias_salud_deporte =
        _prefixId.prefix "esquemaCategorias-salud_deporte"

    let esquemaCategorias_transporte = _prefixId.prefix "esquemaCategorias-transporte"

    let esquemaCategorias_turismo_hosteleria =
        _prefixId.prefix "esquemaCategorias-turismo_hosteleria"

    let esquemaCategorias_vigilancia_servicios =
        _prefixId.prefix "esquemaCategorias-vigilancia_servicios"

    let esquemaTiposContrato = _prefixId.prefix "esquemaTiposContrato"

    let esquemaTiposContrato_laboral_indefinido =
        _prefixId.prefix "esquemaTiposContrato-laboral_indefinido"

    let esquemaTiposContrato_laboral_temporal =
        _prefixId.prefix "esquemaTiposContrato-laboral_temporal"

    let esquemaTiposContrato_mercantil =
        _prefixId.prefix "esquemaTiposContrato-mercantil"

    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Tipo del examen de la oferta</para>
    ///   <para>rdfs:label : Tipo de exámen</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#examen">emp:examen</a>
    /// </summary>
    let examen = _prefixId.prefix "examen"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Expediente relacionado con la oferta</para>
    ///   <para>rdfs:label : Expediente</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#expediente">emp:expediente</a>
    /// </summary>
    let expediente = _prefixId.prefix "expediente"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Fecha límite de presentación de la instancia para la oferta en formato “ISO 8601”</para>
    ///   <para>rdfs:label : Fecha de presentación de la instancia</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#fechaPresentacion">emp:fechaPresentacion</a>
    /// </summary>
    let fechaPresentacion = _prefixId.prefix "fechaPresentacion"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Grupo de clasificación profesional</para>
    ///   <para>rdfs:label : Grupo Profesional</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#grupoProfesional">emp:grupoProfesional</a>
    /// </summary>
    let grupoProfesional = _prefixId.prefix "grupoProfesional"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-01^^xsd:string</para>
    ///   <para>rdfs:comment : Jornada laboral que tendrá el puesto laboral de la oferta de empleo</para>
    ///   <para>rdfs:label : Jornada laboral</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#jornada">emp:jornada</a>
    /// </summary>
    let jornada = _prefixId.prefix "jornada"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : El tipo de plantilla de personal del puesto de trabajo</para>
    ///   <para>rdfs:label : Plantilla de personal</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#plantillaPersonal">emp:plantillaPersonal</a>
    /// </summary>
    let plantillaPersonal = _prefixId.prefix "plantillaPersonal"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Número de plazas reservadas a promoción interna en la oferta de trabajo</para>
    ///   <para>rdfs:label : Número de plazas para promoción interna</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#plazasInternas">emp:plazasInternas</a>
    /// </summary>
    let plazasInternas = _prefixId.prefix "plazasInternas"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Número de plazas reservadas a personas discapacitadas para el puesto de trabajo</para>
    ///   <para>rdfs:label : Número de plazas para minusválidos</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#plazasMinusvalidos">emp:plazasMinusvalidos</a>
    /// </summary>
    let plazasMinusvalidos = _prefixId.prefix "plazasMinusvalidos"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Número de plazas para el puesto de trabajo</para>
    ///   <para>rdfs:label : Plazas totales</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#plazasTotal">emp:plazasTotal</a>
    /// </summary>
    let plazasTotal = _prefixId.prefix "plazasTotal"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-01^^xsd:string</para>
    ///   <para>rdfs:comment : Requisitos generales necesarios y/o deseados para acceder al puesto de trabajo</para>
    ///   <para>rdfs:label : Requisito</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#requisito">emp:requisito</a>
    /// </summary>
    let requisito = _prefixId.prefix "requisito"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-01^^xsd:string</para>
    ///   <para>rdfs:comment : Experiencia mínima necesario para acceder al puesto de trabajo</para>
    ///   <para>rdfs:label : Experiencia</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#requisito-experiencia">emp:requisito-experiencia</a>
    /// </summary>
    let requisito_experiencia = _prefixId.prefix "requisito-experiencia"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-01^^xsd:string</para>
    ///   <para>rdfs:comment : Formación mínima necesaria y/o la formación deseada para acceder al puesto de trabajo</para>
    ///   <para>rdfs:label : Formación</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#requisito-formacion">emp:requisito-formacion</a>
    /// </summary>
    let requisito_formacion = _prefixId.prefix "requisito-formacion"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-01^^xsd:string</para>
    ///   <para>rdfs:comment : Conocimientos de idiomas necesarios y/o deseados para acceder al puesto de trabajo</para>
    ///   <para>rdfs:label : Idiomas</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#requisito-idiomas">emp:requisito-idiomas</a>
    /// </summary>
    let requisito_idiomas = _prefixId.prefix "requisito-idiomas"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-01^^xsd:string</para>
    ///   <para>rdfs:comment : Conocimientos de informática necesarios y/o deseados para acceder al puesto de trabajo</para>
    ///   <para>rdfs:label : Informática</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#requisito-inform%C3%A1tica">emp:requisito-inform%C3%A1tica</a>
    /// </summary>
    let ``requisito_inform%C3%A1tica`` = _prefixId.prefix "requisito-inform%C3%A1tica"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-01^^xsd:string</para>
    ///   <para>rdfs:comment : Salario y/o remuneraciones del contrato ofertado para el puesto</para>
    ///   <para>rdfs:label : Salario</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#salario">emp:salario</a>
    /// </summary>
    let salario = _prefixId.prefix "salario"
    /// <summary>
    ///   <para>dcterms:issued : 2012-09-01^^xsd:string</para>
    ///   <para>rdfs:comment : Tipo de contrato de la oferta de empleo. Referencia un concepto del esquema Tipos de contrato</para>
    ///   <para>rdfs:label : Tipo de contrato</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#tipoContrato">emp:tipoContrato</a>
    /// </summary>
    let tipoContrato = _prefixId.prefix "tipoContrato"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : La titulación que se requiere para la oferta de trabajo</para>
    ///   <para>rdfs:label : Titulación</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#titulacion">emp:titulacion</a>
    /// </summary>
    let titulacion = _prefixId.prefix "titulacion"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Tribunal que evaluará la convocatoria</para>
    ///   <para>rdfs:label : Tribunal</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#tribunal">emp:tribunal</a>
    /// </summary>
    let tribunal = _prefixId.prefix "tribunal"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Turno de la oferta</para>
    ///   <para>rdfs:label : Turno</para>
    ///   <a href="http://purl.org/ctic/empleo/oferta#turno">emp:turno</a>
    /// </summary>
    let turno = _prefixId.prefix "turno"
