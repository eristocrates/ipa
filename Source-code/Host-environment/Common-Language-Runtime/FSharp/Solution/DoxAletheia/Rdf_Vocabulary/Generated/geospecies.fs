namespace http.rdf.geospecies.org.ont.geospecies.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module geospecies =
    let _namespace_iri = Namespace_Iri geospecies |> NamespaceIRI
    /// <summary>
    ///   <para>geospecies:BBCPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"BBCPage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBCPage">http://rdf.geospecies.org/ont/geospecies#BBCPage</seealso>
    let BBCPage = Prefixed_Name(geospecies, "BBCPage") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:BBC_Ecozone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"BBC_Ecozone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone">http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone</seealso>
    let BBC_Ecozone = Prefixed_Name(geospecies, "BBC_Ecozone") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Ecozone_Afrotropics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:BBC_Ecozone</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Afrotropics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Afrotropics">http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Afrotropics</seealso>
    let BBC_Ecozone_Afrotropics =
        Prefixed_Name(geospecies, "BBC_Ecozone_Afrotropics") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Ecozone_Antarctica</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:BBC_Ecozone</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Antarctica"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Antarctica">http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Antarctica</seealso>
    let BBC_Ecozone_Antarctica =
        Prefixed_Name(geospecies, "BBC_Ecozone_Antarctica") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Ecozone_Australasia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:BBC_Ecozone</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Australasia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Australasia">http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Australasia</seealso>
    let BBC_Ecozone_Australasia =
        Prefixed_Name(geospecies, "BBC_Ecozone_Australasia") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Ecozone_Indo-Malay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:BBC_Ecozone</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Indo-Malay"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Indo-Malay">http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Indo-Malay</seealso>
    let BBC_Ecozone_Indo_Malay =
        Prefixed_Name(geospecies, "BBC_Ecozone_Indo-Malay") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Ecozone_Nearctic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:BBC_Ecozone</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Nearctic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Nearctic">http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Nearctic</seealso>
    let BBC_Ecozone_Nearctic =
        Prefixed_Name(geospecies, "BBC_Ecozone_Nearctic") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Ecozone_Neotropical</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:BBC_Ecozone</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Neotropical"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Neotropical">http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Neotropical</seealso>
    let BBC_Ecozone_Neotropical =
        Prefixed_Name(geospecies, "BBC_Ecozone_Neotropical") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Ecozone_Oceania</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:BBC_Ecozone</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Oceania"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Oceania">http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Oceania</seealso>
    let BBC_Ecozone_Oceania =
        Prefixed_Name(geospecies, "BBC_Ecozone_Oceania") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Ecozone_Palaearctic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:BBC_Ecozone</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Palaearctic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Palaearctic">http://rdf.geospecies.org/ont/geospecies#BBC_Ecozone_Palaearctic</seealso>
    let BBC_Ecozone_Palaearctic =
        Prefixed_Name(geospecies, "BBC_Ecozone_Palaearctic") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Freshwater_Habitat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"BBC_Freshwater_Habitats"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat">http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat</seealso>
    let BBC_Freshwater_Habitat =
        Prefixed_Name(geospecies, "BBC_Freshwater_Habitat") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Freshwater_Habitat_Brackish_water</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:BBC_Freshwater_Habitat</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Brackish water"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Brackish_water">http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Brackish_water</seealso>
    let BBC_Freshwater_Habitat_Brackish_water =
        Prefixed_Name(geospecies, "BBC_Freshwater_Habitat_Brackish_water") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Freshwater_Habitat_Lakes_and_ponds</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:BBC_Freshwater_Habitat</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Lakes and ponds"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Lakes_and_ponds">http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Lakes_and_ponds</seealso>
    let BBC_Freshwater_Habitat_Lakes_and_ponds =
        Prefixed_Name(geospecies, "BBC_Freshwater_Habitat_Lakes_and_ponds") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Freshwater_Habitat_Marsh</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:BBC_Freshwater_Habitat</para>
    ///
    /// labels<para>"Marsh"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Marsh">http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Marsh</seealso>
    let BBC_Freshwater_Habitat_Marsh =
        Prefixed_Name(geospecies, "BBC_Freshwater_Habitat_Marsh") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Freshwater_Habitat_Rivers_and_streams</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:BBC_Freshwater_Habitat</para>
    ///
    /// labels<para>"Rivers and streams"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Rivers_and_streams">http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Rivers_and_streams</seealso>
    let BBC_Freshwater_Habitat_Rivers_and_streams =
        Prefixed_Name(geospecies, "BBC_Freshwater_Habitat_Rivers_and_streams") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Freshwater_Habitat_Swamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:BBC_Freshwater_Habitat</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Swamp"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Swamp">http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Swamp</seealso>
    let BBC_Freshwater_Habitat_Swamp =
        Prefixed_Name(geospecies, "BBC_Freshwater_Habitat_Swamp") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Freshwater_Habitat_Temporary_pools</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:BBC_Freshwater_Habitat</para>
    ///
    /// labels<para>"Temporary pools"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Temporary_pools">http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Temporary_pools</seealso>
    let BBC_Freshwater_Habitat_Temporary_pools =
        Prefixed_Name(geospecies, "BBC_Freshwater_Habitat_Temporary_pools") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Freshwater_Habitat_Wetlands</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:BBC_Freshwater_Habitat</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Wetlands"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Wetlands">http://rdf.geospecies.org/ont/geospecies#BBC_Freshwater_Habitat_Wetlands</seealso>
    let BBC_Freshwater_Habitat_Wetlands =
        Prefixed_Name(geospecies, "BBC_Freshwater_Habitat_Wetlands") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Habitat_Classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"BBC_Habitat_Classification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Habitat_Classification">http://rdf.geospecies.org/ont/geospecies#BBC_Habitat_Classification</seealso>
    let BBC_Habitat_Classification =
        Prefixed_Name(geospecies, "BBC_Habitat_Classification") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Marine_Habitat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"BBC_Marine_Habitats"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat">http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat</seealso>
    let BBC_Marine_Habitat =
        Prefixed_Name(geospecies, "BBC_Marine_Habitat") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Marine_Habitat_Deep_ocean</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:BBC_Marine_Habitat</para>
    ///
    /// labels<para>"Deep ocean"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Deep_ocean">http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Deep_ocean</seealso>
    let BBC_Marine_Habitat_Deep_ocean =
        Prefixed_Name(geospecies, "BBC_Marine_Habitat_Deep_ocean") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Marine_Habitat_Estuaries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:BBC_Marine_Habitat</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Estuaries"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Estuaries">http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Estuaries</seealso>
    let BBC_Marine_Habitat_Estuaries =
        Prefixed_Name(geospecies, "BBC_Marine_Habitat_Estuaries") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Marine_Habitat_Hydrothermal_vents</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:BBC_Marine_Habitat</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Hydrothermal vents"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Hydrothermal_vents">http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Hydrothermal_vents</seealso>
    let BBC_Marine_Habitat_Hydrothermal_vents =
        Prefixed_Name(geospecies, "BBC_Marine_Habitat_Hydrothermal_vents") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Marine_Habitat_Open_ocean</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:BBC_Marine_Habitat</para>
    ///
    /// labels<para>"Open ocean"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Open_ocean">http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Open_ocean</seealso>
    let BBC_Marine_Habitat_Open_ocean =
        Prefixed_Name(geospecies, "BBC_Marine_Habitat_Open_ocean") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Marine_Habitat_Reefs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:BBC_Marine_Habitat</para>
    ///
    /// labels<para>"Reefs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Reefs">http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Reefs</seealso>
    let BBC_Marine_Habitat_Reefs =
        Prefixed_Name(geospecies, "BBC_Marine_Habitat_Reefs") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Marine_Habitat_Sea_bed</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:BBC_Marine_Habitat</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Sea bed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Sea_bed">http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Sea_bed</seealso>
    let BBC_Marine_Habitat_Sea_bed =
        Prefixed_Name(geospecies, "BBC_Marine_Habitat_Sea_bed") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Marine_Habitat_Shallow_seas</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:BBC_Marine_Habitat</para>
    ///
    /// labels<para>"Shallow seas"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Shallow_seas">http://rdf.geospecies.org/ont/geospecies#BBC_Marine_Habitat_Shallow_seas</seealso>
    let BBC_Marine_Habitat_Shallow_seas =
        Prefixed_Name(geospecies, "BBC_Marine_Habitat_Shallow_seas") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Terrestrial_Habitat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"BBC_Terrestrial_Habitats"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat">http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat</seealso>
    let BBC_Terrestrial_Habitat =
        Prefixed_Name(geospecies, "BBC_Terrestrial_Habitat") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Terrestrial_Habitat_Broadleaf_forest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:BBC_Terrestrial_Habitat</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Broadleaf forest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Broadleaf_forest">http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Broadleaf_forest</seealso>
    let BBC_Terrestrial_Habitat_Broadleaf_forest =
        Prefixed_Name(geospecies, "BBC_Terrestrial_Habitat_Broadleaf_forest") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Terrestrial_Habitat_Coastal</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:BBC_Terrestrial_Habitat</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Coastal"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Coastal">http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Coastal</seealso>
    let BBC_Terrestrial_Habitat_Coastal =
        Prefixed_Name(geospecies, "BBC_Terrestrial_Habitat_Coastal") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Terrestrial_Habitat_Coniferous_forest</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:BBC_Terrestrial_Habitat</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Coniferous forest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Coniferous_forest">http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Coniferous_forest</seealso>
    let BBC_Terrestrial_Habitat_Coniferous_forest =
        Prefixed_Name(geospecies, "BBC_Terrestrial_Habitat_Coniferous_forest") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Terrestrial_Habitat_Desert</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:BBC_Terrestrial_Habitat</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Desert"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Desert">http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Desert</seealso>
    let BBC_Terrestrial_Habitat_Desert =
        Prefixed_Name(geospecies, "BBC_Terrestrial_Habitat_Desert") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Terrestrial_Habitat_Flooded_grassland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:BBC_Terrestrial_Habitat</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Flooded grassland"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Flooded_grassland">http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Flooded_grassland</seealso>
    let BBC_Terrestrial_Habitat_Flooded_grassland =
        Prefixed_Name(geospecies, "BBC_Terrestrial_Habitat_Flooded_grassland") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Terrestrial_Habitat_Mangroves</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:BBC_Terrestrial_Habitat</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Mangroves"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Mangroves">http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Mangroves</seealso>
    let BBC_Terrestrial_Habitat_Mangroves =
        Prefixed_Name(geospecies, "BBC_Terrestrial_Habitat_Mangroves") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Terrestrial_Habitat_Mediterranean_forest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:BBC_Terrestrial_Habitat</para>
    ///
    /// labels<para>"Mediterranean forest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Mediterranean_forest">http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Mediterranean_forest</seealso>
    let BBC_Terrestrial_Habitat_Mediterranean_forest =
        Prefixed_Name(geospecies, "BBC_Terrestrial_Habitat_Mediterranean_forest") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Terrestrial_Habitat_Mountain_grassland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:BBC_Terrestrial_Habitat</para>
    ///
    /// labels<para>"Mountain grassland"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Mountain_grassland">http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Mountain_grassland</seealso>
    let BBC_Terrestrial_Habitat_Mountain_grassland =
        Prefixed_Name(geospecies, "BBC_Terrestrial_Habitat_Mountain_grassland") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Terrestrial_Habitat_Polar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:BBC_Terrestrial_Habitat</para>
    ///
    /// labels<para>"Polar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Polar">http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Polar</seealso>
    let BBC_Terrestrial_Habitat_Polar =
        Prefixed_Name(geospecies, "BBC_Terrestrial_Habitat_Polar") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Terrestrial_Habitat_Rainforest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:BBC_Terrestrial_Habitat</para>
    ///
    /// labels<para>"Rainforest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Rainforest">http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Rainforest</seealso>
    let BBC_Terrestrial_Habitat_Rainforest =
        Prefixed_Name(geospecies, "BBC_Terrestrial_Habitat_Rainforest") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Terrestrial_Habitat_Taiga</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:BBC_Terrestrial_Habitat</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Taiga"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Taiga">http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Taiga</seealso>
    let BBC_Terrestrial_Habitat_Taiga =
        Prefixed_Name(geospecies, "BBC_Terrestrial_Habitat_Taiga") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Terrestrial_Habitat_Temperate_grassland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:BBC_Terrestrial_Habitat</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Temperate grassland"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Temperate_grassland">http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Temperate_grassland</seealso>
    let BBC_Terrestrial_Habitat_Temperate_grassland =
        Prefixed_Name(geospecies, "BBC_Terrestrial_Habitat_Temperate_grassland") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Terrestrial_Habitat_Tropical_coniferous_forest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:BBC_Terrestrial_Habitat</para>
    ///
    /// labels<para>"Tropical coniferous forest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Tropical_coniferous_forest">http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Tropical_coniferous_forest</seealso>
    let BBC_Terrestrial_Habitat_Tropical_coniferous_forest =
        Prefixed_Name(geospecies, "BBC_Terrestrial_Habitat_Tropical_coniferous_forest") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Terrestrial_Habitat_Tropical_dry_forest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:BBC_Terrestrial_Habitat</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Tropical dry forest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Tropical_dry_forest">http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Tropical_dry_forest</seealso>
    let BBC_Terrestrial_Habitat_Tropical_dry_forest =
        Prefixed_Name(geospecies, "BBC_Terrestrial_Habitat_Tropical_dry_forest") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BBC_Terrestrial_Habitat_Tropical_grassland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:BBC_Terrestrial_Habitat</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Tropical grassland"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Tropical_grassland">http://rdf.geospecies.org/ont/geospecies#BBC_Terrestrial_Habitat_Tropical_grassland</seealso>
    let BBC_Terrestrial_Habitat_Tropical_grassland =
        Prefixed_Name(geospecies, "BBC_Terrestrial_Habitat_Tropical_grassland") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BasisOfRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"BasisOfRecord"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord">http://rdf.geospecies.org/ont/geospecies#BasisOfRecord</seealso>
    let BasisOfRecord = Prefixed_Name(geospecies, "BasisOfRecord") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BasisOfRecord_FossilSpecimen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:BasisOfRecord</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"BasisOfRecord_FossilSpecimen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_FossilSpecimen">http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_FossilSpecimen</seealso>
    let BasisOfRecord_FossilSpecimen =
        Prefixed_Name(geospecies, "BasisOfRecord_FossilSpecimen") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BasisOfRecord_HumanObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:BasisOfRecord</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"BasisOfRecord_HumanObservation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_HumanObservation">http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_HumanObservation</seealso>
    let BasisOfRecord_HumanObservation =
        Prefixed_Name(geospecies, "BasisOfRecord_HumanObservation") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BasisOfRecord_LivingSpecimen</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:BasisOfRecord</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"BasisOfRecord_LivingSpecimen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_LivingSpecimen">http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_LivingSpecimen</seealso>
    let BasisOfRecord_LivingSpecimen =
        Prefixed_Name(geospecies, "BasisOfRecord_LivingSpecimen") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BasisOfRecord_MachineObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:BasisOfRecord</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"BasisOfRecord_MachineObservation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_MachineObservation">http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_MachineObservation</seealso>
    let BasisOfRecord_MachineObservation =
        Prefixed_Name(geospecies, "BasisOfRecord_MachineObservation") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BasisOfRecord_MovingImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:BasisOfRecord</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"BasisOfRecord_MovingImage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_MovingImage">http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_MovingImage</seealso>
    let BasisOfRecord_MovingImage =
        Prefixed_Name(geospecies, "BasisOfRecord_MovingImage") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BasisOfRecord_NomenclaturalChecklist</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:BasisOfRecord</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"BasisOfRecord_NomenclaturalChecklist"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_NomenclaturalChecklist">http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_NomenclaturalChecklist</seealso>
    let BasisOfRecord_NomenclaturalChecklist =
        Prefixed_Name(geospecies, "BasisOfRecord_NomenclaturalChecklist") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BasisOfRecord_PreservedSpecimen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:BasisOfRecord</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"basisOfRecord_PreservedSpecimen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_PreservedSpecimen">http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_PreservedSpecimen</seealso>
    let BasisOfRecord_PreservedSpecimen =
        Prefixed_Name(geospecies, "BasisOfRecord_PreservedSpecimen") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BasisOfRecord_Sound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:BasisOfRecord</para>
    ///
    /// labels<para>"BasisOfRecord_Sound"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_Sound">http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_Sound</seealso>
    let BasisOfRecord_Sound =
        Prefixed_Name(geospecies, "BasisOfRecord_Sound") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:BasisOfRecord_StillImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:BasisOfRecord</para>
    ///
    /// labels<para>"BasisOfRecord_StillImage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_StillImage">http://rdf.geospecies.org/ont/geospecies#BasisOfRecord_StillImage</seealso>
    let BasisOfRecord_StillImage =
        Prefixed_Name(geospecies, "BasisOfRecord_StillImage") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Bio2RDFtaxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Bio2RDFtaxon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Bio2RDFtaxon">http://rdf.geospecies.org/ont/geospecies#Bio2RDFtaxon</seealso>
    let Bio2RDFtaxon = Prefixed_Name(geospecies, "Bio2RDFtaxon") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:BioLibPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"BBCPage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"BioLibPage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BioLibPage">http://rdf.geospecies.org/ont/geospecies#BioLibPage</seealso>
    let BioLibPage = Prefixed_Name(geospecies, "BioLibPage") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:BugGuidePage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"BugGuidePage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#BugGuidePage">http://rdf.geospecies.org/ont/geospecies#BugGuidePage</seealso>
    let BugGuidePage = Prefixed_Name(geospecies, "BugGuidePage") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:ClassConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ClassConcept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#ClassConcept">http://rdf.geospecies.org/ont/geospecies#ClassConcept</seealso>
    let ClassConcept = Prefixed_Name(geospecies, "ClassConcept") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:CoL_LSID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"CoL_LSID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#CoL_LSID">http://rdf.geospecies.org/ont/geospecies#CoL_LSID</seealso>
    let CoL_LSID = Prefixed_Name(geospecies, "CoL_LSID") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:Continent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Continent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Continent">http://rdf.geospecies.org/ont/geospecies#Continent</seealso>
    let Continent = Prefixed_Name(geospecies, "Continent") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:Country</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Country"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Country">http://rdf.geospecies.org/ont/geospecies#Country</seealso>
    let Country = Prefixed_Name(geospecies, "Country") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:County</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"County"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#County">http://rdf.geospecies.org/ont/geospecies#County</seealso>
    let County = Prefixed_Name(geospecies, "County") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:DBpediaResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"DBpediaResource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#DBpediaResource">http://rdf.geospecies.org/ont/geospecies#DBpediaResource</seealso>
    let DBpediaResource = Prefixed_Name(geospecies, "DBpediaResource") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:DarwinPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Darwin Point is an occurrence location that meets the DarwinCore specifications for longitude, latitude, datum, extent, etc as described in "Guide to Best Practices for Georeferencing""^^&lt;http://www.w3.org/1999/02/22-rdf-syntax-ns#XMLLiteral&gt;</para>
    /// labels<para>"DarwinPoint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#DarwinPoint">http://rdf.geospecies.org/ont/geospecies#DarwinPoint</seealso>
    let DarwinPoint = Prefixed_Name(geospecies, "DarwinPoint") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:Ecozone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ecozone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Ecozone">http://rdf.geospecies.org/ont/geospecies#Ecozone</seealso>
    let Ecozone = Prefixed_Name(geospecies, "Ecozone") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:EoLPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"EoLPage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#EoLPage">http://rdf.geospecies.org/ont/geospecies#EoLPage</seealso>
    let EoLPage = Prefixed_Name(geospecies, "EoLPage") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:FamilyConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"FamilyConcept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#FamilyConcept">http://rdf.geospecies.org/ont/geospecies#FamilyConcept</seealso>
    let FamilyConcept = Prefixed_Name(geospecies, "FamilyConcept") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:FreebaseGUID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"FreebaseGUID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#FreebaseGUID">http://rdf.geospecies.org/ont/geospecies#FreebaseGUID</seealso>
    let FreebaseGUID = Prefixed_Name(geospecies, "FreebaseGUID") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:GBIFPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"GBIFPage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#GBIFPage">http://rdf.geospecies.org/ont/geospecies#GBIFPage</seealso>
    let GBIFPage = Prefixed_Name(geospecies, "GBIFPage") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:GeoSpeciesPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"GeoSpeciesPage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#GeoSpeciesPage">http://rdf.geospecies.org/ont/geospecies#GeoSpeciesPage</seealso>
    let GeoSpeciesPage = Prefixed_Name(geospecies, "GeoSpeciesPage") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:GeoSpeciesScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"GeoSpeciesScheme"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#GeoSpeciesScheme">http://rdf.geospecies.org/ont/geospecies#GeoSpeciesScheme</seealso>
    let GeoSpeciesScheme = Prefixed_Name(geospecies, "GeoSpeciesScheme") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:GeoSpecies_Knowledge_Base_Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:Project</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GeoSpecies_Knowledge_Base_Project"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#GeoSpecies_Knowledge_Base_Project">http://rdf.geospecies.org/ont/geospecies#GeoSpecies_Knowledge_Base_Project</seealso>
    let GeoSpecies_Knowledge_Base_Project =
        Prefixed_Name(geospecies, "GeoSpecies_Knowledge_Base_Project") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:GeodeticDatum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"GeodeticDatum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#GeodeticDatum">http://rdf.geospecies.org/ont/geospecies#GeodeticDatum</seealso>
    let GeodeticDatum = Prefixed_Name(geospecies, "GeodeticDatum") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:GeodeticDatum_NAD27</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:GeodeticDatum</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GeodeticDatum_NAD27"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#GeodeticDatum_NAD27">http://rdf.geospecies.org/ont/geospecies#GeodeticDatum_NAD27</seealso>
    let GeodeticDatum_NAD27 =
        Prefixed_Name(geospecies, "GeodeticDatum_NAD27") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:GeodeticDatum_NAD83</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:GeodeticDatum</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"GeodeticDatum_NAD83"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#GeodeticDatum_NAD83">http://rdf.geospecies.org/ont/geospecies#GeodeticDatum_NAD83</seealso>
    let GeodeticDatum_NAD83 =
        Prefixed_Name(geospecies, "GeodeticDatum_NAD83") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:GeodeticDatum_WGS84</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:GeodeticDatum</para>
    ///   <para>"The Geodetic Datum WGS84"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GeodeticDatum_WGS84"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#GeodeticDatum_WGS84">http://rdf.geospecies.org/ont/geospecies#GeodeticDatum_WGS84</seealso>
    let GeodeticDatum_WGS84 =
        Prefixed_Name(geospecies, "GeodeticDatum_WGS84") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Habitat_Classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Habitat"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Habitat_Classification">http://rdf.geospecies.org/ont/geospecies#Habitat_Classification</seealso>
    let Habitat_Classification =
        Prefixed_Name(geospecies, "Habitat_Classification") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:ITISPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ITISPage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#ITISPage">http://rdf.geospecies.org/ont/geospecies#ITISPage</seealso>
    let ITISPage = Prefixed_Name(geospecies, "ITISPage") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:IUCN_Habitat_Classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"HabitatIUCN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#IUCN_Habitat_Classification">http://rdf.geospecies.org/ont/geospecies#IUCN_Habitat_Classification</seealso>
    let IUCN_Habitat_Classification =
        Prefixed_Name(geospecies, "IUCN_Habitat_Classification") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:IndividualOrganism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"IndividualOrganism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#IndividualOrganism">http://rdf.geospecies.org/ont/geospecies#IndividualOrganism</seealso>
    let IndividualOrganism =
        Prefixed_Name(geospecies, "IndividualOrganism") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:KingdomConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"KingdomConcept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#KingdomConcept">http://rdf.geospecies.org/ont/geospecies#KingdomConcept</seealso>
    let KingdomConcept = Prefixed_Name(geospecies, "KingdomConcept") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:LSID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"LSID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#LSID">http://rdf.geospecies.org/ont/geospecies#LSID</seealso>
    let LSID = Prefixed_Name(geospecies, "LSID") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:LifeForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"LifeForm"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#LifeForm">http://rdf.geospecies.org/ont/geospecies#LifeForm</seealso>
    let LifeForm = Prefixed_Name(geospecies, "LifeForm") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:LifeStage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"LifeStage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#LifeStage">http://rdf.geospecies.org/ont/geospecies#LifeStage</seealso>
    let LifeStage = Prefixed_Name(geospecies, "LifeStage") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:Locality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Locality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Locality">http://rdf.geospecies.org/ont/geospecies#Locality</seealso>
    let Locality = Prefixed_Name(geospecies, "Locality") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A location, would be a subclass of geonames feature, but it will not always have a geonames feature id"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Location"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Location">http://rdf.geospecies.org/ont/geospecies#Location</seealso>
    let Location = Prefixed_Name(geospecies, "Location") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Method_Above_Ground_Sticky_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>obsm:ArthropodCollectionMethods</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Method_Above_Ground_Sticky_Trap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Method_Above_Ground_Sticky_Trap">http://rdf.geospecies.org/ont/geospecies#Method_Above_Ground_Sticky_Trap</seealso>
    let Method_Above_Ground_Sticky_Trap =
        Prefixed_Name(geospecies, "Method_Above_Ground_Sticky_Trap") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Method_Aerial_Collection_Net</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>obsm:ArthropodCollectionMethods</para>
    ///
    /// labels<para>"Method_Aerial_Collection_Net"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Method_Aerial_Collection_Net">http://rdf.geospecies.org/ont/geospecies#Method_Aerial_Collection_Net</seealso>
    let Method_Aerial_Collection_Net =
        Prefixed_Name(geospecies, "Method_Aerial_Collection_Net") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Method_Barrier_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>obsm:ArthropodCollectionMethods</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Method_Barrier_Trap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Method_Barrier_Trap">http://rdf.geospecies.org/ont/geospecies#Method_Barrier_Trap</seealso>
    let Method_Barrier_Trap =
        Prefixed_Name(geospecies, "Method_Barrier_Trap") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Method_Berlese_Sample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>obsm:ArthropodCollectionMethods</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Method_Berlese_Sample"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Method_Berlese_Sample">http://rdf.geospecies.org/ont/geospecies#Method_Berlese_Sample</seealso>
    let Method_Berlese_Sample =
        Prefixed_Name(geospecies, "Method_Berlese_Sample") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Method_CO2_Suction_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>obsm:ArthropodCollectionMethods</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Method_CO2_Suction_Trap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Method_CO2_Suction_Trap">http://rdf.geospecies.org/ont/geospecies#Method_CO2_Suction_Trap</seealso>
    let Method_CO2_Suction_Trap =
        Prefixed_Name(geospecies, "Method_CO2_Suction_Trap") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Method_Cantharidin_Baited_Jar_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>obsm:ArthropodCollectionMethods</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Method_Cantharidin_Baited_Jar_Trap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Method_Cantharidin_Baited_Jar_Trap">http://rdf.geospecies.org/ont/geospecies#Method_Cantharidin_Baited_Jar_Trap</seealso>
    let Method_Cantharidin_Baited_Jar_Trap =
        Prefixed_Name(geospecies, "Method_Cantharidin_Baited_Jar_Trap") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Method_Chicken_Mash_Baited_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>obsm:ArthropodCollectionMethods</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Method_Chicken_Mash_Baited_Trap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Method_Chicken_Mash_Baited_Trap">http://rdf.geospecies.org/ont/geospecies#Method_Chicken_Mash_Baited_Trap</seealso>
    let Method_Chicken_Mash_Baited_Trap =
        Prefixed_Name(geospecies, "Method_Chicken_Mash_Baited_Trap") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Method_Flight_Intercept_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>obsm:ArthropodCollectionMethods</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Method_Flight_Intercept_Trap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Method_Flight_Intercept_Trap">http://rdf.geospecies.org/ont/geospecies#Method_Flight_Intercept_Trap</seealso>
    let Method_Flight_Intercept_Trap =
        Prefixed_Name(geospecies, "Method_Flight_Intercept_Trap") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Method_Ground_Based_Sticky_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>obsm:ArthropodCollectionMethods</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Method_Ground_Based_Sticky_Trap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Method_Ground_Based_Sticky_Trap">http://rdf.geospecies.org/ont/geospecies#Method_Ground_Based_Sticky_Trap</seealso>
    let Method_Ground_Based_Sticky_Trap =
        Prefixed_Name(geospecies, "Method_Ground_Based_Sticky_Trap") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Method_Hand_Collected</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>obsm:ArthropodCollectionMethods</para>
    ///
    /// labels<para>"Method_Hand_Collected"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Method_Hand_Collected">http://rdf.geospecies.org/ont/geospecies#Method_Hand_Collected</seealso>
    let Method_Hand_Collected =
        Prefixed_Name(geospecies, "Method_Hand_Collected") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Method_Hand_Collected_and_Released</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>obsm:ArthropodCollectionMethods</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Method_Hand_Collected_and_Released"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Method_Hand_Collected_and_Released">http://rdf.geospecies.org/ont/geospecies#Method_Hand_Collected_and_Released</seealso>
    let Method_Hand_Collected_and_Released =
        Prefixed_Name(geospecies, "Method_Hand_Collected_and_Released") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Method_Human_Bite_Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>obsm:ArthropodCollectionMethods</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Method_Human_Bite_Collection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Method_Human_Bite_Collection">http://rdf.geospecies.org/ont/geospecies#Method_Human_Bite_Collection</seealso>
    let Method_Human_Bite_Collection =
        Prefixed_Name(geospecies, "Method_Human_Bite_Collection") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Method_Human_Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>obsm:Human_Observation</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Method_Human_Observation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Method_Human_Observation">http://rdf.geospecies.org/ont/geospecies#Method_Human_Observation</seealso>
    let Method_Human_Observation =
        Prefixed_Name(geospecies, "Method_Human_Observation") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Method_Light_and_CO2_Suction_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>obsm:ArthropodCollectionMethods</para>
    ///
    /// labels<para>"Method_Light_and_CO2_Suction_Trap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Method_Light_and_CO2_Suction_Trap">http://rdf.geospecies.org/ont/geospecies#Method_Light_and_CO2_Suction_Trap</seealso>
    let Method_Light_and_CO2_Suction_Trap =
        Prefixed_Name(geospecies, "Method_Light_and_CO2_Suction_Trap") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Method_Malaise_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>obsm:ArthropodCollectionMethods</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Method_Malaise_Trap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Method_Malaise_Trap">http://rdf.geospecies.org/ont/geospecies#Method_Malaise_Trap</seealso>
    let Method_Malaise_Trap =
        Prefixed_Name(geospecies, "Method_Malaise_Trap") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Method_Photographed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>obsm:Photographed</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Method_Photographed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Method_Photographed">http://rdf.geospecies.org/ont/geospecies#Method_Photographed</seealso>
    let Method_Photographed =
        Prefixed_Name(geospecies, "Method_Photographed") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Method_Pitfall_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>obsm:ArthropodCollectionMethods</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Method_Pitfall_Trap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Method_Pitfall_Trap">http://rdf.geospecies.org/ont/geospecies#Method_Pitfall_Trap</seealso>
    let Method_Pitfall_Trap =
        Prefixed_Name(geospecies, "Method_Pitfall_Trap") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Method_Sweep_Net</para>
    /// </summary>
    /// <remarks>
    ///   <para>obsm:ArthropodCollectionMethods</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Method_Sweep_Net"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Method_Sweep_Net">http://rdf.geospecies.org/ont/geospecies#Method_Sweep_Net</seealso>
    let Method_Sweep_Net = Prefixed_Name(geospecies, "Method_Sweep_Net") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Method_UV_Light_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>obsm:ArthropodCollectionMethods</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Method_UV_Light_Trap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Method_UV_Light_Trap">http://rdf.geospecies.org/ont/geospecies#Method_UV_Light_Trap</seealso>
    let Method_UV_Light_Trap =
        Prefixed_Name(geospecies, "Method_UV_Light_Trap") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Method_Vacuum_Collector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>obsm:ArthropodCollectionMethods</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Method_Vacuum_Collector"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Method_Vacuum_Collector">http://rdf.geospecies.org/ont/geospecies#Method_Vacuum_Collector</seealso>
    let Method_Vacuum_Collector =
        Prefixed_Name(geospecies, "Method_Vacuum_Collector") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Method_Visible_Light_Trap</para>
    /// </summary>
    /// <remarks>
    ///   <para>obsm:ArthropodCollectionMethods</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Method_Visible_Light_Trap"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Method_Visible_Light_Trap">http://rdf.geospecies.org/ont/geospecies#Method_Visible_Light_Trap</seealso>
    let Method_Visible_Light_Trap =
        Prefixed_Name(geospecies, "Method_Visible_Light_Trap") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Nativeness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Nativeness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Nativeness">http://rdf.geospecies.org/ont/geospecies#Nativeness</seealso>
    let Nativeness = Prefixed_Name(geospecies, "Nativeness") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:NomenclaturalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode">http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode</seealso>
    let NomenclaturalCode =
        Prefixed_Name(geospecies, "NomenclaturalCode") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:NomenclaturalCode_BioCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:NomenclaturalCode</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_BioCode">http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_BioCode</seealso>
    let NomenclaturalCode_BioCode =
        Prefixed_Name(geospecies, "NomenclaturalCode_BioCode") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:NomenclaturalCode_ICBN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:NomenclaturalCode</para>
    ///
    /// labels<para>"International Code of Botanical Nomenclature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICBN">http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICBN</seealso>
    let NomenclaturalCode_ICBN =
        Prefixed_Name(geospecies, "NomenclaturalCode_ICBN") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:NomenclaturalCode_ICNB</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:NomenclaturalCode</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICNB">http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICNB</seealso>
    let NomenclaturalCode_ICNB =
        Prefixed_Name(geospecies, "NomenclaturalCode_ICNB") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:NomenclaturalCode_ICNCP</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:NomenclaturalCode</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"International Code of Cultivated Plants"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICNCP">http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICNCP</seealso>
    let NomenclaturalCode_ICNCP =
        Prefixed_Name(geospecies, "NomenclaturalCode_ICNCP") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:NomenclaturalCode_ICTV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:NomenclaturalCode</para>
    ///
    /// labels<para>"International Committee on Taxonomy of Viruses"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICTV">http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICTV</seealso>
    let NomenclaturalCode_ICTV =
        Prefixed_Name(geospecies, "NomenclaturalCode_ICTV") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:NomenclaturalCode_ICVCN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:NomenclaturalCode</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"NomenclaturalCode_ICVCN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICVCN">http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICVCN</seealso>
    let NomenclaturalCode_ICVCN =
        Prefixed_Name(geospecies, "NomenclaturalCode_ICVCN") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:NomenclaturalCode_ICZN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:NomenclaturalCode</para>
    ///
    /// labels<para>"International Code of Zoological Nomenclature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICZN">http://rdf.geospecies.org/ont/geospecies#NomenclaturalCode_ICZN</seealso>
    let NomenclaturalCode_ICZN =
        Prefixed_Name(geospecies, "NomenclaturalCode_ICZN") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Observation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Observation">http://rdf.geospecies.org/ont/geospecies#Observation</seealso>
    let Observation = Prefixed_Name(geospecies, "Observation") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:ObservationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ObservationMethod"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#ObservationMethod">http://rdf.geospecies.org/ont/geospecies#ObservationMethod</seealso>
    let ObservationMethod =
        Prefixed_Name(geospecies, "ObservationMethod") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:OccurrenceStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"OccurrenceStatus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus">http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus</seealso>
    let OccurrenceStatus = Prefixed_Name(geospecies, "OccurrenceStatus") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:OccurrenceStatus_absent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:OccurrenceStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"OccurrenceStatus_absent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_absent">http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_absent</seealso>
    let OccurrenceStatus_absent =
        Prefixed_Name(geospecies, "OccurrenceStatus_absent") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:OccurrenceStatus_common</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:OccurrenceStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"OccurrenceStatus_common"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_common">http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_common</seealso>
    let OccurrenceStatus_common =
        Prefixed_Name(geospecies, "OccurrenceStatus_common") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:OccurrenceStatus_doubtful</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:OccurrenceStatus</para>
    ///
    /// labels<para>"OccurrenceStatus_doubtful"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_doubtful">http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_doubtful</seealso>
    let OccurrenceStatus_doubtful =
        Prefixed_Name(geospecies, "OccurrenceStatus_doubtful") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:OccurrenceStatus_irregular</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:OccurrenceStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"OccurrenceStatus_irregular"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_irregular">http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_irregular</seealso>
    let OccurrenceStatus_irregular =
        Prefixed_Name(geospecies, "OccurrenceStatus_irregular") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:OccurrenceStatus_present</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:OccurrenceStatus</para>
    ///
    /// labels<para>"OccurrenceStatus_present"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_present">http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_present</seealso>
    let OccurrenceStatus_present =
        Prefixed_Name(geospecies, "OccurrenceStatus_present") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:OccurrenceStatus_rare</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:OccurrenceStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"OccurrenceStatus_rare"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_rare">http://rdf.geospecies.org/ont/geospecies#OccurrenceStatus_rare</seealso>
    let OccurrenceStatus_rare =
        Prefixed_Name(geospecies, "OccurrenceStatus_rare") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_3_47_Western_Corn_Belt_Plains</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Omernik_Level_III_Ecoregion_Classification</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Omernik_3_Western Corn Belt Plains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_3_47_Western_Corn_Belt_Plains">http://rdf.geospecies.org/ont/geospecies#Omernik_3_47_Western_Corn_Belt_Plains</seealso>
    let Omernik_3_47_Western_Corn_Belt_Plains =
        Prefixed_Name(geospecies, "Omernik_3_47_Western_Corn_Belt_Plains") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_3_50_Northern_Lakes_and_Forests</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    ///   <para>geospecies:Omernik_Level_III_Ecoregion_Classification</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Omernik_4_Northern Lakes and Forests"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_3_50_Northern_Lakes_and_Forests">http://rdf.geospecies.org/ont/geospecies#Omernik_3_50_Northern_Lakes_and_Forests</seealso>
    let Omernik_3_50_Northern_Lakes_and_Forests =
        Prefixed_Name(geospecies, "Omernik_3_50_Northern_Lakes_and_Forests") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_3_51_North_Central_Hardwood_Forests</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Omernik_Level_III_Ecoregion_Classification</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Omernik_3_North_Central_Hardwood_Forests"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_3_51_North_Central_Hardwood_Forests">http://rdf.geospecies.org/ont/geospecies#Omernik_3_51_North_Central_Hardwood_Forests</seealso>
    let Omernik_3_51_North_Central_Hardwood_Forests =
        Prefixed_Name(geospecies, "Omernik_3_51_North_Central_Hardwood_Forests") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_3_52_Driftless_Area</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:Omernik_Level_III_Ecoregion_Classification</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    ///
    /// labels<para>"Omernik_3_Driftless_Area"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_3_52_Driftless_Area">http://rdf.geospecies.org/ont/geospecies#Omernik_3_52_Driftless_Area</seealso>
    let Omernik_3_52_Driftless_Area =
        Prefixed_Name(geospecies, "Omernik_3_52_Driftless_Area") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_3_53_Southeastern_Wisconsin_Till_Plains</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Omernik_Level_III_Ecoregion_Classification</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    ///
    /// labels<para>"Omernik_3_Southeastern_Wisconsin_Till_Plains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_3_53_Southeastern_Wisconsin_Till_Plains">http://rdf.geospecies.org/ont/geospecies#Omernik_3_53_Southeastern_Wisconsin_Till_Plains</seealso>
    let Omernik_3_53_Southeastern_Wisconsin_Till_Plains =
        Prefixed_Name(geospecies, "Omernik_3_53_Southeastern_Wisconsin_Till_Plains") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_3_54_Central_Corn_Belt_Plains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    ///   <para>geospecies:Omernik_Level_IV_Ecoregion_Classification</para>
    ///
    /// labels<para>"Omernik_3_Central Corn Belt Plains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_3_54_Central_Corn_Belt_Plains">http://rdf.geospecies.org/ont/geospecies#Omernik_3_54_Central_Corn_Belt_Plains</seealso>
    let Omernik_3_54_Central_Corn_Belt_Plains =
        Prefixed_Name(geospecies, "Omernik_3_54_Central_Corn_Belt_Plains") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_4_47g_Prairie_Pothole_Region_</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    ///   <para>geospecies:Omernik_Level_IV_Ecoregion_Classification</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Omernik_4_Prairie Pothole Region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_47g_Prairie_Pothole_Region_">http://rdf.geospecies.org/ont/geospecies#Omernik_4_47g_Prairie_Pothole_Region_</seealso>
    let Omernik_4_47g_Prairie_Pothole_Region_ =
        Prefixed_Name(geospecies, "Omernik_4_47g_Prairie_Pothole_Region_") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_4_50a_Lake_Superior_Clay_Plain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:Omernik_Level_IV_Ecoregion_Classification</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    ///
    /// labels<para>"Omernik_4_Lake Superior Clay Plain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_50a_Lake_Superior_Clay_Plain">http://rdf.geospecies.org/ont/geospecies#Omernik_4_50a_Lake_Superior_Clay_Plain</seealso>
    let Omernik_4_50a_Lake_Superior_Clay_Plain =
        Prefixed_Name(geospecies, "Omernik_4_50a_Lake_Superior_Clay_Plain") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_4_51a_St._Croix_Pitted_Stagnation_Moraines</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Omernik_Level_IV_Ecoregion_Classification</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    ///
    /// labels<para>"Omernik_4_51a_St. Croix Pitted Stagnation Moraines"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_51a_St._Croix_Pitted_Stagnation_Moraines">http://rdf.geospecies.org/ont/geospecies#Omernik_4_51a_St._Croix_Pitted_Stagnation_Moraines</seealso>
    let ``Omernik_4_51a_St._Croix_Pitted_Stagnation_Moraines`` =
        Prefixed_Name(geospecies, "Omernik_4_51a_St._Croix_Pitted_Stagnation_Moraines") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_4_51b_Central_Wisconsin_Undulating_Till_Plain</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Omernik_Level_IV_Ecoregion_Classification</para>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Omernik_4_Central_Wisconsin_Undulating_Till_Plain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_51b_Central_Wisconsin_Undulating_Till_Plain">http://rdf.geospecies.org/ont/geospecies#Omernik_4_51b_Central_Wisconsin_Undulating_Till_Plain</seealso>
    let Omernik_4_51b_Central_Wisconsin_Undulating_Till_Plain =
        Prefixed_Name(geospecies, "Omernik_4_51b_Central_Wisconsin_Undulating_Till_Plain") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_4_51c_Glacial_Lake_Wisconsin_Sand_Plain</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:Omernik_Level_IV_Ecoregion_Classification</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Omernik_4_Glacial_Lake_Wisconsin_Sand_Plain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_51c_Glacial_Lake_Wisconsin_Sand_Plain">http://rdf.geospecies.org/ont/geospecies#Omernik_4_51c_Glacial_Lake_Wisconsin_Sand_Plain</seealso>
    let Omernik_4_51c_Glacial_Lake_Wisconsin_Sand_Plain =
        Prefixed_Name(geospecies, "Omernik_4_51c_Glacial_Lake_Wisconsin_Sand_Plain") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_4_51d_Central_Sand_Ridges</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:Omernik_Level_IV_Ecoregion_Classification</para>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    ///
    /// labels<para>"Omernik_4_Central_Sand_Ridges"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_51d_Central_Sand_Ridges">http://rdf.geospecies.org/ont/geospecies#Omernik_4_51d_Central_Sand_Ridges</seealso>
    let Omernik_4_51d_Central_Sand_Ridges =
        Prefixed_Name(geospecies, "Omernik_4_51d_Central_Sand_Ridges") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_4_51e_Upper_Wolf_River_Stagnation_Moraine</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    ///   <para>geospecies:Omernik_Level_IV_Ecoregion_Classification</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Omernik_4_51e_Upper Wolf River Stagnation Moraine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_51e_Upper_Wolf_River_Stagnation_Moraine">http://rdf.geospecies.org/ont/geospecies#Omernik_4_51e_Upper_Wolf_River_Stagnation_Moraine</seealso>
    let Omernik_4_51e_Upper_Wolf_River_Stagnation_Moraine =
        Prefixed_Name(geospecies, "Omernik_4_51e_Upper_Wolf_River_Stagnation_Moraine") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_4_51f_Green_Bay_Till_and_Lacustrine_Plain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:Omernik_Level_IV_Ecoregion_Classification</para>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Omernik_4_51f_Green Bay Till and Lacustrine Plain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_51f_Green_Bay_Till_and_Lacustrine_Plain">http://rdf.geospecies.org/ont/geospecies#Omernik_4_51f_Green_Bay_Till_and_Lacustrine_Plain</seealso>
    let Omernik_4_51f_Green_Bay_Till_and_Lacustrine_Plain =
        Prefixed_Name(geospecies, "Omernik_4_51f_Green_Bay_Till_and_Lacustrine_Plain") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_4_51g_Door_Peninsula</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:Omernik_Level_IV_Ecoregion_Classification</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Omernik_4_Door_Peninsula"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_51g_Door_Peninsula">http://rdf.geospecies.org/ont/geospecies#Omernik_4_51g_Door_Peninsula</seealso>
    let Omernik_4_51g_Door_Peninsula =
        Prefixed_Name(geospecies, "Omernik_4_51g_Door_Peninsula") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_4_52a_Savanna_Section</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Omernik_Level_IV_Ecoregion_Classification</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Omernik_4_Savanna Section"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_52a_Savanna_Section">http://rdf.geospecies.org/ont/geospecies#Omernik_4_52a_Savanna_Section</seealso>
    let Omernik_4_52a_Savanna_Section =
        Prefixed_Name(geospecies, "Omernik_4_52a_Savanna_Section") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_4_52b_Coulee_Section</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    ///   <para>geospecies:Omernik_Level_IV_Ecoregion_Classification</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Omernik_4_Paleozoic_Plateau_Coulee_Section"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_52b_Coulee_Section">http://rdf.geospecies.org/ont/geospecies#Omernik_4_52b_Coulee_Section</seealso>
    let Omernik_4_52b_Coulee_Section =
        Prefixed_Name(geospecies, "Omernik_4_52b_Coulee_Section") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_4_53a_Rock_River_Drift_Plain</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:Omernik_Level_IV_Ecoregion_Classification</para>
    ///
    /// labels<para>"Omernik_4_53a_Rock River Drift Plain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_53a_Rock_River_Drift_Plain">http://rdf.geospecies.org/ont/geospecies#Omernik_4_53a_Rock_River_Drift_Plain</seealso>
    let Omernik_4_53a_Rock_River_Drift_Plain =
        Prefixed_Name(geospecies, "Omernik_4_53a_Rock_River_Drift_Plain") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_4_53b_Kettle_Moraines</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:Omernik_Level_IV_Ecoregion_Classification</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Omernik_4_Kettle_Moraines"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_53b_Kettle_Moraines">http://rdf.geospecies.org/ont/geospecies#Omernik_4_53b_Kettle_Moraines</seealso>
    let Omernik_4_53b_Kettle_Moraines =
        Prefixed_Name(geospecies, "Omernik_4_53b_Kettle_Moraines") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_4_53c_Southeastern_Wisconsin_Savannah_and_Till_Plain</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Omernik_Level_IV_Ecoregion_Classification</para>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Omernik_4_Southeastern_Wisconsin_Savannah_and_Till_Plain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_53c_Southeastern_Wisconsin_Savannah_and_Till_Plain">http://rdf.geospecies.org/ont/geospecies#Omernik_4_53c_Southeastern_Wisconsin_Savannah_and_Till_Plain</seealso>
    let Omernik_4_53c_Southeastern_Wisconsin_Savannah_and_Till_Plain =
        Prefixed_Name(geospecies, "Omernik_4_53c_Southeastern_Wisconsin_Savannah_and_Till_Plain") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_4_53d_Lake_Michigan_Lacustrine_Clay_Plain</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Omernik_Level_IV_Ecoregion_Classification</para>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Omernik_4_53d_Lake Michigan Lacustrine Clay Plain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_53d_Lake_Michigan_Lacustrine_Clay_Plain">http://rdf.geospecies.org/ont/geospecies#Omernik_4_53d_Lake_Michigan_Lacustrine_Clay_Plain</seealso>
    let Omernik_4_53d_Lake_Michigan_Lacustrine_Clay_Plain =
        Prefixed_Name(geospecies, "Omernik_4_53d_Lake_Michigan_Lacustrine_Clay_Plain") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_4_54e_Chiwaukee_Prairie_Region</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:Omernik_Level_IV_Ecoregion_Classification</para>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    ///
    /// labels<para>"Omernik_4_Chiwaukee Prairie Region"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_4_54e_Chiwaukee_Prairie_Region">http://rdf.geospecies.org/ont/geospecies#Omernik_4_54e_Chiwaukee_Prairie_Region</seealso>
    let Omernik_4_54e_Chiwaukee_Prairie_Region =
        Prefixed_Name(geospecies, "Omernik_4_54e_Chiwaukee_Prairie_Region") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_Ecoregion_Classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Omernik Ecoregion Classification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_Ecoregion_Classification">http://rdf.geospecies.org/ont/geospecies#Omernik_Ecoregion_Classification</seealso>
    let Omernik_Ecoregion_Classification =
        Prefixed_Name(geospecies, "Omernik_Ecoregion_Classification") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_Level_III_Ecoregion_Classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Omernik_Level_Three_Classification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_Level_III_Ecoregion_Classification">http://rdf.geospecies.org/ont/geospecies#Omernik_Level_III_Ecoregion_Classification</seealso>
    let Omernik_Level_III_Ecoregion_Classification =
        Prefixed_Name(geospecies, "Omernik_Level_III_Ecoregion_Classification") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Omernik_Level_IV_Ecoregion_Classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Omernik_Level_Four_Classification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Omernik_Level_IV_Ecoregion_Classification">http://rdf.geospecies.org/ont/geospecies#Omernik_Level_IV_Ecoregion_Classification</seealso>
    let Omernik_Level_IV_Ecoregion_Classification =
        Prefixed_Name(geospecies, "Omernik_Level_IV_Ecoregion_Classification") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:OpenCycConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"OpenCycConcept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#OpenCycConcept">http://rdf.geospecies.org/ont/geospecies#OpenCycConcept</seealso>
    let OpenCycConcept = Prefixed_Name(geospecies, "OpenCycConcept") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:OrderConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"OrderConcept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#OrderConcept">http://rdf.geospecies.org/ont/geospecies#OrderConcept</seealso>
    let OrderConcept = Prefixed_Name(geospecies, "OrderConcept") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:PhotoCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PhotoCollection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#PhotoCollection">http://rdf.geospecies.org/ont/geospecies#PhotoCollection</seealso>
    let PhotoCollection = Prefixed_Name(geospecies, "PhotoCollection") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:PhylumConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"PhylumConcept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#PhylumConcept">http://rdf.geospecies.org/ont/geospecies#PhylumConcept</seealso>
    let PhylumConcept = Prefixed_Name(geospecies, "PhylumConcept") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:Project</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Project"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Project">http://rdf.geospecies.org/ont/geospecies#Project</seealso>
    let Project = Prefixed_Name(geospecies, "Project") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:Sex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Sex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Sex">http://rdf.geospecies.org/ont/geospecies#Sex</seealso>
    let Sex = Prefixed_Name(geospecies, "Sex") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:Sex_female</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:Sex</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"female"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Sex_female">http://rdf.geospecies.org/ont/geospecies#Sex_female</seealso>
    let Sex_female = Prefixed_Name(geospecies, "Sex_female") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Sex_hermaphrodite</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Sex</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"hermaphrodite"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Sex_hermaphrodite">http://rdf.geospecies.org/ont/geospecies#Sex_hermaphrodite</seealso>
    let Sex_hermaphrodite =
        Prefixed_Name(geospecies, "Sex_hermaphrodite") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Sex_male</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:Sex</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"male"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Sex_male">http://rdf.geospecies.org/ont/geospecies#Sex_male</seealso>
    let Sex_male = Prefixed_Name(geospecies, "Sex_male") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:Sex_undetermined</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:Sex</para>
    ///
    /// labels<para>"Sex Undetermined"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Sex_undetermined">http://rdf.geospecies.org/ont/geospecies#Sex_undetermined</seealso>
    let Sex_undetermined = Prefixed_Name(geospecies, "Sex_undetermined") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:Sex_unknowable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:Sex</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Sex Unknowable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Sex_unknowable">http://rdf.geospecies.org/ont/geospecies#Sex_unknowable</seealso>
    let Sex_unknowable = Prefixed_Name(geospecies, "Sex_unknowable") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:SpeciesConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"SpeciesConcept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#SpeciesConcept">http://rdf.geospecies.org/ont/geospecies#SpeciesConcept</seealso>
    let SpeciesConcept = Prefixed_Name(geospecies, "SpeciesConcept") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"State or Province"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"State"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#State">http://rdf.geospecies.org/ont/geospecies#State</seealso>
    let State = Prefixed_Name(geospecies, "State") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:TaxonConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TaxonConcept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonConcept">http://rdf.geospecies.org/ont/geospecies#TaxonConcept</seealso>
    let TaxonConcept = Prefixed_Name(geospecies, "TaxonConcept") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:TaxonRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TaxonRank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank">http://rdf.geospecies.org/ont/geospecies#TaxonRank</seealso>
    let TaxonRank = Prefixed_Name(geospecies, "TaxonRank") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:TaxonRank_class</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:TaxonRank</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"class"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_class">http://rdf.geospecies.org/ont/geospecies#TaxonRank_class</seealso>
    let TaxonRank_class = Prefixed_Name(geospecies, "TaxonRank_class") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_cultivar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:TaxonRank</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"TaxonRank_cultivar"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_cultivar">http://rdf.geospecies.org/ont/geospecies#TaxonRank_cultivar</seealso>
    let TaxonRank_cultivar =
        Prefixed_Name(geospecies, "TaxonRank_cultivar") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_cultivarGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:TaxonRank</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TaxonRank_cultivarGroup"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_cultivarGroup">http://rdf.geospecies.org/ont/geospecies#TaxonRank_cultivarGroup</seealso>
    let TaxonRank_cultivarGroup =
        Prefixed_Name(geospecies, "TaxonRank_cultivarGroup") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_domain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:TaxonRank</para>
    ///
    /// labels<para>"domain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_domain">http://rdf.geospecies.org/ont/geospecies#TaxonRank_domain</seealso>
    let TaxonRank_domain = Prefixed_Name(geospecies, "TaxonRank_domain") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:TaxonRank_family</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:TaxonRank</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TaxonRank_family"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_family">http://rdf.geospecies.org/ont/geospecies#TaxonRank_family</seealso>
    let TaxonRank_family = Prefixed_Name(geospecies, "TaxonRank_family") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:TaxonRank_form</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:TaxonRank</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"TaxonRank_form"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_form">http://rdf.geospecies.org/ont/geospecies#TaxonRank_form</seealso>
    let TaxonRank_form = Prefixed_Name(geospecies, "TaxonRank_form") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:TaxonRank_genus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:TaxonRank</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TaxonRank_genus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_genus">http://rdf.geospecies.org/ont/geospecies#TaxonRank_genus</seealso>
    let TaxonRank_genus = Prefixed_Name(geospecies, "TaxonRank_genus") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_infraorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:TaxonRank</para>
    ///
    /// labels<para>"TaxonRank_infraorder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_infraorder">http://rdf.geospecies.org/ont/geospecies#TaxonRank_infraorder</seealso>
    let TaxonRank_infraorder =
        Prefixed_Name(geospecies, "TaxonRank_infraorder") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_kingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:TaxonRank</para>
    ///
    /// labels<para>"kingdom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_kingdom">http://rdf.geospecies.org/ont/geospecies#TaxonRank_kingdom</seealso>
    let TaxonRank_kingdom =
        Prefixed_Name(geospecies, "TaxonRank_kingdom") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_lass</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_lass">http://rdf.geospecies.org/ont/geospecies#TaxonRank_lass</seealso>
    let TaxonRank_lass = Prefixed_Name(geospecies, "TaxonRank_lass") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:TaxonRank_order</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:TaxonRank</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"TaxonRank_order"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_order">http://rdf.geospecies.org/ont/geospecies#TaxonRank_order</seealso>
    let TaxonRank_order = Prefixed_Name(geospecies, "TaxonRank_order") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:TaxonRank_phylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:TaxonRank</para>
    ///
    /// labels<para>"phylum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_phylum">http://rdf.geospecies.org/ont/geospecies#TaxonRank_phylum</seealso>
    let TaxonRank_phylum = Prefixed_Name(geospecies, "TaxonRank_phylum") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_section</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:TaxonRank</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"TaxonRank_section"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_section">http://rdf.geospecies.org/ont/geospecies#TaxonRank_section</seealso>
    let TaxonRank_section =
        Prefixed_Name(geospecies, "TaxonRank_section") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_species</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:TaxonRank</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TaxonRank_species"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_species">http://rdf.geospecies.org/ont/geospecies#TaxonRank_species</seealso>
    let TaxonRank_species =
        Prefixed_Name(geospecies, "TaxonRank_species") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_speciesAggregate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:TaxonRank</para>
    ///
    /// labels<para>"TaxonRank_speciesAggregate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_speciesAggregate">http://rdf.geospecies.org/ont/geospecies#TaxonRank_speciesAggregate</seealso>
    let TaxonRank_speciesAggregate =
        Prefixed_Name(geospecies, "TaxonRank_speciesAggregate") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_subclass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:TaxonRank</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"subclass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subclass">http://rdf.geospecies.org/ont/geospecies#TaxonRank_subclass</seealso>
    let TaxonRank_subclass =
        Prefixed_Name(geospecies, "TaxonRank_subclass") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_subfamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:TaxonRank</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TaxonRank_subfamily"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subfamily">http://rdf.geospecies.org/ont/geospecies#TaxonRank_subfamily</seealso>
    let TaxonRank_subfamily =
        Prefixed_Name(geospecies, "TaxonRank_subfamily") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_subform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:TaxonRank</para>
    ///
    /// labels<para>"TaxonRank_subform"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subform">http://rdf.geospecies.org/ont/geospecies#TaxonRank_subform</seealso>
    let TaxonRank_subform =
        Prefixed_Name(geospecies, "TaxonRank_subform") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_subgenus</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:TaxonRank</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"TaxonRank_subgenus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subgenus">http://rdf.geospecies.org/ont/geospecies#TaxonRank_subgenus</seealso>
    let TaxonRank_subgenus =
        Prefixed_Name(geospecies, "TaxonRank_subgenus") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_subkingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:TaxonRank</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"subkingdom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subkingdom">http://rdf.geospecies.org/ont/geospecies#TaxonRank_subkingdom</seealso>
    let TaxonRank_subkingdom =
        Prefixed_Name(geospecies, "TaxonRank_subkingdom") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_suborder</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:TaxonRank</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TaxonRank_suborder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_suborder">http://rdf.geospecies.org/ont/geospecies#TaxonRank_suborder</seealso>
    let TaxonRank_suborder =
        Prefixed_Name(geospecies, "TaxonRank_suborder") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_subphylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:TaxonRank</para>
    ///
    /// labels<para>"subphylum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subphylum">http://rdf.geospecies.org/ont/geospecies#TaxonRank_subphylum</seealso>
    let TaxonRank_subphylum =
        Prefixed_Name(geospecies, "TaxonRank_subphylum") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_subsection</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:TaxonRank</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"TaxonRank_subsection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subsection">http://rdf.geospecies.org/ont/geospecies#TaxonRank_subsection</seealso>
    let TaxonRank_subsection =
        Prefixed_Name(geospecies, "TaxonRank_subsection") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_subspecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:TaxonRank</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"TaxonRank_subspecies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subspecies">http://rdf.geospecies.org/ont/geospecies#TaxonRank_subspecies</seealso>
    let TaxonRank_subspecies =
        Prefixed_Name(geospecies, "TaxonRank_subspecies") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_subspecificAggregate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:TaxonRank</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TaxonRank_subspecificAggregate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subspecificAggregate">http://rdf.geospecies.org/ont/geospecies#TaxonRank_subspecificAggregate</seealso>
    let TaxonRank_subspecificAggregate =
        Prefixed_Name(geospecies, "TaxonRank_subspecificAggregate") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_subtribe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:TaxonRank</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"TaxonRank_subtribe"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subtribe">http://rdf.geospecies.org/ont/geospecies#TaxonRank_subtribe</seealso>
    let TaxonRank_subtribe =
        Prefixed_Name(geospecies, "TaxonRank_subtribe") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_subvariety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:TaxonRank</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TaxonRank_subvariety"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_subvariety">http://rdf.geospecies.org/ont/geospecies#TaxonRank_subvariety</seealso>
    let TaxonRank_subvariety =
        Prefixed_Name(geospecies, "TaxonRank_subvariety") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_superclass</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:TaxonRank</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"superclass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_superclass">http://rdf.geospecies.org/ont/geospecies#TaxonRank_superclass</seealso>
    let TaxonRank_superclass =
        Prefixed_Name(geospecies, "TaxonRank_superclass") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_superfamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:TaxonRank</para>
    ///
    /// labels<para>"TaxonRank_superfamily"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_superfamily">http://rdf.geospecies.org/ont/geospecies#TaxonRank_superfamily</seealso>
    let TaxonRank_superfamily =
        Prefixed_Name(geospecies, "TaxonRank_superfamily") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_superorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:TaxonRank</para>
    ///
    /// labels<para>"TaxonRank_superorder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_superorder">http://rdf.geospecies.org/ont/geospecies#TaxonRank_superorder</seealso>
    let TaxonRank_superorder =
        Prefixed_Name(geospecies, "TaxonRank_superorder") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_tribe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:TaxonRank</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"TaxonRank_tribe"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_tribe">http://rdf.geospecies.org/ont/geospecies#TaxonRank_tribe</seealso>
    let TaxonRank_tribe = Prefixed_Name(geospecies, "TaxonRank_tribe") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonRank_variety</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:TaxonRank</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TaxonRank_variety"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonRank_variety">http://rdf.geospecies.org/ont/geospecies#TaxonRank_variety</seealso>
    let TaxonRank_variety =
        Prefixed_Name(geospecies, "TaxonRank_variety") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonomicStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"taxonomicStatus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus">http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus</seealso>
    let TaxonomicStatus = Prefixed_Name(geospecies, "TaxonomicStatus") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonomicStatus_accepted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:TaxonomicStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Accepted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_accepted">http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_accepted</seealso>
    let TaxonomicStatus_accepted =
        Prefixed_Name(geospecies, "TaxonomicStatus_accepted") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonomicStatus_heterotypicSynonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:TaxonomicStatus</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Heterotypic Synonym"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_heterotypicSynonym">http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_heterotypicSynonym</seealso>
    let TaxonomicStatus_heterotypicSynonym =
        Prefixed_Name(geospecies, "TaxonomicStatus_heterotypicSynonym") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonomicStatus_homotypicSynonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:TaxonomicStatus</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Homotypic Synonym"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_homotypicSynonym">http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_homotypicSynonym</seealso>
    let TaxonomicStatus_homotypicSynonym =
        Prefixed_Name(geospecies, "TaxonomicStatus_homotypicSynonym") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonomicStatus_invalid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:TaxonomicStatus</para>
    ///   <para>owl:Thing</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_invalid">http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_invalid</seealso>
    let TaxonomicStatus_invalid =
        Prefixed_Name(geospecies, "TaxonomicStatus_invalid") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonomicStatus_misapplied</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:TaxonomicStatus</para>
    ///
    /// labels<para>"Misapplied"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_misapplied">http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_misapplied</seealso>
    let TaxonomicStatus_misapplied =
        Prefixed_Name(geospecies, "TaxonomicStatus_misapplied") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonomicStatus_proParteSynonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:TaxonomicStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Proparte Synonym"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_proParteSynonym">http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_proParteSynonym</seealso>
    let TaxonomicStatus_proParteSynonym =
        Prefixed_Name(geospecies, "TaxonomicStatus_proParteSynonym") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonomicStatus_synonym</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:TaxonomicStatus</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Synonym"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_synonym">http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_synonym</seealso>
    let TaxonomicStatus_synonym =
        Prefixed_Name(geospecies, "TaxonomicStatus_synonym") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonomicStatus_unaccepted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:TaxonomicStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Unaccepted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_unaccepted">http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_unaccepted</seealso>
    let TaxonomicStatus_unaccepted =
        Prefixed_Name(geospecies, "TaxonomicStatus_unaccepted") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TaxonomicStatus_unverified</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:TaxonomicStatus</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_unverified">http://rdf.geospecies.org/ont/geospecies#TaxonomicStatus_unverified</seealso>
    let TaxonomicStatus_unverified =
        Prefixed_Name(geospecies, "TaxonomicStatus_unverified") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:ThreatStatusIUCN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"ThreatStatusIUCN"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#ThreatStatusIUCN">http://rdf.geospecies.org/ont/geospecies#ThreatStatusIUCN</seealso>
    let ThreatStatusIUCN = Prefixed_Name(geospecies, "ThreatStatusIUCN") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:TypeStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"TypeStatus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TypeStatus">http://rdf.geospecies.org/ont/geospecies#TypeStatus</seealso>
    let TypeStatus = Prefixed_Name(geospecies, "TypeStatus") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TypeStatus_hapantotype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:TypeStatus</para>
    ///
    /// labels<para>"TypeStatus_hapantotype"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_hapantotype">http://rdf.geospecies.org/ont/geospecies#TypeStatus_hapantotype</seealso>
    let TypeStatus_hapantotype =
        Prefixed_Name(geospecies, "TypeStatus_hapantotype") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TypeStatus_holotype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:TypeStatus</para>
    ///
    /// labels<para>"TypeStatus_holotype"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_holotype">http://rdf.geospecies.org/ont/geospecies#TypeStatus_holotype</seealso>
    let TypeStatus_holotype =
        Prefixed_Name(geospecies, "TypeStatus_holotype") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TypeStatus_lectotype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:TypeStatus</para>
    ///
    /// labels<para>"TypeStatus_lectotype"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_lectotype">http://rdf.geospecies.org/ont/geospecies#TypeStatus_lectotype</seealso>
    let TypeStatus_lectotype =
        Prefixed_Name(geospecies, "TypeStatus_lectotype") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TypeStatus_neotype</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:TypeStatus</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TypeStatus_neotype"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_neotype">http://rdf.geospecies.org/ont/geospecies#TypeStatus_neotype</seealso>
    let TypeStatus_neotype =
        Prefixed_Name(geospecies, "TypeStatus_neotype") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TypeStatus_paralectotype</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:TypeStatus</para>
    ///
    /// labels<para>"TypeStatus_paralectotype"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_paralectotype">http://rdf.geospecies.org/ont/geospecies#TypeStatus_paralectotype</seealso>
    let TypeStatus_paralectotype =
        Prefixed_Name(geospecies, "TypeStatus_paralectotype") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TypeStatus_paratype</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:TypeStatus</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TypeStatus_paratype"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_paratype">http://rdf.geospecies.org/ont/geospecies#TypeStatus_paratype</seealso>
    let TypeStatus_paratype =
        Prefixed_Name(geospecies, "TypeStatus_paratype") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TypeStatus_syntype</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:TypeStatus</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"TypeStatus_syntype"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_syntype">http://rdf.geospecies.org/ont/geospecies#TypeStatus_syntype</seealso>
    let TypeStatus_syntype =
        Prefixed_Name(geospecies, "TypeStatus_syntype") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:TypeStatus_varitype</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:TypeStatus</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"TypeStatus_varitype"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#TypeStatus_varitype">http://rdf.geospecies.org/ont/geospecies#TypeStatus_varitype</seealso>
    let TypeStatus_varitype =
        Prefixed_Name(geospecies, "TypeStatus_varitype") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Growth_Habit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"USDA_Growth_Habit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit">http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit</seealso>
    let USDA_Growth_Habit =
        Prefixed_Name(geospecies, "USDA_Growth_Habit") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Growth_Habit_Forb_Herb</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:USDA_Growth_Habit</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Applies to vascular plants only. Federal Geographic Data Committee (FGDC) definition includes graminoids, forbs, and ferns."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"USDA_Growth_Habit_Forb_Herb"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Forb_Herb">http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Forb_Herb</seealso>
    let USDA_Growth_Habit_Forb_Herb =
        Prefixed_Name(geospecies, "USDA_Growth_Habit_Forb_Herb") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Growth_Habit_Graminoid</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:USDA_Growth_Habit</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Applies to vascular plants only. An herb in the FGDC classification."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"USDA_Growth_Habit_Graminoid"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Graminoid">http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Graminoid</seealso>
    let USDA_Growth_Habit_Graminoid =
        Prefixed_Name(geospecies, "USDA_Growth_Habit_Graminoid") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Growth_Habit_Liana</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:USDA_Growth_Habit</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Applies to vascular plants only. In PLANTS, mutually exclusive with VI (Vine). A shrub in the FGDC classification."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"USDA_Growth_Habit_Liana"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Liana">http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Liana</seealso>
    let USDA_Growth_Habit_Liana =
        Prefixed_Name(geospecies, "USDA_Growth_Habit_Liana") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Growth_Habit_Lichenous</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:USDA_Growth_Habit</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Applies to lichens only, which are not true plants."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"USDA_Growth_Habit_Lichenous"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Lichenous">http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Lichenous</seealso>
    let USDA_Growth_Habit_Lichenous =
        Prefixed_Name(geospecies, "USDA_Growth_Habit_Lichenous") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Growth_Habit_Nonvascular</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:USDA_Growth_Habit</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Applies to non-vascular plants only; in PLANTS system this is groups HN (Hornworts), LV (Liverworts), and MS (Mosses)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"USDA_Growth_Habit_Nonvascular"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Nonvascular">http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Nonvascular</seealso>
    let USDA_Growth_Habit_Nonvascular =
        Prefixed_Name(geospecies, "USDA_Growth_Habit_Nonvascular") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Growth_Habit_Shrub</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:USDA_Growth_Habit</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Applies to vascular plants only."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"USDA_Growth_Habit_Shrub"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Shrub">http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Shrub</seealso>
    let USDA_Growth_Habit_Shrub =
        Prefixed_Name(geospecies, "USDA_Growth_Habit_Shrub") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Growth_Habit_Subshrub</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:USDA_Growth_Habit</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Applies to vascular plants only. A dwarf-shrub in the FGDC classification."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"USDA_Growth_Habit_Subshrub"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Subshrub">http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Subshrub</seealso>
    let USDA_Growth_Habit_Subshrub =
        Prefixed_Name(geospecies, "USDA_Growth_Habit_Subshrub") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Growth_Habit_Tree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:USDA_Growth_Habit</para>
    ///   <para>owl:Thing</para>
    ///   <para>"Applies to vascular plants only."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"USDA_Growth_Habit_Tree"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Tree">http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Tree</seealso>
    let USDA_Growth_Habit_Tree =
        Prefixed_Name(geospecies, "USDA_Growth_Habit_Tree") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Growth_Habit_Unknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:USDA_Growth_Habit</para>
    ///
    /// labels<para>"USDA_Growth_Habit_Unknown"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Unknown">http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Unknown</seealso>
    let USDA_Growth_Habit_Unknown =
        Prefixed_Name(geospecies, "USDA_Growth_Habit_Unknown") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Growth_Habit_Vine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:USDA_Growth_Habit</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Applies to vascular plants only. In PLANTS, mutually exclusive with LI (Liana). FGDC classification considers woody vines to be shrubs and herbaceous vines to be herbs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"USDA_Growth_Habit_Vine"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Vine">http://rdf.geospecies.org/ont/geospecies#USDA_Growth_Habit_Vine</seealso>
    let USDA_Growth_Habit_Vine =
        Prefixed_Name(geospecies, "USDA_Growth_Habit_Vine") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Native_Jurisdiction_Code</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Native Jurisdiction Code"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Jurisdiction_Code">http://rdf.geospecies.org/ont/geospecies#USDA_Native_Jurisdiction_Code</seealso>
    let USDA_Native_Jurisdiction_Code =
        Prefixed_Name(geospecies, "USDA_Native_Jurisdiction_Code") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Native_Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"USDA_Native_Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status">http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status</seealso>
    let USDA_Native_Status =
        Prefixed_Name(geospecies, "USDA_Native_Status") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Native_Status_Introduced_Garden_persistent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:USDA_Native_Status</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"USDA_Native_Status_Introduced_Garden_persistent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Garden_persistent">http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Garden_persistent</seealso>
    let USDA_Native_Status_Introduced_Garden_persistent =
        Prefixed_Name(geospecies, "USDA_Native_Status_Introduced_Garden_persistent") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Native_Status_Introduced_Introduced</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:USDA_Native_Status</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USDA_Native_Status_Introduced_Introduced"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Introduced">http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Introduced</seealso>
    let USDA_Native_Status_Introduced_Introduced =
        Prefixed_Name(geospecies, "USDA_Native_Status_Introduced_Introduced") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Native_Status_Introduced_Probably_Garden_persistent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:USDA_Native_Status</para>
    ///
    /// labels<para>"USDA_Native_Status_Introduced_Probably_Garden_persistent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Probably_Garden_persistent">http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Probably_Garden_persistent</seealso>
    let USDA_Native_Status_Introduced_Probably_Garden_persistent =
        Prefixed_Name(geospecies, "USDA_Native_Status_Introduced_Probably_Garden_persistent") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Native_Status_Introduced_Probably_Introduced</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:USDA_Native_Status</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USDA_Native_Status_Introduced_Probably_Introduced"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Probably_Introduced">http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Probably_Introduced</seealso>
    let USDA_Native_Status_Introduced_Probably_Introduced =
        Prefixed_Name(geospecies, "USDA_Native_Status_Introduced_Probably_Introduced") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Native_Status_Introduced_Probably_Native_and_Introduced</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:USDA_Native_Status</para>
    ///
    /// labels<para>"USDA_Native_Status_Introduced_Probably_Native_and_Introduced"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Probably_Native_and_Introduced">http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Probably_Native_and_Introduced</seealso>
    let USDA_Native_Status_Introduced_Probably_Native_and_Introduced =
        Prefixed_Name(geospecies, "USDA_Native_Status_Introduced_Probably_Native_and_Introduced") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Native_Status_Introduced_Probably_a_Waif</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:USDA_Native_Status</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"USDA_Native_Status_Introduced_Probably_a_Waif"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Probably_a_Waif">http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Probably_a_Waif</seealso>
    let USDA_Native_Status_Introduced_Probably_a_Waif =
        Prefixed_Name(geospecies, "USDA_Native_Status_Introduced_Probably_a_Waif") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Native_Status_Introduced_Waif</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:USDA_Native_Status</para>
    ///
    /// labels<para>"USDA_Native_Status_Introduced_Waif"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Waif">http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Introduced_Waif</seealso>
    let USDA_Native_Status_Introduced_Waif =
        Prefixed_Name(geospecies, "USDA_Native_Status_Introduced_Waif") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Native_Status_Native_Native</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:USDA_Native_Status</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"USDA_Native_Status_Native_Native"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Native_Native">http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Native_Native</seealso>
    let USDA_Native_Status_Native_Native =
        Prefixed_Name(geospecies, "USDA_Native_Status_Native_Native") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Native_Status_Native_Native_and_Introduced</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:USDA_Native_Status</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"USDA_Native_Status_Native_Native_and_Introduced"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Native_Native_and_Introduced">http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Native_Native_and_Introduced</seealso>
    let USDA_Native_Status_Native_Native_and_Introduced =
        Prefixed_Name(geospecies, "USDA_Native_Status_Native_Native_and_Introduced") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Native_Status_Native_Native_and_Probably_Introduced</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:USDA_Native_Status</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"USDA_Native_Status_Native_Native_and_Probably_Introduced"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Native_Native_and_Probably_Introduced">http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Native_Native_and_Probably_Introduced</seealso>
    let USDA_Native_Status_Native_Native_and_Probably_Introduced =
        Prefixed_Name(geospecies, "USDA_Native_Status_Native_Native_and_Probably_Introduced") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Native_Status_Native_Probably_Native</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:USDA_Native_Status</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"USDA_Native_Status_Native_Probably_Native"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Native_Probably_Native">http://rdf.geospecies.org/ont/geospecies#USDA_Native_Status_Native_Probably_Native</seealso>
    let USDA_Native_Status_Native_Probably_Native =
        Prefixed_Name(geospecies, "USDA_Native_Status_Native_Probably_Native") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:USDA_Plant_Characteristics</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"USDA_Plants_Characteristics"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#USDA_Plant_Characteristics">http://rdf.geospecies.org/ont/geospecies#USDA_Plant_Characteristics</seealso>
    let USDA_Plant_Characteristics =
        Prefixed_Name(geospecies, "USDA_Plant_Characteristics") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:UUID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"UUID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#UUID">http://rdf.geospecies.org/ont/geospecies#UUID</seealso>
    let UUID = Prefixed_Name(geospecies, "UUID") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:Ubio_LSID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Ubio_LSID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Ubio_LSID">http://rdf.geospecies.org/ont/geospecies#Ubio_LSID</seealso>
    let Ubio_LSID = Prefixed_Name(geospecies, "Ubio_LSID") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:UniprotTaxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"UniprotTaxon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#UniprotTaxon">http://rdf.geospecies.org/ont/geospecies#UniprotTaxon</seealso>
    let UniprotTaxon = Prefixed_Name(geospecies, "UniprotTaxon") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:WikipediaArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WikipediaArticle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#WikipediaArticle">http://rdf.geospecies.org/ont/geospecies#WikipediaArticle</seealso>
    let WikipediaArticle = Prefixed_Name(geospecies, "WikipediaArticle") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:WikispeciesArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"WikispeciesArticle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#WikispeciesArticle">http://rdf.geospecies.org/ont/geospecies#WikispeciesArticle</seealso>
    let WikispeciesArticle =
        Prefixed_Name(geospecies, "WikispeciesArticle") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Wisconsin_Herbarium_Beech_Forest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:Wisconsin_Herbarium_Habitat_Classification</para>
    ///
    /// labels<para>"Wisconsin_Herbarium_Beech_Forest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Beech_Forest">http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Beech_Forest</seealso>
    let Wisconsin_Herbarium_Beech_Forest =
        Prefixed_Name(geospecies, "Wisconsin_Herbarium_Beech_Forest") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Wisconsin_Herbarium_Bog_and_Fen</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Wisconsin_Herbarium_Habitat_Classification</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Wisconsin_Herbarium_Bog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Bog_and_Fen">http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Bog_and_Fen</seealso>
    let Wisconsin_Herbarium_Bog_and_Fen =
        Prefixed_Name(geospecies, "Wisconsin_Herbarium_Bog_and_Fen") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Wisconsin_Herbarium_Boreal_Forest</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Wisconsin_Herbarium_Habitat_Classification</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Wisconsin_Herbarium_Boreal_Forest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Boreal_Forest">http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Boreal_Forest</seealso>
    let Wisconsin_Herbarium_Boreal_Forest =
        Prefixed_Name(geospecies, "Wisconsin_Herbarium_Boreal_Forest") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Wisconsin_Herbarium_Bracken_Grassland</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:Wisconsin_Herbarium_Habitat_Classification</para>
    ///
    /// labels<para>"Wisconsin_Herbarium_Bracken_Grassland"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Bracken_Grassland">http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Bracken_Grassland</seealso>
    let Wisconsin_Herbarium_Bracken_Grassland =
        Prefixed_Name(geospecies, "Wisconsin_Herbarium_Bracken_Grassland") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Wisconsin_Herbarium_Cliff</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Wisconsin_Herbarium_Habitat_Classification</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Wisconsin_Herbarium_Cliff"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Cliff">http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Cliff</seealso>
    let Wisconsin_Herbarium_Cliff =
        Prefixed_Name(geospecies, "Wisconsin_Herbarium_Cliff") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Wisconsin_Herbarium_Emergent_Aquatic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:Wisconsin_Herbarium_Habitat_Classification</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Wisconsin_Herbarium_Emergent_Aquatic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Emergent_Aquatic">http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Emergent_Aquatic</seealso>
    let Wisconsin_Herbarium_Emergent_Aquatic =
        Prefixed_Name(geospecies, "Wisconsin_Herbarium_Emergent_Aquatic") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Wisconsin_Herbarium_Habitat_Classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wisconsin Herbarium Habitat Classification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Habitat_Classification">http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Habitat_Classification</seealso>
    let Wisconsin_Herbarium_Habitat_Classification =
        Prefixed_Name(geospecies, "Wisconsin_Herbarium_Habitat_Classification") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Wisconsin_Herbarium_Northern_Lowland_Forest</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Wisconsin_Herbarium_Habitat_Classification</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Wisconsin_Herbarium_Northern_Lowland_Forest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Northern_Lowland_Forest">http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Northern_Lowland_Forest</seealso>
    let Wisconsin_Herbarium_Northern_Lowland_Forest =
        Prefixed_Name(geospecies, "Wisconsin_Herbarium_Northern_Lowland_Forest") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Wisconsin_Herbarium_Northern_Upland_Forest</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Wisconsin_Herbarium_Habitat_Classification</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Wisconsin_Herbarium_Northern_Upland_Forest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Northern_Upland_Forest">http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Northern_Upland_Forest</seealso>
    let Wisconsin_Herbarium_Northern_Upland_Forest =
        Prefixed_Name(geospecies, "Wisconsin_Herbarium_Northern_Upland_Forest") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Wisconsin_Herbarium_Pine_Barrens</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:Wisconsin_Herbarium_Habitat_Classification</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Wisconsin_Herbarium_Pine_Barrens"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Pine_Barrens">http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Pine_Barrens</seealso>
    let Wisconsin_Herbarium_Pine_Barrens =
        Prefixed_Name(geospecies, "Wisconsin_Herbarium_Pine_Barrens") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Wisconsin_Herbarium_Prairie</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:Wisconsin_Herbarium_Habitat_Classification</para>
    ///
    /// labels<para>"Wisconsin_Herbarium_Prairie"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Prairie">http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Prairie</seealso>
    let Wisconsin_Herbarium_Prairie =
        Prefixed_Name(geospecies, "Wisconsin_Herbarium_Prairie") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Wisconsin_Herbarium_Sand_Barrens</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:Wisconsin_Herbarium_Habitat_Classification</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Wisconsin_Herbarium_Sand_Barrens"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Sand_Barrens">http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Sand_Barrens</seealso>
    let Wisconsin_Herbarium_Sand_Barrens =
        Prefixed_Name(geospecies, "Wisconsin_Herbarium_Sand_Barrens") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Wisconsin_Herbarium_Sand_Dunes</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Wisconsin_Herbarium_Habitat_Classification</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Wisconsin_Herbarium_Sand_Dunes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Sand_Dunes">http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Sand_Dunes</seealso>
    let Wisconsin_Herbarium_Sand_Dunes =
        Prefixed_Name(geospecies, "Wisconsin_Herbarium_Sand_Dunes") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Wisconsin_Herbarium_Savanna</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Wisconsin_Herbarium_Habitat_Classification</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Wisconsin_Herbarium_Savanna"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Savanna">http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Savanna</seealso>
    let Wisconsin_Herbarium_Savanna =
        Prefixed_Name(geospecies, "Wisconsin_Herbarium_Savanna") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Wisconsin_Herbarium_Sedge_Meadow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:Wisconsin_Herbarium_Habitat_Classification</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Wisconsin_Herbarium_Sedge_Meadow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Sedge_Meadow">http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Sedge_Meadow</seealso>
    let Wisconsin_Herbarium_Sedge_Meadow =
        Prefixed_Name(geospecies, "Wisconsin_Herbarium_Sedge_Meadow") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Wisconsin_Herbarium_Shrub_Carr</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:Wisconsin_Herbarium_Habitat_Classification</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Wisconsin_Herbarium_Shrub_Carr"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Shrub_Carr">http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Shrub_Carr</seealso>
    let Wisconsin_Herbarium_Shrub_Carr =
        Prefixed_Name(geospecies, "Wisconsin_Herbarium_Shrub_Carr") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Wisconsin_Herbarium_Southern_Lowland_Forest</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Wisconsin_Herbarium_Habitat_Classification</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Wisconsin_Herbarium_Southern_Lowland_Forest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Southern_Lowland_Forest">http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Southern_Lowland_Forest</seealso>
    let Wisconsin_Herbarium_Southern_Lowland_Forest =
        Prefixed_Name(geospecies, "Wisconsin_Herbarium_Southern_Lowland_Forest") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Wisconsin_Herbarium_Southern_Upland_Forest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///   <para>geospecies:Wisconsin_Herbarium_Habitat_Classification</para>
    ///
    /// labels<para>"Wisconsin_Herbarium_Southern_Upland_Forest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Southern_Upland_Forest">http://rdf.geospecies.org/ont/geospecies#Wisconsin_Herbarium_Southern_Upland_Forest</seealso>
    let Wisconsin_Herbarium_Southern_Upland_Forest =
        Prefixed_Name(geospecies, "Wisconsin_Herbarium_Southern_Upland_Forest") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:Wisconsin_Natural_Heritage_Inventory_Habitat_Classification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Wisconsin_Natural_Heritage_Inventory Habitat_Classification"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#Wisconsin_Natural_Heritage_Inventory_Habitat_Classification">http://rdf.geospecies.org/ont/geospecies#Wisconsin_Natural_Heritage_Inventory_Habitat_Classification</seealso>
    let Wisconsin_Natural_Heritage_Inventory_Habitat_Classification =
        Prefixed_Name(geospecies, "Wisconsin_Natural_Heritage_Inventory_Habitat_Classification") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:World_Pyrochroidae_Database</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Project</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"World Pyrochroidae Database"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#World_Pyrochroidae_Database">http://rdf.geospecies.org/ont/geospecies#World_Pyrochroidae_Database</seealso>
    let World_Pyrochroidae_Database =
        Prefixed_Name(geospecies, "World_Pyrochroidae_Database") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:habitatHasSpeciesAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasSpeciesAssociation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#habitatHasSpeciesAssociation">http://rdf.geospecies.org/ont/geospecies#habitatHasSpeciesAssociation</seealso>
    let habitatHasSpeciesAssociation =
        Prefixed_Name(geospecies, "habitatHasSpeciesAssociation") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasBBCHabitatAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasBBCHabitatPreference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasBBCHabitatAssociation">http://rdf.geospecies.org/ont/geospecies#hasBBCHabitatAssociation</seealso>
    let hasBBCHabitatAssociation =
        Prefixed_Name(geospecies, "hasBBCHabitatAssociation") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasBBC_Ecozone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasBBC_Ecozone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasBBC_Ecozone">http://rdf.geospecies.org/ont/geospecies#hasBBC_Ecozone</seealso>
    let hasBBC_Ecozone = Prefixed_Name(geospecies, "hasBBC_Ecozone") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasBBC_EcozoneName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasBBC_EcozoneName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasBBC_EcozoneName">http://rdf.geospecies.org/ont/geospecies#hasBBC_EcozoneName</seealso>
    let hasBBC_EcozoneName =
        Prefixed_Name(geospecies, "hasBBC_EcozoneName") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasBBC_Habitat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasBBC_Habitat"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasBBC_Habitat">http://rdf.geospecies.org/ont/geospecies#hasBBC_Habitat</seealso>
    let hasBBC_Habitat = Prefixed_Name(geospecies, "hasBBC_Habitat") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasBasionymName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasBasionymName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasBasionymName">http://rdf.geospecies.org/ont/geospecies#hasBasionymName</seealso>
    let hasBasionymName = Prefixed_Name(geospecies, "hasBasionymName") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasBio2RDFtaxon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasBio2RDFtaxon"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasBio2RDFtaxon">http://rdf.geospecies.org/ont/geospecies#hasBio2RDFtaxon</seealso>
    let hasBio2RDFtaxon = Prefixed_Name(geospecies, "hasBio2RDFtaxon") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasBioLib</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasBioLib"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasBioLib">http://rdf.geospecies.org/ont/geospecies#hasBioLib</seealso>
    let hasBioLib = Prefixed_Name(geospecies, "hasBioLib") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasBioLibPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasBioLibPage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasBioLibPage">http://rdf.geospecies.org/ont/geospecies#hasBioLibPage</seealso>
    let hasBioLibPage = Prefixed_Name(geospecies, "hasBioLibPage") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasBugGuidePage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasBugGuidePage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasBugGuidePage">http://rdf.geospecies.org/ont/geospecies#hasBugGuidePage</seealso>
    let hasBugGuidePage = Prefixed_Name(geospecies, "hasBugGuidePage") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasCanonicalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasCanonicalName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasCanonicalName">http://rdf.geospecies.org/ont/geospecies#hasCanonicalName</seealso>
    let hasCanonicalName = Prefixed_Name(geospecies, "hasCanonicalName") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasClassName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasClassName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasClassName">http://rdf.geospecies.org/ont/geospecies#hasClassName</seealso>
    let hasClassName = Prefixed_Name(geospecies, "hasClassName") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasCoL_LSID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasCoL_LSID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasCoL_LSID">http://rdf.geospecies.org/ont/geospecies#hasCoL_LSID</seealso>
    let hasCoL_LSID = Prefixed_Name(geospecies, "hasCoL_LSID") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasCollectionCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasCollectionCode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasCollectionCode">http://rdf.geospecies.org/ont/geospecies#hasCollectionCode</seealso>
    let hasCollectionCode =
        Prefixed_Name(geospecies, "hasCollectionCode") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasCollector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasCollector"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasCollector">http://rdf.geospecies.org/ont/geospecies#hasCollector</seealso>
    let hasCollector = Prefixed_Name(geospecies, "hasCollector") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasCommonName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasCommonName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasCommonName">http://rdf.geospecies.org/ont/geospecies#hasCommonName</seealso>
    let hasCommonName = Prefixed_Name(geospecies, "hasCommonName") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasContinent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasContinent"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasContinent">http://rdf.geospecies.org/ont/geospecies#hasContinent</seealso>
    let hasContinent = Prefixed_Name(geospecies, "hasContinent") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasContinentName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasContinentName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasContinentName">http://rdf.geospecies.org/ont/geospecies#hasContinentName</seealso>
    let hasContinentName = Prefixed_Name(geospecies, "hasContinentName") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasCountry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasCountry"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasCountry">http://rdf.geospecies.org/ont/geospecies#hasCountry</seealso>
    let hasCountry = Prefixed_Name(geospecies, "hasCountry") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasCountryCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasCountryCode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasCountryCode">http://rdf.geospecies.org/ont/geospecies#hasCountryCode</seealso>
    let hasCountryCode = Prefixed_Name(geospecies, "hasCountryCode") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasCountryName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasCountryName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasCountryName">http://rdf.geospecies.org/ont/geospecies#hasCountryName</seealso>
    let hasCountryName = Prefixed_Name(geospecies, "hasCountryName") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasCounty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasCounty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasCounty">http://rdf.geospecies.org/ont/geospecies#hasCounty</seealso>
    let hasCounty = Prefixed_Name(geospecies, "hasCounty") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasCountyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasCountyName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasCountyName">http://rdf.geospecies.org/ont/geospecies#hasCountyName</seealso>
    let hasCountyName = Prefixed_Name(geospecies, "hasCountyName") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasDBpediaResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasDBpediaResource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasDBpediaResource">http://rdf.geospecies.org/ont/geospecies#hasDBpediaResource</seealso>
    let hasDBpediaResource =
        Prefixed_Name(geospecies, "hasDBpediaResource") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasEOLPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasEOLPage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasEOLPage">http://rdf.geospecies.org/ont/geospecies#hasEOLPage</seealso>
    let hasEOLPage = Prefixed_Name(geospecies, "hasEOLPage") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasEndDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasEndDate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasEndDate">http://rdf.geospecies.org/ont/geospecies#hasEndDate</seealso>
    let hasEndDate = Prefixed_Name(geospecies, "hasEndDate") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasEndDayOfYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasEndDayOfYear"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasEndDayOfYear">http://rdf.geospecies.org/ont/geospecies#hasEndDayOfYear</seealso>
    let hasEndDayOfYear = Prefixed_Name(geospecies, "hasEndDayOfYear") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasExpectationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasExpectationOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasExpectationOf">http://rdf.geospecies.org/ont/geospecies#hasExpectationOf</seealso>
    let hasExpectationOf = Prefixed_Name(geospecies, "hasExpectationOf") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasFamilyInfoContributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasFamilyInfoContributor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasFamilyInfoContributor">http://rdf.geospecies.org/ont/geospecies#hasFamilyInfoContributor</seealso>
    let hasFamilyInfoContributor =
        Prefixed_Name(geospecies, "hasFamilyInfoContributor") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasFamilyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasFamilyName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasFamilyName">http://rdf.geospecies.org/ont/geospecies#hasFamilyName</seealso>
    let hasFamilyName = Prefixed_Name(geospecies, "hasFamilyName") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasFreebaseResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"FreebaseResource"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasFreebaseResource">http://rdf.geospecies.org/ont/geospecies#hasFreebaseResource</seealso>
    let hasFreebaseResource =
        Prefixed_Name(geospecies, "hasFreebaseResource") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasGBIF</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasGBIF"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasGBIF">http://rdf.geospecies.org/ont/geospecies#hasGBIF</seealso>
    let hasGBIF = Prefixed_Name(geospecies, "hasGBIF") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasGBIFPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasGBIFPage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasGBIFPage">http://rdf.geospecies.org/ont/geospecies#hasGBIFPage</seealso>
    let hasGBIFPage = Prefixed_Name(geospecies, "hasGBIFPage") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasGNI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasGNI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasGNI">http://rdf.geospecies.org/ont/geospecies#hasGNI</seealso>
    let hasGNI = Prefixed_Name(geospecies, "hasGNI") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasGenusName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasGenusName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasGenusName">http://rdf.geospecies.org/ont/geospecies#hasGenusName</seealso>
    let hasGenusName = Prefixed_Name(geospecies, "hasGenusName") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasGeoSpeciesConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasGeoSpeciesConcept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasGeoSpeciesConcept">http://rdf.geospecies.org/ont/geospecies#hasGeoSpeciesConcept</seealso>
    let hasGeoSpeciesConcept =
        Prefixed_Name(geospecies, "hasGeoSpeciesConcept") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasGeodeticDatum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasGeodeticDatum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasGeodeticDatum">http://rdf.geospecies.org/ont/geospecies#hasGeodeticDatum</seealso>
    let hasGeodeticDatum = Prefixed_Name(geospecies, "hasGeodeticDatum") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasHumanCollector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasHumanCollector"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasHumanCollector">http://rdf.geospecies.org/ont/geospecies#hasHumanCollector</seealso>
    let hasHumanCollector =
        Prefixed_Name(geospecies, "hasHumanCollector") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasHumanCollectorName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasHumanCollector"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasHumanCollectorName">http://rdf.geospecies.org/ont/geospecies#hasHumanCollectorName</seealso>
    let hasHumanCollectorName =
        Prefixed_Name(geospecies, "hasHumanCollectorName") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasHumanIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasHumanIdentifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasHumanIdentifier">http://rdf.geospecies.org/ont/geospecies#hasHumanIdentifier</seealso>
    let hasHumanIdentifier =
        Prefixed_Name(geospecies, "hasHumanIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasHumanIdentifierName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasHumanIdentifierName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasHumanIdentifierName">http://rdf.geospecies.org/ont/geospecies#hasHumanIdentifierName</seealso>
    let hasHumanIdentifierName =
        Prefixed_Name(geospecies, "hasHumanIdentifierName") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasITIS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasITIS"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasITIS">http://rdf.geospecies.org/ont/geospecies#hasITIS</seealso>
    let hasITIS = Prefixed_Name(geospecies, "hasITIS") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasITISPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasITISPage"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasITISPage">http://rdf.geospecies.org/ont/geospecies#hasITISPage</seealso>
    let hasITISPage = Prefixed_Name(geospecies, "hasITISPage") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasInfraspecificEpithet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasInfraspecificEpithet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasInfraspecificEpithet">http://rdf.geospecies.org/ont/geospecies#hasInfraspecificEpithet</seealso>
    let hasInfraspecificEpithet =
        Prefixed_Name(geospecies, "hasInfraspecificEpithet") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasKingdomName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasKingdomName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasKingdomName">http://rdf.geospecies.org/ont/geospecies#hasKingdomName</seealso>
    let hasKingdomName = Prefixed_Name(geospecies, "hasKingdomName") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasLocality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasLocality"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasLocality">http://rdf.geospecies.org/ont/geospecies#hasLocality</seealso>
    let hasLocality = Prefixed_Name(geospecies, "hasLocality") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasLocalityName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasLocalityName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasLocalityName">http://rdf.geospecies.org/ont/geospecies#hasLocalityName</seealso>
    let hasLocalityName = Prefixed_Name(geospecies, "hasLocalityName") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasLocalityText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasLocalityText"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasLocalityText">http://rdf.geospecies.org/ont/geospecies#hasLocalityText</seealso>
    let hasLocalityText = Prefixed_Name(geospecies, "hasLocalityText") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasLocation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasLocation">http://rdf.geospecies.org/ont/geospecies#hasLocation</seealso>
    let hasLocation = Prefixed_Name(geospecies, "hasLocation") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasLocationName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasLocationName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasLocationName">http://rdf.geospecies.org/ont/geospecies#hasLocationName</seealso>
    let hasLocationName = Prefixed_Name(geospecies, "hasLocationName") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasLocationText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasLocationName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasLocationText">http://rdf.geospecies.org/ont/geospecies#hasLocationText</seealso>
    let hasLocationText = Prefixed_Name(geospecies, "hasLocationText") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasLowExpectationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasLowExpectationOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasLowExpectationOf">http://rdf.geospecies.org/ont/geospecies#hasLowExpectationOf</seealso>
    let hasLowExpectationOf =
        Prefixed_Name(geospecies, "hasLowExpectationOf") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasLowUSDA_ExpectationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasLowUSDA_ExpectationOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasLowUSDA_ExpectationOf">http://rdf.geospecies.org/ont/geospecies#hasLowUSDA_ExpectationOf</seealso>
    let hasLowUSDA_ExpectationOf =
        Prefixed_Name(geospecies, "hasLowUSDA_ExpectationOf") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasNCBITaxonID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasNCBITaxonID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasNCBITaxonID">http://rdf.geospecies.org/ont/geospecies#hasNCBITaxonID</seealso>
    let hasNCBITaxonID = Prefixed_Name(geospecies, "hasNCBITaxonID") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasNoUSDA_ExpectationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasNoUSDA_ExpectationOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasNoUSDA_ExpectationOf">http://rdf.geospecies.org/ont/geospecies#hasNoUSDA_ExpectationOf</seealso>
    let hasNoUSDA_ExpectationOf =
        Prefixed_Name(geospecies, "hasNoUSDA_ExpectationOf") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasNomenclaturalCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasNomenclaturalCode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasNomenclaturalCode">http://rdf.geospecies.org/ont/geospecies#hasNomenclaturalCode</seealso>
    let hasNomenclaturalCode =
        Prefixed_Name(geospecies, "hasNomenclaturalCode") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasNomenclaturalCodeString</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasNomenclaturalCodeString"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasNomenclaturalCodeString">http://rdf.geospecies.org/ont/geospecies#hasNomenclaturalCodeString</seealso>
    let hasNomenclaturalCodeString =
        Prefixed_Name(geospecies, "hasNomenclaturalCodeString") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasObservation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasObservation">http://rdf.geospecies.org/ont/geospecies#hasObservation</seealso>
    let hasObservation = Prefixed_Name(geospecies, "hasObservation") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasObservationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasObservationMethod"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasObservationMethod">http://rdf.geospecies.org/ont/geospecies#hasObservationMethod</seealso>
    let hasObservationMethod =
        Prefixed_Name(geospecies, "hasObservationMethod") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasObservationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasObservationOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasObservationOf">http://rdf.geospecies.org/ont/geospecies#hasObservationOf</seealso>
    let hasObservationOf = Prefixed_Name(geospecies, "hasObservationOf") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasOccurrenceStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasOccurrenceStatus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasOccurrenceStatus">http://rdf.geospecies.org/ont/geospecies#hasOccurrenceStatus</seealso>
    let hasOccurrenceStatus =
        Prefixed_Name(geospecies, "hasOccurrenceStatus") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasOmernik_3_Ecozone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasOmernik_3_Ecozone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasOmernik_3_Ecozone">http://rdf.geospecies.org/ont/geospecies#hasOmernik_3_Ecozone</seealso>
    let hasOmernik_3_Ecozone =
        Prefixed_Name(geospecies, "hasOmernik_3_Ecozone") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasOmernik_4_Ecozone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasOmernik_4_Ecozone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasOmernik_4_Ecozone">http://rdf.geospecies.org/ont/geospecies#hasOmernik_4_Ecozone</seealso>
    let hasOmernik_4_Ecozone =
        Prefixed_Name(geospecies, "hasOmernik_4_Ecozone") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasOrderName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasOrderName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasOrderName">http://rdf.geospecies.org/ont/geospecies#hasOrderName</seealso>
    let hasOrderName = Prefixed_Name(geospecies, "hasOrderName") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasPhylumName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasPhylumName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasPhylumName">http://rdf.geospecies.org/ont/geospecies#hasPhylumName</seealso>
    let hasPhylumName = Prefixed_Name(geospecies, "hasPhylumName") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasProject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasProject"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasProject">http://rdf.geospecies.org/ont/geospecies#hasProject</seealso>
    let hasProject = Prefixed_Name(geospecies, "hasProject") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasScientificName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasScientificName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasScientificName">http://rdf.geospecies.org/ont/geospecies#hasScientificName</seealso>
    let hasScientificName =
        Prefixed_Name(geospecies, "hasScientificName") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasScientificNameAuthorship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasScientificNameAuthorship"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasScientificNameAuthorship">http://rdf.geospecies.org/ont/geospecies#hasScientificNameAuthorship</seealso>
    let hasScientificNameAuthorship =
        Prefixed_Name(geospecies, "hasScientificNameAuthorship") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasScientificNameRank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasScientificNameRank"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasScientificNameRank">http://rdf.geospecies.org/ont/geospecies#hasScientificNameRank</seealso>
    let hasScientificNameRank =
        Prefixed_Name(geospecies, "hasScientificNameRank") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasSex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasSex"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasSex">http://rdf.geospecies.org/ont/geospecies#hasSex</seealso>
    let hasSex = Prefixed_Name(geospecies, "hasSex") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasSpecies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasSpecies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasSpecies">http://rdf.geospecies.org/ont/geospecies#hasSpecies</seealso>
    let hasSpecies = Prefixed_Name(geospecies, "hasSpecies") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasSpecificEpithet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasSpecificEpithet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasSpecificEpithet">http://rdf.geospecies.org/ont/geospecies#hasSpecificEpithet</seealso>
    let hasSpecificEpithet =
        Prefixed_Name(geospecies, "hasSpecificEpithet") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasStartDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasStartDate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasStartDate">http://rdf.geospecies.org/ont/geospecies#hasStartDate</seealso>
    let hasStartDate = Prefixed_Name(geospecies, "hasStartDate") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasStartDayOfYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasStartDayOfYear"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasStartDayOfYear">http://rdf.geospecies.org/ont/geospecies#hasStartDayOfYear</seealso>
    let hasStartDayOfYear =
        Prefixed_Name(geospecies, "hasStartDayOfYear") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasStateProvName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasStateProvName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasStateProvName">http://rdf.geospecies.org/ont/geospecies#hasStateProvName</seealso>
    let hasStateProvName = Prefixed_Name(geospecies, "hasStateProvName") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasStateProvince</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasStateProv"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasStateProvince">http://rdf.geospecies.org/ont/geospecies#hasStateProvince</seealso>
    let hasStateProvince = Prefixed_Name(geospecies, "hasStateProvince") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasStateProvinceName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasStateProvinceName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasStateProvinceName">http://rdf.geospecies.org/ont/geospecies#hasStateProvinceName</seealso>
    let hasStateProvinceName =
        Prefixed_Name(geospecies, "hasStateProvinceName") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasSubfamilyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasSubfamilyName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasSubfamilyName">http://rdf.geospecies.org/ont/geospecies#hasSubfamilyName</seealso>
    let hasSubfamilyName = Prefixed_Name(geospecies, "hasSubfamilyName") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasSubgenusName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasSubgenusName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasSubgenusName">http://rdf.geospecies.org/ont/geospecies#hasSubgenusName</seealso>
    let hasSubgenusName = Prefixed_Name(geospecies, "hasSubgenusName") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasTDWG_Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasTDWG_Concept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasTDWG_Concept">http://rdf.geospecies.org/ont/geospecies#hasTDWG_Concept</seealso>
    let hasTDWG_Concept = Prefixed_Name(geospecies, "hasTDWG_Concept") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasTaxonConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasTaxonConcept"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasTaxonConcept">http://rdf.geospecies.org/ont/geospecies#hasTaxonConcept</seealso>
    let hasTaxonConcept = Prefixed_Name(geospecies, "hasTaxonConcept") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasTaxonomicStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasTaxonomicStatus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasTaxonomicStatus">http://rdf.geospecies.org/ont/geospecies#hasTaxonomicStatus</seealso>
    let hasTaxonomicStatus =
        Prefixed_Name(geospecies, "hasTaxonomicStatus") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasTreeBaseID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasTreeBaseID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasTreeBaseID">http://rdf.geospecies.org/ont/geospecies#hasTreeBaseID</seealso>
    let hasTreeBaseID = Prefixed_Name(geospecies, "hasTreeBaseID") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasTypeStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasTypeStatus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasTypeStatus">http://rdf.geospecies.org/ont/geospecies#hasTypeStatus</seealso>
    let hasTypeStatus = Prefixed_Name(geospecies, "hasTypeStatus") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasUSDA_ExpectationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasUSDA_ExpectationOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasUSDA_ExpectationOf">http://rdf.geospecies.org/ont/geospecies#hasUSDA_ExpectationOf</seealso>
    let hasUSDA_ExpectationOf =
        Prefixed_Name(geospecies, "hasUSDA_ExpectationOf") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasUUID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasUUID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasUUID">http://rdf.geospecies.org/ont/geospecies#hasUUID</seealso>
    let hasUUID = Prefixed_Name(geospecies, "hasUUID") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:hasUbio_LSID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasUbio_LSID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasUbio_LSID">http://rdf.geospecies.org/ont/geospecies#hasUbio_LSID</seealso>
    let hasUbio_LSID = Prefixed_Name(geospecies, "hasUbio_LSID") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasUnknownExpectationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasUnknownExpectationOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasUnknownExpectationOf">http://rdf.geospecies.org/ont/geospecies#hasUnknownExpectationOf</seealso>
    let hasUnknownExpectationOf =
        Prefixed_Name(geospecies, "hasUnknownExpectationOf") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasVernacularName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"hasVernacularName"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasVernacularName">http://rdf.geospecies.org/ont/geospecies#hasVernacularName</seealso>
    let hasVernacularName =
        Prefixed_Name(geospecies, "hasVernacularName") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasWI_Herbarium_Habitat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasWI_Herbarium_Habitat"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasWI_Herbarium_Habitat">http://rdf.geospecies.org/ont/geospecies#hasWI_Herbarium_Habitat</seealso>
    let hasWI_Herbarium_Habitat =
        Prefixed_Name(geospecies, "hasWI_Herbarium_Habitat") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasWikipediaArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasWikipediaArticle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasWikipediaArticle">http://rdf.geospecies.org/ont/geospecies#hasWikipediaArticle</seealso>
    let hasWikipediaArticle =
        Prefixed_Name(geospecies, "hasWikipediaArticle") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasWikispeciesArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasWikispeciesArticle"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasWikispeciesArticle">http://rdf.geospecies.org/ont/geospecies#hasWikispeciesArticle</seealso>
    let hasWikispeciesArticle =
        Prefixed_Name(geospecies, "hasWikispeciesArticle") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasWisconsinHerbariumHabitatAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasWisconsinHerbariumHabitatAssociation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasWisconsinHerbariumHabitatAssociation">http://rdf.geospecies.org/ont/geospecies#hasWisconsinHerbariumHabitatAssociation</seealso>
    let hasWisconsinHerbariumHabitatAssociation =
        Prefixed_Name(geospecies, "hasWisconsinHerbariumHabitatAssociation") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasWisconsinHerbariumHabitatPreference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasWisconsinHerbariumHabitatPreference"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasWisconsinHerbariumHabitatPreference">http://rdf.geospecies.org/ont/geospecies#hasWisconsinHerbariumHabitatPreference</seealso>
    let hasWisconsinHerbariumHabitatPreference =
        Prefixed_Name(geospecies, "hasWisconsinHerbariumHabitatPreference") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:hasWisconsinHerbariumSpeciesAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasWisconsinHerbariumSpeciesAssociation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#hasWisconsinHerbariumSpeciesAssociation">http://rdf.geospecies.org/ont/geospecies#hasWisconsinHerbariumSpeciesAssociation</seealso>
    let hasWisconsinHerbariumSpeciesAssociation =
        Prefixed_Name(geospecies, "hasWisconsinHerbariumSpeciesAssociation") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:has_USDA_Growth_Habit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has_USDA_Growth_Habit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#has_USDA_Growth_Habit">http://rdf.geospecies.org/ont/geospecies#has_USDA_Growth_Habit</seealso>
    let has_USDA_Growth_Habit =
        Prefixed_Name(geospecies, "has_USDA_Growth_Habit") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:has_USDA_Native_Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has_USDA_Native_Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#has_USDA_Native_Status">http://rdf.geospecies.org/ont/geospecies#has_USDA_Native_Status</seealso>
    let has_USDA_Native_Status =
        Prefixed_Name(geospecies, "has_USDA_Native_Status") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:inClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"inClass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#inClass">http://rdf.geospecies.org/ont/geospecies#inClass</seealso>
    let inClass = Prefixed_Name(geospecies, "inClass") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:inFamily</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"inFamily"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#inFamily">http://rdf.geospecies.org/ont/geospecies#inFamily</seealso>
    let inFamily = Prefixed_Name(geospecies, "inFamily") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:inKingdom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"inKingdom"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#inKingdom">http://rdf.geospecies.org/ont/geospecies#inKingdom</seealso>
    let inKingdom = Prefixed_Name(geospecies, "inKingdom") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:inOrder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"inOrder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#inOrder">http://rdf.geospecies.org/ont/geospecies#inOrder</seealso>
    let inOrder = Prefixed_Name(geospecies, "inOrder") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:inPhylum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"inPhylum"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#inPhylum">http://rdf.geospecies.org/ont/geospecies#inPhylum</seealso>
    let inPhylum = Prefixed_Name(geospecies, "inPhylum") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:isBugGuidePageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isBugGuidePageOf"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#isBugGuidePageOf">http://rdf.geospecies.org/ont/geospecies#isBugGuidePageOf</seealso>
    let isBugGuidePageOf = Prefixed_Name(geospecies, "isBugGuidePageOf") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:isExpectedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isExpectedIn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#isExpectedIn">http://rdf.geospecies.org/ont/geospecies#isExpectedIn</seealso>
    let isExpectedIn = Prefixed_Name(geospecies, "isExpectedIn") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:isNotUSDA_ExpectedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isNotUSDA_ExpectedIn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#isNotUSDA_ExpectedIn">http://rdf.geospecies.org/ont/geospecies#isNotUSDA_ExpectedIn</seealso>
    let isNotUSDA_ExpectedIn =
        Prefixed_Name(geospecies, "isNotUSDA_ExpectedIn") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:isUSDA_ExpectedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isUSDA_ExpectedIn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#isUSDA_ExpectedIn">http://rdf.geospecies.org/ont/geospecies#isUSDA_ExpectedIn</seealso>
    let isUSDA_ExpectedIn =
        Prefixed_Name(geospecies, "isUSDA_ExpectedIn") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:isUSDA_UnexpectedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isUSDA_UnexpectedIn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#isUSDA_UnexpectedIn">http://rdf.geospecies.org/ont/geospecies#isUSDA_UnexpectedIn</seealso>
    let isUSDA_UnexpectedIn =
        Prefixed_Name(geospecies, "isUSDA_UnexpectedIn") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:isUnexpectedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isUnexpectedIn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#isUnexpectedIn">http://rdf.geospecies.org/ont/geospecies#isUnexpectedIn</seealso>
    let isUnexpectedIn = Prefixed_Name(geospecies, "isUnexpectedIn") |> PrefixedName
    /// <summary>
    ///   <para>geospecies:isUnknownAboutIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"isUnknownIn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#isUnknownAboutIn">http://rdf.geospecies.org/ont/geospecies#isUnknownAboutIn</seealso>
    let isUnknownAboutIn = Prefixed_Name(geospecies, "isUnknownAboutIn") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:nativeness_introduced</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Nativeness</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Introduced"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#nativeness_introduced">http://rdf.geospecies.org/ont/geospecies#nativeness_introduced</seealso>
    let nativeness_introduced =
        Prefixed_Name(geospecies, "nativeness_introduced") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:nativeness_invasive</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Nativeness</para>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///
    /// labels<para>"Invasive"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#nativeness_invasive">http://rdf.geospecies.org/ont/geospecies#nativeness_invasive</seealso>
    let nativeness_invasive =
        Prefixed_Name(geospecies, "nativeness_invasive") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:nativeness_managed</para>
    /// </summary>
    /// <remarks>
    ///   <para>geospecies:Nativeness</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Thing</para>
    ///
    /// labels<para>"Managed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#nativeness_managed">http://rdf.geospecies.org/ont/geospecies#nativeness_managed</seealso>
    let nativeness_managed =
        Prefixed_Name(geospecies, "nativeness_managed") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:nativeness_native</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:Nativeness</para>
    ///
    /// labels<para>"Native"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#nativeness_native">http://rdf.geospecies.org/ont/geospecies#nativeness_native</seealso>
    let nativeness_native =
        Prefixed_Name(geospecies, "nativeness_native") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:nativeness_naturalised</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Thing</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>geospecies:Nativeness</para>
    ///
    /// labels<para>"Naturalised"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#nativeness_naturalised">http://rdf.geospecies.org/ont/geospecies#nativeness_naturalised</seealso>
    let nativeness_naturalised =
        Prefixed_Name(geospecies, "nativeness_naturalised") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:speciesHasHabitatAssociation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"hasHabitatAssociation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#speciesHasHabitatAssociation">http://rdf.geospecies.org/ont/geospecies#speciesHasHabitatAssociation</seealso>
    let speciesHasHabitatAssociation =
        Prefixed_Name(geospecies, "speciesHasHabitatAssociation") |> PrefixedName

    /// <summary>
    ///   <para>geospecies:wasObservedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"wasObservedIn"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://rdf.geospecies.org/ont/geospecies#wasObservedIn">http://rdf.geospecies.org/ont/geospecies#wasObservedIn</seealso>
    let wasObservedIn = Prefixed_Name(geospecies, "wasObservedIn") |> PrefixedName
