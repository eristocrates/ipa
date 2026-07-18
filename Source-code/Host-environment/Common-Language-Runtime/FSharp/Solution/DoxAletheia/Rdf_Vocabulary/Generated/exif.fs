namespace http.www.w3.org._2003._12.exif.ns.hash

open DoxAletheia.Rdf_Vocabulary

module exif =
    let _namespace_name = "http://www.w3.org/2003/12/exif/ns#"
    /// <summary>
    /// An Image File Directory
    /// <see href="http://www.w3.org/2003/12/exif/ns#IFD"></see></summary>
    let IFD = Namespaced_IRI.parse _namespace_name "IFD" |> NamespacedName
    /// <summary>
    /// An Exif tag whose meaning is not known
    /// <see href="http://www.w3.org/2003/12/exif/ns#_unknown"></see></summary>
    let _unknown = Namespaced_IRI.parse _namespace_name "_unknown" |> NamespacedName

    /// <summary>
    /// The lens aperture. The unit is the APEX value.
    /// <see href="http://www.w3.org/2003/12/exif/ns#apertureValue"></see></summary>
    let apertureValue =
        Namespaced_IRI.parse _namespace_name "apertureValue" |> NamespacedName

    /// <summary>
    /// An attribute relating to Picture-Taking Conditions
    /// <see href="http://www.w3.org/2003/12/exif/ns#pictTaking"></see></summary>
    let pictTaking = Namespaced_IRI.parse _namespace_name "pictTaking" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2003/12/exif/ns#tagNumber"></see>
    /// </summary>
    let tagNumber = Namespaced_IRI.parse _namespace_name "tagNumber" |> NamespacedName
    /// <summary>
    /// Person who created the image
    /// <see href="http://www.w3.org/2003/12/exif/ns#artist"></see></summary>
    let artist = Namespaced_IRI.parse _namespace_name "artist" |> NamespacedName

    /// <summary>
    /// A property that connects an IFD to one of its entries. Super property which integrates all Exif tags.
    /// <see href="http://www.w3.org/2003/12/exif/ns#exifAttribute"></see></summary>
    let exifAttribute =
        Namespaced_IRI.parse _namespace_name "exifAttribute" |> NamespacedName

    /// <summary>
    /// The number of bits per image component. In this standard each component of the image is 8 bits, so the value for this tag is 8. See also SamplesPerPixel. In JPEG compressed data a JPEG marker is used instead of this tag.
    /// <see href="http://www.w3.org/2003/12/exif/ns#bitsPerSample"></see></summary>
    let bitsPerSample =
        Namespaced_IRI.parse _namespace_name "bitsPerSample" |> NamespacedName

    /// <summary>
    /// An attribute relating to image data structure
    /// <see href="http://www.w3.org/2003/12/exif/ns#imageDataStruct"></see></summary>
    let imageDataStruct =
        Namespaced_IRI.parse _namespace_name "imageDataStruct" |> NamespacedName

    /// <summary>
    /// a rational number representing a resolution. Could be a subProperty of other general schema.
    /// <see href="http://www.w3.org/2003/12/exif/ns#resolution"></see></summary>
    let resolution = Namespaced_IRI.parse _namespace_name "resolution" |> NamespacedName

    /// <summary>
    /// The value of brightness. The unit is the APEX value. Ordinarily it is given in the range of -99.99 to 99.99. Note that if the numerator of the recorded value is FFFFFFFF.H, Unknown shall be indicated.
    /// <see href="http://www.w3.org/2003/12/exif/ns#brightnessValue"></see></summary>
    let brightnessValue =
        Namespaced_IRI.parse _namespace_name "brightnessValue" |> NamespacedName

    /// <summary>
    /// The color filter array (CFA) geometric pattern of the image sensor when a one-chip color area sensor is used. It does not apply to all sensing methods.
    /// <see href="http://www.w3.org/2003/12/exif/ns#cfaPattern"></see></summary>
    let cfaPattern = Namespaced_IRI.parse _namespace_name "cfaPattern" |> NamespacedName
    /// <summary>
    /// The color space information tag (ColorSpace) is always recorded as the color space specifier. Normally sRGB (=1) is used to define the color space based on the PC monitor conditions and environment.
    /// <see href="http://www.w3.org/2003/12/exif/ns#colorSpace"></see></summary>
    let colorSpace = Namespaced_IRI.parse _namespace_name "colorSpace" |> NamespacedName

    /// <summary>
    /// An attribute relating to image data characteristics
    /// <see href="http://www.w3.org/2003/12/exif/ns#imageDataCharacter"></see></summary>
    let imageDataCharacter =
        Namespaced_IRI.parse _namespace_name "imageDataCharacter" |> NamespacedName

    /// <summary>
    /// Information specific to compressed data. The channels of each component are arranged in order from the 1st component to the 4th. For uncompressed data the data arrangement is given in the PhotometricInterpretation tag. However, since PhotometricInterpretation can only express the order of Y,Cb and Cr, this tag is provided for cases when compressed data uses components other than Y, Cb, and Cr and to enable support of other sequences.
    /// <see href="http://www.w3.org/2003/12/exif/ns#componentsConfiguration"></see></summary>
    let componentsConfiguration =
        Namespaced_IRI.parse _namespace_name "componentsConfiguration" |> NamespacedName

    /// <summary>
    /// An attribute relating to Image Configuration
    /// <see href="http://www.w3.org/2003/12/exif/ns#imageConfig"></see></summary>
    let imageConfig =
        Namespaced_IRI.parse _namespace_name "imageConfig" |> NamespacedName

    /// <summary>
    /// Information specific to compressed data. The compression mode used for a compressed image is indicated in unit bits per pixel.
    /// <see href="http://www.w3.org/2003/12/exif/ns#compressedBitsPerPixel"></see></summary>
    let compressedBitsPerPixel =
        Namespaced_IRI.parse _namespace_name "compressedBitsPerPixel" |> NamespacedName

    /// <summary>
    /// The compression scheme used for the image data. When a primary image is JPEG compressed, this designation is not necessary and is omitted. When thumbnails use JPEG compression, this tag value is set to 6.
    /// <see href="http://www.w3.org/2003/12/exif/ns#compression"></see></summary>
    let compression =
        Namespaced_IRI.parse _namespace_name "compression" |> NamespacedName

    /// <summary>
    /// The direction of contrast processing applied by the camera when the image was shot.
    /// <see href="http://www.w3.org/2003/12/exif/ns#contrast"></see></summary>
    let contrast = Namespaced_IRI.parse _namespace_name "contrast" |> NamespacedName
    /// <summary>
    /// Copyright information. In this standard the tag is used to indicate both the photographer and editor copyrights. It is the copyright notice of the person or organization claiming rights to the image.
    /// <see href="http://www.w3.org/2003/12/exif/ns#copyright"></see></summary>
    let copyright = Namespaced_IRI.parse _namespace_name "copyright" |> NamespacedName

    /// <summary>
    /// The use of special processing on image data, such as rendering geared to output. When special processing is performed, the reader is expected to disable or minimize any further processing.
    /// <see href="http://www.w3.org/2003/12/exif/ns#customRendered"></see></summary>
    let customRendered =
        Namespaced_IRI.parse _namespace_name "customRendered" |> NamespacedName

    /// <summary>
    /// The Exif field data type, such as ascii, byte, short etc.
    /// <see href="http://www.w3.org/2003/12/exif/ns#datatype"></see></summary>
    let datatype = Namespaced_IRI.parse _namespace_name "datatype" |> NamespacedName
    /// <summary>
    /// a date information. Usually saved as YYYY:MM:DD (HH:MM:SS) format in Exif data, but represented here as W3C-DTF format
    /// <see href="http://www.w3.org/2003/12/exif/ns#date"></see></summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName

    /// <summary>
    /// An attribute relating to Date and/or Time
    /// <see href="http://www.w3.org/2003/12/exif/ns#dateAndOrTime"></see></summary>
    let dateAndOrTime =
        Namespaced_IRI.parse _namespace_name "dateAndOrTime" |> NamespacedName

    /// <summary>
    /// The date and time of image creation. In this standard it is the date and time the file was changed.
    /// <see href="http://www.w3.org/2003/12/exif/ns#dateTime"></see></summary>
    let dateTime = Namespaced_IRI.parse _namespace_name "dateTime" |> NamespacedName

    /// <summary>
    /// The date and time when the image was stored as digital data. If, for example, an image was captured by DSC and at the same time the file was recorded, then the DateTimeOriginal and DateTimeDigitized will have the same contents.
    /// <see href="http://www.w3.org/2003/12/exif/ns#dateTimeDigitized"></see></summary>
    let dateTimeDigitized =
        Namespaced_IRI.parse _namespace_name "dateTimeDigitized" |> NamespacedName

    /// <summary>
    /// The date and time when the original image data was generated. For a DSC the date and time the picture was taken are recorded.
    /// <see href="http://www.w3.org/2003/12/exif/ns#dateTimeOriginal"></see></summary>
    let dateTimeOriginal =
        Namespaced_IRI.parse _namespace_name "dateTimeOriginal" |> NamespacedName

    /// <summary>
    /// Information on the picture-taking conditions of a particular camera model. The tag is used only to indicate the picture-taking conditions in the reader.
    /// <see href="http://www.w3.org/2003/12/exif/ns#deviceSettingDescription"></see></summary>
    let deviceSettingDescription =
        Namespaced_IRI.parse _namespace_name "deviceSettingDescription" |> NamespacedName

    /// <summary>
    /// The digital zoom ratio when the image was shot. If the numerator of the recorded value is 0, this indicates that digital zoom was not used.
    /// <see href="http://www.w3.org/2003/12/exif/ns#digitalZoomRatio"></see></summary>
    let digitalZoomRatio =
        Namespaced_IRI.parse _namespace_name "digitalZoomRatio" |> NamespacedName

    /// <summary>
    /// Exif Version
    /// <see href="http://www.w3.org/2003/12/exif/ns#exifVersion"></see></summary>
    let exifVersion =
        Namespaced_IRI.parse _namespace_name "exifVersion" |> NamespacedName

    /// <summary>
    /// An attribute relating to Version
    /// <see href="http://www.w3.org/2003/12/exif/ns#versionInfo"></see></summary>
    let versionInfo =
        Namespaced_IRI.parse _namespace_name "versionInfo" |> NamespacedName

    /// <summary>
    /// A pointer to the Exif IFD, which is a set of tags for recording Exif-specific attribute information.
    /// <see href="http://www.w3.org/2003/12/exif/ns#exif_IFD_Pointer"></see></summary>
    let exif_IFD_Pointer =
        Namespaced_IRI.parse _namespace_name "exif_IFD_Pointer" |> NamespacedName

    /// <summary>
    /// A tag that refers a child IFD
    /// <see href="http://www.w3.org/2003/12/exif/ns#ifdPointer"></see></summary>
    let ifdPointer = Namespaced_IRI.parse _namespace_name "ifdPointer" |> NamespacedName
    /// <summary>
    /// An Exif IFD data entry
    /// <see href="http://www.w3.org/2003/12/exif/ns#exifdata"></see></summary>
    let exifdata = Namespaced_IRI.parse _namespace_name "exifdata" |> NamespacedName

    /// <summary>
    /// The exposure bias. The unit is the APEX value. Ordinarily it is given in the range of -99.99 to 99.99.
    /// <see href="http://www.w3.org/2003/12/exif/ns#exposureBiasValue"></see></summary>
    let exposureBiasValue =
        Namespaced_IRI.parse _namespace_name "exposureBiasValue" |> NamespacedName

    /// <summary>
    /// The exposure index selected on the camera or input device at the time the image is captured.
    /// <see href="http://www.w3.org/2003/12/exif/ns#exposureIndex"></see></summary>
    let exposureIndex =
        Namespaced_IRI.parse _namespace_name "exposureIndex" |> NamespacedName

    /// <summary>
    /// the exposure mode set when the image was shot. In auto-bracketing mode, the camera shoots a series of frames of the same scene at different exposure settings.
    /// <see href="http://www.w3.org/2003/12/exif/ns#exposureMode"></see></summary>
    let exposureMode =
        Namespaced_IRI.parse _namespace_name "exposureMode" |> NamespacedName

    /// <summary>
    /// The class of the program used by the camera to set exposure when the picture is taken.
    /// <see href="http://www.w3.org/2003/12/exif/ns#exposureProgram"></see></summary>
    let exposureProgram =
        Namespaced_IRI.parse _namespace_name "exposureProgram" |> NamespacedName

    /// <summary>
    /// Exposure time, given in seconds (sec).
    /// <see href="http://www.w3.org/2003/12/exif/ns#exposureTime"></see></summary>
    let exposureTime =
        Namespaced_IRI.parse _namespace_name "exposureTime" |> NamespacedName

    /// <summary>
    /// a mesurement of time length with unit of second
    /// <see href="http://www.w3.org/2003/12/exif/ns#seconds"></see></summary>
    let seconds = Namespaced_IRI.parse _namespace_name "seconds" |> NamespacedName
    /// <summary>
    /// F number
    /// <see href="http://www.w3.org/2003/12/exif/ns#fNumber"></see></summary>
    let fNumber = Namespaced_IRI.parse _namespace_name "fNumber" |> NamespacedName
    /// <summary>
    /// The image source. If a DSC recorded the image, this tag value of this tag always be set to 3, indicating that the image was recorded on a DSC.
    /// <see href="http://www.w3.org/2003/12/exif/ns#fileSource"></see></summary>
    let fileSource = Namespaced_IRI.parse _namespace_name "fileSource" |> NamespacedName
    /// <summary>
    /// The status of flash when the image was shot.
    /// <see href="http://www.w3.org/2003/12/exif/ns#flash"></see></summary>
    let flash = Namespaced_IRI.parse _namespace_name "flash" |> NamespacedName

    /// <summary>
    /// The strobe energy at the time the image is captured, as measured in Beam Candle Power Seconds (BCPS).
    /// <see href="http://www.w3.org/2003/12/exif/ns#flashEnergy"></see></summary>
    let flashEnergy =
        Namespaced_IRI.parse _namespace_name "flashEnergy" |> NamespacedName

    /// <summary>
    /// The Flashpix format version supported by a FPXR file. If the FPXR function supports Flashpix format Ver. 1.0, this is indicated similarly to ExifVersion by recording "0100" as 4-byte ASCII.
    /// <see href="http://www.w3.org/2003/12/exif/ns#flashpixVersion"></see></summary>
    let flashpixVersion =
        Namespaced_IRI.parse _namespace_name "flashpixVersion" |> NamespacedName

    /// <summary>
    /// The actual focal length of the lens, in mm. Conversion is not made to the focal length of a 35 mm film camera.
    /// <see href="http://www.w3.org/2003/12/exif/ns#focalLength"></see></summary>
    let focalLength =
        Namespaced_IRI.parse _namespace_name "focalLength" |> NamespacedName

    /// <summary>
    /// A length with unit of mm
    /// <see href="http://www.w3.org/2003/12/exif/ns#mm"></see></summary>
    let mm = Namespaced_IRI.parse _namespace_name "mm" |> NamespacedName

    /// <summary>
    /// The equivalent focal length assuming a 35mm film camera, in mm. A value of 0 means the focal length is unknown. Note that this tag differs from the FocalLength tag.
    /// <see href="http://www.w3.org/2003/12/exif/ns#focalLengthIn35mmFilm"></see></summary>
    let focalLengthIn35mmFilm =
        Namespaced_IRI.parse _namespace_name "focalLengthIn35mmFilm" |> NamespacedName

    /// <summary>
    /// Length of an object. Could be a subProperty of other general schema.
    /// <see href="http://www.w3.org/2003/12/exif/ns#length"></see></summary>
    let length = Namespaced_IRI.parse _namespace_name "length" |> NamespacedName

    /// <summary>
    /// The unit for measuring FocalPlaneXResolution and FocalPlaneYResolution. This value is the same as the ResolutionUnit.
    /// <see href="http://www.w3.org/2003/12/exif/ns#focalPlaneResolutionUnit"></see></summary>
    let focalPlaneResolutionUnit =
        Namespaced_IRI.parse _namespace_name "focalPlaneResolutionUnit" |> NamespacedName

    /// <summary>
    /// The number of pixels in the image width (X) direction per FocalPlaneResolutionUnit on the camera focal plane.
    /// <see href="http://www.w3.org/2003/12/exif/ns#focalPlaneXResolution"></see></summary>
    let focalPlaneXResolution =
        Namespaced_IRI.parse _namespace_name "focalPlaneXResolution" |> NamespacedName

    /// <summary>
    /// The number of pixels in the image height (Y) direction per FocalPlaneResolutionUnit on the camera focal plane.
    /// <see href="http://www.w3.org/2003/12/exif/ns#focalPlaneYResolution"></see></summary>
    let focalPlaneYResolution =
        Namespaced_IRI.parse _namespace_name "focalPlaneYResolution" |> NamespacedName

    /// <summary>
    /// The degree of overall image gain adjustment.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gainControl"></see></summary>
    let gainControl =
        Namespaced_IRI.parse _namespace_name "gainControl" |> NamespacedName

    /// <summary>
    /// Geometric data such as latitude, longitude and altitude. Usually saved as rational number.
    /// <see href="http://www.w3.org/2003/12/exif/ns#geo"></see></summary>
    let geo = Namespaced_IRI.parse _namespace_name "geo" |> NamespacedName

    /// <summary>
    /// The altitude based on the reference in GPSAltitudeRef. Altitude is expressed as one RATIONAL value. The reference unit is meters.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsAltitude"></see></summary>
    let gpsAltitude =
        Namespaced_IRI.parse _namespace_name "gpsAltitude" |> NamespacedName

    /// <summary>
    /// An attribute relating to GPS information
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsInfo"></see></summary>
    let gpsInfo = Namespaced_IRI.parse _namespace_name "gpsInfo" |> NamespacedName

    /// <summary>
    /// Indicates the altitude used as the reference altitude. If the reference is sea level and the altitude is above sea level, 0 is given. If the altitude is below sea level, a value of 1 is given and the altitude is indicated as an absolute value in the GPSAltitude tag. The reference unit is meters.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsAltitudeRef"></see></summary>
    let gpsAltitudeRef =
        Namespaced_IRI.parse _namespace_name "gpsAltitudeRef" |> NamespacedName

    /// <summary>
    /// A character string recording the name of the GPS area. The first byte indicates the character code used, and this is followed by the name of the GPS area.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsAreaInformation"></see></summary>
    let gpsAreaInformation =
        Namespaced_IRI.parse _namespace_name "gpsAreaInformation" |> NamespacedName

    /// <summary>
    /// The GPS DOP (data degree of precision). An HDOP value is written during two-dimensional measurement, and PDOP during three-dimensional measurement.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsDOP"></see></summary>
    let gpsDOP = Namespaced_IRI.parse _namespace_name "gpsDOP" |> NamespacedName

    /// <summary>
    /// date and time information relative to UTC (Coordinated Universal Time). The record format is "YYYY:MM:DD" while converted to W3C-DTF to use in RDF
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsDateStamp"></see></summary>
    let gpsDateStamp =
        Namespaced_IRI.parse _namespace_name "gpsDateStamp" |> NamespacedName

    /// <summary>
    /// The bearing to the destination point. The range of values is from 0.00 to 359.99.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsDestBearing"></see></summary>
    let gpsDestBearing =
        Namespaced_IRI.parse _namespace_name "gpsDestBearing" |> NamespacedName

    /// <summary>
    /// Indicates the reference used for giving the bearing to the destination point. 'T' denotes true direction and 'M' is magnetic direction.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsDestBearingRef"></see></summary>
    let gpsDestBearingRef =
        Namespaced_IRI.parse _namespace_name "gpsDestBearingRef" |> NamespacedName

    /// <summary>
    /// The distance to the destination point.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsDestDistance"></see></summary>
    let gpsDestDistance =
        Namespaced_IRI.parse _namespace_name "gpsDestDistance" |> NamespacedName

    /// <summary>
    /// Indicates the unit used to express the distance to the destination point. 'K', 'M' and 'N' represent kilometers, miles and knots.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsDestDistanceRef"></see></summary>
    let gpsDestDistanceRef =
        Namespaced_IRI.parse _namespace_name "gpsDestDistanceRef" |> NamespacedName

    /// <summary>
    /// Latitude of destination, expressed as three values giving the degrees, minutes, and seconds, respectively.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsDestLatitude"></see></summary>
    let gpsDestLatitude =
        Namespaced_IRI.parse _namespace_name "gpsDestLatitude" |> NamespacedName

    /// <summary>
    /// Reference for latitude of destination
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsDestLatitudeRef"></see></summary>
    let gpsDestLatitudeRef =
        Namespaced_IRI.parse _namespace_name "gpsDestLatitudeRef" |> NamespacedName

    /// <summary>
    /// Longitude of destination, expressed as three values giving the degrees, minutes, and seconds, respectively.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsDestLongitude"></see></summary>
    let gpsDestLongitude =
        Namespaced_IRI.parse _namespace_name "gpsDestLongitude" |> NamespacedName

    /// <summary>
    /// Reference for longitude of destination
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsDestLongitudeRef"></see></summary>
    let gpsDestLongitudeRef =
        Namespaced_IRI.parse _namespace_name "gpsDestLongitudeRef" |> NamespacedName

    /// <summary>
    /// Indicates whether differential correction is applied to the GPS receiver.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsDifferential"></see></summary>
    let gpsDifferential =
        Namespaced_IRI.parse _namespace_name "gpsDifferential" |> NamespacedName

    /// <summary>
    /// The direction of the image when it was captured. The range of values is from 0.00 to 359.99.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsImgDirection"></see></summary>
    let gpsImgDirection =
        Namespaced_IRI.parse _namespace_name "gpsImgDirection" |> NamespacedName

    /// <summary>
    /// The reference for giving the direction of the image when it is captured. 'T' denotes true direction and 'M' is magnetic direction.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsImgDirectionRef"></see></summary>
    let gpsImgDirectionRef =
        Namespaced_IRI.parse _namespace_name "gpsImgDirectionRef" |> NamespacedName

    /// <summary>
    /// A pointer to the GPS IFD, which is a set of tags for recording GPS information.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsInfo_IFD_Pointer"></see></summary>
    let gpsInfo_IFD_Pointer =
        Namespaced_IRI.parse _namespace_name "gpsInfo_IFD_Pointer" |> NamespacedName

    /// <summary>
    /// The latitude, expressed as three values giving the degrees, minutes, and seconds, respectively.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsLatitude"></see></summary>
    let gpsLatitude =
        Namespaced_IRI.parse _namespace_name "gpsLatitude" |> NamespacedName

    /// <summary>
    /// Indicates whether the latitude is north or south latitude. The ASCII value 'N' indicates north latitude, and 'S' is south latitude.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsLatitudeRef"></see></summary>
    let gpsLatitudeRef =
        Namespaced_IRI.parse _namespace_name "gpsLatitudeRef" |> NamespacedName

    /// <summary>
    /// The longitude, expressed as three values giving the degrees, minutes, and seconds, respectively.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsLongitude"></see></summary>
    let gpsLongitude =
        Namespaced_IRI.parse _namespace_name "gpsLongitude" |> NamespacedName

    /// <summary>
    /// Indicates whether the longitude is east or west longitude. ASCII 'E' indicates east longitude, and 'W' is west longitude.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsLongitudeRef"></see></summary>
    let gpsLongitudeRef =
        Namespaced_IRI.parse _namespace_name "gpsLongitudeRef" |> NamespacedName

    /// <summary>
    /// The geodetic survey data used by the GPS receiver. If the survey data is restricted to Japan, the value of this tag is 'TOKYO' or 'WGS-84'. If a GPS Info tag is recorded, it is strongly recommended that this tag be recorded.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsMapDatum"></see></summary>
    let gpsMapDatum =
        Namespaced_IRI.parse _namespace_name "gpsMapDatum" |> NamespacedName

    /// <summary>
    /// The GPS measurement mode. '2' means two-dimensional measurement and '3' means three-dimensional measurement is in progress.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsMeasureMode"></see></summary>
    let gpsMeasureMode =
        Namespaced_IRI.parse _namespace_name "gpsMeasureMode" |> NamespacedName

    /// <summary>
    /// A character string recording the name of the method used for location finding. The first byte indicates the character code used, and this is followed by the name of the method.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsProcessingMethod"></see></summary>
    let gpsProcessingMethod =
        Namespaced_IRI.parse _namespace_name "gpsProcessingMethod" |> NamespacedName

    /// <summary>
    /// The GPS satellites used for measurements. This tag can be used to describe the number of satellites, their ID number, angle of elevation, azimuth, SNR and other information in ASCII notation. The format is not specified. If the GPS receiver is incapable of taking measurements, value of the tag shall be set to NULL.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsSatellites"></see></summary>
    let gpsSatellites =
        Namespaced_IRI.parse _namespace_name "gpsSatellites" |> NamespacedName

    /// <summary>
    /// The speed of GPS receiver movement.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsSpeed"></see></summary>
    let gpsSpeed = Namespaced_IRI.parse _namespace_name "gpsSpeed" |> NamespacedName

    /// <summary>
    /// The unit used to express the GPS receiver speed of movement. 'K' 'M' and 'N' represents kilometers per hour, miles per hour, and knots.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsSpeedRef"></see></summary>
    let gpsSpeedRef =
        Namespaced_IRI.parse _namespace_name "gpsSpeedRef" |> NamespacedName

    /// <summary>
    /// The status of the GPS receiver when the image is recorded. 'A' means measurement is in progress, and 'V' means the measurement is Interoperability.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsStatus"></see></summary>
    let gpsStatus = Namespaced_IRI.parse _namespace_name "gpsStatus" |> NamespacedName

    /// <summary>
    /// The time as UTC (Coordinated Universal Time). TimeStamp is expressed as three RATIONAL values giving the hour, minute, and second.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsTimeStamp"></see></summary>
    let gpsTimeStamp =
        Namespaced_IRI.parse _namespace_name "gpsTimeStamp" |> NamespacedName

    /// <summary>
    /// The direction of GPS receiver movement. The range of values is from 0.00 to 359.99.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsTrack"></see></summary>
    let gpsTrack = Namespaced_IRI.parse _namespace_name "gpsTrack" |> NamespacedName

    /// <summary>
    /// The reference for giving the direction of GPS receiver movement. 'T' denotes true direction and 'M' is magnetic direction.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsTrackRef"></see></summary>
    let gpsTrackRef =
        Namespaced_IRI.parse _namespace_name "gpsTrackRef" |> NamespacedName

    /// <summary>
    /// The version of GPSInfoIFD. The version is given as 2.2.0.0. This tag is mandatory when GPSInfo tag is present.
    /// <see href="http://www.w3.org/2003/12/exif/ns#gpsVersionID"></see></summary>
    let gpsVersionID =
        Namespaced_IRI.parse _namespace_name "gpsVersionID" |> NamespacedName

    /// <summary>
    /// Height of an object
    /// <see href="http://www.w3.org/2003/12/exif/ns#height"></see></summary>
    let height = Namespaced_IRI.parse _namespace_name "height" |> NamespacedName

    /// <summary>
    /// A character string giving the title of the image. It may be a comment such as "1988 company picnic" or the like. Two-byte character codes cannot be used. When a 2-byte code is necessary, the Exif Private tag UserComment is to be used.
    /// <see href="http://www.w3.org/2003/12/exif/ns#imageDescription"></see></summary>
    let imageDescription =
        Namespaced_IRI.parse _namespace_name "imageDescription" |> NamespacedName

    /// <summary>
    /// Image height. The number of rows of image data. In JPEG compressed data a JPEG marker is used.
    /// <see href="http://www.w3.org/2003/12/exif/ns#imageLength"></see></summary>
    let imageLength =
        Namespaced_IRI.parse _namespace_name "imageLength" |> NamespacedName

    /// <summary>
    /// An identifier assigned uniquely to each image. It is recorded as an ASCII string equivalent to hexadecimal notation and 128-bit fixed length.
    /// <see href="http://www.w3.org/2003/12/exif/ns#imageUniqueID"></see></summary>
    let imageUniqueID =
        Namespaced_IRI.parse _namespace_name "imageUniqueID" |> NamespacedName

    /// <summary>
    /// Image width. The number of columns of image data, equal to the number of pixels per row. In JPEG compressed data a JPEG marker is used instead of this tag.
    /// <see href="http://www.w3.org/2003/12/exif/ns#imageWidth"></see></summary>
    let imageWidth = Namespaced_IRI.parse _namespace_name "imageWidth" |> NamespacedName
    /// <summary>
    /// Width of an object
    /// <see href="http://www.w3.org/2003/12/exif/ns#width"></see></summary>
    let width = Namespaced_IRI.parse _namespace_name "width" |> NamespacedName

    /// <summary>
    /// An attribute relating to Interoperability. Tags stored in
    /// Interoperability IFD may be defined dependently to each Interoperability rule.
    /// <see href="http://www.w3.org/2003/12/exif/ns#interopInfo"></see></summary>
    let interopInfo =
        Namespaced_IRI.parse _namespace_name "interopInfo" |> NamespacedName

    /// <summary>
    /// Indicates the identification of the Interoperability rule. 'R98' = conforming to R98 file specification of Recommended Exif Interoperability Rules (ExifR98) or to DCF basic file stipulated by Design Rule for Camera File System. 'THM' = conforming to DCF thumbnail file stipulated by Design rule for Camera File System.
    /// <see href="http://www.w3.org/2003/12/exif/ns#interoperabilityIndex"></see></summary>
    let interoperabilityIndex =
        Namespaced_IRI.parse _namespace_name "interoperabilityIndex" |> NamespacedName

    /// <summary>
    /// Interoperability Version
    /// <see href="http://www.w3.org/2003/12/exif/ns#interoperabilityVersion"></see></summary>
    let interoperabilityVersion =
        Namespaced_IRI.parse _namespace_name "interoperabilityVersion" |> NamespacedName

    /// <summary>
    /// A pointer to the Interoperability IFD, which is composed of tags storing the information to ensure the Interoperability
    /// <see href="http://www.w3.org/2003/12/exif/ns#interoperability_IFD_Pointer"></see></summary>
    let interoperability_IFD_Pointer =
        Namespaced_IRI.parse _namespace_name "interoperability_IFD_Pointer" |> NamespacedName

    /// <summary>
    /// Indicates the ISO Speed and ISO Latitude of the camera or input device as specified in ISO 12232.
    /// <see href="http://www.w3.org/2003/12/exif/ns#isoSpeedRatings"></see></summary>
    let isoSpeedRatings =
        Namespaced_IRI.parse _namespace_name "isoSpeedRatings" |> NamespacedName

    /// <summary>
    /// The offset to the start byte (SOI) of JPEG compressed thumbnail data. This is not used for primary image JPEG data.
    /// <see href="http://www.w3.org/2003/12/exif/ns#jpegInterchangeFormat"></see></summary>
    let jpegInterchangeFormat =
        Namespaced_IRI.parse _namespace_name "jpegInterchangeFormat" |> NamespacedName

    /// <summary>
    /// An attribute relating to recording offset
    /// <see href="http://www.w3.org/2003/12/exif/ns#recOffset"></see></summary>
    let recOffset = Namespaced_IRI.parse _namespace_name "recOffset" |> NamespacedName

    /// <summary>
    /// The number of bytes of JPEG compressed thumbnail data. This is not used for primary image JPEG data.
    /// <see href="http://www.w3.org/2003/12/exif/ns#jpegInterchangeFormatLength"></see></summary>
    let jpegInterchangeFormatLength =
        Namespaced_IRI.parse _namespace_name "jpegInterchangeFormatLength" |> NamespacedName

    /// <summary>
    /// Light source such as Daylight, Tungsten, Flash etc.
    /// <see href="http://www.w3.org/2003/12/exif/ns#lightSource"></see></summary>
    let lightSource =
        Namespaced_IRI.parse _namespace_name "lightSource" |> NamespacedName

    /// <summary>
    /// Manufacturer of image input equipment
    /// <see href="http://www.w3.org/2003/12/exif/ns#make"></see></summary>
    let make = Namespaced_IRI.parse _namespace_name "make" |> NamespacedName
    /// <summary>
    /// Manufacturer notes
    /// <see href="http://www.w3.org/2003/12/exif/ns#makerNote"></see></summary>
    let makerNote = Namespaced_IRI.parse _namespace_name "makerNote" |> NamespacedName
    /// <summary>
    /// An attribute relating to User Information
    /// <see href="http://www.w3.org/2003/12/exif/ns#userInfo"></see></summary>
    let userInfo = Namespaced_IRI.parse _namespace_name "userInfo" |> NamespacedName

    /// <summary>
    /// The smallest F number of the lens. The unit is the APEX value. Ordinarily it is given in the range of 00.00 to 99.99, but it is not limited to this range.
    /// <see href="http://www.w3.org/2003/12/exif/ns#maxApertureValue"></see></summary>
    let maxApertureValue =
        Namespaced_IRI.parse _namespace_name "maxApertureValue" |> NamespacedName

    /// <summary>
    /// A length with unit of meter
    /// <see href="http://www.w3.org/2003/12/exif/ns#meter"></see></summary>
    let meter = Namespaced_IRI.parse _namespace_name "meter" |> NamespacedName

    /// <summary>
    /// Metering mode, such as CenterWeightedAverage, Spot, MultiSpot,Pattern, Partial etc.
    /// <see href="http://www.w3.org/2003/12/exif/ns#meteringMode"></see></summary>
    let meteringMode =
        Namespaced_IRI.parse _namespace_name "meteringMode" |> NamespacedName

    /// <summary>
    /// Model of image input equipment
    /// <see href="http://www.w3.org/2003/12/exif/ns#model"></see></summary>
    let model = Namespaced_IRI.parse _namespace_name "model" |> NamespacedName
    /// <summary>
    /// Indicates the Opto-Electric Conversion Function (OECF) specified in ISO 14524. OECF is the relationship between the camera optical input and the image values.
    /// <see href="http://www.w3.org/2003/12/exif/ns#oecf"></see></summary>
    let oecf = Namespaced_IRI.parse _namespace_name "oecf" |> NamespacedName

    /// <summary>
    /// The image orientation viewed in terms of rows and columns.
    /// <see href="http://www.w3.org/2003/12/exif/ns#orientation"></see></summary>
    let orientation =
        Namespaced_IRI.parse _namespace_name "orientation" |> NamespacedName

    /// <summary>
    /// Pixel composition. In JPEG compressed data a JPEG marker is used instead of this tag.
    /// <see href="http://www.w3.org/2003/12/exif/ns#photometricInterpretation"></see></summary>
    let photometricInterpretation =
        Namespaced_IRI.parse _namespace_name "photometricInterpretation" |> NamespacedName

    /// <summary>
    /// Brightness info for print image matching
    /// <see href="http://www.w3.org/2003/12/exif/ns#pimBrightness"></see></summary>
    let pimBrightness =
        Namespaced_IRI.parse _namespace_name "pimBrightness" |> NamespacedName

    /// <summary>
    /// An attribute relating to print image matching
    /// <see href="http://www.w3.org/2003/12/exif/ns#pimInfo"></see></summary>
    let pimInfo = Namespaced_IRI.parse _namespace_name "pimInfo" |> NamespacedName

    /// <summary>
    /// ColorBalance info for print image matching
    /// <see href="http://www.w3.org/2003/12/exif/ns#pimColorBalance"></see></summary>
    let pimColorBalance =
        Namespaced_IRI.parse _namespace_name "pimColorBalance" |> NamespacedName

    /// <summary>
    /// Contrast info for print image matching
    /// <see href="http://www.w3.org/2003/12/exif/ns#pimContrast"></see></summary>
    let pimContrast =
        Namespaced_IRI.parse _namespace_name "pimContrast" |> NamespacedName

    /// <summary>
    /// Saturation info for print image matching
    /// <see href="http://www.w3.org/2003/12/exif/ns#pimSaturation"></see></summary>
    let pimSaturation =
        Namespaced_IRI.parse _namespace_name "pimSaturation" |> NamespacedName

    /// <summary>
    /// Sharpness info for print image matching
    /// <see href="http://www.w3.org/2003/12/exif/ns#pimSharpness"></see></summary>
    let pimSharpness =
        Namespaced_IRI.parse _namespace_name "pimSharpness" |> NamespacedName

    /// <summary>
    /// Information specific to compressed data. When a compressed file is recorded, the valid width of the meaningful image shall be recorded in this tag, whether or not there is padding data or a restart marker. This tag should not exist in an uncompressed file.
    /// <see href="http://www.w3.org/2003/12/exif/ns#pixelXDimension"></see></summary>
    let pixelXDimension =
        Namespaced_IRI.parse _namespace_name "pixelXDimension" |> NamespacedName

    /// <summary>
    /// Information specific to compressed data. When a compressed file is recorded, the valid height of the meaningful image shall be recorded in this tag, whether or not there is padding data or a restart marker. This tag should not exist in an uncompressed file. Since data padding is unnecessary in the vertical direction, the number of lines recorded in this valid image height tag will in fact be the same as that recorded in the SOF.
    /// <see href="http://www.w3.org/2003/12/exif/ns#pixelYDimension"></see></summary>
    let pixelYDimension =
        Namespaced_IRI.parse _namespace_name "pixelYDimension" |> NamespacedName

    /// <summary>
    /// Indicates whether pixel components are recorded in chunky or planar format. In JPEG compressed files a JPEG marker is used instead of this tag. If this field does not exist, the TIFF default of 1 (chunky) is assumed.
    /// <see href="http://www.w3.org/2003/12/exif/ns#planarConfiguration"></see></summary>
    let planarConfiguration =
        Namespaced_IRI.parse _namespace_name "planarConfiguration" |> NamespacedName

    /// <summary>
    /// The chromaticity of the three primary colors of the image. Normally this tag is not necessary, since color space is specified in the color space information tag (ColorSpace).
    /// <see href="http://www.w3.org/2003/12/exif/ns#primaryChromaticities"></see></summary>
    let primaryChromaticities =
        Namespaced_IRI.parse _namespace_name "primaryChromaticities" |> NamespacedName

    /// <summary>
    /// A pointer to the print image matching IFD
    /// <see href="http://www.w3.org/2003/12/exif/ns#printImageMatching_IFD_Pointer"></see></summary>
    let printImageMatching_IFD_Pointer =
        Namespaced_IRI.parse _namespace_name "printImageMatching_IFD_Pointer" |> NamespacedName

    /// <summary>
    /// The reference black point value and reference white point value. The color space is declared in a color space information tag, with the default being the value that gives the optimal image characteristics Interoperability these conditions.
    /// <see href="http://www.w3.org/2003/12/exif/ns#referenceBlackWhite"></see></summary>
    let referenceBlackWhite =
        Namespaced_IRI.parse _namespace_name "referenceBlackWhite" |> NamespacedName

    /// <summary>
    /// Tag Relating to Related File Information
    /// <see href="http://www.w3.org/2003/12/exif/ns#relatedFile"></see></summary>
    let relatedFile =
        Namespaced_IRI.parse _namespace_name "relatedFile" |> NamespacedName

    /// <summary>
    /// Related image file format
    /// <see href="http://www.w3.org/2003/12/exif/ns#relatedImageFileFormat"></see></summary>
    let relatedImageFileFormat =
        Namespaced_IRI.parse _namespace_name "relatedImageFileFormat" |> NamespacedName

    /// <summary>
    /// Related image length
    /// <see href="http://www.w3.org/2003/12/exif/ns#relatedImageLength"></see></summary>
    let relatedImageLength =
        Namespaced_IRI.parse _namespace_name "relatedImageLength" |> NamespacedName

    /// <summary>
    /// Related image width
    /// <see href="http://www.w3.org/2003/12/exif/ns#relatedImageWidth"></see></summary>
    let relatedImageWidth =
        Namespaced_IRI.parse _namespace_name "relatedImageWidth" |> NamespacedName

    /// <summary>
    /// Related audio file
    /// <see href="http://www.w3.org/2003/12/exif/ns#relatedSoundFile"></see></summary>
    let relatedSoundFile =
        Namespaced_IRI.parse _namespace_name "relatedSoundFile" |> NamespacedName

    /// <summary>
    /// The unit for measuring XResolution and YResolution. The same unit is used for both XResolution and YResolution. If the image resolution in unknown, 2 (inches) is designated.
    /// <see href="http://www.w3.org/2003/12/exif/ns#resolutionUnit"></see></summary>
    let resolutionUnit =
        Namespaced_IRI.parse _namespace_name "resolutionUnit" |> NamespacedName

    /// <summary>
    /// The number of rows per strip. This is the number of rows in the image of one strip when an image is divided into strips. With JPEG compressed data this designation is not needed and is omitted.
    /// <see href="http://www.w3.org/2003/12/exif/ns#rowsPerStrip"></see></summary>
    let rowsPerStrip =
        Namespaced_IRI.parse _namespace_name "rowsPerStrip" |> NamespacedName

    /// <summary>
    /// The number of components per pixel. Since this standard applies to RGB and YCbCr images, the value set for this tag is 3. In JPEG compressed data a JPEG marker is used instead of this tag.
    /// <see href="http://www.w3.org/2003/12/exif/ns#samplesPerPixel"></see></summary>
    let samplesPerPixel =
        Namespaced_IRI.parse _namespace_name "samplesPerPixel" |> NamespacedName

    /// <summary>
    /// The direction of saturation processing applied by the camera when the image was shot.
    /// <see href="http://www.w3.org/2003/12/exif/ns#saturation"></see></summary>
    let saturation = Namespaced_IRI.parse _namespace_name "saturation" |> NamespacedName

    /// <summary>
    /// The type of scene that was shot. It can also be used to record the mode in which the image was shot, such as Landscape, Portrait etc. Note that this differs from the scene type (SceneType) tag.
    /// <see href="http://www.w3.org/2003/12/exif/ns#sceneCaptureType"></see></summary>
    let sceneCaptureType =
        Namespaced_IRI.parse _namespace_name "sceneCaptureType" |> NamespacedName

    /// <summary>
    /// The type of scene. If a DSC recorded the image, this tag value shall always be set to 1, indicating that the image was directly photographed.
    /// <see href="http://www.w3.org/2003/12/exif/ns#sceneType"></see></summary>
    let sceneType = Namespaced_IRI.parse _namespace_name "sceneType" |> NamespacedName

    /// <summary>
    /// The image sensor type on the camera or input device, such as One-chip color area sensor etc.
    /// <see href="http://www.w3.org/2003/12/exif/ns#sensingMethod"></see></summary>
    let sensingMethod =
        Namespaced_IRI.parse _namespace_name "sensingMethod" |> NamespacedName

    /// <summary>
    /// The direction of sharpness processing applied by the camera when the image was shot.
    /// <see href="http://www.w3.org/2003/12/exif/ns#sharpness"></see></summary>
    let sharpness = Namespaced_IRI.parse _namespace_name "sharpness" |> NamespacedName

    /// <summary>
    /// Shutter speed. The unit is the APEX (Additive System of Photographic Exposure) setting
    /// <see href="http://www.w3.org/2003/12/exif/ns#shutterSpeedValue"></see></summary>
    let shutterSpeedValue =
        Namespaced_IRI.parse _namespace_name "shutterSpeedValue" |> NamespacedName

    /// <summary>
    /// The name and version of the software or firmware of the camera or image input device used to generate the image.
    /// <see href="http://www.w3.org/2003/12/exif/ns#software"></see></summary>
    let software = Namespaced_IRI.parse _namespace_name "software" |> NamespacedName

    /// <summary>
    /// This tag records the camera or input device spatial frequency table and SFR values in the direction of image width, image height, and diagonal direction, as specified in ISO 12233.
    /// <see href="http://www.w3.org/2003/12/exif/ns#spatialFrequencyResponse"></see></summary>
    let spatialFrequencyResponse =
        Namespaced_IRI.parse _namespace_name "spatialFrequencyResponse" |> NamespacedName

    /// <summary>
    /// Indicates the spectral sensitivity of each channel of the camera used. The tag value is an ASCII string compatible with the standard developed by the ASTM Technical committee.
    /// <see href="http://www.w3.org/2003/12/exif/ns#spectralSensitivity"></see></summary>
    let spectralSensitivity =
        Namespaced_IRI.parse _namespace_name "spectralSensitivity" |> NamespacedName

    /// <summary>
    /// The total number of bytes in each strip. With JPEG compressed data this designation is not needed and is omitted.
    /// <see href="http://www.w3.org/2003/12/exif/ns#stripByteCounts"></see></summary>
    let stripByteCounts =
        Namespaced_IRI.parse _namespace_name "stripByteCounts" |> NamespacedName

    /// <summary>
    /// For each strip, the byte offset of that strip. With JPEG compressed data this designation is not needed and is omitted.
    /// <see href="http://www.w3.org/2003/12/exif/ns#stripOffsets"></see></summary>
    let stripOffsets =
        Namespaced_IRI.parse _namespace_name "stripOffsets" |> NamespacedName

    /// <summary>
    /// DateTime subseconds
    /// <see href="http://www.w3.org/2003/12/exif/ns#subSecTime"></see></summary>
    let subSecTime = Namespaced_IRI.parse _namespace_name "subSecTime" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.w3.org/2003/12/exif/ns#subsecond"></see>
    /// </summary>
    let subsecond = Namespaced_IRI.parse _namespace_name "subsecond" |> NamespacedName

    /// <summary>
    /// DateTimeDigitized subseconds
    /// <see href="http://www.w3.org/2003/12/exif/ns#subSecTimeDigitized"></see></summary>
    let subSecTimeDigitized =
        Namespaced_IRI.parse _namespace_name "subSecTimeDigitized" |> NamespacedName

    /// <summary>
    /// DateTimeOriginal subseconds
    /// <see href="http://www.w3.org/2003/12/exif/ns#subSecTimeOriginal"></see></summary>
    let subSecTimeOriginal =
        Namespaced_IRI.parse _namespace_name "subSecTimeOriginal" |> NamespacedName

    /// <summary>
    /// The location and area of the main subject in the overall scene.
    /// <see href="http://www.w3.org/2003/12/exif/ns#subjectArea"></see></summary>
    let subjectArea =
        Namespaced_IRI.parse _namespace_name "subjectArea" |> NamespacedName

    /// <summary>
    /// The distance to the subject, given in meters. Note that if the numerator of the recorded value is FFFFFFFF.H, Infinity shall be indicated; and if the numerator is 0, Distance unknown shall be indicated.
    /// <see href="http://www.w3.org/2003/12/exif/ns#subjectDistance"></see></summary>
    let subjectDistance =
        Namespaced_IRI.parse _namespace_name "subjectDistance" |> NamespacedName

    /// <summary>
    /// The distance to the subject, such as Macro, Close View or Distant View.
    /// <see href="http://www.w3.org/2003/12/exif/ns#subjectDistanceRange"></see></summary>
    let subjectDistanceRange =
        Namespaced_IRI.parse _namespace_name "subjectDistanceRange" |> NamespacedName

    /// <summary>
    /// The location of the main subject in the scene. The value of this tag represents the pixel at the center of the main subject relative to the left edge, prior to rotation processing as per the Rotation tag. The first value indicates the X column number and second indicates the Y row number.
    /// <see href="http://www.w3.org/2003/12/exif/ns#subjectLocation"></see></summary>
    let subjectLocation =
        Namespaced_IRI.parse _namespace_name "subjectLocation" |> NamespacedName

    /// <summary>
    /// A tag used to record fractions of seconds for a date property
    /// <see href="http://www.w3.org/2003/12/exif/ns#subseconds"></see></summary>
    let subseconds = Namespaced_IRI.parse _namespace_name "subseconds" |> NamespacedName
    /// <summary>
    /// The Exif tag number
    /// <see href="http://www.w3.org/2003/12/exif/ns#tag_number"></see></summary>
    let tag_number = Namespaced_IRI.parse _namespace_name "tag_number" |> NamespacedName
    /// <summary>
    /// The Exif tag number with context prefix, such as IFD type or maker name
    /// <see href="http://www.w3.org/2003/12/exif/ns#tagid"></see></summary>
    let tagid = Namespaced_IRI.parse _namespace_name "tagid" |> NamespacedName

    /// <summary>
    /// A transfer function for the image, described in tabular style. Normally this tag is not necessary, since color space is specified in the color space information tag (ColorSpace).
    /// <see href="http://www.w3.org/2003/12/exif/ns#transferFunction"></see></summary>
    let transferFunction =
        Namespaced_IRI.parse _namespace_name "transferFunction" |> NamespacedName

    /// <summary>
    /// A tag for Exif users to write keywords or comments on the image besides those in ImageDescription, and without the character code limitations of the ImageDescription tag. The character code used in the UserComment tag is identified based on an ID code in a fixed 8-byte area at the start of the tag data area.
    /// <see href="http://www.w3.org/2003/12/exif/ns#userComment"></see></summary>
    let userComment =
        Namespaced_IRI.parse _namespace_name "userComment" |> NamespacedName

    /// <summary>
    /// The white balance mode set when the image was shot.
    /// <see href="http://www.w3.org/2003/12/exif/ns#whiteBalance"></see></summary>
    let whiteBalance =
        Namespaced_IRI.parse _namespace_name "whiteBalance" |> NamespacedName

    /// <summary>
    /// The chromaticity of the white point of the image. Normally this tag is not necessary, since color space is specified in the color space information tag (ColorSpace).
    /// <see href="http://www.w3.org/2003/12/exif/ns#whitePoint"></see></summary>
    let whitePoint = Namespaced_IRI.parse _namespace_name "whitePoint" |> NamespacedName

    /// <summary>
    /// The number of pixels per ResolutionUnit in the ImageWidth direction. When the image resolution is unknown, 72 [dpi] is designated.
    /// <see href="http://www.w3.org/2003/12/exif/ns#xResolution"></see></summary>
    let xResolution =
        Namespaced_IRI.parse _namespace_name "xResolution" |> NamespacedName

    /// <summary>
    /// The matrix coefficients for transformation from RGB to YCbCr image data.
    /// <see href="http://www.w3.org/2003/12/exif/ns#yCbCrCoefficients"></see></summary>
    let yCbCrCoefficients =
        Namespaced_IRI.parse _namespace_name "yCbCrCoefficients" |> NamespacedName

    /// <summary>
    /// The position of chrominance components in relation to the luminance component. This field is designated only for JPEG compressed data or uncompressed YCbCr data.
    /// <see href="http://www.w3.org/2003/12/exif/ns#yCbCrPositioning"></see></summary>
    let yCbCrPositioning =
        Namespaced_IRI.parse _namespace_name "yCbCrPositioning" |> NamespacedName

    /// <summary>
    /// The sampling ratio of chrominance components in relation to the luminance component. In JPEG compressed data a JPEG marker is used instead of this tag.
    /// <see href="http://www.w3.org/2003/12/exif/ns#yCbCrSubSampling"></see></summary>
    let yCbCrSubSampling =
        Namespaced_IRI.parse _namespace_name "yCbCrSubSampling" |> NamespacedName

    /// <summary>
    /// The number of pixels per ResolutionUnit in the ImageLength direction. The same value as XResolution is designated.
    /// <see href="http://www.w3.org/2003/12/exif/ns#yResolution"></see></summary>
    let yResolution =
        Namespaced_IRI.parse _namespace_name "yResolution" |> NamespacedName
