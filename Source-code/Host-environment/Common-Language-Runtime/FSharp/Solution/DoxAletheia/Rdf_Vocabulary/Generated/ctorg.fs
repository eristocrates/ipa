namespace http.purl.org.ctic.infraestructuras.organizacion.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ctorg =
    let _namespace_iri = Namespace_Iri ctorg |> NamespaceIRI
    /// <summary>
    ///   <para>ctorg:CentroServicios</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Centro que ofrece servicios públicos"</para>
    /// labels<para>"Centro de Servicios"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/organizacion#CentroServicios">http://purl.org/ctic/infraestructuras/organizacion#CentroServicios</seealso>
    let CentroServicios = Prefixed_Name(ctorg, "CentroServicios") |> PrefixedName
    /// <summary>
    ///   <para>ctorg:Edificio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Un edificio donde se encuentra ubicado el centro de servicios"</para>
    /// labels<para>"Edificio"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/organizacion#Edificio">http://purl.org/ctic/infraestructuras/organizacion#Edificio</seealso>
    let Edificio = Prefixed_Name(ctorg, "Edificio") |> PrefixedName
    /// <summary>
    ///   <para>ctorg:EdificioMunicipal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Edificio perteneciente al Ayuntamiento"</para>
    /// labels<para>"Edificio municipal"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/organizacion#EdificioMunicipal">http://purl.org/ctic/infraestructuras/organizacion#EdificioMunicipal</seealso>
    let EdificioMunicipal = Prefixed_Name(ctorg, "EdificioMunicipal") |> PrefixedName
    /// <summary>
    ///   <para>ctorg:OrganoPublico</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Órgano del que depende"</para>
    /// labels<para>"Órgano público"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/organizacion#OrganoPublico">http://purl.org/ctic/infraestructuras/organizacion#OrganoPublico</seealso>
    let OrganoPublico = Prefixed_Name(ctorg, "OrganoPublico") |> PrefixedName
    /// <summary>
    ///   <para>ctorg:accesibilidad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Información relativa a la accesibilidad del centro. Es contenido textual"</para>
    /// labels<para>"Información sobre accesibilidad"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/organizacion#accesibilidad">http://purl.org/ctic/infraestructuras/organizacion#accesibilidad</seealso>
    let accesibilidad = Prefixed_Name(ctorg, "accesibilidad") |> PrefixedName
    /// <summary>
    ///   <para>ctorg:areaOrganizativa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Área organizativa relacionada con los órganos públicos y sus servicios"</para>
    /// labels<para>"Área de la organización"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/organizacion#areaOrganizativa">http://purl.org/ctic/infraestructuras/organizacion#areaOrganizativa</seealso>
    let areaOrganizativa = Prefixed_Name(ctorg, "areaOrganizativa") |> PrefixedName
    /// <summary>
    ///   <para>ctorg:bus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Lista de líneas de autobús con parada cercana para acceso al edificio"</para>
    /// labels<para>"Acceso mediante bus municipal"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/organizacion#bus">http://purl.org/ctic/infraestructuras/organizacion#bus</seealso>
    let bus = Prefixed_Name(ctorg, "bus") |> PrefixedName
    /// <summary>
    ///   <para>ctorg:centroServicios</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Un centro (o varios) asociado a un órgano público que ofrece servicios."</para>
    /// labels<para>"Centro de servicios"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/organizacion#centroServicios">http://purl.org/ctic/infraestructuras/organizacion#centroServicios</seealso>
    let centroServicios = Prefixed_Name(ctorg, "centroServicios") |> PrefixedName

    /// <summary>
    ///   <para>ctorg:clasificacionServicios</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Clasificación de los servicios prestados en el centro"</para>
    /// labels<para>"Clasificación de los servicios prestados"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/organizacion#clasificacionServicios">http://purl.org/ctic/infraestructuras/organizacion#clasificacionServicios</seealso>
    let clasificacionServicios =
        Prefixed_Name(ctorg, "clasificacionServicios") |> PrefixedName

    /// <summary>
    ///   <para>ctorg:depende</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Órgano que es dependiente de éste"</para>
    /// labels<para>"Órgano hijo"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/organizacion#depende">http://purl.org/ctic/infraestructuras/organizacion#depende</seealso>
    let depende = Prefixed_Name(ctorg, "depende") |> PrefixedName
    /// <summary>
    ///   <para>ctorg:dependeDe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Órgano del que depende"</para>
    /// labels<para>"Órgano padre"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/organizacion#dependeDe">http://purl.org/ctic/infraestructuras/organizacion#dependeDe</seealso>
    let dependeDe = Prefixed_Name(ctorg, "dependeDe") |> PrefixedName
    /// <summary>
    ///   <para>ctorg:direccion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Dirección postal del edificio"</para>
    /// labels<para>"Dirección del edificio"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/organizacion#direccion">http://purl.org/ctic/infraestructuras/organizacion#direccion</seealso>
    let direccion = Prefixed_Name(ctorg, "direccion") |> PrefixedName
    /// <summary>
    ///   <para>ctorg:edificio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Edificio donde se encuentra un centro que presta servicios"</para>
    /// labels<para>"Ubicación en edificio"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/organizacion#edificio">http://purl.org/ctic/infraestructuras/organizacion#edificio</seealso>
    let edificio = Prefixed_Name(ctorg, "edificio") |> PrefixedName
    /// <summary>
    ///   <para>ctorg:horario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Horario de apertura del centro"</para>
    /// labels<para>"Horario de apertura"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/organizacion#horario">http://purl.org/ctic/infraestructuras/organizacion#horario</seealso>
    let horario = Prefixed_Name(ctorg, "horario") |> PrefixedName
    /// <summary>
    ///   <para>ctorg:numeroPortal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Número del portal en el que se encuentra el edificio"</para>
    /// labels<para>"Número de portal"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/organizacion#numeroPortal">http://purl.org/ctic/infraestructuras/organizacion#numeroPortal</seealso>
    let numeroPortal = Prefixed_Name(ctorg, "numeroPortal") |> PrefixedName
    /// <summary>
    ///   <para>ctorg:organoPublico</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"El órgano público asociado al centro"</para>
    /// labels<para>"Órgano del que depende"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/organizacion#organoPublico">http://purl.org/ctic/infraestructuras/organizacion#organoPublico</seealso>
    let organoPublico = Prefixed_Name(ctorg, "organoPublico") |> PrefixedName
    /// <summary>
    ///   <para>ctorg:plantaEdificio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Indica la planta del edificio donde se encuentra el centro"</para>
    /// labels<para>"Planta (piso) del edificio"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/organizacion#plantaEdificio">http://purl.org/ctic/infraestructuras/organizacion#plantaEdificio</seealso>
    let plantaEdificio = Prefixed_Name(ctorg, "plantaEdificio") |> PrefixedName
    /// <summary>
    ///   <para>ctorg:servicios</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Servicios prestados en el centro"</para>
    /// labels<para>"Servicios prestados"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/organizacion#servicios">http://purl.org/ctic/infraestructuras/organizacion#servicios</seealso>
    let servicios = Prefixed_Name(ctorg, "servicios") |> PrefixedName
    /// <summary>
    ///   <para>ctorg:tipoCentro</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"El tipo del centro"</para>
    /// labels<para>"Tipo de Centro"</para></remarks>
    /// <seealso href="http://purl.org/ctic/infraestructuras/organizacion#tipoCentro">http://purl.org/ctic/infraestructuras/organizacion#tipoCentro</seealso>
    let tipoCentro = Prefixed_Name(ctorg, "tipoCentro") |> PrefixedName
