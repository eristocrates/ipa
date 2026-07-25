namespace http.def.seegrid.csiro.au.isotc211.iso19115._2003.extent.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ext =
    let _namespace_iri = Namespace_Iri ext |> NamespaceIRI
    /// <summary>
    ///   <para>ext:VerticalExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Vertical extent</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#VerticalExtent">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#VerticalExtent</seealso>
    let VerticalExtent = Prefixed_Name(ext, "VerticalExtent") |> PrefixedName
    /// <summary>
    ///   <para>ext:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>description</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#description">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#description</seealso>
    let description = Prefixed_Name(ext, "description") |> PrefixedName

    /// <summary>
    ///   <para>ext:SpatialTemporalExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Spatial and temporal extent</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#SpatialTemporalExtent">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#SpatialTemporalExtent</seealso>
    let SpatialTemporalExtent =
        Prefixed_Name(ext, "SpatialTemporalExtent") |> PrefixedName

    /// <summary>
    ///   <para>ext:GeographicBoundingBox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Geographic bounding box</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#GeographicBoundingBox">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#GeographicBoundingBox</seealso>
    let GeographicBoundingBox =
        Prefixed_Name(ext, "GeographicBoundingBox") |> PrefixedName

    /// <summary>
    ///   <para>ext:eastBoundLongitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>east bound longitude</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#eastBoundLongitude">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#eastBoundLongitude</seealso>
    let eastBoundLongitude = Prefixed_Name(ext, "eastBoundLongitude") |> PrefixedName
    /// <summary>
    ///   <para>ext:extent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>extent</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#extent">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#extent</seealso>
    let extent = Prefixed_Name(ext, "extent") |> PrefixedName

    /// <summary>
    ///   <para>ext:geographicIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>geographic identifier</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#geographicIdentifier">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#geographicIdentifier</seealso>
    let geographicIdentifier =
        Prefixed_Name(ext, "geographicIdentifier") |> PrefixedName

    /// <summary>
    ///   <para>ext:extentTypeCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>extent type code</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#extentTypeCode">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#extentTypeCode</seealso>
    let extentTypeCode = Prefixed_Name(ext, "extentTypeCode") |> PrefixedName
    /// <summary>
    ///   <para>ext:BoundingPolygon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bounding polygon</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#BoundingPolygon">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#BoundingPolygon</seealso>
    let BoundingPolygon = Prefixed_Name(ext, "BoundingPolygon") |> PrefixedName
    /// <summary>
    ///   <para>ext:verticalCRS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>vertical CRS</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#verticalCRS">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#verticalCRS</seealso>
    let verticalCRS = Prefixed_Name(ext, "verticalCRS") |> PrefixedName
    /// <summary>
    ///   <para>ext:polygon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>polygon</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#polygon">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#polygon</seealso>
    let polygon = Prefixed_Name(ext, "polygon") |> PrefixedName
    /// <summary>
    ///   <para>ext:verticalElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>vertical element</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#verticalElement">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#verticalElement</seealso>
    let verticalElement = Prefixed_Name(ext, "verticalElement") |> PrefixedName
    /// <summary>
    ///   <para>ext:westBoundLongitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>west bound longitude</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#westBoundLongitude">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#westBoundLongitude</seealso>
    let westBoundLongitude = Prefixed_Name(ext, "westBoundLongitude") |> PrefixedName
    /// <summary>
    ///   <para>ext:TemporalExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Temporal extent</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#TemporalExtent">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#TemporalExtent</seealso>
    let TemporalExtent = Prefixed_Name(ext, "TemporalExtent") |> PrefixedName
    /// <summary>
    ///   <para>ext:northBoundLatitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>north bound latitude</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#northBoundLatitude">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#northBoundLatitude</seealso>
    let northBoundLatitude = Prefixed_Name(ext, "northBoundLatitude") |> PrefixedName
    /// <summary>
    ///   <para>ext:GeographicExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Geographic extent</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#GeographicExtent">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#GeographicExtent</seealso>
    let GeographicExtent = Prefixed_Name(ext, "GeographicExtent") |> PrefixedName
    /// <summary>
    ///   <para>ext:spatialExtent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>spatial extent</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#spatialExtent">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#spatialExtent</seealso>
    let spatialExtent = Prefixed_Name(ext, "spatialExtent") |> PrefixedName
    /// <summary>
    ///   <para>ext:geographicElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>geographic element</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#geographicElement">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#geographicElement</seealso>
    let geographicElement = Prefixed_Name(ext, "geographicElement") |> PrefixedName
    /// <summary>
    ///   <para>ext:Extent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Extent</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#Extent">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#Extent</seealso>
    let Extent = Prefixed_Name(ext, "Extent") |> PrefixedName
    /// <summary>
    ///   <para>ext:minumumValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>minumu value</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#minumumValue">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#minumumValue</seealso>
    let minumumValue = Prefixed_Name(ext, "minumumValue") |> PrefixedName
    /// <summary>
    ///   <para>ext:southBoundLatitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>south bound latitude</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#southBoundLatitude">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#southBoundLatitude</seealso>
    let southBoundLatitude = Prefixed_Name(ext, "southBoundLatitude") |> PrefixedName
    /// <summary>
    ///   <para>ext:maximumValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>maximum value</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#maximumValue">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#maximumValue</seealso>
    let maximumValue = Prefixed_Name(ext, "maximumValue") |> PrefixedName

    /// <summary>
    ///   <para>ext:GeographicDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Geographic description</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#GeographicDescription">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#GeographicDescription</seealso>
    let GeographicDescription =
        Prefixed_Name(ext, "GeographicDescription") |> PrefixedName

    /// <summary>
    ///   <para>ext:temporalElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>temporal element</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#temporalElement">http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#temporalElement</seealso>
    let temporalElement = Prefixed_Name(ext, "temporalElement") |> PrefixedName
