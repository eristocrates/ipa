namespace http.tour_pedia.org.download.tp.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tp =
    let _namespace_iri = Namespace_Iri tp |> NamespaceIRI
    /// <summary>
    ///   <para>tp:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The generic class for a touristic place.</para>
    /// labels<para>Place</para></remarks>
    /// <seealso href="http://tour-pedia.org/download/tp.owl#Place">http://tour-pedia.org/download/tp.owl#Place</seealso>
    let Place = Prefixed_Name(tp, "Place") |> PrefixedName
    /// <summary>
    ///   <para>tp:POI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://tour-pedia.org/download/tp.owl#POI">http://tour-pedia.org/download/tp.owl#POI</seealso>
    let POI = Prefixed_Name(tp, "POI") |> PrefixedName
    /// <summary>
    ///   <para>tp:Restaurant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://tour-pedia.org/download/tp.owl#Restaurant">http://tour-pedia.org/download/tp.owl#Restaurant</seealso>
    let Restaurant = Prefixed_Name(tp, "Restaurant") |> PrefixedName
    /// <summary>
    ///   <para>tp:Attraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://tour-pedia.org/download/tp.owl#Attraction">http://tour-pedia.org/download/tp.owl#Attraction</seealso>
    let Attraction = Prefixed_Name(tp, "Attraction") |> PrefixedName
    /// <summary>
    ///   <para>tp:Accommodation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://tour-pedia.org/download/tp.owl#Accommodation">http://tour-pedia.org/download/tp.owl#Accommodation</seealso>
    let Accommodation = Prefixed_Name(tp, "Accommodation") |> PrefixedName
