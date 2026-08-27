namespace http.vocab.linkeddata.es.datosabiertos.def.sector_publico.territorio.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module esadm =
    let _namespace_iri = Namespace_Iri esadm |> NamespaceIRI
    /// <summary>
    ///   <para>esadm:Autonomia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Autonomía (Comunidad Autónoma o Ciudad Autónoma) a la que pertenece un fenómeno geográfico o una entidad administrativa"</para>
    ///   <para>"Autonomy (Autonomous Community or Autonomous City) to which a geographical phenomenon or an administrative entity belongs"</para>
    ///   <para>"Uniprovincial or multiprovincial entity with specific territorial limits within the kingdom of Spain, which is endowed with legislative autonomy and executive powers in everything that is not common with the rest of the State."</para>
    /// labels<para>"Autonomy"</para></remarks>
    /// <seealso href="http://vocab.linkeddata.es/datosabiertos/def/sector-publico/territorio#Autonomia">http://vocab.linkeddata.es/datosabiertos/def/sector-publico/territorio#Autonomia</seealso>
    let Autonomia = Prefixed_Name(esadm, "Autonomia") |> PrefixedName
    /// <summary>
    ///   <para>esadm:CiudadAutonoma</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Autonomous City to which a geographical phenomenon or an administrative entity belongs"</para>
    /// labels<para>"Autonomous City"</para></remarks>
    /// <seealso href="http://vocab.linkeddata.es/datosabiertos/def/sector-publico/territorio#CiudadAutonoma">http://vocab.linkeddata.es/datosabiertos/def/sector-publico/territorio#CiudadAutonoma</seealso>
    let CiudadAutonoma = Prefixed_Name(esadm, "CiudadAutonoma") |> PrefixedName
    /// <summary>
    ///   <para>esadm:ComunidadAutonoma</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Autonomous Community to which a geographical phenomenon or an administrative entity belongs"</para>
    /// labels<para>"Autonomous Community"</para></remarks>
    /// <seealso href="http://vocab.linkeddata.es/datosabiertos/def/sector-publico/territorio#ComunidadAutonoma">http://vocab.linkeddata.es/datosabiertos/def/sector-publico/territorio#ComunidadAutonoma</seealso>
    let ComunidadAutonoma = Prefixed_Name(esadm, "ComunidadAutonoma") |> PrefixedName

    /// <summary>
    ///   <para>esadm:ComunidadJurisdiccional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Jurisdictional Community"</para>
    /// labels<para>"Jurisdictional Community"</para></remarks>
    /// <seealso href="http://vocab.linkeddata.es/datosabiertos/def/sector-publico/territorio#ComunidadJurisdiccional">http://vocab.linkeddata.es/datosabiertos/def/sector-publico/territorio#ComunidadJurisdiccional</seealso>
    let ComunidadJurisdiccional =
        Prefixed_Name(esadm, "ComunidadJurisdiccional") |> PrefixedName

    /// <summary>
    ///   <para>esadm:EntidadSingular</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://vocab.linkeddata.es/datosabiertos/def/sector-publico/territorio#EntidadSingular">http://vocab.linkeddata.es/datosabiertos/def/sector-publico/territorio#EntidadSingular</seealso>
    let EntidadSingular = Prefixed_Name(esadm, "EntidadSingular") |> PrefixedName
    /// <summary>
    ///   <para>esadm:Municipio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A municipality is an administrative entity that can group a single locality or several, it can refer to a city or a town."</para>
    ///   <para>"Un municipio es una entidad administrativa que puede agrupar una sola localidad o varias, puede hacer referencia a una ciudad o un pueblo."</para>
    /// labels<para>"Municipality"</para></remarks>
    /// <seealso href="http://vocab.linkeddata.es/datosabiertos/def/sector-publico/territorio#Municipio">http://vocab.linkeddata.es/datosabiertos/def/sector-publico/territorio#Municipio</seealso>
    let Municipio = Prefixed_Name(esadm, "Municipio") |> PrefixedName
    /// <summary>
    ///   <para>esadm:Pais</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Un país  es un territorio con características geográficas y culturales propias, que puede o no constituir un Estado soberano o una entidad política dentro de un Estado. También es utilizado como sinónimo de Estado, conjunto de instituciones políticas dotadas de territorio, población y soberanía."</para>
    ///   <para>"A country is a territory with its own geographical and cultural characteristics, which may or may not constitute a sovereign State or a political entity within a State. It is also used as a synonym for State, a set of political institutions endowed with territory, population and sovereignty."</para>
    /// labels<para>"Country"</para></remarks>
    /// <seealso href="http://vocab.linkeddata.es/datosabiertos/def/sector-publico/territorio#Pais">http://vocab.linkeddata.es/datosabiertos/def/sector-publico/territorio#Pais</seealso>
    let Pais = Prefixed_Name(esadm, "Pais") |> PrefixedName
    /// <summary>
    ///   <para>esadm:Provincia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In Spain, &lt; regionName &gt;  in Tpeg Location or &lt; administrativeArea &gt; in Location ReferencePoint"</para>
    ///   <para>"Una provincia es una entidad subnacional del Estado"</para>
    ///   <para>"A province is a subnational entity of the State"</para>
    /// labels<para>"Province"</para></remarks>
    /// <seealso href="http://vocab.linkeddata.es/datosabiertos/def/sector-publico/territorio#Provincia">http://vocab.linkeddata.es/datosabiertos/def/sector-publico/territorio#Provincia</seealso>
    let Provincia = Prefixed_Name(esadm, "Provincia") |> PrefixedName
    /// <summary>
    ///   <para>esadm:codigoINE</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Coding assigned by the INE Nomenclature"</para>
    /// labels<para>"code INE"</para></remarks>
    /// <seealso href="http://vocab.linkeddata.es/datosabiertos/def/sector-publico/territorio#codigoINE">http://vocab.linkeddata.es/datosabiertos/def/sector-publico/territorio#codigoINE</seealso>
    let codigoINE = Prefixed_Name(esadm, "codigoINE") |> PrefixedName
