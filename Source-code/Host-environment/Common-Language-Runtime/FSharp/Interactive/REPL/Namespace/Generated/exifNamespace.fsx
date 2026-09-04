#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module exif =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/2003/12/exif/ns#" "exif"

    /// <summary>
    ///   <para>rdfs:label : IFD</para>
    ///   <para>rdfs:comment : An Image File Directory</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#IFD">exif:IFD</a>
    /// </summary>
    let IFD = _prefixId.prefix "IFD"
    /// <summary>
    ///   <para>rdfs:label : Unknown tag</para>
    ///   <para>rdfs:comment : An Exif tag whose meaning is not known</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#_unknown">exif:_unknown</a>
    /// </summary>
    let _unknown = _prefixId.prefix "_unknown"
    /// <summary>
    ///   <para>exif:tagNumber : 37378</para>
    ///   <para>rdfs:label : ApertureValue</para>
    ///   <para>rdfs:comment : The lens aperture. The unit is the APEX value.rdfs:comment : レンズ絞り値（APEX値）。この値のルート2のベキ乗を取ると、通常の絞り値となる。例えば'5'の場合だと√2^5=F5.6</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#apertureValue">exif:apertureValue</a>
    /// </summary>
    let apertureValue = _prefixId.prefix "apertureValue"
    /// <summary>
    ///   <para>exif:tagNumber : 315</para>
    ///   <para>rdfs:label : Artist</para>
    ///   <para>rdfs:comment : Person who created the image</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#artist">exif:artist</a>
    /// </summary>
    let artist = _prefixId.prefix "artist"
    /// <summary>
    ///   <para>exif:tagNumber : 258</para>
    ///   <para>rdfs:label : BitsPerSample</para>
    ///   <para>rdfs:comment : The number of bits per image component. In this standard each component of the image is 8 bits, so the value for this tag is 8. See also SamplesPerPixel. In JPEG compressed data a JPEG marker is used instead of this tag.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#bitsPerSample">exif:bitsPerSample</a>
    /// </summary>
    let bitsPerSample = _prefixId.prefix "bitsPerSample"
    /// <summary>
    ///   <para>exif:tagNumber : 37379</para>
    ///   <para>rdfs:label : BrightnessValue</para>
    ///   <para>rdfs:comment : The value of brightness. The unit is the APEX value. Ordinarily it is given in the range of -99.99 to 99.99. Note that if the numerator of the recorded value is FFFFFFFF.H, Unknown shall be indicated.rdfs:comment : 画像撮影時の撮影対象物の明るさ（APEX値）。EVにするにはISO感度の値を足す必要があり、Ev:Exposure, Bv:BrightnessValue, Sv:SensitivityValueとしてEv=Bv+Sv Sv=log^2(ISOSpeedRating/3.125)という計算式を使う。ISO感度100の場合Sv=5、ISO200の場合Sv=6、ISO125ではSv=5.32</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#brightnessValue">exif:brightnessValue</a>
    /// </summary>
    let brightnessValue = _prefixId.prefix "brightnessValue"
    /// <summary>
    ///   <para>exif:tagNumber : 41730</para>
    ///   <para>rdfs:label : CFAPattern</para>
    ///   <para>rdfs:comment : The color filter array (CFA) geometric pattern of the image sensor when a one-chip color area sensor is used. It does not apply to all sensing methods.rdfs:comment : CCDに付いているColor filter array(CFA)のパターン。例えば普通のRGBフィルターだと、CFAPatternのデータは 02 02 00 01 01 02</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#cfaPattern">exif:cfaPattern</a>
    /// </summary>
    let cfaPattern = _prefixId.prefix "cfaPattern"
    /// <summary>
    ///   <para>exif:tagNumber : 40961</para>
    ///   <para>rdfs:label : ColorSpace</para>
    ///   <para>rdfs:comment : The color space information tag (ColorSpace) is always recorded as the color space specifier. Normally sRGB (=1) is used to define the color space based on the PC monitor conditions and environment.rdfs:comment : 使われる色空間。通常sRGB</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#colorSpace">exif:colorSpace</a>
    /// </summary>
    let colorSpace = _prefixId.prefix "colorSpace"
    /// <summary>
    ///   <para>exif:tagNumber : 37121</para>
    ///   <para>rdfs:label : ComponentsConfiguration</para>
    ///   <para>rdfs:comment : Information specific to compressed data. The channels of each component are arranged in order from the 1st component to the 4th. For uncompressed data the data arrangement is given in the PhotometricInterpretation tag. However, since PhotometricInterpretation can only express the order of Y,Cb and Cr, this tag is provided for cases when compressed data uses components other than Y, Cb, and Cr and to enable support of other sequences.rdfs:comment : 圧縮データがYCC以外の並びの場合、4バイトでその並びを示す。それぞれの値は0:not exist,1:Y,2:Cb,3:Cr,4:R,5:G,6:B</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#componentsConfiguration">exif:componentsConfiguration</a>
    /// </summary>
    let componentsConfiguration = _prefixId.prefix "componentsConfiguration"
    /// <summary>
    ///   <para>exif:tagNumber : 37122</para>
    ///   <para>rdfs:label : CompressedBitsPerPixel</para>
    ///   <para>rdfs:comment : Information specific to compressed data. The compression mode used for a compressed image is indicated in unit bits per pixel.rdfs:comment : 画像の圧縮率</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#compressedBitsPerPixel">exif:compressedBitsPerPixel</a>
    /// </summary>
    let compressedBitsPerPixel = _prefixId.prefix "compressedBitsPerPixel"
    /// <summary>
    ///   <para>exif:tagNumber : 259</para>
    ///   <para>rdfs:label : Compression</para>
    ///   <para>rdfs:comment : The compression scheme used for the image data. When a primary image is JPEG compressed, this designation is not necessary and is omitted. When thumbnails use JPEG compression, this tag value is set to 6.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#compression">exif:compression</a>
    /// </summary>
    let compression = _prefixId.prefix "compression"
    /// <summary>
    ///   <para>exif:tagNumber : 41992</para>
    ///   <para>rdfs:label : Contrast</para>
    ///   <para>rdfs:comment : The direction of contrast processing applied by the camera when the image was shot.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#contrast">exif:contrast</a>
    /// </summary>
    let contrast = _prefixId.prefix "contrast"
    /// <summary>
    ///   <para>exif:tagNumber : 33432</para>
    ///   <para>rdfs:label : Copyright</para>
    ///   <para>rdfs:comment : Copyright information. In this standard the tag is used to indicate both the photographer and editor copyrights. It is the copyright notice of the person or organization claiming rights to the image.rdfs:comment : この画像の撮影者および編集者の著作権情報</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#copyright">exif:copyright</a>
    /// </summary>
    let copyright = _prefixId.prefix "copyright"
    /// <summary>
    ///   <para>exif:tagNumber : 41985</para>
    ///   <para>rdfs:label : CustomRendered</para>
    ///   <para>rdfs:comment : The use of special processing on image data, such as rendering geared to output. When special processing is performed, the reader is expected to disable or minimize any further processing.rdfs:comment : 特別なレンダリング処理を行っているかどうか</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#customRendered">exif:customRendered</a>
    /// </summary>
    let customRendered = _prefixId.prefix "customRendered"
    /// <summary>
    ///   <para>rdfs:label : Data Type</para>
    ///   <para>rdfs:comment : The Exif field data type, such as ascii, byte, short etc.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#datatype">exif:datatype</a>
    /// </summary>
    let datatype = _prefixId.prefix "datatype"
    /// <summary>
    ///   <para>rdfs:label : Date</para>
    ///   <para>rdfs:comment : a date information. Usually saved as YYYY:MM:DD (HH:MM:SS) format in Exif data, but represented here as W3C-DTF format</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#date">exif:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>rdfs:label : Date and/or Time</para>
    ///   <para>rdfs:comment : An attribute relating to Date and/or Time</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#dateAndOrTime">exif:dateAndOrTime</a>
    /// </summary>
    let dateAndOrTime = _prefixId.prefix "dateAndOrTime"
    /// <summary>
    ///   <para>exif:tagNumber : 306</para>
    ///   <para>rdfs:label : DateTime</para>
    ///   <para>rdfs:comment : The date and time of image creation. In this standard it is the date and time the file was changed.rdfs:comment : この画像が作成（あるいは最後に変更された）日時。通常はDateTimeOriginaと同じ値</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#dateTime">exif:dateTime</a>
    /// </summary>
    let dateTime = _prefixId.prefix "dateTime"
    /// <summary>
    ///   <para>exif:tagNumber : 36868</para>
    ///   <para>rdfs:label : DateTimeDigitized</para>
    ///   <para>rdfs:comment : The date and time when the image was stored as digital data. If, for example, an image was captured by DSC and at the same time the file was recorded, then the DateTimeOriginal and DateTimeDigitized will have the same contents.rdfs:comment : 画像がデジタル化された日時。デジカメ画像なら通常DateTimeOriginalと同じ値</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#dateTimeDigitized">exif:dateTimeDigitized</a>
    /// </summary>
    let dateTimeDigitized = _prefixId.prefix "dateTimeDigitized"
    /// <summary>
    ///   <para>exif:tagNumber : 36867</para>
    ///   <para>rdfs:label : DateTimeOriginal</para>
    ///   <para>rdfs:comment : The date and time when the original image data was generated. For a DSC the date and time the picture was taken are recorded.rdfs:comment : オリジナル画像が作成（撮影）された日時</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#dateTimeOriginal">exif:dateTimeOriginal</a>
    /// </summary>
    let dateTimeOriginal = _prefixId.prefix "dateTimeOriginal"
    /// <summary>
    ///   <para>exif:tagNumber : 41995</para>
    ///   <para>rdfs:label : DeviceSettingDescription</para>
    ///   <para>rdfs:comment : Information on the picture-taking conditions of a particular camera model. The tag is used only to indicate the picture-taking conditions in the reader.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#deviceSettingDescription">exif:deviceSettingDescription</a>
    /// </summary>
    let deviceSettingDescription = _prefixId.prefix "deviceSettingDescription"
    /// <summary>
    ///   <para>exif:tagNumber : 41988</para>
    ///   <para>rdfs:label : DigitalZoomRatio</para>
    ///   <para>rdfs:comment : The digital zoom ratio when the image was shot. If the numerator of the recorded value is 0, this indicates that digital zoom was not used.rdfs:comment : デジタルズームが使われた場合、その比率</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#digitalZoomRatio">exif:digitalZoomRatio</a>
    /// </summary>
    let digitalZoomRatio = _prefixId.prefix "digitalZoomRatio"
    /// <summary>
    ///   <para>rdfs:label : Exif Attribute</para>
    ///   <para>rdfs:comment : A property that connects an IFD to one of its entries. Super property which integrates all Exif tags.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#exifAttribute">exif:exifAttribute</a>
    /// </summary>
    let exifAttribute = _prefixId.prefix "exifAttribute"
    /// <summary>
    ///   <para>exif:tagNumber : 36864</para>
    ///   <para>rdfs:label : ExifVersion</para>
    ///   <para>rdfs:comment : Exif Versionrdfs:comment : Exif形式のバージョン</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#exifVersion">exif:exifVersion</a>
    /// </summary>
    let exifVersion = _prefixId.prefix "exifVersion"
    /// <summary>
    ///   <para>exif:tagNumber : 34665</para>
    ///   <para>rdfs:label : Exif IFD Pointer</para>
    ///   <para>rdfs:comment : A pointer to the Exif IFD, which is a set of tags for recording Exif-specific attribute information.rdfs:comment : Exif IFDへのポインタ</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#exif_IFD_Pointer">exif:exif_IFD_Pointer</a>
    /// </summary>
    let exif_IFD_Pointer = _prefixId.prefix "exif_IFD_Pointer"
    /// <summary>
    ///   <para>rdfs:label : Exif data</para>
    ///   <para>rdfs:comment : An Exif IFD data entry</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#exifdata">exif:exifdata</a>
    /// </summary>
    let exifdata = _prefixId.prefix "exifdata"
    /// <summary>
    ///   <para>exif:tagNumber : 37380</para>
    ///   <para>rdfs:label : ExposureBiasValue</para>
    ///   <para>rdfs:comment : The exposure bias. The unit is the APEX value. Ordinarily it is given in the range of -99.99 to 99.99.rdfs:comment : 撮影時の露光補正量。単位はAPEX値(EV)</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#exposureBiasValue">exif:exposureBiasValue</a>
    /// </summary>
    let exposureBiasValue = _prefixId.prefix "exposureBiasValue"
    /// <summary>
    ///   <para>exif:tagNumber : 41493</para>
    ///   <para>rdfs:label : ExposureIndex</para>
    ///   <para>rdfs:comment : The exposure index selected on the camera or input device at the time the image is captured.rdfs:comment : CCD感度。データ形式が符号なし分数である事を除き、ISOSpeedRatingsと同じ</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#exposureIndex">exif:exposureIndex</a>
    /// </summary>
    let exposureIndex = _prefixId.prefix "exposureIndex"
    /// <summary>
    ///   <para>exif:tagNumber : 41986</para>
    ///   <para>rdfs:label : ExposureMode</para>
    ///   <para>rdfs:comment : the exposure mode set when the image was shot. In auto-bracketing mode, the camera shoots a series of frames of the same scene at different exposure settings.rdfs:comment : 露光モード</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#exposureMode">exif:exposureMode</a>
    /// </summary>
    let exposureMode = _prefixId.prefix "exposureMode"
    /// <summary>
    ///   <para>exif:tagNumber : 34850</para>
    ///   <para>rdfs:label : ExposureProgram</para>
    ///   <para>rdfs:comment : The class of the program used by the camera to set exposure when the picture is taken.rdfs:comment : 露光制御のモード</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#exposureProgram">exif:exposureProgram</a>
    /// </summary>
    let exposureProgram = _prefixId.prefix "exposureProgram"
    /// <summary>
    ///   <para>exif:tagNumber : 33434</para>
    ///   <para>rdfs:label : ExposureTime</para>
    ///   <para>rdfs:comment : Exposure time, given in seconds (sec).rdfs:comment : 露光時間（シャッター速度の逆数）。単位は秒</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#exposureTime">exif:exposureTime</a>
    /// </summary>
    let exposureTime = _prefixId.prefix "exposureTime"
    /// <summary>
    ///   <para>exif:tagNumber : 33437</para>
    ///   <para>rdfs:label : FNumber</para>
    ///   <para>rdfs:comment : F numberrdfs:comment : レンズのF値</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#fNumber">exif:fNumber</a>
    /// </summary>
    let fNumber = _prefixId.prefix "fNumber"
    /// <summary>
    ///   <para>exif:tagNumber : 41728</para>
    ///   <para>rdfs:label : FileSource</para>
    ///   <para>rdfs:comment : The image source. If a DSC recorded the image, this tag value of this tag always be set to 3, indicating that the image was recorded on a DSC.rdfs:comment : 画像がどういうデバイスから得られたか。通常3=DSC</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#fileSource">exif:fileSource</a>
    /// </summary>
    let fileSource = _prefixId.prefix "fileSource"
    /// <summary>
    ///   <para>exif:tagNumber : 37385</para>
    ///   <para>rdfs:label : Flash</para>
    ///   <para>rdfs:comment : The status of flash when the image was shot.rdfs:comment : フラッシュ発光の状態</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#flash">exif:flash</a>
    /// </summary>
    let flash = _prefixId.prefix "flash"
    /// <summary>
    ///   <para>exif:tagNumber : 41483</para>
    ///   <para>rdfs:label : FlashEnergy</para>
    ///   <para>rdfs:comment : The strobe energy at the time the image is captured, as measured in Beam Candle Power Seconds (BCPS).rdfs:comment : BCPSによるストロボの強度</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#flashEnergy">exif:flashEnergy</a>
    /// </summary>
    let flashEnergy = _prefixId.prefix "flashEnergy"
    /// <summary>
    ///   <para>exif:tagNumber : 40960</para>
    ///   <para>rdfs:label : FlashpixVersion</para>
    ///   <para>rdfs:comment : The Flashpix format version supported by a FPXR file. If the FPXR function supports Flashpix format Ver. 1.0, this is indicated similarly to ExifVersion by recording "0100" as 4-byte ASCII.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#flashpixVersion">exif:flashpixVersion</a>
    /// </summary>
    let flashpixVersion = _prefixId.prefix "flashpixVersion"
    /// <summary>
    ///   <para>exif:tagNumber : 37386</para>
    ///   <para>rdfs:label : FocalLength</para>
    ///   <para>rdfs:comment : The actual focal length of the lens, in mm. Conversion is not made to the focal length of a 35 mm film camera.rdfs:comment : レンズの焦点距離。単位はmm</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#focalLength">exif:focalLength</a>
    /// </summary>
    let focalLength = _prefixId.prefix "focalLength"
    /// <summary>
    ///   <para>exif:tagNumber : 41989</para>
    ///   <para>rdfs:label : FocalLengthIn35mmFilm</para>
    ///   <para>rdfs:comment : The equivalent focal length assuming a 35mm film camera, in mm. A value of 0 means the focal length is unknown. Note that this tag differs from the FocalLength tag.rdfs:comment : 35mm換算した焦点距離</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#focalLengthIn35mmFilm">exif:focalLengthIn35mmFilm</a>
    /// </summary>
    let focalLengthIn35mmFilm = _prefixId.prefix "focalLengthIn35mmFilm"
    /// <summary>
    ///   <para>exif:tagNumber : 41488</para>
    ///   <para>rdfs:label : FocalPlaneResolutionUnit</para>
    ///   <para>rdfs:comment : The unit for measuring FocalPlaneXResolution and FocalPlaneYResolution. This value is the same as the ResolutionUnit.rdfs:comment : CCD画素密度の単位</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#focalPlaneResolutionUnit">exif:focalPlaneResolutionUnit</a>
    /// </summary>
    let focalPlaneResolutionUnit = _prefixId.prefix "focalPlaneResolutionUnit"
    /// <summary>
    ///   <para>exif:tagNumber : 41486</para>
    ///   <para>rdfs:label : FocalPlaneXResolution</para>
    ///   <para>rdfs:comment : The number of pixels in the image width (X) direction per FocalPlaneResolutionUnit on the camera focal plane.rdfs:comment : 撮影画像のCCD位置での水平解像度。この値とFocalPlaneYResolution、FocalLengthを使うと、レンズ焦点距離の35mmカメラ換算値が計算できる。例えば200万画素機を使いVGAモードの画像を撮ったような場合はこの値はVGAの解像度でリサンプルされた値になっており、CCDの画素ピッチそのままの値ではないので注意が必要</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#focalPlaneXResolution">exif:focalPlaneXResolution</a>
    /// </summary>
    let focalPlaneXResolution = _prefixId.prefix "focalPlaneXResolution"
    /// <summary>
    ///   <para>exif:tagNumber : 41487</para>
    ///   <para>rdfs:label : FocalPlaneYResolution</para>
    ///   <para>rdfs:comment : The number of pixels in the image height (Y) direction per FocalPlaneResolutionUnit on the camera focal plane.rdfs:comment : 撮影画像のCCD位置での垂直解像度</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#focalPlaneYResolution">exif:focalPlaneYResolution</a>
    /// </summary>
    let focalPlaneYResolution = _prefixId.prefix "focalPlaneYResolution"
    /// <summary>
    ///   <para>exif:tagNumber : 41991</para>
    ///   <para>rdfs:label : GainControl</para>
    ///   <para>rdfs:comment : The degree of overall image gain adjustment.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gainControl">exif:gainControl</a>
    /// </summary>
    let gainControl = _prefixId.prefix "gainControl"
    /// <summary>
    ///   <para>rdfs:label : Geometric data</para>
    ///   <para>rdfs:comment : Geometric data such as latitude, longitude and altitude. Usually saved as rational number.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#geo">exif:geo</a>
    /// </summary>
    let geo = _prefixId.prefix "geo"
    /// <summary>
    ///   <para>exif:tagNumber : 6</para>
    ///   <para>rdfs:label : GPSAltitude</para>
    ///   <para>rdfs:comment : The altitude based on the reference in GPSAltitudeRef. Altitude is expressed as one RATIONAL value. The reference unit is meters.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsAltitude">exif:gpsAltitude</a>
    /// </summary>
    let gpsAltitude = _prefixId.prefix "gpsAltitude"
    /// <summary>
    ///   <para>exif:tagNumber : 5</para>
    ///   <para>rdfs:label : GPSAltitudeRef</para>
    ///   <para>rdfs:comment : Indicates the altitude used as the reference altitude. If the reference is sea level and the altitude is above sea level, 0 is given. If the altitude is below sea level, a value of 1 is given and the altitude is indicated as an absolute value in the GPSAltitude tag. The reference unit is meters.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsAltitudeRef">exif:gpsAltitudeRef</a>
    /// </summary>
    let gpsAltitudeRef = _prefixId.prefix "gpsAltitudeRef"
    /// <summary>
    ///   <para>exif:tagNumber : 28</para>
    ///   <para>rdfs:label : GPSAreaInformation</para>
    ///   <para>rdfs:comment : A character string recording the name of the GPS area. The first byte indicates the character code used, and this is followed by the name of the GPS area.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsAreaInformation">exif:gpsAreaInformation</a>
    /// </summary>
    let gpsAreaInformation = _prefixId.prefix "gpsAreaInformation"
    /// <summary>
    ///   <para>exif:tagNumber : 11</para>
    ///   <para>rdfs:label : GPSDOP</para>
    ///   <para>rdfs:comment : The GPS DOP (data degree of precision). An HDOP value is written during two-dimensional measurement, and PDOP during three-dimensional measurement.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsDOP">exif:gpsDOP</a>
    /// </summary>
    let gpsDOP = _prefixId.prefix "gpsDOP"
    /// <summary>
    ///   <para>exif:tagNumber : 29</para>
    ///   <para>rdfs:label : GPSDateStamp</para>
    ///   <para>rdfs:comment : date and time information relative to UTC (Coordinated Universal Time). The record format is "YYYY:MM:DD" while converted to W3C-DTF to use in RDF</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsDateStamp">exif:gpsDateStamp</a>
    /// </summary>
    let gpsDateStamp = _prefixId.prefix "gpsDateStamp"
    /// <summary>
    ///   <para>exif:tagNumber : 24</para>
    ///   <para>rdfs:label : GPSDestBearing</para>
    ///   <para>rdfs:comment : The bearing to the destination point. The range of values is from 0.00 to 359.99.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsDestBearing">exif:gpsDestBearing</a>
    /// </summary>
    let gpsDestBearing = _prefixId.prefix "gpsDestBearing"
    /// <summary>
    ///   <para>exif:tagNumber : 23</para>
    ///   <para>rdfs:label : GPSDestBearingRef</para>
    ///   <para>rdfs:comment : Indicates the reference used for giving the bearing to the destination point. 'T' denotes true direction and 'M' is magnetic direction.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsDestBearingRef">exif:gpsDestBearingRef</a>
    /// </summary>
    let gpsDestBearingRef = _prefixId.prefix "gpsDestBearingRef"
    /// <summary>
    ///   <para>exif:tagNumber : 26</para>
    ///   <para>rdfs:label : GPSDestDistance</para>
    ///   <para>rdfs:comment : The distance to the destination point.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsDestDistance">exif:gpsDestDistance</a>
    /// </summary>
    let gpsDestDistance = _prefixId.prefix "gpsDestDistance"
    /// <summary>
    ///   <para>exif:tagNumber : 25</para>
    ///   <para>rdfs:label : GPSDestDistanceRef</para>
    ///   <para>rdfs:comment : Indicates the unit used to express the distance to the destination point. 'K', 'M' and 'N' represent kilometers, miles and knots.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsDestDistanceRef">exif:gpsDestDistanceRef</a>
    /// </summary>
    let gpsDestDistanceRef = _prefixId.prefix "gpsDestDistanceRef"
    /// <summary>
    ///   <para>exif:tagNumber : 20</para>
    ///   <para>rdfs:label : GPSDestLatitude</para>
    ///   <para>rdfs:comment : Latitude of destination, expressed as three values giving the degrees, minutes, and seconds, respectively.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsDestLatitude">exif:gpsDestLatitude</a>
    /// </summary>
    let gpsDestLatitude = _prefixId.prefix "gpsDestLatitude"
    /// <summary>
    ///   <para>exif:tagNumber : 19</para>
    ///   <para>rdfs:label : GPSDestLatitudeRef</para>
    ///   <para>rdfs:comment : Reference for latitude of destination</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsDestLatitudeRef">exif:gpsDestLatitudeRef</a>
    /// </summary>
    let gpsDestLatitudeRef = _prefixId.prefix "gpsDestLatitudeRef"
    /// <summary>
    ///   <para>exif:tagNumber : 22</para>
    ///   <para>rdfs:label : GPSDestLongitude</para>
    ///   <para>rdfs:comment : Longitude of destination, expressed as three values giving the degrees, minutes, and seconds, respectively.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsDestLongitude">exif:gpsDestLongitude</a>
    /// </summary>
    let gpsDestLongitude = _prefixId.prefix "gpsDestLongitude"
    /// <summary>
    ///   <para>exif:tagNumber : 21</para>
    ///   <para>rdfs:label : GPSDestLongitudeRef</para>
    ///   <para>rdfs:comment : Reference for longitude of destination</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsDestLongitudeRef">exif:gpsDestLongitudeRef</a>
    /// </summary>
    let gpsDestLongitudeRef = _prefixId.prefix "gpsDestLongitudeRef"
    /// <summary>
    ///   <para>exif:tagNumber : 30</para>
    ///   <para>rdfs:label : GPSDifferential</para>
    ///   <para>rdfs:comment : Indicates whether differential correction is applied to the GPS receiver.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsDifferential">exif:gpsDifferential</a>
    /// </summary>
    let gpsDifferential = _prefixId.prefix "gpsDifferential"
    /// <summary>
    ///   <para>exif:tagNumber : 17</para>
    ///   <para>rdfs:label : GPSImgDirection</para>
    ///   <para>rdfs:comment : The direction of the image when it was captured. The range of values is from 0.00 to 359.99.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsImgDirection">exif:gpsImgDirection</a>
    /// </summary>
    let gpsImgDirection = _prefixId.prefix "gpsImgDirection"
    /// <summary>
    ///   <para>exif:tagNumber : 16</para>
    ///   <para>rdfs:label : GPSImgDirectionRef</para>
    ///   <para>rdfs:comment : The reference for giving the direction of the image when it is captured. 'T' denotes true direction and 'M' is magnetic direction.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsImgDirectionRef">exif:gpsImgDirectionRef</a>
    /// </summary>
    let gpsImgDirectionRef = _prefixId.prefix "gpsImgDirectionRef"
    /// <summary>
    ///   <para>rdfs:label : GPS Info</para>
    ///   <para>rdfs:comment : An attribute relating to GPS information</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsInfo">exif:gpsInfo</a>
    /// </summary>
    let gpsInfo = _prefixId.prefix "gpsInfo"
    /// <summary>
    ///   <para>exif:tagNumber : 34853</para>
    ///   <para>rdfs:label : GPSInfo IFD Pointer</para>
    ///   <para>rdfs:comment : A pointer to the GPS IFD, which is a set of tags for recording GPS information.rdfs:comment : GPS IFDへのポインタ</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsInfo_IFD_Pointer">exif:gpsInfo_IFD_Pointer</a>
    /// </summary>
    let gpsInfo_IFD_Pointer = _prefixId.prefix "gpsInfo_IFD_Pointer"
    /// <summary>
    ///   <para>exif:tagNumber : 2</para>
    ///   <para>rdfs:label : GPSLatitude</para>
    ///   <para>rdfs:comment : The latitude, expressed as three values giving the degrees, minutes, and seconds, respectively.rdfs:comment : 緯度</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsLatitude">exif:gpsLatitude</a>
    /// </summary>
    let gpsLatitude = _prefixId.prefix "gpsLatitude"
    /// <summary>
    ///   <para>exif:tagNumber : 1</para>
    ///   <para>rdfs:label : GPSLatitudeRef</para>
    ///   <para>rdfs:comment : Indicates whether the latitude is north or south latitude. The ASCII value 'N' indicates north latitude, and 'S' is south latitude.rdfs:comment : 緯度の北緯もしくは南緯</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsLatitudeRef">exif:gpsLatitudeRef</a>
    /// </summary>
    let gpsLatitudeRef = _prefixId.prefix "gpsLatitudeRef"
    /// <summary>
    ///   <para>exif:tagNumber : 4</para>
    ///   <para>rdfs:label : GPSLongitude</para>
    ///   <para>rdfs:comment : The longitude, expressed as three values giving the degrees, minutes, and seconds, respectively.rdfs:comment : 経度</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsLongitude">exif:gpsLongitude</a>
    /// </summary>
    let gpsLongitude = _prefixId.prefix "gpsLongitude"
    /// <summary>
    ///   <para>exif:tagNumber : 3</para>
    ///   <para>rdfs:label : GPSLongitudeRef</para>
    ///   <para>rdfs:comment : Indicates whether the longitude is east or west longitude. ASCII 'E' indicates east longitude, and 'W' is west longitude.rdfs:comment : 経度の東経もしくは西経</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsLongitudeRef">exif:gpsLongitudeRef</a>
    /// </summary>
    let gpsLongitudeRef = _prefixId.prefix "gpsLongitudeRef"
    /// <summary>
    ///   <para>exif:tagNumber : 18</para>
    ///   <para>rdfs:label : GPSMapDatum</para>
    ///   <para>rdfs:comment : The geodetic survey data used by the GPS receiver. If the survey data is restricted to Japan, the value of this tag is 'TOKYO' or 'WGS-84'. If a GPS Info tag is recorded, it is strongly recommended that this tag be recorded.rdfs:comment : 測地系。日本なら'TOKYO'もしくは'WGS-84'</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsMapDatum">exif:gpsMapDatum</a>
    /// </summary>
    let gpsMapDatum = _prefixId.prefix "gpsMapDatum"
    /// <summary>
    ///   <para>exif:tagNumber : 10</para>
    ///   <para>rdfs:label : GPSMeasureMode</para>
    ///   <para>rdfs:comment : The GPS measurement mode. '2' means two-dimensional measurement and '3' means three-dimensional measurement is in progress.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsMeasureMode">exif:gpsMeasureMode</a>
    /// </summary>
    let gpsMeasureMode = _prefixId.prefix "gpsMeasureMode"
    /// <summary>
    ///   <para>exif:tagNumber : 27</para>
    ///   <para>rdfs:label : GPSProcessingMethod</para>
    ///   <para>rdfs:comment : A character string recording the name of the method used for location finding. The first byte indicates the character code used, and this is followed by the name of the method.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsProcessingMethod">exif:gpsProcessingMethod</a>
    /// </summary>
    let gpsProcessingMethod = _prefixId.prefix "gpsProcessingMethod"
    /// <summary>
    ///   <para>exif:tagNumber : 8</para>
    ///   <para>rdfs:label : GPSSatellites</para>
    ///   <para>rdfs:comment : The GPS satellites used for measurements. This tag can be used to describe the number of satellites, their ID number, angle of elevation, azimuth, SNR and other information in ASCII notation. The format is not specified. If the GPS receiver is incapable of taking measurements, value of the tag shall be set to NULL.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsSatellites">exif:gpsSatellites</a>
    /// </summary>
    let gpsSatellites = _prefixId.prefix "gpsSatellites"
    /// <summary>
    ///   <para>exif:tagNumber : 13</para>
    ///   <para>rdfs:label : GPSSpeed</para>
    ///   <para>rdfs:comment : The speed of GPS receiver movement.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsSpeed">exif:gpsSpeed</a>
    /// </summary>
    let gpsSpeed = _prefixId.prefix "gpsSpeed"
    /// <summary>
    ///   <para>exif:tagNumber : 12</para>
    ///   <para>rdfs:label : GPSSpeedRef</para>
    ///   <para>rdfs:comment : The unit used to express the GPS receiver speed of movement. 'K' 'M' and 'N' represents kilometers per hour, miles per hour, and knots.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsSpeedRef">exif:gpsSpeedRef</a>
    /// </summary>
    let gpsSpeedRef = _prefixId.prefix "gpsSpeedRef"
    /// <summary>
    ///   <para>exif:tagNumber : 9</para>
    ///   <para>rdfs:label : GPSStatus</para>
    ///   <para>rdfs:comment : The status of the GPS receiver when the image is recorded. 'A' means measurement is in progress, and 'V' means the measurement is Interoperability.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsStatus">exif:gpsStatus</a>
    /// </summary>
    let gpsStatus = _prefixId.prefix "gpsStatus"
    /// <summary>
    ///   <para>exif:tagNumber : 7</para>
    ///   <para>rdfs:label : GPSTimeStamp</para>
    ///   <para>rdfs:comment : The time as UTC (Coordinated Universal Time). TimeStamp is expressed as three RATIONAL values giving the hour, minute, and second.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsTimeStamp">exif:gpsTimeStamp</a>
    /// </summary>
    let gpsTimeStamp = _prefixId.prefix "gpsTimeStamp"
    /// <summary>
    ///   <para>exif:tagNumber : 15</para>
    ///   <para>rdfs:label : GPSTrack</para>
    ///   <para>rdfs:comment : The direction of GPS receiver movement. The range of values is from 0.00 to 359.99.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsTrack">exif:gpsTrack</a>
    /// </summary>
    let gpsTrack = _prefixId.prefix "gpsTrack"
    /// <summary>
    ///   <para>exif:tagNumber : 14</para>
    ///   <para>rdfs:label : GPSTrackRef</para>
    ///   <para>rdfs:comment : The reference for giving the direction of GPS receiver movement. 'T' denotes true direction and 'M' is magnetic direction.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsTrackRef">exif:gpsTrackRef</a>
    /// </summary>
    let gpsTrackRef = _prefixId.prefix "gpsTrackRef"
    /// <summary>
    ///   <para>exif:tagNumber : 0</para>
    ///   <para>rdfs:label : GPSVersionID</para>
    ///   <para>rdfs:comment : The version of GPSInfoIFD. The version is given as 2.2.0.0. This tag is mandatory when GPSInfo tag is present.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#gpsVersionID">exif:gpsVersionID</a>
    /// </summary>
    let gpsVersionID = _prefixId.prefix "gpsVersionID"
    /// <summary>
    ///   <para>rdfs:label : Height</para>
    ///   <para>rdfs:comment : Height of an object</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#height">exif:height</a>
    /// </summary>
    let height = _prefixId.prefix "height"
    /// <summary>
    ///   <para>rdfs:label : IFD Pointer</para>
    ///   <para>rdfs:comment : A tag that refers a child IFD</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#ifdPointer">exif:ifdPointer</a>
    /// </summary>
    let ifdPointer = _prefixId.prefix "ifdPointer"
    /// <summary>
    ///   <para>rdfs:label : Image Config</para>
    ///   <para>rdfs:comment : An attribute relating to Image Configuration</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#imageConfig">exif:imageConfig</a>
    /// </summary>
    let imageConfig = _prefixId.prefix "imageConfig"
    /// <summary>
    ///   <para>rdfs:label : Image Data Character</para>
    ///   <para>rdfs:comment : An attribute relating to image data characteristics</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#imageDataCharacter">exif:imageDataCharacter</a>
    /// </summary>
    let imageDataCharacter = _prefixId.prefix "imageDataCharacter"
    /// <summary>
    ///   <para>rdfs:label : Image Data Structure</para>
    ///   <para>rdfs:comment : An attribute relating to image data structure</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#imageDataStruct">exif:imageDataStruct</a>
    /// </summary>
    let imageDataStruct = _prefixId.prefix "imageDataStruct"
    /// <summary>
    ///   <para>exif:tagNumber : 270</para>
    ///   <para>rdfs:label : ImageDescription</para>
    ///   <para>rdfs:comment : A character string giving the title of the image. It may be a comment such as "1988 company picnic" or the like. Two-byte character codes cannot be used. When a 2-byte code is necessary, the Exif Private tag UserComment is to be used.rdfs:comment : この画像についての説明。漢字等の2バイト文字の使用は禁止</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#imageDescription">exif:imageDescription</a>
    /// </summary>
    let imageDescription = _prefixId.prefix "imageDescription"
    /// <summary>
    ///   <para>exif:tagNumber : 257</para>
    ///   <para>rdfs:label : ImageLength</para>
    ///   <para>rdfs:comment : Image height. The number of rows of image data. In JPEG compressed data a JPEG marker is used.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#imageLength">exif:imageLength</a>
    /// </summary>
    let imageLength = _prefixId.prefix "imageLength"
    /// <summary>
    ///   <para>exif:tagNumber : 42016</para>
    ///   <para>rdfs:label : ImageUniqueID</para>
    ///   <para>rdfs:comment : An identifier assigned uniquely to each image. It is recorded as an ASCII string equivalent to hexadecimal notation and 128-bit fixed length.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#imageUniqueID">exif:imageUniqueID</a>
    /// </summary>
    let imageUniqueID = _prefixId.prefix "imageUniqueID"
    /// <summary>
    ///   <para>exif:tagNumber : 256</para>
    ///   <para>rdfs:label : ImageWidth</para>
    ///   <para>rdfs:comment : Image width. The number of columns of image data, equal to the number of pixels per row. In JPEG compressed data a JPEG marker is used instead of this tag.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#imageWidth">exif:imageWidth</a>
    /// </summary>
    let imageWidth = _prefixId.prefix "imageWidth"
    /// <summary>
    ///   <para>rdfs:label : Interoperability Info</para>
    ///   <para>rdfs:comment : An attribute relating to Interoperability. Tags stored in
    /// Interoperability IFD may be defined dependently to each Interoperability rule.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#interopInfo">exif:interopInfo</a>
    /// </summary>
    let interopInfo = _prefixId.prefix "interopInfo"
    /// <summary>
    ///   <para>exif:tagNumber : 1</para>
    ///   <para>rdfs:label : InteroperabilityIndex</para>
    ///   <para>rdfs:comment : Indicates the identification of the Interoperability rule. 'R98' = conforming to R98 file specification of Recommended Exif Interoperability Rules (ExifR98) or to DCF basic file stipulated by Design Rule for Camera File System. 'THM' = conforming to DCF thumbnail file stipulated by Design rule for Camera File System.rdfs:comment : メイン画像のInteroperability IFDで、データの内容がExifR98 v1.0準拠の場合は、'R98'の文字列。サムネィル画像のInteroperability IFDの場合は、'THM'の文字列</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#interoperabilityIndex">exif:interoperabilityIndex</a>
    /// </summary>
    let interoperabilityIndex = _prefixId.prefix "interoperabilityIndex"
    /// <summary>
    ///   <para>exif:tagNumber : 2</para>
    ///   <para>rdfs:label : InteroperabilityVersion</para>
    ///   <para>rdfs:comment : Interoperability Versionrdfs:comment : データの内容がExifR98 v1.0準拠の場合は、'0100'の文字列。</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#interoperabilityVersion">exif:interoperabilityVersion</a>
    /// </summary>
    let interoperabilityVersion = _prefixId.prefix "interoperabilityVersion"
    /// <summary>
    ///   <para>exif:tagNumber : 40965</para>
    ///   <para>rdfs:label : Interoperability IFD Pointer</para>
    ///   <para>rdfs:comment : A pointer to the Interoperability IFD, which is composed of tags storing the information to ensure the Interoperabilityrdfs:comment : Interoperability IFDへのポインタ</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#interoperability_IFD_Pointer">exif:interoperability_IFD_Pointer</a>
    /// </summary>
    let interoperability_IFD_Pointer = _prefixId.prefix "interoperability_IFD_Pointer"
    /// <summary>
    ///   <para>exif:tagNumber : 34855</para>
    ///   <para>rdfs:label : ISOSpeedRatings</para>
    ///   <para>rdfs:comment : Indicates the ISO Speed and ISO Latitude of the camera or input device as specified in ISO 12232.rdfs:comment : CCD感度の銀塩フィルム換算値</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#isoSpeedRatings">exif:isoSpeedRatings</a>
    /// </summary>
    let isoSpeedRatings = _prefixId.prefix "isoSpeedRatings"
    /// <summary>
    ///   <para>exif:tagNumber : 513</para>
    ///   <para>rdfs:label : JPEGInterchangeFormat</para>
    ///   <para>rdfs:comment : The offset to the start byte (SOI) of JPEG compressed thumbnail data. This is not used for primary image JPEG data.rdfs:comment : 圧縮されたサムネイルへのオフセット</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#jpegInterchangeFormat">exif:jpegInterchangeFormat</a>
    /// </summary>
    let jpegInterchangeFormat = _prefixId.prefix "jpegInterchangeFormat"
    /// <summary>
    ///   <para>exif:tagNumber : 514</para>
    ///   <para>rdfs:label : JPEGInterchangeFormatLength</para>
    ///   <para>rdfs:comment : The number of bytes of JPEG compressed thumbnail data. This is not used for primary image JPEG data.rdfs:comment : 圧縮されたサムネイルのサイズ</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#jpegInterchangeFormatLength">exif:jpegInterchangeFormatLength</a>
    /// </summary>
    let jpegInterchangeFormatLength = _prefixId.prefix "jpegInterchangeFormatLength"
    /// <summary>
    ///   <para>rdfs:label : Length</para>
    ///   <para>rdfs:comment : Length of an object. Could be a subProperty of other general schema.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#length">exif:length</a>
    /// </summary>
    let length = _prefixId.prefix "length"
    /// <summary>
    ///   <para>exif:tagNumber : 37384</para>
    ///   <para>rdfs:label : LightSource</para>
    ///   <para>rdfs:comment : Light source such as Daylight, Tungsten, Flash etc.rdfs:comment : 光源。これはマニュアルでホワイトバランスを設定した場合のモード値となる</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#lightSource">exif:lightSource</a>
    /// </summary>
    let lightSource = _prefixId.prefix "lightSource"
    /// <summary>
    ///   <para>exif:tagNumber : 271</para>
    ///   <para>rdfs:label : Make</para>
    ///   <para>rdfs:comment : Manufacturer of image input equipmentrdfs:comment : カメラのメーカー名。DCFでは必須</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#make">exif:make</a>
    /// </summary>
    let make = _prefixId.prefix "make"
    /// <summary>
    ///   <para>exif:tagNumber : 37500</para>
    ///   <para>rdfs:label : MakerNote</para>
    ///   <para>rdfs:comment : Manufacturer notesrdfs:comment : カメラの内部情報等、メーカー依存データ</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#makerNote">exif:makerNote</a>
    /// </summary>
    let makerNote = _prefixId.prefix "makerNote"
    /// <summary>
    ///   <para>exif:tagNumber : 37381</para>
    ///   <para>rdfs:label : MaxApertureValue</para>
    ///   <para>rdfs:comment : The smallest F number of the lens. The unit is the APEX value. Ordinarily it is given in the range of 00.00 to 99.99, but it is not limited to this range.rdfs:comment : レンズの開放F値。ApertureValue同様、ルート2のベキ乗を取ると通常の絞り値に換算できる</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#maxApertureValue">exif:maxApertureValue</a>
    /// </summary>
    let maxApertureValue = _prefixId.prefix "maxApertureValue"
    /// <summary>
    ///   <para>rdfs:label : Meter</para>
    ///   <para>rdfs:comment : A length with unit of meter</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#meter">exif:meter</a>
    /// </summary>
    let meter = _prefixId.prefix "meter"
    /// <summary>
    ///   <para>exif:tagNumber : 37383</para>
    ///   <para>rdfs:label : MeteringMode</para>
    ///   <para>rdfs:comment : Metering mode, such as CenterWeightedAverage, Spot, MultiSpot,Pattern, Partial etc.rdfs:comment : 自動露出の測光モード</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#meteringMode">exif:meteringMode</a>
    /// </summary>
    let meteringMode = _prefixId.prefix "meteringMode"
    /// <summary>
    ///   <para>rdfs:label : Milimeter</para>
    ///   <para>rdfs:comment : A length with unit of mm</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#mm">exif:mm</a>
    /// </summary>
    let mm = _prefixId.prefix "mm"
    /// <summary>
    ///   <para>exif:tagNumber : 272</para>
    ///   <para>rdfs:label : Model</para>
    ///   <para>rdfs:comment : Model of image input equipmentrdfs:comment : カメラの機種名。DCFでは必須</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#model">exif:model</a>
    /// </summary>
    let model = _prefixId.prefix "model"
    /// <summary>
    ///   <para>exif:tagNumber : 34856</para>
    ///   <para>rdfs:label : OECF</para>
    ///   <para>rdfs:comment : Indicates the Opto-Electric Conversion Function (OECF) specified in ISO 14524. OECF is the relationship between the camera optical input and the image values.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#oecf">exif:oecf</a>
    /// </summary>
    let oecf = _prefixId.prefix "oecf"
    /// <summary>
    ///   <para>exif:tagNumber : 274</para>
    ///   <para>rdfs:label : Orientation</para>
    ///   <para>rdfs:comment : The image orientation viewed in terms of rows and columns.rdfs:comment : 画像データがどこ(top-leftなど）を起点として、どの向きで格納されているか</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#orientation">exif:orientation</a>
    /// </summary>
    let orientation = _prefixId.prefix "orientation"
    /// <summary>
    ///   <para>exif:tagNumber : 262</para>
    ///   <para>rdfs:label : PhotometricInterpretation</para>
    ///   <para>rdfs:comment : Pixel composition. In JPEG compressed data a JPEG marker is used instead of this tag.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#photometricInterpretation">exif:photometricInterpretation</a>
    /// </summary>
    let photometricInterpretation = _prefixId.prefix "photometricInterpretation"
    /// <summary>
    ///   <para>rdfs:label : PictTaking</para>
    ///   <para>rdfs:comment : An attribute relating to Picture-Taking Conditions</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#pictTaking">exif:pictTaking</a>
    /// </summary>
    let pictTaking = _prefixId.prefix "pictTaking"
    /// <summary>
    ///   <para>exif:tagNumber : 10</para>
    ///   <para>rdfs:label : PrintIM Brightness</para>
    ///   <para>rdfs:comment : Brightness info for print image matching</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#pimBrightness">exif:pimBrightness</a>
    /// </summary>
    let pimBrightness = _prefixId.prefix "pimBrightness"
    /// <summary>
    ///   <para>exif:tagNumber : 11</para>
    ///   <para>rdfs:label : PrintIM ColorBalance</para>
    ///   <para>rdfs:comment : ColorBalance info for print image matching</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#pimColorBalance">exif:pimColorBalance</a>
    /// </summary>
    let pimColorBalance = _prefixId.prefix "pimColorBalance"
    /// <summary>
    ///   <para>exif:tagNumber : 9</para>
    ///   <para>rdfs:label : PrintIM Contrast</para>
    ///   <para>rdfs:comment : Contrast info for print image matching</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#pimContrast">exif:pimContrast</a>
    /// </summary>
    let pimContrast = _prefixId.prefix "pimContrast"
    /// <summary>
    ///   <para>rdfs:label : PIM Info</para>
    ///   <para>rdfs:comment : An attribute relating to print image matching</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#pimInfo">exif:pimInfo</a>
    /// </summary>
    let pimInfo = _prefixId.prefix "pimInfo"
    /// <summary>
    ///   <para>exif:tagNumber : 12</para>
    ///   <para>rdfs:label : PrintIM Saturation</para>
    ///   <para>rdfs:comment : Saturation info for print image matching</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#pimSaturation">exif:pimSaturation</a>
    /// </summary>
    let pimSaturation = _prefixId.prefix "pimSaturation"
    /// <summary>
    ///   <para>exif:tagNumber : 13</para>
    ///   <para>rdfs:label : PrintIM Sharpness</para>
    ///   <para>rdfs:comment : Sharpness info for print image matching</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#pimSharpness">exif:pimSharpness</a>
    /// </summary>
    let pimSharpness = _prefixId.prefix "pimSharpness"
    /// <summary>
    ///   <para>exif:tagNumber : 40962</para>
    ///   <para>rdfs:label : PixelXDimension</para>
    ///   <para>rdfs:comment : Information specific to compressed data. When a compressed file is recorded, the valid width of the meaningful image shall be recorded in this tag, whether or not there is padding data or a restart marker. This tag should not exist in an uncompressed file.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#pixelXDimension">exif:pixelXDimension</a>
    /// </summary>
    let pixelXDimension = _prefixId.prefix "pixelXDimension"
    /// <summary>
    ///   <para>exif:tagNumber : 40963</para>
    ///   <para>rdfs:label : PixelYDimension</para>
    ///   <para>rdfs:comment : Information specific to compressed data. When a compressed file is recorded, the valid height of the meaningful image shall be recorded in this tag, whether or not there is padding data or a restart marker. This tag should not exist in an uncompressed file. Since data padding is unnecessary in the vertical direction, the number of lines recorded in this valid image height tag will in fact be the same as that recorded in the SOF.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#pixelYDimension">exif:pixelYDimension</a>
    /// </summary>
    let pixelYDimension = _prefixId.prefix "pixelYDimension"
    /// <summary>
    ///   <para>exif:tagNumber : 284</para>
    ///   <para>rdfs:label : PlanarConfiguration</para>
    ///   <para>rdfs:comment : Indicates whether pixel components are recorded in chunky or planar format. In JPEG compressed files a JPEG marker is used instead of this tag. If this field does not exist, the TIFF default of 1 (chunky) is assumed.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#planarConfiguration">exif:planarConfiguration</a>
    /// </summary>
    let planarConfiguration = _prefixId.prefix "planarConfiguration"
    /// <summary>
    ///   <para>exif:tagNumber : 319</para>
    ///   <para>rdfs:label : PrimaryChromaticities</para>
    ///   <para>rdfs:comment : The chromaticity of the three primary colors of the image. Normally this tag is not necessary, since color space is specified in the color space information tag (ColorSpace).rdfs:comment : 原色の色度。CCIR REcommendation 709 primariesを使っている場合は、'640/1000,330/1000,300/1000,600/1000,150/1000,60/1000'という値。通常はColorSpaceタグがあるので不要</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#primaryChromaticities">exif:primaryChromaticities</a>
    /// </summary>
    let primaryChromaticities = _prefixId.prefix "primaryChromaticities"

    /// <summary>
    ///   <para>exif:tagNumber : 50341</para>
    ///   <para>rdfs:label : PrintImageMatching IFD Pointer</para>
    ///   <para>rdfs:comment : A pointer to the print image matching IFD</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#printImageMatching_IFD_Pointer">exif:printImageMatching_IFD_Pointer</a>
    /// </summary>
    let printImageMatching_IFD_Pointer =
        _prefixId.prefix "printImageMatching_IFD_Pointer"

    /// <summary>
    ///   <para>rdfs:label : Recording Offset</para>
    ///   <para>rdfs:comment : An attribute relating to recording offset</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#recOffset">exif:recOffset</a>
    /// </summary>
    let recOffset = _prefixId.prefix "recOffset"
    /// <summary>
    ///   <para>exif:tagNumber : 532</para>
    ///   <para>rdfs:label : ReferenceBlackWhite</para>
    ///   <para>rdfs:comment : The reference black point value and reference white point value. The color space is declared in a color space information tag, with the default being the value that gives the optimal image characteristics Interoperability these conditions.rdfs:comment : 画像情報の黒点・白点値。YCbCr形式の場合、最初の２つの値がY(輝度)の黒点・白点、次がCb、最後がCrとなり、デフォルト値は'0,255,0,128,0,128'。RGB形式の場合はR、G、Bの順で黒点・白点値が並んでおり、デフォルト値は'0,255,0,255,0,255'。</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#referenceBlackWhite">exif:referenceBlackWhite</a>
    /// </summary>
    let referenceBlackWhite = _prefixId.prefix "referenceBlackWhite"
    /// <summary>
    ///   <para>rdfs:label : Related File</para>
    ///   <para>rdfs:comment : Tag Relating to Related File Information</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#relatedFile">exif:relatedFile</a>
    /// </summary>
    let relatedFile = _prefixId.prefix "relatedFile"
    /// <summary>
    ///   <para>exif:tagNumber : 4096</para>
    ///   <para>rdfs:label : RelatedImageFileFormat</para>
    ///   <para>rdfs:comment : Related image file formatrdfs:comment : 画像フォーマットを'Exif JPEG Ver. 2.1'などの文字列で示す。通常はサムネィル画像に使う</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#relatedImageFileFormat">exif:relatedImageFileFormat</a>
    /// </summary>
    let relatedImageFileFormat = _prefixId.prefix "relatedImageFileFormat"
    /// <summary>
    ///   <para>exif:tagNumber : 4098</para>
    ///   <para>rdfs:label : RelatedImageLength</para>
    ///   <para>rdfs:comment : Related image lengthrdfs:comment : 画像高。通常はサムネイル画像のInteroperability IFDに使う</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#relatedImageLength">exif:relatedImageLength</a>
    /// </summary>
    let relatedImageLength = _prefixId.prefix "relatedImageLength"
    /// <summary>
    ///   <para>exif:tagNumber : 4097</para>
    ///   <para>rdfs:label : RelatedImageWidth</para>
    ///   <para>rdfs:comment : Related image widthrdfs:comment : 画像幅。通常はサムネイル画像のInteroperability IFDに使う</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#relatedImageWidth">exif:relatedImageWidth</a>
    /// </summary>
    let relatedImageWidth = _prefixId.prefix "relatedImageWidth"
    /// <summary>
    ///   <para>exif:tagNumber : 40964</para>
    ///   <para>rdfs:label : RelatedSoundFile</para>
    ///   <para>rdfs:comment : Related audio filerdfs:comment : 画像と一緒に音声録音できる機種の場合に、音声ファイルの名前</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#relatedSoundFile">exif:relatedSoundFile</a>
    /// </summary>
    let relatedSoundFile = _prefixId.prefix "relatedSoundFile"
    /// <summary>
    ///   <para>rdfs:label : Resolution</para>
    ///   <para>rdfs:comment : a rational number representing a resolution. Could be a subProperty of other general schema.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#resolution">exif:resolution</a>
    /// </summary>
    let resolution = _prefixId.prefix "resolution"
    /// <summary>
    ///   <para>exif:tagNumber : 296</para>
    ///   <para>rdfs:label : ResolutionUnit</para>
    ///   <para>rdfs:comment : The unit for measuring XResolution and YResolution. The same unit is used for both XResolution and YResolution. If the image resolution in unknown, 2 (inches) is designated.rdfs:comment : XResolution/YResolutionの解像度の単位</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#resolutionUnit">exif:resolutionUnit</a>
    /// </summary>
    let resolutionUnit = _prefixId.prefix "resolutionUnit"
    /// <summary>
    ///   <para>exif:tagNumber : 278</para>
    ///   <para>rdfs:label : RowsPerStrip</para>
    ///   <para>rdfs:comment : The number of rows per strip. This is the number of rows in the image of one strip when an image is divided into strips. With JPEG compressed data this designation is not needed and is omitted.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#rowsPerStrip">exif:rowsPerStrip</a>
    /// </summary>
    let rowsPerStrip = _prefixId.prefix "rowsPerStrip"
    /// <summary>
    ///   <para>exif:tagNumber : 277</para>
    ///   <para>rdfs:label : SamplesPerPixel</para>
    ///   <para>rdfs:comment : The number of components per pixel. Since this standard applies to RGB and YCbCr images, the value set for this tag is 3. In JPEG compressed data a JPEG marker is used instead of this tag.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#samplesPerPixel">exif:samplesPerPixel</a>
    /// </summary>
    let samplesPerPixel = _prefixId.prefix "samplesPerPixel"
    /// <summary>
    ///   <para>exif:tagNumber : 41993</para>
    ///   <para>rdfs:label : Saturation</para>
    ///   <para>rdfs:comment : The direction of saturation processing applied by the camera when the image was shot.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#saturation">exif:saturation</a>
    /// </summary>
    let saturation = _prefixId.prefix "saturation"
    /// <summary>
    ///   <para>exif:tagNumber : 41990</para>
    ///   <para>rdfs:label : SceneCaptureType</para>
    ///   <para>rdfs:comment : The type of scene that was shot. It can also be used to record the mode in which the image was shot, such as Landscape, Portrait etc. Note that this differs from the scene type (SceneType) tag.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#sceneCaptureType">exif:sceneCaptureType</a>
    /// </summary>
    let sceneCaptureType = _prefixId.prefix "sceneCaptureType"
    /// <summary>
    ///   <para>exif:tagNumber : 41729</para>
    ///   <para>rdfs:label : SceneType</para>
    ///   <para>rdfs:comment : The type of scene. If a DSC recorded the image, this tag value shall always be set to 1, indicating that the image was directly photographed.rdfs:comment : 画像がどうやって撮られたか。デジカメの場合は通常1=A directly photographed image</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#sceneType">exif:sceneType</a>
    /// </summary>
    let sceneType = _prefixId.prefix "sceneType"
    /// <summary>
    ///   <para>rdfs:label : Seconds</para>
    ///   <para>rdfs:comment : a mesurement of time length with unit of second</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#seconds">exif:seconds</a>
    /// </summary>
    let seconds = _prefixId.prefix "seconds"
    /// <summary>
    ///   <para>exif:tagNumber : 41495</para>
    ///   <para>rdfs:label : SensingMethod</para>
    ///   <para>rdfs:comment : The image sensor type on the camera or input device, such as One-chip color area sensor etc.rdfs:comment : イメージセンサーの形式。One-chip color area sensor、Color sequential area sensor、Trilinear sensorなど</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#sensingMethod">exif:sensingMethod</a>
    /// </summary>
    let sensingMethod = _prefixId.prefix "sensingMethod"
    /// <summary>
    ///   <para>exif:tagNumber : 41994</para>
    ///   <para>rdfs:label : Sharpness</para>
    ///   <para>rdfs:comment : The direction of sharpness processing applied by the camera when the image was shot.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#sharpness">exif:sharpness</a>
    /// </summary>
    let sharpness = _prefixId.prefix "sharpness"
    /// <summary>
    ///   <para>exif:tagNumber : 37377</para>
    ///   <para>rdfs:label : ShutterSpeedValue</para>
    ///   <para>rdfs:comment : Shutter speed. The unit is the APEX (Additive System of Photographic Exposure) settingrdfs:comment : シャッター速度（APEX値）。この値の2のベキ乗をとって逆数にすると、通常のシャッター速度表示になる。例えば'4'の場合だと1/(2^4)=1/16秒</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#shutterSpeedValue">exif:shutterSpeedValue</a>
    /// </summary>
    let shutterSpeedValue = _prefixId.prefix "shutterSpeedValue"
    /// <summary>
    ///   <para>exif:tagNumber : 305</para>
    ///   <para>rdfs:label : Software</para>
    ///   <para>rdfs:comment : The name and version of the software or firmware of the camera or image input device used to generate the image.rdfs:comment : デジカメ（もしくは入力機器）の内蔵ソフトウェア/ファームウェアの名称とバージョン</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#software">exif:software</a>
    /// </summary>
    let software = _prefixId.prefix "software"
    /// <summary>
    ///   <para>exif:tagNumber : 41484</para>
    ///   <para>rdfs:label : SpatialFrequencyResponse</para>
    ///   <para>rdfs:comment : This tag records the camera or input device spatial frequency table and SFR values in the direction of image width, image height, and diagonal direction, as specified in ISO 12233.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#spatialFrequencyResponse">exif:spatialFrequencyResponse</a>
    /// </summary>
    let spatialFrequencyResponse = _prefixId.prefix "spatialFrequencyResponse"
    /// <summary>
    ///   <para>exif:tagNumber : 34852</para>
    ///   <para>rdfs:label : SpectralSensitivity</para>
    ///   <para>rdfs:comment : Indicates the spectral sensitivity of each channel of the camera used. The tag value is an ASCII string compatible with the standard developed by the ASTM Technical committee.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#spectralSensitivity">exif:spectralSensitivity</a>
    /// </summary>
    let spectralSensitivity = _prefixId.prefix "spectralSensitivity"
    /// <summary>
    ///   <para>exif:tagNumber : 279</para>
    ///   <para>rdfs:label : StripByteCounts</para>
    ///   <para>rdfs:comment : The total number of bytes in each strip. With JPEG compressed data this designation is not needed and is omitted.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#stripByteCounts">exif:stripByteCounts</a>
    /// </summary>
    let stripByteCounts = _prefixId.prefix "stripByteCounts"
    /// <summary>
    ///   <para>exif:tagNumber : 273</para>
    ///   <para>rdfs:label : StripOffsets</para>
    ///   <para>rdfs:comment : For each strip, the byte offset of that strip. With JPEG compressed data this designation is not needed and is omitted.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#stripOffsets">exif:stripOffsets</a>
    /// </summary>
    let stripOffsets = _prefixId.prefix "stripOffsets"
    /// <summary>
    ///   <para>exif:tagNumber : 37520</para>
    ///   <para>rdfs:label : SubSecTime</para>
    ///   <para>rdfs:comment : DateTime subseconds</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#subSecTime">exif:subSecTime</a>
    /// </summary>
    let subSecTime = _prefixId.prefix "subSecTime"
    /// <summary>
    ///   <para>exif:tagNumber : 37522</para>
    ///   <para>rdfs:label : SubSecTimeDigitized</para>
    ///   <para>rdfs:comment : DateTimeDigitized subseconds</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#subSecTimeDigitized">exif:subSecTimeDigitized</a>
    /// </summary>
    let subSecTimeDigitized = _prefixId.prefix "subSecTimeDigitized"
    /// <summary>
    ///   <para>exif:tagNumber : 37521</para>
    ///   <para>rdfs:label : SubSecTimeOriginal</para>
    ///   <para>rdfs:comment : DateTimeOriginal subseconds</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#subSecTimeOriginal">exif:subSecTimeOriginal</a>
    /// </summary>
    let subSecTimeOriginal = _prefixId.prefix "subSecTimeOriginal"
    /// <summary>
    ///   <para>exif:tagNumber : 37396</para>
    ///   <para>rdfs:label : SubjectArea</para>
    ///   <para>rdfs:comment : The location and area of the main subject in the overall scene.rdfs:comment : 画面中の主たる被写体の位置。2値によるXY座標、3値による円、4値による長方形座標の3通りの示し方がある</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#subjectArea">exif:subjectArea</a>
    /// </summary>
    let subjectArea = _prefixId.prefix "subjectArea"
    /// <summary>
    ///   <para>exif:tagNumber : 37382</para>
    ///   <para>rdfs:label : SubjectDistance</para>
    ///   <para>rdfs:comment : The distance to the subject, given in meters. Note that if the numerator of the recorded value is FFFFFFFF.H, Infinity shall be indicated; and if the numerator is 0, Distance unknown shall be indicated.rdfs:comment : 被写体までの距離。単位はm</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#subjectDistance">exif:subjectDistance</a>
    /// </summary>
    let subjectDistance = _prefixId.prefix "subjectDistance"
    /// <summary>
    ///   <para>exif:tagNumber : 41996</para>
    ///   <para>rdfs:label : SubjectDistanceRange</para>
    ///   <para>rdfs:comment : The distance to the subject, such as Macro, Close View or Distant View.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#subjectDistanceRange">exif:subjectDistanceRange</a>
    /// </summary>
    let subjectDistanceRange = _prefixId.prefix "subjectDistanceRange"
    /// <summary>
    ///   <para>exif:tagNumber : 41492</para>
    ///   <para>rdfs:label : SubjectLocation</para>
    ///   <para>rdfs:comment : The location of the main subject in the scene. The value of this tag represents the pixel at the center of the main subject relative to the left edge, prior to rotation processing as per the Rotation tag. The first value indicates the X column number and second indicates the Y row number.rdfs:comment : 画面中の主要被写体のXY座標</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#subjectLocation">exif:subjectLocation</a>
    /// </summary>
    let subjectLocation = _prefixId.prefix "subjectLocation"
    let subsecond = _prefixId.prefix "subsecond"
    /// <summary>
    ///   <para>rdfs:label : Subseconds</para>
    ///   <para>rdfs:comment : A tag used to record fractions of seconds for a date property</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#subseconds">exif:subseconds</a>
    /// </summary>
    let subseconds = _prefixId.prefix "subseconds"
    let tagNumber = _prefixId.prefix "tagNumber"
    /// <summary>
    ///   <para>rdfs:label : Tag number</para>
    ///   <para>rdfs:comment : The Exif tag number</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#tag_number">exif:tag_number</a>
    /// </summary>
    let tag_number = _prefixId.prefix "tag_number"
    /// <summary>
    ///   <para>rdfs:label : Tag ID</para>
    ///   <para>rdfs:comment : The Exif tag number with context prefix, such as IFD type or maker name</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#tagid">exif:tagid</a>
    /// </summary>
    let tagid = _prefixId.prefix "tagid"
    /// <summary>
    ///   <para>exif:tagNumber : 301</para>
    ///   <para>rdfs:label : TransferFunction</para>
    ///   <para>rdfs:comment : A transfer function for the image, described in tabular style. Normally this tag is not necessary, since color space is specified in the color space information tag (ColorSpace).</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#transferFunction">exif:transferFunction</a>
    /// </summary>
    let transferFunction = _prefixId.prefix "transferFunction"
    /// <summary>
    ///   <para>exif:tagNumber : 37510</para>
    ///   <para>rdfs:label : UserComment</para>
    ///   <para>rdfs:comment : A tag for Exif users to write keywords or comments on the image besides those in ImageDescription, and without the character code limitations of the ImageDescription tag. The character code used in the UserComment tag is identified based on an ID code in a fixed 8-byte area at the start of the tag data area.rdfs:comment : ユーザーコメント。ImageDescriptionタグと違って、こちらはJIS2バイトコード、Unicode等での記述が許されており、最初の8バイトが文字コード</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#userComment">exif:userComment</a>
    /// </summary>
    let userComment = _prefixId.prefix "userComment"
    /// <summary>
    ///   <para>rdfs:label : User Info</para>
    ///   <para>rdfs:comment : An attribute relating to User Information</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#userInfo">exif:userInfo</a>
    /// </summary>
    let userInfo = _prefixId.prefix "userInfo"
    /// <summary>
    ///   <para>rdfs:label : Version Info</para>
    ///   <para>rdfs:comment : An attribute relating to Version</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#versionInfo">exif:versionInfo</a>
    /// </summary>
    let versionInfo = _prefixId.prefix "versionInfo"
    /// <summary>
    ///   <para>exif:tagNumber : 41987</para>
    ///   <para>rdfs:label : WhiteBalance</para>
    ///   <para>rdfs:comment : The white balance mode set when the image was shot.rdfs:comment : ホワイトバランスのモード</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#whiteBalance">exif:whiteBalance</a>
    /// </summary>
    let whiteBalance = _prefixId.prefix "whiteBalance"
    /// <summary>
    ///   <para>exif:tagNumber : 318</para>
    ///   <para>rdfs:label : WhitePoint</para>
    ///   <para>rdfs:comment : The chromaticity of the white point of the image. Normally this tag is not necessary, since color space is specified in the color space information tag (ColorSpace).rdfs:comment : 白点の色度。CIE Standard Illuminant D65(いわゆる昼光色の世界標準値)を使っていれば、'3127/10000,3290/10000'という値。通常はColorSpaceタグがあるので不要</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#whitePoint">exif:whitePoint</a>
    /// </summary>
    let whitePoint = _prefixId.prefix "whitePoint"
    /// <summary>
    ///   <para>rdfs:label : Width</para>
    ///   <para>rdfs:comment : Width of an object</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#width">exif:width</a>
    /// </summary>
    let width = _prefixId.prefix "width"
    /// <summary>
    ///   <para>exif:tagNumber : 282</para>
    ///   <para>rdfs:label : XResolution</para>
    ///   <para>rdfs:comment : The number of pixels per ResolutionUnit in the ImageWidth direction. When the image resolution is unknown, 72 [dpi] is designated.rdfs:comment : 画像の表示・印刷時の水平解像度</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#xResolution">exif:xResolution</a>
    /// </summary>
    let xResolution = _prefixId.prefix "xResolution"
    /// <summary>
    ///   <para>exif:tagNumber : 529</para>
    ///   <para>rdfs:label : YCbCrCoefficients</para>
    ///   <para>rdfs:comment : The matrix coefficients for transformation from RGB to YCbCr image data.rdfs:comment : RGB形式からYCbCr形式に変換するための3つの係数。通常は0.299、0.587、0.114という値</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#yCbCrCoefficients">exif:yCbCrCoefficients</a>
    /// </summary>
    let yCbCrCoefficients = _prefixId.prefix "yCbCrCoefficients"
    /// <summary>
    ///   <para>exif:tagNumber : 531</para>
    ///   <para>rdfs:label : YCbCrPositioning</para>
    ///   <para>rdfs:comment : The position of chrominance components in relation to the luminance component. This field is designated only for JPEG compressed data or uncompressed YCbCr data.rdfs:comment : 色情報のサンプリングを間引きしている場合に、色情報のサンプルポイントがどこになるか。1='centered'なら点集合の中央、2＝'co-sited'なら点集合の原点</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#yCbCrPositioning">exif:yCbCrPositioning</a>
    /// </summary>
    let yCbCrPositioning = _prefixId.prefix "yCbCrPositioning"
    /// <summary>
    ///   <para>exif:tagNumber : 530</para>
    ///   <para>rdfs:label : YCbCrSubSampling</para>
    ///   <para>rdfs:comment : The sampling ratio of chrominance components in relation to the luminance component. In JPEG compressed data a JPEG marker is used instead of this tag.</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#yCbCrSubSampling">exif:yCbCrSubSampling</a>
    /// </summary>
    let yCbCrSubSampling = _prefixId.prefix "yCbCrSubSampling"
    /// <summary>
    ///   <para>exif:tagNumber : 283</para>
    ///   <para>rdfs:label : YResolution</para>
    ///   <para>rdfs:comment : The number of pixels per ResolutionUnit in the ImageLength direction. The same value as XResolution is designated.rdfs:comment : 画像の表示・印刷時の垂直解像度</para>
    ///   <a href="http://www.w3.org/2003/12/exif/ns#yResolution">exif:yResolution</a>
    /// </summary>
    let yResolution = _prefixId.prefix "yResolution"
