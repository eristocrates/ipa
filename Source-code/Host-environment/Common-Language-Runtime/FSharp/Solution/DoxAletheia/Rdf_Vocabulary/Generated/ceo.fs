namespace http.www.ebusiness_unibw.org.ontologies.consumerelectronics.v1.hash

open DoxAletheia

module ceo =
    let _namespace_name =
        "http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Format of the german institute for standardization: 841 x 1189 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#A0"></see></summary>
    let A0 = _prefix "A0"
    /// <summary>
    /// Describes to which product categories the property or concept belongs (comma seperated, e.g. "MP3Player, TV").
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#belongsToModule"></see></summary>
    let belongsToModule = _prefix "belongsToModule"
    /// <summary>
    /// Sizes and shapes of the paper.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MediaFormat"></see></summary>
    let MediaFormat = _prefix "MediaFormat"
    /// <summary>
    /// Format of the german institute for standardization: 594 x 841 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#A1"></see></summary>
    let A1 = _prefix "A1"
    /// <summary>
    /// Format of the german institute for standardization: 420 x 594 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#A2"></see></summary>
    let A2 = _prefix "A2"
    /// <summary>
    /// Format of the german institute for standardization: 297 x 420 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#A3"></see></summary>
    let A3 = _prefix "A3"
    /// <summary>
    /// Format of the german institute for standardization: 210 x 297 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#A4"></see></summary>
    let A4 = _prefix "A4"
    /// <summary>
    /// Format of the german institute for standardization: 148 x 210 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#A5"></see></summary>
    let A5 = _prefix "A5"
    /// <summary>
    /// Format of the german institute for standardization: 105 x 148 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#A6"></see></summary>
    let A6 = _prefix "A6"
    /// <summary>
    /// Format of the german institute for standardization: 74 x 105 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#A7"></see></summary>
    let A7 = _prefix "A7"
    /// <summary>
    /// Format of the german institute for standardization: 52 x 74 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#A8"></see></summary>
    let A8 = _prefix "A8"
    /// <summary>
    /// Format of the german institute for standardization: 37 x 52 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#A9"></see></summary>
    let A9 = _prefix "A9"
    /// <summary>
    /// Advanced Audio Coding (AAC) is a standardized, lossy compression and encoding scheme for digital audio.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Advanced Audio Coding" (http://en.wikipedia.org/wiki/Advanced_Audio_Coding) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AAC-LC"></see></summary>
    let ``AAC-LC`` = _prefix "AAC-LC"
    /// <summary>
    /// A data format is a particular way to encode information for storage in a computer file (refers to audiodata).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "File Format" (http://en.wikipedia.org/wiki/File_format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DataFormatAudio"></see></summary>
    let DataFormatAudio = _prefix "DataFormatAudio"
    /// <summary>
    /// A linear or switched-mode power supply (or in some cases just a transformer) that is built into the top of a plug and needed for the conversion of one form of electrical power to another desired form and voltage.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Power supply" (http://en.wikipedia.org/wiki/Power_supply) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ACAdapter"></see></summary>
    let ACAdapter = _prefix "ACAdapter"
    /// <summary>
    /// A Power Supply Adapter is used to convert 120 or 240 volt AC supplied by a utility company to a well-regulated lower voltage DC for electronic devices.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Power supply" (http://en.wikipedia.org/wiki/Power_supply) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PowerSupplyUnit"></see></summary>
    let PowerSupplyUnit = _prefix "PowerSupplyUnit"
    /// <summary>
    /// A net transfer of energy over a complete cycle of the alternating current waveform.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AC_Cable"></see></summary>
    let AC_Cable = _prefix "AC_Cable"
    /// <summary>
    /// A subordinate or supplementary item; an adjunct.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Accessory"></see></summary>
    let Accessory = _prefix "Accessory"
    /// <summary>
    /// Audio Interchange File Format (AIFF) is an audio file format standard used for storing sound data for personal computers and other electronic audio devices.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Audio Interchange File Format" (http://en.wikipedia.org/wiki/Audio_Interchange_File_Format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AIFF"></see></summary>
    let AIFF = _prefix "AIFF"
    /// <summary>
    /// The business entity AIPTEK, Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AIPTEK"></see></summary>
    let AIPTEK = _prefix "AIPTEK"
    /// <summary>
    /// Apple Lossless (also known as Apple Lossless Encoder, ALE, or Apple Lossless Audio Codec, ALAC) is an audio codec developed by Apple Inc. for lossless data compression of digital music.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Apple Lossless" (http://en.wikipedia.org/wiki/Apple_Lossless) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ALE"></see></summary>
    let ALE = _prefix "ALE"
    /// <summary>
    /// The business entity AOC.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AOC"></see></summary>
    let AOC = _prefix "AOC"
    /// <summary>
    /// Advanced Systems Format (formerly Advanced Streaming Format, Active Streaming Format) is Microsoft's proprietary digital audio/digital video container format, especially meant for streaming media. ASF is part of the Windows Media framework.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Advanced Systems Format" (http://en.wikipedia.org/wiki/Advanced_Systems_Format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ASF"></see></summary>
    let ASF = _prefix "ASF"
    /// <summary>
    /// The business entity ATEC.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ATEC"></see></summary>
    let ATEC = _prefix "ATEC"
    /// <summary>
    /// ATMT
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ATMT"></see></summary>
    let ATMT = _prefix "ATMT"
    /// <summary>
    /// Audio connectors and video connectors are electrical connectors for carrying an audio signal or video signal, either in an analog or digital format. Analog A/V connectors often use shielded cable to inhibit RF interference and noise.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Audio and video connector" (http://en.wikipedia.org/wiki/Audio_and_video_connector) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AV"></see></summary>
    let AV = _prefix "AV"
    /// <summary>
    /// A generic term for linking devices to each other and allow sending data in one or both directions.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Connectivity"></see></summary>
    let Connectivity = _prefix "Connectivity"
    /// <summary>
    /// A high-definition and standard-definition recording format for use in digital tapeless camcorders. The format is comparable to other handheld video camera recording formats, particularly HDV and TOD.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "HDV" (http://en.wikipedia.org/wiki/HDV) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AVCH"></see></summary>
    let AVCH = _prefix "AVCH"
    /// <summary>
    /// A data format is a particular way to encode information for storage in a computer file (refers to video data).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "File Format" (http://en.wikipedia.org/wiki/File_format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DataFormatVideo"></see></summary>
    let DataFormatVideo = _prefix "DataFormatVideo"
    /// <summary>
    /// A multimedia container format introduced by Microsoft.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AVI"></see></summary>
    let AVI = _prefix "AVI"
    /// <summary>
    /// A cable to carry video and audio signals from a device, to a tv; in digital or analog format.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AV_Cable"></see></summary>
    let AV_Cable = _prefix "AV_Cable"
    /// <summary>
    /// The business entity Acer, Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Acer"></see></summary>
    let Acer = _prefix "Acer"
    /// <summary>
    /// The business entity Actebis Peacock GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Actebis"></see></summary>
    let Actebis = _prefix "Actebis"
    /// <summary>
    /// Is acuteness or clearness of vision, especially form vision, which is dependent on the sharpness of the retinal focus within the eye and the sensitivity of the interpretative faculty of the brain.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Visual acuity" (http://en.wikipedia.org/wiki/Visual_acuity) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Acuity"></see></summary>
    let Acuity = _prefix "Acuity"
    /// <summary>
    /// Additional video equipment and abilities.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#VideoFeatures"></see></summary>
    let VideoFeatures = _prefix "VideoFeatures"
    /// <summary>
    /// The business entity Agfa-Gevaert N.V.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Agfa"></see></summary>
    let Agfa = _prefix "Agfa"
    /// <summary>
    /// The business entity Beijing Huaqi Information Digital Technology Co., Ltd.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Aigo"></see></summary>
    let Aigo = _prefix "Aigo"
    /// <summary>
    /// The business entity Sony Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Aiwa"></see></summary>
    let Aiwa = _prefix "Aiwa"
    /// <summary>
    /// The business entity Akai.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Akai"></see></summary>
    let Akai = _prefix "Akai"
    /// <summary>
    /// Has wakeup-function.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Alert"></see></summary>
    let Alert = _prefix "Alert"
    /// <summary>
    /// Additional equipment and abilities.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Features"></see></summary>
    let Features = _prefix "Features"
    /// <summary>
    /// Ambilight, which is short for Ambient Lighting Technology, is a feature invented by Philips Electronics, generating light effects around the TV that correspond to the video content.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Ambilight" (http://en.wikipedia.org/wiki/Ambilight) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Ambilight1"></see></summary>
    let Ambilight1 = _prefix "Ambilight1"
    /// <summary>
    /// Ambilight Spectra 2 generates reactive ambient lighting on both sides of a Flat TV.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AmbilightSpectra2"></see></summary>
    let AmbilightSpectra2 = _prefix "AmbilightSpectra2"
    /// <summary>
    /// Enlarges the screen further by projecting a glow of light from the back of the screen onto the surrounding wall. Ambilight adjusts automatically the colour and brightness of the light surrounding the TV to match with the picture.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AmbilightSpectra3"></see></summary>
    let AmbilightSpectra3 = _prefix "AmbilightSpectra3"
    /// <summary>
    /// Active Frame is a single soft halo of light powered by 126 LEDs.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AmbilightSpectraActiveFrame"></see></summary>
    let AmbilightSpectraActiveFrame = _prefix "AmbilightSpectraActiveFrame"
    /// <summary>
    /// An analog or analogue signal is any continuous signal for which the time varying feature (variable) of the signal is a representation of some other time varying quantity, i.e analogous to another time varying signal.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Analog signal" (http://en.wikipedia.org/wiki/Analog_signal) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Analog"></see></summary>
    let Analog = _prefix "Analog"
    /// <summary>
    /// Type of TV tuner that is used to convert RF television transmissions into audio and video signals.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Tuner (electronics)" (http://en.wikipedia.org/wiki/Tuner_(electronics)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TunerType"></see></summary>
    let TunerType = _prefix "TunerType"
    /// <summary>
    /// The screen has a short persistence phosphor with an anti-reflection and anti-static coating.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Anti-ReflectionCoatedScreen"></see></summary>
    let ``Anti-ReflectionCoatedScreen`` = _prefix "Anti-ReflectionCoatedScreen"
    /// <summary>
    /// Additional general equipment and abilities.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#GeneralFeatures"></see></summary>
    let GeneralFeatures = _prefix "GeneralFeatures"
    /// <summary>
    /// The business entity Apacer Technology, Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Apacer"></see></summary>
    let Apacer = _prefix "Apacer"
    /// <summary>
    /// The business entity Apple, Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Apple"></see></summary>
    let Apple = _prefix "Apple"
    /// <summary>
    /// The business entity Archos GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Archos"></see></summary>
    let Archos = _prefix "Archos"
    /// <summary>
    /// The business entity Asus.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Asus"></see></summary>
    let Asus = _prefix "Asus"
    /// <summary>
    /// Audio interface type of a specific diameter.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Audio2.5mm"></see></summary>
    let ``Audio2.5mm`` = _prefix "Audio2.5mm"
    /// <summary>
    /// Interface generally refers to an abstraction that an entity provides of itself to the outside (refers to audio output).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Interface (computer science)" (http://en.wikipedia.org/wiki/Interface_(computer_science)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AudioInterfaceType"></see></summary>
    let AudioInterfaceType = _prefix "AudioInterfaceType"
    /// <summary>
    /// Audio interface type of a specific diameter.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Audio3.5mm"></see></summary>
    let ``Audio3.5mm`` = _prefix "Audio3.5mm"
    /// <summary>
    /// Additional audio equipment and abilities.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AudioFeatures"></see></summary>
    let AudioFeatures = _prefix "AudioFeatures"
    /// <summary>
    /// Defines the support of a computer soundcard driver protocol for digital audio specified by Steinberg, providing a low-latency and high fidelity interface between a software application and a computer's sound card.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AudioInput"></see></summary>
    let AudioInput = _prefix "AudioInput"
    /// <summary>
    /// Gives an indication of preprogrammed channels for the user of a television so that he does not need to programm it himself.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AutoChannelSearch"></see></summary>
    let AutoChannelSearch = _prefix "AutoChannelSearch"
    /// <summary>
    /// Levels the audio volume of televisions automatically so that undesired peaks in the sound can be reduced.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AutoVolumeLeveller"></see></summary>
    let AutoVolumeLeveller = _prefix "AutoVolumeLeveller"
    /// <summary>
    /// Ability to adapt of different adjustments of the intensities of the colors.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AutoWhiteBalance"></see></summary>
    let AutoWhiteBalance = _prefix "AutoWhiteBalance"
    /// <summary>
    /// Is the global adjustment of the intensities of the colors (typically red, green, and blue primary colors). An important goal of this adjustment is to render specific colors - particularly neutral colors - correctly; hence, the general method is sometimes called gray balance, neutral balance, or white balance.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "White Balance" (http://en.wikipedia.org/wiki/White_Balance) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#WhiteBalance"></see></summary>
    let WhiteBalance = _prefix "WhiteBalance"
    /// <summary>
    /// A device used to stabilize a picture in order to keep it in a steady position.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#AutomaticPictureStabilizer"></see></summary>
    let AutomaticPictureStabilizer = _prefix "AutomaticPictureStabilizer"
    /// <summary>
    /// The business entity Axago.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Axago"></see></summary>
    let Axago = _prefix "Axago"
    /// <summary>
    /// Format of the german institute for standardization: 1000 x 1414 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#B0"></see></summary>
    let B0 = _prefix "B0"
    /// <summary>
    /// Format of the german institute for standardization: 707 x 1000 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#B1"></see></summary>
    let B1 = _prefix "B1"
    /// <summary>
    /// Format of the german institute for standardization: 500 x 707 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#B2"></see></summary>
    let B2 = _prefix "B2"
    /// <summary>
    /// Format of the german institute for standardization: 353 x 500 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#B3"></see></summary>
    let B3 = _prefix "B3"
    /// <summary>
    /// Format of the german institute for standardization: 250 x 353 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#B4"></see></summary>
    let B4 = _prefix "B4"
    /// <summary>
    /// Format of the german institute for standardization: 176 x 250 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#B5"></see></summary>
    let B5 = _prefix "B5"
    /// <summary>
    /// Format of the german institute for standardization: 125 x 176 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#B6"></see></summary>
    let B6 = _prefix "B6"
    /// <summary>
    /// Format of the german institute for standardization: 88 x 125 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#B7"></see></summary>
    let B7 = _prefix "B7"
    /// <summary>
    /// Format of the german institute for standardization: 62 x 88 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#B8"></see></summary>
    let B8 = _prefix "B8"
    /// <summary>
    /// Format of the german institute for standardization: 44 x 62 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#B9"></see></summary>
    let B9 = _prefix "B9"
    /// <summary>
    /// Ability to photograph against a light source.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#BacklightMode"></see></summary>
    let BacklightMode = _prefix "BacklightMode"
    /// <summary>
    /// Ability of the camcorder to adapt to special environments.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#BeachAndSnow"></see></summary>
    let BeachAndSnow = _prefix "BeachAndSnow"
    /// <summary>
    /// A projection of information from any physical environment into any sensory system.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SceneMode"></see></summary>
    let SceneMode = _prefix "SceneMode"
    /// <summary>
    /// RGB Value 245,245,220
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Beige"></see></summary>
    let Beige = _prefix "Beige"
    /// <summary>
    /// Color derives from the spectrum of light interacting in the eye with the spectral sensitivities of the light receptors.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Color" (http://en.wikipedia.org/wiki/Color) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Color"></see></summary>
    let Color = _prefix "Color"
    /// <summary>
    /// The business entity Belkin International Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Belkin"></see></summary>
    let Belkin = _prefix "Belkin"
    /// <summary>
    /// The business entity BenQ Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#BenQ"></see></summary>
    let BenQ = _prefix "BenQ"
    /// <summary>
    /// In computer graphics, a bitmap or pixmap is a type of memory organization or image file format used to store digital images.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Bitmap" (http://en.wikipedia.org/wiki/Bitmap) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Bitmap"></see></summary>
    let Bitmap = _prefix "Bitmap"
    /// <summary>
    /// A data format is a particular way to encode information for storage in a computer file (refers to image data).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "File Format" (http://en.wikipedia.org/wiki/File_format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DataFormatImage"></see></summary>
    let DataFormatImage = _prefix "DataFormatImage"
    /// <summary>
    /// RGB Value 0,0,0
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Black"></see></summary>
    let Black = _prefix "Black"
    /// <summary>
    /// RGB Value 0,0,255
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Blue"></see></summary>
    let Blue = _prefix "Blue"
    /// <summary>
    /// Bluetooth is a wireless protocol utilizing short-range communications technology facilitating data transmission over short distances from fixed and mobile devices, creating wireless personal area networks.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Bluetooth"></see></summary>
    let Bluetooth = _prefix "Bluetooth"
    /// <summary>
    /// Interface generally refers to an abstraction that an entity provides of itself to the outside.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Interface (computer science)" (http://en.wikipedia.org/wiki/Interface_(computer_science)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DataInterfaceType"></see></summary>
    let DataInterfaceType = _prefix "DataInterfaceType"
    /// <summary>
    /// Bluetooth is a wireless protocol utilizing short-range communications technology facilitating data transmission over short distances from fixed and mobile devices, creating wireless personal area networks (refers to audio).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#BluetoothAudio"></see></summary>
    let BluetoothAudio = _prefix "BluetoothAudio"
    /// <summary>
    /// The business entity Brother.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Brother"></see></summary>
    let Brother = _prefix "Brother"
    /// <summary>
    /// RGB Value 165,42,42
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Brown"></see></summary>
    let Brown = _prefix "Brown"
    /// <summary>
    /// Speakers that are integrated in the hull of a electronical device, that is able to play audio signals.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#BuiltInSpeakers"></see></summary>
    let BuiltInSpeakers = _prefix "BuiltInSpeakers"
    /// <summary>
    /// The CE marking (also known as CE mark) is a mandatory conformity mark on many products placed on the single market in the European Economic Area (EEA).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "CE mark" (http://en.wikipedia.org/wiki/CE_mark) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CE_Mark"></see></summary>
    let CE_Mark = _prefix "CE_Mark"
    /// <summary>
    /// A certificate is an official document affirming some fact like quality standards.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Certificate" (http://en.wikipedia.org/wiki/Certificate) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Certificate"></see></summary>
    let Certificate = _prefix "Certificate"
    /// <summary>
    /// CGM (Computer Graphics Metafile) is a file format for 2D vector graphics, raster graphics, and text, and is defined by ISO/IEC 8632.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Computer Graphics Metafile" (http://en.wikipedia.org/wiki/Computer_Graphics_Metafile) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CGM"></see></summary>
    let CGM = _prefix "CGM"
    /// <summary>
    /// Complementary metal-oxide-semiconductor (CMOS) (pronounced "see-moss", IPA: /ˈsiːmɒs/), is a major class of integrated circuits. CMOS technology is used in microprocessors, microcontrollers, static RAM, and other digital logic circuits. CMOS technology is also used for a wide variety of analog circuits such as image sensors, data converters, and highly integrated transceivers for many types of communication. Frank Wanlass successfully patented CMOS in 1967 (US Patent 3,356,858).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "CMOS" (http://en.wikipedia.org/wiki/CMOS) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CMOS"></see></summary>
    let CMOS = _prefix "CMOS"
    /// <summary>
    /// Type of device that measures a physical quantity and converts it into a signal which can be read by an observer or by an instrument.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Sensor" (http://en.wikipedia.org/wiki/Sensor) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SensorType"></see></summary>
    let SensorType = _prefix "SensorType"
    /// <summary>
    /// The business entity CTX.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CTX"></see></summary>
    let CTX = _prefix "CTX"
    /// <summary>
    /// Composite video is often designated by the CVBS acronym, meaning any of "Color, Video, Blank and Sync", "Composite Video Baseband Signal", "Composite Video Burst Signal", or "Composite Video with Burst and Sync". Here the input is meant.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CVBS_in"></see></summary>
    let CVBS_in = _prefix "CVBS_in"
    /// <summary>
    /// Composite video is often designated by the CVBS acronym, meaning any of "Color, Video, Blank and Sync", "Composite Video Baseband Signal", "Composite Video Burst Signal", or "Composite Video with Burst and Sync". Here the output is meant.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CVBS_out"></see></summary>
    let CVBS_out = _prefix "CVBS_out"
    /// <summary>
    /// A camcorder is a portable consumer electronics device for recording video and audio using a built-in recorder unit.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Camcorder"></see></summary>
    let Camcorder = _prefix "Camcorder"
    /// <summary>
    /// The business entity Canon.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Canon"></see></summary>
    let Canon = _prefix "Canon"
    /// <summary>
    /// The business entity Canyon.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Canyon"></see></summary>
    let Canyon = _prefix "Canyon"
    /// <summary>
    /// A paper stock that is thicker and more durable than normal writing or printing paper, but thinner and more flexible than other forms of paperboard.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Cardstock" (http://en.wikipedia.org/wiki/Card_stock) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Cardstock"></see></summary>
    let Cardstock = _prefix "Cardstock"
    /// <summary>
    /// The type of paper a device is able to handle.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MediaType"></see></summary>
    let MediaType = _prefix "MediaType"
    /// <summary>
    /// The business entity Casio Computer Co., Ltd.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Casio"></see></summary>
    let Casio = _prefix "Casio"
    /// <summary>
    /// A child safety lock is a special-purpose lock that is designed to help prevent children from getting at any dangerous contents.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Child safety lock" (http://en.wikipedia.org/wiki/Child_safety_lock) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ChildSafetyLock"></see></summary>
    let ChildSafetyLock = _prefix "ChildSafetyLock"
    /// <summary>
    /// The business entity Chimei.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Chimei"></see></summary>
    let Chimei = _prefix "Chimei"
    /// <summary>
    /// Can display the current time.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Clock"></see></summary>
    let Clock = _prefix "Clock"
    /// <summary>
    /// The business entity Coby Electronics Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Coby"></see></summary>
    let Coby = _prefix "Coby"
    /// <summary>
    /// The reproduction of an image or text in color on a paper.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ColorPrint"></see></summary>
    let ColorPrint = _prefix "ColorPrint"
    /// <summary>
    /// In signal processing, a comb filter adds a delayed version of a signal to itself, causing constructive and destructive interference. The frequency response of a comb filter consists of a series of regularly-spaced spikes, giving the appearance of a comb.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Comb filter" (http://en.wikipedia.org/wiki/Comb_filter) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CombFilter"></see></summary>
    let CombFilter = _prefix "CombFilter"
    /// <summary>
    /// The Common Interface is an extensible digital interconnect found in the digital TV market.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Common Interface" (http://en.wikipedia.org/wiki/Common_Interface) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CommonInterface"></see></summary>
    let CommonInterface = _prefix "CommonInterface"
    /// <summary>
    /// CompactFlash (CF) is a mass storage device format used in portable electronic devices. For storage, CompactFlash typically uses flash memory in a standardized enclosure.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "CompactFlash" (http://en.wikipedia.org/wiki/CompactFlash) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CompactFlash"></see></summary>
    let CompactFlash = _prefix "CompactFlash"
    /// <summary>
    /// A data storage device is a device for recording (storing) information (data).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Data Storage Device" (http://en.wikipedia.org/wiki/Data_storage_device) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#StorageMedia"></see></summary>
    let StorageMedia = _prefix "StorageMedia"
    /// <summary>
    /// Ability to communicate with different kinds of operating systems.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CompatibleOperatingSystems"></see></summary>
    let CompatibleOperatingSystems = _prefix "CompatibleOperatingSystems"
    /// <summary>
    /// Component video is a video signal that has been split into two or more components. In popular use, it refers to a type of analog video information that is transmitted or stored as three separate signals. Component video can be contrasted with composite video (NTSC, PAL or SECAM) in which all the video information is combined into a single line-level signal. Like composite, component video cables do not carry audio and are often paired with audio cables. Here the input is meant.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Component video" (http://en.wikipedia.org/wiki/Component_video) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ComponentVideoIn"></see></summary>
    let ComponentVideoIn = _prefix "ComponentVideoIn"
    /// <summary>
    /// Component video is a video signal that has been split into two or more components. In popular use, it refers to a type of analog video information that is transmitted or stored as three separate signals. Component video can be contrasted with composite video (NTSC, PAL or SECAM) in which all the video information is combined into a single line-level signal. Like composite, component video cables do not carry audio and are often paired with audio cables. Here the output is meant.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Component video" (http://en.wikipedia.org/wiki/Component_video) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ComponentVideoOut"></see></summary>
    let ComponentVideoOut = _prefix "ComponentVideoOut"
    /// <summary>
    /// Composite video is the format of an analog television (picture only) signal before it is combined with a sound signal and modulated onto an RF carrier. It is usually in a standard format such as NTSC, PAL, or SECAM. It is a composite of three source signals called Y, U and V (together referred to as YUV) with sync pulses. Here the input is meant.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Composite video" (http://en.wikipedia.org/wiki/Composite_video) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#CompositeVideoIn"></see></summary>
    let CompositeVideoIn = _prefix "CompositeVideoIn"
    /// <summary>
    /// The display resolution of a computer display typically refers to the number of distinct pixels in each dimension that can be displayed.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Display resolution" (http://en.wikipedia.org/wiki/Display_resolution) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ComputerDisplayResolution"></see></summary>
    let ComputerDisplayResolution = _prefix "ComputerDisplayResolution"
    /// <summary>
    /// Resolution supported by an electronical device.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SupportedResolution"></see></summary>
    let SupportedResolution = _prefix "SupportedResolution"

    /// <summary>
    /// Display resolution specified as the width and height in pixels, color depth measured in bits, and refresh rate expressed in hertz; here Extended Graphics Array.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Display resolution" (http://en.wikipedia.org/wiki/Display_resolution) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ComputerDisplayResolution_1024x768_60_70_75_85Hz"></see></summary>
    let ComputerDisplayResolution_1024x768_60_70_75_85Hz =
        _prefix "ComputerDisplayResolution_1024x768_60_70_75_85Hz"

    /// <summary>
    /// Display resolution specified as the width and height in pixels, color depth measured in bits, and refresh rate expressed in hertz; here Video Graphics Array.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Display resolution" (http://en.wikipedia.org/wiki/Display_resolution) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ComputerDisplayResolution_640x480_60_72_75_85Hz"></see></summary>
    let ComputerDisplayResolution_640x480_60_72_75_85Hz =
        _prefix "ComputerDisplayResolution_640x480_60_72_75_85Hz"

    /// <summary>
    /// Display resolution specified as the width and height in pixels, color depth measured in bits, and refresh rate expressed in hertz; here Super Video Graphics Array.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Display resolution" (http://en.wikipedia.org/wiki/Display_resolution) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ComputerDisplayResolution_800x600_60_72_75_85Hz"></see></summary>
    let ComputerDisplayResolution_800x600_60_72_75_85Hz =
        _prefix "ComputerDisplayResolution_800x600_60_72_75_85Hz"

    /// <summary>
    /// Ensures that, according to the scene, the screen always displays the best possible contrast. This results in a depth of focus, which lends an extraordinary power to the television image, making it appear almost touchable.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ContrastPlus"></see></summary>
    let ContrastPlus = _prefix "ContrastPlus"
    /// <summary>
    /// The business entity COWON SYSTEMS, Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Cowon"></see></summary>
    let Cowon = _prefix "Cowon"
    /// <summary>
    /// The business entity Creative Technology Limited.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Creative_Labs"></see></summary>
    let Creative_Labs = _prefix "Creative_Labs"
    /// <summary>
    /// The mean amplitude of a waveform.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DC_Cable"></see></summary>
    let DC_Cable = _prefix "DC_Cable"
    /// <summary>
    /// The business entity DK digital GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DK_digital"></see></summary>
    let DK_digital = _prefix "DK_digital"
    /// <summary>
    /// Format of the german institute for standardization: 110 x 220 mm.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DL"></see></summary>
    let DL = _prefix "DL"
    /// <summary>
    /// The Digital Living Network Alliance is an international, cross-industry collaboration of consumer electronics, computing industry and mobile device companies. Members of DLNA develop a concept of wired and wireless interoperable networks where digital content such as photos, music, and videos can be shared through consumer electronics (CE), personal computers (PCs), and mobile devices in and beyond the home.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital Living Network Alliance" (http://en.wikipedia.org/wiki/Digital_Living_Network_Alliance) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DLNA_Ethernet"></see></summary>
    let DLNA_Ethernet = _prefix "DLNA_Ethernet"
    /// <summary>
    /// A file extension for word processing documents.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DOC"></see></summary>
    let DOC = _prefix "DOC"
    /// <summary>
    /// A data format is a particular way to encode information for storage in a computer file (refers to office data).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "File Format" (http://en.wikipedia.org/wiki/File_format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DataFormatOffice"></see></summary>
    let DataFormatOffice = _prefix "DataFormatOffice"
    /// <summary>
    /// DPOF (Digital Print Order format) is a format which allows the user of a digital camera or other device such as a Mobile Phone or PDA to define which captured images on the storage card are to be printed, together with information on the number of copies or other image information such as paper size, image title text, image orientation, contact information and more.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "DPOF" (http://en.wikipedia.org/wiki/DPOF) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DPOF"></see></summary>
    let DPOF = _prefix "DPOF"
    /// <summary>
    /// Digital Video (DV) is a digital video format created by Sony, JVC, Panasonic and other video camera producers, and launched in 1995. The DV specification (originally known as the Blue Book, current official name IEC 61834) defines both the codec and the tape format.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "DV" (http://en.wikipedia.org/wiki/DV) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DV"></see></summary>
    let DV = _prefix "DV"
    /// <summary>
    /// Digital Video Broadcasting (DVB) is a suite of internationally accepted open standards for digital television. DVB systems distribute data using a variety of approaches, including by satellite (DVB-S, DVB-S2 and DVB-SH; also DVB-SMATV for distribution via SMATV); cable (DVB-C); terrestrial television (DVB-T, DVB-T2) and digital terrestrial television for handhelds (DVB-H,DVB-SH); and via microwave using DTT (DVB-MT), the MMDS (DVB-MC), and/or MVDS standards (DVB-MS).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital Video Broadcasting" (http://en.wikipedia.org/wiki/Digital_Video_Broadcasting) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DVB"></see></summary>
    let DVB = _prefix "DVB"
    /// <summary>
    /// Type of the transmitted video format signal that is displayed by a monitor or TV panel.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SignalFormat"></see></summary>
    let SignalFormat = _prefix "SignalFormat"
    /// <summary>
    /// DVB-T is an abbreviation for Digital Video Broadcasting - Terrestrial; it is the DVB European-based consortium standard for the broadcast transmission of digital terrestrial television. This system transmits compressed digital audio, video and other data in an MPEG transport stream, using COFDM modulation.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "DVB-T" (http://en.wikipedia.org/wiki/DVB-T) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DVB-T"></see></summary>
    let ``DVB-T`` = _prefix "DVB-T"
    /// <summary>
    /// Digital Video Broadcasting (DVB) is a suite of internationally accepted open standards for digital television. Coded OFDM (COFDM) and Discrete multi-tone modulation (DMT) is a frequency-division multiplexing (FDM) scheme utilized as a digital multi-carrier modulation method. A large number of closely-spaced orthogonal sub-carriers are used to carry data. The data is divided into several parallel data streams or channels, one for each sub-carrier. Each sub-carrier is modulated with a conventional modulation scheme (such as quadrature amplitude modulation or phase shift keying) at a low symbol rate, maintaining total data rates similar to conventional single-carrier modulation schemes in the same bandwidth.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital Video Broadcasting" (http://en.wikipedia.org/wiki/Digital_Video_Broadcasting) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DVB_COFDM"></see></summary>
    let DVB_COFDM = _prefix "DVB_COFDM"
    /// <summary>
    /// The Digital Visual Interface (DVI) is a video interface standard designed to maximize the visual quality of digital display devices such as flat panel LCD computer displays and digital projectors. It is designed for carrying uncompressed digital video data to a display. It is partially compatible with the High-Definition Multimedia Interface (HDMI) standard in digital mode (DVI-D), and VGA in analog mode (DVI-A).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital Visual Interface" (http://en.wikipedia.org/wiki/Digital_Visual_Interface) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DVI"></see></summary>
    let DVI = _prefix "DVI"
    /// <summary>
    /// A digital video format created by Sony, JVC, Panasonic and other video camera producers.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DVI_in"></see></summary>
    let DVI_in = _prefix "DVI_in"
    /// <summary>
    /// A digital video format created by Sony, JVC, Panasonic and other video camera producers.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DVI_out"></see></summary>
    let DVI_out = _prefix "DVI_out"
    /// <summary>
    /// The business entity Daewoo.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Daewoo"></see></summary>
    let Daewoo = _prefix "Daewoo"
    /// <summary>
    /// The business entity Dane-Elec GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Dane-Elec"></see></summary>
    let ``Dane-Elec`` = _prefix "Dane-Elec"
    /// <summary>
    /// A data format is a particular way to encode information for storage in a computer file.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "File Format" (http://en.wikipedia.org/wiki/File_format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DataFormat"></see></summary>
    let DataFormat = _prefix "DataFormat"
    /// <summary>
    /// The business entity Decktron Europe GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Decktron"></see></summary>
    let Decktron = _prefix "Decktron"
    /// <summary>
    /// The business entity Dell.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Dell"></see></summary>
    let Dell = _prefix "Dell"
    /// <summary>
    /// The business entity Denver.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Denver"></see></summary>
    let Denver = _prefix "Denver"
    /// <summary>
    /// The business entity Differo Ltd.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Differo"></see></summary>
    let Differo = _prefix "Differo"
    /// <summary>
    /// The business entity DIFRNCE B.V.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Difrnce"></see></summary>
    let Difrnce = _prefix "Difrnce"
    /// <summary>
    /// A digital system uses discrete (discontinuous) values, usually but not always symbolized numerically (hence called "digital") to represent information for input, processing, transmission, storage.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital" (http://en.wikipedia.org/wiki/Digital) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Digital"></see></summary>
    let Digital = _prefix "Digital"
    /// <summary>
    /// Digital audio uses digital signals for sound reproduction. This includes analog-to-digital conversion, digital-to-analog conversion, storage and transmission. From the signal point of view, a connector can be viewed as a short, rigid cable. The connector usually has the same impedance as the related cable and probably has a similar cutoff frequency although its dielectric may be different. Some connectors are gold or rhodium plated, while some connectors use nickel or tin plating. Silver is also used due to its excellent conductivity. Although silver tends to oxidize rather quickly, the silver oxide that is produced is still conductive. This may pose a cosmetic issue but it does not degrade the performance of the connector. Here the output is meant.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital audio" (http://en.wikipedia.org/wiki/Digital_audio) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DigitalAudioCoaxialOut"></see></summary>
    let DigitalAudioCoaxialOut = _prefix "DigitalAudioCoaxialOut"
    /// <summary>
    /// Digital audio uses digital signals for sound reproduction. This includes analog-to-digital conversion, digital-to-analog conversion, storage, and transmission. TOSLINK or Optical Cable is a standardized optical fiber connection system.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital audio" (http://en.wikipedia.org/wiki/Digital_audio) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DigitalAudioOpticalOut"></see></summary>
    let DigitalAudioOpticalOut = _prefix "DigitalAudioOpticalOut"
    /// <summary>
    /// A digital camera (or digicam for short) is a camera that takes video or still photographs, or both, digitally by recording images via an electronic image sensor.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital camera" (http://en.wikipedia.org/wiki/Digital_camera) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DigitalCamera"></see></summary>
    let DigitalCamera = _prefix "DigitalCamera"
    /// <summary>
    /// Digital Crystal Clear is a package of picture innovations that digitally adjusts and optimises picture quality to optimal contrast, colour and sharpness levels.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DigitalCrystalClear"></see></summary>
    let DigitalCrystalClear = _prefix "DigitalCrystalClear"
    /// <summary>
    /// Seamlessly up-scales any video source to display at full high definition 1080p.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DigitalImageScalingTechnology"></see></summary>
    let DigitalImageScalingTechnology = _prefix "DigitalImageScalingTechnology"
    /// <summary>
    /// A display device is an output device for presentation of information for visual, tactile or auditive reception, acquired, stored, or transmitted in various forms.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Display device" (http://en.wikipedia.org/wiki/Display_device) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DisplayType"></see></summary>
    let DisplayType = _prefix "DisplayType"
    /// <summary>
    /// Is any kind of electrochemical cell in which the electrochemical reaction of interest is not reversible.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DisposableBattery"></see></summary>
    let DisposableBattery = _prefix "DisposableBattery"
    /// <summary>
    /// Disposable batteries are non-rechargeable batteries. When they are out of power you have to dispose them.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DisposableEnergySource"></see></summary>
    let DisposableEnergySource = _prefix "DisposableEnergySource"
    /// <summary>
    /// Methods of energy storage have been developed, which transform electrical energy into forms of potential energy.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Energy development" (http://en.wikipedia.org/wiki/Energy_development) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#EnergySource"></see></summary>
    let EnergySource = _prefix "EnergySource"
    /// <summary>
    /// Ability to display documents.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DocumentViewing"></see></summary>
    let DocumentViewing = _prefix "DocumentViewing"
    /// <summary>
    /// The marketing name for a series of lossy audio compression technologies developed by Dolby Laboratories.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Dolby Digital" (http://en.wikipedia.org/wiki/Dolby_Digital) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DolbyDigital"></see></summary>
    let DolbyDigital = _prefix "DolbyDigital"
    /// <summary>
    /// A feature of computer printers and MFPs that allows the automatic printing of a sheet of paper on both sides.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DuplexPrint"></see></summary>
    let DuplexPrint = _prefix "DuplexPrint"
    /// <summary>
    /// Dynamic settlement of bass audiosignals.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#DynamicBassEnhancement"></see></summary>
    let DynamicBassEnhancement = _prefix "DynamicBassEnhancement"
    /// <summary>
    /// 480p is the shorthand name for a video display resolution. The p stands for progressive scan, i.e. non-interlaced. The 480 denotes a vertical resolution of 480 vertically scanning lines, usually with a horizontal resolution of 640 pixels and 4:3 aspect ratio or a horizontal resolution of 854 pixels and 16:9 aspect ratio.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "480p" (http://en.wikipedia.org/wiki/480p) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#EDTV_480p"></see></summary>
    let EDTV_480p = _prefix "EDTV_480p"
    /// <summary>
    /// The display resolution of a digital television or display typically refers to the number of distinct pixels in each dimension that can be displayed.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Display resolution" (http://en.wikipedia.org/wiki/Display_resolution) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TVDisplayResolution"></see></summary>
    let TVDisplayResolution = _prefix "TVDisplayResolution"
    /// <summary>
    /// An electronic program(me) guide (EPG) or interactive program(me) guide (IPG) or electronic service guide (ESG) is an digital guide to scheduled broadcast television or radio programs, typically displayed on-screen with functions allowing a viewer to navigate, select, and discover content by time, title, channel, genre, etc. by use of their remote control, a keyboard, or other input devices such as a phone keypad.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Electronic program guide" (http://en.wikipedia.org/wiki/Electronic_program_guide) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#EPG"></see></summary>
    let EPG = _prefix "EPG"
    /// <summary>
    /// The business entity EACONN B.V.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Eaconn"></see></summary>
    let Eaconn = _prefix "Eaconn"
    /// <summary>
    /// Equipment that allows economical printing.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#EconomicalMode"></see></summary>
    let EconomicalMode = _prefix "EconomicalMode"
    /// <summary>
    /// The business entity Eizo.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Eizo"></see></summary>
    let Eizo = _prefix "Eizo"
    /// <summary>
    /// The business entity Energy Sistem Soyntec S.A.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Energy_Sistem"></see></summary>
    let Energy_Sistem = _prefix "Energy_Sistem"
    /// <summary>
    /// Is a packaging product, usually made of flat material such as paper or cardboard.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Envelope"></see></summary>
    let Envelope = _prefix "Envelope"
    /// <summary>
    /// The business entity Seiko Epson Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Epson"></see></summary>
    let Epson = _prefix "Epson"
    /// <summary>
    /// Equalization, equalisation or EQ is the process of using passive or active electronic elements or digital algorithms for the purpose of altering (originally flattening) the frequency response characteristics of a system.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Equalization" (http://en.wikipedia.org/wiki/Equalization) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Equalizer"></see></summary>
    let Equalizer = _prefix "Equalizer"
    /// <summary>
    /// The business entity Esselte.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Esselte"></see></summary>
    let Esselte = _prefix "Esselte"
    /// <summary>
    /// Free Lossless Audio Codec (FLAC) is a file format for lossless audio data compression.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Free Lossless Audio Codec" (http://en.wikipedia.org/wiki/Free_Lossless_Audio_Codec) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#FLAC"></see></summary>
    let FLAC = _prefix "FLAC"
    /// <summary>
    /// Ability to identify the face and to justify the picture to it.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#FaceIdendification"></see></summary>
    let FaceIdendification = _prefix "FaceIdendification"
    /// <summary>
    /// The business entity Finlux.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Finlux"></see></summary>
    let Finlux = _prefix "Finlux"
    /// <summary>
    /// The term upgrade refers to the replacement of a product with a newer version of that same product, here it is the replacement of the firmware with a newer version of it.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#FirmwareUpgradable"></see></summary>
    let FirmwareUpgradable = _prefix "FirmwareUpgradable"
    /// <summary>
    /// Is a device used in photography that produces an instantaneous flash of artificial light.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Flash"></see></summary>
    let Flash = _prefix "Flash"
    /// <summary>
    /// A focus, also called an image point, is the point where light rays originating from a point on the object converge.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Focus (optics)" (http://en.wikipedia.org/wiki/Focus_(optics)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Focus"></see></summary>
    let Focus = _prefix "Focus"
    /// <summary>
    /// Autofocus (or AF) is a feature of some optical systems that allows them to obtain (and in some systems to also continuously maintain) correct focus on a subject, instead of requiring the operator to adjust focus manually.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Autofocus" (http://en.wikipedia.org/wiki/Autofocus) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#FocusAuto"></see></summary>
    let FocusAuto = _prefix "FocusAuto"
    /// <summary>
    /// A photographic lens for which the focus is not adjustable is called a fixed-focus lens.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Fixed focus" (http://en.wikipedia.org/wiki/Fixed_focus) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#FocusFixed"></see></summary>
    let FocusFixed = _prefix "FocusFixed"
    /// <summary>
    /// A manual focus allows the operator to adjust the focus of the lens by hand.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Manual focus" (http://en.wikipedia.org/wiki/Manual_focus) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#FocusManual"></see></summary>
    let FocusManual = _prefix "FocusManual"
    /// <summary>
    /// Encompasses a range of techniques for enriching (expanding and deepening) the sound reproduction quality, of an audio source, with additional audio channels reproduced via additional, discrete speakers.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Format5.1ch"></see></summary>
    let ``Format5.1ch`` = _prefix "Format5.1ch"
    /// <summary>
    /// The business entity Freecom Technologies GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Freecom"></see></summary>
    let Freecom = _prefix "Freecom"
    /// <summary>
    /// The business entity Fujifilm Holdings Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Fujifilm"></see></summary>
    let Fujifilm = _prefix "Fujifilm"
    /// <summary>
    /// The business entity Fujitsu Siemens.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Fujitsu_Siemens"></see></summary>
    let Fujitsu_Siemens = _prefix "Fujitsu_Siemens"
    /// <summary>
    /// Usually assumes a widescreen aspect ratio of 16:9, implying a horizontal resolution of 1920 pixels. This creates a frame resolution of 1920×1080, or 2,073,600 pixels in total.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "1080p" (http://en.wikipedia.org/wiki/1080p) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#FullHD"></see></summary>
    let FullHD = _prefix "FullHD"
    /// <summary>
    /// A designation used by Apple Computer to describe a fourth generation of 32-bit PowerPC microprocessors.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "PowerPC_G4" (http://en.wikipedia.org/wiki/PowerPC_G4) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#G4_Class_Processor"></see></summary>
    let G4_Class_Processor = _prefix "G4_Class_Processor"
    /// <summary>
    /// The type of central processing unit (CPU) as an electronic circuit that can execute printing tasks or programs.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ProcessorType"></see></summary>
    let ProcessorType = _prefix "ProcessorType"
    /// <summary>
    /// The business entity General Electric Company.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#GE"></see></summary>
    let GE = _prefix "GE"
    /// <summary>
    /// The format supports up to 8 bits per pixel, allowing a single image to reference a palette of up to 256 distinct colors chosen from the 24-bit RGB color space.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Graphics Interchange Format" (http://en.wikipedia.org/wiki/Graphics_Interchange_Format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#GIF"></see></summary>
    let GIF = _prefix "GIF"
    /// <summary>
    /// The business entity GNR.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#GNR"></see></summary>
    let GNR = _prefix "GNR"
    /// <summary>
    /// A special mode providing more performance of the television to optimize pictures when games are played on a LCD or plasma panel.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#GameMode"></see></summary>
    let GameMode = _prefix "GameMode"
    /// <summary>
    /// The business entity GEMBIRD ® Deutschland GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Gembird"></see></summary>
    let Gembird = _prefix "Gembird"
    /// <summary>
    /// RGB Value 255,215,0
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Gold"></see></summary>
    let Gold = _prefix "Gold"
    /// <summary>
    /// RGB Value 0,128,0
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Green"></see></summary>
    let Green = _prefix "Green"
    /// <summary>
    /// RGB Value 128,128,128
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Grey"></see></summary>
    let Grey = _prefix "Grey"
    /// <summary>
    /// The business entity Griffin Technology.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Griffin"></see></summary>
    let Griffin = _prefix "Griffin"
    /// <summary>
    /// The business entity GRUNDIG Intermedia GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Grundig"></see></summary>
    let Grundig = _prefix "Grundig"
    /// <summary>
    /// The business entity Guillemot Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Guillemot"></see></summary>
    let Guillemot = _prefix "Guillemot"
    /// <summary>
    /// H.264 is a standard for video compression, and is equivalent to MPEG-4 Part 10, or MPEG-4 AVC (for Advanced Video Coding). As of 2008, it is the latest block-oriented motion-compensation-based codec standard developed by the ITU-T Video Coding Experts Group (VCEG) together with the ISO/IEC Moving Picture Experts Group (MPEG), and it was the product of a partnership effort known as the Joint Video Team (JVT).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "H.264" (http://en.wikipedia.org/wiki/H.264) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#H.264"></see></summary>
    let ``H.264`` = _prefix "H.264"
    /// <summary>
    /// HDMI (High-Definition Multimedia Interface) is a compact audio/video interface for transmitting uncompressed digital data. It represents a digital alternative to consumer analog standards such as Radio Frequency (RF) coaxial cable, composite video, S-Video, SCART, component video, D-Terminal, and VGA. HDMI connects digital audio/video sources such as set-top boxes, Blu-ray Disc players, personal computers (PCs), video game consoles, and AV receivers to compatible digital audio devices, computer monitors, and digital televisions.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "HDMI" (http://en.wikipedia.org/wiki/HDMI) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#HDMI"></see></summary>
    let HDMI = _prefix "HDMI"
    /// <summary>
    /// HDMI (High-Definition Multimedia Interface) is a compact audio/video interface for transmitting uncompressed digital data.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "HDMI" (http://en.wikipedia.org/wiki/HDMI) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#HDMI_Interface"></see></summary>
    let HDMI_Interface = _prefix "HDMI_Interface"
    /// <summary>
    /// 1080i is the shorthand name of a format of high-definition video modes. 1080 denotes the number of horizontal scan lines - also known as vertical resolution - and the letter i stands for interlaced.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "1080i" (http://en.wikipedia.org/wiki/1080i) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#HDTV_1080i"></see></summary>
    let HDTV_1080i = _prefix "HDTV_1080i"
    /// <summary>
    /// 1080p is the shorthand name for a category of HDTV video modes. The number "1080" represents 1,080 lines of vertical resolution (1080 horizontal scan lines), while the letter p stands for progressive scan (meaning the image is not interlaced). 1080p can be referred to as full HD or full high definition to differentiate it from other HDTV video modes.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "1080p" (http://en.wikipedia.org/wiki/1080p) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#HDTV_1080p"></see></summary>
    let HDTV_1080p = _prefix "HDTV_1080p"
    /// <summary>
    /// 720p is the shorthand name for a category of HDTV video modes. The number 720 stands for the 720 vertical scan lines of display resolution (also known as 720 pixels of vertical resolution), while the letter p stands for progressive scan or non-interlaced.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "720p" (http://en.wikipedia.org/wiki/720p) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#HDTV_720p"></see></summary>
    let HDTV_720p = _prefix "HDTV_720p"
    /// <summary>
    /// The business entity Hewlett-Packard Company.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#HP"></see></summary>
    let HP = _prefix "HP"
    /// <summary>
    /// Special printing technology invented and used by HP.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#HP_FastRes_1200_DPI"></see></summary>
    let HP_FastRes_1200_DPI = _prefix "HP_FastRes_1200_DPI"
    /// <summary>
    /// Defines the maximum digital resolution the device is able to print.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PrintResolution"></see></summary>
    let PrintResolution = _prefix "PrintResolution"
    /// <summary>
    /// Special printing technology invented and used by HP.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#HP_REt"></see></summary>
    let HP_REt = _prefix "HP_REt"
    /// <summary>
    /// The business entity Haier.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Haier"></see></summary>
    let Haier = _prefix "Haier"
    /// <summary>
    /// The business entity Hannspree.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Hannspree"></see></summary>
    let Hannspree = _prefix "Hannspree"
    /// <summary>
    /// The business entity Harwa.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Harwa"></see></summary>
    let Harwa = _prefix "Harwa"
    /// <summary>
    /// Port to connect headphones with an electronical device. Here the port has the diameter of 2,5 millimetres.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#HeadphoneLineOut_2.5mm"></see></summary>
    let ``HeadphoneLineOut_2.5mm`` = _prefix "HeadphoneLineOut_2.5mm"
    /// <summary>
    /// Port to connect headphones with an electronical device. Here the port has the diameter of 3,5 millimetres.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#HeadphoneLineOut_3.5mm"></see></summary>
    let ``HeadphoneLineOut_3.5mm`` = _prefix "HeadphoneLineOut_3.5mm"
    /// <summary>
    /// A pair of small loudspeakers, or less commonly a single speaker, with a way of holding them close to a user's ears and a means of connecting them to a signal source such as an audio amplifier, radio or CD player.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Headphones"></see></summary>
    let Headphones = _prefix "Headphones"
    /// <summary>
    /// The business entity Hisense.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Hisense"></see></summary>
    let Hisense = _prefix "Hisense"
    /// <summary>
    /// The business entity Hitachi.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Hitachi"></see></summary>
    let Hitachi = _prefix "Hitachi"
    /// <summary>
    /// The business entity Humax.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Humax"></see></summary>
    let Humax = _prefix "Humax"
    /// <summary>
    /// Hyperband designates a range (band) of electromagnetic waves with frequencies between 300 MHz and 470 MHz. This is designated for kable TV especially to recieve digital TV normed for DVB-C.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Hyperband"></see></summary>
    let Hyperband = _prefix "Hyperband"
    /// <summary>
    /// The business entity Hyundai.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Hyundai"></see></summary>
    let Hyundai = _prefix "Hyundai"
    /// <summary>
    /// The business entity IBM.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#IBM"></see></summary>
    let IBM = _prefix "IBM"
    /// <summary>
    /// The IEEE 1394 interface is a serial bus interface standard for high-speed communications and isochronous real-time data transfer, frequently used by personal computers, as well as in digital audio, digital video, automotive, and aeronautics applications.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "firewire" (http://en.wikipedia.org/wiki/FireWire) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#IEEE_1394"></see></summary>
    let IEEE_1394 = _prefix "IEEE_1394"
    /// <summary>
    /// IEEE 802.11 is a set of standards for wireless local area network (WLAN) computer communication, developed by the IEEE LAN/MAN Standards Committee (IEEE 802) in the 5 GHz and 2.4 GHz public spectrum bands.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "802.11" (http://en.wikipedia.org/wiki/802.11) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#IEEE_802.11"></see></summary>
    let ``IEEE_802.11`` = _prefix "IEEE_802.11"
    /// <summary>
    /// Remote control with a electromagnetic radiation whose wavelength is longer than that of visible light (400-700 nm), but shorter than that of terahertz radiation (3-300 µm) and microwaves (~30,000 µm). Infrared radiation spans roughly three orders of magnitude (750 nm and 1000 µm)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#IR_Remote"></see></summary>
    let IR_Remote = _prefix "IR_Remote"
    /// <summary>
    /// The business entity Iiyama.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Iiyama"></see></summary>
    let Iiyama = _prefix "Iiyama"
    /// <summary>
    /// The business entity InFocus.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#InFocus"></see></summary>
    let InFocus = _prefix "InFocus"
    /// <summary>
    /// Psycho-acoustic method of widening the stereo spatial image especially suited for applications with limited separation of left and right speakers.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#IncredibleSurround"></see></summary>
    let IncredibleSurround = _prefix "IncredibleSurround"
    /// <summary>
    /// Ability to adapt of different adjustments of the intensities of the colors.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#IndoorWhiteBalance"></see></summary>
    let IndoorWhiteBalance = _prefix "IndoorWhiteBalance"
    /// <summary>
    /// The business entity InfoPrint.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#InfoPrint"></see></summary>
    let InfoPrint = _prefix "InfoPrint"
    /// <summary>
    /// Infrared (IR) radiation is electromagnetic radiation whose wavelength is longer than that of visible light, but shorter than that of terahertz radiation and microwaves.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Infrared" (http://en.wikipedia.org/wiki/Infrared) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Infrared"></see></summary>
    let Infrared = _prefix "Infrared"
    /// <summary>
    /// Inkjet printers operate by propelling variably-sized droplets of liquid or molten material (ink) onto almost any sized page.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Inkjet printer" (http://en.wikipedia.org/wiki/Inkjet_printer) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#InkjetPrinter"></see></summary>
    let InkjetPrinter = _prefix "InkjetPrinter"
    /// <summary>
    /// A peripheral which produces a hard copy (permanent human-readable text and/or graphics) of documents stored in electronic form, usually on physical print media such as paper or transparencies.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Printer" (http://en.wikipedia.org/wiki/Computer_printer) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Printer"></see></summary>
    let Printer = _prefix "Printer"
    /// <summary>
    /// Clock integrated in a device.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#IntegratedClock"></see></summary>
    let IntegratedClock = _prefix "IntegratedClock"
    /// <summary>
    /// The business entity Intenso GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Intenso"></see></summary>
    let Intenso = _prefix "Intenso"
    /// <summary>
    /// Flash memory is non-volatile computer memory that can be electrically erased and reprogrammed.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#InternalFlashMemory"></see></summary>
    let InternalFlashMemory = _prefix "InternalFlashMemory"
    /// <summary>
    /// Hard disk drive, a computer device which stores digitally encoded data.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#InternalHDD"></see></summary>
    let InternalHDD = _prefix "InternalHDD"
    /// <summary>
    /// The business entity Intuix LLC.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Intuix"></see></summary>
    let Intuix = _prefix "Intuix"
    /// <summary>
    /// JPEG compression is used in a number of image file formats. JPEG/Exif is the most common image format used by digital cameras and other photographic image capture devices; along with JPEG/JFIF, it is the most common format for storing and transmitting photographic images on the World Wide Web.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "JPEG" (http://en.wikipedia.org/wiki/JPEG) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#JPEG"></see></summary>
    let JPEG = _prefix "JPEG"
    /// <summary>
    /// The business entity Victor Company of Japan, Limited.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#JVC"></see></summary>
    let JVC = _prefix "JVC"
    /// <summary>
    /// The business entity Eastman Kodak Company.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Kodak"></see></summary>
    let Kodak = _prefix "Kodak"
    /// <summary>
    /// The business entity Konica Minolta.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Konica_Minolta"></see></summary>
    let Konica_Minolta = _prefix "Konica_Minolta"
    /// <summary>
    /// The business entity Genius, KYE Systems Corp.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Kye_Genius"></see></summary>
    let Kye_Genius = _prefix "Kye_Genius"
    /// <summary>
    /// The business entity Kyocera.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Kyocera"></see></summary>
    let Kyocera = _prefix "Kyocera"
    /// <summary>
    /// A liquid crystal display (LCD) is an electronically-modulated optical device shaped into a thin, flat panel made up of any number of color or monochrome pixels filled with liquid crystals and arrayed in front of a light source (backlight) or reflector.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Liquid crystal display" (http://en.wikipedia.org/wiki/Liquid_crystal_display) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#LCD"></see></summary>
    let LCD = _prefix "LCD"
    /// <summary>
    /// The business entity LG Group.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#LG"></see></summary>
    let LG = _prefix "LG"
    /// <summary>
    /// Media type that can be printed on one side and has a glued area on the other side.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Label"></see></summary>
    let Label = _prefix "Label"
    /// <summary>
    /// A label printer is a computer peripheral that prints on self-adhesive label material and sometimes card-stock (also called tags).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#LabelPrinter"></see></summary>
    let LabelPrinter = _prefix "LabelPrinter"
    /// <summary>
    /// A laser printer is a common type of computer printer that rapidly produces high quality text and graphics on plain paper.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Laser printer" (http://en.wikipedia.org/wiki/Laser_printer) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#LaserPrinter"></see></summary>
    let LaserPrinter = _prefix "LaserPrinter"
    /// <summary>
    /// Special sort of paper used in laser printers.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#LaserPrintingPaper"></see></summary>
    let LaserPrintingPaper = _prefix "LaserPrintingPaper"
    /// <summary>
    /// The business entity LAVOD CORPORATION.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Lavod"></see></summary>
    let Lavod = _prefix "Lavod"
    /// <summary>
    /// The business entity Lenco Audio-Video.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Lenco"></see></summary>
    let Lenco = _prefix "Lenco"
    /// <summary>
    /// A lens is an optical device with perfect or approximate axial symmetry which transmits and refracts light, converging or diverging the beam.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Lens (optics)" (http://en.wikipedia.org/wiki/Lens_(optics)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#LensSystem"></see></summary>
    let LensSystem = _prefix "LensSystem"
    /// <summary>
    /// The business entity Lexar Media, Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Lexar"></see></summary>
    let Lexar = _prefix "Lexar"
    /// <summary>
    /// The business entity Lexmark.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Lexmark"></see></summary>
    let Lexmark = _prefix "Lexmark"
    /// <summary>
    /// Lithium polymer batteries (abbreviated Li-poly, Li-Pol, LiPo, LIP, PLI or LiP) are rechargeable batteries which have technologically evolved from lithium-ion batteries.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Lithium-polymer" (http://en.wikipedia.org/wiki/Lithium-polymer) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Li-Ion_Polymer"></see></summary>
    let ``Li-Ion_Polymer`` = _prefix "Li-Ion_Polymer"
    /// <summary>
    /// A rechargeable battery is a kind of energy source that is able to be reused by refilling it with a charger.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#RechargeableEnergySource"></see></summary>
    let RechargeableEnergySource = _prefix "RechargeableEnergySource"
    /// <summary>
    /// Is the total amount of light allowed to fall on the photographic medium during the process of taking a photograph.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#LightExposureControl"></see></summary>
    let LightExposureControl = _prefix "LightExposureControl"
    /// <summary>
    /// Ability to record sounds via cable connection.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#LineInRecorder"></see></summary>
    let LineInRecorder = _prefix "LineInRecorder"
    /// <summary>
    /// Linux is a generic term commonly used to refer to Unix-like computer operating systems which use the Linux kernel.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Linux"></see></summary>
    let Linux = _prefix "Linux"
    /// <summary>
    /// Type of rechargeable battery in which a lithium ion moves between the anode and cathode.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Lithium ion battery" (http://en.wikipedia.org/wiki/Lithium_ion_battery) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Lit-Ion"></see></summary>
    let ``Lit-Ion`` = _prefix "Lit-Ion"
    /// <summary>
    /// The business entity Logitech International S.A.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Logitech"></see></summary>
    let Logitech = _prefix "Logitech"
    /// <summary>
    /// A solid state disk or flash memory data storage device.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MMC"></see></summary>
    let MMC = _prefix "MMC"
    /// <summary>
    /// The QuickTime (.mov) file format functions as a multimedia container file that contains one or more tracks, each of which stores a particular type of data: audio, video, effects, or text (e.g. for subtitles).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "QuickTime" (http://en.wikipedia.org/wiki/QuickTime) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MOV"></see></summary>
    let MOV = _prefix "MOV"
    /// <summary>
    /// A digital audio encoding format using a form of lossy data compression.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MP3"></see></summary>
    let MP3 = _prefix "MP3"
    /// <summary>
    /// Playback equipment for certain data formats, especially audio data. Product is often equipped with some scope of delivery. Especially earphones, booklet, sotwareCD, charger and datacable.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MP3Player"></see></summary>
    let MP3Player = _prefix "MP3Player"
    /// <summary>
    /// A collection of methods defining compression of audio digital data.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MP4_Audio"></see></summary>
    let MP4_Audio = _prefix "MP4_Audio"
    /// <summary>
    /// A collection of methods defining compression of video digital data.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MP4_Video"></see></summary>
    let MP4_Video = _prefix "MP4_Video"
    /// <summary>
    /// Includes all kinds of MPEG formats.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MPEG"></see></summary>
    let MPEG = _prefix "MPEG"
    /// <summary>
    /// The business entity MPIO Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MPIO"></see></summary>
    let MPIO = _prefix "MPIO"
    /// <summary>
    /// The business entity MPMAN Europe.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MPMAN"></see></summary>
    let MPMAN = _prefix "MPMAN"
    /// <summary>
    /// The business entity Micro-Star Int'l Co., Ltd.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MSI"></see></summary>
    let MSI = _prefix "MSI"
    /// <summary>
    /// Mac OS is the trademarked name for a series of graphical user interface-based operating systems developed by Apple Inc. for their Macintosh line of computer systems.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MacOSXCheetah"></see></summary>
    let MacOSXCheetah = _prefix "MacOSXCheetah"
    /// <summary>
    /// Mac OS is the trademarked name for a series of graphical user interface-based operating systems developed by Apple Inc. for their Macintosh line of computer systems.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MacOSXJaguar"></see></summary>
    let MacOSXJaguar = _prefix "MacOSXJaguar"
    /// <summary>
    /// Mac OS is the trademarked name for a series of graphical user interface-based operating systems developed by Apple Inc. for their Macintosh line of computer systems.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MacOSXLeopard"></see></summary>
    let MacOSXLeopard = _prefix "MacOSXLeopard"
    /// <summary>
    /// Mac OS is the trademarked name for a series of graphical user interface-based operating systems developed by Apple Inc. for their Macintosh line of computer systems.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MacOSXPanther"></see></summary>
    let MacOSXPanther = _prefix "MacOSXPanther"
    /// <summary>
    /// Mac OS is the trademarked name for a series of graphical user interface-based operating systems developed by Apple Inc. for their Macintosh line of computer systems.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MacOSXPuma"></see></summary>
    let MacOSXPuma = _prefix "MacOSXPuma"
    /// <summary>
    /// Mac OS is the trademarked name for a series of graphical user interface-based operating systems developed by Apple Inc. for their Macintosh line of computer systems.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MacOSXSnowLeopard"></see></summary>
    let MacOSXSnowLeopard = _prefix "MacOSXSnowLeopard"
    /// <summary>
    /// Mac OS is the trademarked name for a series of graphical user interface-based operating systems developed by Apple Inc. for their Macintosh line of computer systems.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MacOSXTiger"></see></summary>
    let MacOSXTiger = _prefix "MacOSXTiger"
    /// <summary>
    /// The business entity Maxfield GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Maxfield"></see></summary>
    let Maxfield = _prefix "Maxfield"
    /// <summary>
    /// Media format that is able to assume different shapes.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MediaFormaPostcard"></see></summary>
    let MediaFormaPostcard = _prefix "MediaFormaPostcard"
    /// <summary>
    /// Media format that is able to assume different shapes.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MediaFormatEnvelope"></see></summary>
    let MediaFormatEnvelope = _prefix "MediaFormatEnvelope"
    /// <summary>
    /// The business entity Medion AG.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Medion"></see></summary>
    let Medion = _prefix "Medion"
    /// <summary>
    /// The business entity Memorex Products, Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Memorex"></see></summary>
    let Memorex = _prefix "Memorex"
    /// <summary>
    /// Memory Stick is a removable flash memory card format.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MemoryStick"></see></summary>
    let MemoryStick = _prefix "MemoryStick"
    /// <summary>
    /// The business entity Modul Burotic SAS.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Memup"></see></summary>
    let Memup = _prefix "Memup"
    /// <summary>
    /// A miniature, 1-inch hard disk designed to fit in a CompactFlash (CF) Type II slot.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MicroDrive"></see></summary>
    let MicroDrive = _prefix "MicroDrive"
    /// <summary>
    /// Ability to record voices and sounds.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Microphon"></see></summary>
    let Microphon = _prefix "Microphon"
    /// <summary>
    /// The business entity Microsoft Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Microsoft"></see></summary>
    let Microsoft = _prefix "Microsoft"
    /// <summary>
    /// The non-standard Mini-USB's, official Mini-B, Micro-A, and Micro-B connectors are used for smaller devices such as PDAs, mobile phones or digital cameras. The Standard-A plug is approximately 4 by 12 mm, the Standard-B approximately 7 by 8 mm, and the Mini-A and Mini-B plugs approximately 2 by 7 mm.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Universial Serial Bus" (http://en.wikipedia.org/wiki/Universal_Serial_Bus) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MiniUSB"></see></summary>
    let MiniUSB = _prefix "MiniUSB"
    /// <summary>
    /// The business entity Mirai.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Mirai"></see></summary>
    let Mirai = _prefix "Mirai"
    /// <summary>
    /// Ability to display just two colors (black/white).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Monochrome"></see></summary>
    let Monochrome = _prefix "Monochrome"
    /// <summary>
    /// Ability to display more than two different kinds of color.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Multicolor"></see></summary>
    let Multicolor = _prefix "Multicolor"
    /// <summary>
    /// The body of the Product has more than one color.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#MulticoloredBody"></see></summary>
    let MulticoloredBody = _prefix "MulticoloredBody"
    /// <summary>
    /// The business entity Mustek Ltd.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Mustek"></see></summary>
    let Mustek = _prefix "Mustek"
    /// <summary>
    /// The business entity NEC Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#NEC"></see></summary>
    let NEC = _prefix "NEC"
    /// <summary>
    /// NICAM stands for Near Instantaneous Companded Audio Multiplex. It is an early form of lossy compression for digital audio.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "NICAM" (http://en.wikipedia.org/wiki/NICAM) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#NICAM"></see></summary>
    let NICAM = _prefix "NICAM"
    /// <summary>
    /// A nickel hydrogen battery (NIH2 or Ni-H2) is a rechargeable electrochemical power source based on nickel and hydrogen.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#NIH2"></see></summary>
    let NIH2 = _prefix "NIH2"
    /// <summary>
    /// NTSC (National Television Standard Conversion) is the analog television system used in most of the Americas, Japan, South Korea, Taiwan, the Philippines, Burma, and some Pacific island nations and territories.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "NTSC" (http://en.wikipedia.org/wiki/NTSC) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#NTSC"></see></summary>
    let NTSC = _prefix "NTSC"
    /// <summary>
    /// The business entity Nanopoint Technology Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Nanopoint"></see></summary>
    let Nanopoint = _prefix "Nanopoint"
    /// <summary>
    /// RGB Value 0,0,128
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Navy"></see></summary>
    let Navy = _prefix "Navy"
    /// <summary>
    /// The business entity NETGEAR, Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Netgear"></see></summary>
    let Netgear = _prefix "Netgear"
    /// <summary>
    /// The business entity New Universe B.V.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#New_Universe"></see></summary>
    let New_Universe = _prefix "New_Universe"
    /// <summary>
    /// A type of rechargeable battery using nickel oxide hydroxide and metallic cadmium as electrodes.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Nickel-cadmium battery" (http://en.wikipedia.org/wiki/Nickel-cadmium_battery) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#NiCd"></see></summary>
    let NiCd = _prefix "NiCd"
    /// <summary>
    /// A nickel-metal hydride battery, abbreviated NiMH, is a type of rechargeable battery similar to a nickel-cadmium (NiCd) battery but using a hydrogen-absorbing alloy for the negative electrode instead of cadmium.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Nickel metal hydride battery" (http://en.wikipedia.org/wiki/Nickel_metal_hydride_battery) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#NiMH"></see></summary>
    let NiMH = _prefix "NiMH"
    /// <summary>
    /// Ability of the camcorder to adapt to special environments.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#NightMode"></see></summary>
    let NightMode = _prefix "NightMode"
    /// <summary>
    /// The business entity Nikon Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Nikon"></see></summary>
    let Nikon = _prefix "Nikon"
    /// <summary>
    /// The business entity Nintendo Company Ltd.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Nintendo"></see></summary>
    let Nintendo = _prefix "Nintendo"
    /// <summary>
    /// Noise reduction is the process of removing noise from a signal.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#NoiseReduction"></see></summary>
    let NoiseReduction = _prefix "NoiseReduction"
    /// <summary>
    /// The business entity Nokia Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Nokia"></see></summary>
    let Nokia = _prefix "Nokia"
    /// <summary>
    /// The business entity ODYS.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ODYS"></see></summary>
    let ODYS = _prefix "ODYS"
    /// <summary>
    /// Ogg is a free, open standard container format maintained by the Xiph.Org Foundation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#OGG"></see></summary>
    let OGG = _prefix "OGG"
    /// <summary>
    /// The business entity Oki.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Oki"></see></summary>
    let Oki = _prefix "Oki"
    /// <summary>
    /// RGB Value 128,128,0
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Olive"></see></summary>
    let Olive = _prefix "Olive"
    /// <summary>
    /// The business entity Olivetti.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Olivetti"></see></summary>
    let Olivetti = _prefix "Olivetti"
    /// <summary>
    /// The business entity Olympus Europa Holding GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Olympus"></see></summary>
    let Olympus = _prefix "Olympus"
    /// <summary>
    /// Describes the possibility to maintain a designated  time when the television or electrical device should be switched off or on automatically.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#OnOffTimer"></see></summary>
    let OnOffTimer = _prefix "OnOffTimer"
    /// <summary>
    /// An on-screen display (abbreviated OSD) is an image superimposed on a screen picture, commonly used by modern televisions, VCRs, and DVD players to display information such as volume, channel, and time.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "On-screen display" (http://en.wikipedia.org/wiki/On-screen_display) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#OnScreenDisplay"></see></summary>
    let OnScreenDisplay = _prefix "OnScreenDisplay"
    /// <summary>
    /// A special lens system.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#OneStepFixed"></see></summary>
    let OneStepFixed = _prefix "OneStepFixed"
    /// <summary>
    /// The business entity Oppo.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Oppo"></see></summary>
    let Oppo = _prefix "Oppo"
    /// <summary>
    /// RGB Value 255,165,0
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Orange"></see></summary>
    let Orange = _prefix "Orange"
    /// <summary>
    /// The business entity Orion.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Orion"></see></summary>
    let Orion = _prefix "Orion"
    /// <summary>
    /// Ability to adapt of different adjustments of the intensities of the colors.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#OutdoorWhiteBalance"></see></summary>
    let OutdoorWhiteBalance = _prefix "OutdoorWhiteBalance"
    /// <summary>
    /// PAL, short for Phase Alternating Line, is a colour-encoding system used in broadcast television systems in large parts of the world.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "PAL" (http://en.wikipedia.org/wiki/PAL) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PAL"></see></summary>
    let PAL = _prefix "PAL"
    /// <summary>
    /// PAL, short for Phase Alternating Line, is a colour-encoding system used in broadcast television systems in large parts of the world. This is used in western europe.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "PAL" (http://en.wikipedia.org/wiki/PAL) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PAL-B_G"></see></summary>
    let ``PAL-B_G`` = _prefix "PAL-B_G"
    /// <summary>
    /// PAL, short for Phase Alternating Line, is a colour-encoding system used in broadcast television systems in large parts of the world. This is only used in Ireland, the UK, Hongkong and Macau.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "PAL" (http://en.wikipedia.org/wiki/PAL) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PAL-I"></see></summary>
    let ``PAL-I`` = _prefix "PAL-I"
    /// <summary>
    /// PAL, short for Phase Alternating Line, is a colour-encoding system used in broadcast television systems in large parts of the world. PAL L is used on some hotel internal distribution systems, as well as other public display and plant television systems.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "PAL" (http://en.wikipedia.org/wiki/PAL) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PAL-L"></see></summary>
    let ``PAL-L`` = _prefix "PAL-L"
    /// <summary>
    /// Port to connect the audio cables for a PC with the electronical device.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PCAudioIn"></see></summary>
    let PCAudioIn = _prefix "PCAudioIn"
    /// <summary>
    /// Port to connect a PC with the electronical device.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PCIn"></see></summary>
    let PCIn = _prefix "PCIn"
    /// <summary>
    /// The Personal Computer Memory Card International Association is an international standards body that defines and promotes the PC Card (formerly known as "PCMCIA card") and ExpressCard standards. Although the organization's name refers to memory cards, their standards are not limited to memory devices. These cards can be used for wireless connectivity, modem and other functions in laptop/notebook PCs that may be lacking them natively.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "PCMCIA" (http://en.wikipedia.org/wiki/PCMCIA) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PCMCIA"></see></summary>
    let PCMCIA = _prefix "PCMCIA"
    /// <summary>
    /// Portable Document Format (PDF) is a file format created by Adobe Systems in 1993 for document exchange.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Pdf" (http://en.wikipedia.org/wiki/Pdf) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PDF"></see></summary>
    let PDF = _prefix "PDF"
    /// <summary>
    /// A plasma display panel (PDP) is a type of flat panel display common to large TV displays (37in. [940mm]). Many tiny cells between two panels of glass hold an inert mixture of noble gases. The gas in the cells is electrically turned into a plasma which then excites phosphors to emit light.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital newspaper technology - Plasma" (http://en.wikipedia.org/wiki/Digital_newspaper_technology#Plasma) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PDP"></see></summary>
    let PDP = _prefix "PDP"
    /// <summary>
    /// The PNG (Portable Network Graphics) file format was created as the free, open-source successor to the GIF.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Graphics file format" (http://en.wikipedia.org/wiki/Graphics_file_format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PNG"></see></summary>
    let PNG = _prefix "PNG"
    /// <summary>
    /// The business entity Power Quotient International Co., Ltd.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PQI"></see></summary>
    let PQI = _prefix "PQI"
    /// <summary>
    /// The .PSD (Photoshop Document) format stores an image with support for most imaging options available in Photoshop. These include layers with masks, color spaces, ICC profiles, transparency, text, alpha channels and spot colors, clipping paths, and duotone settings.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Adobe Photoshop" (http://en.wikipedia.org/wiki/Adobe_Photoshop) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PSD"></see></summary>
    let PSD = _prefix "PSD"
    /// <summary>
    /// The business entity Pacific Digital Home.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Pacific_Digital"></see></summary>
    let Pacific_Digital = _prefix "Pacific_Digital"
    /// <summary>
    /// The business entity Packard Bell.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PackardBell"></see></summary>
    let PackardBell = _prefix "PackardBell"
    /// <summary>
    /// The business entity Palm Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Palm"></see></summary>
    let Palm = _prefix "Palm"
    /// <summary>
    /// The business entity Panasonic Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Panasonic"></see></summary>
    let Panasonic = _prefix "Panasonic"
    /// <summary>
    /// The business entity dynaTRON Electronics GmbH &amp; Co KG.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Pendrive"></see></summary>
    let Pendrive = _prefix "Pendrive"
    /// <summary>
    /// The business entity Pentax Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Pentax"></see></summary>
    let Pentax = _prefix "Pentax"
    /// <summary>
    /// Perfect Pixel HD Engine offers the unique combination of ultimate sharpness, natural detail, vivid colours and smooth natural motion on all qualities of HD, standard TV signals and multimedia content, for high definition displays. Each pixel of the incoming picture is enhanced to better match the surrounding pixels, resulting in a more natural picture.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PerfectPixelHD"></see></summary>
    let PerfectPixelHD = _prefix "PerfectPixelHD"
    /// <summary>
    /// The business entity Koninklijke Philips Electronics N.V.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Philips"></see></summary>
    let Philips = _prefix "Philips"
    /// <summary>
    /// The business entity Phillar.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Phillar"></see></summary>
    let Phillar = _prefix "Phillar"
    /// <summary>
    /// The business entity Phoenix.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Phoenix"></see></summary>
    let Phoenix = _prefix "Phoenix"
    /// <summary>
    /// Ability of the camcorder to adapt to special environments.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PhotoMode"></see></summary>
    let PhotoMode = _prefix "PhotoMode"
    /// <summary>
    /// A photo printer is a printer that is specifically designed to print high quality digital photos on photo paper.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Photo printer" (http://en.wikipedia.org/wiki/Photo_printer) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PhotoPrinter"></see></summary>
    let PhotoPrinter = _prefix "PhotoPrinter"
    /// <summary>
    /// Kind of paper that is specifically designed to print high quality digital photos.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Photopaper"></see></summary>
    let Photopaper = _prefix "Photopaper"
    /// <summary>
    /// Is an industry standard from the Camera &amp; Imaging Products Association (CIPA) for direct printing.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PictBridge"></see></summary>
    let PictBridge = _prefix "PictBridge"
    /// <summary>
    /// Picture in Picture (PiP) is a feature of some television receivers and similar devices. One program (channel) is displayed on the full TV screen at the same time as one or more other programs are displayed in inset windows. Sound is usually from the main program only.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Picture in picture" (http://en.wikipedia.org/wiki/Picture-in-picture) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PictureInPicture"></see></summary>
    let PictureInPicture = _prefix "PictureInPicture"
    /// <summary>
    /// Ability to display digital pictures.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PictureViewing"></see></summary>
    let PictureViewing = _prefix "PictureViewing"
    /// <summary>
    /// RGB Value 255,192,203
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Pink"></see></summary>
    let Pink = _prefix "Pink"
    /// <summary>
    /// The business entity Pioneer.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Pioneer"></see></summary>
    let Pioneer = _prefix "Pioneer"
    /// <summary>
    /// Pixelplus 2 is a technology which allows motion reinterpolation on 480p and 576p material.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PixelPlus2"></see></summary>
    let PixelPlus2 = _prefix "PixelPlus2"
    /// <summary>
    /// Pixel Plus 3 HD offers the unique combination of ultimate sharpness, natural detail, vivid colours and smooth natural motion on all qualities of HD, standard TV signals and multimedia content for high definition displays. Each pixel of the incoming picture is enhanced to better match the surrounding pixels, resulting in a more natural picture. Artefacts and noise in all sources from multimedia to standard TV and also in highly compressed HD are detected and reduced.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PixelPlus3HD"></see></summary>
    let PixelPlus3HD = _prefix "PixelPlus3HD"
    /// <summary>
    /// Pixel Plus HD is a picture processing technology that enables viewers to watch content that is vivid, natural and real.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PixelPlusHD"></see></summary>
    let PixelPlusHD = _prefix "PixelPlusHD"
    /// <summary>
    /// Thin material mainly used for writing upon, printing upon or packaging.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PlainPaper"></see></summary>
    let PlainPaper = _prefix "PlainPaper"
    /// <summary>
    /// Ability to put audiofiles in a playlist.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Playlist"></see></summary>
    let Playlist = _prefix "Playlist"
    /// <summary>
    /// Describes any hardware specification that alleviates the need for user configuration of device resources.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Legacy Plug and Play" (http://en.wikipedia.org/wiki/Legacy_Plug_and_Play) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PlugAndPlay"></see></summary>
    let PlugAndPlay = _prefix "PlugAndPlay"
    /// <summary>
    /// The business entity Polaroid.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Polaroid"></see></summary>
    let Polaroid = _prefix "Polaroid"
    /// <summary>
    /// Ability of the camcorder to adapt to special environments.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Portrait"></see></summary>
    let Portrait = _prefix "Portrait"
    /// <summary>
    /// Rectangular piece of thick paper or thin cardboard intended for writing and mailing without an envelope.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Postcard"></see></summary>
    let Postcard = _prefix "Postcard"
    /// <summary>
    /// It is a semiconductor diode that emits light when an electric current is applied in the forward direction of the device used to show the power status of an electrical device.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "LED" (http://en.wikipedia.org/wiki/Led) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PowerLED"></see></summary>
    let PowerLED = _prefix "PowerLED"
    /// <summary>
    /// A RISC instruction set architecture created by the 1991 Apple-IBM-Motorola alliance, known as AIM. Originally intended for personal computers, PowerPC CPUs have since become popular embedded and high-performance processors.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#PowerPC_32_bit"></see></summary>
    let PowerPC_32_bit = _prefix "PowerPC_32_bit"
    /// <summary>
    /// The business entity Prestigio.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Prestigio"></see></summary>
    let Prestigio = _prefix "Prestigio"
    /// <summary>
    /// Progressive or noninterlaced scanning is a method for displaying, storing or transmitting moving images in which all the lines of each frame are drawn in sequence.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Progressive scan" (http://en.wikipedia.org/wiki/Progressive_scan) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ProgressiveScan"></see></summary>
    let ProgressiveScan = _prefix "ProgressiveScan"
    /// <summary>
    /// RGB Value 128,0,128
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Purple"></see></summary>
    let Purple = _prefix "Purple"
    /// <summary>
    /// An RF connector is an electrical connector designed to work at radio frequencies in the multi-megahertz range. RF connectors are typically used with coaxial cables and are designed to maintain the shielding that the coaxial design offers. Better models also minimize the change in transmission line impedance at the connection. Mechanically they provide a fastening mechanism (thread, bayonet, braces, push pull) and springs for a low ohmic electric contact while sparing the gold surface thus allowing above 1000 reconnects and reducing the insertion force. Research activity in the area of radio-frequency (RF) circuit design has surged in the last decade in direct response to the enormous market demand for inexpensive, high data rate wireless transceivers.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "RF connector" (http://en.wikipedia.org/wiki/RF_connector) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#RF"></see></summary>
    let RF = _prefix "RF"
    /// <summary>
    /// The RGB color model is an additive color model in which red, green, and blue light are added together in various ways to reproduce a broad array of colors. The name of the model comes from the initials of the three additive primary colors, red, green, and blue. Typical RGB input devices are color TV and video cameras, image scanners, and digital cameras. Typical RGB output devices are TV sets of various technologies (CRT, LCD, plasma, etc.), computer and mobile phone displays, video projectors, multicolor LED displays, and large screens as JumboTron, etc. Color printers, on the other hand, are usually not RGB devices, but subtractive color devices (typically CMYK color model).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "RGB" (http://en.wikipedia.org/wiki/RGB) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#RGB"></see></summary>
    let RGB = _prefix "RGB"
    /// <summary>
    /// Reduced instruction set computing, represents a CPU design strategy emphasizing the insight that simplified instructions that "do less" may still provide for higher performance if this simplicity can be utilized to make instructions execute very quickly.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#RISC"></see></summary>
    let RISC = _prefix "RISC"
    /// <summary>
    /// In telecommunications, RS-232 (Recommended Standard 232) is a standard for serial binary data signals connecting between a DTE (Data Terminal Equipment) and a DCE (Data Circuit-terminating Equipment). It is commonly used in computer serial ports.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "RS-232" (http://en.wikipedia.org/wiki/RS-232) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#RS-232"></see></summary>
    let ``RS-232`` = _prefix "RS-232"
    /// <summary>
    /// Ability to recieve radiosignal.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Radio"></see></summary>
    let Radio = _prefix "Radio"
    /// <summary>
    /// RGB Value 255,0,0
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Red"></see></summary>
    let Red = _prefix "Red"
    /// <summary>
    /// Defines the ability to precede the flash with a series of short, low-power flashes, or a continuous piercing bright light triggering the iris to contract.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#RedEyeReduction"></see></summary>
    let RedEyeReduction = _prefix "RedEyeReduction"
    /// <summary>
    /// The business entity Ricatech B.V.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Ricatech"></see></summary>
    let Ricatech = _prefix "Ricatech"
    /// <summary>
    /// The business entity Ricoh.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Ricoh"></see></summary>
    let Ricoh = _prefix "Ricoh"
    /// <summary>
    /// The Directive on the restriction of the use of certain hazardous substances in electrical and electronic equipment 2002/95/EC.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "ROHS" (http://en.wikipedia.org/wiki/ROHS) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#RoHS"></see></summary>
    let RoHS = _prefix "RoHS"
    /// <summary>
    /// Is an analog video signal that carries the video data as two separate signals, lumen (luminance) and chroma (color).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "S-Video" (http://en.wikipedia.org/wiki/S-Video) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#S-Video_in"></see></summary>
    let ``S-Video_in`` = _prefix "S-Video_in"
    /// <summary>
    /// Is an analog video signal that carries the video data as two separate signals, lumen (luminance) and chroma (color).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "S-Video" (http://en.wikipedia.org/wiki/S-Video) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#S-Video_out"></see></summary>
    let ``S-Video_out`` = _prefix "S-Video_out"
    /// <summary>
    /// SCART (from Syndicat des Constructeurs d'Appareils Radiorécepteurs et Téléviseurs, Radio and Television Receiver Manufacturer's Association) is a French-originated standard and associated 21-pin connector for connecting audio-visual (AV) equipment together.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "SCART" (http://en.wikipedia.org/wiki/SCART) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SCART"></see></summary>
    let SCART = _prefix "SCART"
    /// <summary>
    /// A flash memory card format used in portable device.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SD"></see></summary>
    let SD = _prefix "SD"
    /// <summary>
    /// SDHC (Secure Digital High Capacity, SD 2.0) is an extension of the SD standard that appeared in June 2006.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Secure Digital card" (http://en.wikipedia.org/wiki/Secure_Digital_card) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SDHC"></see></summary>
    let SDHC = _prefix "SDHC"
    /// <summary>
    /// 480i is the shorthand name for a video mode, namely the U.S. NTSC television system or digital television systems with the same characteristics. The i, which is sometimes uppercase, stands for interlaced, the 480 for a vertical frame resolution of 480 lines containing picture information; while NTSC has a total of 525 lines, only 480 of these are used to display the image.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "480i" (http://en.wikipedia.org/wiki/480i) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SDTV_480i"></see></summary>
    let SDTV_480i = _prefix "SDTV_480i"
    /// <summary>
    /// 576i is a standard-definition video mode used in (former) PAL and SECAM countries. In digital applications it's usually referred to as "576i", in analogue contexts it's often quoted as "625 lines". The 576 identifies a vertical resolution of 576 lines (usually with a horizontal resolution of 720 or 704 pixels), and the i identifies it as an interlaced resolution.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "576ii" (http://en.wikipedia.org/wiki/576i) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SDTV_576i"></see></summary>
    let SDTV_576i = _prefix "SDTV_576i"
    /// <summary>
    /// SECAM, also written SÉCAM (Séquentiel couleur à mémoire, French for "Sequential Color with Memory"), is an analog color television system first used in France.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "SECAM" (http://en.wikipedia.org/wiki/SECAM) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SECAM"></see></summary>
    let SECAM = _prefix "SECAM"
    /// <summary>
    /// SECAM, also written SÉCAM (Séquentiel couleur à mémoire, French for "Sequential Color with Memory"), is an analog color television system first used in France. SECAM-B/G is used in the Middle East, former East Germany and Greece.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "SECAM" (http://en.wikipedia.org/wiki/SECAM) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SECAM-B_G"></see></summary>
    let ``SECAM-B_G`` = _prefix "SECAM-B_G"
    /// <summary>
    /// SECAM, also written SÉCAM (Séquentiel couleur à mémoire, French for "Sequential Color with Memory"), is an analog color television system first used in France. SECAM D/K is used in the Commonwealth of Independent States and Eastern Europe (this is simply SECAM used with the D and K monochrome TV transmission standards).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "SECAM" (http://en.wikipedia.org/wiki/SECAM) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SECAM-D_K"></see></summary>
    let ``SECAM-D_K`` = _prefix "SECAM-D_K"
    /// <summary>
    /// SECAM, also written SÉCAM (Séquentiel couleur à mémoire, French for "Sequential Color with Memory"), is an analog color television system first used in France. French SECAM (SECAM-L) is used only in France, Luxembourg (only RTL9 on CH 21 from Dudelange) and Tele Monte-Carlo Transmitters in the south of France.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "SECAM" (http://en.wikipedia.org/wiki/SECAM) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SECAM-L"></see></summary>
    let ``SECAM-L`` = _prefix "SECAM-L"
    /// <summary>
    /// The business entity SIGMA GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SIGMA"></see></summary>
    let SIGMA = _prefix "SIGMA"
    /// <summary>
    /// The business entity SMS.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SMS"></see></summary>
    let SMS = _prefix "SMS"
    /// <summary>
    /// SVG (Scalable Vector Graphics) is an open standard created and developed by the World Wide Web Consortium to address the need (and attempts of several corporations) for a versatile, scriptable and all-purpose vector format for the web and otherwise.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Vector graphics" (http://en.wikipedia.org/wiki/Vector_graphics) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SVG"></see></summary>
    let SVG = _prefix "SVG"
    /// <summary>
    /// The business entity Sagem.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Sagem"></see></summary>
    let Sagem = _prefix "Sagem"
    /// <summary>
    /// The business entity Salora.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Salora"></see></summary>
    let Salora = _prefix "Salora"
    /// <summary>
    /// The business entity Samsung Group.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Samsung"></see></summary>
    let Samsung = _prefix "Samsung"
    /// <summary>
    /// The business entity SanDisk Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SanDisk"></see></summary>
    let SanDisk = _prefix "SanDisk"
    /// <summary>
    /// The business entity Sanyo.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Sanyo"></see></summary>
    let Sanyo = _prefix "Sanyo"
    /// <summary>
    /// The business entity Sapphire Technology Limited
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Sapphire"></see></summary>
    let Sapphire = _prefix "Sapphire"
    /// <summary>
    /// Includes the possibility to switch between different screen formats.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ScreenFormatAdjustments"></see></summary>
    let ScreenFormatAdjustments = _prefix "ScreenFormatAdjustments"
    /// <summary>
    /// The business entity Seiko.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Seiko"></see></summary>
    let Seiko = _prefix "Seiko"
    /// <summary>
    /// Ability to give a delay between the pressing of the shutter release and the shutter firing.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SelfTimer"></see></summary>
    let SelfTimer = _prefix "SelfTimer"
    /// <summary>
    /// 3CCD is a term used to describe an imaging system employed by some still cameras, video cameras, telecine and camcorders.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Three-CCD" (http://en.wikipedia.org/wiki/Three-CCD) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SensorType_3CCD"></see></summary>
    let SensorType_3CCD = _prefix "SensorType_3CCD"
    /// <summary>
    /// The business entity SHARKOON Technologies GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Sharkoon"></see></summary>
    let Sharkoon = _prefix "Sharkoon"
    /// <summary>
    /// The business entity Sharp.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Sharp"></see></summary>
    let Sharp = _prefix "Sharp"
    /// <summary>
    /// Ability to play files in random order.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Shuffle"></see></summary>
    let Shuffle = _prefix "Shuffle"
    /// <summary>
    /// A television tuner converts an RF television transmission into audio and video signals which can be further processed to produce sound and a picture.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Tuner (electronics)" (http://en.wikipedia.org/wiki/Tuner_(electronics)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TVTuner"></see></summary>
    let TVTuner = _prefix "TVTuner"
    /// <summary>
    /// RGB Value 192,192,192
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Silver"></see></summary>
    let Silver = _prefix "Silver"
    /// <summary>
    /// The business entity Sitecom
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Sitecom"></see></summary>
    let Sitecom = _prefix "Sitecom"
    /// <summary>
    /// A sleep timer is a function on many modern televisions that shut off the power after a preset amount of time. The setting is usually made either from the remote control or the television menus. They are intended to allow viewers to watch as they fall asleep.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Sleep timer" (http://en.wikipedia.org/wiki/Sleep_timer) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SleepTimer"></see></summary>
    let SleepTimer = _prefix "SleepTimer"
    /// <summary>
    /// SmartMedia is a flash memory card standard.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SmartMediaCard"></see></summary>
    let SmartMediaCard = _prefix "SmartMediaCard"
    /// <summary>
    /// SmartSound’s technology benefits television producers and editors by giving enhanced creative options through special music technology that delivers multiple musical variations for different moods.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SmartSoundControl"></see></summary>
    let SmartSoundControl = _prefix "SmartSoundControl"
    /// <summary>
    /// The business entity Verbatim Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Smartdisk"></see></summary>
    let Smartdisk = _prefix "Smartdisk"
    /// <summary>
    /// Is a shot that is aimed and fired very quickly at a target that appears suddenly and for a very short period of time.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Snapshot"></see></summary>
    let Snapshot = _prefix "Snapshot"
    /// <summary>
    /// Solar cell or photovoltaic cell is a wide area electronic device that converts solar energy into electricity by the photovoltaic effect.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Solar cell" (http://en.wikipedia.org/wiki/Solar_cell) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Solar"></see></summary>
    let Solar = _prefix "Solar"
    /// <summary>
    /// The business entity Sony Corporation
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Sony"></see></summary>
    let Sony = _prefix "Sony"
    /// <summary>
    /// Ability of the camcorder to adapt to special environments.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Sports"></see></summary>
    let Sports = _prefix "Sports"
    /// <summary>
    /// Ability of the camcorder to adapt to special environments.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Spotlight"></see></summary>
    let Spotlight = _prefix "Spotlight"
    /// <summary>
    /// It is a semiconductor diode that emits light when an electric current is applied in the forward direction of the device used to show the standby status of an electrical device.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "LED" (http://en.wikipedia.org/wiki/Led) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#StandbyLED"></see></summary>
    let StandbyLED = _prefix "StandbyLED"
    /// <summary>
    /// A connection port for a subwoover. Subwoofer is a woofer, or a complete loudspeaker dedicated to the reproduction of bass audio frequencies, from perhaps 150 Hz down as far as 20 Hz, or in rare cases lower.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Subwoofer" (http://en.wikipedia.org/wiki/Subwoofer) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#SubwooferOut"></see></summary>
    let SubwooferOut = _prefix "SubwooferOut"
    /// <summary>
    /// The business entity Sweex.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Sweex"></see></summary>
    let Sweex = _prefix "Sweex"
    /// <summary>
    /// The business entity TEAC Europe GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TEAC"></see></summary>
    let TEAC = _prefix "TEAC"
    /// <summary>
    /// The TIFF (Tagged Image File Format) is a flexible format that normally saves 8 bits or 16 bits per color (red, green, blue) for 24-bit and 48-bit totals, respectively, using either the TIFF or the TIF filenames.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Graphics file format" (http://en.wikipedia.org/wiki/Graphics_file_format) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TIFF"></see></summary>
    let TIFF = _prefix "TIFF"
    /// <summary>
    /// A TRS connector (tip, ring, sleeve) also called an audio jack, phone plug, jack plug, stereo plug, mini-jack, or mini-stereo, is a common audio connector. It is cylindrical in shape, typically with three contacts, although sometimes with two (a TS connector) or four (a TRRS connector).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "TRS connector" (http://en.wikipedia.org/wiki/TRS_connector) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TRSConnector"></see></summary>
    let TRSConnector = _prefix "TRSConnector"
    /// <summary>
    /// The business entity TRUST International B.V.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TRUST"></see></summary>
    let TRUST = _prefix "TRUST"
    /// <summary>
    /// Television (TV) is a widely used telecommunication medium for transmitting and receiving moving images, either monochromatic ("black and white") or color, usually accompanied by sound. Is often deliverd with a remote control and a manual.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "TV" (http://en.wikipedia.org/wiki/Tv) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TV"></see></summary>
    let TV = _prefix "TV"
    /// <summary>
    /// Is a filename extension for files consisting of text usually contain very little formatting.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TXT"></see></summary>
    let TXT = _prefix "TXT"
    /// <summary>
    /// The business entity takeMS International AG.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TakeMS"></see></summary>
    let TakeMS = _prefix "TakeMS"
    /// <summary>
    /// The business entity TallyGenicom.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TallyGenicom"></see></summary>
    let TallyGenicom = _prefix "TallyGenicom"
    /// <summary>
    /// The business entity Tatung Co.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Tatung"></see></summary>
    let Tatung = _prefix "Tatung"
    /// <summary>
    /// The business entity TechniSat.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TechniSat"></see></summary>
    let TechniSat = _prefix "TechniSat"
    /// <summary>
    /// The business entity Techsolo Europe B.V.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Techsolo"></see></summary>
    let Techsolo = _prefix "Techsolo"
    /// <summary>
    /// The business entity Tektronix.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Tektronix"></see></summary>
    let Tektronix = _prefix "Tektronix"
    /// <summary>
    /// Teletext (or "broadcast Teletext") is a television information retrieval service developed in the United Kingdom in the early 1970s. It offers a range of text-based information, typically including national, international and sporting news, weather and TV schedules.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Teletext" (http://en.wikipedia.org/wiki/Teletext) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TeletextFunction"></see></summary>
    let TeletextFunction = _prefix "TeletextFunction"
    /// <summary>
    /// Ability to display text.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TextViewing"></see></summary>
    let TextViewing = _prefix "TextViewing"
    /// <summary>
    /// The business entity The Thomson Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Thomson"></see></summary>
    let Thomson = _prefix "Thomson"
    /// <summary>
    /// A timer is a specialized type of clock counting backwards to a predefined end.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Timer" (http://en.wikipedia.org/wiki/Timer) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Timer"></see></summary>
    let Timer = _prefix "Timer"
    /// <summary>
    /// The business entity Toshiba Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Toshiba"></see></summary>
    let Toshiba = _prefix "Toshiba"
    /// <summary>
    /// The business entity Transcend Information, Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Transcend"></see></summary>
    let Transcend = _prefix "Transcend"
    /// <summary>
    /// A thin sheet of transparent flexible material, typically cellulose acetate, onto which you can print.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Transparency"></see></summary>
    let Transparency = _prefix "Transparency"
    /// <summary>
    /// The business entity TrekStore GmbH &amp; Co. KG
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TrekStor"></see></summary>
    let TrekStor = _prefix "TrekStor"
    /// <summary>
    /// The business entity TwinMOS Technologies Inc
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#TwinMOS"></see></summary>
    let TwinMOS = _prefix "TwinMOS"
    /// <summary>
    /// The business entity COS Distribution GmbH
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Typhoon"></see></summary>
    let Typhoon = _prefix "Typhoon"
    /// <summary>
    /// Ultra high frequency (UHF) designates a range (band) of electromagnetic waves with frequencies between 300 MHz and 3 GHz (3,000 MHz).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "UHF" (http://en.wikipedia.org/wiki/UHF) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#UHF"></see></summary>
    let UHF = _prefix "UHF"
    /// <summary>
    /// Universal Serial Bus (USB) is a serial bus standard to connect devices to a host computer.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Universal Serial Bus" (http://en.wikipedia.org/wiki/Universal_Serial_Bus) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#USB"></see></summary>
    let USB = _prefix "USB"
    /// <summary>
    /// Specified data rates of 1.5 Mbit/s and 12 Mbit/s.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#USB1.0"></see></summary>
    let ``USB1.0`` = _prefix "USB1.0"
    /// <summary>
    /// Maximum speed of 480 Mbit/s.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#USB2.0"></see></summary>
    let ``USB2.0`` = _prefix "USB2.0"
    /// <summary>
    /// Maximum speed of 4,8 Gbit/s.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#USB3.0"></see></summary>
    let ``USB3.0`` = _prefix "USB3.0"
    /// <summary>
    /// USB-interface used to provide power to low-consumption devices without the need for an external power supply.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#USBEnergyInterface"></see></summary>
    let USBEnergyInterface = _prefix "USBEnergyInterface"
    /// <summary>
    /// A serial bus standard to connect devices to a host computer.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#USB_Cable"></see></summary>
    let USB_Cable = _prefix "USB_Cable"
    /// <summary>
    /// The business entity Videoseven.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#V7"></see></summary>
    let V7 = _prefix "V7"
    /// <summary>
    /// VHF (Very high frequency) is the radio frequency range from 30 MHz to 300 MHz.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "VHF" (http://en.wikipedia.org/wiki/VHF) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#VHF"></see></summary>
    let VHF = _prefix "VHF"
    /// <summary>
    /// The business entity VIVOTEK Inc.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#VIVOTEK"></see></summary>
    let VIVOTEK = _prefix "VIVOTEK"
    /// <summary>
    /// The business entity Verbatim Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Verbatim"></see></summary>
    let Verbatim = _prefix "Verbatim"
    /// <summary>
    /// The business entity Vestel.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Vestel"></see></summary>
    let Vestel = _prefix "Vestel"
    /// <summary>
    /// The business entity Victory Niederland B.V.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Victory"></see></summary>
    let Victory = _prefix "Victory"
    /// <summary>
    /// A video signal that has been split into two or more components.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#VideoComponent_Cable"></see></summary>
    let VideoComponent_Cable = _prefix "VideoComponent_Cable"
    /// <summary>
    /// Ability to display video files.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#VideoPlayBack"></see></summary>
    let VideoPlayBack = _prefix "VideoPlayBack"
    /// <summary>
    /// Ability to record videos.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#VideoRecording"></see></summary>
    let VideoRecording = _prefix "VideoRecording"
    /// <summary>
    /// A viewfinder is what the photographer looks through to compose, and in many cases to focus, the picture.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Viewfinder" (http://en.wikipedia.org/wiki/Viewfinder) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ViewFinder"></see></summary>
    let ViewFinder = _prefix "ViewFinder"
    /// <summary>
    /// An electronic viewfinder or EVF is a viewfinder where the image captured by the lens is projected electronically onto a miniature display. The image on this display is used to assist in aiming the camera at the scene to be photographed.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Electronic viewfinder" (http://en.wikipedia.org/wiki/Electronic_viewfinder) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ViewFinderElectronic"></see></summary>
    let ViewFinderElectronic = _prefix "ViewFinderElectronic"
    /// <summary>
    /// An optical viewfinder is simply a reversed telescope mounted to see what the camera will see.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Viewfinder" (http://en.wikipedia.org/wiki/Viewfinder) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ViewFinderOptical"></see></summary>
    let ViewFinderOptical = _prefix "ViewFinderOptical"
    /// <summary>
    /// The business entity ViewSonic.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ViewSonic"></see></summary>
    let ViewSonic = _prefix "ViewSonic"
    /// <summary>
    /// The business entity Viewpia.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Viewpia"></see></summary>
    let Viewpia = _prefix "Viewpia"
    /// <summary>
    /// The business entity Vivitar Corporation.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Vivitar"></see></summary>
    let Vivitar = _prefix "Vivitar"
    /// <summary>
    /// Ability to record sounds with a micro.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#VoiceRecording"></see></summary>
    let VoiceRecording = _prefix "VoiceRecording"
    /// <summary>
    /// WAV (or WAVE), short for Waveform audio format, is a Microsoft and IBM audio file format standard for storing an audio bitstream on PCs.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "WAV" (http://en.wikipedia.org/wiki/WAV) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#WAV"></see></summary>
    let WAV = _prefix "WAV"
    /// <summary>
    /// An audio data compression technology developed by Microsoft.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#WMA"></see></summary>
    let WMA = _prefix "WMA"
    /// <summary>
    /// A compressed video file format for several proprietary codecs developed by Microsoft.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#WMV"></see></summary>
    let WMV = _prefix "WMV"
    /// <summary>
    /// RGB Value 255,255,255
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#White"></see></summary>
    let White = _prefix "White"
    /// <summary>
    /// Ability to filter out wind noises.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#WindFilter"></see></summary>
    let WindFilter = _prefix "WindFilter"
    /// <summary>
    /// A version of a Microsoft operating system.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Windows2000"></see></summary>
    let Windows2000 = _prefix "Windows2000"
    /// <summary>
    /// A version of a Microsoft operating system.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Windows2003"></see></summary>
    let Windows2003 = _prefix "Windows2003"
    /// <summary>
    /// A version of a Microsoft operating system.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Windows95"></see></summary>
    let Windows95 = _prefix "Windows95"
    /// <summary>
    /// A version of a Microsoft operating system.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Windows98"></see></summary>
    let Windows98 = _prefix "Windows98"
    /// <summary>
    /// A version of a Microsoft operating system.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#WindowsME"></see></summary>
    let WindowsME = _prefix "WindowsME"
    /// <summary>
    /// A version of a Microsoft operating system.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#WindowsNT"></see></summary>
    let WindowsNT = _prefix "WindowsNT"
    /// <summary>
    /// A version of a Microsoft operating system.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#WindowsVista"></see></summary>
    let WindowsVista = _prefix "WindowsVista"
    /// <summary>
    /// A version of a Microsoft operating system.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#WindowsXP"></see></summary>
    let WindowsXP = _prefix "WindowsXP"
    /// <summary>
    /// The xD-Picture Card is a type of flash memory card.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#XDPictureCard"></see></summary>
    let XDPictureCard = _prefix "XDPictureCard"
    /// <summary>
    /// The business entity Xerox.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Xerox"></see></summary>
    let Xerox = _prefix "Xerox"
    /// <summary>
    /// YPbPR is the analog video signal carried by component video cable in consumer electronics. The green cable carries Y, the blue cable carries PB and the red cable carries PR.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "YPbPr" (http://en.wikipedia.org/wiki/YPbPr) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#YPbPr"></see></summary>
    let YPbPr = _prefix "YPbPr"
    /// <summary>
    /// The business entity Yakumo GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Yakumo"></see></summary>
    let Yakumo = _prefix "Yakumo"
    /// <summary>
    /// RGB Value 255,255,0
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Yellow"></see></summary>
    let Yellow = _prefix "Yellow"
    /// <summary>
    /// The business entity Yukai.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Yukai"></see></summary>
    let Yukai = _prefix "Yukai"
    /// <summary>
    /// The business entity Yuraku.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Yuraku"></see></summary>
    let Yuraku = _prefix "Yuraku"
    /// <summary>
    /// The business entity Yusmart.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Yusmart"></see></summary>
    let Yusmart = _prefix "Yusmart"
    /// <summary>
    /// Zoom is a method of decreasing (narrowing) the apparent angle of view of a photographic or video image.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital zoom" (http://en.wikipedia.org/wiki/Digital_zoom) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#Zoom"></see></summary>
    let Zoom = _prefix "Zoom"
    /// <summary>
    /// Zoom is a method of decreasing (narrowing) the apparent angle of view of a photographic or video image.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital zoom" (http://en.wikipedia.org/wiki/Digital_zoom) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ZoomDigital"></see></summary>
    let ZoomDigital = _prefix "ZoomDigital"
    /// <summary>
    /// An optical zoom is a mechanical assembly of lens elements with the ability to vary its focal length (and thus angle of view), as opposed to a fixed focal length (FFL) lens (see prime lens).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Zoom lens" (http://en.wikipedia.org/wiki/Zoom_lens) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#ZoomOptical"></see></summary>
    let ZoomOptical = _prefix "ZoomOptical"
    /// <summary>
    /// Defines an optical lens or assembly of lenses used in conjunction with a camera body and mechanism to make images of objects either on photographic film or on other media capable of storing an image chemically or electronically.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#has35mmCameraLensEquivalentRange"></see></summary>
    let has35mmCameraLensEquivalentRange = _prefix "has35mmCameraLensEquivalentRange"
    /// <summary>
    /// Defines subordinate or supplementary items.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasAccessory"></see></summary>
    let hasAccessory = _prefix "hasAccessory"
    /// <summary>
    /// Defines whether an analog video signal is supported.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasAnalogVideoSignal"></see></summary>
    let hasAnalogVideoSignal = _prefix "hasAnalogVideoSignal"
    /// <summary>
    /// Defines the hole or an opening through which light is admitted.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasApertureRange"></see></summary>
    let hasApertureRange = _prefix "hasApertureRange"
    /// <summary>
    /// The aspect ratio of a shape is the ratio of its longer dimension to its shorter dimension. The vertical dimension is the longer one.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Aspect ratio" (http://en.wikipedia.org/wiki/Aspect_ratio) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasAspectRatioHorizontal"></see></summary>
    let hasAspectRatioHorizontal = _prefix "hasAspectRatioHorizontal"
    /// <summary>
    /// The aspect ratio of a shape is the ratio of its longer dimension to its shorter dimension. The vertical dimension is the shorter one.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Aspect ratio" (http://en.wikipedia.org/wiki/Aspect_ratio) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasAspectRatioVertical"></see></summary>
    let hasAspectRatioVertical = _prefix "hasAspectRatioVertical"
    /// <summary>
    /// Defines which audio input devices can be used with this object.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasAudioInputSource"></see></summary>
    let hasAudioInputSource = _prefix "hasAudioInputSource"
    /// <summary>
    /// Defines the type of interfaces used to transfer audio signals.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasAudioInterfaceType"></see></summary>
    let hasAudioInterfaceType = _prefix "hasAudioInterfaceType"
    /// <summary>
    /// Defines the rate of energy conversion (Common unit of Measurement milliwatt, C31).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasAudioOutputPower"></see></summary>
    let hasAudioOutputPower = _prefix "hasAudioOutputPower"
    /// <summary>
    /// Defines the rate of energy conversion (Common unit of Measurement milliwatt, C31).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasOutputPower"></see></summary>
    let hasOutputPower = _prefix "hasOutputPower"
    /// <summary>
    /// Total time needed to fully recharge a completely discharged rechargeable energy source for this mp3 player (Common unit of measurement hour, HUR).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasBatteryRechargeTime"></see></summary>
    let hasBatteryRechargeTime = _prefix "hasBatteryRechargeTime"
    /// <summary>
    /// Defines the size of used energy source. (Use ASIN code here. For more information we refer to http://en.wikipedia.org/wiki/List_of_battery_sizes)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasBatterySize"></see></summary>
    let hasBatterySize = _prefix "hasBatterySize"
    /// <summary>
    /// Defines the major color of an objects body.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasBodyColor"></see></summary>
    let hasBodyColor = _prefix "hasBodyColor"
    /// <summary>
    /// Defines the type of certificate of a product used to attest quality standards.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasCertificate"></see></summary>
    let hasCertificate = _prefix "hasCertificate"
    /// <summary>
    /// Defines the number of channels of a television that can be used to save specific transmitted signals.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasChannelQuantity"></see></summary>
    let hasChannelQuantity = _prefix "hasChannelQuantity"
    /// <summary>
    /// In photography and image processing, color balance is the global adjustment of the intensities of the colors (typically red, green, and blue primary colors).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "White balance" (http://en.wikipedia.org/wiki/White_balance) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasColorBalance"></see></summary>
    let hasColorBalance = _prefix "hasColorBalance"
    /// <summary>
    /// Defines the possible external operating systems to communicate with.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasCompatibleOperatingSystem"></see></summary>
    let hasCompatibleOperatingSystem = _prefix "hasCompatibleOperatingSystem"
    /// <summary>
    /// Defines the possibilities to connect different kinds of electronical devices.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasConnectivity"></see></summary>
    let hasConnectivity = _prefix "hasConnectivity"
    /// <summary>
    /// The contrast ratio is a measure of a display system, defined as the ratio of the luminance of the brightest color (white) to that of the darkest color (black) that the system is capable of producing.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Contrast ratio" (http://en.wikipedia.org/wiki/Contrast_ratio) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasContrastRatio"></see></summary>
    let hasContrastRatio = _prefix "hasContrastRatio"
    /// <summary>
    /// Defines the support of a generic term that refers to access control technologies used by hardware manufacturers.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDRMSupport"></see></summary>
    let hasDRMSupport = _prefix "hasDRMSupport"
    /// <summary>
    /// Defines the supported data formats.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDataFormat"></see></summary>
    let hasDataFormat = _prefix "hasDataFormat"
    /// <summary>
    /// Defines the type of interfaces used to exchange data.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDataInterfaceType"></see></summary>
    let hasDataInterfaceType = _prefix "hasDataInterfaceType"
    /// <summary>
    /// Defines the distance from side to side, measuring across the object at right angles to the width (Common unit of measurement centimetre, CMT).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Length" (http://en.wikipedia.org/wiki/Length) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDepth"></see></summary>
    let hasDepth = _prefix "hasDepth"
    /// <summary>
    /// Defines the distance from side to side, measuring across the object with its stand at right angles to the width (Common unit of measurement centimetre, CMT).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Length" (http://en.wikipedia.org/wiki/Length) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDepthWithStand"></see></summary>
    let hasDepthWithStand = _prefix "hasDepthWithStand"
    /// <summary>
    /// Digital frequency is the analogue for discrete signals as frequency is to continuous signals (Common unit of measurement hertz, HTZ).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital frequency" (http://en.wikipedia.org/wiki/Digital_frequency) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDigitalFrequency"></see></summary>
    let hasDigitalFrequency = _prefix "hasDigitalFrequency"
    /// <summary>
    /// Speed of the process of converting an analog video signal—such as that produced by a video camera or DVD player—to digital form.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDigitalVideoCaptureSpeed"></see></summary>
    let hasDigitalVideoCaptureSpeed = _prefix "hasDigitalVideoCaptureSpeed"
    /// <summary>
    /// Zoom is a method of decreasing (narrowing) the apparent angle of view of a photographic or video image.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital zoom" (http://en.wikipedia.org/wiki/Digital_zoom) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDigitalZoom"></see></summary>
    let hasDigitalZoom = _prefix "hasDigitalZoom"
    /// <summary>
    /// Defines the stages an object can be zoomed digitally.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDigitalZoomFactor"></see></summary>
    let hasDigitalZoomFactor = _prefix "hasDigitalZoomFactor"
    /// <summary>
    /// Defines if object includes a screen.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDisplay"></see></summary>
    let hasDisplay = _prefix "hasDisplay"
    /// <summary>
    /// Defines the brightness of a display or screen. Brightness is an attribute of visual perception in which a source appears to be radiating or reflecting light.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Brightness" (http://en.wikipedia.org/wiki/Brightness) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDisplayBrightness"></see></summary>
    let hasDisplayBrightness = _prefix "hasDisplayBrightness"
    /// <summary>
    /// Defines the digital resolution of the horizontal axe (Common unit of measurement pixel, E37).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDisplayResolutionHorizontal"></see></summary>
    let hasDisplayResolutionHorizontal = _prefix "hasDisplayResolutionHorizontal"
    /// <summary>
    /// Defines the digital resolution of the vertical axe (Common unit of measurement pixel, E37).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDisplayResolutionVertical"></see></summary>
    let hasDisplayResolutionVertical = _prefix "hasDisplayResolutionVertical"
    /// <summary>
    /// Defines the diagonal length from the upper left to the lower right angle (Common unit of measurement centimetre, CMT; or inch, INH).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDisplaySize"></see></summary>
    let hasDisplaySize = _prefix "hasDisplaySize"
    /// <summary>
    /// Defines the type of the display like LCD or Plasma.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDisplayType"></see></summary>
    let hasDisplayType = _prefix "hasDisplayType"

    /// <summary>
    /// Defines the digital resolution of the horizontal axe (Common unit of measurement pixel, E37) for black/white prints for draft prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDraftPrintableResolutionBlackWhiteHorizontal"></see></summary>
    let hasDraftPrintableResolutionBlackWhiteHorizontal =
        _prefix "hasDraftPrintableResolutionBlackWhiteHorizontal"

    /// <summary>
    /// Defines the digital resolution of the vertical axe (Common unit of measurement pixel, E37) for black/white prints for draft prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDraftPrintableResolutionBlackWhiteVertical"></see></summary>
    let hasDraftPrintableResolutionBlackWhiteVertical =
        _prefix "hasDraftPrintableResolutionBlackWhiteVertical"

    /// <summary>
    /// Defines the digital resolution of the horizontal axe (Common unit of measurement pixel, E37) for black/white prints for draft prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDraftPrintableResolutionColorHorizontal"></see></summary>
    let hasDraftPrintableResolutionColorHorizontal =
        _prefix "hasDraftPrintableResolutionColorHorizontal"

    /// <summary>
    /// Defines the digital resolution of the vertical axe (Common unit of measurement pixel, E37) for black/white prints for draft prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDraftPrintableResolutionColorVertical"></see></summary>
    let hasDraftPrintableResolutionColorVertical =
        _prefix "hasDraftPrintableResolutionColorVertical"

    /// <summary>
    /// Amount of time the printer needs to start printing the first page.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasDurationToPrintFirstPage"></see></summary>
    let hasDurationToPrintFirstPage = _prefix "hasDurationToPrintFirstPage"
    /// <summary>
    /// Describes whether or not the product is equipped with features that allow economical printing.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasEconomicPrintMode"></see></summary>
    let hasEconomicPrintMode = _prefix "hasEconomicPrintMode"
    /// <summary>
    /// Defines the used energy source.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasEnergySource"></see></summary>
    let hasEnergySource = _prefix "hasEnergySource"
    /// <summary>
    /// Indicates wheter this feature is available on this product.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasEnvelopeFeeder"></see></summary>
    let hasEnvelopeFeeder = _prefix "hasEnvelopeFeeder"
    /// <summary>
    /// Defines the possibility to vary the audio presentation of sound.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasEqualizer"></see></summary>
    let hasEqualizer = _prefix "hasEqualizer"
    /// <summary>
    /// Defines the number of supported equalizers.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasEqualizerBandsQuantity"></see></summary>
    let hasEqualizerBandsQuantity = _prefix "hasEqualizerBandsQuantity"
    /// <summary>
    /// Defines the ability to add devices (e.g. cards) to maximize the storage capacity.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasExpansionSlot"></see></summary>
    let hasExpansionSlot = _prefix "hasExpansionSlot"
    /// <summary>
    /// Defines the type of special functions the object is capable of.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasFeature"></see></summary>
    let hasFeature = _prefix "hasFeature"
    /// <summary>
    /// Device for instantaneous illumination for picture taking.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasFlash"></see></summary>
    let hasFlash = _prefix "hasFlash"
    /// <summary>
    /// Defines a measure of how strongly it converges (focuses) or diverges (diffuses) light.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Focal length" (http://en.wikipedia.org/wiki/Focal_length) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasFocalLength"></see></summary>
    let hasFocalLength = _prefix "hasFocalLength"
    /// <summary>
    /// A focus, also called an image point, is the point where light rays originating from a point on the object converge.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Focus (optics)" (http://en.wikipedia.org/wiki/Focus_(optics)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasFocus"></see></summary>
    let hasFocus = _prefix "hasFocus"
    /// <summary>
    /// Focus, also called an image point, is the point where light rays originating from a point on the object converge.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Focus (optics)" (http://en.wikipedia.org/wiki/Focus_(optics)) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasFocusSize"></see></summary>
    let hasFocusSize = _prefix "hasFocusSize"
    /// <summary>
    /// Defines the range of supported frequency signals (Common unit of measurement megahertz, MHZ).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasFrequencyRange"></see></summary>
    let hasFrequencyRange = _prefix "hasFrequencyRange"
    /// <summary>
    /// Defines the measurement of vertical distance (Common unit of measurement centimetre, CMT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasHeight"></see></summary>
    let hasHeight = _prefix "hasHeight"
    /// <summary>
    /// Defines the measurement of vertical distance of an object with its stand (Common unit of measurement centimetre, CMT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasHeightWithStand"></see></summary>
    let hasHeightWithStand = _prefix "hasHeightWithStand"
    /// <summary>
    /// Defines the support of information such as the title, artist, album, track number, or other information about the file to be stored in the file itself.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasID3Support"></see></summary>
    let hasID3Support = _prefix "hasID3Support"
    /// <summary>
    /// Defines the capacity to store data on internal memory (Common unit of measurement Megabyte, 4L).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasInternalMemoryCapacity"></see></summary>
    let hasInternalMemoryCapacity = _prefix "hasInternalMemoryCapacity"
    /// <summary>
    /// Defines the perfect or approximate axial symmetry which transmits and refracts light.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasLensSystem"></see></summary>
    let hasLensSystem = _prefix "hasLensSystem"
    /// <summary>
    /// Defines the total amount of light allowed to fall on the photographic medium (photographic film or image sensor) during the process of taking a photograph.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasLightExposureControl"></see></summary>
    let hasLightExposureControl = _prefix "hasLightExposureControl"

    /// <summary>
    /// Amount of pages per minute the product is able to print in the mode of black-printig best quality.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxBlackWhitePrintSpeedBestQuality"></see></summary>
    let hasMaxBlackWhitePrintSpeedBestQuality =
        _prefix "hasMaxBlackWhitePrintSpeedBestQuality"

    /// <summary>
    /// Amount of pages per minute the product is able to print in the mode of black-printig of drafts.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxBlackWhitePrintSpeedDraft"></see></summary>
    let hasMaxBlackWhitePrintSpeedDraft = _prefix "hasMaxBlackWhitePrintSpeedDraft"
    /// <summary>
    /// Amount of pages per minute the product is able to print in the mode of black-printig normal quality.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxBlackWhitePrintSpeedNormal"></see></summary>
    let hasMaxBlackWhitePrintSpeedNormal = _prefix "hasMaxBlackWhitePrintSpeedNormal"
    /// <summary>
    /// Amount of pages per minute the product is able to print in the mode of color-printig best quality.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxColorPrintSpeedBestQuality"></see></summary>
    let hasMaxColorPrintSpeedBestQuality = _prefix "hasMaxColorPrintSpeedBestQuality"
    /// <summary>
    /// Amount of pages per minute the product is able to print in the mode of color-printig of drafts.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxColorPrintSpeedDraft"></see></summary>
    let hasMaxColorPrintSpeedDraft = _prefix "hasMaxColorPrintSpeedDraft"
    /// <summary>
    /// Amount of pages per minute the product is able to print in the mode of color-printig normal quality.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxColorPrintSpeedNormal"></see></summary>
    let hasMaxColorPrintSpeedNormal = _prefix "hasMaxColorPrintSpeedNormal"
    /// <summary>
    /// Maximum number of sheets the device can hold in all available standard and optional output trays.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxInputCapacity"></see></summary>
    let hasMaxInputCapacity = _prefix "hasMaxInputCapacity"
    /// <summary>
    /// Defines the maximum ability to hold for envelopes.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxInputCapacityForEnvelopes"></see></summary>
    let hasMaxInputCapacityForEnvelopes = _prefix "hasMaxInputCapacityForEnvelopes"
    /// <summary>
    /// Defines the maximum amount of memory that can be installed in the systems hardware (common unit of measurement: megabyte(MB): 4L).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxInternalMemoryCapacity"></see></summary>
    let hasMaxInternalMemoryCapacity = _prefix "hasMaxInternalMemoryCapacity"
    /// <summary>
    /// Defines the maximum size of the printed media format.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxMediaFormat"></see></summary>
    let hasMaxMediaFormat = _prefix "hasMaxMediaFormat"
    /// <summary>
    /// Describes the maximum weight of the media format (Common unit of measurement gram per square metre, GM).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxMediaWeight"></see></summary>
    let hasMaxMediaWeight = _prefix "hasMaxMediaWeight"
    /// <summary>
    /// Defines the maxium capacity that can be provided by using external memory (Common unit of measurement megabyte, 4L).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxMemoryCapacity"></see></summary>
    let hasMaxMemoryCapacity = _prefix "hasMaxMemoryCapacity"
    /// <summary>
    /// Defines the maximum temperature the product is able to operate (Common unit of measurement grad celsius, CEL).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxOperatingTemperature"></see></summary>
    let hasMaxOperatingTemperature = _prefix "hasMaxOperatingTemperature"
    /// <summary>
    /// Maximum number of sheets the product can hold in all available standard and optional output trays.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxOutputCapacity"></see></summary>
    let hasMaxOutputCapacity = _prefix "hasMaxOutputCapacity"
    /// <summary>
    /// Describes the maximum printed sites per month.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxPrintCapacity"></see></summary>
    let hasMaxPrintCapacity = _prefix "hasMaxPrintCapacity"

    /// <summary>
    /// Defines the maximum digital resolution of the horizontal axe (Common unit of measurement pixel, E37) for black/white prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxPrintableResolutionBlackWhiteHorizontal"></see></summary>
    let hasMaxPrintableResolutionBlackWhiteHorizontal =
        _prefix "hasMaxPrintableResolutionBlackWhiteHorizontal"

    /// <summary>
    /// Defines the maximum digital resolution of the vertical axe (Common unit of measurement pixel, E37) for black/white prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxPrintableResolutionBlackWhiteVertical"></see></summary>
    let hasMaxPrintableResolutionBlackWhiteVertical =
        _prefix "hasMaxPrintableResolutionBlackWhiteVertical"

    /// <summary>
    /// Defines the maximum digital resolution of the horizontal axe (Common unit of measurement pixel, E37) for color prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxPrintableResolutionColorHorizontal"></see></summary>
    let hasMaxPrintableResolutionColorHorizontal =
        _prefix "hasMaxPrintableResolutionColorHorizontal"

    /// <summary>
    /// Defines the maximum digital resolution of the vertical axe (Common unit of measurement pixel, E37)  for color prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxPrintableResolutionColorVertical"></see></summary>
    let hasMaxPrintableResolutionColorVertical =
        _prefix "hasMaxPrintableResolutionColorVertical"

    /// <summary>
    /// Defines the maximum level of relative humidity, non-condensing, within which the product can operate.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMaxRelativeHumidity"></see></summary>
    let hasMaxRelativeHumidity = _prefix "hasMaxRelativeHumidity"
    /// <summary>
    /// Describes the weight of the media format (Common unit of measurement gram per square metre, GM) hold in tray 1.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMediaWeightTray1"></see></summary>
    let hasMediaWeightTray1 = _prefix "hasMediaWeightTray1"
    /// <summary>
    /// Describes the weight of the media format (Common unit of measurement gram per square metre, GM) hold in tray 2.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMediaWeightTray2"></see></summary>
    let hasMediaWeightTray2 = _prefix "hasMediaWeightTray2"
    /// <summary>
    /// Minimum deliberate application of light to achieve some aesthetic or practical effect (common unit of measurement: Lux; LUX).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMinIllumination"></see></summary>
    let hasMinIllumination = _prefix "hasMinIllumination"
    /// <summary>
    /// Describes the minimum weight of the media format (Common unit of measurement gram per square metre, GM).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMinMediaWeight"></see></summary>
    let hasMinMediaWeight = _prefix "hasMinMediaWeight"
    /// <summary>
    /// Defines the minimum temperature the product is able to operate (Common unit of measurement grad celsius, CEL).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMinOperatingTemperature"></see></summary>
    let hasMinOperatingTemperature = _prefix "hasMinOperatingTemperature"
    /// <summary>
    /// Defines the minimum level of relative humidity, non-condensing, within which the product can operate.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasMinRelativeHumidity"></see></summary>
    let hasMinRelativeHumidity = _prefix "hasMinRelativeHumidity"
    /// <summary>
    /// Ability to connect the product to a network.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNetworkAbility"></see></summary>
    let hasNetworkAbility = _prefix "hasNetworkAbility"

    /// <summary>
    /// Defines the digital resolution of the horizontal axe (Common unit of measurement pixel, E37) for black/white prints for normal prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNormalPrintableResolutionBlackWhiteHorizontal"></see></summary>
    let hasNormalPrintableResolutionBlackWhiteHorizontal =
        _prefix "hasNormalPrintableResolutionBlackWhiteHorizontal"

    /// <summary>
    /// Defines the  digital resolution of the vertical axe (Common unit of measurement pixel, E37) for black/white prints for normal prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNormalPrintableResolutionBlackWhiteVertical"></see></summary>
    let hasNormalPrintableResolutionBlackWhiteVertical =
        _prefix "hasNormalPrintableResolutionBlackWhiteVertical"

    /// <summary>
    /// Defines the digital resolution of the horizontal axe (Common unit of measurement pixel, E37) for color prints for normal prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNormalPrintableResolutionColorHorizontal"></see></summary>
    let hasNormalPrintableResolutionColorHorizontal =
        _prefix "hasNormalPrintableResolutionColorHorizontal"

    /// <summary>
    /// Defines the digital resolution of the vertical axe (Common unit of measurement pixel, E37)  for color prints for normal prints.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNormalPrintableResolutionColorVertical"></see></summary>
    let hasNormalPrintableResolutionColorVertical =
        _prefix "hasNormalPrintableResolutionColorVertical"

    /// <summary>
    /// Defines the number of component video ports a device offers.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfComponentVideoPorts"></see></summary>
    let hasNumberOfComponentVideoPorts = _prefix "hasNumberOfComponentVideoPorts"
    /// <summary>
    /// Defines the number of colors an electronical device is able to display on a screen.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfDisplayColors"></see></summary>
    let hasNumberOfDisplayColors = _prefix "hasNumberOfDisplayColors"
    /// <summary>
    /// Number of compact audio/video interface ports for transmitting uncompressed digital data.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfHDMIPorts"></see></summary>
    let hasNumberOfHDMIPorts = _prefix "hasNumberOfHDMIPorts"
    /// <summary>
    /// Defines the number of hypertext pages that can be displayed on the main screen of a device.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfHyptertextPages"></see></summary>
    let hasNumberOfHyptertextPages = _prefix "hasNumberOfHyptertextPages"
    /// <summary>
    /// Counts the trays which feed the printer with paper.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfInputPaperTrays"></see></summary>
    let hasNumberOfInputPaperTrays = _prefix "hasNumberOfInputPaperTrays"
    /// <summary>
    /// Defines the available languages that can be chosen to be displayed on the main screen of a device.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfOnScreenLanguages"></see></summary>
    let hasNumberOfOnScreenLanguages = _prefix "hasNumberOfOnScreenLanguages"
    /// <summary>
    /// Number of replaceable components of a printer that contains the ink that is spread on paper during printing.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfPrintCartridges"></see></summary>
    let hasNumberOfPrintCartridges = _prefix "hasNumberOfPrintCartridges"
    /// <summary>
    /// Defines the number of trays able to hold sheets of paper to be printed.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasNumberOfStandardInputTrays"></see></summary>
    let hasNumberOfStandardInputTrays = _prefix "hasNumberOfStandardInputTrays"
    /// <summary>
    /// Average time the object operates (Common unit of measurement hour, HUR).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasOperatingTime"></see></summary>
    let hasOperatingTime = _prefix "hasOperatingTime"
    /// <summary>
    /// Describes the ability of an imaging system to resolve detail in the object that is being imaged.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasOpticalSensorResolution"></see></summary>
    let hasOpticalSensorResolution = _prefix "hasOpticalSensorResolution"
    /// <summary>
    /// Size of the device that measures a physical quantity and converts it into a signal which can be read by an observer or by an instrument (common unit of measurement: inch; INH).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasOpticalSensorSize"></see></summary>
    let hasOpticalSensorSize = _prefix "hasOpticalSensorSize"
    /// <summary>
    /// Defines a method of decreasing (narrowing) the apparent angle of view of a digital photographic or video image with a higher optical resolution than the digital zoom.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasOpticalZoom"></see></summary>
    let hasOpticalZoom = _prefix "hasOpticalZoom"
    /// <summary>
    /// Defines the stages an object can be zoomed optically.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasOpticalZoomFactor"></see></summary>
    let hasOpticalZoomFactor = _prefix "hasOpticalZoomFactor"
    /// <summary>
    /// Defines the distance from side to side, measuring across the object with its package at right angles to the width (Common unit of measurement centimetre, CMT).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Length" (http://en.wikipedia.org/wiki/Length) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPackageDepth"></see></summary>
    let hasPackageDepth = _prefix "hasPackageDepth"
    /// <summary>
    /// Defines the measurement of vertical distance of an object with its package (Common unit of measurement centimetre, CMT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPackageHeight"></see></summary>
    let hasPackageHeight = _prefix "hasPackageHeight"
    /// <summary>
    /// Defines the measurement of the gravitational force acting on an object with its package (Common unit of measurement gramm, GRM).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPackageWeight"></see></summary>
    let hasPackageWeight = _prefix "hasPackageWeight"
    /// <summary>
    /// Defines the distance between the ends of an object, its linear extent as measured from end to end with its package (Common unit of measurement centimetre, CMT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPackageWidth"></see></summary>
    let hasPackageWidth = _prefix "hasPackageWidth"
    /// <summary>
    /// Defines the supported paper formats.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPaperFormat"></see></summary>
    let hasPaperFormat = _prefix "hasPaperFormat"
    /// <summary>
    /// Size of a camera accessory consisting of an optical filter that can be inserted in the optical path.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Photographic filter" (http://en.wikipedia.org/wiki/Photographic_filter) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPhotographicFilterSize"></see></summary>
    let hasPhotographicFilterSize = _prefix "hasPhotographicFilterSize"
    /// <summary>
    /// Defines that an electronical screen can display minimum two pictures on one screen.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPictureInPicture"></see></summary>
    let hasPictureInPicture = _prefix "hasPictureInPicture"
    /// <summary>
    /// Defines the digital resolution of the pictures (Common unit of measurement pixel, E37).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPictureResolution"></see></summary>
    let hasPictureResolution = _prefix "hasPictureResolution"
    /// <summary>
    /// Defines the requirements of power an electronical device needs to operate (Common unit of measurement Ampere, AMP).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPowerRequirementsAC"></see></summary>
    let hasPowerRequirementsAC = _prefix "hasPowerRequirementsAC"
    /// <summary>
    /// Defines the power requirements of an electronical device (Common unit of measurement hertz, HTZ).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPowerRequirementsHTZ"></see></summary>
    let hasPowerRequirementsHTZ = _prefix "hasPowerRequirementsHTZ"
    /// <summary>
    /// Defines the area which can not be printed on the bottom side of a paper (A4) (Common unit of measurement millimetre, MMT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPrintBorderBottom"></see></summary>
    let hasPrintBorderBottom = _prefix "hasPrintBorderBottom"
    /// <summary>
    /// Defines the area which can not be printed on the left side of a paper (DIN A4) (Common unit of measurement millimetre, MMT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPrintBorderLeft"></see></summary>
    let hasPrintBorderLeft = _prefix "hasPrintBorderLeft"
    /// <summary>
    /// Defines the area which can not be printed on the right side of a paper (A4) (Common unit of measurement millimetre, MMT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPrintBorderRight"></see></summary>
    let hasPrintBorderRight = _prefix "hasPrintBorderRight"
    /// <summary>
    /// Defines the area which can not be printed on the top side of a paper (A4) (Common unit of measurement millimetre, MMT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasPrintBorderTop"></see></summary>
    let hasPrintBorderTop = _prefix "hasPrintBorderTop"
    /// <summary>
    /// Defines the frequency of the clock in any synchronous circuit (common unit of measurement: hertz, HTZ).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasProcessorClockSpeed"></see></summary>
    let hasProcessorClockSpeed = _prefix "hasProcessorClockSpeed"
    /// <summary>
    /// The type of central processing unit (CPU) as an electronic circuit that can execute printing tasks or programs.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasProcessorType"></see></summary>
    let hasProcessorType = _prefix "hasProcessorType"
    /// <summary>
    /// The red-eye effect in photography is the common appearance of red pupils in color photographs of eyes. The red-eye reduction feature reduces the red-eye effect.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasRedEyeReduction"></see></summary>
    let hasRedEyeReduction = _prefix "hasRedEyeReduction"
    /// <summary>
    /// Defines the type of resolution a screen is able to display.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasResolution"></see></summary>
    let hasResolution = _prefix "hasResolution"
    /// <summary>
    /// Defines the time an electronical device needs to react on a signal (Common unit of measurement millisecond, C26).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasResponseTime"></see></summary>
    let hasResponseTime = _prefix "hasResponseTime"
    /// <summary>
    /// Defines a projection of information from any physical environment into any sensory system.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasSceneMode"></see></summary>
    let hasSceneMode = _prefix "hasSceneMode"
    /// <summary>
    /// Defines whether the product is able  to give a delay between the pressing of the shutter release and the shutter firing.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasSelfTimer"></see></summary>
    let hasSelfTimer = _prefix "hasSelfTimer"
    /// <summary>
    /// Defines type of device that measures a physical quantity and converts it into a signal which can be read by an observer or by an instrument.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasSensorType"></see></summary>
    let hasSensorType = _prefix "hasSensorType"
    /// <summary>
    /// Defines the delay between triggering the shutter and when the photograph is actually recorded (Common unit of measurement seconds, SEC).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasShutterLag"></see></summary>
    let hasShutterLag = _prefix "hasShutterLag"
    /// <summary>
    /// Defines the ability to use a mode that saves significant electrical consumption compared to leaving a device fully on and idle but allows the user to avoid having to reset programming codes (Common unit of measurement Watt, WTT).
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Sleep mode" (http://en.wikipedia.org/wiki/Sleep_mode) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasSleepModePowerConsumption"></see></summary>
    let hasSleepModePowerConsumption = _prefix "hasSleepModePowerConsumption"
    /// <summary>
    /// Level of sound power during the printing (Common unit of measurement decibel, 2N).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasSoundEmission"></see></summary>
    let hasSoundEmission = _prefix "hasSoundEmission"
    /// <summary>
    /// Defines the number of integrated speakers an object includes.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasSpeakerQuantity"></see></summary>
    let hasSpeakerQuantity = _prefix "hasSpeakerQuantity"
    /// <summary>
    /// Amount of sheets the product can hold as standard.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasStandardInputCapacity"></see></summary>
    let hasStandardInputCapacity = _prefix "hasStandardInputCapacity"
    /// <summary>
    /// Number of sheets the product can hold in all available output trays as a standard.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasStandardOutputCapacity"></see></summary>
    let hasStandardOutputCapacity = _prefix "hasStandardOutputCapacity"

    /// <summary>
    /// Defines the maximum amount of envelopes the product is able to print.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasStandardOutputCapacityForEnvelopes"></see></summary>
    let hasStandardOutputCapacityForEnvelopes =
        _prefix "hasStandardOutputCapacityForEnvelopes"

    /// <summary>
    /// Defines the maximum amount of transparancies the product is able to print.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasStandardOutputCapacityForTransperancies"></see></summary>
    let hasStandardOutputCapacityForTransperancies =
        _prefix "hasStandardOutputCapacityForTransperancies"

    /// <summary>
    /// Defines the amount of consumed energy while the device is in the standby mode (Common unit of measurement Watt, WTT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasStandbyPowerConsumption"></see></summary>
    let hasStandbyPowerConsumption = _prefix "hasStandbyPowerConsumption"
    /// <summary>
    /// Defines the type of storage media the object uses to store data.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasStorageMedia"></see></summary>
    let hasStorageMedia = _prefix "hasStorageMedia"
    /// <summary>
    /// Defines the possibilty to rotate or turn an object into different directions (Common unit of measurement degree, DD).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasSwivel"></see></summary>
    let hasSwivel = _prefix "hasSwivel"
    /// <summary>
    /// Defines the type of included TV tuner.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasTVTuner"></see></summary>
    let hasTVTuner = _prefix "hasTVTuner"
    /// <summary>
    /// Defines the ability to operate an object by touching its screen.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasTouchscreen"></see></summary>
    let hasTouchscreen = _prefix "hasTouchscreen"
    /// <summary>
    /// Number of serial bus standard ports to connect devices to a host computer.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasUSBPortsQuantity"></see></summary>
    let hasUSBPortsQuantity = _prefix "hasUSBPortsQuantity"
    /// <summary>
    /// Defines the necessary power for an electronical object while the device is used (Common unit of measurement Watt, WTT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasUsagePowerConsumption"></see></summary>
    let hasUsagePowerConsumption = _prefix "hasUsagePowerConsumption"
    /// <summary>
    /// Defines the digital resolution of the videos (Common unit of measurement pixel, E37). (Example: 1024x768)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasVideoResolution"></see></summary>
    let hasVideoResolution = _prefix "hasVideoResolution"
    /// <summary>
    /// A viewfinder is what the photographer looks through to compose, and in many cases to focus, the picture.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Viewfinder" (http://en.wikipedia.org/wiki/Viewfinder) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasViewFinder"></see></summary>
    let hasViewFinder = _prefix "hasViewFinder"
    /// <summary>
    /// Defines the angle in a horizontal axe where a viewer is still able to see the picture on a screen (Common unit of measurement degree, DD).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasViewingAngleHorizontal"></see></summary>
    let hasViewingAngleHorizontal = _prefix "hasViewingAngleHorizontal"
    /// <summary>
    /// Defines the angle in a vertical axe where a viewer is still able to see the picture on a screen (Common unit of measurement degree, DD).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasViewingAngleVertical"></see></summary>
    let hasViewingAngleVertical = _prefix "hasViewingAngleVertical"
    /// <summary>
    /// Defines if an object can be installed at a wall.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasWallMountability"></see></summary>
    let hasWallMountability = _prefix "hasWallMountability"
    /// <summary>
    /// Defines the amount of time the device needs to be ready.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasWarmupTime"></see></summary>
    let hasWarmupTime = _prefix "hasWarmupTime"
    /// <summary>
    /// Defines the measurement of the gravitational force acting on an object (Common unit of measurement gramm, GRM).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasWeight"></see></summary>
    let hasWeight = _prefix "hasWeight"
    /// <summary>
    /// Defines the measurement of the gravitational force acting on an object with its stand (Common unit of measurement gramm, GRM).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasWeightWithStand"></see></summary>
    let hasWeightWithStand = _prefix "hasWeightWithStand"
    /// <summary>
    /// Defines the global adjustment of the intensities of the colors.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasWhiteBalance"></see></summary>
    let hasWhiteBalance = _prefix "hasWhiteBalance"
    /// <summary>
    /// Defines the distance between the ends of an object, its linear extent as measured from end to end (Common unit of measurement centimetre, CMT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasWidth"></see></summary>
    let hasWidth = _prefix "hasWidth"
    /// <summary>
    /// Defines the distance between the ends of an object, its linear extent as measured from end to end with its stand (Common unit of measurement centimetre, CMT).
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasWidthWithStand"></see></summary>
    let hasWidthWithStand = _prefix "hasWidthWithStand"
    /// <summary>
    /// Zoom is a method of decreasing (narrowing) the apparent angle of view of a photographic or video image.
    ///
    /// (This description is partly based on or reuses content from the Wikipedia article "Digital zoom" (http://en.wikipedia.org/wiki/Digital_zoom) and is licensed under the GNU Free Documentation License (http://www.gnu.org/copyleft/fdl.html).)
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#hasZoom"></see></summary>
    let hasZoom = _prefix "hasZoom"
    /// <summary>
    /// The business entity iDream Production Pvt. Ltd.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#iDream"></see></summary>
    let iDream = _prefix "iDream"
    /// <summary>
    /// The business entity iriver Europe GmbH.
    /// <see href="http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#iRiver"></see></summary>
    let iRiver = _prefix "iRiver"
