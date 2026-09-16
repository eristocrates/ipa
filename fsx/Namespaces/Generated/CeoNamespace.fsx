#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ceo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#" "ceo"

    let A0 = _prefixId.prefix "A0"
    let A1 = _prefixId.prefix "A1"
    let A2 = _prefixId.prefix "A2"
    let A3 = _prefixId.prefix "A3"
    let A4 = _prefixId.prefix "A4"
    let A5 = _prefixId.prefix "A5"
    let A6 = _prefixId.prefix "A6"
    let A7 = _prefixId.prefix "A7"
    let A8 = _prefixId.prefix "A8"
    let A9 = _prefixId.prefix "A9"
    let AAC_LC = _prefixId.prefix "AAC-LC"
    let ACAdapter = _prefixId.prefix "ACAdapter"
    let AC_Cable = _prefixId.prefix "AC_Cable"
    let AIFF = _prefixId.prefix "AIFF"
    let AIPTEK = _prefixId.prefix "AIPTEK"
    let ALE = _prefixId.prefix "ALE"
    let AOC = _prefixId.prefix "AOC"
    let ASF = _prefixId.prefix "ASF"
    let ATEC = _prefixId.prefix "ATEC"
    let ATMT = _prefixId.prefix "ATMT"
    let AV = _prefixId.prefix "AV"
    let AVCH = _prefixId.prefix "AVCH"
    let AVI = _prefixId.prefix "AVI"
    let AV_Cable = _prefixId.prefix "AV_Cable"
    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : Accessoryrdfs:label : Zubehör</para>
    ///   <para>rdfs:comment : A subordinate or supplementary item; an adjunct.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Accessory">ceo:Accessory</a>
    /// </summary>
    let Accessory = _prefixId.prefix "Accessory"
    let Acer = _prefixId.prefix "Acer"
    let Actebis = _prefixId.prefix "Actebis"
    let Acuity = _prefixId.prefix "Acuity"
    let Agfa = _prefixId.prefix "Agfa"
    let Aigo = _prefixId.prefix "Aigo"
    let Aiwa = _prefixId.prefix "Aiwa"
    let Akai = _prefixId.prefix "Akai"
    let Alert = _prefixId.prefix "Alert"
    let Ambilight1 = _prefixId.prefix "Ambilight1"
    let AmbilightSpectra2 = _prefixId.prefix "AmbilightSpectra2"
    let AmbilightSpectra3 = _prefixId.prefix "AmbilightSpectra3"
    let AmbilightSpectraActiveFrame = _prefixId.prefix "AmbilightSpectraActiveFrame"
    let Analog = _prefixId.prefix "Analog"
    let Anti_ReflectionCoatedScreen = _prefixId.prefix "Anti-ReflectionCoatedScreen"
    let Apacer = _prefixId.prefix "Apacer"
    let Apple = _prefixId.prefix "Apple"
    let Archos = _prefixId.prefix "Archos"
    let Asus = _prefixId.prefix "Asus"
    let Audio2'_period_'5mm = _prefixId.prefix "Audio2.5mm"
    let Audio3'_period_'5mm = _prefixId.prefix "Audio3.5mm"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Audio Eigenschaftenrdfs:label : Audio Features</para>
    ///   <para>rdfs:comment : Additional audio equipment and abilities.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AudioFeatures">ceo:AudioFeatures</a>
    /// </summary>
    let AudioFeatures = _prefixId.prefix "AudioFeatures"
    let AudioInput = _prefixId.prefix "AudioInput"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player</para>
    ///   <para>rdfs:label : Audio Interface Typerdfs:label : Audioschnittstellentyp</para>
    ///   <para>rdfs:comment : Interface generally refers to an abstraction that an entity provides of itself to the outside (refers to audio output).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Interface (computer science)" (http://en.wikipedia.org/wiki/Interface_(computer_science)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AudioInterfaceType">ceo:AudioInterfaceType</a>
    /// </summary>
    let AudioInterfaceType = _prefixId.prefix "AudioInterfaceType"
    let AutoChannelSearch = _prefixId.prefix "AutoChannelSearch"
    let AutoVolumeLeveller = _prefixId.prefix "AutoVolumeLeveller"
    let AutoWhiteBalance = _prefixId.prefix "AutoWhiteBalance"
    let AutomaticPictureStabilizer = _prefixId.prefix "AutomaticPictureStabilizer"
    let Axago = _prefixId.prefix "Axago"
    let B0 = _prefixId.prefix "B0"
    let B1 = _prefixId.prefix "B1"
    let B2 = _prefixId.prefix "B2"
    let B3 = _prefixId.prefix "B3"
    let B4 = _prefixId.prefix "B4"
    let B5 = _prefixId.prefix "B5"
    let B6 = _prefixId.prefix "B6"
    let B7 = _prefixId.prefix "B7"
    let B8 = _prefixId.prefix "B8"
    let B9 = _prefixId.prefix "B9"
    let BacklightMode = _prefixId.prefix "BacklightMode"
    let BeachAndSnow = _prefixId.prefix "BeachAndSnow"
    let Beige = _prefixId.prefix "Beige"
    let Belkin = _prefixId.prefix "Belkin"
    let BenQ = _prefixId.prefix "BenQ"
    let Bitmap = _prefixId.prefix "Bitmap"
    let Black = _prefixId.prefix "Black"
    let Blue = _prefixId.prefix "Blue"
    let Bluetooth = _prefixId.prefix "Bluetooth"
    let BluetoothAudio = _prefixId.prefix "BluetoothAudio"
    let Brother = _prefixId.prefix "Brother"
    let Brown = _prefixId.prefix "Brown"
    let BuiltInSpeakers = _prefixId.prefix "BuiltInSpeakers"
    let CE_Mark = _prefixId.prefix "CE_Mark"
    let CGM = _prefixId.prefix "CGM"
    let CMOS = _prefixId.prefix "CMOS"
    let CTX = _prefixId.prefix "CTX"
    let CVBS_in = _prefixId.prefix "CVBS_in"
    let CVBS_out = _prefixId.prefix "CVBS_out"
    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : Camcorderrdfs:label : Camcorder</para>
    ///   <para>rdfs:comment : A camcorder is a portable consumer electronics device for recording video and audio using a built-in recorder unit.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Camcorder">ceo:Camcorder</a>
    /// </summary>
    let Camcorder = _prefixId.prefix "Camcorder"
    let Canon = _prefixId.prefix "Canon"
    let Canyon = _prefixId.prefix "Canyon"
    let Cardstock = _prefixId.prefix "Cardstock"
    let Casio = _prefixId.prefix "Casio"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Certificaterdfs:label : Zertifikat</para>
    ///   <para>rdfs:comment : A certificate is an official document affirming some fact like quality standards.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Certificate" (http://en.wikipedia.org/wiki/Certificate) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Certificate">ceo:Certificate</a>
    /// </summary>
    let Certificate = _prefixId.prefix "Certificate"
    let ChildSafetyLock = _prefixId.prefix "ChildSafetyLock"
    let Chimei = _prefixId.prefix "Chimei"
    let Clock = _prefixId.prefix "Clock"
    let Coby = _prefixId.prefix "Coby"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, TV, Printer, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Farberdfs:label : Color</para>
    ///   <para>rdfs:comment : Color derives from the spectrum of light interacting in the eye with the spectral sensitivities of the light receptors.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Color" (http://en.wikipedia.org/wiki/Color) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Color">ceo:Color</a>
    /// </summary>
    let Color = _prefixId.prefix "Color"
    let ColorPrint = _prefixId.prefix "ColorPrint"
    let CombFilter = _prefixId.prefix "CombFilter"
    let CommonInterface = _prefixId.prefix "CommonInterface"
    let CompactFlash = _prefixId.prefix "CompactFlash"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, Printer, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Kompatible Betriebssytemerdfs:label : Compatible Operating Systems</para>
    ///   <para>rdfs:comment : Ability to communicate with different kinds of operating systems.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CompatibleOperatingSystems">ceo:CompatibleOperatingSystems</a>
    /// </summary>
    let CompatibleOperatingSystems = _prefixId.prefix "CompatibleOperatingSystems"
    let ComponentVideoIn = _prefixId.prefix "ComponentVideoIn"
    let ComponentVideoOut = _prefixId.prefix "ComponentVideoOut"
    let CompositeVideoIn = _prefixId.prefix "CompositeVideoIn"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Computerbildschirmauflösungrdfs:label : Computer display resolution</para>
    ///   <para>rdfs:comment : The display resolution of a computer display typically refers to the number of distinct pixels in each dimension that can be displayed.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Display resolution" (http://en.wikipedia.org/wiki/Display_resolution) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ComputerDisplayResolution">ceo:ComputerDisplayResolution</a>
    /// </summary>
    let ComputerDisplayResolution = _prefixId.prefix "ComputerDisplayResolution"

    let ComputerDisplayResolution_1024x768_60_70_75_85Hz = _prefixId.prefix "ComputerDisplayResolution_1024x768_60_70_75_85Hz"

    let ComputerDisplayResolution_640x480_60_72_75_85Hz = _prefixId.prefix "ComputerDisplayResolution_640x480_60_72_75_85Hz"

    let ComputerDisplayResolution_800x600_60_72_75_85Hz = _prefixId.prefix "ComputerDisplayResolution_800x600_60_72_75_85Hz"

    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Connectivityrdfs:label : Verbindungsmöglichkeit</para>
    ///   <para>rdfs:comment : A generic term for linking devices to each other and allow sending data in one or both directions.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Connectivity">ceo:Connectivity</a>
    /// </summary>
    let Connectivity = _prefixId.prefix "Connectivity"
    let ContrastPlus = _prefixId.prefix "ContrastPlus"
    let Cowon = _prefixId.prefix "Cowon"
    let Creative_Labs = _prefixId.prefix "Creative_Labs"
    let DC_Cable = _prefixId.prefix "DC_Cable"
    let DK_digital = _prefixId.prefix "DK_digital"
    let DL = _prefixId.prefix "DL"
    let DLNA_Ethernet = _prefixId.prefix "DLNA_Ethernet"
    let DOC = _prefixId.prefix "DOC"
    let DPOF = _prefixId.prefix "DPOF"
    let DV = _prefixId.prefix "DV"
    let DVB = _prefixId.prefix "DVB"
    let DVB_T = _prefixId.prefix "DVB-T"
    let DVB_COFDM = _prefixId.prefix "DVB_COFDM"
    let DVI = _prefixId.prefix "DVI"
    let DVI_in = _prefixId.prefix "DVI_in"
    let DVI_out = _prefixId.prefix "DVI_out"
    let Daewoo = _prefixId.prefix "Daewoo"
    let Dane_Elec = _prefixId.prefix "Dane-Elec"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Datenformatrdfs:label : Data Format</para>
    ///   <para>rdfs:comment : A data format is a particular way to encode information for storage in a computer file.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "File Format" (http://en.wikipedia.org/wiki/File_format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DataFormat">ceo:DataFormat</a>
    /// </summary>
    let DataFormat = _prefixId.prefix "DataFormat"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Audio Datenformatrdfs:label : Data Format Audio</para>
    ///   <para>rdfs:comment : A data format is a particular way to encode information for storage in a computer file (refers to audiodata).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "File Format" (http://en.wikipedia.org/wiki/File_format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DataFormatAudio">ceo:DataFormatAudio</a>
    /// </summary>
    let DataFormatAudio = _prefixId.prefix "DataFormatAudio"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Data Format Imagerdfs:label : Graphik Datenformat</para>
    ///   <para>rdfs:comment : A data format is a particular way to encode information for storage in a computer file (refers to image data).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "File Format" (http://en.wikipedia.org/wiki/File_format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DataFormatImage">ceo:DataFormatImage</a>
    /// </summary>
    let DataFormatImage = _prefixId.prefix "DataFormatImage"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, DigitalCamera</para>
    ///   <para>rdfs:label : Büro Datenformatrdfs:label : Data Format Office</para>
    ///   <para>rdfs:comment : A data format is a particular way to encode information for storage in a computer file (refers to office data).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "File Format" (http://en.wikipedia.org/wiki/File_format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DataFormatOffice">ceo:DataFormatOffice</a>
    /// </summary>
    let DataFormatOffice = _prefixId.prefix "DataFormatOffice"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Video Datenformatrdfs:label : Data Format Video</para>
    ///   <para>rdfs:comment : A data format is a particular way to encode information for storage in a computer file (refers to video data).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "File Format" (http://en.wikipedia.org/wiki/File_format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DataFormatVideo">ceo:DataFormatVideo</a>
    /// </summary>
    let DataFormatVideo = _prefixId.prefix "DataFormatVideo"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, Printer, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Data Interface Typerdfs:label : Datenschnittstellentyp</para>
    ///   <para>rdfs:comment : Interface generally refers to an abstraction that an entity provides of itself to the outside.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Interface (computer science)" (http://en.wikipedia.org/wiki/Interface_(computer_science)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DataInterfaceType">ceo:DataInterfaceType</a>
    /// </summary>
    let DataInterfaceType = _prefixId.prefix "DataInterfaceType"
    let Decktron = _prefixId.prefix "Decktron"
    let Dell = _prefixId.prefix "Dell"
    let Denver = _prefixId.prefix "Denver"
    let Differo = _prefixId.prefix "Differo"
    let Difrnce = _prefixId.prefix "Difrnce"
    let Digital = _prefixId.prefix "Digital"
    let DigitalAudioCoaxialOut = _prefixId.prefix "DigitalAudioCoaxialOut"
    let DigitalAudioOpticalOut = _prefixId.prefix "DigitalAudioOpticalOut"
    /// <summary>
    ///   <para>ceo:belongsToModule : DigitalCamera^^xsd:string</para>
    ///   <para>rdfs:label : Digitalkamerardfs:label : Digital camera</para>
    ///   <para>rdfs:comment : A digital camera (or digicam for short) is a camera that takes video or still photographs, or both, digitally by recording images via an electronic image sensor.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital camera" (http://en.wikipedia.org/wiki/Digital_camera) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DigitalCamera">ceo:DigitalCamera</a>
    /// </summary>
    let DigitalCamera = _prefixId.prefix "DigitalCamera"
    let DigitalCrystalClear = _prefixId.prefix "DigitalCrystalClear"
    let DigitalImageScalingTechnology = _prefixId.prefix "DigitalImageScalingTechnology"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, TV, Printer, Camcorder</para>
    ///   <para>rdfs:label : Display Typerdfs:label : Bildschirmtyp</para>
    ///   <para>rdfs:comment : A display device is an output device for presentation of information for visual, tactile or auditive reception, acquired, stored, or transmitted in various forms.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Display device" (http://en.wikipedia.org/wiki/Display_device) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DisplayType">ceo:DisplayType</a>
    /// </summary>
    let DisplayType = _prefixId.prefix "DisplayType"
    let DisposableBattery = _prefixId.prefix "DisposableBattery"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Disposable Energy Sourcerdfs:label : Einweg-Energiequelle</para>
    ///   <para>rdfs:comment : Disposable batteries are non-rechargeable batteries. When they are out of power you have to dispose them.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DisposableEnergySource">ceo:DisposableEnergySource</a>
    /// </summary>
    let DisposableEnergySource = _prefixId.prefix "DisposableEnergySource"
    let DocumentViewing = _prefixId.prefix "DocumentViewing"
    let DolbyDigital = _prefixId.prefix "DolbyDigital"
    let DuplexPrint = _prefixId.prefix "DuplexPrint"
    let DynamicBassEnhancement = _prefixId.prefix "DynamicBassEnhancement"
    let EDTV_480p = _prefixId.prefix "EDTV_480p"
    let EPG = _prefixId.prefix "EPG"
    let Eaconn = _prefixId.prefix "Eaconn"
    let EconomicalMode = _prefixId.prefix "EconomicalMode"
    let Eizo = _prefixId.prefix "Eizo"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, Printer, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Energy Sourcerdfs:label : Energiequelle</para>
    ///   <para>rdfs:comment : Methods of energy storage have been developed, which transform electrical energy into forms of potential energy.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Energy development" (http://en.wikipedia.org/wiki/Energy_development) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#EnergySource">ceo:EnergySource</a>
    /// </summary>
    let EnergySource = _prefixId.prefix "EnergySource"
    let Energy_Sistem = _prefixId.prefix "Energy_Sistem"
    let Envelope = _prefixId.prefix "Envelope"
    let Epson = _prefixId.prefix "Epson"
    let Equalizer = _prefixId.prefix "Equalizer"
    let Esselte = _prefixId.prefix "Esselte"
    let FLAC = _prefixId.prefix "FLAC"
    let FaceIdendification = _prefixId.prefix "FaceIdendification"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, TV, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Featuresrdfs:label : Eigenschaften</para>
    ///   <para>rdfs:comment : Additional equipment and abilities.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Features">ceo:Features</a>
    /// </summary>
    let Features = _prefixId.prefix "Features"
    let Finlux = _prefixId.prefix "Finlux"
    let FirmwareUpgradable = _prefixId.prefix "FirmwareUpgradable"
    let Flash = _prefixId.prefix "Flash"
    /// <summary>
    ///   <para>ceo:belongsToModule : DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Fokusrdfs:label : Focus</para>
    ///   <para>rdfs:comment : A focus, also called an image point, is the point where light rays originating from a point on the object converge.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Focus (optics)" (http://en.wikipedia.org/wiki/Focus_(optics)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Focus">ceo:Focus</a>
    /// </summary>
    let Focus = _prefixId.prefix "Focus"
    let FocusAuto = _prefixId.prefix "FocusAuto"
    let FocusFixed = _prefixId.prefix "FocusFixed"
    let FocusManual = _prefixId.prefix "FocusManual"
    let Format5'_period_'1ch = _prefixId.prefix "Format5.1ch"
    let Freecom = _prefixId.prefix "Freecom"
    let Fujifilm = _prefixId.prefix "Fujifilm"
    let Fujitsu_Siemens = _prefixId.prefix "Fujitsu_Siemens"
    let FullHD = _prefixId.prefix "FullHD"
    let G4_Class_Processor = _prefixId.prefix "G4_Class_Processor"
    let GE = _prefixId.prefix "GE"
    let GIF = _prefixId.prefix "GIF"
    let GNR = _prefixId.prefix "GNR"
    let GameMode = _prefixId.prefix "GameMode"
    let Gembird = _prefixId.prefix "Gembird"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Allgemeine Eigenschaftenrdfs:label : General Features</para>
    ///   <para>rdfs:comment : Additional general equipment and abilities.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#GeneralFeatures">ceo:GeneralFeatures</a>
    /// </summary>
    let GeneralFeatures = _prefixId.prefix "GeneralFeatures"
    let Gold = _prefixId.prefix "Gold"
    let Green = _prefixId.prefix "Green"
    let Grey = _prefixId.prefix "Grey"
    let Griffin = _prefixId.prefix "Griffin"
    let Grundig = _prefixId.prefix "Grundig"
    let Guillemot = _prefixId.prefix "Guillemot"
    let H'_period_'264 = _prefixId.prefix "H.264"
    let HDMI = _prefixId.prefix "HDMI"
    let HDMI_Interface = _prefixId.prefix "HDMI_Interface"
    let HDTV_1080i = _prefixId.prefix "HDTV_1080i"
    let HDTV_1080p = _prefixId.prefix "HDTV_1080p"
    let HDTV_720p = _prefixId.prefix "HDTV_720p"
    let HP = _prefixId.prefix "HP"
    let HP_FastRes_1200_DPI = _prefixId.prefix "HP_FastRes_1200_DPI"
    let HP_REt = _prefixId.prefix "HP_REt"
    let Haier = _prefixId.prefix "Haier"
    let Hannspree = _prefixId.prefix "Hannspree"
    let Harwa = _prefixId.prefix "Harwa"
    let HeadphoneLineOut_2'_period_'5mm = _prefixId.prefix "HeadphoneLineOut_2.5mm"
    let HeadphoneLineOut_3'_period_'5mm = _prefixId.prefix "HeadphoneLineOut_3.5mm"
    let Headphones = _prefixId.prefix "Headphones"
    let Hisense = _prefixId.prefix "Hisense"
    let Hitachi = _prefixId.prefix "Hitachi"
    let Humax = _prefixId.prefix "Humax"
    let Hyperband = _prefixId.prefix "Hyperband"
    let Hyundai = _prefixId.prefix "Hyundai"
    let IBM = _prefixId.prefix "IBM"
    let IEEE_1394 = _prefixId.prefix "IEEE_1394"
    let IEEE_802'_period_'11 = _prefixId.prefix "IEEE_802.11"
    let IR_Remote = _prefixId.prefix "IR_Remote"
    let Iiyama = _prefixId.prefix "Iiyama"
    let InFocus = _prefixId.prefix "InFocus"
    let IncredibleSurround = _prefixId.prefix "IncredibleSurround"
    let IndoorWhiteBalance = _prefixId.prefix "IndoorWhiteBalance"
    let InfoPrint = _prefixId.prefix "InfoPrint"
    let Infrared = _prefixId.prefix "Infrared"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Tintenstrahldruckerrdfs:label : Inkjet printer</para>
    ///   <para>rdfs:comment : Inkjet printers operate by propelling variably-sized droplets of liquid or molten material (ink) onto almost any sized page.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Inkjet printer" (http://en.wikipedia.org/wiki/Inkjet_printer) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#InkjetPrinter">ceo:InkjetPrinter</a>
    /// </summary>
    let InkjetPrinter = _prefixId.prefix "InkjetPrinter"
    let IntegratedClock = _prefixId.prefix "IntegratedClock"
    let Intenso = _prefixId.prefix "Intenso"
    let InternalFlashMemory = _prefixId.prefix "InternalFlashMemory"
    let InternalHDD = _prefixId.prefix "InternalHDD"
    let Intuix = _prefixId.prefix "Intuix"
    let JPEG = _prefixId.prefix "JPEG"
    let JVC = _prefixId.prefix "JVC"
    let Kodak = _prefixId.prefix "Kodak"
    let Konica_Minolta = _prefixId.prefix "Konica_Minolta"
    let Kye_Genius = _prefixId.prefix "Kye_Genius"
    let Kyocera = _prefixId.prefix "Kyocera"
    let LCD = _prefixId.prefix "LCD"
    let LG = _prefixId.prefix "LG"
    let Label = _prefixId.prefix "Label"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Etikettendruckerrdfs:label : Label printer</para>
    ///   <para>rdfs:comment : A label printer is a computer peripheral that prints on self-adhesive label material and sometimes card-stock (also called tags).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#LabelPrinter">ceo:LabelPrinter</a>
    /// </summary>
    let LabelPrinter = _prefixId.prefix "LabelPrinter"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Laser printerrdfs:label : Laserdrucker</para>
    ///   <para>rdfs:comment : A laser printer is a common type of computer printer that rapidly produces high quality text and graphics on plain paper.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Laser printer" (http://en.wikipedia.org/wiki/Laser_printer) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#LaserPrinter">ceo:LaserPrinter</a>
    /// </summary>
    let LaserPrinter = _prefixId.prefix "LaserPrinter"
    let LaserPrintingPaper = _prefixId.prefix "LaserPrintingPaper"
    let Lavod = _prefixId.prefix "Lavod"
    let Lenco = _prefixId.prefix "Lenco"
    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : Lens systemrdfs:label : Objektivsystem</para>
    ///   <para>rdfs:comment : A lens is an optical device with perfect or approximate axial symmetry which transmits and refracts light, converging or diverging the beam.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Lens (optics)" (http://en.wikipedia.org/wiki/Lens_(optics)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#LensSystem">ceo:LensSystem</a>
    /// </summary>
    let LensSystem = _prefixId.prefix "LensSystem"
    let Lexar = _prefixId.prefix "Lexar"
    let Lexmark = _prefixId.prefix "Lexmark"
    let Li_Ion_Polymer = _prefixId.prefix "Li-Ion_Polymer"
    let LightExposureControl = _prefixId.prefix "LightExposureControl"
    let LineInRecorder = _prefixId.prefix "LineInRecorder"
    let Linux = _prefixId.prefix "Linux"
    let Lit_Ion = _prefixId.prefix "Lit-Ion"
    let Logitech = _prefixId.prefix "Logitech"
    let MMC = _prefixId.prefix "MMC"
    let MOV = _prefixId.prefix "MOV"
    let MP3 = _prefixId.prefix "MP3"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player</para>
    ///   <para>rdfs:label : MP3-Playerrdfs:label : MP3-Player</para>
    ///   <para>rdfs:comment : Playback equipment for certain data formats, especially audio data. Product is often equipped with some scope of delivery. Especially earphones, booklet, sotwareCD, charger and datacable.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MP3Player">ceo:MP3Player</a>
    /// </summary>
    let MP3Player = _prefixId.prefix "MP3Player"
    let MP4_Audio = _prefixId.prefix "MP4_Audio"
    let MP4_Video = _prefixId.prefix "MP4_Video"
    let MPEG = _prefixId.prefix "MPEG"
    let MPIO = _prefixId.prefix "MPIO"
    let MPMAN = _prefixId.prefix "MPMAN"
    let MSI = _prefixId.prefix "MSI"
    let MacOSXCheetah = _prefixId.prefix "MacOSXCheetah"
    let MacOSXJaguar = _prefixId.prefix "MacOSXJaguar"
    let MacOSXLeopard = _prefixId.prefix "MacOSXLeopard"
    let MacOSXPanther = _prefixId.prefix "MacOSXPanther"
    let MacOSXPuma = _prefixId.prefix "MacOSXPuma"
    let MacOSXSnowLeopard = _prefixId.prefix "MacOSXSnowLeopard"
    let MacOSXTiger = _prefixId.prefix "MacOSXTiger"
    let Maxfield = _prefixId.prefix "Maxfield"
    let MediaFormaPostcard = _prefixId.prefix "MediaFormaPostcard"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Media formatrdfs:label : Medienformat</para>
    ///   <para>rdfs:comment : Sizes and shapes of the paper.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MediaFormat">ceo:MediaFormat</a>
    /// </summary>
    let MediaFormat = _prefixId.prefix "MediaFormat"
    let MediaFormatEnvelope = _prefixId.prefix "MediaFormatEnvelope"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Media type^^xsd:stringrdfs:label : Mediumart</para>
    ///   <para>rdfs:comment : The type of paper a device is able to handle.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MediaType">ceo:MediaType</a>
    /// </summary>
    let MediaType = _prefixId.prefix "MediaType"
    let Medion = _prefixId.prefix "Medion"
    let Memorex = _prefixId.prefix "Memorex"
    let MemoryStick = _prefixId.prefix "MemoryStick"
    let Memup = _prefixId.prefix "Memup"
    let MicroDrive = _prefixId.prefix "MicroDrive"
    let Microphon = _prefixId.prefix "Microphon"
    let Microsoft = _prefixId.prefix "Microsoft"
    let MiniUSB = _prefixId.prefix "MiniUSB"
    let Mirai = _prefixId.prefix "Mirai"
    let Monochrome = _prefixId.prefix "Monochrome"
    let Multicolor = _prefixId.prefix "Multicolor"
    let MulticoloredBody = _prefixId.prefix "MulticoloredBody"
    let Mustek = _prefixId.prefix "Mustek"
    let NEC = _prefixId.prefix "NEC"
    let NICAM = _prefixId.prefix "NICAM"
    let NIH2 = _prefixId.prefix "NIH2"
    let NTSC = _prefixId.prefix "NTSC"
    let Nanopoint = _prefixId.prefix "Nanopoint"
    let Navy = _prefixId.prefix "Navy"
    let Netgear = _prefixId.prefix "Netgear"
    let New_Universe = _prefixId.prefix "New_Universe"
    let NiCd = _prefixId.prefix "NiCd"
    let NiMH = _prefixId.prefix "NiMH"
    let NightMode = _prefixId.prefix "NightMode"
    let Nikon = _prefixId.prefix "Nikon"
    let Nintendo = _prefixId.prefix "Nintendo"
    let NoiseReduction = _prefixId.prefix "NoiseReduction"
    let Nokia = _prefixId.prefix "Nokia"
    let ODYS = _prefixId.prefix "ODYS"
    let OGG = _prefixId.prefix "OGG"
    let Oki = _prefixId.prefix "Oki"
    let Olive = _prefixId.prefix "Olive"
    let Olivetti = _prefixId.prefix "Olivetti"
    let Olympus = _prefixId.prefix "Olympus"
    let OnOffTimer = _prefixId.prefix "OnOffTimer"
    let OnScreenDisplay = _prefixId.prefix "OnScreenDisplay"
    let OneStepFixed = _prefixId.prefix "OneStepFixed"
    let Oppo = _prefixId.prefix "Oppo"
    let Orange = _prefixId.prefix "Orange"
    let Orion = _prefixId.prefix "Orion"
    let OutdoorWhiteBalance = _prefixId.prefix "OutdoorWhiteBalance"
    let PAL = _prefixId.prefix "PAL"
    let PAL_B_G = _prefixId.prefix "PAL-B_G"
    let PAL_I = _prefixId.prefix "PAL-I"
    let PAL_L = _prefixId.prefix "PAL-L"
    let PCAudioIn = _prefixId.prefix "PCAudioIn"
    let PCIn = _prefixId.prefix "PCIn"
    let PCMCIA = _prefixId.prefix "PCMCIA"
    let PDF = _prefixId.prefix "PDF"
    let PDP = _prefixId.prefix "PDP"
    let PNG = _prefixId.prefix "PNG"
    let PQI = _prefixId.prefix "PQI"
    let PSD = _prefixId.prefix "PSD"
    let Pacific_Digital = _prefixId.prefix "Pacific_Digital"
    let PackardBell = _prefixId.prefix "PackardBell"
    let Palm = _prefixId.prefix "Palm"
    let Panasonic = _prefixId.prefix "Panasonic"
    let Pendrive = _prefixId.prefix "Pendrive"
    let Pentax = _prefixId.prefix "Pentax"
    let PerfectPixelHD = _prefixId.prefix "PerfectPixelHD"
    let Philips = _prefixId.prefix "Philips"
    let Phillar = _prefixId.prefix "Phillar"
    let Phoenix = _prefixId.prefix "Phoenix"
    let PhotoMode = _prefixId.prefix "PhotoMode"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Photo printerrdfs:label : Fotodrucker</para>
    ///   <para>rdfs:comment : A photo printer is a printer that is specifically designed to print high quality digital photos on photo paper.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Photo printer" (http://en.wikipedia.org/wiki/Photo_printer) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PhotoPrinter">ceo:PhotoPrinter</a>
    /// </summary>
    let PhotoPrinter = _prefixId.prefix "PhotoPrinter"
    let Photopaper = _prefixId.prefix "Photopaper"
    let PictBridge = _prefixId.prefix "PictBridge"
    let PictureInPicture = _prefixId.prefix "PictureInPicture"
    let PictureViewing = _prefixId.prefix "PictureViewing"
    let Pink = _prefixId.prefix "Pink"
    let Pioneer = _prefixId.prefix "Pioneer"
    let PixelPlus2 = _prefixId.prefix "PixelPlus2"
    let PixelPlus3HD = _prefixId.prefix "PixelPlus3HD"
    let PixelPlusHD = _prefixId.prefix "PixelPlusHD"
    let PlainPaper = _prefixId.prefix "PlainPaper"
    let Playlist = _prefixId.prefix "Playlist"
    let PlugAndPlay = _prefixId.prefix "PlugAndPlay"
    let Polaroid = _prefixId.prefix "Polaroid"
    let Portrait = _prefixId.prefix "Portrait"
    let Postcard = _prefixId.prefix "Postcard"
    let PowerLED = _prefixId.prefix "PowerLED"
    let PowerPC_32_bit = _prefixId.prefix "PowerPC_32_bit"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, Printer, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Power Supply Unitrdfs:label : Netzgerät</para>
    ///   <para>rdfs:comment : A Power Supply Adapter is used to convert 120 or 240 volt AC supplied by a utility company to a well-regulated lower voltage DC for electronic devices.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Power supply" (http://en.wikipedia.org/wiki/Power_supply) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PowerSupplyUnit">ceo:PowerSupplyUnit</a>
    /// </summary>
    let PowerSupplyUnit = _prefixId.prefix "PowerSupplyUnit"
    let Prestigio = _prefixId.prefix "Prestigio"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Druckauflösungrdfs:label : Print resolution</para>
    ///   <para>rdfs:comment : Defines the maximum digital resolution the device is able to print.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PrintResolution">ceo:PrintResolution</a>
    /// </summary>
    let PrintResolution = _prefixId.prefix "PrintResolution"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Printerrdfs:label : Drucker</para>
    ///   <para>rdfs:comment : A peripheral which produces a hard copy (permanent human-readable text and/or graphics) of documents stored in electronic form, usually on physical print media such as paper or transparencies.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Printer" (http://en.wikipedia.org/wiki/Computer_printer) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Printer">ceo:Printer</a>
    /// </summary>
    let Printer = _prefixId.prefix "Printer"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Processor typerdfs:label : Prozessorart</para>
    ///   <para>rdfs:comment : The type of central processing unit (CPU) as an electronic circuit that can execute printing tasks or programs.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ProcessorType">ceo:ProcessorType</a>
    /// </summary>
    let ProcessorType = _prefixId.prefix "ProcessorType"
    let ProgressiveScan = _prefixId.prefix "ProgressiveScan"
    let Purple = _prefixId.prefix "Purple"
    let RF = _prefixId.prefix "RF"
    let RGB = _prefixId.prefix "RGB"
    let RISC = _prefixId.prefix "RISC"
    let RS_232 = _prefixId.prefix "RS-232"
    let Radio = _prefixId.prefix "Radio"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Wiederaufladbare Energiequellerdfs:label : Rechargeable Energy Source</para>
    ///   <para>rdfs:comment : A rechargeable battery is a kind of energy source that is able to be reused by refilling it with a charger.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#RechargeableEnergySource">ceo:RechargeableEnergySource</a>
    /// </summary>
    let RechargeableEnergySource = _prefixId.prefix "RechargeableEnergySource"
    let Red = _prefixId.prefix "Red"
    let RedEyeReduction = _prefixId.prefix "RedEyeReduction"
    let Ricatech = _prefixId.prefix "Ricatech"
    let Ricoh = _prefixId.prefix "Ricoh"
    let RoHS = _prefixId.prefix "RoHS"
    let S_Video_in = _prefixId.prefix "S-Video_in"
    let S_Video_out = _prefixId.prefix "S-Video_out"
    let SCART = _prefixId.prefix "SCART"
    let SD = _prefixId.prefix "SD"
    let SDHC = _prefixId.prefix "SDHC"
    let SDTV_480i = _prefixId.prefix "SDTV_480i"
    let SDTV_576i = _prefixId.prefix "SDTV_576i"
    let SECAM = _prefixId.prefix "SECAM"
    let SECAM_B_G = _prefixId.prefix "SECAM-B_G"
    let SECAM_D_K = _prefixId.prefix "SECAM-D_K"
    let SECAM_L = _prefixId.prefix "SECAM-L"
    let SIGMA = _prefixId.prefix "SIGMA"
    let SMS = _prefixId.prefix "SMS"
    let SVG = _prefixId.prefix "SVG"
    let Sagem = _prefixId.prefix "Sagem"
    let Salora = _prefixId.prefix "Salora"
    let Samsung = _prefixId.prefix "Samsung"
    let SanDisk = _prefixId.prefix "SanDisk"
    let Sanyo = _prefixId.prefix "Sanyo"
    let Sapphire = _prefixId.prefix "Sapphire"
    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : Szenenmodusrdfs:label : Scene mode</para>
    ///   <para>rdfs:comment : A projection of information from any physical environment into any sensory system.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SceneMode">ceo:SceneMode</a>
    /// </summary>
    let SceneMode = _prefixId.prefix "SceneMode"
    let ScreenFormatAdjustments = _prefixId.prefix "ScreenFormatAdjustments"
    let Seiko = _prefixId.prefix "Seiko"
    let SelfTimer = _prefixId.prefix "SelfTimer"
    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : Sensor typerdfs:label : Sensorart</para>
    ///   <para>rdfs:comment : Type of device that measures a physical quantity and converts it into a signal which can be read by an observer or by an instrument.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Sensor" (http://en.wikipedia.org/wiki/Sensor) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SensorType">ceo:SensorType</a>
    /// </summary>
    let SensorType = _prefixId.prefix "SensorType"
    let SensorType_3CCD = _prefixId.prefix "SensorType_3CCD"
    let Sharkoon = _prefixId.prefix "Sharkoon"
    let Sharp = _prefixId.prefix "Sharp"
    let Shuffle = _prefixId.prefix "Shuffle"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Signal formatrdfs:label : Signalformat</para>
    ///   <para>rdfs:comment : Type of the transmitted video format signal that is displayed by a monitor or TV panel.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SignalFormat">ceo:SignalFormat</a>
    /// </summary>
    let SignalFormat = _prefixId.prefix "SignalFormat"
    let Silver = _prefixId.prefix "Silver"
    let Sitecom = _prefixId.prefix "Sitecom"
    let SleepTimer = _prefixId.prefix "SleepTimer"
    let SmartMediaCard = _prefixId.prefix "SmartMediaCard"
    let SmartSoundControl = _prefixId.prefix "SmartSoundControl"
    let Smartdisk = _prefixId.prefix "Smartdisk"
    let Snapshot = _prefixId.prefix "Snapshot"
    let Solar = _prefixId.prefix "Solar"
    let Sony = _prefixId.prefix "Sony"
    let Sports = _prefixId.prefix "Sports"
    let Spotlight = _prefixId.prefix "Spotlight"
    let StandbyLED = _prefixId.prefix "StandbyLED"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Storage Mediardfs:label : Speichermedium</para>
    ///   <para>rdfs:comment : A data storage device is a device for recording (storing) information (data).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Data Storage Device" (http://en.wikipedia.org/wiki/Data_storage_device) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#StorageMedia">ceo:StorageMedia</a>
    /// </summary>
    let StorageMedia = _prefixId.prefix "StorageMedia"
    let SubwooferOut = _prefixId.prefix "SubwooferOut"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Supported resolutionrdfs:label : Unterstützte Auflösung</para>
    ///   <para>rdfs:comment : Resolution supported by an electronical device.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SupportedResolution">ceo:SupportedResolution</a>
    /// </summary>
    let SupportedResolution = _prefixId.prefix "SupportedResolution"
    let Sweex = _prefixId.prefix "Sweex"
    let TEAC = _prefixId.prefix "TEAC"
    let TIFF = _prefixId.prefix "TIFF"
    let TRSConnector = _prefixId.prefix "TRSConnector"
    let TRUST = _prefixId.prefix "TRUST"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : TVrdfs:label : TV</para>
    ///   <para>rdfs:comment : Television (TV) is a widely used telecommunication medium for transmitting and receiving moving images, either monochromatic ("black and white") or color, usually accompanied by sound. Is often deliverd with a remote control and a manual.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "TV" (http://en.wikipedia.org/wiki/Tv) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TV">ceo:TV</a>
    /// </summary>
    let TV = _prefixId.prefix "TV"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Fernsehbildschirmauflösungrdfs:label : TV display resolution</para>
    ///   <para>rdfs:comment : The display resolution of a digital television or display typically refers to the number of distinct pixels in each dimension that can be displayed.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Display resolution" (http://en.wikipedia.org/wiki/Display_resolution) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)^^xsd:string</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TVDisplayResolution">ceo:TVDisplayResolution</a>
    /// </summary>
    let TVDisplayResolution = _prefixId.prefix "TVDisplayResolution"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : TV Tunerrdfs:label : TV Tuner</para>
    ///   <para>rdfs:comment : A television tuner converts an RF television transmission into audio and video signals which can be further processed to produce sound and a picture.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Tuner (electronics)" (http://en.wikipedia.org/wiki/Tuner_(electronics)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)^^xsd:string</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TVTuner">ceo:TVTuner</a>
    /// </summary>
    let TVTuner = _prefixId.prefix "TVTuner"
    let TXT = _prefixId.prefix "TXT"
    let TakeMS = _prefixId.prefix "TakeMS"
    let TallyGenicom = _prefixId.prefix "TallyGenicom"
    let Tatung = _prefixId.prefix "Tatung"
    let TechniSat = _prefixId.prefix "TechniSat"
    let Techsolo = _prefixId.prefix "Techsolo"
    let Tektronix = _prefixId.prefix "Tektronix"
    let TeletextFunction = _prefixId.prefix "TeletextFunction"
    let TextViewing = _prefixId.prefix "TextViewing"
    let Thomson = _prefixId.prefix "Thomson"
    let Timer = _prefixId.prefix "Timer"
    let Toshiba = _prefixId.prefix "Toshiba"
    let Transcend = _prefixId.prefix "Transcend"
    let Transparency = _prefixId.prefix "Transparency"
    let TrekStor = _prefixId.prefix "TrekStor"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Tuner typerdfs:label : Tuner Typ</para>
    ///   <para>rdfs:comment : Type of TV tuner that is used to convert RF television transmissions into audio and video signals.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Tuner (electronics)" (http://en.wikipedia.org/wiki/Tuner_(electronics)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TunerType">ceo:TunerType</a>
    /// </summary>
    let TunerType = _prefixId.prefix "TunerType"
    let TwinMOS = _prefixId.prefix "TwinMOS"
    let Typhoon = _prefixId.prefix "Typhoon"
    let UHF = _prefixId.prefix "UHF"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, Printer, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : USBrdfs:label : USB</para>
    ///   <para>rdfs:comment : Universal Serial Bus (USB) is a serial bus standard to connect devices to a host computer.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Universal Serial Bus" (http://en.wikipedia.org/wiki/Universal_Serial_Bus) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#USB">ceo:USB</a>
    /// </summary>
    let USB = _prefixId.prefix "USB"
    let USB1'_period_'0 = _prefixId.prefix "USB1.0"
    let USB2'_period_'0 = _prefixId.prefix "USB2.0"
    let USB3'_period_'0 = _prefixId.prefix "USB3.0"
    let USBEnergyInterface = _prefixId.prefix "USBEnergyInterface"
    let USB_Cable = _prefixId.prefix "USB_Cable"
    let V7 = _prefixId.prefix "V7"
    let VHF = _prefixId.prefix "VHF"
    let VIVOTEK = _prefixId.prefix "VIVOTEK"
    let Verbatim = _prefixId.prefix "Verbatim"
    let Vestel = _prefixId.prefix "Vestel"
    let Victory = _prefixId.prefix "Victory"
    let VideoComponent_Cable = _prefixId.prefix "VideoComponent_Cable"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Video Eigenschaftenrdfs:label : Video Features</para>
    ///   <para>rdfs:comment : Additional video equipment and abilities.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#VideoFeatures">ceo:VideoFeatures</a>
    /// </summary>
    let VideoFeatures = _prefixId.prefix "VideoFeatures"
    let VideoPlayBack = _prefixId.prefix "VideoPlayBack"
    let VideoRecording = _prefixId.prefix "VideoRecording"
    /// <summary>
    ///   <para>ceo:belongsToModule : DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Bildsucherrdfs:label : Viewfinder</para>
    ///   <para>rdfs:comment : A viewfinder is what the photographer looks through to compose, and in many cases to focus, the picture.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Viewfinder" (http://en.wikipedia.org/wiki/Viewfinder) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ViewFinder">ceo:ViewFinder</a>
    /// </summary>
    let ViewFinder = _prefixId.prefix "ViewFinder"
    let ViewFinderElectronic = _prefixId.prefix "ViewFinderElectronic"
    let ViewFinderOptical = _prefixId.prefix "ViewFinderOptical"
    let ViewSonic = _prefixId.prefix "ViewSonic"
    let Viewpia = _prefixId.prefix "Viewpia"
    let Vivitar = _prefixId.prefix "Vivitar"
    let VoiceRecording = _prefixId.prefix "VoiceRecording"
    let WAV = _prefixId.prefix "WAV"
    let WMA = _prefixId.prefix "WMA"
    let WMV = _prefixId.prefix "WMV"
    let White = _prefixId.prefix "White"
    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : White balancerdfs:label : Weißabgleich</para>
    ///   <para>rdfs:comment : Is the global adjustment of the intensities of the colors (typically red, green, and blue primary colors). An important goal of this adjustment is to render specific colors - particularly neutral colors - correctly; hence, the general method is sometimes called gray balance, neutral balance, or white balance.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "White Balance" (http://en.wikipedia.org/wiki/White_Balance) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#WhiteBalance">ceo:WhiteBalance</a>
    /// </summary>
    let WhiteBalance = _prefixId.prefix "WhiteBalance"
    let WindFilter = _prefixId.prefix "WindFilter"
    let Windows2000 = _prefixId.prefix "Windows2000"
    let Windows2003 = _prefixId.prefix "Windows2003"
    let Windows95 = _prefixId.prefix "Windows95"
    let Windows98 = _prefixId.prefix "Windows98"
    let WindowsME = _prefixId.prefix "WindowsME"
    let WindowsNT = _prefixId.prefix "WindowsNT"
    let WindowsVista = _prefixId.prefix "WindowsVista"
    let WindowsXP = _prefixId.prefix "WindowsXP"
    let XDPictureCard = _prefixId.prefix "XDPictureCard"
    let Xerox = _prefixId.prefix "Xerox"
    let YPbPr = _prefixId.prefix "YPbPr"
    let Yakumo = _prefixId.prefix "Yakumo"
    let Yellow = _prefixId.prefix "Yellow"
    let Yukai = _prefixId.prefix "Yukai"
    let Yuraku = _prefixId.prefix "Yuraku"
    let Yusmart = _prefixId.prefix "Yusmart"
    /// <summary>
    ///   <para>ceo:belongsToModule : DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Zoomrdfs:label : Zoom</para>
    ///   <para>rdfs:comment : Zoom is a method of decreasing (narrowing) the apparent angle of view of a photographic or video image.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital zoom" (http://en.wikipedia.org/wiki/Digital_zoom) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Zoom">ceo:Zoom</a>
    /// </summary>
    let Zoom = _prefixId.prefix "Zoom"
    let ZoomDigital = _prefixId.prefix "ZoomDigital"
    let ZoomOptical = _prefixId.prefix "ZoomOptical"
    /// <summary>
    ///   <para>rdfs:comment : Describes to which product categories the property or concept belongs (comma seperated, e.g. "MP3Player, TV").</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#belongsToModule">ceo:belongsToModule</a>
    /// </summary>
    let belongsToModule = _prefixId.prefix "belongsToModule"

    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : 35mm Kameraobjektivrdfs:label : 35mm camera lens equivalent range</para>
    ///   <para>rdfs:comment : Defines an optical lens or assembly of lenses used in conjunction with a camera body and mechanism to make images of objects either on photographic film or on other media capable of storing an image chemically or electronically.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#has35mmCameraLensEquivalentRange">ceo:has35mmCameraLensEquivalentRange</a>
    /// </summary>
    let has35mmCameraLensEquivalentRange = _prefixId.prefix "has35mmCameraLensEquivalentRange"

    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : Zubehörrdfs:label : accessory</para>
    ///   <para>rdfs:comment : Defines subordinate or supplementary items.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasAccessory">ceo:hasAccessory</a>
    /// </summary>
    let hasAccessory = _prefixId.prefix "hasAccessory"
    /// <summary>
    ///   <para>ceo:belongsToModule : DigitalCamera</para>
    ///   <para>rdfs:label : analoges Videosignalrdfs:label : analog video signal</para>
    ///   <para>rdfs:comment : Defines whether an analog video signal is supported.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasAnalogVideoSignal">ceo:hasAnalogVideoSignal</a>
    /// </summary>
    let hasAnalogVideoSignal = _prefixId.prefix "hasAnalogVideoSignal"
    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : Blendenbereichrdfs:label : aperture range</para>
    ///   <para>rdfs:comment : Defines the hole or an opening through which light is admitted.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasApertureRange">ceo:hasApertureRange</a>
    /// </summary>
    let hasApertureRange = _prefixId.prefix "hasApertureRange"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : horizontales Bildseitenverhältnisrdfs:label : aspect ratio horizontal</para>
    ///   <para>rdfs:comment : The aspect ratio of a shape is the ratio of its longer dimension to its shorter dimension. The vertical dimension is the longer one.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Aspect ratio" (http://en.wikipedia.org/wiki/Aspect_ratio) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasAspectRatioHorizontal">ceo:hasAspectRatioHorizontal</a>
    /// </summary>
    let hasAspectRatioHorizontal = _prefixId.prefix "hasAspectRatioHorizontal"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : vertikales Bildseitenverhältnisrdfs:label : aspect ratio vertical^^xsd:string</para>
    ///   <para>rdfs:comment : The aspect ratio of a shape is the ratio of its longer dimension to its shorter dimension. The vertical dimension is the shorter one.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Aspect ratio" (http://en.wikipedia.org/wiki/Aspect_ratio) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasAspectRatioVertical">ceo:hasAspectRatioVertical</a>
    /// </summary>
    let hasAspectRatioVertical = _prefixId.prefix "hasAspectRatioVertical"
    /// <summary>
    ///   <para>ceo:belongsToModule : DigitalCamera</para>
    ///   <para>rdfs:label : Audioeingangrdfs:label : audio input source</para>
    ///   <para>rdfs:comment : Defines which audio input devices can be used with this object.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasAudioInputSource">ceo:hasAudioInputSource</a>
    /// </summary>
    let hasAudioInputSource = _prefixId.prefix "hasAudioInputSource"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player</para>
    ///   <para>rdfs:label : Audioschnittstellentyprdfs:label : audio interface type</para>
    ///   <para>rdfs:comment : Defines the type of interfaces used to transfer audio signals.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasAudioInterfaceType">ceo:hasAudioInterfaceType</a>
    /// </summary>
    let hasAudioInterfaceType = _prefixId.prefix "hasAudioInterfaceType"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV^^xsd:string</para>
    ///   <para>rdfs:label : Audioausgangsleistungrdfs:label : audio output power</para>
    ///   <para>rdfs:comment : Defines the rate of energy conversion (Common unit of Measurement milliwatt, C31).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasAudioOutputPower">ceo:hasAudioOutputPower</a>
    /// </summary>
    let hasAudioOutputPower = _prefixId.prefix "hasAudioOutputPower"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Akkuladezeitrdfs:label : battery recharge time</para>
    ///   <para>rdfs:comment : Total time needed to fully recharge a completely discharged rechargeable energy source for this mp3 player (Common unit of measurement hour, HUR).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasBatteryRechargeTime">ceo:hasBatteryRechargeTime</a>
    /// </summary>
    let hasBatteryRechargeTime = _prefixId.prefix "hasBatteryRechargeTime"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Batteriegrößerdfs:label : battery size</para>
    ///   <para>rdfs:comment : Defines the size of used energy source. (Use ASIN code here. For more information we refer to http://en.wikipedia.org/wiki/List_of_battery_sizes)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasBatterySize">ceo:hasBatterySize</a>
    /// </summary>
    let hasBatterySize = _prefixId.prefix "hasBatterySize"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, TV, Printer, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Farberdfs:label : body color</para>
    ///   <para>rdfs:comment : Defines the major color of an objects body.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasBodyColor">ceo:hasBodyColor</a>
    /// </summary>
    let hasBodyColor = _prefixId.prefix "hasBodyColor"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Zertifikatrdfs:label : certificate</para>
    ///   <para>rdfs:comment : Defines the type of certificate of a product used to attest quality standards.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasCertificate">ceo:hasCertificate</a>
    /// </summary>
    let hasCertificate = _prefixId.prefix "hasCertificate"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Anzahl von Kanälerdfs:label : channel quantity</para>
    ///   <para>rdfs:comment : Defines the number of channels of a television that can be used to save specific transmitted signals.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasChannelQuantity">ceo:hasChannelQuantity</a>
    /// </summary>
    let hasChannelQuantity = _prefixId.prefix "hasChannelQuantity"
    /// <summary>
    ///   <para>ceo:belongsToModule : DigitalCamera</para>
    ///   <para>rdfs:label : Farbabgleichrdfs:label : color balance</para>
    ///   <para>rdfs:comment : In photography and image processing, color balance is the global adjustment of the intensities of the colors (typically red, green, and blue primary colors).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "White balance" (http://en.wikipedia.org/wiki/White_balance) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasColorBalance">ceo:hasColorBalance</a>
    /// </summary>
    let hasColorBalance = _prefixId.prefix "hasColorBalance"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, Printer, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : kompatibles Betriebssystemrdfs:label : compatible operating system</para>
    ///   <para>rdfs:comment : Defines the possible external operating systems to communicate with.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasCompatibleOperatingSystem">ceo:hasCompatibleOperatingSystem</a>
    /// </summary>
    let hasCompatibleOperatingSystem = _prefixId.prefix "hasCompatibleOperatingSystem"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Verbindungsmöglichkeitrdfs:label : connectivity</para>
    ///   <para>rdfs:comment : Defines the possibilities to connect different kinds of electronical devices.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasConnectivity">ceo:hasConnectivity</a>
    /// </summary>
    let hasConnectivity = _prefixId.prefix "hasConnectivity"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Kontrastverhältnisrdfs:label : contrast ratio</para>
    ///   <para>rdfs:comment : The contrast ratio is a measure of a display system, defined as the ratio of the luminance of the brightest color (white) to that of the darkest color (black) that the system is capable of producing.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Contrast ratio" (http://en.wikipedia.org/wiki/Contrast_ratio) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasContrastRatio">ceo:hasContrastRatio</a>
    /// </summary>
    let hasContrastRatio = _prefixId.prefix "hasContrastRatio"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player</para>
    ///   <para>rdfs:label : DRM Unterstützungrdfs:label : DRM support</para>
    ///   <para>rdfs:comment : Defines the support of a generic term that refers to access control technologies used by hardware manufacturers.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDRMSupport">ceo:hasDRMSupport</a>
    /// </summary>
    let hasDRMSupport = _prefixId.prefix "hasDRMSupport"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Datenformatrdfs:label : data format</para>
    ///   <para>rdfs:comment : Defines the supported data formats.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDataFormat">ceo:hasDataFormat</a>
    /// </summary>
    let hasDataFormat = _prefixId.prefix "hasDataFormat"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Datenschnittstellentyprdfs:label : data interface type</para>
    ///   <para>rdfs:comment : Defines the type of interfaces used to exchange data.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDataInterfaceType">ceo:hasDataInterfaceType</a>
    /// </summary>
    let hasDataInterfaceType = _prefixId.prefix "hasDataInterfaceType"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, TV, Printer, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Tieferdfs:label : depth</para>
    ///   <para>rdfs:comment : Defines the distance from side to side, measuring across the object at right angles to the width (Common unit of measurement centimetre, CMT).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Length" (http://en.wikipedia.org/wiki/Length) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDepth">ceo:hasDepth</a>
    /// </summary>
    let hasDepth = _prefixId.prefix "hasDepth"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Tiefe mit Standfußrdfs:label : depth with stand</para>
    ///   <para>rdfs:comment : Defines the distance from side to side, measuring across the object with its stand at right angles to the width (Common unit of measurement centimetre, CMT).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Length" (http://en.wikipedia.org/wiki/Length) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDepthWithStand">ceo:hasDepthWithStand</a>
    /// </summary>
    let hasDepthWithStand = _prefixId.prefix "hasDepthWithStand"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Digitale Frequenzrdfs:label : digital frequency</para>
    ///   <para>rdfs:comment : Digital frequency is the analogue for discrete signals as frequency is to continuous signals (Common unit of measurement hertz, HTZ).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital frequency" (http://en.wikipedia.org/wiki/Digital_frequency) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDigitalFrequency">ceo:hasDigitalFrequency</a>
    /// </summary>
    let hasDigitalFrequency = _prefixId.prefix "hasDigitalFrequency"
    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : digitale Videoaufnahmgeschwindigkeitrdfs:label : digital video capture speed</para>
    ///   <para>rdfs:comment : Speed of the process of converting an analog video signal—such as that produced by a video camera or DVD player—to digital form.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDigitalVideoCaptureSpeed">ceo:hasDigitalVideoCaptureSpeed</a>
    /// </summary>
    let hasDigitalVideoCaptureSpeed = _prefixId.prefix "hasDigitalVideoCaptureSpeed"
    /// <summary>
    ///   <para>ceo:belongsToModule : DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : digitaler Zoomrdfs:label : digital zoom</para>
    ///   <para>rdfs:comment : Zoom is a method of decreasing (narrowing) the apparent angle of view of a photographic or video image.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital zoom" (http://en.wikipedia.org/wiki/Digital_zoom) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDigitalZoom">ceo:hasDigitalZoom</a>
    /// </summary>
    let hasDigitalZoom = _prefixId.prefix "hasDigitalZoom"
    /// <summary>
    ///   <para>ceo:belongsToModule : DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : digitaler Zoomfaktorrdfs:label : digital zoom factor</para>
    ///   <para>rdfs:comment : Defines the stages an object can be zoomed digitally.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDigitalZoomFactor">ceo:hasDigitalZoomFactor</a>
    /// </summary>
    let hasDigitalZoomFactor = _prefixId.prefix "hasDigitalZoomFactor"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, Printer, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Bildschirmrdfs:label : display</para>
    ///   <para>rdfs:comment : Defines if object includes a screen.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDisplay">ceo:hasDisplay</a>
    /// </summary>
    let hasDisplay = _prefixId.prefix "hasDisplay"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Bildhelligkeitrdfs:label : display brightness</para>
    ///   <para>rdfs:comment : Defines the brightness of a display or screen. Brightness is an attribute of visual perception in which a source appears to be radiating or reflecting light.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Brightness" (http://en.wikipedia.org/wiki/Brightness) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDisplayBrightness">ceo:hasDisplayBrightness</a>
    /// </summary>
    let hasDisplayBrightness = _prefixId.prefix "hasDisplayBrightness"

    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, TV, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : horizontale Bildschirmauflösungrdfs:label : display resolution horizontal</para>
    ///   <para>rdfs:comment : Defines the digital resolution of the horizontal axe (Common unit of measurement pixel, E37).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDisplayResolutionHorizontal">ceo:hasDisplayResolutionHorizontal</a>
    /// </summary>
    let hasDisplayResolutionHorizontal = _prefixId.prefix "hasDisplayResolutionHorizontal"

    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, TV, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : vertikale Bildschirmauflösungrdfs:label : display resolution vertical</para>
    ///   <para>rdfs:comment : Defines the digital resolution of the vertical axe (Common unit of measurement pixel, E37).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDisplayResolutionVertical">ceo:hasDisplayResolutionVertical</a>
    /// </summary>
    let hasDisplayResolutionVertical = _prefixId.prefix "hasDisplayResolutionVertical"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, TV, Printer, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Bildschirmgrößerdfs:label : display size</para>
    ///   <para>rdfs:comment : Defines the diagonal length from the upper left to the lower right angle (Common unit of measurement centimetre, CMT; or inch, INH).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDisplaySize">ceo:hasDisplaySize</a>
    /// </summary>
    let hasDisplaySize = _prefixId.prefix "hasDisplaySize"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, TV, Printer, Camcorder</para>
    ///   <para>rdfs:label : Bildschirmtyprdfs:label : display type</para>
    ///   <para>rdfs:comment : Defines the type of the display like LCD or Plasma.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDisplayType">ceo:hasDisplayType</a>
    /// </summary>
    let hasDisplayType = _prefixId.prefix "hasDisplayType"

    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : horizontale druckbare Auflösung Schwarz/Weiß Entwurfrdfs:label : draft printable resolution black white horizontal</para>
    ///   <para>rdfs:comment : Defines the digital resolution of the horizontal axe (Common unit of measurement pixel, E37) for black/white prints for draft prints.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDraftPrintableResolutionBlackWhiteHorizontal">ceo:hasDraftPrintableResolutionBlackWhiteHorizontal</a>
    /// </summary>
    let hasDraftPrintableResolutionBlackWhiteHorizontal = _prefixId.prefix "hasDraftPrintableResolutionBlackWhiteHorizontal"

    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : vertikale druckbare Auflösung Schwarz/Weiß Entwurfrdfs:label : draft printable resolution black white vertical</para>
    ///   <para>rdfs:comment : Defines the digital resolution of the vertical axe (Common unit of measurement pixel, E37) for black/white prints for draft prints.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDraftPrintableResolutionBlackWhiteVertical">ceo:hasDraftPrintableResolutionBlackWhiteVertical</a>
    /// </summary>
    let hasDraftPrintableResolutionBlackWhiteVertical = _prefixId.prefix "hasDraftPrintableResolutionBlackWhiteVertical"

    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : horizontale druckbare Auflösung Farbe Entwurfrdfs:label : draft printable resolution color horizontal</para>
    ///   <para>rdfs:comment : Defines the digital resolution of the horizontal axe (Common unit of measurement pixel, E37) for black/white prints for draft prints.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDraftPrintableResolutionColorHorizontal">ceo:hasDraftPrintableResolutionColorHorizontal</a>
    /// </summary>
    let hasDraftPrintableResolutionColorHorizontal = _prefixId.prefix "hasDraftPrintableResolutionColorHorizontal"

    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : vertikale druckbare Auflösung Farbe Entwurfrdfs:label : draft printable resolution color vertical</para>
    ///   <para>rdfs:comment : Defines the digital resolution of the vertical axe (Common unit of measurement pixel, E37) for black/white prints for draft prints.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDraftPrintableResolutionColorVertical">ceo:hasDraftPrintableResolutionColorVertical</a>
    /// </summary>
    let hasDraftPrintableResolutionColorVertical = _prefixId.prefix "hasDraftPrintableResolutionColorVertical"

    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Zeitspanne bis Druck erster Seiterdfs:label : duration to print first page</para>
    ///   <para>rdfs:comment : Amount of time the printer needs to start printing the first page.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDurationToPrintFirstPage">ceo:hasDurationToPrintFirstPage</a>
    /// </summary>
    let hasDurationToPrintFirstPage = _prefixId.prefix "hasDurationToPrintFirstPage"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Energiespardruckmodusrdfs:label : economic print mode</para>
    ///   <para>rdfs:comment : Describes whether or not the product is equipped with features that allow economical printing.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasEconomicPrintMode">ceo:hasEconomicPrintMode</a>
    /// </summary>
    let hasEconomicPrintMode = _prefixId.prefix "hasEconomicPrintMode"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, Printer, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Energiequellerdfs:label : energy source</para>
    ///   <para>rdfs:comment : Defines the used energy source.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasEnergySource">ceo:hasEnergySource</a>
    /// </summary>
    let hasEnergySource = _prefixId.prefix "hasEnergySource"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Kuvertzuführeinrichtungrdfs:label : envelope feeder</para>
    ///   <para>rdfs:comment : Indicates wheter this feature is available on this product.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasEnvelopeFeeder">ceo:hasEnvelopeFeeder</a>
    /// </summary>
    let hasEnvelopeFeeder = _prefixId.prefix "hasEnvelopeFeeder"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player</para>
    ///   <para>rdfs:label : Equalizerrdfs:label : Equalizer</para>
    ///   <para>rdfs:comment : Defines the possibility to vary the audio presentation of sound.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasEqualizer">ceo:hasEqualizer</a>
    /// </summary>
    let hasEqualizer = _prefixId.prefix "hasEqualizer"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, TV</para>
    ///   <para>rdfs:label : Anzahl von Equalizerrdfs:label : equalizer bands qunatity</para>
    ///   <para>rdfs:comment : Defines the number of supported equalizers.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasEqualizerBandsQuantity">ceo:hasEqualizerBandsQuantity</a>
    /// </summary>
    let hasEqualizerBandsQuantity = _prefixId.prefix "hasEqualizerBandsQuantity"
    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : Erweiterungsplätzerdfs:label : expansion slot</para>
    ///   <para>rdfs:comment : Defines the ability to add devices (e.g. cards) to maximize the storage capacity.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasExpansionSlot">ceo:hasExpansionSlot</a>
    /// </summary>
    let hasExpansionSlot = _prefixId.prefix "hasExpansionSlot"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, TV, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Eigenschaftrdfs:label : feature</para>
    ///   <para>rdfs:comment : Defines the type of special functions the object is capable of.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasFeature">ceo:hasFeature</a>
    /// </summary>
    let hasFeature = _prefixId.prefix "hasFeature"
    /// <summary>
    ///   <para>ceo:belongsToModule : DigitalCamera</para>
    ///   <para>rdfs:label : Blitzrdfs:label : flash</para>
    ///   <para>rdfs:comment : Device for instantaneous illumination for picture taking.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasFlash">ceo:hasFlash</a>
    /// </summary>
    let hasFlash = _prefixId.prefix "hasFlash"
    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : Brennweiterdfs:label : focal length</para>
    ///   <para>rdfs:comment : Defines a measure of how strongly it converges (focuses) or diverges (diffuses) light.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Focal length" (http://en.wikipedia.org/wiki/Focal_length) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasFocalLength">ceo:hasFocalLength</a>
    /// </summary>
    let hasFocalLength = _prefixId.prefix "hasFocalLength"
    /// <summary>
    ///   <para>ceo:belongsToModule : DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Fokusrdfs:label : focus</para>
    ///   <para>rdfs:comment : A focus, also called an image point, is the point where light rays originating from a point on the object converge.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Focus (optics)" (http://en.wikipedia.org/wiki/Focus_(optics)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasFocus">ceo:hasFocus</a>
    /// </summary>
    let hasFocus = _prefixId.prefix "hasFocus"
    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : Fokusgrößerdfs:label : focus size</para>
    ///   <para>rdfs:comment : Focus, also called an image point, is the point where light rays originating from a point on the object converge.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Focus (optics)" (http://en.wikipedia.org/wiki/Focus_(optics)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasFocusSize">ceo:hasFocusSize</a>
    /// </summary>
    let hasFocusSize = _prefixId.prefix "hasFocusSize"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player</para>
    ///   <para>rdfs:label : Frequenzberichrdfs:label : frequency range</para>
    ///   <para>rdfs:comment : Defines the range of supported frequency signals (Common unit of measurement megahertz, MHZ).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasFrequencyRange">ceo:hasFrequencyRange</a>
    /// </summary>
    let hasFrequencyRange = _prefixId.prefix "hasFrequencyRange"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, TV, Printer, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Höherdfs:label : height</para>
    ///   <para>rdfs:comment : Defines the measurement of vertical distance (Common unit of measurement centimetre, CMT).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasHeight">ceo:hasHeight</a>
    /// </summary>
    let hasHeight = _prefixId.prefix "hasHeight"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Höhe mit Standfußrdfs:label : height with stand</para>
    ///   <para>rdfs:comment : Defines the measurement of vertical distance of an object with its stand (Common unit of measurement centimetre, CMT).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasHeightWithStand">ceo:hasHeightWithStand</a>
    /// </summary>
    let hasHeightWithStand = _prefixId.prefix "hasHeightWithStand"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player</para>
    ///   <para>rdfs:label : ID3 Unterstützungrdfs:label : ID3 support</para>
    ///   <para>rdfs:comment : Defines the support of information such as the title, artist, album, track number, or other information about the file to be stored in the file itself.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasID3Support">ceo:hasID3Support</a>
    /// </summary>
    let hasID3Support = _prefixId.prefix "hasID3Support"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, Printer, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : interner Speicherplatzrdfs:label : internal memory capacity</para>
    ///   <para>rdfs:comment : Defines the capacity to store data on internal memory (Common unit of measurement Megabyte, 4L).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasInternalMemoryCapacity">ceo:hasInternalMemoryCapacity</a>
    /// </summary>
    let hasInternalMemoryCapacity = _prefixId.prefix "hasInternalMemoryCapacity"
    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : Objektivsystemrdfs:label : lens system</para>
    ///   <para>rdfs:comment : Defines the perfect or approximate axial symmetry which transmits and refracts light.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasLensSystem">ceo:hasLensSystem</a>
    /// </summary>
    let hasLensSystem = _prefixId.prefix "hasLensSystem"
    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : Belichtungsregelungrdfs:label : light exposure control</para>
    ///   <para>rdfs:comment : Defines the total amount of light allowed to fall on the photographic medium (photographic film or image sensor) during the process of taking a photograph.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasLightExposureControl">ceo:hasLightExposureControl</a>
    /// </summary>
    let hasLightExposureControl = _prefixId.prefix "hasLightExposureControl"

    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : maximale Druckgeschwindigkeit Schwarz/Weiß beste Qualitätrdfs:label : max black white print speed best quality</para>
    ///   <para>rdfs:comment : Amount of pages per minute the product is able to print in the mode of black-printig best quality.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxBlackWhitePrintSpeedBestQuality">ceo:hasMaxBlackWhitePrintSpeedBestQuality</a>
    /// </summary>
    let hasMaxBlackWhitePrintSpeedBestQuality = _prefixId.prefix "hasMaxBlackWhitePrintSpeedBestQuality"

    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : maximale Druckgeschwindigkeit schwarz/weiß Entwurfrdfs:label : max black white print speed draft</para>
    ///   <para>rdfs:comment : Amount of pages per minute the product is able to print in the mode of black-printig of drafts.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxBlackWhitePrintSpeedDraft">ceo:hasMaxBlackWhitePrintSpeedDraft</a>
    /// </summary>
    let hasMaxBlackWhitePrintSpeedDraft = _prefixId.prefix "hasMaxBlackWhitePrintSpeedDraft"

    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : maximale Druckgeschwindigkeit Schwarz/Weiß normalrdfs:label : max black white print speed draft</para>
    ///   <para>rdfs:comment : Amount of pages per minute the product is able to print in the mode of black-printig normal quality.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxBlackWhitePrintSpeedNormal">ceo:hasMaxBlackWhitePrintSpeedNormal</a>
    /// </summary>
    let hasMaxBlackWhitePrintSpeedNormal = _prefixId.prefix "hasMaxBlackWhitePrintSpeedNormal"

    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : maximale Druckgeschwindigkeit Farbe beste Qualitätrdfs:label : max color print speed best quality</para>
    ///   <para>rdfs:comment : Amount of pages per minute the product is able to print in the mode of color-printig best quality.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxColorPrintSpeedBestQuality">ceo:hasMaxColorPrintSpeedBestQuality</a>
    /// </summary>
    let hasMaxColorPrintSpeedBestQuality = _prefixId.prefix "hasMaxColorPrintSpeedBestQuality"

    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : maximale Druckgeschwindigkeit Farbe Entwurfrdfs:label : max color print speed draft</para>
    ///   <para>rdfs:comment : Amount of pages per minute the product is able to print in the mode of color-printig of drafts.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxColorPrintSpeedDraft">ceo:hasMaxColorPrintSpeedDraft</a>
    /// </summary>
    let hasMaxColorPrintSpeedDraft = _prefixId.prefix "hasMaxColorPrintSpeedDraft"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : maximale Druckgeschwindigkeit Farbe normalrdfs:label : max color print speed normal</para>
    ///   <para>rdfs:comment : Amount of pages per minute the product is able to print in the mode of color-printig normal quality.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxColorPrintSpeedNormal">ceo:hasMaxColorPrintSpeedNormal</a>
    /// </summary>
    let hasMaxColorPrintSpeedNormal = _prefixId.prefix "hasMaxColorPrintSpeedNormal"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : maximale Medienkapazitätrdfs:label : max input capacity</para>
    ///   <para>rdfs:comment : Maximum number of sheets the device can hold in all available standard and optional output trays.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxInputCapacity">ceo:hasMaxInputCapacity</a>
    /// </summary>
    let hasMaxInputCapacity = _prefixId.prefix "hasMaxInputCapacity"

    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : maximale Menge an Briefkuvertrdfs:label : max input capacity for envelopes</para>
    ///   <para>rdfs:comment : Defines the maximum ability to hold for envelopes.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxInputCapacityForEnvelopes">ceo:hasMaxInputCapacityForEnvelopes</a>
    /// </summary>
    let hasMaxInputCapacityForEnvelopes = _prefixId.prefix "hasMaxInputCapacityForEnvelopes"

    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : maximaler interner Speicherplatzrdfs:label : max internal memory capacity</para>
    ///   <para>rdfs:comment : Defines the maximum amount of memory that can be installed in the systems hardware (common unit of measurement: megabyte(MB): 4L).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxInternalMemoryCapacity">ceo:hasMaxInternalMemoryCapacity</a>
    /// </summary>
    let hasMaxInternalMemoryCapacity = _prefixId.prefix "hasMaxInternalMemoryCapacity"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : maximale Mediengrößerdfs:label : max media format</para>
    ///   <para>rdfs:comment : Defines the maximum size of the printed media format.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxMediaFormat">ceo:hasMaxMediaFormat</a>
    /// </summary>
    let hasMaxMediaFormat = _prefixId.prefix "hasMaxMediaFormat"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : maximales Mediengewichtrdfs:label : max media weight</para>
    ///   <para>rdfs:comment : Describes the maximum weight of the media format (Common unit of measurement gram per square metre, GM).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxMediaWeight">ceo:hasMaxMediaWeight</a>
    /// </summary>
    let hasMaxMediaWeight = _prefixId.prefix "hasMaxMediaWeight"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : maximale Speicherkapazitätrdfs:label : maximale memory capacity</para>
    ///   <para>rdfs:comment : Defines the maxium capacity that can be provided by using external memory (Common unit of measurement megabyte, 4L).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxMemoryCapacity">ceo:hasMaxMemoryCapacity</a>
    /// </summary>
    let hasMaxMemoryCapacity = _prefixId.prefix "hasMaxMemoryCapacity"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV, Printer</para>
    ///   <para>rdfs:label : maximale Betriebstemperaturrdfs:label : max operating temperatur</para>
    ///   <para>rdfs:comment : Defines the maximum temperature the product is able to operate (Common unit of measurement grad celsius, CEL).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxOperatingTemperature">ceo:hasMaxOperatingTemperature</a>
    /// </summary>
    let hasMaxOperatingTemperature = _prefixId.prefix "hasMaxOperatingTemperature"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : maximale Größe Ausgabefachrdfs:label : max output capacity</para>
    ///   <para>rdfs:comment : Maximum number of sheets the product can hold in all available standard and optional output trays.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxOutputCapacity">ceo:hasMaxOutputCapacity</a>
    /// </summary>
    let hasMaxOutputCapacity = _prefixId.prefix "hasMaxOutputCapacity"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : maximale Druckkapazitätrdfs:label : max print capacity</para>
    ///   <para>rdfs:comment : Describes the maximum printed sites per month.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxPrintCapacity">ceo:hasMaxPrintCapacity</a>
    /// </summary>
    let hasMaxPrintCapacity = _prefixId.prefix "hasMaxPrintCapacity"

    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : maximale horizontale druckbare Auflösung Schwarz/Weißrdfs:label : max printable resolution black white horizontal</para>
    ///   <para>rdfs:comment : Defines the maximum digital resolution of the horizontal axe (Common unit of measurement pixel, E37) for black/white prints.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxPrintableResolutionBlackWhiteHorizontal">ceo:hasMaxPrintableResolutionBlackWhiteHorizontal</a>
    /// </summary>
    let hasMaxPrintableResolutionBlackWhiteHorizontal = _prefixId.prefix "hasMaxPrintableResolutionBlackWhiteHorizontal"

    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : max printable resolution black white verticalrdfs:label : maximale vertikale druckbare Auflösung Schwarz/Weiß</para>
    ///   <para>rdfs:comment : Defines the maximum digital resolution of the vertical axe (Common unit of measurement pixel, E37) for black/white prints.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxPrintableResolutionBlackWhiteVertical">ceo:hasMaxPrintableResolutionBlackWhiteVertical</a>
    /// </summary>
    let hasMaxPrintableResolutionBlackWhiteVertical = _prefixId.prefix "hasMaxPrintableResolutionBlackWhiteVertical"

    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : maximale horizontale druckbare Auflösung Farberdfs:label : max printable resolution color horizontal</para>
    ///   <para>rdfs:comment : Defines the maximum digital resolution of the horizontal axe (Common unit of measurement pixel, E37) for color prints.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxPrintableResolutionColorHorizontal">ceo:hasMaxPrintableResolutionColorHorizontal</a>
    /// </summary>
    let hasMaxPrintableResolutionColorHorizontal = _prefixId.prefix "hasMaxPrintableResolutionColorHorizontal"

    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : maximale vertikale druckbare Auflösung Farberdfs:label : max printable resolution color vertical</para>
    ///   <para>rdfs:comment : Defines the maximum digital resolution of the vertical axe (Common unit of measurement pixel, E37)  for color prints.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxPrintableResolutionColorVertical">ceo:hasMaxPrintableResolutionColorVertical</a>
    /// </summary>
    let hasMaxPrintableResolutionColorVertical = _prefixId.prefix "hasMaxPrintableResolutionColorVertical"

    /// <summary>
    ///   <para>ceo:belongsToModule : TV, Printer</para>
    ///   <para>rdfs:label : maximale Luftfeuchtigkeitrdfs:label : max relative humidity</para>
    ///   <para>rdfs:comment : Defines the maximum level of relative humidity, non-condensing, within which the product can operate.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxRelativeHumidity">ceo:hasMaxRelativeHumidity</a>
    /// </summary>
    let hasMaxRelativeHumidity = _prefixId.prefix "hasMaxRelativeHumidity"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Mediengewicht Kassette 1rdfs:label : media weight tray 1</para>
    ///   <para>rdfs:comment : Describes the weight of the media format (Common unit of measurement gram per square metre, GM) hold in tray 1.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMediaWeightTray1">ceo:hasMediaWeightTray1</a>
    /// </summary>
    let hasMediaWeightTray1 = _prefixId.prefix "hasMediaWeightTray1"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Mediengewicht Kassette 1rdfs:label : media weight tray 2</para>
    ///   <para>rdfs:comment : Describes the weight of the media format (Common unit of measurement gram per square metre, GM) hold in tray 2.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMediaWeightTray2">ceo:hasMediaWeightTray2</a>
    /// </summary>
    let hasMediaWeightTray2 = _prefixId.prefix "hasMediaWeightTray2"
    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : minimale Belichtungrdfs:label : min illumination</para>
    ///   <para>rdfs:comment : Minimum deliberate application of light to achieve some aesthetic or practical effect (common unit of measurement: Lux; LUX).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMinIllumination">ceo:hasMinIllumination</a>
    /// </summary>
    let hasMinIllumination = _prefixId.prefix "hasMinIllumination"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : minimales Mediengewichtrdfs:label : min media weight</para>
    ///   <para>rdfs:comment : Describes the minimum weight of the media format (Common unit of measurement gram per square metre, GM).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMinMediaWeight">ceo:hasMinMediaWeight</a>
    /// </summary>
    let hasMinMediaWeight = _prefixId.prefix "hasMinMediaWeight"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV, Printer</para>
    ///   <para>rdfs:label : minimale Betriebstemperaturrdfs:label : min operating temperature</para>
    ///   <para>rdfs:comment : Defines the minimum temperature the product is able to operate (Common unit of measurement grad celsius, CEL).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMinOperatingTemperature">ceo:hasMinOperatingTemperature</a>
    /// </summary>
    let hasMinOperatingTemperature = _prefixId.prefix "hasMinOperatingTemperature"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV, Printer</para>
    ///   <para>rdfs:label : minimale Luftfeuchtigkeitrdfs:label : min relative humidity</para>
    ///   <para>rdfs:comment : Defines the minimum level of relative humidity, non-condensing, within which the product can operate.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMinRelativeHumidity">ceo:hasMinRelativeHumidity</a>
    /// </summary>
    let hasMinRelativeHumidity = _prefixId.prefix "hasMinRelativeHumidity"
    /// <summary>
    ///   <para>rdfs:label : Netzwerkfähigkeitrdfs:label : network ability</para>
    ///   <para>rdfs:comment : Ability to connect the product to a network.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNetworkAbility">ceo:hasNetworkAbility</a>
    /// </summary>
    let hasNetworkAbility = _prefixId.prefix "hasNetworkAbility"

    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : horizontale druckbare Auflösung Schwarz/Weiß normalrdfs:label : normal printable resolution black white horizontal</para>
    ///   <para>rdfs:comment : Defines the digital resolution of the horizontal axe (Common unit of measurement pixel, E37) for black/white prints for normal prints.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNormalPrintableResolutionBlackWhiteHorizontal">ceo:hasNormalPrintableResolutionBlackWhiteHorizontal</a>
    /// </summary>
    let hasNormalPrintableResolutionBlackWhiteHorizontal = _prefixId.prefix "hasNormalPrintableResolutionBlackWhiteHorizontal"

    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : vertikale druckbare Auflösung Schwarz/Weiß normalrdfs:label : normal printable resolution black white vertical</para>
    ///   <para>rdfs:comment : Defines the  digital resolution of the vertical axe (Common unit of measurement pixel, E37) for black/white prints for normal prints.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNormalPrintableResolutionBlackWhiteVertical">ceo:hasNormalPrintableResolutionBlackWhiteVertical</a>
    /// </summary>
    let hasNormalPrintableResolutionBlackWhiteVertical = _prefixId.prefix "hasNormalPrintableResolutionBlackWhiteVertical"

    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : horizontale druckbare Auflösung Farbe normalrdfs:label : normal printable resolution color horizontal</para>
    ///   <para>rdfs:comment : Defines the digital resolution of the horizontal axe (Common unit of measurement pixel, E37) for color prints for normal prints.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNormalPrintableResolutionColorHorizontal">ceo:hasNormalPrintableResolutionColorHorizontal</a>
    /// </summary>
    let hasNormalPrintableResolutionColorHorizontal = _prefixId.prefix "hasNormalPrintableResolutionColorHorizontal"

    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : vertikale durckbare Aufslösung Farbe normalrdfs:label : normal printable resolution color vertical</para>
    ///   <para>rdfs:comment : Defines the digital resolution of the vertical axe (Common unit of measurement pixel, E37)  for color prints for normal prints.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNormalPrintableResolutionColorVertical">ceo:hasNormalPrintableResolutionColorVertical</a>
    /// </summary>
    let hasNormalPrintableResolutionColorVertical = _prefixId.prefix "hasNormalPrintableResolutionColorVertical"

    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : Anzahl an Component Vido Portsrdfs:label : number of component video ports</para>
    ///   <para>rdfs:comment : Defines the number of component video ports a device offers.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfComponentVideoPorts">ceo:hasNumberOfComponentVideoPorts</a>
    /// </summary>
    let hasNumberOfComponentVideoPorts = _prefixId.prefix "hasNumberOfComponentVideoPorts"

    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, TV, Printer, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Anzahl von Bildschirmfarbenrdfs:label : number of display colors</para>
    ///   <para>rdfs:comment : Defines the number of colors an electronical device is able to display on a screen.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfDisplayColors">ceo:hasNumberOfDisplayColors</a>
    /// </summary>
    let hasNumberOfDisplayColors = _prefixId.prefix "hasNumberOfDisplayColors"
    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : Anzahl HDMI Anschlussmöglichkeitenrdfs:label : number of HDMI ports</para>
    ///   <para>rdfs:comment : Number of compact audio/video interface ports for transmitting uncompressed digital data.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfHDMIPorts">ceo:hasNumberOfHDMIPorts</a>
    /// </summary>
    let hasNumberOfHDMIPorts = _prefixId.prefix "hasNumberOfHDMIPorts"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Anzahl von Teletextseitenrdfs:label : number of hypertext pages</para>
    ///   <para>rdfs:comment : Defines the number of hypertext pages that can be displayed on the main screen of a device.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfHyptertextPages">ceo:hasNumberOfHyptertextPages</a>
    /// </summary>
    let hasNumberOfHyptertextPages = _prefixId.prefix "hasNumberOfHyptertextPages"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Anzahl an Papierkassetten Zuführungrdfs:label : number of input paper trays</para>
    ///   <para>rdfs:comment : Counts the trays which feed the printer with paper.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfInputPaperTrays">ceo:hasNumberOfInputPaperTrays</a>
    /// </summary>
    let hasNumberOfInputPaperTrays = _prefixId.prefix "hasNumberOfInputPaperTrays"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Anzahl von verfügbaren Sprachenrdfs:label : number of on screen languages</para>
    ///   <para>rdfs:comment : Defines the available languages that can be chosen to be displayed on the main screen of a device.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfOnScreenLanguages">ceo:hasNumberOfOnScreenLanguages</a>
    /// </summary>
    let hasNumberOfOnScreenLanguages = _prefixId.prefix "hasNumberOfOnScreenLanguages"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Anzahl von Druckerkassettenrdfs:label : number of print cartridges</para>
    ///   <para>rdfs:comment : Number of replaceable components of a printer that contains the ink that is spread on paper during printing.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfPrintCartridges">ceo:hasNumberOfPrintCartridges</a>
    /// </summary>
    let hasNumberOfPrintCartridges = _prefixId.prefix "hasNumberOfPrintCartridges"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Anzahl an Standard Papierkassettenrdfs:label : number of standard input trays</para>
    ///   <para>rdfs:comment : Defines the number of trays able to hold sheets of paper to be printed.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfStandardInputTrays">ceo:hasNumberOfStandardInputTrays</a>
    /// </summary>
    let hasNumberOfStandardInputTrays = _prefixId.prefix "hasNumberOfStandardInputTrays"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Betriebsdauerrdfs:label : operating time</para>
    ///   <para>rdfs:comment : Average time the object operates (Common unit of measurement hour, HUR).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasOperatingTime">ceo:hasOperatingTime</a>
    /// </summary>
    let hasOperatingTime = _prefixId.prefix "hasOperatingTime"
    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : Auflösung optischer Sensorrdfs:label : optical sensor resolution</para>
    ///   <para>rdfs:comment : Describes the ability of an imaging system to resolve detail in the object that is being imaged.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasOpticalSensorResolution">ceo:hasOpticalSensorResolution</a>
    /// </summary>
    let hasOpticalSensorResolution = _prefixId.prefix "hasOpticalSensorResolution"
    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : optischer Sensorgrößerdfs:label : optical sensor size</para>
    ///   <para>rdfs:comment : Size of the device that measures a physical quantity and converts it into a signal which can be read by an observer or by an instrument (common unit of measurement: inch; INH).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasOpticalSensorSize">ceo:hasOpticalSensorSize</a>
    /// </summary>
    let hasOpticalSensorSize = _prefixId.prefix "hasOpticalSensorSize"
    /// <summary>
    ///   <para>ceo:belongsToModule : DigitalCamera</para>
    ///   <para>rdfs:label : optischer Zoomrdfs:label : optical zoom</para>
    ///   <para>rdfs:comment : Defines a method of decreasing (narrowing) the apparent angle of view of a digital photographic or video image with a higher optical resolution than the digital zoom.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasOpticalZoom">ceo:hasOpticalZoom</a>
    /// </summary>
    let hasOpticalZoom = _prefixId.prefix "hasOpticalZoom"
    /// <summary>
    ///   <para>ceo:belongsToModule : DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : optischer Zoomfaktorrdfs:label : optical zoom factor</para>
    ///   <para>rdfs:comment : Defines the stages an object can be zoomed optically.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasOpticalZoomFactor">ceo:hasOpticalZoomFactor</a>
    /// </summary>
    let hasOpticalZoomFactor = _prefixId.prefix "hasOpticalZoomFactor"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, Printer</para>
    ///   <para>rdfs:label : Ausgangsleistungrdfs:label : output power</para>
    ///   <para>rdfs:comment : Defines the rate of energy conversion (Common unit of Measurement milliwatt, C31).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasOutputPower">ceo:hasOutputPower</a>
    /// </summary>
    let hasOutputPower = _prefixId.prefix "hasOutputPower"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Verpackungstieferdfs:label : package depth</para>
    ///   <para>rdfs:comment : Defines the distance from side to side, measuring across the object with its package at right angles to the width (Common unit of measurement centimetre, CMT).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Length" (http://en.wikipedia.org/wiki/Length) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPackageDepth">ceo:hasPackageDepth</a>
    /// </summary>
    let hasPackageDepth = _prefixId.prefix "hasPackageDepth"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Verpackungshöherdfs:label : package height</para>
    ///   <para>rdfs:comment : Defines the measurement of vertical distance of an object with its package (Common unit of measurement centimetre, CMT).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPackageHeight">ceo:hasPackageHeight</a>
    /// </summary>
    let hasPackageHeight = _prefixId.prefix "hasPackageHeight"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Verpackungsgewichtrdfs:label : package weight</para>
    ///   <para>rdfs:comment : Defines the measurement of the gravitational force acting on an object with its package (Common unit of measurement gramm, GRM).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPackageWeight">ceo:hasPackageWeight</a>
    /// </summary>
    let hasPackageWeight = _prefixId.prefix "hasPackageWeight"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Verpackungsbreiterdfs:label : package width</para>
    ///   <para>rdfs:comment : Defines the distance between the ends of an object, its linear extent as measured from end to end with its package (Common unit of measurement centimetre, CMT).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPackageWidth">ceo:hasPackageWidth</a>
    /// </summary>
    let hasPackageWidth = _prefixId.prefix "hasPackageWidth"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Papierformatrdfs:label : paper format</para>
    ///   <para>rdfs:comment : Defines the supported paper formats.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPaperFormat">ceo:hasPaperFormat</a>
    /// </summary>
    let hasPaperFormat = _prefixId.prefix "hasPaperFormat"
    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : Filtergrößerdfs:label : filter size</para>
    ///   <para>rdfs:comment : Size of a camera accessory consisting of an optical filter that can be inserted in the optical path.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Photographic filter" (http://en.wikipedia.org/wiki/Photographic_filter) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPhotographicFilterSize">ceo:hasPhotographicFilterSize</a>
    /// </summary>
    let hasPhotographicFilterSize = _prefixId.prefix "hasPhotographicFilterSize"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Bild-in-Bild Funktionrdfs:label : picture in picture</para>
    ///   <para>rdfs:comment : Defines that an electronical screen can display minimum two pictures on one screen.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPictureInPicture">ceo:hasPictureInPicture</a>
    /// </summary>
    let hasPictureInPicture = _prefixId.prefix "hasPictureInPicture"
    /// <summary>
    ///   <para>ceo:belongsToModule : DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Fotoauflösungrdfs:label : picture resolution</para>
    ///   <para>rdfs:comment : Defines the digital resolution of the pictures (Common unit of measurement pixel, E37).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPictureResolution">ceo:hasPictureResolution</a>
    /// </summary>
    let hasPictureResolution = _prefixId.prefix "hasPictureResolution"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Strombedarf ACrdfs:label : power requirements AC</para>
    ///   <para>rdfs:comment : Defines the requirements of power an electronical device needs to operate (Common unit of measurement Ampere, AMP).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPowerRequirementsAC">ceo:hasPowerRequirementsAC</a>
    /// </summary>
    let hasPowerRequirementsAC = _prefixId.prefix "hasPowerRequirementsAC"
    /// <summary>
    ///   <para>rdfs:label : Strombedarf HTZrdfs:label : power requirements HTZ</para>
    ///   <para>rdfs:comment : Defines the power requirements of an electronical device (Common unit of measurement hertz, HTZ).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPowerRequirementsHTZ">ceo:hasPowerRequirementsHTZ</a>
    /// </summary>
    let hasPowerRequirementsHTZ = _prefixId.prefix "hasPowerRequirementsHTZ"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Druckgrenze untenrdfs:label : print border bottom</para>
    ///   <para>rdfs:comment : Defines the area which can not be printed on the bottom side of a paper (A4) (Common unit of measurement millimetre, MMT).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPrintBorderBottom">ceo:hasPrintBorderBottom</a>
    /// </summary>
    let hasPrintBorderBottom = _prefixId.prefix "hasPrintBorderBottom"
    /// <summary>
    ///   <para>rdfs:label : Druckgrenze linksrdfs:label : print border left</para>
    ///   <para>rdfs:comment : Defines the area which can not be printed on the left side of a paper (DIN A4) (Common unit of measurement millimetre, MMT).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPrintBorderLeft">ceo:hasPrintBorderLeft</a>
    /// </summary>
    let hasPrintBorderLeft = _prefixId.prefix "hasPrintBorderLeft"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Druckgrenze rechtsrdfs:label : print border right</para>
    ///   <para>rdfs:comment : Defines the area which can not be printed on the right side of a paper (A4) (Common unit of measurement millimetre, MMT).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPrintBorderRight">ceo:hasPrintBorderRight</a>
    /// </summary>
    let hasPrintBorderRight = _prefixId.prefix "hasPrintBorderRight"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Druckgrenze obenrdfs:label : print border top</para>
    ///   <para>rdfs:comment : Defines the area which can not be printed on the top side of a paper (A4) (Common unit of measurement millimetre, MMT).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPrintBorderTop">ceo:hasPrintBorderTop</a>
    /// </summary>
    let hasPrintBorderTop = _prefixId.prefix "hasPrintBorderTop"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Prozessortaktraterdfs:label : processor clock speed</para>
    ///   <para>rdfs:comment : Defines the frequency of the clock in any synchronous circuit (common unit of measurement: hertz, HTZ).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasProcessorClockSpeed">ceo:hasProcessorClockSpeed</a>
    /// </summary>
    let hasProcessorClockSpeed = _prefixId.prefix "hasProcessorClockSpeed"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Prozessorartrdfs:label : processor type</para>
    ///   <para>rdfs:comment : The type of central processing unit (CPU) as an electronic circuit that can execute printing tasks or programs.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasProcessorType">ceo:hasProcessorType</a>
    /// </summary>
    let hasProcessorType = _prefixId.prefix "hasProcessorType"
    /// <summary>
    ///   <para>ceo:belongsToModule : DigitalCamera</para>
    ///   <para>rdfs:label : Rote-Augen-Effekt Reduktionrdfs:label : red eye reduction</para>
    ///   <para>rdfs:comment : The red-eye effect in photography is the common appearance of red pupils in color photographs of eyes. The red-eye reduction feature reduces the red-eye effect.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasRedEyeReduction">ceo:hasRedEyeReduction</a>
    /// </summary>
    let hasRedEyeReduction = _prefixId.prefix "hasRedEyeReduction"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV^^xsd:string</para>
    ///   <para>rdfs:label : Auflösungrdfs:label : resolution</para>
    ///   <para>rdfs:comment : Defines the type of resolution a screen is able to display.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasResolution">ceo:hasResolution</a>
    /// </summary>
    let hasResolution = _prefixId.prefix "hasResolution"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Reaktionszeitrdfs:label : response time</para>
    ///   <para>rdfs:comment : Defines the time an electronical device needs to react on a signal (Common unit of measurement millisecond, C26).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasResponseTime">ceo:hasResponseTime</a>
    /// </summary>
    let hasResponseTime = _prefixId.prefix "hasResponseTime"
    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : Szenenmodusrdfs:label : scene mode</para>
    ///   <para>rdfs:comment : Defines a projection of information from any physical environment into any sensory system.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasSceneMode">ceo:hasSceneMode</a>
    /// </summary>
    let hasSceneMode = _prefixId.prefix "hasSceneMode"
    /// <summary>
    ///   <para>ceo:belongsToModule : DigitalCamera</para>
    ///   <para>rdfs:label : Selbstauslöserrdfs:label : self-timer</para>
    ///   <para>rdfs:comment : Defines whether the product is able  to give a delay between the pressing of the shutter release and the shutter firing.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasSelfTimer">ceo:hasSelfTimer</a>
    /// </summary>
    let hasSelfTimer = _prefixId.prefix "hasSelfTimer"
    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : Sensorartrdfs:label : sensor type</para>
    ///   <para>rdfs:comment : Defines type of device that measures a physical quantity and converts it into a signal which can be read by an observer or by an instrument.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasSensorType">ceo:hasSensorType</a>
    /// </summary>
    let hasSensorType = _prefixId.prefix "hasSensorType"
    /// <summary>
    ///   <para>ceo:belongsToModule : DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Auslöseverzögerungrdfs:label : shutter lag</para>
    ///   <para>rdfs:comment : Defines the delay between triggering the shutter and when the photograph is actually recorded (Common unit of measurement seconds, SEC).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasShutterLag">ceo:hasShutterLag</a>
    /// </summary>
    let hasShutterLag = _prefixId.prefix "hasShutterLag"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Stromverbrauch im Ruhezustandrdfs:label : sleep mode power consumption</para>
    ///   <para>rdfs:comment : Defines the ability to use a mode that saves significant electrical consumption compared to leaving a device fully on and idle but allows the user to avoid having to reset programming codes (Common unit of measurement Watt, WTT).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Sleep mode" (http://en.wikipedia.org/wiki/Sleep_mode) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasSleepModePowerConsumption">ceo:hasSleepModePowerConsumption</a>
    /// </summary>
    let hasSleepModePowerConsumption = _prefixId.prefix "hasSleepModePowerConsumption"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Geräuschentwicklungrdfs:label : sound emission</para>
    ///   <para>rdfs:comment : Level of sound power during the printing (Common unit of measurement decibel, 2N).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasSoundEmission">ceo:hasSoundEmission</a>
    /// </summary>
    let hasSoundEmission = _prefixId.prefix "hasSoundEmission"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Anzahl an Lautsprecherrdfs:label : speaker quantity</para>
    ///   <para>rdfs:comment : Defines the number of integrated speakers an object includes.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasSpeakerQuantity">ceo:hasSpeakerQuantity</a>
    /// </summary>
    let hasSpeakerQuantity = _prefixId.prefix "hasSpeakerQuantity"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Standard Eingabekapazitätrdfs:label : standard input capacity</para>
    ///   <para>rdfs:comment : Amount of sheets the product can hold as standard.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasStandardInputCapacity">ceo:hasStandardInputCapacity</a>
    /// </summary>
    let hasStandardInputCapacity = _prefixId.prefix "hasStandardInputCapacity"
    /// <summary>
    ///   <para>rdfs:label : Standard Ausgabkapazitätrdfs:label : standard output capacity</para>
    ///   <para>rdfs:comment : Number of sheets the product can hold in all available output trays as a standard.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasStandardOutputCapacity">ceo:hasStandardOutputCapacity</a>
    /// </summary>
    let hasStandardOutputCapacity = _prefixId.prefix "hasStandardOutputCapacity"

    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Standard Ausgabekapazität für Briefkuvertrdfs:label : standard output capacity for envelopes</para>
    ///   <para>rdfs:comment : Defines the maximum amount of envelopes the product is able to print.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasStandardOutputCapacityForEnvelopes">ceo:hasStandardOutputCapacityForEnvelopes</a>
    /// </summary>
    let hasStandardOutputCapacityForEnvelopes = _prefixId.prefix "hasStandardOutputCapacityForEnvelopes"

    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Standard Ausgabekapazität für Folienrdfs:label : standard output capacity for transperancies</para>
    ///   <para>rdfs:comment : Defines the maximum amount of transparancies the product is able to print.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasStandardOutputCapacityForTransperancies">ceo:hasStandardOutputCapacityForTransperancies</a>
    /// </summary>
    let hasStandardOutputCapacityForTransperancies = _prefixId.prefix "hasStandardOutputCapacityForTransperancies"

    /// <summary>
    ///   <para>ceo:belongsToModule : TV, Printer</para>
    ///   <para>rdfs:label : Standby Stromverbrauchrdfs:label : standby power consumption</para>
    ///   <para>rdfs:comment : Defines the amount of consumed energy while the device is in the standby mode (Common unit of measurement Watt, WTT).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasStandbyPowerConsumption">ceo:hasStandbyPowerConsumption</a>
    /// </summary>
    let hasStandbyPowerConsumption = _prefixId.prefix "hasStandbyPowerConsumption"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Speichermediumrdfs:label : storage media</para>
    ///   <para>rdfs:comment : Defines the type of storage media the object uses to store data.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasStorageMedia">ceo:hasStorageMedia</a>
    /// </summary>
    let hasStorageMedia = _prefixId.prefix "hasStorageMedia"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Schwenkarmrdfs:label : swivel</para>
    ///   <para>rdfs:comment : Defines the possibilty to rotate or turn an object into different directions (Common unit of measurement degree, DD).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasSwivel">ceo:hasSwivel</a>
    /// </summary>
    let hasSwivel = _prefixId.prefix "hasSwivel"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : TV Tunerrdfs:label : TV Tuner^^xsd:string</para>
    ///   <para>rdfs:comment : Defines the type of included TV tuner.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasTVTuner">ceo:hasTVTuner</a>
    /// </summary>
    let hasTVTuner = _prefixId.prefix "hasTVTuner"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, Printer, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Sensorbildschirmrdfs:label : touch screen</para>
    ///   <para>rdfs:comment : Defines the ability to operate an object by touching its screen.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasTouchscreen">ceo:hasTouchscreen</a>
    /// </summary>
    let hasTouchscreen = _prefixId.prefix "hasTouchscreen"
    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : Anzahl USB Anschlussmöglichkeitenrdfs:label : number of USB ports</para>
    ///   <para>rdfs:comment : Number of serial bus standard ports to connect devices to a host computer.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasUSBPortsQuantity">ceo:hasUSBPortsQuantity</a>
    /// </summary>
    let hasUSBPortsQuantity = _prefixId.prefix "hasUSBPortsQuantity"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV, Printer</para>
    ///   <para>rdfs:label : Stromverbrauch in Betriebrdfs:label : usage power consumption</para>
    ///   <para>rdfs:comment : Defines the necessary power for an electronical object while the device is used (Common unit of measurement Watt, WTT).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasUsagePowerConsumption">ceo:hasUsagePowerConsumption</a>
    /// </summary>
    let hasUsagePowerConsumption = _prefixId.prefix "hasUsagePowerConsumption"
    /// <summary>
    ///   <para>ceo:belongsToModule : DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Videoauflösungrdfs:label : video resolution</para>
    ///   <para>rdfs:comment : Defines the digital resolution of the videos (Common unit of measurement pixel, E37). (Example: 1024x768)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasVideoResolution">ceo:hasVideoResolution</a>
    /// </summary>
    let hasVideoResolution = _prefixId.prefix "hasVideoResolution"
    /// <summary>
    ///   <para>ceo:belongsToModule : DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Bildsucherrdfs:label : viewfinder</para>
    ///   <para>rdfs:comment : A viewfinder is what the photographer looks through to compose, and in many cases to focus, the picture.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Viewfinder" (http://en.wikipedia.org/wiki/Viewfinder) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasViewFinder">ceo:hasViewFinder</a>
    /// </summary>
    let hasViewFinder = _prefixId.prefix "hasViewFinder"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : horizontaler Betrachtungswinkelrdfs:label : viewing angle horizontal</para>
    ///   <para>rdfs:comment : Defines the angle in a horizontal axe where a viewer is still able to see the picture on a screen (Common unit of measurement degree, DD).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasViewingAngleHorizontal">ceo:hasViewingAngleHorizontal</a>
    /// </summary>
    let hasViewingAngleHorizontal = _prefixId.prefix "hasViewingAngleHorizontal"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : vertikaler Betrachtungswinkelrdfs:label : viewing angle vertical</para>
    ///   <para>rdfs:comment : Defines the angle in a vertical axe where a viewer is still able to see the picture on a screen (Common unit of measurement degree, DD).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasViewingAngleVertical">ceo:hasViewingAngleVertical</a>
    /// </summary>
    let hasViewingAngleVertical = _prefixId.prefix "hasViewingAngleVertical"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Wandmontagemöglichkeitrdfs:label : wall mountability</para>
    ///   <para>rdfs:comment : Defines if an object can be installed at a wall.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasWallMountability">ceo:hasWallMountability</a>
    /// </summary>
    let hasWallMountability = _prefixId.prefix "hasWallMountability"
    /// <summary>
    ///   <para>ceo:belongsToModule : Printer</para>
    ///   <para>rdfs:label : Warmlaufzeitrdfs:label : warmup time</para>
    ///   <para>rdfs:comment : Defines the amount of time the device needs to be ready.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasWarmupTime">ceo:hasWarmupTime</a>
    /// </summary>
    let hasWarmupTime = _prefixId.prefix "hasWarmupTime"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, TV, Printer, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Gewichtrdfs:label : weight</para>
    ///   <para>rdfs:comment : Defines the measurement of the gravitational force acting on an object (Common unit of measurement gramm, GRM).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasWeight">ceo:hasWeight</a>
    /// </summary>
    let hasWeight = _prefixId.prefix "hasWeight"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Gewicht mit Standfußrdfs:label : weight with stand</para>
    ///   <para>rdfs:comment : Defines the measurement of the gravitational force acting on an object with its stand (Common unit of measurement gramm, GRM).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasWeightWithStand">ceo:hasWeightWithStand</a>
    /// </summary>
    let hasWeightWithStand = _prefixId.prefix "hasWeightWithStand"
    /// <summary>
    ///   <para>ceo:belongsToModule : Camcorder</para>
    ///   <para>rdfs:label : Weißabgleichrdfs:label : white balance</para>
    ///   <para>rdfs:comment : Defines the global adjustment of the intensities of the colors.</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasWhiteBalance">ceo:hasWhiteBalance</a>
    /// </summary>
    let hasWhiteBalance = _prefixId.prefix "hasWhiteBalance"
    /// <summary>
    ///   <para>ceo:belongsToModule : MP3Player, TV, Printer, DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Breiterdfs:label : width</para>
    ///   <para>rdfs:comment : Defines the distance between the ends of an object, its linear extent as measured from end to end (Common unit of measurement centimetre, CMT).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasWidth">ceo:hasWidth</a>
    /// </summary>
    let hasWidth = _prefixId.prefix "hasWidth"
    /// <summary>
    ///   <para>ceo:belongsToModule : TV</para>
    ///   <para>rdfs:label : Breite mit Standfußrdfs:label : width with stand</para>
    ///   <para>rdfs:comment : Defines the distance between the ends of an object, its linear extent as measured from end to end with its stand (Common unit of measurement centimetre, CMT).</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasWidthWithStand">ceo:hasWidthWithStand</a>
    /// </summary>
    let hasWidthWithStand = _prefixId.prefix "hasWidthWithStand"
    /// <summary>
    ///   <para>ceo:belongsToModule : DigitalCamera, Camcorder</para>
    ///   <para>rdfs:label : Zoomrdfs:label : zoom</para>
    ///   <para>rdfs:comment : Zoom is a method of decreasing (narrowing) the apparent angle of view of a photographic or video image.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital zoom" (http://en.wikipedia.org/wiki/Digital_zoom) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)</para>
    ///   <a href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasZoom">ceo:hasZoom</a>
    /// </summary>
    let hasZoom = _prefixId.prefix "hasZoom"
    let iDream = _prefixId.prefix "iDream"
    let iRiver = _prefixId.prefix "iRiver"
