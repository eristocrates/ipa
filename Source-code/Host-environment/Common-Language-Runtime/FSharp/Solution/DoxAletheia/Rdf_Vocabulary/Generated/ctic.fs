namespace http.purl.org.ctic.infraestructuras.localizacion.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ctic =
    let _namespace_iri = Namespace_Iri ctic |> NamespaceIRI
    /// <summary>
    ///   <para>ctic:Autonomia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Comunidad Autónoma o Ciudad Autónoma, que disponen de mediante normas y órganos de gobierno propios"</para>
    /// labels<para>"Autonomía"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/localizacion#Autonomia">http://purl.org/ctic/infraestructuras/localizacion#Autonomia</seealso>
    let Autonomia = Prefixed_Name(ctic, "Autonomia") |> PrefixedName
    /// <summary>
    ///   <para>ctic:Barrio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cada una de las partes en que se dividen los distritos de los municipios"</para>
    /// labels<para>"Barrio"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/localizacion#Barrio">http://purl.org/ctic/infraestructuras/localizacion#Barrio</seealso>
    let Barrio = Prefixed_Name(ctic, "Barrio") |> PrefixedName
    /// <summary>
    ///   <para>ctic:Calle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Vía urbana"</para>
    /// labels<para>"Calle"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/localizacion#Calle">http://purl.org/ctic/infraestructuras/localizacion#Calle</seealso>
    let Calle = Prefixed_Name(ctic, "Calle") |> PrefixedName
    /// <summary>
    ///   <para>ctic:Direccion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Dirección postal"</para>
    /// labels<para>"Dirección"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/localizacion#Direccion">http://purl.org/ctic/infraestructuras/localizacion#Direccion</seealso>
    let Direccion = Prefixed_Name(ctic, "Direccion") |> PrefixedName
    /// <summary>
    ///   <para>ctic:Distrito</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cada una de las demarcaciones en que se subdivide un territorio o una población para distribuir y ordenar el ejercicio de los derechos civiles y políticos, o de las funciones públicas, o de los servicios administrativos"</para>
    /// labels<para>"Distrito"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/localizacion#Distrito">http://purl.org/ctic/infraestructuras/localizacion#Distrito</seealso>
    let Distrito = Prefixed_Name(ctic, "Distrito") |> PrefixedName
    /// <summary>
    ///   <para>ctic:JuntaAdministrativa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Junta administrativa que rige los intereses de un pueblo que, en unión con otros, forma un municipio"</para>
    /// labels<para>"Junta administrativa"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/localizacion#JuntaAdministrativa">http://purl.org/ctic/infraestructuras/localizacion#JuntaAdministrativa</seealso>
    let JuntaAdministrativa = Prefixed_Name(ctic, "JuntaAdministrativa") |> PrefixedName
    /// <summary>
    ///   <para>ctic:Municipio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Término jurisdiccional, regido por un ayuntamiento"</para>
    /// labels<para>"Municipio"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/localizacion#Municipio">http://purl.org/ctic/infraestructuras/localizacion#Municipio</seealso>
    let Municipio = Prefixed_Name(ctic, "Municipio") |> PrefixedName
    /// <summary>
    ///   <para>ctic:Pais</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"País o nación"</para>
    /// labels<para>"País"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/localizacion#Pais">http://purl.org/ctic/infraestructuras/localizacion#Pais</seealso>
    let Pais = Prefixed_Name(ctic, "Pais") |> PrefixedName
    /// <summary>
    ///   <para>ctic:Provincia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cada una de las grandes divisiones de una Autonomía"</para>
    /// labels<para>"Provincia"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/localizacion#Provincia">http://purl.org/ctic/infraestructuras/localizacion#Provincia</seealso>
    let Provincia = Prefixed_Name(ctic, "Provincia") |> PrefixedName
    /// <summary>
    ///   <para>ctic:TramoCalle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Tramo parcial o total de una vía pública"</para>
    /// labels<para>"Tramo de calle"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/localizacion#TramoCalle">http://purl.org/ctic/infraestructuras/localizacion#TramoCalle</seealso>
    let TramoCalle = Prefixed_Name(ctic, "TramoCalle") |> PrefixedName
    /// <summary>
    ///   <para>ctic:barrio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Barrio al que pertenece una dirección de un edificio"</para>
    /// labels<para>"Barrio"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/localizacion#barrio">http://purl.org/ctic/infraestructuras/localizacion#barrio</seealso>
    let barrio = Prefixed_Name(ctic, "barrio") |> PrefixedName
    /// <summary>
    ///   <para>ctic:calle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Calle a la que pertenece una dirección de un edificio"</para>
    /// labels<para>"Calle"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/localizacion#calle">http://purl.org/ctic/infraestructuras/localizacion#calle</seealso>
    let calle = Prefixed_Name(ctic, "calle") |> PrefixedName
    /// <summary>
    ///   <para>ctic:iae</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Valor del Impuesto sobre Actividades Económicas relativo al tramo de calle"</para>
    /// labels<para>"IAE"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/localizacion#iae">http://purl.org/ctic/infraestructuras/localizacion#iae</seealso>
    let iae = Prefixed_Name(ctic, "iae") |> PrefixedName
    /// <summary>
    ///   <para>ctic:juntaAdministrativa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Junta Administrativa a la que pertenece una dirección de un edificio"</para>
    /// labels<para>"Junta administrativa"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/localizacion#juntaAdministrativa">http://purl.org/ctic/infraestructuras/localizacion#juntaAdministrativa</seealso>
    let juntaAdministrativa = Prefixed_Name(ctic, "juntaAdministrativa") |> PrefixedName
    /// <summary>
    ///   <para>ctic:numeroFinTramo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Número de la calle donde finaliza el tramo"</para>
    /// labels<para>"Número final de la calle (par o impar)"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/localizacion#numeroFinTramo">http://purl.org/ctic/infraestructuras/localizacion#numeroFinTramo</seealso>
    let numeroFinTramo = Prefixed_Name(ctic, "numeroFinTramo") |> PrefixedName
    /// <summary>
    ///   <para>ctic:numeroInicioTramo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Número de la calle donde comienza el tramo"</para>
    /// labels<para>"Número inicial de la calle (par o impar)"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/localizacion#numeroInicioTramo">http://purl.org/ctic/infraestructuras/localizacion#numeroInicioTramo</seealso>
    let numeroInicioTramo = Prefixed_Name(ctic, "numeroInicioTramo") |> PrefixedName
