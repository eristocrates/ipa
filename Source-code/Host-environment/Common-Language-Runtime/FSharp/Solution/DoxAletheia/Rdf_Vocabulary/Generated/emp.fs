namespace http.purl.org.ctic.empleo.oferta.hash

open DoxAletheia.Rdf_Vocabulary

module emp =
    let _namespace_name = "http://purl.org/ctic/empleo/oferta#"

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#AnuncioOferta"></see>
    /// </summary>
    let AnuncioOferta =
        Namespaced_IRI.parse _namespace_name "AnuncioOferta" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#OfertaEmpleo"></see>
    /// </summary>
    let OfertaEmpleo =
        Namespaced_IRI.parse _namespace_name "OfertaEmpleo" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#PlantillaPersonal"></see>
    /// </summary>
    let PlantillaPersonal =
        Namespaced_IRI.parse _namespace_name "PlantillaPersonal" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#anoOferta"></see>
    /// </summary>
    let anoOferta = Namespaced_IRI.parse _namespace_name "anoOferta" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#anuncio"></see>
    /// </summary>
    let anuncio = Namespaced_IRI.parse _namespace_name "anuncio" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#bases"></see>
    /// </summary>
    let bases = Namespaced_IRI.parse _namespace_name "bases" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#boa"></see>
    /// </summary>
    let boa = Namespaced_IRI.parse _namespace_name "boa" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#boe"></see>
    /// </summary>
    let boe = Namespaced_IRI.parse _namespace_name "boe" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#bop"></see>
    /// </summary>
    let bop = Namespaced_IRI.parse _namespace_name "bop" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#categoriaProfesional"></see>
    /// </summary>
    let categoriaProfesional =
        Namespaced_IRI.parse _namespace_name "categoriaProfesional" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#duracionContrato"></see>
    /// </summary>
    let duracionContrato =
        Namespaced_IRI.parse _namespace_name "duracionContrato" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#escalaProfesional"></see>
    /// </summary>
    let escalaProfesional =
        Namespaced_IRI.parse _namespace_name "escalaProfesional" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias"></see>
    /// </summary>
    let esquemaCategorias =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-administracion"></see>
    /// </summary>
    let ``esquemaCategorias-administracion`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-administracion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-agricultura_alimentacion"></see>
    /// </summary>
    let ``esquemaCategorias-agricultura_alimentacion`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-agricultura_alimentacion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-almacenes"></see>
    /// </summary>
    let ``esquemaCategorias-almacenes`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-almacenes" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-arquitectura_dise%C3%B1o"></see>
    /// </summary>
    let ``esquemaCategorias-arquitectura_dise%C3%B1o`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-arquitectura_dise%C3%B1o" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-comercial_ventas"></see>
    /// </summary>
    let ``esquemaCategorias-comercial_ventas`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-comercial_ventas" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-comunicacion_cultura"></see>
    /// </summary>
    let ``esquemaCategorias-comunicacion_cultura`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-comunicacion_cultura" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-construccion"></see>
    /// </summary>
    let ``esquemaCategorias-construccion`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-construccion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-derecho_psicologia"></see>
    /// </summary>
    let ``esquemaCategorias-derecho_psicologia`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-derecho_psicologia" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-directivos"></see>
    /// </summary>
    let ``esquemaCategorias-directivos`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-directivos" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-educacion_serviciossociales"></see>
    /// </summary>
    let ``esquemaCategorias-educacion_serviciossociales`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-educacion_serviciossociales" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-electricidad_energia"></see>
    /// </summary>
    let ``esquemaCategorias-electricidad_energia`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-electricidad_energia" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-industria"></see>
    /// </summary>
    let ``esquemaCategorias-industria`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-industria" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-informacion"></see>
    /// </summary>
    let ``esquemaCategorias-informacion`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-informacion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-informatica_telecomunicaciones"></see>
    /// </summary>
    let ``esquemaCategorias-informatica_telecomunicaciones`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-informatica_telecomunicaciones" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-ingenieria_ciencias"></see>
    /// </summary>
    let ``esquemaCategorias-ingenieria_ciencias`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-ingenieria_ciencias" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-limpieza_cuidadopersonas"></see>
    /// </summary>
    let ``esquemaCategorias-limpieza_cuidadopersonas`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-limpieza_cuidadopersonas" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-metal_mecanica"></see>
    /// </summary>
    let ``esquemaCategorias-metal_mecanica`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-metal_mecanica" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-peluqueria_estetica"></see>
    /// </summary>
    let ``esquemaCategorias-peluqueria_estetica`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-peluqueria_estetica" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-primer_empleo"></see>
    /// </summary>
    let ``esquemaCategorias-primer_empleo`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-primer_empleo" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-salud_deporte"></see>
    /// </summary>
    let ``esquemaCategorias-salud_deporte`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-salud_deporte" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-transporte"></see>
    /// </summary>
    let ``esquemaCategorias-transporte`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-transporte" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-turismo_hosteleria"></see>
    /// </summary>
    let ``esquemaCategorias-turismo_hosteleria`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-turismo_hosteleria" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-vigilancia_servicios"></see>
    /// </summary>
    let ``esquemaCategorias-vigilancia_servicios`` =
        Namespaced_IRI.parse _namespace_name "esquemaCategorias-vigilancia_servicios" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaTiposContrato"></see>
    /// </summary>
    let esquemaTiposContrato =
        Namespaced_IRI.parse _namespace_name "esquemaTiposContrato" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaTiposContrato-laboral_indefinido"></see>
    /// </summary>
    let ``esquemaTiposContrato-laboral_indefinido`` =
        Namespaced_IRI.parse _namespace_name "esquemaTiposContrato-laboral_indefinido" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaTiposContrato-laboral_temporal"></see>
    /// </summary>
    let ``esquemaTiposContrato-laboral_temporal`` =
        Namespaced_IRI.parse _namespace_name "esquemaTiposContrato-laboral_temporal" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#esquemaTiposContrato-mercantil"></see>
    /// </summary>
    let ``esquemaTiposContrato-mercantil`` =
        Namespaced_IRI.parse _namespace_name "esquemaTiposContrato-mercantil" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#examen"></see>
    /// </summary>
    let examen = Namespaced_IRI.parse _namespace_name "examen" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#expediente"></see>
    /// </summary>
    let expediente = Namespaced_IRI.parse _namespace_name "expediente" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#fechaPresentacion"></see>
    /// </summary>
    let fechaPresentacion =
        Namespaced_IRI.parse _namespace_name "fechaPresentacion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#grupoProfesional"></see>
    /// </summary>
    let grupoProfesional =
        Namespaced_IRI.parse _namespace_name "grupoProfesional" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#jornada"></see>
    /// </summary>
    let jornada = Namespaced_IRI.parse _namespace_name "jornada" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#plantillaPersonal"></see>
    /// </summary>
    let plantillaPersonal =
        Namespaced_IRI.parse _namespace_name "plantillaPersonal" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#plazasInternas"></see>
    /// </summary>
    let plazasInternas =
        Namespaced_IRI.parse _namespace_name "plazasInternas" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#plazasMinusvalidos"></see>
    /// </summary>
    let plazasMinusvalidos =
        Namespaced_IRI.parse _namespace_name "plazasMinusvalidos" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#plazasTotal"></see>
    /// </summary>
    let plazasTotal =
        Namespaced_IRI.parse _namespace_name "plazasTotal" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#requisito"></see>
    /// </summary>
    let requisito = Namespaced_IRI.parse _namespace_name "requisito" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#requisito-experiencia"></see>
    /// </summary>
    let ``requisito-experiencia`` =
        Namespaced_IRI.parse _namespace_name "requisito-experiencia" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#requisito-formacion"></see>
    /// </summary>
    let ``requisito-formacion`` =
        Namespaced_IRI.parse _namespace_name "requisito-formacion" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#requisito-idiomas"></see>
    /// </summary>
    let ``requisito-idiomas`` =
        Namespaced_IRI.parse _namespace_name "requisito-idiomas" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#requisito-inform%C3%A1tica"></see>
    /// </summary>
    let ``requisito-inform%C3%A1tica`` =
        Namespaced_IRI.parse _namespace_name "requisito-inform%C3%A1tica" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#salario"></see>
    /// </summary>
    let salario = Namespaced_IRI.parse _namespace_name "salario" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#tipoContrato"></see>
    /// </summary>
    let tipoContrato =
        Namespaced_IRI.parse _namespace_name "tipoContrato" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#titulacion"></see>
    /// </summary>
    let titulacion = Namespaced_IRI.parse _namespace_name "titulacion" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#tribunal"></see>
    /// </summary>
    let tribunal = Namespaced_IRI.parse _namespace_name "tribunal" |> NamespacedName
    /// <summary>
    ///   <see href="http://purl.org/ctic/empleo/oferta#turno"></see>
    /// </summary>
    let turno = Namespaced_IRI.parse _namespace_name "turno" |> NamespacedName
