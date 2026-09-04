#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module orges =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://datos.gob.es/def/sector-publico/organizacion#" "orges"

    let _namespaceIri = _prefixId.prefix ""
    let ``_1.0.0`` = _prefixId.prefix "1.0.0"
    /// <summary>
    ///   <para>dcterms:issued : 2015-19-02^^xsd:string</para>
    ///   <para>rdfs:label : Entidad de Derecho Público</para>
    ///   <para>rdfs:comment : Organismo creado para satisfacer necesidades de interés general, excluidos los de carácter mercantil o industrial; que tenga personalidad jurídica; que su actividad se financie mayoritariamente con fondos públicos o que su gestión esté sometida al control público o bien que más de la mitad de los miembros de su órgano de administración, de dirección o vigilancia, sean nombrados por el sector público.
    /// Morales, F. J. (2007). La Contratación del Sector Público. Recuperado el 17 de febrero de 2015, de https://books.google.es/books?id=RozAMdGDMDIC&amp;pg=PA1&amp;lpg=PA1&amp;dq=la+contratación+del+sector+publico+f.+javier+escrihuela</para>
    ///   <a href="http://datos.gob.es/def/sector-publico/organizacion#EntidadDerechoPublico">orges:EntidadDerechoPublico</a>
    /// </summary>
    let EntidadDerechoPublico = _prefixId.prefix "EntidadDerechoPublico"
    /// <summary>
    ///   <para>dcterms:issued : 2015-19-02^^xsd:string</para>
    ///   <para>rdfs:label : Oficina</para>
    ///   <para>rdfs:comment : Oficina de registro, información o tramitación que las distintas Administraciones Públicas ponen a disposición del Ciudadano.</para>
    ///   <a href="http://datos.gob.es/def/sector-publico/organizacion#Oficina">orges:Oficina</a>
    /// </summary>
    let Oficina = _prefixId.prefix "Oficina"
    /// <summary>
    ///   <para>dcterms:issued : 2015-02-19^^xsd:string</para>
    ///   <para>rdfs:label : Unidad con función de Gestión Económica-Presupuestaria</para>
    ///   <para>rdfs:comment : Las UGEP son las unidades de rango inferior o independiente que queden excluidas del ámbito de una «org:FormalUnit.</para>
    ///   <a href="http://datos.gob.es/def/sector-publico/organizacion#UGEP">orges:UGEP</a>
    /// </summary>
    let UGEP = _prefixId.prefix "UGEP"
    /// <summary>
    ///   <para>dcterms:issued : 2015-19-02^^xsd:string</para>
    ///   <para>rdfs:label : Unidad Orgánica No Raíz</para>
    ///   <para>rdfs:comment : Unidad Orgánica con un nivel jerárquico mayor a 1, que depende de una Unidad Orgánica Raíz.</para>
    ///   <a href="http://datos.gob.es/def/sector-publico/organizacion#UnidadOrganicaNoRaiz">orges:UnidadOrganicaNoRaiz</a>
    /// </summary>
    let UnidadOrganicaNoRaiz = _prefixId.prefix "UnidadOrganicaNoRaiz"
    /// <summary>
    ///   <para>dcterms:issued : 2015-02-19^^xsd:string</para>
    ///   <para>rdfs:label : Ámbito de Competencias</para>
    ///   <para>rdfs:comment : Ámbito territorial de ejercicio de competencias de una organización.</para>
    ///   <a href="http://datos.gob.es/def/sector-publico/organizacion#ambitoCompetencias">orges:ambitoCompetencias</a>
    /// </summary>
    let ambitoCompetencias = _prefixId.prefix "ambitoCompetencias"
    /// <summary>
    ///   <para>dcterms:issued : 2015-02-19^^xsd:string</para>
    ///   <para>rdfs:label : Días Inhábiles</para>
    ///   <para>rdfs:comment : Designa los días inhábiles.
    /// Los días inhábiles se tratan como una frase en lenguaje natural. Ejemplo: «Domingos y festivos de ámbito nacional, autonómico o local.».</para>
    ///   <a href="http://datos.gob.es/def/sector-publico/organizacion#diasInhabiles">orges:diasInhabiles</a>
    /// </summary>
    let diasInhabiles = _prefixId.prefix "diasInhabiles"
    /// <summary>
    ///   <para>dcterms:issued : 2015-02-19^^xsd:string</para>
    ///   <para>rdfs:label : Disposición Legal</para>
    ///   <para>rdfs:comment : Identificación de la Disposición Legal que regula las competencias de la organización.
    /// Ejemplo: En el caso del BOE se haría referencia al RD de creación del Organismo como Agencia Estatal: «REAL DECRETO 1495/2007 por el que se crea la Agencia Estatal Boletín Oficial del Estado y se aprueba su estatuto».</para>
    ///   <a href="http://datos.gob.es/def/sector-publico/organizacion#disposicionLegal">orges:disposicionLegal</a>
    /// </summary>
    let disposicionLegal = _prefixId.prefix "disposicionLegal"
    /// <summary>
    ///   <para>dcterms:issued : 2015-02-19^^xsd:string</para>
    ///   <para>rdfs:label : Estado</para>
    ///   <para>rdfs:comment : Estatus o situación jurídico/funcional de una organización.</para>
    ///   <a href="http://datos.gob.es/def/sector-publico/organizacion#estado">orges:estado</a>
    /// </summary>
    let estado = _prefixId.prefix "estado"
    /// <summary>
    ///   <para>dcterms:issued : 2015-02-19^^xsd:string</para>
    ///   <para>rdfs:label : Horario de Atención</para>
    ///   <para>rdfs:comment : Define el horario de atención al ciudadano de la organización.
    /// El horario de atención se trata como una frase en lenguaje natural. Ejemplo: «Horario: De lunes a viernes de 8:30 a 14:30h. y de 16:10 a 18:30h. Sábados de 9:10 a 13:30. Horario de verano: … ».</para>
    ///   <a href="http://datos.gob.es/def/sector-publico/organizacion#horarioAtencion">orges:horarioAtencion</a>
    /// </summary>
    let horarioAtencion = _prefixId.prefix "horarioAtencion"
    /// <summary>
    ///   <para>dcterms:issued : 2015-02-19^^xsd:string</para>
    ///   <para>rdfs:label : IdentificadorExterno</para>
    ///   <para>rdfs:comment : Código externo que designa una organización según la codificación propia de la fuente de provisión.</para>
    ///   <a href="http://datos.gob.es/def/sector-publico/organizacion#identificadorExterno">orges:identificadorExterno</a>
    /// </summary>
    let identificadorExterno = _prefixId.prefix "identificadorExterno"
    /// <summary>
    ///   <para>dcterms:issued : 2015-02-19^^xsd:string</para>
    ///   <para>rdfs:label : Nivel de Administración</para>
    ///   <para>rdfs:comment : Nivel territorial de administración al que pertenece la organización, según el artículo 2.1 de la Ley 30/1992.</para>
    ///   <a href="http://datos.gob.es/def/sector-publico/organizacion#nivelAdministracion">orges:nivelAdministracion</a>
    /// </summary>
    let nivelAdministracion = _prefixId.prefix "nivelAdministracion"
    /// <summary>
    ///   <para>dcterms:issued : 2015-02-19^^xsd:string</para>
    ///   <para>rdfs:label : Nivel Jerárquico</para>
    ///   <para>rdfs:comment : Secuencial que identifica el nivel jerárquico relativo de la organización dentro de la entidad a la que pertenece.
    /// Para la raíz de un nivel de administración, este campo deberá ser 0. Para la unidad principal (de máximo nivel) de cualquier Ministerio, Comunidad Autónoma o Entidad Local el campo tomará el valor 1. Más allá de esto, el número se irá incrementando según convenga.</para>
    ///   <a href="http://datos.gob.es/def/sector-publico/organizacion#nivelJerarquico">orges:nivelJerarquico</a>
    /// </summary>
    let nivelJerarquico = _prefixId.prefix "nivelJerarquico"
    /// <summary>
    ///   <para>dcterms:issued : 2015-02-19^^xsd:string</para>
    ///   <para>rdfs:label : Observación de Baja</para>
    ///   <para>rdfs:comment : Observaciones relacionadas con la baja de la organización.</para>
    ///   <a href="http://datos.gob.es/def/sector-publico/organizacion#observacionBaja">orges:observacionBaja</a>
    /// </summary>
    let observacionBaja = _prefixId.prefix "observacionBaja"
    /// <summary>
    ///   <para>dcterms:issued : 2015-02-19^^xsd:string</para>
    ///   <para>rdfs:label : Otro Contacto</para>
    ///   <para>rdfs:comment : Cualquier dato de contacto adicional que no se encuentre definido en el DIR3.</para>
    ///   <a href="http://datos.gob.es/def/sector-publico/organizacion#otroContacto">orges:otroContacto</a>
    /// </summary>
    let otroContacto = _prefixId.prefix "otroContacto"
    /// <summary>
    ///   <para>dcterms:issued : 2015-02-19^^xsd:string</para>
    ///   <para>rdfs:label : Servicio</para>
    ///   <para>rdfs:comment : Servicios que puede prestar una determinada oficina.</para>
    ///   <a href="http://datos.gob.es/def/sector-publico/organizacion#servicio">orges:servicio</a>
    /// </summary>
    let servicio = _prefixId.prefix "servicio"
    /// <summary>
    ///   <para>dcterms:issued : 2015-02-19^^xsd:string</para>
    ///   <para>rdfs:label : Tiene Unidad Orgánica Raíz</para>
    ///   <para>rdfs:comment : Organización, al nivel máximo de jerarquía de que depende otra organización.</para>
    ///   <a href="http://datos.gob.es/def/sector-publico/organizacion#tieneUORaiz">orges:tieneUORaiz</a>
    /// </summary>
    let tieneUORaiz = _prefixId.prefix "tieneUORaiz"
