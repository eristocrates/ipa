namespace http.def.seegrid.csiro.au.isotc211.iso19115._2003.extent.hash

open DoxAletheia.Rdf_Vocabulary

module ext =
    let _namespace_name = "http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#"

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#GeographicBoundingBox"></see>
    /// </summary>
    let GeographicBoundingBox =
        Namespaced_IRI.parse _namespace_name "GeographicBoundingBox" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#westBoundLongitude"></see>
    /// </summary>
    let westBoundLongitude =
        Namespaced_IRI.parse _namespace_name "westBoundLongitude" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#VerticalExtent"></see>
    /// </summary>
    let VerticalExtent =
        Namespaced_IRI.parse _namespace_name "VerticalExtent" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#northBoundLatitude"></see>
    /// </summary>
    let northBoundLatitude =
        Namespaced_IRI.parse _namespace_name "northBoundLatitude" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#eastBoundLongitude"></see>
    /// </summary>
    let eastBoundLongitude =
        Namespaced_IRI.parse _namespace_name "eastBoundLongitude" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#TemporalExtent"></see>
    /// </summary>
    let TemporalExtent =
        Namespaced_IRI.parse _namespace_name "TemporalExtent" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#GeographicDescription"></see>
    /// </summary>
    let GeographicDescription =
        Namespaced_IRI.parse _namespace_name "GeographicDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#description"></see>
    /// </summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#extent"></see>
    /// </summary>
    let extent = Namespaced_IRI.parse _namespace_name "extent" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#GeographicExtent"></see>
    /// </summary>
    let GeographicExtent =
        Namespaced_IRI.parse _namespace_name "GeographicExtent" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#minumumValue"></see>
    /// </summary>
    let minumumValue =
        Namespaced_IRI.parse _namespace_name "minumumValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#geographicIdentifier"></see>
    /// </summary>
    let geographicIdentifier =
        Namespaced_IRI.parse _namespace_name "geographicIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#extentTypeCode"></see>
    /// </summary>
    let extentTypeCode =
        Namespaced_IRI.parse _namespace_name "extentTypeCode" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#SpatialTemporalExtent"></see>
    /// </summary>
    let SpatialTemporalExtent =
        Namespaced_IRI.parse _namespace_name "SpatialTemporalExtent" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#spatialExtent"></see>
    /// </summary>
    let spatialExtent =
        Namespaced_IRI.parse _namespace_name "spatialExtent" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#temporalElement"></see>
    /// </summary>
    let temporalElement =
        Namespaced_IRI.parse _namespace_name "temporalElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#BoundingPolygon"></see>
    /// </summary>
    let BoundingPolygon =
        Namespaced_IRI.parse _namespace_name "BoundingPolygon" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#verticalCRS"></see>
    /// </summary>
    let verticalCRS =
        Namespaced_IRI.parse _namespace_name "verticalCRS" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#geographicElement"></see>
    /// </summary>
    let geographicElement =
        Namespaced_IRI.parse _namespace_name "geographicElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#southBoundLatitude"></see>
    /// </summary>
    let southBoundLatitude =
        Namespaced_IRI.parse _namespace_name "southBoundLatitude" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#maximumValue"></see>
    /// </summary>
    let maximumValue =
        Namespaced_IRI.parse _namespace_name "maximumValue" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#polygon"></see>
    /// </summary>
    let polygon = Namespaced_IRI.parse _namespace_name "polygon" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#verticalElement"></see>
    /// </summary>
    let verticalElement =
        Namespaced_IRI.parse _namespace_name "verticalElement" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#Extent"></see>
    /// </summary>
    let Extent = Namespaced_IRI.parse _namespace_name "Extent" |> NamespacedName
