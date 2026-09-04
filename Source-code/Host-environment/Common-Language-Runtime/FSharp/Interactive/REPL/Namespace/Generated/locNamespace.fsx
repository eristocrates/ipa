#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module loc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/ctic/infraestructuras/localizacion#" "loc"

    /// <summary>
    ///   <para>dcterms:issued : 2011-11-05^^xsd:string</para>
    ///   <para>rdfs:comment : Comunidad Autónoma o Ciudad Autónoma, que disponen de mediante normas y órganos de gobierno propios</para>
    ///   <para>rdfs:label : Autonomía</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/localizacion#Autonomia">loc:Autonomia</a>
    /// </summary>
    let Autonomia = _prefixId.prefix "Autonomia"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Cada una de las partes en que se dividen los distritos de los municipios</para>
    ///   <para>rdfs:label : Barrio</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/localizacion#Barrio">loc:Barrio</a>
    /// </summary>
    let Barrio = _prefixId.prefix "Barrio"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Vía urbana</para>
    ///   <para>rdfs:label : Calle</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/localizacion#Calle">loc:Calle</a>
    /// </summary>
    let Calle = _prefixId.prefix "Calle"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Dirección postal</para>
    ///   <para>rdfs:label : Dirección</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/localizacion#Direccion">loc:Direccion</a>
    /// </summary>
    let Direccion = _prefixId.prefix "Direccion"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Cada una de las demarcaciones en que se subdivide un territorio o una población para distribuir y ordenar el ejercicio de los derechos civiles y políticos, o de las funciones públicas, o de los servicios administrativos</para>
    ///   <para>rdfs:label : Distrito</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/localizacion#Distrito">loc:Distrito</a>
    /// </summary>
    let Distrito = _prefixId.prefix "Distrito"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Junta administrativa que rige los intereses de un pueblo que, en unión con otros, forma un municipio</para>
    ///   <para>rdfs:label : Junta administrativa</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/localizacion#JuntaAdministrativa">loc:JuntaAdministrativa</a>
    /// </summary>
    let JuntaAdministrativa = _prefixId.prefix "JuntaAdministrativa"
    /// <summary>
    ///   <para>dcterms:issued : 2011-11-05^^xsd:string</para>
    ///   <para>rdfs:comment : Término jurisdiccional, regido por un ayuntamiento</para>
    ///   <para>rdfs:label : Municipio</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/localizacion#Municipio">loc:Municipio</a>
    /// </summary>
    let Municipio = _prefixId.prefix "Municipio"
    /// <summary>
    ///   <para>dcterms:issued : 2011-11-05^^xsd:string</para>
    ///   <para>rdfs:comment : País o nación</para>
    ///   <para>rdfs:label : País</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/localizacion#Pais">loc:Pais</a>
    /// </summary>
    let Pais = _prefixId.prefix "Pais"
    /// <summary>
    ///   <para>dcterms:issued : 2011-11-05^^xsd:string</para>
    ///   <para>rdfs:comment : Cada una de las grandes divisiones de una Autonomía</para>
    ///   <para>rdfs:label : Provincia</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/localizacion#Provincia">loc:Provincia</a>
    /// </summary>
    let Provincia = _prefixId.prefix "Provincia"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Tramo parcial o total de una vía pública</para>
    ///   <para>rdfs:label : Tramo de calle</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/localizacion#TramoCalle">loc:TramoCalle</a>
    /// </summary>
    let TramoCalle = _prefixId.prefix "TramoCalle"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Barrio al que pertenece una dirección de un edificio</para>
    ///   <para>rdfs:label : Barrio</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/localizacion#barrio">loc:barrio</a>
    /// </summary>
    let barrio = _prefixId.prefix "barrio"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Calle a la que pertenece una dirección de un edificio</para>
    ///   <para>rdfs:label : Calle</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/localizacion#calle">loc:calle</a>
    /// </summary>
    let calle = _prefixId.prefix "calle"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Valor del Impuesto sobre Actividades Económicas relativo al tramo de calle</para>
    ///   <para>rdfs:label : IAE</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/localizacion#iae">loc:iae</a>
    /// </summary>
    let iae = _prefixId.prefix "iae"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Junta Administrativa a la que pertenece una dirección de un edificio</para>
    ///   <para>rdfs:label : Junta administrativa</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/localizacion#juntaAdministrativa">loc:juntaAdministrativa</a>
    /// </summary>
    let juntaAdministrativa = _prefixId.prefix "juntaAdministrativa"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Número de la calle donde finaliza el tramo</para>
    ///   <para>rdfs:label : Número final de la calle (par o impar)</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/localizacion#numeroFinTramo">loc:numeroFinTramo</a>
    /// </summary>
    let numeroFinTramo = _prefixId.prefix "numeroFinTramo"
    /// <summary>
    ///   <para>dcterms:issued : 2010-10-01^^xsd:string</para>
    ///   <para>rdfs:comment : Número de la calle donde comienza el tramo</para>
    ///   <para>rdfs:label : Número inicial de la calle (par o impar)</para>
    ///   <a href="http://purl.org/ctic/infraestructuras/localizacion#numeroInicioTramo">loc:numeroInicioTramo</a>
    /// </summary>
    let numeroInicioTramo = _prefixId.prefix "numeroInicioTramo"
