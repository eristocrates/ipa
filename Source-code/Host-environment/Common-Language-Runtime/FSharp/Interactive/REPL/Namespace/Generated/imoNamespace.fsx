#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module imo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://imgpedia.dcc.uchile.cl/ontology#" "imo"

    /// <summary>
    ///   <para>rdfs:label : Color Layout Descriptorrdfs:label : Descriptor de la Distribución del Color</para>
    ///   <a href="http://imgpedia.dcc.uchile.cl/ontology#CLD">imo:CLD</a>
    /// </summary>
    let CLD = _prefixId.prefix "CLD"
    /// <summary>
    ///   <para>rdfs:label : Descriptorrdfs:label : Descriptor</para>
    ///   <a href="http://imgpedia.dcc.uchile.cl/ontology#Descriptor">imo:Descriptor</a>
    /// </summary>
    let Descriptor = _prefixId.prefix "Descriptor"
    /// <summary>
    ///   <para>rdfs:label : Gray Histogram Descriptorrdfs:label : Histograma de Grises</para>
    ///   <a href="http://imgpedia.dcc.uchile.cl/ontology#GHD">imo:GHD</a>
    /// </summary>
    let GHD = _prefixId.prefix "GHD"
    /// <summary>
    ///   <para>rdfs:label : Histogram of Oriented Gradientrdfs:label : Histograma de Orientación del Gradiente</para>
    ///   <a href="http://imgpedia.dcc.uchile.cl/ontology#HOG">imo:HOG</a>
    /// </summary>
    let HOG = _prefixId.prefix "HOG"
    /// <summary>
    ///   <para>rdfs:label : Imagerdfs:label : Imagen</para>
    ///   <a href="http://imgpedia.dcc.uchile.cl/ontology#Image">imo:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>rdfs:label : Image Relationrdfs:label : Relación entre Imágenes</para>
    ///   <a href="http://imgpedia.dcc.uchile.cl/ontology#ImageRelation">imo:ImageRelation</a>
    /// </summary>
    let ImageRelation = _prefixId.prefix "ImageRelation"
    /// <summary>
    ///   <para>rdfs:label : Tha image appears in the resourcerdfs:label : La imagen aparece en el recurso</para>
    ///   <a href="http://imgpedia.dcc.uchile.cl/ontology#appearsIn">imo:appearsIn</a>
    /// </summary>
    let appearsIn = _prefixId.prefix "appearsIn"
    /// <summary>
    ///   <para>rdfs:label : Describes an imagerdfs:label : Descriptor de una imagen</para>
    ///   <a href="http://imgpedia.dcc.uchile.cl/ontology#describes">imo:describes</a>
    /// </summary>
    let describes = _prefixId.prefix "describes"
    /// <summary>
    ///   <para>rdfs:label : The distance between the images in the relationrdfs:label : La distancia entre las imágenes de la relación</para>
    ///   <a href="http://imgpedia.dcc.uchile.cl/ontology#distance">imo:distance</a>
    /// </summary>
    let distance = _prefixId.prefix "distance"
    /// <summary>
    ///   <para>rdfs:label : The URL of the image in Wikimedia Commonsrdfs:label : La URL de la imagen en Wikimedia Commons</para>
    ///   <a href="http://imgpedia.dcc.uchile.cl/ontology#fileURL">imo:fileURL</a>
    /// </summary>
    let fileURL = _prefixId.prefix "fileURL"
    /// <summary>
    ///   <para>rdfs:label : Image height in pixelsrdfs:label : Altura de la imagen en unidades de pixel</para>
    ///   <a href="http://imgpedia.dcc.uchile.cl/ontology#height">imo:height</a>
    /// </summary>
    let height = _prefixId.prefix "height"
    /// <summary>
    ///   <para>rdfs:label : A similar imagerdfs:label : Una imagen similar</para>
    ///   <a href="http://imgpedia.dcc.uchile.cl/ontology#similar">imo:similar</a>
    /// </summary>
    let similar = _prefixId.prefix "similar"
    /// <summary>
    ///   <para>rdfs:label : The source of an image relationrdfs:label : El sujeto de la relación entre imágenes</para>
    ///   <a href="http://imgpedia.dcc.uchile.cl/ontology#sourceImg">imo:sourceImg</a>
    /// </summary>
    let sourceImg = _prefixId.prefix "sourceImg"
    /// <summary>
    ///   <para>rdfs:label : The target of an image relationrdfs:label : El objeto de la relación entre imágenes</para>
    ///   <a href="http://imgpedia.dcc.uchile.cl/ontology#targetImg">imo:targetImg</a>
    /// </summary>
    let targetImg = _prefixId.prefix "targetImg"
    /// <summary>
    ///   <para>rdfs:label : The descriptor used in the relationrdfs:label : El descriptor usado en la relación</para>
    ///   <a href="http://imgpedia.dcc.uchile.cl/ontology#usesDescriptor">imo:usesDescriptor</a>
    /// </summary>
    let usesDescriptor = _prefixId.prefix "usesDescriptor"
    /// <summary>
    ///   <para>rdfs:label : Descriptor valuerdfs:label : Valor del descriptor</para>
    ///   <a href="http://imgpedia.dcc.uchile.cl/ontology#value">imo:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
    /// <summary>
    ///   <para>rdfs:label : Image width in pixelsrdfs:label : Ancho de la imagen en unidades de pixel</para>
    ///   <a href="http://imgpedia.dcc.uchile.cl/ontology#width">imo:width</a>
    /// </summary>
    let width = _prefixId.prefix "width"
