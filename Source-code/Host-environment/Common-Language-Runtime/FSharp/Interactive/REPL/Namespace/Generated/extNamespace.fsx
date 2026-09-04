#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ext =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#" "ext"

    /// <summary>
    ///   <para>skos:notation : EX_BoundingPolygon^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Bounding polygon^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#BoundingPolygon">ext:BoundingPolygon</a>
    /// </summary>
    let BoundingPolygon = _prefixId.prefix "BoundingPolygon"
    /// <summary>
    ///   <para>skos:notation : EX_Extent^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Extent^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#Extent">ext:Extent</a>
    /// </summary>
    let Extent = _prefixId.prefix "Extent"
    /// <summary>
    ///   <para>skos:notation : EX_GeographicBoundingBox^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Geographic bounding box^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#GeographicBoundingBox">ext:GeographicBoundingBox</a>
    /// </summary>
    let GeographicBoundingBox = _prefixId.prefix "GeographicBoundingBox"
    /// <summary>
    ///   <para>skos:notation : EX_GeographicDescription^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Geographic description</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#GeographicDescription">ext:GeographicDescription</a>
    /// </summary>
    let GeographicDescription = _prefixId.prefix "GeographicDescription"
    /// <summary>
    ///   <para>skos:notation : EX_GeographicExtent^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Geographic extent^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#GeographicExtent">ext:GeographicExtent</a>
    /// </summary>
    let GeographicExtent = _prefixId.prefix "GeographicExtent"
    /// <summary>
    ///   <para>skos:notation : EX_SpatialTemporalExtent^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Spatial and temporal extent^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#SpatialTemporalExtent">ext:SpatialTemporalExtent</a>
    /// </summary>
    let SpatialTemporalExtent = _prefixId.prefix "SpatialTemporalExtent"
    /// <summary>
    ///   <para>skos:notation : EX_TemporalExtent^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Temporal extent^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#TemporalExtent">ext:TemporalExtent</a>
    /// </summary>
    let TemporalExtent = _prefixId.prefix "TemporalExtent"
    /// <summary>
    ///   <para>skos:notation : EX_VerticalExtent^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Vertical extent^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#VerticalExtent">ext:VerticalExtent</a>
    /// </summary>
    let VerticalExtent = _prefixId.prefix "VerticalExtent"
    /// <summary>
    ///   <para>rdfs:label : description^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#description">ext:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : east bound longitude^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#eastBoundLongitude">ext:eastBoundLongitude</a>
    /// </summary>
    let eastBoundLongitude = _prefixId.prefix "eastBoundLongitude"
    /// <summary>
    ///   <para>rdfs:label : extent^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#extent">ext:extent</a>
    /// </summary>
    let extent = _prefixId.prefix "extent"
    /// <summary>
    ///   <para>rdfs:label : extent type code^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#extentTypeCode">ext:extentTypeCode</a>
    /// </summary>
    let extentTypeCode = _prefixId.prefix "extentTypeCode"
    /// <summary>
    ///   <para>rdfs:label : geographic element^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#geographicElement">ext:geographicElement</a>
    /// </summary>
    let geographicElement = _prefixId.prefix "geographicElement"
    /// <summary>
    ///   <para>rdfs:label : geographic identifier^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#geographicIdentifier">ext:geographicIdentifier</a>
    /// </summary>
    let geographicIdentifier = _prefixId.prefix "geographicIdentifier"
    /// <summary>
    ///   <para>rdfs:label : maximum value^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#maximumValue">ext:maximumValue</a>
    /// </summary>
    let maximumValue = _prefixId.prefix "maximumValue"
    /// <summary>
    ///   <para>rdfs:label : minumu value^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#minumumValue">ext:minumumValue</a>
    /// </summary>
    let minumumValue = _prefixId.prefix "minumumValue"
    /// <summary>
    ///   <para>rdfs:label : north bound latitude^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#northBoundLatitude">ext:northBoundLatitude</a>
    /// </summary>
    let northBoundLatitude = _prefixId.prefix "northBoundLatitude"
    /// <summary>
    ///   <para>rdfs:label : polygon^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#polygon">ext:polygon</a>
    /// </summary>
    let polygon = _prefixId.prefix "polygon"
    /// <summary>
    ///   <para>rdfs:label : south bound latitude^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#southBoundLatitude">ext:southBoundLatitude</a>
    /// </summary>
    let southBoundLatitude = _prefixId.prefix "southBoundLatitude"
    /// <summary>
    ///   <para>rdfs:label : spatial extent^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#spatialExtent">ext:spatialExtent</a>
    /// </summary>
    let spatialExtent = _prefixId.prefix "spatialExtent"
    /// <summary>
    ///   <para>rdfs:label : temporal element^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#temporalElement">ext:temporalElement</a>
    /// </summary>
    let temporalElement = _prefixId.prefix "temporalElement"
    /// <summary>
    ///   <para>rdfs:label : vertical CRS^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#verticalCRS">ext:verticalCRS</a>
    /// </summary>
    let verticalCRS = _prefixId.prefix "verticalCRS"
    /// <summary>
    ///   <para>rdfs:label : vertical element^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#verticalElement">ext:verticalElement</a>
    /// </summary>
    let verticalElement = _prefixId.prefix "verticalElement"
    /// <summary>
    ///   <para>rdfs:label : west bound longitude^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#westBoundLongitude">ext:westBoundLongitude</a>
    /// </summary>
    let westBoundLongitude = _prefixId.prefix "westBoundLongitude"
