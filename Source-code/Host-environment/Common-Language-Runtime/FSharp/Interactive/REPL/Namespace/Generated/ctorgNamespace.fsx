#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ctorg =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/ctic/infraestructuras/organizacion#" "ctorg"

    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:label : Centro de Servicios</para>
    ///   <para>rdfs:comment : Centro que ofrece servicios públicos</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/organizacion#CentroServicios">ctorg:CentroServicios</a>
    /// </summary>
    let CentroServicios = _prefixId.prefix "CentroServicios"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:label : Edificio</para>
    ///   <para>rdfs:comment : Un edificio donde se encuentra ubicado el centro de servicios</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/organizacion#Edificio">ctorg:Edificio</a>
    /// </summary>
    let Edificio = _prefixId.prefix "Edificio"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:label : Edificio municipal</para>
    ///   <para>rdfs:comment : Edificio perteneciente al Ayuntamiento</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/organizacion#EdificioMunicipal">ctorg:EdificioMunicipal</a>
    /// </summary>
    let EdificioMunicipal = _prefixId.prefix "EdificioMunicipal"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:label : Órgano público</para>
    ///   <para>rdfs:comment : Órgano del que depende</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/organizacion#OrganoPublico">ctorg:OrganoPublico</a>
    /// </summary>
    let OrganoPublico = _prefixId.prefix "OrganoPublico"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:label : Información sobre accesibilidad</para>
    ///   <para>rdfs:comment : Información relativa a la accesibilidad del centro. Es contenido textual</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/organizacion#accesibilidad">ctorg:accesibilidad</a>
    /// </summary>
    let accesibilidad = _prefixId.prefix "accesibilidad"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:label : Área de la organización</para>
    ///   <para>rdfs:comment : Área organizativa relacionada con los órganos públicos y sus servicios</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/organizacion#areaOrganizativa">ctorg:areaOrganizativa</a>
    /// </summary>
    let areaOrganizativa = _prefixId.prefix "areaOrganizativa"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:label : Acceso mediante bus municipal</para>
    ///   <para>rdfs:comment : Lista de líneas de autobús con parada cercana para acceso al edificio</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/organizacion#bus">ctorg:bus</a>
    /// </summary>
    let bus = _prefixId.prefix "bus"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:label : Centro de servicios</para>
    ///   <para>rdfs:comment : Un centro (o varios) asociado a un órgano público que ofrece servicios.</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/organizacion#centroServicios">ctorg:centroServicios</a>
    /// </summary>
    let centroServicios = _prefixId.prefix "centroServicios"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:label : Clasificación de los servicios prestados</para>
    ///   <para>rdfs:comment : Clasificación de los servicios prestados en el centro</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/organizacion#clasificacionServicios">ctorg:clasificacionServicios</a>
    /// </summary>
    let clasificacionServicios = _prefixId.prefix "clasificacionServicios"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:label : Órgano hijo</para>
    ///   <para>rdfs:comment : Órgano que es dependiente de éste</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/organizacion#depende">ctorg:depende</a>
    /// </summary>
    let depende = _prefixId.prefix "depende"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:label : Órgano padre</para>
    ///   <para>rdfs:comment : Órgano del que depende</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/organizacion#dependeDe">ctorg:dependeDe</a>
    /// </summary>
    let dependeDe = _prefixId.prefix "dependeDe"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:label : Dirección del edificio</para>
    ///   <para>rdfs:comment : Dirección postal del edificio</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/organizacion#direccion">ctorg:direccion</a>
    /// </summary>
    let direccion = _prefixId.prefix "direccion"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:label : Ubicación en edificio</para>
    ///   <para>rdfs:comment : Edificio donde se encuentra un centro que presta servicios</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/organizacion#edificio">ctorg:edificio</a>
    /// </summary>
    let edificio = _prefixId.prefix "edificio"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:label : Horario de apertura</para>
    ///   <para>rdfs:comment : Horario de apertura del centro</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/organizacion#horario">ctorg:horario</a>
    /// </summary>
    let horario = _prefixId.prefix "horario"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:label : Número de portal</para>
    ///   <para>rdfs:comment : Número del portal en el que se encuentra el edificio</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/organizacion#numeroPortal">ctorg:numeroPortal</a>
    /// </summary>
    let numeroPortal = _prefixId.prefix "numeroPortal"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:label : Órgano del que depende</para>
    ///   <para>rdfs:comment : El órgano público asociado al centro</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/organizacion#organoPublico">ctorg:organoPublico</a>
    /// </summary>
    let organoPublico = _prefixId.prefix "organoPublico"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:label : Planta (piso) del edificio</para>
    ///   <para>rdfs:comment : Indica la planta del edificio donde se encuentra el centro</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/organizacion#plantaEdificio">ctorg:plantaEdificio</a>
    /// </summary>
    let plantaEdificio = _prefixId.prefix "plantaEdificio"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:label : Servicios prestados</para>
    ///   <para>rdfs:comment : Servicios prestados en el centro</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/organizacion#servicios">ctorg:servicios</a>
    /// </summary>
    let servicios = _prefixId.prefix "servicios"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:label : Tipo de Centro</para>
    ///   <para>rdfs:comment : El tipo del centro</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/organizacion#tipoCentro">ctorg:tipoCentro</a>
    /// </summary>
    let tipoCentro = _prefixId.prefix "tipoCentro"
