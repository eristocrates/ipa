namespace http.datos.gob.es.def.sector_publico.organizacion.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module orges =
    let _namespace_iri = Namespace_Iri orges |> NamespaceIRI
    /// <summary>
    ///   <para>orges:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"Extensión de la ontología de Organizaciones para adecuarla al Directorio Común de entidades públicas en España."</para>
    /// </remarks>
    /// <seealso href="http://datos.gob.es/def/sector-publico/organizacion#">http://datos.gob.es/def/sector-publico/organizacion#</seealso>
    let _prefix_iri = Prefixed_Name(orges, "") |> PrefixedName
    /// <summary>
    ///   <para>orges:1.0.0</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://datos.gob.es/def/sector-publico/organizacion#1.0.0">http://datos.gob.es/def/sector-publico/organizacion#1.0.0</seealso>
    let ``_1.0.0`` = Prefixed_Name(orges, "1.0.0") |> PrefixedName

    /// <summary>
    ///   <para>orges:EntidadDerechoPublico</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Organismo creado para satisfacer necesidades de interés general, excluidos los de carácter mercantil o industrial; que tenga personalidad jurídica; que su actividad se financie mayoritariamente con fondos públicos o que su gestión esté sometida al control público o bien que más de la mitad de los miembros de su órgano de administración, de dirección o vigilancia, sean nombrados por el sector público.
    /// Morales, F. J. (2007). La Contratación del Sector Público. Recuperado el 17 de febrero de 2015, de https://books.google.es/books?id=RozAMdGDMDIC&amp;pg=PA1&amp;lpg=PA1&amp;dq=la+contratación+del+sector+publico+f.+javier+escrihuela"</para>
    /// labels<para>"Entidad de Derecho Público"</para></remarks>
    /// <seealso href="http://datos.gob.es/def/sector-publico/organizacion#EntidadDerechoPublico">http://datos.gob.es/def/sector-publico/organizacion#EntidadDerechoPublico</seealso>
    let EntidadDerechoPublico =
        Prefixed_Name(orges, "EntidadDerechoPublico") |> PrefixedName

    /// <summary>
    ///   <para>orges:Oficina</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Oficina de registro, información o tramitación que las distintas Administraciones Públicas ponen a disposición del Ciudadano."</para>
    /// labels<para>"Oficina"</para></remarks>
    /// <seealso href="http://datos.gob.es/def/sector-publico/organizacion#Oficina">http://datos.gob.es/def/sector-publico/organizacion#Oficina</seealso>
    let Oficina = Prefixed_Name(orges, "Oficina") |> PrefixedName
    /// <summary>
    ///   <para>orges:UGEP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Las UGEP son las unidades de rango inferior o independiente que queden excluidas del ámbito de una «org:FormalUnit."</para>
    /// labels<para>"Unidad con función de Gestión Económica-Presupuestaria"</para></remarks>
    /// <seealso href="http://datos.gob.es/def/sector-publico/organizacion#UGEP">http://datos.gob.es/def/sector-publico/organizacion#UGEP</seealso>
    let UGEP = Prefixed_Name(orges, "UGEP") |> PrefixedName

    /// <summary>
    ///   <para>orges:UnidadOrganicaNoRaiz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Unidad Orgánica con un nivel jerárquico mayor a 1, que depende de una Unidad Orgánica Raíz."</para>
    /// labels<para>"Unidad Orgánica No Raíz"</para></remarks>
    /// <seealso href="http://datos.gob.es/def/sector-publico/organizacion#UnidadOrganicaNoRaiz">http://datos.gob.es/def/sector-publico/organizacion#UnidadOrganicaNoRaiz</seealso>
    let UnidadOrganicaNoRaiz =
        Prefixed_Name(orges, "UnidadOrganicaNoRaiz") |> PrefixedName

    /// <summary>
    ///   <para>orges:ambitoCompetencias</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Ámbito territorial de ejercicio de competencias de una organización."</para>
    /// labels<para>"Ámbito de Competencias"</para></remarks>
    /// <seealso href="http://datos.gob.es/def/sector-publico/organizacion#ambitoCompetencias">http://datos.gob.es/def/sector-publico/organizacion#ambitoCompetencias</seealso>
    let ambitoCompetencias = Prefixed_Name(orges, "ambitoCompetencias") |> PrefixedName
    /// <summary>
    ///   <para>orges:diasInhabiles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Designa los días inhábiles.
    /// Los días inhábiles se tratan como una frase en lenguaje natural. Ejemplo: «Domingos y festivos de ámbito nacional, autonómico o local.»."</para>
    /// labels<para>"Días Inhábiles"</para></remarks>
    /// <seealso href="http://datos.gob.es/def/sector-publico/organizacion#diasInhabiles">http://datos.gob.es/def/sector-publico/organizacion#diasInhabiles</seealso>
    let diasInhabiles = Prefixed_Name(orges, "diasInhabiles") |> PrefixedName
    /// <summary>
    ///   <para>orges:disposicionLegal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Identificación de la Disposición Legal que regula las competencias de la organización.
    /// Ejemplo: En el caso del BOE se haría referencia al RD de creación del Organismo como Agencia Estatal: «REAL DECRETO 1495/2007 por el que se crea la Agencia Estatal Boletín Oficial del Estado y se aprueba su estatuto»."</para>
    /// labels<para>"Disposición Legal"</para></remarks>
    /// <seealso href="http://datos.gob.es/def/sector-publico/organizacion#disposicionLegal">http://datos.gob.es/def/sector-publico/organizacion#disposicionLegal</seealso>
    let disposicionLegal = Prefixed_Name(orges, "disposicionLegal") |> PrefixedName
    /// <summary>
    ///   <para>orges:estado</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Estatus o situación jurídico/funcional de una organización."</para>
    /// labels<para>"Estado"</para></remarks>
    /// <seealso href="http://datos.gob.es/def/sector-publico/organizacion#estado">http://datos.gob.es/def/sector-publico/organizacion#estado</seealso>
    let estado = Prefixed_Name(orges, "estado") |> PrefixedName
    /// <summary>
    ///   <para>orges:horarioAtencion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Define el horario de atención al ciudadano de la organización.
    /// El horario de atención se trata como una frase en lenguaje natural. Ejemplo: «Horario: De lunes a viernes de 8:30 a 14:30h. y de 16:10 a 18:30h. Sábados de 9:10 a 13:30. Horario de verano: … »."</para>
    /// labels<para>"Horario de Atención"</para></remarks>
    /// <seealso href="http://datos.gob.es/def/sector-publico/organizacion#horarioAtencion">http://datos.gob.es/def/sector-publico/organizacion#horarioAtencion</seealso>
    let horarioAtencion = Prefixed_Name(orges, "horarioAtencion") |> PrefixedName

    /// <summary>
    ///   <para>orges:identificadorExterno</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Código externo que designa una organización según la codificación propia de la fuente de provisión."</para>
    /// labels<para>"IdentificadorExterno"</para></remarks>
    /// <seealso href="http://datos.gob.es/def/sector-publico/organizacion#identificadorExterno">http://datos.gob.es/def/sector-publico/organizacion#identificadorExterno</seealso>
    let identificadorExterno =
        Prefixed_Name(orges, "identificadorExterno") |> PrefixedName

    /// <summary>
    ///   <para>orges:nivelAdministracion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Nivel territorial de administración al que pertenece la organización, según el artículo 2.1 de la Ley 30/1992."</para>
    /// labels<para>"Nivel de Administración"</para></remarks>
    /// <seealso href="http://datos.gob.es/def/sector-publico/organizacion#nivelAdministracion">http://datos.gob.es/def/sector-publico/organizacion#nivelAdministracion</seealso>
    let nivelAdministracion =
        Prefixed_Name(orges, "nivelAdministracion") |> PrefixedName

    /// <summary>
    ///   <para>orges:nivelJerarquico</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Secuencial que identifica el nivel jerárquico relativo de la organización dentro de la entidad a la que pertenece.
    /// Para la raíz de un nivel de administración, este campo deberá ser 0. Para la unidad principal (de máximo nivel) de cualquier Ministerio, Comunidad Autónoma o Entidad Local el campo tomará el valor 1. Más allá de esto, el número se irá incrementando según convenga."</para>
    /// labels<para>"Nivel Jerárquico"</para></remarks>
    /// <seealso href="http://datos.gob.es/def/sector-publico/organizacion#nivelJerarquico">http://datos.gob.es/def/sector-publico/organizacion#nivelJerarquico</seealso>
    let nivelJerarquico = Prefixed_Name(orges, "nivelJerarquico") |> PrefixedName
    /// <summary>
    ///   <para>orges:observacionBaja</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Observaciones relacionadas con la baja de la organización."</para>
    /// labels<para>"Observación de Baja"</para></remarks>
    /// <seealso href="http://datos.gob.es/def/sector-publico/organizacion#observacionBaja">http://datos.gob.es/def/sector-publico/organizacion#observacionBaja</seealso>
    let observacionBaja = Prefixed_Name(orges, "observacionBaja") |> PrefixedName
    /// <summary>
    ///   <para>orges:otroContacto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Cualquier dato de contacto adicional que no se encuentre definido en el DIR3."</para>
    /// labels<para>"Otro Contacto"</para></remarks>
    /// <seealso href="http://datos.gob.es/def/sector-publico/organizacion#otroContacto">http://datos.gob.es/def/sector-publico/organizacion#otroContacto</seealso>
    let otroContacto = Prefixed_Name(orges, "otroContacto") |> PrefixedName
    /// <summary>
    ///   <para>orges:servicio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Servicios que puede prestar una determinada oficina."</para>
    /// labels<para>"Servicio"</para></remarks>
    /// <seealso href="http://datos.gob.es/def/sector-publico/organizacion#servicio">http://datos.gob.es/def/sector-publico/organizacion#servicio</seealso>
    let servicio = Prefixed_Name(orges, "servicio") |> PrefixedName
    /// <summary>
    ///   <para>orges:tieneUORaiz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Organización, al nivel máximo de jerarquía de que depende otra organización."</para>
    /// labels<para>"Tiene Unidad Orgánica Raíz"</para></remarks>
    /// <seealso href="http://datos.gob.es/def/sector-publico/organizacion#tieneUORaiz">http://datos.gob.es/def/sector-publico/organizacion#tieneUORaiz</seealso>
    let tieneUORaiz = Prefixed_Name(orges, "tieneUORaiz") |> PrefixedName
