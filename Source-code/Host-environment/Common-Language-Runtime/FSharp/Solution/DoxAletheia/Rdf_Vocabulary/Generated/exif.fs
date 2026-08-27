namespace http.www.kanzaki.com.ns.exif.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module exif =
    let _namespace_iri = Namespace_Iri exif |> NamespaceIRI
    /// <summary>
    ///   <para>exif:IFD</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#IFD">http://www.kanzaki.com/ns/exif#IFD</seealso>
    let IFD = Prefixed_Name(exif, "IFD") |> PrefixedName
    /// <summary>
    ///   <para>exif:_unknown</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#_unknown">http://www.kanzaki.com/ns/exif#_unknown</seealso>
    let _unknown = Prefixed_Name(exif, "_unknown") |> PrefixedName
    /// <summary>
    ///   <para>exif:apertureValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#apertureValue">http://www.kanzaki.com/ns/exif#apertureValue</seealso>
    let apertureValue = Prefixed_Name(exif, "apertureValue") |> PrefixedName
    /// <summary>
    ///   <para>exif:artist</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#artist">http://www.kanzaki.com/ns/exif#artist</seealso>
    let artist = Prefixed_Name(exif, "artist") |> PrefixedName
    /// <summary>
    ///   <para>exif:bitsPerSample</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#bitsPerSample">http://www.kanzaki.com/ns/exif#bitsPerSample</seealso>
    let bitsPerSample = Prefixed_Name(exif, "bitsPerSample") |> PrefixedName
    /// <summary>
    ///   <para>exif:brightnessValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#brightnessValue">http://www.kanzaki.com/ns/exif#brightnessValue</seealso>
    let brightnessValue = Prefixed_Name(exif, "brightnessValue") |> PrefixedName
    /// <summary>
    ///   <para>exif:cfaPattern</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#cfaPattern">http://www.kanzaki.com/ns/exif#cfaPattern</seealso>
    let cfaPattern = Prefixed_Name(exif, "cfaPattern") |> PrefixedName
    /// <summary>
    ///   <para>exif:colorSpace</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#colorSpace">http://www.kanzaki.com/ns/exif#colorSpace</seealso>
    let colorSpace = Prefixed_Name(exif, "colorSpace") |> PrefixedName

    /// <summary>
    ///   <para>exif:componentsConfiguration</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#componentsConfiguration">http://www.kanzaki.com/ns/exif#componentsConfiguration</seealso>
    let componentsConfiguration =
        Prefixed_Name(exif, "componentsConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>exif:compressedBitsPerPixel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#compressedBitsPerPixel">http://www.kanzaki.com/ns/exif#compressedBitsPerPixel</seealso>
    let compressedBitsPerPixel =
        Prefixed_Name(exif, "compressedBitsPerPixel") |> PrefixedName

    /// <summary>
    ///   <para>exif:compression</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#compression">http://www.kanzaki.com/ns/exif#compression</seealso>
    let compression = Prefixed_Name(exif, "compression") |> PrefixedName
    /// <summary>
    ///   <para>exif:contrast</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#contrast">http://www.kanzaki.com/ns/exif#contrast</seealso>
    let contrast = Prefixed_Name(exif, "contrast") |> PrefixedName
    /// <summary>
    ///   <para>exif:copyright</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#copyright">http://www.kanzaki.com/ns/exif#copyright</seealso>
    let copyright = Prefixed_Name(exif, "copyright") |> PrefixedName
    /// <summary>
    ///   <para>exif:customRendered</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#customRendered">http://www.kanzaki.com/ns/exif#customRendered</seealso>
    let customRendered = Prefixed_Name(exif, "customRendered") |> PrefixedName
    /// <summary>
    ///   <para>exif:datatype</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#datatype">http://www.kanzaki.com/ns/exif#datatype</seealso>
    let datatype = Prefixed_Name(exif, "datatype") |> PrefixedName
    /// <summary>
    ///   <para>exif:date</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#date">http://www.kanzaki.com/ns/exif#date</seealso>
    let date = Prefixed_Name(exif, "date") |> PrefixedName
    /// <summary>
    ///   <para>exif:dateAndOrTime</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#dateAndOrTime">http://www.kanzaki.com/ns/exif#dateAndOrTime</seealso>
    let dateAndOrTime = Prefixed_Name(exif, "dateAndOrTime") |> PrefixedName
    /// <summary>
    ///   <para>exif:dateTime</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#dateTime">http://www.kanzaki.com/ns/exif#dateTime</seealso>
    let dateTime = Prefixed_Name(exif, "dateTime") |> PrefixedName
    /// <summary>
    ///   <para>exif:dateTimeDigitized</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#dateTimeDigitized">http://www.kanzaki.com/ns/exif#dateTimeDigitized</seealso>
    let dateTimeDigitized = Prefixed_Name(exif, "dateTimeDigitized") |> PrefixedName
    /// <summary>
    ///   <para>exif:dateTimeOriginal</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#dateTimeOriginal">http://www.kanzaki.com/ns/exif#dateTimeOriginal</seealso>
    let dateTimeOriginal = Prefixed_Name(exif, "dateTimeOriginal") |> PrefixedName

    /// <summary>
    ///   <para>exif:deviceSettingDescription</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#deviceSettingDescription">http://www.kanzaki.com/ns/exif#deviceSettingDescription</seealso>
    let deviceSettingDescription =
        Prefixed_Name(exif, "deviceSettingDescription") |> PrefixedName

    /// <summary>
    ///   <para>exif:digitalZoomRatio</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#digitalZoomRatio">http://www.kanzaki.com/ns/exif#digitalZoomRatio</seealso>
    let digitalZoomRatio = Prefixed_Name(exif, "digitalZoomRatio") |> PrefixedName
    /// <summary>
    ///   <para>exif:exifAttribute</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#exifAttribute">http://www.kanzaki.com/ns/exif#exifAttribute</seealso>
    let exifAttribute = Prefixed_Name(exif, "exifAttribute") |> PrefixedName
    /// <summary>
    ///   <para>exif:exifVersion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#exifVersion">http://www.kanzaki.com/ns/exif#exifVersion</seealso>
    let exifVersion = Prefixed_Name(exif, "exifVersion") |> PrefixedName
    /// <summary>
    ///   <para>exif:exif_IFD_Pointer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#exif_IFD_Pointer">http://www.kanzaki.com/ns/exif#exif_IFD_Pointer</seealso>
    let exif_IFD_Pointer = Prefixed_Name(exif, "exif_IFD_Pointer") |> PrefixedName
    /// <summary>
    ///   <para>exif:exifdata</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#exifdata">http://www.kanzaki.com/ns/exif#exifdata</seealso>
    let exifdata = Prefixed_Name(exif, "exifdata") |> PrefixedName
    /// <summary>
    ///   <para>exif:exposureBiasValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#exposureBiasValue">http://www.kanzaki.com/ns/exif#exposureBiasValue</seealso>
    let exposureBiasValue = Prefixed_Name(exif, "exposureBiasValue") |> PrefixedName
    /// <summary>
    ///   <para>exif:exposureIndex</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#exposureIndex">http://www.kanzaki.com/ns/exif#exposureIndex</seealso>
    let exposureIndex = Prefixed_Name(exif, "exposureIndex") |> PrefixedName
    /// <summary>
    ///   <para>exif:exposureMode</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#exposureMode">http://www.kanzaki.com/ns/exif#exposureMode</seealso>
    let exposureMode = Prefixed_Name(exif, "exposureMode") |> PrefixedName
    /// <summary>
    ///   <para>exif:exposureProgram</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#exposureProgram">http://www.kanzaki.com/ns/exif#exposureProgram</seealso>
    let exposureProgram = Prefixed_Name(exif, "exposureProgram") |> PrefixedName
    /// <summary>
    ///   <para>exif:exposureTime</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#exposureTime">http://www.kanzaki.com/ns/exif#exposureTime</seealso>
    let exposureTime = Prefixed_Name(exif, "exposureTime") |> PrefixedName
    /// <summary>
    ///   <para>exif:fNumber</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#fNumber">http://www.kanzaki.com/ns/exif#fNumber</seealso>
    let fNumber = Prefixed_Name(exif, "fNumber") |> PrefixedName
    /// <summary>
    ///   <para>exif:fileSource</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#fileSource">http://www.kanzaki.com/ns/exif#fileSource</seealso>
    let fileSource = Prefixed_Name(exif, "fileSource") |> PrefixedName
    /// <summary>
    ///   <para>exif:flash</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#flash">http://www.kanzaki.com/ns/exif#flash</seealso>
    let flash = Prefixed_Name(exif, "flash") |> PrefixedName
    /// <summary>
    ///   <para>exif:flashEnergy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#flashEnergy">http://www.kanzaki.com/ns/exif#flashEnergy</seealso>
    let flashEnergy = Prefixed_Name(exif, "flashEnergy") |> PrefixedName
    /// <summary>
    ///   <para>exif:flashpixVersion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#flashpixVersion">http://www.kanzaki.com/ns/exif#flashpixVersion</seealso>
    let flashpixVersion = Prefixed_Name(exif, "flashpixVersion") |> PrefixedName
    /// <summary>
    ///   <para>exif:focalLength</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#focalLength">http://www.kanzaki.com/ns/exif#focalLength</seealso>
    let focalLength = Prefixed_Name(exif, "focalLength") |> PrefixedName

    /// <summary>
    ///   <para>exif:focalLengthIn35mmFilm</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#focalLengthIn35mmFilm">http://www.kanzaki.com/ns/exif#focalLengthIn35mmFilm</seealso>
    let focalLengthIn35mmFilm =
        Prefixed_Name(exif, "focalLengthIn35mmFilm") |> PrefixedName

    /// <summary>
    ///   <para>exif:focalPlaneResolutionUnit</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#focalPlaneResolutionUnit">http://www.kanzaki.com/ns/exif#focalPlaneResolutionUnit</seealso>
    let focalPlaneResolutionUnit =
        Prefixed_Name(exif, "focalPlaneResolutionUnit") |> PrefixedName

    /// <summary>
    ///   <para>exif:focalPlaneXResolution</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#focalPlaneXResolution">http://www.kanzaki.com/ns/exif#focalPlaneXResolution</seealso>
    let focalPlaneXResolution =
        Prefixed_Name(exif, "focalPlaneXResolution") |> PrefixedName

    /// <summary>
    ///   <para>exif:focalPlaneYResolution</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#focalPlaneYResolution">http://www.kanzaki.com/ns/exif#focalPlaneYResolution</seealso>
    let focalPlaneYResolution =
        Prefixed_Name(exif, "focalPlaneYResolution") |> PrefixedName

    /// <summary>
    ///   <para>exif:gainControl</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gainControl">http://www.kanzaki.com/ns/exif#gainControl</seealso>
    let gainControl = Prefixed_Name(exif, "gainControl") |> PrefixedName
    /// <summary>
    ///   <para>exif:geo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#geo">http://www.kanzaki.com/ns/exif#geo</seealso>
    let geo = Prefixed_Name(exif, "geo") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsAltitudeRef</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsAltitudeRef">http://www.kanzaki.com/ns/exif#gpsAltitudeRef</seealso>
    let gpsAltitudeRef = Prefixed_Name(exif, "gpsAltitudeRef") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsAreaInformation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsAreaInformation">http://www.kanzaki.com/ns/exif#gpsAreaInformation</seealso>
    let gpsAreaInformation = Prefixed_Name(exif, "gpsAreaInformation") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsDOP</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsDOP">http://www.kanzaki.com/ns/exif#gpsDOP</seealso>
    let gpsDOP = Prefixed_Name(exif, "gpsDOP") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsDateStamp</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsDateStamp">http://www.kanzaki.com/ns/exif#gpsDateStamp</seealso>
    let gpsDateStamp = Prefixed_Name(exif, "gpsDateStamp") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsDestBearing</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsDestBearing">http://www.kanzaki.com/ns/exif#gpsDestBearing</seealso>
    let gpsDestBearing = Prefixed_Name(exif, "gpsDestBearing") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsDestBearingRef</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsDestBearingRef">http://www.kanzaki.com/ns/exif#gpsDestBearingRef</seealso>
    let gpsDestBearingRef = Prefixed_Name(exif, "gpsDestBearingRef") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsDestDistance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsDestDistance">http://www.kanzaki.com/ns/exif#gpsDestDistance</seealso>
    let gpsDestDistance = Prefixed_Name(exif, "gpsDestDistance") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsDestDistanceRef</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsDestDistanceRef">http://www.kanzaki.com/ns/exif#gpsDestDistanceRef</seealso>
    let gpsDestDistanceRef = Prefixed_Name(exif, "gpsDestDistanceRef") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsDestLatitudeRef</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsDestLatitudeRef">http://www.kanzaki.com/ns/exif#gpsDestLatitudeRef</seealso>
    let gpsDestLatitudeRef = Prefixed_Name(exif, "gpsDestLatitudeRef") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsDestLongitudeRef</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsDestLongitudeRef">http://www.kanzaki.com/ns/exif#gpsDestLongitudeRef</seealso>
    let gpsDestLongitudeRef = Prefixed_Name(exif, "gpsDestLongitudeRef") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsDifferential</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsDifferential">http://www.kanzaki.com/ns/exif#gpsDifferential</seealso>
    let gpsDifferential = Prefixed_Name(exif, "gpsDifferential") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsImgDirection</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsImgDirection">http://www.kanzaki.com/ns/exif#gpsImgDirection</seealso>
    let gpsImgDirection = Prefixed_Name(exif, "gpsImgDirection") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsImgDirectionRef</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsImgDirectionRef">http://www.kanzaki.com/ns/exif#gpsImgDirectionRef</seealso>
    let gpsImgDirectionRef = Prefixed_Name(exif, "gpsImgDirectionRef") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsInfo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsInfo">http://www.kanzaki.com/ns/exif#gpsInfo</seealso>
    let gpsInfo = Prefixed_Name(exif, "gpsInfo") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsInfo_IFD_Pointer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsInfo_IFD_Pointer">http://www.kanzaki.com/ns/exif#gpsInfo_IFD_Pointer</seealso>
    let gpsInfo_IFD_Pointer = Prefixed_Name(exif, "gpsInfo_IFD_Pointer") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsLatitudeRef</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsLatitudeRef">http://www.kanzaki.com/ns/exif#gpsLatitudeRef</seealso>
    let gpsLatitudeRef = Prefixed_Name(exif, "gpsLatitudeRef") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsLongitudeRef</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsLongitudeRef">http://www.kanzaki.com/ns/exif#gpsLongitudeRef</seealso>
    let gpsLongitudeRef = Prefixed_Name(exif, "gpsLongitudeRef") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsMapDatum</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsMapDatum">http://www.kanzaki.com/ns/exif#gpsMapDatum</seealso>
    let gpsMapDatum = Prefixed_Name(exif, "gpsMapDatum") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsMeasureMode</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsMeasureMode">http://www.kanzaki.com/ns/exif#gpsMeasureMode</seealso>
    let gpsMeasureMode = Prefixed_Name(exif, "gpsMeasureMode") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsProcessingMethod</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsProcessingMethod">http://www.kanzaki.com/ns/exif#gpsProcessingMethod</seealso>
    let gpsProcessingMethod = Prefixed_Name(exif, "gpsProcessingMethod") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsSatellites</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsSatellites">http://www.kanzaki.com/ns/exif#gpsSatellites</seealso>
    let gpsSatellites = Prefixed_Name(exif, "gpsSatellites") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsSpeed</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsSpeed">http://www.kanzaki.com/ns/exif#gpsSpeed</seealso>
    let gpsSpeed = Prefixed_Name(exif, "gpsSpeed") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsSpeedRef</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsSpeedRef">http://www.kanzaki.com/ns/exif#gpsSpeedRef</seealso>
    let gpsSpeedRef = Prefixed_Name(exif, "gpsSpeedRef") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsStatus</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsStatus">http://www.kanzaki.com/ns/exif#gpsStatus</seealso>
    let gpsStatus = Prefixed_Name(exif, "gpsStatus") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsTimeStamp</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsTimeStamp">http://www.kanzaki.com/ns/exif#gpsTimeStamp</seealso>
    let gpsTimeStamp = Prefixed_Name(exif, "gpsTimeStamp") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsTrack</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsTrack">http://www.kanzaki.com/ns/exif#gpsTrack</seealso>
    let gpsTrack = Prefixed_Name(exif, "gpsTrack") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsTrackRef</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsTrackRef">http://www.kanzaki.com/ns/exif#gpsTrackRef</seealso>
    let gpsTrackRef = Prefixed_Name(exif, "gpsTrackRef") |> PrefixedName
    /// <summary>
    ///   <para>exif:gpsVersionID</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#gpsVersionID">http://www.kanzaki.com/ns/exif#gpsVersionID</seealso>
    let gpsVersionID = Prefixed_Name(exif, "gpsVersionID") |> PrefixedName
    /// <summary>
    ///   <para>exif:height</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#height">http://www.kanzaki.com/ns/exif#height</seealso>
    let height = Prefixed_Name(exif, "height") |> PrefixedName
    /// <summary>
    ///   <para>exif:ifdPointer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#ifdPointer">http://www.kanzaki.com/ns/exif#ifdPointer</seealso>
    let ifdPointer = Prefixed_Name(exif, "ifdPointer") |> PrefixedName
    /// <summary>
    ///   <para>exif:imageConfig</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#imageConfig">http://www.kanzaki.com/ns/exif#imageConfig</seealso>
    let imageConfig = Prefixed_Name(exif, "imageConfig") |> PrefixedName
    /// <summary>
    ///   <para>exif:imageDataCharacter</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#imageDataCharacter">http://www.kanzaki.com/ns/exif#imageDataCharacter</seealso>
    let imageDataCharacter = Prefixed_Name(exif, "imageDataCharacter") |> PrefixedName
    /// <summary>
    ///   <para>exif:imageDataStruct</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#imageDataStruct">http://www.kanzaki.com/ns/exif#imageDataStruct</seealso>
    let imageDataStruct = Prefixed_Name(exif, "imageDataStruct") |> PrefixedName
    /// <summary>
    ///   <para>exif:imageDescription</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#imageDescription">http://www.kanzaki.com/ns/exif#imageDescription</seealso>
    let imageDescription = Prefixed_Name(exif, "imageDescription") |> PrefixedName
    /// <summary>
    ///   <para>exif:imageLength</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#imageLength">http://www.kanzaki.com/ns/exif#imageLength</seealso>
    let imageLength = Prefixed_Name(exif, "imageLength") |> PrefixedName
    /// <summary>
    ///   <para>exif:imageUniqueID</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#imageUniqueID">http://www.kanzaki.com/ns/exif#imageUniqueID</seealso>
    let imageUniqueID = Prefixed_Name(exif, "imageUniqueID") |> PrefixedName
    /// <summary>
    ///   <para>exif:imageWidth</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#imageWidth">http://www.kanzaki.com/ns/exif#imageWidth</seealso>
    let imageWidth = Prefixed_Name(exif, "imageWidth") |> PrefixedName
    /// <summary>
    ///   <para>exif:interopInfo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#interopInfo">http://www.kanzaki.com/ns/exif#interopInfo</seealso>
    let interopInfo = Prefixed_Name(exif, "interopInfo") |> PrefixedName

    /// <summary>
    ///   <para>exif:interoperabilityIndex</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#interoperabilityIndex">http://www.kanzaki.com/ns/exif#interoperabilityIndex</seealso>
    let interoperabilityIndex =
        Prefixed_Name(exif, "interoperabilityIndex") |> PrefixedName

    /// <summary>
    ///   <para>exif:interoperabilityVersion</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#interoperabilityVersion">http://www.kanzaki.com/ns/exif#interoperabilityVersion</seealso>
    let interoperabilityVersion =
        Prefixed_Name(exif, "interoperabilityVersion") |> PrefixedName

    /// <summary>
    ///   <para>exif:interoperability_IFD_Pointer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#interoperability_IFD_Pointer">http://www.kanzaki.com/ns/exif#interoperability_IFD_Pointer</seealso>
    let interoperability_IFD_Pointer =
        Prefixed_Name(exif, "interoperability_IFD_Pointer") |> PrefixedName

    /// <summary>
    ///   <para>exif:isoSpeedRatings</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#isoSpeedRatings">http://www.kanzaki.com/ns/exif#isoSpeedRatings</seealso>
    let isoSpeedRatings = Prefixed_Name(exif, "isoSpeedRatings") |> PrefixedName

    /// <summary>
    ///   <para>exif:jpegInterchangeFormat</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#jpegInterchangeFormat">http://www.kanzaki.com/ns/exif#jpegInterchangeFormat</seealso>
    let jpegInterchangeFormat =
        Prefixed_Name(exif, "jpegInterchangeFormat") |> PrefixedName

    /// <summary>
    ///   <para>exif:jpegInterchangeFormatLength</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#jpegInterchangeFormatLength">http://www.kanzaki.com/ns/exif#jpegInterchangeFormatLength</seealso>
    let jpegInterchangeFormatLength =
        Prefixed_Name(exif, "jpegInterchangeFormatLength") |> PrefixedName

    /// <summary>
    ///   <para>exif:length</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#length">http://www.kanzaki.com/ns/exif#length</seealso>
    let length = Prefixed_Name(exif, "length") |> PrefixedName
    /// <summary>
    ///   <para>exif:lightSource</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#lightSource">http://www.kanzaki.com/ns/exif#lightSource</seealso>
    let lightSource = Prefixed_Name(exif, "lightSource") |> PrefixedName
    /// <summary>
    ///   <para>exif:make</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#make">http://www.kanzaki.com/ns/exif#make</seealso>
    let make = Prefixed_Name(exif, "make") |> PrefixedName
    /// <summary>
    ///   <para>exif:makerNote</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#makerNote">http://www.kanzaki.com/ns/exif#makerNote</seealso>
    let makerNote = Prefixed_Name(exif, "makerNote") |> PrefixedName
    /// <summary>
    ///   <para>exif:maxApertureValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#maxApertureValue">http://www.kanzaki.com/ns/exif#maxApertureValue</seealso>
    let maxApertureValue = Prefixed_Name(exif, "maxApertureValue") |> PrefixedName
    /// <summary>
    ///   <para>exif:meter</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#meter">http://www.kanzaki.com/ns/exif#meter</seealso>
    let meter = Prefixed_Name(exif, "meter") |> PrefixedName
    /// <summary>
    ///   <para>exif:meteringMode</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#meteringMode">http://www.kanzaki.com/ns/exif#meteringMode</seealso>
    let meteringMode = Prefixed_Name(exif, "meteringMode") |> PrefixedName
    /// <summary>
    ///   <para>exif:mm</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#mm">http://www.kanzaki.com/ns/exif#mm</seealso>
    let mm = Prefixed_Name(exif, "mm") |> PrefixedName
    /// <summary>
    ///   <para>exif:model</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#model">http://www.kanzaki.com/ns/exif#model</seealso>
    let model = Prefixed_Name(exif, "model") |> PrefixedName
    /// <summary>
    ///   <para>exif:oecf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#oecf">http://www.kanzaki.com/ns/exif#oecf</seealso>
    let oecf = Prefixed_Name(exif, "oecf") |> PrefixedName
    /// <summary>
    ///   <para>exif:orientation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#orientation">http://www.kanzaki.com/ns/exif#orientation</seealso>
    let orientation = Prefixed_Name(exif, "orientation") |> PrefixedName

    /// <summary>
    ///   <para>exif:photometricInterpretation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#photometricInterpretation">http://www.kanzaki.com/ns/exif#photometricInterpretation</seealso>
    let photometricInterpretation =
        Prefixed_Name(exif, "photometricInterpretation") |> PrefixedName

    /// <summary>
    ///   <para>exif:pictTaking</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#pictTaking">http://www.kanzaki.com/ns/exif#pictTaking</seealso>
    let pictTaking = Prefixed_Name(exif, "pictTaking") |> PrefixedName
    /// <summary>
    ///   <para>exif:pimBrightness</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#pimBrightness">http://www.kanzaki.com/ns/exif#pimBrightness</seealso>
    let pimBrightness = Prefixed_Name(exif, "pimBrightness") |> PrefixedName
    /// <summary>
    ///   <para>exif:pimColorBalance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#pimColorBalance">http://www.kanzaki.com/ns/exif#pimColorBalance</seealso>
    let pimColorBalance = Prefixed_Name(exif, "pimColorBalance") |> PrefixedName
    /// <summary>
    ///   <para>exif:pimContrast</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#pimContrast">http://www.kanzaki.com/ns/exif#pimContrast</seealso>
    let pimContrast = Prefixed_Name(exif, "pimContrast") |> PrefixedName
    /// <summary>
    ///   <para>exif:pimInfo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#pimInfo">http://www.kanzaki.com/ns/exif#pimInfo</seealso>
    let pimInfo = Prefixed_Name(exif, "pimInfo") |> PrefixedName
    /// <summary>
    ///   <para>exif:pimSaturation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#pimSaturation">http://www.kanzaki.com/ns/exif#pimSaturation</seealso>
    let pimSaturation = Prefixed_Name(exif, "pimSaturation") |> PrefixedName
    /// <summary>
    ///   <para>exif:pimSharpness</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#pimSharpness">http://www.kanzaki.com/ns/exif#pimSharpness</seealso>
    let pimSharpness = Prefixed_Name(exif, "pimSharpness") |> PrefixedName
    /// <summary>
    ///   <para>exif:pixelXDimension</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#pixelXDimension">http://www.kanzaki.com/ns/exif#pixelXDimension</seealso>
    let pixelXDimension = Prefixed_Name(exif, "pixelXDimension") |> PrefixedName
    /// <summary>
    ///   <para>exif:pixelYDimension</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#pixelYDimension">http://www.kanzaki.com/ns/exif#pixelYDimension</seealso>
    let pixelYDimension = Prefixed_Name(exif, "pixelYDimension") |> PrefixedName
    /// <summary>
    ///   <para>exif:planarConfiguration</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#planarConfiguration">http://www.kanzaki.com/ns/exif#planarConfiguration</seealso>
    let planarConfiguration = Prefixed_Name(exif, "planarConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>exif:primaryChromaticities</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#primaryChromaticities">http://www.kanzaki.com/ns/exif#primaryChromaticities</seealso>
    let primaryChromaticities =
        Prefixed_Name(exif, "primaryChromaticities") |> PrefixedName

    /// <summary>
    ///   <para>exif:printImageMatching_IFD_Pointer</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#printImageMatching_IFD_Pointer">http://www.kanzaki.com/ns/exif#printImageMatching_IFD_Pointer</seealso>
    let printImageMatching_IFD_Pointer =
        Prefixed_Name(exif, "printImageMatching_IFD_Pointer") |> PrefixedName

    /// <summary>
    ///   <para>exif:recOffset</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#recOffset">http://www.kanzaki.com/ns/exif#recOffset</seealso>
    let recOffset = Prefixed_Name(exif, "recOffset") |> PrefixedName
    /// <summary>
    ///   <para>exif:referenceBlackWhite</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#referenceBlackWhite">http://www.kanzaki.com/ns/exif#referenceBlackWhite</seealso>
    let referenceBlackWhite = Prefixed_Name(exif, "referenceBlackWhite") |> PrefixedName
    /// <summary>
    ///   <para>exif:relatedFile</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#relatedFile">http://www.kanzaki.com/ns/exif#relatedFile</seealso>
    let relatedFile = Prefixed_Name(exif, "relatedFile") |> PrefixedName

    /// <summary>
    ///   <para>exif:relatedImageFileFormat</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#relatedImageFileFormat">http://www.kanzaki.com/ns/exif#relatedImageFileFormat</seealso>
    let relatedImageFileFormat =
        Prefixed_Name(exif, "relatedImageFileFormat") |> PrefixedName

    /// <summary>
    ///   <para>exif:relatedImageLength</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#relatedImageLength">http://www.kanzaki.com/ns/exif#relatedImageLength</seealso>
    let relatedImageLength = Prefixed_Name(exif, "relatedImageLength") |> PrefixedName
    /// <summary>
    ///   <para>exif:relatedImageWidth</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#relatedImageWidth">http://www.kanzaki.com/ns/exif#relatedImageWidth</seealso>
    let relatedImageWidth = Prefixed_Name(exif, "relatedImageWidth") |> PrefixedName
    /// <summary>
    ///   <para>exif:relatedSoundFile</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#relatedSoundFile">http://www.kanzaki.com/ns/exif#relatedSoundFile</seealso>
    let relatedSoundFile = Prefixed_Name(exif, "relatedSoundFile") |> PrefixedName
    /// <summary>
    ///   <para>exif:resolution</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#resolution">http://www.kanzaki.com/ns/exif#resolution</seealso>
    let resolution = Prefixed_Name(exif, "resolution") |> PrefixedName
    /// <summary>
    ///   <para>exif:resolutionUnit</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#resolutionUnit">http://www.kanzaki.com/ns/exif#resolutionUnit</seealso>
    let resolutionUnit = Prefixed_Name(exif, "resolutionUnit") |> PrefixedName
    /// <summary>
    ///   <para>exif:rowsPerStrip</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#rowsPerStrip">http://www.kanzaki.com/ns/exif#rowsPerStrip</seealso>
    let rowsPerStrip = Prefixed_Name(exif, "rowsPerStrip") |> PrefixedName
    /// <summary>
    ///   <para>exif:samplesPerPixel</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#samplesPerPixel">http://www.kanzaki.com/ns/exif#samplesPerPixel</seealso>
    let samplesPerPixel = Prefixed_Name(exif, "samplesPerPixel") |> PrefixedName
    /// <summary>
    ///   <para>exif:saturation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#saturation">http://www.kanzaki.com/ns/exif#saturation</seealso>
    let saturation = Prefixed_Name(exif, "saturation") |> PrefixedName
    /// <summary>
    ///   <para>exif:sceneCaptureType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#sceneCaptureType">http://www.kanzaki.com/ns/exif#sceneCaptureType</seealso>
    let sceneCaptureType = Prefixed_Name(exif, "sceneCaptureType") |> PrefixedName
    /// <summary>
    ///   <para>exif:sceneType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#sceneType">http://www.kanzaki.com/ns/exif#sceneType</seealso>
    let sceneType = Prefixed_Name(exif, "sceneType") |> PrefixedName
    /// <summary>
    ///   <para>exif:seconds</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#seconds">http://www.kanzaki.com/ns/exif#seconds</seealso>
    let seconds = Prefixed_Name(exif, "seconds") |> PrefixedName
    /// <summary>
    ///   <para>exif:sensingMethod</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#sensingMethod">http://www.kanzaki.com/ns/exif#sensingMethod</seealso>
    let sensingMethod = Prefixed_Name(exif, "sensingMethod") |> PrefixedName
    /// <summary>
    ///   <para>exif:sharpness</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#sharpness">http://www.kanzaki.com/ns/exif#sharpness</seealso>
    let sharpness = Prefixed_Name(exif, "sharpness") |> PrefixedName
    /// <summary>
    ///   <para>exif:shutterSpeedValue</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#shutterSpeedValue">http://www.kanzaki.com/ns/exif#shutterSpeedValue</seealso>
    let shutterSpeedValue = Prefixed_Name(exif, "shutterSpeedValue") |> PrefixedName
    /// <summary>
    ///   <para>exif:software</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#software">http://www.kanzaki.com/ns/exif#software</seealso>
    let software = Prefixed_Name(exif, "software") |> PrefixedName

    /// <summary>
    ///   <para>exif:spatialFrequencyResponse</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#spatialFrequencyResponse">http://www.kanzaki.com/ns/exif#spatialFrequencyResponse</seealso>
    let spatialFrequencyResponse =
        Prefixed_Name(exif, "spatialFrequencyResponse") |> PrefixedName

    /// <summary>
    ///   <para>exif:spectralSensitivity</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#spectralSensitivity">http://www.kanzaki.com/ns/exif#spectralSensitivity</seealso>
    let spectralSensitivity = Prefixed_Name(exif, "spectralSensitivity") |> PrefixedName
    /// <summary>
    ///   <para>exif:stripByteCounts</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#stripByteCounts">http://www.kanzaki.com/ns/exif#stripByteCounts</seealso>
    let stripByteCounts = Prefixed_Name(exif, "stripByteCounts") |> PrefixedName
    /// <summary>
    ///   <para>exif:stripOffsets</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#stripOffsets">http://www.kanzaki.com/ns/exif#stripOffsets</seealso>
    let stripOffsets = Prefixed_Name(exif, "stripOffsets") |> PrefixedName
    /// <summary>
    ///   <para>exif:subSecTime</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#subSecTime">http://www.kanzaki.com/ns/exif#subSecTime</seealso>
    let subSecTime = Prefixed_Name(exif, "subSecTime") |> PrefixedName
    /// <summary>
    ///   <para>exif:subSecTimeDigitized</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#subSecTimeDigitized">http://www.kanzaki.com/ns/exif#subSecTimeDigitized</seealso>
    let subSecTimeDigitized = Prefixed_Name(exif, "subSecTimeDigitized") |> PrefixedName
    /// <summary>
    ///   <para>exif:subSecTimeOriginal</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#subSecTimeOriginal">http://www.kanzaki.com/ns/exif#subSecTimeOriginal</seealso>
    let subSecTimeOriginal = Prefixed_Name(exif, "subSecTimeOriginal") |> PrefixedName
    /// <summary>
    ///   <para>exif:subjectArea</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#subjectArea">http://www.kanzaki.com/ns/exif#subjectArea</seealso>
    let subjectArea = Prefixed_Name(exif, "subjectArea") |> PrefixedName
    /// <summary>
    ///   <para>exif:subjectDistance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#subjectDistance">http://www.kanzaki.com/ns/exif#subjectDistance</seealso>
    let subjectDistance = Prefixed_Name(exif, "subjectDistance") |> PrefixedName

    /// <summary>
    ///   <para>exif:subjectDistanceRange</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#subjectDistanceRange">http://www.kanzaki.com/ns/exif#subjectDistanceRange</seealso>
    let subjectDistanceRange =
        Prefixed_Name(exif, "subjectDistanceRange") |> PrefixedName

    /// <summary>
    ///   <para>exif:subjectLocation</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#subjectLocation">http://www.kanzaki.com/ns/exif#subjectLocation</seealso>
    let subjectLocation = Prefixed_Name(exif, "subjectLocation") |> PrefixedName
    /// <summary>
    ///   <para>exif:subseconds</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#subseconds">http://www.kanzaki.com/ns/exif#subseconds</seealso>
    let subseconds = Prefixed_Name(exif, "subseconds") |> PrefixedName
    /// <summary>
    ///   <para>exif:tag_number</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#tag_number">http://www.kanzaki.com/ns/exif#tag_number</seealso>
    let tag_number = Prefixed_Name(exif, "tag_number") |> PrefixedName
    /// <summary>
    ///   <para>exif:tagid</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#tagid">http://www.kanzaki.com/ns/exif#tagid</seealso>
    let tagid = Prefixed_Name(exif, "tagid") |> PrefixedName
    /// <summary>
    ///   <para>exif:transferFunction</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#transferFunction">http://www.kanzaki.com/ns/exif#transferFunction</seealso>
    let transferFunction = Prefixed_Name(exif, "transferFunction") |> PrefixedName
    /// <summary>
    ///   <para>exif:userComment</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#userComment">http://www.kanzaki.com/ns/exif#userComment</seealso>
    let userComment = Prefixed_Name(exif, "userComment") |> PrefixedName
    /// <summary>
    ///   <para>exif:userInfo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#userInfo">http://www.kanzaki.com/ns/exif#userInfo</seealso>
    let userInfo = Prefixed_Name(exif, "userInfo") |> PrefixedName
    /// <summary>
    ///   <para>exif:versionInfo</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#versionInfo">http://www.kanzaki.com/ns/exif#versionInfo</seealso>
    let versionInfo = Prefixed_Name(exif, "versionInfo") |> PrefixedName
    /// <summary>
    ///   <para>exif:whiteBalance</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#whiteBalance">http://www.kanzaki.com/ns/exif#whiteBalance</seealso>
    let whiteBalance = Prefixed_Name(exif, "whiteBalance") |> PrefixedName
    /// <summary>
    ///   <para>exif:whitePoint</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#whitePoint">http://www.kanzaki.com/ns/exif#whitePoint</seealso>
    let whitePoint = Prefixed_Name(exif, "whitePoint") |> PrefixedName
    /// <summary>
    ///   <para>exif:width</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#width">http://www.kanzaki.com/ns/exif#width</seealso>
    let width = Prefixed_Name(exif, "width") |> PrefixedName
    /// <summary>
    ///   <para>exif:xResolution</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#xResolution">http://www.kanzaki.com/ns/exif#xResolution</seealso>
    let xResolution = Prefixed_Name(exif, "xResolution") |> PrefixedName
    /// <summary>
    ///   <para>exif:yCbCrCoefficients</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#yCbCrCoefficients">http://www.kanzaki.com/ns/exif#yCbCrCoefficients</seealso>
    let yCbCrCoefficients = Prefixed_Name(exif, "yCbCrCoefficients") |> PrefixedName
    /// <summary>
    ///   <para>exif:yCbCrPositioning</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#yCbCrPositioning">http://www.kanzaki.com/ns/exif#yCbCrPositioning</seealso>
    let yCbCrPositioning = Prefixed_Name(exif, "yCbCrPositioning") |> PrefixedName
    /// <summary>
    ///   <para>exif:yCbCrSubSampling</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#yCbCrSubSampling">http://www.kanzaki.com/ns/exif#yCbCrSubSampling</seealso>
    let yCbCrSubSampling = Prefixed_Name(exif, "yCbCrSubSampling") |> PrefixedName
    /// <summary>
    ///   <para>exif:yResolution</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.kanzaki.com/ns/exif#yResolution">http://www.kanzaki.com/ns/exif#yResolution</seealso>
    let yResolution = Prefixed_Name(exif, "yResolution") |> PrefixedName
