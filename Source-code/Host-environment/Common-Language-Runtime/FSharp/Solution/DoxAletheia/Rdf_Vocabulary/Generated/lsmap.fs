namespace http.ontology.cybershare.utep.edu.ELSEWeb.elseweb_data.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module lsmap =
    let _namespace_iri = Namespace_Iri lsmap |> NamespaceIRI
    /// <summary>
    ///   <para>lsmap:GeospatialDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#GeospatialDataset">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#GeospatialDataset</seealso>
    let GeospatialDataset = Prefixed_Name(lsmap, "GeospatialDataset") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:Unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Unit">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Unit</seealso>
    let Unit = Prefixed_Name(lsmap, "Unit") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:Format</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Format">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Format</seealso>
    let Format = Prefixed_Name(lsmap, "Format") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:Entity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Entity">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Entity</seealso>
    let Entity = Prefixed_Name(lsmap, "Entity") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:Provider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Provider">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Provider</seealso>
    let Provider = Prefixed_Name(lsmap, "Provider") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:GeographicRegion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#GeographicRegion">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#GeographicRegion</seealso>
    let GeographicRegion = Prefixed_Name(lsmap, "GeographicRegion") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:encodedInFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#encodedInFormat">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#encodedInFormat</seealso>
    let encodedInFormat = Prefixed_Name(lsmap, "encodedInFormat") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:Characteristic</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Characteristic">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Characteristic</seealso>
    let Characteristic = Prefixed_Name(lsmap, "Characteristic") |> PrefixedName

    /// <summary>
    ///   <para>lsmap:DatasetManifestation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#DatasetManifestation">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#DatasetManifestation</seealso>
    let DatasetManifestation =
        Prefixed_Name(lsmap, "DatasetManifestation") |> PrefixedName

    /// <summary>
    ///   <para>lsmap:Theme</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Theme">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#Theme</seealso>
    let Theme = Prefixed_Name(lsmap, "Theme") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:TimePeriod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#TimePeriod">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#TimePeriod</seealso>
    let TimePeriod = Prefixed_Name(lsmap, "TimePeriod") |> PrefixedName
    /// <summary>
    ///   <para>lsmap:hasManifestation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#hasManifestation">http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#hasManifestation</seealso>
    let hasManifestation = Prefixed_Name(lsmap, "hasManifestation") |> PrefixedName
