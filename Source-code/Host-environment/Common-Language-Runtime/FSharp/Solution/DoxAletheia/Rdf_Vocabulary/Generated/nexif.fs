namespace http.www.semanticdesktop.org.ontologies._2007._05._10.nexif.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module nexif =
    let _namespace_iri = Namespace_Iri nexif |> NamespaceIRI
    /// <summary>
    ///   <para>nexif:exposureMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 41986
    /// the exposure mode set when the image was shot. In auto-bracketing mode, the camera shoots a series of frames of the same scene at different exposure settings.</para>
    /// labels<para>exposureMode</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#exposureMode">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#exposureMode</seealso>
    let exposureMode = Prefixed_Name(nexif, "exposureMode") |> PrefixedName
    /// <summary>
    ///   <para>nexif:artist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 315
    /// Person who created the image</para>
    /// labels<para>artist</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#artist">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#artist</seealso>
    let artist = Prefixed_Name(nexif, "artist") |> PrefixedName
    /// <summary>
    ///   <para>nexif:xResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of pixels per ResolutionUnit in the ImageWidth direction. When the image resolution is unknown, 72 [dpi] is designated.
    /// tagNumber: 282</para>
    /// labels<para>xResolution</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#xResolution">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#xResolution</seealso>
    let xResolution = Prefixed_Name(nexif, "xResolution") |> PrefixedName
    /// <summary>
    ///   <para>nexif:Photo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A photo, an image captured using a camera, an EXIF Image File Directory. Implementation notes: use nie:copyright to store copyright notices.</para>
    /// labels<para>Photo</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#Photo">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#Photo</seealso>
    let Photo = Prefixed_Name(nexif, "Photo") |> PrefixedName
    /// <summary>
    ///   <para>nexif:exifAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A property that connects an IFD (or other resource) to one of its entries (Exif attribute). Super property which integrates all Exif tags. Domain definition dropped so that this vocabulary can be used to describe not only Exif IFD, but also general image.</para>
    /// labels<para>exifAttribute</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#exifAttribute">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#exifAttribute</seealso>
    let exifAttribute = Prefixed_Name(nexif, "exifAttribute") |> PrefixedName
    /// <summary>
    ///   <para>nexif:colorSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 40961
    /// The color space information tag (ColorSpace) is always recorded as the color space specifier. Normally sRGB (=1) is used to define the color space based on the PC monitor conditions and environment.</para>
    /// labels<para>colorSpace</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#colorSpace">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#colorSpace</seealso>
    let colorSpace = Prefixed_Name(nexif, "colorSpace") |> PrefixedName
    /// <summary>
    ///   <para>nexif:imageConfig</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An attribute relating to Image Configuration</para>
    /// labels<para>imageConfig</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#imageConfig">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#imageConfig</seealso>
    let imageConfig = Prefixed_Name(nexif, "imageConfig") |> PrefixedName

    /// <summary>
    ///   <para>nexif:compressedBitsPerPixel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 37122
    /// Information specific to compressed data. The compression mode used for a compressed image is indicated in unit bits per pixel.</para>
    /// labels<para>compressedBitsPerPixel</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#compressedBitsPerPixel">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#compressedBitsPerPixel</seealso>
    let compressedBitsPerPixel =
        Prefixed_Name(nexif, "compressedBitsPerPixel") |> PrefixedName

    /// <summary>
    ///   <para>nexif:copyright</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 33432
    /// Copyright information. In this standard the tag is used to indicate both the photographer and editor copyrights. It is the copyright notice of the person or organization claiming rights to the image. Deprecated in favor of the more generic nie:copyright.</para>
    /// labels<para>copyright</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#copyright">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#copyright</seealso>
    let copyright = Prefixed_Name(nexif, "copyright") |> PrefixedName
    /// <summary>
    ///   <para>nexif:datatype</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Exif field data type, such as ascii, byte, short etc.</para>
    /// labels<para>datatype</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#datatype">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#datatype</seealso>
    let datatype = Prefixed_Name(nexif, "datatype") |> PrefixedName
    /// <summary>
    ///   <para>nexif:dateAndOrTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An attribute relating to Date and/or Time</para>
    /// labels<para>dateAndOrTime</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#dateAndOrTime">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#dateAndOrTime</seealso>
    let dateAndOrTime = Prefixed_Name(nexif, "dateAndOrTime") |> PrefixedName
    /// <summary>
    ///   <para>nexif:dateTimeDigitized</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date and time when the image was stored as digital data. If, for example, an image was captured by DSC and at the same time the file was recorded, then the DateTimeOriginal and DateTimeDigitized will have the same contents.
    /// tagNumber: 36868</para>
    /// labels<para>dateTimeDigitized</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#dateTimeDigitized">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#dateTimeDigitized</seealso>
    let dateTimeDigitized = Prefixed_Name(nexif, "dateTimeDigitized") |> PrefixedName

    /// <summary>
    ///   <para>nexif:deviceSettingDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 41995
    /// Information on the picture-taking conditions of a particular camera model. The tag is used only to indicate the picture-taking conditions in the reader.</para>
    /// labels<para>deviceSettingDescription</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#deviceSettingDescription">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#deviceSettingDescription</seealso>
    let deviceSettingDescription =
        Prefixed_Name(nexif, "deviceSettingDescription") |> PrefixedName

    /// <summary>
    ///   <para>nexif:printImageMatchingIFDPointer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 50341
    /// A pointer to the print image matching IFD</para>
    /// labels<para>printImageMatchingIFDPointer</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#printImageMatchingIFDPointer">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#printImageMatchingIFDPointer</seealso>
    let printImageMatchingIFDPointer =
        Prefixed_Name(nexif, "printImageMatchingIFDPointer") |> PrefixedName

    /// <summary>
    ///   <para>nexif:referenceBlackWhite</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 532
    /// The reference black point value and reference white point value. The color space is declared in a color space information tag, with the default being the value that gives the optimal image characteristics Interoperability these conditions.</para>
    /// labels<para>referenceBlackWhite</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#referenceBlackWhite">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#referenceBlackWhite</seealso>
    let referenceBlackWhite =
        Prefixed_Name(nexif, "referenceBlackWhite") |> PrefixedName

    /// <summary>
    ///   <para>nexif:pictTaking</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An attribute relating to Picture-Taking Conditions</para>
    /// labels<para>pictTaking</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#pictTaking">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#pictTaking</seealso>
    let pictTaking = Prefixed_Name(nexif, "pictTaking") |> PrefixedName
    /// <summary>
    ///   <para>nexif:imageDataStruct</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An attribute relating to image data structure</para>
    /// labels<para>imageDataStruct</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#imageDataStruct">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#imageDataStruct</seealso>
    let imageDataStruct = Prefixed_Name(nexif, "imageDataStruct") |> PrefixedName
    /// <summary>
    ///   <para>nexif:cfaPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 41730
    /// The color filter array (CFA) geometric pattern of the image sensor when a one-chip color area sensor is used. It does not apply to all sensing methods.</para>
    /// labels<para>cfaPattern</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#cfaPattern">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#cfaPattern</seealso>
    let cfaPattern = Prefixed_Name(nexif, "cfaPattern") |> PrefixedName
    /// <summary>
    ///   <para>nexif:contrast</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 41992
    /// The direction of contrast processing applied by the camera when the image was shot.</para>
    /// labels<para>contrast</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#contrast">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#contrast</seealso>
    let contrast = Prefixed_Name(nexif, "contrast") |> PrefixedName
    /// <summary>
    ///   <para>nexif:lightSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 37384
    /// Light source such as Daylight, Tungsten, Flash etc.</para>
    /// labels<para>lightSource</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#lightSource">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#lightSource</seealso>
    let lightSource = Prefixed_Name(nexif, "lightSource") |> PrefixedName
    /// <summary>
    ///   <para>nexif:userInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An attribute relating to User Information</para>
    /// labels<para>userInfo</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#userInfo">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#userInfo</seealso>
    let userInfo = Prefixed_Name(nexif, "userInfo") |> PrefixedName
    /// <summary>
    ///   <para>nexif:maxApertureValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 37381
    /// The smallest F number of the lens. The unit is the APEX value. Ordinarily it is given in the range of 00.00 to 99.99, but it is not limited to this range.</para>
    /// labels<para>maxApertureValue</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#maxApertureValue">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#maxApertureValue</seealso>
    let maxApertureValue = Prefixed_Name(nexif, "maxApertureValue") |> PrefixedName
    /// <summary>
    ///   <para>nexif:flashEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 41483
    /// The strobe energy at the time the image is captured, as measured in Beam Candle Power Seconds (BCPS).</para>
    /// labels<para>flashEnergy</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#flashEnergy">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#flashEnergy</seealso>
    let flashEnergy = Prefixed_Name(nexif, "flashEnergy") |> PrefixedName
    /// <summary>
    ///   <para>nexif:flashpixVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 40960
    /// The Flashpix format version supported by a FPXR file. If the FPXR function supports Flashpix format Ver. 1.0, this is indicated similarly to ExifVersion by recording "0100" as 4-byte ASCII.</para>
    /// labels<para>flashpixVersion</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#flashpixVersion">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#flashpixVersion</seealso>
    let flashpixVersion = Prefixed_Name(nexif, "flashpixVersion") |> PrefixedName

    /// <summary>
    ///   <para>nexif:focalLengthIn35mmFilm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The equivalent focal length assuming a 35mm film camera, in mm. A value of 0 means the focal length is unknown. Note that this tag differs from the FocalLength tag.
    /// tagNumber: 41989</para>
    /// labels<para>focalLengthIn35mmFilm</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#focalLengthIn35mmFilm">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#focalLengthIn35mmFilm</seealso>
    let focalLengthIn35mmFilm =
        Prefixed_Name(nexif, "focalLengthIn35mmFilm") |> PrefixedName

    /// <summary>
    ///   <para>nexif:length</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Length of an object. Could be a subProperty of other general schema.</para>
    /// labels<para>length</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#length">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#length</seealso>
    let length = Prefixed_Name(nexif, "length") |> PrefixedName

    /// <summary>
    ///   <para>nexif:focalPlaneXResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of pixels in the image width (X) direction per FocalPlaneResolutionUnit on the camera focal plane.
    /// tagNumber: 41486</para>
    /// labels<para>focalPlaneXResolution</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#focalPlaneXResolution">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#focalPlaneXResolution</seealso>
    let focalPlaneXResolution =
        Prefixed_Name(nexif, "focalPlaneXResolution") |> PrefixedName

    /// <summary>
    ///   <para>nexif:gainControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 41991
    /// The degree of overall image gain adjustment.</para>
    /// labels<para>gainControl</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gainControl">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gainControl</seealso>
    let gainControl = Prefixed_Name(nexif, "gainControl") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gps</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The location where the picture has been made. This property aggregates values of two properties from the original EXIF specification: gpsLatitute (tag number 2) and gpsLongitude (tag number 4), and gpsAltitude (tag number 6).</para>
    /// labels<para>gps</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gps">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gps</seealso>
    let gps = Prefixed_Name(nexif, "gps") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsAreaInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A character string recording the name of the GPS area. The first byte indicates the character code used, and this is followed by the name of the GPS area.
    /// tagNumber: 28</para>
    /// labels<para>gpsAreaInformation</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsAreaInformation">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsAreaInformation</seealso>
    let gpsAreaInformation = Prefixed_Name(nexif, "gpsAreaInformation") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsDateStamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 29
    /// date and time information relative to UTC (Coordinated Universal Time). The record format is "YYYY:MM:DD" while converted to W3C-DTF to use in RDF</para>
    /// labels<para>gpsDateStamp</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsDateStamp">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsDateStamp</seealso>
    let gpsDateStamp = Prefixed_Name(nexif, "gpsDateStamp") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsDestBearingRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the reference used for giving the bearing to the destination point. 'T' denotes true direction and 'M' is magnetic direction.
    /// tagNumber: 23</para>
    /// labels<para>gpsDestBearingRef</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsDestBearingRef">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsDestBearingRef</seealso>
    let gpsDestBearingRef = Prefixed_Name(nexif, "gpsDestBearingRef") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsDestLatitudeRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 19
    /// Reference for latitude of destination</para>
    /// labels<para>gpsDestLatitudeRef</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsDestLatitudeRef">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsDestLatitudeRef</seealso>
    let gpsDestLatitudeRef = Prefixed_Name(nexif, "gpsDestLatitudeRef") |> PrefixedName

    /// <summary>
    ///   <para>nexif:gpsDestLongitudeRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Reference for longitude of destination
    /// tagNumber: 21</para>
    /// labels<para>gpsDestLongitudeRef</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsDestLongitudeRef">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsDestLongitudeRef</seealso>
    let gpsDestLongitudeRef =
        Prefixed_Name(nexif, "gpsDestLongitudeRef") |> PrefixedName

    /// <summary>
    ///   <para>nexif:gpsImgDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 17
    /// The direction of the image when it was captured. The range of values is from 0.00 to 359.99.</para>
    /// labels<para>gpsImgDirection</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsImgDirection">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsImgDirection</seealso>
    let gpsImgDirection = Prefixed_Name(nexif, "gpsImgDirection") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsInfoIFDPointer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A pointer to the GPS IFD, which is a set of tags for recording GPS information.
    /// tagNumber: 34853</para>
    /// labels<para>gpsInfoIFDPointer</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsInfoIFDPointer">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsInfoIFDPointer</seealso>
    let gpsInfoIFDPointer = Prefixed_Name(nexif, "gpsInfoIFDPointer") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsLongitudeRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 3
    /// Indicates whether the longitude is east or west longitude. ASCII 'E' indicates east longitude, and 'W' is west longitude.</para>
    /// labels<para>gpsLongitudeRef</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsLongitudeRef">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsLongitudeRef</seealso>
    let gpsLongitudeRef = Prefixed_Name(nexif, "gpsLongitudeRef") |> PrefixedName

    /// <summary>
    ///   <para>nexif:gpsProcessingMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 27
    /// A character string recording the name of the method used for location finding. The first byte indicates the character code used, and this is followed by the name of the method.</para>
    /// labels<para>gpsProcessingMethod</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsProcessingMethod">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsProcessingMethod</seealso>
    let gpsProcessingMethod =
        Prefixed_Name(nexif, "gpsProcessingMethod") |> PrefixedName

    /// <summary>
    ///   <para>nexif:gpsStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 9
    /// The status of the GPS receiver when the image is recorded. 'A' means measurement is in progress, and 'V' means the measurement is Interoperability.</para>
    /// labels<para>gpsStatus</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsStatus">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsStatus</seealso>
    let gpsStatus = Prefixed_Name(nexif, "gpsStatus") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsTimeStamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 7
    /// The time as UTC (Coordinated Universal Time). TimeStamp is expressed as three RATIONAL values giving the hour, minute, and second.</para>
    /// labels<para>gpsTimeStamp</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsTimeStamp">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsTimeStamp</seealso>
    let gpsTimeStamp = Prefixed_Name(nexif, "gpsTimeStamp") |> PrefixedName
    /// <summary>
    ///   <para>nexif:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Height of an object</para>
    /// labels<para>height</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#height">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#height</seealso>
    let height = Prefixed_Name(nexif, "height") |> PrefixedName
    /// <summary>
    ///   <para>nexif:imageDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 270
    /// A character string giving the title of the image. It may be a comment such as "1988 company picnic" or the like. Two-byte character codes cannot be used. When a 2-byte code is necessary, the Exif Private tag UserComment is to be used.</para>
    /// labels<para>imageDescription</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#imageDescription">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#imageDescription</seealso>
    let imageDescription = Prefixed_Name(nexif, "imageDescription") |> PrefixedName
    /// <summary>
    ///   <para>nexif:imageUniqueID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An identifier assigned uniquely to each image. It is recorded as an ASCII string equivalent to hexadecimal notation and 128-bit fixed length.
    /// tagNumber: 42016</para>
    /// labels<para>imageUniqueID</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#imageUniqueID">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#imageUniqueID</seealso>
    let imageUniqueID = Prefixed_Name(nexif, "imageUniqueID") |> PrefixedName
    /// <summary>
    ///   <para>nexif:imageWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 256
    /// Image width. The number of columns of image data, equal to the number of pixels per row. In JPEG compressed data a JPEG marker is used instead of this tag.</para>
    /// labels<para>imageWidth</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#imageWidth">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#imageWidth</seealso>
    let imageWidth = Prefixed_Name(nexif, "imageWidth") |> PrefixedName

    /// <summary>
    ///   <para>nexif:interoperabilityIFDPointer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A pointer to the Interoperability IFD, which is composed of tags storing the information to ensure the Interoperability
    /// tagNumber: 40965</para>
    /// labels<para>interoperabilityIFDPointer</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#interoperabilityIFDPointer">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#interoperabilityIFDPointer</seealso>
    let interoperabilityIFDPointer =
        Prefixed_Name(nexif, "interoperabilityIFDPointer") |> PrefixedName

    /// <summary>
    ///   <para>nexif:interoperabilityIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the identification of the Interoperability rule. 'R98' = conforming to R98 file specification of Recommended Exif Interoperability Rules (ExifR98) or to DCF basic file stipulated by Design Rule for Camera File System. 'THM' = conforming to DCF thumbnail file stipulated by Design rule for Camera File System.
    /// tagNumber: 1</para>
    /// labels<para>interoperabilityIndex</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#interoperabilityIndex">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#interoperabilityIndex</seealso>
    let interoperabilityIndex =
        Prefixed_Name(nexif, "interoperabilityIndex") |> PrefixedName

    /// <summary>
    ///   <para>nexif:isoSpeedRatings</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the ISO Speed and ISO Latitude of the camera or input device as specified in ISO 12232.
    /// tagNumber: 34855</para>
    /// labels<para>isoSpeedRatings</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#isoSpeedRatings">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#isoSpeedRatings</seealso>
    let isoSpeedRatings = Prefixed_Name(nexif, "isoSpeedRatings") |> PrefixedName

    /// <summary>
    ///   <para>nexif:jpegInterchangeFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 513
    /// The offset to the start byte (SOI) of JPEG compressed thumbnail data. This is not used for primary image JPEG data.</para>
    /// labels<para>jpegInterchangeFormat</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#jpegInterchangeFormat">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#jpegInterchangeFormat</seealso>
    let jpegInterchangeFormat =
        Prefixed_Name(nexif, "jpegInterchangeFormat") |> PrefixedName

    /// <summary>
    ///   <para>nexif:recOffset</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An attribute relating to recording offset</para>
    /// labels<para>recOffset</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#recOffset">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#recOffset</seealso>
    let recOffset = Prefixed_Name(nexif, "recOffset") |> PrefixedName
    /// <summary>
    ///   <para>nexif:make</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Manufacturer of image input equipment
    /// tagNumber: 271</para>
    /// labels<para>make</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#make">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#make</seealso>
    let make = Prefixed_Name(nexif, "make") |> PrefixedName
    /// <summary>
    ///   <para>nexif:makerNote</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Manufacturer notes
    /// tagNumber: 37500</para>
    /// labels<para>makerNote</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#makerNote">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#makerNote</seealso>
    let makerNote = Prefixed_Name(nexif, "makerNote") |> PrefixedName
    /// <summary>
    ///   <para>nexif:meter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A length with unit of meter</para>
    /// labels<para>meter</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#meter">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#meter</seealso>
    let meter = Prefixed_Name(nexif, "meter") |> PrefixedName
    /// <summary>
    ///   <para>nexif:meteringMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Metering mode, such as CenterWeightedAverage, Spot, MultiSpot,Pattern, Partial etc.
    /// tagNumber: 37383</para>
    /// labels<para>meteringMode</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#meteringMode">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#meteringMode</seealso>
    let meteringMode = Prefixed_Name(nexif, "meteringMode") |> PrefixedName
    /// <summary>
    ///   <para>nexif:model</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 272
    /// Model of image input equipment</para>
    /// labels<para>model</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#model">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#model</seealso>
    let model = Prefixed_Name(nexif, "model") |> PrefixedName
    /// <summary>
    ///   <para>nexif:oecf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 34856
    /// Indicates the Opto-Electric Conversion Function (OECF) specified in ISO 14524. OECF is the relationship between the camera optical input and the image values.</para>
    /// labels<para>oecf</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#oecf">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#oecf</seealso>
    let oecf = Prefixed_Name(nexif, "oecf") |> PrefixedName
    /// <summary>
    ///   <para>nexif:orientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The image orientation viewed in terms of rows and columns. As defined in the EXIF specification this is a number between 1 and 8.</para>
    /// labels<para>orientation</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#orientation">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#orientation</seealso>
    let orientation = Prefixed_Name(nexif, "orientation") |> PrefixedName

    /// <summary>
    ///   <para>nexif:photometricInterpretation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Pixel composition. In JPEG compressed data a JPEG marker is used instead of this tag.
    /// tagNumber: 262</para>
    /// labels<para>photometricInterpretation</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#photometricInterpretation">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#photometricInterpretation</seealso>
    let photometricInterpretation =
        Prefixed_Name(nexif, "photometricInterpretation") |> PrefixedName

    /// <summary>
    ///   <para>nexif:pimBrightness</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Brightness info for print image matching
    /// tagNumber: 10</para>
    /// labels<para>pimBrightness</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#pimBrightness">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#pimBrightness</seealso>
    let pimBrightness = Prefixed_Name(nexif, "pimBrightness") |> PrefixedName
    /// <summary>
    ///   <para>nexif:pimInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An attribute relating to print image matching</para>
    /// labels<para>pimInfo</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#pimInfo">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#pimInfo</seealso>
    let pimInfo = Prefixed_Name(nexif, "pimInfo") |> PrefixedName
    /// <summary>
    ///   <para>nexif:pimColorBalance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 11
    /// ColorBalance info for print image matching</para>
    /// labels<para>pimColorBalance</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#pimColorBalance">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#pimColorBalance</seealso>
    let pimColorBalance = Prefixed_Name(nexif, "pimColorBalance") |> PrefixedName
    /// <summary>
    ///   <para>nexif:pimContrast</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 9
    /// Contrast info for print image matching</para>
    /// labels<para>pimContrast</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#pimContrast">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#pimContrast</seealso>
    let pimContrast = Prefixed_Name(nexif, "pimContrast") |> PrefixedName
    /// <summary>
    ///   <para>nexif:pixelXDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Information specific to compressed data. When a compressed file is recorded, the valid width of the meaningful image shall be recorded in this tag, whether or not there is padding data or a restart marker. This tag should not exist in an uncompressed file.
    /// tagNumber: 40962</para>
    /// labels<para>pixelXDimension</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#pixelXDimension">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#pixelXDimension</seealso>
    let pixelXDimension = Prefixed_Name(nexif, "pixelXDimension") |> PrefixedName
    /// <summary>
    ///   <para>nexif:pixelYDimension</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Information specific to compressed data. When a compressed file is recorded, the valid height of the meaningful image shall be recorded in this tag, whether or not there is padding data or a restart marker. This tag should not exist in an uncompressed file. Since data padding is unnecessary in the vertical direction, the number of lines recorded in this valid image height tag will in fact be the same as that recorded in the SOF.
    /// tagNumber: 40963</para>
    /// labels<para>pixelYDimension</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#pixelYDimension">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#pixelYDimension</seealso>
    let pixelYDimension = Prefixed_Name(nexif, "pixelYDimension") |> PrefixedName

    /// <summary>
    ///   <para>nexif:planarConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates whether pixel components are recorded in chunky or planar format. In JPEG compressed files a JPEG marker is used instead of this tag. If this field does not exist, the TIFF default of 1 (chunky) is assumed.
    /// tagNumber: 284</para>
    /// labels<para>planarConfiguration</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#planarConfiguration">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#planarConfiguration</seealso>
    let planarConfiguration =
        Prefixed_Name(nexif, "planarConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>nexif:primaryChromaticities</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The chromaticity of the three primary colors of the image. Normally this tag is not necessary, since color space is specified in the color space information tag (ColorSpace).
    /// tagNumber: 319</para>
    /// labels<para>primaryChromaticities</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#primaryChromaticities">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#primaryChromaticities</seealso>
    let primaryChromaticities =
        Prefixed_Name(nexif, "primaryChromaticities") |> PrefixedName

    /// <summary>
    ///   <para>nexif:relatedFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Tag Relating to Related File Information</para>
    /// labels<para>relatedFile</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#relatedFile">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#relatedFile</seealso>
    let relatedFile = Prefixed_Name(nexif, "relatedFile") |> PrefixedName

    /// <summary>
    ///   <para>nexif:relatedImageFileFormat</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Related image file format
    /// tagNumber: 4096</para>
    /// labels<para>relatedImageFileFormat</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#relatedImageFileFormat">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#relatedImageFileFormat</seealso>
    let relatedImageFileFormat =
        Prefixed_Name(nexif, "relatedImageFileFormat") |> PrefixedName

    /// <summary>
    ///   <para>nexif:relatedImageLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Related image length
    /// tagNumber: 4098</para>
    /// labels<para>relatedImageLength</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#relatedImageLength">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#relatedImageLength</seealso>
    let relatedImageLength = Prefixed_Name(nexif, "relatedImageLength") |> PrefixedName
    /// <summary>
    ///   <para>nexif:relatedImageWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 4097
    /// Related image width</para>
    /// labels<para>relatedImageWidth</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#relatedImageWidth">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#relatedImageWidth</seealso>
    let relatedImageWidth = Prefixed_Name(nexif, "relatedImageWidth") |> PrefixedName
    /// <summary>
    ///   <para>nexif:resolutionUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 296
    /// The unit for measuring XResolution and YResolution. The same unit is used for both XResolution and YResolution. If the image resolution in unknown, 2 (inches) is designated.</para>
    /// labels<para>resolutionUnit</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#resolutionUnit">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#resolutionUnit</seealso>
    let resolutionUnit = Prefixed_Name(nexif, "resolutionUnit") |> PrefixedName
    /// <summary>
    ///   <para>nexif:rowsPerStrip</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 278
    /// The number of rows per strip. This is the number of rows in the image of one strip when an image is divided into strips. With JPEG compressed data this designation is not needed and is omitted.</para>
    /// labels<para>rowsPerStrip</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#rowsPerStrip">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#rowsPerStrip</seealso>
    let rowsPerStrip = Prefixed_Name(nexif, "rowsPerStrip") |> PrefixedName
    /// <summary>
    ///   <para>nexif:samplesPerPixel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of components per pixel. Since this standard applies to RGB and YCbCr images, the value set for this tag is 3. In JPEG compressed data a JPEG marker is used instead of this tag.
    /// tagNumber: 277</para>
    /// labels<para>samplesPerPixel</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#samplesPerPixel">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#samplesPerPixel</seealso>
    let samplesPerPixel = Prefixed_Name(nexif, "samplesPerPixel") |> PrefixedName
    /// <summary>
    ///   <para>nexif:sceneCaptureType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 41990
    /// The type of scene that was shot. It can also be used to record the mode in which the image was shot, such as Landscape, Portrait etc. Note that this differs from the scene type (SceneType) tag.</para>
    /// labels<para>sceneCaptureType</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#sceneCaptureType">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#sceneCaptureType</seealso>
    let sceneCaptureType = Prefixed_Name(nexif, "sceneCaptureType") |> PrefixedName
    /// <summary>
    ///   <para>nexif:sceneType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 41729
    /// The type of scene. If a DSC recorded the image, this tag value shall always be set to 1, indicating that the image was directly photographed.</para>
    /// labels<para>sceneType</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#sceneType">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#sceneType</seealso>
    let sceneType = Prefixed_Name(nexif, "sceneType") |> PrefixedName
    /// <summary>
    ///   <para>nexif:sensingMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 41495
    /// The image sensor type on the camera or input device, such as One-chip color area sensor etc.</para>
    /// labels<para>sensingMethod</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#sensingMethod">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#sensingMethod</seealso>
    let sensingMethod = Prefixed_Name(nexif, "sensingMethod") |> PrefixedName
    /// <summary>
    ///   <para>nexif:shutterSpeedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 37377
    /// Shutter speed. The unit is the APEX (Additive System of Photographic Exposure) setting</para>
    /// labels<para>shutterSpeedValue</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#shutterSpeedValue">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#shutterSpeedValue</seealso>
    let shutterSpeedValue = Prefixed_Name(nexif, "shutterSpeedValue") |> PrefixedName
    /// <summary>
    ///   <para>nexif:software</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 305
    /// The name and version of the software or firmware of the camera or image input device used to generate the image.</para>
    /// labels<para>software</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#software">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#software</seealso>
    let software = Prefixed_Name(nexif, "software") |> PrefixedName

    /// <summary>
    ///   <para>nexif:spatialFrequencyResponse</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>This tag records the camera or input device spatial frequency table and SFR values in the direction of image width, image height, and diagonal direction, as specified in ISO 12233.
    /// tagNumber: 41484</para>
    /// labels<para>spatialFrequencyResponse</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#spatialFrequencyResponse">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#spatialFrequencyResponse</seealso>
    let spatialFrequencyResponse =
        Prefixed_Name(nexif, "spatialFrequencyResponse") |> PrefixedName

    /// <summary>
    ///   <para>nexif:spectralSensitivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the spectral sensitivity of each channel of the camera used. The tag value is an ASCII string compatible with the standard developed by the ASTM Technical committee.
    /// tagNumber: 34852</para>
    /// labels<para>spectralSensitivity</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#spectralSensitivity">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#spectralSensitivity</seealso>
    let spectralSensitivity =
        Prefixed_Name(nexif, "spectralSensitivity") |> PrefixedName

    /// <summary>
    ///   <para>nexif:brightnessValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 37379
    /// The value of brightness. The unit is the APEX value. Ordinarily it is given in the range of -99.99 to 99.99. Note that if the numerator of the recorded value is FFFFFFFF.H, Unknown shall be indicated.</para>
    /// labels<para>brightnessValue</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#brightnessValue">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#brightnessValue</seealso>
    let brightnessValue = Prefixed_Name(nexif, "brightnessValue") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsMeasureMode</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The GPS measurement mode. '2' means two-dimensional measurement and '3' means three-dimensional measurement is in progress.
    /// tagNumber: 10</para>
    /// labels<para>gpsMeasureMode</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsMeasureMode">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsMeasureMode</seealso>
    let gpsMeasureMode = Prefixed_Name(nexif, "gpsMeasureMode") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The speed of GPS receiver movement.
    /// tagNumber: 13</para>
    /// labels<para>gpsSpeed</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsSpeed">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsSpeed</seealso>
    let gpsSpeed = Prefixed_Name(nexif, "gpsSpeed") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsVersionID</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The version of GPSInfoIFD. The version is given as 2.2.0.0. This tag is mandatory when GPSInfo tag is present.
    /// tagNumber: 0</para>
    /// labels<para>gpsVersionID</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsVersionID">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsVersionID</seealso>
    let gpsVersionID = Prefixed_Name(nexif, "gpsVersionID") |> PrefixedName
    /// <summary>
    ///   <para>nexif:imageLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 257
    /// Image height. The number of rows of image data. In JPEG compressed data a JPEG marker is used.</para>
    /// labels<para>imageLength</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#imageLength">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#imageLength</seealso>
    let imageLength = Prefixed_Name(nexif, "imageLength") |> PrefixedName
    /// <summary>
    ///   <para>nexif:interopInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An attribute relating to Interoperability. Tags stored in
    /// Interoperability IFD may be defined dependently to each Interoperability rule.</para>
    /// labels<para>interopInfo</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#interopInfo">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#interopInfo</seealso>
    let interopInfo = Prefixed_Name(nexif, "interopInfo") |> PrefixedName

    /// <summary>
    ///   <para>nexif:interoperabilityVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 2
    /// Interoperability Version</para>
    /// labels<para>interoperabilityVersion</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#interoperabilityVersion">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#interoperabilityVersion</seealso>
    let interoperabilityVersion =
        Prefixed_Name(nexif, "interoperabilityVersion") |> PrefixedName

    /// <summary>
    ///   <para>nexif:jpegInterchangeFormatLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The number of bytes of JPEG compressed thumbnail data. This is not used for primary image JPEG data.
    /// tagNumber: 514</para>
    /// labels<para>jpegInterchangeFormatLength</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#jpegInterchangeFormatLength">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#jpegInterchangeFormatLength</seealso>
    let jpegInterchangeFormatLength =
        Prefixed_Name(nexif, "jpegInterchangeFormatLength") |> PrefixedName

    /// <summary>
    ///   <para>nexif:gpsDest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Location of the destination. This property aggregates values of two other properties from the original exif specification. gpsDestLatitude (tag number 20) and gpsDestLongitude (tag number 22)</para>
    /// labels<para>gpsDest</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsDest">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsDest</seealso>
    let gpsDest = Prefixed_Name(nexif, "gpsDest") |> PrefixedName
    /// <summary>
    ///   <para>nexif:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Width of an object</para>
    /// labels<para>width</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#width">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#width</seealso>
    let width = Prefixed_Name(nexif, "width") |> PrefixedName
    /// <summary>
    ///   <para>nexif:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>a date information. Usually saved as YYYY:MM:DD (HH:MM:SS) format in Exif data, but represented here as W3C-DTF format</para>
    /// labels<para>date</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#date">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#date</seealso>
    let date = Prefixed_Name(nexif, "date") |> PrefixedName
    /// <summary>
    ///   <para>nexif:dateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The date and time of image creation. In this standard it is the date and time the file was changed.
    /// tagNumber: 306</para>
    /// labels<para>dateTime</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#dateTime">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#dateTime</seealso>
    let dateTime = Prefixed_Name(nexif, "dateTime") |> PrefixedName
    /// <summary>
    ///   <para>nexif:pimSharpness</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Sharpness info for print image matching
    /// tagNumber: 13</para>
    /// labels<para>pimSharpness</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#pimSharpness">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#pimSharpness</seealso>
    let pimSharpness = Prefixed_Name(nexif, "pimSharpness") |> PrefixedName
    /// <summary>
    ///   <para>nexif:pimSaturation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 12
    /// Saturation info for print image matching</para>
    /// labels<para>pimSaturation</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#pimSaturation">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#pimSaturation</seealso>
    let pimSaturation = Prefixed_Name(nexif, "pimSaturation") |> PrefixedName
    /// <summary>
    ///   <para>nexif:versionInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An attribute relating to Version</para>
    /// labels<para>versionInfo</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#versionInfo">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#versionInfo</seealso>
    let versionInfo = Prefixed_Name(nexif, "versionInfo") |> PrefixedName
    /// <summary>
    ///   <para>nexif:relatedSoundFile</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Related audio file
    /// tagNumber: 40964</para>
    /// labels<para>relatedSoundFile</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#relatedSoundFile">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#relatedSoundFile</seealso>
    let relatedSoundFile = Prefixed_Name(nexif, "relatedSoundFile") |> PrefixedName
    /// <summary>
    ///   <para>nexif:saturation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The direction of saturation processing applied by the camera when the image was shot.
    /// tagNumber: 41993</para>
    /// labels<para>saturation</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#saturation">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#saturation</seealso>
    let saturation = Prefixed_Name(nexif, "saturation") |> PrefixedName
    /// <summary>
    ///   <para>nexif:exifdata</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An Exif IFD data entry</para>
    /// labels<para>exifdata</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#exifdata">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#exifdata</seealso>
    let exifdata = Prefixed_Name(nexif, "exifdata") |> PrefixedName
    /// <summary>
    ///   <para>nexif:stripByteCounts</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 279
    /// The total number of bytes in each strip. With JPEG compressed data this designation is not needed and is omitted.</para>
    /// labels<para>stripByteCounts</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#stripByteCounts">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#stripByteCounts</seealso>
    let stripByteCounts = Prefixed_Name(nexif, "stripByteCounts") |> PrefixedName
    /// <summary>
    ///   <para>nexif:subsecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>subsecond</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#subsecond">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#subsecond</seealso>
    let subsecond = Prefixed_Name(nexif, "subsecond") |> PrefixedName
    /// <summary>
    ///   <para>nexif:subjectArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 37396
    /// The location and area of the main subject in the overall scene.</para>
    /// labels<para>subjectArea</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#subjectArea">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#subjectArea</seealso>
    let subjectArea = Prefixed_Name(nexif, "subjectArea") |> PrefixedName
    /// <summary>
    ///   <para>nexif:subjectDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 37382
    /// The distance to the subject, given in meters. Note that if the numerator of the recorded value is FFFFFFFF.H, Infinity shall be indicated; and if the numerator is 0, Distance unknown shall be indicated.</para>
    /// labels<para>subjectDistance</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#subjectDistance">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#subjectDistance</seealso>
    let subjectDistance = Prefixed_Name(nexif, "subjectDistance") |> PrefixedName
    /// <summary>
    ///   <para>nexif:tagid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Exif tag number with context prefix, such as IFD type or maker name (for this schema definition)</para>
    /// labels<para>tagid</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#tagid">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#tagid</seealso>
    let tagid = Prefixed_Name(nexif, "tagid") |> PrefixedName
    /// <summary>
    ///   <para>nexif:userComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 37510
    /// A tag for Exif users to write keywords or comments on the image besides those in ImageDescription, and without the character code limitations of the ImageDescription tag. The character code used in the UserComment tag is identified based on an ID code in a fixed 8-byte area at the start of the tag data area.</para>
    /// labels<para>userComment</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#userComment">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#userComment</seealso>
    let userComment = Prefixed_Name(nexif, "userComment") |> PrefixedName
    /// <summary>
    ///   <para>nexif:exposureProgram</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 34850
    /// The class of the program used by the camera to set exposure when the picture is taken.</para>
    /// labels<para>exposureProgram</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#exposureProgram">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#exposureProgram</seealso>
    let exposureProgram = Prefixed_Name(nexif, "exposureProgram") |> PrefixedName
    /// <summary>
    ///   <para>nexif:fileSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The image source. If a DSC recorded the image, this tag value of this tag always be set to 3, indicating that the image was recorded on a DSC.
    /// tagNumber: 41728</para>
    /// labels<para>fileSource</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#fileSource">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#fileSource</seealso>
    let fileSource = Prefixed_Name(nexif, "fileSource") |> PrefixedName
    /// <summary>
    ///   <para>nexif:sharpness</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 41994
    /// The direction of sharpness processing applied by the camera when the image was shot.</para>
    /// labels<para>sharpness</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#sharpness">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#sharpness</seealso>
    let sharpness = Prefixed_Name(nexif, "sharpness") |> PrefixedName
    /// <summary>
    ///   <para>nexif:flash</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 37385
    /// The status of flash when the image was shot.</para>
    /// labels<para>flash</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#flash">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#flash</seealso>
    let flash = Prefixed_Name(nexif, "flash") |> PrefixedName
    /// <summary>
    ///   <para>nexif:mm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A length with unit of mm</para>
    /// labels<para>mm</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#mm">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#mm</seealso>
    let mm = Prefixed_Name(nexif, "mm") |> PrefixedName
    /// <summary>
    ///   <para>nexif:focalLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The actual focal length of the lens, in mm. Conversion is not made to the focal length of a 35 mm film camera.
    /// tagNumber: 37386</para>
    /// labels<para>focalLength</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#focalLength">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#focalLength</seealso>
    let focalLength = Prefixed_Name(nexif, "focalLength") |> PrefixedName

    /// <summary>
    ///   <para>nexif:focalPlaneYResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 41487
    /// The number of pixels in the image height (Y) direction per FocalPlaneResolutionUnit on the camera focal plane.</para>
    /// labels<para>focalPlaneYResolution</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#focalPlaneYResolution">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#focalPlaneYResolution</seealso>
    let focalPlaneYResolution =
        Prefixed_Name(nexif, "focalPlaneYResolution") |> PrefixedName

    /// <summary>
    ///   <para>nexif:geo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Geometric data such as latitude, longitude and altitude. Usually saved as rational number.</para>
    /// labels<para>geo</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#geo">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#geo</seealso>
    let geo = Prefixed_Name(nexif, "geo") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsInfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An attribute relating to GPS information</para>
    /// labels<para>gpsInfo</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsInfo">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsInfo</seealso>
    let gpsInfo = Prefixed_Name(nexif, "gpsInfo") |> PrefixedName

    /// <summary>
    ///   <para>nexif:focalPlaneResolutionUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The unit for measuring FocalPlaneXResolution and FocalPlaneYResolution. This value is the same as the ResolutionUnit.
    /// tagNumber: 41488</para>
    /// labels<para>focalPlaneResolutionUnit</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#focalPlaneResolutionUnit">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#focalPlaneResolutionUnit</seealso>
    let focalPlaneResolutionUnit =
        Prefixed_Name(nexif, "focalPlaneResolutionUnit") |> PrefixedName

    /// <summary>
    ///   <para>nexif:gpsAltitudeRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the altitude used as the reference altitude. If the reference is sea level and the altitude is above sea level, 0 is given. If the altitude is below sea level, a value of 1 is given and the altitude is indicated as an absolute value in the GPSAltitude tag. The reference unit is meters.
    /// tagNumber: 5</para>
    /// labels<para>gpsAltitudeRef</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsAltitudeRef">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsAltitudeRef</seealso>
    let gpsAltitudeRef = Prefixed_Name(nexif, "gpsAltitudeRef") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsDOP</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The GPS DOP (data degree of precision). An HDOP value is written during two-dimensional measurement, and PDOP during three-dimensional measurement.
    /// tagNumber: 11</para>
    /// labels<para>gpsDOP</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsDOP">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsDOP</seealso>
    let gpsDOP = Prefixed_Name(nexif, "gpsDOP") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsDestDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The distance to the destination point.
    /// tagNumber: 26</para>
    /// labels<para>gpsDestDistance</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsDestDistance">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsDestDistance</seealso>
    let gpsDestDistance = Prefixed_Name(nexif, "gpsDestDistance") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsDestBearing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The bearing to the destination point. The range of values is from 0.00 to 359.99.
    /// tagNumber: 24</para>
    /// labels<para>gpsDestBearing</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsDestBearing">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsDestBearing</seealso>
    let gpsDestBearing = Prefixed_Name(nexif, "gpsDestBearing") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsDestDistanceRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the unit used to express the distance to the destination point. 'K', 'M' and 'N' represent kilometers, miles and knots.
    /// tagNumber: 25</para>
    /// labels<para>gpsDestDistanceRef</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsDestDistanceRef">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsDestDistanceRef</seealso>
    let gpsDestDistanceRef = Prefixed_Name(nexif, "gpsDestDistanceRef") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsDifferential</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 30
    /// Indicates whether differential correction is applied to the GPS receiver.</para>
    /// labels<para>gpsDifferential</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsDifferential">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsDifferential</seealso>
    let gpsDifferential = Prefixed_Name(nexif, "gpsDifferential") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsImgDirectionRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 16
    /// The reference for giving the direction of the image when it is captured. 'T' denotes true direction and 'M' is magnetic direction.</para>
    /// labels<para>gpsImgDirectionRef</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsImgDirectionRef">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsImgDirectionRef</seealso>
    let gpsImgDirectionRef = Prefixed_Name(nexif, "gpsImgDirectionRef") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsLatitudeRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 1
    /// Indicates whether the latitude is north or south latitude. The ASCII value 'N' indicates north latitude, and 'S' is south latitude.</para>
    /// labels<para>gpsLatitudeRef</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsLatitudeRef">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsLatitudeRef</seealso>
    let gpsLatitudeRef = Prefixed_Name(nexif, "gpsLatitudeRef") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsMapDatum</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The geodetic survey data used by the GPS receiver. If the survey data is restricted to Japan, the value of this tag is 'TOKYO' or 'WGS-84'. If a GPS Info tag is recorded, it is strongly recommended that this tag be recorded.
    /// tagNumber: 18</para>
    /// labels<para>gpsMapDatum</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsMapDatum">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsMapDatum</seealso>
    let gpsMapDatum = Prefixed_Name(nexif, "gpsMapDatum") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsSatellites</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 8
    /// The GPS satellites used for measurements. This tag can be used to describe the number of satellites, their ID number, angle of elevation, azimuth, SNR and other information in ASCII notation. The format is not specified. If the GPS receiver is incapable of taking measurements, value of the tag shall be set to NULL.</para>
    /// labels<para>gpsSatellites</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsSatellites">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsSatellites</seealso>
    let gpsSatellites = Prefixed_Name(nexif, "gpsSatellites") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsSpeedRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 12
    /// The unit used to express the GPS receiver speed of movement. 'K' 'M' and 'N' represents kilometers per hour, miles per hour, and knots.</para>
    /// labels<para>gpsSpeedRef</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsSpeedRef">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsSpeedRef</seealso>
    let gpsSpeedRef = Prefixed_Name(nexif, "gpsSpeedRef") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsTrack</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The direction of GPS receiver movement. The range of values is from 0.00 to 359.99.
    /// tagNumber: 15</para>
    /// labels<para>gpsTrack</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsTrack">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsTrack</seealso>
    let gpsTrack = Prefixed_Name(nexif, "gpsTrack") |> PrefixedName
    /// <summary>
    ///   <para>nexif:gpsTrackRef</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 14
    /// The reference for giving the direction of GPS receiver movement. 'T' denotes true direction and 'M' is magnetic direction.</para>
    /// labels<para>gpsTrackRef</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsTrackRef">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#gpsTrackRef</seealso>
    let gpsTrackRef = Prefixed_Name(nexif, "gpsTrackRef") |> PrefixedName
    /// <summary>
    ///   <para>nexif:apertureValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 37378
    /// The lens aperture. The unit is the APEX value.</para>
    /// labels<para>apertureValue</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#apertureValue">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#apertureValue</seealso>
    let apertureValue = Prefixed_Name(nexif, "apertureValue") |> PrefixedName
    /// <summary>
    ///   <para>nexif:bitsPerSample</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 258
    /// The number of bits per image component. In this standard each component of the image is 8 bits, so the value for this tag is 8. See also SamplesPerPixel. In JPEG compressed data a JPEG marker is used instead of this tag.</para>
    /// labels<para>bitsPerSample</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#bitsPerSample">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#bitsPerSample</seealso>
    let bitsPerSample = Prefixed_Name(nexif, "bitsPerSample") |> PrefixedName
    /// <summary>
    ///   <para>nexif:resolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>a rational number representing a resolution. Could be a subProperty of other general schema.</para>
    /// labels<para>resolution</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#resolution">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#resolution</seealso>
    let resolution = Prefixed_Name(nexif, "resolution") |> PrefixedName
    /// <summary>
    ///   <para>nexif:imageDataCharacter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An attribute relating to image data characteristics</para>
    /// labels<para>imageDataCharacter</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#imageDataCharacter">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#imageDataCharacter</seealso>
    let imageDataCharacter = Prefixed_Name(nexif, "imageDataCharacter") |> PrefixedName

    /// <summary>
    ///   <para>nexif:componentsConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Information specific to compressed data. The channels of each component are arranged in order from the 1st component to the 4th. For uncompressed data the data arrangement is given in the PhotometricInterpretation tag. However, since PhotometricInterpretation can only express the order of Y,Cb and Cr, this tag is provided for cases when compressed data uses components other than Y, Cb, and Cr and to enable support of other sequences.
    /// tagNumber: 37121</para>
    /// labels<para>componentsConfiguration</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#componentsConfiguration">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#componentsConfiguration</seealso>
    let componentsConfiguration =
        Prefixed_Name(nexif, "componentsConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>nexif:compression</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The compression scheme used for the image data. When a primary image is JPEG compressed, this designation is not necessary and is omitted. When thumbnails use JPEG compression, this tag value is set to 6.
    /// tagNumber: 259</para>
    /// labels<para>compression</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#compression">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#compression</seealso>
    let compression = Prefixed_Name(nexif, "compression") |> PrefixedName
    /// <summary>
    ///   <para>nexif:customRendered</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The use of special processing on image data, such as rendering geared to output. When special processing is performed, the reader is expected to disable or minimize any further processing.
    /// tagNumber: 41985</para>
    /// labels<para>customRendered</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#customRendered">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#customRendered</seealso>
    let customRendered = Prefixed_Name(nexif, "customRendered") |> PrefixedName
    /// <summary>
    ///   <para>nexif:dateTimeOriginal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 36867
    /// The date and time when the original image data was generated. For a DSC the date and time the picture was taken are recorded.</para>
    /// labels<para>dateTimeOriginal</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#dateTimeOriginal">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#dateTimeOriginal</seealso>
    let dateTimeOriginal = Prefixed_Name(nexif, "dateTimeOriginal") |> PrefixedName
    /// <summary>
    ///   <para>nexif:digitalZoomRatio</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 41988
    /// The digital zoom ratio when the image was shot. If the numerator of the recorded value is 0, this indicates that digital zoom was not used.</para>
    /// labels<para>digitalZoomRatio</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#digitalZoomRatio">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#digitalZoomRatio</seealso>
    let digitalZoomRatio = Prefixed_Name(nexif, "digitalZoomRatio") |> PrefixedName
    /// <summary>
    ///   <para>nexif:exifIFDPointer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 34665
    /// A pointer to the Exif IFD, which is a set of tags for recording Exif-specific attribute information.</para>
    /// labels<para>exifIFDPointer</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#exifIFDPointer">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#exifIFDPointer</seealso>
    let exifIFDPointer = Prefixed_Name(nexif, "exifIFDPointer") |> PrefixedName
    /// <summary>
    ///   <para>nexif:ifdPointer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A tag that refers a child IFD</para>
    /// labels<para>ifdPointer</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#ifdPointer">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#ifdPointer</seealso>
    let ifdPointer = Prefixed_Name(nexif, "ifdPointer") |> PrefixedName
    /// <summary>
    ///   <para>nexif:exifVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 36864
    /// Exif Version</para>
    /// labels<para>exifVersion</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#exifVersion">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#exifVersion</seealso>
    let exifVersion = Prefixed_Name(nexif, "exifVersion") |> PrefixedName
    /// <summary>
    ///   <para>nexif:exposureBiasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 37380
    /// The exposure bias. The unit is the APEX value. Ordinarily it is given in the range of -99.99 to 99.99.</para>
    /// labels<para>exposureBiasValue</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#exposureBiasValue">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#exposureBiasValue</seealso>
    let exposureBiasValue = Prefixed_Name(nexif, "exposureBiasValue") |> PrefixedName
    /// <summary>
    ///   <para>nexif:exposureIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The exposure index selected on the camera or input device at the time the image is captured.
    /// tagNumber: 41493</para>
    /// labels<para>exposureIndex</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#exposureIndex">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#exposureIndex</seealso>
    let exposureIndex = Prefixed_Name(nexif, "exposureIndex") |> PrefixedName
    /// <summary>
    ///   <para>nexif:exposureTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 33434
    /// Exposure time, given in seconds (sec).</para>
    /// labels<para>exposureTime</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#exposureTime">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#exposureTime</seealso>
    let exposureTime = Prefixed_Name(nexif, "exposureTime") |> PrefixedName
    /// <summary>
    ///   <para>nexif:seconds</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>a mesurement of time length with unit of second</para>
    /// labels<para>seconds</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#seconds">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#seconds</seealso>
    let seconds = Prefixed_Name(nexif, "seconds") |> PrefixedName
    /// <summary>
    ///   <para>nexif:fNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 33437
    /// F number</para>
    /// labels<para>fNumber</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#fNumber">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#fNumber</seealso>
    let fNumber = Prefixed_Name(nexif, "fNumber") |> PrefixedName
    /// <summary>
    ///   <para>nexif:stripOffsets</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>For each strip, the byte offset of that strip. With JPEG compressed data this designation is not needed and is omitted.
    /// tagNumber: 273</para>
    /// labels<para>stripOffsets</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#stripOffsets">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#stripOffsets</seealso>
    let stripOffsets = Prefixed_Name(nexif, "stripOffsets") |> PrefixedName
    /// <summary>
    ///   <para>nexif:subSecTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 37520
    /// DateTime subseconds</para>
    /// labels<para>subSecTime</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#subSecTime">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#subSecTime</seealso>
    let subSecTime = Prefixed_Name(nexif, "subSecTime") |> PrefixedName

    /// <summary>
    ///   <para>nexif:subSecTimeDigitized</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 37522
    /// DateTimeDigitized subseconds</para>
    /// labels<para>subSecTimeDigitized</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#subSecTimeDigitized">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#subSecTimeDigitized</seealso>
    let subSecTimeDigitized =
        Prefixed_Name(nexif, "subSecTimeDigitized") |> PrefixedName

    /// <summary>
    ///   <para>nexif:subSecTimeOriginal</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 37521
    /// DateTimeOriginal subseconds</para>
    /// labels<para>subSecTimeOriginal</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#subSecTimeOriginal">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#subSecTimeOriginal</seealso>
    let subSecTimeOriginal = Prefixed_Name(nexif, "subSecTimeOriginal") |> PrefixedName

    /// <summary>
    ///   <para>nexif:subjectDistanceRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The distance to the subject, such as Macro, Close View or Distant View.
    /// tagNumber: 41996</para>
    /// labels<para>subjectDistanceRange</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#subjectDistanceRange">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#subjectDistanceRange</seealso>
    let subjectDistanceRange =
        Prefixed_Name(nexif, "subjectDistanceRange") |> PrefixedName

    /// <summary>
    ///   <para>nexif:subjectLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The location of the main subject in the scene. The value of this tag represents the pixel at the center of the main subject relative to the left edge, prior to rotation processing as per the Rotation tag. The first value indicates the X column number and second indicates the Y row number.
    /// tagNumber: 41492</para>
    /// labels<para>subjectLocation</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#subjectLocation">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#subjectLocation</seealso>
    let subjectLocation = Prefixed_Name(nexif, "subjectLocation") |> PrefixedName
    /// <summary>
    ///   <para>nexif:subseconds</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A tag used to record fractions of seconds for a date property</para>
    /// labels<para>subseconds</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#subseconds">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#subseconds</seealso>
    let subseconds = Prefixed_Name(nexif, "subseconds") |> PrefixedName
    /// <summary>
    ///   <para>nexif:tagNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The Exif tag number (for this schema definition)</para>
    /// labels<para>tagNumber</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#tagNumber">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#tagNumber</seealso>
    let tagNumber = Prefixed_Name(nexif, "tagNumber") |> PrefixedName
    /// <summary>
    ///   <para>nexif:transferFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 301
    /// A transfer function for the image, described in tabular style. Normally this tag is not necessary, since color space is specified in the color space information tag (ColorSpace).</para>
    /// labels<para>transferFunction</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#transferFunction">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#transferFunction</seealso>
    let transferFunction = Prefixed_Name(nexif, "transferFunction") |> PrefixedName
    /// <summary>
    ///   <para>nexif:unknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An Exif tag whose meaning is not known</para>
    /// labels<para>unknown</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#unknown">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#unknown</seealso>
    let unknown = Prefixed_Name(nexif, "unknown") |> PrefixedName
    /// <summary>
    ///   <para>nexif:whiteBalance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 41987
    /// The white balance mode set when the image was shot.</para>
    /// labels<para>whiteBalance</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#whiteBalance">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#whiteBalance</seealso>
    let whiteBalance = Prefixed_Name(nexif, "whiteBalance") |> PrefixedName
    /// <summary>
    ///   <para>nexif:whitePoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The chromaticity of the white point of the image. Normally this tag is not necessary, since color space is specified in the color space information tag (ColorSpace).
    /// tagNumber: 318</para>
    /// labels<para>whitePoint</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#whitePoint">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#whitePoint</seealso>
    let whitePoint = Prefixed_Name(nexif, "whitePoint") |> PrefixedName
    /// <summary>
    ///   <para>nexif:yCbCrCoefficients</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 529
    /// The matrix coefficients for transformation from RGB to YCbCr image data.</para>
    /// labels<para>yCbCrCoefficients</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#yCbCrCoefficients">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#yCbCrCoefficients</seealso>
    let yCbCrCoefficients = Prefixed_Name(nexif, "yCbCrCoefficients") |> PrefixedName
    /// <summary>
    ///   <para>nexif:yCbCrPositioning</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The position of chrominance components in relation to the luminance component. This field is designated only for JPEG compressed data or uncompressed YCbCr data.
    /// tagNumber: 531</para>
    /// labels<para>yCbCrPositioning</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#yCbCrPositioning">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#yCbCrPositioning</seealso>
    let yCbCrPositioning = Prefixed_Name(nexif, "yCbCrPositioning") |> PrefixedName
    /// <summary>
    ///   <para>nexif:yCbCrSubSampling</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The sampling ratio of chrominance components in relation to the luminance component. In JPEG compressed data a JPEG marker is used instead of this tag.
    /// tagNumber: 530</para>
    /// labels<para>yCbCrSubSampling</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#yCbCrSubSampling">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#yCbCrSubSampling</seealso>
    let yCbCrSubSampling = Prefixed_Name(nexif, "yCbCrSubSampling") |> PrefixedName
    /// <summary>
    ///   <para>nexif:yResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>tagNumber: 283
    /// The number of pixels per ResolutionUnit in the ImageLength direction. The same value as XResolution is designated.</para>
    /// labels<para>yResolution</para></remarks>
    /// <seealso href="http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#yResolution">http://www.semanticdesktop.org/ontologies/2007/05/10/nexif#yResolution</seealso>
    let yResolution = Prefixed_Name(nexif, "yResolution") |> PrefixedName
