namespace http.imgpedia.dcc.uchile.cl.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module imo =
    let _namespace_iri = Namespace_Iri imo |> NamespaceIRI
    /// <summary>
    ///   <para>imo:CLD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Descriptor de la Distribución del Color</para><para>Color Layout Descriptor</para></remarks>
    /// <seealso href="http://imgpedia.dcc.uchile.cl/ontology#CLD">http://imgpedia.dcc.uchile.cl/ontology#CLD</seealso>
    let CLD = Prefixed_Name(imo, "CLD") |> PrefixedName
    /// <summary>
    ///   <para>imo:Descriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Descriptor</para><para>Descriptor</para></remarks>
    /// <seealso href="http://imgpedia.dcc.uchile.cl/ontology#Descriptor">http://imgpedia.dcc.uchile.cl/ontology#Descriptor</seealso>
    let Descriptor = Prefixed_Name(imo, "Descriptor") |> PrefixedName
    /// <summary>
    ///   <para>imo:HOG</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Histograma de Orientación del Gradiente</para><para>Histogram of Oriented Gradient</para></remarks>
    /// <seealso href="http://imgpedia.dcc.uchile.cl/ontology#HOG">http://imgpedia.dcc.uchile.cl/ontology#HOG</seealso>
    let HOG = Prefixed_Name(imo, "HOG") |> PrefixedName
    /// <summary>
    ///   <para>imo:appearsIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Tha image appears in the resource</para><para>La imagen aparece en el recurso</para></remarks>
    /// <seealso href="http://imgpedia.dcc.uchile.cl/ontology#appearsIn">http://imgpedia.dcc.uchile.cl/ontology#appearsIn</seealso>
    let appearsIn = Prefixed_Name(imo, "appearsIn") |> PrefixedName
    /// <summary>
    ///   <para>imo:GHD</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Gray Histogram Descriptor</para><para>Histograma de Grises</para></remarks>
    /// <seealso href="http://imgpedia.dcc.uchile.cl/ontology#GHD">http://imgpedia.dcc.uchile.cl/ontology#GHD</seealso>
    let GHD = Prefixed_Name(imo, "GHD") |> PrefixedName
    /// <summary>
    ///   <para>imo:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Imagen</para><para>Image</para></remarks>
    /// <seealso href="http://imgpedia.dcc.uchile.cl/ontology#Image">http://imgpedia.dcc.uchile.cl/ontology#Image</seealso>
    let Image = Prefixed_Name(imo, "Image") |> PrefixedName
    /// <summary>
    ///   <para>imo:ImageRelation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Relación entre Imágenes</para><para>Image Relation</para></remarks>
    /// <seealso href="http://imgpedia.dcc.uchile.cl/ontology#ImageRelation">http://imgpedia.dcc.uchile.cl/ontology#ImageRelation</seealso>
    let ImageRelation = Prefixed_Name(imo, "ImageRelation") |> PrefixedName
    /// <summary>
    ///   <para>imo:describes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Descriptor de una imagen</para><para>Describes an image</para></remarks>
    /// <seealso href="http://imgpedia.dcc.uchile.cl/ontology#describes">http://imgpedia.dcc.uchile.cl/ontology#describes</seealso>
    let describes = Prefixed_Name(imo, "describes") |> PrefixedName
    /// <summary>
    ///   <para>imo:distance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>The distance between the images in the relation</para><para>La distancia entre las imágenes de la relación</para></remarks>
    /// <seealso href="http://imgpedia.dcc.uchile.cl/ontology#distance">http://imgpedia.dcc.uchile.cl/ontology#distance</seealso>
    let distance = Prefixed_Name(imo, "distance") |> PrefixedName
    /// <summary>
    ///   <para>imo:fileURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>The URL of the image in Wikimedia Commons</para><para>La URL de la imagen en Wikimedia Commons</para></remarks>
    /// <seealso href="http://imgpedia.dcc.uchile.cl/ontology#fileURL">http://imgpedia.dcc.uchile.cl/ontology#fileURL</seealso>
    let fileURL = Prefixed_Name(imo, "fileURL") |> PrefixedName
    /// <summary>
    ///   <para>imo:targetImg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>El objeto de la relación entre imágenes</para><para>The target of an image relation</para></remarks>
    /// <seealso href="http://imgpedia.dcc.uchile.cl/ontology#targetImg">http://imgpedia.dcc.uchile.cl/ontology#targetImg</seealso>
    let targetImg = Prefixed_Name(imo, "targetImg") |> PrefixedName
    /// <summary>
    ///   <para>imo:usesDescriptor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>The descriptor used in the relation</para><para>El descriptor usado en la relación</para></remarks>
    /// <seealso href="http://imgpedia.dcc.uchile.cl/ontology#usesDescriptor">http://imgpedia.dcc.uchile.cl/ontology#usesDescriptor</seealso>
    let usesDescriptor = Prefixed_Name(imo, "usesDescriptor") |> PrefixedName
    /// <summary>
    ///   <para>imo:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Ancho de la imagen en unidades de pixel</para><para>Image width in pixels</para></remarks>
    /// <seealso href="http://imgpedia.dcc.uchile.cl/ontology#width">http://imgpedia.dcc.uchile.cl/ontology#width</seealso>
    let width = Prefixed_Name(imo, "width") |> PrefixedName
    /// <summary>
    ///   <para>imo:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Altura de la imagen en unidades de pixel</para><para>Image height in pixels</para></remarks>
    /// <seealso href="http://imgpedia.dcc.uchile.cl/ontology#height">http://imgpedia.dcc.uchile.cl/ontology#height</seealso>
    let height = Prefixed_Name(imo, "height") |> PrefixedName
    /// <summary>
    ///   <para>imo:similar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>Una imagen similar</para><para>A similar image</para></remarks>
    /// <seealso href="http://imgpedia.dcc.uchile.cl/ontology#similar">http://imgpedia.dcc.uchile.cl/ontology#similar</seealso>
    let similar = Prefixed_Name(imo, "similar") |> PrefixedName
    /// <summary>
    ///   <para>imo:sourceImg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>El sujeto de la relación entre imágenes</para><para>The source of an image relation</para></remarks>
    /// <seealso href="http://imgpedia.dcc.uchile.cl/ontology#sourceImg">http://imgpedia.dcc.uchile.cl/ontology#sourceImg</seealso>
    let sourceImg = Prefixed_Name(imo, "sourceImg") |> PrefixedName
    /// <summary>
    ///   <para>imo:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Valor del descriptor</para><para>Descriptor value</para></remarks>
    /// <seealso href="http://imgpedia.dcc.uchile.cl/ontology#value">http://imgpedia.dcc.uchile.cl/ontology#value</seealso>
    let value = Prefixed_Name(imo, "value") |> PrefixedName
