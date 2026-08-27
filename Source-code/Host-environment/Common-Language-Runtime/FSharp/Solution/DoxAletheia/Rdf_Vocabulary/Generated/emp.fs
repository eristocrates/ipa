namespace http.purl.org.ctic.empleo.oferta.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module emp =
    let _namespace_iri = Namespace_Iri emp |> NamespaceIRI
    /// <summary>
    ///   <para>emp:AnuncioOferta</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Un anuncio de una oferta de empleo"</para>
    /// labels<para>"Anuncio de oferta"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#AnuncioOferta">http://purl.org/ctic/empleo/oferta#AnuncioOferta</seealso>
    let AnuncioOferta = Prefixed_Name(emp, "AnuncioOferta") |> PrefixedName
    /// <summary>
    ///   <para>emp:OfertaEmpleo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Una oferta de empleo es un documento que describe los detalles de uno o más trabajos que deben ser cubiertos. Nótese que no es lo mismo un trabajo, que una oferta de trabajo."</para>
    /// labels<para>"Oferta de Empleo"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#OfertaEmpleo">http://purl.org/ctic/empleo/oferta#OfertaEmpleo</seealso>
    let OfertaEmpleo = Prefixed_Name(emp, "OfertaEmpleo") |> PrefixedName
    /// <summary>
    ///   <para>emp:PlantillaPersonal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"La plantilla de personal es un grupo de personas contratadas bajo unas condiciones o estatutos similares"</para>
    /// labels<para>"Plantilla de personal"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#PlantillaPersonal">http://purl.org/ctic/empleo/oferta#PlantillaPersonal</seealso>
    let PlantillaPersonal = Prefixed_Name(emp, "PlantillaPersonal") |> PrefixedName
    /// <summary>
    ///   <para>emp:anoOferta</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Año o años de la oferta"</para>
    /// labels<para>"Año de la oferta"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#anoOferta">http://purl.org/ctic/empleo/oferta#anoOferta</seealso>
    let anoOferta = Prefixed_Name(emp, "anoOferta") |> PrefixedName
    /// <summary>
    ///   <para>emp:anuncio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Anuncio de la convocatoria de la oferta"</para>
    /// labels<para>"Anuncio"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#anuncio">http://purl.org/ctic/empleo/oferta#anuncio</seealso>
    let anuncio = Prefixed_Name(emp, "anuncio") |> PrefixedName
    /// <summary>
    ///   <para>emp:bases</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Bases de la convocatoria"</para>
    /// labels<para>"Bases"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#bases">http://purl.org/ctic/empleo/oferta#bases</seealso>
    let bases = Prefixed_Name(emp, "bases") |> PrefixedName
    /// <summary>
    ///   <para>emp:boa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Ejemplar del Boletín Oficial Autonómico donde aparece información sobre la oferta"</para>
    /// labels<para>"Boletín Oficial Autonómico"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#boa">http://purl.org/ctic/empleo/oferta#boa</seealso>
    let boa = Prefixed_Name(emp, "boa") |> PrefixedName
    /// <summary>
    ///   <para>emp:boe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Ejemplar del Boletín Oficial del Estado donde aparece información sobre la oferta"</para>
    /// labels<para>"Boletín Oficial del Estado"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#boe">http://purl.org/ctic/empleo/oferta#boe</seealso>
    let boe = Prefixed_Name(emp, "boe") |> PrefixedName
    /// <summary>
    ///   <para>emp:bop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Ejemplar del Boletín Oficial Provincial donde aparece información sobre la oferta"</para>
    /// labels<para>"Boletín Oficial Provincial"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#bop">http://purl.org/ctic/empleo/oferta#bop</seealso>
    let bop = Prefixed_Name(emp, "bop") |> PrefixedName

    /// <summary>
    ///   <para>emp:categoriaProfesional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Tipo de la categoría profesional destinataria de la oferta"</para>
    /// labels<para>"Categoría profesional"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#categoriaProfesional">http://purl.org/ctic/empleo/oferta#categoriaProfesional</seealso>
    let categoriaProfesional =
        Prefixed_Name(emp, "categoriaProfesional") |> PrefixedName

    /// <summary>
    ///   <para>emp:duracionContrato</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Periodo de tiempo que durará el contrato ofertado"</para>
    /// labels<para>"Duración del contrato"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#duracionContrato">http://purl.org/ctic/empleo/oferta#duracionContrato</seealso>
    let duracionContrato = Prefixed_Name(emp, "duracionContrato") |> PrefixedName
    /// <summary>
    ///   <para>emp:escalaProfesional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Escala profesional de la oferta"</para>
    /// labels<para>"Escala profesional"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#escalaProfesional">http://purl.org/ctic/empleo/oferta#escalaProfesional</seealso>
    let escalaProfesional = Prefixed_Name(emp, "escalaProfesional") |> PrefixedName
    /// <summary>
    ///   <para>emp:esquemaCategorias</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>"Esquema de conceptos de las diferentes categorías y subcategorías que puede tener una oferta de empleo"</para>
    /// labels<para>"Taxonomía de las categorías de las ofertas de empleo"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias">http://purl.org/ctic/empleo/oferta#esquemaCategorias</seealso>
    let esquemaCategorias = Prefixed_Name(emp, "esquemaCategorias") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-administracion</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-administracion">http://purl.org/ctic/empleo/oferta#esquemaCategorias-administracion</seealso>
    let esquemaCategorias_administracion =
        Prefixed_Name(emp, "esquemaCategorias-administracion") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-agricultura_alimentacion</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-agricultura_alimentacion">http://purl.org/ctic/empleo/oferta#esquemaCategorias-agricultura_alimentacion</seealso>
    let esquemaCategorias_agricultura_alimentacion =
        Prefixed_Name(emp, "esquemaCategorias-agricultura_alimentacion") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-almacenes</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-almacenes">http://purl.org/ctic/empleo/oferta#esquemaCategorias-almacenes</seealso>
    let esquemaCategorias_almacenes =
        Prefixed_Name(emp, "esquemaCategorias-almacenes") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-arquitectura_dise%C3%B1o</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-arquitectura_dise%C3%B1o">http://purl.org/ctic/empleo/oferta#esquemaCategorias-arquitectura_dise%C3%B1o</seealso>
    let ``esquemaCategorias_arquitectura_dise%C3%B1o`` =
        Prefixed_Name(emp, "esquemaCategorias-arquitectura_dise%C3%B1o") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-comercial_ventas</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-comercial_ventas">http://purl.org/ctic/empleo/oferta#esquemaCategorias-comercial_ventas</seealso>
    let esquemaCategorias_comercial_ventas =
        Prefixed_Name(emp, "esquemaCategorias-comercial_ventas") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-comunicacion_cultura</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-comunicacion_cultura">http://purl.org/ctic/empleo/oferta#esquemaCategorias-comunicacion_cultura</seealso>
    let esquemaCategorias_comunicacion_cultura =
        Prefixed_Name(emp, "esquemaCategorias-comunicacion_cultura") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-construccion</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-construccion">http://purl.org/ctic/empleo/oferta#esquemaCategorias-construccion</seealso>
    let esquemaCategorias_construccion =
        Prefixed_Name(emp, "esquemaCategorias-construccion") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-derecho_psicologia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-derecho_psicologia">http://purl.org/ctic/empleo/oferta#esquemaCategorias-derecho_psicologia</seealso>
    let esquemaCategorias_derecho_psicologia =
        Prefixed_Name(emp, "esquemaCategorias-derecho_psicologia") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-directivos</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-directivos">http://purl.org/ctic/empleo/oferta#esquemaCategorias-directivos</seealso>
    let esquemaCategorias_directivos =
        Prefixed_Name(emp, "esquemaCategorias-directivos") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-educacion_serviciossociales</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-educacion_serviciossociales">http://purl.org/ctic/empleo/oferta#esquemaCategorias-educacion_serviciossociales</seealso>
    let esquemaCategorias_educacion_serviciossociales =
        Prefixed_Name(emp, "esquemaCategorias-educacion_serviciossociales") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-electricidad_energia</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-electricidad_energia">http://purl.org/ctic/empleo/oferta#esquemaCategorias-electricidad_energia</seealso>
    let esquemaCategorias_electricidad_energia =
        Prefixed_Name(emp, "esquemaCategorias-electricidad_energia") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-industria</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-industria">http://purl.org/ctic/empleo/oferta#esquemaCategorias-industria</seealso>
    let esquemaCategorias_industria =
        Prefixed_Name(emp, "esquemaCategorias-industria") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-informacion</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-informacion">http://purl.org/ctic/empleo/oferta#esquemaCategorias-informacion</seealso>
    let esquemaCategorias_informacion =
        Prefixed_Name(emp, "esquemaCategorias-informacion") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-informatica_telecomunicaciones</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-informatica_telecomunicaciones">http://purl.org/ctic/empleo/oferta#esquemaCategorias-informatica_telecomunicaciones</seealso>
    let esquemaCategorias_informatica_telecomunicaciones =
        Prefixed_Name(emp, "esquemaCategorias-informatica_telecomunicaciones") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-ingenieria_ciencias</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-ingenieria_ciencias">http://purl.org/ctic/empleo/oferta#esquemaCategorias-ingenieria_ciencias</seealso>
    let esquemaCategorias_ingenieria_ciencias =
        Prefixed_Name(emp, "esquemaCategorias-ingenieria_ciencias") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-limpieza_cuidadopersonas</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-limpieza_cuidadopersonas">http://purl.org/ctic/empleo/oferta#esquemaCategorias-limpieza_cuidadopersonas</seealso>
    let esquemaCategorias_limpieza_cuidadopersonas =
        Prefixed_Name(emp, "esquemaCategorias-limpieza_cuidadopersonas") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-metal_mecanica</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-metal_mecanica">http://purl.org/ctic/empleo/oferta#esquemaCategorias-metal_mecanica</seealso>
    let esquemaCategorias_metal_mecanica =
        Prefixed_Name(emp, "esquemaCategorias-metal_mecanica") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-peluqueria_estetica</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-peluqueria_estetica">http://purl.org/ctic/empleo/oferta#esquemaCategorias-peluqueria_estetica</seealso>
    let esquemaCategorias_peluqueria_estetica =
        Prefixed_Name(emp, "esquemaCategorias-peluqueria_estetica") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-primer_empleo</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-primer_empleo">http://purl.org/ctic/empleo/oferta#esquemaCategorias-primer_empleo</seealso>
    let esquemaCategorias_primer_empleo =
        Prefixed_Name(emp, "esquemaCategorias-primer_empleo") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-salud_deporte</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-salud_deporte">http://purl.org/ctic/empleo/oferta#esquemaCategorias-salud_deporte</seealso>
    let esquemaCategorias_salud_deporte =
        Prefixed_Name(emp, "esquemaCategorias-salud_deporte") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-transporte</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-transporte">http://purl.org/ctic/empleo/oferta#esquemaCategorias-transporte</seealso>
    let esquemaCategorias_transporte =
        Prefixed_Name(emp, "esquemaCategorias-transporte") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-turismo_hosteleria</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-turismo_hosteleria">http://purl.org/ctic/empleo/oferta#esquemaCategorias-turismo_hosteleria</seealso>
    let esquemaCategorias_turismo_hosteleria =
        Prefixed_Name(emp, "esquemaCategorias-turismo_hosteleria") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaCategorias-vigilancia_servicios</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaCategorias-vigilancia_servicios">http://purl.org/ctic/empleo/oferta#esquemaCategorias-vigilancia_servicios</seealso>
    let esquemaCategorias_vigilancia_servicios =
        Prefixed_Name(emp, "esquemaCategorias-vigilancia_servicios") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaTiposContrato</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>"Esquema de conceptos de los tipos de contrato que puede tener una oferta de empleo"</para>
    /// labels<para>"Taxonomía de los tipos de contrato de una oferta de empleo"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaTiposContrato">http://purl.org/ctic/empleo/oferta#esquemaTiposContrato</seealso>
    let esquemaTiposContrato =
        Prefixed_Name(emp, "esquemaTiposContrato") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaTiposContrato-laboral_indefinido</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaTiposContrato-laboral_indefinido">http://purl.org/ctic/empleo/oferta#esquemaTiposContrato-laboral_indefinido</seealso>
    let esquemaTiposContrato_laboral_indefinido =
        Prefixed_Name(emp, "esquemaTiposContrato-laboral_indefinido") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaTiposContrato-laboral_temporal</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaTiposContrato-laboral_temporal">http://purl.org/ctic/empleo/oferta#esquemaTiposContrato-laboral_temporal</seealso>
    let esquemaTiposContrato_laboral_temporal =
        Prefixed_Name(emp, "esquemaTiposContrato-laboral_temporal") |> PrefixedName

    /// <summary>
    ///   <para>emp:esquemaTiposContrato-mercantil</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#esquemaTiposContrato-mercantil">http://purl.org/ctic/empleo/oferta#esquemaTiposContrato-mercantil</seealso>
    let esquemaTiposContrato_mercantil =
        Prefixed_Name(emp, "esquemaTiposContrato-mercantil") |> PrefixedName

    /// <summary>
    ///   <para>emp:examen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Tipo del examen de la oferta"</para>
    /// labels<para>"Tipo de exámen"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#examen">http://purl.org/ctic/empleo/oferta#examen</seealso>
    let examen = Prefixed_Name(emp, "examen") |> PrefixedName
    /// <summary>
    ///   <para>emp:expediente</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Expediente relacionado con la oferta"</para>
    /// labels<para>"Expediente"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#expediente">http://purl.org/ctic/empleo/oferta#expediente</seealso>
    let expediente = Prefixed_Name(emp, "expediente") |> PrefixedName
    /// <summary>
    ///   <para>emp:fechaPresentacion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Fecha límite de presentación de la instancia para la oferta en formato “ISO 8601”"</para>
    /// labels<para>"Fecha de presentación de la instancia"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#fechaPresentacion">http://purl.org/ctic/empleo/oferta#fechaPresentacion</seealso>
    let fechaPresentacion = Prefixed_Name(emp, "fechaPresentacion") |> PrefixedName
    /// <summary>
    ///   <para>emp:grupoProfesional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Grupo de clasificación profesional"</para>
    /// labels<para>"Grupo Profesional"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#grupoProfesional">http://purl.org/ctic/empleo/oferta#grupoProfesional</seealso>
    let grupoProfesional = Prefixed_Name(emp, "grupoProfesional") |> PrefixedName
    /// <summary>
    ///   <para>emp:jornada</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Jornada laboral que tendrá el puesto laboral de la oferta de empleo"</para>
    /// labels<para>"Jornada laboral"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#jornada">http://purl.org/ctic/empleo/oferta#jornada</seealso>
    let jornada = Prefixed_Name(emp, "jornada") |> PrefixedName
    /// <summary>
    ///   <para>emp:plantillaPersonal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"El tipo de plantilla de personal del puesto de trabajo"</para>
    /// labels<para>"Plantilla de personal"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#plantillaPersonal">http://purl.org/ctic/empleo/oferta#plantillaPersonal</seealso>
    let plantillaPersonal = Prefixed_Name(emp, "plantillaPersonal") |> PrefixedName
    /// <summary>
    ///   <para>emp:plazasInternas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Número de plazas reservadas a promoción interna en la oferta de trabajo"</para>
    /// labels<para>"Número de plazas para promoción interna"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#plazasInternas">http://purl.org/ctic/empleo/oferta#plazasInternas</seealso>
    let plazasInternas = Prefixed_Name(emp, "plazasInternas") |> PrefixedName
    /// <summary>
    ///   <para>emp:plazasMinusvalidos</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Número de plazas reservadas a personas discapacitadas para el puesto de trabajo"</para>
    /// labels<para>"Número de plazas para minusválidos"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#plazasMinusvalidos">http://purl.org/ctic/empleo/oferta#plazasMinusvalidos</seealso>
    let plazasMinusvalidos = Prefixed_Name(emp, "plazasMinusvalidos") |> PrefixedName
    /// <summary>
    ///   <para>emp:plazasTotal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Número de plazas para el puesto de trabajo"</para>
    /// labels<para>"Plazas totales"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#plazasTotal">http://purl.org/ctic/empleo/oferta#plazasTotal</seealso>
    let plazasTotal = Prefixed_Name(emp, "plazasTotal") |> PrefixedName
    /// <summary>
    ///   <para>emp:requisito</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Requisitos generales necesarios y/o deseados para acceder al puesto de trabajo"</para>
    /// labels<para>"Requisito"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#requisito">http://purl.org/ctic/empleo/oferta#requisito</seealso>
    let requisito = Prefixed_Name(emp, "requisito") |> PrefixedName

    /// <summary>
    ///   <para>emp:requisito-experiencia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Experiencia mínima necesario para acceder al puesto de trabajo"</para>
    /// labels<para>"Experiencia"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#requisito-experiencia">http://purl.org/ctic/empleo/oferta#requisito-experiencia</seealso>
    let requisito_experiencia =
        Prefixed_Name(emp, "requisito-experiencia") |> PrefixedName

    /// <summary>
    ///   <para>emp:requisito-formacion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Formación mínima necesaria y/o la formación deseada para acceder al puesto de trabajo"</para>
    /// labels<para>"Formación"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#requisito-formacion">http://purl.org/ctic/empleo/oferta#requisito-formacion</seealso>
    let requisito_formacion = Prefixed_Name(emp, "requisito-formacion") |> PrefixedName
    /// <summary>
    ///   <para>emp:requisito-idiomas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Conocimientos de idiomas necesarios y/o deseados para acceder al puesto de trabajo"</para>
    /// labels<para>"Idiomas"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#requisito-idiomas">http://purl.org/ctic/empleo/oferta#requisito-idiomas</seealso>
    let requisito_idiomas = Prefixed_Name(emp, "requisito-idiomas") |> PrefixedName

    /// <summary>
    ///   <para>emp:requisito-inform%C3%A1tica</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Conocimientos de informática necesarios y/o deseados para acceder al puesto de trabajo"</para>
    /// labels<para>"Informática"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#requisito-inform%C3%A1tica">http://purl.org/ctic/empleo/oferta#requisito-inform%C3%A1tica</seealso>
    let ``requisito_inform%C3%A1tica`` =
        Prefixed_Name(emp, "requisito-inform%C3%A1tica") |> PrefixedName

    /// <summary>
    ///   <para>emp:salario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Salario y/o remuneraciones del contrato ofertado para el puesto"</para>
    /// labels<para>"Salario"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#salario">http://purl.org/ctic/empleo/oferta#salario</seealso>
    let salario = Prefixed_Name(emp, "salario") |> PrefixedName
    /// <summary>
    ///   <para>emp:tipoContrato</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Tipo de contrato de la oferta de empleo. Referencia un concepto del esquema Tipos de contrato"</para>
    /// labels<para>"Tipo de contrato"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#tipoContrato">http://purl.org/ctic/empleo/oferta#tipoContrato</seealso>
    let tipoContrato = Prefixed_Name(emp, "tipoContrato") |> PrefixedName
    /// <summary>
    ///   <para>emp:titulacion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"La titulación que se requiere para la oferta de trabajo"</para>
    /// labels<para>"Titulación"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#titulacion">http://purl.org/ctic/empleo/oferta#titulacion</seealso>
    let titulacion = Prefixed_Name(emp, "titulacion") |> PrefixedName
    /// <summary>
    ///   <para>emp:tribunal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Tribunal que evaluará la convocatoria"</para>
    /// labels<para>"Tribunal"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#tribunal">http://purl.org/ctic/empleo/oferta#tribunal</seealso>
    let tribunal = Prefixed_Name(emp, "tribunal") |> PrefixedName
    /// <summary>
    ///   <para>emp:turno</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Turno de la oferta"</para>
    /// labels<para>"Turno"</para></remarks>
    /// <seealso href="http://purl.org/ctic/empleo/oferta#turno">http://purl.org/ctic/empleo/oferta#turno</seealso>
    let turno = Prefixed_Name(emp, "turno") |> PrefixedName
